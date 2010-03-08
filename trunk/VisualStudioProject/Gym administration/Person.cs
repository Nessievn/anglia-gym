using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gym_administration
{
    // It's an abstract class because it is not instantiable
    public abstract class Person
    {
        private string sFirstName;

        public string SFirstName
        {
            get { return sFirstName; }
            set { sFirstName = value; }
        }
        private string sLastName;

        public string SLastName
        {
            get { return sLastName; }
            set { sLastName = value; }
        }
        private string sBirthdate;

        public string SBirthdate
        {
            get { return sBirthdate; }
            set { sBirthdate = value; }
        }
        private string sAddress_1;

        public string SAddress_1
        {
            get { return sAddress_1; }
            set { sAddress_1 = value; }
        }
        private string sAaddress_2;

        public string SAaddress_2
        {
            get { return sAaddress_2; }
            set { sAaddress_2 = value; }
        }
        private string sCity;

        public string SCity
        {
            get { return sCity; }
            set { sCity = value; }
        }
        private string sCounty;

        public string SCounty
        {
            get { return sCounty; }
            set { sCounty = value; }
        }
        private string sPostalcode;

        public string SPostalcode
        {
            get { return sPostalcode; }
            set { sPostalcode = value; }
        }

        private string sEmail;

        public string SEmail
        {
            get { return sEmail; }
            set { sEmail = value; }
        }


        private string sPhone;

        public string SPhone
        {
            get { return sPhone; }
            set { sPhone = value; }
        }

        private string sMobile;

        public string SMobile
        {
            get { return sMobile; }
            set { sMobile = value; }
        }

    }
}
