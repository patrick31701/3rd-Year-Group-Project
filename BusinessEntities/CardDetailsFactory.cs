using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class CardDetailsFactory
    {
        private static ICardDetails cardDetails = null;

        public static ICardDetails GetCardDetails(string cardNumber, string customerID, string cardName, string cardType, int expiryMonth, int expiryYear)
        {
            if (cardDetails != null)
            {
                return cardDetails;
            }
            else
                return new CardDetails(cardNumber, customerID, cardName, cardType, expiryMonth, expiryYear);
        }

        public static void SetCardDetails(ICardDetails aCard)
        {
            cardDetails = aCard;
        }
    }
}
