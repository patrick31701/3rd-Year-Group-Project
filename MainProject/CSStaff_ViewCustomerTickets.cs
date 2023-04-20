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
    public partial class CSStaff_ViewCustomerTickets : Form
    {
        #region Instance Attributes
        private CSStaff_Dashboard dash;
        private IModel Model;
        #endregion Instance Attributes
        #region Constructors
        public CSStaff_ViewCustomerTickets(CSStaff_Dashboard dash, IModel Model)
        {
            InitializeComponent();
            this.Model = Model;
            DisplayAllQueries();

        }
        #endregion

        private void btnReviewTicket_Click(object sender, EventArgs e)
        {
            string ticketID = "";
            foreach (ListViewItem x in lvCustomerTickets.SelectedItems)
            {
                ticketID = x.SubItems[0].Text;
            }
            CSStaff_TicketReview ticketReview = new CSStaff_TicketReview(this, Model, ticketID);
            ticketReview.ShowDialog();
            return;

        }

        public void DisplayAllQueries()
        {
            List<IQueries> queryList = Model.getAllQueries();
            foreach(IQueries x in queryList)
            {
                if (x.Complete == 0)
                {
                    lvCustomerTickets.Items.Add(new ListViewItem(new string[]
                    {
                    x.QueryID,
                    x.Topic
                    }));
                }
            }
        }
    }
}
