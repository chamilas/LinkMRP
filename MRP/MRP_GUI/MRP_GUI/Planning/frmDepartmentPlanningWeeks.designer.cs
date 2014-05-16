namespace ProductionPlan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpFirstWeekStart = new System.Windows.Forms.DateTimePicker();
            this.dtpFirstWeekStop = new System.Windows.Forms.DateTimePicker();
            this.dtpSecondWeekStart = new System.Windows.Forms.DateTimePicker();
            this.dtpSecondWeekStop = new System.Windows.Forms.DateTimePicker();
            this.grpDepartmentPlanningWeeks = new System.Windows.Forms.GroupBox();
            this.dgvDepartmentPlanningList = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpThirdWeekStart = new System.Windows.Forms.DateTimePicker();
            this.dtpThirdWeekStop = new System.Windows.Forms.DateTimePicker();
            this.dtpFourthWeekStart = new System.Windows.Forms.DateTimePicker();
            this.dtpFourthWeekStop = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.objSource = new System.Windows.Forms.BindingSource(this.components);
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Month = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Week = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.From = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.To = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpDepartmentPlanningWeeks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartmentPlanningList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Week -01";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Week -02";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Week -03";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Week -04";
            // 
            // dtpFirstWeekStart
            // 
            this.dtpFirstWeekStart.Location = new System.Drawing.Point(166, 49);
            this.dtpFirstWeekStart.Name = "dtpFirstWeekStart";
            this.dtpFirstWeekStart.Size = new System.Drawing.Size(248, 26);
            this.dtpFirstWeekStart.TabIndex = 4;
            this.dtpFirstWeekStart.ValueChanged += new System.EventHandler(this.dtpFirstWeekStart_ValueChanged);
            // 
            // dtpFirstWeekStop
            // 
            this.dtpFirstWeekStop.Location = new System.Drawing.Point(497, 47);
            this.dtpFirstWeekStop.Name = "dtpFirstWeekStop";
            this.dtpFirstWeekStop.Size = new System.Drawing.Size(248, 26);
            this.dtpFirstWeekStop.TabIndex = 5;
            this.dtpFirstWeekStop.ValueChanged += new System.EventHandler(this.dtpFirstWeekStop_ValueChanged);
            // 
            // dtpSecondWeekStart
            // 
            this.dtpSecondWeekStart.Enabled = false;
            this.dtpSecondWeekStart.Location = new System.Drawing.Point(167, 80);
            this.dtpSecondWeekStart.Name = "dtpSecondWeekStart";
            this.dtpSecondWeekStart.Size = new System.Drawing.Size(248, 26);
            this.dtpSecondWeekStart.TabIndex = 6;
            // 
            // dtpSecondWeekStop
            // 
            this.dtpSecondWeekStop.Location = new System.Drawing.Point(497, 78);
            this.dtpSecondWeekStop.Name = "dtpSecondWeekStop";
            this.dtpSecondWeekStop.Size = new System.Drawing.Size(248, 26);
            this.dtpSecondWeekStop.TabIndex = 7;
            this.dtpSecondWeekStop.ValueChanged += new System.EventHandler(this.dtpSecondWeekStop_ValueChanged);
            // 
            // grpDepartmentPlanningWeeks
            // 
            this.grpDepartmentPlanningWeeks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDepartmentPlanningWeeks.Controls.Add(this.dgvDepartmentPlanningList);
            this.grpDepartmentPlanningWeeks.Location = new System.Drawing.Point(16, 191);
            this.grpDepartmentPlanningWeeks.Name = "grpDepartmentPlanningWeeks";
            this.grpDepartmentPlanningWeeks.Size = new System.Drawing.Size(976, 409);
            this.grpDepartmentPlanningWeeks.TabIndex = 8;
            this.grpDepartmentPlanningWeeks.TabStop = false;
            this.grpDepartmentPlanningWeeks.Text = "Department Planning Weeks";
            // 
            // dgvDepartmentPlanningList
            // 
            this.dgvDepartmentPlanningList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDepartmentPlanningList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepartmentPlanningList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Year,
            this.Month,
            this.Week,
            this.From,
            this.To});
            this.dgvDepartmentPlanningList.Location = new System.Drawing.Point(18, 25);
            this.dgvDepartmentPlanningList.Name = "dgvDepartmentPlanningList";
            this.dgvDepartmentPlanningList.Size = new System.Drawing.Size(944, 370);
            this.dgvDepartmentPlanningList.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(295, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Please Define the Planning Weeks Of  a Month";
            // 
            // dtpThirdWeekStart
            // 
            this.dtpThirdWeekStart.Enabled = false;
            this.dtpThirdWeekStart.Location = new System.Drawing.Point(167, 111);
            this.dtpThirdWeekStart.Name = "dtpThirdWeekStart";
            this.dtpThirdWeekStart.Size = new System.Drawing.Size(248, 26);
            this.dtpThirdWeekStart.TabIndex = 10;
            // 
            // dtpThirdWeekStop
            // 
            this.dtpThirdWeekStop.Location = new System.Drawing.Point(497, 109);
            this.dtpThirdWeekStop.Name = "dtpThirdWeekStop";
            this.dtpThirdWeekStop.Size = new System.Drawing.Size(248, 26);
            this.dtpThirdWeekStop.TabIndex = 11;
            this.dtpThirdWeekStop.ValueChanged += new System.EventHandler(this.dtpThirdWeekStop_ValueChanged);
            // 
            // dtpFourthWeekStart
            // 
            this.dtpFourthWeekStart.Enabled = false;
            this.dtpFourthWeekStart.Location = new System.Drawing.Point(167, 142);
            this.dtpFourthWeekStart.Name = "dtpFourthWeekStart";
            this.dtpFourthWeekStart.Size = new System.Drawing.Size(248, 26);
            this.dtpFourthWeekStart.TabIndex = 12;
            // 
            // dtpFourthWeekStop
            // 
            this.dtpFourthWeekStop.Enabled = false;
            this.dtpFourthWeekStop.Location = new System.Drawing.Point(497, 140);
            this.dtpFourthWeekStop.Name = "dtpFourthWeekStop";
            this.dtpFourthWeekStop.Size = new System.Drawing.Size(248, 26);
            this.dtpFourthWeekStop.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(123, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 18);
            this.label6.TabIndex = 14;
            this.label6.Text = "Start";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(455, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 18);
            this.label7.TabIndex = 15;
            this.label7.Text = "Stop";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(123, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 18);
            this.label8.TabIndex = 14;
            this.label8.Text = "Start";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(455, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 18);
            this.label9.TabIndex = 15;
            this.label9.Text = "Stop";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(123, 119);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 18);
            this.label10.TabIndex = 14;
            this.label10.Text = "Start";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(455, 117);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 18);
            this.label11.TabIndex = 15;
            this.label11.Text = "Stop";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(124, 150);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 18);
            this.label12.TabIndex = 14;
            this.label12.Text = "Start";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(455, 148);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 18);
            this.label13.TabIndex = 15;
            this.label13.Text = "Stop";
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreate.Location = new System.Drawing.Point(891, 137);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(101, 31);
            this.btnCreate.TabIndex = 16;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ID.DataPropertyName = "MonthlyDeptPlanningID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // Year
            // 
            this.Year.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Year.DataPropertyName = "Year";
            this.Year.HeaderText = "Year";
            this.Year.Name = "Year";
            // 
            // Month
            // 
            this.Month.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Month.DataPropertyName = "Month";
            this.Month.HeaderText = "Month";
            this.Month.Name = "Month";
            // 
            // Week
            // 
            this.Week.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Week.DataPropertyName = "WeekID";
            this.Week.HeaderText = "Week";
            this.Week.Name = "Week";
            // 
            // From
            // 
            this.From.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.From.DataPropertyName = "FromDate";
            dataGridViewCellStyle1.Format = "D";
            dataGridViewCellStyle1.NullValue = null;
            this.From.DefaultCellStyle = dataGridViewCellStyle1;
            this.From.HeaderText = "From";
            this.From.Name = "From";
            // 
            // To
            // 
            this.To.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.To.DataPropertyName = "ToDate";
            dataGridViewCellStyle2.Format = "D";
            dataGridViewCellStyle2.NullValue = null;
            this.To.DefaultCellStyle = dataGridViewCellStyle2;
            this.To.HeaderText = "To";
            this.To.Name = "To";
            // 
            // frmDepartmentPlanningWeeks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 612);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpFourthWeekStop);
            this.Controls.Add(this.dtpFourthWeekStart);
            this.Controls.Add(this.dtpThirdWeekStop);
            this.Controls.Add(this.dtpThirdWeekStart);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.grpDepartmentPlanningWeeks);
            this.Controls.Add(this.dtpSecondWeekStop);
            this.Controls.Add(this.dtpSecondWeekStart);
            this.Controls.Add(this.dtpFirstWeekStop);
            this.Controls.Add(this.dtpFirstWeekStart);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDepartmentPlanningWeeks";
            this.Text = "Department Planning  Weeks";
            this.Load += new System.EventHandler(this.frmDepartmentPlanningWeeks_Load);
            this.grpDepartmentPlanningWeeks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartmentPlanningList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpFirstWeekStart;
        private System.Windows.Forms.DateTimePicker dtpFirstWeekStop;
        private System.Windows.Forms.DateTimePicker dtpSecondWeekStart;
        private System.Windows.Forms.DateTimePicker dtpSecondWeekStop;
        private System.Windows.Forms.GroupBox grpDepartmentPlanningWeeks;
        private System.Windows.Forms.DataGridView dgvDepartmentPlanningList;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpThirdWeekStart;
        private System.Windows.Forms.DateTimePicker dtpThirdWeekStop;
        private System.Windows.Forms.DateTimePicker dtpFourthWeekStart;
        private System.Windows.Forms.DateTimePicker dtpFourthWeekStop;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.BindingSource objSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
        private System.Windows.Forms.DataGridViewTextBoxColumn Month;
        private System.Windows.Forms.DataGridViewTextBoxColumn Week;
        private System.Windows.Forms.DataGridViewTextBoxColumn From;
        private System.Windows.Forms.DataGridViewTextBoxColumn To;
    }
}