namespace MRP_GUI
{
    partial class frmTGRNSelection
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeliverNoteList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceDeliverNotes)).BeginInit();
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
            this.dgvDeliverNoteList.Location = new System.Drawing.Point(12, 12);
            this.dgvDeliverNoteList.Name = "dgvDeliverNoteList";
            this.dgvDeliverNoteList.ReadOnly = true;
            this.dgvDeliverNoteList.Size = new System.Drawing.Size(810, 417);
            this.dgvDeliverNoteList.TabIndex = 2;
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
            // frmTGRNSelection
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(834, 441);
            this.Controls.Add(this.dgvDeliverNoteList);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmTGRNSelection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Temperory GRN";
            this.Load += new System.EventHandler(this.frmTGRN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeliverNoteList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceDeliverNotes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDeliverNoteList;
        private System.Windows.Forms.BindingSource objSourceDeliverNotes;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnteredDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn _DeliverNote;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaterialCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaterialName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
    }
}