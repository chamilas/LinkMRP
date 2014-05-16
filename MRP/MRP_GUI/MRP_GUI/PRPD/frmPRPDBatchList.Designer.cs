namespace MRP_GUI.PRPD
{
    partial class frmPRPDBatchList
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
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPRPDbatchByState = new System.Windows.Forms.DataGridView();
            this.PRPDBatchID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Material = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MRNO_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BatchSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FinalQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.bindPRPD = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPRPDbatchByState)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindPRPD)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbStatus
            // 
            this.cmbStatus.DisplayMember = "PRPDBatchStatus";
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(104, 41);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(121, 21);
            this.cmbStatus.TabIndex = 5;
            this.cmbStatus.SelectedIndexChanged += new System.EventHandler(this.cmbStatus_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Status";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "PRPD Batch Files";
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
            this.MRNO_,
            this.BatchSize,
            this.FinalQty,
            this.Unit});
            this.dgvPRPDbatchByState.Location = new System.Drawing.Point(9, 84);
            this.dgvPRPDbatchByState.Name = "dgvPRPDbatchByState";
            this.dgvPRPDbatchByState.ReadOnly = true;
            this.dgvPRPDbatchByState.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPRPDbatchByState.RowTemplate.Height = 30;
            this.dgvPRPDbatchByState.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPRPDbatchByState.Size = new System.Drawing.Size(910, 382);
            this.dgvPRPDbatchByState.TabIndex = 33;
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
            this.Material.FillWeight = 200F;
            this.Material.HeaderText = "Material";
            this.Material.Name = "Material";
            this.Material.ReadOnly = true;
            // 
            // MRNO_
            // 
            this.MRNO_.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MRNO_.DataPropertyName = "MRIN";
            this.MRNO_.FillWeight = 70F;
            this.MRNO_.HeaderText = "MRNO";
            this.MRNO_.Name = "MRNO_";
            this.MRNO_.ReadOnly = true;
            // 
            // BatchSize
            // 
            this.BatchSize.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BatchSize.DataPropertyName = "PRPDBatchQty";
            this.BatchSize.FillWeight = 70F;
            this.BatchSize.HeaderText = "BatchSize";
            this.BatchSize.Name = "BatchSize";
            this.BatchSize.ReadOnly = true;
            // 
            // FinalQty
            // 
            this.FinalQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FinalQty.DataPropertyName = "FinalQty";
            this.FinalQty.FillWeight = 70F;
            this.FinalQty.HeaderText = "FinalQty";
            this.FinalQty.Name = "FinalQty";
            this.FinalQty.ReadOnly = true;
            // 
            // Unit
            // 
            this.Unit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Unit.DataPropertyName = "UnitCode";
            this.Unit.FillWeight = 30F;
            this.Unit.HeaderText = "Unit";
            this.Unit.Name = "Unit";
            this.Unit.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Batch Files";
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Location = new System.Drawing.Point(847, 479);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 34;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmPRPDBatchList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 514);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.dgvPRPDbatchByState);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmPRPDBatchList";
            this.Text = "PRPD Batch List";
            this.Load += new System.EventHandler(this.frmPRPDBatchList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPRPDbatchByState)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindPRPD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRPDBatchID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Material;
        private System.Windows.Forms.DataGridViewTextBoxColumn MRNO_;
        private System.Windows.Forms.DataGridViewTextBoxColumn BatchSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn FinalQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
    }
}