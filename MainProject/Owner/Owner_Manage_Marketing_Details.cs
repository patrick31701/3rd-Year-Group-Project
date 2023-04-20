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

namespace MainProject.Owner
{
    public partial class Owner_Manage_Marketing_Details : Form
    {
        string[] pType = { "BKRY", "BPROD", "DAIRY", "DRINK", "MEAT" };
        #region Instance Attributes
        private User_Login ULogin;
        private IModel Model;
        private string loginID;
        #endregion
        public Owner_Manage_Marketing_Details(User_Login staff, IModel Model, string loginID)
        {
            InitializeComponent();
            ULogin = staff;
            this.Model = Model;
            this.loginID = loginID;

            foreach (string p in pType)
            {
                productType.Items.Add(p);
            }
            foreach (Discount discount in Model.DiscountList)
            {
                dataGridView1.Rows.Add(discount.DiscountID, discount.DiscountCode, discount.DiscountPercentage, discount.startDate, discount.endDate, discount.productType);
            }


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (discountCode.Text == "" || discountPercentage.Text == "" || productType.Items.Contains(""))
            {
                MessageBox.Show("No input detected!", "Warning");
            }
            else if (!int.TryParse(discountPercentage.Text, out _))
            {
                MessageBox.Show("discount percentage input is not numeric", "Warning");
            }
            else {
                string newID = Model.makeDiscountID();
                Model.addDiscountDetails(newID, discountCode.Text, int.Parse(discountPercentage.Text), startDate.Value, endDate.Value, productType.Text);
                dataGridView1.Rows.Add(newID, discountCode.Text, int.Parse(discountPercentage.Text), startDate.Value, endDate.Value, productType.Text);
                discountCode.Text = "";
                discountPercentage.Text = "";
                startDate.Value = DateTime.Now;
                endDate.Value = DateTime.Now;
                productType.Text = "";

                dataGridView1.Update();
                dataGridView1.Refresh();
            }

        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 1)
            {
                Model.updateDiscountDetails(dataGridView1.CurrentRow.Cells[0].Value.ToString(), discountCode.Text, int.Parse(discountPercentage.Text), startDate.Value, endDate.Value, productType.Text);
                dataGridView1.Update();
                dataGridView1.Refresh();
                discountCode.Text = "";
                discountPercentage.Text = "";
                startDate.Value = DateTime.Now;
                endDate.Value = DateTime.Now;
                productType.Text = "";
            }
            else
            {
                MessageBox.Show("There is no data being selected!", "Warning");
            }

            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != -1)
            {
                discountCode.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                discountPercentage.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                startDate.Value = DateTime.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString());
                endDate.Value = DateTime.Parse(dataGridView1.CurrentRow.Cells[4].Value.ToString());
                productType.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            }
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            Model.deleteDiscountDetails(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            discountCode.Text = "";
            discountPercentage.Text = "";
            startDate.Value = DateTime.Now;
            endDate.Value = DateTime.Now;
            productType.Text = "";
            dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);
            dataGridView1.Update();
            dataGridView1.Refresh();
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            discountCode.Text = "";
            discountPercentage.Text = "";
            startDate.Value = DateTime.Now;
            endDate.Value = DateTime.Now;
            productType.Text = "";
        }
    }
}
