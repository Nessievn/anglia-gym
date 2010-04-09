using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Windows.Forms;

namespace Gym_administration
{
    class EquipmentBooked
    {

//DISPLAY/TEMP STORAGE
        private string sBookingType;
        //as BookingType
        public string SBookingType
        {
            get { return sBookingType; }
            set { sBookingType = value; }
        }

//TABLE
        private int id_eq_booking;
        //as BookingNr
        public int Id_eq_booking
        {
            get { return id_eq_booking; }
            set { id_eq_booking = value; }
        }


//TABLE
        private string id_member;
        //as MemberID
        public string Id_member
        {
            get { return id_member; }
            set { id_member = value; }
        }

//DISPLAY/TEMP STORAGE
        private string sMemberName;
        //as MemberName
        public string SMemberName
        {
            get { return sMemberName; }
            set { sMemberName = value; }
        }



//TABLE
        private string id_staff;
        //as StaffID
        public string Id_staff
        {
            get { return id_staff; }
            set { id_staff = value; }
        }

//DISPLAY/TEMP STORAGE 
        private string sStaffName;
        //as StaffName
        public string SStaffName
        {
            get { return sStaffName; }
            set { sStaffName = value; }
        }

//TABLE
        private string id_class_instance;
        //as ClassInstance
        public string Id_class_instance
        {
            get { return id_class_instance; }
            set { id_class_instance = value; }
        }

//TABLE
        private string sDateStart;
        //as date_start
        public string SDateStart
        {
            get { return sDateStart; }
            set { sDateStart = value; }
        }
//TABLE
        private string sDateDue;
        //as date_due
        public string SDateDue
        {
            get { return sDateDue; }
            set { sDateDue = value; }
        }
//TABLE
        //as EqID
        private int id_equipment;
        public int Id_equipment
        {
            get { return id_equipment; }
            set { id_equipment = value; }
        }

        //as Equipment (equipment name)


//TABLE
        private int sBorrowedAmount;
        //as BorrowedAmount
        public int SBorrowedAmount
        {
            get { return sBorrowedAmount; }
            set { sBorrowedAmount = value; }
        }
//TABLE
        private bool sIsReturned;

        public bool SIsReturned
        {
            get { return sIsReturned; }
            set { sIsReturned = value; }
        }


        public EquipmentBooked()
        {

            this.id_eq_booking = -1;
        }



        public EquipmentBooked(int iIdEqBooking)
        {
            mySqlConn conn = new mySqlConn();
            conn.connect();
            // We launch the query
            //List<Hashtable> lhResultset = conn.lhSqlQuery("Select * from equipment_bookings WHERE id_equipment = '" + iIdEqBooking + "'");


            List<Hashtable> lhResultset = conn.lhSqlQuery("SELECT IF(eb.id_staff IS NULL, 'MEMBER_BOOKING','STAFF_BOOKING') BookingType, eb.id_eq_booking BookingNr, eb.id_member MemberID, CONCAT(m.lastName, ', ', m.firstName) MemberName, eb.id_staff StaffID, CONCAT(s.lastName, ', ', s.firstName) SaffName, eb.id_equipment EqID,  e.name Equipment, eb.borrowedamount, eb.date_start, eb.date_due, eb.id_class_instance ClassInstance FROM equipment e, equipment_bookings eb LEFT OUTER JOIN staff s ON eb.id_staff = s.id_staff LEFT OUTER JOIN members m ON eb.id_member = m.id_member WHERE e.id_equipment = eb.id_equipment AND eb.id_eq_booking = '" + iIdEqBooking + "'");


            // Check if we found the equipment
            if ((int)lhResultset.Count > 0)
            {

                this.SBookingType = lhResultset[0]["BookingType"].ToString();
                this.Id_eq_booking = int.Parse(lhResultset[0]["BookingNr"].ToString());
                
            }
        }
               


        /**
        * @desc This method will save the object into the database
        */
        public bool bSave()
        {
            // Field checking
            string sQuery;

            mySqlConn conn = new mySqlConn();
                conn.connect();
                if (this.Id_eq_booking == -1)
                {
                    
                    sQuery = "insert into `gym`.`equipment_bookings` (`id_eq_booking`, `id_staff`, `id_member`, `id_class_instance`, `date_start`, `date_due`, `id_equipment`, `borrowedamount`,`isreturned`) values " +
                             "(NULL, " + this.Id_staff + ", " + this.Id_member + ", " + this.Id_class_instance + ", '" + this.SDateStart + "', '" + this.SDateDue
                             + "', " + this.Id_equipment + ", " + this.SBorrowedAmount + ", NULL)";

                    int iIdEqBooking = conn.iInsert(sQuery);
                    if (iIdEqBooking != -1)
                    {
                        this.Id_eq_booking = iIdEqBooking;
                        MessageBox.Show("The new equipment booking has been added to the databse succesfully!");
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("There was a problem adding the new equipment booking, please check your data!");
                        return false;
                    }
                }
                else
                {
                    sQuery = "UPDATE `gym`.`equipment_bookings` SET `borrowedamount` = "+this.SBorrowedAmount+", `isreturned`= "+this.SIsReturned+" WHERE id_eq_booking = '" + this.Id_eq_booking + "'";

                    

                    int iRes = conn.iDeleteOrUpdate(sQuery);
                    if (iRes > 0)
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
