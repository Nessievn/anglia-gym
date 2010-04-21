//RENAME THIS TO frm_payments_list!!!
     /* Form Handler for payments. It lists all payments and let the user add a new payment,
     * where it lists all members, then after selecting a member, 
     * it displays a new form to add a payment to the payment list.*/


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
     * @desc 
     * Form Handler for listing all payments
     * @params [none] Incoming parameters are described at the individual constructors.
     * @return [none] No directly returned data. 
     * Returns of public methods are described at the individual methods.
     */
    public partial class frm_payment_list : Form
    {
        int Id_member = -1;

        /** 
         * @desc Default constructor for creating payment list from main menu.
         * This is for loading from main menu, 
         * @params [none] No input parameter. 
         * @return [none] No directly returned data. 
         */
        public frm_payment_list()
        {
            InitializeComponent();
            vloadDgPayments();
        }

        /** 
         * @desc Constructor to add a payment to a specific member
         * This is for loading from frm_member member panel 
         * @params [int] id_member: This is for reference to a member.
         * @return [none] No directly returned data. 
         */
        public frm_payment_list(int id_member)
        {
            InitializeComponent();
            this.Id_member = id_member;
            vloadDgPayments();
        }

        /** 
          * @desc Executes when the Add Payment button is clicked
	      * It invokes the frm_member_list panel for selecting a member to add a payment
          * Or if an id_member is already present then open frm_add_payment for that member
          * @params [none] No input parameter. 
          * @return [none] No directly returned data. 
          */
        private void button_addpayments_Click(object sender, EventArgs e)
        {
            // if this was launche from main menu invoke the frm_member_list panel for selecting a member to add a payment
            if (this.Id_member == -1)
            {
                frm_member_list frmMemberList = new frm_member_list(this);
                frmMemberList.ShowDialog();
            }
            // if an id_member is already present then open frm_add_payment for that member
            else
            {
                frm_add_payment frmAddPayment = new frm_add_payment(this.Id_member);
                frmAddPayment.ShowDialog();
            }
        }

        /** 
          * @desc This method refreshes the payment list
          * @params [none] No input parameter. 
          * @return [none] No directly returned data. 
          */ 
        public void vloadDgPayments()
        {
            string query = "";
            // Create mysql connection           
            mySqlConn conn = new mySqlConn();
            conn.connect();
            // Create source for grid
            BindingSource itemsSource = new BindingSource();
            // Create query for retrieving all payments
            if (this.Id_member == -1)
                query = "SELECT m.id_member MID, m.member_number NO, CONCAT(m.lastName,', ', m.firstName) Name, p.amount Amount, p.details Details, DATE_FORMAT(p.date,'%d-%m-%Y') 'Date dd-mm-yyyy', CONCAT(s.lastName,', ', s.firstName) 'Received By', p.receiptnumber 'Receipt Number', p.paymentmethod Method FROM members m, payments p, staff s WHERE m.id_member = p.id_member AND s.id_staff = p.receivedby ORDER BY m.id_member";
            // Create query for retrieving payments for a specific member only
            else
                query = "SELECT m.id_member MID, m.member_number NO, CONCAT(m.lastName,', ', m.firstName) Name, p.amount Amount, p.details Details, DATE_FORMAT(p.date,'%d-%m-%Y') 'Date dd-mm-yyyy', CONCAT(s.lastName,', ', s.firstName) 'Received By', p.receiptnumber 'Receipt Number', p.paymentmethod Method FROM members m, payments p, staff s WHERE m.id_member = p.id_member AND m.id_member = " + this.Id_member + "  AND s.id_staff = p.receivedby ORDER BY m.id_member";
            // Launch query and load result into source
            itemsSource.DataSource = conn.dtGetTableForDataGrid(query);
            // Assign source to grid
            dg_payments.DataSource = itemsSource;
            dg_payments.AllowUserToAddRows = false;
            dg_payments.ReadOnly = true;
        }

        // Close/Cancel
        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}

