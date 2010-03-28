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
        public frm_equipment_list()
        {
            InitializeComponent();
        }

        private void frm_equipment_list_Load(object sender, EventArgs e)
        {
            mySqlConn conn = new mySqlConn();
            conn.connect();
            BindingSource bSource = new BindingSource();
            string sQuery = "SELECT id_equipment EID, name Name, id_set Id_Set, description Description FROM equipment ORDER BY name";
            bSource.DataSource = conn.dtGetTableForDataGrid(sQuery);
            dg_equipment.DataSource = bSource;
            dg_equipment.AllowUserToAddRows = false;
            dg_equipment.ReadOnly = true;
        }

        private void dg_classes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string sEquipmentId = dg_equipment.Rows[e.RowIndex].Cells[0].Value.ToString();
                int iEquipmentId = int.Parse(sEquipmentId);
                frm_class frm_class = new frm_class(iEquipmentId);
                frm_class.MdiParent = this.MdiParent;
                frm_class.Show();
            }
            catch (Exception ea)
            {
                MessageBox.Show(ea.ToString());
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm_equipment frmEquipment = new frm_equipment();
            frmEquipment.MdiParent = this.MdiParent;
            frmEquipment.Show();
        }

        private void button1_Click(object sender, EventArgs e)
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



    }
}
