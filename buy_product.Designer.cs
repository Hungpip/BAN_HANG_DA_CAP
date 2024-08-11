namespace BAN_HANG_DA_CAP
{
    partial class buy_product
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtQuan = new System.Windows.Forms.TextBox();
            this.btnBuy = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lbB1 = new System.Windows.Forms.Label();
            this.product_list = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbQua = new System.Windows.Forms.Label();
            this.customer_list = new System.Windows.Forms.DataGridView();
            this.cus_id_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cus_name_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cus_phone_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.product_list)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customer_list)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(508, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(404, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Order, buy products";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(510, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Quantity:";
            // 
            // txtQuan
            // 
            this.txtQuan.Location = new System.Drawing.Point(566, 83);
            this.txtQuan.Name = "txtQuan";
            this.txtQuan.Size = new System.Drawing.Size(117, 20);
            this.txtQuan.TabIndex = 1;
            this.txtQuan.TextChanged += new System.EventHandler(this.txtQuan_TextChanged);
            // 
            // btnBuy
            // 
            this.btnBuy.Location = new System.Drawing.Point(690, 212);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(81, 48);
            this.btnBuy.TabIndex = 2;
            this.btnBuy.Text = "Buy";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(871, 360);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 48);
            this.button2.TabIndex = 4;
            this.button2.Text = "Exit ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbB1
            // 
            this.lbB1.AutoSize = true;
            this.lbB1.Location = new System.Drawing.Point(496, 247);
            this.lbB1.Name = "lbB1";
            this.lbB1.Size = new System.Drawing.Size(0, 13);
            this.lbB1.TabIndex = 26;
            // 
            // product_list
            // 
            this.product_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.product_list.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column5,
            this.Column3});
            this.product_list.Location = new System.Drawing.Point(54, 9);
            this.product_list.MultiSelect = false;
            this.product_list.Name = "product_list";
            this.product_list.ReadOnly = true;
            this.product_list.RowHeadersVisible = false;
            this.product_list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.product_list.Size = new System.Drawing.Size(385, 184);
            this.product_list.TabIndex = 27;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "product_id";
            this.Column1.HeaderText = "Product_ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 70;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "product_name";
            this.Column2.HeaderText = "Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "category_id";
            this.Column4.HeaderText = "Category";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 55;
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
            // lbQua
            // 
            this.lbQua.AutoSize = true;
            this.lbQua.BackColor = System.Drawing.Color.Red;
            this.lbQua.Location = new System.Drawing.Point(687, 80);
            this.lbQua.Name = "lbQua";
            this.lbQua.Size = new System.Drawing.Size(11, 13);
            this.lbQua.TabIndex = 32;
            this.lbQua.Text = "*";
            // 
            // customer_list
            // 
            this.customer_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customer_list.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cus_id_col,
            this.cus_name_col,
            this.cus_phone_col});
            this.customer_list.Location = new System.Drawing.Point(12, 202);
            this.customer_list.MultiSelect = false;
            this.customer_list.Name = "customer_list";
            this.customer_list.RowHeadersVisible = false;
            this.customer_list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.customer_list.Size = new System.Drawing.Size(456, 206);
            this.customer_list.TabIndex = 33;
            // 
            // cus_id_col
            // 
            this.cus_id_col.DataPropertyName = "id";
            this.cus_id_col.HeaderText = "ID";
            this.cus_id_col.Name = "cus_id_col";
            this.cus_id_col.ReadOnly = true;
            // 
            // cus_name_col
            // 
            this.cus_name_col.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cus_name_col.DataPropertyName = "name";
            this.cus_name_col.HeaderText = "Customer name";
            this.cus_name_col.Name = "cus_name_col";
            this.cus_name_col.ReadOnly = true;
            // 
            // cus_phone_col
            // 
            this.cus_phone_col.DataPropertyName = "number";
            this.cus_phone_col.HeaderText = "Phone";
            this.cus_phone_col.Name = "cus_phone_col";
            this.cus_phone_col.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(161, 29);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox1.Text = "Delete";
            this.toolStripTextBox1.Click += new System.EventHandler(this.toolStripTextBox1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(518, 360);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 48);
            this.button1.TabIndex = 3;
            this.button1.Text = "delete user";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // buy_product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 420);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.customer_list);
            this.Controls.Add(this.lbQua);
            this.Controls.Add(this.product_list);
            this.Controls.Add(this.lbB1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.txtQuan);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Name = "buy_product";
            this.Text = "buy_product";
            ((System.ComponentModel.ISupportInitialize)(this.product_list)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customer_list)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtQuan;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbB1;
        private System.Windows.Forms.DataGridView product_list;
        private System.Windows.Forms.Label lbQua;
        private System.Windows.Forms.DataGridView customer_list;
        private System.Windows.Forms.DataGridViewTextBoxColumn cus_id_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn cus_name_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn cus_phone_col;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button button1;
    }
}