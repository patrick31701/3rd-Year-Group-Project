using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public static class ProductFactory
    {
        private static IProduct product = null;

        public static IProduct GetProduct(string productID, string productName, int quantity, double price, int discount, string description, string productType)
        {
            if (product != null)
            {
                return product;
            }
            else
                return new Product(productID, productName, quantity, price, discount, description, productType);
        }

        public static void SetProduct(IProduct aProduct)
        {
            product = aProduct;
        }
    }
}
