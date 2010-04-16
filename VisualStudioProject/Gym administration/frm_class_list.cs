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
            vLoadClassList();
        }

        public void vLoadClassList()
        {
            mySqlConn conn = new mySqlConn();
            conn.connect();
            BindingSource bSource = new BindingSource();
            string query = "SELECT id_class CID, name Name, type Type, description Description FROM classes ORDER BY id_class";
            bSource.DataSource = conn.dtGetTableForDataGrid(query);
            dg_classes.DataSource = bSource;
            dg_classes.AllowUserToAddRows = false;
            dg_classes.ReadOnly = true;
            dg_classes.Columns[3].Width = 300;
        }


        private void dg_classes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string sClassId = dg_classes.Rows[e.RowIndex].Cells[0].Value.ToString();
                int iClassId = int.Parse(sClassId);
                frm_class frm_class = new frm_class(iClassId, this);
                //frm_class.MdiParent = this.MdiParent;
                //frm_class.Show();
                frm_class.ShowDialog();
            }
            catch (Exception ea)
            {
                MessageBox.Show(ea.ToString());
                return;
            }
        }

        private void button_addclass_Click(object sender, EventArgs e)
        {
            frm_class frmClass = new frm_class(this);
            //frmClass.MdiParent = this.MdiParent;
            //frmClass.Show();
            frmClass.ShowDialog();
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            mySqlConn conn = new mySqlConn();
            conn.connect();
            BindingSource bSource = new BindingSource();
            string query = "SELECT id_class CID, name Name, type Type, description Description FROM classes WHERE 1 = 1";
            if (txt_classname.Text != "")
                query += " AND name LIKE '%" + txt_classname.Text + "%'";

            query += "  ORDER BY id_class";

            bSource.DataSource = conn.dtGetTableForDataGrid(query);
            dg_classes.DataSource = bSource;
            dg_classes.AllowUserToAddRows = false;
            dg_classes.ReadOnly = true;
        }



    }
}
