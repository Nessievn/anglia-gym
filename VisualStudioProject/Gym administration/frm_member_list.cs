using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;


namespace Gym_administration
{
    public partial class frm_member_list : Form
    {
        public frm_member_list()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            mySqlConn conn = new mySqlConn();
            conn.connect();
            BindingSource bSource = new BindingSource();
            string sQuery = "SELECT id_member MID, member_number NO, firstName as 'First Name', lastName 'Last Name', birthdate DOB, email 'EMail' FROM members ORDER BY firstName";
            bSource.DataSource = conn.dtGetTableForDataGrid(sQuery);
            dg_members.DataSource = bSource;
            dg_members.AllowUserToAddRows = false;
            dg_members.ReadOnly = true;
        }


        private void dg_members_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string sMemberId = dg_members.Rows[e.RowIndex].Cells[0].Value.ToString();
            int iMbrId = int.Parse(sMemberId);
            frm_member frm_mbr = new frm_member(iMbrId);
            frm_mbr.MdiParent = this.MdiParent;
            frm_mbr.Show();
        }

        private void dg_members_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            mySqlConn conn = new mySqlConn();
            conn.connect();
            BindingSource bSource = new BindingSource();
            string sQuery = "SELECT id_member MID, member_number NO, firstName as 'First Name', lastName 'Last Name', birthdate DOB, email 'EMail' FROM members WHERE id_member > 4  ORDER BY firstName";
            bSource.DataSource = conn.dtGetTableForDataGrid(sQuery);
            dg_members.DataSource = bSource;
            dg_members.AllowUserToAddRows = false;
            dg_members.ReadOnly = true;
        }
    }
}
