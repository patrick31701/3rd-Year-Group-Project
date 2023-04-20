using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public interface IProduct
    {
        string ProductID { get; set; }
        string ProductName { get; set; }
        int Quantity { get; set; }
        double Price { get; set; }
        int Discount { get; set; }
        string Description { get; set; }
        string ProductType { get; set; }
    }
}
