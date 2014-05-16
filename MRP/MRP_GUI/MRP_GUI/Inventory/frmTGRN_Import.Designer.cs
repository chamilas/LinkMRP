namespace MRP_GUI
{
    partial class frmTGRN_Import
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
            this.txtMaterial = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDeliverNote = new System.Windows.Forms.TextBox();
            this.dgvDeliverNoteList = new System.Windows.Forms.DataGridView();
            this.MaterialCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaterialName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMaterialCode = new System.Windows.Forms.TextBox();
            this.lblUnit = new System.Windows.Forms.Label();
            this.txtSupplier = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.txtSupplierCode = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPONO = new System.Windows.Forms.TextBox();
            this.objSourceDeliverNotes = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeliverNoteList)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceDeliverNotes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Material";
            // 
            // txtMaterial
            // 
            this.txtMaterial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaterial.Location = new System.Drawing.Point(101, 76);
            this.txtMaterial.Name = "txtMaterial";
            this.txtMaterial.Size = new System.Drawing.Size(529, 24);
            this.txtMaterial.TabIndex = 2;
            this.txtMaterial.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMaterial_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Quantity";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(101, 114);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(96, 24);
            this.txtQuantity.TabIndex = 3;
            this.txtQuantity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQuantity_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Deliver Note";
            // 
            // txtDeliverNote
            // 
            this.txtDeliverNote.Location = new System.Drawing.Point(101, 12);
            this.txtDeliverNote.Name = "txtDeliverNote";
            this.txtDeliverNote.Size = new System.Drawing.Size(171, 24);
            this.txtDeliverNote.TabIndex = 0;
            this.txtDeliverNote.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDeliverNote_KeyDown);
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
            this.MaterialCode,
            this.MaterialName,
            this.Qty,
            this.Unit});
            this.dgvDeliverNoteList.Location = new System.Drawing.Point(12, 154);
            this.dgvDeliverNoteList.Name = "dgvDeliverNoteList";
            this.dgvDeliverNoteList.ReadOnly = true;
            this.dgvDeliverNoteList.Size = new System.Drawing.Size(810, 251);
            this.dgvDeliverNoteList.TabIndex = 2;
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
            this.MaterialName.DataPropertyName = "MaterialName";
            this.MaterialName.FillWeight = 300F;
            this.MaterialName.HeaderText = "MaterialName";
            this.MaterialName.Name = "MaterialName";
            this.MaterialName.ReadOnly = true;
            // 
            // Qty
            // 
            this.Qty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Qty.DataPropertyName = "DeleverdMaterialQty";
            this.Qty.HeaderText = "Qty";
            this.Qty.Name = "Qty";
            this.Qty.ReadOnly = true;
            // 
            // Unit
            // 
            this.Unit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Unit.DataPropertyName = "Unit";
            this.Unit.HeaderText = "Unit";
            this.Unit.Name = "Unit";
            this.Unit.ReadOnly = true;
            // 
            // txtMaterialCode
            // 
            this.txtMaterialCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaterialCode.Location = new System.Drawing.Point(636, 76);
            this.txtMaterialCode.Name = "txtMaterialCode";
            this.txtMaterialCode.Size = new System.Drawing.Size(176, 24);
            this.txtMaterialCode.TabIndex = 1;
            this.txtMaterialCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMaterial_KeyDown);
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Location = new System.Drawing.Point(203, 117);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(26, 18);
            this.lblUnit.TabIndex = 0;
            this.lblUnit.Text = "<>";
            // 
            // txtSupplier
            // 
            this.txtSupplier.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSupplier.Location = new System.Drawing.Point(786, 12);
            this.txtSupplier.Name = "txtSupplier";
            this.txtSupplier.Size = new System.Drawing.Size(10, 24);
            this.txtSupplier.TabIndex = 1;
            this.txtSupplier.Visible = false;
            this.txtSupplier.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSupplier_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(278, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Purchase Order";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 18);
            this.label6.TabIndex = 4;
            this.label6.Text = "Remarks";
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(101, 46);
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(711, 24);
            this.txtRemarks.TabIndex = 4;
            this.txtRemarks.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRemarks_KeyDown);
            // 
            // txtSupplierCode
            // 
            this.txtSupplierCode.Location = new System.Drawing.Point(802, 12);
            this.txtSupplierCode.Name = "txtSupplierCode";
            this.txtSupplierCode.Size = new System.Drawing.Size(10, 24);
            this.txtSupplierCode.TabIndex = 6;
            this.txtSupplierCode.Visible = false;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 416);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(215, 18);
            this.label7.TabIndex = 7;
            this.label7.Text = "End = Confirm Deliver Note";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(576, 414);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(255, 18);
            this.label8.TabIndex = 7;
            this.label8.Text = "F1= View Previous Deliver Notes";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.YellowGreen;
            this.panel1.Controls.Add(this.txtPONO);
            this.panel1.Controls.Add(this.txtDeliverNote);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtSupplierCode);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtRemarks);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lblUnit);
            this.panel1.Controls.Add(this.txtMaterial);
            this.panel1.Controls.Add(this.txtQuantity);
            this.panel1.Controls.Add(this.txtMaterialCode);
            this.panel1.Controls.Add(this.txtSupplier);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(4, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(827, 146);
            this.panel1.TabIndex = 0;
            // 
            // txtPONO
            // 
            this.txtPONO.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPONO.Location = new System.Drawing.Point(397, 12);
            this.txtPONO.Name = "txtPONO";
            this.txtPONO.Size = new System.Drawing.Size(383, 24);
            this.txtPONO.TabIndex = 7;
            this.txtPONO.TextChanged += new System.EventHandler(this.txtPONO_TextChanged);
            this.txtPONO.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPONO_KeyDown);
            // 
            // frmTGRN
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(834, 441);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvDeliverNoteList);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmTGRN";
            this.Text = "Temperory GRN";
            this.Load += new System.EventHandler(this.frmTGRN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeliverNoteList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceDeliverNotes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaterial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDeliverNote;
        private System.Windows.Forms.DataGridView dgvDeliverNoteList;
        private System.Windows.Forms.BindingSource objSourceDeliverNotes;
        private System.Windows.Forms.TextBox txtMaterialCode;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaterialCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaterialName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private System.Windows.Forms.TextBox txtSupplier;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.TextBox txtSupplierCode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtPONO;
    }
}