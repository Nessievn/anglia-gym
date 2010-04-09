﻿/**
 * @desc It returns...etc
 * 
 * @params [type] 
 * @return [type] 
 */

//

//Constructor (default)     
//Constructor (id_class)    loads in all fields from a single "Gym Class" row of the CLASSES table
//Method 1
//bRemove   removes a class from the CLASSES table
//Method 2
//bSave     saves a new class to the CLASSES table

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Windows.Forms;

namespace Gym_administration
{

    /**
     * @desc It holds data and modifying methods for CLASSES table. 
     * This is about "Gym Class" that is a general gym "class activity",
     * (NOT a certain class at a certain time!)
     * Most closely associated form is frm_class.
     * Most closely associated table is CLASSES.
     * @params Incoming parameters are described at the individual constructors.
     * @return All constructors are void types.
     */
    class Class
    {
        private int id_class;
        public int Id_class
        {
            get { return id_class; }
            set { id_class = value; }
        }

        private string sName;
        public string SName
        {
            get { return sName; }
            set { sName = value; }
        }


        private string sType;
        public string SType
        {
            get { return sType; }
            set { sType = value; }
        }

        private string sDescription;
        public string SDescription
        {
            get { return sDescription; }
            set { sDescription = value; }
        }


        /**
         * @desc Default constructor.
         * It sets id_class to -1 and establishes connection for saving new class.
         * 
         * @params [type] 
         * @return [type] 
         */
        public Class()
        {
            this.id_class = -1;
    //        mySqlConn conn = new mySqlConn();
      //      conn.connect();
        }

        public Class(int iIdClass)
        {
            mySqlConn conn = new mySqlConn();
            conn.connect();
            // We launch the query
            List<Hashtable> lhResultset = conn.lhSqlQuery("Select * from classes WHERE id_class = '" + iIdClass + "'");

            // Check if we found the member
            if ((int)lhResultset.Count > 0)
            {
                this.Id_class = int.Parse(lhResultset[0]["id_class"].ToString());
                this.SType = lhResultset[0]["type"].ToString();
                this.SDescription = lhResultset[0]["description"].ToString();
                this.SName = lhResultset[0]["name"].ToString();
            }
        }

        public bool bRemove()
        {
            if (this.Id_class != -1)
            {
                mySqlConn conn = new mySqlConn();
                conn.connect();
                string sQuery = "DELETE FROM classes WHERE id_class = '" + this.Id_class + "'";
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
                if (this.Id_class == -1)
                {
                    sQuery = "insert into `gym`.`classes` (`id_class`, `name`, `type`, `description`) values " +
                             "(NULL, '" + this.SName + "', '" + this.SType + "', '" + this.SDescription + "')";

                    int iIdClass = conn.iInsert(sQuery);
                    if (iIdClass != -1)
                    {
                        this.Id_class = iIdClass;
                        MessageBox.Show("The new class has been added to the databse succesfully!");
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("There was a problem adding the new class, please check your data!");
                        return false;
                    }
                }
                else
                {
                    sQuery = "UPDATE classes SET name = '" + this.SName + "', description = '" + this.SDescription + "' " +
                             " WHERE id_class = '" + this.Id_class + "'";

                    int iRes = conn.iDeleteOrUpdate(sQuery);
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
