using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class WishlistFactory
    {
        private static IWishlist wishlist = null;
        public static IWishlist GetWishlist(string customerID, string productID, string productName, double price, string productType)
        {
            if (wishlist != null)
            {
                return wishlist;
            }
            else
                return new Wishlist(customerID, productID, productName, price, productType);
        }

        public static void SetWishlist(IWishlist awishlist)
        {
            wishlist = awishlist;
        }
    }
}
