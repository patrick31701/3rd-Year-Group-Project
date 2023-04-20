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
    public partial class GM_StockOrders : Form
    {
        #region Instance Attributes
        private IModel Model;
        public string SRID ;
        private string LogID;
        #endregion
        #region Constructors
        public GM_StockOrders(Manager_Dashboard dashboard, IModel Model )
        {
            InitializeComponent();
            this.Model = Model;
            DisplayProducts();
        }
        #endregion
        public GM_StockOrders()
        {
            InitializeComponent();
        }

        private void btnReview_Click(object sender, EventArgs e)
        {
            GMStockOrder_Review orderReview = new GMStockOrder_Review(this,Model,SRID);
            orderReview.Show();
            //this.Close();
        }

        private void lvStockOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem x in lvStockOrders.SelectedItems)
            {
                SRID = x.SubItems[0].Text;
                chItems.Text = x.SubItems[1].Text;
                chStaffID.Text = x.SubItems[2].Text;
            }
        }
        
        private void DisplayProducts()
        {
            foreach (IStock_Requests request in Model.StockRequestList)
            {
                if (request.Quantity == 0)
                {
                    Model.deleteRequest(SRID);
                } 
                lvStockOrders.Items.Add(new ListViewItem(new string[]
                    {
                        request.SRID,
                        request.Quantity.ToString(),
                        request.StaffID
                    })); ; 
                }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            User_Login login = new User_Login(Model);
            Manager_Dashboard y = new Manager_Dashboard(login, this.Model, LogID);
            this.Hide();
            y.Show();
        }
    }
}
