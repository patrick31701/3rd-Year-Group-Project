using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class Queries : IQueries
    {
        #region Instance Properties
        private string queryID;
        private string customerID;
        private string topic;
        private string description;
        private int complete;
        #endregion
        #region Instance Properties
        public string QueryID
        {
            get
            {
                return queryID;
            }
            set
            {
                queryID = value;
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
        public string Topic
        {
            get
            {
                return topic;
            }
            set
            {
                topic = value;
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
        #endregion
        #region Constructors
        public Queries()
        {
            throw new System.NotImplementedException();
        }
        public Queries(string queryID, string customerID, string topic, string description, int complete)
        {
            this.queryID = queryID;
            this.customerID = customerID;
            this.topic = topic;
            this.description = description;
            this.complete = complete;
        }
        #endregion
    }
}
