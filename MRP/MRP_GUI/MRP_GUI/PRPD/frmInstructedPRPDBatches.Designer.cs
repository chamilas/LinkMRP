namespace MRP_GUI.PRPD
{
    partial class frmInstructedPRPDBatches
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInstructedPRPDBatches));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvPRPDbatchByState = new System.Windows.Forms.DataGridView();
            this.colPRPDBatchID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaterialName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BatchQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MRNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRPDBatchInstructedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRPDBatchMaterialCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindPRPD = new System.Windows.Forms.BindingSource(this.components);
            this.btnExit = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.v = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPRPDbatchByState)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindPRPD)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Instructed PRPD Batch Files";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Status";
            // 
            // cmbStatus
            // 
            this.cmbStatus.DisplayMember = "PRPDBatchStatus";
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(104, 41);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(121, 21);
            this.cmbStatus.TabIndex = 2;
            this.cmbStatus.SelectedIndexChanged += new System.EventHandler(this.cmbStatus_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Batch Files";
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
            this.dgvPRPDbatchByState.AutoGenerateColumns = false;
            this.dgvPRPDbatchByState.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPRPDbatchByState.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPRPDBatchID,
            this.MaterialName,
            this.Column1,
            this.BatchQty,
            this.MRNO,
            this.PRPDBatchInstructedBy,
            this.PRPDBatchMaterialCode});
            this.dgvPRPDbatchByState.DataSource = this.bindPRPD;
            this.dgvPRPDbatchByState.Location = new System.Drawing.Point(12, 90);
            this.dgvPRPDbatchByState.Name = "dgvPRPDbatchByState";
            this.dgvPRPDbatchByState.ReadOnly = true;
            this.dgvPRPDbatchByState.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPRPDbatchByState.RowTemplate.Height = 30;
            this.dgvPRPDbatchByState.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPRPDbatchByState.Size = new System.Drawing.Size(910, 382);
            this.dgvPRPDbatchByState.TabIndex = 31;
            this.dgvPRPDbatchByState.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPRPDbatchByState_CellDoubleClick);
            // 
            // colPRPDBatchID
            // 
            this.colPRPDBatchID.DataPropertyName = "PRPDBatchID";
            this.colPRPDBatchID.FillWeight = 25.77319F;
            this.colPRPDBatchID.HeaderText = "PRPDBatchID";
            this.colPRPDBatchID.MinimumWidth = 150;
            this.colPRPDBatchID.Name = "colPRPDBatchID";
            this.colPRPDBatchID.ReadOnly = true;
            this.colPRPDBatchID.Width = 150;
            // 
            // MaterialName
            // 
            this.MaterialName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaterialName.DataPropertyName = "Material";
            this.MaterialName.HeaderText = "Material Name";
            this.MaterialName.MinimumWidth = 200;
            this.MaterialName.Name = "MaterialName";
            this.MaterialName.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "UnitCode";
            this.Column1.HeaderText = "Unit";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // BatchQty
            // 
            this.BatchQty.DataPropertyName = "PRPDBatchQty";
            this.BatchQty.FillWeight = 25.77319F;
            this.BatchQty.HeaderText = "Quantity";
            this.BatchQty.Name = "BatchQty";
            this.BatchQty.ReadOnly = true;
            // 
            // MRNO
            // 
            this.MRNO.DataPropertyName = "MRIN";
            this.MRNO.FillWeight = 25.77319F;
            this.MRNO.HeaderText = "MRNO";
            this.MRNO.Name = "MRNO";
            this.MRNO.ReadOnly = true;
            this.MRNO.Width = 75;
            // 
            // PRPDBatchInstructedBy
            // 
            this.PRPDBatchInstructedBy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PRPDBatchInstructedBy.DataPropertyName = "InspetedByName";
            this.PRPDBatchInstructedBy.HeaderText = "Instructed By";
            this.PRPDBatchInstructedBy.MinimumWidth = 200;
            this.PRPDBatchInstructedBy.Name = "PRPDBatchInstructedBy";
            this.PRPDBatchInstructedBy.ReadOnly = true;
            // 
            // PRPDBatchMaterialCode
            // 
            this.PRPDBatchMaterialCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PRPDBatchMaterialCode.DataPropertyName = "PRPDBatchMaterialCode";
            this.PRPDBatchMaterialCode.HeaderText = "PRPDBatchMaterialCode";
            this.PRPDBatchMaterialCode.Name = "PRPDBatchMaterialCode";
            this.PRPDBatchMaterialCode.ReadOnly = true;
            this.PRPDBatchMaterialCode.Visible = false;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Location = new System.Drawing.Point(847, 479);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 32;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PRPDBatchID";
            this.dataGridViewTextBoxColumn1.FillWeight = 25.77319F;
            this.dataGridViewTextBoxColumn1.HeaderText = "PRPDBatchID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 150;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Material";
            this.dataGridViewTextBoxColumn2.HeaderText = "Material Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 200;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "UnitCode";
            this.dataGridViewTextBoxColumn3.HeaderText = "Unit";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "PRPDBatchQty";
            this.dataGridViewTextBoxColumn4.FillWeight = 25.77319F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "MRIN";
            this.dataGridViewTextBoxColumn5.FillWeight = 25.77319F;
            this.dataGridViewTextBoxColumn5.HeaderText = "MRNO";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 75;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "InspetedByName";
            this.dataGridViewTextBoxColumn6.HeaderText = "Instructed By";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 200;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "PRPDBatchMaterialCode";
            this.dataGridViewTextBoxColumn7.HeaderText = "PRPDBatchMaterialCode";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // dtFrom
            // 
            this.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFrom.Location = new System.Drawing.Point(367, 16);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(94, 20);
            this.dtFrom.TabIndex = 33;
            this.dtFrom.ValueChanged += new System.EventHandler(this.dtFrom_ValueChanged);
            // 
            // dtTo
            // 
            this.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTo.Location = new System.Drawing.Point(367, 45);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(94, 20);
            this.dtTo.TabIndex = 34;
            this.dtTo.ValueChanged += new System.EventHandler(this.dtTo_ValueChanged);
            // 
            // v
            // 
            this.v.AutoSize = true;
            this.v.Location = new System.Drawing.Point(331, 19);
            this.v.Name = "v";
            this.v.Size = new System.Drawing.Size(30, 13);
            this.v.TabIndex = 35;
            this.v.Text = "From";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(341, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "To";
            // 
            // frmInstructedPRPDBatches
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 514);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.v);
            this.Controls.Add(this.dtTo);
            this.Controls.Add(this.dtFrom);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.dgvPRPDbatchByState);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInstructedPRPDBatches";
            this.Text = "Instructed PRPD Batch Files";
            this.Load += new System.EventHandler(this.frmInstructedPRPDBatches_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPRPDbatchByState)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindPRPD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvPRPDbatchByState;
        private System.Windows.Forms.BindingSource bindPRPD;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPRPDBatchID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaterialName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn BatchQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn MRNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRPDBatchInstructedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRPDBatchMaterialCode;
        private System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.Label v;
        private System.Windows.Forms.Label label4;
    }
}