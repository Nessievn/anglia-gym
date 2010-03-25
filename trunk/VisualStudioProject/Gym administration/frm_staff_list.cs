using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Gym_administration
{
    public partial class frm_staff_list : Form
    {
        public frm_staff_list()
        {
            InitializeComponent();
        }

        private void dg_staff_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string sStaffId = dg_staff.Rows[e.RowIndex].Cells[0].Value.ToString();
                int iStfId = int.Parse(sStaffId);
                frm_staff frm_stf = new frm_staff(iStfId);
                frm_stf.MdiParent = this.MdiParent;
                frm_stf.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            mySqlConn conn = new mySqlConn();
            conn.connect();
            BindingSource bSource = new BindingSource();
            string sQuery = "SELECT id_staff MID, staff_number NO, firstName as 'First Name', lastName 'Last Name', DATE_FORMAT(birthdate,\"%d/%m/%Y\") DOB, email 'EMail' FROM staffs WHERE 1 = 1 ";
            if (txt_firstName.Text != "")
                sQuery += " AND firstName LIKE '%" + txt_firstName.Text + "%'";
            if (txt_lastName.Text != "")
                sQuery += " AND lastName LIKE '%" + txt_lastName.Text + "%'";
            if (txt_email.Text != "")
                sQuery += " AND email LIKE '%" + txt_email.Text + "%'";
            string sDate = Utils.sGetMysqlDate(txt_dob.Text);
            if (sDate != "0000-00-00")
                sQuery += " AND birthdate = '" + sDate + "'";

            sQuery += "  ORDER BY id_staff";

            bSource.DataSource = conn.dtGetTableForDataGrid(sQuery);
            dg_staff.DataSource = bSource;
            dg_staff.AllowUserToAddRows = false;
            dg_staff.ReadOnly = true;
        }

        private void frm_staff_list_Load(object sender, EventArgs e)
        {
            mySqlConn conn = new mySqlConn();
            conn.connect();
            BindingSource bSource = new BindingSource();
            string sQuery = "SELECT id_staff MID, firstName as 'First Name', lastName 'Last Name', DATE_FORMAT(birthdate,\"%d/%m/%Y\") DOB, email 'EMail' FROM staff s, users u WHERE u.id_user = s.id_user ORDER BY id_staff";
            bSource.DataSource = conn.dtGetTableForDataGrid(sQuery);
            dg_staff.DataSource = bSource;
            dg_staff.AllowUserToAddRows = false;
            dg_staff.ReadOnly = true;
        }

        private void dg_staff_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm_staff frmStaff = new frm_staff();
            frmStaff.MdiParent = this.MdiParent;
            frmStaff.Show();
        }

    }
}
