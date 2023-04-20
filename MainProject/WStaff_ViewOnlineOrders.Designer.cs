
namespace MainProject
{
    partial class WStaff_ViewOnlineOrders
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
            this.lvOnlineOrders = new System.Windows.Forms.ListView();
            this.chOrderID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chOrderQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chOrderCost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnOrderReview = new System.Windows.Forms.Button();
            this.chCustomerID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Online Order Review";
            // 
            // lvOnlineOrders
            // 
            this.lvOnlineOrders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chOrderID,
            this.chCustomerID,
            this.chOrderQuantity,
            this.chOrderCost});
            this.lvOnlineOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvOnlineOrders.FullRowSelect = true;
            this.lvOnlineOrders.GridLines = true;
            this.lvOnlineOrders.HideSelection = false;
            this.lvOnlineOrders.Location = new System.Drawing.Point(12, 101);
            this.lvOnlineOrders.Name = "lvOnlineOrders";
            this.lvOnlineOrders.Size = new System.Drawing.Size(399, 300);
            this.lvOnlineOrders.TabIndex = 1;
            this.lvOnlineOrders.UseCompatibleStateImageBehavior = false;
            this.lvOnlineOrders.View = System.Windows.Forms.View.Details;
            // 
            // chOrderID
            // 
            this.chOrderID.Text = "Order ID";
            this.chOrderID.Width = 150;
            // 
            // chOrderQuantity
            // 
            this.chOrderQuantity.Text = "Quantity";
            this.chOrderQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chOrderCost
            // 
            this.chOrderCost.Text = "Total Cost";
            this.chOrderCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chOrderCost.Width = 85;
            // 
            // btnOrderReview
            // 
            this.btnOrderReview.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderReview.Location = new System.Drawing.Point(137, 407);
            this.btnOrderReview.Name = "btnOrderReview";
            this.btnOrderReview.Size = new System.Drawing.Size(127, 40);
            this.btnOrderReview.TabIndex = 2;
            this.btnOrderReview.Text = "Review";
            this.btnOrderReview.UseVisualStyleBackColor = true;
            this.btnOrderReview.Click += new System.EventHandler(this.btnOrderReview_Click);
            // 
            // chCustomerID
            // 
            this.chCustomerID.Text = "Customer ID";
            this.chCustomerID.Width = 100;
            // 
            // WStaff_ViewOnlineOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 455);
            this.Controls.Add(this.btnOrderReview);
            this.Controls.Add(this.lvOnlineOrders);
            this.Controls.Add(this.label1);
            this.Name = "WStaff_ViewOnlineOrders";
            this.Text = "WStaff_ViewOnlineOrders";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvOnlineOrders;
        private System.Windows.Forms.ColumnHeader chOrderID;
        private System.Windows.Forms.ColumnHeader chOrderQuantity;
        private System.Windows.Forms.ColumnHeader chOrderCost;
        private System.Windows.Forms.Button btnOrderReview;
        private System.Windows.Forms.ColumnHeader chCustomerID;
    }
}