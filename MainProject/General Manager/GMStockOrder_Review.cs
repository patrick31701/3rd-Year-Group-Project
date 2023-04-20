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

namespace MainProject.General_Manager
{
    public partial class GMStockOrder_Review : Form
    {
        #region Instance Attributes
        private IModel Model;
        private string LogID;
        #endregion
        #region Constructors
        public GMStockOrder_Review(GM_StockOrders orders, IModel Model,string srid)
        {
            InitializeComponent();
            this.Model = Model;
            DisplayProducts(srid);
        }
        #endregion
        public GMStockOrder_Review()
        {
            InitializeComponent();
        }

        private void lv_StockOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem x in lv_StockOrder.SelectedItems)
            {
                chProductID.Text = x.SubItems[0].Text;
                chProductDetails.Text = x.SubItems[1].Text;
                chQuantity.Text = x.SubItems[2].Text;
                chStockDetailsID.Text = x.SubItems[3].Text;
                chStockRequestID.Text = x.SubItems[4].Text;
            }
        }

        private void DisplayProducts(string srid)
        {
            foreach (IStock_Request_Details request in Model.StockRequestDetailsList)
            {
                if (request.SRID == srid )
                lv_StockOrder.Items.Add(new ListViewItem(new string[]
                {
                    request.ProductID,
                    request.ProductName,
                    request.Quantity.ToString(),
                    request.SDetailsID.ToString(),
                    request.SRID
                 })); ;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

            User_Login login = new User_Login(Model);
            Manager_Dashboard y = new Manager_Dashboard(login, this.Model, LogID);
            GM_StockOrders x = new GM_StockOrders(y,this.Model);
            this.Hide();
            x.Show();
        }

        private void btnDeny_StockOrder_Click(object sender, EventArgs e)
        {
            
            var confirm = MessageBox.Show("Are you sure you want to delete this product ? ", "Decline ? ", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                Model.deleteRequest(lv_StockOrder.SelectedItems[0].Text);
            }
        }

        private void btnOrder_StockOrder_Click(object sender, EventArgs e)
        {
            List<IOrderDetails> details = new List<IOrderDetails>();

            var confirm = MessageBox.Show("Are you sure you want to confirm the Request ?", "Confirm ?", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                foreach (IOrderDetails od in details)
                {

                    if (od.ProductQuantity < od.ProductStoreQuantity)
                    {
                        Model.confirmOrder(od.OrderID);
                        MessageBox.Show("There is not enough stock for this order.");
                        this.Close();
                    }
                    else
                        MessageBox.Show("There is not enough stock for this order.");
                }
            }
        }
    }
}
