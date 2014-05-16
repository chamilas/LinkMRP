namespace MRP_GUI.RPD
{
    partial class frmRPDCostApprove
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bindRPD = new System.Windows.Forms.BindingSource(this.components);
            this.btnExit = new System.Windows.Forms.Button();
            this.gvRPDBatch = new System.Windows.Forms.DataGridView();
            this.btnApprove = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.RPDBatchID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Material = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DryerRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDryerRate = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindRPD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvRPDBatch)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "RPD Cost Approve";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Finished Batch List";
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Location = new System.Drawing.Point(847, 429);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
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
            this.RPDBatchID,
            this.Material,
            this.Quantity,
            this.StartDate,
            this.EndDate,
            this.DryerRate});
            this.gvRPDBatch.Location = new System.Drawing.Point(12, 56);
            this.gvRPDBatch.Name = "gvRPDBatch";
            this.gvRPDBatch.ReadOnly = true;
            this.gvRPDBatch.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvRPDBatch.RowTemplate.Height = 30;
            this.gvRPDBatch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvRPDBatch.Size = new System.Drawing.Size(910, 367);
            this.gvRPDBatch.TabIndex = 4;
            this.gvRPDBatch.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvRPDBatch_CellClick);
            this.gvRPDBatch.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvRPDBatch_CellDoubleClick);
            // 
            // btnApprove
            // 
            this.btnApprove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApprove.Location = new System.Drawing.Point(766, 429);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(75, 23);
            this.btnApprove.TabIndex = 5;
            this.btnApprove.Text = "Approve";
            this.btnApprove.UseVisualStyleBackColor = true;
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.Location = new System.Drawing.Point(801, 27);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(121, 23);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update Dryer Rate";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
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
            // Quantity
            // 
            this.Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Quantity.DataPropertyName = "RPDBatchQty";
            this.Quantity.FillWeight = 70F;
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // StartDate
            // 
            this.StartDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StartDate.DataPropertyName = "RPDBatchStartDate";
            this.StartDate.FillWeight = 70F;
            this.StartDate.HeaderText = "StartDate";
            this.StartDate.Name = "StartDate";
            this.StartDate.ReadOnly = true;
            // 
            // EndDate
            // 
            this.EndDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EndDate.DataPropertyName = "RPDBatchEndDate";
            this.EndDate.FillWeight = 70F;
            this.EndDate.HeaderText = "EndDate";
            this.EndDate.Name = "EndDate";
            this.EndDate.ReadOnly = true;
            // 
            // DryerRate
            // 
            this.DryerRate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DryerRate.DataPropertyName = "DryerRate";
            this.DryerRate.FillWeight = 70F;
            this.DryerRate.HeaderText = "DryerRate";
            this.DryerRate.Name = "DryerRate";
            this.DryerRate.ReadOnly = true;
            // 
            // txtDryerRate
            // 
            this.txtDryerRate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDryerRate.Location = new System.Drawing.Point(695, 29);
            this.txtDryerRate.Name = "txtDryerRate";
            this.txtDryerRate.Size = new System.Drawing.Size(100, 20);
            this.txtDryerRate.TabIndex = 7;
            // 
            // frmRPDCostApprove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 464);
            this.Controls.Add(this.txtDryerRate);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnApprove);
            this.Controls.Add(this.gvRPDBatch);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmRPDCostApprove";
            this.Text = "RPD Cost Approve";
            this.Load += new System.EventHandler(this.frmRPDCostApprove_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindRPD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvRPDBatch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource bindRPD;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView gvRPDBatch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRPDBatchID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn RPDBatchID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Material;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn DryerRate;
        private System.Windows.Forms.TextBox txtDryerRate;
    }
}