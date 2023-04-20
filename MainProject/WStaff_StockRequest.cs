using BusinessEntities;
using BusinessLayer;
using System;
using System.Windows.Forms;

namespace MainProject
{
    // Made By Jakub
    public partial class WStaff_StockRequest : Form
    {
        #region Instance Attributes
        private IModel Model;
        private WStaff_Dashboard pf;
        #endregion
        #region Constructors
        public WStaff_StockRequest(IModel Model, WStaff_Dashboard passedForm)
        {
            InitializeComponent();
            this.Model = Model;
            pf = passedForm;
            DisplayProducts();
        }
        #endregion

        private void btnSumbitRequest_Click(object sender, EventArgs e)
        {
            if (lvOrderBasket.Items.Count == 0)
            {
                MessageBox.Show("There is nothing to submit");
            }
            else
            {
                int total = countQuantity();
                string srID = Model.makeRequestID();
                string description = txtDescription.Text;
                Model.submitStockRequest(srID, total, description);
                foreach (ListViewItem x in lvOrderBasket.Items)
                {
                    string productID = x.SubItems[0].Text;
                    string productName = x.SubItems[1].Text;
                    int productQuantity = Convert.ToInt32(x.SubItems[2].Text);
                    Model.submitStockRequestDetails(srID, productID, productName, productQuantity);
                }
                lvOrderBasket.Clear();
                this.Close();
            }
            
        }

        private void DisplayProducts()
        {
            foreach (IProduct aProduct in Model.ProductList)
            {
                lvStockProducts.Items.Add(new ListViewItem(new string[]
                {
                    aProduct.ProductID,
                    aProduct.ProductName,
                }));
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string code = "";
            bool found = false;
            foreach (ListViewItem x in lvStockProducts.SelectedItems)
            {
                code = x.SubItems[0].Text;
            }
            int quantity = 0;
            if (txtQuantity.Text == "")
            {
                quantity = 1;
            }
            else
                quantity = Convert.ToInt32(txtQuantity.Text);

            if (checkListView())
            {
                foreach(ListViewItem x in lvOrderBasket.Items)
                {
                    if(x.SubItems[0].Text == code)
                    {
                        int stockQuantity = Convert.ToInt32(x.SubItems[2].Text);
                        x.SubItems[2].Text = (quantity + stockQuantity).ToString();
                    }
                }
                txtQuantity.Clear();
            }
            else
            {
                foreach (ListViewItem x in lvStockProducts.SelectedItems)
                {
                    lvOrderBasket.Items.Add(new ListViewItem(new string[]{
                        x.SubItems[0].Text,
                        x.SubItems[1].Text,
                        quantity.ToString()
                    }));
                }
                txtQuantity.Clear();
            }
        }

        public bool checkListView()
        {
            string code = "";

            foreach (ListViewItem x in lvStockProducts.SelectedItems)
            {
                code = x.SubItems[0].Text;
            }

            foreach (ListViewItem x in lvOrderBasket.Items)
            {
                if (x.SubItems[0].Text == code)
                {
                    return true;
                }
            }
            return false;
        }

        public int countQuantity()
        {
            int total = 0;
            foreach(ListViewItem x in lvOrderBasket.Items)
            {
                total += Convert.ToInt32(x.SubItems[2].Text);
            }
            return total;
        }
    }
}
