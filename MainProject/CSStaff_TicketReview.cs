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
    public partial class CSStaff_TicketReview : Form
    {
        #region Instance Attributes
        private IModel Model;
        string tID;
        #endregion
        #region Constructors
        public CSStaff_TicketReview(CSStaff_ViewCustomerTickets viewTickets, IModel Model, string ticketID)
        {
            InitializeComponent();
            tID = ticketID;
            this.Model = Model;
            DisplayTickets(ticketID);
        }
        #endregion

        private void btnCompleteTicket_Click(object sender, EventArgs e)
        {
            if (Model.completeQuery(tID))
            {
                MessageBox.Show("Ticket has been closed !!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Something has gone wrong...");
            }
        }

        private void DisplayTickets(string ticketID)
        {
            IQueries query = Model.getQueryByID(ticketID);
            ICustomer customer = Model.getCustomerByID(query.CustomerID);

            lblTicketID.Text = "Ticket ID : " + query.QueryID;
            txtTicketFirstname.Text = customer.FirstName;
            txtTicketLastname.Text = customer.LastName;
            txtTicketDescription.Text = query.Description;
            
        }

        private void btnReplyTicket_Click(object sender, EventArgs e)
        {
            CSStaff_TicketReply ticketReply = new CSStaff_TicketReply(this, Model, tID);
            ticketReply.ShowDialog();
            this.Hide();
            return;
        }
    }
}
