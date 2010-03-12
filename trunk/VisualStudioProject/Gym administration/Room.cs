using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Windows.Forms;

namespace Gym_administration
{
    class Room
    {
        private int id_room;

        public int Id_room
        {
            get { return id_room; }
            set { id_room = value; }
        }
        private string sName;

        public string SName
        {
            get { return sName; }
            set { sName = value; }
        }
        private int iSize;

        public int ISize
        {
            get { return iSize; }
            set { iSize = value; }
        }
        private string sDescription;

        public string SDescription
        {
            get { return sDescription; }
            set { sDescription = value; }
        }
        public Room()
        {
            this.id_room = 0;
        }

        public Room(int iIdRoom)
        {
            mySqlConn conn = new mySqlConn();
            conn.connect();
            // We launch the query
            List<Hashtable> lhResultset = conn.lhSqlQuery("Select * from rooms WHERE id_room = '" + iIdRoom + "'");

            // Check if we found the member
            if ((int)lhResultset.Count > 0)
            {
                this.Id_room = int.Parse(lhResultset[0]["id_room"].ToString());
                this.ISize = int.Parse(lhResultset[0]["size"].ToString());
                this.SDescription = lhResultset[0]["description"].ToString();
                this.SName = lhResultset[0]["name"].ToString();
            }
        }

        /**
        * @desc This method will save the object into the database
        */
        public bool bSave()
        {
            // Field checking
            string sQuery;

            if (this.SName == "")
            {
                MessageBox.Show("Please Insert a name.");
            }
            else
            {
                mySqlConn conn = new mySqlConn();
                conn.connect();
                if (this.Id_room == 0)
                {
                    sQuery = "insert into `gym`.`rooms` (`id_room`, `name`, `size`, `description`) values " +
                             "(NULL, '" + this.SName + "', '" + this.ISize + "', '" + this.SDescription + "')";

                    int iIdRoom = conn.iInsert(sQuery);
                    if (iIdRoom > 1)
                    {
                        this.Id_room = iIdRoom;
                        MessageBox.Show("The new room has been added to the databse succesfully!");
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("There was a problem adding the new room, please check your data!");
                        return false;
                    }
                }
                else
                {
                    sQuery = "UPDATE rooms SET name = '" + this.SName + "', size = '" + this.ISize + "', description = '" + this.SDescription + "' " +
                             " WHERE id_room = '" + this.Id_room + "'";

                    int iRes = conn.iDeleteOrUpdate(sQuery);
                    if (iRes > 0)
                    {
                        MessageBox.Show("The room data has been updated succesfully!");
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("There was a problem updating the room information, please check your data!");
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
