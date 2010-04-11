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
        private int id_member;

        public int Id_member
        {
            get { return id_member; }
            set { id_member = value; }
        }
        private string memberNumber;

        public string MemberNumber
        {
            get { return memberNumber; }
            set { memberNumber = value; }
        }
    
        private string type;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        private string paymentMethod;

        public string PaymentMethod
        {
            get { return paymentMethod; }
            set { paymentMethod = value; }
        }
       
        private bool isActive;

        public bool IsActive
        {
            get { return isActive; }
            set { isActive = value; }
        }
        private string emergContactName;

        public string EmergContactName
        {
            get { return emergContactName; }
            set { emergContactName = value; }
        }
        private string emergContactRelation;

        public string EmergContactRelation
        {
            get { return emergContactRelation; }
            set { emergContactRelation = value; }
        }
        private string emergContactPhone;

        public string EmergContactPhone
        {
            get { return emergContactPhone; }
            set { emergContactPhone = value; }
        }
        private string emergContactMobile;

        public string EmergContactMobile
        {
            get { return emergContactMobile; }
            set { emergContactMobile = value; }
        }
        private string medicalAllergies;

        public string MedicalAllergies
        {
            get { return medicalAllergies; }
            set { medicalAllergies = value; }
        }
        private string medicalNotes;

        public string MedicalNotes
        {
            get { return medicalNotes; }
            set { medicalNotes = value; }
        }
        private string picture;

        public string Picture
        {
            get { return picture; }
            set { picture = value; }
        }
        private string medicalDoctorName;

        public string MedicalDoctorName
        {
            get { return medicalDoctorName; }
            set { medicalDoctorName = value; }
        }
        private string medicalPhone;

        public string MedicalPhone
        {
            get { return medicalPhone; }
            set { medicalPhone = value; }
        }
        private User clUser;

        internal User ClUser
        {
            get { return clUser; }
            set { clUser = value; }
        }
        public Member()
        {
            this.id_member = 0;
            this.clUser = new User();
        }

        public bool bAddPayment(Decimal dAmount, string sDate, string sDesc)
        {
            if (this.Id_member != -1)
            {
                Payment p = new Payment();
                p.Amount = dAmount;
                p.Date = sDate;
                p.ClMember = this;
                p.Details = sDesc;
                if (p.bSave())
                    return true;
                else
                    return false;
            }
            else
                return false;

        }

        public Member(int id_member)
        {
            mySqlConn conn = new mySqlConn();
            conn.connect();
            // We launch the query
            List<Hashtable> lhResultset = conn.lhSqlQuery("Select * from members m, users u where u.id_user = m.id_user AND m.id_member = '" + id_member + "'");

            // Check if we found the member
            if ((int)lhResultset.Count > 0)
            {
                this.clUser = new User();
                this.clUser.Id_user = int.Parse(lhResultset[0]["id_user"].ToString());
                this.clUser.Login = lhResultset[0]["login"].ToString();
                this.clUser.Password = lhResultset[0]["password"].ToString();
                this.clUser.Profile = lhResultset[0]["profile"].ToString();
                this.IsActive = (lhResultset[0]["is_active"].ToString() == "True") ? true : false;
                this.Id_member = int.Parse(lhResultset[0]["id_member"].ToString());
                this.Address_2 = lhResultset[0]["address_2"].ToString();
                this.Address_1 = lhResultset[0]["address_1"].ToString();
                this.Birthdate = lhResultset[0]["birthdate"].ToString();
                this.City = lhResultset[0]["city"].ToString();
                this.County = lhResultset[0]["county"].ToString();
                this.Email = lhResultset[0]["email"].ToString();
                this.EmergContactMobile = lhResultset[0]["emerg_contact_mobile"].ToString();
                this.EmergContactName = lhResultset[0]["emerg_contact_name"].ToString();
                this.EmergContactPhone = lhResultset[0]["emerg_contact_phone"].ToString();
                this.EmergContactRelation = lhResultset[0]["emerg_contact_relation"].ToString();
                this.FirstName = lhResultset[0]["firstName"].ToString();
                this.LastName = lhResultset[0]["lastName"].ToString();
                this.MedicalAllergies = lhResultset[0]["medical_allergies"].ToString();
                this.MedicalDoctorName = lhResultset[0]["medical_doctor_name"].ToString();
                this.MedicalNotes = lhResultset[0]["medical_notes"].ToString();
                this.MedicalPhone = lhResultset[0]["medical_phone"].ToString();
                this.MemberNumber = lhResultset[0]["member_number"].ToString();
                this.PaymentMethod = lhResultset[0]["payment_method"].ToString();
                this.Picture = lhResultset[0]["picture"].ToString();
                this.PostalCode = lhResultset[0]["postalcode"].ToString();
                this.Type = lhResultset[0]["type"].ToString();
                this.Mobile = lhResultset[0]["mobile"].ToString();
                this.Phone = lhResultset[0]["phone"].ToString();
            }
        }

        /**
         * @desc This method will save the object into the database
         */
        public bool bSave()
        {
            // Field checking
            string sMysqlDate = Utils.sGetMysqlDate(this.Birthdate);
            string sQuery;

            if (sMysqlDate == "0000-00-00")
            {
                MessageBox.Show("The birth date is in incorrect format");
            }
            else if (Utils.bValidateEmail(this.Email) == false)
            {
                MessageBox.Show("The E-Mail address is incorrect");
            }
            else
            {
                // First the user object is filled
                clUser.IsActive = (this.IsActive) ? true : false;
                clUser.Login = this.Email;
                clUser.Password = sMysqlDate;
                clUser.Profile = "member";

                // then the bSave method is called
                if (clUser.bSave())
                {
                    mySqlConn conn = new mySqlConn();
                    conn.connect();
                    if (this.Id_member == 0)
                    {
                        sQuery = "insert into `gym`.`members` (`id_member`, `firstName`, `lastName`, `birthdate`, `address_1`, `city`, `county`, `postalcode`, `type`, `payment_method`, `id_user`, `is_active`, `address_2`, `emerg_contact_name`, `emerg_contact_relation`, `emerg_contact_phone`, `emerg_contact_mobile`, `medical_allergies`, `medical_notes`, `picture`, `medical_doctor_name`, `medical_phone`, `email`, `member_number`, `phone`,`mobile`) values " +
                                 "(NULL, '" + this.FirstName + "', '" + this.LastName + "', '" + sMysqlDate + "', '" + this.Address_1 + "', '" + this.City + "', '" + this.County + "', '" + this.PostalCode + "', '" + this.Type + "', '" + this.PaymentMethod + "', '" + clUser.Id_user + "', '" + ((this.IsActive) ? "1" : "0") + "', '" + this.Address_2 + "', '" + this.EmergContactName + "', '" + this.EmergContactRelation + "', '" + this.EmergContactPhone + "', '" + this.EmergContactMobile + "', '" + this.MedicalAllergies + "', '" + this.MedicalNotes + "', NULL, '" + this.MedicalDoctorName + "', '" + this.MedicalPhone + "', '" + this.Email + "', '" + this.MemberNumber + "','"+this.Phone+"','"+this.Mobile+"')";

                        int iMbrId = conn.iInsert(sQuery);
                        if (iMbrId != -1)
                        {
                            this.Id_member = iMbrId;
                            MessageBox.Show("The new member has been added to the databse succesfully!");
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("There was a problem adding the new user, please check your data!");
                            clUser.bDelete();
                            return false;
                        }
                    }
                    else
                    {
                        sQuery = "UPDATE members SET firstName = '" + this.FirstName + "', lastName = '" + this.LastName + "', birthdate = '" + sMysqlDate + "', address_1 = '"+this.Address_1+"', city = '"+this.City+"', county = '"+this.County+"', postalcode = '"+this.PostalCode+"', type = '"+this.Type+"', payment_method = '"+this.PaymentMethod+"', is_active = '"+((this.IsActive) ? "1" : "0")+"', address_2 = '"+this.Address_2+"', emerg_contact_name = '"+this.EmergContactName+"', emerg_contact_relation = '"+this.EmergContactRelation+"', emerg_contact_phone = '"+this.EmergContactPhone+"', emerg_contact_mobile = '"+this.EmergContactMobile+"', medical_allergies = '"+this.MedicalAllergies+"', medical_notes = '"+this.MedicalNotes+"', medical_doctor_name = '"+this.MedicalDoctorName+"', medical_phone = '"+this.MedicalPhone+"', email = '"+this.Email+"', phone = '"+this.Phone+"', mobile = '"+this.Mobile+"' " +
                                 " WHERE id_member = '"+this.Id_member+"'";
     
                        int iRes = conn.iDeleteOrUpdate(sQuery);
                        if (iRes > 0)
                        {
                            MessageBox.Show("The member data has been updated succesfully!");
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("There was a problem updating the user information, please check your data!");
                            clUser.bDelete();
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
        public bool bRemove()
        {
            if (this.Id_member != 0)
            {
                this.IsActive = false;
                this.bSave();
            }
            return true;
                
        }
    }
}
