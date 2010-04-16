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
        Equipment clEquipment;
        EquipmentBooked clEquipmentBooked;
        frm_message_box frmMessageBox;
        frm_equipment_list frmEqList;
        bool IsBooking;
        int Id_member;
        int Id_staff;
        int Id_class_instance;


        //loading from main menu
        public frm_equipment()
        {
            InitializeComponent();
            clEquipment = new Equipment();
            this.frmEqList = null;
            button_vehicle.Show();
            rd_item.Checked = true;
            rd_item_Checked();
        }

        //loading from equipment list to refresh eq list after saving added new item to itemlist
        public frm_equipment(frm_equipment_list frmEqList)
        {
            InitializeComponent();
            clEquipment = new Equipment();
            this.frmEqList = frmEqList;
            button_vehicle.Show();
            rd_item.Checked = true;
            rd_item_Checked();
        }


        //loading from equipment list to refresh eq list after saving edited item
        public frm_equipment(int iEquipmentId, frm_equipment_list frmEqList)
        {
            InitializeComponent();
            clEquipment = new Equipment(iEquipmentId);
            this.frmEqList = frmEqList;

            if (clEquipment.Id_equipment < 1)
                MessageBox.Show("The equipment could not be found");
            else
            {
                if (clEquipment.Type == "item")
                {
                    button_vehicle.Hide();
                    rd_item.Checked = true;
                    rd_item_Checked();
                    rd_set.Hide();
                    txt_itemname.Text = clEquipment.Name;
                    txt_equipmentdesc.Text = clEquipment.Description;
                }
                else if (clEquipment.Type == "set")
                {
                    button_vehicle.Hide();
                    rd_set.Checked = true;
                    rd_set_Checked();
                    rd_item.Hide();
                    txt_setname.Text = clEquipment.Name;
                    txt_equipmentdesc.Text = clEquipment.Description;
                }
                else if (clEquipment.Type == "vehicle")
                {
                    //OPEN NEW WINDOW FOR VEHICLES
                    MessageBox.Show("vehicles are going to be here");
                }
            }
        }

        //loading from equipment list to refresh eq list after saving new item booking
        public frm_equipment(int id_member, int id_staff, int id_class_instance, int id_equipment, frm_equipment_list frmEqList)
        {
            IsBooking = true;
            InitializeComponent();
            label_amounttoborrow.Visible = true;
            counter_amounttoborrow.Visible = true;
            counter_amounttoborrow.Value = 1;
            label_numberofdays.Visible = true;
            counter_numberofdays.Visible = true;
            counter_numberofdays.Value = 7;
            
            button_save.Text = "Borrow";
            this.frmEqList = frmEqList;
            frmMessageBox = new frm_message_box();
            clEquipment = new Equipment(id_equipment);
            Id_member = id_member;
            Id_staff = id_staff;
            Id_class_instance = id_class_instance;



            if (clEquipment.Id_equipment < 1)
                MessageBox.Show("The equipment could not be found");
            else
            {
                if (clEquipment.Type == "item")
                {
                    button_vehicle.Hide();
                    rd_item.Checked = true;
                    rd_item_Checked();
                    rd_set.Hide();
                    txt_itemname.Text = clEquipment.Name;
                    txt_equipmentdesc.Text = clEquipment.Description;
                }
                else if (clEquipment.Type == "set")
                {
                    button_vehicle.Hide();
                    rd_set.Checked = true;
                    rd_set_Checked();

                    rd_item.Hide();
                    txt_setname.Text = clEquipment.Name;
                    txt_equipmentdesc.Text = clEquipment.Description;
                }

                else if (clEquipment.Type == "vehicle")
                {
                    //OPEN NEW WINDOW FOR VEHICLES
                    MessageBox.Show("vehicles are going to be here");
                }
            }
            txt_itemname.ReadOnly = true;
            txt_setname.ReadOnly = true;
            txt_equipmentdesc.ReadOnly = true;
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


        private void save_eq_booking()
        {


            this.clEquipmentBooked = new EquipmentBooked();
            clEquipmentBooked.Id_equipment = clEquipment.Id_equipment;


            if ((Id_staff == -1)&&(Id_class_instance == -1))
            {
                clEquipmentBooked.Id_member = this.Id_member.ToString();
                clEquipmentBooked.Id_staff = "NULL";
                clEquipmentBooked.Id_class_instance = "NULL";

            }
            else if (Id_class_instance == -1)
            {
                clEquipmentBooked.Id_member = "NULL";
                clEquipmentBooked.Id_staff = this.Id_staff.ToString();
                clEquipmentBooked.Id_class_instance = "NULL";
            }
            else
            {
                clEquipmentBooked.Id_member = "NULL";
                clEquipmentBooked.Id_staff = "NULL";
                clEquipmentBooked.Id_class_instance = this.Id_class_instance.ToString();
            }
            DateTime today = DateTime.Today;
            clEquipmentBooked.DateStart = String.Format("{0:yyyy-MM-dd}", today);

            if (counter_amounttoborrow.Value > 0)
            {
                clEquipmentBooked.DateDue = String.Format("{0:yyyy-MM-dd}", today.AddDays(double.Parse(counter_numberofdays.Value.ToString()))); 
                
            }
            else
            {
                MessageBox.Show("Please set the number of days to borrow to be more than 0.");
                return;
            }
            




            if (counter_amounttoborrow.Value > 0)
            {
                clEquipmentBooked.BorrowedAmount = int.Parse(counter_amounttoborrow.Value.ToString());
            }
            else
            {
                MessageBox.Show("Please set the borrowed amount of "+clEquipment.Type+" to be more than 0.");
                return;
            }

            clEquipmentBooked.IsReturned = false;

            clEquipmentBooked.SaveEquipmentBooking();

            if (this.frmEqList != null) frmEqList.vLoadEqList(clEquipment.Type);
            this.Close();
        }
        
        
        //set loadup state
        private void frm_equipment_Load(object sender, EventArgs e)
        {
            //rd_item.Checked = true;
 
        }


 
        //SAVE
        private void button_save_Click(object sender, EventArgs e)
        {

            if (IsBooking)
            {
                save_eq_booking();
            }
            else
            {
                if (rd_item.Checked == true)
                {

                    if (txt_itemname.Text.Length == 0)
                    {
                        MessageBox.Show("Please insert a name for the equipment.");
                        return;
                    }
                    clEquipment.Type = "item";
                    clEquipment.Name = txt_itemname.Text;
                    clEquipment.Description = txt_equipmentdesc.Text;




                }
                else if (rd_set.Checked == true)
                {
                    if (txt_setname.Text.Length == 0)
                    {
                        MessageBox.Show("Please insert a name for the set.");
                        return;
                    }
                    clEquipment.Type = "set";
                    clEquipment.Name = txt_setname.Text;
                    clEquipment.Description = txt_equipmentdesc.Text;

                    if (cmb_item1.SelectedIndex < 1)
                    {
                        MessageBox.Show("Please select at least one item for the set!");
                        return;
                    }


                    if (cmb_item1.SelectedIndex > 0)
                    {
                        if (counter_item1.Value > 0)
                        {
                            DictionaryEntry de1 = (DictionaryEntry)cmb_item1.SelectedItem;
                            clEquipment.ItemInSet1 = int.Parse(de1.Key.ToString());
                            clEquipment.AmountInSet1 = int.Parse(counter_item1.Value.ToString());
                        }
                        else
                        {
                            MessageBox.Show("Please set the 1st item's amount to be more than 0.");
                            return;
                        }
                    }

                   

                    if (cmb_item2.SelectedIndex > 0) 
                    {
                        if (counter_item2.Value > 0)
                        {
                            DictionaryEntry de2 = (DictionaryEntry)cmb_item2.SelectedItem;
                            clEquipment.ItemInSet2 = int.Parse(de2.Key.ToString());
                            clEquipment.AmountInSet2 = int.Parse(counter_item2.Value.ToString());
                        }
                        else
                        {
                            MessageBox.Show("Please set the 2nd item's amount to be more than 0.");
                            return;
                        }
                    }
                    

                    if (cmb_item3.SelectedIndex > 0)
                    {
                        if (counter_item3.Value > 0)
                        {
                            DictionaryEntry de3 = (DictionaryEntry)cmb_item3.SelectedItem;
                            clEquipment.ItemInSet3 = int.Parse(de3.Key.ToString());
                            clEquipment.AmountInSet3 = int.Parse(counter_item3.Value.ToString());
                        }
                        else
                        {
                            MessageBox.Show("Please set the 3rd item's amount to be more than 0.");
                            return;
                        }
                    }
                    

                    if (cmb_item4.SelectedIndex > 0)
                    {
                        if (counter_item4.Value > 0)
                        {
                            DictionaryEntry de4 = (DictionaryEntry)cmb_item4.SelectedItem;
                            clEquipment.ItemInSet4 = int.Parse(de4.Key.ToString());
                            clEquipment.AmountInSet4 = int.Parse(counter_item4.Value.ToString());
                        }
                        else
                        {
                            MessageBox.Show("Please set the 4th item's amount to be more than 0.");
                            return;
                        }
                    }
                    

                    if (cmb_item5.SelectedIndex > 0)
                    {
                        if (counter_item5.Value > 0)
                        {
                            DictionaryEntry de5 = (DictionaryEntry)cmb_item5.SelectedItem;
                            clEquipment.ItemInSet5 = int.Parse(de5.Key.ToString());
                            clEquipment.AmountInSet5 = int.Parse(counter_item5.Value.ToString());
                        }
                        else
                        {
                            MessageBox.Show("Please set the 5th item's amount to be more than 0.");
                            return;
                        }
                    }
                    

                }


                clEquipment.SaveEquipment();
                //call list reload in parent form
                //if frmEqlist is null, then this form was called from the main menu and list reload is not necessary
                if (this.frmEqList != null) frmEqList.vLoadEqList(clEquipment.Type);
                this.Close();
            }
        }

        //CANCEL
        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //REMOVE
        private void button_remove_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "Delete entry", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                //call list reload in parent form
                //if frmEqlist is null, then this form was called from the main menu and list reload is not necessary
                if (this.frmEqList != null) frmEqList.vLoadEqList(clEquipment.Type);
                clEquipment.RemoveEquipment();
                this.Close();
            }
        }

private void button_vehicle_Click(object sender, EventArgs e)
{

    MessageBox.Show("vehicles are going to be here");
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

            button_vehicle.Hide();

            label_iteminfo.Show();
            label_itemsetinfo.Hide();

            label_itemname.Enabled = true;
            txt_itemname.Enabled = true;

            label_setname.Enabled = false;
            txt_setname.Enabled = false;
            txt_setname.Text = "";

 

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

            button_vehicle.Hide();

            mySqlConn conn = new mySqlConn();
            conn.connect();



            

            // Loading Available Items
            string query = "SELECT id_equipment, name FROM equipment WHERE type = 'item' ORDER BY id_equipment";
            ArrayList myItems1 = conn.alGetComboFromDb(query, "id_equipment", "name");
            ArrayList myItems2 = conn.alGetComboFromDb(query, "id_equipment", "name");
            ArrayList myItems3 = conn.alGetComboFromDb(query, "id_equipment", "name");
            ArrayList myItems4 = conn.alGetComboFromDb(query, "id_equipment", "name");
            ArrayList myItems5 = conn.alGetComboFromDb(query, "id_equipment", "name");

            //cmb_item1.SelectedIndex = 0;
            DictionaryEntry dent = (DictionaryEntry)myItems1[0];
            //clEquipment.SItemInSet1 = de.Value.ToString();

            dent.Key = "0";
            dent.Value = "none";
            


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



            int j = 0;
            foreach (object i in myItems1)
            {

                dent = (DictionaryEntry)myItems1[j];
                if (int.Parse(dent.Key.ToString()) == clEquipment.ItemInSet1)
                    cmb_item1.SelectedIndex = j;
                j++;
            }
            j = 0;
            foreach (object i in myItems1)
            {

                dent = (DictionaryEntry)myItems1[j];
                if (int.Parse(dent.Key.ToString()) == clEquipment.ItemInSet2)
                    cmb_item2.SelectedIndex = j;
                j++;
            }
            j = 0;
            foreach (object i in myItems1)
            {

                dent = (DictionaryEntry)myItems1[j];
                if (int.Parse(dent.Key.ToString()) == clEquipment.ItemInSet3)
                    cmb_item3.SelectedIndex = j;
                j++;
            }
            j = 0;
            foreach (object i in myItems1)
            {

                dent = (DictionaryEntry)myItems1[j];
                if (int.Parse(dent.Key.ToString()) == clEquipment.ItemInSet4)
                    cmb_item4.SelectedIndex = j;
                j++;
            }
            j = 0;
            foreach (object i in myItems1)
            {

                dent = (DictionaryEntry)myItems1[j];
                if (int.Parse(dent.Key.ToString()) == clEquipment.ItemInSet5)
                    cmb_item5.SelectedIndex = j;
                j++;
            }



            counter_item1.Value = clEquipment.AmountInSet1;
            counter_item2.Value = clEquipment.AmountInSet2;
            counter_item3.Value = clEquipment.AmountInSet3;
            counter_item4.Value = clEquipment.AmountInSet4;
            counter_item5.Value = clEquipment.AmountInSet5;



            label_iteminfo.Hide();
            label_itemsetinfo.Show();

            label_itemname.Enabled = false;
            txt_itemname.Enabled = false;

            label_setname.Enabled = true;
            txt_setname.Enabled = true;


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
