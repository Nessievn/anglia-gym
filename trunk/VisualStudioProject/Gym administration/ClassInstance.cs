using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Windows.Forms;

namespace Gym_administration
{
    /**
     * @desc It holds data and modifying methods for the CLASS_INSTANCE table. 
     * Which is about a single class instance (certain class at a certain time).
     * Most closely associated form is frm_class_instance_arrange,
     * when frm_class_instance_arrange is called from frm_class_instance_list.
     * Used also in frm_member_list, as frm_member_list is used to book attendants for a class instance.
     * Most closely associated table is CLASS_INSTANCE.
     * @params [none] Incoming parameters are described at the individual constructors.
     * @return [none] No directly returned data. 
     * Returns of public methods are described at the individual methods.
     */
    public class ClassInstance
    {
        // id_class_instance field from CLASS_INSTANCE table stored here
        private int id_class_instance;
        public int Id_class_instance
        {
            get { return id_class_instance; }
            set { id_class_instance = value; }
        }

        // a 'Gym class' (Class.cs) object is stored here
//why?
        private Class clClass;
        internal Class ClClass
        {
            get { return clClass; }
            set { clClass = value; }
        }

        // id_staff field from CLASS_INSTANCE table stored here
        private int id_staff;
        public int Id_staff
        {
            get { return id_staff; }
            set { id_staff = value; }
        }

        // date field from CLASS_INSTANCE table stored here
        private string sDateStart;
        public string SDateStart
        {
            get { return sDateStart; }
            set { sDateStart = value; }
        }

        // start_time field from CLASS_INSTANCE table stored here
        private string sStartTime;
        public string SStartTime
        {
            get { return sStartTime; }
            set { sStartTime = value; }
        }

        // end_time field from CLASS_INSTANCE table stored here
        private string sEndTime;
        public string SEndTime
        {
            get { return sEndTime; }
            set { sEndTime = value; }
        }

        // frequency field from CLASS_INSTANCE table stored here
        private string sFrequency;
        public string SFrequency
        {
            get { return sFrequency; }
            set { sFrequency = value; }
        }

        // a Room (Room.cs) object is stored here
//why?
        private Room clRoom;
        internal Room ClRoom
        {
            get { return clRoom; }
            set { clRoom = value; }
        }

        // A list of members participating in the class instance stored here
        private List<Member> Members = new List<Member>();
        internal List<Member> lmAttendants
        {
            get { return Members; }
            set { Members = value; }
        }

        /**
         * @desc Default constructor.
         * Sets id_class to -1 so the fact of this is a new class instance can be referenced.
         * 
         * @params [none] No input parameter.
         * @return [none] No directly returned data.
         */
        public ClassInstance()
        {
            this.id_class_instance = -1;
        }

        /**
         * @desc Constructor.  
         * Loads in various info from tables CLASSES, CLASS_INSTANCE and STAFF for this class instance.
         * Loads in all atendants for this class instance.
         * @params [int id_class_instance] This identifies the class instance uniquely.
         * @return [none] No directly returned data.
         */
        public ClassInstance(int id_class_instance)
        {
            // Create mysql connection.
            mySqlConn conn = new mySqlConn();
            conn.connect();
            // Launch the query to return all all fields from a single class instance row of the CLASS_INSTANCE table.
            List<Hashtable> lhResultset = conn.lhSqlQuery("SELECT ci.id_class_instance, c.name, c.type, c.description, s.firstName, s.id_staff, DATE_FORMAT(ci.date, '%d/%m/%Y') date, ci.start_time, ci.end_time, ci.id_room, c.id_class, ci.frequency FROM classes c, class_instance ci, staff s WHERE ci.id_class = c.id_class AND ci.id_staff = s.id_staff AND ci.id_class_instance = '" + id_class_instance + "'");

            // Check if we found the row
            if ((int)lhResultset.Count > 0)
            {
                // Fill in all class instance fields with table data
                this.Id_class_instance = int.Parse(lhResultset[0]["id_class_instance"].ToString());
                this.Id_staff = int.Parse(lhResultset[0]["id_staff"].ToString());
                this.ClRoom = new Room(int.Parse(lhResultset[0]["id_room"].ToString()));
                this.ClClass = new Class(int.Parse(lhResultset[0]["id_class"].ToString()));
                this.SDateStart = lhResultset[0]["date"].ToString();
                this.SEndTime = lhResultset[0]["end_time"].ToString();
                this.SStartTime = lhResultset[0]["start_time"].ToString();
                this.SFrequency = lhResultset[0]["frequency"].ToString();


                // Retrieve all the attendants of this class instance
                List<Member> Members = new List<Member>();
//What does the class booking query load into the member list?
//How does this part work?
                List<Hashtable> lhResultsetMbrs = conn.lhSqlQuery("SELECT * FROM `gym`.`class_bookings` WHERE id_class_instance = '" + id_class_instance + "'");
                // If there are any attendants enrolled already
                if ((int)lhResultsetMbrs.Count > 0)
                {
                    // Create a list of attending members
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

        /**
         * @desc Method for checking if there is any overlap
         * @params [int id_class_instance, ] This identifies the class instance uniquely.
         * @return [bool] Returns true if ... and false if ....
         */
//Overlap of what?
        public bool bCheckOverlap(string sDate, string id_room, string id_staff, string sStartTime, string sEndTime)
        {
            // Create mysql connection
            mySqlConn conn = new mySqlConn();
            conn.connect();
            // Create the overlap check query
            string sQuery = "SELECT * FROM gym.class_instance WHERE date = '" + sDate + "' AND (id_room = '" + id_room + "' OR id_staff = '" + id_staff + "') AND (" +
                            "(start_time BETWEEN '" + sStartTime + "' AND '" + sEndTime + "') OR " +
                            "(end_time BETWEEN '" + sStartTime + "' AND '" + sEndTime + "') OR " +
                            "(start_time < '" + sStartTime + "' AND end_time > '" + sEndTime + "') OR " +
                            "(start_time > '" + sStartTime + "' AND end_time < '" + sEndTime + "'))" + ((this.Id_class_instance != -1)?"  AND id_class_instance != '"+this.Id_class_instance+"'":"");
            // Launch the overlap check query and load the result into a hashtable
            List<Hashtable> lhResultset = conn.lhSqlQuery(sQuery);

            // Check if we found the user
//What user? Why?
            if ((int)lhResultset.Count >= 1)
                return true;   

            return false;
        }


        /**
         * @desc This method will save or update a class instance in the CLASS_INSTANCE table
         * @params [none] No input parameter.
         * @return [bool] Returns true in case of success, false if there was problem saving/updating the class
         */
        public bool bSave()
        {
            // Create mysql connection
            mySqlConn conn = new mySqlConn();
            conn.connect();

            // Check whether there is a new id_class_instance assigned to this class instance, 
            // if not then this a new class to save
            if (this.Id_class_instance == -1)
            {
                // Create the save query
                string sQuery = "insert into `gym`.`class_instance` (`id_class_instance`, `id_class`, `id_staff`, `date`, `start_time`, `end_time`, `frequency`, `id_room`) values " +
                                "(NULL, '" + this.ClClass.Id_class + "', '" + this.Id_staff + "', '" + Utils.sGetMysqlDate(this.SDateStart) + "', '" + this.SStartTime + "', '" + this.SEndTime + "', '" + this.SFrequency + "', '" + this.ClRoom.Id_room + "');";
                // Launch save query
                int id_class_instance = conn.iInsert(sQuery);
                // Check saving result
                if (id_class_instance != -1)
                {
                    this.Id_class_instance = id_class_instance;
                    MessageBox.Show("The class has been saved!");
                    return true;
                }
                else
                {
                    MessageBox.Show("There has been an error creating the class instance! Contact with your administrator.");
                }
            }
            // If an id_class_instance already exists for this class instance, then this is an existing class instance to update
            else 
            {
                string sQuery = "UPDATE class_instance SET id_staff= '" + this.Id_staff + "', date = '" + Utils.sGetMysqlDate(this.SDateStart) + "', start_time = '" + this.SStartTime + "', end_time = '" + this.SEndTime + "', frequency = '" + this.SFrequency + "', id_room = '" + this.ClRoom.Id_room + "' " +
                                "WHERE id_class_instance = '" + this.Id_class_instance + "'";
                // Launch update query
                int iRes = conn.iDeleteOrUpdate(sQuery);
                // Check update result
                if (iRes > 0)
                {
                    MessageBox.Show("The class booking data has been updated succesfully!");
                }
                else
                {
                    MessageBox.Show("There was a problem updating the class booking information, please check your data!");
                    return false;
                }
            }

//I don't know what's happening here, Isidro please explain this too at some point in the future
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


        /**
         * @desc Removes the class instance from the CLASS_INSTANCE table.
         * @params [none] No input parameter.
         * @return [bool] Returns true in case of success, false if there was problem deleting the class instance.
         */
        public bool bRemove()
        {
            if (this.Id_class_instance != 0)
            {
                // Create mysql connection
                mySqlConn conn = new mySqlConn();
                conn.connect();
                // Create the delete query
                string sQuery = "DELETE FROM class_instance WHERE id_class_instance = '" + this.Id_class_instance + "'";
                // Launch delete query
                int iRes = conn.iDeleteOrUpdate(sQuery);
                // Check deletion result
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
