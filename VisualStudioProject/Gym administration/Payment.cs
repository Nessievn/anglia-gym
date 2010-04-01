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
        private Decimal dAmount;

        public Decimal DAmount
        {
            get { return dAmount; }
            set { dAmount = value; }
        }
        private string sDate;

        public string SDate
        {
            get { return sDate; }
            set { sDate = value; }
        }
        private string sDetails;

        public string SDetails
        {
            get { return sDetails; }
            set { sDetails = value; }
        }
        private Member mMember;

        internal Member MMember
        {
            get { return mMember; }
            set { mMember = value; }
        }

        public Payment()
        {

        }

        public bool bSave()
        {
            if (this.MMember.IId_member != -1)
            {
                string sQuery = "insert into `gym`.`payments` (`id_payment`, `id_member`, `date`, `amount`, `details`) values (NULL, '"+this.MMember.IId_member+"', '"+this.SDate+"', '"+this.DAmount+"', '"+this.SDetails+"');";
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
