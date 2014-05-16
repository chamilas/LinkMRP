namespace MRP_GUI
{
    partial class frmMRT_Batch_Partial

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMRT_Batch_Partial));
            this.dgvItemList = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReqQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.objsourceRequested = new System.Windows.Forms.BindingSource(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.cmbBatchNo = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbPart = new System.Windows.Forms.ComboBox();
            this.btnSendMR = new System.Windows.Forms.Button();
            this.objSourceBatchist = new System.Windows.Forms.BindingSource(this.components);
            this.objSourceMaterialList = new System.Windows.Forms.BindingSource(this.components);
            this.dgvItemRequested = new System.Windows.Forms.DataGridView();
            this.MaterialCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Material = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvItem_toRequest = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaterialName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdbSemiFinished = new System.Windows.Forms.RadioButton();
            this.rdbMaterial = new System.Windows.Forms.RadioButton();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.objSourceItems_toRequest = new System.Windows.Forms.BindingSource(this.components);
            this.dgvItem_toRequest_BP = new System.Windows.Forms.DataGridView();
            this.ItemCode_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReqQty_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objsourceRequested)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceBatchist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceMaterialList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemRequested)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem_toRequest)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceItems_toRequest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem_toRequest_BP)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvItemList
            // 
            this.dgvItemList.AllowUserToAddRows = false;
            this.dgvItemList.AllowUserToDeleteRows = false;
            this.dgvItemList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvItemList.AutoGenerateColumns = false;
            this.dgvItemList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItemList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.ItemCode,
            this.Column2,
            this.ReqQty});
            this.dgvItemList.DataSource = this.objsourceRequested;
            this.dgvItemList.Location = new System.Drawing.Point(12, 74);
            this.dgvItemList.Name = "dgvItemList";
            this.dgvItemList.ReadOnly = true;
            this.dgvItemList.RowHeadersVisible = false;
            this.dgvItemList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItemList.Size = new System.Drawing.Size(442, 229);
            this.dgvItemList.TabIndex = 4;
            this.dgvItemList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItemList_CellClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "Item";
            this.Column1.HeaderText = "Item";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // ItemCode
            // 
            this.ItemCode.DataPropertyName = "ItemCode";
            this.ItemCode.HeaderText = "ItemCode";
            this.ItemCode.Name = "ItemCode";
            this.ItemCode.ReadOnly = true;
            this.ItemCode.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "UnitCode";
            this.Column2.HeaderText = "Unit";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ReqQty
            // 
            this.ReqQty.DataPropertyName = "Qty";
            dataGridViewCellStyle1.Format = "N3";
            dataGridViewCellStyle1.NullValue = null;
            this.ReqQty.DefaultCellStyle = dataGridViewCellStyle1;
            this.ReqQty.HeaderText = "Reqd Qty.";
            this.ReqQty.Name = "ReqQty";
            this.ReqQty.ReadOnly = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 15);
            this.label10.TabIndex = 1;
            this.label10.Text = "Batch No";
            // 
            // cmbBatchNo
            // 
            this.cmbBatchNo.DisplayMember = "BatchID";
            this.cmbBatchNo.FormattingEnabled = true;
            this.cmbBatchNo.Location = new System.Drawing.Point(87, 12);
            this.cmbBatchNo.Name = "cmbBatchNo";
            this.cmbBatchNo.Size = new System.Drawing.Size(211, 23);
            this.cmbBatchNo.TabIndex = 2;
            this.cmbBatchNo.ValueMember = "BatchID";
            this.cmbBatchNo.SelectedIndexChanged += new System.EventHandler(this.cmbBatchNo_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(335, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 15);
            this.label11.TabIndex = 3;
            this.label11.Text = "Part";
            // 
            // cmbPart
            // 
            this.cmbPart.FormattingEnabled = true;
            this.cmbPart.Items.AddRange(new object[] {
            "C",
            "D"});
            this.cmbPart.Location = new System.Drawing.Point(383, 13);
            this.cmbPart.Name = "cmbPart";
            this.cmbPart.Size = new System.Drawing.Size(71, 23);
            this.cmbPart.TabIndex = 2;
            this.cmbPart.SelectedIndexChanged += new System.EventHandler(this.cmbPart_SelectedIndexChanged);
            // 
            // btnSendMR
            // 
            this.btnSendMR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSendMR.Location = new System.Drawing.Point(909, 309);
            this.btnSendMR.Name = "btnSendMR";
            this.btnSendMR.Size = new System.Drawing.Size(81, 33);
            this.btnSendMR.TabIndex = 4;
            this.btnSendMR.Text = "Send MR";
            this.btnSendMR.UseVisualStyleBackColor = true;
            this.btnSendMR.Click += new System.EventHandler(this.btnSendMR_Click);
            // 
            // dgvItemRequested
            // 
            this.dgvItemRequested.AllowUserToAddRows = false;
            this.dgvItemRequested.AllowUserToDeleteRows = false;
            this.dgvItemRequested.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvItemRequested.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItemRequested.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaterialCode,
            this.Material,
            this.dataGridViewTextBoxColumn3});
            this.dgvItemRequested.Location = new System.Drawing.Point(12, 351);
            this.dgvItemRequested.Name = "dgvItemRequested";
            this.dgvItemRequested.ReadOnly = true;
            this.dgvItemRequested.RowHeadersVisible = false;
            this.dgvItemRequested.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItemRequested.Size = new System.Drawing.Size(978, 253);
            this.dgvItemRequested.TabIndex = 4;
            // 
            // MaterialCode
            // 
            this.MaterialCode.DataPropertyName = "MRMaterialCode";
            this.MaterialCode.HeaderText = "MaterialCode";
            this.MaterialCode.Name = "MaterialCode";
            this.MaterialCode.ReadOnly = true;
            this.MaterialCode.Visible = false;
            // 
            // Material
            // 
            this.Material.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Material.DataPropertyName = "Material";
            this.Material.HeaderText = "Material";
            this.Material.Name = "Material";
            this.Material.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "MRReqdQty";
            dataGridViewCellStyle3.Format = "N3";
            dataGridViewCellStyle3.NullValue = null;
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn3.HeaderText = "Reqd Qty.";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dgvItem_toRequest
            // 
            this.dgvItem_toRequest.AllowUserToAddRows = false;
            this.dgvItem_toRequest.AllowUserToDeleteRows = false;
            this.dgvItem_toRequest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvItem_toRequest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItem_toRequest.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.MaterialName,
            this.dataGridViewTextBoxColumn6});
            this.dgvItem_toRequest.Location = new System.Drawing.Point(547, 74);
            this.dgvItem_toRequest.Name = "dgvItem_toRequest";
            this.dgvItem_toRequest.ReadOnly = true;
            this.dgvItem_toRequest.RowHeadersVisible = false;
            this.dgvItem_toRequest.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItem_toRequest.Size = new System.Drawing.Size(443, 229);
            this.dgvItem_toRequest.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "MaterialCode";
            this.dataGridViewTextBoxColumn4.HeaderText = "Item";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // MaterialName
            // 
            this.MaterialName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaterialName.DataPropertyName = "MaterialName";
            this.MaterialName.FillWeight = 150F;
            this.MaterialName.HeaderText = "Material Name";
            this.MaterialName.Name = "MaterialName";
            this.MaterialName.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ReqdQty";
            dataGridViewCellStyle2.Format = "N3";
            dataGridViewCellStyle2.NullValue = null;
            this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn6.HeaderText = "Reqd Qty.";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(887, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Items Requested";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Items in the Part";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdbSemiFinished);
            this.panel1.Controls.Add(this.rdbMaterial);
            this.panel1.Location = new System.Drawing.Point(460, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(191, 36);
            this.panel1.TabIndex = 6;
            // 
            // rdbSemiFinished
            // 
            this.rdbSemiFinished.AutoSize = true;
            this.rdbSemiFinished.Location = new System.Drawing.Point(80, 8);
            this.rdbSemiFinished.Name = "rdbSemiFinished";
            this.rdbSemiFinished.Size = new System.Drawing.Size(105, 19);
            this.rdbSemiFinished.TabIndex = 1;
            this.rdbSemiFinished.Text = "Semi-Finished";
            this.rdbSemiFinished.UseVisualStyleBackColor = true;
            this.rdbSemiFinished.CheckedChanged += new System.EventHandler(this.rdbSemiFinished_CheckedChanged);
            // 
            // rdbMaterial
            // 
            this.rdbMaterial.AutoSize = true;
            this.rdbMaterial.Checked = true;
            this.rdbMaterial.Location = new System.Drawing.Point(4, 8);
            this.rdbMaterial.Name = "rdbMaterial";
            this.rdbMaterial.Size = new System.Drawing.Size(70, 19);
            this.rdbMaterial.TabIndex = 0;
            this.rdbMaterial.TabStop = true;
            this.rdbMaterial.Text = "Material";
            this.rdbMaterial.UseVisualStyleBackColor = true;
            this.rdbMaterial.CheckedChanged += new System.EventHandler(this.rdbMaterial_CheckedChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(460, 152);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(81, 27);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add>>";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.Location = new System.Drawing.Point(460, 185);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(81, 27);
            this.btnRemove.TabIndex = 7;
            this.btnRemove.Text = "<< Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // dgvItem_toRequest_BP
            // 
            this.dgvItem_toRequest_BP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvItem_toRequest_BP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItem_toRequest_BP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemCode_,
            this.ItemName,
            this.ReqQty_});
            this.dgvItem_toRequest_BP.Location = new System.Drawing.Point(547, 74);
            this.dgvItem_toRequest_BP.Name = "dgvItem_toRequest_BP";
            this.dgvItem_toRequest_BP.Size = new System.Drawing.Size(440, 229);
            this.dgvItem_toRequest_BP.TabIndex = 8;
            this.dgvItem_toRequest_BP.Visible = false;
            this.dgvItem_toRequest_BP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ItemCode_
            // 
            this.ItemCode_.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ItemCode_.DataPropertyName = "ItemCode";
            this.ItemCode_.HeaderText = "Item";
            this.ItemCode_.Name = "ItemCode_";
            // 
            // ItemName
            // 
            this.ItemName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ItemName.DataPropertyName = "Item";
            this.ItemName.HeaderText = "ItemName";
            this.ItemName.Name = "ItemName";
            // 
            // ReqQty_
            // 
            this.ReqQty_.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ReqQty_.DataPropertyName = "ReqdQty";
            this.ReqQty_.HeaderText = "ReqQty";
            this.ReqQty_.Name = "ReqQty_";
            // 
            // frmMRT_Batch_Partial
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1002, 616);
            this.Controls.Add(this.dgvItem_toRequest_BP);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSendMR);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cmbPart);
            this.Controls.Add(this.cmbBatchNo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dgvItem_toRequest);
            this.Controls.Add(this.dgvItemRequested);
            this.Controls.Add(this.dgvItemList);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMRT_Batch_Partial";
            this.Text = "Material Requisition Note";
            this.Load += new System.EventHandler(this.frmMRT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objsourceRequested)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceBatchist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceMaterialList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemRequested)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem_toRequest)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceItems_toRequest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem_toRequest_BP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvItemList;
        private System.Windows.Forms.BindingSource objsourceRequested;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbBatchNo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbPart;
        private System.Windows.Forms.Button btnSendMR;
        private System.Windows.Forms.BindingSource objSourceBatchist;
        private System.Windows.Forms.BindingSource objSourceMaterialList;
        private System.Windows.Forms.DataGridView dgvItemRequested;
        private System.Windows.Forms.DataGridView dgvItem_toRequest;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdbSemiFinished;
        private System.Windows.Forms.RadioButton rdbMaterial;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.BindingSource objSourceItems_toRequest;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReqQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaterialCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Material;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaterialName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridView dgvItem_toRequest_BP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemCode_;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReqQty_;
    }
}