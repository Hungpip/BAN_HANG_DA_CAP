namespace BAN_HANG_DA_CAP
{
    partial class Update_Product
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPro = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPri = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbErPo = new System.Windows.Forms.Label();
            this.lbErNa = new System.Windows.Forms.Label();
            this.lbErCa = new System.Windows.Forms.Label();
            this.lbErPri = new System.Windows.Forms.Label();
            this.lbErPo1 = new System.Windows.Forms.Label();
            this.btnUp = new System.Windows.Forms.Button();
            this.lbErQuan = new System.Windows.Forms.Label();
            this.txtQuan = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column5,
            this.Column3});
            this.dgv.Location = new System.Drawing.Point(39, 189);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersVisible = false;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(453, 249);
            this.dgv.TabIndex = 0;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "product_id";
            this.Column1.HeaderText = "Product ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "product_name";
            this.Column2.HeaderText = "Product Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "category_id";
            this.Column4.HeaderText = "Category ID";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "price";
            this.Column5.HeaderText = "Price";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "quantity";
            this.Column3.HeaderText = "Quantity";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Product_ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Product_name:";
            // 
            // txtPro
            // 
            this.txtPro.Location = new System.Drawing.Point(95, 17);
            this.txtPro.Name = "txtPro";
            this.txtPro.Size = new System.Drawing.Size(92, 20);
            this.txtPro.TabIndex = 1;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(43, 142);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 6;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click_1);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(282, 142);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(408, 142);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(95, 62);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(182, 20);
            this.txtName.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(293, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Category:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(293, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Price:";
            // 
            // txtPri
            // 
            this.txtPri.Location = new System.Drawing.Point(351, 62);
            this.txtPri.Name = "txtPri";
            this.txtPri.Size = new System.Drawing.Size(162, 20);
            this.txtPri.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(351, 16);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(162, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // lbErPo
            // 
            this.lbErPo.AutoSize = true;
            this.lbErPo.BackColor = System.Drawing.SystemColors.Control;
            this.lbErPo.ForeColor = System.Drawing.Color.Red;
            this.lbErPo.Location = new System.Drawing.Point(92, 1);
            this.lbErPo.Name = "lbErPo";
            this.lbErPo.Size = new System.Drawing.Size(0, 13);
            this.lbErPo.TabIndex = 16;
            // 
            // lbErNa
            // 
            this.lbErNa.AutoSize = true;
            this.lbErNa.BackColor = System.Drawing.SystemColors.Control;
            this.lbErNa.ForeColor = System.Drawing.Color.Red;
            this.lbErNa.Location = new System.Drawing.Point(92, 46);
            this.lbErNa.Name = "lbErNa";
            this.lbErNa.Size = new System.Drawing.Size(0, 13);
            this.lbErNa.TabIndex = 17;
            // 
            // lbErCa
            // 
            this.lbErCa.AutoSize = true;
            this.lbErCa.ForeColor = System.Drawing.Color.Red;
            this.lbErCa.Location = new System.Drawing.Point(348, 0);
            this.lbErCa.Name = "lbErCa";
            this.lbErCa.Size = new System.Drawing.Size(0, 13);
            this.lbErCa.TabIndex = 18;
            // 
            // lbErPri
            // 
            this.lbErPri.AutoSize = true;
            this.lbErPri.ForeColor = System.Drawing.Color.Red;
            this.lbErPri.Location = new System.Drawing.Point(348, 46);
            this.lbErPri.Name = "lbErPri";
            this.lbErPri.Size = new System.Drawing.Size(0, 13);
            this.lbErPri.TabIndex = 20;
            // 
            // lbErPo1
            // 
            this.lbErPo1.AutoSize = true;
            this.lbErPo1.BackColor = System.Drawing.SystemColors.Control;
            this.lbErPo1.ForeColor = System.Drawing.Color.Red;
            this.lbErPo1.Location = new System.Drawing.Point(92, 1);
            this.lbErPo1.Name = "lbErPo1";
            this.lbErPo1.Size = new System.Drawing.Size(0, 13);
            this.lbErPo1.TabIndex = 21;
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(164, 142);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(75, 23);
            this.btnUp.TabIndex = 7;
            this.btnUp.Text = "Update";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // lbErQuan
            // 
            this.lbErQuan.AutoSize = true;
            this.lbErQuan.ForeColor = System.Drawing.Color.Red;
            this.lbErQuan.Location = new System.Drawing.Point(192, 88);
            this.lbErQuan.Name = "lbErQuan";
            this.lbErQuan.Size = new System.Drawing.Size(0, 13);
            this.lbErQuan.TabIndex = 24;
            // 
            // txtQuan
            // 
            this.txtQuan.Location = new System.Drawing.Point(195, 104);
            this.txtQuan.Name = "txtQuan";
            this.txtQuan.Size = new System.Drawing.Size(162, 20);
            this.txtQuan.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(137, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Quantity:";
            // 
            // Update_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 450);
            this.Controls.Add(this.lbErQuan);
            this.Controls.Add(this.txtQuan);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.lbErPo1);
            this.Controls.Add(this.lbErPri);
            this.Controls.Add(this.lbErCa);
            this.Controls.Add(this.lbErNa);
            this.Controls.Add(this.lbErPo);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtPri);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.txtPro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv);
            this.Name = "Update_Product";
            this.Text = "Update_Product";
            this.Load += new System.EventHandler(this.Update_Product_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPro;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPri;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lbErPo;
        private System.Windows.Forms.Label lbErNa;
        private System.Windows.Forms.Label lbErCa;
        private System.Windows.Forms.Label lbErPri;
        private System.Windows.Forms.Label lbErPo1;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Label lbErQuan;
        private System.Windows.Forms.TextBox txtQuan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}