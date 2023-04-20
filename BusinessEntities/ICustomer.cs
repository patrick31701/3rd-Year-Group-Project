using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public interface ICustomer
    {
        string CustomerID { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string Email { get; set; }
        string CurPassword { get; set; }
        string Address { get; set; }
        string City { get; set; }
        string County { get; set; }
        string Eircode { get; set; }
        string Mobile { get; set; }
        int LoyaltyCard { get; set; }
    }
}
