using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class OrderDetails : IOrderDetails
    {
        #region Instance Properties
        private string detailID;
        private string orderID;
        private string productID;
        private string productName;
        private int productQuantity;
        private double productPrice;
        private int productStoreQuantity;
        #endregion
        #region Instance Properties
        public string DetailID
        {
            get
            {
                return detailID;
            }
            set
            {
                detailID = value;
            }
        }
        public string OrderID
        {
            get
            {
                return orderID;
            }
            set
            {
                orderID = value;
            }
        }
        public string ProductID
        {
            get
            {
                return productID;
            }
            set
            {
                productID = value;
            }
        }
        public string ProductName
        {
            get
            {
                return productName;
            }
            set
            {
                productName = value;
            }
        }
        public int ProductQuantity
        {
            get
            {
                return productQuantity;
            }
            set
            {
                productQuantity = value;
            }
        }
        public double ProductPrice
        {
            get
            {
                return productPrice;
            }
            set
            {
                productPrice = value;
            }
        }
        public int ProductStoreQuantity
        {
            get
            {
                return productStoreQuantity;
            }
            set
            {
                productStoreQuantity = value;
            }
        }
        #endregion
        #region Constructors
        public OrderDetails()
        {
            throw new System.NotImplementedException();
        }
        public OrderDetails(string detailID, string orderID, string productID, string productName, int productQuantity, double productPrice,
                int productStoreQuantity)
        {
            this.detailID = detailID;
            this.orderID = orderID;
            this.productID = productID;
            this.productName = productName;
            this.productQuantity = productQuantity;
            this.productPrice = productPrice;
            this.productStoreQuantity = productStoreQuantity;
        }
        #endregion
    }
}
