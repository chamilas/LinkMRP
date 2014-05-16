namespace MRP_GUI
{
    partial class frmQCDetailView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQCDetailView));
            this.txtSampleSize = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtSendDate = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSendBy = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBatch = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtReportType = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtReportID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gvTest = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colTestDetailsID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindDetails = new System.Windows.Forms.BindingSource(this.components);
            this.txtAnalyzedBy = new System.Windows.Forms.TextBox();
            this.txtRDQAOfficer = new System.Windows.Forms.TextBox();
            this.txtTestBy = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvTest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSampleSize
            // 
            this.txtSampleSize.Location = new System.Drawing.Point(585, 78);
            this.txtSampleSize.Name = "txtSampleSize";
            this.txtSampleSize.ReadOnly = true;
            this.txtSampleSize.Size = new System.Drawing.Size(100, 20);
            this.txtSampleSize.TabIndex = 45;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(508, 81);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 13);
            this.label16.TabIndex = 44;
            this.label16.Text = "Sample Size";
            // 
            // txtSendDate
            // 
            this.txtSendDate.Location = new System.Drawing.Point(585, 56);
            this.txtSendDate.Name = "txtSendDate";
            this.txtSendDate.ReadOnly = true;
            this.txtSendDate.Size = new System.Drawing.Size(100, 20);
            this.txtSendDate.TabIndex = 43;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(515, 59);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 42;
            this.label10.Text = "Send Date";
            // 
            // txtSendBy
            // 
            this.txtSendBy.Location = new System.Drawing.Point(585, 34);
            this.txtSendBy.Name = "txtSendBy";
            this.txtSendBy.ReadOnly = true;
            this.txtSendBy.Size = new System.Drawing.Size(324, 20);
            this.txtSendBy.TabIndex = 41;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(526, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 40;
            this.label9.Text = "Send By";
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(85, 170);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRemarks.Size = new System.Drawing.Size(404, 86);
            this.txtRemarks.TabIndex = 39;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 173);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 38;
            this.label8.Text = "Remarks";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "Test By";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "RDQAOfficer";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Analyzed By";
            // 
            // txtBatch
            // 
            this.txtBatch.Location = new System.Drawing.Point(85, 78);
            this.txtBatch.Name = "txtBatch";
            this.txtBatch.ReadOnly = true;
            this.txtBatch.Size = new System.Drawing.Size(324, 20);
            this.txtBatch.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Batch";
            // 
            // txtReportType
            // 
            this.txtReportType.Location = new System.Drawing.Point(85, 56);
            this.txtReportType.Name = "txtReportType";
            this.txtReportType.ReadOnly = true;
            this.txtReportType.Size = new System.Drawing.Size(100, 20);
            this.txtReportType.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Type";
            // 
            // txtReportID
            // 
            this.txtReportID.Location = new System.Drawing.Point(85, 34);
            this.txtReportID.Name = "txtReportID";
            this.txtReportID.ReadOnly = true;
            this.txtReportID.Size = new System.Drawing.Size(100, 20);
            this.txtReportID.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Report ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Quality Inspection Report";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.gvTest);
            this.groupBox1.Location = new System.Drawing.Point(3, 262);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(919, 273);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quality Tests";
            // 
            // gvTest
            // 
            this.gvTest.AllowUserToAddRows = false;
            this.gvTest.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gvTest.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gvTest.AutoGenerateColumns = false;
            this.gvTest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvTest.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.colTestDetailsID,
            this.Column1,
            this.Column3,
            this.Column4,
            this.Column5});
            this.gvTest.DataSource = this.bindDetails;
            this.gvTest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvTest.Location = new System.Drawing.Point(3, 16);
            this.gvTest.Name = "gvTest";
            this.gvTest.ReadOnly = true;
            this.gvTest.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvTest.RowTemplate.Height = 20;
            this.gvTest.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvTest.Size = new System.Drawing.Size(913, 254);
            this.gvTest.TabIndex = 33;
            this.gvTest.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvTest_CellContentClick);
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Acceptence";
            this.Column6.Frozen = true;
            this.Column6.HeaderText = "Acceptence";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colTestDetailsID
            // 
            this.colTestDetailsID.DataPropertyName = "TestDetailsID";
            this.colTestDetailsID.Frozen = true;
            this.colTestDetailsID.HeaderText = "TestDetailsID";
            this.colTestDetailsID.Name = "colTestDetailsID";
            this.colTestDetailsID.ReadOnly = true;
            this.colTestDetailsID.Visible = false;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Parameter";
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "Parameter";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "MaterialCode";
            this.Column3.HeaderText = "Material";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Result";
            this.Column4.HeaderText = "Result";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Comment";
            this.Column5.HeaderText = "Comment";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 300;
            // 
            // txtAnalyzedBy
            // 
            this.txtAnalyzedBy.Location = new System.Drawing.Point(85, 100);
            this.txtAnalyzedBy.Name = "txtAnalyzedBy";
            this.txtAnalyzedBy.ReadOnly = true;
            this.txtAnalyzedBy.Size = new System.Drawing.Size(324, 20);
            this.txtAnalyzedBy.TabIndex = 48;
            // 
            // txtRDQAOfficer
            // 
            this.txtRDQAOfficer.Location = new System.Drawing.Point(85, 123);
            this.txtRDQAOfficer.Name = "txtRDQAOfficer";
            this.txtRDQAOfficer.ReadOnly = true;
            this.txtRDQAOfficer.Size = new System.Drawing.Size(324, 20);
            this.txtRDQAOfficer.TabIndex = 49;
            // 
            // txtTestBy
            // 
            this.txtTestBy.Location = new System.Drawing.Point(85, 146);
            this.txtTestBy.Name = "txtTestBy";
            this.txtTestBy.ReadOnly = true;
            this.txtTestBy.Size = new System.Drawing.Size(324, 20);
            this.txtTestBy.TabIndex = 50;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(847, 537);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 51;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(536, 107);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 13);
            this.label11.TabIndex = 52;
            this.label11.Text = "Status";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(582, 107);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(49, 13);
            this.lblStatus.TabIndex = 53;
            this.lblStatus.Text = "[status]";
            // 
            // frmQCDetailView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 564);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtTestBy);
            this.Controls.Add(this.txtRDQAOfficer);
            this.Controls.Add(this.txtAnalyzedBy);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSampleSize);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtSendDate);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtSendBy);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBatch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtReportType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtReportID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmQCDetailView";
            this.Text = "Quality Inspection Details";
            this.Load += new System.EventHandler(this.frmQCDetailView_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvTest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSampleSize;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtSendDate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSendBy;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBatch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtReportType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtReportID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView gvTest;
        private System.Windows.Forms.TextBox txtAnalyzedBy;
        private System.Windows.Forms.TextBox txtRDQAOfficer;
        private System.Windows.Forms.TextBox txtTestBy;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.BindingSource bindDetails;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTestDetailsID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}