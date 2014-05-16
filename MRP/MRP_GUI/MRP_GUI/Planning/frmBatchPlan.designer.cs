namespace ProductionPlan
{
    partial class frmBatchPlan
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
            this.cmbCategoryList = new System.Windows.Forms.ComboBox();
            this.dgvBatchList = new System.Windows.Forms.DataGridView();
            this.Week = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BatchSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.objSourceCategoryList = new System.Windows.Forms.BindingSource(this.components);
            this.objSourceBasicProductList = new System.Windows.Forms.BindingSource(this.components);
            this.objSourceSTDBatches = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.lstBasicProductList = new System.Windows.Forms.ListBox();
            this.objSourceBatchListWeekly = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpWeek4Stop = new System.Windows.Forms.DateTimePicker();
            this.dtpWeek4Start = new System.Windows.Forms.DateTimePicker();
            this.dtpWeek3Stop = new System.Windows.Forms.DateTimePicker();
            this.dtpWeek1Start = new System.Windows.Forms.DateTimePicker();
            this.dtpWeek3Start = new System.Windows.Forms.DateTimePicker();
            this.dtpWeek2Stop = new System.Windows.Forms.DateTimePicker();
            this.dtpWeek2Start = new System.Windows.Forms.DateTimePicker();
            this.dtpWeek1Stop = new System.Windows.Forms.DateTimePicker();
            this.grpWeekSelection = new System.Windows.Forms.GroupBox();
            this.rdbWeek04 = new System.Windows.Forms.RadioButton();
            this.rdbWeek03 = new System.Windows.Forms.RadioButton();
            this.rdbWeek02 = new System.Windows.Forms.RadioButton();
            this.rdbWeek01 = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtBatchSize = new System.Windows.Forms.TextBox();
            this.cmbBatchSize = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBatchList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceCategoryList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceBasicProductList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceSTDBatches)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceBatchListWeekly)).BeginInit();
            this.panel1.SuspendLayout();
            this.grpWeekSelection.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbCategoryList
            // 
            this.cmbCategoryList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCategoryList.DisplayMember = "BasicProductSubCategory";
            this.cmbCategoryList.FormattingEnabled = true;
            this.cmbCategoryList.Location = new System.Drawing.Point(15, 36);
            this.cmbCategoryList.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCategoryList.Name = "cmbCategoryList";
            this.cmbCategoryList.Size = new System.Drawing.Size(330, 26);
            this.cmbCategoryList.TabIndex = 0;
            this.cmbCategoryList.ValueMember = "BasicProductSubCategory";
            this.cmbCategoryList.SelectedIndexChanged += new System.EventHandler(this.cmbCategoryList_SelectedIndexChanged);
            // 
            // dgvBatchList
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            this.dgvBatchList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBatchList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBatchList.BackgroundColor = System.Drawing.Color.Tan;
            this.dgvBatchList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBatchList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Week,
            this.Product,
            this.ProductName,
            this.BatchSize,
            this.Nos});
            this.dgvBatchList.GridColor = System.Drawing.SystemColors.Control;
            this.dgvBatchList.Location = new System.Drawing.Point(379, 173);
            this.dgvBatchList.Margin = new System.Windows.Forms.Padding(4);
            this.dgvBatchList.Name = "dgvBatchList";
            this.dgvBatchList.Size = new System.Drawing.Size(620, 426);
            this.dgvBatchList.TabIndex = 3;
            // 
            // Week
            // 
            this.Week.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Week.DataPropertyName = "WeekID";
            this.Week.FillWeight = 50F;
            this.Week.HeaderText = "Week";
            this.Week.Name = "Week";
            // 
            // Product
            // 
            this.Product.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Product.DataPropertyName = "ProductCode";
            this.Product.HeaderText = "Product";
            this.Product.Name = "Product";
            // 
            // ProductName
            // 
            this.ProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductName.DataPropertyName = "ProductName";
            this.ProductName.FillWeight = 200F;
            this.ProductName.HeaderText = "ProductName";
            this.ProductName.Name = "ProductName";
            // 
            // BatchSize
            // 
            this.BatchSize.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BatchSize.DataPropertyName = "BatchSize";
            this.BatchSize.FillWeight = 70F;
            this.BatchSize.HeaderText = "BatchSize";
            this.BatchSize.Name = "BatchSize";
            // 
            // Nos
            // 
            this.Nos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nos.DataPropertyName = "Nos";
            this.Nos.FillWeight = 50F;
            this.Nos.HeaderText = "Nos";
            this.Nos.Name = "Nos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Product Category";
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.Olive;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Location = new System.Drawing.Point(520, 135);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(117, 30);
            this.btnCreate.TabIndex = 5;
            this.btnCreate.Text = "Create >>";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackColor = System.Drawing.Color.Olive;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(904, 138);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(95, 30);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "<< Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 18);
            this.label2.TabIndex = 13;
            this.label2.Text = "Month";
            // 
            // cmbMonth
            // 
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Location = new System.Drawing.Point(84, 43);
            this.cmbMonth.Margin = new System.Windows.Forms.Padding(4);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(164, 26);
            this.cmbMonth.TabIndex = 14;
            this.cmbMonth.SelectedIndexChanged += new System.EventHandler(this.cmbMonth_SelectedIndexChanged);
            // 
            // lstBasicProductList
            // 
            this.lstBasicProductList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.lstBasicProductList.BackColor = System.Drawing.Color.Tan;
            this.lstBasicProductList.DisplayMember = "BasicProductDescription";
            this.lstBasicProductList.FormattingEnabled = true;
            this.lstBasicProductList.ItemHeight = 18;
            this.lstBasicProductList.Location = new System.Drawing.Point(3, 90);
            this.lstBasicProductList.Name = "lstBasicProductList";
            this.lstBasicProductList.Size = new System.Drawing.Size(362, 508);
            this.lstBasicProductList.TabIndex = 15;
            this.lstBasicProductList.ValueMember = "BasicProductCode";
            this.lstBasicProductList.SelectedIndexChanged += new System.EventHandler(this.lstBasicProductList_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 18);
            this.label3.TabIndex = 17;
            this.label3.Text = "Year";
            // 
            // cmbYear
            // 
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Items.AddRange(new object[] {
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030"});
            this.cmbYear.Location = new System.Drawing.Point(84, 13);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(128, 26);
            this.cmbYear.TabIndex = 18;
            this.cmbYear.SelectedIndexChanged += new System.EventHandler(this.cmbYear_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cmbYear);
            this.panel1.Controls.Add(this.cmbMonth);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(379, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(258, 80);
            this.panel1.TabIndex = 19;
            // 
            // dtpWeek4Stop
            // 
            this.dtpWeek4Stop.CalendarFont = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpWeek4Stop.Enabled = false;
            this.dtpWeek4Stop.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpWeek4Stop.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpWeek4Stop.Location = new System.Drawing.Point(904, 97);
            this.dtpWeek4Stop.Name = "dtpWeek4Stop";
            this.dtpWeek4Stop.Size = new System.Drawing.Size(94, 23);
            this.dtpWeek4Stop.TabIndex = 27;
            // 
            // dtpWeek4Start
            // 
            this.dtpWeek4Start.CalendarFont = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpWeek4Start.Enabled = false;
            this.dtpWeek4Start.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpWeek4Start.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpWeek4Start.Location = new System.Drawing.Point(796, 97);
            this.dtpWeek4Start.Name = "dtpWeek4Start";
            this.dtpWeek4Start.Size = new System.Drawing.Size(94, 23);
            this.dtpWeek4Start.TabIndex = 26;
            // 
            // dtpWeek3Stop
            // 
            this.dtpWeek3Stop.CalendarFont = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpWeek3Stop.Enabled = false;
            this.dtpWeek3Stop.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpWeek3Stop.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpWeek3Stop.Location = new System.Drawing.Point(904, 68);
            this.dtpWeek3Stop.Name = "dtpWeek3Stop";
            this.dtpWeek3Stop.Size = new System.Drawing.Size(94, 23);
            this.dtpWeek3Stop.TabIndex = 25;
            // 
            // dtpWeek1Start
            // 
            this.dtpWeek1Start.CalendarFont = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpWeek1Start.Enabled = false;
            this.dtpWeek1Start.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpWeek1Start.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpWeek1Start.Location = new System.Drawing.Point(796, 10);
            this.dtpWeek1Start.Name = "dtpWeek1Start";
            this.dtpWeek1Start.Size = new System.Drawing.Size(94, 23);
            this.dtpWeek1Start.TabIndex = 24;
            // 
            // dtpWeek3Start
            // 
            this.dtpWeek3Start.CalendarFont = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpWeek3Start.Enabled = false;
            this.dtpWeek3Start.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpWeek3Start.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpWeek3Start.Location = new System.Drawing.Point(796, 68);
            this.dtpWeek3Start.Name = "dtpWeek3Start";
            this.dtpWeek3Start.Size = new System.Drawing.Size(94, 23);
            this.dtpWeek3Start.TabIndex = 23;
            // 
            // dtpWeek2Stop
            // 
            this.dtpWeek2Stop.CalendarFont = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpWeek2Stop.Enabled = false;
            this.dtpWeek2Stop.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpWeek2Stop.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpWeek2Stop.Location = new System.Drawing.Point(904, 39);
            this.dtpWeek2Stop.Name = "dtpWeek2Stop";
            this.dtpWeek2Stop.Size = new System.Drawing.Size(94, 23);
            this.dtpWeek2Stop.TabIndex = 22;
            // 
            // dtpWeek2Start
            // 
            this.dtpWeek2Start.CalendarFont = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpWeek2Start.Enabled = false;
            this.dtpWeek2Start.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpWeek2Start.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpWeek2Start.Location = new System.Drawing.Point(796, 39);
            this.dtpWeek2Start.Name = "dtpWeek2Start";
            this.dtpWeek2Start.Size = new System.Drawing.Size(94, 23);
            this.dtpWeek2Start.TabIndex = 21;
            // 
            // dtpWeek1Stop
            // 
            this.dtpWeek1Stop.CalendarFont = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpWeek1Stop.Enabled = false;
            this.dtpWeek1Stop.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpWeek1Stop.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpWeek1Stop.Location = new System.Drawing.Point(904, 10);
            this.dtpWeek1Stop.Name = "dtpWeek1Stop";
            this.dtpWeek1Stop.Size = new System.Drawing.Size(94, 23);
            this.dtpWeek1Stop.TabIndex = 20;
            // 
            // grpWeekSelection
            // 
            this.grpWeekSelection.Controls.Add(this.rdbWeek04);
            this.grpWeekSelection.Controls.Add(this.rdbWeek03);
            this.grpWeekSelection.Controls.Add(this.rdbWeek02);
            this.grpWeekSelection.Controls.Add(this.rdbWeek01);
            this.grpWeekSelection.Location = new System.Drawing.Point(643, 4);
            this.grpWeekSelection.Name = "grpWeekSelection";
            this.grpWeekSelection.Size = new System.Drawing.Size(127, 118);
            this.grpWeekSelection.TabIndex = 19;
            this.grpWeekSelection.TabStop = false;
            this.grpWeekSelection.Text = "Select the Week";
            // 
            // rdbWeek04
            // 
            this.rdbWeek04.AutoSize = true;
            this.rdbWeek04.Location = new System.Drawing.Point(13, 93);
            this.rdbWeek04.Name = "rdbWeek04";
            this.rdbWeek04.Size = new System.Drawing.Size(79, 22);
            this.rdbWeek04.TabIndex = 12;
            this.rdbWeek04.Text = "Week 04";
            this.rdbWeek04.UseVisualStyleBackColor = true;
            this.rdbWeek04.CheckedChanged += new System.EventHandler(this.rdbWeek04_CheckedChanged);
            // 
            // rdbWeek03
            // 
            this.rdbWeek03.AutoSize = true;
            this.rdbWeek03.Location = new System.Drawing.Point(13, 69);
            this.rdbWeek03.Name = "rdbWeek03";
            this.rdbWeek03.Size = new System.Drawing.Size(79, 22);
            this.rdbWeek03.TabIndex = 11;
            this.rdbWeek03.Text = "Week 03";
            this.rdbWeek03.UseVisualStyleBackColor = true;
            this.rdbWeek03.CheckedChanged += new System.EventHandler(this.rdbWeek03_CheckedChanged);
            // 
            // rdbWeek02
            // 
            this.rdbWeek02.AutoSize = true;
            this.rdbWeek02.Location = new System.Drawing.Point(13, 46);
            this.rdbWeek02.Name = "rdbWeek02";
            this.rdbWeek02.Size = new System.Drawing.Size(79, 22);
            this.rdbWeek02.TabIndex = 10;
            this.rdbWeek02.Text = "Week 02";
            this.rdbWeek02.UseVisualStyleBackColor = true;
            this.rdbWeek02.CheckedChanged += new System.EventHandler(this.rdbWeek02_CheckedChanged);
            // 
            // rdbWeek01
            // 
            this.rdbWeek01.AutoSize = true;
            this.rdbWeek01.Checked = true;
            this.rdbWeek01.Location = new System.Drawing.Point(13, 25);
            this.rdbWeek01.Name = "rdbWeek01";
            this.rdbWeek01.Size = new System.Drawing.Size(79, 22);
            this.rdbWeek01.TabIndex = 9;
            this.rdbWeek01.TabStop = true;
            this.rdbWeek01.Text = "Week 01";
            this.rdbWeek01.UseVisualStyleBackColor = true;
            this.rdbWeek01.CheckedChanged += new System.EventHandler(this.rdbWeek01_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.BurlyWood;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cmbCategoryList);
            this.panel2.Location = new System.Drawing.Point(3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(362, 80);
            this.panel2.TabIndex = 20;
            // 
            // txtBatchSize
            // 
            this.txtBatchSize.Location = new System.Drawing.Point(379, 138);
            this.txtBatchSize.Name = "txtBatchSize";
            this.txtBatchSize.Size = new System.Drawing.Size(134, 26);
            this.txtBatchSize.TabIndex = 21;
            // 
            // cmbBatchSize
            // 
            this.cmbBatchSize.DisplayMember = "STDBatchSize";
            this.cmbBatchSize.FormattingEnabled = true;
            this.cmbBatchSize.Location = new System.Drawing.Point(379, 106);
            this.cmbBatchSize.Name = "cmbBatchSize";
            this.cmbBatchSize.Size = new System.Drawing.Size(134, 26);
            this.cmbBatchSize.TabIndex = 28;
            this.cmbBatchSize.ValueMember = "STDBatchSize";
            this.cmbBatchSize.SelectedIndexChanged += new System.EventHandler(this.cmbBatchSize_SelectedIndexChanged);
            this.cmbBatchSize.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbBatchSize_KeyDown);
            // 
            // frmBatchPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(1004, 612);
            this.Controls.Add(this.cmbBatchSize);
            this.Controls.Add(this.dtpWeek4Stop);
            this.Controls.Add(this.txtBatchSize);
            this.Controls.Add(this.dtpWeek4Start);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dtpWeek3Stop);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtpWeek1Start);
            this.Controls.Add(this.lstBasicProductList);
            this.Controls.Add(this.dtpWeek3Start);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dtpWeek2Stop);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.dtpWeek2Start);
            this.Controls.Add(this.dtpWeek1Stop);
            this.Controls.Add(this.dgvBatchList);
            this.Controls.Add(this.grpWeekSelection);
            this.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmBatchPlan";
            this.Text = "Batch Plan";
            this.Load += new System.EventHandler(this.frmBatchPlan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBatchList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceCategoryList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceBasicProductList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceSTDBatches)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceBatchListWeekly)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grpWeekSelection.ResumeLayout(false);
            this.grpWeekSelection.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBatchList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.BindingSource objSourceCategoryList;
        private System.Windows.Forms.ComboBox cmbCategoryList;
        private System.Windows.Forms.BindingSource objSourceBasicProductList;
        private System.Windows.Forms.BindingSource objSourceSTDBatches;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.ListBox lstBasicProductList;
        private System.Windows.Forms.BindingSource objSourceBatchListWeekly;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox grpWeekSelection;
        private System.Windows.Forms.RadioButton rdbWeek04;
        private System.Windows.Forms.RadioButton rdbWeek03;
        private System.Windows.Forms.RadioButton rdbWeek02;
        private System.Windows.Forms.RadioButton rdbWeek01;
        private System.Windows.Forms.DateTimePicker dtpWeek4Stop;
        private System.Windows.Forms.DateTimePicker dtpWeek4Start;
        private System.Windows.Forms.DateTimePicker dtpWeek3Stop;
        private System.Windows.Forms.DateTimePicker dtpWeek1Start;
        private System.Windows.Forms.DateTimePicker dtpWeek3Start;
        private System.Windows.Forms.DateTimePicker dtpWeek2Stop;
        private System.Windows.Forms.DateTimePicker dtpWeek2Start;
        private System.Windows.Forms.DateTimePicker dtpWeek1Stop;
        private System.Windows.Forms.TextBox txtBatchSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn Week;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BatchSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nos;
        private System.Windows.Forms.ComboBox cmbBatchSize;
    }
}