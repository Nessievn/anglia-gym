using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Gym_administration
{
    class Member : Person
    {
        private int iId_member;

        public int IId_member
        {
            get { return iId_member; }
        }
        private string sMemberNumber;

        public string SMemberNumber
        {
            get { return sMemberNumber; }
            set { sMemberNumber = value; }
        }
    
        private string sType;

        public string SType
        {
            get { return sType; }
            set { sType = value; }
        }
        private string sPayment_method;

        public string SPayment_method
        {
            get { return sPayment_method; }
            set { sPayment_method = value; }
        }
        private string sId_user;

        public string SId_user
        {
            get { return sId_user; }
            set { sId_user = value; }
        }
        private bool bIs_active;

        public bool BIs_active
        {
            get { return bIs_active; }
            set { bIs_active = value; }
        }
        private string sEmerg_contact_name;

        public string SEmerg_contact_name
        {
            get { return sEmerg_contact_name; }
            set { sEmerg_contact_name = value; }
        }
        private string sEmerg_contact_relation;

        public string SEmerg_contact_relation
        {
            get { return sEmerg_contact_relation; }
            set { sEmerg_contact_relation = value; }
        }
        private string sEmerg_contact_phone;

        public string SEmerg_contact_phone
        {
            get { return sEmerg_contact_phone; }
            set { sEmerg_contact_phone = value; }
        }
        private string sEmerg_contact_mobile;

        public string SEmerg_contact_mobile
        {
            get { return sEmerg_contact_mobile; }
            set { sEmerg_contact_mobile = value; }
        }
        private string sMedical_allergies;

        public string SMedical_allergies
        {
            get { return sMedical_allergies; }
            set { sMedical_allergies = value; }
        }
        private string sMedical_notes;

        public string SMedical_notes
        {
            get { return sMedical_notes; }
            set { sMedical_notes = value; }
        }
        private string sPicture;

        public string SPicture
        {
            get { return sPicture; }
            set { sPicture = value; }
        }
        private string sMedical_doctor_name;

        public string SMedical_doctor_name
        {
            get { return sMedical_doctor_name; }
            set { sMedical_doctor_name = value; }
        }
        private string sMedical_phone;

        public string SMedical_phone
        {
            get { return sMedical_phone; }
            set { sMedical_phone = value; }
        }
        private User usrUser;

        internal User UUser
        {
            get { return usrUser; }
            set { usrUser = value; }
        }

        /*
         * This method will save the object into the database
         */
        public bool bSave()
        {
            // Field checking
            string sMysqlDate = Utils.sGetMysqlDate(this.SBirthdate);
            string sQuery;
            if (sMysqlDate != "0000-00-00")
            {
                this.usrUser = new User();
                // First the user object is filled
                usrUser.BActive = (this.BIs_active) ? true : false;
                usrUser.SLogin = this.SEmail;
                usrUser.SPassword = sMysqlDate;
                usrUser.SProfile = "member";

                // then the bSave method is called
                if (usrUser.bSave())
                {
                    mySqlConn conn = new mySqlConn();
                    conn.connect();
                    sQuery = "insert into `gym`.`members` (`id_member`, `firstName`, `lastName`, `birthdate`, `address_1`, `city`, `county`, `postalcode`, `type`, `payment_method`, `id_user`, `is_active`, `address_2`, `emerg_contact_name`, `emerg_contact_relation`, `emerg_contact_phone`, `emerg_contact_mobile`, `medical_allergies`, `medical_notes`, `picture`, `medical_doctor_name`, `medical_phone`, `email`) values "+
                             "(NULL, '" + this.SFirstName + "', '" + this.SLastName + "', '" + sMysqlDate + "', '" + this.SAddress_1 + "', '" + this.SCity + "', '" + this.SCounty + "', '" + this.SPostalcode + "', '" + this.SType + "', '" + this.SPayment_method + "', '" + usrUser.IId_user + "', '" + ((this.BIs_active) ? "1" : "0") + "', '" + this.SAaddress_2 + "', '" + this.SEmerg_contact_name + "', '" + this.SEmerg_contact_relation + "', '" + this.SEmerg_contact_phone + "', '" + this.SEmerg_contact_mobile + "', '" + this.SMedical_allergies + "', '" + this.SMedical_notes + "', NULL, '" + this.SMedical_doctor_name + "', '" + this.SMedical_phone + "', '" + this.SEmail + "')";
       
                    int iMbrId = conn.iInsert(sQuery);
                    if (iMbrId > 1)
                    {
                        MessageBox.Show("The new member has been added to the databse succesfully!");
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("There was a problem adding the new user, please check your data!");
                        usrUser.bDelete();
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("The e-mail already exists in the database!, please choose another one.");
                    return false;
                }

            }
             return true;
        }
    }
}
