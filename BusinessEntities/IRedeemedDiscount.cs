using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public interface IRedeemedDiscount
    {
        string discountCode { get; set; }
        string customerID { get; set; }
        DateTime redeemedDate { get; set; }

    }
}
