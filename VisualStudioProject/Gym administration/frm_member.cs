﻿using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Gym_administration
{
    public partial class frm_member : Form
    {
        Member clMember;
        EquipmentBooked clEquipmentBooked;

        

        public void vLoadBookedList()
        {

            // Create mysql connection            
            mySqlConn conn = new mySqlConn();    
            conn.connect();
            BindingSource itemsSource = new BindingSource();
            pictureBox1.Image = null;
            string query = "SELECT DISTINCT eb.date_due Due, e.name Name, eb.borrowedamount Amount, eb.id_equipment EqID, eb.id_eq_booking BkID FROM equipment e, equipment_bookings eb WHERE eb.id_member = " + clMember.Id_member + " AND (eb.isreturned = 0 OR eb.isreturned is NULL) AND eb.id_equipment = e.id_equipment ORDER BY Due";
            itemsSource.DataSource = conn.dtGetTableForDataGrid(query);
            dg_currentborrows.DataSource = itemsSource;
            dg_currentborrows.AllowUserToAddRows = false;
            dg_currentborrows.ReadOnly = true;

            if (dg_currentborrows.RowCount > 0)
            {
                int lateItems = 0;
                int rowIndex;
                for (rowIndex = 0; rowIndex < dg_currentborrows.RowCount; rowIndex++) 
                {
                    string eqDueDate = dg_currentborrows.Rows[rowIndex].Cells[0].Value.ToString();

                    DateTime today = DateTime.Today;
                    DateTime due = DateTime.Parse(eqDueDate);
                    int result = DateTime.Compare(today, due);
                    if (result > 0)
                        lateItems++;
                }
                if (lateItems>0)
                    MessageBox.Show("This persom has "+lateItems+" late, unreturned item(s).");
            }
        }

        public frm_member()
        {

            clMember = new Member();
            InitializeComponent();
            txt_membernum.Text = Utils.sGenerateNewMemberNumber();
            txt_membernum.ReadOnly = true;
            button_equipmentbooking.Hide();
            button_payments.Hide();
            button_remove.Hide();
            clMember.Id_file = "";
            cmb_type.SelectedIndex = 0;

            this.pictureBox1.BackgroundImage = global::Gym_administration.Properties.Resources.member_male_128;
            rd_male.Checked = true;
        }

        public frm_member(bool isFromMemberList)
        {

            clMember = new Member();
            InitializeComponent();
            txt_membernum.Text = Utils.sGenerateNewMemberNumber();
            txt_membernum.ReadOnly = true;
            button_equipmentbooking.Hide();
            button_payments.Hide();
            button_remove.Hide();
            button_saveOpen.Hide();
            clMember.Id_file = "";
            cmb_type.SelectedIndex = 0;
            this.pictureBox1.BackgroundImage = global::Gym_administration.Properties.Resources.member_male_128;
            rd_male.Checked = true;
        }
        
        public frm_member(int id_member)
        {
            
 
            InitializeComponent();
            button_equipmentbooking.Show();
            button_saveOpen.Hide();
            clMember = new Member(id_member);
            if (clMember.Id_member < 1)
                MessageBox.Show("The member could not be found");
            else
            {

                vLoadBookedList();
                 txt_firstName.Text = clMember.FirstName;
                 txt_lastName.Text = clMember.LastName;
                 chk_active.Checked = clMember.IsActive;
                 txt_dob.Text = Utils.sGetCsharpDateFromMysqlDate(clMember.Birthdate);
                 txt_address1.Text = clMember.Address_1;
                 txt_address2.Text = clMember.Address_2;
                 txt_city.Text = clMember.City;
                 txt_county.Text = clMember.County;
                 txt_emerg_mobile.Text = clMember.EmergContactMobile;
                 txt_emerg_name.Text = clMember.EmergContactName;
                 txt_emerg_telephone.Text = clMember.EmergContactPhone;
                 txt_emerg_relation.Text = clMember.EmergContactRelation;
                 txt_allergies.Text = clMember.MedicalAllergies;
                 txt_doctor_name.Text = clMember.MedicalDoctorName;
                 txt_medical_notes.Text = clMember.MedicalNotes;
                 txt_doctor_phone.Text = clMember.MedicalPhone;
                 txt_membernum.Text = clMember.Id_member.ToString();
                 txt_pc.Text = clMember.PostalCode;
                 cmb_type.Text = clMember.Type;
                 txt_email.Text = clMember.Email;
                 txt_mobile.Text = clMember.Mobile;
                 txt_telephone.Text = clMember.Phone;
                 txt_sid.Text = clMember.Sid;
                 txt_stcardnumber.Text = clMember.StudCardNumber;

                 // Create mysql connection            
                mySqlConn conn = new mySqlConn();
                 conn.connect();
                 if (clMember.Gender == "male")
                 {
                     rd_male.Checked = true;
                     if (clMember.Id_file == "")
                     {
                         this.pictureBox1.BackgroundImage = global::Gym_administration.Properties.Resources.member_male_128;
                     }
                     else
                     {
                         
                         pictureBox1.Image = conn.loadImageFromDB(clMember.Id_file);
                     }
                 }
                 else
                 {
                     rd_female.Checked = true;
                     if (clMember.Id_file == "")
                     {
                         this.pictureBox1.BackgroundImage = global::Gym_administration.Properties.Resources.member_female_128;
                     }
                     else
                     {
                         pictureBox1.Image = conn.loadImageFromDB(clMember.Id_file);
                     }
                 }

            }
        }







        private void frm_member_Load(object sender, EventArgs e)
        {
            //Startup load
        }


        /** 
          * @desc Executes when the "Save and Stay" button is clicked
	      * If the saving is ok, then leaves the form open for further editing
          * @params [none] No input parameter. 
          * @return [none] No directly returned data. 
          */
        private void button_saveStay_Click(object sender, EventArgs e)
        {

            saveClick();

        }


        /** 
          * @desc Executes when the "Save and Close", "Save and Open List" or "Save and Stay" button is clicked
	      * It copies user input into member object and then calls for saving the member
          * @params [none] No input parameter. 
          * @return [bool] Returns true in case of success. 
          */
        private bool saveClick()
        {
            clMember.FirstName = txt_firstName.Text;
            clMember.LastName = txt_lastName.Text;
            clMember.IsActive = (chk_active.Checked) ? true : false;
            clMember.Birthdate = txt_dob.Text;
            clMember.Address_2 = txt_address2.Text;
            clMember.Address_1 = txt_address1.Text;
            clMember.City = txt_city.Text;
            clMember.County = txt_county.Text;
            clMember.EmergContactMobile = txt_emerg_mobile.Text;
            clMember.EmergContactName = txt_emerg_name.Text;
            clMember.EmergContactPhone = txt_emerg_telephone.Text;
            clMember.EmergContactRelation = txt_emerg_relation.Text;
            clMember.MedicalAllergies = txt_allergies.Text;
            clMember.MedicalDoctorName = txt_doctor_name.Text;
            clMember.MedicalNotes = txt_medical_notes.Text;
            clMember.MedicalPhone = txt_doctor_phone.Text;
            clMember.MemberNumber = txt_membernum.Text;
            clMember.PostalCode = txt_pc.Text;
            clMember.Type = cmb_type.Text;
            clMember.Email = txt_email.Text;
            clMember.Phone = txt_telephone.Text;
            clMember.Mobile = txt_mobile.Text;
            clMember.Sid = txt_sid.Text;

            clMember.StudCardNumber = txt_stcardnumber.Text;
            if (rd_male.Checked == true)
                clMember.Gender = "male";
            else
                clMember.Gender = "female";

            return clMember.SaveMember();
        }

        

        private void button_payments_Click(object sender, EventArgs e)
        {
            frm_payments frmPayments = new frm_payments(clMember.Id_member);
            frmPayments.ShowDialog();
        }

        // Close this form
        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /** 
          * @desc Executes when the "Remove" button is clicked
	      * It asks for confirmation and then calls for removing the member
          * @params [none] No input parameter. 
          * @return [none] No directly returned data. 
          */
        private void button_remove_Click(object sender, EventArgs e)
        {
            if (dg_currentborrows.RowCount > 0)
                MessageBox.Show("You can't remove this member as the borrowed equipments has to be returned first!");
            else
            {
                DialogResult result = MessageBox.Show("Are you sure?", "Delete entry", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    clMember.RemoveMember();
                    this.Close();
                }
            }
        }

        private void button_equipmentbooking_Click(object sender, EventArgs e)
        {

            frm_equipment_list frmEquipmentList = new frm_equipment_list(clMember.Id_member, this);

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
                                    this.clEquipmentBooked = new EquipmentBooked(id_eq_booking);
                                    this.clEquipmentBooked.BorrowedAmount = int.Parse(result);
                                    this.clEquipmentBooked.IsReturned = false;
                                    this.clEquipmentBooked.SaveEquipmentBooking();
                                }
                                else
                                {
                                    this.clEquipmentBooked = new EquipmentBooked(id_eq_booking);
                                    this.clEquipmentBooked.BorrowedAmount = 0;
                                    this.clEquipmentBooked.IsReturned = true;
                                    this.clEquipmentBooked.SaveEquipmentBooking();

                                }
                                this.vLoadBookedList();
 	                        }

        }


        private void rd_male_Checked(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {

                this.pictureBox1.BackgroundImage = global::Gym_administration.Properties.Resources.member_male_128;
            }
        }

        private void rd_female_Checked(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
           
                this.pictureBox1.BackgroundImage = global::Gym_administration.Properties.Resources.member_female_128;
            }
        }







        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {

            try
            {

                OpenFileDialog open = new OpenFileDialog();

                open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";

                if (open.ShowDialog() == DialogResult.OK)
                {

                    clMember.FilePath = open.FileName;
                    FileInfo file = new FileInfo(clMember.FilePath);
                    clMember.FileName = file.Name;
                    pictureBox1.Image = new Bitmap(clMember.FilePath);
                    this.pictureBox1.BackgroundImage = null;

                }

            }

            catch (Exception)
            {

                throw new ApplicationException("Failed loading image");

            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
        
            switch (e.Button) 
            {

                case (MouseButtons.Right):
                    {
                        if ((this.pictureBox1.Image != null) && (clMember.Id_file != null))
                        {
                            frm_message_box frmMessageBox = new frm_message_box();
                            string result = frmMessageBox.ShowBox(Utils.MB_YESNO, "Would you like to delete the picture?", "Delete?");
                            //MessageBox.Show(result);
                            if (result == "YES")
                            {
                                this.pictureBox1.Image = null;
                                clMember.Id_file = "";
                                clMember.FileName = "";
                                clMember.FilePath = "";
                                MessageBox.Show("Image has been marked for deletion,\r\nyou must click on save for\r\nthe deletion to take effect!");
                                if (rd_male.Checked)
                                    this.pictureBox1.BackgroundImage = global::Gym_administration.Properties.Resources.member_male_128;
                                else
                                    this.pictureBox1.BackgroundImage = global::Gym_administration.Properties.Resources.member_female_128;
                            }
                        }
                        break;
                    }
            }
        }

        /** 
          * @desc Executes when the "Save and Close" button is clicked
	      * If the saving is ok, then closes the member form
          * @params [none] No input parameter. 
          * @return [none] No directly returned data. 
          */
        private void button_saveClose_Click(object sender, EventArgs e)
        {
            if (this.saveClick())
                this.Close();
        }

        /** 
          * @desc Executes when the "Save and Close" button is clicked
	      * If the saving is ok, then closes the member form and opens up the member list
          * @params [none] No input parameter. 
          * @return [none] No directly returned data. 
          */
        private void button_saveOpen_Click(object sender, EventArgs e)
        {
            if (this.saveClick())
            {
                
                this.Dispose();
                frm_member_list frmMemberList = new frm_member_list();
                frmMemberList.ShowDialog();
            }
        }

        private void frm_member_Activated(object sender, EventArgs e)
        {
            //vLoadBookedList();
        }

        private void txt_city_TextChanged(object sender, EventArgs e)
        {
            if (txt_city.Text == "Cambridge")
                txt_county.Text = "Cambridgeshire";
        }

        private void button_RestoreMedicalText_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("This will delete all current medical notes!\r\nAre you sure?\r\n\r\n(You must click on save for\r\nthe modifications to take effect!)", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_member));
                this.txt_medical_notes.Text = resources.GetString("txt_medical_notes.Text");
            }
        }






        
    }
}
