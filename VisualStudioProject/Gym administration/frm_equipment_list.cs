using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Gym_administration
{

    /**
     * @desc 
     * Form Handler for listing equipments and sets for adding, editing or booking
     * This can be called from any of the foms that allow equipment booking
     * ie frm_member, frm_staff and frm_class_instance_arrange
     * @params [none] Incoming parameters are described at the individual constructors.
     * @return [none] No directly returned data. 
     * Returns of public methods are described at the individual methods.
     */
    public partial class frm_equipment_list : Form
    {
        
        frm_message_box frmMessageBox;
        frm_member frmMember;
        frm_staff frmStaff;
        frm_class_instance_arrange frmClassInstanceArrange;
        bool IsBooking;
        int Id_member;
        int Id_staff;
        int Id_class_instance;


        /** 
         * @desc Default constructor for listing equipments
         * This is for loading from main menu, 
         * @params [none] No input parameter. 
         * @return [none] No directly returned data. 
         */ 
        public frm_equipment_list()
        {
            Id_member = -1;
            Id_staff = -1; 
            Id_class_instance = -1;
            InitializeComponent();
            this.Text = "Equipment List - Double Click on a Row to Edit Item/Set";
            this.frmMember = null;
            this.frmStaff = null;
            this.frmClassInstanceArrange = null;
            rd_item.Checked = true;
            vLoadEqList("item");
        }

        /** 
         * @desc constructor for listing equipments for booking for a member
         * @params [int] id_member: this identifies the member to book for
         * @params [frm_member] frmMember: this identifies this specific constructor to call
         * and passes the refernce to the parent form to be able to refresh the booking list when this
         * form is closed
         * @return [none] No directly returned data. 
         */
        public frm_equipment_list(int id_member, frm_member frmMember)
        {
            IsBooking = true;
            Id_staff = -1; 
            Id_class_instance = -1;
            Id_member = id_member;
            this.frmMember = frmMember;
            InitializeComponent();
            this.Text = "Equipment List - Double Click on a Row to Edit or Borrow an Item/Set";
            rd_item.Checked = true;
            vLoadEqList("item");
        }

        /** 
         * @desc constructor for listing equipments for booking for staff
         * @params [int] id_staff: this identifies the staff to book for
         * @params [frm_staff] frmStaff: this identifies this specific constructor to call,
         * and passes the refernce to the parent form to be able to refresh the booking list when this
         * form is closed
         * @return [none] No directly returned data. 
         */
        public frm_equipment_list(int id_staff, frm_staff frmStaff)
        {
            IsBooking = true;
            Id_member = -1;
            Id_class_instance = -1;
            Id_staff = id_staff;
            this.frmStaff = frmStaff;
            InitializeComponent();
            this.Text = "Equipment List - Double Click on a Row to Edit or Borrow an Item/Set";
            rd_item.Checked = true;
            vLoadEqList("item");
        }

        /** 
         * @desc constructor for listing equipments for booking for a class instance
         * @params [int] id_class_instance: this identifies the class instance to book for
         * @params [frm_class_instance] frmClassInstanceArrange: this identifies this specific constructor to call,
         * and passes the refernce to the parent form to be able to refresh the booking list when this
         * form is closed
         * @return [none] No directly returned data. 
         */
        public frm_equipment_list(int id_class_instance, frm_class_instance_arrange frmClassInstanceArrange)
        {

            IsBooking = true;
            Id_member = -1;
            Id_staff = -1;
            Id_class_instance = id_class_instance;
            this.frmClassInstanceArrange = frmClassInstanceArrange;
            InitializeComponent();
            this.Text = "Equipment List - Double Click on a Row to Edit or Borrow an Item/Set";
            rd_item.Checked = true;
            vLoadEqList("item");
        }

        /** 
          * @desc This method loads in every time the frm_equipment_list is instantiated
          * @params [none] No input parameter. 
          * @return [none] No directly returned data. 
          */ 
        private void frm_equipment_list_Load(object sender, EventArgs e)
        {
            frmMessageBox = new frm_message_box();
        }


        /** 
          * @desc This method refreshes the equipment list
          * @params [string] type: this tells to method to list items or sets
          * @return [none] No directly returned data. 
          */ 
        public void vLoadEqList(string type)
        {
            // Create mysql connection         
            mySqlConn conn = new mySqlConn();
            conn.connect();
            // Create source for grid
            BindingSource itemsSource = new BindingSource();
            // Create query for retrieving item or set depending on parameter
            string query = "SELECT id_equipment EID, name Name, description Description FROM equipment WHERE type = '"+type+"' ORDER BY id_equipment";
            // Launch query and load result into source
            itemsSource.DataSource = conn.dtGetTableForDataGrid(query);
            // Assign source to grid
            dg_equipment.DataSource = itemsSource;
            dg_equipment.AllowUserToAddRows = false;
            dg_equipment.ReadOnly = true;

        }



        /** 
          * @desc Executes when a grid cell is double clicked on the equipment list
	      * It loads in the equipment belonging to the cell
          * @params [none] No input parameter. 
          * @return [none] No directly returned data. 
          */
        private void dg_equipment_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // If this is a list conjured for an equipment booking, the option for editing the item or set is still provided
            bool isBooking = false;
            if (IsBooking)
            {
                // Retrive the name of the equipment from grid
                string equipmentName = dg_equipment.Rows[e.RowIndex].Cells[1].Value.ToString();
                // Offer the option for edit/borrow
                string result = frmMessageBox.ShowBox(Utils.MB_CUST2, "Would you like to Edit the " + equipmentName + " or Borrow it?", "Edit or Borrow?", "Edit", "Borrow");
                // Store the result
                if (result == "Edit") 
                    isBooking = false; 
                else 
                    isBooking = true;
            }

            // If this is really a booking then
            if (isBooking)
            {
                try
                {
                    // Get equipment id
                    int id_equipment = int.Parse(dg_equipment.Rows[e.RowIndex].Cells[0].Value.ToString());
                    // Bring up the borrow form for this equipment with the previously stored borrower
                    frm_equipment frm_equipment = new frm_equipment(id_equipment, Id_member, Id_staff, Id_class_instance);                    
                    frm_equipment.ShowDialog();
                }
                catch (Exception ea)
                {
                    MessageBox.Show(ea.ToString());
                    return;
                }
            }
            // Not Booking (regular equipment edit form)
            else 
            {
                try
                {
                    // Get the equipment id
                    int id_equipment = int.Parse(dg_equipment.Rows[e.RowIndex].Cells[0].Value.ToString());
                    // Bring up the equipment edit form
                    frm_equipment frm_equipment = new frm_equipment(id_equipment, this);
                    frm_equipment.ShowDialog();
                }
                catch (Exception ea)
                {
                    MessageBox.Show(ea.ToString());
                    return;
                }
            }
        }

        /** 
          * @desc Executes when "Add Equipment" button is clicked
	      * It loads in an empty frm_equipment form for adding new equipment
          * @params [none] No input parameter. 
          * @return [none] No directly returned data. 
          */
        private void button_addequipment_Click(object sender, EventArgs e)
        {
            frm_equipment frmEquipment = new frm_equipment(this);
            frmEquipment.ShowDialog();
        }

        /** 
          * @desc Executes when the "Search" button is clicked
	      * It creates a new list of equipments based on search criteria given by the user
          * @params [none] No input parameter. 
          * @return [none] No directly returned data. 
          */
        private void button_search_Click(object sender, EventArgs e)
        {
            // Create mysql connection            
            mySqlConn conn = new mySqlConn();
            conn.connect();
            // Create source for grid
            BindingSource itemsSource = new BindingSource();
            // Create query different one for either set or item depending on settings done by user on form
            string query = "";
            if (rd_item.Checked == true)
                query = "SELECT id_equipment EID, name Name, description Description FROM equipment WHERE type = 'item' AND 1 = 1";
            else
                query = "SELECT id_equipment EID, name Name, description Description FROM equipment WHERE type = 'set' AND 1 = 1";
            // Check user input and create query for search
            if (txt_equipmentname.Text != "")
                query += " AND name LIKE '%" + txt_equipmentname.Text + "%'";

            query += "  ORDER BY name";
            // Launch query and load result into source
            itemsSource.DataSource = conn.dtGetTableForDataGrid(query);
            // Assign source to grid
            dg_equipment.DataSource = itemsSource;
            dg_equipment.AllowUserToAddRows = false;
            dg_equipment.ReadOnly = true;
        }

        /** 
          * @desc Executes when the "Item" radiobutton is set
	      * It launches the method responsible for refreshing the equipment list with items only
          * @params [none] No input parameter. 
          * @return [none] No directly returned data. 
          */
        private void rd_item_Checked(object sender, EventArgs e)
        {
            vLoadEqList("item");
        }

        /** 
          * @desc Executes when the "Set" radiobutton is set
	      * It launches the method responsible for refreshing the equipment list with sets only
          * @params [none] No input parameter. 
          * @return [none] No directly returned data. 
          */
        private void rd_set_Checked(object sender, EventArgs e)
        {
            vLoadEqList("set");
        }

        /** 
          * @desc Executes when this frm_equipment_list form is about to close
	      * This is for refreshing booked eqipment lists
          * @params [none] No input parameter. 
          * @return [none] No directly returned data. 
          */
        private void frm_equipment_list_FormClosing(object sender, FormClosingEventArgs e)
        {
            // If this form was raised from a parent where adding new booking is possible,
            // ie frm_member, frm_staff and frm_class_instance_arrange
            if (IsBooking)
            {
                // Refresh the booking list on the appropriate parent form
                if (this.frmMember != null) frmMember.vLoadBookedList();
                if (this.frmStaff != null) frmStaff.vLoadBookedList();
                if (this.frmClassInstanceArrange != null) frmClassInstanceArrange.vLoadBookedList();
            }
        }
    }
}
