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
    public partial class frm_class_list : Form
    {
        public frm_class_list()
        {
            InitializeComponent();
        }

   


        private void frm_class_list_Load(object sender, EventArgs e)
        {
            mySqlConn conn = new mySqlConn();
            conn.connect();
            BindingSource bSource = new BindingSource();
            string sQuery = "SELECT id_class CID, name Name, type Type, description Description FROM classes ORDER BY id_class";
            bSource.DataSource = conn.dtGetTableForDataGrid(sQuery);
            dg_classes.DataSource = bSource;
            dg_classes.AllowUserToAddRows = false;
            dg_classes.ReadOnly = true;
        }

        private void dg_classes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string sClassId = dg_classes.Rows[e.RowIndex].Cells[0].Value.ToString();
                int iClassId = int.Parse(sClassId);
                frm_class frm_class = new frm_class(iClassId);
                frm_class.MdiParent = this.MdiParent;
                frm_class.Show();
            }
            catch (Exception ea)
            {
                MessageBox.Show(ea.ToString());
                return;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            frm_class frmClass = new frm_class();
            frmClass.MdiParent = this.MdiParent;
            frmClass.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            mySqlConn conn = new mySqlConn();
            conn.connect();
            BindingSource bSource = new BindingSource();
            string sQuery = "SELECT id_class CID, name Name, type Type, description Description FROM classes WHERE 1 = 1";
            if (txt_classname.Text != "")
                sQuery += " AND name LIKE '%" + txt_classname.Text + "%'";

            sQuery += "  ORDER BY id_class";

            bSource.DataSource = conn.dtGetTableForDataGrid(sQuery);
            dg_classes.DataSource = bSource;
            dg_classes.AllowUserToAddRows = false;
            dg_classes.ReadOnly = true;
        }


    }
}
