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
            string sQuery = "SELECT id_member MID, member_number NO, firstName as 'First Name', lastName 'Last Name', DATE_FORMAT(birthdate,\"%d/%m/%Y\") DOB, email 'EMail' FROM members ORDER BY id_member";
            bSource.DataSource = conn.dtGetTableForDataGrid(sQuery);
            dg_members.DataSource = bSource;
            dg_members.AllowUserToAddRows = false;
            dg_members.ReadOnly = true;
        }


        private void dg_members_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string sMemberId = dg_members.Rows[e.RowIndex].Cells[0].Value.ToString();
                int iMbrId = int.Parse(sMemberId);
                frm_member frm_mbr = new frm_member(iMbrId);
                frm_mbr.MdiParent = this.MdiParent;
                frm_mbr.Show();
            }catch(Exception)
            {
                return;
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            mySqlConn conn = new mySqlConn();
            conn.connect();
            BindingSource bSource = new BindingSource();
            string sQuery = "SELECT id_member MID, member_number NO, firstName as 'First Name', lastName 'Last Name', DATE_FORMAT(birthdate,\"%d/%m/%Y\") DOB, email 'EMail' FROM members WHERE 1 = 1 ";
            if (txt_firstName.Text != "")
                sQuery += " AND firstName LIKE '%"+txt_firstName.Text+"%'";
            if (txt_lastName.Text != "")
                sQuery += " AND lastName LIKE '%" + txt_lastName.Text + "%'";
            if (txt_email.Text != "")
                sQuery += " AND email LIKE '%" + txt_email.Text + "%'";
            if (txt_membernum.Text != "")
                sQuery += " AND member_number LIKE '%" + txt_membernum.Text + "%'";
            string sDate = Utils.sGetMysqlDate(txt_dob.Text);
            if (sDate != "0000-00-00")
                sQuery += " AND birthdate = '" + sDate + "'";

            sQuery += "  ORDER BY id_member";

            bSource.DataSource = conn.dtGetTableForDataGrid(sQuery);
            dg_members.DataSource = bSource;
            dg_members.AllowUserToAddRows = false;
            dg_members.ReadOnly = true;
        }

    }
}
