namespace MRP_GUI.Sales
{
    partial class frmCustomerProducts
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
            this.cmb_customer = new System.Windows.Forms.ComboBox();
            this.cmb_products = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_discountType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_tpye = new System.Windows.Forms.TextBox();
            this.grid_itemsPerPrice = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid_itemsPerDiscount = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmb_productCatType = new System.Windows.Forms.ComboBox();
            this.btn_save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid_itemsPerPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_itemsPerDiscount)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Name";
            // 
            // cmb_customer
            // 
            this.cmb_customer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_customer.FormattingEnabled = true;
            this.cmb_customer.Location = new System.Drawing.Point(33, 29);
            this.cmb_customer.Name = "cmb_customer";
            this.cmb_customer.Size = new System.Drawing.Size(240, 21);
            this.cmb_customer.TabIndex = 1;
            this.cmb_customer.SelectedIndexChanged += new System.EventHandler(this.cmb_customer_SelectedIndexChanged);
            // 
            // cmb_products
            // 
            this.cmb_products.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_products.FormattingEnabled = true;
            this.cmb_products.Location = new System.Drawing.Point(34, 115);
            this.cmb_products.Name = "cmb_products";
            this.cmb_products.Size = new System.Drawing.Size(239, 21);
            this.cmb_products.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Product ID";
            // 
            // cmb_discountType
            // 
            this.cmb_discountType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_discountType.FormattingEnabled = true;
            this.cmb_discountType.Items.AddRange(new object[] {
            "Price/Item",
            "Discount/Item"});
            this.cmb_discountType.Location = new System.Drawing.Point(301, 29);
            this.cmb_discountType.Name = "cmb_discountType";
            this.cmb_discountType.Size = new System.Drawing.Size(200, 21);
            this.cmb_discountType.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(298, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Discount Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(298, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Price/Discount Per Item";
            // 
            // txt_tpye
            // 
            this.txt_tpye.Location = new System.Drawing.Point(301, 70);
            this.txt_tpye.Name = "txt_tpye";
            this.txt_tpye.Size = new System.Drawing.Size(200, 20);
            this.txt_tpye.TabIndex = 7;
            // 
            // grid_itemsPerPrice
            // 
            this.grid_itemsPerPrice.AllowUserToAddRows = false;
            this.grid_itemsPerPrice.AllowUserToDeleteRows = false;
            this.grid_itemsPerPrice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_itemsPerPrice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.grid_itemsPerPrice.Location = new System.Drawing.Point(20, 163);
            this.grid_itemsPerPrice.Name = "grid_itemsPerPrice";
            this.grid_itemsPerPrice.ReadOnly = true;
            this.grid_itemsPerPrice.Size = new System.Drawing.Size(481, 142);
            this.grid_itemsPerPrice.TabIndex = 8;
            this.grid_itemsPerPrice.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_itemsPerPrice_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Remove";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 75;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Customer_Code";
            this.Column2.HeaderText = "Customer ID";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "BasicProductCode";
            this.Column3.HeaderText = "Basic Product Code";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 130;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "PrincePerQuantity";
            this.Column4.HeaderText = "Price Per Quantity";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // grid_itemsPerDiscount
            // 
            this.grid_itemsPerDiscount.AllowUserToAddRows = false;
            this.grid_itemsPerDiscount.AllowUserToDeleteRows = false;
            this.grid_itemsPerDiscount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_itemsPerDiscount.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.grid_itemsPerDiscount.Location = new System.Drawing.Point(20, 336);
            this.grid_itemsPerDiscount.Name = "grid_itemsPerDiscount";
            this.grid_itemsPerDiscount.ReadOnly = true;
            this.grid_itemsPerDiscount.Size = new System.Drawing.Size(481, 150);
            this.grid_itemsPerDiscount.TabIndex = 9;
            this.grid_itemsPerDiscount.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_itemsPerDiscount_CellClick);
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Remove";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 75;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Customer_Code";
            this.Column6.HeaderText = "Customer ID";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "BasicProductCode";
            this.Column7.HeaderText = "Basic Product Code";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 130;
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column8.DataPropertyName = "DiscountPerQuantity";
            this.Column8.HeaderText = "Discount Per Quantity";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Price/Item";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 320);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Discount/Item";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Product Type";
            // 
            // cmb_productCatType
            // 
            this.cmb_productCatType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_productCatType.FormattingEnabled = true;
            this.cmb_productCatType.Location = new System.Drawing.Point(33, 70);
            this.cmb_productCatType.Name = "cmb_productCatType";
            this.cmb_productCatType.Size = new System.Drawing.Size(240, 21);
            this.cmb_productCatType.TabIndex = 13;
            this.cmb_productCatType.SelectedIndexChanged += new System.EventHandler(this.cmb_productCatType_SelectedIndexChanged);
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(301, 105);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(200, 43);
            this.btn_save.TabIndex = 14;
            this.btn_save.Text = "Add";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // frmCustomerProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 505);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.cmb_productCatType);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.grid_itemsPerDiscount);
            this.Controls.Add(this.grid_itemsPerPrice);
            this.Controls.Add(this.txt_tpye);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmb_discountType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_products);
            this.Controls.Add(this.cmb_customer);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "frmCustomerProducts";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Products";
            this.Load += new System.EventHandler(this.frmCustomerProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_itemsPerPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_itemsPerDiscount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_customer;
        private System.Windows.Forms.ComboBox cmb_products;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_discountType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_tpye;
        private System.Windows.Forms.DataGridView grid_itemsPerPrice;
        private System.Windows.Forms.DataGridView grid_itemsPerDiscount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmb_productCatType;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.DataGridViewButtonColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
    }
}