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
    public partial class Customer_CustomerSupport : Form
    {
        #region Instance Attributes
        private User_Login ULogin;
        private IModel Model;
        #endregion
        #region Constructors
        public Customer_CustomerSupport(IModel Model)
        {
            InitializeComponent();            
            this.Model = Model;
            displayName();
            displayQueries();
        }
        #endregion

        public Customer_CustomerSupport()
        {
            InitializeComponent();
        }

        public void displayName()
        {
            txtTicketFirstname.Enabled = false;
            txtTicketLastname.Enabled = false;
            txtTicketFirstname.Text = Model.CurrentCustomer.FirstName.ToString();
            txtTicketLastname.Text = Model.CurrentCustomer.LastName.ToString();

        }

        public void displayQueries()
        {
            string id;
            List<IQueries> queryList = Model.getAllQueries();
            foreach (IQueries x in queryList)
            {
                id = x.CustomerID;
                if (Model.CurrentCustomer.CustomerID == id)
                {
                    if (x.Complete == 1)
                    {
                        lvCustomerSupport.Items.Add(new ListViewItem(new string[] {
                    x.QueryID,
                    x.Topic,
                    "Complete"
                    }));

                    }
                    else
                    {
                        lvCustomerSupport.Items.Add(new ListViewItem(new string[]
                        {
                    x.QueryID,
                    x.Topic,
                    "Not Complete"
                        }));
                    }
                }
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            Model.CustomerSupport(txtTicketTopic.Text, txtTicketDescription.Text,Model.CurrentCustomer.CustomerID);

            txtTicketTopic.Clear();
            txtTicketDescription.Clear();
            lvCustomerSupport.Items.Clear();
            displayQueries();
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
