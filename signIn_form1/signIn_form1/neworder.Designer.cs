namespace signIn_form1
{
    partial class neworder
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
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTable = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtQTY = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbProducts = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnadd = new System.Windows.Forms.Button();
            this.dtGrd_Items = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tab_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnbill = new System.Windows.Forms.Button();
            this.totamt = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtContactNo = new System.Windows.Forms.TextBox();
            this.lblContN0 = new System.Windows.Forms.Label();
            this.btnOrder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrd_Items)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.MaximumSize = new System.Drawing.Size(1072, 63);
            this.label3.MinimumSize = new System.Drawing.Size(1072, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1072, 63);
            this.label3.TabIndex = 21;
            this.label3.Text = "New Order";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // cmbTable
            // 
            this.cmbTable.DisplayMember = "cat_Id";
            this.cmbTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTable.FormattingEnabled = true;
            this.cmbTable.Location = new System.Drawing.Point(443, 135);
            this.cmbTable.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTable.Name = "cmbTable";
            this.cmbTable.Size = new System.Drawing.Size(355, 37);
            this.cmbTable.TabIndex = 37;
            this.cmbTable.ValueMember = "cat_Id";
            this.cmbTable.SelectedIndexChanged += new System.EventHandler(this.cmbTable_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(195, 133);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 39);
            this.label1.TabIndex = 36;
            this.label1.Text = "Select Table :";
            // 
            // txtQTY
            // 
            this.txtQTY.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtQTY.Location = new System.Drawing.Point(443, 260);
            this.txtQTY.Margin = new System.Windows.Forms.Padding(4);
            this.txtQTY.Multiline = true;
            this.txtQTY.Name = "txtQTY";
            this.txtQTY.Size = new System.Drawing.Size(148, 35);
            this.txtQTY.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(259, 258);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 39);
            this.label4.TabIndex = 34;
            this.label4.Text = "Quantity :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // cmbProducts
            // 
            this.cmbProducts.DisplayMember = "cat_Id";
            this.cmbProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProducts.FormattingEnabled = true;
            this.cmbProducts.Location = new System.Drawing.Point(443, 199);
            this.cmbProducts.Margin = new System.Windows.Forms.Padding(4);
            this.cmbProducts.Name = "cmbProducts";
            this.cmbProducts.Size = new System.Drawing.Size(355, 37);
            this.cmbProducts.TabIndex = 39;
            this.cmbProducts.ValueMember = "cat_Id";
            this.cmbProducts.SelectedIndexChanged += new System.EventHandler(this.product_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(265, 194);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 39);
            this.label2.TabIndex = 38;
            this.label2.Text = "Product :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.White;
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnadd.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btnadd.Location = new System.Drawing.Point(865, 138);
            this.btnadd.Margin = new System.Windows.Forms.Padding(4);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(192, 57);
            this.btnadd.TabIndex = 41;
            this.btnadd.Text = "Add Item";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // dtGrd_Items
            // 
            this.dtGrd_Items.AllowUserToAddRows = false;
            this.dtGrd_Items.AllowUserToDeleteRows = false;
            this.dtGrd_Items.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrd_Items.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.ProdID,
            this.Product,
            this.QTY,
            this.Amount,
            this.Price,
            this.Tab_ID});
            this.dtGrd_Items.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtGrd_Items.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtGrd_Items.Location = new System.Drawing.Point(0, 382);
            this.dtGrd_Items.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtGrd_Items.MultiSelect = false;
            this.dtGrd_Items.Name = "dtGrd_Items";
            this.dtGrd_Items.ReadOnly = true;
            this.dtGrd_Items.RowHeadersVisible = false;
            this.dtGrd_Items.RowTemplate.Height = 25;
            this.dtGrd_Items.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGrd_Items.Size = new System.Drawing.Size(1068, 150);
            this.dtGrd_Items.TabIndex = 43;
            this.dtGrd_Items.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Sr.No";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // ProdID
            // 
            this.ProdID.HeaderText = "ProductID";
            this.ProdID.Name = "ProdID";
            this.ProdID.ReadOnly = true;
            // 
            // Product
            // 
            this.Product.HeaderText = "Product";
            this.Product.Name = "Product";
            this.Product.ReadOnly = true;
            // 
            // QTY
            // 
            this.QTY.HeaderText = "QTY";
            this.QTY.Name = "QTY";
            this.QTY.ReadOnly = true;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.HeaderText = "Total Amount";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Tab_ID
            // 
            this.Tab_ID.HeaderText = "Table ID";
            this.Tab_ID.Name = "Tab_ID";
            this.Tab_ID.ReadOnly = true;
            // 
            // btnbill
            // 
            this.btnbill.BackColor = System.Drawing.Color.White;
            this.btnbill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnbill.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btnbill.Location = new System.Drawing.Point(869, 276);
            this.btnbill.Margin = new System.Windows.Forms.Padding(4);
            this.btnbill.Name = "btnbill";
            this.btnbill.Size = new System.Drawing.Size(188, 54);
            this.btnbill.TabIndex = 44;
            this.btnbill.Text = "Bill";
            this.btnbill.UseVisualStyleBackColor = false;
            this.btnbill.Click += new System.EventHandler(this.btnbill_Click);
            // 
            // totamt
            // 
            this.totamt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totamt.Location = new System.Drawing.Point(153, 106);
            this.totamt.Margin = new System.Windows.Forms.Padding(4);
            this.totamt.Multiline = true;
            this.totamt.Name = "totamt";
            this.totamt.Size = new System.Drawing.Size(23, 15);
            this.totamt.TabIndex = 45;
            this.totamt.Visible = false;
            this.totamt.TextChanged += new System.EventHandler(this.totamt_TextChanged);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(-1, 66);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(61, 46);
            this.linkLabel1.TabIndex = 46;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "←";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPrice.Location = new System.Drawing.Point(807, 201);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(0, 39);
            this.lblPrice.TabIndex = 47;
            // 
            // txtContactNo
            // 
            this.txtContactNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtContactNo.Location = new System.Drawing.Point(443, 316);
            this.txtContactNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtContactNo.Multiline = true;
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.Size = new System.Drawing.Size(355, 35);
            this.txtContactNo.TabIndex = 49;
            this.txtContactNo.Visible = false;
            // 
            // lblContN0
            // 
            this.lblContN0.AutoSize = true;
            this.lblContN0.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContN0.ForeColor = System.Drawing.SystemColors.Control;
            this.lblContN0.Location = new System.Drawing.Point(217, 315);
            this.lblContN0.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContN0.Name = "lblContN0";
            this.lblContN0.Size = new System.Drawing.Size(205, 39);
            this.lblContN0.TabIndex = 48;
            this.lblContN0.Text = "Contact No :";
            this.lblContN0.Visible = false;
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.White;
            this.btnOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnOrder.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btnOrder.Location = new System.Drawing.Point(869, 208);
            this.btnOrder.Margin = new System.Windows.Forms.Padding(4);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(188, 55);
            this.btnOrder.TabIndex = 50;
            this.btnOrder.Text = "Place Order";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // neworder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(1068, 532);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.txtContactNo);
            this.Controls.Add(this.lblContN0);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.totamt);
            this.Controls.Add(this.btnbill);
            this.Controls.Add(this.dtGrd_Items);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.cmbProducts);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbTable);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtQTY);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1086, 579);
            this.MinimumSize = new System.Drawing.Size(1086, 579);
            this.Name = "neworder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "neworder";
            this.Load += new System.EventHandler(this.neworder_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dtGrd_Items)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtQTY;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbProducts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.DataGridView dtGrd_Items;
        private System.Windows.Forms.Button btnbill;
        private System.Windows.Forms.TextBox totamt;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtContactNo;
        private System.Windows.Forms.Label lblContN0;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn QTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tab_ID;
    }
}