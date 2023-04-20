using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    class CardDetails : BusinessEntities.ICardDetails
    {
        #region Instance Properties
        public string cardNumber { get; set; }
        public string customerID { get; set; }
        public string cardName { get; set; }
        public string cardType { get; set; }
        public int expiryMonth { get; set; }
        public int expiryYear { get; set; }


        #endregion

        #region Constructors
        public CardDetails() { }

        public CardDetails(string cardNumber, string customerID, string cardName, string cardType, int expiryMonth, int expiryYear)
        {
            this.cardNumber = cardNumber;
            this.customerID = customerID;
            this.cardName = cardName;
            this.cardType = cardType;
            this.expiryMonth = expiryMonth;
            this.expiryYear = expiryYear;
        }
        #endregion
    }
}
