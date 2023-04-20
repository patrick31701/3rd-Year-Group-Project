using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public static class OrderFactory
    {
        private static IOrder order = null;

        public static IOrder GetOrder(string orderID, string customerID, int complete, int quantity, DateTime dateOrdered)
        {
            if (order != null)
            {
                return order;
            }
            else
                return new Order(orderID, customerID, complete, quantity, dateOrdered);
        }

        public static void SetOrder(IOrder anOrder)
        {
            order = anOrder;
        }
    }
}
