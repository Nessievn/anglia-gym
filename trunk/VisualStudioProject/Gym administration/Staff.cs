using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;


namespace Gym_administration
{


    /**
     * @desc It holds data and modifying methods for the STAFF table. 
     * Most closely associated form is frm_staff.
     * Most closely associated table is STAFF.
     * @params [none] Incoming parameters are described at the individual constructors.
     * @return [none] No directly returned data. 
     * Returns of public methods are described at the individual methods.
     */
    class Staff : Person
    {

        // A field from the STAFF table
        private int id_staff;
        public int Id_staff
        {
            get { return id_staff; }
            set { id_staff = value; }
        }

        // A field from the STAFF table
        private string position;
        public string Position
        {
            get { return position; }
            set { position = value; }
        }

        // A field from the STAFF table
        private string contractType;
        public string ContractType
        {
            get { return contractType; }
            set { contractType = value; }
        }

        // A field from the STAFF table
        private string emergContactName;
        public string EmergContactName
        {
            get { return emergContactName; }
            set { emergContactName = value; }
        }

        // A field from the STAFF table
        private string emergContactRelation;
        public string EmergContactRelation
        {
            get { return emergContactRelation; }
            set { emergContactRelation = value; }
        }

        // A field from the STAFF table
        private string emergContactPhone;
        public string EmergContactPhone
        {
            get { return emergContactPhone; }
            set { emergContactPhone = value; }
        }

        // A field from the STAFF table
        private string emergContactMobile;
        public string EmergContactMobile
        {
            get { return emergContactMobile; }
            set { emergContactMobile = value; }
        }

        // A field from the STAFF table
        private string medicalAllergies;
        public string MedicalAllergies
        {
            get { return medicalAllergies; }
            set { medicalAllergies = value; }
        }

        // A field from the STAFF table
        private string medicalNotes;
        public string MedicalNotes
        {
            get { return medicalNotes; }
            set { medicalNotes = value; }
        }

        // A field from the STAFF table
        private string qualifications;
        public string Qualifications
        {
            get { return qualifications; }
            set { qualifications = value; }
        }

        // A field from the STAFF table
        private string picture;
        public string Picture
        {
            get { return picture; }
            set { picture = value; }
        }

        // A field from the STAFF table
        private string medicalDoctorName;
        public string MedicalDoctorName
        {
            get { return medicalDoctorName; }
            set { medicalDoctorName = value; }
        }

        // A field from the STAFF table
        private string medicalPhone;
        public string MedicalPhone
        {
            get { return medicalPhone; }
            set { medicalPhone = value; }
        }

        // a User (User.cs) object is stored here
        private User clUser;
        internal User ClUser
        {
            get { return clUser; }
            set { clUser = value; }
        }

        // A field from the STAFF table
        private string natInsNumb;
        public string NatInsNumb
        {
            get { return natInsNumb; }
            set { natInsNumb = value; }
        }

        // A field from the STAFF table
        private string sContractStart;
        public string SContractStart
        {
            get { return sContractStart; }
            set { sContractStart = value; }
        }

        // A field from the STAFF table
        private string sContractFinish;
        public string SContractFinish
        {
            get { return sContractFinish; }
            set { sContractFinish = value; }
        }


        /**
         * @desc Default constructor.
         * Sets id_staff to -1 so the fact of this is a new staff can be referenced.
         * Creates a new user parent class instance.
         * @params [none] No input parameter.
         * @return [none] No directly returned data.
         */
        public Staff()
        {
            this.Id_staff = -1;
            this.clUser = new User();
        }


        /**
         * @desc Constructor
         * Loads in all fields from a single row of the Staff table.
         * @params [int] id_staff identifies the staff uniquely.
         * @return [none] No directly returned data.
         */
        public Staff(int id_staff)
        {
            // Create mysql connection
            mySqlConn conn = new mySqlConn();
            conn.connect();
            // Launch the query to return all fields from a single row of the STAFF table
            List<Hashtable> lhResultset = conn.lhSqlQuery("Select * from staff s, users u where u.id_user = s.id_user AND s.id_staff = '" + id_staff + "'");

            // Check if we found the staff
            if ((int)lhResultset.Count > 0)
            {
                // Fill in all staff and parent user fields with table data
                this.clUser = new User();
                this.clUser.Id_user = int.Parse(lhResultset[0]["id_user"].ToString());
                this.clUser.Login = lhResultset[0]["login"].ToString();
                this.clUser.Password = lhResultset[0]["password"].ToString();
                this.clUser.Profile = lhResultset[0]["profile"].ToString();
                this.Id_staff = int.Parse(lhResultset[0]["id_staff"].ToString());
                this.Address_2 = lhResultset[0]["address_2"].ToString();
                this.Address_1 = lhResultset[0]["address_1"].ToString();
                this.Birthdate = lhResultset[0]["birthdate"].ToString();
                this.City = lhResultset[0]["city"].ToString();
                this.County = lhResultset[0]["county"].ToString();
                this.Email = lhResultset[0]["email"].ToString();
                this.EmergContactName = lhResultset[0]["emerg_contact_name"].ToString();
                this.EmergContactPhone = lhResultset[0]["emerg_contact_telephone"].ToString();
                this.EmergContactRelation = lhResultset[0]["emerg_contact_relation"].ToString();
                this.EmergContactMobile = lhResultset[0]["emerg_contact_mobile"].ToString();
                this.FirstName = lhResultset[0]["firstName"].ToString();
                this.LastName = lhResultset[0]["lastName"].ToString();
                this.MedicalAllergies = lhResultset[0]["allergies"].ToString();
                this.MedicalDoctorName = lhResultset[0]["medical_doctor_name"].ToString();
                this.MedicalNotes = lhResultset[0]["medicalNotes"].ToString();
                this.Qualifications = lhResultset[0]["qualifications"].ToString();
                this.MedicalPhone = lhResultset[0]["medical_phone"].ToString();
                this.Picture = "none";
                this.PostalCode = lhResultset[0]["postalcode"].ToString();
                this.ContractType = lhResultset[0]["contract_type"].ToString();
                this.Mobile = lhResultset[0]["mobile"].ToString();
                this.Phone = lhResultset[0]["phone"].ToString();
                this.Position = lhResultset[0]["position"].ToString();
                this.NatInsNumb = lhResultset[0]["natinsnumber"].ToString();
                this.SContractFinish = lhResultset[0]["contract_finish"].ToString();
                this.SContractStart = lhResultset[0]["contract_start"].ToString();
            }
        }


        /**
         * @desc This method will save the object into the database
         * @return [bool] Returns true in case of success, false if there was a problem
         */
         public bool SaveStaff()
        {
            string query;

            // Convert dates into mysql format
            string sMysqlDate = Utils.sGetMysqlDate(this.Birthdate);
            string sMysqlStartDate = Utils.sGetMysqlDate(this.SContractStart);
            string sMysqlFinishDate = Utils.sGetMysqlDate(this.SContractFinish);

	    // Check user input format
            if (sMysqlDate == "0000-00-00") 
                MessageBox.Show("The Date of Birth is in incorrect format!");
            else if (sMysqlStartDate == "0000-00-00")
                MessageBox.Show("The Contract Start date is in incorrect format!");
            else if (sMysqlFinishDate == "0000-00-00")
                MessageBox.Show("The Contract Finish date is in incorrect format!");
            else if (Utils.bValidateEmail(this.Email) == false)
                MessageBox.Show("The E-Mail address is incorrect");
            else
            {
                // First the user object is filled
                clUser.Login = this.Email;
                clUser.Password = this.Birthdate;
                clUser.Profile = "staff";
                clUser.IsActive = true;

                if (clUser.SaveUser())
                {
	            // Create mysql connection
                    mySqlConn conn = new mySqlConn();
                    conn.connect();

		    // If this is a new staff
                    if (Id_staff == -1)
                    {
			// Create insert query 
                        query = "insert into `gym`.`staff` (`id_staff`, `firstName`, `lastName`, `birthdate`, `address_1`, `city`, `county`, `postalcode`, `contract_type`, `natinsnumber`, `position`, `contract_start`, `contract_finish`, `id_user`, `address_2`, `emerg_contact_name`, `emerg_contact_telephone`, `emerg_contact_relation`, `allergies`, `medicalNotes`, `qualifications`, `phone`, `mobile`, `email`, `emerg_contact_mobile`, `medical_doctor_name`, `medical_phone`) values " +
                                 "(NULL, '" + this.FirstName + "', '" + this.LastName + "', '" + sMysqlDate + "', '" + this.Address_1 + "', '" + this.City + "', '" + this.County + "', '" + this.PostalCode + "', '" + this.ContractType + "', '" + this.NatInsNumb + "', '" + this.Position + "', '" + sMysqlStartDate + "', '" + sMysqlFinishDate + "', '" + clUser.Id_user + "', '" + this.Address_2 + "', '" + this.EmergContactName + "', '" + this.EmergContactPhone + "', '" + this.EmergContactRelation + "', '" + this.MedicalAllergies + "', '" + this.MedicalNotes + "','" + this.Qualifications + "', '" + this.Phone + "','" + this.Mobile + "','" + this.Email + "','" + this.EmergContactMobile + "','" + this.MedicalDoctorName + "','" + this.MedicalPhone + "')";
                        // Launch insert query
                        int id_staff = conn.InsertToDB(query);
                        // Check if the insert was successful
                        if (id_staff != -1)
                        {
                            Id_staff = id_staff;
                            MessageBox.Show("The new staff member has been added to the databse succesfully!");
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("There was a problem adding the new user, please check your data!");
                            clUser.DeleteUser();
                            return false;
                        }
                    }
                    // This is a staff update
                    else
                    {
                        // Create update query
                        query = "UPDATE staff SET firstName = '" + this.FirstName + "', lastName = '" + this.LastName + "', birthdate = '" + sMysqlDate + "', address_1 = '" + this.Address_1 + "', city = '" + this.City + "', county = '" + this.County + "', postalcode = '" + this.PostalCode + "', contract_type = '" + this.ContractType + "', contract_start = '" + sMysqlStartDate + "', contract_finish = '" + sMysqlFinishDate + "', address_2 = '" + this.Address_2 + "', emerg_contact_name = '" + this.EmergContactName + "', emerg_contact_relation = '" + this.EmergContactRelation + "', emerg_contact_telephone = '" + this.EmergContactPhone + "', emerg_contact_mobile = '" + this.EmergContactMobile + "', allergies = '" + this.MedicalAllergies + "', medicalNotes = '" + this.MedicalNotes + "', qualifications = '" + this.Qualifications + "', medical_doctor_name = '" + this.MedicalDoctorName + "', medical_phone = '" + this.MedicalPhone + "', email = '" + this.Email + "', phone = '" + this.Phone + "', mobile = '" + this.Mobile + "', natinsnumber = '" + this.NatInsNumb + "', position = '" + this.Position + "' " +
                                 " WHERE id_staff = '"+this.id_staff+"'";
                        // Launch update query     
                        int result = conn.DeleteOrUpdate(query);
                        // Check if the update was successful
                        if (result > 0)
                        {
                            MessageBox.Show("The staff data has been updated succesfully!");
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
                // If the user saving was false, then it was becuase of duplicate e-mail at this point
                else
                {
                    MessageBox.Show("The e-mail already exists in the database!, please choose another one.");
                    return false;
                }
            }
            return false;
        }
    }
}

