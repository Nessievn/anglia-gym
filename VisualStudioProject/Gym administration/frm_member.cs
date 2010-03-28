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

        public frm_member()
        {
            mbrMember = new Member();
            InitializeComponent();
            txt_membernum.Text = Utils.sGenerateNewMemberNumber();
            txt_membernum.ReadOnly = true;
        }
        
        public frm_member(int iMemberId)
        {
            InitializeComponent();

            mbrMember = new Member(iMemberId);
            if (mbrMember.IId_member < 1)
                MessageBox.Show("The member could not be found");
            else
            {
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
                 cmb_payment.Text = mbrMember.SPayment_method;
                 txt_pc.Text = mbrMember.SPostalcode;
                 cmb_type.Text = mbrMember.SType;
                 txt_email.Text = mbrMember.SEmail;
                 txt_mobile.Text = mbrMember.SMobile;
                 txt_telephone.Text = mbrMember.SPhone;
            }
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
            mbrMember.SPayment_method = cmb_payment.Text;
            mbrMember.SPicture = "none";
            mbrMember.SPostalcode = txt_pc.Text;
            mbrMember.SType = cmb_type.Text;
            mbrMember.SEmail = txt_email.Text;
            mbrMember.SPhone = txt_telephone.Text;
            mbrMember.SMobile = txt_mobile.Text;

            mbrMember.bSave();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            frm_member_list frm = new frm_member_list();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure?", "Delete entry", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                mbrMember.bRemove();
                this.Close();
            }
        }
    }
}
