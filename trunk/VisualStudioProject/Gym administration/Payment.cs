using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gym_administration
{

    /**
     * @desc It temporarily holds payment details for saving a new payment 
     * Most closely associated form is frm_member.
     * Most closely associated table is MEMBERS.
     * @params [none] Incoming parameters are described at the individual constructors.
     * @return [none] No directly returned data. 
     * Returns of public methods are described at the individual methods.
     */
    class Payment
    {

        // A field with the same name from PAYMENTS table
        private Decimal amount;
        public Decimal Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        // A field with the same name from PAYMENTS table
        private string date;
        public string Date
        {
            get { return date; }
            set { date = value; }
        }

        // A field with the same name from PAYMENTS table
        private string details;
        public string Details
        {
            get { return details; }
            set { details = value; }
        }

        // A Member (Member.cs) object is stored here
        private Member clMember;
        internal Member ClMember
        {
            get { return clMember; }
            set { clMember = value; }
        }

        // A field with the same name from PAYMENTS table
        private string paymentMethod;
        public string PaymentMethod
        {
            get { return paymentMethod; }
            set { paymentMethod = value; }
        }

        // A field with the same name from PAYMENTS table
        private string receiptNumber;
        public string ReceiptNumber
        {
            get { return receiptNumber; }
            set { receiptNumber = value; }
        }

        // A field with the same name from PAYMENTS table
        private string receivedBy;
        public string ReceivedBy
        {
            get { return receivedBy; }
            set { receivedBy = value; }
        }

        /**
         * @desc Default constructor.
         * It creates a payment object for holding and saving payment data
         * @params [none] No input parameter.
         * @return [none] No directly returned data.
         */
        public Payment()
        {
            // Nothing here currently.
        }

        /**
         * @desc This method will save the object into the database
         * @return [bool] Returns true in case of success, false if there was a problem
         */
        public bool SavePayment()
        {
            // If this is an existing member's payment
            if (this.ClMember.Id_member != -1)
            {
                // Create insert query
                string query = "insert into `gym`.`payments` (`id_payment`, `id_member`, `date`, `amount`, `details`,`receiptnumber`,`paymentmethod`,`receivedby`) values (NULL, '" + this.ClMember.Id_member + "', '" + this.Date + "', '" + this.Amount + "', '" + this.Details + "', '" + this.ReceiptNumber + "', '" + this.PaymentMethod + "', '" + this.ReceivedBy + "');";
                // Create mysql connection
                mySqlConn conn = new mySqlConn();
                conn.connect();
                // Launch insert query
                int payment = conn.iInsert(query);
                // Check if the insert was succesful
                if (payment != -1)
                    return true;
            }
            return false;
        }



        //Modifying payments? Currently NO!
        //this.PaymentMethod = lhResultset[0]["payment_method"].ToString();
        //payment_method = '"+this.PaymentMethod+"'
    }
}
