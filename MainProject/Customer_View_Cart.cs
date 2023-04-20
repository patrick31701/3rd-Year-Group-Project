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
    public partial class Customer_View_Cart : Form
    {
        #region Instance Attributes
        private User_Login ULogin;
        private IModel Model;
        #endregion
        #region Constructors
        public Customer_View_Cart(User_Login customer, IModel Model)
        {
            InitializeComponent();
            ULogin = customer;
            this.Model = Model;
            if (Model.getCartByCustomerID(Model.CurrentCustomer.CustomerID) != null)
            {
                lblEmpty.Text = "Cart";
            }
            displayproducts();
            
        }
        #endregion
        
        private void displayproducts()
        {
            List<ICart> cartlist = Model.getCartByCustomerID(Model.CurrentCustomer.CustomerID);
            foreach (Cart cItem in cartlist) {
                ListViewItem newitem = new ListViewItem(cItem.productName);
                newitem.SubItems.Add(cItem.quantity.ToString());
                newitem.SubItems.Add((cItem.productPrice * cItem.quantity).ToString());
                newitem.SubItems.Add(cItem.productType);
                cart.Items.Add(newitem);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Customer_Dashboard customer_Dashboard = new Customer_Dashboard(ULogin, this.Model);
            customer_Dashboard.Show();
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            List<ICart> cartlist = Model.getCartByCustomerID(Model.CurrentCustomer.CustomerID);
            if (cartlist.FirstOrDefault()!=null)
            {
                Customer_Checkout_Shipping checkout = new Customer_Checkout_Shipping(ULogin, this.Model);
                this.Close();
                checkout.Show();
            }
            else
            {
                MessageBox.Show("Cart is empty!", "Warning");
            }

        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            List<ICart> cartlist = Model.getCartByCustomerID(Model.CurrentCustomer.CustomerID);
            if (cart.Items.Count > 0)
            {    
                foreach (Cart cItem in cartlist)
                {
                    if (cart.SelectedItems.Count == 0)
                    {
                        MessageBox.Show("No item is selected!", "Warning");
                    }
                    else if (cart.SelectedItems[0].SubItems[0].Text == cItem.productName)
                    {
                        cart.Items.Remove(cart.SelectedItems[0]);
                        Model.removeItemFromCart(cItem.productID, Model.CurrentCustomer.CustomerID);
                        break;
                    }
                }
                
            }
            else {
                MessageBox.Show("The cart is empty", "Warning");
            }
        }

        private void btnClearCart_Click(object sender, EventArgs e)
        {
            if (cart.Items.Count > 0)
            {
                cart.Items.Clear();
                Model.clearCart(Model.CurrentCustomer.CustomerID);
            }
            else
            {
                MessageBox.Show("The cart is empty", "Warning");
            }

        }
    }
}
