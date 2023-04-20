using MainProject.General_Manager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BusinessLayer;
using BusinessEntities;

namespace MainProject
{
    public partial class Manager_Dashboard : Form
    {
        #region Instance Attributes
        private User_Login ULogin;
        private IModel Model;
        string logID;
        public string oID;
        public string cID;
        #endregion
        #region Constructors
        public Manager_Dashboard(User_Login staff, IModel Model, string loginID)
        {
            InitializeComponent();
            ULogin = staff;
            this.Model = Model;
            logID = loginID;
            Display();
        }
        #endregion
        private void btnLogout_Click(object sender, EventArgs e)
        {
            Model.CurrentCustomer = null;
            User_Login login = new User_Login(Model);
            this.Hide();
            login.ShowDialog();
            this.Close();
        }

        private void lblNumStockOrders_Click(object sender, EventArgs e)
        {

        }

        private void Manager_Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void btnStockOrders_Click(object sender, EventArgs e)
        {
            GM_StockOrders orderReview = new GM_StockOrders(this, Model);
            orderReview.Show();
            this.Close();
        }

        private void btnProductDetails_Click(object sender, EventArgs e)
        {
            this.Hide();
            var productDetails = new GMManage_ProductDetails(Model, logID);
            productDetails.Closed += (s, args) => this.Close();
            productDetails.Show();
        }

        private void btnStaffDetails_Click(object sender, EventArgs e)
        {
            GMManage_StaffDetails editStaffDetails = new GMManage_StaffDetails(this, Model);
            editStaffDetails.Show();
            this.Close();
        }

        private void btnPurchaseHistory_Click(object sender, EventArgs e)
        {
            GMView_PurchaseHistory ViewPurchaseHistory = new GMView_PurchaseHistory(this, Model,oID);
            ViewPurchaseHistory.Show();
            this.Close();

           

        }

        private void btnManageMarketingDetails_Click(object sender, EventArgs e)
        {

        }

        private void Display()
        {
            int numofstaff = 0;
            foreach (Staff staff in Model.StaffList)
            {
                if (staff.StaffType != "OWNER")
                {
                    numofstaff++;
                }
            }
            txtNoOfStaff.Text = numofstaff.ToString();
        
       
            int numOfCustomers = 0;
            foreach (Customer cust in Model.CustomerList)
            {

                numOfCustomers++;

            }
            txtNoOfCustomers.Text = numOfCustomers.ToString();

            int numOfProducts = 0;
            foreach (Customer cust in Model.CustomerList)
            {
                numOfProducts++;
            }
            txtNoOfProducts.Text = numOfProducts.ToString();

            int num;
            num = Model.getAllOrders().Count;
            txtNoOfStockOrders.Text = num.ToString();
        
        }

        private void btnMessages_Click(object sender, EventArgs e)
        {
            Messaging messaging = new Messaging(logID, Model);
            messaging.Show();
            this.Hide();
        }

        private void btnEmail_Click(object sender, EventArgs e)
        {
            PromotionalEmail promoEmail = new PromotionalEmail(this, Model);
            promoEmail.ShowDialog();
            return;
        }

       

        private void gbDetails_Enter(object sender, EventArgs e)
        {

        }

        private void btnViewStaffDetails_Click(object sender, EventArgs e)
        {
            View_StaffDetails editStaffDetails = new View_StaffDetails(this, Model);
            editStaffDetails.Show();
            this.Close();
        }
    }
}
