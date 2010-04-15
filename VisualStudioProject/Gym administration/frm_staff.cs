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
    public partial class frm_staff : Form
    {
        Staff stfStaff;
        EquipmentBooked eqEquipmentBooked;

        public void vLoadBookedList()
        {
            mySqlConn conn = new mySqlConn();
            conn.connect();
            BindingSource itemsSource = new BindingSource();
            string sQuery = "SELECT DISTINCT eb.date_due Due, e.name Name, eb.borrowedamount Amount, eb.id_equipment EqID, eb.id_eq_booking BkID FROM equipment e, equipment_bookings eb WHERE eb.id_staff = " + stfStaff.Id_staff + " AND (eb.isreturned = 0 OR eb.isreturned is NULL) AND eb.id_equipment = e.id_equipment ORDER BY Due";
            itemsSource.DataSource = conn.dtGetTableForDataGrid(sQuery);
            dg_currentborrows.DataSource = itemsSource;
            dg_currentborrows.AllowUserToAddRows = false;
            dg_currentborrows.ReadOnly = true;
        }


        public frm_staff()
        {
            stfStaff = new Staff();
            InitializeComponent();
            button_equipmentbooking.Hide();
            DateTime today = DateTime.Today;
            txt_contract_start.Text = String.Format("{0:dd-MM-yyyy}", today);
        }
        public frm_staff(bool isFromStaffList)
        {
            stfStaff = new Staff();
            InitializeComponent();
            button_equipmentbooking.Hide();
            button_saveOpen.Hide();
            DateTime today = DateTime.Today;
            txt_contract_start.Text = String.Format("{0:dd-MM-yyyy}", today);
        }

        public frm_staff(int iStaffId)
        {
            InitializeComponent();
            button_equipmentbooking.Show();
            button_saveOpen.Hide();
            stfStaff = new Staff(iStaffId);
            if (stfStaff.Id_staff < 1)
                MessageBox.Show("The staff member could not be found");
            else
            {
                vLoadBookedList();
                 txt_firstName.Text = stfStaff.FirstName;
                 txt_lastName.Text = stfStaff.LastName;
                 txt_dob.Text = Utils.sGetCsharpDateFromMysqlDate(stfStaff.Birthdate);
                 txt_address1.Text = stfStaff.Address_1;
                 txt_address2.Text = stfStaff.Address_2;
                 txt_city.Text = stfStaff.City;
                 txt_county.Text = stfStaff.County;
                 txt_emerg_mobile.Text = stfStaff.EmergContactMobile;
                 txt_emerg_name.Text = stfStaff.EmergContactName;
                 txt_emerg_telephone.Text = stfStaff.EmergContactPhone;
                 txt_emerg_relation.Text = stfStaff.EmergContactRelation;
                 txt_allergies.Text = stfStaff.MedicalAllergies;
                 txt_doctor_name.Text = stfStaff.MedicalDoctorName;
                 txt_medical_notes.Text = stfStaff.MedicalNotes;
                 txt_qualifications.Text = stfStaff.Qualifications;
                 txt_doctor_phone.Text = stfStaff.MedicalPhone;
                 txt_pc.Text = stfStaff.PostalCode;
                 cmb_contract.Text = stfStaff.ContractType;
                 txt_email.Text = stfStaff.Email;
                 txt_mobile.Text = stfStaff.Mobile;
                 txt_telephone.Text = stfStaff.Phone;
                 cmb_position.Text = stfStaff.Position;
                 txt_natinsnumb.Text = stfStaff.NatInsNumb;
                 txt_contract_start.Text = stfStaff.SContractStart;
                 txt_contract_finish.Text = stfStaff.SContractFinish;
            }
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_staff_Load(object sender, EventArgs e)
        {
            //Startup load
        }

        private bool saveClick()
        {
            stfStaff.FirstName = txt_firstName.Text;
            stfStaff.LastName = txt_lastName.Text;
            stfStaff.Birthdate = txt_dob.Text;
            stfStaff.Address_1 = txt_address1.Text;
            stfStaff.Address_2 = txt_address2.Text;
            stfStaff.City = txt_city.Text;
            stfStaff.County = txt_county.Text;
            stfStaff.EmergContactMobile = txt_emerg_mobile.Text;
            stfStaff.EmergContactName = txt_emerg_name.Text;
            stfStaff.EmergContactPhone = txt_emerg_telephone.Text;
            stfStaff.EmergContactRelation = txt_emerg_relation.Text;
            stfStaff.MedicalAllergies = txt_allergies.Text;
            stfStaff.MedicalDoctorName = txt_doctor_name.Text;
            stfStaff.MedicalNotes = txt_medical_notes.Text;
            stfStaff.Qualifications = txt_qualifications.Text;
            stfStaff.MedicalPhone = txt_doctor_phone.Text;
            stfStaff.Position = cmb_position.Text;
            stfStaff.Picture = "none";
            stfStaff.PostalCode = txt_pc.Text;
            stfStaff.ContractType = cmb_contract.Text;
            stfStaff.Email = txt_email.Text;
            stfStaff.Phone = txt_telephone.Text;
            stfStaff.Mobile = txt_mobile.Text;
            stfStaff.NatInsNumb = txt_natinsnumb.Text;
            stfStaff.SContractStart = txt_contract_start.Text;
            stfStaff.SContractFinish = txt_contract_finish.Text;


            return stfStaff.bSave();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            saveClick();
        }

        private void button_equipmentbooking_Click(object sender, EventArgs e)
        {


            // Creating the child form login
            //isBooking, "isMember", id_member
            frm_equipment_list frmEquipmentList = new frm_equipment_list(stfStaff.Id_staff,this);

            if (Utils.bIsAlreadyOpened(frmEquipmentList)) return;
            //frmEquipmentList.Show();
            frmEquipmentList.ShowDialog();  


        }

        private void dg_currentborrows_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            string sEquipmentName = dg_currentborrows.Rows[e.RowIndex].Cells[1].Value.ToString();
            int iBorrowedAmount = int.Parse(dg_currentborrows.Rows[e.RowIndex].Cells[2].Value.ToString());
            int iEquipmentId = int.Parse(dg_currentborrows.Rows[e.RowIndex].Cells[3].Value.ToString());
            int iEqBookingId = int.Parse(dg_currentborrows.Rows[e.RowIndex].Cells[4].Value.ToString());

            frm_message_box myMessageBox = new frm_message_box();
            string iresult = myMessageBox.ShowBox(Utils.MB_CUST4, "", "How many " + sEquipmentName + " would you like to return?", iBorrowedAmount.ToString());


            //ref  http://social.msdn.microsoft.com/Forums/en-US/winforms/thread/84990ad2-5046-472b-b103-f862bfcd5dbc


            double Num;
            bool isNum = double.TryParse(iresult, out Num);
            if (isNum)
            {

                if ((int.Parse(iresult) > 0) && (iresult != "Cancel"))
                {
                    this.eqEquipmentBooked = new EquipmentBooked(iEqBookingId);
                    this.eqEquipmentBooked.BorrowedAmount = int.Parse(iresult);
                    this.eqEquipmentBooked.IsReturned = false;
                    this.eqEquipmentBooked.bSave();
                }
                else
                {
                    this.eqEquipmentBooked = new EquipmentBooked(iEqBookingId);
                    this.eqEquipmentBooked.BorrowedAmount = 0;
                    this.eqEquipmentBooked.IsReturned = true;
                    this.eqEquipmentBooked.bSave();

                }
                this.vLoadBookedList();
            }

        }

        private void button_saveClose_Click(object sender, EventArgs e)
        {
            if (this.saveClick())
                this.Close();
        }
        private void button_saveOpen_Click(object sender, EventArgs e)
        {
            if (this.saveClick())
            {

                this.Dispose();
                frm_member_list frmMemberList = new frm_member_list();
                frmMemberList.ShowDialog();
            }
        }


 


    }
}
