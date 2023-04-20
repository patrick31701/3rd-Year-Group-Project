
namespace MainProject.Owner
{
    partial class Owner_Manage_Marketing_Details
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.productType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.endDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.discountPercentage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.discountCode = new System.Windows.Forms.TextBox();
            this.fName = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.discount_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discount_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discount_percentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.start_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.end_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.productType);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.endDate);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.startDate);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.discountPercentage);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.discountCode);
            this.panel1.Controls.Add(this.fName);
            this.panel1.Location = new System.Drawing.Point(49, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(864, 421);
            this.panel1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(48, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 31);
            this.label4.TabIndex = 19;
            this.label4.Text = "Product Type";
            // 
            // productType
            // 
            this.productType.FormattingEnabled = true;
            this.productType.Location = new System.Drawing.Point(340, 258);
            this.productType.Name = "productType";
            this.productType.Size = new System.Drawing.Size(184, 33);
            this.productType.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(48, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 31);
            this.label3.TabIndex = 17;
            this.label3.Text = "End Date";
            // 
            // endDate
            // 
            this.endDate.Location = new System.Drawing.Point(340, 205);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(373, 31);
            this.endDate.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(48, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 31);
            this.label2.TabIndex = 15;
            this.label2.Text = "Start Date";
            // 
            // startDate
            // 
            this.startDate.Location = new System.Drawing.Point(340, 153);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(373, 31);
            this.startDate.TabIndex = 14;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Nirmala UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(663, 345);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(148, 58);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Nirmala UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(456, 345);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(148, 58);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click_1);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Nirmala UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(252, 345);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(148, 58);
            this.btnEdit.TabIndex = 11;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Nirmala UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(59, 345);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(148, 58);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // discountPercentage
            // 
            this.discountPercentage.Location = new System.Drawing.Point(340, 96);
            this.discountPercentage.Name = "discountPercentage";
            this.discountPercentage.Size = new System.Drawing.Size(116, 31);
            this.discountPercentage.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(48, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Discount Percentage";
            // 
            // discountCode
            // 
            this.discountCode.Location = new System.Drawing.Point(340, 37);
            this.discountCode.Name = "discountCode";
            this.discountCode.Size = new System.Drawing.Size(196, 31);
            this.discountCode.TabIndex = 1;
            // 
            // fName
            // 
            this.fName.AutoSize = true;
            this.fName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fName.ForeColor = System.Drawing.SystemColors.Control;
            this.fName.Location = new System.Drawing.Point(48, 34);
            this.fName.Name = "fName";
            this.fName.Size = new System.Drawing.Size(206, 31);
            this.fName.TabIndex = 0;
            this.fName.Text = "Discount Code";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.discount_id,
            this.discount_code,
            this.discount_percentage,
            this.start_date,
            this.end_date,
            this.product_type});
            this.dataGridView1.Location = new System.Drawing.Point(49, 469);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(864, 302);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // discount_id
            // 
            this.discount_id.HeaderText = "Discount ID";
            this.discount_id.MinimumWidth = 10;
            this.discount_id.Name = "discount_id";
            this.discount_id.Width = 200;
            // 
            // discount_code
            // 
            this.discount_code.HeaderText = "Discount Code";
            this.discount_code.MinimumWidth = 10;
            this.discount_code.Name = "discount_code";
            this.discount_code.Width = 200;
            // 
            // discount_percentage
            // 
            this.discount_percentage.HeaderText = "Discount Percentage";
            this.discount_percentage.MinimumWidth = 10;
            this.discount_percentage.Name = "discount_percentage";
            this.discount_percentage.Width = 200;
            // 
            // start_date
            // 
            this.start_date.HeaderText = "Start Date";
            this.start_date.MinimumWidth = 10;
            this.start_date.Name = "start_date";
            this.start_date.Width = 200;
            // 
            // end_date
            // 
            this.end_date.HeaderText = "End Date";
            this.end_date.MinimumWidth = 10;
            this.end_date.Name = "end_date";
            this.end_date.Width = 200;
            // 
            // product_type
            // 
            this.product_type.HeaderText = "Product Type";
            this.product_type.MinimumWidth = 10;
            this.product_type.Name = "product_type";
            this.product_type.Width = 200;
            // 
            // Owner_Manage_Marketing_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(951, 783);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "Owner_Manage_Marketing_Details";
            this.Text = "Owner_Manage_Marketing_Details";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox discountPercentage;
        private System.Windows.Forms.TextBox discountCode;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox productType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker endDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker startDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label fName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn discount_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn discount_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn discount_percentage;
        private System.Windows.Forms.DataGridViewTextBoxColumn start_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn end_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_type;
    }
}