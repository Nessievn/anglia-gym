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
    public partial class frm_member : Form
    {
        public frm_member()
        {
            InitializeComponent();
        }

        private void frm_member_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Member mbrMember = new Member();
            mbrMember.SFirstName = txt_firstName.Text;
            mbrMember.SLastName = txt_lastName.Text;
            mbrMember.BIs_active = (chk_active.Checked) ? true : false;
            mbrMember.SBirthdate = txt_dob.Text;
            mbrMember.SAaddress_2 = txt_address1.Text;
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
            mbrMember.SPayment_method = cmb_payment.Text;
            mbrMember.SPicture = "none";
            mbrMember.SPostalcode = txt_pc.Text;
            mbrMember.SType = cmb_type.Text;
            mbrMember.SEmail = txt_email.Text;
            mbrMember.bSave();
        }
    }
}
