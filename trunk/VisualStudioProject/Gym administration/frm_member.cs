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
            
            string sQuery = "SELECT DISTINCT eb.date_due Due, e.name Name, eb.borrowedamount Amount, eb.id_equipment EqID, eb.id_eq_booking BkID FROM equipment e, equipment_bookings eb WHERE eb.id_member = " + mbrMember.IId_member + " AND (eb.isreturned = 0 OR eb.isreturned is NULL) AND eb.id_equipment = e.id_equipment ORDER BY Due";
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
            //eqEquipmentBooked.SDateStart = String.Format("{0:yyyy-MM-dd}", today);

            //eqEquipmentBooked.SDateDue = String.Format("{0:yyyy-MM-dd}", today.AddDays(double.Parse(counter_numberofdays.Value.ToString())));
            //eqEquipmentBooked.SDateStart = Utils.sGetMysqlDate(txt_startdate.Text);
            //string strTest = "25 May 2006";
            //DateTime dtmTest = DateTime.Parse(strTest);
            //
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
            if (mbrMember.IId_member < 1)
                MessageBox.Show("The member could not be found");
            else
            {

                vLoadBookedList();

                 txt_firstName.Text = mbrMember.SFirstName;
                 txt_lastName.Text = mbrMember.SLastName;
                 chk_active.Checked = mbrMember.BIs_active;
                 txt_dob.Text = Utils.sGetCsharpDateFromMysqlDate(mbrMember.SBirthdate);
                 txt_address1.Text = mbrMember.SAddress_1;
                 txt_address2.Text = mbrMember.SAaddress_2;
                 txt_city.Text = mbrMember.SCity;
                 txt_county.Text = mbrMember.SCounty;
                 txt_emerg_mobile.Text = mbrMember.SEmerg_contact_mobile;
                 txt_emerg_name.Text = mbrMember.SEmerg_contact_name;
                 txt_emerg_telephone.Text = mbrMember.SEmerg_contact_phone;
                 txt_emerg_relation.Text = mbrMember.SEmerg_contact_relation;
                 txt_allergies.Text = mbrMember.SMedical_allergies;
                 txt_doctor_name.Text = mbrMember.SMedical_doctor_name;
                 txt_medical_notes.Text = mbrMember.SMedical_notes;
                 txt_doctor_phone.Text = mbrMember.SMedical_phone;
                 txt_membernum.Text = mbrMember.SMemberNumber;
                 cmb_paymenttype.Text = mbrMember.SPayment_method;
                 txt_pc.Text = mbrMember.SPostalcode;
                 cmb_type.Text = mbrMember.SType;
                 txt_email.Text = mbrMember.SEmail;
                 txt_mobile.Text = mbrMember.SMobile;
                 txt_telephone.Text = mbrMember.SPhone;
            }
        }

        private void frm_member_Load(object sender, EventArgs e)
        {
            //Startup load
        }


        private void button_save_Click(object sender, EventArgs e)
        {
            mbrMember.SFirstName = txt_firstName.Text;
            mbrMember.SLastName = txt_lastName.Text;
            mbrMember.BIs_active = (chk_active.Checked) ? true : false;
            mbrMember.SBirthdate = txt_dob.Text;
            mbrMember.SAaddress_2 = txt_address2.Text;
            mbrMember.SAddress_1 = txt_address1.Text;
            mbrMember.SCity = txt_city.Text;
            mbrMember.SCounty = txt_county.Text;
            mbrMember.SEmerg_contact_mobile = txt_emerg_mobile.Text;
            mbrMember.SEmerg_contact_name = txt_emerg_name.Text;
            mbrMember.SEmerg_contact_phone = txt_emerg_telephone.Text;
            mbrMember.SEmerg_contact_relation = txt_emerg_relation.Text;
            mbrMember.SMedical_allergies = txt_allergies.Text;
            mbrMember.SMedical_doctor_name = txt_doctor_name.Text;
            mbrMember.SMedical_notes = txt_medical_notes.Text;
            mbrMember.SMedical_phone = txt_doctor_phone.Text;
            mbrMember.SMemberNumber = txt_membernum.Text;
            mbrMember.SPayment_method = cmb_paymenttype.Text;
            mbrMember.SPicture = "none";
            mbrMember.SPostalcode = txt_pc.Text;
            mbrMember.SType = cmb_type.Text;
            mbrMember.SEmail = txt_email.Text;
            mbrMember.SPhone = txt_telephone.Text;
            mbrMember.SMobile = txt_mobile.Text;

            mbrMember.bSave();


        }

        

        private void button_payments_Click(object sender, EventArgs e)
        {
//IMLEMENT IT TO PAYMENTS??
            frm_member_list frm = new frm_member_list();
            frm.MdiParent = this.MdiParent;
            frm.Show();
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
                                                                            //isBooking, "isMember", id_member
            frm_equipment_list frmEquipmentList = new frm_equipment_list(true, true, mbrMember.IId_member,this,null );
            frmEquipmentList.MdiParent = this.MdiParent;

            
            if (Utils.bIsAlreadyOpened(frmEquipmentList)) return;
            frmEquipmentList.Show();  
        }


        private void dg_currentborrows_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            string sEquipmentName = dg_currentborrows.Rows[e.RowIndex].Cells[1].Value.ToString();
            int iBorrowedAmount = int.Parse(dg_currentborrows.Rows[e.RowIndex].Cells[2].Value.ToString());
            //int iEquipmentId = int.Parse(dg_currentborrows.Rows[e.RowIndex].Cells[3].Value.ToString());
            int iEqBookingId = int.Parse(dg_currentborrows.Rows[e.RowIndex].Cells[4].Value.ToString());

            MyMessageBox myMessageBox = new MyMessageBox();
            string iresult = myMessageBox.ShowBox(Utils.MB_CUST4, "", "How many "+sEquipmentName+" would you like to return?",iBorrowedAmount.ToString());
 
 
 	                        //ref  http://social.msdn.microsoft.com/Forums/en-US/winforms/thread/84990ad2-5046-472b-b103-f862bfcd5dbc
 
 
 	                        double Num;
 	                        bool isNum = double.TryParse(iresult, out Num);
 	                        if (isNum)
 	                        {
                                
                                if ((int.Parse(iresult) > 0) && (iresult != "Cancel"))
                                {
                                    this.eqEquipmentBooked = new EquipmentBooked(iEqBookingId);
                                    this.eqEquipmentBooked.SBorrowedAmount = int.Parse(iresult);
                                    this.eqEquipmentBooked.SIsReturned = false;
                                    this.eqEquipmentBooked.bSave();
                                }
                                else
                                {
                                    this.eqEquipmentBooked = new EquipmentBooked(iEqBookingId);
                                    this.eqEquipmentBooked.SBorrowedAmount = 0;
                                    this.eqEquipmentBooked.SIsReturned = true;
                                    this.eqEquipmentBooked.bSave();

                                }
                                this.vLoadBookedList();
 	                        }

        }

        
    }
}
