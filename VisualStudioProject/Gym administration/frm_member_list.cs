using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Gym_administration
{
    public partial class frm_member_list : Form
    {
        ClassInstance clClassInstance;
        frm_payments frmPayments = null;
        public bool BViewAttendants;
        //public bool bPayments;
        
        public frm_member_list(ClassInstance clClassInstance, bool bViewAttendants)
        {
            InitializeComponent();
            this.clClassInstance = clClassInstance;
            this.BViewAttendants = bViewAttendants;
        }

        public frm_member_list(frm_payments frmPayments)
        {
            InitializeComponent();
            this.frmPayments = frmPayments;
        }
       
        public frm_member_list()
        {
            InitializeComponent();
            this.clClassInstance = new ClassInstance();
        }


        public void vLoadMemberList()
        {
            string sQuery = "";
            mySqlConn conn = new mySqlConn();
            conn.connect();
            BindingSource bSource = new BindingSource();
            if (this.BViewAttendants == false)
                sQuery = "SELECT id_member ID, member_number Nr, sid SID, CONCAT(lastName, ', ', firstName) 'Member Name', DATE_FORMAT(birthdate,\"%d-%m-%Y\") DOB, email 'EMail', type Type FROM members ORDER BY ID ";
            else
                sQuery = "SELECT m.id_member ID, m.member_number Nr, CONCAT(m.lastName, ', ', m.firstName) 'Member Name', DATE_FORMAT(m.birthdate,\"%d-%m-%Y\") DOB, email 'EMail' FROM members m, class_bookings cb WHERE m.id_member = cb.id_member AND cb.id_class_instance = '" + this.clClassInstance.Id_class_instance + "' ORDER BY ID";

            bSource.DataSource = conn.dtGetTableForDataGrid(sQuery);
            dg_members.DataSource = bSource;
            dg_members.AllowUserToAddRows = false;
            dg_members.ReadOnly = true;
            label_numberOfPeople.Text = dg_members.RowCount.ToString();
        }


        private void frm_member_list_Load(object sender, EventArgs e)
        {
            //vLoadMemberList();

        }


        private void dg_members_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id_member = int.Parse(dg_members.Rows[e.RowIndex].Cells[0].Value.ToString());
                mySqlConn conn = new mySqlConn();
                conn.connect();

                if (this.frmPayments != null)
                {

                    frm_add_payment frmAddPayment = new frm_add_payment(id_member);

                    frmAddPayment.ShowDialog();
                    this.frmPayments.vloadDgPayments();
                    this.Close();
                    return;
                }

                if (this.clClassInstance.Id_class_instance != -1 && this.BViewAttendants == false)
                {
                    DialogResult result = MessageBox.Show("Enroll this member to the class?", "Delete entry", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        // Check the room size
                        string sQuery = "SELECT COUNT(*) q FROM gym.class_bookings WHERE id_class_instance = '" + this.clClassInstance.Id_class_instance + "'";
                        List<Hashtable> lhRes = conn.lhSqlQuery(sQuery);
                        int iCurrMembers = int.Parse(lhRes[0]["q"].ToString());
                        sQuery = "SELECT r.size FROM gym.class_instance ci, gym.rooms r WHERE ci.id_room = r.id_room AND ci.id_class_instance = '" + this.clClassInstance.Id_class_instance + "'";
                        lhRes = conn.lhSqlQuery(sQuery);
                        int iMaxMembers = int.Parse(lhRes[0]["size"].ToString());
                        if (iMaxMembers < iCurrMembers + 1)
                        {
                            MessageBox.Show("Sorry! This room does not allow more bookings!");
                            return;
                        }

                        Member mbr_t = new Member(id_member);
                        this.clClassInstance.LclAttendants.Add(mbr_t);
                        this.clClassInstance.SaveClassInstance();
                    }
                }
                else
                {
                    frm_member frm_mbr = new frm_member(id_member);

                    frm_mbr.ShowDialog();
                }
            }catch(Exception)
            {
                return;
            }
        }



        private void button_search_Click(object sender, EventArgs e)
        {
            mySqlConn conn = new mySqlConn();
            conn.connect();
            BindingSource bSource = new BindingSource();
            string sQuery = "SELECT id_member ID, member_number Nr, sid SID, CONCAT(lastName, ', ', firstName) 'Member Name', DATE_FORMAT(birthdate,\"%d-%m-%Y\") DOB, email 'EMail', type Type FROM members WHERE 1 = 1 ";
            if (txt_firstName.Text != "")
                sQuery += " AND firstName LIKE '%"+txt_firstName.Text+"%'";
            if (txt_lastName.Text != "")
                sQuery += " AND lastName LIKE '%" + txt_lastName.Text + "%'";
            if (txt_email.Text != "")
                sQuery += " AND email LIKE '%" + txt_email.Text + "%'";
            if (txt_membernum.Text != "")
                sQuery += " AND member_number LIKE '%" + txt_membernum.Text + "%'";

            if (cmb_type.SelectedIndex != -1)
            {

                //
                  //  sQuery += " AND type LIKE '%%'";
                if (cmb_type.SelectedIndex == 1)
                {
                    sQuery += " AND type LIKE '%Student Full Time%'";
                    sQuery += " OR type LIKE '%Student Part Time%'";
                }
                else if (cmb_type.SelectedIndex != 0)
                    sQuery += " AND type LIKE '%" + cmb_type.SelectedItem.ToString() + "%'";
            }




            string sDate = Utils.sGetMysqlDate(txt_dob.Text);
            if (sDate != "0000-00-00")
                sQuery += " AND birthdate = '" + sDate + "'";

            sQuery += "  ORDER BY ID";

            bSource.DataSource = conn.dtGetTableForDataGrid(sQuery);
            dg_members.DataSource = bSource;
            dg_members.AllowUserToAddRows = false;
            dg_members.ReadOnly = true;
            label_numberOfPeople.Text = dg_members.RowCount.ToString();
        }

        private void button_copy_Click(object sender, EventArgs e)
        {

            frm_message_box frmMessageBox = new frm_message_box();
            string result = frmMessageBox.ShowBox(Utils.MB_CUST2, "Which delimiter would you like to use? \r\n Its normally a comma (,) ARU mail uses semicolon (;)", "Mass e-mail delimiter selection", ",", ";");


            char delimiter = result[0];
            int counter = 0;
            string cellValue;
            string[] saSelectedCellValues = new string[dg_members.SelectedCells.Count];

            for (counter = 0; counter < (dg_members.SelectedCells.Count); counter++)
            {

                cellValue = dg_members.SelectedCells[counter].Value.ToString();
                if (cellValue.Length != 0)
                    saSelectedCellValues[counter] = cellValue;
            }


            Clipboard.SetData(DataFormats.Text, string.Join(delimiter+" ", saSelectedCellValues));

            if (Clipboard.ContainsData(DataFormats.Text))
                MessageBox.Show(Clipboard.GetData(DataFormats.Text) + "\r\n\r\n is on the Clipboard now!");
            else
                MessageBox.Show("Nothing was selected");

        }

        private void button_addNewMember_Click(object sender, EventArgs e)
        {
            bool isFromMemberList = true;
            frm_member frmMember = new frm_member(isFromMemberList);
            // We check if the form is already opened
            //if (Utils.bIsAlreadyOpened(mdiFrmMember)) return;
            // Set the Parent Form of the Child window.
            //mdiFrmMember.MdiParent = this;
            //mdiFrmMember.Show();  
            // Display the new form.
            frmMember.ShowDialog();  
        }

        private void frm_member_list_Activated(object sender, EventArgs e)
        {
            vLoadMemberList();
        }





    }
}
