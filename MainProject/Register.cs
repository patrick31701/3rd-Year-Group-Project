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
    public partial class Register : Form
    {
        #region Instance Attributes
        private IModel Model;
        User_Login uLogin;
        #endregion
        #region Constructors
        public Register(User_Login ULogin, IModel Model)
        {
            InitializeComponent();
            this.Model = Model;
            uLogin = ULogin;
        }
        #endregion

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (cboxConfirm.Checked)
            { 
                if (verifyInput() && Model.validateForm(txtPassword.Text, txtConPassword.Text, txtEmail.Text))
                {
                    Model.registerCustomer(txtFirstname.Text, txtLastname.Text, txtEmail.Text, Model.ComputeSha256Hash(txtPassword.Text), txtAddress.Text,
                            txtCity.Text, cbbCounty.Text, txtEircode.Text, txtMobile.Text);
                    MessageBox.Show("You are now Registered !!!!");
                    //Emailing.sendEmail(txtEmail.Text);
                    this.Close();
                    uLogin.Show();
                }
                else
                    MessageBox.Show("Registration was not complete");
            }
            else
            {
                MessageBox.Show("Please accept the terms of service");
            }
        }

        public bool verifyInput()
        {
            foreach(Control control in this.Controls)
            {
                if(control is TextBox && string.IsNullOrWhiteSpace(control.Text) && control.Name != "txtMobile")
                {
                    MessageBox.Show(control.Name + " cannot be empty");
                    return false;
                }
                else if(control is ComboBox && string.IsNullOrWhiteSpace(control.Text))
                {
                    MessageBox.Show("Please input select a county !");
                    return false;
                }
            }
            return true;
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }
    }
}
