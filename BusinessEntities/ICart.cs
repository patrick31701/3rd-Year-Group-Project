using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public interface ICart
    {
        int id { get; set; }
        string productID { get; set; }
        string productName { get; set; }
        double productPrice { get; set; }
        int quantity { get; set; }
        string customerID { get; set; }
        string productType { get; set; }

    }
}
