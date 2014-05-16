namespace MRP_GUI.Sales
{
    partial class frmCustomerRegistration
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.cmbProductType = new System.Windows.Forms.ComboBox();
            this.cmbTerritory = new System.Windows.Forms.ComboBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.btnAddTerritory = new System.Windows.Forms.Button();
            this.btnDeleteTerritory = new System.Windows.Forms.Button();
            this.lbTerritory = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalesMethod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.cmbSelectMethod = new System.Windows.Forms.ComboBox();
            this.objCustomerBindingSourse = new System.Windows.Forms.BindingSource(this.components);
            this.bsSalesMethod = new System.Windows.Forms.BindingSource(this.components);
            this.bsProductType = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objCustomerBindingSourse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSalesMethod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProductType)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Address :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telephone :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Product Type :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Sales Method :";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(525, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Territory :";
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(91, 13);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(398, 20);
            this.txtCustomerID.TabIndex = 7;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(91, 45);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(398, 20);
            this.txtCustomerName.TabIndex = 8;
            // 
            // txtTelephone
            // 
            this.txtTelephone.Location = new System.Drawing.Point(91, 142);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(398, 20);
            this.txtTelephone.TabIndex = 10;
            // 
            // cmbProductType
            // 
            this.cmbProductType.DisplayMember = "ProductCatID";
            this.cmbProductType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProductType.FormattingEnabled = true;
            this.cmbProductType.Location = new System.Drawing.Point(91, 110);
            this.cmbProductType.Name = "cmbProductType";
            this.cmbProductType.Size = new System.Drawing.Size(398, 21);
            this.cmbProductType.TabIndex = 12;
            // 
            // cmbTerritory
            // 
            this.cmbTerritory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbTerritory.DisplayMember = "Name";
            this.cmbTerritory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTerritory.FormattingEnabled = true;
            this.cmbTerritory.Location = new System.Drawing.Point(583, 12);
            this.cmbTerritory.Name = "cmbTerritory";
            this.cmbTerritory.Size = new System.Drawing.Size(410, 21);
            this.cmbTerritory.TabIndex = 13;
            this.cmbTerritory.ValueMember = "TerritoryID";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(91, 170);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAddress.Size = new System.Drawing.Size(398, 63);
            this.txtAddress.TabIndex = 76;
            // 
            // btnAddTerritory
            // 
            this.btnAddTerritory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddTerritory.Location = new System.Drawing.Point(584, 42);
            this.btnAddTerritory.Name = "btnAddTerritory";
            this.btnAddTerritory.Size = new System.Drawing.Size(178, 23);
            this.btnAddTerritory.TabIndex = 77;
            this.btnAddTerritory.Text = "Add Territory ";
            this.btnAddTerritory.UseVisualStyleBackColor = true;
            this.btnAddTerritory.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDeleteTerritory
            // 
            this.btnDeleteTerritory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteTerritory.Location = new System.Drawing.Point(836, 42);
            this.btnDeleteTerritory.Name = "btnDeleteTerritory";
            this.btnDeleteTerritory.Size = new System.Drawing.Size(157, 23);
            this.btnDeleteTerritory.TabIndex = 78;
            this.btnDeleteTerritory.Text = "Delete Territory";
            this.btnDeleteTerritory.UseVisualStyleBackColor = true;
            this.btnDeleteTerritory.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbTerritory
            // 
            this.lbTerritory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTerritory.FormattingEnabled = true;
            this.lbTerritory.Location = new System.Drawing.Point(584, 77);
            this.lbTerritory.Name = "lbTerritory";
            this.lbTerritory.Size = new System.Drawing.Size(409, 95);
            this.lbTerritory.TabIndex = 79;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerID,
            this.CustomerName,
            this.Address,
            this.SalesMethod,
            this.ProductType,
            this.Telephone});
            this.dataGridView1.Location = new System.Drawing.Point(8, 288);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(984, 357);
            this.dataGridView1.TabIndex = 80;
            // 
            // CustomerID
            // 
            this.CustomerID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CustomerID.DataPropertyName = "CustomerID";
            this.CustomerID.HeaderText = "Customer ID";
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.ReadOnly = true;
            // 
            // CustomerName
            // 
            this.CustomerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CustomerName.DataPropertyName = "Name";
            this.CustomerName.HeaderText = "Customer Name";
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // SalesMethod
            // 
            this.SalesMethod.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SalesMethod.DataPropertyName = "SalesMethod";
            this.SalesMethod.HeaderText = "Sales Method";
            this.SalesMethod.Name = "SalesMethod";
            this.SalesMethod.ReadOnly = true;
            // 
            // ProductType
            // 
            this.ProductType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductType.DataPropertyName = "ProductType";
            this.ProductType.HeaderText = "Product Type";
            this.ProductType.Name = "ProductType";
            this.ProductType.ReadOnly = true;
            // 
            // Telephone
            // 
            this.Telephone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Telephone.DataPropertyName = "Telephone";
            this.Telephone.HeaderText = "Telephone";
            this.Telephone.Name = "Telephone";
            this.Telephone.ReadOnly = true;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(865, 257);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 25);
            this.button3.TabIndex = 81;
            this.button3.Text = "Clear";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Location = new System.Drawing.Point(730, 257);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(129, 24);
            this.button4.TabIndex = 82;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.Location = new System.Drawing.Point(584, 255);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(140, 26);
            this.button5.TabIndex = 83;
            this.button5.Text = "Insert";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // cmbSelectMethod
            // 
            this.cmbSelectMethod.DisplayMember = "SalesMethodID";
            this.cmbSelectMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSelectMethod.FormattingEnabled = true;
            this.cmbSelectMethod.Location = new System.Drawing.Point(91, 77);
            this.cmbSelectMethod.Name = "cmbSelectMethod";
            this.cmbSelectMethod.Size = new System.Drawing.Size(398, 21);
            this.cmbSelectMethod.TabIndex = 84;
            this.cmbSelectMethod.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // frmCustomerRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 657);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbSelectMethod);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbTerritory);
            this.Controls.Add(this.btnDeleteTerritory);
            this.Controls.Add(this.btnAddTerritory);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.cmbTerritory);
            this.Controls.Add(this.cmbProductType);
            this.Controls.Add(this.txtTelephone);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "frmCustomerRegistration";
            this.Text = "Customer Registration";
            this.Load += new System.EventHandler(this.frmCustomerRegistration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objCustomerBindingSourse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSalesMethod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProductType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.ComboBox cmbProductType;
        private System.Windows.Forms.ComboBox cmbTerritory;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Button btnAddTerritory;
        private System.Windows.Forms.Button btnDeleteTerritory;
        private System.Windows.Forms.ListBox lbTerritory;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox cmbSelectMethod;
        private System.Windows.Forms.BindingSource objCustomerBindingSourse;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalesMethod;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telephone;
        private System.Windows.Forms.BindingSource bsSalesMethod;
        private System.Windows.Forms.BindingSource bsProductType;
    }
}