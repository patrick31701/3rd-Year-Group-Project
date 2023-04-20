using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class Order : BusinessEntities.IOrder
    {
        #region Instance Properties
        private string orderID;
        private string customerID;
        private int complete;
        private int quantity;
        private DateTime dateOrdered;
        #endregion
        #region Instance Properties
        public string OrderID { 
            get
            {
                return orderID;
            }
            set
            {
                orderID = value;
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
        public int Complete
        {
            get
            {
                return complete;
            }
            set
            {
                complete = value;
            }
        }
        public int Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                quantity = value;
            }
        }
        public DateTime DateOrdered
        {
            get
            {
                return dateOrdered;
            }
            set
            {
                dateOrdered = value;
            }
        }
        #endregion
        #region Constructors
        public Order()
        {
            throw new System.NotImplementedException();
        }
        public Order(string orderID, string customerID, int complete, int quantity, DateTime dateOrdered)
        {
            this.orderID = orderID;
            this.customerID = customerID;
            this.complete = complete;
            this.quantity = quantity;
            this.dateOrdered = dateOrdered;
        }
        #endregion
    }
}
