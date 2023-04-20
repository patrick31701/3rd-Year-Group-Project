using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public interface IDiscount
    {
        string DiscountID { get; set; }
        string DiscountCode { get; set; }
        int DiscountPercentage { get; set; }
        DateTime startDate { get; set; }
        DateTime endDate { get; set; }
        string productType { get; set; }
    }
}
