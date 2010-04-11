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
        private string dateStart;
        public string DateStart
        {
            get { return dateStart; }
            set { dateStart = value; }
        }

        // start_time field from CLASS_INSTANCE table stored here
        private string startTime;
        public string StartTime
        {
            get { return startTime; }
            set { startTime = value; }
        }

        // end_time field from CLASS_INSTANCE table stored here
        private string endTime;
        public string EndTime
        {
            get { return endTime; }
            set { endTime = value; }
        }

        // frequency field from CLASS_INSTANCE table stored here
        private string frequency;
        public string Frequency
        {
            get { return frequency; }
            set { frequency = value; }
        }

        // a Room (Room.cs) object is stored here
        private Room clRoom;
        internal Room ClRoom
        {
            get { return clRoom; }
            set { clRoom = value; }
        }

        // A list of member objects participating in the class instance stored here
        private List<Member> lclAttendants = new List<Member>();
        internal List<Member> LclAttendants
        {
            get { return lclAttendants; }
            set { lclAttendants = value; }
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
         * @params [int]  id_class_instance identifies the class instance uniquely.
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
                this.DateStart = lhResultset[0]["date"].ToString();
                this.EndTime = lhResultset[0]["end_time"].ToString();
                this.StartTime = lhResultset[0]["start_time"].ToString();
                this.Frequency = lhResultset[0]["frequency"].ToString();


                // Create a list for storing member objects
                // Load in all records for the same class instance from CLASS_BOOKINGS table (each contains a different member ID)
                List<Hashtable> lhResultsetMbrs = conn.lhSqlQuery("SELECT * FROM `gym`.`class_bookings` WHERE id_class_instance = '" + id_class_instance + "'");
                // If there is any class booking (any member enrolled) exist with the class instance id
                if ((int)lhResultsetMbrs.Count > 0)
                {
                    // Create a list of attending members
                    foreach (Hashtable hClassBooking in lhResultsetMbrs)
                    {
                        // Retrieve the member number from the current class booking
                        int id_member = int.Parse(hClassBooking["id_member"].ToString());
                        // Create a corresponding member object with all the particular member info loaded into it
                        Member clMember = new Member(id_member);
                        // If a member with this id_member actually exist, then add the member object to the list
                        if(clMember.Id_member != -1)
                            this.lclAttendants.Add(clMember);
                    }
                }
            }
        }

        /**
         * @desc Method for checking if there is any overlap of class instances in the same room or same instructor at conflicting times 
         * @params [string] sDate has the date of the class instance
         * @params [string] id_room is the room where the class instance takes place
         * @params [string] id_staff is the instructor on this occasion
         * @params [string] sStartTime is the start time
         * @params [string] sEndTime is the end time
         * @return [bool] Returns true if there is an overlap and false if everything is green ligth
         */
        public bool bCheckOverlap(string date, string id_room, string id_staff, string dtartTime, string endTime)
        {
            // Create mysql connection
            mySqlConn conn = new mySqlConn();
            conn.connect();
            // Create the overlap check query
            string sQuery = "SELECT * FROM gym.class_instance WHERE date = '" + date + "' AND (id_room = '" + id_room + "' OR id_staff = '" + id_staff + "') AND (" +
                            "(start_time BETWEEN '" + startTime + "' AND '" + endTime + "') OR " +
                            "(end_time BETWEEN '" + startTime + "' AND '" + endTime + "') OR " +
                            "(start_time < '" + startTime + "' AND end_time > '" + endTime + "') OR " +
                            "(start_time > '" + startTime + "' AND end_time < '" + endTime + "'))" + ((this.Id_class_instance != -1)?"  AND id_class_instance != '"+this.Id_class_instance+"'":"");
            // Launch the overlap check query and load the result into a hashtable
            List<Hashtable> lhResultset = conn.lhSqlQuery(sQuery);
            // If there is any result then there is an overlap
            if ((int)lhResultset.Count >= 1)
                return true;   
            // Otherwise ther is no overlap
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
            // SAVING THE CLASS INSTANCE INTO CLASS_INSTANCE
            // Check whether there is a new id_class_instance assigned to this class instance, 
            // if not then this a new class to save
            if (this.Id_class_instance == -1)
            {
                // Create the save query
                string sQuery = "insert into `gym`.`class_instance` (`id_class_instance`, `id_class`, `id_staff`, `date`, `start_time`, `end_time`, `frequency`, `id_room`) values " +
                                "(NULL, '" + this.ClClass.Id_class + "', '" + this.Id_staff + "', '" + Utils.sGetMysqlDate(this.DateStart) + "', '" + this.StartTime + "', '" + this.EndTime + "', '" + this.Frequency + "', '" + this.ClRoom.Id_room + "');";
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
                string sQuery = "UPDATE class_instance SET id_staff= '" + this.Id_staff + "', date = '" + Utils.sGetMysqlDate(this.DateStart) + "', start_time = '" + this.StartTime + "', end_time = '" + this.EndTime + "', frequency = '" + this.Frequency + "', id_room = '" + this.ClRoom.Id_room + "' " +
                                "WHERE id_class_instance = '" + this.Id_class_instance + "'";
                // Launch update query
                int result = conn.iDeleteOrUpdate(sQuery);
                // Check update result
                if (result > 0)
                {
                    MessageBox.Show("The class booking data has been updated succesfully!");
                }
                else
                {
                    MessageBox.Show("There was a problem updating the class booking information, please check your data!");
                    return false;
                }
            }
            // SAVING THE ATTENDANTS INTO CLASS_BOOKINGS
                // If there are any attendants save them into the CLASS_BOOKINGS table
                if (this.lclAttendants.Count > 0)
                {

                    StringBuilder sbQueryClassBooking = new StringBuilder();
                    // Create the first half of the insert query containing so far only the fields
                    sbQueryClassBooking.Append("insert into `gym`.`class_bookings` (`id_class_booking`, `id_member`, `id_class_instance`, `booking_date`) values ");
                    int i = 0;
                    // Create a string array storing each second half of the queries, that is the values of each booking
                    string[] aQueryClassBookingValues = new string[this.lclAttendants.Count];
                    // Copy all values of each booking into each string in the array
                    foreach (Member clMember in this.lclAttendants)
                    {
                        aQueryClassBookingValues[i] = "(NULL, '" + clMember.Id_member + "', '" + this.Id_class_instance + "', NOW())";
                        i++;
                    }
                    // It is possible to add more than one class booking into the CLASS_BOOKINGS table in the same query at the same time
                    // so append each set of booking values one after the other at the end of the query, separated by comma
                    sbQueryClassBooking.Append(string.Join(", ", aQueryClassBookingValues));
                    sbQueryClassBooking.Append(" ON DUPLICATE KEY UPDATE booking_date = booking_date");
                    int iLastMbrId = conn.iInsert(sbQueryClassBooking.ToString());
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
