namespace MRP_GUI
{
    partial class frmRemoveStock
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRemoveStock));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbStoreFrom = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbMTNType = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtAvailableQty = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnItemAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbItem = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.gvMTNList = new System.Windows.Forms.DataGridView();
            this.bindItemList = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.cmbDepartmentFrom = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bindMTNList = new System.Windows.Forms.BindingSource(this.components);
            this.bindGRNList = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvMTNList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindItemList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindMTNList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindGRNList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbStoreFrom);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cmbMTNType);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Controls.Add(this.gvMTNList);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbDepartmentFrom);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(940, 536);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reduce Stock Levels";
            // 
            // cmbStoreFrom
            // 
            this.cmbStoreFrom.DisplayMember = "StoreName";
            this.cmbStoreFrom.FormattingEnabled = true;
            this.cmbStoreFrom.Location = new System.Drawing.Point(125, 80);
            this.cmbStoreFrom.Name = "cmbStoreFrom";
            this.cmbStoreFrom.Size = new System.Drawing.Size(200, 21);
            this.cmbStoreFrom.TabIndex = 17;
            this.cmbStoreFrom.SelectedIndexChanged += new System.EventHandler(this.cmbStoreFrom_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(46, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Store From";
            // 
            // cmbMTNType
            // 
            this.cmbMTNType.FormattingEnabled = true;
            this.cmbMTNType.Items.AddRange(new object[] {
            "Material",
            "Basic Product",
            "Finish Product"});
            this.cmbMTNType.Location = new System.Drawing.Point(125, 19);
            this.cmbMTNType.Name = "cmbMTNType";
            this.cmbMTNType.Size = new System.Drawing.Size(147, 21);
            this.cmbMTNType.TabIndex = 15;
            this.cmbMTNType.SelectedIndexChanged += new System.EventHandler(this.cmbMTNType_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(46, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Item Type";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtAvailableQty);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txtQty);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.btnItemAdd);
            this.groupBox2.Controls.Add(this.btnClear);
            this.groupBox2.Controls.Add(this.txtUnit);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtRemarks);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cmbItem);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(331, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(603, 154);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Item";
            // 
            // txtAvailableQty
            // 
            this.txtAvailableQty.Location = new System.Drawing.Point(119, 66);
            this.txtAvailableQty.Name = "txtAvailableQty";
            this.txtAvailableQty.ReadOnly = true;
            this.txtAvailableQty.Size = new System.Drawing.Size(89, 20);
            this.txtAvailableQty.TabIndex = 23;
            this.txtAvailableQty.Text = "0.0";
            this.txtAvailableQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(21, 69);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 13);
            this.label13.TabIndex = 22;
            this.label13.Text = "Available Quantity";
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(119, 92);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(89, 20);
            this.txtQty.TabIndex = 21;
            this.txtQty.Text = "0.0";
            this.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtQty.Validated += new System.EventHandler(this.txtQty_Validated);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(67, 95);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "Quantity";
            // 
            // btnItemAdd
            // 
            this.btnItemAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnItemAdd.Location = new System.Drawing.Point(522, 125);
            this.btnItemAdd.Name = "btnItemAdd";
            this.btnItemAdd.Size = new System.Drawing.Size(75, 23);
            this.btnItemAdd.TabIndex = 19;
            this.btnItemAdd.Text = "Add";
            this.btnItemAdd.UseVisualStyleBackColor = true;
            this.btnItemAdd.Click += new System.EventHandler(this.btnItemAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Location = new System.Drawing.Point(441, 125);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 18;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtUnit
            // 
            this.txtUnit.Location = new System.Drawing.Point(70, 40);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.ReadOnly = true;
            this.txtUnit.Size = new System.Drawing.Size(138, 20);
            this.txtUnit.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(38, 43);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Unit";
            // 
            // txtRemarks
            // 
            this.txtRemarks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRemarks.Location = new System.Drawing.Point(340, 32);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRemarks.Size = new System.Drawing.Size(257, 91);
            this.txtRemarks.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(337, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Remarks";
            // 
            // cmbItem
            // 
            this.cmbItem.DisplayMember = "Item";
            this.cmbItem.FormattingEnabled = true;
            this.cmbItem.Location = new System.Drawing.Point(70, 13);
            this.cmbItem.Name = "cmbItem";
            this.cmbItem.Size = new System.Drawing.Size(261, 21);
            this.cmbItem.TabIndex = 7;
            this.cmbItem.ValueMember = "ItemCode";
            this.cmbItem.SelectedIndexChanged += new System.EventHandler(this.cmbItem_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Item";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(772, 507);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Location = new System.Drawing.Point(853, 507);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // gvMTNList
            // 
            this.gvMTNList.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gvMTNList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gvMTNList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gvMTNList.AutoGenerateColumns = false;
            this.gvMTNList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gvMTNList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvMTNList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.gvMTNList.DataSource = this.bindMTNList;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvMTNList.DefaultCellStyle = dataGridViewCellStyle2;
            this.gvMTNList.Location = new System.Drawing.Point(6, 168);
            this.gvMTNList.Name = "gvMTNList";
            this.gvMTNList.ReadOnly = true;
            this.gvMTNList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvMTNList.Size = new System.Drawing.Size(922, 332);
            this.gvMTNList.TabIndex = 7;
            this.gvMTNList.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.gvMTNList_UserDeletingRow);
            this.gvMTNList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvMTNList_CellClick);
            this.gvMTNList.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.gvMTNList_RowsRemoved);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Item List";
            // 
            // cmbDepartmentFrom
            // 
            this.cmbDepartmentFrom.DisplayMember = "DepName";
            this.cmbDepartmentFrom.FormattingEnabled = true;
            this.cmbDepartmentFrom.Location = new System.Drawing.Point(125, 58);
            this.cmbDepartmentFrom.Name = "cmbDepartmentFrom";
            this.cmbDepartmentFrom.Size = new System.Drawing.Size(200, 21);
            this.cmbDepartmentFrom.TabIndex = 3;
            this.cmbDepartmentFrom.Text = "--Select Department From--";
            this.cmbDepartmentFrom.SelectedIndexChanged += new System.EventHandler(this.cmbDepartmentFrom_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Department From";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Item";
            this.dataGridViewTextBoxColumn1.HeaderText = "Item";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 250;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Remarks";
            this.dataGridViewTextBoxColumn2.HeaderText = "Remarks";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Unit";
            this.dataGridViewTextBoxColumn3.HeaderText = "Unit";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Qty";
            this.dataGridViewTextBoxColumn4.HeaderText = "Transfer Qty";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Item";
            this.Column1.HeaderText = "Item";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 250;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "Remarks";
            this.Column2.HeaderText = "Remarks";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Unit";
            this.Column3.HeaderText = "Unit";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Qty";
            this.Column4.HeaderText = "Transfer Qty";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 150;
            // 
            // frmRemoveStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 536);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRemoveStock";
            this.Text = "Reduce Stock Levels";
            this.Load += new System.EventHandler(this.frmRemoveStock_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvMTNList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindItemList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindMTNList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindGRNList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbStoreFrom;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbMTNType;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtAvailableQty;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnItemAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbItem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView gvMTNList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbDepartmentFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource bindMTNList;
        private System.Windows.Forms.BindingSource bindGRNList;
        private System.Windows.Forms.BindingSource bindItemList;
        private System.Windows.Forms.BindingSource bindingSource4;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}