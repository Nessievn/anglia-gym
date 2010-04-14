//Form Handler for payments. It lists all payments and let the user add a new payment,
//where it lists all members, then after selecting a member, 
//it displays a new form to add a payment to the payment list.

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
    /**
     * @desc Add payment form.
     * @params [none] Incoming parameters are described at the individual constructors.
     * @return [none] No directly returned data. 
     * Returns of public methods are described at the individual methods.
     */    
    public partial class frm_add_payment : Form
    {


        Member clMember;

        public frm_add_payment()
        {
            InitializeComponent();
        }

        public frm_add_payment(int id_member)
        {
            InitializeComponent();
            this.clMember = new Member(id_member);

        }

        private void frm_add_payment_Load(object sender, EventArgs e)
        {
            //Startup
            DateTime today = DateTime.Today;
            txt_date.Text = String.Format("{0:dd-MM-yyyy}", today);
        }

        private void button_addpayment_Click(object sender, EventArgs e)
        {
            if (txt_amount.Text.Length < 1)
            {
                MessageBox.Show("Please specify an amount!");
                return;
            }
            Decimal amount;
            try
            {
                amount = Decimal.Parse(txt_amount.Text);
            }catch(Exception ex)
            {
                MessageBox.Show("Amount can not be empty! (or) Check amount format!" + "\r\n\r\n" + ex.ToString());
                return;
            }
          
            string date = Utils.sGetMysqlDate(txt_date.Text);
            
            if (date == "0000-00-00")
            {
                MessageBox.Show("The date is in wrong format!");
                return;
            }

            if (this.clMember.AddPayment(amount, date, txt_details.Text))
            {
                MessageBox.Show("The payment has been added succesfully!");
                this.Close();
            }
            else
                MessageBox.Show("There was a problem adding your payment, please check your data!");
        }
    }
}
