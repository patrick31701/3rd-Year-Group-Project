using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public static class QueriesFactory
    {
        private static IQueries query = null;

        public static IQueries GetQueries(string queryID, string customerID, string topic, string description, int complete)
        {
            if (query != null)
            {
                return query;
            }
            else
                return new Queries(queryID, customerID, topic, description, complete);
        }

        public static void SetQueries(IQueries aQuery)
        {
            query = aQuery;
        }
    }
}
