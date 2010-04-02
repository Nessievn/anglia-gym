﻿using System;
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
    public partial class frm_equipment_list : Form
    {
        bool IsBooking;
        bool IsMember;
        int Id_Member;

        public frm_equipment_list()
        {

            InitializeComponent();
            rd_item.Checked = true;
            rd_item_Checked();
        }

        public frm_equipment_list(bool isBooking, bool isMember, int id_Member)
        {
            IsBooking = isBooking;
            IsMember = isMember;
            Id_Member = id_Member;
            InitializeComponent();
            rd_item.Checked = true;
            rd_item_Checked();
        }

        private void frm_equipment_list_Load(object sender, EventArgs e)
        {
            //..
        }

        public void vLoadEqList(string type)
        {
            if (type == "item")
            {
                rd_item.Checked = true;
                rd_item_Checked();
            }
            else if (type == "set")
            {
                rd_set.Checked = true;
                rd_set_Checked();
            }

        }



        private void dg_equipment_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (IsBooking)
            {

/*
                string result = MyMessageBox.ShowBox("Do you want to exit?", "Exit");
                if (result.Equals("1"))
                {
                    MessageBox.Show("OK Button was Clicked");
                }

                if (result.Equals("2"))
                {
                    MessageBox.Show("Cancel Button was Clicked");
                }

*/

//                DialogResult res = MessageBox.Show("Edit?", "Edit the item instead of borrowing?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
//                if (res == DialogResult.Yes)


                try
                {
                    string sEquipmentId = dg_equipment.Rows[e.RowIndex].Cells[0].Value.ToString();
                    int iEquipmentId = int.Parse(sEquipmentId);
                    frm_equipment frm_equipment = new frm_equipment(IsBooking, IsMember, Id_Member, iEquipmentId, this);
                    frm_equipment.MdiParent = this.MdiParent;
                    frm_equipment.Show();
                }
                catch (Exception ea)
                {
                    MessageBox.Show(ea.ToString());
                    return;
                }
            }
            else
            {
                try
                {
                    string sEquipmentId = dg_equipment.Rows[e.RowIndex].Cells[0].Value.ToString();
                    int iEquipmentId = int.Parse(sEquipmentId);
                    frm_equipment frm_equipment = new frm_equipment(false, false, -1, iEquipmentId, this);
                    frm_equipment.MdiParent = this.MdiParent;
                    frm_equipment.Show();
                    
                }
                catch (Exception ea)
                {
                    MessageBox.Show(ea.ToString());
                    return;
                }
            }



        }

        private void button_addequipment_Click(object sender, EventArgs e)
        {
            frm_equipment frmEquipment = new frm_equipment(this);
            frmEquipment.MdiParent = this.MdiParent;
            frmEquipment.Show();
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            mySqlConn conn = new mySqlConn();
            conn.connect();
            BindingSource bSource = new BindingSource();
            string sQuery = "SELECT id_equipment EID, name Name, id_set Id_Set, description Description FROM equipment WHERE 1 = 1";
            if (txt_equipmentname.Text != "")
                sQuery += " AND name LIKE '%" + txt_equipmentname.Text + "%'";

            sQuery += "  ORDER BY name";

            bSource.DataSource = conn.dtGetTableForDataGrid(sQuery);
            dg_equipment.DataSource = bSource;
            dg_equipment.AllowUserToAddRows = false;
            dg_equipment.ReadOnly = true;
        }


        private void rd_item_Checked(object sender, EventArgs e)
        {
            rd_item_Checked();
        }
        private void rd_item_Checked()
        {
            mySqlConn conn = new mySqlConn();
            conn.connect();
            BindingSource itemsSource = new BindingSource();
            string sQuery = "SELECT id_equipment EID, name Name, description Description, currentlyinstock Stock FROM equipment WHERE type = 'item' ORDER BY id_equipment";
            itemsSource.DataSource = conn.dtGetTableForDataGrid(sQuery);
            dg_equipment.DataSource = itemsSource;
            dg_equipment.AllowUserToAddRows = false;
            dg_equipment.ReadOnly = true;

        }


        private void rd_set_Checked(object sender, EventArgs e)
        {
            rd_set_Checked();
        }

        private void rd_set_Checked()
        {

            mySqlConn conn = new mySqlConn();
            conn.connect();
            BindingSource setsSource = new BindingSource();
            string sQuery = "SELECT id_equipment EID, name Name, description Description, iteminset1 Setitem1, amountinset1 Amount, iteminset2 Setitem2, amountinset2 Amount, iteminset3 Setitem3, amountinset3 Amount, iteminset4 Setitem4, amountinset4 Amount, iteminset5 Setitem5, amountinset5 Amount FROM equipment WHERE type = 'set' ORDER BY id_equipment";
            setsSource.DataSource = conn.dtGetTableForDataGrid(sQuery);
            dg_equipment.DataSource = setsSource;
            dg_equipment.AllowUserToAddRows = false;
            dg_equipment.ReadOnly = true;

        }
    }
}
