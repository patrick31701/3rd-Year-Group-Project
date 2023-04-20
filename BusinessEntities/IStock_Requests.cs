using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public interface IStock_Requests
    {
        string SRID { get; set; }
        int Quantity { get; set; }
        string Description { get; set; }
        int Complete { get; set; }
        string StaffID { get; set; }
    }
}
