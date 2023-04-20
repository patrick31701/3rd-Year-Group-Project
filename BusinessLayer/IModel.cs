using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BusinessEntities;

namespace BusinessLayer
{
    public interface IModel
    {
        BusinessEntities.IStaff CurrentStaff { get; set; }
        BusinessEntities.ICustomer CurrentCustomer { get; set; }
        DataAccessLayer.IDataLayer DataLayer { get; set; }
        List<IStaff> StaffList { get; }
        List<ICustomer> CustomerList { get; }
        List<IProduct> ProductList { get; }
        List<IStock_Requests> StockRequestList { get; }
        List<IStock_Request_Details> StockRequestDetailsList { get; }
        List<IDiscount> DiscountList { get; }
        void tearDown();
        List<IOrder> getAllOrders();
        bool staffLogin(string email, string password);
        bool customerLogin(string email, string password);
        String getUserTypeForCurrentStaff();
        IProduct getProductByID(string productID);
        IOrder getOrderByID(string orderID);
        double getPriceOfOrder(string orderID);
        List<IOrderDetails> getOrderDetails(string orderID);
        ICustomer getCustomerOfOrder(string custID);
        bool checkIfEnoughStock(List<IOrderDetails> detailsList);
        void confirmOrder(string orderID);
        void deleteOrder(string orderID);
        
        string makeRequestID();
        void submitStockRequest(string id, int quantity, string desciprion);
        void submitStockRequestDetails(string srID, string productID, string productName, int quantity);
        void deleteRequest(string sdetailsID);
        string makeLoginID();
        void recordLogin(string loginID);
        void recordLogout(string loginID);
        bool replyToQuery(string ticketID, string reply);
        ICustomer getCustomerByID(string customerID);
        IQueries getQueryByID(string ticketID);
        List<IQueries> getAllQueries();
        void deleteProduct(string productID);
        void addProduct(string productName, int quantity, double price, string descrpiton, string productType);
        bool checkForEmails(string email);
        void ProcessPurchase(string cardNo, string customerID, string name, string cardType, int expiryMonth, int expiryYear);
        void editProduct(string productID, string productName, int quantity, double price, string descrpiton, string productType);
        void editCustomerDetails(string id,  string address, string number,string email,string city,string county,string eircode);
        string ComputeSha256Hash(string plainData);
        bool validateEmail(string email);
        bool validateForm(string password, string conPassword, string email);
        bool registerCustomer(string firstName, string lastName, string email, string password, string address, string city, string county, string eircode, string mobile);
        void editStaffDetails(string staffID, string firstName, string lastName, string staffType, string email, string password, int mobile);
        void deleteStaff(string staffID);
        void addStaffDetails(string staffID, string firstName, string lastName, string staffType, string email, string password, int mobile);
        void AddOrder(string orderID, string customerID, int quantity);
        string makeOrderID();
        void addOrderDetails(string detailsID, string orderID, string productID, string productName, int productQuantity, double productPrice, int productStoreQuantity);
        int getProductStoreQuantityByID(string productID);
        int getOrderDetailsCount();
        void applyForLoyaltyCard(string customerID);
        string generateLoyaltyCardID();
        int getStaffCount();
        double getTotalEarnings();
        int getOrderCount();
        List<IStaff> ManagerList { get; }
        void addManager(string staffID, string firstName, string lastName, string email, string password, string mobile);
        void updateManager(string staffID, string firstName, string lastName, string email, string password, string mobile);
        void deleteManager(string managerID);
        string makeStaffID();
        IStaff getManagerByID(string id);
        void CustomerSupport(string topic, string description, string custID);
        string makeTicketID();
        void addDiscountDetails(string discountID, string discountCode, int discountPercentage, DateTime startDate, DateTime endDate, string productType);
        void updateDiscountDetails(string discountID, string discountCode, int discountPercentage, DateTime startDate, DateTime endDate, string productType);
        void deleteDiscountDetails(string discountID);
        IDiscount getDiscountDetailsByID(string discountID);
        string makeDiscountID();
        void resetPassword(string newPassword, string customerID);
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

        Boolean completeQuery(string ticketID);
        void promotionalEmail(string subject, string title, string body, string coupon, List<ICustomer> custList, string loyal);


        void redeemedDiscount(string discountCode, string customerID, DateTime redeemedDate);

        List<IRedeemedDiscount> getRedeemedDiscountByCustomerID(string customerID);
        void priceDiscountInCart(double price, string productID, string customerID);

    }
}
