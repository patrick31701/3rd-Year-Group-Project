using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class Cart : BusinessEntities.ICart
    {
        public Cart(int id, string productID, string productName, double productPrice, int quantity, string customerID, string productType)
        {

            this.productID = productID;
            this.productName = productName;
            this.productPrice = productPrice;
            this.quantity = quantity;
            this.customerID = customerID;
            this.productType = productType;
        }
        public Cart() { }

        public int id { get; set; }
        public string productID { get; set; }
        public string productName { get; set; }
        public double productPrice { get; set; }
        public int quantity { get; set; }
        public string customerID { get; set; }
        public string productType { get; set; }
    }
}
