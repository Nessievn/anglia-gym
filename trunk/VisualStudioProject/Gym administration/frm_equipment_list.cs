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
    public partial class frm_equipment_list : Form
    {
        
        MyMessageBox myMessageBox;
        frm_member frmMember;
        frm_staff frmStaff;
        bool IsBooking;
        bool IsMember;
        int Id_Person;

        public frm_equipment_list()
        {

            InitializeComponent();
            this.frmMember = null;
            this.frmStaff = null;
            rd_item.Checked = true;
            rd_item_Checked();
        }

        public frm_equipment_list(bool isBooking, bool isMember, int id_Person,frm_member frmMember, frm_staff frmStaff)
        {
            
            InitializeComponent();
            IsBooking = isBooking;
            IsMember = isMember;
            if (isMember) 
            {
                this.frmMember = frmMember;
                this.frmStaff = null;
            }
            else 
            {
                this.frmStaff = frmStaff;
                this.frmMember = null;
            }


            Id_Person = id_Person;
            rd_item.Checked = true;
            rd_item_Checked();
        }

        private void frm_equipment_list_Load(object sender, EventArgs e)
        {
            myMessageBox = new MyMessageBox();
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
            bool isBooking = false;

            if (IsBooking)
            {
                string sEquipmentName = dg_equipment.Rows[e.RowIndex].Cells[1].Value.ToString();
                string result = myMessageBox.ShowBox(Utils.MB_CUST2, "Would you like to Edit the " + sEquipmentName + " or Borrow it?", "Edit or Borrow?", "Edit", "Borrow");
                if (result == "Edit") 
                    isBooking = false; 
                else 
                    isBooking = true;
            }

            if (isBooking)
            {
                try
                {
                    string sEquipmentId = dg_equipment.Rows[e.RowIndex].Cells[0].Value.ToString();
                    int iEquipmentId = int.Parse(sEquipmentId);
                    frm_equipment frm_equipment = new frm_equipment(IsBooking, IsMember, Id_Person, iEquipmentId, this);
                    frm_equipment.MdiParent = this.MdiParent;
                    frm_equipment.Show();
                }
                catch (Exception ea)
                {
                    MessageBox.Show(ea.ToString());
                    return;
                }
             }
            else //Not Booking (regular equipment edit form)
            {
                try
                {
                    string sEquipmentId = dg_equipment.Rows[e.RowIndex].Cells[0].Value.ToString();
                    int iEquipmentId = int.Parse(sEquipmentId);
                    frm_equipment frm_equipment = new frm_equipment(iEquipmentId, this);
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
            string sQuery = "SELECT id_equipment EID, name Name, description Description FROM equipment WHERE type = 'item' ORDER BY id_equipment";
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
            string sQuery = "SELECT id_equipment EID, name Name, description Description FROM equipment WHERE type = 'set' ORDER BY id_equipment";
            setsSource.DataSource = conn.dtGetTableForDataGrid(sQuery);
            dg_equipment.DataSource = setsSource;
            dg_equipment.AllowUserToAddRows = false;
            dg_equipment.ReadOnly = true;

        }

        private void frm_equipment_list_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (IsBooking)
            {
                if (IsMember)
                {
                    if (this.frmMember != null) frmMember.vLoadBookedList();
                    //this.Close();
                }
                else
                {
                    if (this.frmStaff != null) frmStaff.vLoadBookedList();
                    //this.Close();
                }

            }

        }


        

        
    }
}
