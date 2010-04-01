//Holds data for a single class instance (certain class at a certain time)
//Most closely associated form is frm_class_arrange
//when frm_class_arrange is called from frm_class_arrange_list

//Used also in
//      frm_member_list

//Most closely associated table is CLASS_INSTANCE
//Constructor (default)
//sets id_class_instance to -1
//Constructor (id_class_booked)
//Loads in various info from tables CLASSES, CLASS_INSTANCE and STAFF for this class instance
//Loads in all atendants for this class instance
//Method 1
//Checkoverlap()  ???
//Method 2
//bSave() saves into CLASS_INSTANCE table
//Method 3 
//bRemove() removes a class instance from CLASS_INSTANCE table


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Windows.Forms;

namespace Gym_administration
{
    public class ClassInstance
    {
        private int id_class_instance;

        public int Id_class_instance
        {
            get { return id_class_instance; }
            set { id_class_instance = value; }
        }
        private Class sClass;

        internal Class SClass
        {
            get { return sClass; }
            set { sClass = value; }
        }
        private int id_staff;

        public int Id_staff
        {
            get { return id_staff; }
            set { id_staff = value; }
        }
        private Room rRoom;

        internal Room RRoom
        {
            get { return rRoom; }
            set { rRoom = value; }
        }
        private string sDateStart;

        public string SDateStart
        {
            get { return sDateStart; }
            set { sDateStart = value; }
        }
        private string sStartTime;

        public string SStartTime
        {
            get { return sStartTime; }
            set { sStartTime = value; }
        }
        private string sEndTime;

        public string SEndTime
        {
            get { return sEndTime; }
            set { sEndTime = value; }
        }
        private string sFrequency;

        public string SFrequency
        {
            get { return sFrequency; }
            set { sFrequency = value; }
        }
        private List<Member> Members = new List<Member>();

        internal List<Member> lmAttendants
        {
            get { return Members; }
            set { Members = value; }
        }


        public ClassInstance()
        {
            this.id_class_instance = -1;
        }

        public ClassInstance(int iIdClassInstance)
        {
            mySqlConn conn = new mySqlConn();
            conn.connect();
            // We launch the query
            List<Hashtable> lhResultset = conn.lhSqlQuery("SELECT ci.id_class_instance, c.name, c.type, c.description, s.firstName, s.id_staff, DATE_FORMAT(ci.date, '%d/%m/%Y') date, ci.start_time, ci.end_time, ci.id_room, c.id_class, ci.frequency FROM classes c, class_instance ci, staff s WHERE ci.id_class = c.id_class AND ci.id_staff = s.id_staff AND ci.id_class_instance = '" + iIdClassInstance + "'");

            // Check if we found the member
            if ((int)lhResultset.Count > 0)
            {
                this.Id_class_instance = int.Parse(lhResultset[0]["id_class_instance"].ToString());
                this.Id_staff = int.Parse(lhResultset[0]["id_staff"].ToString());
                this.RRoom = new Room(int.Parse(lhResultset[0]["id_room"].ToString()));
                this.SClass = new Class(int.Parse(lhResultset[0]["id_class"].ToString()));
                this.SDateStart = lhResultset[0]["date"].ToString();
                this.SEndTime = lhResultset[0]["end_time"].ToString();
                this.SStartTime = lhResultset[0]["start_time"].ToString();
                this.SFrequency = lhResultset[0]["frequency"].ToString();

                // We retrieve the attendants
                List<Member> Members = new List<Member>();
                List<Hashtable> lhResultsetMbrs = conn.lhSqlQuery("SELECT * FROM `gym`.`class_bookings` WHERE id_class_instance = '"+iIdClassInstance+"'");
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
    }
}
