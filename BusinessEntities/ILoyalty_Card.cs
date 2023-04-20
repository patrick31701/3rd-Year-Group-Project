using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    interface ILoyalty_Card
    {
         string Loyalty_cardID { get; set; }
         int Card_points { get; set; }
         string CustomerID { get; set;}
    }
}
