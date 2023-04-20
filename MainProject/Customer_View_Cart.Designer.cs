
namespace MainProject
{
    partial class Customer_View_Cart
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
            this.lblEmpty = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.cart = new System.Windows.Forms.ListView();
            this.Product = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnClearCart = new System.Windows.Forms.Button();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.productType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lblEmpty
            // 
            this.lblEmpty.AutoSize = true;
            this.lblEmpty.Font = new System.Drawing.Font("Nirmala UI", 28.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpty.Location = new System.Drawing.Point(12, 9);
            this.lblEmpty.Name = "lblEmpty";
            this.lblEmpty.Size = new System.Drawing.Size(854, 100);
            this.lblEmpty.TabIndex = 0;
            this.lblEmpty.Text = "Your cart is now empty";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(696, 765);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(203, 98);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Continue Shopping";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnCheckout
            // 
            this.btnCheckout.Location = new System.Drawing.Point(199, 631);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(203, 98);
            this.btnCheckout.TabIndex = 2;
            this.btnCheckout.Text = "Checkout";
            this.btnCheckout.UseVisualStyleBackColor = true;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // cart
            // 
            this.cart.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Product,
            this.Quantity,
            this.Price,
            this.productType});
            this.cart.HideSelection = false;
            this.cart.Location = new System.Drawing.Point(55, 129);
            this.cart.Name = "cart";
            this.cart.Size = new System.Drawing.Size(1022, 473);
            this.cart.TabIndex = 3;
            this.cart.UseCompatibleStateImageBehavior = false;
            this.cart.View = System.Windows.Forms.View.Details;
            // 
            // Product
            // 
            this.Product.Text = "Product Name";
            this.Product.Width = 182;
            // 
            // Quantity
            // 
            this.Quantity.Text = "Quantity";
            this.Quantity.Width = 125;
            // 
            // Price
            // 
            this.Price.Text = "Price";
            this.Price.Width = 145;
            // 
            // btnClearCart
            // 
            this.btnClearCart.Location = new System.Drawing.Point(199, 765);
            this.btnClearCart.Name = "btnClearCart";
            this.btnClearCart.Size = new System.Drawing.Size(203, 98);
            this.btnClearCart.TabIndex = 4;
            this.btnClearCart.Text = "Clear Cart";
            this.btnClearCart.UseVisualStyleBackColor = true;
            this.btnClearCart.Click += new System.EventHandler(this.btnClearCart_Click);
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.Location = new System.Drawing.Point(696, 631);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(203, 98);
            this.btnRemoveItem.TabIndex = 5;
            this.btnRemoveItem.Text = "Remove";
            this.btnRemoveItem.UseVisualStyleBackColor = true;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // productType
            // 
            this.productType.Text = "Product Type";
            this.productType.Width = 121;
            // 
            // Customer_View_Cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 887);
            this.Controls.Add(this.btnRemoveItem);
            this.Controls.Add(this.btnClearCart);
            this.Controls.Add(this.cart);
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblEmpty);
            this.Name = "Customer_View_Cart";
            this.Text = "Customer_View_Cart";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmpty;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.ListView cart;
        private System.Windows.Forms.ColumnHeader Product;
        private System.Windows.Forms.ColumnHeader Quantity;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.Button btnClearCart;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.ColumnHeader productType;
    }
}