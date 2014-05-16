namespace MRP_GUI
{
    partial class frmMTNReceiveGRN_Herbal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMTNReceiveGRN_Herbal));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gvItemList = new System.Windows.Forms.DataGridView();
            this.ColItemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnitCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTrans = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColRec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColRemarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindItemList = new System.Windows.Forms.BindingSource(this.components);
            this.btnGRN = new System.Windows.Forms.Button();
            this.gvMTNList = new System.Windows.Forms.DataGridView();
            this.bindMTNList = new System.Windows.Forms.BindingSource(this.components);
            this.bindDepartment = new System.Windows.Forms.BindingSource(this.components);
            this.bindStores = new System.Windows.Forms.BindingSource(this.components);
            this.colMTN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BatchID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FromDep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MTNDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostingDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvItemList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindItemList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMTNList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindMTNList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindDepartment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindStores)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gvItemList);
            this.groupBox1.Controls.Add(this.btnGRN);
            this.groupBox1.Controls.Add(this.gvMTNList);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1004, 612);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Transfer Item Received";
            // 
            // gvItemList
            // 
            this.gvItemList.AllowUserToAddRows = false;
            this.gvItemList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gvItemList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gvItemList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvItemList.AutoGenerateColumns = false;
            this.gvItemList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvItemList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColItemCode,
            this.ColItem,
            this.colUnitCost,
            this.ColTrans,
            this.ColRec,
            this.ColRemarks});
            this.gvItemList.DataSource = this.bindItemList;
            this.gvItemList.Location = new System.Drawing.Point(12, 250);
            this.gvItemList.Name = "gvItemList";
            this.gvItemList.RowTemplate.Height = 30;
            this.gvItemList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvItemList.Size = new System.Drawing.Size(980, 317);
            this.gvItemList.TabIndex = 16;
            // 
            // ColItemCode
            // 
            this.ColItemCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColItemCode.DataPropertyName = "ItemCode";
            this.ColItemCode.FillWeight = 50F;
            this.ColItemCode.HeaderText = "Item Code";
            this.ColItemCode.Name = "ColItemCode";
            // 
            // ColItem
            // 
            this.ColItem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColItem.DataPropertyName = "Item";
            this.ColItem.FillWeight = 150F;
            this.ColItem.HeaderText = "Item";
            this.ColItem.MinimumWidth = 200;
            this.ColItem.Name = "ColItem";
            this.ColItem.ReadOnly = true;
            this.ColItem.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColItem.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colUnitCost
            // 
            this.colUnitCost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colUnitCost.DataPropertyName = "MTNUnitRate_Budget";
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.colUnitCost.DefaultCellStyle = dataGridViewCellStyle2;
            this.colUnitCost.FillWeight = 50F;
            this.colUnitCost.HeaderText = "Unit Cost";
            this.colUnitCost.Name = "colUnitCost";
            this.colUnitCost.ReadOnly = true;
            // 
            // ColTrans
            // 
            this.ColTrans.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColTrans.DataPropertyName = "MTNTransferQty";
            dataGridViewCellStyle3.Format = "N3";
            dataGridViewCellStyle3.NullValue = null;
            this.ColTrans.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColTrans.FillWeight = 50F;
            this.ColTrans.HeaderText = "Transfer Qty";
            this.ColTrans.Name = "ColTrans";
            this.ColTrans.ReadOnly = true;
            // 
            // ColRec
            // 
            this.ColRec.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColRec.DataPropertyName = "MTNRceivedQty";
            dataGridViewCellStyle4.Format = "N3";
            dataGridViewCellStyle4.NullValue = null;
            this.ColRec.DefaultCellStyle = dataGridViewCellStyle4;
            this.ColRec.FillWeight = 50F;
            this.ColRec.HeaderText = "Received Quantity";
            this.ColRec.Name = "ColRec";
            // 
            // ColRemarks
            // 
            this.ColRemarks.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColRemarks.FillWeight = 50F;
            this.ColRemarks.HeaderText = "Remarks";
            this.ColRemarks.Name = "ColRemarks";
            // 
            // btnGRN
            // 
            this.btnGRN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGRN.Location = new System.Drawing.Point(882, 573);
            this.btnGRN.Name = "btnGRN";
            this.btnGRN.Size = new System.Drawing.Size(110, 33);
            this.btnGRN.TabIndex = 7;
            this.btnGRN.Text = "GRN";
            this.btnGRN.UseVisualStyleBackColor = true;
            this.btnGRN.Click += new System.EventHandler(this.btnGRN_Click);
            // 
            // gvMTNList
            // 
            this.gvMTNList.AllowUserToAddRows = false;
            this.gvMTNList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gvMTNList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.gvMTNList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvMTNList.AutoGenerateColumns = false;
            this.gvMTNList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvMTNList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMTN,
            this.BatchID,
            this.FromDep,
            this.MTNDate,
            this.CostingDate});
            this.gvMTNList.DataSource = this.bindMTNList;
            this.gvMTNList.Location = new System.Drawing.Point(12, 29);
            this.gvMTNList.Name = "gvMTNList";
            this.gvMTNList.ReadOnly = true;
            this.gvMTNList.RowHeadersVisible = false;
            this.gvMTNList.RowTemplate.Height = 30;
            this.gvMTNList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvMTNList.Size = new System.Drawing.Size(980, 215);
            this.gvMTNList.TabIndex = 0;
            this.gvMTNList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvMTNList_CellClick);
            // 
            // colMTN
            // 
            this.colMTN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colMTN.DataPropertyName = "MTNNO";
            this.colMTN.FillWeight = 122.9508F;
            this.colMTN.HeaderText = "MTN No";
            this.colMTN.Name = "colMTN";
            this.colMTN.ReadOnly = true;
            // 
            // BatchID
            // 
            this.BatchID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BatchID.DataPropertyName = "BatchID";
            this.BatchID.HeaderText = "BatchID";
            this.BatchID.Name = "BatchID";
            this.BatchID.ReadOnly = true;
            // 
            // FromDep
            // 
            this.FromDep.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FromDep.DataPropertyName = "FromDepName";
            this.FromDep.FillWeight = 77.04918F;
            this.FromDep.HeaderText = "Department From";
            this.FromDep.Name = "FromDep";
            this.FromDep.ReadOnly = true;
            // 
            // MTNDate
            // 
            this.MTNDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MTNDate.DataPropertyName = "MTNDate";
            dataGridViewCellStyle6.Format = "d";
            this.MTNDate.DefaultCellStyle = dataGridViewCellStyle6;
            this.MTNDate.HeaderText = "Date";
            this.MTNDate.Name = "MTNDate";
            this.MTNDate.ReadOnly = true;
            // 
            // CostingDate
            // 
            this.CostingDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CostingDate.DataPropertyName = "MTNBudgetCostDate";
            this.CostingDate.HeaderText = "Costing Approved Date";
            this.CostingDate.Name = "CostingDate";
            this.CostingDate.ReadOnly = true;
            // 
            // frmMTNReceiveGRN_Herbal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1004, 612);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMTNReceiveGRN_Herbal";
            this.Text = "MTN - GRN";
            this.Load += new System.EventHandler(this.frmMTNReceiveGRN_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvItemList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindItemList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMTNList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindMTNList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindDepartment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindStores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView gvItemList;
        private System.Windows.Forms.Button btnGRN;
        private System.Windows.Forms.DataGridView gvMTNList;
        private System.Windows.Forms.BindingSource bindItemList;
        private System.Windows.Forms.BindingSource bindDepartment;
        private System.Windows.Forms.BindingSource bindMTNList;
        private System.Windows.Forms.BindingSource bindStores;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColItemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnitCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTrans;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColRec;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColRemarks;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMTN;
        private System.Windows.Forms.DataGridViewTextBoxColumn BatchID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FromDep;
        private System.Windows.Forms.DataGridViewTextBoxColumn MTNDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostingDate;
    }
}