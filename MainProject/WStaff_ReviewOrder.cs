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
    public partial class WStaff_ReviewOrder : Form
    {
        #region Instance Attributes
        private IModel Model;
        private WStaff_ViewOnlineOrders pf;
        List<IOrderDetails> detailsList = new List<IOrderDetails>();
        string oID;
        string cID;
        #endregion
        #region Constructors
        public WStaff_ReviewOrder(WStaff_ViewOnlineOrders passedForm, IModel Model, string orderID, string custID)
        {
            InitializeComponent();
            this.Model = Model;
            pf = passedForm;
            oID = orderID;
            cID = custID;
            detailsList = Model.getOrderDetails(oID);
            DisplayOrder(oID, cID, detailsList);
        }
        #endregion
        private void btnOrderAccept_Click(object sender, EventArgs e)
        {
            if (checkStock(detailsList))
            {
                MessageBox.Show("There is not enough stock for the orders");
            }
            else
            {
                var confirm = MessageBox.Show("Are you sure you want to confirm the order ?", "Confirm ?", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    if (Model.checkIfEnoughStock(detailsList))
                    {
                        Model.confirmOrder(oID);
                        this.Close();
                    }
                    else
                        MessageBox.Show("There is not enough stock for this order.");
                }
            }
        }

        private void DisplayOrder(string oID, string cID, List<IOrderDetails> detailsList)
        {
            ICustomer customer = Model.getCustomerOfOrder(cID);
            lblOrderNum.Text = oID;
            txtOrderFName.Text = customer.FirstName;
            txtOrderLName.Text = customer.LastName;
            txtOrderAddress.Text = customer.Address + ", " + customer.City + ", Co." + customer.County;

            foreach(IOrderDetails od in detailsList)
            {
                lvOrderDetails.Items.Add(new ListViewItem(new string[]
                {
                    od.ProductID,
                    od.ProductName,
                    od.ProductQuantity.ToString(),
                    od.ProductStoreQuantity.ToString()
                }));
            }
        }

        private void btnOrderDecline_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Are you sure you want to decline this order?", "Decline ?", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {

                Model.deleteOrder(oID);
                this.Close();
            }
        }

        private Boolean checkStock(List<IOrderDetails> oList)
        {
            foreach(IOrderDetails o in oList)
            {
                if(o.ProductStoreQuantity - o.ProductQuantity <= 0)
                {
                    return true;
                }
            }
            return false;
        } 
    }
}
