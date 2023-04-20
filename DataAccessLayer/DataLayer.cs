using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

using BusinessEntities;
using System.Windows.Forms;

namespace DataAccessLayer
{
    public class DataLayer : IDataLayer
    {
        #region Instance Attributes
        private SqlConnection connection;
        DataSet ds;
        SqlDataAdapter da;
        int totStaff;
        int totCustomer;
        int totProduct;
        int totOrders;
        int totStock_Requests;
        int totQueries;
        int totStock_Request_Details;
        int totRedeemedDiscount;
        int totDiscount;
        int totManager;
        int totOrderProd;
        int totCardDetails;
        int totCart;
        int totWishlist;
        SqlCommandBuilder cb;
        #endregion
        #region Static Attributes
        private static IDataLayer dataLayerSingletonInstance;
        static readonly object padlock = new object();
        #endregion
        #region Constructors
        public static IDataLayer GetInstance()
        {
            lock (padlock)
            {
                if (dataLayerSingletonInstance == null)
                {
                    dataLayerSingletonInstance = new DataLayer();
                }
                return dataLayerSingletonInstance;
            }
        }
        private DataLayer()
        {
            OpenConnection();
        }
        #endregion

        public void OpenConnection()
        {
            connection = new SqlConnection();
            //connection.ConnectionString = "Data Source=team4-foodstore.database.windows.net;Initial Catalog=Healthy;Persist Security Info=True;User ID=Team4_FoodStore;Password=HealthyStore_4";
            connection.ConnectionString = "Data Source = SQL5.student.litdom.lit.ie\\Team4 ; Initial Catalog = healthyfoodstoredb; User id=K00251917; Password=Misza2018";
            try
            {
                connection.Open();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                Environment.Exit(0);
            }
        }

        public void CloseConnection()
        {
            connection.Close();
        }

        public SqlConnection GetConnection()
        {
            return connection;
        }

        public List<IStaff> getAllStaff()
        {
            List<IStaff> staffList = new List<IStaff>();
            try
            {
                ds = new DataSet();
                string sql = "SELECT * FROM healthyfoodstoredb.Staff";
                da = new SqlDataAdapter(sql, connection);
                cb = new SqlCommandBuilder(da);
                da.Fill(ds, "StaffData");
                totStaff = ds.Tables["StaffData"].Rows.Count;
                for (int i = 0; i < totStaff; i++)
                {
                    DataRow dRow = ds.Tables["StaffData"].Rows[i];
                    IStaff staff = StaffFactory.GetStaff(dRow.ItemArray.GetValue(0).ToString(),
                        dRow.ItemArray.GetValue(1).ToString(), dRow.ItemArray.GetValue(2).ToString(),
                        dRow.ItemArray.GetValue(3).ToString(), dRow.ItemArray.GetValue(4).ToString(),
                        dRow.ItemArray.GetValue(5).ToString(), dRow.ItemArray.GetValue(6).ToString());
                    staffList.Add(staff);
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (connection.State.ToString() == "Open")
                    connection.Close();
                Application.Exit();
            }
            return staffList;
        }

        /* public List<IOrderDetails> getOrderDetails(string orderID)
         {
             List<IOrderDetails> detailsList = new List<IOrderDetails>();
             try
             {
                 ds = new DataSet();
                 string sql = $"SELECT * FROM healthyfoodstoredb.orderdetails WHERE orderID = '{orderID}'";
                 da = new SqlDataAdapter(sql, connection);
                 cb = new SqlCommandBuilder(da);
                 da.Fill(ds, "DetailsData");
                 totOrders = ds.Tables["DetailsData"].Rows.Count;
                 for (int i = 0; i < totOrders; i++)
                 {
                     DataRow dRow = ds.Tables["DetailsData"].Rows[i];
                     IOrderDetails details = OrderDetailsFactory.GetOrderDetails(dRow.ItemArray.GetValue(0).ToString(), dRow.ItemArray.GetValue(1).ToString(),
                             dRow.ItemArray.GetValue(2).ToString(), dRow.ItemArray.GetValue(3).ToString(),
                             Convert.ToInt32(dRow.ItemArray.GetValue(4)), Convert.ToDouble(dRow.ItemArray.GetValue(5)),
                             Convert.ToInt32(dRow.ItemArray.GetValue(6)));
                     detailsList.Add(details);
                 }
             }
             catch (System.Exception ex)
             {
                 MessageBox.Show(ex.Message);
                 if (connection.State.ToString() == "Open")
                     connection.Close();
                 Application.Exit();
             }
             return detailsList;
         }*/

        public List<ICustomer> getAllCustomer()
        {
            List<ICustomer> customerList = new List<ICustomer>();
            try
            {
                ds = new DataSet();
                string sql = "SELECT * FROM healthyfoodstoredb.Customer";
                da = new SqlDataAdapter(sql, connection);
                cb = new SqlCommandBuilder(da);
                da.Fill(ds, "CustomerData");
                totCustomer = ds.Tables["CustomerData"].Rows.Count;
                for (int i = 0; i < totCustomer; i++)
                {
                    DataRow dRow = ds.Tables["CustomerData"].Rows[i];
                    ICustomer customer = CustomerFactory.GetCustomer(dRow.ItemArray.GetValue(0).ToString(), dRow.ItemArray.GetValue(1).ToString(),
                        dRow.ItemArray.GetValue(2).ToString(), dRow.ItemArray.GetValue(3).ToString(),
                        dRow.ItemArray.GetValue(4).ToString(), dRow.ItemArray.GetValue(5).ToString(),
                        dRow.ItemArray.GetValue(6).ToString(), dRow.ItemArray.GetValue(7).ToString(),
                        dRow.ItemArray.GetValue(8).ToString(), dRow.ItemArray.GetValue(9).ToString(),
                        Convert.ToInt32(dRow.ItemArray.GetValue(10).ToString()));
                    customerList.Add(customer);
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (connection.State.ToString() == "Open")
                    connection.Close();
                Application.Exit();
            }
            return customerList;
        }

        public List<IProduct> getAllProduct()
        {
            List<IProduct> productList = new List<IProduct>();
            try
            {
                ds = new DataSet();
                string sql = "SELECT * FROM healthyfoodstoredb.Products";
                da = new SqlDataAdapter(sql, connection);
                cb = new SqlCommandBuilder(da);
                da.Fill(ds, "ProductData");
                totProduct = ds.Tables["ProductData"].Rows.Count;
                for (int i = 0; i < totProduct; i++)
                {
                    DataRow dRow = ds.Tables["ProductData"].Rows[i];
                    IProduct product = ProductFactory.GetProduct(dRow.ItemArray.GetValue(0).ToString(),
                        dRow.ItemArray.GetValue(1).ToString(), Convert.ToInt32(dRow.ItemArray.GetValue(2)),
                        Convert.ToDouble(dRow.ItemArray.GetValue(3)), Convert.ToInt32(dRow.ItemArray.GetValue(4)),
                        dRow.ItemArray.GetValue(5).ToString(), dRow.ItemArray.GetValue(6).ToString());
                    productList.Add(product);
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (connection.State.ToString() == "Open")
                    connection.Close();
                Application.Exit();
            }
            return productList;
        }

        public List<IOrder> getAllOrders()
        {
            List<IOrder> orderList = new List<IOrder>();
            try
            {
                ds = new DataSet();
                string sql = "SELECT * FROM healthyfoodstoredb.orders";
                da = new SqlDataAdapter(sql, connection);
                cb = new SqlCommandBuilder(da);
                da.Fill(ds, "OrderData");
                totOrders = ds.Tables["OrderData"].Rows.Count;
                for (int i = 0; i < totOrders; i++)
                {
                    DataRow dRow = ds.Tables["OrderData"].Rows[i];
                    IOrder order = OrderFactory.GetOrder(dRow.ItemArray.GetValue(0).ToString(), dRow.ItemArray.GetValue(1).ToString(),
                        Convert.ToInt16(dRow.ItemArray.GetValue(2)), Convert.ToInt32(dRow.ItemArray.GetValue(3)),
                        Convert.ToDateTime(dRow.ItemArray.GetValue(4).ToString()));
                    orderList.Add(order);
                }

            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (connection.State.ToString() == "Open")
                    connection.Close();
                Application.Exit();
            }
            return orderList;
        }

        public List<IStock_Requests> getAllRequests()
        {
            List<IStock_Requests> StockRequestList = new List<IStock_Requests>();
            try
            {
                ds = new DataSet();
                string sql = "SELECT * FROM healthyfoodstoredb.Stock_Requests";
                da = new SqlDataAdapter(sql, connection);
                cb = new SqlCommandBuilder(da);
                da.Fill(ds, "Stock_Requests");
                totStock_Requests = ds.Tables["Stock_Requests"].Rows.Count;
                for (int i = 0; i < totStock_Requests; i++)
                {
                    DataRow dRow = ds.Tables["Stock_Requests"].Rows[i];
                    IStock_Requests request = Stock_RequestsFactory.GetStock_Requests(dRow.ItemArray.GetValue(0).ToString(), Convert.ToInt32(dRow.ItemArray.GetValue(1)),
                        dRow.ItemArray.GetValue(2).ToString(), Convert.ToInt32(dRow.ItemArray.GetValue(3)),
                        dRow.ItemArray.GetValue(4).ToString());
                    StockRequestList.Add(request);
                }

            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (connection.State.ToString() == "Open")
                    connection.Close();
                Application.Exit();
            }
            return StockRequestList;
        }
        public List<IStock_Request_Details> getAllRequestDetails()
        {
            List<IStock_Request_Details> StockRequestDetailsList = new List<IStock_Request_Details>();
            try
            {
                ds = new DataSet();
                string sql = "SELECT * FROM healthyfoodstoredb.Stock_Request_Details";
                da = new SqlDataAdapter(sql, connection);
                cb = new SqlCommandBuilder(da);
                da.Fill(ds, "Stock_Request_Details");
                totStock_Request_Details = ds.Tables["Stock_Request_Details"].Rows.Count;
                for (int i = 0; i < totStock_Request_Details; i++)
                {
                    DataRow dRow = ds.Tables["Stock_Request_Details"].Rows[i];
                    IStock_Request_Details request = Stock_Request_DetailsFactory.GetStock_Request_Details(Convert.ToInt32(dRow.ItemArray.GetValue(0)), dRow.ItemArray.GetValue(1).ToString(),
                        dRow.ItemArray.GetValue(2).ToString(), dRow.ItemArray.GetValue(3).ToString(),
                        Convert.ToInt32(dRow.ItemArray.GetValue(4)));
                    StockRequestDetailsList.Add(request);
                }

            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (connection.State.ToString() == "Open")
                    connection.Close();
                Application.Exit();
            }
            return StockRequestDetailsList;
        }

        public IProduct getProductByID(string productID)
        {
            DataSet ds;
            SqlDataAdapter dataAdapter;
            try
            {
                ds = new DataSet();
                string sql = $"SELECT * FROM healthyfoodstoredb.products WHERE productID = '{productID}';";
                dataAdapter = new SqlDataAdapter(sql, connection);
                dataAdapter.Fill(ds, "productData");
                cb = new SqlCommandBuilder(dataAdapter);
                DataRow dRow = ds.Tables["productData"].Rows[0];
                return ProductFactory.GetProduct(dRow.ItemArray.GetValue(0).ToString(),
                        dRow.ItemArray.GetValue(1).ToString(), Convert.ToInt32(dRow.ItemArray.GetValue(2)),
                        Convert.ToDouble(dRow.ItemArray.GetValue(3)), Convert.ToInt32(dRow.ItemArray.GetValue(4)),
                        dRow.ItemArray.GetValue(5).ToString(), dRow.ItemArray.GetValue(6).ToString());
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (connection.State.ToString() == "Open")
                    connection.Close();
                Application.Exit();
                return null;
            }
        }

        public IOrder getOrderByID(string orderID)
        {
            DataSet ds;
            SqlDataAdapter dataAdapter;
            try
            {
                ds = new DataSet();
                string sql = $"SELECT * FROM healthyfoodstoredb.orders WHERE orderID = '{orderID}'";
                dataAdapter = new SqlDataAdapter(sql, connection);
                dataAdapter.Fill(ds, "orderData");
                cb = new SqlCommandBuilder(dataAdapter);
                DataRow dRow = ds.Tables["orderData"].Rows[0];
                return OrderFactory.GetOrder(dRow.ItemArray.GetValue(0).ToString(), dRow.ItemArray.GetValue(1).ToString(),
                        Convert.ToInt16(dRow.ItemArray.GetValue(2)), Convert.ToInt32(dRow.ItemArray.GetValue(3)),
                        Convert.ToDateTime(dRow.ItemArray.GetValue(4).ToString()));
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (connection.State.ToString() == "Open")
                    connection.Close();
                Application.Exit();
                return null;
            }
        }

        public double getPriceOfOrder(string orderID)
        {
            SqlCommand cmd;
            string sql = $"SELECT SUM(productPrice) FROM healthyfoodstoredb.orderdetails WHERE orderID = '{orderID}'";
            try
            {
                cmd = new SqlCommand(sql, connection);
                double totalPrice = Convert.ToDouble(cmd.ExecuteScalar());
                cmd.Dispose();
                return totalPrice;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (connection.State.ToString() == "Open")
                    connection.Close();
                Application.Exit();
                return 0;
            }
        }

        public List<IOrderDetails> getOrderDetails(string orderID)
        {
            List<IOrderDetails> detailsList = new List<IOrderDetails>();
            try
            {
                ds = new DataSet();
                string sql = $"SELECT * FROM healthyfoodstoredb.orderdetails WHERE orderID = '{orderID}'";
                da = new SqlDataAdapter(sql, connection);
                cb = new SqlCommandBuilder(da);
                da.Fill(ds, "DetailsData");
                totOrders = ds.Tables["DetailsData"].Rows.Count;
                for (int i = 0; i < totOrders; i++)
                {
                    DataRow dRow = ds.Tables["DetailsData"].Rows[i];
                    IOrderDetails details = OrderDetailsFactory.GetOrderDetails(dRow.ItemArray.GetValue(0).ToString(), dRow.ItemArray.GetValue(1).ToString(),
                            dRow.ItemArray.GetValue(2).ToString(), dRow.ItemArray.GetValue(3).ToString(),
                            Convert.ToInt32(dRow.ItemArray.GetValue(4)), Convert.ToDouble(dRow.ItemArray.GetValue(5)),
                            Convert.ToInt32(dRow.ItemArray.GetValue(6)));
                    detailsList.Add(details);
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (connection.State.ToString() == "Open")
                    connection.Close();
                Application.Exit();
            }
            return detailsList;
        }

        public ICustomer getCustomerOfOrder(string custID)
        {
            DataSet ds;
            SqlDataAdapter dataAdapter;
            try
            {
                ds = new DataSet();
                string sql = $"SELECT * FROM healthyfoodstoredb.customer INNER JOIN healthyfoodstoredb.orders ON (healthyfoodstoredb.orders.customerID = healthyfoodstoredb.customer.customerID) WHERE customer.customerID = '{custID}';";
                dataAdapter = new SqlDataAdapter(sql, connection);
                dataAdapter.Fill(ds, "customerData");
                cb = new SqlCommandBuilder(dataAdapter);
                DataRow dRow = ds.Tables["customerData"].Rows[0];
                return CustomerFactory.GetCustomer(dRow.ItemArray.GetValue(0).ToString(), dRow.ItemArray.GetValue(1).ToString(),
                        dRow.ItemArray.GetValue(2).ToString(), dRow.ItemArray.GetValue(3).ToString(),
                        dRow.ItemArray.GetValue(4).ToString(), dRow.ItemArray.GetValue(5).ToString(),
                        dRow.ItemArray.GetValue(6).ToString(), dRow.ItemArray.GetValue(7).ToString(),
                        dRow.ItemArray.GetValue(8).ToString(), dRow.ItemArray.GetValue(9).ToString(),
                        Convert.ToInt32(dRow.ItemArray.GetValue(10).ToString()));
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (connection.State.ToString() == "Open")
                    connection.Close();
                Application.Exit();
                return null;
            }
        }

        public void confirmOrder(string orderID)
        {
            try
            {
                string sql = $"UPDATE healthyfoodstoredb.orders SET complete = 1 WHERE orderID = '{orderID}';";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.ExecuteScalar();
                MessageBox.Show("Order has been completed !!");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (connection.State.ToString() == "Open")
                    connection.Close();
                Application.Exit();
            }
        }

        public void deleteOrderDetails(string orderID)
        {
            try
            {
                string sql = $"DELETE FROM healthyfoodstoredb.orderdetails WHERE orderID = '{orderID}'";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.ExecuteNonQuery();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (connection.State.ToString() == "Open")
                    connection.Close();
                Application.Exit();
            }
        }

        public void deleteOrder(string orderID)
        {
            try
            {
                string sql = $"DELETE FROM healthyfoodstoredb.orders WHERE orderID = '{orderID}'";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Order has been deleted !!");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (connection.State.ToString() == "Open")
                    connection.Close();
                Application.Exit();
            }
        }



        public int selectStockRequests()
        {
            SqlCommand cmd;
            string sql = "SELECT TOP 1 SUBSTRING(srID, 5, LEN(srID)-1) FROM healthyfoodstoredb.stock_requests ORDER BY CAST(SUBSTRING(srID, 5, LEN(srID)-1) AS int) DESC;";
            try
            {
                cmd = new SqlCommand(sql, connection);
                int requestID = Convert.ToInt32(cmd.ExecuteScalar());
                cmd.Dispose();
                return requestID;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (connection.State.ToString() == "Open")
                    connection.Close();
                Application.Exit();
                return 0;
            }
        }
        public int countProduct()
        {
            SqlCommand cmd;
            string sql = "SELECT TOP 1 SUBSTRING(productID, 4, LEN(productID)-1) FROM healthyfoodstoredb.products ORDER BY CAST(SUBSTRING(productID, 4, LEN(productID)-1) AS int) DESC;";
            try
            {
                cmd = new SqlCommand(sql, connection);
                int total = Convert.ToInt32(cmd.ExecuteScalar());
                cmd.Dispose();
                return total;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (connection.State.ToString() == "Open")
                    connection.Close();
                Application.Exit();
                return 0;
            }
        }

        public void requestStock(int quantity, string srID, string description, string staffID)
        {
            SqlCommand cmd;
            string sql = $"INSERT INTO healthyfoodstoredb.stock_requests(srID, quantity, description, complete, staffID) VALUES ('{srID}', {quantity}, '{description}', 0, '{staffID}')";
            try
            {
                cmd = new SqlCommand(sql, connection);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                MessageBox.Show("Request has been submitted !!!");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (connection.State.ToString() == "Open")
                    connection.Close();
                Application.Exit();
            }
        }

        public void sumbitStockDetials(string srID, string productID, string productName, int productQuantity)
        {
            SqlCommand cmd;
            string sql = $"INSERT INTO healthyfoodstoredb.stock_request_details(srID, productID, productName, productQuantity) VALUES ('{srID}', '{productID}', '{productName}', {productQuantity})";
            try
            {
                cmd = new SqlCommand(sql, connection);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (connection.State.ToString() == "Open")
                    connection.Close();
                Application.Exit();
            }
        }

        public int selectLoginLogs()
        {
            SqlCommand cmd;
            string sql = "SELECT TOP 1 SUBSTRING(logID, 5, LEN(logID)-1) FROM healthyfoodstoredb.loginlog ORDER BY CAST(SUBSTRING(logID, 5, LEN(logID)-1) AS int) DESC;";
            try
            {
                cmd = new SqlCommand(sql, connection);
                int logID = Convert.ToInt32(cmd.ExecuteScalar());
                cmd.Dispose();
                return logID;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (connection.State.ToString() == "Open")
                    connection.Close();
                Application.Exit();
                return 0;
            }
        }

        public void deleteRequestDetails(string sdetailsID)
        {
            try
            {
                string sql = $"DELETE FROM healthyfoodstoredb.stock_request_details WHERE sdetailsID = '{sdetailsID}'";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.ExecuteNonQuery();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (connection.State.ToString() == "Open")
                    connection.Close();
                Application.Exit();
            }
        }

        public void deleteRequest(string sdetailsID)
        {
            try
            {
                string sql = $"DELETE FROM healthyfoodstoredb.stock_requests WHERE srID = '{sdetailsID}'";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Order has been deleted !!");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (connection.State.ToString() == "Open")
                    connection.Close();
                Application.Exit();
            }
        }

        public int countLoginLogs()
        {
            SqlCommand cmd;
            string sql = "SELECT TOP 1 SUBSTRING(logID, 4, LEN(logID)-1) FROM healthyfoodstoredb.loginlog ORDER BY CAST(SUBSTRING(logID, 4, LEN(logID)-1) AS int) DESC;";
            try
            {
                cmd = new SqlCommand(sql, connection);
                int loginID = Convert.ToInt32(cmd.ExecuteScalar());
                cmd.Dispose();
                return loginID;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (connection.State.ToString() == "Open")
                    connection.Close();
                Application.Exit();
                return 0;
            }
        }

        public void recordLogin(string loginID, string staffID)
        {
            SqlCommand cmd;
            string sql = $"INSERT INTO healthyfoodstoredb.loginlog(logID, staffID, loginTime, date) VALUES ('{loginID}', '{staffID}', CURRENT_TIMESTAMP, CURRENT_TIMESTAMP);";
            try
            {
                cmd = new SqlCommand(sql, connection);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (connection.State.ToString() == "Open")
                    connection.Close();
                Application.Exit();
            }
        }

        public void recordLogout(string loginID)
        {
            SqlCommand cmd;
            string sql = $"UPDATE healthyfoodstoredb.loginlog SET logoutTime = CURRENT_TIMESTAMP WHERE logID = '{loginID}';";
            try
            {
                cmd = new SqlCommand(sql, connection);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (connection.State.ToString() == "Open")
                    connection.Close();
                Application.Exit();
            }
        }

        public List<IQueries> getAllQueries()
        {
            List<IQueries> queryList = new List<IQueries>();
            try
            {
                ds = new DataSet();
                string sql = $"SELECT * FROM healthyfoodstoredb.queries";
                da = new SqlDataAdapter(sql, connection);
                cb = new SqlCommandBuilder(da);
                da.Fill(ds, "QueryData");
                totQueries = ds.Tables["QueryData"].Rows.Count;
                for (int i = 0; i < totQueries; i++)
                {
                    DataRow dRow = ds.Tables["QueryData"].Rows[i];
                    IQueries query = QueriesFactory.GetQueries(dRow.ItemArray.GetValue(0).ToString(), dRow.ItemArray.GetValue(1).ToString(),
                        dRow.ItemArray.GetValue(2).ToString(), dRow.ItemArray.GetValue(3).ToString(), Convert.ToInt32(dRow.ItemArray.GetValue(4)));
                    queryList.Add(query);
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (connection.State.ToString() == "Open")
                    connection.Close();
                Application.Exit();
            }
            return queryList;
        }

        public void deleteProduct(string productID)
        {
            try
            {
                string sql = $"DELETE FROM healthyfoodstoredb.products WHERE productID = '{productID}'";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product has been deleted !!");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (connection.State.ToString() == "Open")
                    connection.Close();
                Application.Exit();
            }
        }

        public IQueries getQueryByID(string ticketID)
        {
            DataSet ds;
            SqlDataAdapter dataAdapter;
            try
            {
                ds = new DataSet();
                string sql = $"SELECT * FROM healthyfoodstoredb.queries WHERE queryID = '{ticketID}';";
                dataAdapter = new SqlDataAdapter(sql, connection);
                dataAdapter.Fill(ds, "queryData");
                cb = new SqlCommandBuilder(dataAdapter);
                DataRow dRow = ds.Tables["queryData"].Rows[0];
                return QueriesFactory.GetQueries(dRow.ItemArray.GetValue(0).ToString(), dRow.ItemArray.GetValue(1).ToString(),
                    dRow.ItemArray.GetValue(2).ToString(), dRow.ItemArray.GetValue(3).ToString(),
                    Convert.ToInt32(dRow.ItemArray.GetValue(4)));
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (connection.State.ToString() == "Open")
                    connection.Close();
                Application.Exit();
                return null;
            }
        }

        public ICustomer getCustomerByID(string customerID)
        {
            DataSet ds;
            SqlDataAdapter dataAdapter;
            try
            {
                ds = new DataSet();
                string sql = $"SELECT * FROM healthyfoodstoredb.customer WHERE customerID = '{customerID}';";
                dataAdapter = new SqlDataAdapter(sql, connection);
                dataAdapter.Fill(ds, "queryData");
                cb = new SqlCommandBuilder(dataAdapter);
                DataRow dRow = ds.Tables["queryData"].Rows[0];
                return CustomerFactory.GetCustomer(dRow.ItemArray.GetValue(0).ToString(), dRow.ItemArray.GetValue(1).ToString(),
                    dRow.ItemArray.GetValue(2).ToString(), dRow.ItemArray.GetValue(3).ToString(),
                    dRow.ItemArray.GetValue(4).ToString(), dRow.ItemArray.GetValue(5).ToString(),
                    dRow.ItemArray.GetValue(6).ToString(), dRow.ItemArray.GetValue(7).ToString(),
                    dRow.ItemArray.GetValue(8).ToString(), dRow.ItemArray.GetValue(9).ToString(),
                    Convert.ToInt32(dRow.ItemArray.GetValue(10)));
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (connection.State.ToString() == "Open")
                    connection.Close();
                Application.Exit();
                return null;
            }
        }

        public bool replyToQuery(string ticketID, string reply)
        {
            SqlCommand cmd;
            string sql = $"UPDATE healthyfoodstoredb.queries SET Description = Description + CHAR(13) +'{reply}' WHERE queryID = '{ticketID}';";
            try
            {
                cmd = new SqlCommand(sql, connection);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                return true;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (connection.State.ToString() == "Open")
                    connection.Close();
                return false;
            }
        }
        public void addProduct(string productID, string productName, int quantity, double price, string descrpiton, string productType)
        {
            try
            {
                string sql = $"INSERT INTO healthyfoodstoredb.products(productID,productName,quantity,price,discount,description,productType) VALUES('{productID}','{productName}','{quantity}','{price}',0,'{descrpiton}','{productType}')";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product has been added !!");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (connection.State.ToString() == "Open")
                    connection.Close();
                Application.Exit();
            }
        }
        public int selectCustomers()
        {
            SqlCommand cmd;
            string sql = "SELECT TOP 1 SUBSTRING(customerID, 4, LEN(customerID)-1) AS ID FROM healthyfoodstoredb.customer ORDER BY CAST(SUBSTRING(customerID, 4, LEN(customerID)-1) AS int) DESC;";
            try
            {
                cmd = new SqlCommand(sql, connection);
                int custID = Convert.ToInt32(cmd.ExecuteScalar());
                cmd.Dispose();
                return custID;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (connection.State.ToString() == "Open")
                    connection.Close();
                Application.Exit();
                return 0;
            }
        }
        public bool registerCustomer(string customerID, string firstName, string lastName, string email, string password, string address, string city, string county, string eircode, string mobile)
        {
            try
            {
                SqlCommand cmd;
                string sql = $"INSERT INTO healthyfoodstoredb.customer(customerID, firstName, lastName, email, password, address, city, county, eircode, mobile, loyalty_card) VALUES ('{customerID}', '{firstName}', '{lastName}', '{email}', '{password}', '{address}', '{city}', '{county}', '{eircode}', '{mobile}', 0);";
                cmd = new SqlCommand(sql, connection);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (System.Exception ex)
            {
                return false;
            }
        }

        //Online Checkout
        public void ProcessPurchase(string cardNo, string customerID, string name, string cardType, int expiryMonth, int expiryYear)
        {
            SqlCommand cmd;
            string sql = $"INSERT INTO healthyfoodstoredb.card_details(cardNumber, customerID, cardName, cardType, expiryMonth, expiryYear) VALUES ('{cardNo}', '{customerID}', '{name}', '{cardType}', {expiryMonth}, {expiryYear})";
            try
            {
                cmd = new SqlCommand(sql, connection);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                MessageBox.Show("Card details have been added! ");

            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (connection.State.ToString() == "Open")
                    connection.Close();
                Application.Exit();
            }
        }

        public int getOrderCount()
        {
            SqlCommand cmd;
            try
            {
                string sql = $"SELECT COUNT(*) FROM healthyfoodstoredb.orders";
                cmd = new SqlCommand(sql, connection);
                int countOrder = Convert.ToInt32(cmd.ExecuteScalar());
                cmd.Dispose();
                return countOrder;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (connection.State.ToString() == "Open")
                    connection.Close();
                Application.Exit();
                return 0;
            }
        }


        public void addOrder(string id, string customerID, int quantity)
        {

            try
            {
                string sql = $"INSERT INTO healthyfoodstoredb.orders(orderID, customerID, complete, quantity, dateOrdered) VALUES ('{id}', '{customerID}', 0, {quantity}, GETDATE())";
                sql += "";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Order has been added");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (connection.State.ToString() == "Open")
                    connection.Close();
                Application.Exit();
            }
        }


        public void editProduct(string productName, string productID, int quantity, double price, string descrpiton, string productType)
        {

            try
            {
                string sql = $"UPDATE healthyfoodstoredb.products SET productName = '{productName}', quantity='{quantity}',price='{price}',discount=0,description='{descrpiton}',productType='{productType}'  WHERE productID = '{productID}';";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product has been edited !!");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (connection.State.ToString() == "Open")
                    connection.Close();
                Application.Exit();
            }
        }

        public void editCustomerDetails(string id, string address, string number, string email, string city, string county, string eircode)
        {
            try
            {
                string sql = $"UPDATE healthyfoodstoredb.customer SET address='{address}',mobile='{number}',email='{email}',city='{city}',county='{county}',eircode='{eircode}' WHERE customerID='{id}'";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Your personal information has been changed !!");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (connection.State.ToString() == "Open")
                    connection.Close();
                Application.Exit();
            }
        }

        public void editStaffDetails(string staffID, string firstName, string lastName, string staffType, string email, string password, int mobile)
        {
            try
            {
                string sql = $"UPDATE healthyfoodstoredb.staff SET staffID = '{staffID}', firsttName='{firstName}',lastName='{lastName}',staffType='{staffType}',email='{email}',password='{password}',mobile='{mobile}'  WHERE staffID = '{staffID}';";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Staff details have been updated!");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (connection.State.ToString() == "Open")
                    connection.Close();
                Application.Exit();
            }
        }

        public void deleteStaff(string staffID)
        {
            try
            {
                string sql = $"DELETE FROM healthyfoodstoredb.staff WHERE staffID = '{staffID}'";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Staff details have been deleted!");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (connection.State.ToString() == "Open")
                    connection.Close();
                Application.Exit();
            }
        }

        public void addStaffDetails(string staffID, string firstName, string lastName, string staffType, string email, string password, int mobile)
        {
            try
            {
                string sql = $"INSERT INTO healthyfoodstoredb.staff (staffID, firstName, lastName, staffType, email, password, mobile) VALUES('{staffID}','{firstName}', '{lastName}', '{staffType}','{email}', '{password}', '{mobile})";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Staff member has been added !!");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (connection.State.ToString() == "Open")
                    connection.Close();
                Application.Exit();
            }
        }

        public void addOrderDetails(string detailsID, string orderID, string productID, string productName, int productQuantity, double productPrice, int productStoreQuantity)
        {
            try
            {
                string sql = $"INSERT INTO healthyfoodstoredb.orderdetails(detailID, orderID, productID, productName,productQuantity, productPrice, productStoreQuantity) VALUES ('{detailsID}','{orderID}', '{productID}', '{productName}', {productQuantity}, {productPrice}, {productStoreQuantity})";
                sql += "";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Order Details has been added");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (connection.State.ToString() == "Open")
                    connection.Close();
                Application.Exit();
            }
        }

        public int getProductStoreQuantityByID(string productID)
        {
            SqlCommand cmd;
            try
            {
                string sql = $"SELECT quantity FROM healthyfoodstoredb.products WHERE productID = '{productID}'";
                cmd = new SqlCommand(sql, connection);
                int storeQuantity = Convert.ToInt32(cmd.ExecuteScalar());
                cmd.Dispose();
                return storeQuantity;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (connection.State.ToString() == "Open")
                    connection.Close();
                Application.Exit();
                return 0;
            }
        }

        public int getOrderDetailsCount()
        {
            SqlCommand cmd;
            try
            {
                string sql = $"SELECT COUNT(*) FROM healthyfoodstoredb.orderDetails";
                cmd = new SqlCommand(sql, connection);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                cmd.Dispose();
                return count;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (connection.State.ToString() == "Open")
                    connection.Close();
                Application.Exit();
                return 0;
            }
        }

        public void applyForLoyaltyCard(string customerID, string loyaltyID)
        {
            SqlCommand cmd;
            SqlCommand cmd2;
            try
            {
                string sql2 = $"UPDATE healthyfoodstoredb.customer SET loyalty_card=1 WHERE customerID='{customerID}'";
                string sql = $"INSERT INTO healthyfoodstoredb.loyalty_card(loyalty_cardID,card_points,customerID) VALUES('{loyaltyID}',0,'{customerID}')";
                cmd = new SqlCommand(sql, connection);
                cmd2 = new SqlCommand(sql2, connection);
                int storeQuantity = Convert.ToInt32(cmd.ExecuteScalar());
                int storeQuantity2 = Convert.ToInt32(cmd2.ExecuteScalar());
                cmd.Dispose();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (connection.State.ToString() == "Open")
                    connection.Close();
                Application.Exit();
            }
        }

        public int countLoyaltyCards()
        {
            SqlCommand cmd;
            string sql = "SELECT TOP 1 SUBSTRING(loyalty_cardID, 4, LEN(loyalty_cardID)-1) FROM healthyfoodstoredb.loyalty_card ORDER BY CAST(SUBSTRING(loyalty_cardID, 4, LEN(loyalty_cardID)-1) AS int) DESC;";
            try
            {
                cmd = new SqlCommand(sql, connection);
                int total = Convert.ToInt32(cmd.ExecuteScalar());
                cmd.Dispose();
                return total;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (connection.State.ToString() == "Open")
                    connection.Close();
                Application.Exit();
                return 0;
            }
        }

        public int getStaffCount()
        {
            SqlCommand cmd;
            string sql = "SELECT COUNT(*) FROM healthyfoodstoredb.staff WHERE NOT STAFFTYPE = 'OWNER'";
            try
            {
                cmd = new SqlCommand(sql, connection);
                int total = Convert.ToInt32(cmd.ExecuteScalar());
                cmd.Dispose();
                return total;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (connection.State.ToString() == "Open")
                    connection.Close();
                Application.Exit();
                return 0;
            }
        }

        public int getAllStaffCount()
        {
            SqlCommand cmd;
            string sql = "SELECT COUNT(*) FROM healthyfoodstoredb.staff";
            try
            {
                cmd = new SqlCommand(sql, connection);
                int total = Convert.ToInt32(cmd.ExecuteScalar());
                cmd.Dispose();
                return total;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (connection.State.ToString() == "Open")
                    connection.Close();
                Application.Exit();
                return 0;
            }
        }

        public double getTotalEarnings()
        {
            SqlCommand cmd;
            string sql = "SELECT SUM(productPrice) FROM healthyfoodstoredb.orderdetails";
            try
            {
                cmd = new SqlCommand(sql, connection);
                int total = Convert.ToInt32(cmd.ExecuteScalar());
                cmd.Dispose();
                return total;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (connection.State.ToString() == "Open")
                    connection.Close();
                Application.Exit();
                return 0;
            }
        }


        public List<IDiscount> getAllDiscountDetails()
        {
            List<IDiscount> discountList = new List<IDiscount>();
            try
            {
                ds = new DataSet();
                string sql = "SELECT * FROM healthyfoodstoredb.discounts";
                da = new SqlDataAdapter(sql, connection);
                cb = new SqlCommandBuilder(da);
                da.Fill(ds, "DiscountData");
                totDiscount = ds.Tables["DiscountData"].Rows.Count;
                for (int i = 0; i < totDiscount; i++)
                {
                    DataRow dRow = ds.Tables["DiscountData"].Rows[i];
                    IDiscount discount = DiscountFactory.GetDiscount(dRow.ItemArray.GetValue(0).ToString(),
                        dRow.ItemArray.GetValue(1).ToString(), Convert.ToInt32(dRow.ItemArray.GetValue(2)),
                        Convert.ToDateTime(dRow.ItemArray.GetValue(3)), Convert.ToDateTime(dRow.ItemArray.GetValue(4)),
                        dRow.ItemArray.GetValue(5).ToString());
                    discountList.Add(discount);
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (connection.State.ToString() == "Open")
                    connection.Close();
                Application.Exit();
            }
            return discountList;
        }

        public List<IStaff> getAllManager()
        {
            List<IStaff> managerList = new List<IStaff>();
            try
            {
                ds = new DataSet();
                string sql = "SELECT * FROM healthyfoodstoredb.staff WHERE staffType='MANAGER'";
                da = new SqlDataAdapter(sql, connection);
                cb = new SqlCommandBuilder(da);
                da.Fill(ds, "ManagerData");
                totManager = ds.Tables["ManagerData"].Rows.Count;
                for (int i = 0; i < totManager; i++)
                {
                    DataRow dRow = ds.Tables["ManagerData"].Rows[i];
                    IStaff manager = StaffFactory.GetStaff(dRow.ItemArray.GetValue(0).ToString(),
                        dRow.ItemArray.GetValue(1).ToString(), dRow.ItemArray.GetValue(2).ToString(),
                        dRow.ItemArray.GetValue(3).ToString(), dRow.ItemArray.GetValue(4).ToString(),
                        dRow.ItemArray.GetValue(5).ToString(), dRow.ItemArray.GetValue(6).ToString());
                    managerList.Add(manager);
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (connection.State.ToString() == "Open")
                    connection.Close();
                Application.Exit();
            }
            return managerList;
        }

        public IStaff getManagerByID(string id)
        {
            DataSet ds;
            SqlDataAdapter dataAdapter;
            try
            {
                ds = new DataSet();
                string sql = $"SELECT * FROM healthyfoodstoredb.staff WHERE staffID = '{id}';";
                dataAdapter = new SqlDataAdapter(sql, connection);
                dataAdapter.Fill(ds, "managertData");
                cb = new SqlCommandBuilder(dataAdapter);
                DataRow dRow = ds.Tables["managertData"].Rows[0];
                return StaffFactory.GetStaff(dRow.ItemArray.GetValue(0).ToString(),
                       dRow.ItemArray.GetValue(1).ToString(), dRow.ItemArray.GetValue(2).ToString(),
                       dRow.ItemArray.GetValue(3).ToString(), dRow.ItemArray.GetValue(4).ToString(),
                       dRow.ItemArray.GetValue(5).ToString(), dRow.ItemArray.GetValue(6).ToString());
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (connection.State.ToString() == "Open")
                    connection.Close();
                Application.Exit();
                return null;
            }
        }

        public void addManager(string staffID, string firstName, string lastName, string email, string password, string mobile)
        {
            try
            {
                string sql = $"INSERT INTO healthyfoodstoredb.staff(staffID, firsttName, lastName, email, password, mobile, staffType) VALUES ('{staffID}', '{firstName}', '{lastName}', '{email}', '{password}', '{mobile}', 'MANAGER')";
                sql += "";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("MANAGER has been added");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (connection.State.ToString() == "Open")
                    connection.Close();
                Application.Exit();
            }
        }

        public void updateManager(string staffID, string firstName, string lastName, string email, string password, string mobile)
        {
            try
            {
                string sql = $"UPDATE healthyfoodstoredb.staff SET firsttName='{firstName}', lastName='{lastName}',email='{email}',password='{password}',mobile='{lastName}' WHERE staffID='{staffID}'";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Manager details has been changed!");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (connection.State.ToString() == "Open")
                    connection.Close();
                Application.Exit();
            }
        }
        public void deleteManager(string staffID)
        {
            try
            {
                string sql = $"DELETE FROM healthyfoodstoredb.staff WHERE staffID = '{staffID}'";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Manager has been deleted");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (connection.State.ToString() == "Open")
                    connection.Close();
                Application.Exit();
            }
        }

        public int countTickets()
        {
            SqlCommand cmd;
            string sql = "SELECT COUNT(*) FROM healthyfoodstoredb.queries";
            try
            {
                cmd = new SqlCommand(sql, connection);
                int total = Convert.ToInt32(cmd.ExecuteScalar());
                cmd.Dispose();
                return total;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (connection.State.ToString() == "Open")
                    connection.Close();
                Application.Exit();
                return 0;
            }

        }

        public void MakeTicket(string queryID, string topic, string description, string custID)
        {
            try
            {
                string sql = $"INSERT INTO healthyfoodstoredb.queries(queryID,customerID,topic,Description,complete) VALUES ('{queryID}', '{custID}', '{topic}', '{description}',0)";
                sql += "";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("You have made a query, our staff will help you as quick as possible.");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (connection.State.ToString() == "Open")
                    connection.Close();
                Application.Exit();
            }
        }

        public void addDiscountDetails(string discountID, string discountCode, int discountPercentage, DateTime startDate, DateTime endDate, string productType)
        {
            try
            {
                string sql = $"INSERT INTO healthyfoodstoredb.discounts VALUES ('{discountID}', '{discountCode}', {discountPercentage}, '{startDate}','{endDate}', '{productType}')";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Discount details has been added");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (connection.State.ToString() == "Open")
                    connection.Close();
                Application.Exit();
            }
        }

        public void updateDiscountDetails(string discountID, string discountCode, int discountPercentage, DateTime startDate, DateTime endDate, string productType)
        {
            try
            {
                string sql = $"UPDATE healthyfoodstoredb.discounts SET discountCode = '{discountCode}',discount = {discountPercentage},startDate = '{startDate}',endDate = '{endDate}',productType = '{productType}' WHERE discountID = '{discountID}'";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Discount details has been updated");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (connection.State.ToString() == "Open")
                    connection.Close();
                Application.Exit();
            }
        }



        public void deleteDiscountDetails(string discountID)
        {
            try
            {
                string sql = $"DELETE FROM healthyfoodstoredb.discounts WHERE discountID = '{discountID}'";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Discount details has been deleted");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (connection.State.ToString() == "Open")
                    connection.Close();
                Application.Exit();
            }
        }

        public IDiscount getDiscountDetailsByID(string id)
        {
            DataSet ds;
            SqlDataAdapter dataAdapter;
            try
            {
                ds = new DataSet();
                string sql = $"SELECT * FROM healthyfoodstoredb.discounts WHERE discountID = '{id}';";
                dataAdapter = new SqlDataAdapter(sql, connection);
                dataAdapter.Fill(ds, "discounttData");
                cb = new SqlCommandBuilder(dataAdapter);
                DataRow dRow = ds.Tables["discounttData"].Rows[0];
                return DiscountFactory.GetDiscount(dRow.ItemArray.GetValue(0).ToString(),
                    dRow.ItemArray.GetValue(1).ToString(), Convert.ToInt32(dRow.ItemArray.GetValue(2)),
                    Convert.ToDateTime(dRow.ItemArray.GetValue(3)), Convert.ToDateTime(dRow.ItemArray.GetValue(4)),
                    dRow.ItemArray.GetValue(5).ToString());
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (connection.State.ToString() == "Open")
                    connection.Close();
                Application.Exit();
                return null;
            }

        }

        public int getDiscountDetailsCount()
        {
            SqlCommand cmd;
            string sql = "SELECT TOP 1 discountID FROM healthyfoodstoredb.discounts ORDER BY discountID DESC";
            try
            {
                cmd = new SqlCommand(sql, connection);
                int total = Convert.ToInt32(cmd.ExecuteScalar());
                cmd.Dispose();
                return total;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (connection.State.ToString() == "Open")
                    connection.Close();
                Application.Exit();
                return 0;
            }
        }

        public void resetPassword(string newPassword, string customerID)
        {

            try
            {
                string sql = $"UPDATE healthyfoodstoredb.customer SET password = '{newPassword}' WHERE customerID = '{customerID}'";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Your Password has been updated!");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (connection.State.ToString() == "Open")
                    connection.Close();
                Application.Exit();
            }
        }

        public Dictionary<string, int> getOrderProducts(string oID)
        {
            Dictionary<string, int> orderProducts = new Dictionary<string, int>();

            ds = new DataSet();
            string sql = $"SELECT productID, productQuantity FROM healthyfoodstoredb.orderdetails WHERE orderID = '{oID}'";
            da = new SqlDataAdapter(sql, connection);
            cb = new SqlCommandBuilder(da);
            da.Fill(ds, "ProdData");
            totOrderProd = ds.Tables["ProdData"].Rows.Count;
            for (int i = 0; i < totOrderProd; i++)
            {
                DataRow dRow = ds.Tables["ProdData"].Rows[i];
                orderProducts.Add(dRow.ItemArray.GetValue(0).ToString(), Convert.ToInt32(dRow.ItemArray.GetValue(1)));
            }

            return orderProducts;
        }

        public void updateProducts(string productID, int productQuantity)
        {   
            try
            {
                string sql = $"UPDATE healthyfoodstoredb.products SET quantity = quantity - {productQuantity} WHERE productID = '{productID}';";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (connection.State.ToString() == "Open")
                    connection.Close();
            }
        }


        public List<ICardDetails> getCardDetailsByCustomerID(string customerID)
        {
            List<ICardDetails> cardDetailsList = new List<ICardDetails>();
            try
            {
                ds = new DataSet();
                string sql = $"SELECT * FROM healthyfoodstoredb.card_details WHERE customerID = '{customerID}'";
                da = new SqlDataAdapter(sql, connection);
                cb = new SqlCommandBuilder(da);
                da.Fill(ds, "cardDetailsData");
                totCardDetails = ds.Tables["cardDetailsData"].Rows.Count;
                for (int i = 0; i < totCardDetails; i++)
                {
                    DataRow dRow = ds.Tables["cardDetailsData"].Rows[i];
                    ICardDetails cardDetails = CardDetailsFactory.GetCardDetails(dRow.ItemArray.GetValue(0).ToString(),
                        dRow.ItemArray.GetValue(1).ToString(), dRow.ItemArray.GetValue(2).ToString(),
                        dRow.ItemArray.GetValue(3).ToString(), int.Parse(dRow.ItemArray.GetValue(4).ToString()),
                        int.Parse(dRow.ItemArray.GetValue(5).ToString()));
                    cardDetailsList.Add(cardDetails);
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (connection.State.ToString() == "Open")
                    connection.Close();
                Application.Exit();
            }
            return cardDetailsList;
        }

        public double priceOfOrders(string orderID)
        {
            SqlCommand cmd;
            string sql = $"SELECT SUM(productPrice) as Price FROM healthyfoodstoredb.orderdetails WHERE orderID = '{orderID}' ;";
            try
            {
                cmd = new SqlCommand(sql, connection);
                double total = Convert.ToDouble(cmd.ExecuteScalar());
                cmd.Dispose();
                return total;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (connection.State.ToString() == "Open")
                    connection.Close();
                Application.Exit();
                return 0;
            }

        }

        public void addWishListItem(string customerID, string productID, string productName, double price, string productType)
        {
            try
            {
                string sql = $"INSERT INTO dbo.wishlist VALUES ('{customerID}', '{productID}', '{productName}', {price}, '{productType}')";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("New item has been added to the wishlist");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (connection.State.ToString() == "Open")
                    connection.Close();
                Application.Exit();
            }
        }

        public void deleteWishListItem(string customerID, string productID)
        {
            try
            {
                string sql = $"DELETE FROM dbo.wishlist WHERE customerID = '{customerID}' AND productID = '{productID}'";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.ExecuteNonQuery();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (connection.State.ToString() == "Open")
                    connection.Close();
                Application.Exit();
            }
        }

        public void clearWishList(string customerID)
        {
            try
            {
                string sql = $"DELETE FROM dbo.wishlist WHERE customerID = '{customerID}'";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Wishlist has been cleared");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (connection.State.ToString() == "Open")
                    connection.Close();
                Application.Exit();
            }
        }

        public List<IWishlist> getWishListItemByCustomerID(string customerID)
        {
            List<IWishlist> wishlist = new List<IWishlist>();
            try
            {
                ds = new DataSet();
                string sql = $"SELECT customerID, productID, productName, price, productType FROM dbo.wishlist WHERE customerID = '{customerID}'";
                da = new SqlDataAdapter(sql, connection);
                cb = new SqlCommandBuilder(da);
                da.Fill(ds, "wishlistData");
                totWishlist = ds.Tables["wishlistData"].Rows.Count;
                for (int i = 0; i < totWishlist; i++)
                {
                    DataRow dRow = ds.Tables["wishlistData"].Rows[i];
                    IWishlist wishlistitem = WishlistFactory.GetWishlist(dRow.ItemArray.GetValue(0).ToString(),
                        dRow.ItemArray.GetValue(1).ToString(), dRow.ItemArray.GetValue(2).ToString(),
                        double.Parse(dRow.ItemArray.GetValue(3).ToString()), dRow.ItemArray.GetValue(4).ToString());
                    wishlist.Add(wishlistitem);
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (connection.State.ToString() == "Open")
                    connection.Close();
                Application.Exit();
            }
            return wishlist;

        }

        public void addItemToCart(string productID, string productName, double productPrice, int quantity, string customerID, string productType)
        {
            try
            {
                string sql = $"INSERT INTO dbo.cart VALUES ('{productID}', '{productName}', {productPrice}, {quantity}, '{customerID}', '{productType}')";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("New item has been added to the cart");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (connection.State.ToString() == "Open")
                    connection.Close();
                Application.Exit();
            }
        }

        public List<ICart> getCartByCustomerID(string customerID)
        {
            List<ICart> cart = new List<ICart>();
            try
            {
                ds = new DataSet();
                string sql = $"SELECT id, productID, productName, productPrice, quantity, customerID, productType FROM dbo.cart WHERE customerID = '{customerID}'";
                da = new SqlDataAdapter(sql, connection);
                cb = new SqlCommandBuilder(da);
                da.Fill(ds, "cartData");
                totCart = ds.Tables["cartData"].Rows.Count;
                for (int i = 0; i < totCart; i++)
                {
                    DataRow dRow = ds.Tables["cartData"].Rows[i];
                    ICart cartitem = CartFactory.GetCart(int.Parse(dRow.ItemArray.GetValue(0).ToString()),
                        dRow.ItemArray.GetValue(1).ToString(), dRow.ItemArray.GetValue(2).ToString(),
                        double.Parse(dRow.ItemArray.GetValue(3).ToString()), int.Parse(dRow.ItemArray.GetValue(4).ToString()), dRow.ItemArray.GetValue(5).ToString(), dRow.ItemArray.GetValue(6).ToString());
                    cart.Add(cartitem);
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (connection.State.ToString() == "Open")
                    connection.Close();
                Application.Exit();
            }
            return cart;

        }

        public void removeItemFromCart(string productID, string customerID)
        {
            try
            {
                string sql = $"DELETE FROM dbo.cart WHERE customerID = '{customerID}' AND productID = '{productID}'";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cart item has been deleted");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (connection.State.ToString() == "Open")
                    connection.Close();
                Application.Exit();
            }
        }

        public void clearCart(string customerID)
        {
            try
            {
                string sql = $"DELETE FROM dbo.cart WHERE customerID = '{customerID}'";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cart has been cleared!");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (connection.State.ToString() == "Open")
                    connection.Close();
                Application.Exit();
            }
        }

        public void addQuantityToCart(int quantity, string productID, string customerID)
        {
            SqlCommand cmd;
            string sql = $"UPDATE dbo.cart SET quantity = quantity+{quantity} WHERE productID = '{productID}' AND customerID = '{customerID}';";
            try
            {
                cmd = new SqlCommand(sql, connection);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (connection.State.ToString() == "Open")
                    connection.Close();
            }
        }

        public List<IDiscount> getValidDiscounts()
        {
            List<IDiscount> discountList = new List<IDiscount>();
            try
            {
                ds = new DataSet();
                DateTime thisDay = DateTime.Today;
                string sql = $"SELECT * FROM healthyfoodstoredb.discounts WHERE '{thisDay}' BETWEEN startDate AND endDate";
                da = new SqlDataAdapter(sql, connection);
                cb = new SqlCommandBuilder(da);
                da.Fill(ds, "DiscountData");
                totDiscount = ds.Tables["DiscountData"].Rows.Count;
                for (int i = 0; i < totDiscount; i++)
                {
                    DataRow dRow = ds.Tables["DiscountData"].Rows[i];
                    IDiscount discount = DiscountFactory.GetDiscount(dRow.ItemArray.GetValue(0).ToString(),
                        dRow.ItemArray.GetValue(1).ToString(), Convert.ToInt32(dRow.ItemArray.GetValue(2)),
                        Convert.ToDateTime(dRow.ItemArray.GetValue(3)), Convert.ToDateTime(dRow.ItemArray.GetValue(4)),
                        dRow.ItemArray.GetValue(5).ToString());
                    discountList.Add(discount);
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (connection.State.ToString() == "Open")
                    connection.Close();
                Application.Exit();
            }
            return discountList;
        }

        public void redeemedDiscount(string discountCode, string customerID, DateTime redeemedDate)
        {
            try
            {
                string sql = $"INSERT INTO dbo.discountRedeemed VALUES ('{discountCode}', '{customerID}', '{redeemedDate}')";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Discount redeemed");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (connection.State.ToString() == "Open")
                    connection.Close();
                Application.Exit();
            }

        }

        public List<IRedeemedDiscount> getRedeemedDiscountByCustomerID(string customerID)
        {
            List<IRedeemedDiscount> discountList = new List<IRedeemedDiscount>();
            try
            {
                ds = new DataSet();
                DateTime thisDay = DateTime.Today;
                string sql = $"SELECT * FROM dbo.discountRedeemed WHERE customerID = '{customerID}'";
                da = new SqlDataAdapter(sql, connection);
                cb = new SqlCommandBuilder(da);
                da.Fill(ds, "RedeemedDiscountData");
                totRedeemedDiscount = ds.Tables["RedeemedDiscountData"].Rows.Count;
                for (int i = 0; i < totRedeemedDiscount; i++)
                {
                    DataRow dRow = ds.Tables["RedeemedDiscountData"].Rows[i];
                    IRedeemedDiscount discount = RedeemedDiscountFactory.GetRedeemedDiscount(
                        dRow.ItemArray.GetValue(1).ToString(), dRow.ItemArray.GetValue(2).ToString(), Convert.ToDateTime(dRow.ItemArray.GetValue(3)));
                    discountList.Add(discount);
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (connection.State.ToString() == "Open")
                    connection.Close();
                Application.Exit();
            }
            return discountList;
        }

        public void priceDiscountInCart(double price, string productID, string customerID)
        {
            SqlCommand cmd;
            string sql = $"UPDATE dbo.cart SET productPrice = {price} WHERE productID = '{productID}' AND customerID = '{customerID}';";
            try
            {
                cmd = new SqlCommand(sql, connection);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (connection.State.ToString() == "Open")
                    connection.Close();
            }
        }
        public void completeQuery(string ticketID)
        {
            try
            {
                string sql = $"UPDATE healthyfoodstoredb.queries SET complete = 1 WHERE queryID = '{ticketID}'";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (connection.State.ToString() == "Open")
                    connection.Close();
            }
        }

    }
}
