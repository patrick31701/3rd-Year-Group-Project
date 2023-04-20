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


namespace MainProject.General_Manager
{
    //Made by Jakub
    public partial class PromotionalEmail : Form
    {
        #region Instance Attributes
        private IModel Model;
        #endregion
        #region Constructor
        public PromotionalEmail(Manager_Dashboard manager_Dashboard, IModel Model)
        {
            InitializeComponent();
            this.Model = Model;
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            /*if (rbtnLoyalty.Checked)
            {
                List<ICustomer> loyalCust = new List<ICustomer>();
                foreach(ICustomer aCustomer in Model.CustomerList)
                {
                    if(aCustomer.LoyaltyCard == 1)
                    {
                        loyalCust.Add(aCustomer);
                    }
                }
                Model.promotionalEmail(txtTitle.Text, txtSubject.Text, txtBody.Text, txtCoupon.Text, loyalCust, "loyal");
            }*/
        }
    }
}
