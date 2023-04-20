using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public interface IStock_Request_Details
    {
        int SDetailsID { get; set; }
        string SRID { get; set; }
        string ProductID { get; set; }
        string ProductName { get; set; }
        int Quantity { get; set; }
    }
}
