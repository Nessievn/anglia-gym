using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace Gym_administration
{
    class User
    {
        private int id_user;

        public int Id_user
        {
            get { return id_user; }
            set { id_user = value; }
        }

        private string login;

        public string Login
        {
            get { return login; }
            set { login = value; }
        }

        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        private string profile;

        public string Profile
        {
            get { return profile; }
            set { profile = value; }
        }

        private bool isActive;

        public bool IsActive
        {
            get { return isActive; }
            set { isActive = value; }
        }

        public User()
        {
            this.Id_user = -1;
        }

        public User(int id_user)
        {
            mySqlConn conn = new mySqlConn();
            conn.connect();
            string sQuery = "SELECT * FROM users WHERE id_user = '"+id_user.ToString()+"'";
            // We launch the query
            List<Hashtable> lhResultset = conn.lhSqlQuery(sQuery);

            // Check if we found the User
            if ((int)lhResultset.Count > 0)
            {
                this.Id_user = int.Parse(lhResultset[0]["id_user"].ToString());
                this.IsActive = true;
                this.Login = lhResultset[0]["login"].ToString();
                this.Password = lhResultset[0]["password"].ToString();
                this.Profile = lhResultset[0]["profile"].ToString();
            }
            else
                MessageBox.Show("The User could not be found!");
        }

        public bool UpdatePassword(int id_User, string oldPassword, string newPassword)
        {
            mySqlConn conn = new mySqlConn();
            conn.connect();
            string sQuery = "UPDATE users SET password = MD5('" + newPassword + "') WHERE id_user = '" + id_user + "' AND password = MD5('" + oldPassword + "')";
            int iMod = conn.iDeleteOrUpdate(sQuery);

            if (iMod > 0)
                return true;
            else
                return false;
        }

        public bool SaveUser()
        {
            mySqlConn conn = new mySqlConn();
            conn.connect();

            if (this.Id_user == -1)
            {
                string sQuery = "insert into users (id_user, login, password, profile, active) " +
                "values (NULL, '" + this.Login + "', MD5('" + this.Password +
                "'), '" + this.Profile + "', '" + ((this.isActive) ? "1" : "0") + "')";

                this.id_user = conn.iInsert(sQuery);

                if (this.id_user > 0)
                    return true;
            }
            else
            {
                string sQuery = "UPDATE users SET login = '" + this.Login + "', active = '" + ((this.isActive) ? "1" : "0") + "' "+
                                "WHERE id_user = '" + this.Id_user + "'";

                int iMod = conn.iDeleteOrUpdate(sQuery);

                if (iMod > 0)
                    return true;
            }
            return false;
        }
        public bool DeleteUser()
        {
            mySqlConn conn = new mySqlConn();
            conn.connect();
            string sQuery = "DELETE FROM users WHERE id_user = '" + this.Id_user + "'";
            int result = conn.iDeleteOrUpdate(sQuery);
            if (result > 0)
                return true;
            return false;
        }
    }
}
