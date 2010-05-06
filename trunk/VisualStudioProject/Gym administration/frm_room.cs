using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Gym_administration
{
    /**
     * @desc Form Handler for rooms. 
     * It is for adding or modifying a room.
     * @params [none] Incoming parameters are described at the individual constructors.
     * @return [none] No directly returned data. 
     * Returns of public methods are described at the individual methods.
     */
    public partial class frm_room : Form
    {
        Room clRoom;
        frm_room_list frmRoomList;

        /** 
         * @desc Default constructor for creating new room from main menu
         * Not implemented
         * @params [none] No input parameter. 
         * @return [none] No directly returned data. 
         */
        public frm_room()
        {
            InitializeComponent();
            this.Text = "Add New Room Form";
            clRoom = new Room();
            button_remove.Enabled = false;
        }

        /** 
         * @desc Default constructor for creating new room from room list
         * @params [frm_room_list] frmRoomList: This is for referencing to parent class
         * @return [none] No directly returned data. 
         */
        public frm_room(frm_room_list frmRoomList)
        {
            this.frmRoomList = frmRoomList;
            InitializeComponent();
            this.Text = "Add New Room Form";
            clRoom = new Room();
            button_remove.Enabled = false;
        }

        /** 
         * @desc Default constructor for editing an existing room from room list
         * @params [int] id_room: This is for referencing to a specific room
         * @params [frm_room_list] frmRoomList: This is for referencing to parent class
         * @return [none] No directly returned data. 
         */
        public frm_room(int id_room, frm_room_list frmRoomList)
        {
            this.frmRoomList = frmRoomList;
            InitializeComponent();
            this.Text = "Edit Room Form";
            clRoom = new Room(id_room);
            if (clRoom.Id_room < 1)
                MessageBox.Show("The room could not be found");
            else
            {
                txt_roomdesc.Text = clRoom.Description;
                txt_roomname.Text = clRoom.Name;
                txt_roomsize.Text = clRoom.Size.ToString();
            }
        }


        /** 
          * @desc Executes when the "Save" button is clicked
	      * It checks user input and then calls for saving the room
          * @params [none] No input parameter. 
          * @return [none] No directly returned data. 
          */
        private void button_save_Click(object sender, EventArgs e)
        {
            // Check user inputs and formats
            try
            {
                if (txt_roomsize.Text == "")
                    txt_roomsize.Text = "0";

                clRoom.Size = int.Parse(txt_roomsize.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("The size must be numeric please");
                return;
            }
            
            // Copy form fields into object fields
            clRoom.Description = txt_roomdesc.Text;
            clRoom.Name = txt_roomname.Text;
            // Save the room
            if (clRoom.SaveRoom())
            {
                // Refresh parent list if parent exists
                if (this.frmRoomList != null) this.frmRoomList.vLoadRoomList();
                this.Close();
            }
        }

        /** 
          * @desc Executes when the "Remove" button is clicked
	      * It asks for confirmation and then calls for removing the room
          * @params [none] No input parameter. 
          * @return [none] No directly returned data. 
          */
        private void button_remove_Click(object sender, EventArgs e)
        {
            // Confirm removal
            DialogResult result = MessageBox.Show("Are you sure?", "Delete entry", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // Remove room
                if (clRoom.RemoveRoom())
                {
                    if (this.frmRoomList != null) this.frmRoomList.vLoadRoomList();
                    this.Close();
                }
            }
        }

        //Cancel/Close
        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }



    }
}
