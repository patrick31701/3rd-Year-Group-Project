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
    public partial class WStaff_ViewOnlineOrders : Form
    {
        #region Instance Attributes
        private IModel Model;
        private WStaff_Dashboard pf;
        #endregion
        #region Constructors
        public WStaff_ViewOnlineOrders(IModel Model, WStaff_Dashboard passedForm)
        {
            InitializeComponent();
            this.Model = Model;
            pf = passedForm;
            DisplayOrders();
        }
        #endregion

        private void btnOrderReview_Click(object sender, EventArgs e)
        {
            string orderID = "";
            string custID = "";
            foreach (ListViewItem x in lvOnlineOrders.SelectedItems)
            {
                orderID = x.SubItems[0].Text;
                custID = x.SubItems[1].Text;
            }
            WStaff_ReviewOrder order = new WStaff_ReviewOrder(this, Model, orderID, custID);
            order.ShowDialog();
            return;
            
        }

        private void DisplayOrders()
        {
            List<IOrder> orderList = Model.getAllOrders();
            foreach (Order o in orderList)
            {
                if (o.Complete == 0) { 
                    lvOnlineOrders.Items.Add(new ListViewItem(new string[] {
                        o.OrderID,
                        o.CustomerID,
                        o.Quantity.ToString(),
                        Model.getPriceOfOrder(o.OrderID).ToString()
                    }));
                }
            }
        }
    }
}
