namespace MRP_GUI
{
    partial class frmMTNCosting
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMTNCosting));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCostReport = new System.Windows.Forms.Button();
            this.gvMTNList = new System.Windows.Forms.DataGridView();
            this.bindMTNList = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkBudget = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gvItemList = new System.Windows.Forms.DataGridView();
            this.ItemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindItemList = new System.Windows.Forms.BindingSource(this.components);
            this.btnSubmit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.bindDepartment = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BatchID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PackingID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvMTNList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindMTNList)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvItemList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindItemList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindDepartment)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCostReport);
            this.groupBox1.Controls.Add(this.gvMTNList);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1002, 616);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Material Transfer Note - Received";
            // 
            // btnCostReport
            // 
            this.btnCostReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCostReport.Location = new System.Drawing.Point(887, 309);
            this.btnCostReport.Name = "btnCostReport";
            this.btnCostReport.Size = new System.Drawing.Size(103, 27);
            this.btnCostReport.TabIndex = 7;
            this.btnCostReport.Text = "Cost Report";
            this.btnCostReport.UseVisualStyleBackColor = true;
            this.btnCostReport.Click += new System.EventHandler(this.btnCostReport_Click);
            // 
            // gvMTNList
            // 
            this.gvMTNList.AllowUserToAddRows = false;
            this.gvMTNList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gvMTNList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gvMTNList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvMTNList.AutoGenerateColumns = false;
            this.gvMTNList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvMTNList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3,
            this.Column4,
            this.Column5,
            this.BatchID,
            this.PackingID});
            this.gvMTNList.DataSource = this.bindMTNList;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvMTNList.DefaultCellStyle = dataGridViewCellStyle4;
            this.gvMTNList.Location = new System.Drawing.Point(12, 29);
            this.gvMTNList.Name = "gvMTNList";
            this.gvMTNList.ReadOnly = true;
            this.gvMTNList.RowHeadersVisible = false;
            this.gvMTNList.RowTemplate.Height = 30;
            this.gvMTNList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvMTNList.Size = new System.Drawing.Size(978, 274);
            this.gvMTNList.TabIndex = 6;
            this.gvMTNList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvMTNList_CellClick);
            this.gvMTNList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gvMTNList_KeyDown);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.chkBudget);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.gvItemList);
            this.groupBox2.Controls.Add(this.btnSubmit);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(6, 342);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(984, 270);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Item List";
            // 
            // chkBudget
            // 
            this.chkBudget.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkBudget.AutoSize = true;
            this.chkBudget.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBudget.Location = new System.Drawing.Point(395, 244);
            this.chkBudget.Name = "chkBudget";
            this.chkBudget.Size = new System.Drawing.Size(66, 17);
            this.chkBudget.TabIndex = 18;
            this.chkBudget.Text = "Budget";
            this.chkBudget.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "Double Click on the Item row to Enter Budgeted Unit Cost";
            // 
            // gvItemList
            // 
            this.gvItemList.AllowUserToAddRows = false;
            this.gvItemList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gvItemList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.gvItemList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvItemList.AutoGenerateColumns = false;
            this.gvItemList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvItemList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemCode,
            this.Item,
            this.Column9,
            this.Column10,
            this.UnitCost});
            this.gvItemList.DataSource = this.bindItemList;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvItemList.DefaultCellStyle = dataGridViewCellStyle9;
            this.gvItemList.Location = new System.Drawing.Point(11, 19);
            this.gvItemList.Name = "gvItemList";
            this.gvItemList.RowHeadersVisible = false;
            this.gvItemList.RowTemplate.Height = 30;
            this.gvItemList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvItemList.Size = new System.Drawing.Size(963, 216);
            this.gvItemList.TabIndex = 16;
            this.gvItemList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvItemList_CellDoubleClick);
            this.gvItemList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gvItemList_KeyDown);
            // 
            // ItemCode
            // 
            this.ItemCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ItemCode.DataPropertyName = "ItemCode";
            this.ItemCode.HeaderText = "ItemCode";
            this.ItemCode.Name = "ItemCode";
            this.ItemCode.Visible = false;
            // 
            // Item
            // 
            this.Item.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Item.DataPropertyName = "Code";
            this.Item.FillWeight = 300F;
            this.Item.HeaderText = "Item";
            this.Item.MinimumWidth = 200;
            this.Item.Name = "Item";
            this.Item.ReadOnly = true;
            this.Item.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Item.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column9
            // 
            this.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column9.DataPropertyName = "MTNTransferQty";
            dataGridViewCellStyle6.Format = "N3";
            dataGridViewCellStyle6.NullValue = null;
            this.Column9.DefaultCellStyle = dataGridViewCellStyle6;
            this.Column9.HeaderText = "Transfer Qty";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column10.DataPropertyName = "MTNTransferQty";
            dataGridViewCellStyle7.Format = "N3";
            dataGridViewCellStyle7.NullValue = null;
            this.Column10.DefaultCellStyle = dataGridViewCellStyle7;
            this.Column10.HeaderText = "Received Qty";
            this.Column10.Name = "Column10";
            // 
            // UnitCost
            // 
            this.UnitCost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UnitCost.DataPropertyName = "MTNUnitRate_Budget";
            dataGridViewCellStyle8.Format = "N2";
            dataGridViewCellStyle8.NullValue = null;
            this.UnitCost.DefaultCellStyle = dataGridViewCellStyle8;
            this.UnitCost.HeaderText = "Unit Cost Budgeted";
            this.UnitCost.Name = "UnitCost";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmit.Location = new System.Drawing.Point(822, 241);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 13;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnReceive_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(903, 241);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "EmpName";
            this.dataGridViewTextBoxColumn4.HeaderText = "Enterd By";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "MTNTGRNNO";
            this.dataGridViewTextBoxColumn5.HeaderText = "TGRN No";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 75;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "MTNBatchID";
            dataGridViewCellStyle10.NullValue = "N/A";
            this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewTextBoxColumn6.HeaderText = "Batch No";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 75;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "MTNRePackBatchID";
            dataGridViewCellStyle11.NullValue = "N/A";
            this.dataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewTextBoxColumn7.HeaderText = "Repack Batch";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 75;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "MTNReworkBatchID";
            dataGridViewCellStyle12.NullValue = "N/A";
            this.dataGridViewTextBoxColumn8.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridViewTextBoxColumn8.HeaderText = "Rework Batch";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 75;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "MTNMatReworkBatchID";
            dataGridViewCellStyle13.NullValue = "N/A";
            this.dataGridViewTextBoxColumn9.DefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridViewTextBoxColumn9.HeaderText = "Mat Rework";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 75;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Item";
            this.dataGridViewTextBoxColumn10.HeaderText = "Item";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 200;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn10.Width = 200;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn11.DataPropertyName = "MTNDescription";
            this.dataGridViewTextBoxColumn11.HeaderText = "Description";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "MTNUnitRate";
            this.dataGridViewTextBoxColumn12.HeaderText = "Unit Cost";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Width = 125;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "MTNTransferQty";
            this.dataGridViewTextBoxColumn13.HeaderText = "Transfer Qty";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Width = 125;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "MTNTransferQty";
            this.dataGridViewTextBoxColumn14.HeaderText = "Received Qty";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "MTNNO";
            this.Column1.HeaderText = "MTN No.";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "MTNFromDepID";
            this.Column3.HeaderText = "From Dep";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "MTNDate";
            dataGridViewCellStyle2.Format = "d";
            this.Column4.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column4.HeaderText = "Date";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.DataPropertyName = "MTNEnterdByName";
            this.Column5.HeaderText = "Enterd By";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // BatchID
            // 
            this.BatchID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BatchID.DataPropertyName = "BatchID";
            dataGridViewCellStyle3.NullValue = "N/A";
            this.BatchID.DefaultCellStyle = dataGridViewCellStyle3;
            this.BatchID.HeaderText = "Batch No";
            this.BatchID.Name = "BatchID";
            this.BatchID.ReadOnly = true;
            // 
            // PackingID
            // 
            this.PackingID.DataPropertyName = "MTNPackingBatch";
            this.PackingID.HeaderText = "PackingID";
            this.PackingID.Name = "PackingID";
            this.PackingID.ReadOnly = true;
            // 
            // frmMTNCosting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 616);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMTNCosting";
            this.Text = "Material Transfer Note - Costing";
            this.Load += new System.EventHandler(this.frmMTNReceive_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvMTNList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindMTNList)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvItemList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindItemList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindDepartment)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView gvMTNList;
        private System.Windows.Forms.BindingSource bindMTNList;
        private System.Windows.Forms.BindingSource bindDepartment;
        private System.Windows.Forms.DataGridView gvItemList;
        private System.Windows.Forms.BindingSource bindItemList;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitCost;
        private System.Windows.Forms.Button btnCostReport;
        private System.Windows.Forms.CheckBox chkBudget;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn BatchID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PackingID;
    }
}