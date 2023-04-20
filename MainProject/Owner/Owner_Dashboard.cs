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
    public partial class Owner_Dashboard : Form
    {
        #region Instance Attributes
        private User_Login ULogin;
        private IModel Model;
        string logID;
        #endregion
        public Owner_Dashboard(User_Login ulogin, IModel Model, string loginID)
        {
            InitializeComponent();
            this.ULogin = ulogin;
            this.Model = Model;
            logID = loginID;
            lblEarnings.Text = Model.getTotalEarnings().ToString();
            lblOrder.Text = Model.getOrderCount().ToString();
            lblStaff.Text = Model.getStaffCount().ToString();
            List<IOrder> orders = Model.getAllOrders();
            int January = 0, February = 0, March = 0, April = 0, May = 0, June = 0, July = 0, August = 0, September = 0, October = 0, November = 0, December = 0;
            foreach (Order order in orders)
            {
                if (order.DateOrdered.ToString("MMMM") == "January")
                    January++;
                else if (order.DateOrdered.ToString("MMMM") == "February")
                    February++;
                else if (order.DateOrdered.ToString("MMMM") == "March")
                    March++;
                else if (order.DateOrdered.ToString("MMMM") == "April")
                    April++;
                else if (order.DateOrdered.ToString("MMMM") == "May")
                    May++;
                else if (order.DateOrdered.ToString("MMMM") == "June")
                    June++;
                else if (order.DateOrdered.ToString("MMMM") == "July")
                    July++;
                else if (order.DateOrdered.ToString("MMMM") == "August")
                    August++;
                else if (order.DateOrdered.ToString("MMMM") == "September")
                    September++;
                else if (order.DateOrdered.ToString("MMMM") == "October")
                    October++;
                else if (order.DateOrdered.ToString("MMMM") == "November")
                    November++;
                else if (order.DateOrdered.ToString("MMMM") == "December")
                    December++;
            }

            ordersChart.Series["orders"].Points.AddXY("January", January);
            ordersChart.Series["orders"].Points.AddXY("February", February);
            ordersChart.Series["orders"].Points.AddXY("March", March);
            ordersChart.Series["orders"].Points.AddXY("April", April);
            ordersChart.Series["orders"].Points.AddXY("May", May);
            ordersChart.Series["orders"].Points.AddXY("June", June);
            ordersChart.Series["orders"].Points.AddXY("July", July);
            ordersChart.Series["orders"].Points.AddXY("August", August);
            ordersChart.Series["orders"].Points.AddXY("September", September);
            ordersChart.Series["orders"].Points.AddXY("October", October);
            ordersChart.Series["orders"].Points.AddXY("November", November);
            ordersChart.Series["orders"].Points.AddXY("December", December);


        }

        private void Owner_Dashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
