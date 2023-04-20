using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class Discount : BusinessEntities.IDiscount
    {

        #region Instance Properties
        public string DiscountID { get; set; }
        public string DiscountCode { get; set; }
        public int DiscountPercentage { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public string productType { get; set; }
        #endregion

        #region Constructors
        public Discount() { }
        public Discount(string discountID, string discountCode, int discountPercentage, DateTime startDate, DateTime endDate, string productType)
        {
            DiscountID = discountID;
            DiscountCode = discountCode;
            DiscountPercentage = discountPercentage;
            this.startDate = startDate;
            this.endDate = endDate;
            this.productType = productType;
        }
        #endregion
    }
}
