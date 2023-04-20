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
    public partial class Customer_Dashboard : Form
    {
        #region Instance Attributes
        private User_Login ULogin;
        private IModel Model;
        #endregion
        #region Constructors
        public Customer_Dashboard(User_Login customer, IModel Model)
        {
            InitializeComponent();
            ULogin = customer;
            this.Model = Model;
            displayProducts();
            lblWelcome.Text = "Welcome, " + Model.CurrentCustomer.FirstName;
            

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

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            this.Hide();
            var profileDashboard = new Customer_Display_And_Edit_Info(ULogin,Model);
            profileDashboard.Closed += (s, args) => this.Close();
            profileDashboard.Show();
        }

        private void displayProducts()
        {
            foreach (Product aProduct in Model.ProductList)
            {
                    LvProductInfo.Items.Add(new ListViewItem(new string[] {
                    aProduct.ProductName,
                    aProduct.Price.ToString(),
                    aProduct.ProductID,
                    aProduct.ProductType
                }));
                

            }


        }

        private void cbProdMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            LvProductInfo.Items.Clear();
            foreach (Product aProduct in Model.ProductList)
            {
                if (cbProdMenu.SelectedItem == "Bakery" && aProduct.ProductType == "BKRY")
                {
                   
                    LvProductInfo.Items.Add(new ListViewItem(new string[] {
                    aProduct.ProductName,
                   
                    aProduct.Price.ToString(),
                    aProduct.ProductID,
                    aProduct.ProductType

                }));
                }
               else if (cbProdMenu.SelectedItem == "Fresh Produce" && aProduct.ProductType == "DAIRY")
                {

                    LvProductInfo.Items.Add(new ListViewItem(new string[] {
                    aProduct.ProductName,

                    aProduct.Price.ToString(),
                    aProduct.ProductID,
                    aProduct.ProductType


                }));
                }
                else if (cbProdMenu.SelectedItem == "Meat" && aProduct.ProductType == "MEAT")
                {

                    LvProductInfo.Items.Add(new ListViewItem(new string[] {
                    aProduct.ProductName,

                    aProduct.Price.ToString(),
                    aProduct.ProductID,
                    aProduct.ProductType

                }));
                }
                else if (cbProdMenu.SelectedItem == "Drinks" && aProduct.ProductType == "DRINK")
                {

                    LvProductInfo.Items.Add(new ListViewItem(new string[] {
                    aProduct.ProductName,

                    aProduct.Price.ToString(),
                    aProduct.ProductID,
                    aProduct.ProductType

                }));
                }
                else if (cbProdMenu.SelectedItem == "Baby Products" && aProduct.ProductType == "BPROD")
                { 
                

                    LvProductInfo.Items.Add(new ListViewItem(new string[] {
                    aProduct.ProductName,

                    aProduct.Price.ToString(),
                    aProduct.ProductID,
                    aProduct.ProductType

                }));
                }
            }
        }

        private void btnAddCart_Click(object sender, EventArgs e)
        {
            if (LvProductInfo.SelectedItems.Count > 0)
            {
                ListViewItem item = LvProductInfo.SelectedItems[0];
                
                if (quantity.Text == "")
                {
                    MessageBox.Show("Please enter the quantity needed!", "Warning");
                }
                else if (int.Parse(quantity.Text) > Model.getProductByID(item.SubItems[2].Text).Quantity)
                {
                    MessageBox.Show("Sorry! We don't have enough stock at the moment!", "Warning");
                }
                else
                {
                    //if (Model.getCartByCustomerID(Model.CurrentCustomer.CustomerID).Count > 0)
                    //{
                        List<ICart> cart = Model.getCartByCustomerID(Model.CurrentCustomer.CustomerID);
                        List<string> items = new List<string>();
                        foreach (ICart cItem in cart)
                        {
                        items.Add(cItem.productID);
                        }

                    var match = items.FirstOrDefault(stringToCheck => stringToCheck.Contains(item.SubItems[2].Text));
                    if (match!=null)
                    {
                        Model.addQuantityToCart(int.Parse(quantity.Text), item.SubItems[2].Text, Model.CurrentCustomer.CustomerID);
                    }
                    else
                    {
                        Model.addItemToCart(item.SubItems[2].Text, item.SubItems[0].Text, double.Parse(item.SubItems[1].Text), int.Parse(quantity.Text), Model.CurrentCustomer.CustomerID, item.SubItems[3].Text);
                    }

                }
            }
            else {
                MessageBox.Show("No item is selected!", "Warning");
            }

            
        }
        private void btnViewCart_Click(object sender, EventArgs e)
        {
            Customer_View_Cart viewCart = new Customer_View_Cart(ULogin, this.Model);
            this.Close();
            viewCart.Show();
        }



        private void btnCustomerSupport_Click(object sender, EventArgs e)
        {
            Customer_CustomerSupport x = new Customer_CustomerSupport(this.Model);
            this.Close();
            x.Show();
        }

        private void btnRegLoyaltyCard_Click(object sender, EventArgs e)
        {
            Apply_For_Loyalty_Card x = new Apply_For_Loyalty_Card(this.Model);
            this.Close();
            x.Show();
        }

        private void ViewProductDetails(object sender, EventArgs e)
        {
            string prodID = "";
            foreach (ListViewItem x in LvProductInfo.SelectedItems)
            {
                prodID = x.SubItems[2].Text;
            }
            
            IProduct product = Model.getProductByID(prodID);
            View_Product_Details y = new View_Product_Details(product);
            y.Show();
        }


        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            Customer_Reset_Password x = new Customer_Reset_Password(this.Model);
            this.Close();
            x.Show();
        }

        private void btnWishlist_Click(object sender, EventArgs e)
        {
            if (LvProductInfo.SelectedItems.Count > 0)
            {
                ListViewItem item = LvProductInfo.SelectedItems[0];
                List<IWishlist> wishlist = Model.getWishListItemByCustomerID(Model.CurrentCustomer.CustomerID);
                List<string> pname = new List<string>();
                foreach (Wishlist wlitem in wishlist)
                {
                    pname.Add(wlitem.productName);
                }
                var match = pname.FirstOrDefault(stringToCheck => stringToCheck.Contains(item.SubItems[0].Text));
                if (match != null)
                {
                    MessageBox.Show("Items already available in wishlist", "Warning");
                }
                else
                {
                    Model.addWishListItem(Model.CurrentCustomer.CustomerID, item.SubItems[2].Text, item.SubItems[0].Text, double.Parse(item.SubItems[1].Text), item.SubItems[3].Text);

                }
            }

            else
            {
                MessageBox.Show("No Item is selected", "Warning");
            }

            
        }

        private void viewWishlist_Click(object sender, EventArgs e)
        {
            Customer_View_Wishlist wl = new Customer_View_Wishlist(ULogin, this.Model);
            this.Close();
            wl.Show();
        }
    }
}

