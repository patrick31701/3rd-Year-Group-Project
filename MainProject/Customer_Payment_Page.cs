using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


using BusinessEntities;
using BusinessLayer;

namespace MainProject
{
    public partial class Customer_Payment_Page : Form
    {
        #region Instance Attributes
        private User_Login ULogin;
        private IModel Model;
        public List<ICardDetails> cardDetails;
        #endregion
        string[] month = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" };
        string[] year = { "2021", "2022", "2023", "2024", "2025", "2026", "2027" };
        string[] cType = { "Visa", "MasterCard", "American Express" };
        public Customer_Payment_Page(User_Login customer, IModel Model)
        {
            this.Model = Model;
            ULogin = customer;

            this.cardDetails = Model.getCardDetailsByCustomerID(Model.CurrentCustomer.CustomerID);
            var source = new AutoCompleteStringCollection();
            string[] cardNumber = new string[20];
            for (int i = 0; i < cardDetails.Count; i++)
            {
                cardNumber[i] = cardDetails[i].cardNumber;
            }
            source.AddRange(cardNumber);
            InitializeComponent();
            foreach (string m in month) {
                monthBox.Items.Add(m);
            }

            foreach (string y in year) {
                yearBox.Items.Add(y);
            }

            foreach (string c in cType)
            {
                cardType.Items.Add(c);
            }
        }
        bool IsCreditCardInfoValid(string cardNo, string cvv)
        {
            var cardCheck = new Regex(@"^([\-\s]?[0-9]{4}){4}$");
            var cvvCheck = new Regex(@"^\d{3}$");

            if (!cardCheck.IsMatch(cardNo)) // <1>check card number is valid
                return false;
            if (!cvvCheck.IsMatch(cvv)) // <2>check cvv is valid as "999"
                return false;

            return true;

        }

        private void btnProcessPurchase_Click(object sender, EventArgs e)
        {
            List<ICart> cartlist = Model.getCartByCustomerID(Model.CurrentCustomer.CustomerID);
            int totalQuantity = 0;

            string newOrderID = Model.makeOrderID();
            if (IsCreditCardInfoValid(cardNo.Text, cvv.Text))
            {
                if (saveCardCheckBox.Checked) {
                    Model.ProcessPurchase(cardNo.Text, Model.CurrentCustomer.CustomerID, name.Text, cardType.Text, int.Parse(monthBox.Text), int.Parse(yearBox.Text));
                }
                foreach (Cart cItem in cartlist)
                {
                    totalQuantity += cItem.quantity;
                    int orderDetailsCount = Model.getOrderDetailsCount() + 10;
                    int productStoreQuantity = Model.getProductStoreQuantityByID(cItem.productID);
                    Model.addOrderDetails(orderDetailsCount.ToString(), newOrderID, cItem.productID, cItem.productName, cItem.quantity, cItem.productPrice, productStoreQuantity);
                }
                Model.AddOrder(newOrderID, Model.CurrentCustomer.CustomerID, totalQuantity);
                Model.clearCart(Model.CurrentCustomer.CustomerID);
                MessageBox.Show("Successfully Purchase! Return you to home page!");
                this.Close();
                Customer_Dashboard dashboard = new Customer_Dashboard(ULogin, this.Model);
                dashboard.Show();
            }
            else {
                MessageBox.Show("Invalid input! Please try again! ", "Error");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Customer_Checkout_Shipping checkout = new Customer_Checkout_Shipping(ULogin, this.Model);
            checkout.Show();

        }
    }
}
