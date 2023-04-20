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
    // Made by Jakub
    public partial class CSStaff_TicketReply : Form
    {
        #region Instance Properties
        private IModel Model;
        string tID;
        #endregion

        public CSStaff_TicketReply(CSStaff_TicketReview ticketReview, IModel Model, string ticketID)
        {
            InitializeComponent();
            this.Model = Model;
            tID = ticketID;
        }

        private void btnSumbitReply_Click(object sender, EventArgs e)
        {
            string reply = txtTicketReply.Text;
            if (Model.replyToQuery(tID, reply))
                MessageBox.Show("The reply has been sumbitted !");
            else
                MessageBox.Show("Something has gone wrong, couldn't submit reply.");
            this.Close();
        }
    }
}
