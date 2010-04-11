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
        Room rmRoom;

        public frm_room()
        {
            InitializeComponent();
            rmRoom = new Room();
        }
        public frm_room(int iIdRoom)
        {
            InitializeComponent();
            rmRoom = new Room(iIdRoom);
            if (rmRoom.Id_room < 1)
                MessageBox.Show("The room could not be found");
            else
            {
                txt_roomdesc.Text = rmRoom.Description;
                txt_roomname.Text = rmRoom.Name;
                txt_roomsize.Text = rmRoom.Size.ToString();
            }
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_roomsize.Text == "")
                    txt_roomsize.Text = "0";

                rmRoom.Size = int.Parse(txt_roomsize.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("The size must be numeric please");
                return;
            }
            
            rmRoom.Description = txt_roomdesc.Text;
            rmRoom.Name = txt_roomname.Text;

            rmRoom.bSave();
        }

        private void button_remove_Click(object sender, EventArgs e)
        {

            DialogResult res = MessageBox.Show("Are you sure?", "Delete entry", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
             rmRoom.bRemove();
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
