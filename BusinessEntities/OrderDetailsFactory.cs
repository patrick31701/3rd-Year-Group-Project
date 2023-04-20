using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public static class OrderDetailsFactory
    {
        private static IOrderDetails orderDetails = null;

        public static IOrderDetails GetOrderDetails (string detailID, string orderID, string productID, string productName, int productQuantity, double productPrice,
                int productStoreQuantity)
        {
            if(orderDetails != null)
            {
                return orderDetails;
            }
            else
            {
                return new OrderDetails(detailID, orderID, productID, productName, productQuantity, productPrice, productStoreQuantity);
            }
        }

        public static void SetOrderDetails(IOrderDetails anOrderDetails)
        {
            orderDetails = anOrderDetails;
        }
    }
}
