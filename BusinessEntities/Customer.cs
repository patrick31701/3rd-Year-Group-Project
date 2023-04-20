using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class Customer : BusinessEntities.ICustomer
    {
        #region Instance Properties
        private string customerID;
        private string firstName;
        private string lastName;
        private string email;
        private string curPassword;
        private string address;
        private string city;
        private string county;
        private string eircode;
        private string mobile;
        private int loyaltyCard;
        #endregion
        #region Instance Properties
        public string CustomerID
        {
            get
            {
                return customerID;
            }
            set
            {
                customerID = value;
            }
        }
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }
        public string CurPassword
        {
            get
            {
                return curPassword;
            }
            set
            {
                curPassword = value;
            }
        }
        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }
        public string City
        {
            get
            {
                return city;
            }
            set
            {
                city = value;
            }
        }
        public string County
        {
            get
            {
                return county;
            }
            set
            {
                county = value;
            }
        }
        public string Eircode
        {
            get
            {
                return eircode;
            }
            set
            {
                eircode = value;
            }
        }
        public string Mobile
        {
            get
            {
                return mobile;
            }
            set
            {
                mobile = value;
            }
        }
        public int LoyaltyCard
        {
            get
            {
                return loyaltyCard;
            }
            set
            {
                loyaltyCard = value;
            }
        }
        #endregion
        #region Constructors
        public Customer()
        {
            throw new System.NotImplementedException();
        }
        public Customer(string customerID, string firstName, string lastName, string email, string curPassword, string address, string city,
            string county, string eircode, string mobile, int loyalty_card)
        {
            this.customerID = customerID;
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.curPassword = curPassword;
            this.address = address;
            this.city = city;
            this.county = county;
            this.eircode = eircode;
            this.mobile = mobile;
            this.loyaltyCard = loyalty_card;
        }
        #endregion
    }
}
