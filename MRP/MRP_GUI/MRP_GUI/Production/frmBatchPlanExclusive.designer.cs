namespace MRP_GUI
{
    partial class frmBatchPlanExclusive
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
            this.cmbCategoryList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.objSourceCategoryList = new System.Windows.Forms.BindingSource(this.components);
            this.objSourceBasicProductList = new System.Windows.Forms.BindingSource(this.components);
            this.objSourceFinishProductStart = new System.Windows.Forms.BindingSource(this.components);
            this.lstBasicProductList = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtBatchSize = new System.Windows.Forms.TextBox();
            this.objSourceFinishProductStop = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBatchNo = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdbRepack = new System.Windows.Forms.RadioButton();
            this.rdbRework = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txtParentBatches = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbStartProduct = new System.Windows.Forms.ComboBox();
            this.cmbEndProduct = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvBatchActivity = new System.Windows.Forms.DataGridView();
            this.BatchActID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Activity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.objSourceBatchActivity = new System.Windows.Forms.BindingSource(this.components);
            this.txtBatch = new System.Windows.Forms.TextBox();
            this.pnlBatchActivity = new System.Windows.Forms.Panel();
            this.txtStartQty = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDone = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceCategoryList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceBasicProductList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceFinishProductStart)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceFinishProductStop)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBatchActivity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceBatchActivity)).BeginInit();
            this.pnlBatchActivity.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbCategoryList
            // 
            this.cmbCategoryList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCategoryList.DisplayMember = "ProductSubCategory";
            this.cmbCategoryList.FormattingEnabled = true;
            this.cmbCategoryList.Location = new System.Drawing.Point(13, 43);
            this.cmbCategoryList.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCategoryList.Name = "cmbCategoryList";
            this.cmbCategoryList.Size = new System.Drawing.Size(445, 26);
            this.cmbCategoryList.TabIndex = 0;
            this.cmbCategoryList.ValueMember = "ProductSubCatID";
            this.cmbCategoryList.SelectedIndexChanged += new System.EventHandler(this.cmbCategoryList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Product Category";
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreate.BackColor = System.Drawing.Color.Olive;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Location = new System.Drawing.Point(858, 5);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(141, 26);
            this.btnCreate.TabIndex = 5;
            this.btnCreate.Text = "Create >>";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Visible = false;
            this.btnCreate.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lstBasicProductList
            // 
            this.lstBasicProductList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstBasicProductList.BackColor = System.Drawing.SystemColors.Control;
            this.lstBasicProductList.DisplayMember = "Code";
            this.lstBasicProductList.FormattingEnabled = true;
            this.lstBasicProductList.ItemHeight = 18;
            this.lstBasicProductList.Location = new System.Drawing.Point(3, 90);
            this.lstBasicProductList.Name = "lstBasicProductList";
            this.lstBasicProductList.Size = new System.Drawing.Size(458, 508);
            this.lstBasicProductList.TabIndex = 15;
            this.lstBasicProductList.ValueMember = "BasicProductCode";
            this.lstBasicProductList.SelectedIndexChanged += new System.EventHandler(this.lstBasicProductList_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cmbCategoryList);
            this.panel2.Location = new System.Drawing.Point(3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(462, 80);
            this.panel2.TabIndex = 20;
            // 
            // txtBatchSize
            // 
            this.txtBatchSize.Location = new System.Drawing.Point(557, 58);
            this.txtBatchSize.Name = "txtBatchSize";
            this.txtBatchSize.ReadOnly = true;
            this.txtBatchSize.Size = new System.Drawing.Size(119, 26);
            this.txtBatchSize.TabIndex = 21;
            this.txtBatchSize.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(487, 66);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Batch Size";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(487, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Batch No";
            // 
            // txtBatchNo
            // 
            this.txtBatchNo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBatchNo.Location = new System.Drawing.Point(621, 6);
            this.txtBatchNo.Name = "txtBatchNo";
            this.txtBatchNo.Size = new System.Drawing.Size(55, 26);
            this.txtBatchNo.TabIndex = 22;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.rdbRepack);
            this.panel1.Controls.Add(this.rdbRework);
            this.panel1.Location = new System.Drawing.Point(692, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(159, 31);
            this.panel1.TabIndex = 25;
            // 
            // rdbRepack
            // 
            this.rdbRepack.AutoSize = true;
            this.rdbRepack.Checked = true;
            this.rdbRepack.Location = new System.Drawing.Point(4, 3);
            this.rdbRepack.Name = "rdbRepack";
            this.rdbRepack.Size = new System.Drawing.Size(70, 22);
            this.rdbRepack.TabIndex = 0;
            this.rdbRepack.TabStop = true;
            this.rdbRepack.Text = "Repack";
            this.rdbRepack.UseVisualStyleBackColor = true;
            this.rdbRepack.CheckedChanged += new System.EventHandler(this.rdbRepack_CheckedChanged);
            // 
            // rdbRework
            // 
            this.rdbRework.AutoSize = true;
            this.rdbRework.Location = new System.Drawing.Point(80, 4);
            this.rdbRework.Name = "rdbRework";
            this.rdbRework.Size = new System.Drawing.Size(73, 22);
            this.rdbRework.TabIndex = 0;
            this.rdbRework.Text = "Rework";
            this.rdbRework.UseVisualStyleBackColor = true;
            this.rdbRework.CheckedChanged += new System.EventHandler(this.rdbRework_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(861, 66);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Parent Batches";
            // 
            // txtParentBatches
            // 
            this.txtParentBatches.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtParentBatches.Location = new System.Drawing.Point(965, 58);
            this.txtParentBatches.Name = "txtParentBatches";
            this.txtParentBatches.Size = new System.Drawing.Size(34, 26);
            this.txtParentBatches.TabIndex = 28;
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
            this.cmbEndProduct.Size = new System.Drawing.Size(38, 26);
            this.cmbEndProduct.TabIndex = 30;
            this.cmbEndProduct.ValueMember = "FinishProductCode";
            this.cmbEndProduct.SelectedIndexChanged += new System.EventHandler(this.cmbEndProduct_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(388, 87);
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
            this.EndProduct});
            this.dgvBatchActivity.DataSource = this.objSourceBatchActivity;
            this.dgvBatchActivity.Location = new System.Drawing.Point(7, 121);
            this.dgvBatchActivity.Name = "dgvBatchActivity";
            this.dgvBatchActivity.ReadOnly = true;
            this.dgvBatchActivity.Size = new System.Drawing.Size(516, 353);
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
            // EndProduct
            // 
            this.EndProduct.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EndProduct.DataPropertyName = "EndProductCode";
            this.EndProduct.HeaderText = "EndProduct";
            this.EndProduct.Name = "EndProduct";
            this.EndProduct.ReadOnly = true;
            // 
            // txtBatch
            // 
            this.txtBatch.Location = new System.Drawing.Point(557, 7);
            this.txtBatch.Name = "txtBatch";
            this.txtBatch.ReadOnly = true;
            this.txtBatch.Size = new System.Drawing.Size(58, 26);
            this.txtBatch.TabIndex = 33;
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
            this.pnlBatchActivity.Location = new System.Drawing.Point(468, 90);
            this.pnlBatchActivity.Name = "pnlBatchActivity";
            this.pnlBatchActivity.Size = new System.Drawing.Size(531, 482);
            this.pnlBatchActivity.TabIndex = 34;
            this.pnlBatchActivity.Visible = false;
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
            // btnDone
            // 
            this.btnDone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDone.Location = new System.Drawing.Point(920, 578);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(79, 31);
            this.btnDone.TabIndex = 35;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // frmBatchPlanExclusive
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1004, 612);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.pnlBatchActivity);
            this.Controls.Add(this.txtBatch);
            this.Controls.Add(this.txtParentBatches);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtBatchNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBatchSize);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lstBasicProductList);
            this.Controls.Add(this.btnCreate);
            this.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmBatchPlanExclusive";
            this.Text = "Batch Plan";
            this.Load += new System.EventHandler(this.frmBatchPlan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.objSourceCategoryList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceBasicProductList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceFinishProductStart)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceFinishProductStop)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBatchActivity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceBatchActivity)).EndInit();
            this.pnlBatchActivity.ResumeLayout(false);
            this.pnlBatchActivity.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.BindingSource objSourceCategoryList;
        private System.Windows.Forms.ComboBox cmbCategoryList;
        private System.Windows.Forms.BindingSource objSourceBasicProductList;
        private System.Windows.Forms.BindingSource objSourceFinishProductStart;
        private System.Windows.Forms.ListBox lstBasicProductList;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtBatchSize;
        private System.Windows.Forms.BindingSource objSourceFinishProductStop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBatchNo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdbRepack;
        private System.Windows.Forms.RadioButton rdbRework;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtParentBatches;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbStartProduct;
        private System.Windows.Forms.ComboBox cmbEndProduct;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvBatchActivity;
        private System.Windows.Forms.TextBox txtBatch;
        private System.Windows.Forms.Panel pnlBatchActivity;
        private System.Windows.Forms.TextBox txtStartQty;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.BindingSource objSourceBatchActivity;
        private System.Windows.Forms.DataGridViewTextBoxColumn BatchActID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Activity;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndProduct;
        private System.Windows.Forms.Button btnDone;
    }
}