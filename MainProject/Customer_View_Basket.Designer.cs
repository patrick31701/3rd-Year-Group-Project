
namespace MainProject
{
    partial class Form1
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
            this.CustomerBasket = new System.Windows.Forms.ListView();
            this.chProdName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chProdCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chProdPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chProdQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.remove_from_cart = new System.Windows.Forms.Button();
            this.checkout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CustomerBasket
            // 
            this.CustomerBasket.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chProdName,
            this.chProdCode,
            this.chProdPrice,
            this.chProdQuantity});
            this.CustomerBasket.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerBasket.GridLines = true;
            this.CustomerBasket.HideSelection = false;
            this.CustomerBasket.Location = new System.Drawing.Point(4, 6);
            this.CustomerBasket.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.CustomerBasket.Name = "CustomerBasket";
            this.CustomerBasket.Size = new System.Drawing.Size(436, 562);
            this.CustomerBasket.TabIndex = 1;
            this.CustomerBasket.UseCompatibleStateImageBehavior = false;
            this.CustomerBasket.View = System.Windows.Forms.View.Details;
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
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(712, 10);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 60);
            this.button3.TabIndex = 10;
            this.button3.Text = "Log out";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(712, 83);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 60);
            this.button2.TabIndex = 9;
            this.button2.Text = "View Basket";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(600, 83);
            this.button5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 60);
            this.button5.TabIndex = 8;
            this.button5.Text = "View Account";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(600, 10);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 60);
            this.button1.TabIndex = 7;
            this.button1.Text = "Support";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // remove_from_cart
            // 
            this.remove_from_cart.Location = new System.Drawing.Point(446, 385);
            this.remove_from_cart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.remove_from_cart.Name = "remove_from_cart";
            this.remove_from_cart.Size = new System.Drawing.Size(132, 65);
            this.remove_from_cart.TabIndex = 13;
            this.remove_from_cart.Text = "Remove From Cart";
            this.remove_from_cart.UseVisualStyleBackColor = true;
            // 
            // checkout
            // 
            this.checkout.Location = new System.Drawing.Point(608, 385);
            this.checkout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkout.Name = "checkout";
            this.checkout.Size = new System.Drawing.Size(120, 65);
            this.checkout.TabIndex = 14;
            this.checkout.Text = "Checkout";
            this.checkout.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 594);
            this.Controls.Add(this.checkout);
            this.Controls.Add(this.remove_from_cart);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CustomerBasket);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView CustomerBasket;
        private System.Windows.Forms.ColumnHeader chProdName;
        private System.Windows.Forms.ColumnHeader chProdCode;
        private System.Windows.Forms.ColumnHeader chProdPrice;
        private System.Windows.Forms.ColumnHeader chProdQuantity;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button remove_from_cart;
        private System.Windows.Forms.Button checkout;
    }
}