
namespace MainProject
{
    partial class Customer_Payment_Page
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
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.cardNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.monthBox = new System.Windows.Forms.ComboBox();
            this.yearBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cvv = new System.Windows.Forms.TextBox();
            this.btnProcessPurchase = new System.Windows.Forms.Button();
            this.saveCardCheckBox = new System.Windows.Forms.CheckBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.cardType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(28, 34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(201, 45);
            this.label11.TabIndex = 36;
            this.label11.Text = "Card Details";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 25);
            this.label1.TabIndex = 37;
            this.label1.Text = "Name On Card: ";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(238, 98);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(538, 31);
            this.name.TabIndex = 38;
            // 
            // cardNo
            // 
            this.cardNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cardNo.Location = new System.Drawing.Point(238, 147);
            this.cardNo.Name = "cardNo";
            this.cardNo.Size = new System.Drawing.Size(538, 31);
            this.cardNo.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 25);
            this.label2.TabIndex = 39;
            this.label2.Text = "Card Number: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 25);
            this.label3.TabIndex = 41;
            this.label3.Text = "Expiry Date: ";
            // 
            // monthBox
            // 
            this.monthBox.FormattingEnabled = true;
            this.monthBox.Location = new System.Drawing.Point(235, 239);
            this.monthBox.Name = "monthBox";
            this.monthBox.Size = new System.Drawing.Size(86, 33);
            this.monthBox.TabIndex = 42;
            // 
            // yearBox
            // 
            this.yearBox.FormattingEnabled = true;
            this.yearBox.Location = new System.Drawing.Point(338, 239);
            this.yearBox.Name = "yearBox";
            this.yearBox.Size = new System.Drawing.Size(86, 33);
            this.yearBox.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(214, 25);
            this.label4.TabIndex = 44;
            this.label4.Text = "Security Code(CV2): ";
            // 
            // cvv
            // 
            this.cvv.Location = new System.Drawing.Point(235, 283);
            this.cvv.Name = "cvv";
            this.cvv.Size = new System.Drawing.Size(100, 31);
            this.cvv.TabIndex = 45;
            // 
            // btnProcessPurchase
            // 
            this.btnProcessPurchase.Location = new System.Drawing.Point(269, 395);
            this.btnProcessPurchase.Name = "btnProcessPurchase";
            this.btnProcessPurchase.Size = new System.Drawing.Size(244, 62);
            this.btnProcessPurchase.TabIndex = 47;
            this.btnProcessPurchase.Text = "Submit For Processing";
            this.btnProcessPurchase.UseVisualStyleBackColor = true;
            this.btnProcessPurchase.Click += new System.EventHandler(this.btnProcessPurchase_Click);
            // 
            // saveCardCheckBox
            // 
            this.saveCardCheckBox.AutoSize = true;
            this.saveCardCheckBox.Location = new System.Drawing.Point(554, 413);
            this.saveCardCheckBox.Name = "saveCardCheckBox";
            this.saveCardCheckBox.Size = new System.Drawing.Size(217, 29);
            this.saveCardCheckBox.TabIndex = 48;
            this.saveCardCheckBox.Text = "Save Card Details";
            this.saveCardCheckBox.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(72, 395);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(168, 62);
            this.btnBack.TabIndex = 49;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // cardType
            // 
            this.cardType.FormattingEnabled = true;
            this.cardType.Location = new System.Drawing.Point(238, 192);
            this.cardType.Name = "cardType";
            this.cardType.Size = new System.Drawing.Size(275, 33);
            this.cardType.TabIndex = 51;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(94, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 25);
            this.label5.TabIndex = 50;
            this.label5.Text = "Card Type";
            // 
            // Customer_Payment_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 485);
            this.Controls.Add(this.cardType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.saveCardCheckBox);
            this.Controls.Add(this.btnProcessPurchase);
            this.Controls.Add(this.cvv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.yearBox);
            this.Controls.Add(this.monthBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cardNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label11);
            this.Name = "Customer_Payment_Page";
            this.Text = "Customer_Payment_Page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox cardNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox monthBox;
        private System.Windows.Forms.ComboBox yearBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox cvv;
        private System.Windows.Forms.Button btnProcessPurchase;
        private System.Windows.Forms.CheckBox saveCardCheckBox;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ComboBox cardType;
        private System.Windows.Forms.Label label5;
    }
}