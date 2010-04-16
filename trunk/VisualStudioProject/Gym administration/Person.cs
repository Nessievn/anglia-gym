using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gym_administration
{
    /**
     * @desc It's an abstract class because it is not instantiable
     * @params [none]
     * @return [none]
     */
    public abstract class Person
    {

        // Everything here corresponds with fields from STAFF and MEMBER tables

        private string firstName;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        private string lastName;

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        private string birthdate;

        public string Birthdate
        {
            get { return birthdate; }
            set { birthdate = value; }
        }
        private string address_1;

        public string Address_1
        {
            get { return address_1; }
            set { address_1 = value; }
        }
        private string address_2;

        public string Address_2
        {
            get { return address_2; }
            set { address_2 = value; }
        }
        private string city;

        public string City
        {
            get { return city; }
            set { city = value; }
        }
        private string county;

        public string County
        {
            get { return county; }
            set { county = value; }
        }
        private string postalCode;

        public string PostalCode
        {
            get { return postalCode; }
            set { postalCode = value; }
        }

        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }


        private string phone;

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        private string mobile;

        public string Mobile
        {
            get { return mobile; }
            set { mobile = value; }
        }

    }
}
