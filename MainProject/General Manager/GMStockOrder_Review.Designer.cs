
namespace MainProject.General_Manager
{
    partial class GMStockOrder_Review
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
            this.btnOrder_StockOrder = new System.Windows.Forms.Button();
            this.btnDeny_StockOrder = new System.Windows.Forms.Button();
            this.lv_StockOrder = new System.Windows.Forms.ListView();
            this.chProductID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chProductDetails = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chStockDetailsID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chStockRequestID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblOrder_StockOrder = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOrder_StockOrder
            // 
            this.btnOrder_StockOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnOrder_StockOrder.FlatAppearance.BorderSize = 0;
            this.btnOrder_StockOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder_StockOrder.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder_StockOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnOrder_StockOrder.Location = new System.Drawing.Point(3, 265);
            this.btnOrder_StockOrder.Name = "btnOrder_StockOrder";
            this.btnOrder_StockOrder.Size = new System.Drawing.Size(223, 60);
            this.btnOrder_StockOrder.TabIndex = 23;
            this.btnOrder_StockOrder.Text = "Order";
            this.btnOrder_StockOrder.UseVisualStyleBackColor = false;
            this.btnOrder_StockOrder.Click += new System.EventHandler(this.btnOrder_StockOrder_Click);
            // 
            // btnDeny_StockOrder
            // 
            this.btnDeny_StockOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnDeny_StockOrder.FlatAppearance.BorderSize = 0;
            this.btnDeny_StockOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeny_StockOrder.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeny_StockOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnDeny_StockOrder.Location = new System.Drawing.Point(3, 331);
            this.btnDeny_StockOrder.Name = "btnDeny_StockOrder";
            this.btnDeny_StockOrder.Size = new System.Drawing.Size(223, 60);
            this.btnDeny_StockOrder.TabIndex = 22;
            this.btnDeny_StockOrder.Text = "Deny";
            this.btnDeny_StockOrder.UseVisualStyleBackColor = false;
            this.btnDeny_StockOrder.Click += new System.EventHandler(this.btnDeny_StockOrder_Click);
            // 
            // lv_StockOrder
            // 
            this.lv_StockOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.lv_StockOrder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chProductID,
            this.chProductDetails,
            this.chQuantity,
            this.chStockDetailsID,
            this.chStockRequestID,
            this.chCost});
            this.lv_StockOrder.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_StockOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lv_StockOrder.FullRowSelect = true;
            this.lv_StockOrder.GridLines = true;
            this.lv_StockOrder.HideSelection = false;
            this.lv_StockOrder.Location = new System.Drawing.Point(252, 121);
            this.lv_StockOrder.Name = "lv_StockOrder";
            this.lv_StockOrder.Size = new System.Drawing.Size(798, 463);
            this.lv_StockOrder.TabIndex = 21;
            this.lv_StockOrder.UseCompatibleStateImageBehavior = false;
            this.lv_StockOrder.View = System.Windows.Forms.View.Details;
            this.lv_StockOrder.SelectedIndexChanged += new System.EventHandler(this.lv_StockOrder_SelectedIndexChanged);
            // 
            // chProductID
            // 
            this.chProductID.Text = "Product ID";
            this.chProductID.Width = 100;
            // 
            // chProductDetails
            // 
            this.chProductDetails.Text = "Product Name";
            this.chProductDetails.Width = 233;
            // 
            // chQuantity
            // 
            this.chQuantity.Text = "Quantity";
            this.chQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chQuantity.Width = 100;
            // 
            // chStockDetailsID
            // 
            this.chStockDetailsID.Text = "StockDetailsID";
            this.chStockDetailsID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chStockDetailsID.Width = 125;
            // 
            // chStockRequestID
            // 
            this.chStockRequestID.Text = "StockRequestID";
            this.chStockRequestID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chStockRequestID.Width = 120;
            // 
            // chCost
            // 
            this.chCost.Text = "Cost";
            this.chCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chCost.Width = 109;
            // 
            // lblOrder_StockOrder
            // 
            this.lblOrder_StockOrder.AutoSize = true;
            this.lblOrder_StockOrder.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrder_StockOrder.Location = new System.Drawing.Point(489, 23);
            this.lblOrder_StockOrder.Name = "lblOrder_StockOrder";
            this.lblOrder_StockOrder.Size = new System.Drawing.Size(245, 54);
            this.lblOrder_StockOrder.TabIndex = 20;
            this.lblOrder_StockOrder.Text = "Order Stock";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnBack.Location = new System.Drawing.Point(949, 23);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(101, 54);
            this.btnBack.TabIndex = 24;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnOrder_StockOrder);
            this.panel1.Controls.Add(this.btnDeny_StockOrder);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(226, 655);
            this.panel1.TabIndex = 25;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MainProject.Properties.Resources.shopping_bag;
            this.pictureBox1.Location = new System.Drawing.Point(75, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // GMStockOrder_Review
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1062, 653);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lv_StockOrder);
            this.Controls.Add(this.lblOrder_StockOrder);
            this.Name = "GMStockOrder_Review";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOrder_StockOrder;
        private System.Windows.Forms.Button btnDeny_StockOrder;
        private System.Windows.Forms.ListView lv_StockOrder;
        private System.Windows.Forms.ColumnHeader chProductID;
        private System.Windows.Forms.ColumnHeader chProductDetails;
        private System.Windows.Forms.ColumnHeader chQuantity;
        private System.Windows.Forms.ColumnHeader chCost;
        private System.Windows.Forms.Label lblOrder_StockOrder;
        private System.Windows.Forms.ColumnHeader chStockDetailsID;
        private System.Windows.Forms.ColumnHeader chStockRequestID;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}