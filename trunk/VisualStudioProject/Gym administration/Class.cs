// Variable naming conventions in this project:
//
// Class name:
// ClassName 
// (stored in ClassName.cs)
//
// Windows Form Class name:
// frm_windows_form 
// (stored in frm_windows_form.cs)
//
// Locally declared forms:
// frmWindowsForm
//
// Primitive types:
// variableName
//
// Get/Set for primitive types:
// VariableName
//
// Arrays, Lists (type of objects are marked if locally declared class as cl (class) or h (hashtable))
// aArray, lList, lclClassList, lhHashtableList etc
//
// Get set for Arrays, Lists
// AArray, Llist, LclClassList etc
//
// Class type variables:
// clClassName
//
// Get/Set for class type variables :
// ClClassName
//
// Locally declared classes:
// cnClassName
//
// Exceptions:
// All entity identifiers regardless of primitive type:
//
// Private/Local:
// id_entity_identifier
//
// Public/Global
// Id_entity_identifier
//
// Method return type: bool bSave()



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Windows.Forms;

namespace Gym_administration
{
    /**
     * @desc It holds data and modifying methods for the CLASSES table. 
     * This is about "Gym Class" that is a general gym "class activity",
     * (NOT a certain class at a certain time!)
     * Most closely associated form is frm_class.
     * Most closely associated table is CLASSES.
     * @params [none] Incoming parameters are described at the individual constructors.
     * @return [none] No directly returned data. 
     * Returns of public methods are described at the individual methods.
     */
    class Class
    {
        // id_class field from CLASSES table stored here
        private int id_class;
        public int Id_class
        {
            get { return id_class; }
            set { id_class = value; }
        }

        // name field from CLASSES table stored here
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        // description field from CLASSES table stored here
        private string description;
        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        // type field from CLASSES table stored here
        private string type;
        public string Type
        {
            get { return type; }
            set { type = value; }
        }


        /**
         * @desc Default constructor.
         * Sets id_class to -1 so the fact of this is a new class can be referenced.
         * 
         * @params [none] No input parameter.
         * @return [none] No directly returned data.
         */
        public Class()
        {
            this.id_class = -1;
        }

        /**
         * @desc Constructor
         * Loads in all fields from a single "Gym Class" row of the CLASSES table.
         * @params [int] id_Class identifies the class uniquely.
         * @return [none] No directly returned data.
         */
        public Class(int id_Class)
        {
            // Create mysql connection
            mySqlConn conn = new mySqlConn();
            conn.connect();
            // Launch the query to return all fields from a single "Gym Class" row of the CLASSES table
            List<Hashtable> lhResultSet = conn.lhSqlQuery("Select * from classes WHERE id_class = '" + id_Class + "'");
            // Check if we found the row
            if ((int)lhResultSet.Count > 0)
            {
                // Fill in all class fields with table data
                this.Id_class = int.Parse(lhResultSet[0]["id_class"].ToString());
                this.Type = lhResultSet[0]["type"].ToString();
                this.Description = lhResultSet[0]["description"].ToString();
                this.Name = lhResultSet[0]["name"].ToString();
            }
        }

        /**
         * @desc Removes the class from the CLASSES table.
         * @params [none] No input parameter.
         * @return [bool] Returns true in case of success, false if there was problem deleting the class.
         */
        public bool RemoveClass()
        {
            // Check if there is a class already loaded in
            if (this.Id_class != -1)
            {
                // Create mysql connection
                mySqlConn conn = new mySqlConn();
                conn.connect();
                // Create the delete query
                string removeClassQuery = "DELETE FROM classes WHERE id_class = '" + this.Id_class + "'";
                // Launch delete query
                int result = conn.iDeleteOrUpdate(removeClassQuery);
                // Check deletion result
                if (result > 0)
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


        /**
         * @desc This method will save or update a class in the CLASS table
         * @params [none] No input parameter.
         * @return [bool] Returns true in case of success, false if there was problem saving/updating the class
         */
        public bool SaveClass()
        {
            
            string saveClassQuery;

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
                // Check whether there is a new id_class assigned to this class, 
                // if not then this a new class to save
                if (this.Id_class == -1)
                {
                    // Create the save query
                    saveClassQuery = "insert into `gym`.`classes` (`id_class`, `name`, `type`, `description`) values " +
                             "(NULL, '" + this.Name + "', '" + this.Type + "', '" + this.Description + "')";
                    // Launch save query
                    int id_Class = conn.iInsert(saveClassQuery);
                    // Check saving result
                    if (id_Class != -1)
                    {
                        this.Id_class = id_Class;
                        MessageBox.Show("The new class has been added to the databse succesfully!");
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("There was a problem adding the new class, please check your data!");
                        return false;
                    }
                }
                // If an id_class already exists for this class instance, then this is an existing class to update
                else
                {
                    // Create update query
                    saveClassQuery = "UPDATE classes SET name = '" + this.Name + "', description = '" + this.Description + "' " +
                             " WHERE id_class = '" + this.Id_class + "'";

                    // Launch update query
                    int result = conn.iDeleteOrUpdate(saveClassQuery);
                    // Check update result
                    if (result > 0)
                    {
                        MessageBox.Show("The class data has been updated succesfully!");
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("There was a problem updating the class information, please check your data!");
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
