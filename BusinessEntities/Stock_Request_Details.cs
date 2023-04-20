using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class Stock_Request_Details : IStock_Request_Details
    {
        #region Instance Properties
        private int sdetailsID;
        private string srID;
        private string productID;
        private string productName;
        private int quantity;
        #endregion
        #region Instance Properties
        public int SDetailsID
        {
            get
            {
                return sdetailsID;
            }
            set
            {
                sdetailsID = value;
            }
        }
        public string SRID
        {
            get
            {
                return srID;
            }
            set
            {
                srID = value;
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
        #endregion
        #region Constructors
        public Stock_Request_Details()
        {
            throw new System.NotImplementedException();
        }
        public Stock_Request_Details(int sdetailsID, string srID, string productID, string productName, int quantity)
        {
            this.sdetailsID = sdetailsID;
            this.srID = srID;
            this.productID = productID;
            this.productName = productName;
            this.quantity = quantity;
        }
        #endregion
    }
}
