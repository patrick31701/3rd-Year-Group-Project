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
    // Made by Jakub
    public partial class CSStaff_Dashboard : Form
    {
        #region Instance Attributes
        private User_Login ULogin;
        private IModel Model;
        string logID;
        #endregion Instance Attributes
        #region Constructors
        public CSStaff_Dashboard(User_Login staff, IModel Model, string loginID)
        {
            InitializeComponent();
            ULogin = staff;
            this.Model = Model;
            logID = loginID;
            lblWelcome.Text = "Welcome, " + Model.CurrentStaff.FirstName;
            DisplayProducts();
        }
        #endregion

        private void btnViewTickets_Click(object sender, EventArgs e)
        {
            CSStaff_ViewCustomerTickets tickets = new CSStaff_ViewCustomerTickets(this, Model);
            tickets.ShowDialog();
            return;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Model.CurrentStaff = null;
            User_Login login = new User_Login(Model);
            this.Hide();
            login.ShowDialog();
            this.Close();
        }

        private void DisplayProducts()
        {
            foreach (Product aProduct in Model.ProductList)
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
            foreach (ListViewItem x in lvProducts.SelectedItems)
            {
                prodID = x.SubItems[1].Text;
            }
            IProduct product = Model.getProductByID(prodID);
            View_Product_Details view = new View_Product_Details(product);
            view.ShowDialog();
        }

        private void changeProducts(object sender, EventArgs e)
        {
            lvProducts.Items.Clear();
            switch (cbProdMenu.SelectedItem)
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
