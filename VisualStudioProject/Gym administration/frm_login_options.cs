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
    public partial class frm_login_options : Form
    {
        private frm_main frmParent;

        public frm_login_options()
        {
            InitializeComponent();
        }
        public frm_login_options(frm_main parent)
        {
            InitializeComponent();
            this.frmParent = parent;
        }

        private void button_changepassw_Click(object sender, EventArgs e)
        {
            if (txt_newpassw.Text != txt_repeatnewpw.Text)
            {
                MessageBox.Show("The passwords does not match");
                return;
            }
            else if (txt_newpassw.Text.Length < 2 || txt_repeatnewpw.Text.Length < 2)
            {
                MessageBox.Show("The password is too short");
                return;
            }

            if (this.frmParent.UserLogged.bUpdatePassword(this.frmParent.UserLogged.IId_user, txt_oldpassw.Text, txt_newpassw.Text))
            {
                MessageBox.Show("The user's password has been updated!");
                this.Close();
            }
            else
            {
                MessageBox.Show("The old password is incorrect!");
            }
           
        }
    }
}
