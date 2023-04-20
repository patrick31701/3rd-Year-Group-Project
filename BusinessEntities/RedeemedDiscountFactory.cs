using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class RedeemedDiscountFactory
    {
        private static IRedeemedDiscount discount = null;

        public static IRedeemedDiscount GetRedeemedDiscount(string discountCode, string customerID, DateTime redeemedDate)
        {
            if (discount != null)
            {
                return discount;
            }
            else
                return new RedeemedDiscount(discountCode, customerID, redeemedDate);
        }

        public static void SetRedeemedDiscount(IRedeemedDiscount aDiscount)
        {
            discount = aDiscount;
        }
    }
}
