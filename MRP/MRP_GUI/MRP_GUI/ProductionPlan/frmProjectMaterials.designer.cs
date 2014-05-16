namespace MRP_GUI.Sales
{
    partial class frmProjectMaterials
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.cmbProjectName = new System.Windows.Forms.ComboBox();
            this.cbmMaterial = new System.Windows.Forms.ComboBox();
            this.bsProjets = new System.Windows.Forms.BindingSource(this.components);
            this.bsMaterials = new System.Windows.Forms.BindingSource(this.components);
            this.dgvMaterials = new System.Windows.Forms.DataGridView();
            this.MaterialCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BasicProductCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FinishProductCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsedQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DamagedQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDamageQty = new System.Windows.Forms.TextBox();
            this.bsDGVmaterial = new System.Windows.Forms.BindingSource(this.components);
            this.btnClear = new System.Windows.Forms.Button();
            this.lblAvailaableQty = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.bsProjets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMaterials)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterials)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDGVmaterial)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Project Name : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Material ID :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quantity :";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(238, 122);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(109, 29);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(115, 70);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(332, 20);
            this.txtQty.TabIndex = 4;
            // 
            // cmbProjectName
            // 
            this.cmbProjectName.DisplayMember = "ProjectName2";
            this.cmbProjectName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProjectName.FormattingEnabled = true;
            this.cmbProjectName.Location = new System.Drawing.Point(116, 17);
            this.cmbProjectName.Name = "cmbProjectName";
            this.cmbProjectName.Size = new System.Drawing.Size(331, 21);
            this.cmbProjectName.TabIndex = 5;
            this.cmbProjectName.ValueMember = "StoreID";
            this.cmbProjectName.SelectedIndexChanged += new System.EventHandler(this.cmbProjectName_SelectedIndexChanged);
            // 
            // cbmMaterial
            // 
            this.cbmMaterial.DisplayMember = "MaterialIDName";
            this.cbmMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmMaterial.FormattingEnabled = true;
            this.cbmMaterial.Location = new System.Drawing.Point(116, 45);
            this.cbmMaterial.Name = "cbmMaterial";
            this.cbmMaterial.Size = new System.Drawing.Size(331, 21);
            this.cbmMaterial.TabIndex = 6;
            this.cbmMaterial.ValueMember = "ItemCode";
            this.cbmMaterial.SelectedIndexChanged += new System.EventHandler(this.cbmMaterial_SelectedIndexChanged);
            // 
            // dgvMaterials
            // 
            this.dgvMaterials.AllowUserToAddRows = false;
            this.dgvMaterials.AllowUserToDeleteRows = false;
            this.dgvMaterials.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMaterials.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaterials.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaterialCode,
            this.BasicProductCode,
            this.FinishProductCode,
            this.UsedQty,
            this.DamagedQty,
            this.UnitPrice});
            this.dgvMaterials.Location = new System.Drawing.Point(12, 179);
            this.dgvMaterials.MultiSelect = false;
            this.dgvMaterials.Name = "dgvMaterials";
            this.dgvMaterials.ReadOnly = true;
            this.dgvMaterials.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMaterials.Size = new System.Drawing.Size(971, 186);
            this.dgvMaterials.TabIndex = 7;
            // 
            // MaterialCode
            // 
            this.MaterialCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaterialCode.DataPropertyName = "MaterialCode";
            this.MaterialCode.HeaderText = "Material";
            this.MaterialCode.Name = "MaterialCode";
            this.MaterialCode.ReadOnly = true;
            // 
            // BasicProductCode
            // 
            this.BasicProductCode.DataPropertyName = "BasicProductCode";
            this.BasicProductCode.HeaderText = "Basic Product";
            this.BasicProductCode.Name = "BasicProductCode";
            this.BasicProductCode.ReadOnly = true;
            // 
            // FinishProductCode
            // 
            this.FinishProductCode.DataPropertyName = "FinishProductCode";
            this.FinishProductCode.HeaderText = "Finish Product";
            this.FinishProductCode.Name = "FinishProductCode";
            this.FinishProductCode.ReadOnly = true;
            // 
            // UsedQty
            // 
            this.UsedQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UsedQty.DataPropertyName = "UsedQty";
            this.UsedQty.HeaderText = "Used Qty";
            this.UsedQty.Name = "UsedQty";
            this.UsedQty.ReadOnly = true;
            // 
            // DamagedQty
            // 
            this.DamagedQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DamagedQty.DataPropertyName = "DamagedQty";
            this.DamagedQty.HeaderText = "Damaged Qty";
            this.DamagedQty.Name = "DamagedQty";
            this.DamagedQty.ReadOnly = true;
            // 
            // UnitPrice
            // 
            this.UnitPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UnitPrice.DataPropertyName = "UnitPrice";
            this.UnitPrice.HeaderText = "Unit Price";
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.ReadOnly = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Damage Quantity :";
            // 
            // txtDamageQty
            // 
            this.txtDamageQty.Location = new System.Drawing.Point(115, 96);
            this.txtDamageQty.Name = "txtDamageQty";
            this.txtDamageQty.Size = new System.Drawing.Size(332, 20);
            this.txtDamageQty.TabIndex = 9;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(353, 122);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(94, 29);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblAvailaableQty
            // 
            this.lblAvailaableQty.AutoSize = true;
            this.lblAvailaableQty.Location = new System.Drawing.Point(453, 73);
            this.lblAvailaableQty.Name = "lblAvailaableQty";
            this.lblAvailaableQty.Size = new System.Drawing.Size(134, 13);
            this.lblAvailaableQty.TabIndex = 12;
            this.lblAvailaableQty.Text = "Available Quantity : 000.00";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.lblAvailaableQty);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtDamageQty);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtQty);
            this.groupBox1.Controls.Add(this.cmbProjectName);
            this.groupBox1.Controls.Add(this.cbmMaterial);
            this.groupBox1.Location = new System.Drawing.Point(12, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(971, 171);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // frmProjectMaterials
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 377);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvMaterials);
            this.Name = "frmProjectMaterials";
            this.Text = "ProjectMaterials";
            ((System.ComponentModel.ISupportInitialize)(this.bsProjets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMaterials)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterials)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDGVmaterial)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.ComboBox cmbProjectName;
        private System.Windows.Forms.ComboBox cbmMaterial;
        private System.Windows.Forms.BindingSource bsProjets;
        private System.Windows.Forms.BindingSource bsMaterials;
        private System.Windows.Forms.DataGridView dgvMaterials;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDamageQty;
        private System.Windows.Forms.BindingSource bsDGVmaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaterialCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn BasicProductCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn FinishProductCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsedQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn DamagedQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblAvailaableQty;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}