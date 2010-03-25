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
    public partial class frm_class_arrange_list : Form
    {
        public frm_class_arrange_list()
        {
            InitializeComponent();
        }

        private void frm_class_arrange_list_Load(object sender, EventArgs e)
        {
            mySqlConn conn = new mySqlConn();
            conn.connect();
            BindingSource bSource = new BindingSource();
            string sQuery = "SELECT ci.id_class_instance CID, c.name Name, c.type Type, c.description Description, s.firstName Instructor, DATE_FORMAT(ci.date, '%d/%m/%Y') Date, ci.start_time Start, ci.end_time End FROM classes c, class_instance ci, staff s WHERE ci.id_class = c.id_class AND ci.id_staff = s.id_staff ORDER BY ci.date, ci.start_time";

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
                int iClassInstanceId = int.Parse(sClassId);
                frm_class_arrange frm_class_arrange = new frm_class_arrange(iClassInstanceId);
                frm_class_arrange.MdiParent = this.MdiParent;
                frm_class_arrange.Show();
            }
            catch (Exception ea)
            {
                MessageBox.Show(ea.ToString());
                return;
            }
        }
    }
}
