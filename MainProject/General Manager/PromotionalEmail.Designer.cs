
namespace MainProject.General_Manager
{
    partial class PromotionalEmail
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
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBody = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCoupon = new System.Windows.Forms.TextBox();
            this.rbtnLoyalty = new System.Windows.Forms.RadioButton();
            this.rbtnNoLoyalty = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(113, 53);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(237, 20);
            this.txtSubject.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Subject:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Body:";
            // 
            // txtBody
            // 
            this.txtBody.Location = new System.Drawing.Point(113, 147);
            this.txtBody.Multiline = true;
            this.txtBody.Name = "txtBody";
            this.txtBody.Size = new System.Drawing.Size(237, 175);
            this.txtBody.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbtnNoLoyalty);
            this.panel1.Controls.Add(this.rbtnLoyalty);
            this.panel1.Location = new System.Drawing.Point(113, 391);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(129, 84);
            this.panel1.TabIndex = 4;
            // 
            // txtCoupon
            // 
            this.txtCoupon.Location = new System.Drawing.Point(113, 346);
            this.txtCoupon.Name = "txtCoupon";
            this.txtCoupon.Size = new System.Drawing.Size(237, 20);
            this.txtCoupon.TabIndex = 5;
            // 
            // rbtnLoyalty
            // 
            this.rbtnLoyalty.AutoSize = true;
            this.rbtnLoyalty.Location = new System.Drawing.Point(17, 16);
            this.rbtnLoyalty.Name = "rbtnLoyalty";
            this.rbtnLoyalty.Size = new System.Drawing.Size(81, 17);
            this.rbtnLoyalty.TabIndex = 0;
            this.rbtnLoyalty.TabStop = true;
            this.rbtnLoyalty.Text = "Lotalty Card";
            this.rbtnLoyalty.UseVisualStyleBackColor = true;
            // 
            // rbtnNoLoyalty
            // 
            this.rbtnNoLoyalty.AutoSize = true;
            this.rbtnNoLoyalty.Location = new System.Drawing.Point(17, 50);
            this.rbtnNoLoyalty.Name = "rbtnNoLoyalty";
            this.rbtnNoLoyalty.Size = new System.Drawing.Size(70, 17);
            this.rbtnNoLoyalty.TabIndex = 1;
            this.rbtnNoLoyalty.TabStop = true;
            this.rbtnNoLoyalty.Text = "Everyone";
            this.rbtnNoLoyalty.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 341);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Coupon:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 391);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Users:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(113, 501);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 52);
            this.button1.TabIndex = 8;
            this.button1.Text = "Email";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(51, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "Title:";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(114, 100);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(236, 20);
            this.txtTitle.TabIndex = 10;
            // 
            // PromotionalEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 569);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCoupon);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtBody);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSubject);
            this.Name = "PromotionalEmail";
            this.Text = "PromotionalEmail";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBody;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbtnNoLoyalty;
        private System.Windows.Forms.RadioButton rbtnLoyalty;
        private System.Windows.Forms.TextBox txtCoupon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTitle;
    }
}