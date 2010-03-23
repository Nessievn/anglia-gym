using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Gym_administration
{
    class ClassBooked
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

        public ClassBooked()
        {
            this.id_class_instance = -1;
        }

        public bool bCheckOverlap(string sDate, string sIdRoom, string sIdStaff, string sStartTime, string sEndTime)
        {
            mySqlConn conn = new mySqlConn();
            conn.connect();
            string sQuery = "SELECT * FROM gym.class_instance WHERE date = '" + sDate + "' AND (id_room = '" + sIdRoom + "' OR id_staff = '" + sIdStaff + "') AND (" +
                            "(start_time BETWEEN '" + sStartTime + "' AND '" + sEndTime + "') OR " +
                            "(end_time BETWEEN '" + sStartTime + "' AND '" + sEndTime + "') OR " +
                            "(start_time < '" + sStartTime + "' AND end_time > '" + sEndTime + "') OR " +
                            "(start_time > '" + sStartTime + "' AND end_time < '" + sEndTime + "'))";
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
            string sQuery = "insert into `gym`.`class_instance` (`id_class_instance`, `id_class`, `id_staff`, `date`, `start_time`, `end_time`, `frequency`, `id_room`) values " +
                     "(NULL, '" + this.SClass.Id_class + "', '" + this.Id_staff + "', '" + this.SDateStart + "', '" + this.SStartTime + "', '" + this.SEndTime + "', '" + this.SFrequency + "', '" + this.RRoom.Id_room + "');";

            int iIdClassInstance = conn.iInsert(sQuery);
            if (iIdClassInstance != -1)
                this.Id_class_instance = iIdClassInstance;
            else
                return false;

            return true;
        }
    }
}
