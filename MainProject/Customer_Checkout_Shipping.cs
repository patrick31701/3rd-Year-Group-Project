using BusinessLayer;
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
    public partial class Customer_Checkout_Shipping : Form
    {
        
        double subtotal = 0;
        double total = 0;
        int totalQuantity = 0;
        #region Instance Attributes
        private User_Login ULogin;
        private IModel Model;
        #endregion
        string[] cityArr = { "Dublin", "Cork", "Galway", "Limerick", "Waterford", "Drogheda", "Dún Dealgan", "Swords", "Blackrock", "Tralee", "Carlow", "Ennis", "Dunleary", "Kilkenny", "Naas", "Sligo", "Monaghan", "Ros Comáin", "Mullingar", "Tallaght", "Wicklow", "Clonmel", "Wexford", "Longford", "Trim", "Carrick on Shannon", "Tullamore", "Nenagh", "An Cabhán", "Port Laoise", "Castlebar", "Lifford" };
        public Customer_Checkout_Shipping(User_Login customer, IModel Model)
        {
            InitializeComponent();
            ULogin = customer;
            this.Model = Model;
            
            foreach (string city in cityArr) {
                cities.Items.Add(city);
            }
            displayproducts();
            lblSubtotal.Text = subtotal.ToString();
            lblShipping.Text = "7.5";
            total = subtotal + double.Parse(lblShipping.Text);
            lblTotal.Text = total.ToString();

        }


        private void displayproducts()
        {

            List<ICart> cartlist = Model.getCartByCustomerID(Model.CurrentCustomer.CustomerID);
            foreach (Cart cItem in cartlist)
            {
                ListViewItem newitem = new ListViewItem(cItem.productName);
                newitem.SubItems.Add(cItem.quantity.ToString());
                newitem.SubItems.Add((cItem.productPrice * cItem.quantity).ToString());
                newitem.SubItems.Add(cItem.productType);
                newitem.SubItems.Add(cItem.productID);
                cart.Items.Add(newitem);
                subtotal += double.Parse((cItem.productPrice * cItem.quantity).ToString());
                totalQuantity += cItem.quantity;
            }
        }

        private void btnPaymentMethod_Click(object sender, EventArgs e)
        {
            if (IsValidEmail(email.Text) && isNotNull())
            {
                Customer_Payment_Page paymentPage = new Customer_Payment_Page(ULogin, this.Model);
                this.Hide();
                paymentPage.Show();
            }
            else {
                MessageBox.Show("Please try again!", "Error");
            }

        }
        bool isNotNull()
        {
            if (!String.IsNullOrEmpty(email.Text) && !String.IsNullOrEmpty(addressLine1.Text))
            {
                return true;
            }

            else return false;
        }
        bool IsValidEmail(string email)
        {
            if (email.Trim().EndsWith("."))
            {
                return false; // suggested by @TK-421
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            Customer_View_Cart viewCart = new Customer_View_Cart(ULogin, this.Model);
            this.Close();
            viewCart.Show();
        }

        private void btnApplyDiscount_Click(object sender, EventArgs e)
        {
            List<IDiscount> discountList = Model.getValidDiscounts();

            List<string> discountCode = new List<string>();

            foreach (Discount d in discountList)
            {
                discountCode.Add(d.DiscountCode);
            }
            var tmpx = discountCode.FirstOrDefault(stringToCheck => stringToCheck.Contains(txtBoxDiscountCode.Text));
            if (discountList.Count == 0)
            {
                MessageBox.Show("No discount available", "Warning");
            }

            else if (txtBoxDiscountCode.Text == "")
            {
                MessageBox.Show("Please enter a discount code!", "Warning");
            }
            else if (tmpx == null)
            {
                MessageBox.Show("Invalid discount code", "Warning");
            }
            else if (discountList.Count > 0)
            {
                List<IRedeemedDiscount> redeemedList = Model.getRedeemedDiscountByCustomerID(Model.CurrentCustomer.CustomerID);
                List<string> tmp = new List<string>();
                foreach (RedeemedDiscount a in redeemedList)
                {
                    tmp.Add(a.discountCode);
                }
                var match = tmp.FirstOrDefault(stringToCheck => stringToCheck.Contains(txtBoxDiscountCode.Text));
                if (match != null)
                {
                    MessageBox.Show("You have redeemed the discount code!", "Warning");
                }
                else
                {
                    foreach (Discount d in discountList)
                    {
                        if (txtBoxDiscountCode.Text == d.DiscountCode)
                        {
                            subtotal = 0;

                            for (int i = 0; i < cart.Items.Count; i++)
                            {

                                if (d.productType.Trim() == cart.Items[i].SubItems[3].Text.Trim())
                                {
                                    cart.Items[i].SubItems[2].Text = Math.Round(double.Parse(cart.Items[i].SubItems[2].Text) * (double)(100 - d.DiscountPercentage) / (double)100, 2).ToString();

                                }
                                Model.priceDiscountInCart((double.Parse(cart.Items[i].SubItems[2].Text) / double.Parse(cart.Items[i].SubItems[1].Text)), cart.Items[i].SubItems[4].Text, Model.CurrentCustomer.CustomerID);
                                subtotal += double.Parse(cart.Items[i].SubItems[2].Text) * double.Parse(cart.Items[i].SubItems[1].Text);
                            }
                            Model.redeemedDiscount(d.DiscountCode, Model.CurrentCustomer.CustomerID, DateTime.Now);


                        }

                    }

                    lblSubtotal.Text = subtotal.ToString();
                    lblTotal.Text = (double.Parse(lblShipping.Text) + subtotal).ToString();
                }


            }
        }
    }
}
