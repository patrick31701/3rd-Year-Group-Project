
namespace MainProject
{
    partial class Customer_Reset_Password
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbReNewPassword = new System.Windows.Forms.TextBox();
            this.tbNewPassword = new System.Windows.Forms.TextBox();
            this.tbRePassword = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(98, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Password:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(91, 402);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 118);
            this.label2.TabIndex = 1;
            this.label2.Text = "Re enter your new password:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(91, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 83);
            this.label3.TabIndex = 2;
            this.label3.Text = "New Password:";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(91, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 121);
            this.label4.TabIndex = 3;
            this.label4.Text = "Re enter your password:\r\n";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(275, 41);
            this.tbPassword.Multiline = true;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(293, 44);
            this.tbPassword.TabIndex = 4;
            // 
            // tbReNewPassword
            // 
            this.tbReNewPassword.Location = new System.Drawing.Point(275, 416);
            this.tbReNewPassword.Multiline = true;
            this.tbReNewPassword.Name = "tbReNewPassword";
            this.tbReNewPassword.PasswordChar = '*';
            this.tbReNewPassword.Size = new System.Drawing.Size(293, 44);
            this.tbReNewPassword.TabIndex = 5;
            // 
            // tbNewPassword
            // 
            this.tbNewPassword.Location = new System.Drawing.Point(275, 316);
            this.tbNewPassword.Multiline = true;
            this.tbNewPassword.Name = "tbNewPassword";
            this.tbNewPassword.PasswordChar = '*';
            this.tbNewPassword.Size = new System.Drawing.Size(293, 44);
            this.tbNewPassword.TabIndex = 6;
            // 
            // tbRePassword
            // 
            this.tbRePassword.Location = new System.Drawing.Point(275, 165);
            this.tbRePassword.Multiline = true;
            this.tbRePassword.Name = "tbRePassword";
            this.tbRePassword.PasswordChar = '*';
            this.tbRePassword.Size = new System.Drawing.Size(293, 44);
            this.tbRePassword.TabIndex = 7;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSubmit.Location = new System.Drawing.Point(22, 577);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(299, 116);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.SystemColors.Window;
            this.btnClose.Location = new System.Drawing.Point(350, 577);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(299, 116);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Customer_Reset_Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(671, 715);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.tbRePassword);
            this.Controls.Add(this.tbNewPassword);
            this.Controls.Add(this.tbReNewPassword);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Customer_Reset_Password";
            this.Text = "Customer_Reset_Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbReNewPassword;
        private System.Windows.Forms.TextBox tbNewPassword;
        private System.Windows.Forms.TextBox tbRePassword;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnClose;
    }
}