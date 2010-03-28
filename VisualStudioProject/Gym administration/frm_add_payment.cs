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
    
    public partial class frm_add_payment : Form
    {


        Member mbMember;
        public frm_add_payment()
        {
            InitializeComponent();
        }
        public frm_add_payment(int iMbrId)
        {
            InitializeComponent();
            this.mbMember = new Member(iMbrId);

        }

        private void frm_add_payment_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_amount.Text.Length < 1)
            {
                MessageBox.Show("Please specify an amount!");
                return;
            }
            Decimal dAmount;
            try
            {
                dAmount = Decimal.Parse(txt_amount.Text);
            }catch(Exception ex)
            {
                MessageBox.Show("Check amount format!");
                return;
            }
          
            string sDate = Utils.sGetMysqlDate(txt_date.Text);
            
            if (sDate == "0000-00-00")
            {
                MessageBox.Show("The date is in wrong format!");
                return;
            }

            if (this.mbMember.bAddPayment(dAmount, sDate, txt_details.Text))
            {
                MessageBox.Show("The payment has been added succesfully!");
                //this.frmMemberList.vloadDgPayments();
                this.Close();
            }
            else
                MessageBox.Show("There was a problem adding your payment, please check your data!");
        }
    }
}
