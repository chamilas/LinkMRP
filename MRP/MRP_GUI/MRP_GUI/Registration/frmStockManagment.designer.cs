namespace MRP_GUI
{
    partial class frmStockManagment
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStockManagment));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listItemList = new System.Windows.Forms.ListBox();
            this.bindItems = new System.Windows.Forms.BindingSource(this.components);
            this.lblUnit6 = new System.Windows.Forms.Label();
            this.lblUnit5 = new System.Windows.Forms.Label();
            this.lblUnit4 = new System.Windows.Forms.Label();
            this.lblUnit3 = new System.Windows.Forms.Label();
            this.lblUnit2 = new System.Windows.Forms.Label();
            this.lblUnit1 = new System.Windows.Forms.Label();
            this.txtReserved = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.gvStockList = new System.Windows.Forms.DataGridView();
            this.ColStockID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColItemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColStockQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColStockReorderLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMinimumStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMaxStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEconStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindStockList = new System.Windows.Forms.BindingSource(this.components);
            this.txtEconomicalQty = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMaximum = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMinimum = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtReorderLevel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbItem = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbStockType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbStores = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvStockList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindStockList)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listItemList);
            this.groupBox1.Controls.Add(this.lblUnit6);
            this.groupBox1.Controls.Add(this.lblUnit5);
            this.groupBox1.Controls.Add(this.lblUnit4);
            this.groupBox1.Controls.Add(this.lblUnit3);
            this.groupBox1.Controls.Add(this.lblUnit2);
            this.groupBox1.Controls.Add(this.lblUnit1);
            this.groupBox1.Controls.Add(this.txtReserved);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtStock);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.gvStockList);
            this.groupBox1.Controls.Add(this.txtEconomicalQty);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtMaximum);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtMinimum);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtReorderLevel);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbItem);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbStockType);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbStores);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(992, 623);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stock Management";
            // 
            // listItemList
            // 
            this.listItemList.DataSource = this.bindItems;
            this.listItemList.FormattingEnabled = true;
            this.listItemList.Location = new System.Drawing.Point(128, 100);
            this.listItemList.Name = "listItemList";
            this.listItemList.Size = new System.Drawing.Size(332, 95);
            this.listItemList.TabIndex = 29;
            // 
            // lblUnit6
            // 
            this.lblUnit6.AutoSize = true;
            this.lblUnit6.Location = new System.Drawing.Point(715, 140);
            this.lblUnit6.Name = "lblUnit6";
            this.lblUnit6.Size = new System.Drawing.Size(32, 13);
            this.lblUnit6.TabIndex = 28;
            this.lblUnit6.Text = "[Unit]";
            // 
            // lblUnit5
            // 
            this.lblUnit5.AutoSize = true;
            this.lblUnit5.Location = new System.Drawing.Point(715, 119);
            this.lblUnit5.Name = "lblUnit5";
            this.lblUnit5.Size = new System.Drawing.Size(32, 13);
            this.lblUnit5.TabIndex = 27;
            this.lblUnit5.Text = "[Unit]";
            // 
            // lblUnit4
            // 
            this.lblUnit4.AutoSize = true;
            this.lblUnit4.Location = new System.Drawing.Point(715, 98);
            this.lblUnit4.Name = "lblUnit4";
            this.lblUnit4.Size = new System.Drawing.Size(32, 13);
            this.lblUnit4.TabIndex = 26;
            this.lblUnit4.Text = "[Unit]";
            // 
            // lblUnit3
            // 
            this.lblUnit3.AutoSize = true;
            this.lblUnit3.Location = new System.Drawing.Point(715, 76);
            this.lblUnit3.Name = "lblUnit3";
            this.lblUnit3.Size = new System.Drawing.Size(32, 13);
            this.lblUnit3.TabIndex = 25;
            this.lblUnit3.Text = "[Unit]";
            // 
            // lblUnit2
            // 
            this.lblUnit2.AutoSize = true;
            this.lblUnit2.Location = new System.Drawing.Point(715, 42);
            this.lblUnit2.Name = "lblUnit2";
            this.lblUnit2.Size = new System.Drawing.Size(32, 13);
            this.lblUnit2.TabIndex = 24;
            this.lblUnit2.Text = "[Unit]";
            // 
            // lblUnit1
            // 
            this.lblUnit1.AutoSize = true;
            this.lblUnit1.Location = new System.Drawing.Point(715, 19);
            this.lblUnit1.Name = "lblUnit1";
            this.lblUnit1.Size = new System.Drawing.Size(32, 13);
            this.lblUnit1.TabIndex = 23;
            this.lblUnit1.Text = "[Unit]";
            // 
            // txtReserved
            // 
            this.txtReserved.Location = new System.Drawing.Point(609, 39);
            this.txtReserved.Name = "txtReserved";
            this.txtReserved.ReadOnly = true;
            this.txtReserved.Size = new System.Drawing.Size(100, 20);
            this.txtReserved.TabIndex = 22;
            this.txtReserved.Text = "0.00";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(520, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Reserved Qty";
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(609, 16);
            this.txtStock.Name = "txtStock";
            this.txtStock.ReadOnly = true;
            this.txtStock.Size = new System.Drawing.Size(100, 20);
            this.txtStock.TabIndex = 20;
            this.txtStock.Text = "0.00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(557, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Stock";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(896, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(896, 37);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(896, 61);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Visible = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // gvStockList
            // 
            this.gvStockList.AllowUserToAddRows = false;
            this.gvStockList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gvStockList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gvStockList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvStockList.AutoGenerateColumns = false;
            this.gvStockList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvStockList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColStockID,
            this.ColItemCode,
            this.ColItem,
            this.ColStockQty,
            this.ColStockReorderLevel,
            this.ColMinimumStock,
            this.ColMaxStock,
            this.ColEconStock});
            this.gvStockList.DataSource = this.bindStockList;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvStockList.DefaultCellStyle = dataGridViewCellStyle3;
            this.gvStockList.Location = new System.Drawing.Point(12, 202);
            this.gvStockList.Name = "gvStockList";
            this.gvStockList.ReadOnly = true;
            this.gvStockList.RowTemplate.Height = 20;
            this.gvStockList.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gvStockList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvStockList.Size = new System.Drawing.Size(968, 409);
            this.gvStockList.TabIndex = 10;
            this.gvStockList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvStockList_CellClick);
            // 
            // ColStockID
            // 
            this.ColStockID.DataPropertyName = "StockID";
            this.ColStockID.HeaderText = "StockID";
            this.ColStockID.Name = "ColStockID";
            this.ColStockID.ReadOnly = true;
            // 
            // ColItemCode
            // 
            this.ColItemCode.DataPropertyName = "ItemCode";
            this.ColItemCode.HeaderText = "Item Code";
            this.ColItemCode.Name = "ColItemCode";
            this.ColItemCode.ReadOnly = true;
            this.ColItemCode.Width = 125;
            // 
            // ColItem
            // 
            this.ColItem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColItem.DataPropertyName = "Item";
            this.ColItem.HeaderText = "Item";
            this.ColItem.MinimumWidth = 200;
            this.ColItem.Name = "ColItem";
            this.ColItem.ReadOnly = true;
            // 
            // ColStockQty
            // 
            this.ColStockQty.DataPropertyName = "StockQty";
            this.ColStockQty.HeaderText = "Stock";
            this.ColStockQty.Name = "ColStockQty";
            this.ColStockQty.ReadOnly = true;
            // 
            // ColStockReorderLevel
            // 
            this.ColStockReorderLevel.DataPropertyName = "StockReorderLevel";
            this.ColStockReorderLevel.HeaderText = "Re-Order Level";
            this.ColStockReorderLevel.Name = "ColStockReorderLevel";
            this.ColStockReorderLevel.ReadOnly = true;
            // 
            // ColMinimumStock
            // 
            this.ColMinimumStock.DataPropertyName = "StockMinimumQty";
            this.ColMinimumStock.HeaderText = "Minimum Stock";
            this.ColMinimumStock.Name = "ColMinimumStock";
            this.ColMinimumStock.ReadOnly = true;
            // 
            // ColMaxStock
            // 
            this.ColMaxStock.DataPropertyName = "StockMaximumQty";
            this.ColMaxStock.HeaderText = "Maximum Stock";
            this.ColMaxStock.Name = "ColMaxStock";
            this.ColMaxStock.ReadOnly = true;
            // 
            // ColEconStock
            // 
            this.ColEconStock.DataPropertyName = "StockEconomicalQty";
            dataGridViewCellStyle2.NullValue = null;
            this.ColEconStock.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColEconStock.HeaderText = "Economical Stock";
            this.ColEconStock.Name = "ColEconStock";
            this.ColEconStock.ReadOnly = true;
            // 
            // txtEconomicalQty
            // 
            this.txtEconomicalQty.Location = new System.Drawing.Point(609, 137);
            this.txtEconomicalQty.Name = "txtEconomicalQty";
            this.txtEconomicalQty.Size = new System.Drawing.Size(100, 20);
            this.txtEconomicalQty.TabIndex = 6;
            this.txtEconomicalQty.Text = "0.00";
            this.txtEconomicalQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEconomicalQty_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(511, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Economical Qty";
            // 
            // txtMaximum
            // 
            this.txtMaximum.Location = new System.Drawing.Point(609, 116);
            this.txtMaximum.Name = "txtMaximum";
            this.txtMaximum.Size = new System.Drawing.Size(100, 20);
            this.txtMaximum.TabIndex = 5;
            this.txtMaximum.Text = "0.00";
            this.txtMaximum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaximum_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(522, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Maximum Qty";
            // 
            // txtMinimum
            // 
            this.txtMinimum.Location = new System.Drawing.Point(609, 95);
            this.txtMinimum.Name = "txtMinimum";
            this.txtMinimum.Size = new System.Drawing.Size(100, 20);
            this.txtMinimum.TabIndex = 4;
            this.txtMinimum.Text = "0.00";
            this.txtMinimum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMinimum_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(525, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Minimum Qty";
            // 
            // txtReorderLevel
            // 
            this.txtReorderLevel.Location = new System.Drawing.Point(609, 74);
            this.txtReorderLevel.Name = "txtReorderLevel";
            this.txtReorderLevel.Size = new System.Drawing.Size(100, 20);
            this.txtReorderLevel.TabIndex = 3;
            this.txtReorderLevel.Text = "0.00";
            this.txtReorderLevel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtReorderLevel_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(515, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Re-order Level";
            // 
            // cmbItem
            // 
            this.cmbItem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbItem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbItem.DataSource = this.bindItems;
            this.cmbItem.FormattingEnabled = true;
            this.cmbItem.Location = new System.Drawing.Point(128, 72);
            this.cmbItem.Name = "cmbItem";
            this.cmbItem.Size = new System.Drawing.Size(332, 21);
            this.cmbItem.TabIndex = 2;
            this.cmbItem.SelectedIndexChanged += new System.EventHandler(this.cmbItem_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Item";
            // 
            // cmbStockType
            // 
            this.cmbStockType.FormattingEnabled = true;
            this.cmbStockType.Items.AddRange(new object[] {
            "Material",
            "Basic Product",
            "Finish Product"});
            this.cmbStockType.Location = new System.Drawing.Point(128, 45);
            this.cmbStockType.Name = "cmbStockType";
            this.cmbStockType.Size = new System.Drawing.Size(332, 21);
            this.cmbStockType.TabIndex = 1;
            this.cmbStockType.SelectedIndexChanged += new System.EventHandler(this.cmbStockType_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Stock Type";
            // 
            // cmbStores
            // 
            this.cmbStores.DisplayMember = "StoreName";
            this.cmbStores.FormattingEnabled = true;
            this.cmbStores.Location = new System.Drawing.Point(128, 18);
            this.cmbStores.Name = "cmbStores";
            this.cmbStores.Size = new System.Drawing.Size(332, 21);
            this.cmbStores.TabIndex = 0;
            this.cmbStores.SelectedIndexChanged += new System.EventHandler(this.cmbStores_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Store";
            // 
            // frmStockManagment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 623);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmStockManagment";
            this.Text = "Stock Management";
            this.Load += new System.EventHandler(this.frmStockManagment_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvStockList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindStockList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbStockType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbStores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEconomicalQty;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMaximum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMinimum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtReorderLevel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView gvStockList;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.BindingSource bindStockList;
        private System.Windows.Forms.TextBox txtReserved;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblUnit6;
        private System.Windows.Forms.Label lblUnit5;
        private System.Windows.Forms.Label lblUnit4;
        private System.Windows.Forms.Label lblUnit3;
        private System.Windows.Forms.Label lblUnit2;
        private System.Windows.Forms.Label lblUnit1;
        private System.Windows.Forms.BindingSource bindItems;
        private System.Windows.Forms.ListBox listItemList;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColStockID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColItemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColStockQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColStockReorderLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMinimumStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMaxStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEconStock;
    }
}