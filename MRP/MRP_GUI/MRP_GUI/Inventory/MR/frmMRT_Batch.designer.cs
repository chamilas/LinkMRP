namespace MRP_GUI
{
    partial class frmMRT_Batch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMRT_Batch));
            this.dgvItemList = new System.Windows.Forms.DataGridView();
            this.bindItemList = new System.Windows.Forms.BindingSource(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.cmbBatchNo = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbPart = new System.Windows.Forms.ComboBox();
            this.btnSendMR = new System.Windows.Forms.Button();
            this.objSourceBatchist = new System.Windows.Forms.BindingSource(this.components);
            this.objSourceMaterialList = new System.Windows.Forms.BindingSource(this.components);
            this.lblMessage = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdbSemiFinished = new System.Windows.Forms.RadioButton();
            this.rdbMaterial = new System.Windows.Forms.RadioButton();
            this.ColMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindItemList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceBatchist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceMaterialList)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.ColMaterial,
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvItemList.DataSource = this.bindItemList;
            this.dgvItemList.Location = new System.Drawing.Point(22, 77);
            this.dgvItemList.Name = "dgvItemList";
            this.dgvItemList.ReadOnly = true;
            this.dgvItemList.RowHeadersVisible = false;
            this.dgvItemList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItemList.Size = new System.Drawing.Size(968, 527);
            this.dgvItemList.TabIndex = 4;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Batch No";
            // 
            // cmbBatchNo
            // 
            this.cmbBatchNo.DisplayMember = "BatchID";
            this.cmbBatchNo.FormattingEnabled = true;
            this.cmbBatchNo.Location = new System.Drawing.Point(79, 20);
            this.cmbBatchNo.Name = "cmbBatchNo";
            this.cmbBatchNo.Size = new System.Drawing.Size(211, 21);
            this.cmbBatchNo.TabIndex = 2;
            this.cmbBatchNo.ValueMember = "BatchID";
            this.cmbBatchNo.SelectedIndexChanged += new System.EventHandler(this.cmbBatchNo_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(329, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Part";
            // 
            // cmbPart
            // 
            this.cmbPart.FormattingEnabled = true;
            this.cmbPart.Items.AddRange(new object[] {
            "A",
            "B"});
            this.cmbPart.Location = new System.Drawing.Point(375, 20);
            this.cmbPart.Name = "cmbPart";
            this.cmbPart.Size = new System.Drawing.Size(46, 21);
            this.cmbPart.TabIndex = 2;
            this.cmbPart.SelectedIndexChanged += new System.EventHandler(this.cmbPart_SelectedIndexChanged);
            // 
            // btnSendMR
            // 
            this.btnSendMR.Location = new System.Drawing.Point(441, 17);
            this.btnSendMR.Name = "btnSendMR";
            this.btnSendMR.Size = new System.Drawing.Size(75, 23);
            this.btnSendMR.TabIndex = 4;
            this.btnSendMR.Text = "Send MR";
            this.btnSendMR.UseVisualStyleBackColor = true;
            this.btnSendMR.Click += new System.EventHandler(this.btnSendMR_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.Maroon;
            this.lblMessage.Location = new System.Drawing.Point(24, 56);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(47, 15);
            this.lblMessage.TabIndex = 5;
            this.lblMessage.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdbSemiFinished);
            this.panel1.Controls.Add(this.rdbMaterial);
            this.panel1.Location = new System.Drawing.Point(624, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(191, 36);
            this.panel1.TabIndex = 7;
            // 
            // rdbSemiFinished
            // 
            this.rdbSemiFinished.AutoSize = true;
            this.rdbSemiFinished.Location = new System.Drawing.Point(80, 8);
            this.rdbSemiFinished.Name = "rdbSemiFinished";
            this.rdbSemiFinished.Size = new System.Drawing.Size(90, 17);
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
            this.rdbMaterial.Size = new System.Drawing.Size(62, 17);
            this.rdbMaterial.TabIndex = 0;
            this.rdbMaterial.TabStop = true;
            this.rdbMaterial.Text = "Material";
            this.rdbMaterial.UseVisualStyleBackColor = true;
            this.rdbMaterial.CheckedChanged += new System.EventHandler(this.rdbMaterial_CheckedChanged);
            // 
            // ColMaterial
            // 
            this.ColMaterial.DataPropertyName = "ItemCode";
            this.ColMaterial.HeaderText = "Item";
            this.ColMaterial.Name = "ColMaterial";
            this.ColMaterial.ReadOnly = true;
            this.ColMaterial.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColMaterial.Width = 200;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "Item";
            this.Column1.HeaderText = "Description of Items";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
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
            // Column3
            // 
            this.Column3.DataPropertyName = "Qty";
            this.Column3.HeaderText = "Reqd Qty.";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // frmMRT_Batch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 616);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnSendMR);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cmbPart);
            this.Controls.Add(this.cmbBatchNo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dgvItemList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMRT_Batch";
            this.Text = "Material Requisition Note";
            this.Load += new System.EventHandler(this.frmMRT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindItemList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceBatchist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceMaterialList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvItemList;
        private System.Windows.Forms.BindingSource bindItemList;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbBatchNo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbPart;
        private System.Windows.Forms.Button btnSendMR;
        private System.Windows.Forms.BindingSource objSourceBatchist;
        private System.Windows.Forms.BindingSource objSourceMaterialList;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdbSemiFinished;
        private System.Windows.Forms.RadioButton rdbMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}