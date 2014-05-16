namespace MRP_GUI.PRPD
{
    partial class frmPRPDCostingApprove
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnExit = new System.Windows.Forms.Button();
            this.dgvPRPDbatchByState = new System.Windows.Forms.DataGridView();
            this.PRPDBatchID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Material = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRPDBatchQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FinalQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Superviser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DryerRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindPRPD = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnApprove = new System.Windows.Forms.Button();
            this.txtDryerRate = new System.Windows.Forms.TextBox();
            this.btnUpdateDryerRate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPRPDbatchByState)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindPRPD)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Location = new System.Drawing.Point(850, 481);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 40;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dgvPRPDbatchByState
            // 
            this.dgvPRPDbatchByState.AllowUserToAddRows = false;
            this.dgvPRPDbatchByState.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvPRPDbatchByState.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPRPDbatchByState.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPRPDbatchByState.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPRPDbatchByState.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PRPDBatchID,
            this.Material,
            this.PRPDBatchQty,
            this.FinalQty,
            this.UnitCode,
            this.Superviser,
            this.DryerRate});
            this.dgvPRPDbatchByState.Location = new System.Drawing.Point(12, 51);
            this.dgvPRPDbatchByState.Name = "dgvPRPDbatchByState";
            this.dgvPRPDbatchByState.ReadOnly = true;
            this.dgvPRPDbatchByState.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPRPDbatchByState.RowTemplate.Height = 30;
            this.dgvPRPDbatchByState.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPRPDbatchByState.Size = new System.Drawing.Size(910, 417);
            this.dgvPRPDbatchByState.TabIndex = 39;
            this.dgvPRPDbatchByState.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPRPDbatchByState_CellClick);
            this.dgvPRPDbatchByState.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPRPDbatchByState_CellDoubleClick);
            // 
            // PRPDBatchID
            // 
            this.PRPDBatchID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PRPDBatchID.DataPropertyName = "PRPDBatchID";
            this.PRPDBatchID.HeaderText = "PRPDBatchID";
            this.PRPDBatchID.Name = "PRPDBatchID";
            this.PRPDBatchID.ReadOnly = true;
            // 
            // Material
            // 
            this.Material.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Material.DataPropertyName = "Material";
            this.Material.FillWeight = 150F;
            this.Material.HeaderText = "Material";
            this.Material.Name = "Material";
            this.Material.ReadOnly = true;
            // 
            // PRPDBatchQty
            // 
            this.PRPDBatchQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PRPDBatchQty.DataPropertyName = "PRPDBatchQty";
            this.PRPDBatchQty.FillWeight = 75F;
            this.PRPDBatchQty.HeaderText = "PRPDBatchQty";
            this.PRPDBatchQty.Name = "PRPDBatchQty";
            this.PRPDBatchQty.ReadOnly = true;
            // 
            // FinalQty
            // 
            this.FinalQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FinalQty.DataPropertyName = "FinalQty";
            this.FinalQty.FillWeight = 75F;
            this.FinalQty.HeaderText = "FinalQty";
            this.FinalQty.Name = "FinalQty";
            this.FinalQty.ReadOnly = true;
            // 
            // UnitCode
            // 
            this.UnitCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UnitCode.DataPropertyName = "UnitCode";
            this.UnitCode.FillWeight = 30F;
            this.UnitCode.HeaderText = "UnitCode";
            this.UnitCode.Name = "UnitCode";
            this.UnitCode.ReadOnly = true;
            // 
            // Superviser
            // 
            this.Superviser.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Superviser.DataPropertyName = "Superviser";
            this.Superviser.HeaderText = "Superviser";
            this.Superviser.Name = "Superviser";
            this.Superviser.ReadOnly = true;
            // 
            // DryerRate
            // 
            this.DryerRate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DryerRate.DataPropertyName = "DryerRate";
            this.DryerRate.HeaderText = "DryerRate";
            this.DryerRate.Name = "DryerRate";
            this.DryerRate.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Batch Files";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 15);
            this.label1.TabIndex = 35;
            this.label1.Text = "PRPD Batch Files";
            // 
            // btnApprove
            // 
            this.btnApprove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApprove.Location = new System.Drawing.Point(769, 481);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(75, 23);
            this.btnApprove.TabIndex = 41;
            this.btnApprove.Text = "Approve";
            this.btnApprove.UseVisualStyleBackColor = true;
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);
            // 
            // txtDryerRate
            // 
            this.txtDryerRate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDryerRate.Location = new System.Drawing.Point(670, 25);
            this.txtDryerRate.Name = "txtDryerRate";
            this.txtDryerRate.Size = new System.Drawing.Size(100, 20);
            this.txtDryerRate.TabIndex = 42;
            // 
            // btnUpdateDryerRate
            // 
            this.btnUpdateDryerRate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateDryerRate.Location = new System.Drawing.Point(776, 25);
            this.btnUpdateDryerRate.Name = "btnUpdateDryerRate";
            this.btnUpdateDryerRate.Size = new System.Drawing.Size(149, 23);
            this.btnUpdateDryerRate.TabIndex = 43;
            this.btnUpdateDryerRate.Text = "Update Dryer Rate";
            this.btnUpdateDryerRate.UseVisualStyleBackColor = true;
            this.btnUpdateDryerRate.Click += new System.EventHandler(this.btnUpdateDryerRate_Click);
            // 
            // frmPRPDCostingApprove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 514);
            this.Controls.Add(this.btnUpdateDryerRate);
            this.Controls.Add(this.txtDryerRate);
            this.Controls.Add(this.btnApprove);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.dgvPRPDbatchByState);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "frmPRPDCostingApprove";
            this.Text = "PRPD - Costing Approve";
            this.Load += new System.EventHandler(this.frmPRPDCostingApprove_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPRPDbatchByState)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindPRPD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView dgvPRPDbatchByState;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPRPDBatchID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaterialName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn BatchQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn MRNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRPDBatchInstructedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRPDBatchMaterialCode;
        private System.Windows.Forms.BindingSource bindPRPD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.TextBox txtDryerRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRPDBatchID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Material;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRPDBatchQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn FinalQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Superviser;
        private System.Windows.Forms.DataGridViewTextBoxColumn DryerRate;
        private System.Windows.Forms.Button btnUpdateDryerRate;
    }
}