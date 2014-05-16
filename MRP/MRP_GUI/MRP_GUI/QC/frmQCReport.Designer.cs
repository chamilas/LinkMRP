namespace MRP_GUI
{
    partial class frmQCReport
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
            this.btnSaveReport = new System.Windows.Forms.Button();
            this.btnSaveTest = new System.Windows.Forms.Button();
            this.gvTest = new System.Windows.Forms.DataGridView();
            this.ParameterID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Parameter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Acceptance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbTestBy = new System.Windows.Forms.ComboBox();
            this.cmbRDQAOfficer = new System.Windows.Forms.ComboBox();
            this.cmbParameter = new System.Windows.Forms.ComboBox();
            this.cmbAnalizedBy = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bindDetails = new System.Windows.Forms.BindingSource(this.components);
            this.txtBatch = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtReportID = new System.Windows.Forms.TextBox();
            this.txtSendBy = new System.Windows.Forms.TextBox();
            this.txtSendDate = new System.Windows.Forms.TextBox();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbReject = new System.Windows.Forms.RadioButton();
            this.rbAccept = new System.Windows.Forms.RadioButton();
            this.cbAccept = new System.Windows.Forms.CheckBox();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.dgvBatchList = new System.Windows.Forms.DataGridView();
            this.BatchID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.objSourceBatchList = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gvTest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindDetails)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBatchList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceBatchList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSaveReport
            // 
            this.btnSaveReport.Location = new System.Drawing.Point(93, 37);
            this.btnSaveReport.Name = "btnSaveReport";
            this.btnSaveReport.Size = new System.Drawing.Size(123, 34);
            this.btnSaveReport.TabIndex = 1;
            this.btnSaveReport.Text = "Save Report";
            this.btnSaveReport.UseVisualStyleBackColor = true;
            this.btnSaveReport.Click += new System.EventHandler(this.btnSaveReport_Click);
            // 
            // btnSaveTest
            // 
            this.btnSaveTest.Location = new System.Drawing.Point(883, 143);
            this.btnSaveTest.Name = "btnSaveTest";
            this.btnSaveTest.Size = new System.Drawing.Size(109, 30);
            this.btnSaveTest.TabIndex = 2;
            this.btnSaveTest.Text = "Save Test";
            this.btnSaveTest.UseVisualStyleBackColor = true;
            this.btnSaveTest.Click += new System.EventHandler(this.btnSaveTest_Click);
            // 
            // gvTest
            // 
            this.gvTest.AllowUserToAddRows = false;
            this.gvTest.AllowUserToDeleteRows = false;
            this.gvTest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvTest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvTest.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ParameterID,
            this.Parameter,
            this.Result,
            this.Acceptance});
            this.gvTest.Location = new System.Drawing.Point(192, 193);
            this.gvTest.Name = "gvTest";
            this.gvTest.ReadOnly = true;
            this.gvTest.Size = new System.Drawing.Size(800, 283);
            this.gvTest.TabIndex = 5;
            this.gvTest.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvTest_CellClick);
            // 
            // ParameterID
            // 
            this.ParameterID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ParameterID.DataPropertyName = "TestDetailsID";
            this.ParameterID.HeaderText = "ParameterID";
            this.ParameterID.Name = "ParameterID";
            this.ParameterID.ReadOnly = true;
            // 
            // Parameter
            // 
            this.Parameter.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Parameter.DataPropertyName = "Parameter";
            this.Parameter.HeaderText = "Parameter";
            this.Parameter.Name = "Parameter";
            this.Parameter.ReadOnly = true;
            // 
            // Result
            // 
            this.Result.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Result.DataPropertyName = "Result";
            this.Result.HeaderText = "Result";
            this.Result.Name = "Result";
            this.Result.ReadOnly = true;
            // 
            // Acceptance
            // 
            this.Acceptance.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Acceptance.DataPropertyName = "Acceptence";
            this.Acceptance.HeaderText = "Acceptance";
            this.Acceptance.Name = "Acceptance";
            this.Acceptance.ReadOnly = true;
            // 
            // cmbTestBy
            // 
            this.cmbTestBy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbTestBy.DisplayMember = "EmpName";
            this.cmbTestBy.FormattingEnabled = true;
            this.cmbTestBy.Location = new System.Drawing.Point(296, 510);
            this.cmbTestBy.Name = "cmbTestBy";
            this.cmbTestBy.Size = new System.Drawing.Size(458, 26);
            this.cmbTestBy.TabIndex = 6;
            this.cmbTestBy.ValueMember = "EmpID";
            // 
            // cmbRDQAOfficer
            // 
            this.cmbRDQAOfficer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbRDQAOfficer.DisplayMember = "EmpName";
            this.cmbRDQAOfficer.FormattingEnabled = true;
            this.cmbRDQAOfficer.Location = new System.Drawing.Point(296, 542);
            this.cmbRDQAOfficer.Name = "cmbRDQAOfficer";
            this.cmbRDQAOfficer.Size = new System.Drawing.Size(458, 26);
            this.cmbRDQAOfficer.TabIndex = 7;
            this.cmbRDQAOfficer.ValueMember = "EmpID";
            // 
            // cmbParameter
            // 
            this.cmbParameter.DisplayMember = "Parameter";
            this.cmbParameter.FormattingEnabled = true;
            this.cmbParameter.Location = new System.Drawing.Point(272, 113);
            this.cmbParameter.Name = "cmbParameter";
            this.cmbParameter.Size = new System.Drawing.Size(352, 26);
            this.cmbParameter.TabIndex = 8;
            this.cmbParameter.ValueMember = "ParameterID";
            // 
            // cmbAnalizedBy
            // 
            this.cmbAnalizedBy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbAnalizedBy.DisplayMember = "EmpName";
            this.cmbAnalizedBy.FormattingEnabled = true;
            this.cmbAnalizedBy.Location = new System.Drawing.Point(296, 574);
            this.cmbAnalizedBy.Name = "cmbAnalizedBy";
            this.cmbAnalizedBy.Size = new System.Drawing.Size(458, 26);
            this.cmbAnalizedBy.TabIndex = 9;
            this.cmbAnalizedBy.ValueMember = "EmpID";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(195, 518);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Test By";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 550);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "RDQAOfficer";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(195, 582);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "AnalizedBy";
            // 
            // txtBatch
            // 
            this.txtBatch.Location = new System.Drawing.Point(311, 15);
            this.txtBatch.Name = "txtBatch";
            this.txtBatch.ReadOnly = true;
            this.txtBatch.Size = new System.Drawing.Size(100, 24);
            this.txtBatch.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(189, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Batch ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(189, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Parameter";
            // 
            // txtReportID
            // 
            this.txtReportID.Location = new System.Drawing.Point(535, 15);
            this.txtReportID.Name = "txtReportID";
            this.txtReportID.ReadOnly = true;
            this.txtReportID.Size = new System.Drawing.Size(162, 24);
            this.txtReportID.TabIndex = 13;
            // 
            // txtSendBy
            // 
            this.txtSendBy.Location = new System.Drawing.Point(535, 55);
            this.txtSendBy.Name = "txtSendBy";
            this.txtSendBy.ReadOnly = true;
            this.txtSendBy.Size = new System.Drawing.Size(162, 24);
            this.txtSendBy.TabIndex = 13;
            // 
            // txtSendDate
            // 
            this.txtSendDate.Location = new System.Drawing.Point(311, 55);
            this.txtSendDate.Name = "txtSendDate";
            this.txtSendDate.ReadOnly = true;
            this.txtSendDate.Size = new System.Drawing.Size(100, 24);
            this.txtSendDate.TabIndex = 14;
            // 
            // txtRemarks
            // 
            this.txtRemarks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRemarks.Location = new System.Drawing.Point(790, 12);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.ReadOnly = true;
            this.txtRemarks.Size = new System.Drawing.Size(202, 67);
            this.txtRemarks.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.rbReject);
            this.panel1.Controls.Add(this.rbAccept);
            this.panel1.Controls.Add(this.btnSaveReport);
            this.panel1.Location = new System.Drawing.Point(768, 516);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(224, 84);
            this.panel1.TabIndex = 16;
            // 
            // rbReject
            // 
            this.rbReject.AutoSize = true;
            this.rbReject.Location = new System.Drawing.Point(6, 49);
            this.rbReject.Name = "rbReject";
            this.rbReject.Size = new System.Drawing.Size(68, 22);
            this.rbReject.TabIndex = 1;
            this.rbReject.TabStop = true;
            this.rbReject.Text = "Reject";
            this.rbReject.UseVisualStyleBackColor = true;
            // 
            // rbAccept
            // 
            this.rbAccept.AutoSize = true;
            this.rbAccept.Location = new System.Drawing.Point(6, 13);
            this.rbAccept.Name = "rbAccept";
            this.rbAccept.Size = new System.Drawing.Size(71, 22);
            this.rbAccept.TabIndex = 0;
            this.rbAccept.TabStop = true;
            this.rbAccept.Text = "Accept";
            this.rbAccept.UseVisualStyleBackColor = true;
            // 
            // cbAccept
            // 
            this.cbAccept.AutoSize = true;
            this.cbAccept.Location = new System.Drawing.Point(272, 156);
            this.cbAccept.Name = "cbAccept";
            this.cbAccept.Size = new System.Drawing.Size(72, 22);
            this.cbAccept.TabIndex = 17;
            this.cbAccept.Text = "Accept";
            this.cbAccept.UseVisualStyleBackColor = true;
            // 
            // txtComment
            // 
            this.txtComment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtComment.Location = new System.Drawing.Point(718, 113);
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(274, 24);
            this.txtComment.TabIndex = 18;
            // 
            // dgvBatchList
            // 
            this.dgvBatchList.AllowUserToAddRows = false;
            this.dgvBatchList.AllowUserToDeleteRows = false;
            this.dgvBatchList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvBatchList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBatchList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BatchID});
            this.dgvBatchList.Location = new System.Drawing.Point(12, 12);
            this.dgvBatchList.Name = "dgvBatchList";
            this.dgvBatchList.ReadOnly = true;
            this.dgvBatchList.Size = new System.Drawing.Size(171, 588);
            this.dgvBatchList.TabIndex = 24;
            this.dgvBatchList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBatchList_CellClick);
            // 
            // BatchID
            // 
            this.BatchID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BatchID.DataPropertyName = "BatchID";
            this.BatchID.HeaderText = "BatchID";
            this.BatchID.Name = "BatchID";
            this.BatchID.ReadOnly = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(429, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Report ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(429, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 18);
            this.label7.TabIndex = 10;
            this.label7.Text = "Requested By";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(715, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 18);
            this.label8.TabIndex = 10;
            this.label8.Text = "Remarks";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(189, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 18);
            this.label9.TabIndex = 10;
            this.label9.Text = "Requsted Date";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(216, 156);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 18);
            this.label10.TabIndex = 10;
            this.label10.Text = "Result";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(630, 119);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 18);
            this.label11.TabIndex = 10;
            this.label11.Text = "Comment";
            // 
            // frmQCReport
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1004, 612);
            this.Controls.Add(this.dgvBatchList);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.cbAccept);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.txtSendDate);
            this.Controls.Add(this.txtSendBy);
            this.Controls.Add(this.txtReportID);
            this.Controls.Add(this.txtBatch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbAnalizedBy);
            this.Controls.Add(this.cmbParameter);
            this.Controls.Add(this.cmbRDQAOfficer);
            this.Controls.Add(this.cmbTestBy);
            this.Controls.Add(this.gvTest);
            this.Controls.Add(this.btnSaveTest);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmQCReport";
            this.Text = "QCReport";
            this.Load += new System.EventHandler(this.frmQCReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvTest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindDetails)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBatchList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceBatchList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSaveReport;
        private System.Windows.Forms.Button btnSaveTest;
        private System.Windows.Forms.DataGridView gvTest;
        private System.Windows.Forms.ComboBox cmbTestBy;
        private System.Windows.Forms.ComboBox cmbRDQAOfficer;
        private System.Windows.Forms.ComboBox cmbParameter;
        private System.Windows.Forms.ComboBox cmbAnalizedBy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource bindDetails;
        private System.Windows.Forms.TextBox txtBatch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtReportID;
        private System.Windows.Forms.TextBox txtSendBy;
        private System.Windows.Forms.TextBox txtSendDate;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbReject;
        private System.Windows.Forms.RadioButton rbAccept;
        private System.Windows.Forms.CheckBox cbAccept;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.DataGridView dgvBatchList;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn BatchID;
        private System.Windows.Forms.BindingSource objSourceBatchList;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParameterID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Parameter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Result;
        private System.Windows.Forms.DataGridViewTextBoxColumn Acceptance;
    }
}