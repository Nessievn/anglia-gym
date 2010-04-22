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
     * @desc Form Handler for login options. 
     * It lets th user to change password
     * @params [none] Incoming parameters are described at the individual constructors.
     * @return [none] No directly returned data. 
     * Returns of public methods are described at the individual methods.
     */  
    public partial class frm_login_options : Form
    {
        private frm_main frmMain;


        /** 
         * @desc Default constructor
         * @params [none] No input parameter. 
         * @return [none] No directly returned data. 
         */ 
        public frm_login_options()
        {
            InitializeComponent();
        }

        /** 
          * @desc Constructor for editing user password
          * @params [frm_main] frmMain:
          * @return [none] No directly returned data. 
          */
        public frm_login_options(frm_main frmMain)
        {
            InitializeComponent();
            this.frmMain = frmMain;
        }


        /** 
          * @desc Executes when the "Change Password" button is clicked
	      * It checks user input and then calls for saving the new password.
          * @params [none] No input parameter. 
          * @return [none] No directly returned data. 
          */ 
        private void button_changepassw_Click(object sender, EventArgs e)
        {
            // Check user imputs and formats
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

            // Update the user's password
            if (this.frmMain.UserLogged.UpdatePassword(this.frmMain.UserLogged.Id_user, txt_oldpassw.Text, txt_newpassw.Text))
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
