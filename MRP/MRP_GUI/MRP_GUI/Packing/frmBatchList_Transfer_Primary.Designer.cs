namespace MRP_GUI
{
    partial class frmBatchList_Transfer_Primary
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
            this.objSourceActivityList = new System.Windows.Forms.BindingSource(this.components);
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.objSourceBatchLabour = new System.Windows.Forms.BindingSource(this.components);
            this.objSourceBatchMachine = new System.Windows.Forms.BindingSource(this.components);
            this.objSourceMachineList = new System.Windows.Forms.BindingSource(this.components);
            this.objSourceEmployee = new System.Windows.Forms.BindingSource(this.components);
            this.dgvActivity = new System.Windows.Forms.DataGridView();
            this.objSourceFinishedProducts = new System.Windows.Forms.BindingSource(this.components);
            this.btnSendToStore = new System.Windows.Forms.Button();
            this.txtTransferQty = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.objSourceRemaining = new System.Windows.Forms.BindingSource(this.components);
            this.txtProductCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BatchActStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BatchID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BatchActID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SecondaryFinishProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StopQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RemainningQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceBatchList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceActivityList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceBatchLabour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceBatchMachine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceMachineList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceFinishedProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceRemaining)).BeginInit();
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
            // dgvActivity
            // 
            this.dgvActivity.AllowUserToAddRows = false;
            this.dgvActivity.AllowUserToDeleteRows = false;
            this.dgvActivity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvActivity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActivity.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BatchActStatus,
            this.BatchID,
            this.BatchActID,
            this.SecondaryFinishProduct,
            this.EndProductName,
            this.StopQty,
            this.RemainningQty});
            this.dgvActivity.Location = new System.Drawing.Point(12, 12);
            this.dgvActivity.Name = "dgvActivity";
            this.dgvActivity.ReadOnly = true;
            this.dgvActivity.Size = new System.Drawing.Size(980, 552);
            this.dgvActivity.TabIndex = 188;
            this.dgvActivity.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvActivity_CellClick);
            // 
            // btnSendToStore
            // 
            this.btnSendToStore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSendToStore.Enabled = false;
            this.btnSendToStore.Location = new System.Drawing.Point(865, 570);
            this.btnSendToStore.Name = "btnSendToStore";
            this.btnSendToStore.Size = new System.Drawing.Size(127, 31);
            this.btnSendToStore.TabIndex = 191;
            this.btnSendToStore.Text = "Transfer to Store";
            this.btnSendToStore.UseVisualStyleBackColor = true;
            this.btnSendToStore.Click += new System.EventHandler(this.btnSendToStore_Click);
            // 
            // txtTransferQty
            // 
            this.txtTransferQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTransferQty.Location = new System.Drawing.Point(750, 579);
            this.txtTransferQty.Name = "txtTransferQty";
            this.txtTransferQty.Size = new System.Drawing.Size(98, 22);
            this.txtTransferQty.TabIndex = 192;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(663, 585);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 193;
            this.label1.Text = "Transfer Qty";
            // 
            // txtProductCode
            // 
            this.txtProductCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProductCode.Location = new System.Drawing.Point(442, 579);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.ReadOnly = true;
            this.txtProductCode.Size = new System.Drawing.Size(215, 22);
            this.txtProductCode.TabIndex = 195;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(320, 582);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 193;
            this.label2.Text = "Product Code";
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
            // BatchID
            // 
            this.BatchID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BatchID.DataPropertyName = "BatchID";
            this.BatchID.HeaderText = "BatchID";
            this.BatchID.Name = "BatchID";
            this.BatchID.ReadOnly = true;
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
            // SecondaryFinishProduct
            // 
            this.SecondaryFinishProduct.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SecondaryFinishProduct.DataPropertyName = "EndProductCode";
            this.SecondaryFinishProduct.HeaderText = "Finish Product";
            this.SecondaryFinishProduct.Name = "SecondaryFinishProduct";
            this.SecondaryFinishProduct.ReadOnly = true;
            // 
            // EndProductName
            // 
            this.EndProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EndProductName.DataPropertyName = "EndProductName";
            this.EndProductName.HeaderText = "Product Name";
            this.EndProductName.Name = "EndProductName";
            this.EndProductName.ReadOnly = true;
            // 
            // StopQty
            // 
            this.StopQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StopQty.DataPropertyName = "StopQty";
            this.StopQty.HeaderText = "BatchFinalQty";
            this.StopQty.Name = "StopQty";
            this.StopQty.ReadOnly = true;
            // 
            // RemainningQty
            // 
            this.RemainningQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RemainningQty.DataPropertyName = "RemainningQty";
            this.RemainningQty.HeaderText = "RemainningQty";
            this.RemainningQty.Name = "RemainningQty";
            this.RemainningQty.ReadOnly = true;
            // 
            // frmBatchList_Transfer_Primary
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1004, 612);
            this.Controls.Add(this.txtProductCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTransferQty);
            this.Controls.Add(this.btnSendToStore);
            this.Controls.Add(this.dgvActivity);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmBatchList_Transfer_Primary";
            this.Text = "Batch List - Packaging Primary";
            this.Load += new System.EventHandler(this.frmBatchList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.objSourceBatchList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceActivityList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceBatchLabour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceBatchMachine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceMachineList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceFinishedProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceRemaining)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource objSourceBatchList;
        private System.Windows.Forms.BindingSource objSourceActivityList;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.BindingSource objSourceBatchLabour;
        private System.Windows.Forms.BindingSource objSourceBatchMachine;
        private System.Windows.Forms.BindingSource objSourceMachineList;
        private System.Windows.Forms.BindingSource objSourceEmployee;
        private System.Windows.Forms.DataGridView dgvActivity;
        private System.Windows.Forms.BindingSource objSourceFinishedProducts;
        private System.Windows.Forms.Button btnSendToStore;
        private System.Windows.Forms.TextBox txtTransferQty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource objSourceRemaining;
        private System.Windows.Forms.TextBox txtProductCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn BatchActStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn BatchID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BatchActID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SecondaryFinishProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StopQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn RemainningQty;
    }
}