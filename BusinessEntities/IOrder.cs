using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public interface IOrder
    {
        string OrderID { get; set; }
        string CustomerID { get; set; }
        int Complete { get; set; }
        int Quantity { get; set; }
        DateTime DateOrdered { get; set; }
    }
}
