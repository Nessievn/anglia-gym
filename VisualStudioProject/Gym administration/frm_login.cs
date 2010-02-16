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
        public frm_login()
        {
            InitializeComponent();
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

            // We launch the query
            Hashtable htResultset = conn.htSqlQuery("Select * from users where user='"+txt_username.Text+"' and password = '"+txt_password.Text+"'");
            
            // Check if we found the user
            if ((int)htResultset.Count == 0)
                MessageBox.Show("The username or passowrd are wrong, please use the correct credentials and try it again");
            else
            {
                MessageBox.Show("IN!!");
            }

        }
    }
}
