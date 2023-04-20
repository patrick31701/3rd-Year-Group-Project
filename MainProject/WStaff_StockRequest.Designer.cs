
namespace MainProject
{
    partial class WStaff_StockRequest
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
            this.lvStockProducts = new System.Windows.Forms.ListView();
            this.cbStockProdCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chStockProdName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView1 = new System.Windows.Forms.ListView();
            this.cbRequestName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnBack = new System.Windows.Forms.Button();
            this.cbStockMenu = new System.Windows.Forms.ComboBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSumbitRequest = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lvOrderBasket = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lvStockProducts
            // 
            this.lvStockProducts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cbStockProdCode,
            this.chStockProdName});
            this.lvStockProducts.FullRowSelect = true;
            this.lvStockProducts.GridLines = true;
            this.lvStockProducts.HideSelection = false;
            this.lvStockProducts.Location = new System.Drawing.Point(13, 81);
            this.lvStockProducts.Name = "lvStockProducts";
            this.lvStockProducts.Size = new System.Drawing.Size(340, 168);
            this.lvStockProducts.TabIndex = 0;
            this.lvStockProducts.UseCompatibleStateImageBehavior = false;
            this.lvStockProducts.View = System.Windows.Forms.View.Details;
            // 
            // cbStockProdCode
            // 
            this.cbStockProdCode.Text = "Code";
            this.cbStockProdCode.Width = 96;
            // 
            // chStockProdName
            // 
            this.chStockProdName.Text = "Product Name";
            this.chStockProdName.Width = 240;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cbRequestName});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(471, 81);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(246, 168);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // cbRequestName
            // 
            this.cbRequestName.Text = "Product Name";
            this.cbRequestName.Width = 178;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Tw Cen MT", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(82, 27);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // cbStockMenu
            // 
            this.cbStockMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStockMenu.FormattingEnabled = true;
            this.cbStockMenu.Location = new System.Drawing.Point(232, 47);
            this.cbStockMenu.Name = "cbStockMenu";
            this.cbStockMenu.Size = new System.Drawing.Size(121, 28);
            this.cbStockMenu.TabIndex = 3;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(17, 345);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(340, 85);
            this.txtDescription.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 320);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Description";
            // 
            // btnSumbitRequest
            // 
            this.btnSumbitRequest.Font = new System.Drawing.Font("Tw Cen MT", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSumbitRequest.Location = new System.Drawing.Point(485, 345);
            this.btnSumbitRequest.Name = "btnSumbitRequest";
            this.btnSumbitRequest.Size = new System.Drawing.Size(125, 56);
            this.btnSumbitRequest.TabIndex = 6;
            this.btnSumbitRequest.Text = "Submit";
            this.btnSumbitRequest.UseVisualStyleBackColor = true;
            this.btnSumbitRequest.Click += new System.EventHandler(this.btnSumbitRequest_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Tw Cen MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(249, 255);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(104, 49);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lvOrderBasket
            // 
            this.lvOrderBasket.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvOrderBasket.FullRowSelect = true;
            this.lvOrderBasket.GridLines = true;
            this.lvOrderBasket.HideSelection = false;
            this.lvOrderBasket.Location = new System.Drawing.Point(376, 81);
            this.lvOrderBasket.Name = "lvOrderBasket";
            this.lvOrderBasket.Size = new System.Drawing.Size(340, 168);
            this.lvOrderBasket.TabIndex = 8;
            this.lvOrderBasket.UseCompatibleStateImageBehavior = false;
            this.lvOrderBasket.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Code";
            this.columnHeader1.Width = 96;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Product Name";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "No.";
            this.columnHeader3.Width = 40;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Tw Cen MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(612, 255);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(104, 49);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(189, 267);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(46, 26);
            this.txtQuantity.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(112, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "Quantity :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 22);
            this.label3.TabIndex = 12;
            this.label3.Text = "Products";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(374, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 22);
            this.label4.TabIndex = 13;
            this.label4.Text = "Requested";
            // 
            // WStaff_StockRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 442);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lvOrderBasket);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSumbitRequest);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.cbStockMenu);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.lvStockProducts);
            this.Name = "WStaff_StockRequest";
            this.Text = "WStaff_StockRequest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvStockProducts;
        private System.Windows.Forms.ColumnHeader chStockProdName;
        private System.Windows.Forms.ColumnHeader cbStockProdCode;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader cbRequestName;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ComboBox cbStockMenu;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSumbitRequest;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListView lvOrderBasket;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}