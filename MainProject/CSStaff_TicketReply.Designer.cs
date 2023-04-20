
namespace MainProject
{
    partial class CSStaff_TicketReply
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
            this.lblTicketReply = new System.Windows.Forms.Label();
            this.txtTicketReply = new System.Windows.Forms.TextBox();
            this.btnSumbitReply = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTicketReply
            // 
            this.lblTicketReply.AutoSize = true;
            this.lblTicketReply.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTicketReply.Location = new System.Drawing.Point(12, 9);
            this.lblTicketReply.Name = "lblTicketReply";
            this.lblTicketReply.Size = new System.Drawing.Size(110, 22);
            this.lblTicketReply.TabIndex = 0;
            this.lblTicketReply.Text = "Ticket Reply ";
            // 
            // txtTicketReply
            // 
            this.txtTicketReply.Location = new System.Drawing.Point(12, 34);
            this.txtTicketReply.Multiline = true;
            this.txtTicketReply.Name = "txtTicketReply";
            this.txtTicketReply.Size = new System.Drawing.Size(460, 124);
            this.txtTicketReply.TabIndex = 1;
            // 
            // btnSumbitReply
            // 
            this.btnSumbitReply.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSumbitReply.Location = new System.Drawing.Point(360, 164);
            this.btnSumbitReply.Name = "btnSumbitReply";
            this.btnSumbitReply.Size = new System.Drawing.Size(112, 40);
            this.btnSumbitReply.TabIndex = 2;
            this.btnSumbitReply.Text = "Submit";
            this.btnSumbitReply.UseVisualStyleBackColor = true;
            this.btnSumbitReply.Click += new System.EventHandler(this.btnSumbitReply_Click);
            // 
            // CSStaff_TicketReply
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 211);
            this.Controls.Add(this.btnSumbitReply);
            this.Controls.Add(this.txtTicketReply);
            this.Controls.Add(this.lblTicketReply);
            this.Name = "CSStaff_TicketReply";
            this.Text = "CSStaff_TicketReply";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTicketReply;
        private System.Windows.Forms.TextBox txtTicketReply;
        private System.Windows.Forms.Button btnSumbitReply;
    }
}