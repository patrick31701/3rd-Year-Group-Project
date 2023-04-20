
namespace MainProject
{
    partial class Customer_View_Wishlist
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.productID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.productName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnBack = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.quantity = new System.Windows.Forms.TextBox();
            this.productType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.productID,
            this.productName,
            this.price,
            this.productType});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(87, 90);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(955, 506);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // productID
            // 
            this.productID.Text = "Product ID";
            this.productID.Width = 186;
            // 
            // productName
            // 
            this.productName.Text = "Product Name";
            this.productName.Width = 224;
            // 
            // price
            // 
            this.price.Text = "Price";
            this.price.Width = 169;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(42, 762);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(201, 85);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(320, 762);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(201, 85);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear Wishlist";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(601, 762);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(201, 85);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Remove item";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Location = new System.Drawing.Point(866, 762);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(201, 85);
            this.btnAddToCart.TabIndex = 4;
            this.btnAddToCart.Text = "Add To Cart";
            this.btnAddToCart.UseVisualStyleBackColor = true;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 671);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Quantity: ";
            // 
            // quantity
            // 
            this.quantity.Location = new System.Drawing.Point(216, 671);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(145, 31);
            this.quantity.TabIndex = 6;
            // 
            // productType
            // 
            this.productType.Text = "Product Type";
            // 
            // Customer_View_Wishlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 896);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.listView1);
            this.Name = "Customer_View_Wishlist";
            this.Text = "wishlist";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader productName;
        private System.Windows.Forms.ColumnHeader price;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.ColumnHeader productID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox quantity;
        private System.Windows.Forms.ColumnHeader productType;
    }
}