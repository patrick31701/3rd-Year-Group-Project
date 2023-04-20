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
    public partial class GMManage_ProductDetails : Form
    {
        #region Instance Attributes
        private IModel Model;
        string logId;
        #endregion
        #region Constructors

        public GMManage_ProductDetails(IModel Model,string logID)
        {
            InitializeComponent();
            logId = logID;
            this.Model = Model;
            displayProducts();
            tbDescriptionMNG_ProductDetails.ReadOnly = false;
            tbName.ReadOnly = false;
            tbPrice.ReadOnly = false;
        }
        #endregion

        private void displayProducts()
        {
            foreach (Product aProduct in Model.ProductList)
            {
                LvProductInfo.Items.Add(new ListViewItem(new string[] {
                    aProduct.ProductName,
                    aProduct.Price.ToString(),
                     aProduct.ProductID,
                     aProduct.Description,
                     aProduct.ProductType,
                     aProduct.Quantity.ToString()
                    
                }));
            }
        }

        private void LvProductInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(ListViewItem x in LvProductInfo.SelectedItems)
            {
                tbName.Text = x.SubItems[0].Text;
                tbPrice.Text = x.SubItems[1].Text;
                tbProductID.Text = x.SubItems[2].Text;
                tbDescriptionMNG_ProductDetails.Text = x.SubItems[3].Text;
                cbProdMenu.Text = x.SubItems[4].Text;
                tbQuantity.Text = x.SubItems[5].Text;
            }
        }

   

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string productName = tbName.Text;
            string productID = tbProductID.Text;
            int quantity = int.Parse(tbQuantity.Text);
            double price = double.Parse(tbPrice.Text);
            string descrpiton = tbDescriptionMNG_ProductDetails.Text;
            string productType = cbProdMenu.Text;

            var confirm = MessageBox.Show("Are you sure you want to edit this product ? ", "Decline ? ", MessageBoxButtons.YesNo);
            if(confirm==DialogResult.Yes)
            {
                Model.editProduct(productName,productID,quantity,price,descrpiton,productType);
                
            }
            
           


        }



        private void btnDelete_Click(object sender, EventArgs e)
        {
            string id = tbProductID.Text;


            var confirm = MessageBox.Show("Are you sure you want to delete this product ? ", "Decline ? ", MessageBoxButtons.YesNo);
            if(confirm==DialogResult.Yes)
            {
                Model.deleteProduct(id);
            }
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            tbProductID.ReadOnly = true;
            string productName=tbName.Text;
            int quantity=int.Parse(tbQuantity.Text);
            double price=double.Parse(tbPrice.Text);
            string descrpiton=tbDescriptionMNG_ProductDetails.Text;
            string productType = cbProdMenu.SelectedItem.ToString();

            var confirm = MessageBox.Show("Are you sure you want to add this product ? ", "Decline ? ", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                Model.addProduct(productName, quantity, price, descrpiton, productType);

            }
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            User_Login login = new User_Login(Model);
            Manager_Dashboard x = new Manager_Dashboard(login, this.Model,logId);
            this.Close();
            x.Show();
        }
    }
}
