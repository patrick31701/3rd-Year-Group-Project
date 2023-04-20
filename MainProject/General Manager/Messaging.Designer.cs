
namespace MainProject.General_Manager
{
    partial class Messaging
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
            this.label2 = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonSend = new System.Windows.Forms.Button();
            this.textMessage = new System.Windows.Forms.TextBox();
            this.listMessage1 = new System.Windows.Forms.ListView();
            this.cbRemotePort = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnback = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiLight", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGray;
            this.label2.Location = new System.Drawing.Point(13, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Messages";
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.buttonStart.FlatAppearance.BorderSize = 0;
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.Location = new System.Drawing.Point(705, 0);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(157, 81);
            this.buttonStart.TabIndex = 19;
            this.buttonStart.Text = "Connect";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonSend
            // 
            this.buttonSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.buttonSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSend.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSend.ForeColor = System.Drawing.Color.DimGray;
            this.buttonSend.Location = new System.Drawing.Point(569, 565);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(100, 46);
            this.buttonSend.TabIndex = 23;
            this.buttonSend.Text = "Send";
            this.buttonSend.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonSend.UseVisualStyleBackColor = false;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // textMessage
            // 
            this.textMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.textMessage.Font = new System.Drawing.Font("Bahnschrift SemiLight", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMessage.ForeColor = System.Drawing.Color.White;
            this.textMessage.Location = new System.Drawing.Point(12, 565);
            this.textMessage.Multiline = true;
            this.textMessage.Name = "textMessage";
            this.textMessage.ReadOnly = true;
            this.textMessage.Size = new System.Drawing.Size(551, 46);
            this.textMessage.TabIndex = 3;
            // 
            // listMessage1
            // 
            this.listMessage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.listMessage1.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listMessage1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.listMessage1.HideSelection = false;
            this.listMessage1.Location = new System.Drawing.Point(13, 158);
            this.listMessage1.Name = "listMessage1";
            this.listMessage1.Size = new System.Drawing.Size(1038, 389);
            this.listMessage1.TabIndex = 26;
            this.listMessage1.UseCompatibleStateImageBehavior = false;
            this.listMessage1.View = System.Windows.Forms.View.List;
            // 
            // cbRemotePort
            // 
            this.cbRemotePort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.cbRemotePort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbRemotePort.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRemotePort.ForeColor = System.Drawing.Color.DimGray;
            this.cbRemotePort.FormattingEnabled = true;
            this.cbRemotePort.Location = new System.Drawing.Point(868, 24);
            this.cbRemotePort.Name = "cbRemotePort";
            this.cbRemotePort.Size = new System.Drawing.Size(185, 32);
            this.cbRemotePort.TabIndex = 28;
            this.cbRemotePort.SelectedIndexChanged += new System.EventHandler(this.dbRemotePort_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.btnback);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.buttonStart);
            this.panel1.Controls.Add(this.cbRemotePort);
            this.panel1.ForeColor = System.Drawing.Color.DimGray;
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1066, 84);
            this.panel1.TabIndex = 30;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MainProject.Properties.Resources.messaging_icon;
            this.pictureBox1.Location = new System.Drawing.Point(499, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnback.FlatAppearance.BorderSize = 0;
            this.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnback.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.ForeColor = System.Drawing.Color.DimGray;
            this.btnback.Location = new System.Drawing.Point(3, 0);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(85, 81);
            this.btnback.TabIndex = 32;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // Messaging
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1062, 653);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listMessage1);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textMessage);
            this.Name = "Messaging";
            this.Text = "Messaging";
            this.Load += new System.EventHandler(this.Messaging_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.TextBox textMessage;
        private System.Windows.Forms.ListView listMessage1;
        private System.Windows.Forms.ComboBox cbRemotePort;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnback;
    }
}