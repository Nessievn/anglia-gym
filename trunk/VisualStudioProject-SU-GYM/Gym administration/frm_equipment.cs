/*
 * References used:
 * The C# Station Tutorial
 * by Joe Mayo, 8/25/02, updated 3/12/03, 2/22/08, 1/12/09
 * Lesson 14: Introduction to Delegates and Events
 * http://www.csharp-station.com/Tutorials/Lesson14.aspx
 * 
 * DeBugging
 * ComboBox Defaullt Value?
 * http://www.debugging.com/bug/12621
 * 
 * MySQL 5.1 Reference Manual :: 11 Functions and Operators :: 11.6 Date and Time Functions
 * http://dev.mysql.com/doc/refman/5.1/en/date-and-time-functions.html#function_date
 * 
 * String Format for DateTime [C#]
 * http://www.csharp-examples.net/string-format-datetime/
 * 
 * .NET Framework Class Library - DateTime Methods
 * http://msdn.microsoft.com/en-us/library/system.datetime_methods%28v=VS.90%29.aspx
 * 
 */

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

    /**
     * @desc Form Handler for equipments and equipment bookings as well. 
     * It is for adding or modifying an equipment.
     * @params [none] Incoming parameters are described at the individual constructors.
     * @return [none] No directly returned data. 
     * Returns of public methods are described at the individual methods.
     */    
    public partial class frm_equipment : Form
    {
        // For using the form for equipments
        Equipment clEquipment;
        // For using the form for equipment bookings
        EquipmentBooked clEquipmentBooked;
        // This is a custom message box
        frm_message_box frmMessageBox;
        // Declare a reference to the equipment list, so this object can call its methods
        // This is basically for calling a refresh of the equipment list just before this form is closed
        frm_equipment_list frmEqList;
        bool IsBooking = false;
        int Id_member;
        int Id_staff;
        int Id_class_instance;


        /** 
         * @desc Default constructor for creating new equipment from main menu.
         * This is for loading from main menu, 
         * the equipment list reference is not necessary so it will be set to null
         * @params [none] No input parameter. 
         * @return [none] No directly returned data. 
         */ 
        public frm_equipment()
        {
            InitializeComponent();
            clEquipment = new Equipment();
            this.frmEqList = null;
            // Set default state of form
            rd_item.Checked = true;
            rd_item_Checked();
        }


        /** 
         * @desc Constructor for creating new equipment from equipment list.
         * (to be able to refresh eq list after saving added new equipment to equipment list)
         * @params [frm_equipment_list] frmEqList: by taking this parameter there will be a reference
         * to the equipment list so it can be refreshed after saving the new equipment
         * @return [none] No directly returned data. 
         */
        public frm_equipment(frm_equipment_list frmEqList)
        {
            InitializeComponent();
            clEquipment = new Equipment();
            this.frmEqList = frmEqList;
            rd_item.Checked = true;
            rd_item_Checked();
        }


        /** 
          * @desc Constructor for editing an existing equipment.
          * (To be able to refresh equipment list after saving the edited equipment)
	      * @params [int] id_equipment: identifies the equipment to modify
          * @params [frm_equipment_list] frmEqList: by taking this parameter there will be a reference
          * to the equipment list so it can be refreshed after saving the new equipment
          * @return [none] No directly returned data. 
          */
        public frm_equipment(int id_equipment, frm_equipment_list frmEqList)
        {
            InitializeComponent();
            // Load in equipment details for specified equipment
            clEquipment = new Equipment(id_equipment);
            // Create reference to the parent form (frm_equipment_list)
            this.frmEqList = frmEqList;
            // Check if there was such an equipment in the database
            if (clEquipment.Id_equipment < 1)
                MessageBox.Show("The equipment could not be found");
            // If the equipment was found
            else
            {
                // Display table field contents on form in case of item
                if (clEquipment.Type == "item")
                {
                    rd_item.Checked = true;
                    rd_item_Checked();
                    rd_set.Hide();
                    txt_itemname.Text = clEquipment.Name;
                    txt_equipmentdesc.Text = clEquipment.Description;
                }
                // Display table field contents on form in case of set
                else if (clEquipment.Type == "set")
                {
                    rd_set.Checked = true;
                    rd_set_Checked();
                    rd_item.Hide();
                    txt_setname.Text = clEquipment.Name;
                    txt_equipmentdesc.Text = clEquipment.Description;
                }
            }
        }

        /** 
         * @desc Constructor for booking an equipment.
         * This can only launch form a member or staff panel as it needs data from them!
	     * @params [int] id_equipment: identifies the equipment to book
	     * @params [int] id_member: identifies the member who books the equipment
	     * @params [int] id_staff: identifies the staff  who books the equipment
         * @params [int] id_class_instance: identifies the class instance to book the equipment for
         * @return [none] No directly returned data. 
         */
        public frm_equipment(int id_equipment, int id_member, int id_staff, int id_class_instance)
        {
            frmMessageBox = new frm_message_box();
            // Store the fact on class global level that this is a booking
            IsBooking = true;
            InitializeComponent();
            // Set up equipment form for bookings
            label_amounttoborrow.Visible = true;
            counter_amounttoborrow.Visible = true;
            counter_amounttoborrow.Value = 1;
            label_numberofdays.Visible = true;
            counter_numberofdays.Visible = true;
            counter_numberofdays.Value = 7;
            button_save.Text = "Borrow";
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
            // Load in the details of the equipment to book
            clEquipment = new Equipment(id_equipment);
            // Store class global level to whom the equipment is booked for
            Id_member = id_member;
            Id_staff = id_staff;
            Id_class_instance = id_class_instance;

            // If the equipment was not found
            if (clEquipment.Id_equipment < 1)
                MessageBox.Show("The equipment could not be found");
            // If the equipmnet was succesfully loaded in
            else
            {
                // If it is an individual item
                // Display table field contents on form in case of item
                if (clEquipment.Type == "item")
                {
                    rd_item.Checked = true;
                    rd_item_Checked();
                    rd_set.Hide();
                    txt_itemname.Text = clEquipment.Name;
                    txt_equipmentdesc.Text = clEquipment.Description;
                }
                // If it is a set
                // Display table field contents on form in case of set
                else if (clEquipment.Type == "set")
                {
                    rd_set.Checked = true;
                    rd_set_Checked();

                    rd_item.Hide();
                    txt_setname.Text = clEquipment.Name;
                    txt_equipmentdesc.Text = clEquipment.Description;
                }
            }
        }


        /** 
          * @desc This method executes when "Save" button is clicked and IsBooking is true
	      * It checks to whom the booking will be for, checks user input and then calls for saving the new booking
          * @params [none] No input parameter. 
          * @return [none] No directly returned data. 
          */ 
        private void save_eq_booking()
        {
            // Instantiate new booking
            this.clEquipmentBooked = new EquipmentBooked();
            // Pass the equipment id to borrow
            clEquipmentBooked.Id_equipment = clEquipment.Id_equipment;

            // If this is a member booking
            if ((Id_staff == -1)&&(Id_class_instance == -1))
            {
                // Store the member id only
                clEquipmentBooked.Id_member = this.Id_member.ToString();
                clEquipmentBooked.Id_staff = "NULL";
                clEquipmentBooked.Id_class_instance = "NULL";

            }
            // Else If this is a staff booking
            else if (Id_class_instance == -1)
            {
                // Store the staff id only
                clEquipmentBooked.Id_member = "NULL";
                clEquipmentBooked.Id_staff = this.Id_staff.ToString();
                clEquipmentBooked.Id_class_instance = "NULL";
            }
            // Else this is a class instance booking
            else
            {
                // Store the class instance id only
                clEquipmentBooked.Id_member = "NULL";
                clEquipmentBooked.Id_staff = "NULL";
                clEquipmentBooked.Id_class_instance = this.Id_class_instance.ToString();
            }

            // Set the date start for today by default
            DateTime today = DateTime.Today;
            clEquipmentBooked.DateStart = String.Format("{0:yyyy-MM-dd}", today);

            // Add to the start date the number of days the user selected to ccreate return date
            if (counter_amounttoborrow.Value > 0)
            {
                clEquipmentBooked.DateDue = String.Format("{0:yyyy-MM-dd}", today.AddDays(double.Parse(counter_numberofdays.Value.ToString()))); 
                
            }
            else
            {
                MessageBox.Show("Please set the number of days to borrow to be more than 0.");
                return;
            }
            

            // Check that there is at least one item is selected
            if (counter_amounttoborrow.Value > 0)
            {
                clEquipmentBooked.BorrowedAmount = int.Parse(counter_amounttoborrow.Value.ToString());
            }
            else
            {
                MessageBox.Show("Please set the borrowed amount of "+clEquipment.Type+" to be more than 0.");
                return;
            }

            // Set the returned state to false
            clEquipmentBooked.IsReturned = false;
            // Call for saving the new booking
            clEquipmentBooked.SaveEquipmentBooking();
            
            // Close the form
            this.Close();
        }
        
        

        /** 
          * @desc Executes when the "Save" button is clicked
	      * In case of booking it copies user input into equipment bookings object and then calls for saving the equipment booking
          * else it copies user input into equipment object and then calls for saving the equipment.
          * @params [none] No input parameter. 
          * @return [none] No directly returned data. 
          */
        private void button_save_Click(object sender, EventArgs e)
        {
            // If this is a booking call the booking saving method above
            if (IsBooking)
            {
                save_eq_booking();
            }
            // Else it is an equipment adding or editing
            else
            {
                // If this is an individual item
                if (rd_item.Checked == true)
                {
                    // Check item related user input
                    if (txt_itemname.Text.Length == 0)
                    {
                        MessageBox.Show("Please insert a name for the equipment.");
                        return;
                    }
                    // Copy user input into object fields
                    clEquipment.Type = "item";
                    clEquipment.Name = txt_itemname.Text;
                    clEquipment.Description = txt_equipmentdesc.Text;
                }
                // If this is a set
                else if (rd_set.Checked == true)
                {
                    // Check set related user input
                    if (txt_setname.Text.Length == 0)
                    {
                        MessageBox.Show("Please insert a name for the set.");
                        return;
                    }
                    // Copy user input into object fields
                    clEquipment.Type = "set";
                    clEquipment.Name = txt_setname.Text;
                    clEquipment.Description = txt_equipmentdesc.Text;

                    // Check all user input and copy combobox selections into object fields
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

                // Call for saving/updating the equipment
                if (clEquipment.SaveEquipment())
                {
                    //Call list reload in parent form
                    //if frmEqlist is null, then this form was called from the main menu and list reload is not necessary
                    if (this.frmEqList != null) frmEqList.vLoadEqList(clEquipment.Type);
                    this.Close();
                }
            }
        }

        // Cancel/Close
        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /** 
          * @desc Executes when the "Remove" button is clicked
	      * It asks for confirmation and then calls for removing the Equipment.
          * @params [none] No input parameter. 
          * @return [none] No directly returned data. 
          */ 
        private void button_remove_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "Delete entry", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (clEquipment.RemoveEquipment())
                {
                    //call list reload in parent form
                    //if frmEqlist is null, then this form was called from the main menu and list reload is not necessary
                    if (this.frmEqList != null) frmEqList.vLoadEqList(clEquipment.Type);
                    this.Close();
                }
            }
        }

        /** 
          * @desc Executes when the "Item" radiobutton is set
	      * It launches the rd_item_checked() method
          * @params [none] No input parameter. 
          * @return [none] No directly returned data. 
          */ 
        private void rd_item_Checked(object sender, EventArgs e)
        {
            rd_item_Checked();
        }

        /** 
          * @desc It sets up the form for displaying details of an individual item
          * @params [none] No input parameter. 
          * @return [none] No directly returned data. 
          */
        private void rd_item_Checked()
        {


            label_iteminfo.Show();
            label_itemsetinfo.Hide();

            label_itemname.Enabled = true;
            txt_itemname.Enabled = true;

            label_setname.Enabled = false;
            txt_setname.Enabled = false;
            txt_setname.Text = "";

            label_itemdesc.Show();
            label_itemsetdesc.Hide();

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


        /** 
          * @desc Executes when the "Set" radiobutton is set
	      * It launches the rd_set_checked() method
          * @params [none] No input parameter. 
          * @return [none] No directly returned data. 
          */ 
        private void rd_set_Checked(object sender, EventArgs e)
        {
            rd_set_Checked();
        }

        /** 
          * @desc It sets up the form for displaying details of a set
          * @params [none] No input parameter. 
          * @return [none] No directly returned data. 
          */ 
        private void rd_set_Checked()
        {

            // Create mysql connection            
            mySqlConn conn = new mySqlConn();
            conn.connect();
           

            // Loading Available Items
            string query = "SELECT id_equipment, name FROM equipment WHERE type = 'item' ORDER BY id_equipment";
            ArrayList myItems1 = conn.alGetComboFromDB(query, "id_equipment", "name");
            ArrayList myItems2 = conn.alGetComboFromDB(query, "id_equipment", "name");
            ArrayList myItems3 = conn.alGetComboFromDB(query, "id_equipment", "name");
            ArrayList myItems4 = conn.alGetComboFromDB(query, "id_equipment", "name");
            ArrayList myItems5 = conn.alGetComboFromDB(query, "id_equipment", "name");

            
            // Create an option for "none" in each combobox's first position
            DictionaryEntry dent = (DictionaryEntry)myItems1[0];
            dent.Key = "0";
            dent.Value = "none";
            myItems1.Insert(0, dent);
            myItems2.Insert(0, dent);
            myItems3.Insert(0, dent);
            myItems4.Insert(0, dent);
            myItems5.Insert(0, dent);


            // Assign sources and displaymembers to all comboboxes
            cmb_item1.DisplayMember = "Value";
            cmb_item1.DataSource = myItems1;
            cmb_item2.DisplayMember = "Value";
            cmb_item2.DataSource = myItems2;
            cmb_item3.DisplayMember = "Value";
            cmb_item3.DataSource = myItems3;
            cmb_item4.DisplayMember = "Value";
            cmb_item4.DataSource = myItems4;
            cmb_item5.DisplayMember = "Value";
            cmb_item5.DataSource = myItems5;



            // Find the position of the item in the source and set this to be the selected index
            // in each combobox
            int j = 0;
            foreach (object o in myItems1)
            {

                dent = (DictionaryEntry)myItems1[j];
                if (int.Parse(dent.Key.ToString()) == clEquipment.ItemInSet1)
                    cmb_item1.SelectedIndex = j;
                j++;
            }
            j = 0;
            foreach (object o in myItems1)
            {

                dent = (DictionaryEntry)myItems1[j];
                if (int.Parse(dent.Key.ToString()) == clEquipment.ItemInSet2)
                    cmb_item2.SelectedIndex = j;
                j++;
            }
            j = 0;
            foreach (object o in myItems1)
            {

                dent = (DictionaryEntry)myItems1[j];
                if (int.Parse(dent.Key.ToString()) == clEquipment.ItemInSet3)
                    cmb_item3.SelectedIndex = j;
                j++;
            }
            j = 0;
            foreach (object o in myItems1)
            {

                dent = (DictionaryEntry)myItems1[j];
                if (int.Parse(dent.Key.ToString()) == clEquipment.ItemInSet4)
                    cmb_item4.SelectedIndex = j;
                j++;
            }
            j = 0;
            foreach (object o in myItems1)
            {

                dent = (DictionaryEntry)myItems1[j];
                if (int.Parse(dent.Key.ToString()) == clEquipment.ItemInSet5)
                    cmb_item5.SelectedIndex = j;
                j++;
            }


            // Display counter values on form
            counter_item1.Value = clEquipment.AmountInSet1;
            counter_item2.Value = clEquipment.AmountInSet2;
            counter_item3.Value = clEquipment.AmountInSet3;
            counter_item4.Value = clEquipment.AmountInSet4;
            counter_item5.Value = clEquipment.AmountInSet5;

            // Display remaining set related settings on form

            label_iteminfo.Hide();
            label_itemsetinfo.Show();
            label_itemname.Enabled = false;
            txt_itemname.Enabled = false;
            label_setname.Enabled = true;
            txt_setname.Enabled = true;
            label_itemdesc.Hide();
            label_itemsetdesc.Show();
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


        /** 
         * @desc It executes when a different selection happens in cmb_item1 combobox
         * This for preventing the user to select 2nd, 3rd, 4th and 5th item if there is no selection for the first yet
         * and for setting the corresponding value to be 0 if selection is "none" in its combobox
         * @params [none] No input parameter. 
         * @return [none] No directly returned data. 
         */
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

        /** 
         * @desc It executes when a different selection happens in cmb_item2 combobox
         * This for preventing the user to select 3rd, 4th and 5th item if there is no selection for that one yet
         * and for setting the corresponding value to be 0 if selection is "none" in its combobox
         * @params [none] No input parameter. 
         * @return [none] No directly returned data. 
         */
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

        /** 
         * @desc It executes when a different selection happens in cmb_item3 combobox
         * This for preventing the user to select 4th and 5th item if there is no selection for that one yet
         * and for setting the corresponding value to be 0 if selection is "none" in its combobox
         * @params [none] No input parameter. 
         * @return [none] No directly returned data. 
         */
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

        /** 
         * @desc It executes when a different selection happens in cmb_item4 combobox
         * This for preventing the user to select 5th item if there is no selection for that one yet
         * and for setting the corresponding value to be 0 if selection is "none" in its combobox
         * @params [none] No input parameter. 
         * @return [none] No directly returned data. 
         */
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



        /** 
         * @desc It executes when a different selection happens in cmb_item5 combobox
         * This is for setting the corresponding value for 0 if selection is "none" in cmb_item5
         * @params [none] No input parameter. 
         * @return [none] No directly returned data. 
         */
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
