using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Windows.Forms;

namespace Gym_administration
{
    class Equipment
    {
        private int id_equipment;

        public int Id_equipment
        {
            get { return id_equipment; }
            set { id_equipment = value; }
        }
        private string sName;

        public string SName
        {
            get { return sName; }
            set { sName = value; }
        }
        private string sDescription;

        public string SDescription
        {
            get { return sDescription; }
            set { sDescription = value; }
        }
        private int sIdSet;

        public int SIdSet
        {
            get { return sIdSet; }
            set { sIdSet = value; }
        }
        public Equipment()
        {
            this.id_equipment = -1;
            mySqlConn conn = new mySqlConn();
            conn.connect();
        }

        public Equipment(int iIdEquipment)
        {
            mySqlConn conn = new mySqlConn();
            conn.connect();
            // We launch the query
            List<Hashtable> lhResultset = conn.lhSqlQuery("Select * from equipment WHERE id_equipment = '" + iIdEquipment + "'");

            // Check if we found the member
            if ((int)lhResultset.Count > 0)
            {
                this.Id_equipment = int.Parse(lhResultset[0]["id_equipment"].ToString());
                this.SName = lhResultset[0]["name"].ToString();
                this.SDescription = lhResultset[0]["description"].ToString();
                this.SIdSet = int.Parse(lhResultset[0]["id_set"].ToString());
                
                
            }
        }

        public bool bRemove()
        {
            if (this.Id_equipment != -1)
            {
                mySqlConn conn = new mySqlConn();
                conn.connect();
                string sQuery = "DELETE FROM equipment WHERE id_equipment = '" + this.Id_equipment + "'";
                int iRes = conn.iDeleteOrUpdate(sQuery);
                if (iRes > 0)
                {
                    MessageBox.Show("The equipment data has been deleted succesfully!");
                    return true;
                }
                else
                {
                    MessageBox.Show("There was a problem deleting the equipment!");
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
                if (this.Id_equipment == -1)
                {
                    sQuery = "insert into `gym`.`equipment` (`id_equipment`, `name`, `description`, `id_set`) values " +
                             "(NULL, '" + this.SName + "', '" + this.SDescription + "', '" + this.SIdSet + "')";

                    int iIdEquipment = conn.iInsert(sQuery);
                    if (iIdEquipment != -1)
                    {
                        this.Id_equipment = iIdEquipment;
                        MessageBox.Show("The new equipment has been added to the databse succesfully!");
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("There was a problem adding the new equipment, please check your data!");
                        return false;
                    }
                }
                else
                {
                    sQuery = "UPDATE equipment SET name = '" + this.SName + "', id_set = '" + this.SIdSet + "', description = '" + this.SDescription + "' " +
                             " WHERE id_equipment = '" + this.Id_equipment + "'";

                    int iRes = conn.iDeleteOrUpdate(sQuery);
                    if (iRes > 0)
                    {
                        MessageBox.Show("The equipment data has been updated succesfully!");
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("There was a problem updating the equipment information, please check your data!");
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
