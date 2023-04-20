
namespace MainProject
{
    partial class GM_StockOrders
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
            this.lvStockOrders = new System.Windows.Forms.ListView();
            this.chOrderID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chItems = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chStaffID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnReview = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(511, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stock Orders";
            // 
            // lvStockOrders
            // 
            this.lvStockOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.lvStockOrders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chOrderID,
            this.chItems,
            this.chStaffID});
            this.lvStockOrders.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvStockOrders.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lvStockOrders.FullRowSelect = true;
            this.lvStockOrders.GridLines = true;
            this.lvStockOrders.HideSelection = false;
            this.lvStockOrders.Location = new System.Drawing.Point(283, 95);
            this.lvStockOrders.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lvStockOrders.Name = "lvStockOrders";
            this.lvStockOrders.Size = new System.Drawing.Size(735, 491);
            this.lvStockOrders.TabIndex = 1;
            this.lvStockOrders.UseCompatibleStateImageBehavior = false;
            this.lvStockOrders.View = System.Windows.Forms.View.Details;
            this.lvStockOrders.SelectedIndexChanged += new System.EventHandler(this.lvStockOrders_SelectedIndexChanged);
            // 
            // chOrderID
            // 
            this.chOrderID.Text = "Order ID";
            this.chOrderID.Width = 417;
            // 
            // chItems
            // 
            this.chItems.Text = "Item Quantity";
            this.chItems.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chItems.Width = 159;
            // 
            // chStaffID
            // 
            this.chStaffID.Text = "Staff ID";
            this.chStaffID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chStaffID.Width = 153;
            // 
            // btnReview
            // 
            this.btnReview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnReview.FlatAppearance.BorderSize = 0;
            this.btnReview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReview.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnReview.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnReview.Location = new System.Drawing.Point(0, 122);
            this.btnReview.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReview.Name = "btnReview";
            this.btnReview.Size = new System.Drawing.Size(227, 93);
            this.btnReview.TabIndex = 2;
            this.btnReview.Text = "Review";
            this.btnReview.UseVisualStyleBackColor = false;
            this.btnReview.Click += new System.EventHandler(this.btnReview_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnBack.Location = new System.Drawing.Point(916, 16);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(101, 54);
            this.btnBack.TabIndex = 25;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnReview);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(227, 655);
            this.panel1.TabIndex = 26;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MainProject.Properties.Resources.shopping_bag;
            this.pictureBox1.Location = new System.Drawing.Point(75, 31);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // GM_StockOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1061, 654);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lvStockOrders);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "GM_StockOrders";
            this.Text = "GM_StockOrders";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvStockOrders;
        private System.Windows.Forms.ColumnHeader chOrderID;
        private System.Windows.Forms.ColumnHeader chItems;
        private System.Windows.Forms.Button btnReview;
        private System.Windows.Forms.ColumnHeader chStaffID;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}