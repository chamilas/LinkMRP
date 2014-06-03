namespace MRP_GUI
{
    partial class frmQCReportHistory
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
            this.bsAcceptedReports = new System.Windows.Forms.BindingSource(this.components);
            this.bsRejectedReports = new System.Windows.Forms.BindingSource(this.components);
            this.dgvAcceptedReports = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvRejectedReports = new System.Windows.Forms.DataGridView();
            this.QCReportID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductionBatchID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FinishDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnalyzedByName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RDQAOfficerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TestByName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SendByName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SendDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SampleSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bsAcceptedReports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRejectedReports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAcceptedReports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRejectedReports)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAcceptedReports
            // 
            this.dgvAcceptedReports.AllowUserToAddRows = false;
            this.dgvAcceptedReports.AllowUserToDeleteRows = false;
            this.dgvAcceptedReports.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAcceptedReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAcceptedReports.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.QCReportID,
            this.ProductionBatchID,
            this.FinishDate,
            this.AnalyzedByName,
            this.RDQAOfficerName,
            this.TestByName,
            this.SendByName,
            this.SendDate,
            this.SampleSize,
            this.Remarks});
            this.dgvAcceptedReports.Location = new System.Drawing.Point(12, 25);
            this.dgvAcceptedReports.Name = "dgvAcceptedReports";
            this.dgvAcceptedReports.ReadOnly = true;
            this.dgvAcceptedReports.Size = new System.Drawing.Size(947, 298);
            this.dgvAcceptedReports.TabIndex = 112;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 114;
            this.label1.Text = "Accepted QCReports";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 326);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 115;
            this.label2.Text = "Rejected QCReports";
            // 
            // dgvRejectedReports
            // 
            this.dgvRejectedReports.AllowUserToAddRows = false;
            this.dgvRejectedReports.AllowUserToDeleteRows = false;
            this.dgvRejectedReports.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRejectedReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRejectedReports.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.dgvRejectedReports.Location = new System.Drawing.Point(12, 342);
            this.dgvRejectedReports.Name = "dgvRejectedReports";
            this.dgvRejectedReports.ReadOnly = true;
            this.dgvRejectedReports.Size = new System.Drawing.Size(947, 197);
            this.dgvRejectedReports.TabIndex = 116;
            // 
            // QCReportID
            // 
            this.QCReportID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.QCReportID.DataPropertyName = "QCReportID";
            this.QCReportID.HeaderText = "QCReportID";
            this.QCReportID.Name = "QCReportID";
            this.QCReportID.ReadOnly = true;
            // 
            // ProductionBatchID
            // 
            this.ProductionBatchID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductionBatchID.DataPropertyName = "ProductionBatchID";
            this.ProductionBatchID.HeaderText = "ProductionBatchID";
            this.ProductionBatchID.Name = "ProductionBatchID";
            this.ProductionBatchID.ReadOnly = true;
            // 
            // FinishDate
            // 
            this.FinishDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FinishDate.DataPropertyName = "FinishDate";
            this.FinishDate.HeaderText = "FinishDate";
            this.FinishDate.Name = "FinishDate";
            this.FinishDate.ReadOnly = true;
            // 
            // AnalyzedByName
            // 
            this.AnalyzedByName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AnalyzedByName.DataPropertyName = "AnalyzedByName";
            this.AnalyzedByName.HeaderText = "AnalyzedByName";
            this.AnalyzedByName.Name = "AnalyzedByName";
            this.AnalyzedByName.ReadOnly = true;
            this.AnalyzedByName.Visible = false;
            // 
            // RDQAOfficerName
            // 
            this.RDQAOfficerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RDQAOfficerName.DataPropertyName = "RDQAOfficerName";
            this.RDQAOfficerName.HeaderText = "RDQAOfficerName";
            this.RDQAOfficerName.Name = "RDQAOfficerName";
            this.RDQAOfficerName.ReadOnly = true;
            this.RDQAOfficerName.Visible = false;
            // 
            // TestByName
            // 
            this.TestByName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TestByName.DataPropertyName = "TestByName";
            this.TestByName.HeaderText = "TestByName";
            this.TestByName.Name = "TestByName";
            this.TestByName.ReadOnly = true;
            this.TestByName.Visible = false;
            // 
            // SendByName
            // 
            this.SendByName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SendByName.DataPropertyName = "SendByName";
            this.SendByName.HeaderText = "SendByName";
            this.SendByName.Name = "SendByName";
            this.SendByName.ReadOnly = true;
            // 
            // SendDate
            // 
            this.SendDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SendDate.DataPropertyName = "SendDate";
            this.SendDate.HeaderText = "SendDate";
            this.SendDate.Name = "SendDate";
            this.SendDate.ReadOnly = true;
            // 
            // SampleSize
            // 
            this.SampleSize.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SampleSize.DataPropertyName = "SampleSize";
            this.SampleSize.HeaderText = "SampleSize";
            this.SampleSize.Name = "SampleSize";
            this.SampleSize.ReadOnly = true;
            this.SampleSize.Visible = false;
            // 
            // Remarks
            // 
            this.Remarks.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Remarks.DataPropertyName = "Remarks";
            this.Remarks.HeaderText = "Remarks";
            this.Remarks.Name = "Remarks";
            this.Remarks.ReadOnly = true;
            this.Remarks.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "QCReportID";
            this.dataGridViewTextBoxColumn1.HeaderText = "QCReportID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ProductionBatchID";
            this.dataGridViewTextBoxColumn2.HeaderText = "ProductionBatchID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "FinishDate";
            this.dataGridViewTextBoxColumn3.HeaderText = "FinishDate";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "AnalyzedByName";
            this.dataGridViewTextBoxColumn4.HeaderText = "AnalyzedByName";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "RDQAOfficerName";
            this.dataGridViewTextBoxColumn5.HeaderText = "RDQAOfficerName";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "TestByName";
            this.dataGridViewTextBoxColumn6.HeaderText = "TestByName";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "SendByName";
            this.dataGridViewTextBoxColumn7.HeaderText = "SendByName";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn8.DataPropertyName = "SendDate";
            this.dataGridViewTextBoxColumn8.HeaderText = "SendDate";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn9.DataPropertyName = "SampleSize";
            this.dataGridViewTextBoxColumn9.HeaderText = "SampleSize";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Visible = false;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Remarks";
            this.dataGridViewTextBoxColumn10.HeaderText = "Remarks";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Visible = false;
            // 
            // frmQCReportHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 551);
            this.Controls.Add(this.dgvRejectedReports);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvAcceptedReports);
            this.Name = "frmQCReportHistory";
            this.Text = "frmQCReportHistory";
            this.Load += new System.EventHandler(this.frmQCReportHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsAcceptedReports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRejectedReports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAcceptedReports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRejectedReports)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bsAcceptedReports;
        private System.Windows.Forms.BindingSource bsRejectedReports;
        private System.Windows.Forms.DataGridView dgvAcceptedReports;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvRejectedReports;
        private System.Windows.Forms.DataGridViewTextBoxColumn QCReportID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductionBatchID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FinishDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnalyzedByName;
        private System.Windows.Forms.DataGridViewTextBoxColumn RDQAOfficerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TestByName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SendByName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SendDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn SampleSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remarks;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
    }
}