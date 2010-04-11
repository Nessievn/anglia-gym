using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Windows.Forms;

namespace Gym_administration
{
    /**
     * @desc It holds data and modifying methods for the EQUIPMENT table. 
     * Most closely associated form is frm_equipment.
     * Most closely associated table is EQUIPMENT.
     * @params [none] Incoming parameters are described at the individual constructors.
     * @return [none] No directly returned data. 
     * Returns of public methods are described at the individual methods.
     */
    class Equipment
    {

        private int id_equipment;
        public int Id_equipment
        {
            get { return id_equipment; }
            set { id_equipment = value; }
        }

        //item,set,vehicle
        private string type;
        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        private int id_vehicle;
        public int Id_vehicle
        {
            get { return id_vehicle; }
            set { id_vehicle = value; }
        }

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string description;
        public string Description
        {
            get { return description; }
            set { description = value; }
        }


        private int itemInSet1;
        public int ItemInSet1
        {
            get { return itemInSet1; }
            set { itemInSet1 = value; }
        }
        private int amountInSet1;
        public int AmountInSet1
        {
            get { return amountInSet1; }
            set { amountInSet1 = value; }
        }
        private int itemInSet2;
        public int ItemInSet2
        {
            get { return itemInSet2; }
            set { itemInSet2 = value; }
        }
        private int amountInSet2;
        public int AmountInSet2
        {
            get { return amountInSet2; }
            set { amountInSet2 = value; }
        }
        private int itemInSet3;
        public int ItemInSet3
        {
            get { return itemInSet3; }
            set { itemInSet3 = value; }
        }
        private int amountInSet3;
        public int AmountInSet3
        {
            get { return amountInSet3; }
            set { amountInSet3 = value; }
        }
        private int itemInSet4;
        public int ItemInSet4
        {
            get { return itemInSet4; }
            set { itemInSet4 = value; }
        }
        private int amountInSet4;
        public int AmountInSet4
        {
            get { return amountInSet4; }
            set { amountInSet4 = value; }
        }
        private int itemInSet5;
        public int ItemInSet5
        {
            get { return itemInSet5; }
            set { itemInSet5 = value; }
        }
        private int amountInSet5;
        public int AmountInSet5
        {
            get { return amountInSet5; }
            set { amountInSet5 = value; }
        }

        
        public Equipment()
        {
            this.id_equipment = -1;
            mySqlConn conn = new mySqlConn();
            conn.connect();
        }

        public Equipment(int id_equipment)
        {
            mySqlConn conn = new mySqlConn();
            conn.connect();
            // We launch the query
            List<Hashtable> lhResultset = conn.lhSqlQuery("Select * from equipment WHERE id_equipment = '" + id_equipment + "'");

            // Check if we found the equipment
            if ((int)lhResultset.Count > 0)
            {
                this.Id_equipment = int.Parse(lhResultset[0]["id_equipment"].ToString());
                this.Type = lhResultset[0]["type"].ToString();
                this.Id_vehicle = int.Parse(lhResultset[0]["id_vehicle"].ToString());
                this.Name = lhResultset[0]["name"].ToString();
                this.Description = lhResultset[0]["description"].ToString();
                if (this.Type == "set")
                {
                    this.ItemInSet1 = int.Parse(lhResultset[0]["iteminset1"].ToString());
                    this.ItemInSet2 = int.Parse(lhResultset[0]["iteminset2"].ToString());
                    this.ItemInSet3 = int.Parse(lhResultset[0]["iteminset3"].ToString());
                    this.ItemInSet4 = int.Parse(lhResultset[0]["iteminset4"].ToString());
                    this.ItemInSet5 = int.Parse(lhResultset[0]["iteminset5"].ToString());
                    this.AmountInSet1 = int.Parse(lhResultset[0]["amountinset1"].ToString());
                    this.AmountInSet2 = int.Parse(lhResultset[0]["amountinset2"].ToString());
                    this.AmountInSet3 = int.Parse(lhResultset[0]["amountinset3"].ToString());
                    this.AmountInSet4 = int.Parse(lhResultset[0]["amountinset4"].ToString());
                    this.AmountInSet5 = int.Parse(lhResultset[0]["amountinset5"].ToString());
                }
                
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

            if (this.Name == "")
            {
                MessageBox.Show("Please Insert a name.");
            }
            else
            {
                mySqlConn conn = new mySqlConn();
                conn.connect();
                if (this.Id_equipment == -1)
                {
                    sQuery = "insert into `gym`.`equipment` (`id_equipment`, `type`, `id_vehicle`, `name`, `description`, `iteminset1`, `iteminset2`, `iteminset3`, `iteminset4`, `iteminset5`, `iteminset6`, `iteminset7`, `iteminset8`, `iteminset9`, `iteminset10`, `amountinset1`, `amountinset2`, `amountinset3`, `amountinset4`, `amountinset5`, `amountinset6`, `amountinset7`, `amountinset8`, `amountinset9`, `amountinset10`) values " +
                             "(NULL, '" + this.Type + "', '" + this.Id_vehicle + "', '" + this.Name + "', '" + this.Description
                             + "', '" + this.ItemInSet1 + "', '" + this.ItemInSet2 + "', '" + this.ItemInSet3 + "', '" + this.ItemInSet4 + "', '" + this.ItemInSet5
                             + "', '" + this.AmountInSet1 + "', '" + this.AmountInSet2 + "', '" + this.AmountInSet3 + "', '" + this.AmountInSet4 + "', '" + this.AmountInSet5 + "')";


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

                    sQuery = "UPDATE equipment SET type = '" + this.Type
                                       + "', id_vehicle = '" + this.Id_vehicle
                                             + "', name = '" + this.Name
                                      + "', description = '" + this.Description
                                       + "', iteminset1 = '" + this.ItemInSet1
                                       + "', iteminset2 = '" + this.ItemInSet2
                                       + "', iteminset3 = '" + this.ItemInSet3
                                       + "', iteminset4 = '" + this.ItemInSet4
                                       + "', iteminset5 = '" + this.ItemInSet5
                                     + "', amountinset1 = '" + this.AmountInSet1
                                     + "', amountinset2 = '" + this.AmountInSet2
                                     + "', amountinset3 = '" + this.AmountInSet3
                                     + "', amountinset4 = '" + this.AmountInSet4
                                     + "', amountinset5 = '" + this.AmountInSet5 + "' "
                                 + " WHERE id_equipment = '" + this.Id_equipment + "'";

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
