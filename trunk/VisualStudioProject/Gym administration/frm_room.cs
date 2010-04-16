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
    public partial class frm_room : Form
    {
        Room clRoom;

        public frm_room()
        {
            InitializeComponent();
            clRoom = new Room();
        }
        public frm_room(int iIdRoom)
        {
            InitializeComponent();
            clRoom = new Room(iIdRoom);
            if (clRoom.Id_room < 1)
                MessageBox.Show("The room could not be found");
            else
            {
                txt_roomdesc.Text = clRoom.Description;
                txt_roomname.Text = clRoom.Name;
                txt_roomsize.Text = clRoom.Size.ToString();
            }
        }

        private void button_save_Click(object sender, EventArgs e)
        {
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
            
            clRoom.Description = txt_roomdesc.Text;
            clRoom.Name = txt_roomname.Text;

            clRoom.SaveRoom();
        }

        private void button_remove_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Are you sure?", "Delete entry", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
             clRoom.RemoveRoom();
             this.Close();
            }
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_room_Load(object sender, EventArgs e)
        {
            //Startup load
        }


    }
}
