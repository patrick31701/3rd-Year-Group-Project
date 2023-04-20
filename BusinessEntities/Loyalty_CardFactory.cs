using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    static class Loyalty_CardFactory
    {
        private static ILoyalty_Card loyaltyCard = null;
        public static ILoyalty_Card GetLoyalty_Card(string loyalty_card, int card_points,  string customer_ID)
        {
            if (loyaltyCard != null)
            {
                return loyaltyCard;
            }
            else
                return new Loyalty_Card(loyalty_card, card_points, customer_ID);
        }

        public static void setLoyalty_Card(ILoyalty_Card aloyalty_Card)
        {
            loyaltyCard = aloyalty_Card;
        }
    }
}
