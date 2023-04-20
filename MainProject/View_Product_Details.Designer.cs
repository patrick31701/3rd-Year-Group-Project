
namespace MainProject
{
    partial class View_Product_Details
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
            this.lblProductID = new System.Windows.Forms.Label();
            this.lblProdName = new System.Windows.Forms.Label();
            this.txtProdDesc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProdQuantity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProdPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtProdType = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductID.Location = new System.Drawing.Point(132, 42);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(98, 22);
            this.lblProductID.TabIndex = 0;
            this.lblProductID.Text = "{Product ID}";
            this.lblProductID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProdName
            // 
            this.lblProdName.AutoSize = true;
            this.lblProdName.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdName.Location = new System.Drawing.Point(75, 9);
            this.lblProdName.Name = "lblProdName";
            this.lblProdName.Size = new System.Drawing.Size(235, 33);
            this.lblProdName.TabIndex = 1;
            this.lblProdName.Text = "{Product Name}";
            this.lblProdName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtProdDesc
            // 
            this.txtProdDesc.Enabled = false;
            this.txtProdDesc.Location = new System.Drawing.Point(191, 103);
            this.txtProdDesc.Multiline = true;
            this.txtProdDesc.Name = "txtProdDesc";
            this.txtProdDesc.Size = new System.Drawing.Size(177, 181);
            this.txtProdDesc.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(187, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Description :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Quantity :";
            // 
            // txtProdQuantity
            // 
            this.txtProdQuantity.Enabled = false;
            this.txtProdQuantity.Location = new System.Drawing.Point(126, 103);
            this.txtProdQuantity.Name = "txtProdQuantity";
            this.txtProdQuantity.Size = new System.Drawing.Size(46, 20);
            this.txtProdQuantity.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(64, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Price :";
            // 
            // txtProdPrice
            // 
            this.txtProdPrice.Enabled = false;
            this.txtProdPrice.Location = new System.Drawing.Point(126, 142);
            this.txtProdPrice.Name = "txtProdPrice";
            this.txtProdPrice.Size = new System.Drawing.Size(46, 20);
            this.txtProdPrice.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "Product Type :";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(40, 237);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(92, 33);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtProdType
            // 
            this.txtProdType.Enabled = false;
            this.txtProdType.Location = new System.Drawing.Point(126, 176);
            this.txtProdType.Name = "txtProdType";
            this.txtProdType.Size = new System.Drawing.Size(46, 20);
            this.txtProdType.TabIndex = 11;
            // 
            // View_Product_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 296);
            this.Controls.Add(this.txtProdType);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtProdPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtProdQuantity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtProdDesc);
            this.Controls.Add(this.lblProdName);
            this.Controls.Add(this.lblProductID);
            this.Name = "View_Product_Details";
            this.Text = "View_Product_Details";
            this.Load += new System.EventHandler(this.View_Product_Details_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProductID;
        private System.Windows.Forms.Label lblProdName;
        private System.Windows.Forms.TextBox txtProdDesc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProdQuantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtProdPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtProdType;
    }
}