
namespace MainProject
{
    partial class CSStaff_ViewCustomerTickets
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lvCustomerTickets = new System.Windows.Forms.ListView();
            this.chTicketNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTicketDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.btnReviewTicket = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvCustomerTickets
            // 
            this.lvCustomerTickets.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chTicketNumber,
            this.chTicketDescription});
            this.lvCustomerTickets.Font = new System.Drawing.Font("Tw Cen MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvCustomerTickets.FullRowSelect = true;
            this.lvCustomerTickets.GridLines = true;
            this.lvCustomerTickets.HideSelection = false;
            this.lvCustomerTickets.Location = new System.Drawing.Point(12, 74);
            this.lvCustomerTickets.Name = "lvCustomerTickets";
            this.lvCustomerTickets.Size = new System.Drawing.Size(399, 300);
            this.lvCustomerTickets.TabIndex = 0;
            this.lvCustomerTickets.UseCompatibleStateImageBehavior = false;
            this.lvCustomerTickets.View = System.Windows.Forms.View.Details;
            // 
            // chTicketNumber
            // 
            this.chTicketNumber.Text = "Ticket Number";
            this.chTicketNumber.Width = 100;
            // 
            // chTicketDescription
            // 
            this.chTicketDescription.Text = "Topic";
            this.chTicketDescription.Width = 295;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer Tickets";
            // 
            // btnReviewTicket
            // 
            this.btnReviewTicket.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReviewTicket.Location = new System.Drawing.Point(136, 393);
            this.btnReviewTicket.Name = "btnReviewTicket";
            this.btnReviewTicket.Size = new System.Drawing.Size(127, 40);
            this.btnReviewTicket.TabIndex = 2;
            this.btnReviewTicket.Text = "Review";
            this.btnReviewTicket.UseVisualStyleBackColor = true;
            this.btnReviewTicket.Click += new System.EventHandler(this.btnReviewTicket_Click);
            // 
            // CSStaff_ViewCustomerTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 455);
            this.Controls.Add(this.btnReviewTicket);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvCustomerTickets);
            this.Name = "CSStaff_ViewCustomerTickets";
            this.Text = "CSStaff_ViewCustomerTickets";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvCustomerTickets;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader chTicketNumber;
        private System.Windows.Forms.ColumnHeader chTicketDescription;
        private System.Windows.Forms.Button btnReviewTicket;
    }
}