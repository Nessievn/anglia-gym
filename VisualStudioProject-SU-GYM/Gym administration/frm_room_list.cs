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
     * Form Handler for listing rooms
     * @params [none] Incoming parameters are described at the individual constructors.
     * @return [none] No directly returned data. 
     * Returns of public methods are described at the individual methods.
     */
    public partial class frm_room_list : Form
    {
        public frm_room_list()
        {
            InitializeComponent();
            vLoadRoomList();
        }

        /** 
          * @desc Executes when the Search button is clicked
	      * It creates a new list of rooms based on search criteria given by the user
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
            // Create start of query
            string query = "SELECT id_room RID, name Name, size Size, description Description FROM rooms WHERE 1 = 1";
            // Check user input and create query for search
            if (txt_roomname.Text != "")
                query += " AND name LIKE '%" + txt_roomname.Text + "%'";

            query += "  ORDER BY id_room";
            // Launch query and load result into source
            itemsSource.DataSource = conn.dtGetTableForDataGrid(query);
            // Assign source to grid
            dg_rooms.DataSource = itemsSource;
            dg_rooms.AllowUserToAddRows = false;
            dg_rooms.ReadOnly = true;
        }

        /** 
          * @desc Executes when "Add Room" button is clicked
	      * It loads in an empty frm_room form for adding new room
          * @params [none] No input parameter. 
          * @return [none] No directly returned data. 
          */
        private void button_addroom_Click(object sender, EventArgs e)
        {
            frm_room frmRoom = new frm_room(this);
            frmRoom.ShowDialog();
        }

        /** 
          * @desc This method refreshes the room list
          * @params [none] No input parameter. 
          * @return [none] No directly returned data. 
          */
        public void vLoadRoomList()
        {
            // Create mysql connection            
            mySqlConn conn = new mySqlConn();
            conn.connect();
            // Create source for grid
            BindingSource itemsSource = new BindingSource();
            // Create query for retrieving all rooms
            string query = "SELECT id_room RID, name Name, size Size, description Description FROM rooms ORDER BY id_room";
            // Launch query and load result into source
            itemsSource.DataSource = conn.dtGetTableForDataGrid(query);
            // Assign source to grid
            dg_rooms.DataSource = itemsSource;
            dg_rooms.AllowUserToAddRows = false;
            dg_rooms.ReadOnly = true;
        }

        /** 
          * @desc Executes when a grid cell is double clicked on the room list
	      * It loads in the room belonging to the cell for editing
          * @params [none] No input parameter. 
          * @return [none] No directly returned data. 
          */
        private void dg_rooms_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Get the room id at current cell
                int id_room = int.Parse(dg_rooms.Rows[e.RowIndex].Cells[0].Value.ToString());
                // Create an edit room form
                frm_room frmRoom = new frm_room(id_room, this);
                frmRoom.ShowDialog();
            }
            catch (Exception ea)
            {
                MessageBox.Show(ea.ToString());
                return;
            }
        }


    }
}
