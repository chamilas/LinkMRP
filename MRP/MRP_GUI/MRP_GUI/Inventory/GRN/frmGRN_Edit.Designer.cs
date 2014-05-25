namespace MRP_GUI
{
    partial class frmGRN_Edit
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
            this.cmbGRNType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvGRN = new System.Windows.Forms.DataGridView();
            this.GRNNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Doc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GRNDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EnterdByName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GRNStoreID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvGRNMaterial = new System.Windows.Forms.DataGridView();
            this.ItemCodem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descriptionm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RacevQtym = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unitm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPricem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToStorem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remarksm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cmbMaterial = new System.Windows.Forms.ComboBox();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bsGRN = new System.Windows.Forms.BindingSource(this.components);
            this.bsGRNMaterial = new System.Windows.Forms.BindingSource(this.components);
            this.bsMaterialList = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGRN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGRNMaterial)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsGRN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsGRNMaterial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMaterialList)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbGRNType
            // 
            this.cmbGRNType.FormattingEnabled = true;
            this.cmbGRNType.Items.AddRange(new object[] {
            "Material",
            "BasicProduct",
            "FinishProduct"});
            this.cmbGRNType.Location = new System.Drawing.Point(86, 16);
            this.cmbGRNType.Name = "cmbGRNType";
            this.cmbGRNType.Size = new System.Drawing.Size(323, 21);
            this.cmbGRNType.TabIndex = 0;
            this.cmbGRNType.SelectedIndexChanged += new System.EventHandler(this.cmbGRNType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "GRN Type : ";
            // 
            // dgvGRN
            // 
            this.dgvGRN.AllowUserToAddRows = false;
            this.dgvGRN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGRN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGRN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GRNNO,
            this.Doc,
            this.GRNDate,
            this.EnterdByName,
            this.GRNStoreID});
            this.dgvGRN.Location = new System.Drawing.Point(16, 43);
            this.dgvGRN.MultiSelect = false;
            this.dgvGRN.Name = "dgvGRN";
            this.dgvGRN.ReadOnly = true;
            this.dgvGRN.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGRN.Size = new System.Drawing.Size(924, 272);
            this.dgvGRN.TabIndex = 6;
            this.dgvGRN.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGRN_CellClick);
            // 
            // GRNNO
            // 
            this.GRNNO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GRNNO.DataPropertyName = "GRNNO";
            this.GRNNO.HeaderText = "GRNNO";
            this.GRNNO.Name = "GRNNO";
            this.GRNNO.ReadOnly = true;
            // 
            // Doc
            // 
            this.Doc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Doc.DataPropertyName = "Doc";
            this.Doc.HeaderText = "Doc";
            this.Doc.Name = "Doc";
            this.Doc.ReadOnly = true;
            // 
            // GRNDate
            // 
            this.GRNDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GRNDate.DataPropertyName = "GRNDate";
            this.GRNDate.HeaderText = "GRNDate";
            this.GRNDate.Name = "GRNDate";
            this.GRNDate.ReadOnly = true;
            // 
            // EnterdByName
            // 
            this.EnterdByName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EnterdByName.DataPropertyName = "EnterdByName";
            this.EnterdByName.HeaderText = "EnterdByName";
            this.EnterdByName.Name = "EnterdByName";
            this.EnterdByName.ReadOnly = true;
            // 
            // GRNStoreID
            // 
            this.GRNStoreID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GRNStoreID.DataPropertyName = "GRNStoreID";
            this.GRNStoreID.HeaderText = "GRNStoreID";
            this.GRNStoreID.Name = "GRNStoreID";
            this.GRNStoreID.ReadOnly = true;
            // 
            // dgvGRNMaterial
            // 
            this.dgvGRNMaterial.AllowUserToAddRows = false;
            this.dgvGRNMaterial.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGRNMaterial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGRNMaterial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemCodem,
            this.Descriptionm,
            this.RacevQtym,
            this.Unitm,
            this.UnitPricem,
            this.ToStorem,
            this.Remarksm});
            this.dgvGRNMaterial.Location = new System.Drawing.Point(6, 48);
            this.dgvGRNMaterial.MultiSelect = false;
            this.dgvGRNMaterial.Name = "dgvGRNMaterial";
            this.dgvGRNMaterial.ReadOnly = true;
            this.dgvGRNMaterial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGRNMaterial.Size = new System.Drawing.Size(912, 208);
            this.dgvGRNMaterial.TabIndex = 7;
            this.dgvGRNMaterial.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGRNMaterial_CellClick);
            // 
            // ItemCodem
            // 
            this.ItemCodem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ItemCodem.DataPropertyName = "ItemCode";
            this.ItemCodem.HeaderText = "Item Code";
            this.ItemCodem.Name = "ItemCodem";
            this.ItemCodem.ReadOnly = true;
            // 
            // Descriptionm
            // 
            this.Descriptionm.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Descriptionm.DataPropertyName = "Description";
            this.Descriptionm.HeaderText = "Description";
            this.Descriptionm.Name = "Descriptionm";
            this.Descriptionm.ReadOnly = true;
            // 
            // RacevQtym
            // 
            this.RacevQtym.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RacevQtym.DataPropertyName = "RacevQty";
            this.RacevQtym.HeaderText = "Quantity";
            this.RacevQtym.Name = "RacevQtym";
            this.RacevQtym.ReadOnly = true;
            // 
            // Unitm
            // 
            this.Unitm.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Unitm.DataPropertyName = "Unit";
            this.Unitm.HeaderText = "Unit";
            this.Unitm.Name = "Unitm";
            this.Unitm.ReadOnly = true;
            // 
            // UnitPricem
            // 
            this.UnitPricem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UnitPricem.DataPropertyName = "UnitPrice";
            this.UnitPricem.HeaderText = "Unit Price";
            this.UnitPricem.Name = "UnitPricem";
            this.UnitPricem.ReadOnly = true;
            // 
            // ToStorem
            // 
            this.ToStorem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ToStorem.DataPropertyName = "ToStore";
            this.ToStorem.HeaderText = "Store";
            this.ToStorem.Name = "ToStorem";
            this.ToStorem.ReadOnly = true;
            // 
            // Remarksm
            // 
            this.Remarksm.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Remarksm.DataPropertyName = "Remarks";
            this.Remarksm.HeaderText = "Remarks";
            this.Remarksm.Name = "Remarksm";
            this.Remarksm.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Material : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(303, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Quantity :";
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(361, 21);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(63, 20);
            this.txtQty.TabIndex = 11;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(762, 19);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(600, 19);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Location = new System.Drawing.Point(843, 19);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.cmbMaterial);
            this.groupBox1.Controls.Add(this.txtUnitPrice);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.dgvGRNMaterial);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtQty);
            this.groupBox1.Location = new System.Drawing.Point(12, 321);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(924, 262);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.Location = new System.Drawing.Point(681, 19);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // cmbMaterial
            // 
            this.cmbMaterial.FormattingEnabled = true;
            this.cmbMaterial.Location = new System.Drawing.Point(65, 21);
            this.cmbMaterial.Name = "cmbMaterial";
            this.cmbMaterial.Size = new System.Drawing.Size(232, 21);
            this.cmbMaterial.TabIndex = 17;
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(495, 21);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(63, 20);
            this.txtUnitPrice.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(430, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Unit Price :";
            // 
            // frmGRN_Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 589);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvGRN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbGRNType);
            this.Name = "frmGRN_Edit";
            this.Text = "frmGRN_Edit";
            this.Load += new System.EventHandler(this.frmGRN_Edit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGRN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGRNMaterial)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsGRN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsGRNMaterial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMaterialList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbGRNType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvGRN;
        private System.Windows.Forms.DataGridView dgvGRNMaterial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource bsGRN;
        private System.Windows.Forms.DataGridViewTextBoxColumn GRNNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Doc;
        private System.Windows.Forms.DataGridViewTextBoxColumn GRNDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnterdByName;
        private System.Windows.Forms.DataGridViewTextBoxColumn GRNStoreID;
        private System.Windows.Forms.BindingSource bsGRNMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemCodem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descriptionm;
        private System.Windows.Forms.DataGridViewTextBoxColumn RacevQtym;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unitm;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPricem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToStorem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remarksm;
        private System.Windows.Forms.BindingSource bsMaterialList;
        private System.Windows.Forms.ComboBox cmbMaterial;
        private System.Windows.Forms.Button btnUpdate;
    }
}