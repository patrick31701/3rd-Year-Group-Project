
namespace MainProject
{
    partial class Customer_Dashboard
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
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnRegLoyaltyCard = new System.Windows.Forms.Button();
            this.LvProductInfo = new System.Windows.Forms.ListView();
            this.chProdName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chProdPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chProdID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chProdType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbProdMenu = new System.Windows.Forms.ComboBox();
            this.btnAddCart = new System.Windows.Forms.Button();
            this.btnViewCart = new System.Windows.Forms.Button();
            this.btnCustomerSupport = new System.Windows.Forms.Button();
            this.btnResetPassword = new System.Windows.Forms.Button();
            this.btnWishlist = new System.Windows.Forms.Button();
            this.viewWishlist = new System.Windows.Forms.Button();
            this.quantity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.Window;
            this.btnLogout.Location = new System.Drawing.Point(628, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(92, 42);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.SystemColors.Window;
            this.lblWelcome.Location = new System.Drawing.Point(12, 31);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(252, 36);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Welcome, {User}";
            this.lblWelcome.Click += new System.EventHandler(this.lblWelcome_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.ForeColor = System.Drawing.SystemColors.Window;
            this.btnProfile.Location = new System.Drawing.Point(530, 12);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(92, 42);
            this.btnProfile.TabIndex = 2;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = false;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnRegLoyaltyCard
            // 
            this.btnRegLoyaltyCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnRegLoyaltyCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegLoyaltyCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegLoyaltyCard.ForeColor = System.Drawing.SystemColors.Window;
            this.btnRegLoyaltyCard.Location = new System.Drawing.Point(321, 12);
            this.btnRegLoyaltyCard.Name = "btnRegLoyaltyCard";
            this.btnRegLoyaltyCard.Size = new System.Drawing.Size(203, 42);
            this.btnRegLoyaltyCard.TabIndex = 3;
            this.btnRegLoyaltyCard.Text = "Register for Loyalty Card";
            this.btnRegLoyaltyCard.UseVisualStyleBackColor = false;
            this.btnRegLoyaltyCard.Click += new System.EventHandler(this.btnRegLoyaltyCard_Click);
            // 
            // LvProductInfo
            // 
            this.LvProductInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.LvProductInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chProdName,
            this.chProdPrice,
            this.chProdID,
            this.chProdType});
            this.LvProductInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LvProductInfo.ForeColor = System.Drawing.SystemColors.Window;
            this.LvProductInfo.GridLines = true;
            this.LvProductInfo.HideSelection = false;
            this.LvProductInfo.Location = new System.Drawing.Point(12, 143);
            this.LvProductInfo.Name = "LvProductInfo";
            this.LvProductInfo.Size = new System.Drawing.Size(530, 247);
            this.LvProductInfo.TabIndex = 4;
            this.LvProductInfo.TileSize = new System.Drawing.Size(228, 36);
            this.LvProductInfo.UseCompatibleStateImageBehavior = false;
            this.LvProductInfo.View = System.Windows.Forms.View.Details;
            this.LvProductInfo.DoubleClick += new System.EventHandler(this.ViewProductDetails);
            // 
            // chProdName
            // 
            this.chProdName.Text = "Product name";
            this.chProdName.Width = 450;
            // 
            // chProdPrice
            // 
            this.chProdPrice.Text = "Price";
            this.chProdPrice.Width = 76;
            // 
            // chProdID
            // 
            this.chProdID.Text = "Product ID";
            this.chProdID.Width = 89;
            // 
            // chProdType
            // 
            this.chProdType.Text = "Product Type";
            this.chProdType.Width = 171;
            // 
            // cbProdMenu
            // 
            this.cbProdMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.cbProdMenu.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProdMenu.ForeColor = System.Drawing.SystemColors.Window;
            this.cbProdMenu.FormattingEnabled = true;
            this.cbProdMenu.Items.AddRange(new object[] {
            "Fresh Produce",
            "Meat",
            "Bakery",
            "Drinks",
            "Baby Products"});
            this.cbProdMenu.Location = new System.Drawing.Point(12, 110);
            this.cbProdMenu.Name = "cbProdMenu";
            this.cbProdMenu.Size = new System.Drawing.Size(136, 27);
            this.cbProdMenu.TabIndex = 5;
            this.cbProdMenu.Text = "All Products";
            this.cbProdMenu.SelectedIndexChanged += new System.EventHandler(this.cbProdMenu_SelectedIndexChanged);
            // 
            // btnAddCart
            // 
            this.btnAddCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnAddCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCart.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAddCart.Location = new System.Drawing.Point(546, 212);
            this.btnAddCart.Name = "btnAddCart";
            this.btnAddCart.Size = new System.Drawing.Size(123, 49);
            this.btnAddCart.TabIndex = 6;
            this.btnAddCart.Text = "Add to Cart";
            this.btnAddCart.UseVisualStyleBackColor = false;
            this.btnAddCart.Click += new System.EventHandler(this.btnAddCart_Click);
            // 
            // btnViewCart
            // 
            this.btnViewCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnViewCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewCart.ForeColor = System.Drawing.SystemColors.Window;
            this.btnViewCart.Location = new System.Drawing.Point(546, 333);
            this.btnViewCart.Name = "btnViewCart";
            this.btnViewCart.Size = new System.Drawing.Size(123, 49);
            this.btnViewCart.TabIndex = 8;
            this.btnViewCart.Text = "View Cart";
            this.btnViewCart.UseVisualStyleBackColor = false;
            this.btnViewCart.Click += new System.EventHandler(this.btnViewCart_Click);
            // 
            // btnCustomerSupport
            // 
            this.btnCustomerSupport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnCustomerSupport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomerSupport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerSupport.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCustomerSupport.Location = new System.Drawing.Point(530, 60);
            this.btnCustomerSupport.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnCustomerSupport.Name = "btnCustomerSupport";
            this.btnCustomerSupport.Size = new System.Drawing.Size(92, 42);
            this.btnCustomerSupport.TabIndex = 9;
            this.btnCustomerSupport.Text = "Customer Support";
            this.btnCustomerSupport.UseVisualStyleBackColor = false;
            this.btnCustomerSupport.Click += new System.EventHandler(this.btnCustomerSupport_Click);
            // 
            // btnResetPassword
            // 
            this.btnResetPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnResetPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetPassword.ForeColor = System.Drawing.SystemColors.Window;
            this.btnResetPassword.Location = new System.Drawing.Point(628, 60);
            this.btnResetPassword.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnResetPassword.Name = "btnResetPassword";
            this.btnResetPassword.Size = new System.Drawing.Size(92, 42);
            this.btnResetPassword.TabIndex = 10;
            this.btnResetPassword.Text = "Reset Password";
            this.btnResetPassword.UseVisualStyleBackColor = false;
            this.btnResetPassword.Click += new System.EventHandler(this.btnResetPassword_Click);
            // 
            // btnWishlist
            // 
            this.btnWishlist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnWishlist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWishlist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWishlist.ForeColor = System.Drawing.SystemColors.Window;
            this.btnWishlist.Location = new System.Drawing.Point(546, 143);
            this.btnWishlist.Name = "btnWishlist";
            this.btnWishlist.Size = new System.Drawing.Size(123, 49);
            this.btnWishlist.TabIndex = 11;
            this.btnWishlist.Text = "Add to wishlist";
            this.btnWishlist.UseVisualStyleBackColor = false;
            this.btnWishlist.Click += new System.EventHandler(this.btnWishlist_Click);
            // 
            // viewWishlist
            // 
            this.viewWishlist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.viewWishlist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewWishlist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewWishlist.ForeColor = System.Drawing.SystemColors.Window;
            this.viewWishlist.Location = new System.Drawing.Point(321, 60);
            this.viewWishlist.Name = "viewWishlist";
            this.viewWishlist.Size = new System.Drawing.Size(203, 42);
            this.viewWishlist.TabIndex = 12;
            this.viewWishlist.Text = "View Wishlist";
            this.viewWishlist.UseVisualStyleBackColor = false;
            this.viewWishlist.Click += new System.EventHandler(this.viewWishlist_Click);
            // 
            // quantity
            // 
            this.quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantity.Location = new System.Drawing.Point(614, 282);
            this.quantity.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(66, 23);
            this.quantity.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(544, 282);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 19);
            this.label1.TabIndex = 14;
            this.label1.Text = "Quantity: ";
            // 
            // Customer_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(738, 410);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.viewWishlist);
            this.Controls.Add(this.btnWishlist);
            this.Controls.Add(this.btnResetPassword);
            this.Controls.Add(this.btnCustomerSupport);
            this.Controls.Add(this.btnViewCart);
            this.Controls.Add(this.btnAddCart);
            this.Controls.Add(this.cbProdMenu);
            this.Controls.Add(this.LvProductInfo);
            this.Controls.Add(this.btnRegLoyaltyCard);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnLogout);
            this.Name = "Customer_Dashboard";
            this.Text = "Customer_Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnRegLoyaltyCard;
        private System.Windows.Forms.ListView LvProductInfo;
        private System.Windows.Forms.ComboBox cbProdMenu;
        private System.Windows.Forms.ColumnHeader chProdName;
        private System.Windows.Forms.ColumnHeader chProdPrice;
        private System.Windows.Forms.Button btnAddCart;
        private System.Windows.Forms.Button btnViewCart;
        private System.Windows.Forms.Button btnCustomerSupport;
        private System.Windows.Forms.Button btnResetPassword;
        private System.Windows.Forms.ColumnHeader chProdID;
        private System.Windows.Forms.Button btnWishlist;
        private System.Windows.Forms.Button viewWishlist;
        private System.Windows.Forms.TextBox quantity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader chProdType;
    }
}