using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public interface ICardDetails
    {
        string cardNumber { get; set; }
        string customerID { get; set; }
        string cardName { get; set; }
        string cardType { get; set; }
        int expiryMonth { get; set; }
        int expiryYear { get; set; }
    }
}
