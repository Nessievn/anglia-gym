using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
            this.IId_user = 0;
        }

        public bool bSave()
        {
            mySqlConn conn = new mySqlConn();
            conn.connect();

            if (this.IId_user == 0)
            {
                string sQuery = "insert into users (id_user, login, password, profile, active) " +
                "values (NULL, '" + this.SLogin + "', MD5('" + this.SPassword +
                "'), 'member', '" + ((this.BActive) ? "1" : "0") + "')";

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
