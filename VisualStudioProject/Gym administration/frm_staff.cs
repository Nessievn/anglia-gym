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
 
        public frm_staff()
        {
            stfStaff = new Staff();
            InitializeComponent();
        }

        public frm_staff(int iStaffId)
        {
            InitializeComponent();
            
            stfStaff = new Staff(iStaffId);
            if (stfStaff.IId_staff < 1)
                MessageBox.Show("The staff member could not be found");
            else
            {
                 txt_firstName.Text = stfStaff.SFirstName;
                 txt_lastName.Text = stfStaff.SLastName;
                 txt_dob.Text = Utils.sGetCsharpDateFromMysqlDate(stfStaff.SBirthdate);
                 txt_address1.Text = stfStaff.SAddress_1;
                 txt_address2.Text = stfStaff.SAaddress_2;
                 txt_city.Text = stfStaff.SCity;
                 txt_county.Text = stfStaff.SCounty;
                 txt_emerg_mobile.Text = stfStaff.SEmerg_contact_mobile;
                 txt_emerg_name.Text = stfStaff.SEmerg_contact_name;
                 txt_emerg_telephone.Text = stfStaff.SEmerg_contact_phone;
                 txt_emerg_relation.Text = stfStaff.SEmerg_contact_relation;
                 txt_allergies.Text = stfStaff.SMedical_allergies;
                 txt_doctor_name.Text = stfStaff.SMedical_doctor_name;
                 txt_medical_notes.Text = stfStaff.SMedical_notes;
                 txt_qualifications.Text = stfStaff.SQualifications;
                 txt_doctor_phone.Text = stfStaff.SMedical_phone;
                 txt_pc.Text = stfStaff.SPostalcode;
                 cmb_contract.Text = stfStaff.SContractType;
                 txt_email.Text = stfStaff.SEmail;
                 txt_mobile.Text = stfStaff.SMobile;
                 txt_telephone.Text = stfStaff.SPhone;
                 cmb_position.Text = stfStaff.SPosition;
                 txt_natinsnumb.Text = stfStaff.SNatInsNumb;
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



        private void button_save_Click(object sender, EventArgs e)
        {
            stfStaff.SFirstName = txt_firstName.Text;
            stfStaff.SLastName = txt_lastName.Text;
            stfStaff.SBirthdate = txt_dob.Text;
            stfStaff.SAaddress_2 = txt_address2.Text;
            stfStaff.SAddress_1 = txt_address1.Text;
            stfStaff.SCity = txt_city.Text;
            stfStaff.SCounty = txt_county.Text;
            stfStaff.SEmerg_contact_mobile = txt_emerg_mobile.Text;
            stfStaff.SEmerg_contact_name = txt_emerg_name.Text;
            stfStaff.SEmerg_contact_phone = txt_emerg_telephone.Text;
            stfStaff.SEmerg_contact_relation = txt_emerg_relation.Text;
            stfStaff.SMedical_allergies = txt_allergies.Text;
            stfStaff.SMedical_doctor_name = txt_doctor_name.Text;
            stfStaff.SMedical_notes = txt_medical_notes.Text;
            stfStaff.SQualifications = txt_qualifications.Text;
            stfStaff.SMedical_phone = txt_doctor_phone.Text;
            stfStaff.SPosition = cmb_position.Text;
            stfStaff.SPicture = "none";
            stfStaff.SPostalcode = txt_pc.Text;
            stfStaff.SContractType = cmb_contract.Text;
            stfStaff.SEmail = txt_email.Text;
            stfStaff.SPhone = txt_telephone.Text;
            stfStaff.SMobile = txt_mobile.Text;
            stfStaff.SNatInsNumb = txt_natinsnumb.Text;
            stfStaff.SContractStart = txt_contract_start.Text;
            stfStaff.SContractFinish = txt_contract_finish.Text;
            

            stfStaff.bSave();
        }


    }
}
