namespace MRP_GUI
{
    partial class frmWIP_RPD
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvWIP_PRPD = new System.Windows.Forms.DataGridView();
            this.btnPrint = new System.Windows.Forms.Button();
            this.bsWIP_PRPD = new System.Windows.Forms.BindingSource(this.components);
            this.RPDBatchID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRPDBatchMaterialCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaterialName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RPDBatchStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RPDBatchQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaterialCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PackingMaterialCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MachineCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LabourCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OverheadCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWIP_PRPD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsWIP_PRPD)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(78, 7);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "WIP Date :";
            // 
            // dgvWIP_PRPD
            // 
            this.dgvWIP_PRPD.AllowUserToAddRows = false;
            this.dgvWIP_PRPD.AllowUserToDeleteRows = false;
            this.dgvWIP_PRPD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvWIP_PRPD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWIP_PRPD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RPDBatchID,
            this.PRPDBatchMaterialCode,
            this.MaterialName,
            this.RPDBatchStatus,
            this.RPDBatchQty,
            this.UnitCost,
            this.MaterialCost,
            this.PackingMaterialCost,
            this.MachineCost,
            this.LabourCost,
            this.OverheadCost,
            this.TotalCost});
            this.dgvWIP_PRPD.Location = new System.Drawing.Point(15, 37);
            this.dgvWIP_PRPD.Name = "dgvWIP_PRPD";
            this.dgvWIP_PRPD.ReadOnly = true;
            this.dgvWIP_PRPD.Size = new System.Drawing.Size(762, 345);
            this.dgvWIP_PRPD.TabIndex = 4;
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.Location = new System.Drawing.Point(699, 8);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 5;
            this.btnPrint.Text = "Print Report";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // RPDBatchID
            // 
            this.RPDBatchID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RPDBatchID.DataPropertyName = "RPDBatchID";
            this.RPDBatchID.HeaderText = "PRPDBatchID";
            this.RPDBatchID.Name = "RPDBatchID";
            this.RPDBatchID.ReadOnly = true;
            // 
            // PRPDBatchMaterialCode
            // 
            this.PRPDBatchMaterialCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PRPDBatchMaterialCode.DataPropertyName = "RPDBatchMaterialCode";
            this.PRPDBatchMaterialCode.HeaderText = "MaterialCode";
            this.PRPDBatchMaterialCode.Name = "PRPDBatchMaterialCode";
            this.PRPDBatchMaterialCode.ReadOnly = true;
            // 
            // MaterialName
            // 
            this.MaterialName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaterialName.DataPropertyName = "MaterialName";
            this.MaterialName.HeaderText = "MaterialName";
            this.MaterialName.Name = "MaterialName";
            this.MaterialName.ReadOnly = true;
            // 
            // RPDBatchStatus
            // 
            this.RPDBatchStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RPDBatchStatus.DataPropertyName = "RPDBatchStatus";
            this.RPDBatchStatus.HeaderText = "PRPDBatchStatus";
            this.RPDBatchStatus.Name = "RPDBatchStatus";
            this.RPDBatchStatus.ReadOnly = true;
            // 
            // RPDBatchQty
            // 
            this.RPDBatchQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RPDBatchQty.DataPropertyName = "RPDBatchQty";
            this.RPDBatchQty.HeaderText = "PRPDBatchQty";
            this.RPDBatchQty.Name = "RPDBatchQty";
            this.RPDBatchQty.ReadOnly = true;
            // 
            // UnitCost
            // 
            this.UnitCost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UnitCost.DataPropertyName = "UnitCost";
            this.UnitCost.HeaderText = "UnitCost";
            this.UnitCost.Name = "UnitCost";
            this.UnitCost.ReadOnly = true;
            // 
            // MaterialCost
            // 
            this.MaterialCost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaterialCost.DataPropertyName = "MaterialCost";
            this.MaterialCost.HeaderText = "MaterialCost";
            this.MaterialCost.Name = "MaterialCost";
            this.MaterialCost.ReadOnly = true;
            // 
            // PackingMaterialCost
            // 
            this.PackingMaterialCost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PackingMaterialCost.DataPropertyName = "PackingMaterialCost";
            this.PackingMaterialCost.HeaderText = "PackingMaterialCost";
            this.PackingMaterialCost.Name = "PackingMaterialCost";
            this.PackingMaterialCost.ReadOnly = true;
            // 
            // MachineCost
            // 
            this.MachineCost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MachineCost.DataPropertyName = "MachineCost";
            this.MachineCost.HeaderText = "MachineCost";
            this.MachineCost.Name = "MachineCost";
            this.MachineCost.ReadOnly = true;
            // 
            // LabourCost
            // 
            this.LabourCost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LabourCost.DataPropertyName = "LabourCost";
            this.LabourCost.HeaderText = "LabourCost";
            this.LabourCost.Name = "LabourCost";
            this.LabourCost.ReadOnly = true;
            // 
            // OverheadCost
            // 
            this.OverheadCost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.OverheadCost.DataPropertyName = "OverheadCost";
            this.OverheadCost.HeaderText = "OverheadCost";
            this.OverheadCost.Name = "OverheadCost";
            this.OverheadCost.ReadOnly = true;
            // 
            // TotalCost
            // 
            this.TotalCost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TotalCost.DataPropertyName = "TotalCost";
            this.TotalCost.HeaderText = "TotalCost";
            this.TotalCost.Name = "TotalCost";
            this.TotalCost.ReadOnly = true;
            // 
            // frmWIP_RPD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 394);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.dgvWIP_PRPD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "frmWIP_RPD";
            this.Text = "frmWIP_PRPD";
            ((System.ComponentModel.ISupportInitialize)(this.dgvWIP_PRPD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsWIP_PRPD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvWIP_PRPD;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.BindingSource bsWIP_PRPD;
        private System.Windows.Forms.DataGridViewTextBoxColumn RPDBatchID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRPDBatchMaterialCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaterialName;
        private System.Windows.Forms.DataGridViewTextBoxColumn RPDBatchStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn RPDBatchQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaterialCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn PackingMaterialCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn MachineCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn LabourCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn OverheadCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalCost;
    }
}