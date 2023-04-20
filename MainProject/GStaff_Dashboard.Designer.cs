
namespace MainProject
{
    partial class GStaff_Dashboard
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.cbProdMenu = new System.Windows.Forms.ComboBox();
            this.lvProducts = new System.Windows.Forms.ListView();
            this.chProdName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chProdCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chProdPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chProdQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome, {User}";
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(603, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(87, 34);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // cbProdMenu
            // 
            this.cbProdMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProdMenu.FormattingEnabled = true;
            this.cbProdMenu.Items.AddRange(new object[] {
            "Fresh Produce",
            "Meat",
            "Bakery",
            "Drinks",
            "Baby Products"});
            this.cbProdMenu.Location = new System.Drawing.Point(12, 101);
            this.cbProdMenu.Name = "cbProdMenu";
            this.cbProdMenu.Size = new System.Drawing.Size(136, 28);
            this.cbProdMenu.TabIndex = 3;
            this.cbProdMenu.SelectedIndexChanged += new System.EventHandler(this.changedProducts);
            // 
            // lvProducts
            // 
            this.lvProducts.AllowColumnReorder = true;
            this.lvProducts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chProdName,
            this.chProdCode,
            this.chProdPrice,
            this.chProdQuantity});
            this.lvProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvProducts.FullRowSelect = true;
            this.lvProducts.GridLines = true;
            this.lvProducts.HideSelection = false;
            this.lvProducts.Location = new System.Drawing.Point(12, 135);
            this.lvProducts.Name = "lvProducts";
            this.lvProducts.Size = new System.Drawing.Size(680, 274);
            this.lvProducts.TabIndex = 4;
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
            // GStaff_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 426);
            this.Controls.Add(this.lvProducts);
            this.Controls.Add(this.cbProdMenu);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.label1);
            this.Name = "GStaff_Dashboard";
            this.Text = "GStaff_Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.ComboBox cbProdMenu;
        private System.Windows.Forms.ListView lvProducts;
        private System.Windows.Forms.ColumnHeader chProdName;
        private System.Windows.Forms.ColumnHeader chProdCode;
        private System.Windows.Forms.ColumnHeader chProdPrice;
        private System.Windows.Forms.ColumnHeader chProdQuantity;
    }
}