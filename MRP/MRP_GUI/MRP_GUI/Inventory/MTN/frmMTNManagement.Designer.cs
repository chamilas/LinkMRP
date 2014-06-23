namespace MRP_GUI
{
    partial class frmMTNManagement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gvItemList = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindMaterialList = new System.Windows.Forms.BindingSource(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.gvMTNList = new System.Windows.Forms.DataGridView();
            this.bindMtnList = new System.Windows.Forms.BindingSource(this.components);
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MTNReceivedByName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MTNReceivedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GRNNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GRNEnterdByName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GRNDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GRNApprovedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GRNApproveDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvItemList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindMaterialList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMTNList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindMtnList)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.dtTo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtFrom);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbStatus);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbDepartment);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.gvMTNList);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(930, 515);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Material Transfer Note";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(357, 19);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click_1);
            // 
            // dtTo
            // 
            this.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTo.Location = new System.Drawing.Point(81, 69);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(95, 20);
            this.dtTo.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "To";
            // 
            // dtFrom
            // 
            this.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFrom.Location = new System.Drawing.Point(81, 43);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(95, 20);
            this.dtFrom.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "From";
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(232, 46);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(119, 21);
            this.cmbStatus.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(189, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Status";
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.DisplayMember = "DepName";
            this.cmbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Location = new System.Drawing.Point(81, 20);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(270, 21);
            this.cmbDepartment.TabIndex = 3;
            this.cmbDepartment.ValueMember = "Department";
            this.cmbDepartment.SelectedIndexChanged += new System.EventHandler(this.cmbDepartment_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Department";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.gvItemList);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(12, 331);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(906, 172);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Details";
            // 
            // gvItemList
            // 
            this.gvItemList.AllowUserToAddRows = false;
            this.gvItemList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gvItemList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gvItemList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvItemList.AutoGenerateColumns = false;
            this.gvItemList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvItemList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column8,
            this.Column9});
            this.gvItemList.DataSource = this.bindMaterialList;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvItemList.DefaultCellStyle = dataGridViewCellStyle2;
            this.gvItemList.Location = new System.Drawing.Point(9, 19);
            this.gvItemList.Name = "gvItemList";
            this.gvItemList.ReadOnly = true;
            this.gvItemList.RowHeadersVisible = false;
            this.gvItemList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvItemList.Size = new System.Drawing.Size(891, 147);
            this.gvItemList.TabIndex = 15;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column7.DataPropertyName = "Code";
            this.Column7.FillWeight = 250F;
            this.Column7.HeaderText = "Item";
            this.Column7.MinimumWidth = 200;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column8.DataPropertyName = "MTNUnitRate";
            this.Column8.HeaderText = "Unit Cost";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column9.DataPropertyName = "MTNTransferQty";
            this.Column9.HeaderText = "Transfer Qty";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 116);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Material List";
            // 
            // gvMTNList
            // 
            this.gvMTNList.AllowUserToAddRows = false;
            this.gvMTNList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gvMTNList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.gvMTNList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvMTNList.AutoGenerateColumns = false;
            this.gvMTNList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvMTNList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column2,
            this.MTNReceivedByName,
            this.MTNReceivedDate,
            this.Column10,
            this.Column11,
            this.Col,
            this.Column12,
            this.GRNNO,
            this.GRNEnterdByName,
            this.GRNDate,
            this.GRNApprovedBy,
            this.GRNApproveDate});
            this.gvMTNList.DataSource = this.bindMtnList;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvMTNList.DefaultCellStyle = dataGridViewCellStyle9;
            this.gvMTNList.Location = new System.Drawing.Point(12, 95);
            this.gvMTNList.Name = "gvMTNList";
            this.gvMTNList.ReadOnly = true;
            this.gvMTNList.RowHeadersVisible = false;
            this.gvMTNList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvMTNList.Size = new System.Drawing.Size(906, 230);
            this.gvMTNList.TabIndex = 0;
            this.gvMTNList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvMTNList_CellClick_1);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "MTNNO";
            this.Column1.HeaderText = "MTN No.";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "DepNameTo";
            this.Column3.HeaderText = "To";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "MTNDate";
            dataGridViewCellStyle4.Format = "d";
            this.Column4.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column4.HeaderText = "Date";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.DataPropertyName = "MTNEnterdByName";
            this.Column5.HeaderText = "Enterd By";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "MTNTGRNNO";
            this.Column2.HeaderText = "TGRN No";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Visible = false;
            // 
            // MTNReceivedByName
            // 
            this.MTNReceivedByName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MTNReceivedByName.DataPropertyName = "MTNReceivedByName";
            this.MTNReceivedByName.HeaderText = "Received By";
            this.MTNReceivedByName.Name = "MTNReceivedByName";
            this.MTNReceivedByName.ReadOnly = true;
            // 
            // MTNReceivedDate
            // 
            this.MTNReceivedDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MTNReceivedDate.DataPropertyName = "MTNReceivedDate";
            this.MTNReceivedDate.HeaderText = "Received Date";
            this.MTNReceivedDate.Name = "MTNReceivedDate";
            this.MTNReceivedDate.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column10.DataPropertyName = "MTNBatchID";
            dataGridViewCellStyle5.NullValue = "N/A";
            this.Column10.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column10.HeaderText = "Batch No";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column11.DataPropertyName = "MTNRePackBatchID";
            dataGridViewCellStyle6.NullValue = "N/A";
            this.Column11.DefaultCellStyle = dataGridViewCellStyle6;
            this.Column11.HeaderText = "Repack Batch";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // Col
            // 
            this.Col.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Col.DataPropertyName = "MTNReworkBatchID";
            dataGridViewCellStyle7.NullValue = "N/A";
            this.Col.DefaultCellStyle = dataGridViewCellStyle7;
            this.Col.HeaderText = "Rework Batch";
            this.Col.Name = "Col";
            this.Col.ReadOnly = true;
            // 
            // Column12
            // 
            this.Column12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column12.DataPropertyName = "MTNMatReworkBatchID";
            dataGridViewCellStyle8.NullValue = "N/A";
            this.Column12.DefaultCellStyle = dataGridViewCellStyle8;
            this.Column12.HeaderText = "Mat Rework";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            this.Column12.Visible = false;
            // 
            // GRNNO
            // 
            this.GRNNO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GRNNO.DataPropertyName = "GRNNO";
            this.GRNNO.HeaderText = "GRN NO";
            this.GRNNO.Name = "GRNNO";
            this.GRNNO.ReadOnly = true;
            // 
            // GRNEnterdByName
            // 
            this.GRNEnterdByName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GRNEnterdByName.DataPropertyName = "GRNEnterdByName";
            this.GRNEnterdByName.HeaderText = "MTN GRN by";
            this.GRNEnterdByName.Name = "GRNEnterdByName";
            this.GRNEnterdByName.ReadOnly = true;
            // 
            // GRNDate
            // 
            this.GRNDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GRNDate.DataPropertyName = "GRNDate";
            this.GRNDate.HeaderText = "GRN Date";
            this.GRNDate.Name = "GRNDate";
            this.GRNDate.ReadOnly = true;
            // 
            // GRNApprovedBy
            // 
            this.GRNApprovedBy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GRNApprovedBy.DataPropertyName = "GRNApprovedByName";
            this.GRNApprovedBy.HeaderText = "GRN Approved By";
            this.GRNApprovedBy.Name = "GRNApprovedBy";
            this.GRNApprovedBy.ReadOnly = true;
            // 
            // GRNApproveDate
            // 
            this.GRNApproveDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GRNApproveDate.DataPropertyName = "GRNApproveDate";
            this.GRNApproveDate.HeaderText = "GRN Approved Date";
            this.GRNApproveDate.Name = "GRNApproveDate";
            this.GRNApproveDate.ReadOnly = true;
            // 
            // frmMTNManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 515);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMTNManagement";
            this.Text = "Material Transfer Note Management";
            this.Load += new System.EventHandler(this.frmMTNManagement_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvItemList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindMaterialList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMTNList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindMtnList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView gvItemList;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView gvMTNList;
        private System.Windows.Forms.BindingSource bindMtnList;
        private System.Windows.Forms.BindingSource bindMaterialList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MTNReceivedByName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MTNReceivedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn GRNNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn GRNEnterdByName;
        private System.Windows.Forms.DataGridViewTextBoxColumn GRNDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn GRNApprovedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn GRNApproveDate;

    }
}