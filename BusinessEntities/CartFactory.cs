using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class CartFactory
    {
        private static ICart cart= null;

        public static ICart GetCart( int id, string productID, string productName, double productPrice, int quantity, string customerID, string productType)
        {
            if (cart != null)
            {
                return cart;
            }
            else
                return new Cart(id, productID, productName, productPrice, quantity, customerID, productType);
        }

        public static void SetCart(ICart a)
        {
            cart = a;
        }
    }
}
