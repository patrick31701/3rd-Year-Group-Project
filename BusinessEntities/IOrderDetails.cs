using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public interface IOrderDetails
    {
        string DetailID { get; set; }
        string OrderID { get; set; }
        string ProductID { get; set; }
        string ProductName { get; set; }
        int ProductQuantity { get; set; }
        double ProductPrice { get; set; }
        int ProductStoreQuantity { get; set; }
    }
}
