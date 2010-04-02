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

        //item,set,vehicle
        private string sType;
        public string SType
        {
            get { return sType; }
            set { sType = value; }
        }

          private int sId_Vehicle;
        public int SId_Vehicle
        {
            get { return sId_Vehicle; }
            set { sId_Vehicle = value; }
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

        private int sCurrentlyInStock;
        public int SCurrentlyInStock
        {
            get { return sCurrentlyInStock; }
            set { sCurrentlyInStock = value; }
        }




        private string sItemInSet1;
        public string SItemInSet1
        {
            get { return sItemInSet1; }
            set { sItemInSet1 = value; }
        }
        private int sAmountInSet1;
        public int SAmountInSet1
        {
            get { return sAmountInSet1; }
            set { sAmountInSet1 = value; }
        }
        private string sItemInSet2;
        public string SItemInSet2
        {
            get { return sItemInSet2; }
            set { sItemInSet2 = value; }
        }
        private int sAmountInSet2;
        public int SAmountInSet2
        {
            get { return sAmountInSet2; }
            set { sAmountInSet2 = value; }
        }
        private string sItemInSet3;
        public string SItemInSet3
        {
            get { return sItemInSet3; }
            set { sItemInSet3 = value; }
        }
        private int sAmountInSet3;
        public int SAmountInSet3
        {
            get { return sAmountInSet3; }
            set { sAmountInSet3 = value; }
        }
        private string sItemInSet4;
        public string SItemInSet4
        {
            get { return sItemInSet4; }
            set { sItemInSet4 = value; }
        }
        private int sAmountInSet4;
        public int SAmountInSet4
        {
            get { return sAmountInSet4; }
            set { sAmountInSet4 = value; }
        }
        private string sItemInSet5;
        public string SItemInSet5
        {
            get { return sItemInSet5; }
            set { sItemInSet5 = value; }
        }
        private int sAmountInSet5;
        public int SAmountInSet5
        {
            get { return sAmountInSet5; }
            set { sAmountInSet5 = value; }
        }
        private string sItemInSet6;
        public string SItemInSet6
        {
            get { return sItemInSet6; }
            set { sItemInSet6 = value; }
        }
        private int sAmountInSet6;
        public int SAmountInSet6
        {
            get { return sAmountInSet6; }
            set { sAmountInSet6 = value; }
        }
        private string sItemInSet7;
        public string SItemInSet7
        {
            get { return sItemInSet7; }
            set { sItemInSet7 = value; }
        }
        private int sAmountInSet7;
        public int SAmountInSet7
        {
            get { return sAmountInSet7; }
            set { sAmountInSet7 = value; }
        }
        private string sItemInSet8;
        public string SItemInSet8
        {
            get { return sItemInSet8; }
            set { sItemInSet8 = value; }
        }
        private int sAmountInSet8;
        public int SAmountInSet8
        {
            get { return sAmountInSet8; }
            set { sAmountInSet8 = value; }
        }
        private string sItemInSet9;
        public string SItemInSet9
        {
            get { return sItemInSet9; }
            set { sItemInSet9 = value; }
        }
        private int sAmountInSet9;
        public int SAmountInSet9
        {
            get { return sAmountInSet9; }
            set { sAmountInSet9 = value; }
        }
        private string sItemInSet10;
        public string SItemInSet10
        {
            get { return sItemInSet10; }
            set { sItemInSet10 = value; }
        }
        private int sAmountInSet10;
        public int SAmountInSet10
        {
            get { return sAmountInSet10; }
            set { sAmountInSet10 = value; }
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

            // Check if we found the equipment
            if ((int)lhResultset.Count > 0)
            {
                this.Id_equipment = int.Parse(lhResultset[0]["id_equipment"].ToString());
                this.SType = lhResultset[0]["type"].ToString();
                //this.SId_Set = int.Parse(lhResultset[0]["id_set"].ToString());
                this.SId_Vehicle = int.Parse(lhResultset[0]["id_vehicle"].ToString());
                this.SName = lhResultset[0]["name"].ToString();
                this.SDescription = lhResultset[0]["description"].ToString();
                this.SCurrentlyInStock = int.Parse(lhResultset[0]["currentlyinstock"].ToString());
                if (this.sType == "set")
                {
                    this.SItemInSet1 = lhResultset[0]["iteminset1"].ToString();
                    this.SItemInSet2 = lhResultset[0]["iteminset2"].ToString();
                    this.SItemInSet3 = lhResultset[0]["iteminset3"].ToString();
                    this.SItemInSet4 = lhResultset[0]["iteminset4"].ToString();
                    this.SItemInSet5 = lhResultset[0]["iteminset5"].ToString();
                    this.SItemInSet6 = lhResultset[0]["iteminset6"].ToString();
                    this.SItemInSet7 = lhResultset[0]["iteminset7"].ToString();
                    this.SItemInSet8 = lhResultset[0]["iteminset8"].ToString();
                    this.SItemInSet9 = lhResultset[0]["iteminset9"].ToString();
                    this.SItemInSet10 = lhResultset[0]["iteminset10"].ToString();
                    this.SAmountInSet1 = int.Parse(lhResultset[0]["amountinset1"].ToString());
                    this.SAmountInSet2 = int.Parse(lhResultset[0]["amountinset2"].ToString());
                    this.SAmountInSet3 = int.Parse(lhResultset[0]["amountinset3"].ToString());
                    this.SAmountInSet4 = int.Parse(lhResultset[0]["amountinset4"].ToString());
                    this.SAmountInSet5 = int.Parse(lhResultset[0]["amountinset5"].ToString());
                    this.SAmountInSet6 = int.Parse(lhResultset[0]["amountinset6"].ToString());
                    this.SAmountInSet7 = int.Parse(lhResultset[0]["amountinset7"].ToString());
                    this.SAmountInSet8 = int.Parse(lhResultset[0]["amountinset8"].ToString());
                    this.SAmountInSet9 = int.Parse(lhResultset[0]["amountinset9"].ToString());
                    this.SAmountInSet10 = int.Parse(lhResultset[0]["amountinset10"].ToString());
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
                    sQuery = "insert into `gym`.`equipment` (`id_equipment`, `type`, `id_vehicle`, `name`, `description`, `currentlyinstock`, `iteminset1`, `iteminset2`, `iteminset3`, `iteminset4`, `iteminset5`, `iteminset6`, `iteminset7`, `iteminset8`, `iteminset9`, `iteminset10`, `amountinset1`, `amountinset2`, `amountinset3`, `amountinset4`, `amountinset5`, `amountinset6`, `amountinset7`, `amountinset8`, `amountinset9`, `amountinset10`) values " +
                             "(NULL, '" + this.Id_equipment + "','" + this.SType + "', '" + this.SId_Vehicle + "', '" + this.SName + "', '" + this.SDescription + "', '" + this.SCurrentlyInStock
                             + "', '" + this.SItemInSet1 + "', '" + this.SItemInSet2 + "', '" + this.SItemInSet3 + "', '" + this.SItemInSet4 + "', '" + this.SItemInSet5
                             + "', '" + this.SItemInSet6 + "', '" + this.SItemInSet7 + "', '" + this.SItemInSet8 + "', '" + this.SItemInSet9 + "', '" + this.SItemInSet10
                             + "', '" + this.SAmountInSet1 + "', '" + this.SAmountInSet2 + "', '" + this.SAmountInSet3 + "', '" + this.SAmountInSet4 + "', '" + this.SAmountInSet5
                             + "', '" + this.SAmountInSet6 + "', '" + this.SAmountInSet7 + "', '" + this.SAmountInSet8 + "', '" + this.SAmountInSet9 + "', '" + this.SAmountInSet10 + "')";

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
                    
                    sQuery = "UPDATE equipment SET type = '" + this.SType
                                         /*+ "', id_set = '" + this.SId_Set*/
                                       + "', id_vehicle = '" + this.SId_Vehicle
                                             + "', name = '" + this.SName
                                      + "', description = '" + this.SDescription
                                 + "', currentlyinstock = '" + this.SCurrentlyInStock
                                       + "', iteminset1 = '" + this.SItemInSet1
                                       + "', iteminset2 = '" + this.SItemInSet2
                                       + "', iteminset3 = '" + this.SItemInSet3
                                       + "', iteminset4 = '" + this.SItemInSet4
                                       + "', iteminset5 = '" + this.SItemInSet5
                                       + "', iteminset6 = '" + this.SItemInSet6
                                       + "', iteminset7 = '" + this.SItemInSet7
                                       + "', iteminset8 = '" + this.SItemInSet8
                                       + "', iteminset9 = '" + this.SItemInSet9
                                      + "', iteminset10 = '" + this.SItemInSet10
                                     + "', amountinset1 = '" + this.SAmountInSet1
                                     + "', amountinset2 = '" + this.SAmountInSet2
                                     + "', amountinset3 = '" + this.SAmountInSet3
                                     + "', amountinset4 = '" + this.SAmountInSet4
                                     + "', amountinset5 = '" + this.SAmountInSet5
                                     + "', amountinset6 = '" + this.SAmountInSet6
                                     + "', amountinset7 = '" + this.SAmountInSet7
                                     + "', amountinset8 = '" + this.SAmountInSet8
                                     + "', amountinset9 = '" + this.SAmountInSet9
                                    + "', amountinset10 = '" + this.SAmountInSet10 + "' " 
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
