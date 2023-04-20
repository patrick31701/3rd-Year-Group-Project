using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public static class Stock_Request_DetailsFactory
    {
        private static IStock_Request_Details stock_Request_details = null;

        public static IStock_Request_Details GetStock_Request_Details(int sdetailsID, string srID, string productID, string productName, int quantity)
        {
            if (stock_Request_details != null)
            {
                return stock_Request_details;
            }
            else
            {
                return new Stock_Request_Details(sdetailsID, srID, productID, productName, quantity);
            }
        }

        public static void SetStock_Request_Details(IStock_Request_Details astock_Request_details)
        {
            stock_Request_details = astock_Request_details;
        }
    }
}
