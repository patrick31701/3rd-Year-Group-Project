
namespace MainProject
{
    partial class WStaff_ReviewOrder
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
            this.lblOrderNum = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOrderFName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOrderLName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOrderAddress = new System.Windows.Forms.TextBox();
            this.lvOrderDetails = new System.Windows.Forms.ListView();
            this.chOrderProdID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chOrderProdName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chOrderProdQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chOrderProdStock = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnOrderAccept = new System.Windows.Forms.Button();
            this.btnOrderDecline = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblOrderNum
            // 
            this.lblOrderNum.AutoSize = true;
            this.lblOrderNum.Font = new System.Drawing.Font("Tw Cen MT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderNum.Location = new System.Drawing.Point(167, 9);
            this.lblOrderNum.Name = "lblOrderNum";
            this.lblOrderNum.Size = new System.Drawing.Size(230, 37);
            this.lblOrderNum.TabIndex = 0;
            this.lblOrderNum.Text = "{Order Number}";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tw Cen MT", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Firstname";
            // 
            // txtOrderFName
            // 
            this.txtOrderFName.Location = new System.Drawing.Point(37, 99);
            this.txtOrderFName.Name = "txtOrderFName";
            this.txtOrderFName.Size = new System.Drawing.Size(159, 20);
            this.txtOrderFName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tw Cen MT", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(332, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Lastname";
            // 
            // txtOrderLName
            // 
            this.txtOrderLName.Location = new System.Drawing.Point(336, 99);
            this.txtOrderLName.Name = "txtOrderLName";
            this.txtOrderLName.Size = new System.Drawing.Size(159, 20);
            this.txtOrderLName.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tw Cen MT", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "Address";
            // 
            // txtOrderAddress
            // 
            this.txtOrderAddress.Location = new System.Drawing.Point(37, 155);
            this.txtOrderAddress.Name = "txtOrderAddress";
            this.txtOrderAddress.Size = new System.Drawing.Size(458, 20);
            this.txtOrderAddress.TabIndex = 6;
            // 
            // lvOrderDetails
            // 
            this.lvOrderDetails.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chOrderProdID,
            this.chOrderProdName,
            this.chOrderProdQuantity,
            this.chOrderProdStock});
            this.lvOrderDetails.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvOrderDetails.GridLines = true;
            this.lvOrderDetails.HideSelection = false;
            this.lvOrderDetails.Location = new System.Drawing.Point(37, 194);
            this.lvOrderDetails.Name = "lvOrderDetails";
            this.lvOrderDetails.Size = new System.Drawing.Size(458, 188);
            this.lvOrderDetails.TabIndex = 7;
            this.lvOrderDetails.UseCompatibleStateImageBehavior = false;
            this.lvOrderDetails.View = System.Windows.Forms.View.Details;
            // 
            // chOrderProdID
            // 
            this.chOrderProdID.Text = "ID";
            this.chOrderProdID.Width = 100;
            // 
            // chOrderProdName
            // 
            this.chOrderProdName.Text = "Product Name";
            this.chOrderProdName.Width = 200;
            // 
            // chOrderProdQuantity
            // 
            this.chOrderProdQuantity.Text = "Quantity";
            this.chOrderProdQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chOrderProdQuantity.Width = 75;
            // 
            // chOrderProdStock
            // 
            this.chOrderProdStock.Text = "Stock";
            this.chOrderProdStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chOrderProdStock.Width = 78;
            // 
            // btnOrderAccept
            // 
            this.btnOrderAccept.Font = new System.Drawing.Font("Tw Cen MT", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderAccept.Location = new System.Drawing.Point(84, 409);
            this.btnOrderAccept.Name = "btnOrderAccept";
            this.btnOrderAccept.Size = new System.Drawing.Size(112, 40);
            this.btnOrderAccept.TabIndex = 8;
            this.btnOrderAccept.Text = "Accept";
            this.btnOrderAccept.UseVisualStyleBackColor = true;
            this.btnOrderAccept.Click += new System.EventHandler(this.btnOrderAccept_Click);
            // 
            // btnOrderDecline
            // 
            this.btnOrderDecline.Font = new System.Drawing.Font("Tw Cen MT", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderDecline.Location = new System.Drawing.Point(336, 409);
            this.btnOrderDecline.Name = "btnOrderDecline";
            this.btnOrderDecline.Size = new System.Drawing.Size(112, 40);
            this.btnOrderDecline.TabIndex = 9;
            this.btnOrderDecline.Text = "Decline";
            this.btnOrderDecline.UseVisualStyleBackColor = true;
            this.btnOrderDecline.Click += new System.EventHandler(this.btnOrderDecline_Click);
            // 
            // WStaff_ReviewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 461);
            this.Controls.Add(this.btnOrderDecline);
            this.Controls.Add(this.btnOrderAccept);
            this.Controls.Add(this.lvOrderDetails);
            this.Controls.Add(this.txtOrderAddress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtOrderLName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtOrderFName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblOrderNum);
            this.Name = "WStaff_ReviewOrder";
            this.Text = "WStaff_ReviewOrder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOrderNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOrderFName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOrderLName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOrderAddress;
        private System.Windows.Forms.ListView lvOrderDetails;
        private System.Windows.Forms.ColumnHeader chOrderProdName;
        private System.Windows.Forms.ColumnHeader chOrderProdQuantity;
        private System.Windows.Forms.ColumnHeader chOrderProdStock;
        private System.Windows.Forms.Button btnOrderAccept;
        private System.Windows.Forms.Button btnOrderDecline;
        private System.Windows.Forms.ColumnHeader chOrderProdID;
    }
}