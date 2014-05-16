namespace MRP_GUI
{
    partial class frmDepartmentPlanningWeeks
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtpFirstWeekStart = new System.Windows.Forms.DateTimePicker();
            this.dtpFirstWeekStop = new System.Windows.Forms.DateTimePicker();
            this.grpDepartmentPlanningWeeks = new System.Windows.Forms.GroupBox();
            this.dgvDepartmentPlanningList = new System.Windows.Forms.DataGridView();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Month = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Week = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.From = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.To = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.objSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnFinalize = new System.Windows.Forms.Button();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnView = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbWeekID = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grpDepartmentPlanningWeeks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartmentPlanningList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpFirstWeekStart
            // 
            this.dtpFirstWeekStart.Location = new System.Drawing.Point(79, 51);
            this.dtpFirstWeekStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFirstWeekStart.Name = "dtpFirstWeekStart";
            this.dtpFirstWeekStart.Size = new System.Drawing.Size(218, 23);
            this.dtpFirstWeekStart.TabIndex = 4;
            // 
            // dtpFirstWeekStop
            // 
            this.dtpFirstWeekStop.Location = new System.Drawing.Point(79, 80);
            this.dtpFirstWeekStop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFirstWeekStop.Name = "dtpFirstWeekStop";
            this.dtpFirstWeekStop.Size = new System.Drawing.Size(218, 23);
            this.dtpFirstWeekStop.TabIndex = 5;
            // 
            // grpDepartmentPlanningWeeks
            // 
            this.grpDepartmentPlanningWeeks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDepartmentPlanningWeeks.Controls.Add(this.dgvDepartmentPlanningList);
            this.grpDepartmentPlanningWeeks.Location = new System.Drawing.Point(14, 135);
            this.grpDepartmentPlanningWeeks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpDepartmentPlanningWeeks.Name = "grpDepartmentPlanningWeeks";
            this.grpDepartmentPlanningWeeks.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpDepartmentPlanningWeeks.Size = new System.Drawing.Size(980, 466);
            this.grpDepartmentPlanningWeeks.TabIndex = 8;
            this.grpDepartmentPlanningWeeks.TabStop = false;
            this.grpDepartmentPlanningWeeks.Text = "Planning Weeks for the Selected Month";
            // 
            // dgvDepartmentPlanningList
            // 
            this.dgvDepartmentPlanningList.AllowUserToAddRows = false;
            this.dgvDepartmentPlanningList.AllowUserToDeleteRows = false;
            this.dgvDepartmentPlanningList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDepartmentPlanningList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepartmentPlanningList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Year,
            this.Month,
            this.Week,
            this.From,
            this.To});
            this.dgvDepartmentPlanningList.Location = new System.Drawing.Point(16, 21);
            this.dgvDepartmentPlanningList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDepartmentPlanningList.Name = "dgvDepartmentPlanningList";
            this.dgvDepartmentPlanningList.ReadOnly = true;
            this.dgvDepartmentPlanningList.Size = new System.Drawing.Size(952, 433);
            this.dgvDepartmentPlanningList.TabIndex = 0;
            // 
            // Year
            // 
            this.Year.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Year.DataPropertyName = "Year";
            this.Year.HeaderText = "Year";
            this.Year.Name = "Year";
            this.Year.ReadOnly = true;
            // 
            // Month
            // 
            this.Month.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Month.DataPropertyName = "Month";
            this.Month.HeaderText = "Month";
            this.Month.Name = "Month";
            this.Month.ReadOnly = true;
            // 
            // Week
            // 
            this.Week.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Week.DataPropertyName = "WeekID";
            this.Week.HeaderText = "Week";
            this.Week.Name = "Week";
            this.Week.ReadOnly = true;
            // 
            // From
            // 
            this.From.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.From.DataPropertyName = "FromDate";
            dataGridViewCellStyle5.Format = "D";
            dataGridViewCellStyle5.NullValue = null;
            this.From.DefaultCellStyle = dataGridViewCellStyle5;
            this.From.FillWeight = 200F;
            this.From.HeaderText = "From";
            this.From.Name = "From";
            this.From.ReadOnly = true;
            // 
            // To
            // 
            this.To.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.To.DataPropertyName = "ToDate";
            dataGridViewCellStyle6.Format = "D";
            dataGridViewCellStyle6.NullValue = null;
            this.To.DefaultCellStyle = dataGridViewCellStyle6;
            this.To.FillWeight = 200F;
            this.To.HeaderText = "To";
            this.To.Name = "To";
            this.To.ReadOnly = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Start";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "Stop";
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreate.Location = new System.Drawing.Point(398, 21);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(88, 26);
            this.btnCreate.TabIndex = 16;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnFinalize
            // 
            this.btnFinalize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFinalize.Location = new System.Drawing.Point(398, 75);
            this.btnFinalize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFinalize.Name = "btnFinalize";
            this.btnFinalize.Size = new System.Drawing.Size(88, 26);
            this.btnFinalize.TabIndex = 17;
            this.btnFinalize.Text = "Finalize";
            this.btnFinalize.UseVisualStyleBackColor = true;
            this.btnFinalize.Click += new System.EventHandler(this.btnFinalize_Click);
            // 
            // cmbYear
            // 
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Items.AddRange(new object[] {
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
            this.cmbYear.Location = new System.Drawing.Point(57, 29);
            this.cmbYear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(94, 23);
            this.cmbYear.TabIndex = 18;
            this.cmbYear.SelectedIndexChanged += new System.EventHandler(this.cmbYear_SelectedIndexChanged);
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
            this.cmbMonth.Location = new System.Drawing.Point(206, 29);
            this.cmbMonth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(249, 23);
            this.cmbMonth.TabIndex = 19;
            this.cmbMonth.SelectedIndexChanged += new System.EventHandler(this.cmbMonth_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 15);
            this.label5.TabIndex = 20;
            this.label5.Text = "Year";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(157, 37);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(43, 15);
            this.label14.TabIndex = 20;
            this.label14.Text = "Month";
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(22, 75);
            this.btnView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(73, 28);
            this.btnView.TabIndex = 21;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 23;
            this.label1.Text = "Week";
            // 
            // cmbWeekID
            // 
            this.cmbWeekID.FormattingEnabled = true;
            this.cmbWeekID.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cmbWeekID.Location = new System.Drawing.Point(79, 22);
            this.cmbWeekID.Name = "cmbWeekID";
            this.cmbWeekID.Size = new System.Drawing.Size(50, 23);
            this.cmbWeekID.TabIndex = 24;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnView);
            this.groupBox1.Controls.Add(this.cmbMonth);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.cmbYear);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(478, 116);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Please Select the Plan Month";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dtpFirstWeekStart);
            this.groupBox2.Controls.Add(this.btnFinalize);
            this.groupBox2.Controls.Add(this.cmbWeekID);
            this.groupBox2.Controls.Add(this.btnCreate);
            this.groupBox2.Controls.Add(this.dtpFirstWeekStop);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(496, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(498, 117);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Define Weeks";
            // 
            // frmDepartmentPlanningWeeks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 611);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpDepartmentPlanningWeeks);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmDepartmentPlanningWeeks";
            this.Text = "Department Planning  Weeks";
            this.Load += new System.EventHandler(this.frmDepartmentPlanningWeeks_Load);
            this.grpDepartmentPlanningWeeks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartmentPlanningList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFirstWeekStart;
        private System.Windows.Forms.DateTimePicker dtpFirstWeekStop;
        private System.Windows.Forms.GroupBox grpDepartmentPlanningWeeks;
        private System.Windows.Forms.DataGridView dgvDepartmentPlanningList;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.BindingSource objSource;
        private System.Windows.Forms.Button btnFinalize;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbWeekID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
        private System.Windows.Forms.DataGridViewTextBoxColumn Month;
        private System.Windows.Forms.DataGridViewTextBoxColumn Week;
        private System.Windows.Forms.DataGridViewTextBoxColumn From;
        private System.Windows.Forms.DataGridViewTextBoxColumn To;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}