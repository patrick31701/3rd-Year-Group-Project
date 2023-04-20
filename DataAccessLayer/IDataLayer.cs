using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BusinessEntities;

namespace DataAccessLayer
{
    public interface IDataLayer
    {
        void OpenConnection();
        void CloseConnection();
        List<IStaff> getAllStaff();
        List<ICustomer> getAllCustomer();
        List<IProduct> getAllProduct();
        List<IOrder> getAllOrders();
        List<IStock_Requests> getAllRequests();
        List<IStock_Request_Details> getAllRequestDetails();
        List<IDiscount> getAllDiscountDetails();
        System.Data.SqlClient.SqlConnection GetConnection();
        IProduct getProductByID(string productID);
        IOrder getOrderByID(string orderID);
        double getPriceOfOrder(string orderID);
        List<IOrderDetails> getOrderDetails(string orderID);
        ICustomer getCustomerOfOrder(string custID);
        void confirmOrder(string orderID);
        void deleteOrderDetails(string orderID);
        void deleteOrder(string orderID);
        int selectStockRequests();
        void requestStock(int quantity, string srID, string description, string staffID);
        void sumbitStockDetials(string srID, string productID, string productName, int productQuantity);
        int selectLoginLogs();
        void deleteRequestDetails(string sdetailsID);
        void deleteRequest(string sdetailsID);
        int countLoginLogs();
        void recordLogin(string loginID, string staffID);
        void recordLogout(string loginID);
        List<IQueries> getAllQueries();
        IQueries getQueryByID(string ticketID);
        ICustomer getCustomerByID(string customerID);
        bool replyToQuery(string ticketID, string reply);
        void deleteProduct(string productID);
        void addProduct(string productID,string productName, int quantity, double price, string descrpiton, string productType);
        int countProduct();
        int selectCustomers();
        bool registerCustomer(string customerID, string firstName, string lastName, string email, string password, string address, string city, string county, string eircode, string mobile);
        void ProcessPurchase(string cardNo, string customerID, string name, string cardType, int expiryMonth, int expiryYear);
        void editProduct(string productName, string productID, int quantity, double price, string descrpiton, string productType);
        void editCustomerDetails(string id,  string address, string number,string email,string city,string county,string eircode);
        void editStaffDetails(string staffID, string firstName, string lastName, string staffType, string email, string password, int mobile);
        void deleteStaff(string staffID);
        void addStaffDetails(string staffID, string firstName, string lastName, string staffType, string email, string password, int mobile);
        void addOrder(string id, string customerID, int quantity);
        int getOrderCount();
        void addOrderDetails(string detailsID, string orderID, string productID, string productName, int productQuantity,double productPrice, int productStoreQuantity);
        int getProductStoreQuantityByID(string productID);
        int getOrderDetailsCount();
        void applyForLoyaltyCard(string customerID,string loyaltyID);
        int countLoyaltyCards();
        int getStaffCount();
        double getTotalEarnings();

        List<IStaff> getAllManager();
        void addManager(string staffID, string firstName, string lastName, string email, string password, string mobile);
        void updateManager(string staffID, string firstName, string lastName, string email, string password, string mobile);
        void deleteManager(string managerID);
        int getAllStaffCount();
        IStaff getManagerByID(string id);
        int countTickets();
        void MakeTicket(string id, string topic, string description,string custID);
        void addDiscountDetails(string discountID, string discountCode, int discountPercentage, DateTime startDate, DateTime endDate, string productType);
        void updateDiscountDetails(string discountID, string discountCode, int discountPercentage, DateTime startDate, DateTime endDate, string productType);

        void deleteDiscountDetails(string discountID);
        IDiscount getDiscountDetailsByID(string discountID);
        int getDiscountDetailsCount();
        void resetPassword(string newPassword, string customerID);
        Dictionary<string, int> getOrderProducts(string oID);
        void updateProducts(string productID, int productQuantity);
        List<ICardDetails> getCardDetailsByCustomerID(string customerID);
        double priceOfOrders(string orderID);

        void addWishListItem(string customerID, string productID, string productName, double price, string productType);
        void deleteWishListItem(string customerID, string productID);
        void clearWishList(string customerID);
        List<IWishlist> getWishListItemByCustomerID(string customerID);
        void addItemToCart(string productID, string productName, double productPrice, int quantity, string customerID, string productType);
        void removeItemFromCart(string productID, string customerID);
        List<ICart> getCartByCustomerID(string customerID);
        void clearCart(string customerID);
        void addQuantityToCart(int quantity, string productID, string customerID);
        List<IDiscount> getValidDiscounts();
        void completeQuery(string ticketID);
        void redeemedDiscount(string discountCode, string customerID, DateTime redeemedDate);
        List<IRedeemedDiscount> getRedeemedDiscountByCustomerID(string customerID);
        void priceDiscountInCart(double price, string productID, string customerID);

    }
}
