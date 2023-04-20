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
    public partial class Customer_View_Wishlist : Form
    {
        #region Instance Attributes
        private User_Login ULogin;
        private IModel Model;
        List<IWishlist> wishlist = new List<IWishlist>();
        #endregion
        public Customer_View_Wishlist(User_Login customer, IModel Model)
        {
            ULogin = customer;
            this.Model = Model;
            InitializeComponent();
            wishlist = Model.getWishListItemByCustomerID(Model.CurrentCustomer.CustomerID);
            foreach (Wishlist items in wishlist)
            {
                listView1.Items.Add(new ListViewItem(new string[] { items.productID, items.productName,items.price.ToString(), items.productType}));
            }
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            
            if (listView1.Items.Count == 0)
            {
                MessageBox.Show("No item in wishlist!", "Warning");
            }
            else if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("No item is selected! ", "Warning");
            }
            else if (quantity.Text == "")
            {
                MessageBox.Show("Please specify the quantity needed! ", "Warning");
            }
            else
            {
                ListViewItem item = listView1.SelectedItems[0];
                Model.addItemToCart(item.SubItems[0].Text, item.SubItems[1].Text, double.Parse(item.SubItems[2].Text), int.Parse(quantity.Text), Model.CurrentCustomer.CustomerID, item.SubItems[3].Text);
                Model.deleteWishListItem(Model.CurrentCustomer.CustomerID, item.SubItems[2].Text);
                listView1.Items.Remove(item);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Customer_Dashboard c = new Customer_Dashboard(ULogin, this.Model);
            this.Close();
            c.Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count > 0)
            {
                Model.clearWishList(Model.CurrentCustomer.CustomerID);
                listView1.Items.Clear();
            }
            else
            {
                MessageBox.Show("No item in wishlist","Warning" );
            }
            
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count > 0)
            {
                if (listView1.SelectedItems.Count > 1)
                {
                    Model.deleteWishListItem(Model.CurrentCustomer.CustomerID, listView1.SelectedItems[0].SubItems[0].Text);
                    listView1.Items.Remove(listView1.SelectedItems[0]);
                }
                else
                {
                    MessageBox.Show("No item selected to remove", "Warning");
                }

            }
            else
            {
                MessageBox.Show("No item in wishlist", "Warning");
            }
        }
    }
}
