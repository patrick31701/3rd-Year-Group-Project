
namespace MainProject
{
    partial class CSStaff_Dashboard
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
            this.lvProducts = new System.Windows.Forms.ListView();
            this.chProdName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chProdCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chProdPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chProdQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.cbProdMenu = new System.Windows.Forms.ComboBox();
            this.btnViewTickets = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvProducts
            // 
            this.lvProducts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chProdName,
            this.chProdCode,
            this.chProdPrice,
            this.chProdQuantity});
            this.lvProducts.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvProducts.FullRowSelect = true;
            this.lvProducts.GridLines = true;
            this.lvProducts.HideSelection = false;
            this.lvProducts.Location = new System.Drawing.Point(12, 140);
            this.lvProducts.Name = "lvProducts";
            this.lvProducts.Size = new System.Drawing.Size(680, 274);
            this.lvProducts.TabIndex = 0;
            this.lvProducts.UseCompatibleStateImageBehavior = false;
            this.lvProducts.View = System.Windows.Forms.View.Details;
            this.lvProducts.DoubleClick += new System.EventHandler(this.view_product_details);
            // 
            // chProdName
            // 
            this.chProdName.Text = "Product Name";
            this.chProdName.Width = 400;
            // 
            // chProdCode
            // 
            this.chProdCode.Text = "Code";
            this.chProdCode.Width = 100;
            // 
            // chProdPrice
            // 
            this.chProdPrice.Text = "Price";
            this.chProdPrice.Width = 90;
            // 
            // chProdQuantity
            // 
            this.chProdQuantity.Text = "Quantity";
            this.chProdQuantity.Width = 86;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Tw Cen MT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(12, 34);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(235, 37);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Welcome, {User}";
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Tw Cen MT", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(605, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(87, 34);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // cbProdMenu
            // 
            this.cbProdMenu.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProdMenu.FormattingEnabled = true;
            this.cbProdMenu.Items.AddRange(new object[] {
            "All",
            "Fresh Bakery",
            "Meat",
            "Dairy",
            "Drinks",
            "Baby Products"});
            this.cbProdMenu.Location = new System.Drawing.Point(12, 107);
            this.cbProdMenu.Name = "cbProdMenu";
            this.cbProdMenu.Size = new System.Drawing.Size(136, 27);
            this.cbProdMenu.TabIndex = 3;
            this.cbProdMenu.SelectedIndexChanged += new System.EventHandler(this.changeProducts);
            // 
            // btnViewTickets
            // 
            this.btnViewTickets.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewTickets.Location = new System.Drawing.Point(572, 81);
            this.btnViewTickets.Name = "btnViewTickets";
            this.btnViewTickets.Size = new System.Drawing.Size(120, 53);
            this.btnViewTickets.TabIndex = 4;
            this.btnViewTickets.Text = "Customer Tickets";
            this.btnViewTickets.UseVisualStyleBackColor = true;
            this.btnViewTickets.Click += new System.EventHandler(this.btnViewTickets_Click);
            // 
            // CSStaff_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 427);
            this.Controls.Add(this.btnViewTickets);
            this.Controls.Add(this.cbProdMenu);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.lvProducts);
            this.Name = "CSStaff_Dashboard";
            this.Text = "CSStaff_Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvProducts;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.ComboBox cbProdMenu;
        private System.Windows.Forms.ColumnHeader chProdName;
        private System.Windows.Forms.ColumnHeader chProdCode;
        private System.Windows.Forms.ColumnHeader chProdPrice;
        private System.Windows.Forms.ColumnHeader chProdQuantity;
        private System.Windows.Forms.Button btnViewTickets;
    }
}