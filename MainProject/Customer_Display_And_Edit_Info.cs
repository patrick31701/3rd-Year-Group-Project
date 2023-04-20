using BusinessLayer;
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
    public partial class Customer_Display_And_Edit_Info : Form
    {
        #region Instance Attributes
        private User_Login ULogin;
        private IModel Model;
        
        #endregion
        #region Constructors
        public Customer_Display_And_Edit_Info(User_Login customer, IModel Model)
        {
            InitializeComponent();
            ULogin = customer;
            this.Model = Model;
            
            displayInfo();
        }
        #endregion
        public Customer_Display_And_Edit_Info()
        {
            InitializeComponent();
        }
        


        public void displayInfo()
        {
            tbAddress.ReadOnly = true;
            tbEmailAddress.ReadOnly = true;
            tbName.ReadOnly = true;
            tbNumber.ReadOnly = true;
            tbEircode.ReadOnly = true;
            tbCity.ReadOnly = true;
            cbbCounty.Enabled = false;
            tbAddress.Text = Model.CurrentCustomer.Address;
            tbName.Text = Model.CurrentCustomer.FirstName + "" + Model.CurrentCustomer.LastName;
            tbNumber.Text = Model.CurrentCustomer.Mobile.ToString();
            tbEmailAddress.Text = Model.CurrentCustomer.Email;
            tbCity.Text = Model.CurrentCustomer.City;
            cbbCounty.Text = Model.CurrentCustomer.County;
            tbEircode.Text = Model.CurrentCustomer.Eircode;
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if(btn_Edit.Text=="Edit")
            {
                tbAddress.ReadOnly = false;
                tbEmailAddress.ReadOnly = false;
                tbEircode.ReadOnly = false;
                cbbCounty.Enabled = false;
                tbNumber.ReadOnly = false;
                tbCity.ReadOnly = false;
                cbbCounty.Enabled = true;
                btn_Edit.Text = "Save";
            }
          else  if(btn_Edit.Text == "Save")
            {
                tbAddress.ReadOnly = true;
                tbEmailAddress.ReadOnly = true;
                tbNumber.ReadOnly = true;
                tbEircode.ReadOnly = true;
                tbCity.ReadOnly = true;
                cbbCounty.Enabled = false;

                string id = Model.CurrentCustomer.CustomerID;
                string address = tbAddress.Text;
                string number = tbNumber.Text;
                string email = tbEmailAddress.Text;
                string county = cbbCounty.SelectedItem.ToString();
                string city = tbCity.Text;
                string eircode = tbEircode.Text;
                
                if(address==Model.CurrentCustomer.Address&&number==Model.CurrentCustomer.Mobile&&email==Model.CurrentCustomer.Email&&county==Model.CurrentCustomer.County&&city==Model.CurrentCustomer.City&&eircode==Model.CurrentCustomer.Eircode)
                {
                    MessageBox.Show("No personal details have been edited.");
                    btn_Edit.Text = "Edit";
                }
               else if(number.Length>10)
                {
                    MessageBox.Show("Phone number entered is invalid. Please enter in a valid phone number.");
                    btn_Edit.Text = "Edit";
                    tbNumber.Text = Model.CurrentCustomer.Mobile;
                }
                else
                {
                    var confirm = MessageBox.Show("Are you sure you want to edit your personal details? ", "Decline ? ", MessageBoxButtons.YesNo);
                    if (confirm == DialogResult.Yes)
                    {
                        Model.editCustomerDetails(id, address, number, email, city, county, eircode);
                    }
                    btn_Edit.Text = "Edit";
                }
            }
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
