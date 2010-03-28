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
            mySqlConn conn = new mySqlConn();
            conn.connect();
            // We launch the query
            string md5Hash = Utils.CreateMD5Hash(txt_password.Text.Trim());
            List<Hashtable> lhResultset = conn.lhSqlQuery("Select * from users where login='" + txt_username.Text + "' and password = '" + md5Hash + "' and active = 1");
            
            // Check if we found the user
            if ((int)lhResultset.Count != 1)
                MessageBox.Show("The username or password are wrong, please use the correct credentials and try it again");
            else
            {
                User userLogged = new User(int.Parse(lhResultset[0]["id_user"].ToString()));
                m_parent.vLoadOutlookBar();
                m_parent.ShowUserOptions(lhResultset[0]["profile"].ToString());
                m_parent.UserLogged = userLogged;
                
                this.Close();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
