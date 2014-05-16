namespace MRP_GUI.PRPD
{
    partial class frmPRPDQCReport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPRPDQCReport));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTotalImpurities = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtHandOverBy = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtInspectedBy = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtApprovedBy = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtInstructedBy = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSupervisedBy = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaterial = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPRPDBatchID = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSampleSize = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtSendBy = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtTestBy = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtRDQAOffice = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtAnalyzedBy = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtReportID = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.gvTestParameters = new System.Windows.Forms.DataGridView();
            this.btnExit = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Acceptence = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvTestParameters)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtTotalImpurities);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtComment);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtHandOverBy);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtInspectedBy);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtApprovedBy);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtInstructedBy);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtSupervisedBy);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtQuantity);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMaterial);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtPRPDBatchID);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 299);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PRPD Batch ";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 251);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "Total Impurities";
            // 
            // txtTotalImpurities
            // 
            this.txtTotalImpurities.Location = new System.Drawing.Point(98, 248);
            this.txtTotalImpurities.Name = "txtTotalImpurities";
            this.txtTotalImpurities.ReadOnly = true;
            this.txtTotalImpurities.Size = new System.Drawing.Size(204, 20);
            this.txtTotalImpurities.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Comments";
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(98, 172);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.ReadOnly = true;
            this.txtComment.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtComment.Size = new System.Drawing.Size(272, 75);
            this.txtComment.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Hand Over By";
            // 
            // txtHandOverBy
            // 
            this.txtHandOverBy.Location = new System.Drawing.Point(98, 151);
            this.txtHandOverBy.Name = "txtHandOverBy";
            this.txtHandOverBy.ReadOnly = true;
            this.txtHandOverBy.Size = new System.Drawing.Size(204, 20);
            this.txtHandOverBy.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 133);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Inspected By";
            // 
            // txtInspectedBy
            // 
            this.txtInspectedBy.Location = new System.Drawing.Point(98, 130);
            this.txtInspectedBy.Name = "txtInspectedBy";
            this.txtInspectedBy.ReadOnly = true;
            this.txtInspectedBy.Size = new System.Drawing.Size(204, 20);
            this.txtInspectedBy.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Approved By";
            // 
            // txtApprovedBy
            // 
            this.txtApprovedBy.Location = new System.Drawing.Point(98, 109);
            this.txtApprovedBy.Name = "txtApprovedBy";
            this.txtApprovedBy.ReadOnly = true;
            this.txtApprovedBy.Size = new System.Drawing.Size(204, 20);
            this.txtApprovedBy.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Instructed By";
            // 
            // txtInstructedBy
            // 
            this.txtInstructedBy.Location = new System.Drawing.Point(98, 88);
            this.txtInstructedBy.Name = "txtInstructedBy";
            this.txtInstructedBy.ReadOnly = true;
            this.txtInstructedBy.Size = new System.Drawing.Size(204, 20);
            this.txtInstructedBy.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Supervised By";
            // 
            // txtSupervisedBy
            // 
            this.txtSupervisedBy.Location = new System.Drawing.Point(98, 269);
            this.txtSupervisedBy.Name = "txtSupervisedBy";
            this.txtSupervisedBy.ReadOnly = true;
            this.txtSupervisedBy.Size = new System.Drawing.Size(204, 20);
            this.txtSupervisedBy.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Quntity";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(98, 67);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.ReadOnly = true;
            this.txtQuantity.Size = new System.Drawing.Size(204, 20);
            this.txtQuantity.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Material";
            // 
            // txtMaterial
            // 
            this.txtMaterial.Location = new System.Drawing.Point(98, 46);
            this.txtMaterial.Name = "txtMaterial";
            this.txtMaterial.ReadOnly = true;
            this.txtMaterial.Size = new System.Drawing.Size(204, 20);
            this.txtMaterial.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "PRPD Batch ID";
            // 
            // txtPRPDBatchID
            // 
            this.txtPRPDBatchID.Location = new System.Drawing.Point(98, 25);
            this.txtPRPDBatchID.Name = "txtPRPDBatchID";
            this.txtPRPDBatchID.ReadOnly = true;
            this.txtPRPDBatchID.Size = new System.Drawing.Size(120, 20);
            this.txtPRPDBatchID.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtRemarks);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtSampleSize);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txtSendBy);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.txtTestBy);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.txtRDQAOffice);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.txtAnalyzedBy);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.txtReportID);
            this.groupBox2.Location = new System.Drawing.Point(394, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(488, 299);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Quality Control Report";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(48, 154);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "Remarks";
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(103, 151);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.ReadOnly = true;
            this.txtRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRemarks.Size = new System.Drawing.Size(380, 138);
            this.txtRemarks.TabIndex = 28;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(32, 133);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "Sample Size";
            // 
            // txtSampleSize
            // 
            this.txtSampleSize.Location = new System.Drawing.Point(103, 130);
            this.txtSampleSize.Name = "txtSampleSize";
            this.txtSampleSize.ReadOnly = true;
            this.txtSampleSize.Size = new System.Drawing.Size(204, 20);
            this.txtSampleSize.TabIndex = 26;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(50, 112);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "Send By";
            // 
            // txtSendBy
            // 
            this.txtSendBy.Location = new System.Drawing.Point(103, 109);
            this.txtSendBy.Name = "txtSendBy";
            this.txtSendBy.ReadOnly = true;
            this.txtSendBy.Size = new System.Drawing.Size(204, 20);
            this.txtSendBy.TabIndex = 24;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(54, 91);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(43, 13);
            this.label14.TabIndex = 23;
            this.label14.Text = "Test By";
            // 
            // txtTestBy
            // 
            this.txtTestBy.Location = new System.Drawing.Point(103, 88);
            this.txtTestBy.Name = "txtTestBy";
            this.txtTestBy.ReadOnly = true;
            this.txtTestBy.Size = new System.Drawing.Size(204, 20);
            this.txtTestBy.TabIndex = 22;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(25, 70);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(72, 13);
            this.label15.TabIndex = 21;
            this.label15.Text = "RDQA Officer";
            // 
            // txtRDQAOffice
            // 
            this.txtRDQAOffice.Location = new System.Drawing.Point(103, 67);
            this.txtRDQAOffice.Name = "txtRDQAOffice";
            this.txtRDQAOffice.ReadOnly = true;
            this.txtRDQAOffice.Size = new System.Drawing.Size(204, 20);
            this.txtRDQAOffice.TabIndex = 20;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(32, 49);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 13);
            this.label16.TabIndex = 19;
            this.label16.Text = "Analyzed By";
            // 
            // txtAnalyzedBy
            // 
            this.txtAnalyzedBy.Location = new System.Drawing.Point(103, 46);
            this.txtAnalyzedBy.Name = "txtAnalyzedBy";
            this.txtAnalyzedBy.ReadOnly = true;
            this.txtAnalyzedBy.Size = new System.Drawing.Size(204, 20);
            this.txtAnalyzedBy.TabIndex = 18;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(44, 28);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(53, 13);
            this.label17.TabIndex = 17;
            this.label17.Text = "Report ID";
            // 
            // txtReportID
            // 
            this.txtReportID.Location = new System.Drawing.Point(103, 25);
            this.txtReportID.Name = "txtReportID";
            this.txtReportID.ReadOnly = true;
            this.txtReportID.Size = new System.Drawing.Size(120, 20);
            this.txtReportID.TabIndex = 16;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(12, 314);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(84, 13);
            this.label18.TabIndex = 20;
            this.label18.Text = "Test Parameters";
            // 
            // gvTestParameters
            // 
            this.gvTestParameters.AllowUserToAddRows = false;
            this.gvTestParameters.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gvTestParameters.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gvTestParameters.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gvTestParameters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvTestParameters.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Acceptence});
            this.gvTestParameters.Location = new System.Drawing.Point(12, 330);
            this.gvTestParameters.Name = "gvTestParameters";
            this.gvTestParameters.ReadOnly = true;
            this.gvTestParameters.RowTemplate.Height = 20;
            this.gvTestParameters.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvTestParameters.Size = new System.Drawing.Size(870, 150);
            this.gvTestParameters.TabIndex = 21;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(807, 486);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 22;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Parameter";
            this.Column1.HeaderText = "Parameter";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "Description";
            this.Column2.HeaderText = "Description";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Material";
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
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.DataPropertyName = "Comment";
            this.Column5.HeaderText = "Comment";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Acceptence
            // 
            this.Acceptence.HeaderText = "Acceptence";
            this.Acceptence.Name = "Acceptence";
            this.Acceptence.ReadOnly = true;
            // 
            // frmPRPDQCReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 518);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.gvTestParameters);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPRPDQCReport";
            this.Text = "PRPD Batch Quality Report";
            this.Load += new System.EventHandler(this.frmPRPDQCReport_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvTestParameters)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtApprovedBy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtInstructedBy;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSupervisedBy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaterial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPRPDBatchID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtTotalImpurities;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtHandOverBy;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtInspectedBy;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSampleSize;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtSendBy;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtTestBy;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtRDQAOffice;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtAnalyzedBy;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtReportID;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DataGridView gvTestParameters;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Acceptence;
    }
}