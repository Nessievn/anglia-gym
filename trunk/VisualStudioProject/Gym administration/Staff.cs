using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;


namespace Gym_administration
{
    class Staff : Person
    {
        private int iId_staff;

        public int IId_staff
        {
            get { return iId_staff; }
            set { iId_staff = value; }
        }

        private string sPosition;

        public string SPosition
        {
            get { return sPosition; }
            set { sPosition = value; }
        }

        private string sContractType;

        public string SContractType
        {
            get { return sContractType; }
            set { sContractType = value; }
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
        private string sQualifications;

        public string SQualifications
        {
            get { return sQualifications; }
            set { sQualifications = value; }
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

        private string sNatInsNumb;

        public string SNatInsNumb
        {
            get { return sNatInsNumb; }
            set { sNatInsNumb = value; }
        }

        private string sContractStart;

        public string SContractStart
        {
            get { return sContractStart; }
            set { sContractStart = value; }
        }
        private string sContractFinish;

        public string SContractFinish
        {
            get { return sContractFinish; }
            set { sContractFinish = value; }
        }

        public Staff()
        {
            this.iId_staff = 0;
            this.usrUser = new User();
        }

        public Staff(int iStaffId)
        {
            mySqlConn conn = new mySqlConn();
            conn.connect();
            // We launch the query
            List<Hashtable> lhResultset = conn.lhSqlQuery("Select * from staff s, users u where u.id_user = s.id_user AND s.id_staff = '" + iStaffId + "'");

            // Check if we found the staff
            if ((int)lhResultset.Count > 0)
            {
                this.usrUser = new User();
                this.usrUser.IId_user = int.Parse(lhResultset[0]["id_user"].ToString());
                this.usrUser.SLogin = lhResultset[0]["login"].ToString();
                this.usrUser.SPassword = lhResultset[0]["password"].ToString();
                this.usrUser.SProfile = lhResultset[0]["profile"].ToString();
                this.IId_staff = int.Parse(lhResultset[0]["id_staff"].ToString());
                this.SAaddress_2 = lhResultset[0]["address_2"].ToString();
                this.SAddress_1 = lhResultset[0]["address_1"].ToString();
                this.SBirthdate = lhResultset[0]["birthdate"].ToString();
                this.SCity = lhResultset[0]["city"].ToString();
                this.SCounty = lhResultset[0]["county"].ToString();
                this.SEmail = lhResultset[0]["email"].ToString();
                this.SEmerg_contact_name = lhResultset[0]["emerg_contact_name"].ToString();
                this.SEmerg_contact_phone = lhResultset[0]["emerg_contact_telephone"].ToString();
                this.SEmerg_contact_relation = lhResultset[0]["emerg_contact_relation"].ToString();
                this.SEmerg_contact_mobile = lhResultset[0]["emerg_contact_mobile"].ToString();
                this.SFirstName = lhResultset[0]["firstName"].ToString();
                this.SLastName = lhResultset[0]["lastName"].ToString();
                this.SMedical_allergies = lhResultset[0]["allergies"].ToString();
                this.SMedical_doctor_name = lhResultset[0]["medical_doctor_name"].ToString();
                this.SMedical_notes = lhResultset[0]["medicalNotes"].ToString();
                this.SQualifications = lhResultset[0]["qualifications"].ToString();
                this.SMedical_phone = lhResultset[0]["medical_phone"].ToString();
                this.SPicture = "none";
                this.SPostalcode = lhResultset[0]["postalcode"].ToString();
                this.sContractType = lhResultset[0]["contract_type"].ToString();
                this.SMobile = lhResultset[0]["mobile"].ToString();
                this.SPhone = lhResultset[0]["phone"].ToString();
                this.SPosition = lhResultset[0]["position"].ToString();
                this.SNatInsNumb = lhResultset[0]["natinsnumber"].ToString();
                this.SContractFinish = lhResultset[0]["contract_finish"].ToString();
                this.SContractStart = lhResultset[0]["contract_start"].ToString();
            }
        }

        /**
         * @desc This method will save the object into the database
         */
         public bool bSave()
        {
            // Field checking
            string sMysqlDate = Utils.sGetMysqlDate(this.SBirthdate);
            string sMysqlStartDate = Utils.sGetMysqlDate(this.SContractStart);
            string sMysqlFinishDate = Utils.sGetMysqlDate(this.SContractFinish);
            string sQuery;

            if (sMysqlDate == "0000-00-00" || sMysqlFinishDate == "0000-00-00" || sMysqlStartDate == "0000-00-00")
            {
                MessageBox.Show("The date is in incorrect format");
            }
            else if (Utils.bValidateEmail(this.SEmail) == false)
            {
                MessageBox.Show("The E-Mail address is incorrect");
            }
            else
            {
                // First the user object is filled
                usrUser.SLogin = this.SEmail;
                usrUser.SPassword = this.SBirthdate;
                usrUser.SProfile = "staff";
                usrUser.BActive = true;

                // then the bSave method is called
                if (usrUser.bSave())
                {
                    mySqlConn conn = new mySqlConn();
                    conn.connect();

                     if (this.IId_staff == 0)
                    {
                        sQuery = "insert into `gym`.`staff` (`id_staff`, `firstName`, `lastName`, `birthdate`, `address_1`, `city`, `county`, `postalcode`, `contract_type`, `natinsnumber`, `position`, `contract_start`, `contract_finish`, `id_user`, `address_2`, `emerg_contact_name`, `emerg_contact_telephone`, `emerg_contact_relation`, `allergies`, `medicalNotes`, `qualifications`, `phone`, `mobile`, `email`, `emerg_contact_mobile`, `medical_doctor_name`, `medical_phone`) values " +
                                 "(NULL, '" + this.SFirstName + "', '" + this.SLastName + "', '" + sMysqlDate + "', '" + this.SAddress_1 + "', '" + this.SCity + "', '" + this.SCounty + "', '" + this.SPostalcode + "', '" + this.SContractType + "', '" + this.SNatInsNumb + "', '" + this.SPosition + "', '" + sMysqlStartDate + "', '" + sMysqlFinishDate + "', '" + usrUser.IId_user + "', '" + this.SAaddress_2 + "', '" + this.SEmerg_contact_name + "', '" + this.SEmerg_contact_phone + "', '" + this.SEmerg_contact_relation + "', '" + this.SMedical_allergies + "', '" + this.SMedical_notes + "','" + this.SQualifications + "', '" + this.SPhone + "','" + this.SMobile + "','" + this.SEmail + "','" + this.SEmerg_contact_mobile + "','" + this.SMedical_doctor_name + "','" + this.SMedical_phone + "')";

                        int iMbrId = conn.iInsert(sQuery);
                        if (iMbrId > 1)
                        {
                            this.IId_staff = iMbrId;
                            MessageBox.Show("The new staff member has been added to the databse succesfully!");
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
                        sQuery = "UPDATE staff SET firstName = '" + this.SFirstName + "', lastName = '" + this.SLastName + "', birthdate = '" + sMysqlDate + "', address_1 = '" + this.SAddress_1 + "', city = '" + this.SCity + "', county = '" + this.SCounty + "', postalcode = '" + this.SPostalcode + "', contract_type = '" + this.SContractType + "', contract_start = '" + sMysqlStartDate + "', contract_finish = '" + sMysqlFinishDate + "', address_2 = '" + this.SAaddress_2 + "', emerg_contact_name = '" + this.SEmerg_contact_name + "', emerg_contact_relation = '" + this.SEmerg_contact_relation + "', emerg_contact_telephone = '" + this.SEmerg_contact_phone + "', emerg_contact_mobile = '" + this.SEmerg_contact_mobile + "', allergies = '" + this.SMedical_allergies + "', medicalNotes = '" + this.SMedical_notes + "', qualifications = '" + this.SQualifications + "', medical_doctor_name = '" + this.SMedical_doctor_name + "', medical_phone = '" + this.SMedical_phone + "', email = '" + this.SEmail + "', phone = '" + this.SPhone + "', mobile = '" + this.SMobile + "', natinsnumber = '" + this.SNatInsNumb + "', position = '" + this.SPosition + "' " +
                                 " WHERE id_staff = '"+this.IId_staff+"'";
     
                        int iRes = conn.iDeleteOrUpdate(sQuery);
                        if (iRes > 0)
                        {
                            MessageBox.Show("The staff data has been updated succesfully!");
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("There was a problem updating the user information, please check your data!");
                            usrUser.bDelete();
                            return false;
                        }
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
