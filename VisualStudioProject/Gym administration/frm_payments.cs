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
    public partial class frm_payments : Form
    {
        public frm_payments()
        {
            InitializeComponent();
        }

        private void button_addpayments_Click(object sender, EventArgs e)
        {
            frm_member_list frmMemberList = new frm_member_list(true);
            frmMemberList.MdiParent = this.MdiParent;
            frmMemberList.Show();
        }

        private void frm_payments_Load(object sender, EventArgs e)
        {
            this.vloadDgPayments();
        }

        public void vloadDgPayments()
        {
            string sQuery = "";
            mySqlConn conn = new mySqlConn();
            conn.connect();
            BindingSource bSource = new BindingSource();
            sQuery = "SELECT m.id_member MID, m.member_number NO, m.firstName as 'First Name', m.lastName 'Last Name', p.amount Amount, p.details Details FROM members m, payments p WHERE m.id_member = p.id_member ORDER BY p.date";

            bSource.DataSource = conn.dtGetTableForDataGrid(sQuery);

            dg_payments.DataSource = bSource;
            dg_payments.AllowUserToAddRows = false;
            dg_payments.ReadOnly = true;
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
