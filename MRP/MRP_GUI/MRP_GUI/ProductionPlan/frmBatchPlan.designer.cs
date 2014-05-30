﻿namespace MRP_GUI
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmbCategoryList = new System.Windows.Forms.ComboBox();
            this.dgvBatchList = new System.Windows.Forms.DataGridView();
            this.RevisionIDD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Week = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BatchSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.lstBasicProductList = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtBatchSize = new System.Windows.Forms.TextBox();
            this.dgvWeeks = new System.Windows.Forms.DataGridView();
            this.RevisionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WeekIDD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FromDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNos = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblAvailability = new System.Windows.Forms.Label();
            this.objSourceCategoryList = new System.Windows.Forms.BindingSource(this.components);
            this.objSourceBasicProductList = new System.Windows.Forms.BindingSource(this.components);
            this.objSourceWeeks = new System.Windows.Forms.BindingSource(this.components);
            this.objSourceBatchListWeekly = new System.Windows.Forms.BindingSource(this.components);
            this.btnFinalize = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBatchList)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWeeks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceCategoryList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceBasicProductList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceWeeks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceBatchListWeekly)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbCategoryList
            // 
            this.cmbCategoryList.DisplayMember = "ProductCategory";
            this.cmbCategoryList.FormattingEnabled = true;
            this.cmbCategoryList.Location = new System.Drawing.Point(15, 36);
            this.cmbCategoryList.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCategoryList.Name = "cmbCategoryList";
            this.cmbCategoryList.Size = new System.Drawing.Size(330, 26);
            this.cmbCategoryList.TabIndex = 0;
            this.cmbCategoryList.ValueMember = "ProductCatID";
            this.cmbCategoryList.SelectedIndexChanged += new System.EventHandler(this.cmbCategoryList_SelectedIndexChanged);
            // 
            // dgvBatchList
            // 
            this.dgvBatchList.AllowUserToAddRows = false;
            this.dgvBatchList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            this.dgvBatchList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBatchList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBatchList.BackgroundColor = System.Drawing.Color.Tan;
            this.dgvBatchList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBatchList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RevisionIDD,
            this.Week,
            this.Product,
            this.ProductName,
            this.BatchSize,
            this.Nos});
            this.dgvBatchList.GridColor = System.Drawing.SystemColors.Control;
            this.dgvBatchList.Location = new System.Drawing.Point(379, 232);
            this.dgvBatchList.Margin = new System.Windows.Forms.Padding(4);
            this.dgvBatchList.Name = "dgvBatchList";
            this.dgvBatchList.ReadOnly = true;
            this.dgvBatchList.Size = new System.Drawing.Size(620, 367);
            this.dgvBatchList.TabIndex = 3;
            // 
            // RevisionIDD
            // 
            this.RevisionIDD.DataPropertyName = "RevisionID";
            this.RevisionIDD.HeaderText = "RevisionID";
            this.RevisionIDD.Name = "RevisionIDD";
            this.RevisionIDD.ReadOnly = true;
            this.RevisionIDD.Visible = false;
            // 
            // Week
            // 
            this.Week.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Week.DataPropertyName = "WeekID";
            this.Week.FillWeight = 50F;
            this.Week.HeaderText = "Week";
            this.Week.Name = "Week";
            this.Week.ReadOnly = true;
            // 
            // Product
            // 
            this.Product.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Product.DataPropertyName = "ProductCode";
            this.Product.HeaderText = "Product";
            this.Product.Name = "Product";
            this.Product.ReadOnly = true;
            // 
            // ProductName
            // 
            this.ProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductName.DataPropertyName = "ProductName";
            this.ProductName.FillWeight = 200F;
            this.ProductName.HeaderText = "ProductName";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            // 
            // BatchSize
            // 
            this.BatchSize.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BatchSize.DataPropertyName = "BatchSize";
            this.BatchSize.FillWeight = 70F;
            this.BatchSize.HeaderText = "BatchSize";
            this.BatchSize.Name = "BatchSize";
            this.BatchSize.ReadOnly = true;
            // 
            // Nos
            // 
            this.Nos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nos.DataPropertyName = "Nos";
            this.Nos.FillWeight = 50F;
            this.Nos.HeaderText = "Nos";
            this.Nos.Name = "Nos";
            this.Nos.ReadOnly = true;
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
            this.btnCreate.Location = new System.Drawing.Point(545, 119);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(92, 30);
            this.btnCreate.TabIndex = 5;
            this.btnCreate.Text = "Create >>";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Olive;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(545, 151);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(92, 30);
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
            this.cmbMonth.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
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
            this.cmbYear.Size = new System.Drawing.Size(164, 26);
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
            this.txtBatchSize.Location = new System.Drawing.Point(456, 122);
            this.txtBatchSize.Name = "txtBatchSize";
            this.txtBatchSize.Size = new System.Drawing.Size(82, 26);
            this.txtBatchSize.TabIndex = 21;
            // 
            // dgvWeeks
            // 
            this.dgvWeeks.AllowUserToAddRows = false;
            this.dgvWeeks.AllowUserToDeleteRows = false;
            this.dgvWeeks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvWeeks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWeeks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RevisionID,
            this.WeekIDD,
            this.FromDate,
            this.ToDate});
            this.dgvWeeks.Location = new System.Drawing.Point(657, 4);
            this.dgvWeeks.Name = "dgvWeeks";
            this.dgvWeeks.ReadOnly = true;
            this.dgvWeeks.Size = new System.Drawing.Size(342, 221);
            this.dgvWeeks.TabIndex = 29;
            this.dgvWeeks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWeeks_CellClick);
            // 
            // RevisionID
            // 
            this.RevisionID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RevisionID.DataPropertyName = "RevisionID";
            this.RevisionID.HeaderText = "RevisionID";
            this.RevisionID.Name = "RevisionID";
            this.RevisionID.ReadOnly = true;
            // 
            // WeekIDD
            // 
            this.WeekIDD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.WeekIDD.DataPropertyName = "WeekID";
            this.WeekIDD.HeaderText = "WeekID";
            this.WeekIDD.Name = "WeekIDD";
            this.WeekIDD.ReadOnly = true;
            // 
            // FromDate
            // 
            this.FromDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FromDate.DataPropertyName = "FromDate";
            this.FromDate.HeaderText = "FromDate";
            this.FromDate.Name = "FromDate";
            this.FromDate.ReadOnly = true;
            // 
            // ToDate
            // 
            this.ToDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ToDate.DataPropertyName = "ToDate";
            this.ToDate.HeaderText = "ToDate";
            this.ToDate.Name = "ToDate";
            this.ToDate.ReadOnly = true;
            // 
            // txtNos
            // 
            this.txtNos.Location = new System.Drawing.Point(456, 154);
            this.txtNos.Name = "txtNos";
            this.txtNos.Size = new System.Drawing.Size(82, 26);
            this.txtNos.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(376, 131);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 18);
            this.label4.TabIndex = 13;
            this.label4.Text = "Batch Size";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(414, 163);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 18);
            this.label5.TabIndex = 13;
            this.label5.Text = "Nos";
            // 
            // lblAvailability
            // 
            this.lblAvailability.AutoSize = true;
            this.lblAvailability.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailability.ForeColor = System.Drawing.Color.Navy;
            this.lblAvailability.Location = new System.Drawing.Point(375, 90);
            this.lblAvailability.Name = "lblAvailability";
            this.lblAvailability.Size = new System.Drawing.Size(204, 19);
            this.lblAvailability.TabIndex = 31;
            this.lblAvailability.Text = "Forecasted Requirement : 00";
            // 
            // btnFinalize
            // 
            this.btnFinalize.Location = new System.Drawing.Point(456, 186);
            this.btnFinalize.Name = "btnFinalize";
            this.btnFinalize.Size = new System.Drawing.Size(181, 39);
            this.btnFinalize.TabIndex = 34;
            this.btnFinalize.Text = "Finalize";
            this.btnFinalize.UseVisualStyleBackColor = true;
            // 
            // frmBatchPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(1004, 612);
            this.Controls.Add(this.btnFinalize);
            this.Controls.Add(this.lblAvailability);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNos);
            this.Controls.Add(this.dgvWeeks);
            this.Controls.Add(this.txtBatchSize);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lstBasicProductList);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.dgvBatchList);
            this.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmBatchPlan";
            this.Text = "Batch Plan";
            this.Load += new System.EventHandler(this.frmBatchPlan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBatchList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWeeks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceCategoryList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceBasicProductList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceWeeks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceBatchListWeekly)).EndInit();
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
        private System.Windows.Forms.BindingSource objSourceWeeks;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.ListBox lstBasicProductList;
        private System.Windows.Forms.BindingSource objSourceBatchListWeekly;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtBatchSize;
        private System.Windows.Forms.DataGridView dgvWeeks;
        private System.Windows.Forms.DataGridViewTextBoxColumn RevisionID;
        private System.Windows.Forms.DataGridViewTextBoxColumn WeekIDD;
        private System.Windows.Forms.DataGridViewTextBoxColumn FromDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToDate;
        private System.Windows.Forms.TextBox txtNos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn RevisionIDD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Week;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BatchSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nos;
        private System.Windows.Forms.Label lblAvailability;
        private System.Windows.Forms.Button btnFinalize;
    }
}