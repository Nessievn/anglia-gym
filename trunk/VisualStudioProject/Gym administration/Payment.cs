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

        public Payment()
        {

        }

        public bool bSave()
        {
            if (this.ClMember.Id_member != -1)
            {
                string sQuery = "insert into `gym`.`payments` (`id_payment`, `id_member`, `date`, `amount`, `details`) values (NULL, '"+this.ClMember.Id_member+"', '"+this.Date+"', '"+this.Amount+"', '"+this.Details+"');";
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
