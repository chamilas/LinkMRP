namespace MRP_GUI.Packing
{
    partial class frmBatchPacking_DamagedGoods
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRejectedQty = new System.Windows.Forms.TextBox();
            this.Qty = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtInputQty = new System.Windows.Forms.TextBox();
            this.txtOutputQty = new System.Windows.Forms.TextBox();
            this.objSourceBatchMachine = new System.Windows.Forms.BindingSource(this.components);
            this.dgvMachineDetails = new System.Windows.Forms.DataGridView();
            this.MachineRecID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MachineCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Machine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.From_Machine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.To_Machine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceBatchMachine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMachineDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(171, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 214;
            this.label5.Text = "Output Quantity :";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 215;
            this.label4.Text = "Input Quantity :";
            // 
            // txtRejectedQty
            // 
            this.txtRejectedQty.Location = new System.Drawing.Point(444, 23);
            this.txtRejectedQty.Name = "txtRejectedQty";
            this.txtRejectedQty.Size = new System.Drawing.Size(42, 20);
            this.txtRejectedQty.TabIndex = 218;
            this.txtRejectedQty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // Qty
            // 
            this.Qty.AutoSize = true;
            this.Qty.Location = new System.Drawing.Point(340, 26);
            this.Qty.Name = "Qty";
            this.Qty.Size = new System.Drawing.Size(98, 13);
            this.Qty.TabIndex = 219;
            this.Qty.Text = "Rejected Quantity :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtInputQty);
            this.groupBox1.Controls.Add(this.txtOutputQty);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Qty);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtRejectedQty);
            this.groupBox1.Location = new System.Drawing.Point(12, 223);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(571, 54);
            this.groupBox1.TabIndex = 220;
            this.groupBox1.TabStop = false;
            // 
            // txtInputQty
            // 
            this.txtInputQty.Location = new System.Drawing.Point(95, 23);
            this.txtInputQty.Name = "txtInputQty";
            this.txtInputQty.Size = new System.Drawing.Size(42, 20);
            this.txtInputQty.TabIndex = 221;
            this.txtInputQty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtInputQty_KeyDown);
            // 
            // txtOutputQty
            // 
            this.txtOutputQty.Location = new System.Drawing.Point(264, 23);
            this.txtOutputQty.Name = "txtOutputQty";
            this.txtOutputQty.Size = new System.Drawing.Size(42, 20);
            this.txtOutputQty.TabIndex = 220;
            this.txtOutputQty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtOutputQty_KeyDown);
            // 
            // dgvMachineDetails
            // 
            this.dgvMachineDetails.AllowUserToAddRows = false;
            this.dgvMachineDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMachineDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMachineDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MachineRecID,
            this.MachineCode,
            this.Machine,
            this.From_Machine,
            this.To_Machine});
            this.dgvMachineDetails.Location = new System.Drawing.Point(12, 12);
            this.dgvMachineDetails.Name = "dgvMachineDetails";
            this.dgvMachineDetails.ReadOnly = true;
            this.dgvMachineDetails.Size = new System.Drawing.Size(571, 205);
            this.dgvMachineDetails.TabIndex = 221;
            // 
            // MachineRecID
            // 
            this.MachineRecID.DataPropertyName = "MachineRecID";
            this.MachineRecID.HeaderText = "MachineRecID";
            this.MachineRecID.Name = "MachineRecID";
            this.MachineRecID.ReadOnly = true;
            this.MachineRecID.Visible = false;
            // 
            // MachineCode
            // 
            this.MachineCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MachineCode.DataPropertyName = "MachineCode";
            this.MachineCode.HeaderText = "MachineCode";
            this.MachineCode.Name = "MachineCode";
            this.MachineCode.ReadOnly = true;
            this.MachineCode.Visible = false;
            // 
            // Machine
            // 
            this.Machine.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Machine.DataPropertyName = "MachineName";
            this.Machine.FillWeight = 150F;
            this.Machine.HeaderText = "Machine";
            this.Machine.Name = "Machine";
            this.Machine.ReadOnly = true;
            // 
            // From_Machine
            // 
            this.From_Machine.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.From_Machine.DataPropertyName = "MachineStart";
            this.From_Machine.HeaderText = "From";
            this.From_Machine.Name = "From_Machine";
            this.From_Machine.ReadOnly = true;
            // 
            // To_Machine
            // 
            this.To_Machine.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.To_Machine.DataPropertyName = "MachineStop";
            this.To_Machine.HeaderText = "To";
            this.To_Machine.Name = "To_Machine";
            this.To_Machine.ReadOnly = true;
            // 
            // frmBatchPacking_DamagedGoods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 286);
            this.Controls.Add(this.dgvMachineDetails);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmBatchPacking_DamagedGoods";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBatchPacking_DamagedGoods";
            this.Load += new System.EventHandler(this.frmBatchPacking_DamagedGoods_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceBatchMachine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMachineDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRejectedQty;
        private System.Windows.Forms.Label Qty;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource objSourceBatchMachine;
        private System.Windows.Forms.DataGridView dgvMachineDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn MachineRecID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MachineCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Machine;
        private System.Windows.Forms.DataGridViewTextBoxColumn From_Machine;
        private System.Windows.Forms.DataGridViewTextBoxColumn To_Machine;
        private System.Windows.Forms.TextBox txtInputQty;
        private System.Windows.Forms.TextBox txtOutputQty;
    }
}