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

namespace MainProject
{
    // Made by Jakub
    public partial class View_Product_Details : Form
    {
        #region Instance Attributes
        IProduct prod;
        #endregion
        public View_Product_Details(IProduct product)
        {
            prod = product;
            InitializeComponent();
        }

        private void View_Product_Details_Load(object sender, EventArgs e)
        {
            lblProdName.Text = prod.ProductName;
            lblProductID.Text = prod.ProductID;
            txtProdDesc.Text = prod.Description;
            txtProdPrice.Text = prod.Price.ToString();
            txtProdQuantity.Text = prod.Quantity.ToString();
            txtProdType.Text = prod.ProductType.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
