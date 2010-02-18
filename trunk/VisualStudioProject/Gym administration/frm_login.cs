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
    public partial class frm_login : Form
    {
        private frm_main m_parent;

        public frm_login(frm_main frmMain)
        {
            InitializeComponent();
            m_parent = frmMain;

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frm_login_Load(object sender, EventArgs e)
        {

        }

        private void btn_accept_Click(object sender, EventArgs e)
        {
            mySqlConn conn = new mySqlConn("localhost", "gym", "gym", "gym");
            conn.connect();
/*
            List<Hashtable> lhResultset2 = new List<Hashtable>();
            lhResultset2 = conn.lhSqlQuery("SELECT * FROM members");

            foreach (record ht in lhResultset2)
                MessageBox.Show(record["name"].ToString());
            */

            // We launch the query
            List<Hashtable> lhResultset = conn.lhSqlQuery("Select * from users where user='" + txt_username.Text + "' and password = '" + txt_password.Text + "'");
            
            // Check if we found the user
            if ((int)lhResultset.Count != 1)
                MessageBox.Show("The username or passowrd are wrong, please use the correct credentials and try it again");
            else
            {
                m_parent.ShowUserOptions("manager");
                this.Close();
            }

        }
    }
}
