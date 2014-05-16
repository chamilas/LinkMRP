namespace MRP_GUI.Production
{
    partial class frmFormulaEdit
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
            this.dgvFormulaMaterial = new System.Windows.Forms.DataGridView();
            this.ItemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Part = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.objSourceFormulaMaterials = new System.Windows.Forms.BindingSource(this.components);
            this.btnSave = new System.Windows.Forms.Button();
            this.cmbMaterial = new System.Windows.Forms.ComboBox();
            this.txtNewQty = new System.Windows.Forms.TextBox();
            this.objSourceMaterial = new System.Windows.Forms.BindingSource(this.components);
            this.cmbSemiFinished = new System.Windows.Forms.ComboBox();
            this.objSourceSemi = new System.Windows.Forms.BindingSource(this.components);
            this.chkMaterial = new System.Windows.Forms.CheckBox();
            this.chkSemiFinished = new System.Windows.Forms.CheckBox();
            this.txtPart = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFormulaMaterial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceFormulaMaterials)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceMaterial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceSemi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFormulaMaterial
            // 
            this.dgvFormulaMaterial.AllowUserToAddRows = false;
            this.dgvFormulaMaterial.AllowUserToDeleteRows = false;
            this.dgvFormulaMaterial.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFormulaMaterial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFormulaMaterial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemCode,
            this.Item,
            this.Part,
            this.Qty,
            this.Unit});
            this.dgvFormulaMaterial.Location = new System.Drawing.Point(12, 39);
            this.dgvFormulaMaterial.Name = "dgvFormulaMaterial";
            this.dgvFormulaMaterial.ReadOnly = true;
            this.dgvFormulaMaterial.Size = new System.Drawing.Size(792, 334);
            this.dgvFormulaMaterial.TabIndex = 0;
            this.dgvFormulaMaterial.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFormulaMaterial_CellClick);
            // 
            // ItemCode
            // 
            this.ItemCode.DataPropertyName = "ItemCode";
            this.ItemCode.HeaderText = "ItemCode";
            this.ItemCode.Name = "ItemCode";
            this.ItemCode.ReadOnly = true;
            this.ItemCode.Visible = false;
            // 
            // Item
            // 
            this.Item.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Item.DataPropertyName = "Item";
            this.Item.FillWeight = 250F;
            this.Item.HeaderText = "Item";
            this.Item.Name = "Item";
            this.Item.ReadOnly = true;
            // 
            // Part
            // 
            this.Part.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Part.DataPropertyName = "Part";
            this.Part.HeaderText = "Part";
            this.Part.Name = "Part";
            this.Part.ReadOnly = true;
            // 
            // Qty
            // 
            this.Qty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Qty.DataPropertyName = "Qty";
            this.Qty.HeaderText = "Qty";
            this.Qty.Name = "Qty";
            this.Qty.ReadOnly = true;
            // 
            // Unit
            // 
            this.Unit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Unit.DataPropertyName = "UnitCode";
            this.Unit.HeaderText = "Unit";
            this.Unit.Name = "Unit";
            this.Unit.ReadOnly = true;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(715, 382);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(89, 27);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cmbMaterial
            // 
            this.cmbMaterial.DisplayMember = "MaterialCode";
            this.cmbMaterial.FormattingEnabled = true;
            this.cmbMaterial.Location = new System.Drawing.Point(12, 382);
            this.cmbMaterial.Name = "cmbMaterial";
            this.cmbMaterial.Size = new System.Drawing.Size(256, 24);
            this.cmbMaterial.TabIndex = 4;
            this.cmbMaterial.ValueMember = "MaterialCode";
            // 
            // txtNewQty
            // 
            this.txtNewQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewQty.Location = new System.Drawing.Point(309, 384);
            this.txtNewQty.Name = "txtNewQty";
            this.txtNewQty.Size = new System.Drawing.Size(57, 24);
            this.txtNewQty.TabIndex = 3;
            // 
            // objSourceMaterial
            // 
            this.objSourceMaterial.AllowNew = true;
            // 
            // cmbSemiFinished
            // 
            this.cmbSemiFinished.DisplayMember = "BasicProductCode";
            this.cmbSemiFinished.FormattingEnabled = true;
            this.cmbSemiFinished.Location = new System.Drawing.Point(12, 383);
            this.cmbSemiFinished.Name = "cmbSemiFinished";
            this.cmbSemiFinished.Size = new System.Drawing.Size(256, 24);
            this.cmbSemiFinished.TabIndex = 5;
            this.cmbSemiFinished.ValueMember = "BasicProductCode";
            this.cmbSemiFinished.Visible = false;
            // 
            // chkMaterial
            // 
            this.chkMaterial.AutoSize = true;
            this.chkMaterial.Checked = true;
            this.chkMaterial.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMaterial.Location = new System.Drawing.Point(13, 13);
            this.chkMaterial.Name = "chkMaterial";
            this.chkMaterial.Size = new System.Drawing.Size(75, 20);
            this.chkMaterial.TabIndex = 6;
            this.chkMaterial.Text = "Material";
            this.chkMaterial.UseVisualStyleBackColor = true;
            this.chkMaterial.CheckedChanged += new System.EventHandler(this.chkMaterial_CheckedChanged);
            // 
            // chkSemiFinished
            // 
            this.chkSemiFinished.AutoSize = true;
            this.chkSemiFinished.Location = new System.Drawing.Point(140, 13);
            this.chkSemiFinished.Name = "chkSemiFinished";
            this.chkSemiFinished.Size = new System.Drawing.Size(112, 20);
            this.chkSemiFinished.TabIndex = 6;
            this.chkSemiFinished.Text = "Semi Finished";
            this.chkSemiFinished.UseVisualStyleBackColor = true;
            this.chkSemiFinished.CheckedChanged += new System.EventHandler(this.chkSemiFinished_CheckedChanged);
            // 
            // txtPart
            // 
            this.txtPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPart.Location = new System.Drawing.Point(419, 385);
            this.txtPart.Name = "txtPart";
            this.txtPart.Size = new System.Drawing.Size(59, 24);
            this.txtPart.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(275, 395);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Qty";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(381, 395);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Part";
            // 
            // txtRemarks
            // 
            this.txtRemarks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.Location = new System.Drawing.Point(553, 385);
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(156, 24);
            this.txtRemarks.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(484, 391);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Remarks";
            // 
            // frmFormulaEdit
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(816, 420);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPart);
            this.Controls.Add(this.chkSemiFinished);
            this.Controls.Add(this.chkMaterial);
            this.Controls.Add(this.cmbSemiFinished);
            this.Controls.Add(this.cmbMaterial);
            this.Controls.Add(this.txtNewQty);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvFormulaMaterial);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmFormulaEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formula Edit";
            this.Load += new System.EventHandler(this.frmFormulaEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFormulaMaterial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceFormulaMaterials)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceMaterial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceSemi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFormulaMaterial;
        private System.Windows.Forms.BindingSource objSourceFormulaMaterials;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cmbMaterial;
        private System.Windows.Forms.TextBox txtNewQty;
        private System.Windows.Forms.BindingSource objSourceMaterial;
        private System.Windows.Forms.ComboBox cmbSemiFinished;
        private System.Windows.Forms.BindingSource objSourceSemi;
        private System.Windows.Forms.CheckBox chkMaterial;
        private System.Windows.Forms.CheckBox chkSemiFinished;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Part;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private System.Windows.Forms.TextBox txtPart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Label label3;
    }
}