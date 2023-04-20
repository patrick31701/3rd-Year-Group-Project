using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public interface IQueries
    {
        string QueryID { get; set; }
        string CustomerID { get; set; }
        string Topic { get; set; }
        string Description { get; set; }
        int Complete { get; set; }
    }
}
