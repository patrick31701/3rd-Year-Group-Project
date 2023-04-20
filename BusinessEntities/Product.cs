using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class Product : BusinessEntities.IProduct
    {
        #region Instance Properties
        private string productID;
        private string productName;
        private int quantity;
        private double price;
        private int discount;
        private string description;
        private string productType;
        #endregion
        #region Instance Properties
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
        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }
        public int Discount
        {
            get
            {
                return discount;
            }
            set
            {
                discount = value;
            }
        }
        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
            }
        }
        public string ProductType
        {
            get
            {
                return productType;
            }
            set
            {
                productType = value;
            }
        }
        #endregion
        #region Constructors
        public Product()
        {
            throw new System.NotImplementedException();
        }
        public Product(string productID, string productName, int quantity, double price, int discount, string description, string productType)
        {
            this.productID = productID;
            this.productName = productName;
            this.quantity = quantity;
            this.price = price;
            this.discount = discount;
            this.description = description;
            this.productType = productType;
        }
        #endregion
    }
}
