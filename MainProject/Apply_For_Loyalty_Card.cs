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
    public partial class Apply_For_Loyalty_Card : Form
    {
        #region Instance Attributes
        private IModel Model;
        private User_Login ULogin;
        List<string[]> list = new List<string[]>();
        #endregion
        #region Constructors
        public Apply_For_Loyalty_Card(IModel Model)
        {
            InitializeComponent();
            this.Model = Model;
            
        }
        #endregion

        private void btnApply_Click(object sender, EventArgs e)
        {
            string hashPass1 = Model.ComputeSha256Hash(tbPassword.Text);
            string hasPass2 = Model.ComputeSha256Hash(tbConfirmPassword.Text);

            if(Model.CurrentCustomer.LoyaltyCard==1)
            {
                MessageBox.Show("You already have a loyalty Card!");
                Customer_Dashboard x = new Customer_Dashboard(ULogin,Model);
                x.Show();
                this.Close();
                
            }

           else if (hashPass1 == hasPass2&&hashPass1==Model.CurrentCustomer.CurPassword&&Model.CurrentCustomer.LoyaltyCard!=1)
            {
                Model.applyForLoyaltyCard(Model.CurrentCustomer.CustomerID);
                MessageBox.Show("You have a loyalty card now!");

            }
            else
                MessageBox.Show("Your entered password either doesnt match your account password or the confirm password doesnt match the entered password. Please try again.");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            User_Login login = new User_Login(Model);
            Customer_Dashboard x = new Customer_Dashboard(login, this.Model);
            this.Close();
            x.Show();
        }
    }
}
