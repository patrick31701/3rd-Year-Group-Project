using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class Loyalty_Card : BusinessEntities.ILoyalty_Card
    {
        #region Instance Properties
        private string loyalty_cardID;
        private int card_points;
        private string customerID;

        #endregion
        #region Instance Properties
        public string Loyalty_cardID
        {
            get
            {
                return loyalty_cardID;
            }
            set
            {
                loyalty_cardID = value;
            }
        }
        public int Card_points
        {
            get
            {
                return card_points;
            }
            set
            {
                card_points = value;
            }
        }
        public string CustomerID
        {
            get
            {
                return customerID;
            }
            set
            {
                customerID = value;
            }
        }
        #endregion
        #region Constructors
        public Loyalty_Card(string loyalty_cardID, int card_points, string customerID)
        {
            this.loyalty_cardID = loyalty_cardID;
            this.card_points = card_points;
            this.customerID = customerID;
        }
        #endregion

    }
}
