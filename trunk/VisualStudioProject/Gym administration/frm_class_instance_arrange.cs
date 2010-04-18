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
     * @desc 
     * Form Handler for class instances. 
     * It is for adding or modifying a class instance.
     * @params [none] Incoming parameters are described at the individual constructors.
     * @return [none] No directly returned data. 
     * Returns of public methods are described at the individual methods.
     */  
    public partial class frm_class_instance_arrange : Form
    {
        ClassInstance clClassInstance;
        frm_class_instance_list frmClassInstanceList;
        EquipmentBooked clEquipmentBooked;

        /** 
         * @desc Default constructor for creating new class instance from main menu.
         * This is for loading from main menu, 
         * @params [none] No input parameter. 
         * @return [none] No directly returned data. 
         */ 
        public frm_class_instance_arrange()
        {
            InitializeComponent();
            clClassInstance = new ClassInstance();
            // A class instance that doesn't exist yet, shouldn't enroll members
            button_enrollmembers.Enabled = false;
            frmClassInstanceList = null;
        }


        /** 
          * @desc Constructor for editing an existing class instance.
          * Loading from class instance list to refresh class instance list after saving new class instance
	      * @params [int] id_class: identifies the class instance to return
          * @params [frm_class__instance_list] frmClInstList: by taking this parameter there will be a reference
          * to the class instance list so it can be refreshed after saving the new class instance
          * @return [none] No directly returned data. 
          */ 
        public frm_class_instance_arrange(int id_class_booked, frm_class_instance_list frmClInstList)
        {
            InitializeComponent();
            this.frmClassInstanceList = frmClInstList;
            // Load in the class instance details
            clClassInstance = new ClassInstance(id_class_booked);
            // Check if it was found
            if (clClassInstance.Id_class_instance == -1)
                MessageBox.Show("The class instance could not be found");
            // If the class instance was found
            else
            {
                // Display class instance details on form
                vLoadBookedList();
                txt_endtime.Text = clClassInstance.EndTime;
                txt_startdate.Text = clClassInstance.DateStart;
                txt_starttime.Text = clClassInstance.StartTime;
                // Let new members to enroll
                button_enrollmembers.Enabled = true;
            }
        }


        /** 
          * @desc Executes when a grid cell is double clicked on the borrowed equipment list
	      * It loads in the equipment return dialog belonging to the cell
          * @params [none] No input parameter. 
          * @return [none] No directly returned data. 
          */ 
        private void dg_eqbookings_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Retrieve equipment booking details from grid row
            string equipmentName = dg_eqbookings.Rows[e.RowIndex].Cells[1].Value.ToString();
            int borrowedAmount = int.Parse(dg_eqbookings.Rows[e.RowIndex].Cells[2].Value.ToString());
            int id_eq_booking = int.Parse(dg_eqbookings.Rows[e.RowIndex].Cells[4].Value.ToString());
            // Show return dialog for confirming amount to be returned
            frm_message_box myMessageBox = new frm_message_box();
            string result = myMessageBox.ShowBox(Utils.MB_CUST4, "", "How many " + equipmentName + " would you like to return?", borrowedAmount.ToString());

            // Reference how to use TryParse
            //ref  http://social.msdn.microsoft.com/Forums/en-US/winforms/thread/84990ad2-5046-472b-b103-f862bfcd5dbc

            // Check the result of user input
            double Num;
            bool isNum = double.TryParse(result, out Num);
            if (isNum)
            {
                // If there is something to return but not everything
                if ((int.Parse(result) > 0) && (result != "Cancel"))
                {
                    // Save the new amount into eq. booking
                    this.clEquipmentBooked = new EquipmentBooked(id_eq_booking);
                    this.clEquipmentBooked.BorrowedAmount = int.Parse(result);
                    this.clEquipmentBooked.IsReturned = false;
                    this.clEquipmentBooked.SaveEquipmentBooking();
                }
                // If all amount of this booking is to be returned
                else
                {
                    // Mark the booking as returned
                    this.clEquipmentBooked = new EquipmentBooked(id_eq_booking);
                    this.clEquipmentBooked.BorrowedAmount = 0;
                    this.clEquipmentBooked.IsReturned = true;
                    this.clEquipmentBooked.SaveEquipmentBooking();

                }
                // Refresh eq. booking list
                this.vLoadBookedList();
            }

        }

        /** 
          * @desc This method refreshes the booked equipment list
          * @params [none] No input parameter. 
          * @return [none] No directly returned data. 
          */ 
        public void vLoadBookedList()
        {
            // Create mysql connection
            mySqlConn conn = new mySqlConn();
            conn.connect();
            // Create source for grid
            BindingSource itemsSource = new BindingSource();
            // Create query
            string query = "SELECT DISTINCT eb.date_due Due, e.name Name, eb.borrowedamount Amount, eb.id_equipment EqID, eb.id_eq_booking BkID FROM equipment e, equipment_bookings eb WHERE eb.id_class_instance = " + clClassInstance.Id_class_instance + " AND (eb.isreturned = 0 OR eb.isreturned is NULL) AND eb.id_equipment = e.id_equipment ORDER BY Due";
            // Launch query and load result into source
            itemsSource.DataSource = conn.dtGetTableForDataGrid(query);
            // Assign source to grid
            dg_eqbookings.DataSource = itemsSource;
            dg_eqbookings.AllowUserToAddRows = false;
            dg_eqbookings.ReadOnly = true;
        }

        /** 
          * @desc This method loads in every time the frm_class_instance_arrange is instantiated
          * @params [none] No input parameter. 
          * @return [none] No directly returned data. 
          */ 
        private void frm_class_instance_arrange_Load(object sender, EventArgs e)
        {
                        // Create mysql connection
            mySqlConn conn = new mySqlConn();
            conn.connect();
            
            // Loading Available Classes
            string query = "SELECT id_class, name FROM classes ORDER BY id_class";
            ArrayList myItems = conn.alGetComboFromDB(query, "id_class","name");
            cmb_classes.DisplayMember = "Value";
            cmb_classes.DataSource = myItems;

            // Loading Available Rooms
            query = "SELECT id_room, name FROM rooms ORDER BY id_room";
            myItems = conn.alGetComboFromDB(query, "id_room", "name");
            cmb_rooms.DisplayMember = "Value";
            cmb_rooms.DataSource = myItems;

            // Loading Available Instructor
            //TODO: Inform Katie about the Position -> Instructor field
            query = "SELECT id_staff, CONCAT(lastName,', ', firstName) name FROM staff WHERE position = 'Instructor' ORDER BY id_staff";
            myItems = conn.alGetComboFromDB(query, "id_staff", "name");
            cmb_instructors.DisplayMember = "Value";
            cmb_instructors.DataSource = myItems;
  
            // Set the options on form to be in par with the class instance
            if (this.clClassInstance.Id_class_instance != -1)
            {
                cmb_classes.SelectedIndex = cmb_classes.FindString(clClassInstance.ClClass.Name);
                cmb_rooms.SelectedIndex = cmb_rooms.FindString(clClassInstance.ClRoom.Name);
                cmb_repeats.SelectedIndex = cmb_repeats.FindString(clClassInstance.Frequency);
                // Display number of members enlisted to this class instance
                query = "SELECT COUNT(*) q FROM gym.class_bookings WHERE id_class_instance = '" + this.clClassInstance.Id_class_instance + "'";
                List<Hashtable> lhRes = conn.lhSqlQuery(query);
                lbl_currentmembers_amount.Text = lhRes[0]["q"].ToString();
                // Display max members allowed in the room allocated to this class
                query = "SELECT r.size FROM gym.class_instance ci, gym.rooms r WHERE ci.id_room = r.id_room AND ci.id_class_instance = '" + this.clClassInstance.Id_class_instance + "'";
                lhRes = conn.lhSqlQuery(query);
                label_maxmembers_amount.Text = lhRes[0]["size"].ToString();
            }
            else
            {
                // If the class instance does not exist yet, it is not possible to ass member or equipment to it
                button_remove.Enabled = false;
                btn_equipment.Enabled = false;
            }
        }

        /** 
          * @desc Executes when the "Save" button is clicked
	      * It checks user input and then calls for saving the new class instance.
          * @params [none] No input parameter. 
          * @return [none] No directly returned data. 
          */ 
        private void button_save_Click(object sender, EventArgs e)
        {
            // create mysql connection
            mySqlConn conn = new mySqlConn();
            conn.connect();

            // Copy form field contents into class instance object fields
            string sDate = Utils.sGetMysqlDate(txt_startdate.Text);
            DictionaryEntry de = (DictionaryEntry)cmb_classes.SelectedItem;
            string id_class = de.Key.ToString();

            de = (DictionaryEntry)cmb_instructors.SelectedItem;
            string id_staff = de.Key.ToString();

        
            de = (DictionaryEntry)cmb_rooms.SelectedItem;
            string id_room = de.Key.ToString();
            
            // Check user inputs and formats
            if(sDate == "0000-00-00")
            {
                MessageBox.Show("Check the date format!");
                return;
            }else if(Utils.bValidateTime(txt_starttime.Text) == false || Utils.bValidateTime(txt_starttime.Text) == false)
            {
                MessageBox.Show("Check the time format!");
                return;
            }
            else if (cmb_classes.Text == "" || cmb_instructors.Text == "" || cmb_rooms.Text == "")
            {
                MessageBox.Show("Missing information to arrange your class. Please check input data.");
                return;
            }

            
            // Check if the user was found
            if (this.clClassInstance.bCheckOverlap(sDate, id_room, id_staff, txt_starttime.Text, txt_endtime.Text))
                MessageBox.Show("The class is overlapping with another class, please specify another date, room or instructor.");
            else
            {
                this.clClassInstance.Id_staff = int.Parse(id_staff);
                this.clClassInstance.ClRoom = new Room(int.Parse(id_room));
                this.clClassInstance.ClClass = new Class(int.Parse(id_class));
                this.clClassInstance.DateStart = sDate;
                this.clClassInstance.EndTime = txt_endtime.Text;
                this.clClassInstance.Frequency = cmb_repeats.Text;
                this.clClassInstance.StartTime = txt_starttime.Text;
                if (this.clClassInstance.SaveClassInstance())
                {
                    button_enrollmembers.Enabled = true;
                    button_remove.Enabled = true;
                    btn_equipment.Enabled = true;
                }
            }

        }

        /** 
          * @desc Executes when the "Enroll" button is clicked
	      * It opens up a member list for enrolling to class instance, but not for viewing attendants
          * @params [none] No input parameter. 
          * @return [none] No directly returned data. 
          */ 
        private void button_enrollmembers_Click(object sender, EventArgs e)
        {
            // Params: this clClassInstance and a false boolean viewAttendants
            frm_member_list frmMemberList = new frm_member_list(clClassInstance,false);
            frmMemberList.ShowDialog();
        }

        /** 
          * @desc Executes when the "View Attendants" button is clicked
	      * It opens up a member list for viewing the attendants to this class instance
          * @params [none] No input parameter. 
          * @return [none] No directly returned data. 
          */ 
        private void button_viewattendants_Click(object sender, EventArgs e)
        {
            // Params: this clClassInstance and a true boolean viewAttendants
            frm_member_list frmMemberList = new frm_member_list(clClassInstance, true);
            frmMemberList.ShowDialog();
        }

        /** 
          * @desc Update the max members allowed in room based on currently selected room
          * @params [none] No input parameter. 
          * @return [none] No directly returned data. 
          */ 
        private void cmb_rooms_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Create mysql connection
            mySqlConn conn = new mySqlConn();
            conn.connect();
            // Get room id
            DictionaryEntry de = (DictionaryEntry)cmb_rooms.SelectedItem;
            string id_room = de.Key.ToString();
            // Get room size based on room id
            string query = "SELECT size FROM gym.rooms WHERE id_room = '" + id_room + "'";
            List<Hashtable> lhRes = conn.lhSqlQuery(query);
            // Display new size
            label_maxmembers_amount.Text = lhRes[0]["size"].ToString();
        }

        /** 
          * @desc Executes when the "Remove" button is clicked
	      * It asks for confirmation and then calls for removing the class instance.
          * @params [none] No input parameter. 
          * @return [none] No directly returned data. 
          */ 
        private void button_remove_Click(object sender, EventArgs e)   
        {
            if (dg_eqbookings.RowCount > 0)
                MessageBox.Show("You can't remove this class as the borrowed equipments has to be returned first!");
            else
            {
                DialogResult result= MessageBox.Show("Are you sure?", "Delete entry", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result== DialogResult.Yes)
                {
                    if (this.clClassInstance.RemoveClassInstance() == false)
                    {
                        //???
                        MessageBox.Show("Please make sure that there aren't any class instances for this class.");
                    }
                    if (frmClassInstanceList != null) frmClassInstanceList.vLoadDgClassList();
                    this.Close();
                }
            }
        }


        /** 
          * @desc Executes when the "Equipment" button is clicked
	      * It opens up an equipment list for borrowing
          * @params [none] No input parameter. 
          * @return [none] No directly returned data. 
          */ 
        private void btn_equipment_Click(object sender, EventArgs e)
        {

            frm_equipment_list frmEquipmentList = new frm_equipment_list(this.clClassInstance.Id_class_instance, this);
            frmEquipmentList.ShowDialog();  

        }
    }
}
