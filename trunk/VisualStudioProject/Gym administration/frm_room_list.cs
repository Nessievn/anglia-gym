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
    public partial class frm_room_list : Form
    {
        public frm_room_list()
        {
            InitializeComponent();
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            mySqlConn conn = new mySqlConn();
            conn.connect();
            BindingSource bSource = new BindingSource();
            string sQuery = "SELECT id_room RID, name Name, size Size, description Description FROM rooms WHERE 1 = 1";
            if (txt_roomname.Text != "")
                sQuery += " AND name LIKE '%" + txt_roomname.Text + "%'";

            sQuery += "  ORDER BY id_room";

            bSource.DataSource = conn.dtGetTableForDataGrid(sQuery);
            dg_rooms.DataSource = bSource;
            dg_rooms.AllowUserToAddRows = false;
            dg_rooms.ReadOnly = true;
        }

        private void button_addroom_Click(object sender, EventArgs e)
        {
            frm_room frmRoom = new frm_room();
            frmRoom.MdiParent = this.MdiParent;
            frmRoom.Show();
        }

        private void frm_room_list_Load(object sender, EventArgs e)
        {
            mySqlConn conn = new mySqlConn();
            conn.connect();
            BindingSource bSource = new BindingSource();
            string sQuery = "SELECT id_room RID, name Name, size Size, description Description FROM rooms ORDER BY id_room";
            bSource.DataSource = conn.dtGetTableForDataGrid(sQuery);
            dg_rooms.DataSource = bSource;
            dg_rooms.AllowUserToAddRows = false;
            dg_rooms.ReadOnly = true;
        }

        private void dg_rooms_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string sRoomId = dg_rooms.Rows[e.RowIndex].Cells[0].Value.ToString();
                int iRoomId = int.Parse(sRoomId);
                frm_room frm_rm = new frm_room(iRoomId);
                frm_rm.MdiParent = this.MdiParent;
                frm_rm.Show();
            }
            catch (Exception ea)
            {
                MessageBox.Show(ea.ToString());
                return;
            }
        }


    }
}
