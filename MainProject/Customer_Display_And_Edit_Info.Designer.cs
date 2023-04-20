
namespace MainProject
{
    partial class Customer_Display_And_Edit_Info
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
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbNumber = new System.Windows.Forms.TextBox();
            this.tbEmailAddress = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbEircode = new System.Windows.Forms.TextBox();
            this.cbbCounty = new System.Windows.Forms.ComboBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(271, 100);
            this.tbName.Multiline = true;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(387, 45);
            this.tbName.TabIndex = 20;
            // 
            // tbNumber
            // 
            this.tbNumber.Location = new System.Drawing.Point(988, 194);
            this.tbNumber.Name = "tbNumber";
            this.tbNumber.Size = new System.Drawing.Size(352, 44);
            this.tbNumber.TabIndex = 21;
            // 
            // tbEmailAddress
            // 
            this.tbEmailAddress.Location = new System.Drawing.Point(956, 100);
            this.tbEmailAddress.Multiline = true;
            this.tbEmailAddress.Name = "tbEmailAddress";
            this.tbEmailAddress.Size = new System.Drawing.Size(384, 44);
            this.tbEmailAddress.TabIndex = 22;
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(269, 190);
            this.tbAddress.Multiline = true;
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(387, 45);
            this.tbAddress.TabIndex = 23;
            // 
            // btn_Edit
            // 
            this.btn_Edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btn_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Edit.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_Edit.Location = new System.Drawing.Point(706, 365);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(277, 122);
            this.btn_Edit.TabIndex = 25;
            this.btn_Edit.Text = "Edit";
            this.btn_Edit.UseVisualStyleBackColor = false;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 37);
            this.label1.TabIndex = 30;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(699, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 37);
            this.label2.TabIndex = 31;
            this.label2.Text = "Email Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(729, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(242, 37);
            this.label3.TabIndex = 32;
            this.label3.Text = "Phone Number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(106, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 37);
            this.label4.TabIndex = 33;
            this.label4.Text = "Address:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(137, 365);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 37);
            this.label5.TabIndex = 35;
            this.label5.Text = "City:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(106, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 37);
            this.label6.TabIndex = 37;
            this.label6.Text = "County:";
            // 
            // tbCity
            // 
            this.tbCity.Location = new System.Drawing.Point(269, 362);
            this.tbCity.Multiline = true;
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(387, 45);
            this.tbCity.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(106, 450);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 37);
            this.label7.TabIndex = 39;
            this.label7.Text = "Eircode:";
            // 
            // tbEircode
            // 
            this.tbEircode.Location = new System.Drawing.Point(269, 443);
            this.tbEircode.Multiline = true;
            this.tbEircode.Name = "tbEircode";
            this.tbEircode.Size = new System.Drawing.Size(387, 45);
            this.tbEircode.TabIndex = 38;
            // 
            // cbbCounty
            // 
            this.cbbCounty.FormattingEnabled = true;
            this.cbbCounty.Items.AddRange(new object[] {
            "Antrim",
            "Armagh",
            "Carlow",
            "Cavan",
            "Clare",
            "Cork",
            "Derry",
            "Donegal",
            "Down",
            "Dublin",
            "Fermanagh",
            "Galway",
            "Kerry",
            "Kildare",
            "Kilkenny",
            "Laois",
            "Leitrim",
            "Limerick",
            "Longford",
            "Louth",
            "Mayo",
            "Meath",
            "Monaghan",
            "Offaly",
            "Roscommon",
            "Sligo",
            "Tipperary",
            "Tyrone",
            "Waterforn",
            "Westmeath",
            "Wexford",
            "Wicklow"});
            this.cbbCounty.Location = new System.Drawing.Point(271, 274);
            this.cbbCounty.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.cbbCounty.Name = "cbbCounty";
            this.cbbCounty.Size = new System.Drawing.Size(387, 45);
            this.cbbCounty.TabIndex = 40;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.SystemColors.Window;
            this.btnClose.Location = new System.Drawing.Point(1012, 362);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(277, 122);
            this.btnClose.TabIndex = 41;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Customer_Display_And_Edit_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1456, 613);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.cbbCounty);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbEircode);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbCity);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.tbEmailAddress);
            this.Controls.Add(this.tbNumber);
            this.Controls.Add(this.tbName);
            this.Name = "Customer_Display_And_Edit_Info";
            this.Text = "Customer_Display_And_Edit_Info";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbNumber;
        private System.Windows.Forms.TextBox tbEmailAddress;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbEircode;
        private System.Windows.Forms.ComboBox cbbCounty;
        private System.Windows.Forms.Button btnClose;
    }
}