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
        int Id_member = -1;

        public frm_payments()
        {
            InitializeComponent();
        }

        public frm_payments(int id_member)
        {
            InitializeComponent();
            this.Id_member = id_member;
        }

        private void button_addpayments_Click(object sender, EventArgs e)
        {
            if (this.Id_member == -1)
            {
                frm_member_list frmMemberList = new frm_member_list(this);
                //frmMemberList.MdiParent = this.MdiParent;
                //frmMemberList.Show();
                frmMemberList.ShowDialog();
            }
            else
            {
                frm_add_payment frmAddPayment = new frm_add_payment(this.Id_member);
                frmAddPayment.ShowDialog();
            }
        }

        private void frm_payments_Load(object sender, EventArgs e)
        {
            //this.vloadDgPayments();
        }

        public void vloadDgPayments()
        {
            string sQuery = "";
            mySqlConn conn = new mySqlConn();
            conn.connect();
            BindingSource bSource = new BindingSource();
            if (this.Id_member == -1)
                sQuery = "SELECT m.id_member MID, m.member_number NO, m.firstName as 'First Name', m.lastName 'Last Name', p.amount Amount, p.details Details, DATE_FORMAT(p.date,'%d-%m-%Y') 'Date dd-mm-yyyy' FROM members m, payments p WHERE m.id_member = p.id_member ORDER BY p.date";
            else
                sQuery = "SELECT m.id_member MID, m.member_number NO, m.firstName as 'First Name', m.lastName 'Last Name', p.amount Amount, p.details Details, DATE_FORMAT(p.date,'%d-%m-%Y') 'Date dd-mm-yyyy' FROM members m, payments p WHERE m.id_member = p.id_member AND m.id_member = " + this.Id_member + " ORDER BY p.date";
            bSource.DataSource = conn.dtGetTableForDataGrid(sQuery);

            dg_payments.DataSource = bSource;
            dg_payments.AllowUserToAddRows = false;
            dg_payments.ReadOnly = true;
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_payments_Activated(object sender, EventArgs e)
        {
            this.vloadDgPayments();
        }
    }
}
