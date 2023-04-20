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

using BusinessEntities;
using BusinessLayer;

namespace MainProject
{
    public partial class GMView_PurchaseHistory : Form
    {
        #region Instance Attributes
        private IModel Model;
        List<IOrderDetails> detailsList = new List<IOrderDetails>();
        string oID;
        string cID;
        #endregion
        #region Constructors

        public GMView_PurchaseHistory(Manager_Dashboard md, IModel Model, string orderID)
        {
            InitializeComponent();
            this.Model = Model;
            oID = orderID;
            detailsList = Model.getOrderDetails(oID);
           // DisplayProducts();
            tbCustomerID.ReadOnly = true;
            tbCustomerName.ReadOnly = true;
            tbOrderID.ReadOnly = true;
            tbProductID.ReadOnly = true;
            tbName.ReadOnly = true;
            tbQuantity.ReadOnly = true;
            tbPrice.ReadOnly = true;
            tbOrderPrice.ReadOnly = true;

        }
        #endregion

       public GMView_PurchaseHistory()
        {
            InitializeComponent();
        }

        private void DisplayProducts()
        {
           /* ICustomer customer = Model.getCustomerOfOrder(cID);
            tbOrderID.Text = oID;
            tbName.Text = customer.FirstName+" "+customer.LastName;
            tbCustomerID.Text = cID;
            //tbOrderPrice.Text = Model.priceOfOrders(oID).ToString();


            foreach (IOrderDetails od in detailsList)
            {
                cbOrderMenu.Items.Add(od.OrderID);

                lv.Items.Add(new ListViewItem(new string[]
                {
                    od.ProductID,
                    od.ProductName,
                    od.ProductQuantity.ToString(),
                    od.ProductPrice.ToString()
                })) ;
            }*/
        }

        private void lv_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem x in lv.SelectedItems)
            {
               // tbCustomerID .Text = x.SubItems[0].Text;
                tbOrderID.Text = x.SubItems[1].Text;
                tbProductID.Text = x.SubItems[2].Text;
                tbName.Text = x.SubItems[3].Text;
              /*  tbQuantity.Text = x.SubItems[4].Text;
                tbPrice.Text = x.SubItems[5].Text;*/
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
