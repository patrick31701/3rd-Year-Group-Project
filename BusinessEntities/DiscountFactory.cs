using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public static class DiscountFactory
    {
        private static IDiscount discount = null;

        public static IDiscount GetDiscount(string discountID, string discountCode, int discountPercentage, DateTime startDate, DateTime endDate, string productType)
        {
            if (discount != null)
            {
                return discount;
            }
            else
                return new Discount(discountID, discountCode, discountPercentage, startDate, endDate, productType);
        }

        public static void SetDiscount(IDiscount aDiscount)
        {
            discount = aDiscount;
        }
    }
}
