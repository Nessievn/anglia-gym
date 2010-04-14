using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Gym_administration
{
    public partial class frm_member : Form
    {
        Member mbrMember;
        EquipmentBooked eqEquipmentBooked;
        

        public void vLoadBookedList()
        {
            mySqlConn conn = new mySqlConn();    
            conn.connect();
            BindingSource itemsSource = new BindingSource();
            
            string sQuery = "SELECT DISTINCT eb.date_due Due, e.name Name, eb.borrowedamount Amount, eb.id_equipment EqID, eb.id_eq_booking BkID FROM equipment e, equipment_bookings eb WHERE eb.id_member = " + mbrMember.Id_member + " AND (eb.isreturned = 0 OR eb.isreturned is NULL) AND eb.id_equipment = e.id_equipment ORDER BY Due";
            itemsSource.DataSource = conn.dtGetTableForDataGrid(sQuery);
            dg_currentborrows.DataSource = itemsSource;
            dg_currentborrows.AllowUserToAddRows = false;
            dg_currentborrows.ReadOnly = true;
            //WARNING IF DUE DATE EXPIRED??
            
            
            if (dg_currentborrows.RowCount > 0)
            {
                int iLateItems = 0;
                int iRowIndex;
                for (iRowIndex = 0; iRowIndex < dg_currentborrows.RowCount; iRowIndex++) 
                {
                    string sEqDueDate = dg_currentborrows.Rows[iRowIndex].Cells[0].Value.ToString();

                    DateTime today = DateTime.Today;
                    DateTime due = DateTime.Parse(sEqDueDate);
                    int result = DateTime.Compare(today, due);
                    if (result > 0)
                        iLateItems++;
                }
                if (iLateItems>0)
                    MessageBox.Show("This persom has "+iLateItems+" late, unreturned item(s).");
            }
        }

        public frm_member()
        {
      
            mbrMember = new Member();
            InitializeComponent();
            txt_membernum.Text = Utils.sGenerateNewMemberNumber();
            txt_membernum.ReadOnly = true;
            button_equipmentbooking.Hide();
        }
        
        public frm_member(int iMemberId)
        {
            
 
            InitializeComponent();
            button_equipmentbooking.Show();

            mbrMember = new Member(iMemberId);
            if (mbrMember.Id_member < 1)
                MessageBox.Show("The member could not be found");
            else
            {

                vLoadBookedList();

                 txt_firstName.Text = mbrMember.FirstName;
                 txt_lastName.Text = mbrMember.LastName;
                 chk_active.Checked = mbrMember.IsActive;
                 txt_dob.Text = Utils.sGetCsharpDateFromMysqlDate(mbrMember.Birthdate);
                 txt_address1.Text = mbrMember.Address_1;
                 txt_address2.Text = mbrMember.Address_2;
                 txt_city.Text = mbrMember.City;
                 txt_county.Text = mbrMember.County;
                 txt_emerg_mobile.Text = mbrMember.EmergContactMobile;
                 txt_emerg_name.Text = mbrMember.EmergContactName;
                 txt_emerg_telephone.Text = mbrMember.EmergContactPhone;
                 txt_emerg_relation.Text = mbrMember.EmergContactRelation;
                 txt_allergies.Text = mbrMember.MedicalAllergies;
                 txt_doctor_name.Text = mbrMember.MedicalDoctorName;
                 txt_medical_notes.Text = mbrMember.MedicalNotes;
                 txt_doctor_phone.Text = mbrMember.MedicalPhone;
                 txt_membernum.Text = mbrMember.Id_member.ToString();
                 cmb_paymenttype.Text = mbrMember.PaymentMethod;
                 txt_pc.Text = mbrMember.PostalCode;
                 cmb_type.Text = mbrMember.Type;
//!!!
                 txt_email.Text = mbrMember.Email;
                 txt_mobile.Text = mbrMember.Mobile;
                 txt_telephone.Text = mbrMember.Phone;
            }
        }

        private void frm_member_Load(object sender, EventArgs e)
        {
            //Startup load
        }


        private void button_save_Click(object sender, EventArgs e)
        {
            mbrMember.FirstName = txt_firstName.Text;
            mbrMember.LastName = txt_lastName.Text;
            mbrMember.IsActive = (chk_active.Checked) ? true : false;
            mbrMember.Birthdate = txt_dob.Text;
            mbrMember.Address_2 = txt_address2.Text;
            mbrMember.Address_1 = txt_address1.Text;
            mbrMember.City = txt_city.Text;
            mbrMember.County = txt_county.Text;
            mbrMember.EmergContactMobile = txt_emerg_mobile.Text;
            mbrMember.EmergContactName = txt_emerg_name.Text;
            mbrMember.EmergContactPhone = txt_emerg_telephone.Text;
            mbrMember.EmergContactRelation = txt_emerg_relation.Text;
            mbrMember.MedicalAllergies = txt_allergies.Text;
            mbrMember.MedicalDoctorName = txt_doctor_name.Text;
            mbrMember.MedicalNotes = txt_medical_notes.Text;
            mbrMember.MedicalPhone = txt_doctor_phone.Text;
            mbrMember.MemberNumber = txt_membernum.Text;
            mbrMember.PaymentMethod = cmb_paymenttype.Text;
            mbrMember.Picture = "none";
            mbrMember.PostalCode = txt_pc.Text;
            mbrMember.Type = cmb_type.Text;
            mbrMember.Email = txt_email.Text;
            mbrMember.Phone = txt_telephone.Text;
            mbrMember.Mobile = txt_mobile.Text;

            mbrMember.bSave();


        }

        

        private void button_payments_Click(object sender, EventArgs e)
        {
//IMLEMENT IT TO PAYMENTS??
            frm_member_list frm = new frm_member_list();
            //frm.MdiParent = this.MdiParent;
            //frm.Show();
            frm.ShowDialog();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void button_remove_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure?", "Delete entry", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                mbrMember.bRemove();
                this.Close();
            }
        }

        private void button_equipmentbooking_Click(object sender, EventArgs e)
        {

     

            // Creating the child form login
                                                                         
            frm_equipment_list frmEquipmentList = new frm_equipment_list(mbrMember.Id_member,this);
            //frmEquipmentList.MdiParent = this.MdiParent;
            //frmEquipmentList.Show();  
            
            //if (Utils.bIsAlreadyOpened(frmEquipmentList)) return;
            frmEquipmentList.ShowDialog();  
        }


        private void dg_currentborrows_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            string name = dg_currentborrows.Rows[e.RowIndex].Cells[1].Value.ToString();
            int borrowedAmount = int.Parse(dg_currentborrows.Rows[e.RowIndex].Cells[2].Value.ToString());
            int id_eq_booking = int.Parse(dg_currentborrows.Rows[e.RowIndex].Cells[4].Value.ToString());

            frm_message_box myMessageBox = new frm_message_box();
            string result = myMessageBox.ShowBox(Utils.MB_CUST4, "", "How many "+name+" would you like to return?",borrowedAmount.ToString());
 
 
 	                        //ref  http://social.msdn.microsoft.com/Forums/en-US/winforms/thread/84990ad2-5046-472b-b103-f862bfcd5dbc
 
 
 	                        double Num;
 	                        bool isNum = double.TryParse(result, out Num);
 	                        if (isNum)
 	                        {
                                
                                if ((int.Parse(result) > 0) && (result != "Cancel"))
                                {
                                    this.eqEquipmentBooked = new EquipmentBooked(id_eq_booking);
                                    this.eqEquipmentBooked.BorrowedAmount = int.Parse(result);
                                    this.eqEquipmentBooked.IsReturned = false;
                                    this.eqEquipmentBooked.bSave();
                                }
                                else
                                {
                                    this.eqEquipmentBooked = new EquipmentBooked(id_eq_booking);
                                    this.eqEquipmentBooked.BorrowedAmount = 0;
                                    this.eqEquipmentBooked.IsReturned = true;
                                    this.eqEquipmentBooked.bSave();

                                }
                                this.vLoadBookedList();
 	                        }

        }

        
    }
}
