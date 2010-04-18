using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Gym_administration
{
    /**
     * @desc Form Handler for adding new payments to members.
     * It is for adding a new payment to the database.
     * @params [none] Incoming parameters are described at the individual constructors.
     * @return [none] No directly returned data. 
     * Returns of public methods are described at the individual methods.
     */    
    public partial class frm_add_payment : Form
    {

	// Declare a member object
        Member clMember;

        /** 
          * @desc Default constructor. 
          * @params [none] No input parameter. 
          * @return [none] No directly returned data. 
          */ 
        public frm_add_payment()
        {
            InitializeComponent();
        }

        /** 
          * @desc Constructor 
          * Create a payment for a specific member
          * @params [int] id_member identifies the member who is to pay uniquely
          * @return [none] No directly returned data. 
          */ 
         public frm_add_payment(int id_member)
        {
            InitializeComponent();
	    // Create a member object
            clMember = new Member(id_member);

        }

        /** 
          * @desc Loads in when the object instance first instantiated
          * @params [none] No input parameter. 
          * @return [none] No directly returned data. 
          */ 
        private void frm_add_payment_Load(object sender, EventArgs e)
        {
	    // Store todays date
            DateTime today = DateTime.Today;
	    // Convert date to display format
            txt_date.Text = String.Format("{0:dd-MM-yyyy}", today);

            // Loading Available Staff
//TODO: Inform Katie about the Position -> Instructor field
	    // Create mysl connection
            mySqlConn conn = new mySqlConn();
            conn.connect();
	    // Create query for returning all staff for selection of payment "received by"
            string query = "SELECT id_staff, CONCAT(lastName,', ', firstName) name FROM staff ORDER BY lastName";
	    // Load result into an arraylist
            ArrayList myItems = conn.alGetComboFromDB(query, "id_staff", "name");
	    // Set combobox to display value
            cmb_staff.DisplayMember = "Value";
            // Set myItems a combobox source
            cmb_staff.DataSource = myItems;
            // Set combobox index to be -1 so it can be checked if the user won't select anything here
// TODO: SET THIS TO BE A CONSTANT AS THE CURRENTLY LOGGED IN STAFF??
            cmb_staff.SelectedIndex = -1;

        }


        /** 
          * @desc Executes when the "Add Payment" button is clicked
	      * It checks user input and then calls for saving the new payment.
          * @params [none] No input parameter. 
          * @return [none] No directly returned data. 
          */
        private void button_addpayment_Click(object sender, EventArgs e)
        {

            // Check user inputs and formats
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


            string id_staff;
            if (cmb_staff.SelectedIndex < 0)
            {
                MessageBox.Show("Please select someone to receive the payment!");
                return;
            }
            else
            {
                    DictionaryEntry de = (DictionaryEntry)cmb_staff.SelectedItem;
                    id_staff = de.Key.ToString();
            }

            string paymentMethod;
            if (cmb_paymentMethod.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a payment method!");
                return;
            }
            else
            {
                paymentMethod = cmb_paymentMethod.SelectedText;
            }


            // Calling the method to save the new payment and checking if it was successfull
            if (this.clMember.AddPayment(amount, date, txt_details.Text, txt_receiptNumber.Text, paymentMethod, id_staff))
            {
                MessageBox.Show("The payment has been added succesfully!");
                this.Close();
            }
            else
                MessageBox.Show("There was a problem adding your payment, please check your data!");
        }





    }
}

