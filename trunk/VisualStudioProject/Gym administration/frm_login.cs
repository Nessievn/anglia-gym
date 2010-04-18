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

    /**
     * @desc Form Handler for login. 
     * It is for authenticating user and retrieving their profile from database
     * @params [none] Incoming parameters are described at the individual constructors.
     * @return [none] No directly returned data. 
     * Returns of public methods are described at the individual methods.
     */  
    public partial class frm_login : Form
    {
        private frm_main frmMain;

        /** 
         * @desc Constructor for creating new login, that was opened from main menu.
         * (To be able to call methods from main menu before the login form closes)
         * @params [frm_main] frmMain: by taking this parameter there will be a reference
         * to the main menu so its methods can be called from here
         * @return [none] No directly returned data. 
         */
        public frm_login(frm_main frmMain)
        {
            InitializeComponent();
            this.frmMain = frmMain;
        }


        /** 
          * @desc Executes when the "Accept" button is clicked
	      * It checks the use rname and password and loads in the profile
          * @params [none] No input parameter. 
          * @return [none] No directly returned data. 
          */ 
        private void button_accept_Click(object sender, EventArgs e)
        {
            // Create mysql connection            
            mySqlConn conn = new mySqlConn();
            conn.connect();
            // Create password md5 hash format
            string md5Hash = Utils.CreateMD5Hash(txt_password.Text.Trim());
            // Launch the query
            List<Hashtable> lhResultset = conn.lhSqlQuery("Select * from users where login='" + txt_username.Text + "' and password = '" + md5Hash + "' and active = 1");
            // If the user with the given credentials was not found
            if ((int)lhResultset.Count != 1)
                MessageBox.Show("The username or password are wrong, please use the correct credentials and try it again");
            // If it was found
            else
            {
                // Create a user object with the retrieved user id
                User userLogged = new User(int.Parse(lhResultset[0]["id_user"].ToString()));
                // Load in the outlook bar
                this.frmMain.vLoadOutlookBar();
                // Display bar options based on profile
                this.frmMain.ShowUserOptions(lhResultset[0]["profile"].ToString());
                // Pass the user to the main form
                this.frmMain.UserLogged = userLogged;
                // Close this form
                this.Close();
            }

        }

        // Close/Cancel
        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
