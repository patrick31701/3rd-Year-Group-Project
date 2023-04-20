
namespace MainProject
{
    partial class View_StaffDetails
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
            this.lvStaffDetails = new System.Windows.Forms.ListView();
            this.chStaffID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblOrder_StockOrder = new System.Windows.Forms.Label();
            this.pnlFormLoader = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbStaffType_MNGStaffDetails = new System.Windows.Forms.TextBox();
            this.tbPassword_MNGStaffDetails = new System.Windows.Forms.TextBox();
            this.tbEmail_MNGStaffDetails = new System.Windows.Forms.TextBox();
            this.tbMobileNumber_MNGStaffDetails = new System.Windows.Forms.TextBox();
            this.tbStaffID_MNGStaffDetails = new System.Windows.Forms.TextBox();
            this.tbLastName_MNGStaffDetails = new System.Windows.Forms.TextBox();
            this.tbFirstName_MNGStaffDetails = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlFormLoader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lvStaffDetails
            // 
            this.lvStaffDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.lvStaffDetails.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chStaffID,
            this.chName});
            this.lvStaffDetails.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvStaffDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lvStaffDetails.FullRowSelect = true;
            this.lvStaffDetails.HideSelection = false;
            this.lvStaffDetails.Location = new System.Drawing.Point(35, 40);
            this.lvStaffDetails.Name = "lvStaffDetails";
            this.lvStaffDetails.Size = new System.Drawing.Size(450, 429);
            this.lvStaffDetails.TabIndex = 65;
            this.lvStaffDetails.UseCompatibleStateImageBehavior = false;
            this.lvStaffDetails.View = System.Windows.Forms.View.Details;
            this.lvStaffDetails.SelectedIndexChanged += new System.EventHandler(this.lvStaffDetails_SelectedIndexChanged);
            // 
            // chStaffID
            // 
            this.chStaffID.Text = "Staff ID";
            this.chStaffID.Width = 150;
            // 
            // chName
            // 
            this.chName.Text = "Name";
            this.chName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chName.Width = 150;
            // 
            // lblOrder_StockOrder
            // 
            this.lblOrder_StockOrder.AutoSize = true;
            this.lblOrder_StockOrder.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrder_StockOrder.Location = new System.Drawing.Point(303, -35);
            this.lblOrder_StockOrder.Name = "lblOrder_StockOrder";
            this.lblOrder_StockOrder.Size = new System.Drawing.Size(182, 41);
            this.lblOrder_StockOrder.TabIndex = 50;
            this.lblOrder_StockOrder.Text = "Staff Details";
            // 
            // pnlFormLoader
            // 
            this.pnlFormLoader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.pnlFormLoader.Controls.Add(this.pictureBox1);
            this.pnlFormLoader.Controls.Add(this.label8);
            this.pnlFormLoader.Controls.Add(this.label7);
            this.pnlFormLoader.Controls.Add(this.label6);
            this.pnlFormLoader.Controls.Add(this.label5);
            this.pnlFormLoader.Controls.Add(this.label4);
            this.pnlFormLoader.Controls.Add(this.label3);
            this.pnlFormLoader.Controls.Add(this.label2);
            this.pnlFormLoader.Controls.Add(this.label1);
            this.pnlFormLoader.Controls.Add(this.tbStaffType_MNGStaffDetails);
            this.pnlFormLoader.Controls.Add(this.tbPassword_MNGStaffDetails);
            this.pnlFormLoader.Controls.Add(this.tbEmail_MNGStaffDetails);
            this.pnlFormLoader.Controls.Add(this.tbMobileNumber_MNGStaffDetails);
            this.pnlFormLoader.Controls.Add(this.tbStaffID_MNGStaffDetails);
            this.pnlFormLoader.Controls.Add(this.tbLastName_MNGStaffDetails);
            this.pnlFormLoader.Controls.Add(this.tbFirstName_MNGStaffDetails);
            this.pnlFormLoader.Location = new System.Drawing.Point(511, -1);
            this.pnlFormLoader.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlFormLoader.Name = "pnlFormLoader";
            this.pnlFormLoader.Size = new System.Drawing.Size(554, 655);
            this.pnlFormLoader.TabIndex = 67;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.label8.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label8.Location = new System.Drawing.Point(198, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(210, 45);
            this.label8.TabIndex = 81;
            this.label8.Text = "Staff Details";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label7.Location = new System.Drawing.Point(213, 481);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 23);
            this.label7.TabIndex = 80;
            this.label7.Text = "Mobile Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label6.Location = new System.Drawing.Point(403, 362);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 23);
            this.label6.TabIndex = 79;
            this.label6.Text = "Staff Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label5.Location = new System.Drawing.Point(70, 362);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 23);
            this.label5.TabIndex = 78;
            this.label5.Text = "Staff ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label4.Location = new System.Drawing.Point(403, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 23);
            this.label4.TabIndex = 77;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label3.Location = new System.Drawing.Point(77, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 23);
            this.label3.TabIndex = 76;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label2.Location = new System.Drawing.Point(403, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 23);
            this.label2.TabIndex = 75;
            this.label2.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label1.Location = new System.Drawing.Point(58, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 23);
            this.label1.TabIndex = 74;
            this.label1.Text = "First Name";
            // 
            // tbStaffType_MNGStaffDetails
            // 
            this.tbStaffType_MNGStaffDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.tbStaffType_MNGStaffDetails.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStaffType_MNGStaffDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.tbStaffType_MNGStaffDetails.Location = new System.Drawing.Point(361, 388);
            this.tbStaffType_MNGStaffDetails.Multiline = true;
            this.tbStaffType_MNGStaffDetails.Name = "tbStaffType_MNGStaffDetails";
            this.tbStaffType_MNGStaffDetails.Size = new System.Drawing.Size(169, 39);
            this.tbStaffType_MNGStaffDetails.TabIndex = 73;
            this.tbStaffType_MNGStaffDetails.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbPassword_MNGStaffDetails
            // 
            this.tbPassword_MNGStaffDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.tbPassword_MNGStaffDetails.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword_MNGStaffDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.tbPassword_MNGStaffDetails.Location = new System.Drawing.Point(361, 259);
            this.tbPassword_MNGStaffDetails.Multiline = true;
            this.tbPassword_MNGStaffDetails.Name = "tbPassword_MNGStaffDetails";
            this.tbPassword_MNGStaffDetails.Size = new System.Drawing.Size(169, 39);
            this.tbPassword_MNGStaffDetails.TabIndex = 72;
            this.tbPassword_MNGStaffDetails.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbEmail_MNGStaffDetails
            // 
            this.tbEmail_MNGStaffDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.tbEmail_MNGStaffDetails.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail_MNGStaffDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.tbEmail_MNGStaffDetails.Location = new System.Drawing.Point(18, 259);
            this.tbEmail_MNGStaffDetails.Multiline = true;
            this.tbEmail_MNGStaffDetails.Name = "tbEmail_MNGStaffDetails";
            this.tbEmail_MNGStaffDetails.Size = new System.Drawing.Size(169, 39);
            this.tbEmail_MNGStaffDetails.TabIndex = 71;
            this.tbEmail_MNGStaffDetails.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbMobileNumber_MNGStaffDetails
            // 
            this.tbMobileNumber_MNGStaffDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.tbMobileNumber_MNGStaffDetails.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMobileNumber_MNGStaffDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.tbMobileNumber_MNGStaffDetails.Location = new System.Drawing.Point(192, 507);
            this.tbMobileNumber_MNGStaffDetails.Multiline = true;
            this.tbMobileNumber_MNGStaffDetails.Name = "tbMobileNumber_MNGStaffDetails";
            this.tbMobileNumber_MNGStaffDetails.Size = new System.Drawing.Size(169, 39);
            this.tbMobileNumber_MNGStaffDetails.TabIndex = 70;
            this.tbMobileNumber_MNGStaffDetails.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbStaffID_MNGStaffDetails
            // 
            this.tbStaffID_MNGStaffDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.tbStaffID_MNGStaffDetails.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStaffID_MNGStaffDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.tbStaffID_MNGStaffDetails.Location = new System.Drawing.Point(18, 388);
            this.tbStaffID_MNGStaffDetails.Multiline = true;
            this.tbStaffID_MNGStaffDetails.Name = "tbStaffID_MNGStaffDetails";
            this.tbStaffID_MNGStaffDetails.Size = new System.Drawing.Size(169, 39);
            this.tbStaffID_MNGStaffDetails.TabIndex = 69;
            this.tbStaffID_MNGStaffDetails.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbLastName_MNGStaffDetails
            // 
            this.tbLastName_MNGStaffDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.tbLastName_MNGStaffDetails.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLastName_MNGStaffDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.tbLastName_MNGStaffDetails.Location = new System.Drawing.Point(361, 124);
            this.tbLastName_MNGStaffDetails.Multiline = true;
            this.tbLastName_MNGStaffDetails.Name = "tbLastName_MNGStaffDetails";
            this.tbLastName_MNGStaffDetails.Size = new System.Drawing.Size(169, 39);
            this.tbLastName_MNGStaffDetails.TabIndex = 68;
            this.tbLastName_MNGStaffDetails.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbFirstName_MNGStaffDetails
            // 
            this.tbFirstName_MNGStaffDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.tbFirstName_MNGStaffDetails.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFirstName_MNGStaffDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.tbFirstName_MNGStaffDetails.Location = new System.Drawing.Point(18, 124);
            this.tbFirstName_MNGStaffDetails.Multiline = true;
            this.tbFirstName_MNGStaffDetails.Name = "tbFirstName_MNGStaffDetails";
            this.tbFirstName_MNGStaffDetails.Size = new System.Drawing.Size(169, 39);
            this.tbFirstName_MNGStaffDetails.TabIndex = 67;
            this.tbFirstName_MNGStaffDetails.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::MainProject.Properties.Resources.Untitled_11;
            this.pictureBox1.Location = new System.Drawing.Point(161, 41);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 82;
            this.pictureBox1.TabStop = false;
            // 
            // View_StaffDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1062, 653);
            this.Controls.Add(this.pnlFormLoader);
            this.Controls.Add(this.lvStaffDetails);
            this.Controls.Add(this.lblOrder_StockOrder);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.Name = "View_StaffDetails";
            this.Text = "View_StaffDetails";
            this.Load += new System.EventHandler(this.View_StaffDetails_Load);
            this.pnlFormLoader.ResumeLayout(false);
            this.pnlFormLoader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvStaffDetails;
        private System.Windows.Forms.ColumnHeader chStaffID;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.Label lblOrder_StockOrder;
        private System.Windows.Forms.Panel pnlFormLoader;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbStaffType_MNGStaffDetails;
        private System.Windows.Forms.TextBox tbPassword_MNGStaffDetails;
        private System.Windows.Forms.TextBox tbEmail_MNGStaffDetails;
        private System.Windows.Forms.TextBox tbMobileNumber_MNGStaffDetails;
        private System.Windows.Forms.TextBox tbStaffID_MNGStaffDetails;
        private System.Windows.Forms.TextBox tbLastName_MNGStaffDetails;
        private System.Windows.Forms.TextBox tbFirstName_MNGStaffDetails;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}