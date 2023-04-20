
namespace MainProject
{
    partial class WStaff_Dashboard
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
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lvProducts = new System.Windows.Forms.ListView();
            this.chProdName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chProdCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chProdPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chProdQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbProdMenu = new System.Windows.Forms.ComboBox();
            this.btnRequestStock = new System.Windows.Forms.Button();
            this.btnOnlineOrders = new System.Windows.Forms.Button();
            this.Messaging = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Tw Cen MT", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(606, 13);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(82, 40);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Tw Cen MT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(7, 20);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(235, 37);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Welcome, {User}";
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
            this.lvProducts.Location = new System.Drawing.Point(7, 106);
            this.lvProducts.Margin = new System.Windows.Forms.Padding(2);
            this.lvProducts.Name = "lvProducts";
            this.lvProducts.Size = new System.Drawing.Size(681, 288);
            this.lvProducts.TabIndex = 2;
            this.lvProducts.UseCompatibleStateImageBehavior = false;
            this.lvProducts.View = System.Windows.Forms.View.Details;
            this.lvProducts.SelectedIndexChanged += new System.EventHandler(this.lvProducts_SelectedIndexChanged);
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
            this.cbProdMenu.Location = new System.Drawing.Point(7, 75);
            this.cbProdMenu.Margin = new System.Windows.Forms.Padding(2);
            this.cbProdMenu.Name = "cbProdMenu";
            this.cbProdMenu.Size = new System.Drawing.Size(217, 27);
            this.cbProdMenu.TabIndex = 3;
            this.cbProdMenu.SelectedIndexChanged += new System.EventHandler(this.changeProducts);
            // 
            // btnRequestStock
            // 
            this.btnRequestStock.Font = new System.Drawing.Font("Tw Cen MT", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRequestStock.Location = new System.Drawing.Point(559, 57);
            this.btnRequestStock.Margin = new System.Windows.Forms.Padding(2);
            this.btnRequestStock.Name = "btnRequestStock";
            this.btnRequestStock.Size = new System.Drawing.Size(129, 45);
            this.btnRequestStock.TabIndex = 4;
            this.btnRequestStock.Text = "Request Stock";
            this.btnRequestStock.UseVisualStyleBackColor = true;
            this.btnRequestStock.Click += new System.EventHandler(this.btnRequestStock_Click);
            // 
            // btnOnlineOrders
            // 
            this.btnOnlineOrders.Font = new System.Drawing.Font("Tw Cen MT", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOnlineOrders.Location = new System.Drawing.Point(424, 57);
            this.btnOnlineOrders.Margin = new System.Windows.Forms.Padding(2);
            this.btnOnlineOrders.Name = "btnOnlineOrders";
            this.btnOnlineOrders.Size = new System.Drawing.Size(131, 45);
            this.btnOnlineOrders.TabIndex = 5;
            this.btnOnlineOrders.Text = "Online Orders";
            this.btnOnlineOrders.UseVisualStyleBackColor = true;
            this.btnOnlineOrders.Click += new System.EventHandler(this.btnOnlineOrders_Click);
            // 
            // Messaging
            // 
            this.Messaging.Font = new System.Drawing.Font("Tw Cen MT", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Messaging.Location = new System.Drawing.Point(309, 57);
            this.Messaging.Margin = new System.Windows.Forms.Padding(2);
            this.Messaging.Name = "Messaging";
            this.Messaging.Size = new System.Drawing.Size(111, 45);
            this.Messaging.TabIndex = 6;
            this.Messaging.Text = "Messages";
            this.Messaging.UseVisualStyleBackColor = true;
            this.Messaging.Click += new System.EventHandler(this.Messaging_Click);
            // 
            // WStaff_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 405);
            this.Controls.Add(this.Messaging);
            this.Controls.Add(this.btnOnlineOrders);
            this.Controls.Add(this.btnRequestStock);
            this.Controls.Add(this.cbProdMenu);
            this.Controls.Add(this.lvProducts);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnLogout);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "WStaff_Dashboard";
            this.Text = "WStaff_Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.ListView lvProducts;
        private System.Windows.Forms.ColumnHeader chProdName;
        private System.Windows.Forms.ColumnHeader chProdCode;
        private System.Windows.Forms.ColumnHeader chProdPrice;
        private System.Windows.Forms.ColumnHeader chProdQuantity;
        private System.Windows.Forms.ComboBox cbProdMenu;
        private System.Windows.Forms.Button btnRequestStock;
        private System.Windows.Forms.Button btnOnlineOrders;
        private System.Windows.Forms.Button Messaging;
    }
}