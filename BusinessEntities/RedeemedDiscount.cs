using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class RedeemedDiscount : BusinessEntities.IRedeemedDiscount
    {
        public string discountCode { get; set; }
        public string customerID { get; set; }
        public DateTime redeemedDate { get; set; }

        public RedeemedDiscount(string discountCode, string customerID, DateTime redeemedDate)
        {
            this.discountCode = discountCode;
            this.customerID = customerID;

        }

        public RedeemedDiscount()
        {
        }
    }
}
