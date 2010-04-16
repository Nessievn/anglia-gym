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
    public partial class frm_class_instance_list : Form
    {
        public frm_class_instance_list()
        {
            InitializeComponent();
        }
        public void vLoadDgClassList()
        {
            mySqlConn conn = new mySqlConn();
            conn.connect();
            BindingSource bSource = new BindingSource();
            string query = "SELECT ci.id_class_instance CID, c.name Name, c.type Type, c.description Description, s.firstName Instructor, DATE_FORMAT(ci.date, '%d/%m/%Y') Date, ci.start_time Start, ci.end_time End FROM classes c, class_instance ci, staff s WHERE ci.id_class = c.id_class AND ci.id_staff = s.id_staff ORDER BY ci.date, ci.start_time";

            bSource.DataSource = conn.dtGetTableForDataGrid(query);
            dg_classes.DataSource = bSource;
            dg_classes.AllowUserToAddRows = false;
            dg_classes.ReadOnly = true;
        }
        private void frm_class_instance_list_Load(object sender, EventArgs e)
        {
            this.vLoadDgClassList();
        }

        private void dg_classes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string sClassId = dg_classes.Rows[e.RowIndex].Cells[0].Value.ToString();
                int iClassInstanceId = int.Parse(sClassId);
                frm_class_instance_arrange frm_class_instance_arrange = new frm_class_instance_arrange(iClassInstanceId, this);
                //frm_class_instance_arrange.MdiParent = this.MdiParent;
                //frm_class_instance_arrange.Show();
                frm_class_instance_arrange.ShowDialog();
            }
            catch (Exception ea)
            {
                MessageBox.Show(ea.ToString());
                return;
            }
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            mySqlConn conn = new mySqlConn();
            conn.connect();
            BindingSource bSource = new BindingSource();
            string query = "SELECT ci.id_class_instance CID, c.name Name, c.type Type, c.description Description, s.firstName Instructor, DATE_FORMAT(ci.date, '%d/%m/%Y') Date, ci.start_time Start, ci.end_time End FROM classes c, class_instance ci, staff s WHERE ci.id_class = c.id_class AND ci.id_staff = s.id_staff ";
            if (txt_classname.Text != "")
                query += " AND c.name LIKE '%" + txt_classname.Text + "%'";

            query += " ORDER BY ci.date, ci.start_time";

            bSource.DataSource = conn.dtGetTableForDataGrid(query);
            dg_classes.DataSource = bSource;
            dg_classes.AllowUserToAddRows = false;
            dg_classes.ReadOnly = true;
        }


    }
}
