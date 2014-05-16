namespace MRP_GUI
{
    partial class frmQCView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQCView));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.rbInitial = new System.Windows.Forms.RadioButton();
            this.rbReject = new System.Windows.Forms.RadioButton();
            this.rcAccept = new System.Windows.Forms.RadioButton();
            this.gvReports = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRPD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPRPD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProduction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindReports = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnView = new System.Windows.Forms.Button();
            this.btnMore = new System.Windows.Forms.Button();
            this.txtTestBy = new System.Windows.Forms.TextBox();
            this.txtRDQAOfficer = new System.Windows.Forms.TextBox();
            this.txtAnalizedBy = new System.Windows.Forms.TextBox();
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
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvReports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindReports)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbType);
            this.groupBox1.Controls.Add(this.rbInitial);
            this.groupBox1.Controls.Add(this.rbReject);
            this.groupBox1.Controls.Add(this.rcAccept);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(960, 86);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Inspection";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Type";
            // 
            // cmbType
            // 
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "RPD",
            "PRPD"});
            this.cmbType.Location = new System.Drawing.Point(98, 59);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(178, 21);
            this.cmbType.TabIndex = 3;
            this.cmbType.SelectedIndexChanged += new System.EventHandler(this.cmbType_SelectedIndexChanged);
            // 
            // rbInitial
            // 
            this.rbInitial.AutoSize = true;
            this.rbInitial.Checked = true;
            this.rbInitial.Location = new System.Drawing.Point(16, 30);
            this.rbInitial.Name = "rbInitial";
            this.rbInitial.Size = new System.Drawing.Size(49, 17);
            this.rbInitial.TabIndex = 2;
            this.rbInitial.TabStop = true;
            this.rbInitial.Text = "Initial";
            this.rbInitial.UseVisualStyleBackColor = true;
            this.rbInitial.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // rbReject
            // 
            this.rbReject.AutoSize = true;
            this.rbReject.Location = new System.Drawing.Point(208, 30);
            this.rbReject.Name = "rbReject";
            this.rbReject.Size = new System.Drawing.Size(68, 17);
            this.rbReject.TabIndex = 1;
            this.rbReject.Text = "Rejected";
            this.rbReject.UseVisualStyleBackColor = true;
            this.rbReject.CheckedChanged += new System.EventHandler(this.rbReject_CheckedChanged);
            // 
            // rcAccept
            // 
            this.rcAccept.AutoSize = true;
            this.rcAccept.Location = new System.Drawing.Point(98, 30);
            this.rcAccept.Name = "rcAccept";
            this.rcAccept.Size = new System.Drawing.Size(71, 17);
            this.rcAccept.TabIndex = 0;
            this.rcAccept.Text = "Accepted";
            this.rcAccept.UseVisualStyleBackColor = true;
            this.rcAccept.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // gvReports
            // 
            this.gvReports.AllowUserToAddRows = false;
            this.gvReports.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gvReports.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gvReports.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvReports.AutoGenerateColumns = false;
            this.gvReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvReports.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colRPD,
            this.colPRPD,
            this.colProduction,
            this.Column1,
            this.Column2});
            this.gvReports.DataSource = this.bindReports;
            this.gvReports.Location = new System.Drawing.Point(12, 104);
            this.gvReports.Name = "gvReports";
            this.gvReports.ReadOnly = true;
            this.gvReports.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvReports.RowTemplate.Height = 20;
            this.gvReports.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvReports.Size = new System.Drawing.Size(960, 209);
            this.gvReports.TabIndex = 1;
            this.gvReports.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvReports_CellClick);
            // 
            // colID
            // 
            this.colID.DataPropertyName = "QCReportID";
            this.colID.HeaderText = "Report ID";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            // 
            // colRPD
            // 
            this.colRPD.DataPropertyName = "RPDBatchID";
            this.colRPD.HeaderText = "RPD Batch ID";
            this.colRPD.Name = "colRPD";
            this.colRPD.ReadOnly = true;
            // 
            // colPRPD
            // 
            this.colPRPD.DataPropertyName = "PRPDBatchID";
            this.colPRPD.HeaderText = "PRPD Batch ID";
            this.colPRPD.Name = "colPRPD";
            this.colPRPD.ReadOnly = true;
            this.colPRPD.Width = 120;
            // 
            // colProduction
            // 
            this.colProduction.DataPropertyName = "ProductionBatchID";
            this.colProduction.HeaderText = "Batch ID";
            this.colProduction.Name = "colProduction";
            this.colProduction.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "SendByName";
            this.Column1.HeaderText = "Send By";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "SendDate";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column2.HeaderText = "Send Date";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 120;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnView);
            this.groupBox2.Controls.Add(this.btnMore);
            this.groupBox2.Controls.Add(this.txtTestBy);
            this.groupBox2.Controls.Add(this.txtRDQAOfficer);
            this.groupBox2.Controls.Add(this.txtAnalizedBy);
            this.groupBox2.Controls.Add(this.txtSampleSize);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.txtSendDate);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtSendBy);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtRemarks);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtBatch);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtReportType);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtReportID);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 319);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(960, 211);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Details";
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(120, 182);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(75, 23);
            this.btnView.TabIndex = 67;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnMore
            // 
            this.btnMore.Enabled = false;
            this.btnMore.Location = new System.Drawing.Point(6, 182);
            this.btnMore.Name = "btnMore";
            this.btnMore.Size = new System.Drawing.Size(108, 23);
            this.btnMore.TabIndex = 66;
            this.btnMore.Text = "Test Result";
            this.btnMore.UseVisualStyleBackColor = true;
            this.btnMore.Click += new System.EventHandler(this.btnMore_Click);
            // 
            // txtTestBy
            // 
            this.txtTestBy.Location = new System.Drawing.Point(83, 131);
            this.txtTestBy.Name = "txtTestBy";
            this.txtTestBy.ReadOnly = true;
            this.txtTestBy.Size = new System.Drawing.Size(295, 20);
            this.txtTestBy.TabIndex = 65;
            // 
            // txtRDQAOfficer
            // 
            this.txtRDQAOfficer.Location = new System.Drawing.Point(83, 108);
            this.txtRDQAOfficer.Name = "txtRDQAOfficer";
            this.txtRDQAOfficer.ReadOnly = true;
            this.txtRDQAOfficer.Size = new System.Drawing.Size(295, 20);
            this.txtRDQAOfficer.TabIndex = 64;
            // 
            // txtAnalizedBy
            // 
            this.txtAnalizedBy.Location = new System.Drawing.Point(83, 85);
            this.txtAnalizedBy.Name = "txtAnalizedBy";
            this.txtAnalizedBy.ReadOnly = true;
            this.txtAnalizedBy.Size = new System.Drawing.Size(295, 20);
            this.txtAnalizedBy.TabIndex = 63;
            // 
            // txtSampleSize
            // 
            this.txtSampleSize.Location = new System.Drawing.Point(450, 66);
            this.txtSampleSize.Name = "txtSampleSize";
            this.txtSampleSize.ReadOnly = true;
            this.txtSampleSize.Size = new System.Drawing.Size(100, 20);
            this.txtSampleSize.TabIndex = 62;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(383, 69);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 13);
            this.label16.TabIndex = 61;
            this.label16.Text = "Sample Size";
            // 
            // txtSendDate
            // 
            this.txtSendDate.Location = new System.Drawing.Point(450, 44);
            this.txtSendDate.Name = "txtSendDate";
            this.txtSendDate.ReadOnly = true;
            this.txtSendDate.Size = new System.Drawing.Size(100, 20);
            this.txtSendDate.TabIndex = 60;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(390, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 59;
            this.label10.Text = "Send Date";
            // 
            // txtSendBy
            // 
            this.txtSendBy.Location = new System.Drawing.Point(450, 22);
            this.txtSendBy.Name = "txtSendBy";
            this.txtSendBy.ReadOnly = true;
            this.txtSendBy.Size = new System.Drawing.Size(284, 20);
            this.txtSendBy.TabIndex = 58;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(401, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 57;
            this.label9.Text = "Send By";
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(450, 88);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.ReadOnly = true;
            this.txtRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRemarks.Size = new System.Drawing.Size(404, 86);
            this.txtRemarks.TabIndex = 56;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(399, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 55;
            this.label8.Text = "Remarks";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 54;
            this.label7.Text = "Test By";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 53;
            this.label6.Text = "RDQAOfficer";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 52;
            this.label5.Text = "Analyzed By";
            // 
            // txtBatch
            // 
            this.txtBatch.Location = new System.Drawing.Point(83, 63);
            this.txtBatch.Name = "txtBatch";
            this.txtBatch.ReadOnly = true;
            this.txtBatch.Size = new System.Drawing.Size(100, 20);
            this.txtBatch.TabIndex = 51;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 50;
            this.label4.Text = "Batch";
            // 
            // txtReportType
            // 
            this.txtReportType.Location = new System.Drawing.Point(83, 41);
            this.txtReportType.Name = "txtReportType";
            this.txtReportType.ReadOnly = true;
            this.txtReportType.Size = new System.Drawing.Size(100, 20);
            this.txtReportType.TabIndex = 49;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 48;
            this.label3.Text = "Type";
            // 
            // txtReportID
            // 
            this.txtReportID.Location = new System.Drawing.Point(83, 19);
            this.txtReportID.Name = "txtReportID";
            this.txtReportID.ReadOnly = true;
            this.txtReportID.Size = new System.Drawing.Size(100, 20);
            this.txtReportID.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 46;
            this.label2.Text = "Report ID";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(897, 536);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmQCView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 564);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gvReports);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmQCView";
            this.Text = "Quality Inspection";
            this.Load += new System.EventHandler(this.frmQCView_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvReports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindReports)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.RadioButton rbInitial;
        private System.Windows.Forms.RadioButton rbReject;
        private System.Windows.Forms.RadioButton rcAccept;
        private System.Windows.Forms.DataGridView gvReports;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRPD;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPRPD;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProduction;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTestBy;
        private System.Windows.Forms.TextBox txtRDQAOfficer;
        private System.Windows.Forms.TextBox txtAnalizedBy;
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
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMore;
        private System.Windows.Forms.BindingSource bindReports;
        private System.Windows.Forms.Button btnView;
    }
}