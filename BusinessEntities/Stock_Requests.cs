using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class Stock_Requests : IStock_Requests
    {
        #region Instance Properties
        private string srID;
        private int quantity;
        private string description;
        private int complete;
        private string staffID;
        #endregion
        #region Instance Properties
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
        public string StaffID
        {
            get
            {
                return staffID;
            }
            set
            {
                staffID = value;
            }
        }
        #endregion
        #region Constructors
        public Stock_Requests()
        {
            throw new System.NotImplementedException();
        }
        public Stock_Requests(string srID, int quantity, string description, int complete, string staffID)
        {
            this.srID = srID;
            this.quantity = quantity;
            this.description = description;
            this.complete = complete;
            this.staffID = staffID;
        }
        #endregion
    }
}
