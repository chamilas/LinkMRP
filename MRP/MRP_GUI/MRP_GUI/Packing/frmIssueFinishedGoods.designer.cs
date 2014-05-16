namespace MRP_GUI
{
    partial class frmIssueFinishedGoods
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBatchID = new System.Windows.Forms.TextBox();
            this.txtDiaptchNote = new System.Windows.Forms.TextBox();
            this.txtIssuedQty = new System.Windows.Forms.TextBox();
            this.lblQty = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.gvProductList = new System.Windows.Forms.DataGridView();
            this.ProductCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BatchNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbProductCode = new System.Windows.Forms.ComboBox();
            this.lblProductCode = new System.Windows.Forms.Label();
            this.lblBatchNo = new System.Windows.Forms.Label();
            this.cmbDistributor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDistributor = new System.Windows.Forms.Label();
            this.objsourceProducts = new System.Windows.Forms.BindingSource(this.components);
            this.SourceDistributor = new System.Windows.Forms.BindingSource(this.components);
            this.objSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvProductList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objsourceProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SourceDistributor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtBatchID);
            this.groupBox1.Controls.Add(this.txtDiaptchNote);
            this.groupBox1.Controls.Add(this.txtIssuedQty);
            this.groupBox1.Controls.Add(this.lblQty);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.gvProductList);
            this.groupBox1.Controls.Add(this.cmbProductCode);
            this.groupBox1.Controls.Add(this.lblProductCode);
            this.groupBox1.Controls.Add(this.lblBatchNo);
            this.groupBox1.Controls.Add(this.cmbDistributor);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblDistributor);
            this.groupBox1.Location = new System.Drawing.Point(16, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(976, 604);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Finished Goods Issue";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtBatchID
            // 
            this.txtBatchID.Location = new System.Drawing.Point(376, 96);
            this.txtBatchID.Name = "txtBatchID";
            this.txtBatchID.Size = new System.Drawing.Size(118, 22);
            this.txtBatchID.TabIndex = 4;
            // 
            // txtDiaptchNote
            // 
            this.txtDiaptchNote.Location = new System.Drawing.Point(603, 30);
            this.txtDiaptchNote.Name = "txtDiaptchNote";
            this.txtDiaptchNote.Size = new System.Drawing.Size(228, 22);
            this.txtDiaptchNote.TabIndex = 1;
            // 
            // txtIssuedQty
            // 
            this.txtIssuedQty.Location = new System.Drawing.Point(104, 96);
            this.txtIssuedQty.Name = "txtIssuedQty";
            this.txtIssuedQty.Size = new System.Drawing.Size(114, 22);
            this.txtIssuedQty.TabIndex = 3;
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQty.Location = new System.Drawing.Point(45, 103);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(27, 15);
            this.lblQty.TabIndex = 10;
            this.lblQty.Text = "Qty";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(869, 97);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(99, 29);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Location = new System.Drawing.Point(869, 27);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(99, 29);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(869, 62);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(99, 29);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(869, 564);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(99, 32);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(760, 564);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(99, 32);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // gvProductList
            // 
            this.gvProductList.AllowUserToAddRows = false;
            this.gvProductList.AllowUserToDeleteRows = false;
            this.gvProductList.AllowUserToResizeColumns = false;
            this.gvProductList.AllowUserToResizeRows = false;
            this.gvProductList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvProductList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductCode,
            this.ProductName,
            this.Qty,
            this.BatchNo});
            this.gvProductList.Location = new System.Drawing.Point(19, 150);
            this.gvProductList.Name = "gvProductList";
            this.gvProductList.ReadOnly = true;
            this.gvProductList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvProductList.Size = new System.Drawing.Size(949, 407);
            this.gvProductList.TabIndex = 13;
            // 
            // ProductCode
            // 
            this.ProductCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductCode.DataPropertyName = "FinishProduct";
            this.ProductCode.HeaderText = "Product Code";
            this.ProductCode.Name = "ProductCode";
            this.ProductCode.ReadOnly = true;
            // 
            // ProductName
            // 
            this.ProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductName.DataPropertyName = "ProductName";
            this.ProductName.FillWeight = 150F;
            this.ProductName.HeaderText = "Product Name";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            // 
            // Qty
            // 
            this.Qty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Qty.DataPropertyName = "Qty";
            this.Qty.FillWeight = 50F;
            this.Qty.HeaderText = "Qty";
            this.Qty.Name = "Qty";
            this.Qty.ReadOnly = true;
            // 
            // BatchNo
            // 
            this.BatchNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BatchNo.DataPropertyName = "BatchNo";
            this.BatchNo.FillWeight = 50F;
            this.BatchNo.HeaderText = "BatchNo";
            this.BatchNo.Name = "BatchNo";
            this.BatchNo.ReadOnly = true;
            // 
            // cmbProductCode
            // 
            this.cmbProductCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbProductCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbProductCode.DisplayMember = "FinishProduct";
            this.cmbProductCode.FormattingEnabled = true;
            this.cmbProductCode.Location = new System.Drawing.Point(104, 66);
            this.cmbProductCode.Name = "cmbProductCode";
            this.cmbProductCode.Size = new System.Drawing.Size(390, 24);
            this.cmbProductCode.TabIndex = 2;
            this.cmbProductCode.ValueMember = "FinishProductCode";
            // 
            // lblProductCode
            // 
            this.lblProductCode.AutoSize = true;
            this.lblProductCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductCode.Location = new System.Drawing.Point(16, 75);
            this.lblProductCode.Name = "lblProductCode";
            this.lblProductCode.Size = new System.Drawing.Size(56, 15);
            this.lblProductCode.TabIndex = 11;
            this.lblProductCode.Text = "Product";
            // 
            // lblBatchNo
            // 
            this.lblBatchNo.AutoSize = true;
            this.lblBatchNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBatchNo.Location = new System.Drawing.Point(305, 103);
            this.lblBatchNo.Name = "lblBatchNo";
            this.lblBatchNo.Size = new System.Drawing.Size(65, 15);
            this.lblBatchNo.TabIndex = 9;
            this.lblBatchNo.Text = "Batch No";
            // 
            // cmbDistributor
            // 
            this.cmbDistributor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbDistributor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbDistributor.DisplayMember = "DistributorName";
            this.cmbDistributor.FormattingEnabled = true;
            this.cmbDistributor.Location = new System.Drawing.Point(104, 30);
            this.cmbDistributor.Name = "cmbDistributor";
            this.cmbDistributor.Size = new System.Drawing.Size(390, 24);
            this.cmbDistributor.TabIndex = 0;
            this.cmbDistributor.ValueMember = "DistributorID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(500, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Dispatch Note";
            // 
            // lblDistributor
            // 
            this.lblDistributor.AutoSize = true;
            this.lblDistributor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDistributor.Location = new System.Drawing.Point(16, 33);
            this.lblDistributor.Name = "lblDistributor";
            this.lblDistributor.Size = new System.Drawing.Size(74, 15);
            this.lblDistributor.TabIndex = 12;
            this.lblDistributor.Text = "Distributor";
            // 
            // frmIssueFinishedGoods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 612);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmIssueFinishedGoods";
            this.Text = "Issue Finished Goods ( Dispatch Note )";
            this.Load += new System.EventHandler(this.frmIssueFinishedGoods_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvProductList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objsourceProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SourceDistributor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbDistributor;
        private System.Windows.Forms.Label lblDistributor;
        private System.Windows.Forms.Label lblBatchNo;
        private System.Windows.Forms.ComboBox cmbProductCode;
        private System.Windows.Forms.Label lblProductCode;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView gvProductList;
        private System.Windows.Forms.TextBox txtIssuedQty;
        private System.Windows.Forms.TextBox txtBatchID;
        private System.Windows.Forms.BindingSource objsourceProducts;
        private System.Windows.Forms.TextBox txtDiaptchNote;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource SourceDistributor;
        private System.Windows.Forms.BindingSource objSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn BatchNo;
    }
}