using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace Gym_administration
{
    class Member : Person
    {
        private int iId_member;

        public int IId_member
        {
            get { return iId_member; }
            set { iId_member = value; }
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
        public Member()
        {
        }

        public Member(int iMemberId)
        {
            mySqlConn conn = new mySqlConn();
            conn.connect();
            // We launch the query
            List<Hashtable> lhResultset = conn.lhSqlQuery("Select u.id_user, login, password, profile, active, id_member, firstName, lastName, birthdate, address_1, city, county, postalcode, type, payment_method, is_active, address_2, emerg_contact_name, emerg_contact_relation, emerg_contact_phone, emerg_contact_mobile, medical_allergies, medical_notes, picture, medical_doctor_name, medical_phone, email, member_number from members m, users u where u.id_user = m.id_user AND m.id_member = '" + iMemberId + "'");

            // Check if we found the member
            if ((int)lhResultset.Count > 0)
            {
                this.BIs_active = (lhResultset[0]["is_active"].ToString() == "True") ? true : false;
                this.IId_member = int.Parse(lhResultset[0]["id_member"].ToString());
                this.SAaddress_2 = lhResultset[0]["address_2"].ToString();
                this.SAddress_1 = lhResultset[0]["address_1"].ToString();
                this.SBirthdate = lhResultset[0]["birthdate"].ToString();
                this.SCity = lhResultset[0]["city"].ToString();
                this.SCounty = lhResultset[0]["county"].ToString();
                this.SEmail = lhResultset[0]["email"].ToString();
                this.SEmerg_contact_mobile = lhResultset[0]["emerg_contact_mobile"].ToString();
                this.SEmerg_contact_name = lhResultset[0]["emerg_contact_name"].ToString();
                this.SEmerg_contact_phone = lhResultset[0]["emerg_contact_phone"].ToString();
                this.SEmerg_contact_relation = lhResultset[0]["emerg_contact_relation"].ToString();
                this.SFirstName = lhResultset[0]["firstName"].ToString();
                this.SLastName = lhResultset[0]["lastName"].ToString();
                this.SMedical_allergies = lhResultset[0]["medical_allergies"].ToString();
                this.SMedical_doctor_name = lhResultset[0]["medical_doctor_name"].ToString();
                this.SMedical_notes = lhResultset[0]["medical_notes"].ToString();
                this.SMedical_phone = lhResultset[0]["medical_phone"].ToString();
                this.SMemberNumber = lhResultset[0]["member_number"].ToString();
                this.SPayment_method = lhResultset[0]["payment_method"].ToString();
                this.SPicture = lhResultset[0]["picture"].ToString();
                this.SPostalcode = lhResultset[0]["postalcode"].ToString();
                this.SType = lhResultset[0]["type"].ToString();
                this.usrUser = new User();
                this.usrUser.IId_user = int.Parse(lhResultset[0]["id_user"].ToString());
                this.usrUser.SLogin = lhResultset[0]["login"].ToString();
                this.usrUser.SPassword = lhResultset[0]["password"].ToString();
                this.usrUser.SProfile = lhResultset[0]["profile"].ToString();
            }
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
