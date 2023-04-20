using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Security.Cryptography;

using DataAccessLayer;
using BusinessEntities;
using System.Windows.Forms;

namespace BusinessLayer
{
    public class Model : IModel
    {
        #region Static Attributes
        private static IModel modelSingleTonInstance;
        static readonly object padlock = new object();
        #endregion
        #region Instance Attributes
        private IDataLayer dataLayer;
        private IStaff currentStaff;
        private ICustomer currentCustomer;
        private List<IStaff> staffList;
        private List<ICustomer> customerList;
        private List<IProduct> productList;
        private List<IStock_Requests> stockRequestList;
        private List<IStock_Request_Details> stockRequestDetailsList;
        private List<IDiscount> discountList;
        private List<IStaff> managerList;
        private List<IOrderDetails> orderDetailsList;
        #endregion
        #region Constructors/Destructors
        public static IModel GetInstance(IDataLayer _DataLayer)
        {
            lock (padlock)
            {
                if(modelSingleTonInstance == null)
                {
                    modelSingleTonInstance = new Model(_DataLayer);
                }
                return modelSingleTonInstance;
            }
        }
        private Model(IDataLayer _DataLayer)
        {
            staffList = new List<IStaff>();
            customerList = new List<ICustomer>();
            productList = new List<IProduct>();
            stockRequestList = new List<IStock_Requests>();
            stockRequestDetailsList = new List<IStock_Request_Details>();
            discountList = new List<IDiscount>();
            managerList = new List<IStaff>();
/*            orderDetailsList = new List<IOrder_Details>();
*/            dataLayer = _DataLayer;
            staffList = dataLayer.getAllStaff();
            productList = dataLayer.getAllProduct();
            customerList = dataLayer.getAllCustomer();
            stockRequestList = dataLayer.getAllRequests();
            stockRequestDetailsList = dataLayer.getAllRequestDetails();
            discountList = dataLayer.getAllDiscountDetails();
            managerList = dataLayer.getAllManager();
/*            orderDetailsList = dataLayer.getOrderDetails();
*/        }
        ~Model()
        {
            tearDown();
        }
        #endregion
        #region Instance Properties
        public IDataLayer DataLayer
        {
            get { return dataLayer; }
            set { dataLayer = value; }
        }
        public IStaff CurrentStaff 
        {
            get { return currentStaff; }
            set { currentStaff = value; }
        }
        public ICustomer CurrentCustomer
        {
            get { return currentCustomer; }
            set { currentCustomer = value; }
        }
        public List<IStaff> StaffList
        {
            get
            {
                return staffList;
            }
        }
        public List<ICustomer> CustomerList
        {
            get
            {
                return customerList;
            }
        }
        public List<IDiscount> DiscountList
        {
            get
            {
                return discountList;
            }
        }
        public List<IProduct> ProductList
        {
            get
            {
                return productList;
            }
        }
        public List<IStock_Requests> StockRequestList
        {
            get
            {
                return stockRequestList;
            }
        }
        public List<IStock_Request_Details> StockRequestDetailsList
        {
            get
            {
                return stockRequestDetailsList;
            }
        }

        public List<IStaff> ManagerList
        {
            get { return managerList; }
        }
        #endregion

        public Boolean staffLogin(String email, String password)
        {
            password = ComputeSha256Hash(password);
            foreach(Staff astaff in staffList)
            {
                if(email == astaff.Email && password == astaff.CurPassword)
                {
                    Debug.WriteLine(astaff);
                    currentStaff = astaff;
                    return true;
                }
            }
            return false;
        }

        public Boolean customerLogin(String email, String password)
        {
            customerList.Clear();
            customerList = dataLayer.getAllCustomer();
            password = ComputeSha256Hash(password);
            foreach(Customer aCustomer in customerList)
            {
                if(email == aCustomer.Email && password == aCustomer.CurPassword)
                {
                    Debug.WriteLine(aCustomer);
                    currentCustomer = aCustomer;
                    return true;
                }
            }
            return false;
        }


        public String getUserTypeForCurrentStaff()
        {
            return currentStaff.StaffType;
        }

        public void tearDown()
        {
            dataLayer.CloseConnection();
        }

        public List<IOrder> getAllOrders()
        {
            return dataLayer.getAllOrders();
        }

        public List<IStock_Requests> getAllRequests()
        {
            return dataLayer.getAllRequests();
        }

        public List<IStock_Request_Details> getAllRequestDetails()
        {
            return dataLayer.getAllRequestDetails();
        }

        public IProduct getProductByID(string productID)
        {
            return dataLayer.getProductByID(productID);
        }

        public IOrder getOrderByID(string orderID)
        {
            return dataLayer.getOrderByID(orderID);
        }

        public double getPriceOfOrder(string orderID)
        {
            return dataLayer.getPriceOfOrder(orderID);
            //return 0;
        }

        public List<IOrderDetails> getOrderDetails(string orderID)
        {
            return dataLayer.getOrderDetails(orderID);
        }

        public ICustomer getCustomerOfOrder(string custID)
        {
            return dataLayer.getCustomerOfOrder(custID);
        }

        public void AddStock(string id, int customerID, int quantity) { 
            
        }

        public bool checkIfEnoughStock(List<IOrderDetails> detailsList)
        {
            foreach(IOrderDetails od in detailsList)
            {
                if(od.ProductQuantity > od.ProductStoreQuantity)
                {
                    return false;
                }
            }
            return true;
        }

        public void confirmOrder(string orderID)
        {
            Dictionary<string, int> orderProducts = new Dictionary<string, int>();

            dataLayer.confirmOrder(orderID);
            orderProducts = dataLayer.getOrderProducts(orderID);
            foreach(KeyValuePair<string, int> item in orderProducts)
            {
                dataLayer.updateProducts(item.Key, item.Value);
            }

        }

        public void deleteOrder(string orderID)
        {
            dataLayer.deleteOrderDetails(orderID);
            dataLayer.deleteOrder(orderID);
        }

        public void deleteProduct(string productID)
        {
            dataLayer.deleteProduct(productID);
        }

        public void deleteRequest(string orderID)
        {
            dataLayer.deleteRequestDetails(orderID);
            dataLayer.deleteRequest(orderID);
        }

        public void addProduct(string productName, int quantity,double price, string descrpiton,string productType)
        {
            string id = makeProductID();

            dataLayer.addProduct( id,  productName,  quantity,  price,  descrpiton,  productType);
        }

        public void editProduct(string productID, string productName, int quantity, double price, string descrpiton, string productType)
        {
            dataLayer.editProduct(productID,productName,quantity,price,descrpiton,productType);
        }

        public string makeProductID()
        {
            string ID = "P00";
            int totalSR = dataLayer.countProduct();
            if (totalSR == 0)
            {
                return ID + "1";
            }
            else
                return ID + (totalSR + 1).ToString();
        }

        public string makeRequestID()
        {
            string ID = "SR00";
            int IDnum = dataLayer.selectStockRequests();
            if (IDnum == 0)
            {
                return ID + "1";
            }
            else
                return ID + (IDnum + 1).ToString();
        }

        public void submitStockRequest(string id, int quantity, string desciprion)
        {
            dataLayer.requestStock(quantity, id, desciprion, currentStaff.StaffID);
        }

        public void submitStockRequestDetails(string srID, string productID, string productName, int quantity)
        {
            dataLayer.sumbitStockDetials(srID, productID, productName, quantity);
        }

        public void ProcessPurchase(string cardNo, string customerID, string name, string cardType, int expiryMonth, int expiryYear) {
            dataLayer.ProcessPurchase(cardNo, customerID, name, cardType, expiryMonth, expiryYear);
        }

        public string makeLoginID()
        {
            string ID = "LG00";
            int IDnum = dataLayer.selectLoginLogs();
            if (IDnum == 0)
            {
                return ID + "1";
            }
            else
                return ID + (IDnum + 1).ToString();
        }

        public void recordLogin(string loginID)
        {
            dataLayer.recordLogin(loginID, currentStaff.StaffID);
        }

        public void recordLogout(string loginID)
        {
            dataLayer.recordLogout(loginID);
        }

        public List<IQueries> getAllQueries()
        {
            return dataLayer.getAllQueries();
        }

        public IQueries getQueryByID(string ticketID)
        {
            return dataLayer.getQueryByID(ticketID);
        }

        public ICustomer getCustomerByID(string customerID)
        {
            return dataLayer.getCustomerByID(customerID);
        }

        public bool replyToQuery(string ticketID, string reply)
        {
            if (dataLayer.replyToQuery(ticketID, reply))
                return true;
            else
                return false;
        }

        public bool checkForEmails(string email)
        {
            foreach(Staff aStaff in staffList)
            {
                if(aStaff.Email == email)
                {
                    return true;
                }
            }
            foreach(Customer aCustomer in customerList)
            {
                if(aCustomer.Email == email)
                {
                    return true;
                }
            }
            return false;
        }

        public string makeCustomerID()
        {
            string ID = "C00";
            int IDnum = dataLayer.selectCustomers();
            if(IDnum == 0)
            {
                return ID + "1";
            }
            else
                return ID + (IDnum + 1).ToString();
        }

        public string ComputeSha256Hash(string plainData)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(plainData));

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        public bool validateEmail(string email)
        {
            if (email.Trim().EndsWith("."))
            {
                return false;
            }
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
        
        public bool validateForm(string password, string conPassword, string email )
        {
            if (password != conPassword)
            {
                MessageBox.Show("The passwords dont match");
                return false;
            }
            else if (checkForEmails(email))
            {
                MessageBox.Show("This email already exists. Please choose a different one");
                return false;
            }
            else if (!validateEmail(email))
            {
                MessageBox.Show("This is an invalid email");
                return false;
            }
            else
                return true;
        }

        public bool registerCustomer(string firstName, string lastName, string email, string password, string address, string city, string county, string eircode, string mobile)
        {
            string customerID = makeCustomerID();
            if (dataLayer.registerCustomer(customerID, firstName, lastName, email, password, address, city, county, eircode, mobile))
            {
                return true;
            }
            else
                return false;
        }

        public void editCustomerDetails(string id,string address, string number,string email,string city,string county,string eircode)
        {
            dataLayer.editCustomerDetails(id,  address, number,email,city,county,eircode);
        }
        public void editStaffDetails(string staffID, string firstName, string lastName, string staffType, string email, string password, int mobile)
        {
            dataLayer.editStaffDetails(staffID, firstName, lastName, staffType, email, password, mobile);
        }
        public void deleteStaff(string staffID)
        {
            dataLayer.deleteStaff(staffID);
        }

        public void addStaffDetails(string staffID, string firstName, string lastName, string staffType, string email, string password, int mobile)
        {
            dataLayer.addStaffDetails(staffID, firstName, lastName, staffType, email, password, mobile);
        }

        public string makeOrderID()
        {
            string ID = "O00";
            int total = dataLayer.getOrderCount();
            if (total == 0)
                return ID + "1";
            else
                return ID + (total + 10).ToString();
        }

        public void AddOrder(string orderID, string customerID, int quantity) {
            dataLayer.addOrder(orderID, customerID, quantity);
        }

        public void addOrderDetails(string detailsID, string orderID, string productID, string productName, int productQuantity, double productPrice, int productStoreQuantity)
        {
            dataLayer.addOrderDetails(detailsID, orderID, productID, productName, productQuantity, productPrice, productStoreQuantity);
        }

        public int getProductStoreQuantityByID(string productID)
        {
            return dataLayer.getProductStoreQuantityByID(productID);
        }

        public int getOrderDetailsCount() {
            return dataLayer.getOrderDetailsCount();
        }

        public void applyForLoyaltyCard(string customerID)
        {
            string id = generateLoyaltyCardID();
            dataLayer.applyForLoyaltyCard(customerID,id);
        }

        public string generateLoyaltyCardID()
        {
            string ID = "L00";
            int IDnum = dataLayer.countLoyaltyCards();
            if (IDnum == 0)
            {
                return ID + "1";
            }
            else
                return ID + (IDnum + 1).ToString();
        }

        public int getStaffCount()
        {
            return dataLayer.getStaffCount();
        }
        public double getTotalEarnings()
        {
            return dataLayer.getTotalEarnings();
        }

        public int getOrderCount()
        {
            return dataLayer.getOrderCount();
        }
        public void addManager(string staffID, string firstName, string lastName, string email, string password, string mobile)
        {
            dataLayer.addManager(staffID, firstName, lastName, email, password, mobile);
        }
        public void updateManager(string staffID, string firstName, string lastName, string email, string password, string mobile)
        {
            dataLayer.updateManager(staffID, firstName, lastName, email, password, mobile);
        }
        public void deleteManager(string managerID)
        {
            dataLayer.deleteManager(managerID);
        }

        public string makeStaffID()
        {
            string ID = "S00";
            int IDnum = dataLayer.getAllStaffCount();
            if (IDnum == 0)
            {
                return ID + "1";
            }
            else
                return ID + (IDnum + 1).ToString();
        }

        public IStaff getManagerByID(string id)
        {
            return dataLayer.getManagerByID(id);
        }

        public string makeTicketID()
        {
            string id = "Q00";
            int IDnum = dataLayer.countTickets();
            if (IDnum == 0)
            {
                return id + "1";
            }
            else
                return id + (IDnum + 1).ToString();
                
        }

        public void CustomerSupport(string topic,string description,string custID)
        {
            string queryID = makeTicketID();
            dataLayer.MakeTicket(queryID, topic, description,custID);
        }

        public void addDiscountDetails(string discountID, string discountCode, int discountPercentage, DateTime startDate, DateTime endDate, string productType)
        {
            dataLayer.addDiscountDetails(discountID, discountCode, discountPercentage, startDate, endDate, productType);
        }

        public void updateDiscountDetails(string discountID, string discountCode, int discountPercentage, DateTime startDate, DateTime endDate, string productType)
        {
            dataLayer.updateDiscountDetails(discountID, discountCode, discountPercentage, startDate, endDate, productType);
        }

        public void deleteDiscountDetails(string discountID)
        {
            dataLayer.deleteDiscountDetails(discountID);
        }

        public IDiscount getDiscountDetailsByID(string id)
        {
            return dataLayer.getDiscountDetailsByID(id);
        }
        public string makeDiscountID()
        {
            return (dataLayer.getDiscountDetailsCount() + 1).ToString();
        }

        public void resetPassword(string newPassword,string customerID)
        {
            dataLayer.resetPassword(newPassword, customerID);
        }

        public List<ICardDetails> getCardDetailsByCustomerID(string customerID)
        {
            return dataLayer.getCardDetailsByCustomerID(customerID);
        }
        public double priceOfOrders(string orderID)
        {
            return dataLayer.priceOfOrders( orderID);
        }

        public void addWishListItem(string customerID, string productID, string productName, double price, string productType)
        {
            dataLayer.addWishListItem(customerID, productID, productName, price, productType);
        }

        public void deleteWishListItem(string customerID, string productID)
        {
            dataLayer.deleteWishListItem(customerID, productID);
        }

        public void clearWishList(string customerID)
        {
            dataLayer.clearWishList(customerID);
        }

        public List<IWishlist> getWishListItemByCustomerID(string customerID)
        {
            return dataLayer.getWishListItemByCustomerID(customerID);
        }

        public void addItemToCart(string productID, string productName, double productPrice, int quantity, string customerID, string productType) {
            dataLayer.addItemToCart(productID, productName, productPrice, quantity, customerID, productType);
        }
        public void removeItemFromCart(string productID, string customerID){
            dataLayer.removeItemFromCart(productID, customerID);
        }
        public List<ICart> getCartByCustomerID(string customerID){
            return dataLayer.getCartByCustomerID(customerID);
        }

        public void clearCart(string customerID)
        {
            dataLayer.clearCart(customerID);
        }

        public void addQuantityToCart(int quantity, string productID, string customerID)
        {
            dataLayer.addQuantityToCart(quantity, productID, customerID);
        }

        public List<IDiscount> getValidDiscounts()
        {
            return dataLayer.getValidDiscounts();
        }

        public Boolean completeQuery(string ticketID)
        {
            try
            {
                dataLayer.completeQuery(ticketID);
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }

        public void redeemedDiscount(string discountCode, string customerID, DateTime redeemedDate)
        {
            dataLayer.redeemedDiscount(discountCode, customerID, redeemedDate);
        }

        public List<IRedeemedDiscount> getRedeemedDiscountByCustomerID(string customerID)
        {
            return dataLayer.getRedeemedDiscountByCustomerID(customerID);
        }
        public void priceDiscountInCart(double price, string productID, string customerID)
        {
            dataLayer.priceDiscountInCart(price, productID, customerID);
        }

        public void promotionalEmail(string subject, string title, string body, string coupon, List<ICustomer> custList, string loyal)
        {
            string html = Emailing.getPromoEmailStructure(title, body, coupon);
            foreach (ICustomer aCustomer in custList)
            {
                Emailing.sendPromoEmail(aCustomer.Email, subject, html);
            }
        }
        
        public void cancelOrderEmail()
        {

        }
    }
}
