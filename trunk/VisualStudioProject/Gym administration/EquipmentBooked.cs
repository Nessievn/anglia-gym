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


        private string bookingType;
        public string BookingType
        {
            get { return bookingType; }
            set { bookingType = value; }
        }

        private int id_eq_booking;
        public int Id_eq_booking
        {
            get { return id_eq_booking; }
            set { id_eq_booking = value; }
        }

        private string id_member;
        public string Id_member
        {
            get { return id_member; }
            set { id_member = value; }
        }

        private string memberName;
        public string MemberName
        {
            get { return memberName; }
            set { memberName = value; }
        }

        private string id_staff;
        public string Id_staff
        {
            get { return id_staff; }
            set { id_staff = value; }
        }

        private string staffName;
        public string StaffName
        {
            get { return staffName; }
            set { staffName = value; }
        }

        private string id_class_instance;
        public string Id_class_instance
        {
            get { return id_class_instance; }
            set { id_class_instance = value; }
        }

        private string dateStart;
        public string DateStart
        {
            get { return dateStart; }
            set { dateStart = value; }
        }

        private string dateDue;
        public string DateDue
        {
            get { return dateDue; }
            set { dateDue = value; }
        }

        private int id_equipment;
        public int Id_equipment
        {
            get { return id_equipment; }
            set { id_equipment = value; }
        }

        private int borrowedAmount;
        public int BorrowedAmount
        {
            get { return borrowedAmount; }
            set { borrowedAmount = value; }
        }

        private bool isReturned;
        public bool IsReturned
        {
            get { return isReturned; }
            set { isReturned = value; }
        }


        public EquipmentBooked()
        {

            this.id_eq_booking = -1;
        }



        public EquipmentBooked(int id_eq_booking)
        {
            mySqlConn conn = new mySqlConn();
            conn.connect();
            // We launch the query
            //List<Hashtable> lhResultset = conn.lhSqlQuery("Select * from equipment_bookings WHERE id_equipment = '" + iIdEqBooking + "'");


            List<Hashtable> lhResultset = conn.lhSqlQuery("SELECT IF(eb.id_staff IS NULL, 'MEMBER_BOOKING','STAFF_BOOKING') BookingType, eb.id_eq_booking BookingNr, eb.id_member MemberID, CONCAT(m.lastName, ', ', m.firstName) MemberName, eb.id_staff StaffID, CONCAT(s.lastName, ', ', s.firstName) SaffName, eb.id_equipment EqID,  e.name Equipment, eb.borrowedamount, eb.date_start, eb.date_due, eb.id_class_instance ClassInstance FROM equipment e, equipment_bookings eb LEFT OUTER JOIN staff s ON eb.id_staff = s.id_staff LEFT OUTER JOIN members m ON eb.id_member = m.id_member WHERE e.id_equipment = eb.id_equipment AND eb.id_eq_booking = '" + id_eq_booking + "'");


            // Check if we found the equipment
            if ((int)lhResultset.Count > 0)
            {

                this.BookingType = lhResultset[0]["BookingType"].ToString();
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
                             "(NULL, " + this.Id_staff + ", " + this.Id_member + ", " + this.Id_class_instance + ", '" + this.DateStart + "', '" + this.DateDue
                             + "', " + this.Id_equipment + ", " + this.BorrowedAmount + ", NULL)";

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
                    sQuery = "UPDATE `gym`.`equipment_bookings` SET `borrowedamount` = "+this.BorrowedAmount+", `isreturned`= "+this.IsReturned+" WHERE id_eq_booking = '" + this.Id_eq_booking + "'";

                    

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
