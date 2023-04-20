
namespace MainProject
{
    partial class Manager_Dashboard
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
            this.lblNumStaff = new System.Windows.Forms.Label();
            this.lblNumStockOrders = new System.Windows.Forms.Label();
            this.gbDetails = new System.Windows.Forms.GroupBox();
            this.txtNoOfStockOrders = new System.Windows.Forms.TextBox();
            this.txtNoOfProducts = new System.Windows.Forms.TextBox();
            this.txtNoOfCustomers = new System.Windows.Forms.TextBox();
            this.txtNoOfStaff = new System.Windows.Forms.TextBox();
            this.txtNumOfStaff = new System.Windows.Forms.TextBox();
            this.lblProducts = new System.Windows.Forms.Label();
            this.lblNumOfCustomers = new System.Windows.Forms.Label();
            this.lvProducts = new System.Windows.Forms.ListView();
            this.chProdName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chProdCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chProdPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chProdQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbProdMenu = new System.Windows.Forms.ComboBox();
            this.btnStockOrders = new System.Windows.Forms.Button();
            this.btnMessages = new System.Windows.Forms.Button();
            this.btnProductDetails = new System.Windows.Forms.Button();
            this.btnStaffDetails = new System.Windows.Forms.Button();
            this.btnPurchaseHistory = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEmail = new System.Windows.Forms.Button();
            this.btnViewStaffDetails = new System.Windows.Forms.Button();
            this.gbDetails.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnLogout.Location = new System.Drawing.Point(935, 11);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(99, 48);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Visible = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.Black;
            this.lblWelcome.Location = new System.Drawing.Point(62, 62);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(275, 45);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Welcome, {User}";
            // 
            // lblNumStaff
            // 
            this.lblNumStaff.AutoSize = true;
            this.lblNumStaff.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumStaff.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblNumStaff.Location = new System.Drawing.Point(17, 15);
            this.lblNumStaff.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumStaff.Name = "lblNumStaff";
            this.lblNumStaff.Size = new System.Drawing.Size(64, 28);
            this.lblNumStaff.TabIndex = 2;
            this.lblNumStaff.Text = "Staff :";
            this.lblNumStaff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNumStockOrders
            // 
            this.lblNumStockOrders.AutoSize = true;
            this.lblNumStockOrders.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumStockOrders.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblNumStockOrders.Location = new System.Drawing.Point(17, 142);
            this.lblNumStockOrders.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumStockOrders.Name = "lblNumStockOrders";
            this.lblNumStockOrders.Size = new System.Drawing.Size(139, 28);
            this.lblNumStockOrders.TabIndex = 3;
            this.lblNumStockOrders.Text = "Stock Orders :";
            this.lblNumStockOrders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblNumStockOrders.Click += new System.EventHandler(this.lblNumStockOrders_Click);
            // 
            // gbDetails
            // 
            this.gbDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.gbDetails.Controls.Add(this.txtNoOfStockOrders);
            this.gbDetails.Controls.Add(this.txtNoOfProducts);
            this.gbDetails.Controls.Add(this.txtNoOfCustomers);
            this.gbDetails.Controls.Add(this.txtNoOfStaff);
            this.gbDetails.Controls.Add(this.txtNumOfStaff);
            this.gbDetails.Controls.Add(this.lblProducts);
            this.gbDetails.Controls.Add(this.lblNumOfCustomers);
            this.gbDetails.Controls.Add(this.lblNumStockOrders);
            this.gbDetails.Controls.Add(this.lblNumStaff);
            this.gbDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbDetails.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.gbDetails.Location = new System.Drawing.Point(717, 104);
            this.gbDetails.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.gbDetails.Name = "gbDetails";
            this.gbDetails.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbDetails.Size = new System.Drawing.Size(317, 190);
            this.gbDetails.TabIndex = 4;
            this.gbDetails.TabStop = false;
            this.gbDetails.Text = "Statistics";
            this.gbDetails.Enter += new System.EventHandler(this.gbDetails_Enter);
            // 
            // txtNoOfStockOrders
            // 
            this.txtNoOfStockOrders.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtNoOfStockOrders.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoOfStockOrders.ForeColor = System.Drawing.Color.Red;
            this.txtNoOfStockOrders.Location = new System.Drawing.Point(253, 144);
            this.txtNoOfStockOrders.Name = "txtNoOfStockOrders";
            this.txtNoOfStockOrders.Size = new System.Drawing.Size(42, 30);
            this.txtNoOfStockOrders.TabIndex = 18;
            this.txtNoOfStockOrders.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNoOfProducts
            // 
            this.txtNoOfProducts.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtNoOfProducts.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoOfProducts.ForeColor = System.Drawing.Color.Red;
            this.txtNoOfProducts.Location = new System.Drawing.Point(253, 101);
            this.txtNoOfProducts.Name = "txtNoOfProducts";
            this.txtNoOfProducts.Size = new System.Drawing.Size(42, 30);
            this.txtNoOfProducts.TabIndex = 17;
            this.txtNoOfProducts.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNoOfCustomers
            // 
            this.txtNoOfCustomers.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtNoOfCustomers.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoOfCustomers.ForeColor = System.Drawing.Color.Red;
            this.txtNoOfCustomers.Location = new System.Drawing.Point(253, 59);
            this.txtNoOfCustomers.Name = "txtNoOfCustomers";
            this.txtNoOfCustomers.Size = new System.Drawing.Size(42, 30);
            this.txtNoOfCustomers.TabIndex = 16;
            this.txtNoOfCustomers.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNoOfStaff
            // 
            this.txtNoOfStaff.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtNoOfStaff.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoOfStaff.ForeColor = System.Drawing.Color.Red;
            this.txtNoOfStaff.Location = new System.Drawing.Point(253, 17);
            this.txtNoOfStaff.Name = "txtNoOfStaff";
            this.txtNoOfStaff.Size = new System.Drawing.Size(42, 30);
            this.txtNoOfStaff.TabIndex = 14;
            this.txtNoOfStaff.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNumOfStaff
            // 
            this.txtNumOfStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txtNumOfStaff.Location = new System.Drawing.Point(328, 22);
            this.txtNumOfStaff.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtNumOfStaff.Name = "txtNumOfStaff";
            this.txtNumOfStaff.Size = new System.Drawing.Size(64, 26);
            this.txtNumOfStaff.TabIndex = 11;
            // 
            // lblProducts
            // 
            this.lblProducts.AutoSize = true;
            this.lblProducts.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblProducts.Location = new System.Drawing.Point(17, 99);
            this.lblProducts.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProducts.Name = "lblProducts";
            this.lblProducts.Size = new System.Drawing.Size(103, 28);
            this.lblProducts.TabIndex = 10;
            this.lblProducts.Text = "Products :";
            this.lblProducts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNumOfCustomers
            // 
            this.lblNumOfCustomers.AutoSize = true;
            this.lblNumOfCustomers.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumOfCustomers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblNumOfCustomers.Location = new System.Drawing.Point(17, 56);
            this.lblNumOfCustomers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumOfCustomers.Name = "lblNumOfCustomers";
            this.lblNumOfCustomers.Size = new System.Drawing.Size(120, 28);
            this.lblNumOfCustomers.TabIndex = 9;
            this.lblNumOfCustomers.Text = "Customers :";
            this.lblNumOfCustomers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lvProducts
            // 
            this.lvProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.lvProducts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chProdName,
            this.chProdCode,
            this.chProdPrice,
            this.chProdQuantity});
            this.lvProducts.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvProducts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lvProducts.GridLines = true;
            this.lvProducts.HideSelection = false;
            this.lvProducts.Location = new System.Drawing.Point(429, 313);
            this.lvProducts.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.lvProducts.Name = "lvProducts";
            this.lvProducts.Size = new System.Drawing.Size(603, 373);
            this.lvProducts.TabIndex = 5;
            this.lvProducts.UseCompatibleStateImageBehavior = false;
            this.lvProducts.View = System.Windows.Forms.View.Details;
            // 
            // chProdName
            // 
            this.chProdName.Text = "Product Name";
            this.chProdName.Width = 250;
            // 
            // chProdCode
            // 
            this.chProdCode.Text = "Code";
            this.chProdCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chProdCode.Width = 118;
            // 
            // chProdPrice
            // 
            this.chProdPrice.Text = "Price";
            this.chProdPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chProdPrice.Width = 118;
            // 
            // chProdQuantity
            // 
            this.chProdQuantity.Text = "Quantity";
            this.chProdQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chProdQuantity.Width = 118;
            // 
            // cbProdMenu
            // 
            this.cbProdMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.cbProdMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbProdMenu.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProdMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.cbProdMenu.FormattingEnabled = true;
            this.cbProdMenu.Items.AddRange(new object[] {
            "Fresh Produce",
            "Meat",
            "Bakery",
            "Drinks",
            "Baby Products"});
            this.cbProdMenu.Location = new System.Drawing.Point(429, 263);
            this.cbProdMenu.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cbProdMenu.Name = "cbProdMenu";
            this.cbProdMenu.Size = new System.Drawing.Size(261, 31);
            this.cbProdMenu.TabIndex = 10;
            // 
            // btnStockOrders
            // 
            this.btnStockOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnStockOrders.FlatAppearance.BorderSize = 0;
            this.btnStockOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStockOrders.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockOrders.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnStockOrders.Location = new System.Drawing.Point(201, 314);
            this.btnStockOrders.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnStockOrders.Name = "btnStockOrders";
            this.btnStockOrders.Size = new System.Drawing.Size(195, 100);
            this.btnStockOrders.TabIndex = 8;
            this.btnStockOrders.Text = "Stock Orders";
            this.btnStockOrders.UseVisualStyleBackColor = true;
            this.btnStockOrders.Click += new System.EventHandler(this.btnStockOrders_Click);
            // 
            // btnMessages
            // 
            this.btnMessages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnMessages.FlatAppearance.BorderSize = 0;
            this.btnMessages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMessages.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMessages.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnMessages.Location = new System.Drawing.Point(4, 414);
            this.btnMessages.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnMessages.Name = "btnMessages";
            this.btnMessages.Size = new System.Drawing.Size(195, 100);
            this.btnMessages.TabIndex = 9;
            this.btnMessages.Text = "Messages";
            this.btnMessages.UseVisualStyleBackColor = true;
            this.btnMessages.Click += new System.EventHandler(this.btnMessages_Click);
            // 
            // btnProductDetails
            // 
            this.btnProductDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnProductDetails.FlatAppearance.BorderSize = 0;
            this.btnProductDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductDetails.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnProductDetails.Location = new System.Drawing.Point(4, 518);
            this.btnProductDetails.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnProductDetails.Name = "btnProductDetails";
            this.btnProductDetails.Size = new System.Drawing.Size(195, 100);
            this.btnProductDetails.TabIndex = 7;
            this.btnProductDetails.Text = "Product Details";
            this.btnProductDetails.UseVisualStyleBackColor = true;
            this.btnProductDetails.Click += new System.EventHandler(this.btnProductDetails_Click);
            // 
            // btnStaffDetails
            // 
            this.btnStaffDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnStaffDetails.FlatAppearance.BorderSize = 0;
            this.btnStaffDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStaffDetails.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaffDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnStaffDetails.Location = new System.Drawing.Point(201, 518);
            this.btnStaffDetails.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnStaffDetails.Name = "btnStaffDetails";
            this.btnStaffDetails.Size = new System.Drawing.Size(195, 100);
            this.btnStaffDetails.TabIndex = 6;
            this.btnStaffDetails.Text = "Edit Staff Details";
            this.btnStaffDetails.UseVisualStyleBackColor = true;
            this.btnStaffDetails.Click += new System.EventHandler(this.btnStaffDetails_Click);
            // 
            // btnPurchaseHistory
            // 
            this.btnPurchaseHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnPurchaseHistory.FlatAppearance.BorderSize = 0;
            this.btnPurchaseHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPurchaseHistory.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPurchaseHistory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnPurchaseHistory.Location = new System.Drawing.Point(4, 214);
            this.btnPurchaseHistory.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnPurchaseHistory.Name = "btnPurchaseHistory";
            this.btnPurchaseHistory.Size = new System.Drawing.Size(389, 100);
            this.btnPurchaseHistory.TabIndex = 11;
            this.btnPurchaseHistory.Text = "Purchase History";
            this.btnPurchaseHistory.UseVisualStyleBackColor = true;
            this.btnPurchaseHistory.Click += new System.EventHandler(this.btnPurchaseHistory_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.btnViewStaffDetails);
            this.panel1.Controls.Add(this.btnEmail);
            this.panel1.Controls.Add(this.btnPurchaseHistory);
            this.panel1.Controls.Add(this.btnStockOrders);
            this.panel1.Controls.Add(this.btnStaffDetails);
            this.panel1.Controls.Add(this.lblWelcome);
            this.panel1.Controls.Add(this.btnMessages);
            this.panel1.Controls.Add(this.btnProductDetails);
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Location = new System.Drawing.Point(-7, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(397, 694);
            this.panel1.TabIndex = 12;
            // 
            // btnEmail
            // 
            this.btnEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnEmail.FlatAppearance.BorderSize = 0;
            this.btnEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmail.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnEmail.Location = new System.Drawing.Point(4, 314);
            this.btnEmail.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnEmail.Name = "btnEmail";
            this.btnEmail.Size = new System.Drawing.Size(195, 100);
            this.btnEmail.TabIndex = 13;
            this.btnEmail.Text = "Email Promo";
            this.btnEmail.UseVisualStyleBackColor = true;
            this.btnEmail.Click += new System.EventHandler(this.btnEmail_Click);
            // 
            // btnViewStaffDetails
            // 
            this.btnViewStaffDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnViewStaffDetails.FlatAppearance.BorderSize = 0;
            this.btnViewStaffDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewStaffDetails.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewStaffDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnViewStaffDetails.Location = new System.Drawing.Point(201, 418);
            this.btnViewStaffDetails.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnViewStaffDetails.Name = "btnViewStaffDetails";
            this.btnViewStaffDetails.Size = new System.Drawing.Size(195, 100);
            this.btnViewStaffDetails.TabIndex = 14;
            this.btnViewStaffDetails.Text = "View Staff Details";
            this.btnViewStaffDetails.UseVisualStyleBackColor = true;
            this.btnViewStaffDetails.Click += new System.EventHandler(this.btnViewStaffDetails_Click);
            // 
            // Manager_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1062, 690);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbProdMenu);
            this.Controls.Add(this.lvProducts);
            this.Controls.Add(this.gbDetails);
            this.Controls.Add(this.btnLogout);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Manager_Dashboard";
            this.Text = "Manager_Dashboard";
            this.Load += new System.EventHandler(this.Manager_Dashboard_Load);
            this.gbDetails.ResumeLayout(false);
            this.gbDetails.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblNumStaff;
        private System.Windows.Forms.Label lblNumStockOrders;
        private System.Windows.Forms.GroupBox gbDetails;
        private System.Windows.Forms.ListView lvProducts;
        private System.Windows.Forms.ColumnHeader chProdName;
        private System.Windows.Forms.ColumnHeader chProdCode;
        private System.Windows.Forms.ColumnHeader chProdPrice;
        private System.Windows.Forms.ColumnHeader chProdQuantity;
        private System.Windows.Forms.ComboBox cbProdMenu;
        private System.Windows.Forms.Button btnStockOrders;
        private System.Windows.Forms.Button btnMessages;
        private System.Windows.Forms.Button btnProductDetails;
        private System.Windows.Forms.Button btnStaffDetails;
        private System.Windows.Forms.Button btnPurchaseHistory;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblProducts;
        private System.Windows.Forms.Label lblNumOfCustomers;
        private System.Windows.Forms.TextBox txtNumOfStaff;
        private System.Windows.Forms.Button btnEmail;
        private System.Windows.Forms.TextBox txtNoOfStockOrders;
        private System.Windows.Forms.TextBox txtNoOfProducts;
        private System.Windows.Forms.TextBox txtNoOfCustomers;
        private System.Windows.Forms.TextBox txtNoOfStaff;
        private System.Windows.Forms.Button btnEmailPromo;
        private System.Windows.Forms.Button btnViewStaffDetails;
    }
}