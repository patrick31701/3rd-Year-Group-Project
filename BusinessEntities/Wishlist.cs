using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class Wishlist : BusinessEntities.IWishlist
    {
        public Wishlist() { }
        public Wishlist(string customerID, string productID, string productName, double price, string productType)
        {
            this.customerID = customerID;
            this.productID = productID;
            this.productName = productName;
            this.price = price;
            this.productType = productType;
        }

        public string customerID { get; set; }
        public string productID { get; set; }
        public string productName { get; set; }
        public double price { get; set; }
        public string productType { get; set; }
    }
}
