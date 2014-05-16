namespace MRP_GUI
{
    partial class frmBatchCreate
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
            this.cmbCategoryList = new System.Windows.Forms.ComboBox();
            this.dgvBatchFormula = new System.Windows.Forms.DataGridView();
            this.Part = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.objSourceCategoryList = new System.Windows.Forms.BindingSource(this.components);
            this.objSourceBasicProductList = new System.Windows.Forms.BindingSource(this.components);
            this.objSourceSTDBatches = new System.Windows.Forms.BindingSource(this.components);
            this.lstBasicProductList = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtBatchSize = new System.Windows.Forms.TextBox();
            this.cmbBatchSize = new System.Windows.Forms.ComboBox();
            this.txtPrefix = new System.Windows.Forms.TextBox();
            this.chkPrefix = new System.Windows.Forms.CheckBox();
            this.objSourceFormula = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBatchFormula)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceCategoryList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceBasicProductList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceSTDBatches)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceFormula)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbCategoryList
            // 
            this.cmbCategoryList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCategoryList.DisplayMember = "ProductSubCategory";
            this.cmbCategoryList.FormattingEnabled = true;
            this.cmbCategoryList.Location = new System.Drawing.Point(15, 36);
            this.cmbCategoryList.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCategoryList.Name = "cmbCategoryList";
            this.cmbCategoryList.Size = new System.Drawing.Size(330, 26);
            this.cmbCategoryList.TabIndex = 0;
            this.cmbCategoryList.ValueMember = "ProductSubCatID";
            this.cmbCategoryList.SelectedIndexChanged += new System.EventHandler(this.cmbCategoryList_SelectedIndexChanged);
            // 
            // dgvBatchFormula
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            this.dgvBatchFormula.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBatchFormula.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBatchFormula.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvBatchFormula.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBatchFormula.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Part,
            this.ItemCode,
            this.Qty,
            this.Unit});
            this.dgvBatchFormula.GridColor = System.Drawing.SystemColors.Control;
            this.dgvBatchFormula.Location = new System.Drawing.Point(379, 90);
            this.dgvBatchFormula.Margin = new System.Windows.Forms.Padding(4);
            this.dgvBatchFormula.Name = "dgvBatchFormula";
            this.dgvBatchFormula.Size = new System.Drawing.Size(620, 509);
            this.dgvBatchFormula.TabIndex = 3;
            // 
            // Part
            // 
            this.Part.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Part.DataPropertyName = "Part";
            this.Part.HeaderText = "Part";
            this.Part.Name = "Part";
            // 
            // ItemCode
            // 
            this.ItemCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ItemCode.DataPropertyName = "ItemCode";
            this.ItemCode.HeaderText = "ItemCode";
            this.ItemCode.Name = "ItemCode";
            // 
            // Qty
            // 
            this.Qty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Qty.DataPropertyName = "Qty";
            this.Qty.HeaderText = "Qty";
            this.Qty.Name = "Qty";
            // 
            // Unit
            // 
            this.Unit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Unit.DataPropertyName = "Unit";
            this.Unit.HeaderText = "Unit";
            this.Unit.Name = "Unit";
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
            this.btnCreate.Location = new System.Drawing.Point(882, 40);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(117, 26);
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
            this.lstBasicProductList.Size = new System.Drawing.Size(362, 508);
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
            this.panel2.Size = new System.Drawing.Size(362, 80);
            this.panel2.TabIndex = 20;
            // 
            // txtBatchSize
            // 
            this.txtBatchSize.Location = new System.Drawing.Point(511, 40);
            this.txtBatchSize.Name = "txtBatchSize";
            this.txtBatchSize.Size = new System.Drawing.Size(134, 26);
            this.txtBatchSize.TabIndex = 21;
            // 
            // cmbBatchSize
            // 
            this.cmbBatchSize.DisplayMember = "STDBatchSize";
            this.cmbBatchSize.FormattingEnabled = true;
            this.cmbBatchSize.Location = new System.Drawing.Point(371, 40);
            this.cmbBatchSize.Name = "cmbBatchSize";
            this.cmbBatchSize.Size = new System.Drawing.Size(134, 26);
            this.cmbBatchSize.TabIndex = 28;
            this.cmbBatchSize.ValueMember = "STDBatchID";
            this.cmbBatchSize.SelectedIndexChanged += new System.EventHandler(this.cmbBatchSize_SelectedIndexChanged);
            this.cmbBatchSize.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbBatchSize_KeyDown);
            // 
            // txtPrefix
            // 
            this.txtPrefix.Location = new System.Drawing.Point(665, 40);
            this.txtPrefix.Name = "txtPrefix";
            this.txtPrefix.ReadOnly = true;
            this.txtPrefix.Size = new System.Drawing.Size(64, 26);
            this.txtPrefix.TabIndex = 29;
            // 
            // chkPrefix
            // 
            this.chkPrefix.AutoSize = true;
            this.chkPrefix.Location = new System.Drawing.Point(666, 17);
            this.chkPrefix.Name = "chkPrefix";
            this.chkPrefix.Size = new System.Drawing.Size(63, 22);
            this.chkPrefix.TabIndex = 30;
            this.chkPrefix.Text = "Prefix";
            this.chkPrefix.UseVisualStyleBackColor = true;
            this.chkPrefix.CheckedChanged += new System.EventHandler(this.chkPrefix_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(376, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "STD Batch Size";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(508, 17);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Batch Size";
            // 
            // frmBatchPlan
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1004, 612);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chkPrefix);
            this.Controls.Add(this.txtPrefix);
            this.Controls.Add(this.cmbBatchSize);
            this.Controls.Add(this.txtBatchSize);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lstBasicProductList);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.dgvBatchFormula);
            this.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmBatchPlan";
            this.Text = "Batch Plan";
            this.Load += new System.EventHandler(this.frmBatchPlan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBatchFormula)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceCategoryList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceBasicProductList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceSTDBatches)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceFormula)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBatchFormula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.BindingSource objSourceCategoryList;
        private System.Windows.Forms.ComboBox cmbCategoryList;
        private System.Windows.Forms.BindingSource objSourceBasicProductList;
        private System.Windows.Forms.BindingSource objSourceSTDBatches;
        private System.Windows.Forms.ListBox lstBasicProductList;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtBatchSize;
        private System.Windows.Forms.ComboBox cmbBatchSize;
        private System.Windows.Forms.TextBox txtPrefix;
        private System.Windows.Forms.CheckBox chkPrefix;
        private System.Windows.Forms.BindingSource objSourceFormula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Part;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}