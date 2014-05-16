namespace MRP_GUI
{
    partial class frmBatchPacking_Secondary_Instructions
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
            this.objSourceBatchList = new System.Windows.Forms.BindingSource(this.components);
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.txtBatchID = new System.Windows.Forms.TextBox();
            this.txtActivity = new System.Windows.Forms.TextBox();
            this.dgvActivity = new System.Windows.Forms.DataGridView();
            this.BatchActStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BatchActID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InputCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OutputCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnStartPacking = new System.Windows.Forms.Button();
            this.txtPackingQty = new System.Windows.Forms.TextBox();
            this.cmbFinishedProduct = new System.Windows.Forms.ComboBox();
            this.objSourceFinishedProducts = new System.Windows.Forms.BindingSource(this.components);
            this.dgvBatchList = new System.Windows.Forms.DataGridView();
            this.pBatchActID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BatchID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OutputProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Totaloutput = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remaining = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.objSourceSecondaryProduct = new System.Windows.Forms.BindingSource(this.components);
            this.objSourceSecondaryActivityList = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.dgvTransferred = new System.Windows.Forms.DataGridView();
            this.MTNNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransferredQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.objSourceTransferredList = new System.Windows.Forms.BindingSource(this.components);
            this.objSourceActivityList = new System.Windows.Forms.BindingSource(this.components);
            this.chkOutsource = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceBatchList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceFinishedProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBatchList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceSecondaryProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceSecondaryActivityList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransferred)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceTransferredList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceActivityList)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(766, -195);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(278, 22);
            this.textBox2.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(676, -363);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(278, 22);
            this.textBox4.TabIndex = 2;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(636, -124);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 22);
            this.textBox5.TabIndex = 2;
            // 
            // txtBatchID
            // 
            this.txtBatchID.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtBatchID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBatchID.ForeColor = System.Drawing.Color.Black;
            this.txtBatchID.Location = new System.Drawing.Point(12, 11);
            this.txtBatchID.Name = "txtBatchID";
            this.txtBatchID.Size = new System.Drawing.Size(153, 29);
            this.txtBatchID.TabIndex = 186;
            this.txtBatchID.Text = "<Batch ID>";
            // 
            // txtActivity
            // 
            this.txtActivity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtActivity.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtActivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtActivity.ForeColor = System.Drawing.Color.Black;
            this.txtActivity.Location = new System.Drawing.Point(764, 12);
            this.txtActivity.Name = "txtActivity";
            this.txtActivity.Size = new System.Drawing.Size(228, 29);
            this.txtActivity.TabIndex = 187;
            this.txtActivity.Text = "<Activity Name>";
            // 
            // dgvActivity
            // 
            this.dgvActivity.AllowUserToAddRows = false;
            this.dgvActivity.AllowUserToDeleteRows = false;
            this.dgvActivity.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvActivity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActivity.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BatchActStatus,
            this.BatchActID,
            this.InputCode,
            this.Qty,
            this.OutputCode});
            this.dgvActivity.Location = new System.Drawing.Point(571, 121);
            this.dgvActivity.Name = "dgvActivity";
            this.dgvActivity.ReadOnly = true;
            this.dgvActivity.Size = new System.Drawing.Size(422, 479);
            this.dgvActivity.TabIndex = 188;
            this.dgvActivity.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvActivity_CellClick);
            // 
            // BatchActStatus
            // 
            this.BatchActStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BatchActStatus.DataPropertyName = "BatchActStatus";
            this.BatchActStatus.HeaderText = "BatchActStatus";
            this.BatchActStatus.Name = "BatchActStatus";
            this.BatchActStatus.ReadOnly = true;
            this.BatchActStatus.Visible = false;
            // 
            // BatchActID
            // 
            this.BatchActID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BatchActID.DataPropertyName = "BatchActID";
            this.BatchActID.FillWeight = 50F;
            this.BatchActID.HeaderText = "ID";
            this.BatchActID.Name = "BatchActID";
            this.BatchActID.ReadOnly = true;
            // 
            // InputCode
            // 
            this.InputCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.InputCode.DataPropertyName = "StartProductCode";
            this.InputCode.FillWeight = 75F;
            this.InputCode.HeaderText = "Input Code";
            this.InputCode.Name = "InputCode";
            this.InputCode.ReadOnly = true;
            // 
            // Qty
            // 
            this.Qty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Qty.DataPropertyName = "StartQty";
            this.Qty.FillWeight = 50F;
            this.Qty.HeaderText = "InputQty";
            this.Qty.Name = "Qty";
            this.Qty.ReadOnly = true;
            // 
            // OutputCode
            // 
            this.OutputCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.OutputCode.DataPropertyName = "EndProductCode";
            this.OutputCode.HeaderText = "Output Code";
            this.OutputCode.Name = "OutputCode";
            this.OutputCode.ReadOnly = true;
            // 
            // btnStartPacking
            // 
            this.btnStartPacking.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStartPacking.Location = new System.Drawing.Point(896, 73);
            this.btnStartPacking.Name = "btnStartPacking";
            this.btnStartPacking.Size = new System.Drawing.Size(96, 32);
            this.btnStartPacking.TabIndex = 191;
            this.btnStartPacking.Text = "Start Packing";
            this.btnStartPacking.UseVisualStyleBackColor = true;
            this.btnStartPacking.Click += new System.EventHandler(this.btnStartPacking_Click);
            // 
            // txtPackingQty
            // 
            this.txtPackingQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPackingQty.BackColor = System.Drawing.SystemColors.Window;
            this.txtPackingQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPackingQty.ForeColor = System.Drawing.Color.Black;
            this.txtPackingQty.Location = new System.Drawing.Point(787, 76);
            this.txtPackingQty.Name = "txtPackingQty";
            this.txtPackingQty.Size = new System.Drawing.Size(103, 29);
            this.txtPackingQty.TabIndex = 192;
            this.txtPackingQty.Click += new System.EventHandler(this.txtPackingQty_Click);
            // 
            // cmbFinishedProduct
            // 
            this.cmbFinishedProduct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFinishedProduct.BackColor = System.Drawing.SystemColors.Window;
            this.cmbFinishedProduct.DisplayMember = "FinishProdutDescription";
            this.cmbFinishedProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFinishedProduct.ForeColor = System.Drawing.Color.Black;
            this.cmbFinishedProduct.FormattingEnabled = true;
            this.cmbFinishedProduct.Location = new System.Drawing.Point(571, 76);
            this.cmbFinishedProduct.Name = "cmbFinishedProduct";
            this.cmbFinishedProduct.Size = new System.Drawing.Size(132, 28);
            this.cmbFinishedProduct.TabIndex = 193;
            this.cmbFinishedProduct.ValueMember = "FinishProductCode";
            // 
            // dgvBatchList
            // 
            this.dgvBatchList.AllowUserToAddRows = false;
            this.dgvBatchList.AllowUserToDeleteRows = false;
            this.dgvBatchList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBatchList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pBatchActID,
            this.BatchID,
            this.OutputProduct,
            this.Totaloutput,
            this.Remaining});
            this.dgvBatchList.Location = new System.Drawing.Point(15, 72);
            this.dgvBatchList.Name = "dgvBatchList";
            this.dgvBatchList.ReadOnly = true;
            this.dgvBatchList.Size = new System.Drawing.Size(550, 241);
            this.dgvBatchList.TabIndex = 195;
            this.dgvBatchList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBatchList_CellClick);
            // 
            // pBatchActID
            // 
            this.pBatchActID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pBatchActID.DataPropertyName = "BatchActID";
            this.pBatchActID.HeaderText = "BatchActID";
            this.pBatchActID.Name = "pBatchActID";
            this.pBatchActID.ReadOnly = true;
            // 
            // BatchID
            // 
            this.BatchID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BatchID.DataPropertyName = "BatchID";
            this.BatchID.HeaderText = "BatchID";
            this.BatchID.Name = "BatchID";
            this.BatchID.ReadOnly = true;
            // 
            // OutputProduct
            // 
            this.OutputProduct.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.OutputProduct.DataPropertyName = "EndProductCode";
            this.OutputProduct.HeaderText = "Output Product";
            this.OutputProduct.Name = "OutputProduct";
            this.OutputProduct.ReadOnly = true;
            // 
            // Totaloutput
            // 
            this.Totaloutput.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Totaloutput.DataPropertyName = "StopQty";
            this.Totaloutput.HeaderText = "Total";
            this.Totaloutput.Name = "Totaloutput";
            this.Totaloutput.ReadOnly = true;
            // 
            // Remaining
            // 
            this.Remaining.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Remaining.DataPropertyName = "RemainningQty";
            this.Remaining.HeaderText = "Remain";
            this.Remaining.Name = "Remaining";
            this.Remaining.ReadOnly = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 16);
            this.label4.TabIndex = 196;
            this.label4.Text = "Primary Packing Summary";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(568, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(211, 16);
            this.label5.TabIndex = 196;
            this.label5.Text = "Secondary Packing Summary";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(709, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 197;
            this.label1.Text = "Primary Qty";
            // 
            // dgvTransferred
            // 
            this.dgvTransferred.AllowUserToAddRows = false;
            this.dgvTransferred.AllowUserToDeleteRows = false;
            this.dgvTransferred.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvTransferred.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransferred.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MTNNO,
            this.ProductCode,
            this.TransferredQty});
            this.dgvTransferred.Location = new System.Drawing.Point(15, 319);
            this.dgvTransferred.Name = "dgvTransferred";
            this.dgvTransferred.ReadOnly = true;
            this.dgvTransferred.Size = new System.Drawing.Size(550, 281);
            this.dgvTransferred.TabIndex = 201;
            // 
            // MTNNO
            // 
            this.MTNNO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MTNNO.DataPropertyName = "MTNNO";
            this.MTNNO.HeaderText = "MTNNO";
            this.MTNNO.Name = "MTNNO";
            this.MTNNO.ReadOnly = true;
            // 
            // ProductCode
            // 
            this.ProductCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductCode.DataPropertyName = "MTNFinishProductID";
            this.ProductCode.FillWeight = 200F;
            this.ProductCode.HeaderText = "ProductCode";
            this.ProductCode.Name = "ProductCode";
            this.ProductCode.ReadOnly = true;
            // 
            // TransferredQty
            // 
            this.TransferredQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TransferredQty.DataPropertyName = "MTNTransferQty";
            this.TransferredQty.HeaderText = "Transferred Qty";
            this.TransferredQty.Name = "TransferredQty";
            this.TransferredQty.ReadOnly = true;
            // 
            // chkOutsource
            // 
            this.chkOutsource.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkOutsource.AutoSize = true;
            this.chkOutsource.Location = new System.Drawing.Point(896, 47);
            this.chkOutsource.Name = "chkOutsource";
            this.chkOutsource.Size = new System.Drawing.Size(88, 20);
            this.chkOutsource.TabIndex = 202;
            this.chkOutsource.Text = "Outsource";
            this.chkOutsource.UseVisualStyleBackColor = true;
            // 
            // frmBatchPacking_Secondary_Instructions
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1004, 612);
            this.Controls.Add(this.chkOutsource);
            this.Controls.Add(this.dgvTransferred);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvBatchList);
            this.Controls.Add(this.cmbFinishedProduct);
            this.Controls.Add(this.txtPackingQty);
            this.Controls.Add(this.btnStartPacking);
            this.Controls.Add(this.dgvActivity);
            this.Controls.Add(this.txtActivity);
            this.Controls.Add(this.txtBatchID);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmBatchPacking_Secondary_Instructions";
            this.Text = "Batch List - Packaging Secondary (Instructions)";
            this.Load += new System.EventHandler(this.frmBatchList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.objSourceBatchList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceFinishedProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBatchList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceSecondaryProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceSecondaryActivityList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransferred)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceTransferredList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceActivityList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource objSourceBatchList;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox txtBatchID;
        private System.Windows.Forms.TextBox txtActivity;
        private System.Windows.Forms.DataGridView dgvActivity;
        private System.Windows.Forms.Button btnStartPacking;
        private System.Windows.Forms.TextBox txtPackingQty;
        private System.Windows.Forms.ComboBox cmbFinishedProduct;
        private System.Windows.Forms.BindingSource objSourceFinishedProducts;
        private System.Windows.Forms.DataGridView dgvBatchList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource objSourceSecondaryProduct;
        private System.Windows.Forms.BindingSource objSourceSecondaryActivityList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvTransferred;
        private System.Windows.Forms.BindingSource objSourceTransferredList;
        private System.Windows.Forms.DataGridViewTextBoxColumn MTNNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransferredQty;
        private System.Windows.Forms.BindingSource objSourceActivityList;
        private System.Windows.Forms.DataGridViewTextBoxColumn BatchActStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn BatchActID;
        private System.Windows.Forms.DataGridViewTextBoxColumn InputCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn OutputCode;
        private System.Windows.Forms.CheckBox chkOutsource;
        private System.Windows.Forms.DataGridViewTextBoxColumn pBatchActID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BatchID;
        private System.Windows.Forms.DataGridViewTextBoxColumn OutputProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn Totaloutput;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remaining;
    }
}