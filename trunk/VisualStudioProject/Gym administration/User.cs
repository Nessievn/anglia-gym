using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace Gym_administration
{

    /**
     * @desc It holds data and modifying methods for the USERS table. 
     * Most closely associated forms are frm_member and frm_staff.
     * Most closely associated table is MEMBERS and STAFF.
     * @params [none] Incoming parameters are described at the individual constructors.
     * @return [none] No directly returned data. 
     * Returns of public methods are described at the individual methods.
     */
    class User
    {

        // A field with the same name from USERS table
        private int id_user;
        public int Id_user
        {
            get { return id_user; }
            set { id_user = value; }
        }

        // A field with the same name from USERS table
        private string login;
        public string Login
        {
            get { return login; }
            set { login = value; }
        }

        // A field with the same name from USERS table
        private string password;
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        // A field with the same name from USERS table
        private string profile;
        public string Profile
        {
            get { return profile; }
            set { profile = value; }
        }

        // A field with the same name from USERS table
        private bool isActive;
        public bool IsActive
        {
            get { return isActive; }
            set { isActive = value; }
        }


        /**
         * @desc Default constructor.
         * Sets id_class to -1 so the fact of this is a new user can be referenced.
         * @params [none] No input parameter.
         * @return [none] No directly returned data.
         */
        public User()
        {
            this.Id_user = -1;
        }

        /**
         * @desc Constructor
         * Loads in all fields from a single row of the USERS table.
         * @params [int] id_user identifies the user uniquely.
         * @return [none] No directly returned data.
         */
        public User(int id_user)
        {
            // Create mysql connection
            mySqlConn conn = new mySqlConn();
            conn.connect();
            string query = "SELECT * FROM users WHERE id_user = '"+id_user.ToString()+"'";
            // Launch the query to return all fields from a single row of the USERS table
            List<Hashtable> lhResultset = conn.lhSqlQuery(query);

            // Check if we found the User
            if ((int)lhResultset.Count > 0)
            {
                // Fill in all user fields with table data
                this.Id_user = int.Parse(lhResultset[0]["id_user"].ToString());
                this.IsActive = true;
                this.Login = lhResultset[0]["login"].ToString();
                this.Password = lhResultset[0]["password"].ToString();
                this.Profile = lhResultset[0]["profile"].ToString();
            }
            else
                MessageBox.Show("The User could not be found!");
        }


        /**
         * @desc This method will update the password for the user in the USERS table
         * @params [int] id_user identifies the user uniquely.
         * @params [string] oldPassword: Old password of the user
         * @params [string] newPassword: The new password of the user
         * @return [bool] Returns true in case of success, false if there was problem updating the password
         */
        public bool UpdatePassword(int id_User, string oldPassword, string newPassword)
        {
            // Create mysql connection
            mySqlConn conn = new mySqlConn();
            conn.connect();
	    // Create update password query
            string query = "UPDATE users SET password = MD5('" + newPassword + "') WHERE id_user = '" + id_user + "' AND password = MD5('" + oldPassword + "')";
	    // Launch update password query
            int result = conn.iDeleteOrUpdate(query);
	    // Check update result
            if (result > 0)
                return true;
            else
                return false;
        }


        /**
         * @desc This method will save or update a user in the USERS table
         * @params [none] No input parameter.
         * @return [bool] Returns true in case of success, false if there was problem saving/updating the user
         */
        public bool SaveUser()
        {
            // Create mysql connection
            mySqlConn conn = new mySqlConn();
            conn.connect();
	    // If this is a new user
            if (this.Id_user == -1)
            {
		// Create insert query
                string query = "insert into users (id_user, login, password, profile, active) " +
                "values (NULL, '" + this.Login + "', MD5('" + this.Password +
                "'), '" + this.Profile + "', '" + ((this.isActive) ? "1" : "0") + "')";
		// Launch insert query
                this.id_user = conn.iInsert(query);
		// Check result
                if (this.id_user > 0)
                    return true;
            }
	    // This is an existing user
            else
            {
                // Create update query
                string query = "UPDATE users SET login = '" + this.Login + "', active = '" + ((this.isActive) ? "1" : "0") + "' "+
                                "WHERE id_user = '" + this.Id_user + "'";
		// Launch update query
                int result = conn.iDeleteOrUpdate(query);
		// Check update result
                if (result > 0)
                    return true;
            }
            return false;
        }


        /**
         * @desc Removes the user from the USERS table.
         * @params [none] No input parameter.
         * @return [bool] Returns true in case of success, false if there was problem deleting the user.
         */
        public bool DeleteUser()
        {
            // Create mysql connection
            mySqlConn conn = new mySqlConn();
            conn.connect();
	    // Create delete query
            string query = "DELETE FROM users WHERE id_user = '" + this.Id_user + "'";
	    // Check delet query result
            int result = conn.iDeleteOrUpdate(query);
            if (result > 0)
                return true;
            return false;
        }
    }
}

