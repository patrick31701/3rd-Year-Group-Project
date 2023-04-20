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
namespace MainProject
{
    public partial class Customer_Reset_Password : Form
    {
        #region Instance Attributes
        private IModel Model;
        #endregion

        #region Constructors

        public Customer_Reset_Password(IModel Model)
        {
            InitializeComponent();
            this.Model = Model;
        }

        #endregion

        private void btnClose_Click(object sender, EventArgs e)
        {
            User_Login login = new User_Login(Model);
            Customer_Dashboard x = new Customer_Dashboard(login, this.Model);
            this.Close();
            x.Show();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string hashPass1 = Model.ComputeSha256Hash(tbPassword.Text);
            string hashPass2 = Model.ComputeSha256Hash(tbRePassword.Text);
            string hashNewPass1 = Model.ComputeSha256Hash(tbNewPassword.Text);
            string hashNewPass2 = Model.ComputeSha256Hash(tbReNewPassword.Text);

            if (hashPass1 == hashPass2 && hashNewPass1 == hashNewPass2)
            {
                Model.resetPassword(hashNewPass1, Model.CurrentCustomer.CustomerID);

                User_Login login = new User_Login(Model);
                Customer_Dashboard x = new Customer_Dashboard(login, this.Model);
                this.Close();
                x.Show();
            }
            else
                MessageBox.Show("You have entered in one of the fields wrong, Please try again.");
        }
    }
}
