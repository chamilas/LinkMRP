namespace MRP_GUI
{
    partial class frmQC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQC));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtReportID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtReportType = new System.Windows.Forms.TextBox();
            this.txtBatch = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbAnalizedBy = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbRDQAOfficer = new System.Windows.Forms.ComboBox();
            this.cmbTestBy = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.txtSendBy = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSendDate = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.grpDetails = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.gvTest = new System.Windows.Forms.DataGridView();
            this.bindDetails = new System.Windows.Forms.BindingSource(this.components);
            this.btnSaveTest = new System.Windows.Forms.Button();
            this.cmbParameter = new System.Windows.Forms.ComboBox();
            this.cbAccept = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtTestID = new System.Windows.Forms.TextBox();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblItem = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.cmbMaterial = new System.Windows.Forms.ComboBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtSampleSize = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.grpFinalized = new System.Windows.Forms.GroupBox();
            this.rbAccept = new System.Windows.Forms.RadioButton();
            this.rbReject = new System.Windows.Forms.RadioButton();
            this.cbFinalized = new System.Windows.Forms.CheckBox();
            this.btnSaveReport = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colTestDetailsID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvTest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindDetails)).BeginInit();
            this.grpFinalized.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quality Inspection Report";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Report ID";
            // 
            // txtReportID
            // 
            this.txtReportID.Location = new System.Drawing.Point(85, 34);
            this.txtReportID.Name = "txtReportID";
            this.txtReportID.ReadOnly = true;
            this.txtReportID.Size = new System.Drawing.Size(100, 20);
            this.txtReportID.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Type";
            // 
            // txtReportType
            // 
            this.txtReportType.Location = new System.Drawing.Point(85, 56);
            this.txtReportType.Name = "txtReportType";
            this.txtReportType.ReadOnly = true;
            this.txtReportType.Size = new System.Drawing.Size(100, 20);
            this.txtReportType.TabIndex = 4;
            // 
            // txtBatch
            // 
            this.txtBatch.Location = new System.Drawing.Point(85, 78);
            this.txtBatch.Name = "txtBatch";
            this.txtBatch.ReadOnly = true;
            this.txtBatch.Size = new System.Drawing.Size(267, 20);
            this.txtBatch.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Batch";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Analyzed By";
            // 
            // cmbAnalizedBy
            // 
            this.cmbAnalizedBy.DisplayMember = "Employee";
            this.cmbAnalizedBy.FormattingEnabled = true;
            this.cmbAnalizedBy.Location = new System.Drawing.Point(85, 100);
            this.cmbAnalizedBy.Name = "cmbAnalizedBy";
            this.cmbAnalizedBy.Size = new System.Drawing.Size(267, 21);
            this.cmbAnalizedBy.TabIndex = 8;
            this.cmbAnalizedBy.ValueMember = "EmpID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "RDQAOfficer";
            // 
            // cmbRDQAOfficer
            // 
            this.cmbRDQAOfficer.DisplayMember = "Employee";
            this.cmbRDQAOfficer.FormattingEnabled = true;
            this.cmbRDQAOfficer.Location = new System.Drawing.Point(85, 123);
            this.cmbRDQAOfficer.Name = "cmbRDQAOfficer";
            this.cmbRDQAOfficer.Size = new System.Drawing.Size(267, 21);
            this.cmbRDQAOfficer.TabIndex = 10;
            this.cmbRDQAOfficer.ValueMember = "EmpID";
            // 
            // cmbTestBy
            // 
            this.cmbTestBy.DisplayMember = "Employee";
            this.cmbTestBy.FormattingEnabled = true;
            this.cmbTestBy.Location = new System.Drawing.Point(85, 146);
            this.cmbTestBy.Name = "cmbTestBy";
            this.cmbTestBy.Size = new System.Drawing.Size(267, 21);
            this.cmbTestBy.TabIndex = 12;
            this.cmbTestBy.ValueMember = "EmpID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Test By";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 173);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Remarks";
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(85, 170);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRemarks.Size = new System.Drawing.Size(404, 86);
            this.txtRemarks.TabIndex = 14;
            // 
            // txtSendBy
            // 
            this.txtSendBy.Location = new System.Drawing.Point(585, 34);
            this.txtSendBy.Name = "txtSendBy";
            this.txtSendBy.ReadOnly = true;
            this.txtSendBy.Size = new System.Drawing.Size(324, 20);
            this.txtSendBy.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(526, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Send By";
            // 
            // txtSendDate
            // 
            this.txtSendDate.Location = new System.Drawing.Point(585, 56);
            this.txtSendDate.Name = "txtSendDate";
            this.txtSendDate.ReadOnly = true;
            this.txtSendDate.Size = new System.Drawing.Size(100, 20);
            this.txtSendDate.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(515, 59);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Send Date";
            // 
            // grpDetails
            // 
            this.grpDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDetails.Controls.Add(this.btnClear);
            this.grpDetails.Controls.Add(this.btnDelete);
            this.grpDetails.Controls.Add(this.gvTest);
            this.grpDetails.Controls.Add(this.btnSaveTest);
            this.grpDetails.Controls.Add(this.cmbParameter);
            this.grpDetails.Controls.Add(this.cbAccept);
            this.grpDetails.Controls.Add(this.label11);
            this.grpDetails.Controls.Add(this.label15);
            this.grpDetails.Controls.Add(this.txtTestID);
            this.grpDetails.Controls.Add(this.txtComment);
            this.grpDetails.Controls.Add(this.label12);
            this.grpDetails.Controls.Add(this.label14);
            this.grpDetails.Controls.Add(this.lblItem);
            this.grpDetails.Controls.Add(this.txtResult);
            this.grpDetails.Controls.Add(this.cmbMaterial);
            this.grpDetails.Location = new System.Drawing.Point(12, 262);
            this.grpDetails.Name = "grpDetails";
            this.grpDetails.Size = new System.Drawing.Size(960, 273);
            this.grpDetails.TabIndex = 19;
            this.grpDetails.TabStop = false;
            this.grpDetails.Text = "Quality Tests";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(73, 244);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 35;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(151, 244);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 34;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // gvTest
            // 
            this.gvTest.AllowUserToAddRows = false;
            this.gvTest.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gvTest.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gvTest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvTest.AutoGenerateColumns = false;
            this.gvTest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvTest.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.colTestDetailsID,
            this.Column1,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column2});
            this.gvTest.DataSource = this.bindDetails;
            this.gvTest.Location = new System.Drawing.Point(331, 18);
            this.gvTest.Name = "gvTest";
            this.gvTest.ReadOnly = true;
            this.gvTest.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvTest.RowTemplate.Height = 20;
            this.gvTest.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvTest.Size = new System.Drawing.Size(623, 249);
            this.gvTest.TabIndex = 33;
            this.gvTest.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvTest_CellClick);
            // 
            // btnSaveTest
            // 
            this.btnSaveTest.Location = new System.Drawing.Point(232, 244);
            this.btnSaveTest.Name = "btnSaveTest";
            this.btnSaveTest.Size = new System.Drawing.Size(93, 23);
            this.btnSaveTest.TabIndex = 32;
            this.btnSaveTest.Text = "Save";
            this.btnSaveTest.UseVisualStyleBackColor = true;
            this.btnSaveTest.Click += new System.EventHandler(this.btnSaveTest_Click);
            // 
            // cmbParameter
            // 
            this.cmbParameter.DisplayMember = "Parameter";
            this.cmbParameter.FormattingEnabled = true;
            this.cmbParameter.Location = new System.Drawing.Point(85, 42);
            this.cmbParameter.Name = "cmbParameter";
            this.cmbParameter.Size = new System.Drawing.Size(240, 21);
            this.cmbParameter.TabIndex = 24;
            this.cmbParameter.ValueMember = "ParameterID";
            // 
            // cbAccept
            // 
            this.cbAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbAccept.AutoSize = true;
            this.cbAccept.Location = new System.Drawing.Point(85, 207);
            this.cbAccept.Name = "cbAccept";
            this.cbAccept.Size = new System.Drawing.Size(120, 17);
            this.cbAccept.TabIndex = 31;
            this.cbAccept.Text = "Quality Test Passed";
            this.cbAccept.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(37, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Test ID";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(28, 125);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 13);
            this.label15.TabIndex = 30;
            this.label15.Text = "Comment";
            // 
            // txtTestID
            // 
            this.txtTestID.Location = new System.Drawing.Point(85, 18);
            this.txtTestID.Name = "txtTestID";
            this.txtTestID.ReadOnly = true;
            this.txtTestID.Size = new System.Drawing.Size(100, 20);
            this.txtTestID.TabIndex = 22;
            this.txtTestID.Text = "[Auto]";
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(85, 122);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtComment.Size = new System.Drawing.Size(240, 65);
            this.txtComment.TabIndex = 29;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(24, 45);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Parameter";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(42, 99);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 13);
            this.label14.TabIndex = 28;
            this.label14.Text = "Result";
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Location = new System.Drawing.Point(35, 72);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(44, 13);
            this.lblItem.TabIndex = 25;
            this.lblItem.Text = "Material";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(85, 96);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(240, 20);
            this.txtResult.TabIndex = 27;
            // 
            // cmbMaterial
            // 
            this.cmbMaterial.DisplayMember = "Material";
            this.cmbMaterial.FormattingEnabled = true;
            this.cmbMaterial.Location = new System.Drawing.Point(85, 69);
            this.cmbMaterial.Name = "cmbMaterial";
            this.cmbMaterial.Size = new System.Drawing.Size(240, 21);
            this.cmbMaterial.TabIndex = 26;
            this.cmbMaterial.ValueMember = "MaterialCode";
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Location = new System.Drawing.Point(897, 538);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 20;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtSampleSize
            // 
            this.txtSampleSize.Location = new System.Drawing.Point(585, 78);
            this.txtSampleSize.Name = "txtSampleSize";
            this.txtSampleSize.ReadOnly = true;
            this.txtSampleSize.Size = new System.Drawing.Size(100, 20);
            this.txtSampleSize.TabIndex = 22;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(508, 81);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 13);
            this.label16.TabIndex = 21;
            this.label16.Text = "Sample Size";
            // 
            // grpFinalized
            // 
            this.grpFinalized.Controls.Add(this.rbAccept);
            this.grpFinalized.Controls.Add(this.rbReject);
            this.grpFinalized.Enabled = false;
            this.grpFinalized.Location = new System.Drawing.Point(518, 156);
            this.grpFinalized.Name = "grpFinalized";
            this.grpFinalized.Size = new System.Drawing.Size(398, 100);
            this.grpFinalized.TabIndex = 23;
            this.grpFinalized.TabStop = false;
            this.grpFinalized.Text = "Finalise Details";
            // 
            // rbAccept
            // 
            this.rbAccept.AutoSize = true;
            this.rbAccept.Location = new System.Drawing.Point(35, 53);
            this.rbAccept.Name = "rbAccept";
            this.rbAccept.Size = new System.Drawing.Size(59, 17);
            this.rbAccept.TabIndex = 1;
            this.rbAccept.TabStop = true;
            this.rbAccept.Text = "Accept";
            this.rbAccept.UseVisualStyleBackColor = true;
            // 
            // rbReject
            // 
            this.rbReject.AutoSize = true;
            this.rbReject.Location = new System.Drawing.Point(35, 29);
            this.rbReject.Name = "rbReject";
            this.rbReject.Size = new System.Drawing.Size(56, 17);
            this.rbReject.TabIndex = 0;
            this.rbReject.TabStop = true;
            this.rbReject.Text = "Reject";
            this.rbReject.UseVisualStyleBackColor = true;
            // 
            // cbFinalized
            // 
            this.cbFinalized.AutoSize = true;
            this.cbFinalized.Location = new System.Drawing.Point(518, 133);
            this.cbFinalized.Name = "cbFinalized";
            this.cbFinalized.Size = new System.Drawing.Size(120, 17);
            this.cbFinalized.TabIndex = 0;
            this.cbFinalized.Text = "Finalise Test Report";
            this.cbFinalized.UseVisualStyleBackColor = true;
            this.cbFinalized.CheckedChanged += new System.EventHandler(this.cbFinalized_CheckedChanged);
            // 
            // btnSaveReport
            // 
            this.btnSaveReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveReport.Location = new System.Drawing.Point(797, 538);
            this.btnSaveReport.Name = "btnSaveReport";
            this.btnSaveReport.Size = new System.Drawing.Size(94, 23);
            this.btnSaveReport.TabIndex = 24;
            this.btnSaveReport.Text = "Save Report";
            this.btnSaveReport.UseVisualStyleBackColor = true;
            this.btnSaveReport.Click += new System.EventHandler(this.btnSaveReport_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "TestDetailsID";
            this.dataGridViewTextBoxColumn1.Frozen = true;
            this.dataGridViewTextBoxColumn1.HeaderText = "TestDetailsID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Parameter";
            this.dataGridViewTextBoxColumn2.Frozen = true;
            this.dataGridViewTextBoxColumn2.HeaderText = "Parameter";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn3.Frozen = true;
            this.dataGridViewTextBoxColumn3.HeaderText = "Description";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Material";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Result";
            this.dataGridViewTextBoxColumn5.HeaderText = "Result";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Comment";
            this.dataGridViewTextBoxColumn6.HeaderText = "Comment";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 300;
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
            this.Column1.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "MaterialCode";
            this.Column3.Frozen = true;
            this.Column3.HeaderText = "Material";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Result";
            this.Column4.Frozen = true;
            this.Column4.HeaderText = "Result";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Comment";
            this.Column5.Frozen = true;
            this.Column5.HeaderText = "Comment";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 300;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Description";
            this.Column2.Frozen = true;
            this.Column2.HeaderText = "Description";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 175;
            // 
            // frmQC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 564);
            this.Controls.Add(this.btnSaveReport);
            this.Controls.Add(this.cbFinalized);
            this.Controls.Add(this.grpFinalized);
            this.Controls.Add(this.txtSampleSize);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.grpDetails);
            this.Controls.Add(this.txtSendDate);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtSendBy);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbTestBy);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbRDQAOfficer);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbAnalizedBy);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBatch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtReportType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtReportID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmQC";
            this.Text = "Quality Inspection Report";
            this.Load += new System.EventHandler(this.frmQC_Load);
            this.grpDetails.ResumeLayout(false);
            this.grpDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvTest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindDetails)).EndInit();
            this.grpFinalized.ResumeLayout(false);
            this.grpFinalized.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtReportID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtReportType;
        private System.Windows.Forms.TextBox txtBatch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbAnalizedBy;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbRDQAOfficer;
        private System.Windows.Forms.ComboBox cmbTestBy;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.TextBox txtSendBy;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSendDate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox grpDetails;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTestID;
        private System.Windows.Forms.ComboBox cmbParameter;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView gvTest;
        private System.Windows.Forms.Button btnSaveTest;
        private System.Windows.Forms.CheckBox cbAccept;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.ComboBox cmbMaterial;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtSampleSize;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox grpFinalized;
        private System.Windows.Forms.CheckBox cbFinalized;
        private System.Windows.Forms.RadioButton rbAccept;
        private System.Windows.Forms.RadioButton rbReject;
        private System.Windows.Forms.Button btnSaveReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.BindingSource bindDetails;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTestDetailsID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}