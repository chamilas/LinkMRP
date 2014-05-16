namespace MRP_GUI
{
    partial class frmMTN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMTN));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbStoreFrom = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbMTNType = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtGRNQty = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtAvailableQty = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtGRNUnitCost = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtStockHoldingCost = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbGRNNO = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbItem = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.cmbDepartmentTo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbDepartmentFrom = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.bindMTNList = new System.Windows.Forms.BindingSource(this.components);
            this.bindGRNList = new System.Windows.Forms.BindingSource(this.components);
            this.bindItemList = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.bindStores = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindMTNList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindGRNList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindItemList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindStores)).BeginInit();
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
            this.groupBox1.Controls.Add(this.cmbDepartmentTo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbDepartmentFrom);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(617, 453);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Material Transfer Note - From Specific Good Receive Note";
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
            this.cmbMTNType.Size = new System.Drawing.Size(200, 21);
            this.cmbMTNType.TabIndex = 15;
            this.cmbMTNType.SelectedIndexChanged += new System.EventHandler(this.cmbMTNType_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(46, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "MTN Type";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.txtGRNQty);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.txtAvailableQty);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txtQty);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtUnit);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtGRNUnitCost);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtStockHoldingCost);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cmbGRNNO);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtRemarks);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cmbItem);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(12, 137);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(599, 281);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Item";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txtGRNQty
            // 
            this.txtGRNQty.Location = new System.Drawing.Point(118, 177);
            this.txtGRNQty.Name = "txtGRNQty";
            this.txtGRNQty.ReadOnly = true;
            this.txtGRNQty.Size = new System.Drawing.Size(89, 20);
            this.txtGRNQty.TabIndex = 25;
            this.txtGRNQty.Text = "0.0";
            this.txtGRNQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(39, 180);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 13);
            this.label14.TabIndex = 24;
            this.label14.Text = "GRN Quantity";
            // 
            // txtAvailableQty
            // 
            this.txtAvailableQty.Location = new System.Drawing.Point(118, 199);
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
            this.label13.Location = new System.Drawing.Point(20, 202);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 13);
            this.label13.TabIndex = 22;
            this.label13.Text = "Available Quantity";
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(118, 232);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(89, 20);
            this.txtQty.TabIndex = 21;
            this.txtQty.Text = "0.0";
            this.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtQty.Validated += new System.EventHandler(this.txtQty_Validated);
            this.txtQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQty_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(53, 235);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "Quantity";
            // 
            // txtUnit
            // 
            this.txtUnit.Location = new System.Drawing.Point(69, 55);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.ReadOnly = true;
            this.txtUnit.Size = new System.Drawing.Size(138, 20);
            this.txtUnit.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(37, 58);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Unit";
            // 
            // txtGRNUnitCost
            // 
            this.txtGRNUnitCost.Location = new System.Drawing.Point(118, 120);
            this.txtGRNUnitCost.Name = "txtGRNUnitCost";
            this.txtGRNUnitCost.ReadOnly = true;
            this.txtGRNUnitCost.Size = new System.Drawing.Size(89, 20);
            this.txtGRNUnitCost.TabIndex = 15;
            this.txtGRNUnitCost.Text = "0.0";
            this.txtGRNUnitCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(35, 123);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "GRN Unit Cost";
            // 
            // txtStockHoldingCost
            // 
            this.txtStockHoldingCost.Location = new System.Drawing.Point(118, 142);
            this.txtStockHoldingCost.Name = "txtStockHoldingCost";
            this.txtStockHoldingCost.ReadOnly = true;
            this.txtStockHoldingCost.Size = new System.Drawing.Size(89, 20);
            this.txtStockHoldingCost.TabIndex = 13;
            this.txtStockHoldingCost.Text = "0.0";
            this.txtStockHoldingCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Stock Holding Cost";
            // 
            // cmbGRNNO
            // 
            this.cmbGRNNO.DisplayMember = "GRNNO";
            this.cmbGRNNO.FormattingEnabled = true;
            this.cmbGRNNO.Location = new System.Drawing.Point(69, 88);
            this.cmbGRNNO.Name = "cmbGRNNO";
            this.cmbGRNNO.Size = new System.Drawing.Size(138, 21);
            this.cmbGRNNO.TabIndex = 11;
            this.cmbGRNNO.ValueMember = "GRNNO";
            this.cmbGRNNO.SelectedIndexChanged += new System.EventHandler(this.cmbGRNNO_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "GRN";
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(222, 148);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRemarks.Size = new System.Drawing.Size(369, 104);
            this.txtRemarks.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(219, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Remarks";
            // 
            // cmbItem
            // 
            this.cmbItem.DisplayMember = "Item";
            this.cmbItem.FormattingEnabled = true;
            this.cmbItem.Location = new System.Drawing.Point(42, 29);
            this.cmbItem.Name = "cmbItem";
            this.cmbItem.Size = new System.Drawing.Size(271, 21);
            this.cmbItem.TabIndex = 7;
            this.cmbItem.ValueMember = "ItemCode";
            this.cmbItem.SelectedIndexChanged += new System.EventHandler(this.cmbItem_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Item";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(455, 424);
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
            this.btnExit.Location = new System.Drawing.Point(536, 424);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbDepartmentTo
            // 
            this.cmbDepartmentTo.DisplayMember = "DepName";
            this.cmbDepartmentTo.FormattingEnabled = true;
            this.cmbDepartmentTo.Location = new System.Drawing.Point(125, 110);
            this.cmbDepartmentTo.Name = "cmbDepartmentTo";
            this.cmbDepartmentTo.Size = new System.Drawing.Size(200, 21);
            this.cmbDepartmentTo.TabIndex = 5;
            this.cmbDepartmentTo.Text = "--Select Department To--";
            this.cmbDepartmentTo.ValueMember = "DepID";
            this.cmbDepartmentTo.SelectedIndexChanged += new System.EventHandler(this.cmbDepartmentTo_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Department To";
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
            this.cmbDepartmentFrom.ValueMember = "DepID";
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
            // frmMTN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 453);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMTN";
            this.Text = "Material Transfer Note ";
            this.Load += new System.EventHandler(this.frmMTN_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindMTNList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindGRNList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindItemList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindStores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ComboBox cmbDepartmentTo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbDepartmentFrom;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbGRNNO;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbItem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtStockHoldingCost;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbMTNType;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.BindingSource bindGRNList;
        private System.Windows.Forms.BindingSource bindItemList;
        private System.Windows.Forms.BindingSource bindMTNList;
        private System.Windows.Forms.BindingSource bindingSource4;
        private System.Windows.Forms.ComboBox cmbStoreFrom;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtGRNUnitCost;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtAvailableQty;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtGRNQty;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.BindingSource bindStores;
    }
}