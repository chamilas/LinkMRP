namespace MRP_GUI
{
    partial class frmStandardBatch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStandardBatch));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbPart = new System.Windows.Forms.ComboBox();
            this.cmbActivity = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gvActivityList = new System.Windows.Forms.DataGridView();
            this.Column17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.objSourceActivity = new System.Windows.Forms.BindingSource(this.components);
            this.gpSTDBatch = new System.Windows.Forms.GroupBox();
            this.txtSTDBatchID = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtBatchDuration = new System.Windows.Forms.TextBox();
            this.lblUnit = new System.Windows.Forms.Label();
            this.txtBatchSize = new System.Windows.Forms.TextBox();
            this.cmbProductType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbProductCode = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.gpMain = new System.Windows.Forms.GroupBox();
            this.pnlQualityInspection = new System.Windows.Forms.Panel();
            this.groupBox19 = new System.Windows.Forms.GroupBox();
            this.pnlWeightControl = new System.Windows.Forms.Panel();
            this.label39 = new System.Windows.Forms.Label();
            this.pnlOther = new System.Windows.Forms.Panel();
            this.label51 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.objSourceProducts = new System.Windows.Forms.BindingSource(this.components);
            this.objSourceMainActivityList = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvActivityList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceActivity)).BeginInit();
            this.gpSTDBatch.SuspendLayout();
            this.gpMain.SuspendLayout();
            this.pnlQualityInspection.SuspendLayout();
            this.pnlWeightControl.SuspendLayout();
            this.pnlOther.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceMainActivityList)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbPart);
            this.groupBox1.Controls.Add(this.cmbActivity);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.gvActivityList);
            this.groupBox1.Controls.Add(this.gpSTDBatch);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.gpMain);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1028, 638);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // cmbPart
            // 
            this.cmbPart.FormattingEnabled = true;
            this.cmbPart.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.cmbPart.Location = new System.Drawing.Point(526, 257);
            this.cmbPart.Name = "cmbPart";
            this.cmbPart.Size = new System.Drawing.Size(81, 23);
            this.cmbPart.TabIndex = 116;
            // 
            // cmbActivity
            // 
            this.cmbActivity.DisplayMember = "MainActivity";
            this.cmbActivity.FormattingEnabled = true;
            this.cmbActivity.Location = new System.Drawing.Point(126, 257);
            this.cmbActivity.Name = "cmbActivity";
            this.cmbActivity.Size = new System.Drawing.Size(359, 23);
            this.cmbActivity.TabIndex = 21;
            this.cmbActivity.ValueMember = "MainActID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(491, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 15);
            this.label5.TabIndex = 19;
            this.label5.Text = "Part";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 15);
            this.label6.TabIndex = 19;
            this.label6.Text = "Activity List";
            // 
            // gvActivityList
            // 
            this.gvActivityList.AllowUserToAddRows = false;
            this.gvActivityList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gvActivityList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gvActivityList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gvActivityList.AutoGenerateColumns = false;
            this.gvActivityList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvActivityList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column17,
            this.Column19,
            this.Column20});
            this.gvActivityList.DataSource = this.objSourceActivity;
            this.gvActivityList.Location = new System.Drawing.Point(10, 306);
            this.gvActivityList.Name = "gvActivityList";
            this.gvActivityList.ReadOnly = true;
            this.gvActivityList.RowHeadersVisible = false;
            this.gvActivityList.RowTemplate.Height = 25;
            this.gvActivityList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvActivityList.Size = new System.Drawing.Size(997, 291);
            this.gvActivityList.TabIndex = 18;
            this.gvActivityList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvActivityList_CellClick);
            this.gvActivityList.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.gvActivityList_UserDeletingRow);
            // 
            // Column17
            // 
            this.Column17.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column17.DataPropertyName = "MainActivity";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column17.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column17.HeaderText = "Activity";
            this.Column17.Name = "Column17";
            this.Column17.ReadOnly = true;
            // 
            // Column19
            // 
            this.Column19.DataPropertyName = "ActDuration";
            this.Column19.HeaderText = "Time Duration";
            this.Column19.Name = "Column19";
            this.Column19.ReadOnly = true;
            // 
            // Column20
            // 
            this.Column20.DataPropertyName = "ActManHours";
            this.Column20.HeaderText = "Avg Man Hours";
            this.Column20.Name = "Column20";
            this.Column20.ReadOnly = true;
            this.Column20.Width = 150;
            // 
            // gpSTDBatch
            // 
            this.gpSTDBatch.Controls.Add(this.txtSTDBatchID);
            this.gpSTDBatch.Controls.Add(this.label16);
            this.gpSTDBatch.Controls.Add(this.label14);
            this.gpSTDBatch.Controls.Add(this.txtRemarks);
            this.gpSTDBatch.Controls.Add(this.label12);
            this.gpSTDBatch.Controls.Add(this.label15);
            this.gpSTDBatch.Controls.Add(this.txtBatchDuration);
            this.gpSTDBatch.Controls.Add(this.lblUnit);
            this.gpSTDBatch.Controls.Add(this.txtBatchSize);
            this.gpSTDBatch.Controls.Add(this.cmbProductType);
            this.gpSTDBatch.Controls.Add(this.label3);
            this.gpSTDBatch.Controls.Add(this.cmbProductCode);
            this.gpSTDBatch.Controls.Add(this.label1);
            this.gpSTDBatch.Controls.Add(this.label2);
            this.gpSTDBatch.Location = new System.Drawing.Point(6, 19);
            this.gpSTDBatch.Name = "gpSTDBatch";
            this.gpSTDBatch.Size = new System.Drawing.Size(601, 223);
            this.gpSTDBatch.TabIndex = 1;
            this.gpSTDBatch.TabStop = false;
            // 
            // txtSTDBatchID
            // 
            this.txtSTDBatchID.Location = new System.Drawing.Point(120, 16);
            this.txtSTDBatchID.Name = "txtSTDBatchID";
            this.txtSTDBatchID.ReadOnly = true;
            this.txtSTDBatchID.Size = new System.Drawing.Size(222, 21);
            this.txtSTDBatchID.TabIndex = 122;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(25, 22);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(89, 15);
            this.label16.TabIndex = 121;
            this.label16.Text = "STD Batch ID : ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(328, 126);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(91, 15);
            this.label14.TabIndex = 118;
            this.label14.Text = "Time Duration :";
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(120, 154);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRemarks.Size = new System.Drawing.Size(359, 36);
            this.txtRemarks.TabIndex = 117;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(48, 154);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 15);
            this.label12.TabIndex = 116;
            this.label12.Text = "Remarks : ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(488, 126);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(34, 15);
            this.label15.TabIndex = 120;
            this.label15.Text = "Days";
            // 
            // txtBatchDuration
            // 
            this.txtBatchDuration.Location = new System.Drawing.Point(444, 120);
            this.txtBatchDuration.Name = "txtBatchDuration";
            this.txtBatchDuration.Size = new System.Drawing.Size(38, 21);
            this.txtBatchDuration.TabIndex = 119;
            this.txtBatchDuration.Text = "0.00";
            this.txtBatchDuration.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBatchSize_KeyPress);
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Location = new System.Drawing.Point(239, 122);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(33, 15);
            this.lblUnit.TabIndex = 114;
            this.lblUnit.Text = "[unit]";
            // 
            // txtBatchSize
            // 
            this.txtBatchSize.Location = new System.Drawing.Point(120, 123);
            this.txtBatchSize.Name = "txtBatchSize";
            this.txtBatchSize.Size = new System.Drawing.Size(113, 21);
            this.txtBatchSize.TabIndex = 5;
            this.txtBatchSize.Text = "0.00";
            this.txtBatchSize.TextChanged += new System.EventHandler(this.txtBatchSize_TextChanged);
            this.txtBatchSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBatchSize_KeyPress);
            // 
            // cmbProductType
            // 
            this.cmbProductType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbProductType.DisplayMember = "Code";
            this.cmbProductType.FormattingEnabled = true;
            this.cmbProductType.Items.AddRange(new object[] {
            "Semi Processed Product",
            "Basic Product",
            "Finish Product"});
            this.cmbProductType.Location = new System.Drawing.Point(120, 54);
            this.cmbProductType.Name = "cmbProductType";
            this.cmbProductType.Size = new System.Drawing.Size(359, 23);
            this.cmbProductType.TabIndex = 113;
            this.cmbProductType.Text = "-- Select Product Type --";
            this.cmbProductType.ValueMember = "ProductID";
            this.cmbProductType.SelectedIndexChanged += new System.EventHandler(this.cmbProductType_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Batch Size : ";
            // 
            // cmbProductCode
            // 
            this.cmbProductCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbProductCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbProductCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbProductCode.DisplayMember = "Code";
            this.cmbProductCode.FormattingEnabled = true;
            this.cmbProductCode.Location = new System.Drawing.Point(120, 88);
            this.cmbProductCode.Name = "cmbProductCode";
            this.cmbProductCode.Size = new System.Drawing.Size(359, 23);
            this.cmbProductCode.TabIndex = 111;
            this.cmbProductCode.Text = "--Select Product--";
            this.cmbProductCode.ValueMember = "ProductID";
            this.cmbProductCode.SelectedIndexChanged += new System.EventHandler(this.cmbProductCode_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 112;
            this.label1.Text = " Product Type : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 110;
            this.label2.Text = " Product : ";
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(913, 254);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 26);
            this.btnDelete.TabIndex = 115;
            this.btnDelete.Text = "<<Remove";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(613, 254);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(110, 26);
            this.btnAdd.TabIndex = 115;
            this.btnAdd.Text = "Add >>";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(864, 603);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 29);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(945, 603);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 29);
            this.button3.TabIndex = 15;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // gpMain
            // 
            this.gpMain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gpMain.Controls.Add(this.pnlQualityInspection);
            this.gpMain.Controls.Add(this.pnlWeightControl);
            this.gpMain.Controls.Add(this.pnlOther);
            this.gpMain.Location = new System.Drawing.Point(613, 19);
            this.gpMain.Name = "gpMain";
            this.gpMain.Size = new System.Drawing.Size(394, 223);
            this.gpMain.TabIndex = 9;
            this.gpMain.TabStop = false;
            this.gpMain.Text = "Existing STD Batch List";
            this.gpMain.Visible = false;
            // 
            // pnlQualityInspection
            // 
            this.pnlQualityInspection.BackColor = System.Drawing.SystemColors.Control;
            this.pnlQualityInspection.Controls.Add(this.groupBox19);
            this.pnlQualityInspection.Location = new System.Drawing.Point(5, 5778);
            this.pnlQualityInspection.Name = "pnlQualityInspection";
            this.pnlQualityInspection.Size = new System.Drawing.Size(946, 269);
            this.pnlQualityInspection.TabIndex = 29;
            this.pnlQualityInspection.Visible = false;
            // 
            // groupBox19
            // 
            this.groupBox19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox19.Location = new System.Drawing.Point(0, 0);
            this.groupBox19.Name = "groupBox19";
            this.groupBox19.Size = new System.Drawing.Size(946, 269);
            this.groupBox19.TabIndex = 0;
            this.groupBox19.TabStop = false;
            this.groupBox19.Text = "Final Product Quality Inspection";
            // 
            // pnlWeightControl
            // 
            this.pnlWeightControl.BackColor = System.Drawing.SystemColors.Control;
            this.pnlWeightControl.Controls.Add(this.label39);
            this.pnlWeightControl.Location = new System.Drawing.Point(2, 5166);
            this.pnlWeightControl.Name = "pnlWeightControl";
            this.pnlWeightControl.Size = new System.Drawing.Size(946, 269);
            this.pnlWeightControl.TabIndex = 23;
            this.pnlWeightControl.Visible = false;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(11, 11);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(45, 15);
            this.label39.TabIndex = 0;
            this.label39.Text = "Weight";
            // 
            // pnlOther
            // 
            this.pnlOther.BackColor = System.Drawing.SystemColors.Control;
            this.pnlOther.Controls.Add(this.label51);
            this.pnlOther.Location = new System.Drawing.Point(0, 2194);
            this.pnlOther.Name = "pnlOther";
            this.pnlOther.Size = new System.Drawing.Size(946, 269);
            this.pnlOther.TabIndex = 22;
            this.pnlOther.Visible = false;
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(15, 11);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(88, 15);
            this.label51.TabIndex = 0;
            this.label51.Text = "No Instructions";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MainActivity";
            this.dataGridViewTextBoxColumn1.HeaderText = "Activity";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ActDuration";
            this.dataGridViewTextBoxColumn2.HeaderText = "Time Duration";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ActManHours";
            this.dataGridViewTextBoxColumn3.HeaderText = "Avg Man Hours";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Time";
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn4.HeaderText = "Estimated Hours";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // frmStandardBatch
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1028, 638);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(990, 665);
            this.Name = "frmStandardBatch";
            this.Text = "Standard Batch";
            this.Load += new System.EventHandler(this.frmStandardBatch_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvActivityList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceActivity)).EndInit();
            this.gpSTDBatch.ResumeLayout(false);
            this.gpSTDBatch.PerformLayout();
            this.gpMain.ResumeLayout(false);
            this.pnlQualityInspection.ResumeLayout(false);
            this.pnlWeightControl.ResumeLayout(false);
            this.pnlWeightControl.PerformLayout();
            this.pnlOther.ResumeLayout(false);
            this.pnlOther.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceMainActivityList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBatchSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gpMain;
        private System.Windows.Forms.Panel pnlOther;
        private System.Windows.Forms.Panel pnlQualityInspection;
        private System.Windows.Forms.Panel pnlWeightControl;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.GroupBox groupBox19;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.ComboBox cmbProductType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbProductCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gpSTDBatch;
        private System.Windows.Forms.DataGridView gvActivityList;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.BindingSource objSourceActivity;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtBatchDuration;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtSTDBatchID;
        private System.Windows.Forms.ComboBox cmbActivity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.BindingSource objSourceProducts;
        private System.Windows.Forms.ComboBox cmbPart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource objSourceMainActivityList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column17;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column19;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column20;
    }
}