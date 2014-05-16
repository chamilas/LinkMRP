namespace MRP_GUI.RPD
{
    partial class frmRPDBatchList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gvRPDBatch = new System.Windows.Forms.DataGridView();
            this.btnExit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.bindRPDBatch = new System.Windows.Forms.BindingSource(this.components);
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RPDBatchID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Material = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BatchSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MRIssuedQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FinalQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MRUnitRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gvRPDBatch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindRPDBatch)).BeginInit();
            this.SuspendLayout();
            // 
            // gvRPDBatch
            // 
            this.gvRPDBatch.AllowUserToAddRows = false;
            this.gvRPDBatch.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gvRPDBatch.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gvRPDBatch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvRPDBatch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvRPDBatch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Type,
            this.RPDBatchID,
            this.Material,
            this.StartDate,
            this.EndDate,
            this.BatchSize,
            this.MRIssuedQty,
            this.FinalQty,
            this.Unit,
            this.MRUnitRate});
            this.gvRPDBatch.Location = new System.Drawing.Point(12, 83);
            this.gvRPDBatch.Name = "gvRPDBatch";
            this.gvRPDBatch.ReadOnly = true;
            this.gvRPDBatch.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvRPDBatch.RowTemplate.Height = 30;
            this.gvRPDBatch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvRPDBatch.Size = new System.Drawing.Size(980, 398);
            this.gvRPDBatch.TabIndex = 8;
            this.gvRPDBatch.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvRPDBatch_CellDoubleClick);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Location = new System.Drawing.Point(917, 487);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Finished Batch List";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "RPD Batch Files";
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(73, 36);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(209, 23);
            this.cmbStatus.TabIndex = 33;
            this.cmbStatus.SelectedIndexChanged += new System.EventHandler(this.cmbStatus_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(20, 39);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(47, 15);
            this.label15.TabIndex = 32;
            this.label15.Text = "Status";
            // 
            // Type
            // 
            this.Type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Type.DataPropertyName = "RPDBatchType";
            this.Type.FillWeight = 50F;
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            // 
            // RPDBatchID
            // 
            this.RPDBatchID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RPDBatchID.DataPropertyName = "RPDBatchID";
            this.RPDBatchID.HeaderText = "RPDBatchID";
            this.RPDBatchID.Name = "RPDBatchID";
            this.RPDBatchID.ReadOnly = true;
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
            // StartDate
            // 
            this.StartDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StartDate.DataPropertyName = "RPDBatchStartDate";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.StartDate.DefaultCellStyle = dataGridViewCellStyle2;
            this.StartDate.FillWeight = 70F;
            this.StartDate.HeaderText = "StartDate";
            this.StartDate.Name = "StartDate";
            this.StartDate.ReadOnly = true;
            // 
            // EndDate
            // 
            this.EndDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EndDate.DataPropertyName = "RPDBatchEndDate";
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.EndDate.DefaultCellStyle = dataGridViewCellStyle3;
            this.EndDate.FillWeight = 70F;
            this.EndDate.HeaderText = "EndDate";
            this.EndDate.Name = "EndDate";
            this.EndDate.ReadOnly = true;
            // 
            // BatchSize
            // 
            this.BatchSize.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BatchSize.DataPropertyName = "RPDBatchQty";
            this.BatchSize.FillWeight = 70F;
            this.BatchSize.HeaderText = "BatchSize";
            this.BatchSize.Name = "BatchSize";
            this.BatchSize.ReadOnly = true;
            // 
            // MRIssuedQty
            // 
            this.MRIssuedQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MRIssuedQty.DataPropertyName = "MRIssuedQty";
            this.MRIssuedQty.FillWeight = 70F;
            this.MRIssuedQty.HeaderText = "MRIssuedQty";
            this.MRIssuedQty.Name = "MRIssuedQty";
            this.MRIssuedQty.ReadOnly = true;
            // 
            // FinalQty
            // 
            this.FinalQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FinalQty.DataPropertyName = "RPDBatchFinalQty";
            this.FinalQty.FillWeight = 70F;
            this.FinalQty.HeaderText = "FinalQty";
            this.FinalQty.Name = "FinalQty";
            this.FinalQty.ReadOnly = true;
            // 
            // Unit
            // 
            this.Unit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Unit.DataPropertyName = "UnitCode";
            this.Unit.FillWeight = 50F;
            this.Unit.HeaderText = "Unit";
            this.Unit.Name = "Unit";
            this.Unit.ReadOnly = true;
            // 
            // MRUnitRate
            // 
            this.MRUnitRate.DataPropertyName = "MRUnitRate";
            this.MRUnitRate.HeaderText = "MR Unit Rate";
            this.MRUnitRate.Name = "MRUnitRate";
            this.MRUnitRate.ReadOnly = true;
            // 
            // frmRPDBatchList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 512);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.gvRPDBatch);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmRPDBatchList";
            this.Text = "RPD Batch Files";
            this.Load += new System.EventHandler(this.frmRPDBatchList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvRPDBatch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindRPDBatch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvRPDBatch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRPDBatchID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.BindingSource bindRPDBatch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn RPDBatchID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Material;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn BatchSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn MRIssuedQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn FinalQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn MRUnitRate;
    }
}