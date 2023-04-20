
namespace MainProject
{
    partial class Customer_CustomerSupport
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
            this.txtTicketDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTicketLastname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTicketFirstname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTicketTopic = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.lvCustomerSupport = new System.Windows.Forms.ListView();
            this.lvQueryID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvTopic = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvCompleted = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // txtTicketDescription
            // 
            this.txtTicketDescription.Location = new System.Drawing.Point(254, 138);
            this.txtTicketDescription.Multiline = true;
            this.txtTicketDescription.Name = "txtTicketDescription";
            this.txtTicketDescription.Size = new System.Drawing.Size(416, 203);
            this.txtTicketDescription.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(250, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 22);
            this.label4.TabIndex = 11;
            this.label4.Text = "Description";
            // 
            // txtTicketLastname
            // 
            this.txtTicketLastname.Location = new System.Drawing.Point(477, 43);
            this.txtTicketLastname.Name = "txtTicketLastname";
            this.txtTicketLastname.Size = new System.Drawing.Size(166, 20);
            this.txtTicketLastname.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(473, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 22);
            this.label3.TabIndex = 9;
            this.label3.Text = "Lastname";
            // 
            // txtTicketFirstname
            // 
            this.txtTicketFirstname.Location = new System.Drawing.Point(254, 43);
            this.txtTicketFirstname.Name = "txtTicketFirstname";
            this.txtTicketFirstname.Size = new System.Drawing.Size(166, 20);
            this.txtTicketFirstname.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(250, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "Firstname";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Location = new System.Drawing.Point(382, 358);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(67, 34);
            this.btnSubmit.TabIndex = 13;
            this.btnSubmit.Text = "Submit Ticket";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(250, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 22);
            this.label1.TabIndex = 14;
            this.label1.Text = "Topic";
            // 
            // txtTicketTopic
            // 
            this.txtTicketTopic.Location = new System.Drawing.Point(254, 92);
            this.txtTicketTopic.Name = "txtTicketTopic";
            this.txtTicketTopic.Size = new System.Drawing.Size(166, 20);
            this.txtTicketTopic.TabIndex = 15;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(491, 358);
            this.btnClose.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(67, 34);
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lvCustomerSupport
            // 
            this.lvCustomerSupport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.lvCustomerSupport.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lvQueryID,
            this.lvTopic,
            this.lvCompleted});
            this.lvCustomerSupport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvCustomerSupport.GridLines = true;
            this.lvCustomerSupport.HideSelection = false;
            this.lvCustomerSupport.Location = new System.Drawing.Point(1, 108);
            this.lvCustomerSupport.Name = "lvCustomerSupport";
            this.lvCustomerSupport.Size = new System.Drawing.Size(247, 247);
            this.lvCustomerSupport.TabIndex = 17;
            this.lvCustomerSupport.TileSize = new System.Drawing.Size(228, 36);
            this.lvCustomerSupport.UseCompatibleStateImageBehavior = false;
            this.lvCustomerSupport.View = System.Windows.Forms.View.Details;
            // 
            // lvQueryID
            // 
            this.lvQueryID.Text = "Query ID";
            this.lvQueryID.Width = 200;
            // 
            // lvTopic
            // 
            this.lvTopic.Text = "Topic";
            this.lvTopic.Width = 241;
            // 
            // lvCompleted
            // 
            this.lvCompleted.Text = "Completed";
            this.lvCompleted.Width = 239;
            // 
            // Customer_CustomerSupport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(682, 405);
            this.Controls.Add(this.lvCustomerSupport);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtTicketTopic);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtTicketDescription);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTicketLastname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTicketFirstname);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "Customer_CustomerSupport";
            this.Text = "Customer_View_Queries";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTicketDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTicketLastname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTicketFirstname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTicketTopic;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ListView lvCustomerSupport;
        private System.Windows.Forms.ColumnHeader lvQueryID;
        private System.Windows.Forms.ColumnHeader lvTopic;
        private System.Windows.Forms.ColumnHeader lvCompleted;
    }
}