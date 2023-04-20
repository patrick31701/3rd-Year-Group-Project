using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

using BusinessLayer;

namespace MainProject
{
    public partial class User_Login : Form
    {
        #region Instance Attributes
        private IModel Model;
        #endregion
        #region Instance Properties

        #endregion
        #region Constructors
        public User_Login(IModel _Model)
        {
            InitializeComponent();
            Model = _Model;
        }
        #endregion

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(Model.staffLogin(txtEmail.Text.ToString(), txtPassword.Text.ToString()) == true)
            {
                string loginID = Model.makeLoginID();
                Model.recordLogin(loginID);
                switch (Model.getUserTypeForCurrentStaff())
                { 
                    case "MANAGER":
                        Manager_Dashboard Mdashboard = new Manager_Dashboard(this, Model, loginID);
                        this.Hide();
                        Mdashboard.ShowDialog();
                        break;
                    case "OWNER":
                        Owner_Base Obase = new Owner_Base(this, Model, loginID);
                        this.Hide();
                        Obase.Show();
                        break;
                    case "WSTAFF":
                        WStaff_Dashboard Wdashboard = new WStaff_Dashboard(this, Model, loginID);
                        this.Hide();
                        Wdashboard.ShowDialog();
                        break;
                    case "GSTAFF":
                        GStaff_Dashboard Gdashboard = new GStaff_Dashboard(this, Model, loginID);
                        this.Hide();
                        Gdashboard.Show();
                        break;
                    case "CSSTAFF":
                        CSStaff_Dashboard CSdashboard = new CSStaff_Dashboard(this, Model, loginID);
                        this.Hide();
                        CSdashboard.Show();
                        break;
                }
            }
            else if(Model.customerLogin(txtEmail.Text.ToString(), txtPassword.Text.ToString()) == true)
            {
                Customer_Dashboard Cdashboard = new Customer_Dashboard(this, Model);
                this.Hide();
                Cdashboard.Show();
            }
            else
            {
                MessageBox.Show("Youre helpless");
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register register = new Register(this, Model);
            register.ShowDialog();
            return;
        }
    }
}
