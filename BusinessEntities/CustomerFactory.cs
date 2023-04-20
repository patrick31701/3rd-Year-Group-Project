using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public static class CustomerFactory
    {
        private static ICustomer customer = null;

        public static ICustomer GetCustomer(string customerID, string firstName, string lastName, string email, string curPassword, string address, string city, string county, string eircode, string mobile, int loyaltyCard)
        {
            if (customer != null)
            {
                return customer;
            }
            else
                return new Customer(customerID, firstName, lastName, email, curPassword, address, city, county, eircode, mobile, loyaltyCard);
        }

        public static void SetCustomer(ICustomer aCustomer)
        {
            customer = aCustomer;
        }
    }
}
