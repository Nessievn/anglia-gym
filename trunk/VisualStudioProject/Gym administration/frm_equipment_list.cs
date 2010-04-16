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
        
        frm_message_box frmMessageBox;
        frm_member frmMember;
        frm_staff frmStaff;
        frm_class_instance_arrange frmClass;
        bool IsBooking;
        int Id_member;
        int Id_staff;
        int Id_class_instance;

        public frm_equipment_list()
        {
            Id_member = -1;
            Id_staff = -1; 
            Id_class_instance = -1;
            InitializeComponent();
            this.frmMember = null;
            this.frmStaff = null;
            this.frmClass = null;
            rd_item.Checked = true;
            rd_item_Checked();
        }

        public frm_equipment_list(int id_member, frm_member frmMember)
        {
            IsBooking = true;
            Id_staff = -1; 
            Id_class_instance = -1;
            
            Id_member = id_member;
            this.frmMember = frmMember;
            InitializeComponent();
            rd_item.Checked = true;
            rd_item_Checked();
        }

        public frm_equipment_list(int id_staff, frm_staff frmStaff)
        {
            IsBooking = true;
            Id_member = -1;
            Id_class_instance = -1;

            Id_staff = id_staff;
            this.frmStaff = frmStaff;
            InitializeComponent();
            rd_item.Checked = true;
            rd_item_Checked();
        }


        public frm_equipment_list(int id_class_instance, frm_class_instance_arrange frmClass)
        {

            IsBooking = true;
            Id_member = -1;
            Id_staff = -1;

            Id_class_instance = id_class_instance;
            this.frmClass = frmClass;
            InitializeComponent();
            rd_item.Checked = true;
            rd_item_Checked();
        }


        private void frm_equipment_list_Load(object sender, EventArgs e)
        {
            frmMessageBox = new frm_message_box();
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
                string result = frmMessageBox.ShowBox(Utils.MB_CUST2, "Would you like to Edit the " + sEquipmentName + " or Borrow it?", "Edit or Borrow?", "Edit", "Borrow");
                if (result == "Edit") 
                    isBooking = false; 
                else 
                    isBooking = true;
            }

            if (isBooking)
            {
                try
                {
                    string sId_Equipment = dg_equipment.Rows[e.RowIndex].Cells[0].Value.ToString();
                    int id_Equipment = int.Parse(sId_Equipment);
                    frm_equipment frm_equipment = new frm_equipment(Id_member, Id_staff, Id_class_instance, id_Equipment, this);                    
                    //frm_equipment.MdiParent = this.MdiParent;
                    //frm_equipment.Show();
                    frm_equipment.ShowDialog();
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
                    string sId_Equipment = dg_equipment.Rows[e.RowIndex].Cells[0].Value.ToString();
                    int id_Equipment = int.Parse(sId_Equipment);
                    frm_equipment frm_equipment = new frm_equipment(id_Equipment, this);
                    //frm_equipment.MdiParent = this.MdiParent;
                    //frm_equipment.Show();
                    frm_equipment.ShowDialog();
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
            //frmEquipment.MdiParent = this.MdiParent;
            frmEquipment.ShowDialog();
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            mySqlConn conn = new mySqlConn();
            conn.connect();
            BindingSource bSource = new BindingSource();
            string query = "";
            if (rd_item.Checked == true)
                query = "SELECT id_equipment EID, name Name, description Description FROM equipment WHERE type = 'item' AND 1 = 1";
            else
                query = "SELECT id_equipment EID, name Name, description Description FROM equipment WHERE type = 'set' AND 1 = 1";

            if (txt_equipmentname.Text != "")
                query += " AND name LIKE '%" + txt_equipmentname.Text + "%'";

            query += "  ORDER BY name";




            bSource.DataSource = conn.dtGetTableForDataGrid(query);
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
            string query = "SELECT id_equipment EID, name Name, description Description FROM equipment WHERE type = 'item' ORDER BY id_equipment";
            itemsSource.DataSource = conn.dtGetTableForDataGrid(query);
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
            string query = "SELECT id_equipment EID, name Name, description Description FROM equipment WHERE type = 'set' ORDER BY id_equipment";
            setsSource.DataSource = conn.dtGetTableForDataGrid(query);
            dg_equipment.DataSource = setsSource;
            dg_equipment.AllowUserToAddRows = false;
            dg_equipment.ReadOnly = true;

        }

        private void frm_equipment_list_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (IsBooking)
            {
                    if (this.frmMember != null) frmMember.vLoadBookedList();

                    if (this.frmStaff != null) frmStaff.vLoadBookedList();

                    if (this.frmClass != null) frmClass.vLoadBookedList();



            }

        }


        

        
    }
}
