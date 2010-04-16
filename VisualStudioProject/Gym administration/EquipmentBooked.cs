using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Windows.Forms;

namespace Gym_administration
{

    /**
     * @desc It holds data and modifying methods for the EQUIPMENT_BOOKINGS table. 
     * Most closely associated forms are frm_member, frm_staff, frm_class.
     * Most closely associated table is EQUIPMENT_BOOKINGS.
     * @params [none] Incoming parameters are described at the individual constructors.
     * @return [none] No directly returned data. 
     * Returns of public methods are described at the individual methods.
     */
    class EquipmentBooked
    {


        // A field with the same name from EQUIPMENT_BOOKINGS table
        private int id_eq_booking;
        public int Id_eq_booking
        {
            get { return id_eq_booking; }
            set { id_eq_booking = value; }
        }

        // A field with the same name from EQUIPMENT_BOOKINGS table
        private string id_member;
        public string Id_member
        {
            get { return id_member; }
            set { id_member = value; }
        }

        // A field with the same name from EQUIPMENT_BOOKINGS table
        private string id_staff;
        public string Id_staff
        {
            get { return id_staff; }
            set { id_staff = value; }
        }

        // A field with the same name from EQUIPMENT_BOOKINGS table
        private string id_class_instance;
        public string Id_class_instance
        {
            get { return id_class_instance; }
            set { id_class_instance = value; }
        }

        // A field with the same name from EQUIPMENT_BOOKINGS table
        private string dateStart;
        public string DateStart
        {
            get { return dateStart; }
            set { dateStart = value; }
        }

        // A field with the same name from EQUIPMENT_BOOKINGS table
        private string dateDue;
        public string DateDue
        {
            get { return dateDue; }
            set { dateDue = value; }
        }

        // A field with the same name from EQUIPMENT_BOOKINGS table
        private int id_equipment;
        public int Id_equipment
        {
            get { return id_equipment; }
            set { id_equipment = value; }
        }

        // A field with the same name from EQUIPMENT_BOOKINGS table
        private int borrowedAmount;
        public int BorrowedAmount
        {
            get { return borrowedAmount; }
            set { borrowedAmount = value; }
        }

        // A field with the same name from EQUIPMENT_BOOKINGS table
        private bool isReturned;
        public bool IsReturned
        {
            get { return isReturned; }
            set { isReturned = value; }
        }


        /**
         * @desc Default constructor.
         * Sets id_eq_booking to -1 so the fact of this is a new equipment booking can be referenced.
         * 
         * @params [none] No input parameter.
         * @return [none] No directly returned data.
         */         
        public EquipmentBooked()
        {

            this.id_eq_booking = -1;
        }


        /**
          * @desc Constructor
          * Loads in the id_eq_booking into its corresponding field to open up a placeholder to
          * fill with data to modify an existing booking
          * @params [int] id_Class identifies the class uniquely.
          * @return [none] No directly returned data.
          */
        public EquipmentBooked(int id_eq_booking)
        {
            this.Id_eq_booking = id_eq_booking;
        }



        /**
         * @desc This method will save or update an equipment booking in the EQUIPMENT_BOOKINGS table
         * @params [none] No input parameter.
         * @return [bool] Returns true in case of success, false if there was problem saving/updating the equipment
         */
        public bool SaveEquipmentBooking()
        {
            string query;
            // Create mysql connection
            mySqlConn conn = new mySqlConn();
            conn.connect();
            // Check whether there is a new id_eq_booking assigned to this booking, 
            // if not then this a new equipment booking to save
            if (this.Id_eq_booking == -1)
            {
                // Create the save query
                query = "insert into `gym`.`equipment_bookings` (`id_eq_booking`, `id_staff`, `id_member`, `id_class_instance`, `date_start`, `date_due`, `id_equipment`, `borrowedamount`,`isreturned`) values " +
                                     "(NULL, " + this.Id_staff + ", " + this.Id_member + ", " + this.Id_class_instance + ", '" + this.DateStart + "', '" + this.DateDue
                                     + "', " + this.Id_equipment + ", " + this.BorrowedAmount + ", NULL)";
                // Launch save query
                int id_eq_booking = conn.iInsert(query);
                // Check saving result
                if (id_eq_booking != -1)
                {
                    this.Id_eq_booking = id_eq_booking;
                    MessageBox.Show("The new equipment booking has been added to the databse succesfully!");
                    return true;
                }
                else
                {
                    MessageBox.Show("There was a problem adding the new equipment booking, please check your data!");
                    return false;
                }
            }
            // If an id_eq_booking already exists for this booking, then this is an existing booking to update
            else
            {
                // Create update query
                query = "UPDATE `gym`.`equipment_bookings` SET `borrowedamount` = " + this.BorrowedAmount + ", `isreturned`= " + this.IsReturned + " WHERE id_eq_booking = '" + this.Id_eq_booking + "'";
                // Launch update query
                int result = conn.iDeleteOrUpdate(query);
                // Check update result
                if (result > 0)
                {
                    MessageBox.Show("The equipment booking data has been updated succesfully!");
                    return true;
                }
                else
                {
                    MessageBox.Show("There was a problem updating the equipment booking information, please check your data!");
                    return false;
                }

            }
            //return true;
        }
    }
}
