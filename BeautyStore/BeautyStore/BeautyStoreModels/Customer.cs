using System;
using System.Collections.Generic;
using System.Text;

namespace BeautyStore.BeautyStoreModels
{
    /// <summary>
    /// This class contains necessary properties and field for customer information.
    /// </summary>
    class Customer
    {
        private string customerName;
        private string password;
        private int phoneNumber;
        private string emailAddress;
        private string homeAddress;
        private string billingAddress;

        public string CustomerName
        {
            get { return customerName; }
            set
            {
                //if (value.Equals(null)) {} //TODO: throw exception
                customerName = value;
            }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public string Email
        {
            get { return emailAddress; }
            set { emailAddress = value; }
        }
        public int PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }
        public string HomeAddress
        {
            get { return homeAddress; }
            set { homeAddress = value; }
        }
        public string BillingAddress
        {
            get { return billingAddress; }
            set { billingAddress = value; }
        }
    }
}
