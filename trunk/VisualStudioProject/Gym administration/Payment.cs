//It temporarily holds payment details for saving a new payment
//Constructor (default)
//Method 1
//bSave     saving a new payment


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gym_administration
{
    class Payment
    {

        
        private Decimal amount;
        public Decimal Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        
        private string date;
        public string Date
        {
            get { return date; }
            set { date = value; }
        }

        
        private string details;
        public string Details
        {
            get { return details; }
            set { details = value; }
        }


        private Member clMember;
        internal Member ClMember
        {
            get { return clMember; }
            set { clMember = value; }
        }

        // Field payment method from table
        private string paymentMethod;
        public string PaymentMethod
        {
            get { return paymentMethod; }
            set { paymentMethod = value; }
        }


        private string receiptNumber;
        public string ReceiptNumber
        {
            get { return receiptNumber; }
            set { receiptNumber = value; }
        }


        private string receivedBy;
        public string ReceivedBy
        {
            get { return receivedBy; }
            set { receivedBy = value; }
        }




        public Payment()
        {

        }

                        //this.PaymentMethod = lhResultset[0]["payment_method"].ToString();
        //, payment_method = '"+this.PaymentMethod+"'
        public bool bSave()
        {
            if (this.ClMember.Id_member != -1)
            {
                string sQuery = "insert into `gym`.`payments` (`id_payment`, `id_member`, `date`, `amount`, `details`,`receiptnumber`,`paymentmethod`,`receivedby`) values (NULL, '" + this.ClMember.Id_member + "', '" + this.Date + "', '" + this.Amount + "', '" + this.Details + "', '" + this.ReceiptNumber + "', '" + this.PaymentMethod + "', '" + this.ReceivedBy + "');";
                mySqlConn conn = new mySqlConn();
                conn.connect();
                int iPayment = conn.iInsert(sQuery);
                if (iPayment != -1)
                    return true;
            }
            return false;
        }
    }
}
