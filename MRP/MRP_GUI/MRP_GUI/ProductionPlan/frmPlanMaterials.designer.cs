namespace MRP_GUI
{
    partial class frmPlanMaterial
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
            this.dgvTotal = new System.Windows.Forms.DataGridView();
            this.WeekID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RMCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.objTotalReq = new System.Windows.Forms.BindingSource(this.components);
            this.objSourceWeekly = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.objSourceWeeklyRunning = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnFix = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objTotalReq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceWeekly)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceWeeklyRunning)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTotal
            // 
            this.dgvTotal.AllowUserToAddRows = false;
            this.dgvTotal.AllowUserToDeleteRows = false;
            this.dgvTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTotal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTotal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.WeekID,
            this.RMCode,
            this.TotalQty,
            this.Unit});
            this.dgvTotal.Location = new System.Drawing.Point(13, 59);
            this.dgvTotal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvTotal.Name = "dgvTotal";
            this.dgvTotal.ReadOnly = true;
            this.dgvTotal.Size = new System.Drawing.Size(986, 538);
            this.dgvTotal.TabIndex = 15;
            // 
            // WeekID
            // 
            this.WeekID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.WeekID.DataPropertyName = "WeekID";
            this.WeekID.HeaderText = "WeekID";
            this.WeekID.Name = "WeekID";
            this.WeekID.ReadOnly = true;
            // 
            // RMCode
            // 
            this.RMCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RMCode.DataPropertyName = "MaterialCode";
            this.RMCode.HeaderText = "RM Code";
            this.RMCode.Name = "RMCode";
            this.RMCode.ReadOnly = true;
            // 
            // TotalQty
            // 
            this.TotalQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TotalQty.DataPropertyName = "Qty";
            this.TotalQty.HeaderText = "Total Qty.";
            this.TotalQty.Name = "TotalQty";
            this.TotalQty.ReadOnly = true;
            // 
            // Unit
            // 
            this.Unit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Unit.DataPropertyName = "UnitCode";
            this.Unit.FillWeight = 40F;
            this.Unit.HeaderText = "Unit";
            this.Unit.Name = "Unit";
            this.Unit.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "FormulaMaterialCode";
            this.dataGridViewTextBoxColumn1.HeaderText = "Raw Material";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MaterialDescription";
            this.dataGridViewTextBoxColumn2.FillWeight = 300F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Total Quantity";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "StockProcessed";
            this.dataGridViewTextBoxColumn3.FillWeight = 40F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Unit";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Req";
            this.dataGridViewTextBoxColumn4.FillWeight = 300F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Raw Material Name";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "UnitCode";
            this.dataGridViewTextBoxColumn5.FillWeight = 40F;
            this.dataGridViewTextBoxColumn5.HeaderText = "First";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "UnitCode";
            this.dataGridViewTextBoxColumn6.FillWeight = 40F;
            this.dataGridViewTextBoxColumn6.HeaderText = "Second";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ToBeProduced";
            this.dataGridViewTextBoxColumn7.HeaderText = "Third";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn8.DataPropertyName = "UnitCode";
            this.dataGridViewTextBoxColumn8.FillWeight = 40F;
            this.dataGridViewTextBoxColumn8.HeaderText = "Fourth";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn9.DataPropertyName = "UnitCode";
            this.dataGridViewTextBoxColumn9.FillWeight = 40F;
            this.dataGridViewTextBoxColumn9.HeaderText = "Fourth";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn10.DataPropertyName = "MaterialCode";
            this.dataGridViewTextBoxColumn10.FillWeight = 200F;
            this.dataGridViewTextBoxColumn10.HeaderText = "Fourth";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Visible = false;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn11.DataPropertyName = "WeekID";
            this.dataGridViewTextBoxColumn11.FillWeight = 200F;
            this.dataGridViewTextBoxColumn11.HeaderText = "First";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn12.DataPropertyName = "MaterialDescription";
            this.dataGridViewTextBoxColumn12.FillWeight = 200F;
            this.dataGridViewTextBoxColumn12.HeaderText = "Second";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Visible = false;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn13.DataPropertyName = "RequiredQty";
            this.dataGridViewTextBoxColumn13.HeaderText = "Third";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.Visible = false;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn14.DataPropertyName = "RemainingQty";
            this.dataGridViewTextBoxColumn14.HeaderText = "Fourth";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn15.DataPropertyName = "Qty3";
            this.dataGridViewTextBoxColumn15.HeaderText = "Fourth";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "Qty4";
            this.dataGridViewTextBoxColumn16.HeaderText = "Week3";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.Visible = false;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "UnitCode";
            this.dataGridViewTextBoxColumn17.HeaderText = "Week4";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.Visible = false;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "RemainingQty";
            this.dataGridViewTextBoxColumn18.HeaderText = "Total";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.Visible = false;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "RemainingQty";
            this.dataGridViewTextBoxColumn19.HeaderText = "RemainingQty";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.Visible = false;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "RemainingQty";
            this.dataGridViewTextBoxColumn20.HeaderText = "RemainingQty";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.Visible = false;
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.HeaderText = "MatType";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.HeaderText = "MatCode";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn23.HeaderText = "MatName";
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.HeaderText = "Week1_Re";
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            // 
            // dataGridViewTextBoxColumn25
            // 
            this.dataGridViewTextBoxColumn25.HeaderText = "Week2_Re";
            this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            // 
            // dataGridViewTextBoxColumn26
            // 
            this.dataGridViewTextBoxColumn26.HeaderText = "Week3_Re";
            this.dataGridViewTextBoxColumn26.Name = "dataGridViewTextBoxColumn26";
            // 
            // dataGridViewTextBoxColumn27
            // 
            this.dataGridViewTextBoxColumn27.HeaderText = "Week4_Re";
            this.dataGridViewTextBoxColumn27.Name = "dataGridViewTextBoxColumn27";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "Year";
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
            this.cmbYear.Location = new System.Drawing.Point(78, 13);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(121, 23);
            this.cmbYear.TabIndex = 17;
            this.cmbYear.SelectedIndexChanged += new System.EventHandler(this.cmbYear_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(227, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 18;
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
            this.cmbMonth.Location = new System.Drawing.Point(284, 14);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(121, 23);
            this.cmbMonth.TabIndex = 19;
            this.cmbMonth.SelectedIndexChanged += new System.EventHandler(this.cmbMonth_SelectedIndexChanged);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(442, 14);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(79, 27);
            this.btnGenerate.TabIndex = 20;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnFix
            // 
            this.btnFix.Location = new System.Drawing.Point(922, 12);
            this.btnFix.Name = "btnFix";
            this.btnFix.Size = new System.Drawing.Size(78, 29);
            this.btnFix.TabIndex = 21;
            this.btnFix.Text = "Fix";
            this.btnFix.UseVisualStyleBackColor = true;
            this.btnFix.Click += new System.EventHandler(this.btnFix_Click);
            // 
            // frmPlanMaterial
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1012, 623);
            this.Controls.Add(this.btnFix);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.cmbMonth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbYear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvTotal);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmPlanMaterial";
            this.Text = "Material Requirement";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmRPDMaterialRequirement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objTotalReq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceWeekly)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceWeeklyRunning)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.BindingSource objTotalReq;
        private System.Windows.Forms.BindingSource objSourceWeekly;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;
        private System.Windows.Forms.BindingSource objSourceWeeklyRunning;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.DataGridViewTextBoxColumn WeekID;
        private System.Windows.Forms.DataGridViewTextBoxColumn RMCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private System.Windows.Forms.Button btnFix;
    }
}