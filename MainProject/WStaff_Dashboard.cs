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
using DataAccessLayer;
using MainProject.General_Manager;

namespace MainProject
{   
    //Made by Jakub
    public partial class WStaff_Dashboard : Form
    {
        #region Instance Attributes
        private IModel Model;
        string logID;
        #endregion
        #region Constructors
        public WStaff_Dashboard(User_Login Ulogin, IModel Model, string loginID)
        {
            InitializeComponent();
            this.Model = Model;
            lblWelcome.Text = "Welcome, " + Model.CurrentStaff.FirstName + " " + Model.CurrentStaff.LastName;
            logID = loginID;
            DisplayProducts();
        }
        #endregion

        private void btnOnlineOrders_Click(object sender, EventArgs e)
        {
            WStaff_ViewOnlineOrders orders = new WStaff_ViewOnlineOrders(Model, this);
            orders.ShowDialog();
            return;
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            Model.recordLogout(logID);
            Model.CurrentStaff = null;
            User_Login login = new User_Login(Model);
            this.Hide();
            login.ShowDialog();
            this.Close();
        }
        private void DisplayProducts()
        {
            foreach(IProduct aProduct in Model.ProductList)
            {
                lvProducts.Items.Add(new ListViewItem(new string[]
                {
                    aProduct.ProductName,
                    aProduct.ProductID,
                    aProduct.Price.ToString(),
                    aProduct.Quantity.ToString()
                }));
            }
        }

        private void view_product_details(object sender, EventArgs e)
        {
            string prodID = "";
            foreach(ListViewItem x in lvProducts.SelectedItems)
            {
                prodID = x.SubItems[1].Text;
            }
            IProduct product = Model.getProductByID(prodID);
            View_Product_Details view = new View_Product_Details(product);
            view.ShowDialog();
        }

        private void btnRequestStock_Click(object sender, EventArgs e)
        {
            WStaff_StockRequest orders = new WStaff_StockRequest(Model, this);
            orders.ShowDialog();
            return;
        }

        private void lvProducts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Messaging_Click(object sender, EventArgs e)
        {
            Messaging messaging = new Messaging(this, Model);
            messaging.Show();
        }

        private void changeProducts(object sender, EventArgs e)
        {
            lvProducts.Items.Clear();
            switch(cbProdMenu.SelectedItem)
            {
                case "All":
                    foreach (IProduct aProduct in Model.ProductList)
                    {
                        lvProducts.Items.Add(new ListViewItem(new string[]
                        {
                            aProduct.ProductName,
                            aProduct.ProductID,
                            aProduct.Price.ToString(),
                            aProduct.Quantity.ToString()
                        }));
                    }
                    break;
                case "Fresh Bakery":
                    foreach (IProduct aProduct in Model.ProductList)
                    {
                        if (aProduct.ProductType == "BKRY")
                        {
                            lvProducts.Items.Add(new ListViewItem(new string[]
                            {
                            aProduct.ProductName,
                            aProduct.ProductID,
                            aProduct.Price.ToString(),
                            aProduct.Quantity.ToString()
                            }));
                        }
                    }
                    break;
                case "Meat":
                    foreach (IProduct aProduct in Model.ProductList)
                    {
                        if (aProduct.ProductType == "MEAT")
                        {
                            lvProducts.Items.Add(new ListViewItem(new string[]
                            {
                            aProduct.ProductName,
                            aProduct.ProductID,
                            aProduct.Price.ToString(),
                            aProduct.Quantity.ToString()
                            }));
                        }
                    }
                    break;
                case "Drinks":
                    foreach (IProduct aProduct in Model.ProductList)
                    {
                        if (aProduct.ProductType == "DRINK")
                        {
                            lvProducts.Items.Add(new ListViewItem(new string[]
                            {
                            aProduct.ProductName,
                            aProduct.ProductID,
                            aProduct.Price.ToString(),
                            aProduct.Quantity.ToString()
                            }));
                        }
                    }
                    break;
                case "Dairy":
                    foreach (IProduct aProduct in Model.ProductList)
                    {
                        if (aProduct.ProductType == "DAIRY")
                        {
                            lvProducts.Items.Add(new ListViewItem(new string[]
                            {
                            aProduct.ProductName,
                            aProduct.ProductID,
                            aProduct.Price.ToString(),
                            aProduct.Quantity.ToString()
                            }));
                        }
                    }
                    break;
                case "Baby Products":
                    foreach (IProduct aProduct in Model.ProductList)
                    {
                        if (aProduct.ProductType == "BPROD")
                        {
                            lvProducts.Items.Add(new ListViewItem(new string[]
                            {
                            aProduct.ProductName,
                            aProduct.ProductID,
                            aProduct.Price.ToString(),
                            aProduct.Quantity.ToString()
                            }));
                        }
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
