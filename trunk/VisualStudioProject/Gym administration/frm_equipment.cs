using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Gym_administration
{
    public partial class frm_equipment : Form
    {
        Equipment mbrEquipment;
        MyMessageBox myMessagebox;
        frm_equipment_list frmEqList;
        bool IsBooking;
        bool IsMember;
        int Id_Person;
        

        //loading from main menu
        public frm_equipment()
        {
            InitializeComponent();
            mbrEquipment = new Equipment();
            myMessageBox = new MyMessageBox();
            
            this.frmEqList = null;
            button_vehicle.Show();
            rd_item.Checked = true;
            rd_item_Checked();




            
            


        }

        //loading from equipment list to refresh list after saving added new item to itemlist
        public frm_equipment(frm_equipment_list frmEqList)
        {
            InitializeComponent();
            mbrEquipment = new Equipment();
            this.frmEqList = frmEqList;
            button_vehicle.Show();
            rd_item.Checked = true;
            rd_item_Checked();

        }
/*
        //loading from equipment list to refresh list after saving edited item
        public frm_equipment(bool isBooking, bool isMember, int Id_Person, int iEquipmentId, frm_equipment_list frmEqList)
        {
            if (isBooking)
            {
                frm_equipment_booking_ini(isMember, Id_Person, iEquipmentId, frmEqList);

            }
            else
            {
                frm_equipment_ini(iEquipmentId, frmEqList);
            }
        }

        public void frm_equipment_booking_ini(bool isMember, int Id_Person, int iEquipmentId, frm_equipment_list frmEqList)
        {
            InitializeComponent();
            mbrEquipment = new Equipment(iEquipmentId);
            this.frmEqList = frmEqList;



        }


        public void frm_equipment_ini(int iEquipmentId, frm_equipment_list frmEqList)
        {
 */
        public frm_equipment(bool isBooking, bool isMember, int id_Person, int iEquipmentId, frm_equipment_list frmEqList)
        {
            InitializeComponent();
            mbrEquipment = new Equipment(iEquipmentId);
            this.frmEqList = frmEqList;
            IsBooking = isBooking;
            IsMember = isMember;
            Id_Person = id_Person;

            if (IsBooking)
            {
                button_save.Text = "Borrow";
            }
            else
            {
                button_save.Text = "Save";
            }




            if (mbrEquipment.Id_equipment < 1)
                MessageBox.Show("The equipment could not be found");
            else
            {
                if (mbrEquipment.SType == "item")
                {
                    button_vehicle.Hide();
                    rd_item.Checked = true;
                    rd_item_Checked();
                    rd_set.Hide();
                    txt_itemname.Text = mbrEquipment.SName;
                    counter_stock.Value = mbrEquipment.SCurrentlyInStock;
                    txt_equipmentdesc.Text = mbrEquipment.SDescription;

  
                }

                else if (mbrEquipment.SType == "set")
                {
                    button_vehicle.Hide();
                    rd_set.Checked = true;
                    rd_set_Checked();
                    rd_item.Hide();
                    txt_setname.Text = mbrEquipment.SName;
                    txt_equipmentdesc.Text = mbrEquipment.SDescription;


 

                }
                else if (mbrEquipment.SType == "vehicle")
                {
                    //OPEN NEW WINDOW FOR VEHICLES
                    MessageBox.Show("vehicles are going to be here");
                }



            }
        }
        
        
        //set loadup state
        private void frm_equipment_Load(object sender, EventArgs e)
        {
            //rd_item.Checked = true;
 
        }


 
        //SAVE
        private void button_save_Click(object sender, EventArgs e)
        {
            //string sType = (rd_group.Checked) ? "Set Name" : "Set Item";
            

         

            if (rd_item.Checked == true)
            {

                if (txt_itemname.Text.Length == 0)
                {
                    MessageBox.Show("Please insert a name for the equipment.");
                    return;
                }
                mbrEquipment.SType = "item";
                mbrEquipment.SName = txt_itemname.Text;
                mbrEquipment.SDescription = txt_equipmentdesc.Text;
                mbrEquipment.SCurrentlyInStock = int.Parse(counter_stock.Value.ToString());


                

            }
            else if (rd_set.Checked == true)
            {
                if (txt_setname.Text.Length == 0)
                {
                    MessageBox.Show("Please insert a name for the set.");
                    return;
                }
                mbrEquipment.SType = "set";
                mbrEquipment.SName = txt_setname.Text;
                mbrEquipment.SDescription = txt_equipmentdesc.Text;

                if (cmb_item1.SelectedIndex < 1)
                {
                    MessageBox.Show("Please select at least one item for the set!");
                    return;
                }

                if (cmb_item1.SelectedIndex > 0)
                {
                    DictionaryEntry de = (DictionaryEntry)cmb_item1.SelectedItem;
                    mbrEquipment.SItemInSet1 = de.Value.ToString();
                }
                mbrEquipment.SAmountInSet1 = int.Parse(counter_item1.Value.ToString());

                if (cmb_item2.SelectedIndex > 0)
                {
                    DictionaryEntry de2 = (DictionaryEntry)cmb_item2.SelectedItem;
                    mbrEquipment.SItemInSet2 = de2.Value.ToString();
                }
                mbrEquipment.SAmountInSet2 = int.Parse(counter_item2.Value.ToString());

                if (cmb_item3.SelectedIndex > 0)
                {
                    DictionaryEntry de3 = (DictionaryEntry)cmb_item3.SelectedItem;
                    mbrEquipment.SItemInSet3 = de3.Value.ToString();
                }
                mbrEquipment.SAmountInSet3 = int.Parse(counter_item3.Value.ToString());

                if (cmb_item4.SelectedIndex > 0)
                {
                    DictionaryEntry de4 = (DictionaryEntry)cmb_item4.SelectedItem;
                    mbrEquipment.SItemInSet4 = de4.Value.ToString();
                }
                mbrEquipment.SAmountInSet4 = int.Parse(counter_item4.Value.ToString());

                if (cmb_item5.SelectedIndex > 0)
                {
                    DictionaryEntry de5 = (DictionaryEntry)cmb_item5.SelectedItem;
                    mbrEquipment.SItemInSet5 = de5.Value.ToString();
                }
                mbrEquipment.SAmountInSet5 = int.Parse(counter_item5.Value.ToString());

            }


            mbrEquipment.bSave();
            //call list reload in parent form
                //if frmEqlist is null, then this form was called from the main menu and list reload is not necessary
            if (this.frmEqList != null) frmEqList.vLoadEqList(mbrEquipment.SType);
            this.Close();
        }

        //CANCEL
        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //REMOVE
        private void button_remove_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure?", "Delete entry", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                //call list reload in parent form
                //if frmEqlist is null, then this form was called from the main menu and list reload is not necessary
                if (this.frmEqList != null) frmEqList.vLoadEqList(mbrEquipment.SType);
                mbrEquipment.bRemove();
                this.Close();
            }
        }

private void button_vehicle_Click(object sender, EventArgs e)
{

    //MessageBox.Show("vehicles are going to be here");
    //DictionaryEntry de1 = (DictionaryEntry)cmb_item1.SelectedItem;
    //MessageBox.Show(de1.Key.ToString());
  /*  MessageBox.Show(cmb_item1.SelectedIndex.ToString() + "/n" + 
        cmb_item2.SelectedIndex.ToString() + "/n" + 
        cmb_item3.SelectedIndex.ToString() + "/n" + 
        cmb_item4.SelectedIndex.ToString() + "/n" + 
        cmb_item5.SelectedIndex.ToString());*/



            

    


}

        private void rd_item_Checked(object sender, EventArgs e)
        {
            rd_item_Checked();
        }
        private void rd_item_Checked()
        {


            label_iteminfo.Show();
            label_itemsetinfo.Hide();

            label_itemname.Enabled = true;
            txt_itemname.Enabled = true;

            label_setname.Enabled = false;
            txt_setname.Enabled = false;
            txt_setname.Text = "";

 

            label_stock.Enabled = true;
            counter_stock.Enabled = true;

            label_itemdesc.Show();
            label_itemsetdesc.Hide();
            //txt_equipmentdesc.Show();


            label_iteminset.Enabled = false;
            label_itemamount.Enabled = false;
            cmb_item1.Enabled = false;
            cmb_item2.Enabled = false;
            cmb_item3.Enabled = false;
            cmb_item4.Enabled = false;
            cmb_item5.Enabled = false;
            counter_item1.Enabled = false;
            counter_item2.Enabled = false;
            counter_item3.Enabled = false;
            counter_item4.Enabled = false;
            counter_item5.Enabled = false;
            
        }

        private void rd_set_Checked(object sender, EventArgs e)
        {
            rd_set_Checked();
        }

        private void rd_set_Checked()
        {

            mySqlConn conn = new mySqlConn();
            conn.connect();



            

            // Loading Available Items
            string sQuery = "SELECT id_equipment, name FROM equipment WHERE type = 'item' ORDER BY id_equipment";
            ArrayList myItems1 = conn.alGetComboFromDb(sQuery, "id_equipment", "name");
            ArrayList myItems2 = conn.alGetComboFromDb(sQuery, "id_equipment", "name");
            ArrayList myItems3 = conn.alGetComboFromDb(sQuery, "id_equipment", "name");
            ArrayList myItems4 = conn.alGetComboFromDb(sQuery, "id_equipment", "name");
            ArrayList myItems5 = conn.alGetComboFromDb(sQuery, "id_equipment", "name");

            //cmb_item1.SelectedIndex = 0;
            DictionaryEntry dent = (DictionaryEntry)myItems1[0];
            //mbrEquipment.SItemInSet1 = de.Value.ToString();

            dent.Value = "none";
            dent.Key = "0";


            myItems1.Insert(0, dent);
            myItems2.Insert(0, dent);
            myItems3.Insert(0, dent);
            myItems4.Insert(0, dent);
            myItems5.Insert(0, dent);

            cmb_item1.DisplayMember = "Value";
            cmb_item1.DataSource = myItems1;

            cmb_item2.DisplayMember = "Value";
            //myItems2.Insert(0, "none");
            cmb_item2.DataSource = myItems2;
            cmb_item3.DisplayMember = "Value";
            //myItems3.Insert(0, "none");
            cmb_item3.DataSource = myItems3;
            cmb_item4.DisplayMember = "Value";
            //myItems4.Insert(0, "none");
            cmb_item4.DataSource = myItems4;
            cmb_item5.DisplayMember = "Value";
            //myItems5.Insert(0, "none");
            cmb_item5.DataSource = myItems5;
            //cmb_item6.DataSource = myItems;
            //cmb_item7.DataSource = myItems;
            //cmb_item8.DataSource = myItems;
            //cmb_item9.DataSource = myItems;
            //cmb_item10.DataSource = myItems;

            cmb_item1.SelectedIndex = cmb_item1.FindString(mbrEquipment.SItemInSet1);
            cmb_item2.SelectedIndex = cmb_item2.FindString(mbrEquipment.SItemInSet2);
            cmb_item3.SelectedIndex = cmb_item3.FindString(mbrEquipment.SItemInSet3);
            cmb_item4.SelectedIndex = cmb_item4.FindString(mbrEquipment.SItemInSet4);
            cmb_item5.SelectedIndex = cmb_item5.FindString(mbrEquipment.SItemInSet5);
            //cmb_item6.SelectedIndex = mbrEquipment.SItemInSet6;
            //cmb_item7.SelectedIndex = mbrEquipment.SItemInSet7;
            //cmb_item8.SelectedIndex = mbrEquipment.SItemInSet8;
            //cmb_item9.SelectedIndex = mbrEquipment.SItemInSet9;
            //cmb_item10.SelectedIndex = mbrEquipment.SItemInSet10;
            counter_item1.Value = mbrEquipment.SAmountInSet1;
            counter_item2.Value = mbrEquipment.SAmountInSet2;
            counter_item3.Value = mbrEquipment.SAmountInSet3;
            counter_item4.Value = mbrEquipment.SAmountInSet4;
            counter_item5.Value = mbrEquipment.SAmountInSet5;
            //counter_item6.Value = mbrEquipment.SAmountInSet6;
            //counter_item7.Value = mbrEquipment.SAmountInSet7;
            //counter_item8.Value = mbrEquipment.SAmountInSet8;
            //counter_item9.Value = mbrEquipment.SAmountInSet9;
            //counter_item10.Value = mbrEquipment.SAmountInSet10;




            label_iteminfo.Hide();
            label_itemsetinfo.Show();

            label_itemname.Enabled = false;
            txt_itemname.Enabled = false;

            label_setname.Enabled = true;
            txt_setname.Enabled = true;


            label_stock.Enabled = false;
            counter_stock.Enabled = false;

            label_itemdesc.Hide();
            label_itemsetdesc.Show();
            //txt_equipmentdesc;


            label_iteminset.Enabled = true;
            label_itemamount.Enabled = true;

            cmb_item1.Enabled = true;
            if (cmb_item1.SelectedIndex < 1) cmb_item2.Enabled = false;
            if (cmb_item2.SelectedIndex < 1) cmb_item3.Enabled = false;
            if (cmb_item3.SelectedIndex < 1) cmb_item4.Enabled = false;
            if (cmb_item4.SelectedIndex < 1) cmb_item5.Enabled = false;






            if (cmb_item1.SelectedIndex < 1) counter_item2.Enabled = false;
            if (cmb_item2.SelectedIndex < 1) counter_item3.Enabled = false;
            if (cmb_item3.SelectedIndex < 1) counter_item4.Enabled = false;
            if (cmb_item4.SelectedIndex < 1) counter_item5.Enabled = false;
        }

        private void cmb_item1_SelectedIndexChanged(object sender, EventArgs e)
        {

          

            if (cmb_item1.SelectedIndex > 0)
            {
                counter_item1.Enabled = true;
                counter_item1.Value = 1;
                cmb_item2.Enabled = true;
                
            }
            else
            {
                if (cmb_item2.SelectedIndex < 1)
                {
                    counter_item1.Enabled = false;
                    counter_item1.Value = 0;
                    cmb_item2.Enabled = false;
                    cmb_item2.SelectedIndex = -1;
                    counter_item2.Enabled = false;
                    counter_item2.Value = 0;
                    cmb_item3.Enabled = false;
                    cmb_item3.SelectedIndex = -1;
                    counter_item3.Enabled = false;
                    counter_item3.Value = 0;
                    cmb_item4.Enabled = false;
                    cmb_item4.SelectedIndex = -1;
                    counter_item4.Enabled = false;
                    counter_item4.Value = 0;
                    cmb_item5.Enabled = false;
                    cmb_item5.SelectedIndex = -1;
                    counter_item5.Enabled = false;
                }
            }
        }

        private void cmb_item2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
 


            if (cmb_item2.SelectedIndex > 0)
            {
                counter_item2.Enabled = true;
                counter_item2.Value = 1;
                cmb_item3.Enabled = true;
                
            }
            else
            {
                if (cmb_item3.SelectedIndex < 1)
                {
                    counter_item2.Enabled = false;
                    counter_item2.Value = 0;
                    //cmb_item2.SelectedIndex = -1;
                    cmb_item3.Enabled = false;
                    cmb_item3.SelectedIndex = -1;
                    counter_item3.Enabled = false;
                    counter_item3.Value = 0;
                    cmb_item4.Enabled = false;
                    cmb_item4.SelectedIndex = -1;
                    counter_item4.Enabled = false;
                    counter_item4.Value = 0;
                    cmb_item5.Enabled = false;
                    cmb_item5.SelectedIndex = -1;
                    counter_item5.Enabled = false;
                }
            }
        }

        private void cmb_item3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_item3.SelectedIndex > 0)
            {
                counter_item3.Enabled = true;
                counter_item3.Value = 1;
                cmb_item4.Enabled = true;
            }
            else
            {
                if (cmb_item4.SelectedIndex < 1)
                {
                    counter_item3.Enabled = false;
                    counter_item3.Value = 0;
                    //cmb_item3.SelectedIndex = -1;
                    cmb_item4.Enabled = false;
                    cmb_item4.SelectedIndex = -1;
                    counter_item4.Enabled = false;
                    counter_item4.Value = 0;
                    cmb_item5.Enabled = false;
                    cmb_item5.SelectedIndex = -1;
                    counter_item5.Enabled = false;
                }
            }
        }

        private void cmb_item4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_item4.SelectedIndex > 0)
            {
                counter_item4.Enabled = true;
                counter_item4.Value = 1;
                cmb_item5.Enabled = true;
            }
            else
            {
                if (cmb_item5.SelectedIndex < 1)
                {
                    counter_item4.Enabled = false;
                    counter_item4.Value = 0;
                    //cmb_item4.SelectedIndex = -1;
                    cmb_item5.Enabled = false;
                    cmb_item5.SelectedIndex = -1;
                    counter_item5.Enabled = false;
                }
            }
        }




        private void cmb_item5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_item5.SelectedIndex > 0)
            {
                counter_item5.Enabled = true;
                counter_item5.Value = 1;
            }

            else
            {
                counter_item5.Enabled = false;
                counter_item5.Value = 0;
            }
                
        }




      




  

   




  
    }
}
