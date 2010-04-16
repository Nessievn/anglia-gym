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
                //frm_stf.MdiParent = this.MdiParent;
                //frm_stf.Show();
                frm_stf.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }



        private void button_search_Click(object sender, EventArgs e)
        {
            mySqlConn conn = new mySqlConn();
            conn.connect();
            BindingSource bSource = new BindingSource();
            string query = "SELECT id_staff MID, staff_number NO, firstName as 'First Name', lastName 'Last Name', DATE_FORMAT(birthdate,\"%d/%m/%Y\") DOB, email 'EMail' FROM staffs WHERE 1 = 1 ";
            if (txt_firstName.Text != "")
                query += " AND firstName LIKE '%" + txt_firstName.Text + "%'";
            if (txt_lastName.Text != "")
                query += " AND lastName LIKE '%" + txt_lastName.Text + "%'";
            if (txt_email.Text != "")
                query += " AND email LIKE '%" + txt_email.Text + "%'";
            string sDate = Utils.sGetMysqlDate(txt_dob.Text);
            if (sDate != "0000-00-00")
                query += " AND birthdate = '" + sDate + "'";

            query += "  ORDER BY id_staff";

            bSource.DataSource = conn.dtGetTableForDataGrid(query);
            dg_staff.DataSource = bSource;
            dg_staff.AllowUserToAddRows = false;
            dg_staff.ReadOnly = true;
        }


        public void vLoadStaffList()
        {
            mySqlConn conn = new mySqlConn();
            conn.connect();
            BindingSource bSource = new BindingSource();
            string query = "SELECT id_staff MID, firstName as 'First Name', lastName 'Last Name', DATE_FORMAT(birthdate,\"%d/%m/%Y\") DOB, email 'EMail' FROM staff s, users u WHERE u.id_user = s.id_user ORDER BY id_staff";
            bSource.DataSource = conn.dtGetTableForDataGrid(query);
            dg_staff.DataSource = bSource;
            dg_staff.AllowUserToAddRows = false;
            dg_staff.ReadOnly = true;
        }

        private void frm_staff_list_Load(object sender, EventArgs e)
        {
            //vLoadStaffList();
        }


        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_addstaffmember_Click(object sender, EventArgs e)
        {
            bool isFromStaffList = true;
            frm_staff frmStaff = new frm_staff(isFromStaffList);
            //frmStaff.MdiParent = this.MdiParent;
            //frmStaff.Show();
            frmStaff.ShowDialog();
        }

        private void frm_staff_list_Activated(object sender, EventArgs e)
        {
            vLoadStaffList();
        }

        
        

    }
}
