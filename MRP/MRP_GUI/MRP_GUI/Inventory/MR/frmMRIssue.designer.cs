namespace MRP_GUI
{
    partial class frmMRIssue
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMRIssue));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.cmbStore = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnReject = new System.Windows.Forms.Button();
            this.gvItemList = new System.Windows.Forms.DataGridView();
            this.bindItemList = new System.Windows.Forms.BindingSource(this.components);
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtApprovedDate = new System.Windows.Forms.TextBox();
            this.txtapprovedBy = new System.Windows.Forms.TextBox();
            this.txtRequestedDate = new System.Windows.Forms.TextBox();
            this.txtRequestedBy = new System.Windows.Forms.TextBox();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.txtMRNO = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gvMRList = new System.Windows.Forms.DataGridView();
            this.MRNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BatchID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindMRList = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MRDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColReqdQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColIssuedQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvItemList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindItemList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMRList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindMRList)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPrint);
            this.groupBox1.Controls.Add(this.cmbStore);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.gvMRList);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1002, 616);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Material Issue";
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(915, 21);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 5;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // cmbStore
            // 
            this.cmbStore.DisplayMember = "StoreName";
            this.cmbStore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStore.FormattingEnabled = true;
            this.cmbStore.Location = new System.Drawing.Point(73, 18);
            this.cmbStore.Name = "cmbStore";
            this.cmbStore.Size = new System.Drawing.Size(380, 23);
            this.cmbStore.TabIndex = 4;
            this.cmbStore.Text = "--Select Store--";
            this.cmbStore.SelectedIndexChanged += new System.EventHandler(this.cmbStore_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(9, 21);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 15);
            this.label15.TabIndex = 3;
            this.label15.Text = "Store";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnReject);
            this.groupBox2.Controls.Add(this.gvItemList);
            this.groupBox2.Controls.Add(this.txtRemarks);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtDate);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtApprovedDate);
            this.groupBox2.Controls.Add(this.txtapprovedBy);
            this.groupBox2.Controls.Add(this.txtRequestedDate);
            this.groupBox2.Controls.Add(this.txtRequestedBy);
            this.groupBox2.Controls.Add(this.txtDepartment);
            this.groupBox2.Controls.Add(this.txtMRNO);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(6, 226);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(990, 384);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Issue";
            // 
            // btnReject
            // 
            this.btnReject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnReject.Location = new System.Drawing.Point(6, 355);
            this.btnReject.Name = "btnReject";
            this.btnReject.Size = new System.Drawing.Size(75, 23);
            this.btnReject.TabIndex = 28;
            this.btnReject.Text = "Reject";
            this.btnReject.UseVisualStyleBackColor = true;
            this.btnReject.Click += new System.EventHandler(this.btnReject_Click);
            // 
            // gvItemList
            // 
            this.gvItemList.AllowUserToAddRows = false;
            this.gvItemList.AllowUserToDeleteRows = false;
            this.gvItemList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvItemList.AutoGenerateColumns = false;
            this.gvItemList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvItemList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColMaterial,
            this.MRDescription,
            this.Column3,
            this.ColReqdQty,
            this.ColIssuedQty});
            this.gvItemList.DataSource = this.bindItemList;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Format = "N3";
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvItemList.DefaultCellStyle = dataGridViewCellStyle2;
            this.gvItemList.Location = new System.Drawing.Point(6, 113);
            this.gvItemList.Name = "gvItemList";
            this.gvItemList.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvItemList.RowTemplate.Height = 30;
            this.gvItemList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.gvItemList.Size = new System.Drawing.Size(978, 236);
            this.gvItemList.TabIndex = 27;
            this.gvItemList.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvItemList_CellEndEdit);
            this.gvItemList.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.gvItemList_DataError);
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(586, 32);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.ReadOnly = true;
            this.txtRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRemarks.Size = new System.Drawing.Size(374, 65);
            this.txtRemarks.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(583, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Remarks";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(98, 63);
            this.txtDate.Name = "txtDate";
            this.txtDate.ReadOnly = true;
            this.txtDate.Size = new System.Drawing.Size(138, 20);
            this.txtDate.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Date";
            // 
            // txtApprovedDate
            // 
            this.txtApprovedDate.Location = new System.Drawing.Point(356, 80);
            this.txtApprovedDate.Name = "txtApprovedDate";
            this.txtApprovedDate.ReadOnly = true;
            this.txtApprovedDate.Size = new System.Drawing.Size(138, 20);
            this.txtApprovedDate.TabIndex = 22;
            // 
            // txtapprovedBy
            // 
            this.txtapprovedBy.Location = new System.Drawing.Point(356, 59);
            this.txtapprovedBy.Name = "txtapprovedBy";
            this.txtapprovedBy.ReadOnly = true;
            this.txtapprovedBy.Size = new System.Drawing.Size(199, 20);
            this.txtapprovedBy.TabIndex = 21;
            // 
            // txtRequestedDate
            // 
            this.txtRequestedDate.Location = new System.Drawing.Point(356, 34);
            this.txtRequestedDate.Name = "txtRequestedDate";
            this.txtRequestedDate.ReadOnly = true;
            this.txtRequestedDate.Size = new System.Drawing.Size(138, 20);
            this.txtRequestedDate.TabIndex = 20;
            // 
            // txtRequestedBy
            // 
            this.txtRequestedBy.Location = new System.Drawing.Point(356, 13);
            this.txtRequestedBy.Name = "txtRequestedBy";
            this.txtRequestedBy.ReadOnly = true;
            this.txtRequestedBy.Size = new System.Drawing.Size(199, 20);
            this.txtRequestedBy.TabIndex = 19;
            // 
            // txtDepartment
            // 
            this.txtDepartment.Location = new System.Drawing.Point(98, 38);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.ReadOnly = true;
            this.txtDepartment.Size = new System.Drawing.Size(138, 20);
            this.txtDepartment.TabIndex = 18;
            // 
            // txtMRNO
            // 
            this.txtMRNO.Location = new System.Drawing.Point(98, 17);
            this.txtMRNO.Name = "txtMRNO";
            this.txtMRNO.ReadOnly = true;
            this.txtMRNO.Size = new System.Drawing.Size(138, 20);
            this.txtMRNO.TabIndex = 17;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(828, 355);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Issue";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(909, 355);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 97);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(118, 13);
            this.label14.TabIndex = 13;
            this.label14.Text = "Requested Material List";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(281, 62);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 13);
            this.label13.TabIndex = 10;
            this.label13.Text = "Certified By";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(270, 83);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "Certified Date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(256, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Requested Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(267, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Requested By";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Department";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "MRN No";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Material Requests";
            // 
            // gvMRList
            // 
            this.gvMRList.AllowUserToAddRows = false;
            this.gvMRList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gvMRList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.gvMRList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvMRList.AutoGenerateColumns = false;
            this.gvMRList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvMRList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MRNO,
            this.BatchID,
            this.Column2,
            this.Column11,
            this.Column4,
            this.Column5,
            this.Column12});
            this.gvMRList.DataSource = this.bindMRList;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvMRList.DefaultCellStyle = dataGridViewCellStyle5;
            this.gvMRList.Location = new System.Drawing.Point(6, 64);
            this.gvMRList.MultiSelect = false;
            this.gvMRList.Name = "gvMRList";
            this.gvMRList.ReadOnly = true;
            this.gvMRList.RowHeadersVisible = false;
            this.gvMRList.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvMRList.RowTemplate.Height = 28;
            this.gvMRList.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gvMRList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvMRList.Size = new System.Drawing.Size(990, 156);
            this.gvMRList.TabIndex = 0;
            this.gvMRList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvMRList_CellClick);
            // 
            // MRNO
            // 
            this.MRNO.DataPropertyName = "MRNO";
            this.MRNO.HeaderText = "MRN No";
            this.MRNO.Name = "MRNO";
            this.MRNO.ReadOnly = true;
            // 
            // BatchID
            // 
            this.BatchID.DataPropertyName = "BatchID";
            this.BatchID.HeaderText = "Batch ID";
            this.BatchID.Name = "BatchID";
            this.BatchID.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "DepName";
            this.Column2.HeaderText = "Department";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 120;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "MRDate";
            dataGridViewCellStyle4.Format = "d";
            this.Column11.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column11.HeaderText = "Date";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "EnterdBy";
            this.Column4.HeaderText = "Request By";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 130;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "ApproveBy";
            this.Column5.HeaderText = "Certify By";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 130;
            // 
            // Column12
            // 
            this.Column12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column12.DataPropertyName = "MRRemarks";
            this.Column12.HeaderText = "Remarks";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn2.HeaderText = "Description of Item";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "UnitCode";
            this.dataGridViewTextBoxColumn3.HeaderText = "Unit";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ReqdQty";
            this.dataGridViewTextBoxColumn4.HeaderText = "Reqd Qty.";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "IssuedQty";
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewTextBoxColumn5.HeaderText = "Issued Qty";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "MRNO";
            this.dataGridViewTextBoxColumn6.HeaderText = "MRN No";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "DepName";
            this.dataGridViewTextBoxColumn7.HeaderText = "Department";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 120;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "MRDate";
            dataGridViewCellStyle7.Format = "d";
            this.dataGridViewTextBoxColumn8.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewTextBoxColumn8.HeaderText = "Date";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "EnterdBy";
            this.dataGridViewTextBoxColumn9.HeaderText = "Request By";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 130;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "ApproveBy";
            this.dataGridViewTextBoxColumn10.HeaderText = "Certify By";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 130;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn11.DataPropertyName = "MRRemarks";
            this.dataGridViewTextBoxColumn11.HeaderText = "Remarks";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // ColMaterial
            // 
            this.ColMaterial.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColMaterial.DataPropertyName = "Item";
            this.ColMaterial.FillWeight = 250F;
            this.ColMaterial.HeaderText = "Item";
            this.ColMaterial.Name = "ColMaterial";
            this.ColMaterial.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // MRDescription
            // 
            this.MRDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MRDescription.DataPropertyName = "Description";
            this.MRDescription.FillWeight = 150F;
            this.MRDescription.HeaderText = "MRDescription";
            this.MRDescription.Name = "MRDescription";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "UnitCode";
            this.Column3.HeaderText = "Unit";
            this.Column3.Name = "Column3";
            // 
            // ColReqdQty
            // 
            this.ColReqdQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColReqdQty.DataPropertyName = "ReqdQty";
            this.ColReqdQty.HeaderText = "Reqd Qty.";
            this.ColReqdQty.Name = "ColReqdQty";
            // 
            // ColIssuedQty
            // 
            this.ColIssuedQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColIssuedQty.DataPropertyName = "IssuedQty";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Format = "N3";
            dataGridViewCellStyle1.NullValue = null;
            this.ColIssuedQty.DefaultCellStyle = dataGridViewCellStyle1;
            this.ColIssuedQty.HeaderText = "Issued Qty";
            this.ColIssuedQty.Name = "ColIssuedQty";
            // 
            // frmMRIssue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 616);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(690, 580);
            this.Name = "frmMRIssue";
            this.Text = "MR Material Issue";
            this.Load += new System.EventHandler(this.frmMRIssue_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvItemList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindItemList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMRList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindMRList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView gvMRList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cmbStore;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.BindingSource bindMRList;
        private System.Windows.Forms.BindingSource bindItemList;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtApprovedDate;
        private System.Windows.Forms.TextBox txtapprovedBy;
        private System.Windows.Forms.TextBox txtRequestedDate;
        private System.Windows.Forms.TextBox txtRequestedBy;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.TextBox txtMRNO;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView gvItemList;
        private System.Windows.Forms.Button btnReject;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.DataGridViewTextBoxColumn MRNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn BatchID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn MRDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColReqdQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColIssuedQty;
    }
}