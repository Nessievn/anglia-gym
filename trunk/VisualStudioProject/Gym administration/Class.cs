//Variable naming conventions in this project:
//
//Class:
//ClassName
//
//Form Class:
//frm_windows_form
//
//Locally declared forms:
//frmWindowsForm
//
//Primitive types which are private or local to method:
//int iVariableName, string sVariableName
//
//Primitive types which are public or global:
//int IVariableName, string SVariableName
//
//Class type variables which are private or local:
//clClassName
//
//Class type variables which are public or global:
//ClClassName
//
//Exceptions:
//All table identifiers regardless of primitive type:
//
//Private/Local:
//id_entity_identifier
//
//Public/Global
//Id_entity_identifier




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
        private string sName;
        public string SName
        {
            get { return sName; }
            set { sName = value; }
        }

        // description field from CLASSES table stored here
        private string sDescription;
        public string SDescription
        {
            get { return sDescription; }
            set { sDescription = value; }
        }

        // type field from CLASSES table stored here
        private string sType;
        public string SType
        {
            get { return sType; }
            set { sType = value; }
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
         * @params [int id_Class] This identifies the class uniquely.
         * @return [none] No directly returned data.
         */
        public Class(int id_Class)
        {
            // Create mysql connection
            mySqlConn conn = new mySqlConn();
            conn.connect();
            // Launch the query to return all fields from a single "Gym Class" row of the CLASSES table
            List<Hashtable> lhResultset = conn.lhSqlQuery("Select * from classes WHERE id_class = '" + id_Class + "'");
            // Check if we found the row
            if ((int)lhResultset.Count > 0)
            {
                // Fill in all class fields with table data
                this.Id_class = int.Parse(lhResultset[0]["id_class"].ToString());
                this.SType = lhResultset[0]["type"].ToString();
                this.SDescription = lhResultset[0]["description"].ToString();
                this.SName = lhResultset[0]["name"].ToString();
            }
        }

        /**
         * @desc Removes the class from the CLASSES table.
         * @params [none] No input parameter.
         * @return [bool] Returns true in case of success, false if there was problem deleting the class.
         */
        public bool bRemove()
        {
            // Check if there is a class already loaded in
            if (this.Id_class != -1)
            {
                // Create mysql connection
                mySqlConn conn = new mySqlConn();
                conn.connect();
                // Create the delete query
                string sQuery = "DELETE FROM classes WHERE id_class = '" + this.Id_class + "'";
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


        /**
         * @desc This method will save or update a class in the CLASS table
         * @params [none] No input parameter.
         * @return [bool] Returns true in case of success, false if there was problem saving/updating the class
         */
        public bool bSave()
        {
            
            string sQuery;

            // Checking user input
            if (this.SName == "")
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
                    sQuery = "insert into `gym`.`classes` (`id_class`, `name`, `type`, `description`) values " +
                             "(NULL, '" + this.SName + "', '" + this.SType + "', '" + this.SDescription + "')";
                    // Launch save query
                    int id_Class = conn.iInsert(sQuery);
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
                    sQuery = "UPDATE classes SET name = '" + this.SName + "', description = '" + this.SDescription + "' " +
                             " WHERE id_class = '" + this.Id_class + "'";

                    // Launch update query
                    int iRes = conn.iDeleteOrUpdate(sQuery);
                    // Check update result
                    if (iRes > 0)
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
