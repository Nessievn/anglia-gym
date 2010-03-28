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
        private int iId_user;

        public int IId_user
        {
            get { return iId_user; }
            set { iId_user = value; }
        }

        private string sLogin;

        public string SLogin
        {
            get { return sLogin; }
            set { sLogin = value; }
        }

        private string sPassword;

        public string SPassword
        {
            get { return sPassword; }
            set { sPassword = value; }
        }
        private string sProfile;

        public string SProfile
        {
            get { return sProfile; }
            set { sProfile = value; }
        }

        private bool bActive;

        public bool BActive
        {
            get { return bActive; }
            set { bActive = value; }
        }

        public User()
        {
            this.IId_user = -1;
        }

        public User(int iIdUser)
        {
            mySqlConn conn = new mySqlConn();
            conn.connect();
            string sQuery = "SELECT * FROM users WHERE id_user = '"+iIdUser.ToString()+"'";
            // We launch the query
            List<Hashtable> lhResultset = conn.lhSqlQuery(sQuery);

            // Check if we found the User
            if ((int)lhResultset.Count > 0)
            {
                this.IId_user = int.Parse(lhResultset[0]["id_user"].ToString());
                this.BActive = true;
                this.SLogin = lhResultset[0]["login"].ToString();
                this.SPassword = lhResultset[0]["password"].ToString();
                this.SProfile = lhResultset[0]["profile"].ToString();
            }
            else
                MessageBox.Show("The User could not be found!");
        }

        public bool bUpdatePassword(int iIdUser, string old_password, string new_password)
        {
            mySqlConn conn = new mySqlConn();
            conn.connect();
            string sQuery = "UPDATE users SET password = MD5('" + new_password + "') WHERE id_user = '" + iIdUser + "' AND password = MD5('" + old_password + "')";
            int iMod = conn.iDeleteOrUpdate(sQuery);

            if (iMod > 0)
                return true;
            else
                return false;
        }

        public bool bSave()
        {
            mySqlConn conn = new mySqlConn();
            conn.connect();

            if (this.IId_user == -1)
            {
                string sQuery = "insert into users (id_user, login, password, profile, active) " +
                "values (NULL, '" + this.SLogin + "', MD5('" + this.SPassword +
                "'), '" + this.SProfile + "', '" + ((this.BActive) ? "1" : "0") + "')";

                this.iId_user = conn.iInsert(sQuery);

                if (this.iId_user > 0)
                    return true;
            }
            else
            {
                string sQuery = "UPDATE users SET login = '" + this.SLogin + "', active = '" + ((this.BActive) ? "1" : "0") + "' "+
                                "WHERE id_user = '" + this.IId_user + "'";

                int iMod = conn.iDeleteOrUpdate(sQuery);

                if (iMod > 0)
                    return true;
            }
            return false;
        }
        public bool bDelete()
        {
            mySqlConn conn = new mySqlConn();
            conn.connect();
            string sQuery = "DELETE FROM users WHERE id_user = '" + this.IId_user + "'";
            int iRes = conn.iDeleteOrUpdate(sQuery);
            if (iRes > 0)
                return true;
            return false;
        }
    }
}
