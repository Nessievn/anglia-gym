//ITS NOT FINISHED, BUT MAYBE THIS CLASS IS USELESS!!!!
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gym_administration
{
    class EquipmentBooked
    {

        private int id_eq_booking;
        public int Id_eq_booking
        {
            get { return id_eq_booking; }
            set { id_eq_booking = value; }
        }

        private int id_staff;
        public int Id_staff
        {
            get { return id_staff; }
            set { id_staff = value; }
        }

        private int id_member;
        public int Id_member
        {
            get { return id_member; }
            set { id_member = value; }
        }

        private int id_class_instance;
        public int Id_class_instance
        {
            get { return id_class_instance; }
            set { id_class_instance = value; }
        }
 
        private string sDateStart;
        public string SDateStart
        {
            get { return sDateStart; }
            set { sDateStart = value; }
        }

        private string sDateDue;
        public string SDateDue
        {
            get { return sDateDue; }
            set { sDateDue = value; }
        }

        private bool sIsSet;
        public bool SIsSet
        {
            get { return sIsSet; }
            set { sIsSet = value; }
        }
        private int id_equipment;
        public int Id_equipment
        {
            get { return id_equipment; }
            set { id_equipment = value; }
        }
        private int sBorrowedAmount;
        public int SBorrowedAmount
        {
            get { return sBorrowedAmount; }
            set { sBorrowedAmount = value; }
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
