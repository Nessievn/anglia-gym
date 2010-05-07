/** References used:
 * 
 * bytes > c# / c sharp > c# / c sharp questions - line break in message box
 * (Aranbs, 2009)
 * 
 * .NET Framework Class Library - DataGridView.SelectedCells Property 
 * (MSDN, 2010c.)
 * 
 * .NET Framework Class Library - Clipboard Class
 * (MSDN, 2010a.)
 * 
 * .NET Framework Class Library - Clipboard.ContainsData Method 
 * (MSDN, 2010b.)
 * 
 */
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
    /**
     * @desc 
     * Form Handler for listing members
     * @params [none] Incoming parameters are described at the individual constructors.
     * @return [none] No directly returned data. 
     * Returns of public methods are described at the individual methods.
     */
    public partial class frm_member_list : Form
    {
        ClassInstance clClassInstance = null;
        frm_payment_list frmPayments = null;
        public bool viewAttendants;

        /** 
         * @desc Default constructor for creating member list from main menu.
         * This is for loading from main menu, 
         * @params [none] No input parameter. 
         * @return [none] No directly returned data. 
         */ 
        public frm_member_list()
        {
            InitializeComponent();
            this.clClassInstance = new ClassInstance();
            vLoadMemberList();
        }

        /** 
         * @desc Constructor for creating member list for adding new payment from payments list.
         * This is for loading from frm_payment_list. 
         * @params [frm_payments] frmPayments: This is for reference to the parent class.
         * @return [none] No directly returned data. 
         */
        public frm_member_list(frm_payment_list frmPayments)
        {
            InitializeComponent();
            this.frmPayments = frmPayments;
            vLoadMemberList();
        }

        /** 
         * @desc Constructor for creating member list for adding new attendant
         * to a class instance or to view members who are currently attending
         * This is for loading from a class_instance_arrange. 
         * @params [ClassInstance] clClassInstance:  This is for reference to the parent class.
         * @params [bool] viewAttendants: This decides if viewing or adding attendants.
         * @return [none] No directly returned data. 
         */
        public frm_member_list(ClassInstance clClassInstance, bool viewAttendants)
        {
            InitializeComponent();
            this.clClassInstance = clClassInstance;
            this.viewAttendants = viewAttendants;
            vLoadMemberList();
        }





        /** 
          * @desc This method refreshes the member list
          * @params [none] No input parameter. 
          * @return [none] No directly returned data. 
          */ 
        public void vLoadMemberList()
        {
            string query = "";
            // Create mysql connection            
            mySqlConn conn = new mySqlConn();
            conn.connect();
            // Create source for grid
            BindingSource itemsSource = new BindingSource();
            // If this is not for viewing current attendants for a class instance
            if (this.viewAttendants == false)
                // Create query for displaying all members
                query = "SELECT id_member ID, member_number Nr, CONCAT(lastName, ', ', firstName) 'Member Name', DATE_FORMAT(birthdate,\"%d-%m-%Y\") DOB, email 'EMail', type Type, IF((is_active= 0), 'INACTIVE','ACTIVE') Status FROM members ORDER BY ID ";
            // If this is for viewing current attendants for a class instance
            else
                // Create query for displaying only members who attend this class instance
                query = "SELECT m.id_member ID, m.member_number Nr, CONCAT(m.lastName, ', ', m.firstName) 'Member Name', DATE_FORMAT(m.birthdate,\"%d-%m-%Y\") DOB, email 'EMail', type Type, IF((is_active= 0), 'INACTIVE','ACTIVE') Status FROM members m, class_bookings cb WHERE m.id_member = cb.id_member AND cb.id_class_instance = '" + this.clClassInstance.Id_class_instance + "' ORDER BY ID";
            // Launch query and load result into source
            itemsSource.DataSource = conn.dtGetTableForDataGrid(query);
            // Assign source to grid
            dg_members.DataSource = itemsSource;
            dg_members.AllowUserToAddRows = false;
            dg_members.ReadOnly = true;
            // Display current number of people on list
            label_numberOfPeople.Text = dg_members.RowCount.ToString();
        }

        /** 
          * @desc Executes when a grid cell is double clicked on the member list
	      * It loads in the member belonging to the cell for editing
          * @params [none] No input parameter. 
          * @return [none] No directly returned data. 
          */
        private void dg_members_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Get the member id at current cell
                int id_member = int.Parse(dg_members.Rows[e.RowIndex].Cells[0].Value.ToString());
                // Create mysql connection            
                mySqlConn conn = new mySqlConn();
                conn.connect();
                // If this member list was launched from the payment list panel
                if (this.frmPayments != null)
                {
                    // Launch Add Payment panel for the selected member
                    frm_add_payment frmAddPayment = new frm_add_payment(id_member);
                    frmAddPayment.ShowDialog();
                    // As this member list was launched from the payment list, refresh the payment list when this finishes
                    this.frmPayments.vloadDgPayments();
                    this.Close();
                    return;
                }
                // If this member list was launched from class instance list for adding new members
                if (this.clClassInstance.Id_class_instance != -1 && this.viewAttendants == false)
                {
                    // Confirm enrollment
                    DialogResult dialogResult = MessageBox.Show("Enroll this member to the class?", "Enroll member?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        // Check the room size
                        string query = "SELECT COUNT(*) q FROM gym.class_bookings WHERE id_class_instance = '" + this.clClassInstance.Id_class_instance + "'";
                        List<Hashtable> lhRes = conn.lhSqlQuery(query);
                        int currMembers = int.Parse(lhRes[0]["q"].ToString());
                        query = "SELECT r.size FROM gym.class_instance ci, gym.rooms r WHERE ci.id_room = r.id_room AND ci.id_class_instance = '" + this.clClassInstance.Id_class_instance + "'";
                        lhRes = conn.lhSqlQuery(query);
                        int maxMembers = int.Parse(lhRes[0]["size"].ToString());
                        if (maxMembers < currMembers + 1)
                        {
                            MessageBox.Show("Sorry! This room does not allow more bookings!");
                            return;
                        }

                        Member clMember = new Member(id_member);
                        this.clClassInstance.LclAttendants.Add(clMember);
                        this.clClassInstance.SaveClassInstance();
                    }
                }
                // If this member list was launched from class instance list for viewing attending members
                if (this.clClassInstance.Id_class_instance != -1 && this.viewAttendants == true)
                {
                    // Confirm removal
                    DialogResult dialogResult = MessageBox.Show("Remove this member from the class?", "Delete entry?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        // Create delete query
                        string deleteClassBookingQuery = "delete from class_bookings WHERE id_member = '" + id_member + "'" + " AND id_class_instance = '" + this.clClassInstance.Id_class_instance + "'";
                        // Launch delete query 
                        int result = conn.DeleteOrUpdate(deleteClassBookingQuery);
                        // Check delete result
                        if (result > 0)
                        {
                            MessageBox.Show("The attendant has been removed from this class instance!");
                            vLoadMemberList();
                        }
                        else
                        {
                            MessageBox.Show("There was a problem updating the class booking information, please check your data!");
                            return;
                        }
                    }
                }
                // If this member list was launched from main menu just create an edit member form
                else
                {
                    frm_member frmMember = new frm_member(id_member, this);
                    frmMember.ShowDialog();
                }
            }catch(Exception)
            {
                return;
            }
        }

        /** 
          * @desc Executes when the Search button is clicked
	      * It creates a new list of members based on search criteria given by the user
          * @params [none] No input parameter. 
          * @return [none] No directly returned data. 
          */
        private void button_search_Click(object sender, EventArgs e)
        {
            // Create mysql connection            
            mySqlConn conn = new mySqlConn();
            conn.connect();
            // Create source for grid
            BindingSource itemsSource = new BindingSource();
            // Create start of query
            string query = "SELECT id_member ID, member_number Nr, CONCAT(lastName, ', ', firstName) 'Member Name', DATE_FORMAT(birthdate,\"%d-%m-%Y\") DOB, email 'EMail', type Type, IF((is_active= 0), 'INACTIVE','ACTIVE') Status FROM members WHERE 1 = 1 ";
            // Check user input and create query for search
            if (txt_firstName.Text != "")
                query += " AND firstName LIKE '%"+txt_firstName.Text+"%'";
            if (txt_lastName.Text != "")
                query += " AND lastName LIKE '%" + txt_lastName.Text + "%'";
            if (txt_email.Text != "")
                query += " AND email LIKE '%" + txt_email.Text + "%'";
            if (cmb_type.SelectedIndex != -1)
            {
                    query += " AND type LIKE '%" + cmb_type.SelectedItem.ToString() + "%'";
            }
            string sDate = Utils.sGetMysqlDate(txt_dob.Text);
            if (sDate != "0000-00-00")
                query += " AND birthdate = '" + sDate + "'";
            query += "  ORDER BY ID";
            // Launch query and load result into source
            itemsSource.DataSource = conn.dtGetTableForDataGrid(query);
            // Assign source to grid
            dg_members.DataSource = itemsSource;
            dg_members.AllowUserToAddRows = false;
            dg_members.ReadOnly = true;
            // Display amount of people currently on list
            label_numberOfPeople.Text = dg_members.RowCount.ToString();
        }


        /** 
          * @desc Executes when the Copy button is clicked
	      * It copies the contents of the currently selected grids onto the clipboard
          * with the optional delimiter
          * @params [none] No input parameter. 
          * @return [none] No directly returned data. 
          */
        private void button_copy_Click(object sender, EventArgs e)
        {
            // Create a string array of the size (amount) of selected cells
            string[] saSelectedCellValues = new string[dg_members.SelectedCells.Count];
            int counter = 0;
            string cellValue;
            // Fill in all selected cell contents into string array
            for (counter = 0; counter < (dg_members.SelectedCells.Count); counter++)
            {
                cellValue = dg_members.SelectedCells[counter].Value.ToString();
                if (cellValue.Length != 0)
                    saSelectedCellValues[counter] = cellValue;
            }
            // Offer choice of delimiter
            frm_message_box frmMessageBox = new frm_message_box();
            string result = frmMessageBox.ShowBox(Utils.MB_CUST2, "Which delimiter would you like to use? \r\n Its normally a comma (,) some mail uses semicolon (;)", "Mass e-mail delimiter selection", ",", ";");
            char delimiter = result[0];
            // Copy everything to clipboard            
            Clipboard.SetData(DataFormats.Text, string.Join(delimiter+" ", saSelectedCellValues));
            // If let the user know about the result
            if (Clipboard.ContainsData(DataFormats.Text))
                MessageBox.Show(Clipboard.GetData(DataFormats.Text) + "\r\n\r\n is on the Clipboard now!");
            else
                MessageBox.Show("Nothing was selected");
        }

        /** 
          * @desc Executes when the Add Member button is clicked
	      * It invokes the frm_member panel for adding a new member
          * @params [none] No input parameter. 
          * @return [none] No directly returned data. 
          */
        private void button_addNewMember_Click(object sender, EventArgs e)
        {
            frm_member frmMember = new frm_member(this);
            frmMember.ShowDialog();  
        }

        private void frm_member_list_Load(object sender, EventArgs e)
        {

        }


    }
}
