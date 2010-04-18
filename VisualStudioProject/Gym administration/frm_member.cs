/*
 *  Windows Developer Center >  Windows Forms Forums  >  Windows Forms General  >  How can i create a "right-click menu" i C#  
 * http://social.msdn.microsoft.com/Forums/en-US/winforms/thread/790cd8be-0ba8-4f10-95a8-c88f1023d6e7
 * 
 * Mouse left click, right click, middle click, hover : Mouse Event « Event « C# / C Sharp
 * http://www.java2s.com/Code/CSharp/Event/Mouseleftclickrightclickmiddleclickhover.htm
 * 
 * MESHPLEX - C Sharp/String Literals
 * http://www.meshplex.org/wiki/C_Sharp/String_Literals
 * 
 * MySQL 5.1 with Maria Reference Manual :: 20 Connectors and APIs :: 20.2 MySQL Connector/NET :: 20.2.4 Connector/NET Programming :: 20.2.4.7 Handling BLOB Data With Connector/NET
 * http://dev.mysql.com/doc/refman/5.1-maria/en/connector-net-programming-blob.html#connector-net-programming-blob-writing
 * 
 * C# Online.net - Working with Images—Using the Bitmap Class
 * http://en.csharp-online.net/Working_with_Images%E2%80%94Using_the_Bitmap_Class
 * 
  * DevAsp.net - How to load Image in C# and set properties of the Picture Box 
 * http://www.devasp.net/net/articles/display/385.html
 * 
 * Windows Developer Center >  Windows Forms Forums  >  Windows Forms General  >  How to check string is number or not in C#  
 * http://social.msdn.microsoft.com/Forums/en-US/winforms/thread/84990ad2-5046-472b-b103-f862bfcd5dbc
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
using System.IO;

namespace Gym_administration
{
    /**
     * @desc Form Handler for members. 
     * It is for adding or modifying a member.
     * @params [none] Incoming parameters are described at the individual constructors.
     * @return [none] No directly returned data. 
     * Returns of public methods are described at the individual methods.
     */   
    public partial class frm_member : Form
    {
        Member clMember;
        EquipmentBooked clEquipmentBooked;
        frm_member_list frmMemberList;

        /** 
         * @desc Default constructor for creating new member from main menu.
         * This is for loading from main menu, 
         * @params [none] No input parameter. 
         * @return [none] No directly returned data. 
         */ 
        public frm_member()
        {

            clMember = new Member();
            InitializeComponent();
            txt_membernum.Text = Utils.sGenerateNewMemberNumber();
            txt_membernum.ReadOnly = true;
            // Members who don't yet exist can't book equipment
            // This will be available once the "Save and Stay" is executed successfully
            button_equipmentbooking.Hide();
            // Members who don't yet exist can't book equipment
            // This will be available once the "Save and Stay" is executed successfully
            button_payments.Hide();
            // Members who don't yet exist can't be deleted
            button_remove.Hide();
            clMember.Id_file = "";
            cmb_type.SelectedIndex = 0;

            this.pictureBox1.BackgroundImage = global::Gym_administration.Properties.Resources.member_male_128;
            rd_male.Checked = true;
        }

        /** 
          * @desc Constructor for creating new member, that was opened from member list.
          * (To be able to refresh member list after saving the new member)
          * @params [frm_member_list] frmMemberList: by taking this parameter there will be a reference
          * to the member list so it can be refreshed after saving the new member
          * @return [none] No directly returned data. 
          */
        public frm_member(frm_member_list frmMemberList)
        {
            // Create reference to the parent form
            this.frmMemberList = frmMemberList;
            // create new member object
            clMember = new Member();
            InitializeComponent();
            txt_membernum.Text = Utils.sGenerateNewMemberNumber();
            txt_membernum.ReadOnly = true;
            // equipmentbooking, add payments and remove member buttons are hidden until saving (creating) the member
            button_equipmentbooking.Hide();
            button_payments.Hide();
            button_remove.Hide();
            // As this was opened from a member list there is no need to open a new one after closing
            button_saveOpen.Hide();
            clMember.Id_file = "";
            // Set a default type (Full time student)
            cmb_type.SelectedIndex = 0;
            // Set default gender and image
            rd_male.Checked = true;
            this.pictureBox1.BackgroundImage = global::Gym_administration.Properties.Resources.member_male_128;
            
        }

        /** 
          * @desc Constructor for editing an existing member.
          * (To be able to refresh member list after saving the edited member)
	      * @params [int] id_member: identifies the member to modify
          * @params [frm_member_list] frmMemberList: by taking this parameter there will be a reference
          * to the member list so it can be refreshed after saving the edited member
          * @return [none] No directly returned data. 
          */        
        public frm_member(int id_member, frm_member_list frmMemberList)
        {
            InitializeComponent();
            // Create reference to the parent form
            this.frmMemberList = frmMemberList;
            // Load in member details for specified member
            clMember = new Member(id_member);
            
            button_equipmentbooking.Show();
            button_payments.Show();
            button_remove.Show();
            button_saveOpen.Hide();

            if (clMember.Id_member < 1)
                MessageBox.Show("The member could not be found");
            else
            {
                // If the member was found, load in all member details into member object from database
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
                // If there is a corresponing picture for this member, then load it in,
                // else show default image, depending on gender
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




        public void vLoadBookedList()
        {

            // Create mysql connection            
            mySqlConn conn = new mySqlConn();
            conn.connect();
            // Create source for grid
            BindingSource itemsSource = new BindingSource();
            // Create query
            string query = "SELECT DISTINCT eb.date_due Due, e.name Name, eb.borrowedamount Amount, eb.id_equipment EqID, eb.id_eq_booking BkID FROM equipment e, equipment_bookings eb WHERE eb.id_member = " + clMember.Id_member + " AND (eb.isreturned = 0 OR eb.isreturned is NULL) AND eb.id_equipment = e.id_equipment ORDER BY Due";
            // Launch query and load result into source
            itemsSource.DataSource = conn.dtGetTableForDataGrid(query);
            // Assign source to grid
            dg_currentborrows.DataSource = itemsSource;
            dg_currentborrows.AllowUserToAddRows = false;
            dg_currentborrows.ReadOnly = true;
            // Check for unreturned items, if there is any, then report ir to user!
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
                if (lateItems > 0)
                    MessageBox.Show("This persom has " + lateItems + " late, unreturned item(s).");
            }
        }


        /** 
          * @desc Executes when the "Save and Stay" button is clicked
	      * It calls for saving, then leaves the form open for further editing
          * @params [none] No input parameter. 
          * @return [none] No directly returned data. 
          */
        private void button_saveStay_Click(object sender, EventArgs e)
        {

            saveClick();
            button_equipmentbooking.Show();
            button_payments.Show();
            button_remove.Show();

        }


        /** 
          * @desc Executes when the "Save and Close", "Save and Open List" or "Save and Stay" button is clicked
	      * It copies user input into member object and then calls for saving the member
          * @params [none] No input parameter. 
          * @return [bool] Returns true in case of success. 
          */
        private bool saveClick()
        {
            // Copy all form fields into member object fields
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
            // Call for saving the member
            return clMember.SaveMember();
        }


        /** 
          * @desc Executes when the "Payments" button is clicked
          * It displays the add payment form instantiated for this specific member
          * @params [none] No input parameter. 
          * @return [none] No directly returned data. 
          */
        private void button_payments_Click(object sender, EventArgs e)
        {
            frm_payments frmPayments = new frm_payments(clMember.Id_member);
            frmPayments.ShowDialog();
        }

        // Close/Cancel
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
            // If there are still equipments borrowed, the member can't be deleted!
            if (dg_currentborrows.RowCount > 0)
                MessageBox.Show("You can't remove this member as the borrowed equipments has to be returned first!");
            // else there are no outstanding borrowed equipments
            else
            {   // Confirm member removal
                DialogResult result = MessageBox.Show("Are you sure?", "Delete entry", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    // Remove the member
                    clMember.RemoveMember();
                    // refresh parent member list if this was called from a member list
                    if (frmMemberList != null) this.frmMemberList.vLoadMemberList();
                    this.Close();
                }
            }
        }


        /** 
          * @desc Executes when the "Equipment Booking" button is clicked
          * It displays the equipment list for borrowing form instantiated for this specific member
          * @params [none] No input parameter. 
          * @return [none] No directly returned data. 
          */
        private void button_equipmentbooking_Click(object sender, EventArgs e)
        {
            frm_equipment_list frmEquipmentList = new frm_equipment_list(clMember.Id_member, this);
            frmEquipmentList.ShowDialog();  
        }


        /** 
          * @desc Executes when a grid cell is double clicked on the member list
	      * It loads in the member belonging to the cell
          * @params [none] No input parameter. 
          * @return [none] No directly returned data. 
          */ 
        private void dg_currentborrows_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Retrieve member details from grid row
            string name = dg_currentborrows.Rows[e.RowIndex].Cells[1].Value.ToString();
            int borrowedAmount = int.Parse(dg_currentborrows.Rows[e.RowIndex].Cells[2].Value.ToString());
            int id_eq_booking = int.Parse(dg_currentborrows.Rows[e.RowIndex].Cells[4].Value.ToString());

            frm_message_box myMessageBox = new frm_message_box();
            string result = myMessageBox.ShowBox(Utils.MB_CUST4, "", "How many "+name+" would you like to return?",borrowedAmount.ToString());


 
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
            //  If saving the member was successful
            if (this.saveClick())
            {
                // Refresh the list in parent window and close this one
                if (this.frmMemberList != null) this.frmMemberList.vLoadMemberList();
                this.Close();
            }

        }

        /** 
          * @desc Executes when the "Save and Close" button is clicked
	      * If the saving is ok, then closes the member form and opens up the member list
          * This button is never shown on a member form which was just called form a member list.
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
