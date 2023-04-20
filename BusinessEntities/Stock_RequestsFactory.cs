using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public static class Stock_RequestsFactory
    {
        private static IStock_Requests stock_requests = null;

        public static IStock_Requests GetStock_Requests(string srID, int quantity, string description, int complete, string staffID)
        {
            if(stock_requests != null)
            {
                return stock_requests;
            }
            else
            {
                return new Stock_Requests(srID, quantity, description, complete, staffID);
            }
        }

        public static void SetStock_Requests(IStock_Requests aStock_Request)
        {
            stock_requests = aStock_Request;
        }
    }
}
