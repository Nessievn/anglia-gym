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
        private int id_class_instance;
        //as ClassInstance
        public int Id_class_instance
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
        private bool sIsSet;
        public bool SIsSet
        {
            get { return sIsSet; }
            set { sIsSet = value; }
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

                /*             BookingNr
                              this.Id_staff = lhResultset[0]["id_staff"].ToString();
                              MemberID
                              this.Id_member = int.Parse(lhResultset[0]["id_member"].ToString());
                              this.Id_class_instance = int.Parse(lhResultset[0]["id_set"].ToString());
                              this.SName = lhResultset[0]["name"].ToString();
                              this.SDescription = lhResultset[0]["description"].ToString();
                              this.SCurrentlyInStock = int.Parse(lhResultset[0]["currentlyinstock"].ToString());
                              if (this.sType == "set")
                              {
                                  this.SItemInSet1 = lhResultset[0]["iteminset1"].ToString();
                                  this.SItemInSet2 = lhResultset[0]["iteminset2"].ToString();
                                  this.SItemInSet3 = lhResultset[0]["iteminset3"].ToString();
                                  this.SItemInSet4 = lhResultset[0]["iteminset4"].ToString();
                                  this.SItemInSet5 = lhResultset[0]["iteminset5"].ToString();
                                  this.SItemInSet6 = lhResultset[0]["iteminset6"].ToString();
                                  this.SItemInSet7 = lhResultset[0]["iteminset7"].ToString();
                                  this.SItemInSet8 = lhResultset[0]["iteminset8"].ToString();
                                  this.SItemInSet9 = lhResultset[0]["iteminset9"].ToString();
                                  this.SItemInSet10 = lhResultset[0]["iteminset10"].ToString();
                                  this.SAmountInSet1 = int.Parse(lhResultset[0]["amountinset1"].ToString());
                                  this.SAmountInSet2 = int.Parse(lhResultset[0]["amountinset2"].ToString());
                                  this.SAmountInSet3 = int.Parse(lhResultset[0]["amountinset3"].ToString());
                                  this.SAmountInSet4 = int.Parse(lhResultset[0]["amountinset4"].ToString());
                                  this.SAmountInSet5 = int.Parse(lhResultset[0]["amountinset5"].ToString());
                                  this.SAmountInSet6 = int.Parse(lhResultset[0]["amountinset6"].ToString());
                                  this.SAmountInSet7 = int.Parse(lhResultset[0]["amountinset7"].ToString());
                                  this.SAmountInSet8 = int.Parse(lhResultset[0]["amountinset8"].ToString());
                                  this.SAmountInSet9 = int.Parse(lhResultset[0]["amountinset9"].ToString());
                                  this.SAmountInSet10 = int.Parse(lhResultset[0]["amountinset10"].ToString());
   
                              }*/

            }
        }

/*
        public bool bRemove()
        {
            if (this.Id_equipment != -1)
            {
                mySqlConn conn = new mySqlConn();
                conn.connect();
                string sQuery = "DELETE FROM equipment WHERE id_equipment = '" + this.Id_equipment + "'";
                int iRes = conn.iDeleteOrUpdate(sQuery);
                if (iRes > 0)
                {
                    MessageBox.Show("The equipment data has been deleted succesfully!");
                    return true;
                }
                else
                {
                    MessageBox.Show("There was a problem deleting the equipment!");
                    return false;
                }
            }
            return false;
        }
*/


        /**
        * @desc This method will save the object into the database
        */
        public bool bSave()
        {
            // Field checking
            string sQuery;

            /*
            if (this.SName == "")
            {
                MessageBox.Show("Please Insert a name.");
            }
            else
             {}*/
            mySqlConn conn = new mySqlConn();
                conn.connect();
                if (this.Id_eq_booking == -1)
                {
                    
                    sQuery = "insert into `gym`.`equipment_bookings` (`id_eq_booking`, `id_staff`, `id_member`, `id_class_instance`, `date_start`, `date_due`, `isset`, `id_equipment`, `borrowedamount`,`isreturned`) values " +
                             "(NULL, " + this.Id_staff + ", " + this.Id_member + ", '" + this.Id_class_instance + "', '" + this.SDateStart + "', '" + this.SDateDue
                             + "', '" + Convert.ToInt16(this.SIsSet) + "', " + this.Id_equipment + ", '" + this.SBorrowedAmount + "', NULL)";

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
                    sQuery = "UPDATE `gym`.`equipment_bookings` SET `isreturned`='1' WHERE id_eq_booking = '" + this.Id_eq_booking + "'";

                    /*   sQuery = "UPDATE equipment_bookings SET id_staff = '" + this.Id_staff
                                                        + "', id_member = '" + this.Id_member
                                                + "', id_class_instance = '" + this.Id_class_instance
                                                       + "', date_start = '" + this.SDateStart
                                                         + "', date_due = '" + this.SDateDue
                                                            + "', isset = '" + this.SIsSet
                                                     + "', id_equipment = '" + this.Id_equipment
                                                   + "', borrowedamount = '" + this.SBorrowedAmount + "' " 
                                                + " WHERE id_eq_booking = '" + this.Id_eq_booking + "'";*/

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

/*
        public EqBooked(int iIdEqBooked)
        {
            mySqlConn conn = new mySqlConn();
            conn.connect();
            // We launch the query
            List<Hashtable> lhResultset = conn.lhSqlQuery("Select * from equipment_bookings WHERE id_eq_bookings = '" + iIdEqBooked + "'");
            // Check if we found the equipment booking
            if ((int)lhResultset.Count > 0)
            {





                this.Id_eq_booking = int.Parse(lhResultset[0]["id_eq_booking"].ToString());
                this.Id_class_instance = int.Parse(lhResultset[0]["id_class_instance"].ToString());
                this.Id_equipment = int.Parse(lhResultset[0]["id_equipment"].ToString());
                this.Id_staff = int.Parse(lhResultset[0]["id_staff"].ToString());
                this.Id_member = int.Parse(lhResultset[0]["id_member"].ToString());
                this.RRoom = new Room(int.Parse(lhResultset[0]["id_room"].ToString()));
                this.SClass = new Class(int.Parse(lhResultset[0]["id_class"].ToString()));
                this.SDateStart = lhResultset[0]["date"].ToString();
                this.SEndTime = lhResultset[0]["end_time"].ToString();
                this.SStartTime = lhResultset[0]["start_time"].ToString();
                this.SFrequency = lhResultset[0]["frequency"].ToString();

                // We retrieve the attendants
                List<Member> Members = new List<Member>();
                List<Hashtable> lhResultsetMbrs = conn.lhSqlQuery("SELECT * FROM `gym`.`class_bookings` WHERE id_class_instance = '"+iIdClassBooked+"'");
                if ((int)lhResultsetMbrs.Count > 0)
                {
                    foreach (Hashtable record in lhResultsetMbrs)
                    {
                        int iIdMember = int.Parse(record["id_member"].ToString());
                        Member mbt_t = new Member(iIdMember);
                        if(mbt_t.IId_member != -1)
                            Members.Add(mbt_t);
                    }
                    this.lmAttendants = Members;
                }
            }
        }
*/

/*
        public bool bCheckOverlap(string sDate, string sIdRoom, string sIdStaff, string sStartTime, string sEndTime)
        {
            mySqlConn conn = new mySqlConn();
            conn.connect();
            string sQuery = "SELECT * FROM gym.class_instance WHERE date = '" + sDate + "' AND (id_room = '" + sIdRoom + "' OR id_staff = '" + sIdStaff + "') AND (" +
                            "(start_time BETWEEN '" + sStartTime + "' AND '" + sEndTime + "') OR " +
                            "(end_time BETWEEN '" + sStartTime + "' AND '" + sEndTime + "') OR " +
                            "(start_time < '" + sStartTime + "' AND end_time > '" + sEndTime + "') OR " +
                            "(start_time > '" + sStartTime + "' AND end_time < '" + sEndTime + "'))" + ((this.Id_class_instance != -1)?"  AND id_class_instance != '"+this.Id_class_instance+"'":"");
            List<Hashtable> lhResultset = conn.lhSqlQuery(sQuery);

            // Check if we found the user
            if ((int)lhResultset.Count >= 1)
                return true;   

            return false;
        }

        public bool bSave()
        {
            mySqlConn conn = new mySqlConn();
            conn.connect();

            // If the class instance is not created, we create it
            if (this.Id_class_instance == -1)
            {
                string sQuery = "insert into `gym`.`class_instance` (`id_class_instance`, `id_class`, `id_staff`, `date`, `start_time`, `end_time`, `frequency`, `id_room`) values " +
                                "(NULL, '" + this.SClass.Id_class + "', '" + this.Id_staff + "', '" + Utils.sGetMysqlDate(this.SDateStart) + "', '" + this.SStartTime + "', '" + this.SEndTime + "', '" + this.SFrequency + "', '" + this.RRoom.Id_room + "');";

                int iIdClassInstance = conn.iInsert(sQuery);
                if (iIdClassInstance != -1)
                {
                    this.Id_class_instance = iIdClassInstance;
                    MessageBox.Show("The class has been saved!");
                    return true;
                }
                else
                {
                    MessageBox.Show("There has been an error creating the class instance! Contact with your administrator.");
                }
            }
            else
            {
                string sQuery = "UPDATE class_instance SET id_staff= '" + this.Id_staff + "', date = '" + Utils.sGetMysqlDate(this.SDateStart) + "', start_time = '" + this.SStartTime + "', end_time = '" + this.SEndTime + "', frequency = '" + this.SFrequency + "', id_room = '" + this.RRoom.Id_room + "' " +
                                "WHERE id_class_instance = '" + this.Id_class_instance + "'";
                int iRes = conn.iDeleteOrUpdate(sQuery);
                if (iRes > 0)
                {
                    //MessageBox.Show("The class data has been updated succesfully!");
                }
                else
                {
                    MessageBox.Show("There was a problem updating the class information, please check your data!");
                    return false;
                }
            }
                if (this.lmAttendants.Count > 0)
                {
                    StringBuilder sbQuery = new StringBuilder();
                    sbQuery.Append("insert into `gym`.`class_bookings` (`id_class_booking`, `id_member`, `id_class_instance`, `booking_date`) values ");
                    // Then we save the attendants
                    int cnt = 0;
                    string[] sValues = new string[this.lmAttendants.Count];
                    foreach (Member mbr in this.lmAttendants)
                    {
                        sValues[cnt] = "(NULL, '" + mbr.IId_member + "', '" + this.Id_class_instance + "', NOW())";
                        cnt++;
                    }
                    sbQuery.Append(string.Join(", ", sValues));
                    sbQuery.Append(" ON DUPLICATE KEY UPDATE booking_date = booking_date");
                    int iLastMbrId = conn.iInsert(sbQuery.ToString());
                    if (iLastMbrId != -1)
                    {
                        MessageBox.Show("The attendant has been enrolled!");
                    }
                }
            return true;
        }
        public bool bRemove()
        {
            if (this.Id_class_instance != 0)
            {
                mySqlConn conn = new mySqlConn();
                conn.connect();
                string sQuery = "DELETE FROM class_instance WHERE id_class_instance = '" + this.Id_class_instance + "'";
                int iRes = conn.iDeleteOrUpdate(sQuery);
                if (iRes > 0)
                {
                    MessageBox.Show("The class data has been deleted succesfully!");
                    return true;
                }
                else
                {
                    MessageBox.Show("There was a problem deleting the class!");
                    return false;
                }
            }
            return false;
        }

        */



    }
}
