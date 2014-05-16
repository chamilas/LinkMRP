namespace MRP_GUI
{
    partial class frmTGRNEdit
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
            this.dgvDeliverNoteList = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EnteredDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._DeliverNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaterialCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaterialName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.objSourceDeliverNotes = new System.Windows.Forms.BindingSource(this.components);
            this.cmbMaterial = new System.Windows.Forms.ComboBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.objSourceMaterials = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.chkRaw = new System.Windows.Forms.CheckBox();
            this.chkLab = new System.Windows.Forms.CheckBox();
            this.chkPacking = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeliverNoteList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceDeliverNotes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceMaterials)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDeliverNoteList
            // 
            this.dgvDeliverNoteList.AllowUserToAddRows = false;
            this.dgvDeliverNoteList.AllowUserToDeleteRows = false;
            this.dgvDeliverNoteList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDeliverNoteList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeliverNoteList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.EnteredDate,
            this._DeliverNote,
            this.MaterialCode,
            this.MaterialName,
            this.Qty,
            this.Unit});
            this.dgvDeliverNoteList.Location = new System.Drawing.Point(12, 51);
            this.dgvDeliverNoteList.Name = "dgvDeliverNoteList";
            this.dgvDeliverNoteList.ReadOnly = true;
            this.dgvDeliverNoteList.Size = new System.Drawing.Size(980, 549);
            this.dgvDeliverNoteList.TabIndex = 2;
            this.dgvDeliverNoteList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDeliverNoteList_CellClick);
            this.dgvDeliverNoteList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvDeliverNoteList_KeyDown);
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // EnteredDate
            // 
            this.EnteredDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EnteredDate.DataPropertyName = "DeliverEnterdDate";
            this.EnteredDate.FillWeight = 150F;
            this.EnteredDate.HeaderText = "Entered Date";
            this.EnteredDate.Name = "EnteredDate";
            this.EnteredDate.ReadOnly = true;
            // 
            // _DeliverNote
            // 
            this._DeliverNote.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._DeliverNote.DataPropertyName = "DeliverNoteNo";
            this._DeliverNote.HeaderText = "DeliverNote";
            this._DeliverNote.Name = "_DeliverNote";
            this._DeliverNote.ReadOnly = true;
            // 
            // MaterialCode
            // 
            this.MaterialCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaterialCode.DataPropertyName = "MaterialCode";
            this.MaterialCode.HeaderText = "MaterialCode";
            this.MaterialCode.Name = "MaterialCode";
            this.MaterialCode.ReadOnly = true;
            // 
            // MaterialName
            // 
            this.MaterialName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaterialName.DataPropertyName = "MaterialDescription";
            this.MaterialName.FillWeight = 300F;
            this.MaterialName.HeaderText = "MaterialName";
            this.MaterialName.Name = "MaterialName";
            this.MaterialName.ReadOnly = true;
            // 
            // Qty
            // 
            this.Qty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Qty.DataPropertyName = "Quantity";
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
            // cmbMaterial
            // 
            this.cmbMaterial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbMaterial.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbMaterial.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbMaterial.DisplayMember = "Material";
            this.cmbMaterial.FormattingEnabled = true;
            this.cmbMaterial.Location = new System.Drawing.Point(412, 17);
            this.cmbMaterial.Name = "cmbMaterial";
            this.cmbMaterial.Size = new System.Drawing.Size(310, 24);
            this.cmbMaterial.TabIndex = 3;
            this.cmbMaterial.ValueMember = "MaterialCode";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuantity.Location = new System.Drawing.Point(790, 17);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(100, 22);
            this.txtQuantity.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(728, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Quantity";
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Location = new System.Drawing.Point(906, 13);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(86, 26);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(350, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Material";
            // 
            // chkRaw
            // 
            this.chkRaw.AutoSize = true;
            this.chkRaw.Checked = true;
            this.chkRaw.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRaw.Location = new System.Drawing.Point(12, 24);
            this.chkRaw.Name = "chkRaw";
            this.chkRaw.Size = new System.Drawing.Size(54, 20);
            this.chkRaw.TabIndex = 7;
            this.chkRaw.Text = "Raw";
            this.chkRaw.UseVisualStyleBackColor = true;
            this.chkRaw.CheckedChanged += new System.EventHandler(this.chkRaw_CheckedChanged);
            // 
            // chkLab
            // 
            this.chkLab.AutoSize = true;
            this.chkLab.Location = new System.Drawing.Point(204, 25);
            this.chkLab.Name = "chkLab";
            this.chkLab.Size = new System.Drawing.Size(50, 20);
            this.chkLab.TabIndex = 7;
            this.chkLab.Text = "Lab";
            this.chkLab.UseVisualStyleBackColor = true;
            this.chkLab.CheckedChanged += new System.EventHandler(this.chkLab_CheckedChanged);
            // 
            // chkPacking
            // 
            this.chkPacking.AutoSize = true;
            this.chkPacking.Location = new System.Drawing.Point(111, 24);
            this.chkPacking.Name = "chkPacking";
            this.chkPacking.Size = new System.Drawing.Size(76, 20);
            this.chkPacking.TabIndex = 7;
            this.chkPacking.Text = "Packing";
            this.chkPacking.UseVisualStyleBackColor = true;
            this.chkPacking.CheckedChanged += new System.EventHandler(this.chkPacking_CheckedChanged);
            // 
            // frmTGRNEdit
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1004, 612);
            this.Controls.Add(this.chkPacking);
            this.Controls.Add(this.chkLab);
            this.Controls.Add(this.chkRaw);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.cmbMaterial);
            this.Controls.Add(this.dgvDeliverNoteList);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmTGRNEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Temporary GRN";
            this.Load += new System.EventHandler(this.frmTGRN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeliverNoteList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceDeliverNotes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceMaterials)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDeliverNoteList;
        private System.Windows.Forms.BindingSource objSourceDeliverNotes;
        private System.Windows.Forms.ComboBox cmbMaterial;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnteredDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn _DeliverNote;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaterialCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaterialName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private System.Windows.Forms.BindingSource objSourceMaterials;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkRaw;
        private System.Windows.Forms.CheckBox chkLab;
        private System.Windows.Forms.CheckBox chkPacking;
    }
}