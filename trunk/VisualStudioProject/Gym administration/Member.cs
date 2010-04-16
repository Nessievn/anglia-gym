using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Drawing;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Data;
using System.IO;


namespace Gym_administration
{

    /**
     * @desc It holds data and modifying methods for the MEMBERS table. 
     * Most closely associated form is frm_member.
     * Most closely associated table is MEMBERS.
     * @params [none] Incoming parameters are described at the individual constructors.
     * @return [none] No directly returned data. 
     * Returns of public methods are described at the individual methods.
     */
    class Member : Person
    {

        // A field with the same name from MEMBERS table
        private int id_member;
        public int Id_member
        {
            get { return id_member; }
            set { id_member = value; }
        }

        // Field member_number from MEMBERS table
        private string memberNumber;
        public string MemberNumber
        {
            get { return memberNumber; }
            set { memberNumber = value; }
        }
        
        // Field member_number from MEMBERS table
        private string sid;
        public string Sid
        {
            get { return sid; }
            set { sid = value; }
        }
        
        // Field member_number from MEMBERS table
        private string studCardNumber;
        public string StudCardNumber
        {
            get { return studCardNumber; }
            set { studCardNumber = value; }
        }

        // Field type from MEMBERS table
        private string type;
        public string Type
        {
            get { return type; }
            set { type = value; }
        }



        // Field is_active from MEMBERS table
        private bool isActive;
        public bool IsActive
        {
            get { return isActive; }
            set { isActive = value; }
        }

        // Field emerg_contact_name from MEMBERS table
        private string emergContactName;
        public string EmergContactName
        {
            get { return emergContactName; }
            set { emergContactName = value; }
        }

        // Field emerg_contact_relation from MEMBERS table
        private string emergContactRelation;
        public string EmergContactRelation
        {
            get { return emergContactRelation; }
            set { emergContactRelation = value; }
        }

        // Field emerg_contact_phone from MEMBERS table
        private string emergContactPhone;
        public string EmergContactPhone
        {
            get { return emergContactPhone; }
            set { emergContactPhone = value; }
        }

        // Field emerg_contact_mobile from MEMBERS table
        private string emergContactMobile;
        public string EmergContactMobile
        {
            get { return emergContactMobile; }
            set { emergContactMobile = value; }
        }

        // Field medical_allergies from MEMBERS table
        private string medicalAllergies;
        public string MedicalAllergies
        {
            get { return medicalAllergies; }
            set { medicalAllergies = value; }
        }

        // Field medical_notes from MEMBERS table
        private string medicalNotes;
        public string MedicalNotes
        {
            get { return medicalNotes; }
            set { medicalNotes = value; }
        }


        // Field id_file from MEMBERS and FILE tabe for referencing from FILE table
        private string id_file;
        public string Id_file
        {
            get { return id_file; }
            set { id_file = value; }
        }

        // Field file_name from FILE table
        private string fileName;
        public string FileName
        {
            get { return fileName; }
            set { fileName = value; }
        }

        // Variable for storing file path
        private string filePath;
        public string FilePath
        {
            get { return filePath; }
            set { filePath = value; }
        }

        // Field medical_doctor_name from MEMBERS table
        private string medicalDoctorName;
        public string MedicalDoctorName
        {
            get { return medicalDoctorName; }
            set { medicalDoctorName = value; }
        }

        // Field medical_phone from MEMBERS table
        private string medicalPhone;
        public string MedicalPhone
        {
            get { return medicalPhone; }
            set { medicalPhone = value; }
        }        
        
        // Field ismale from MEMBERS table
        private string gender;
        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        // a User (User.cs) object is stored here
        private User clUser;
        internal User ClUser
        {
            get { return clUser; }
            set { clUser = value; }
        }

        /**
         * @desc Default constructor.
         * Sets id_member to -1 so the fact of this is a new member can be referenced.
         * Cretaes a new user parent class instance.
         * @params [none] No input parameter.
         * @return [none] No directly returned data.
         */
        public Member()
        {
            this.id_member = -1;
            this.clUser = new User();
        }


        /**
         * @desc Constructor
         * Loads in all fields from a single row of the MEMBERS table.
         * @params [int] id_Class identifies the class uniquely.
         * @return [none] No directly returned data.
         */
        public Member(int id_member)
        {
            // Create mysql connection
            mySqlConn conn = new mySqlConn();
            conn.connect();
           
            // Launch the query to return all fields from a single row of the MEMBERS table
            List<Hashtable> lhResultset = conn.lhSqlQuery("Select * from members m, users u where u.id_user = m.id_user AND m.id_member = '" + id_member + "'");
            // Check if we found the member
            if ((int)lhResultset.Count > 0)
            {
                // Fill in all class and parent class fields with table data
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
                this.Id_file = lhResultset[0]["id_file"].ToString();
                this.PostalCode = lhResultset[0]["postalcode"].ToString();
                this.Type = lhResultset[0]["type"].ToString();
                this.Mobile = lhResultset[0]["mobile"].ToString();
                this.Phone = lhResultset[0]["phone"].ToString();
                this.Sid = lhResultset[0]["sid"].ToString();
                this.StudCardNumber = lhResultset[0]["studcardnumber"].ToString();
                this.Gender = lhResultset[0]["gender"].ToString();
            }
        }

        /**
         * @desc Creates a new payment for the opened member
         * @params [decimal] amount: the amount payed
         * @params [string] date: the date of the payment
         * @params [desc] desc: comments
         * @return [bool] Returns true in case of success, false if there was a problem
         */
        public bool AddPayment(Decimal amount, string date, string desc, string receiptNumber, string paymentMethod, string receivedBy)
        {
            if (this.Id_member != -1)
            {
                Payment clPayment = new Payment();
                clPayment.Amount = amount;
                clPayment.Date = date;
                clPayment.ClMember = this;
                clPayment.Details = desc;
                clPayment.ReceiptNumber = receiptNumber;
                clPayment.PaymentMethod = paymentMethod;
                clPayment.ReceivedBy = receivedBy;
                
                if (clPayment.bSave())
                    return true;
                else
                    return false;
            }
            else
                return false;

        }

        /**
         * @desc This method will save the object into the database
         */
        public bool SaveMember()
        {
            // Field checking
            string sMysqlDate = Utils.sGetMysqlDate(this.Birthdate);
            string sQuery;

            if (sMysqlDate == "0000-00-00")
            {
                MessageBox.Show("The Date of Birth is in incorrect format!");
            }
            else if (Utils.bValidateEmail(this.Email) == false)
            {
                MessageBox.Show("The E-Mail address is incorrect!");
            }
            else
            {
                // First the user object is filled
                clUser.IsActive = (this.IsActive) ? true : false;
                clUser.Login = this.Email;
                clUser.Password = sMysqlDate;
                clUser.Profile = "member";
                // then the bSave method is called
                mySqlConn conn = new mySqlConn();
                conn.connect();

                if (clUser.SaveUser())
                {
                    if ((this.FilePath != null) && (this.FilePath.Length > 1))
                    {
                        this.Id_file = conn.uploadFileToDB(this.FilePath, this.FileName);
                    }

                    if (this.Id_member == -1)
                    {
                        sQuery = "insert into `gym`.`members` (`id_member`, `firstName`, `lastName`, `birthdate`, `address_1`, `city`, `county`, `postalcode`, `type`, `id_user`, `is_active`, `address_2`, `emerg_contact_name`, `emerg_contact_relation`, `emerg_contact_phone`, `emerg_contact_mobile`, `medical_allergies`, `medical_notes`, `id_file`, `medical_doctor_name`, `medical_phone`, `email`, `member_number`, `phone`,`mobile`,`sid`,`studcardnumber`,`gender`) values " +
                                 "(NULL, '" + this.FirstName + "', '" + this.LastName + "', '" + sMysqlDate + "', '" + this.Address_1 + "', '" + this.City + "', '" + this.County + "', '" + this.PostalCode + "', '" + this.Type + "', '" + clUser.Id_user + "', '" + ((this.IsActive) ? "1" : "0") + "', '" + this.Address_2 + "', '" + this.EmergContactName + "', '" + this.EmergContactRelation + "', '" + this.EmergContactPhone + "', '" + this.EmergContactMobile + "', '" + this.MedicalAllergies + "', '" + this.MedicalNotes + "', '" + this.Id_file + "', '" + this.MedicalDoctorName + "', '" + this.MedicalPhone + "', '" + this.Email + "', '" + this.MemberNumber + "','" + this.Phone + "','" + this.Mobile + "','" + this.Sid + "','" + this.StudCardNumber + "','" + this.Gender + "')";

                        int id_member = conn.iInsert(sQuery);
                        if (id_member != -1)
                        {
                            this.Id_member = id_member;
                            MessageBox.Show("The new member has been added to the databse succesfully!");
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("There was a problem adding the new user, please check your data!");
                            clUser.DeleteUser();
                            return false;
                        }
                    }
                    else
                    {

                        sQuery = "UPDATE members SET firstName = '" + this.FirstName + "', lastName = '" + this.LastName + "', birthdate = '" + sMysqlDate + "', address_1 = '" + this.Address_1 + "', city = '" + this.City + "', county = '" + this.County + "', postalcode = '" + this.PostalCode + "', type = '" + this.Type + "', is_active = '" + ((this.IsActive) ? "1" : "0") + "', address_2 = '" + this.Address_2 + "', emerg_contact_name = '" + this.EmergContactName + "', emerg_contact_relation = '" + this.EmergContactRelation + "', emerg_contact_phone = '" + this.EmergContactPhone + "', emerg_contact_mobile = '" + this.EmergContactMobile + "', medical_allergies = '" + this.MedicalAllergies + "', medical_notes = '" + this.MedicalNotes + "', id_file = '" + this.Id_file + "', medical_doctor_name = '" + this.MedicalDoctorName + "', medical_phone = '" + this.MedicalPhone + "', email = '" + this.Email + "', phone = '" + this.Phone + "', mobile = '" + this.Mobile +
                            "', sid = '" + this.Sid + "', studcardnumber = '" + this.StudCardNumber + "', gender = '" + this.Gender + "' " + " WHERE id_member = '"+this.Id_member+"'";
     
                        int result = conn.iDeleteOrUpdate(sQuery);
                        if (result > 0)
                        {
                            MessageBox.Show("The member data has been updated succesfully!");
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("There was a problem updating the user information, please check your data!");
                            clUser.DeleteUser();
                            return false;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("The e-mail already exists in the database! Please choose another one.");
                    return false;
                }

            }
             return false;
        }

        public bool RemoveMember()
        {
            if (this.Id_member != 0)
            {
                this.IsActive = false;
                this.SaveMember();
            }
            return true;
                
        }


 



    }
}
