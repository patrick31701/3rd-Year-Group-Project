using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public interface IWishlist
    {
        string customerID { get; set; }
        string productID { get; set; }
        string productName { get; set; }
        double price { get; set; }
        string productType { get; set; }
    }
}
