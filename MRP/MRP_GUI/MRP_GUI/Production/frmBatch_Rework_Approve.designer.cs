namespace MRP_GUI
{
    partial class frmBatch_Rework_Approve
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
            this.objSourceFinishProductStart = new System.Windows.Forms.BindingSource(this.components);
            this.objSourceFinishProductStop = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbStartProduct = new System.Windows.Forms.ComboBox();
            this.cmbEndProduct = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvBatchActivity = new System.Windows.Forms.DataGridView();
            this.BatchActID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Activity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.objSourceBatchActivity = new System.Windows.Forms.BindingSource(this.components);
            this.pnlBatchActivity = new System.Windows.Forms.Panel();
            this.txtStartQty = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBatch = new System.Windows.Forms.ComboBox();
            this.btnApprove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceBatchList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceFinishProductStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceFinishProductStop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBatchActivity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceBatchActivity)).BeginInit();
            this.pnlBatchActivity.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 38);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Start Product";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(407, 38);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 18);
            this.label6.TabIndex = 4;
            this.label6.Text = "End Product";
            // 
            // cmbStartProduct
            // 
            this.cmbStartProduct.DisplayMember = "FinishProduct";
            this.cmbStartProduct.FormattingEnabled = true;
            this.cmbStartProduct.Location = new System.Drawing.Point(92, 30);
            this.cmbStartProduct.Name = "cmbStartProduct";
            this.cmbStartProduct.Size = new System.Drawing.Size(308, 26);
            this.cmbStartProduct.TabIndex = 29;
            this.cmbStartProduct.ValueMember = "FinishProductCode";
            // 
            // cmbEndProduct
            // 
            this.cmbEndProduct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbEndProduct.DisplayMember = "FinishProduct";
            this.cmbEndProduct.FormattingEnabled = true;
            this.cmbEndProduct.Location = new System.Drawing.Point(490, 30);
            this.cmbEndProduct.Name = "cmbEndProduct";
            this.cmbEndProduct.Size = new System.Drawing.Size(501, 26);
            this.cmbEndProduct.TabIndex = 30;
            this.cmbEndProduct.ValueMember = "FinishProductCode";
            this.cmbEndProduct.SelectedIndexChanged += new System.EventHandler(this.cmbEndProduct_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(851, 87);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(135, 28);
            this.btnAdd.TabIndex = 31;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // dgvBatchActivity
            // 
            this.dgvBatchActivity.AllowUserToAddRows = false;
            this.dgvBatchActivity.AllowUserToDeleteRows = false;
            this.dgvBatchActivity.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBatchActivity.AutoGenerateColumns = false;
            this.dgvBatchActivity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBatchActivity.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BatchActID,
            this.Activity,
            this.StartProduct,
            this.StartQty,
            this.EndProduct});
            this.dgvBatchActivity.DataSource = this.objSourceBatchActivity;
            this.dgvBatchActivity.Location = new System.Drawing.Point(7, 121);
            this.dgvBatchActivity.Name = "dgvBatchActivity";
            this.dgvBatchActivity.ReadOnly = true;
            this.dgvBatchActivity.Size = new System.Drawing.Size(979, 424);
            this.dgvBatchActivity.TabIndex = 32;
            // 
            // BatchActID
            // 
            this.BatchActID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BatchActID.DataPropertyName = "BatchActID";
            this.BatchActID.HeaderText = "BatchActID";
            this.BatchActID.Name = "BatchActID";
            this.BatchActID.ReadOnly = true;
            // 
            // Activity
            // 
            this.Activity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Activity.DataPropertyName = "MainActivity";
            this.Activity.FillWeight = 200F;
            this.Activity.HeaderText = "Activity";
            this.Activity.Name = "Activity";
            this.Activity.ReadOnly = true;
            // 
            // StartProduct
            // 
            this.StartProduct.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StartProduct.DataPropertyName = "StartProductCode";
            this.StartProduct.HeaderText = "StartProduct";
            this.StartProduct.Name = "StartProduct";
            this.StartProduct.ReadOnly = true;
            // 
            // StartQty
            // 
            this.StartQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StartQty.DataPropertyName = "StartQty";
            this.StartQty.HeaderText = "StartQty";
            this.StartQty.Name = "StartQty";
            this.StartQty.ReadOnly = true;
            // 
            // EndProduct
            // 
            this.EndProduct.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EndProduct.DataPropertyName = "EndProductCode";
            this.EndProduct.HeaderText = "EndProduct";
            this.EndProduct.Name = "EndProduct";
            this.EndProduct.ReadOnly = true;
            // 
            // pnlBatchActivity
            // 
            this.pnlBatchActivity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBatchActivity.Controls.Add(this.txtStartQty);
            this.pnlBatchActivity.Controls.Add(this.label7);
            this.pnlBatchActivity.Controls.Add(this.label4);
            this.pnlBatchActivity.Controls.Add(this.label6);
            this.pnlBatchActivity.Controls.Add(this.dgvBatchActivity);
            this.pnlBatchActivity.Controls.Add(this.cmbStartProduct);
            this.pnlBatchActivity.Controls.Add(this.btnAdd);
            this.pnlBatchActivity.Controls.Add(this.cmbEndProduct);
            this.pnlBatchActivity.Location = new System.Drawing.Point(5, 47);
            this.pnlBatchActivity.Name = "pnlBatchActivity";
            this.pnlBatchActivity.Size = new System.Drawing.Size(994, 553);
            this.pnlBatchActivity.TabIndex = 34;
            // 
            // txtStartQty
            // 
            this.txtStartQty.Location = new System.Drawing.Point(92, 67);
            this.txtStartQty.Name = "txtStartQty";
            this.txtStartQty.Size = new System.Drawing.Size(100, 26);
            this.txtStartQty.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 75);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 18);
            this.label7.TabIndex = 4;
            this.label7.Text = "Start Qty";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 18);
            this.label1.TabIndex = 35;
            this.label1.Text = "Batch No";
            // 
            // cmbBatch
            // 
            this.cmbBatch.DisplayMember = "BatchID";
            this.cmbBatch.FormattingEnabled = true;
            this.cmbBatch.Location = new System.Drawing.Point(97, 14);
            this.cmbBatch.Name = "cmbBatch";
            this.cmbBatch.Size = new System.Drawing.Size(212, 26);
            this.cmbBatch.TabIndex = 36;
            this.cmbBatch.ValueMember = "BatchID";
            this.cmbBatch.SelectedIndexChanged += new System.EventHandler(this.cmbBatch_SelectedIndexChanged);
            // 
            // btnApprove
            // 
            this.btnApprove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApprove.Location = new System.Drawing.Point(815, 7);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(184, 32);
            this.btnApprove.TabIndex = 37;
            this.btnApprove.Text = "Approve and Initiate";
            this.btnApprove.UseVisualStyleBackColor = true;
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);
            // 
            // frmBatch_Rework_Approve
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1004, 612);
            this.Controls.Add(this.btnApprove);
            this.Controls.Add(this.cmbBatch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlBatchActivity);
            this.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmBatch_Rework_Approve";
            this.Text = "Batch Plan";
            this.Load += new System.EventHandler(this.frmBatchPlan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.objSourceBatchList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceFinishProductStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceFinishProductStop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBatchActivity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceBatchActivity)).EndInit();
            this.pnlBatchActivity.ResumeLayout(false);
            this.pnlBatchActivity.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource objSourceBatchList;
        private System.Windows.Forms.BindingSource objSourceFinishProductStart;
        private System.Windows.Forms.BindingSource objSourceFinishProductStop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbStartProduct;
        private System.Windows.Forms.ComboBox cmbEndProduct;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvBatchActivity;
        private System.Windows.Forms.Panel pnlBatchActivity;
        private System.Windows.Forms.TextBox txtStartQty;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.BindingSource objSourceBatchActivity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBatch;
        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.DataGridViewTextBoxColumn BatchActID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Activity;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndProduct;
    }
}