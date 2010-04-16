using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Windows.Forms;

namespace Gym_administration
{

    /**
     * @desc It holds data and modifying methods for the ROOMS table. 
     * Most closely associated form is frm_room.
     * Most closely associated table is ROOMS.
     * @params [none] Incoming parameters are described at the individual constructors.
     * @return [none] No directly returned data. 
     * Returns of public methods are described at the individual methods.
     */
    class Room
    {
        // A field with the same name from MEMBERS table
        private int id_room;
        public int Id_room
        {
            get { return id_room; }
            set { id_room = value; }
        }

        // A field with the same name from MEMBERS table
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        // A field with the same name from MEMBERS table
        private int size;
        public int Size
        {
            get { return size; }
            set { size = value; }
        }

        // A field with the same name from MEMBERS table
        private string description;
        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        /**
         * @desc Default constructor.
         * Sets id_room to -1 so the fact of this is a new room can be referenced.
         * @params [none] No input parameter.
         * @return [none] No directly returned data.
         */        
        public Room()
        {
            this.id_room = -1;
        }


        /**
         * @desc Constructor
         * Loads in all fields from a single row of the ROOMS table.
         * @params [int] id_room identifies the room uniquely.
         * @return [none] No directly returned data.
         */
        public Room(int id_room)
        {
            // Create mysql connection
            mySqlConn conn = new mySqlConn();
            conn.connect();
            // Launch the query to return all fields from a single row of the ROOMS table
            List<Hashtable> lhResultset = conn.lhSqlQuery("Select * from rooms WHERE id_room = '" + id_room + "'");

            // Check if we found the room
            if ((int)lhResultset.Count > 0)
            {
                // Fill in all room fields with table data
                this.Id_room = int.Parse(lhResultset[0]["id_room"].ToString());
                this.Size = int.Parse(lhResultset[0]["size"].ToString());
                this.Description = lhResultset[0]["description"].ToString();
                this.Name = lhResultset[0]["name"].ToString();
            }
        }


        /**
         * @desc Removes the room from the ROOMS table.
         * @params [none] No input parameter.
         * @return [bool] Returns true in case of success, false if there was problem deleting the class.
         */
        public bool RemoveRoom()
        {
            if (this.Id_room != -1)
            {
                // Create mysql connection
                mySqlConn conn = new mySqlConn();
                conn.connect();
                // Create the delete query
                string query = "DELETE FROM rooms WHERE id_room = '"+this.Id_room+"'";
                // Launch delete query
                int result = conn.iDeleteOrUpdate(query);
                // Check deletion result
                if (result > 0)
                {
                    MessageBox.Show("The room data has been deleted succesfully!");
                    return true;
                }
                else
                {
                    MessageBox.Show("There was a problem deleting the room!");
                    return false;
                }
            }
            return false;
        }

        /**
         * @desc This method will save or update a room in the ROOMS table
         * @params [none] No input parameter.
         * @return [bool] Returns true in case of success, false if there was problem saving/updating the class
         */
        public bool SaveRoom()
        {

            string query;
            // Checking user input
            if (this.Name == "")
            {
                MessageBox.Show("Please Insert a name.");
            }
            else
            {
                // Create mysql connection
                mySqlConn conn = new mySqlConn();
                conn.connect();
                // Check whether there is a new id_room assigned to this room, 
                // if not then this a new room to save
                if (this.Id_room == -1)
                {
                    // Create insert query
                    query = "insert into `gym`.`rooms` (`id_room`, `name`, `size`, `description`) values " +
                             "(NULL, '" + this.Name + "', '" + this.Size + "', '" + this.Description + "')";
                    // Launch insert query
                    int id_room = conn.iInsert(query);
                    // Check saving result
                    if (id_room != -1)
                    {
                        this.Id_room = id_room;
                        MessageBox.Show("The new room has been added to the databse succesfully!");
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("There was a problem adding the new room, please check your data!");
                        return false;
                    }
                }
                // If an id_room already exists for this room instance, then this is an existing room to update
                else
                {
                    // Create update query
                    query = "UPDATE rooms SET name = '" + this.Name + "', size = '" + this.Size + "', description = '" + this.Description + "' " +
                             " WHERE id_room = '" + this.Id_room + "'";
                    // Launch update query
                    int result = conn.iDeleteOrUpdate(query);
                    // Check update reults
                    if (result > -1)
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
            return false;
        }
    }
}
