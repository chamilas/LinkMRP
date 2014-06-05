namespace MRP_GUI.Production
{
    partial class frmViewRejectedItems
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
            this.dgvMaterialDetails = new System.Windows.Forms.DataGridView();
            this.MachineID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InputQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OutputQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RejectedQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.objSourceBatchMaterial = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterialDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceBatchMaterial)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMaterialDetails
            // 
            this.dgvMaterialDetails.AllowUserToAddRows = false;
            this.dgvMaterialDetails.AllowUserToDeleteRows = false;
            this.dgvMaterialDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvMaterialDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaterialDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MachineID,
            this.InputQty,
            this.OutputQty,
            this.RejectedQty});
            this.dgvMaterialDetails.Location = new System.Drawing.Point(12, 12);
            this.dgvMaterialDetails.Name = "dgvMaterialDetails";
            this.dgvMaterialDetails.ReadOnly = true;
            this.dgvMaterialDetails.Size = new System.Drawing.Size(589, 316);
            this.dgvMaterialDetails.TabIndex = 1;
            // 
            // MachineID
            // 
            this.MachineID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MachineID.DataPropertyName = "MachineID";
            this.MachineID.HeaderText = "Machine ID";
            this.MachineID.Name = "MachineID";
            this.MachineID.ReadOnly = true;
            // 
            // InputQty
            // 
            this.InputQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.InputQty.DataPropertyName = "InputQty";
            this.InputQty.HeaderText = "Input Quantity";
            this.InputQty.Name = "InputQty";
            this.InputQty.ReadOnly = true;
            // 
            // OutputQty
            // 
            this.OutputQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.OutputQty.DataPropertyName = "OutputQty";
            this.OutputQty.HeaderText = "Output Quantity";
            this.OutputQty.Name = "OutputQty";
            this.OutputQty.ReadOnly = true;
            // 
            // RejectedQty
            // 
            this.RejectedQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RejectedQty.DataPropertyName = "RejectedQty";
            this.RejectedQty.HeaderText = "Rejected Quantity";
            this.RejectedQty.Name = "RejectedQty";
            this.RejectedQty.ReadOnly = true;
            // 
            // frmViewRejectedItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 340);
            this.Controls.Add(this.dgvMaterialDetails);
            this.Name = "frmViewRejectedItems";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmViewRejectedItems";
            this.Load += new System.EventHandler(this.frmViewRejectedItems_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterialDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceBatchMaterial)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMaterialDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn MachineID;
        private System.Windows.Forms.DataGridViewTextBoxColumn InputQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn OutputQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn RejectedQty;
        private System.Windows.Forms.BindingSource objSourceBatchMaterial;
    }
}