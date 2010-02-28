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
            // Field checking
            string sMysqlDate = Utils.sGetMysqlDate(txt_dob.Text);
            if (sMysqlDate != "0000-00-00")
            {
                mySqlConn conn = new mySqlConn();
                conn.connect();
                string sQuery = "insert into users (id_user, login, password, profile, active) values (NULL, '" + txt_email.Text + "', MD5('" + txt_dob.Text + "'), 'member', '1')";
                int iUserId = conn.iInsert(sQuery);
                if (iUserId > 0)
                {
                    sQuery = "insert into `gym`.`members` (`id_member`, `firstName`, `lastName`, `birthdate`, `address_1`, `city`, `county`, `postalcode`, `type`, `payment_method`, `id_user`, `is_active`, `address_2`, `emerg_contact_name`, `emerg_contact_relation`, `emerg_contact_phone`, `emerg_contact_mobile`, `medical_allergies`, `medical_notes`, `picture`, `medical_doctor_name`, `medical_phone`) values (NULL, '" + txt_firstName.Text + "', '" + txt_lastName.Text + "', '" + sMysqlDate + "', '" + txt_address1.Text + "', '" + txt_city.Text + "', '" + txt_county.Text + "', '" + txt_pc.Text + "', '" + cmb_type.Text + "', '" + cmb_payment.Text + "', '" + iUserId + "', '"+ ((chk_active.Checked) ? "1" : "0")+"', '" + txt_address2.Text + "', '" + txt_emerg_name.Text + "', '" + txt_emerg_relation.Text + "', '" + txt_emerg_telephone.Text + "', '" + txt_emerg_mobile.Text + "', '" + txt_allergies.Text + "', '" + txt_medical_notes.Text + "', NULL, '" + txt_doctor_name.Text + "', '" + txt_doctor_phone.Text + "')";
                    MessageBox.Show(sQuery);
                    int iMbrId = conn.iInsert(sQuery);
                    if (iMbrId > 1)
                        MessageBox.Show("The new member has been added to the databse succesfully!");
                    else
                    {
                        sQuery = "DELETE FROM users WHERE id_user = '"+iUserId+"'";
                        conn.iDeleteOrUpdate(sQuery);
                    }
                }
                else
                {
                    MessageBox.Show("The e-mail already exists in the database!, please choose another one.");
                }
                
            }


        }
    }
}
