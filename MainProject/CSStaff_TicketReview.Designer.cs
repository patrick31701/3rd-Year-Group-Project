
namespace MainProject
{
    partial class CSStaff_TicketReview
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
            this.lblTicketID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTicketFirstname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTicketLastname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTicketDescription = new System.Windows.Forms.TextBox();
            this.btnCompleteTicket = new System.Windows.Forms.Button();
            this.btnReplyTicket = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTicketID
            // 
            this.lblTicketID.AutoSize = true;
            this.lblTicketID.Font = new System.Drawing.Font("Tw Cen MT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTicketID.Location = new System.Drawing.Point(94, 9);
            this.lblTicketID.Name = "lblTicketID";
            this.lblTicketID.Size = new System.Drawing.Size(284, 37);
            this.lblTicketID.TabIndex = 0;
            this.lblTicketID.Text = "Ticket ID : {Number}";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Firstname";
            // 
            // txtTicketFirstname
            // 
            this.txtTicketFirstname.Location = new System.Drawing.Point(34, 105);
            this.txtTicketFirstname.Name = "txtTicketFirstname";
            this.txtTicketFirstname.Size = new System.Drawing.Size(166, 20);
            this.txtTicketFirstname.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(280, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Lastname";
            // 
            // txtTicketLastname
            // 
            this.txtTicketLastname.Location = new System.Drawing.Point(284, 105);
            this.txtTicketLastname.Name = "txtTicketLastname";
            this.txtTicketLastname.Size = new System.Drawing.Size(166, 20);
            this.txtTicketLastname.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "Description";
            // 
            // txtTicketDescription
            // 
            this.txtTicketDescription.Location = new System.Drawing.Point(34, 175);
            this.txtTicketDescription.Multiline = true;
            this.txtTicketDescription.Name = "txtTicketDescription";
            this.txtTicketDescription.Size = new System.Drawing.Size(416, 203);
            this.txtTicketDescription.TabIndex = 6;
            // 
            // btnCompleteTicket
            // 
            this.btnCompleteTicket.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompleteTicket.Location = new System.Drawing.Point(88, 399);
            this.btnCompleteTicket.Name = "btnCompleteTicket";
            this.btnCompleteTicket.Size = new System.Drawing.Size(112, 40);
            this.btnCompleteTicket.TabIndex = 7;
            this.btnCompleteTicket.Text = "Complete";
            this.btnCompleteTicket.UseVisualStyleBackColor = true;
            this.btnCompleteTicket.Click += new System.EventHandler(this.btnCompleteTicket_Click);
            // 
            // btnReplyTicket
            // 
            this.btnReplyTicket.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReplyTicket.Location = new System.Drawing.Point(284, 399);
            this.btnReplyTicket.Name = "btnReplyTicket";
            this.btnReplyTicket.Size = new System.Drawing.Size(112, 40);
            this.btnReplyTicket.TabIndex = 8;
            this.btnReplyTicket.Text = "Reply";
            this.btnReplyTicket.UseVisualStyleBackColor = true;
            this.btnReplyTicket.Click += new System.EventHandler(this.btnReplyTicket_Click);
            // 
            // CSStaff_TicketReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.btnReplyTicket);
            this.Controls.Add(this.btnCompleteTicket);
            this.Controls.Add(this.txtTicketDescription);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTicketLastname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTicketFirstname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTicketID);
            this.Name = "CSStaff_TicketReview";
            this.Text = "CSStaff_TicketReview";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTicketID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTicketFirstname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTicketLastname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTicketDescription;
        private System.Windows.Forms.Button btnCompleteTicket;
        private System.Windows.Forms.Button btnReplyTicket;
    }
}