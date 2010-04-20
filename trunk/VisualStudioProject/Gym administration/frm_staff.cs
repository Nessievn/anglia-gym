using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Gym_administration
{

    /**
      * @desc Form Handler for staff. 
      * It is for adding or modifying a staff.
      * @params [none] Incoming parameters are described at the individual constructors.
      * @return [none] No directly returned data. 
      * Returns of public methods are described at the individual methods.
      */ 
    public partial class frm_staff : Form
    {
        Staff clStaff;
        EquipmentBooked clEquipmentBooked;
        frm_staff_list frmStaffList;


        public frm_staff()
        {
            clStaff = new Staff();
            InitializeComponent();
            button_equipmentbooking.Hide();
            DateTime today = DateTime.Today;
            txt_contract_start.Text = String.Format("{0:dd-MM-yyyy}", today);
        }


        public frm_staff(frm_staff_list frmStaffList)
        {
            this.frmStaffList = frmStaffList;
            clStaff = new Staff();
            InitializeComponent();
            button_saveOpen.Hide();
            button_equipmentbooking.Hide();
            DateTime today = DateTime.Today;
            txt_contract_start.Text = String.Format("{0:dd-MM-yyyy}", today);
        }

        public frm_staff(int id_staff, frm_staff_list frmStaffList)
        {
            this.frmStaffList = frmStaffList;
            InitializeComponent();
            button_equipmentbooking.Show();
            button_saveOpen.Hide();
            clStaff = new Staff(id_staff);
            if (clStaff.Id_staff < 1)
                MessageBox.Show("The staff member could not be found");
            else
            {
                vLoadBookedList();
                 txt_firstName.Text = clStaff.FirstName;
                 txt_lastName.Text = clStaff.LastName;
                 txt_dob.Text = Utils.sGetCsharpDateFromMysqlDate(clStaff.Birthdate);
                 txt_address1.Text = clStaff.Address_1;
                 txt_address2.Text = clStaff.Address_2;
                 txt_city.Text = clStaff.City;
                 txt_county.Text = clStaff.County;
                 txt_emerg_mobile.Text = clStaff.EmergContactMobile;
                 txt_emerg_name.Text = clStaff.EmergContactName;
                 txt_emerg_telephone.Text = clStaff.EmergContactPhone;
                 txt_emerg_relation.Text = clStaff.EmergContactRelation;
                 txt_allergies.Text = clStaff.MedicalAllergies;
                 txt_doctor_name.Text = clStaff.MedicalDoctorName;
                 txt_medical_notes.Text = clStaff.MedicalNotes;
                 txt_qualifications.Text = clStaff.Qualifications;
                 txt_doctor_phone.Text = clStaff.MedicalPhone;
                 txt_pc.Text = clStaff.PostalCode;
                 cmb_contract.Text = clStaff.ContractType;
                 txt_email.Text = clStaff.Email;
                 txt_mobile.Text = clStaff.Mobile;
                 txt_telephone.Text = clStaff.Phone;
                 cmb_position.Text = clStaff.Position;
                 txt_natinsnumb.Text = clStaff.NatInsNumb;
                 txt_contract_start.Text = clStaff.SContractStart;
                 txt_contract_finish.Text = clStaff.SContractFinish;
            }
        }


        public void vLoadBookedList()
        {
            // Create mysql connection           
            mySqlConn conn = new mySqlConn();
            conn.connect();
            BindingSource itemsSource = new BindingSource();
            string query = "SELECT DISTINCT eb.date_due Due, e.name Name, eb.borrowedamount Amount, eb.id_equipment EqID, eb.id_eq_booking BkID FROM equipment e, equipment_bookings eb WHERE eb.id_staff = " + clStaff.Id_staff + " AND (eb.isreturned = 0 OR eb.isreturned is NULL) AND eb.id_equipment = e.id_equipment ORDER BY Due";
            itemsSource.DataSource = conn.dtGetTableForDataGrid(query);
            dg_eqbookings.DataSource = itemsSource;
            dg_eqbookings.AllowUserToAddRows = false;
            dg_eqbookings.ReadOnly = true;
        }


        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

 
        /** 
          * @desc Executes when the "Save and Close", "Save and Open List" or "Save and Stay" button is clicked
	      * It copies user input into staff object and then calls for saving the staff
          * @params [none] No input parameter. 
          * @return [bool] Returns true in case of success. 
          */
        private bool saveClick()
        {
            // Copy all form fields into staff object fields
            clStaff.FirstName = txt_firstName.Text;
            clStaff.LastName = txt_lastName.Text;
            clStaff.Birthdate = txt_dob.Text;
            clStaff.Address_1 = txt_address1.Text;
            clStaff.Address_2 = txt_address2.Text;
            clStaff.City = txt_city.Text;
            clStaff.County = txt_county.Text;
            clStaff.EmergContactMobile = txt_emerg_mobile.Text;
            clStaff.EmergContactName = txt_emerg_name.Text;
            clStaff.EmergContactPhone = txt_emerg_telephone.Text;
            clStaff.EmergContactRelation = txt_emerg_relation.Text;
            clStaff.MedicalAllergies = txt_allergies.Text;
            clStaff.MedicalDoctorName = txt_doctor_name.Text;
            clStaff.MedicalNotes = txt_medical_notes.Text;
            clStaff.Qualifications = txt_qualifications.Text;
            clStaff.MedicalPhone = txt_doctor_phone.Text;
            clStaff.Position = cmb_position.Text;
            clStaff.Picture = "none";
            clStaff.PostalCode = txt_pc.Text;
            clStaff.ContractType = cmb_contract.Text;
            clStaff.Email = txt_email.Text;
            clStaff.Phone = txt_telephone.Text;
            clStaff.Mobile = txt_mobile.Text;
            clStaff.NatInsNumb = txt_natinsnumb.Text;
            clStaff.SContractStart = txt_contract_start.Text;
            clStaff.SContractFinish = txt_contract_finish.Text;

            // savig the staff
            return clStaff.SaveStaff();
        }

        /** 
          * @desc Executes when the "Save and Stay" button is clicked
	      * If the saving is ok, then leaves the form open for further editing
          * @params [none] No input parameter. 
          * @return [none] No directly returned data. 
          */
        private void button_saveStay_Click(object sender, EventArgs e)
        {
            if (saveClick())
            {
                button_equipmentbooking.Show();
            }
        }

        private void button_equipmentbooking_Click(object sender, EventArgs e)
        {
            frm_equipment_list frmEquipmentList = new frm_equipment_list(clStaff.Id_staff,this);
            frmEquipmentList.ShowDialog();  
        }

        /** 
          * @desc Executes when a grid cell is double clicked on the borrowed equipment list
	      * It loads in the equipment return dialog belonging to the cell
          * @params [none] No input parameter. 
          * @return [none] No directly returned data. 
          */ 
        private void dg_eqbookings_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Retrieve equipment booking details from grid row
            string equipmentName = dg_eqbookings.Rows[e.RowIndex].Cells[1].Value.ToString();
            int borrowedAmount = int.Parse(dg_eqbookings.Rows[e.RowIndex].Cells[2].Value.ToString());
            int id_eq_booking = int.Parse(dg_eqbookings.Rows[e.RowIndex].Cells[4].Value.ToString());
            // Show return dialog for confirming amount to be returned
            frm_message_box myMessageBox = new frm_message_box();
            string result = myMessageBox.ShowBox(Utils.MB_CUST4, "", "How many " + equipmentName + " would you like to return?", borrowedAmount.ToString());

            // Reference how to use TryParse
            //ref  http://social.msdn.microsoft.com/Forums/en-US/winforms/thread/84990ad2-5046-472b-b103-f862bfcd5dbc

            // Check the result of user input
            double Num;
            bool isNum = double.TryParse(result, out Num);
            if (isNum)
            {
                // If there is something to return but not everything
                if ((int.Parse(result) > 0) && (result != "Cancel"))
                {
                    // Save the new amount into eq. booking
                    this.clEquipmentBooked = new EquipmentBooked(id_eq_booking);
                    this.clEquipmentBooked.BorrowedAmount = int.Parse(result);
                    this.clEquipmentBooked.IsReturned = false;
                    this.clEquipmentBooked.SaveEquipmentBooking();
                }
                // If all amount of this booking is to be returned
                else
                {
                    // Mark the booking as returned
                    this.clEquipmentBooked = new EquipmentBooked(id_eq_booking);
                    this.clEquipmentBooked.BorrowedAmount = 0;
                    this.clEquipmentBooked.IsReturned = true;
                    this.clEquipmentBooked.SaveEquipmentBooking();

                }
                // Refresh eq. booking list
                this.vLoadBookedList();
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
            {
                // Refresh the list in parent window and close this one
                if (this.frmStaffList != null) this.frmStaffList.vLoadStaffList();
                this.Close();
            }
        }

        /** 
          * @desc Executes when the "Save and Open" button is clicked
	      * If the saving is ok, then closes the member form and opens up the member list
          * @params [none] No input parameter. 
          * @return [none] No directly returned data. 
          */
        private void button_saveOpen_Click(object sender, EventArgs e)
        {
            if (this.saveClick())
            {
                this.Dispose();
                frm_staff_list frmStaffList = new frm_staff_list();
                frmStaffList.ShowDialog();
            }
        }






 


    }
}
