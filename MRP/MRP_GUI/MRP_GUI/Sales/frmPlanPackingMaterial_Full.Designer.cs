namespace MRP_GUI.Sales
{
    partial class frmPlanPackingMaterial_Full
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtMonth3 = new System.Windows.Forms.TextBox();
            this.txtYear3 = new System.Windows.Forms.TextBox();
            this.txtMonth2 = new System.Windows.Forms.TextBox();
            this.txtYear2 = new System.Windows.Forms.TextBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnff = new System.Windows.Forms.Button();
            this.dgvTotal = new System.Windows.Forms.DataGridView();
            this.bsTable = new System.Windows.Forms.BindingSource(this.components);
            this.RMCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RMName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Week1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Week1_Minus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Week2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Week2_Minus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Week3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Week3_Minus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Week4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Week4_Minus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Month1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Month1_Minus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Month2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Month2_Minus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Month3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Month3_Minus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMonth3
            // 
            this.txtMonth3.Location = new System.Drawing.Point(854, 16);
            this.txtMonth3.Name = "txtMonth3";
            this.txtMonth3.ReadOnly = true;
            this.txtMonth3.Size = new System.Drawing.Size(100, 20);
            this.txtMonth3.TabIndex = 39;
            // 
            // txtYear3
            // 
            this.txtYear3.Location = new System.Drawing.Point(719, 14);
            this.txtYear3.Name = "txtYear3";
            this.txtYear3.ReadOnly = true;
            this.txtYear3.Size = new System.Drawing.Size(74, 20);
            this.txtYear3.TabIndex = 38;
            // 
            // txtMonth2
            // 
            this.txtMonth2.Location = new System.Drawing.Point(567, 14);
            this.txtMonth2.Name = "txtMonth2";
            this.txtMonth2.ReadOnly = true;
            this.txtMonth2.Size = new System.Drawing.Size(100, 20);
            this.txtMonth2.TabIndex = 37;
            // 
            // txtYear2
            // 
            this.txtYear2.Location = new System.Drawing.Point(417, 14);
            this.txtYear2.Name = "txtYear2";
            this.txtYear2.ReadOnly = true;
            this.txtYear2.Size = new System.Drawing.Size(83, 20);
            this.txtYear2.TabIndex = 36;
            // 
            // btnLoad
            // 
            this.btnLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoad.Location = new System.Drawing.Point(1091, 11);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(78, 29);
            this.btnLoad.TabIndex = 35;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
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
            this.cmbMonth.Location = new System.Drawing.Point(235, 11);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(121, 21);
            this.cmbMonth.TabIndex = 34;
            this.cmbMonth.SelectedIndexChanged += new System.EventHandler(this.cmbMonth_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(799, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Month3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(512, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Month2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(674, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Year3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Month1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(372, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Year2";
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
            this.cmbYear.Location = new System.Drawing.Point(53, 12);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(121, 21);
            this.cmbYear.TabIndex = 30;
            this.cmbYear.SelectedIndexChanged += new System.EventHandler(this.cmbYear_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Year1";
            // 
            // btnff
            // 
            this.btnff.Location = new System.Drawing.Point(960, 12);
            this.btnff.Name = "btnff";
            this.btnff.Size = new System.Drawing.Size(79, 23);
            this.btnff.TabIndex = 41;
            this.btnff.Text = "Load";
            this.btnff.UseVisualStyleBackColor = true;
            this.btnff.Click += new System.EventHandler(this.btnff_Click);
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
            this.RMCode,
            this.RMName,
            this.Stock,
            this.Week1,
            this.Week1_Minus,
            this.Week2,
            this.Week2_Minus,
            this.Week3,
            this.Week3_Minus,
            this.Week4,
            this.Week4_Minus,
            this.Month1,
            this.Month1_Minus,
            this.Month2,
            this.Month2_Minus,
            this.Month3,
            this.Month3_Minus,
            this.Total});
            this.dgvTotal.Location = new System.Drawing.Point(9, 42);
            this.dgvTotal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvTotal.Name = "dgvTotal";
            this.dgvTotal.ReadOnly = true;
            this.dgvTotal.Size = new System.Drawing.Size(1028, 300);
            this.dgvTotal.TabIndex = 42;
            // 
            // RMCode
            // 
            this.RMCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RMCode.DataPropertyName = "MaterialCode";
            this.RMCode.FillWeight = 150F;
            this.RMCode.HeaderText = "RM Code";
            this.RMCode.Name = "RMCode";
            this.RMCode.ReadOnly = true;
            // 
            // RMName
            // 
            this.RMName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RMName.DataPropertyName = "Material";
            this.RMName.FillWeight = 300F;
            this.RMName.HeaderText = "Material";
            this.RMName.Name = "RMName";
            this.RMName.ReadOnly = true;
            // 
            // Stock
            // 
            this.Stock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Stock.DataPropertyName = "Stock";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Stock.DefaultCellStyle = dataGridViewCellStyle1;
            this.Stock.HeaderText = "Stock";
            this.Stock.Name = "Stock";
            this.Stock.ReadOnly = true;
            // 
            // Week1
            // 
            this.Week1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Week1.DataPropertyName = "Week1";
            this.Week1.HeaderText = "W1";
            this.Week1.Name = "Week1";
            this.Week1.ReadOnly = true;
            // 
            // Week1_Minus
            // 
            this.Week1_Minus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Week1_Minus.DataPropertyName = "Week1_Minus";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Week1_Minus.DefaultCellStyle = dataGridViewCellStyle2;
            this.Week1_Minus.HeaderText = "W1_Minus";
            this.Week1_Minus.Name = "Week1_Minus";
            this.Week1_Minus.ReadOnly = true;
            // 
            // Week2
            // 
            this.Week2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Week2.DataPropertyName = "Week2";
            this.Week2.HeaderText = "W2";
            this.Week2.Name = "Week2";
            this.Week2.ReadOnly = true;
            // 
            // Week2_Minus
            // 
            this.Week2_Minus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Week2_Minus.DataPropertyName = "Week2_Minus";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Week2_Minus.DefaultCellStyle = dataGridViewCellStyle3;
            this.Week2_Minus.HeaderText = "W2_Minus";
            this.Week2_Minus.Name = "Week2_Minus";
            this.Week2_Minus.ReadOnly = true;
            // 
            // Week3
            // 
            this.Week3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Week3.DataPropertyName = "Week3";
            this.Week3.HeaderText = "W3";
            this.Week3.Name = "Week3";
            this.Week3.ReadOnly = true;
            // 
            // Week3_Minus
            // 
            this.Week3_Minus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Week3_Minus.DataPropertyName = "Week3_Minus";
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Week3_Minus.DefaultCellStyle = dataGridViewCellStyle4;
            this.Week3_Minus.HeaderText = "W3_Minus";
            this.Week3_Minus.Name = "Week3_Minus";
            this.Week3_Minus.ReadOnly = true;
            // 
            // Week4
            // 
            this.Week4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Week4.DataPropertyName = "Week4";
            this.Week4.HeaderText = "W4";
            this.Week4.Name = "Week4";
            this.Week4.ReadOnly = true;
            // 
            // Week4_Minus
            // 
            this.Week4_Minus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Week4_Minus.DataPropertyName = "Week4_Minus";
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Week4_Minus.DefaultCellStyle = dataGridViewCellStyle5;
            this.Week4_Minus.HeaderText = "W4_Minus";
            this.Week4_Minus.Name = "Week4_Minus";
            this.Week4_Minus.ReadOnly = true;
            // 
            // Month1
            // 
            this.Month1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Month1.DataPropertyName = "Month1";
            this.Month1.HeaderText = "M1";
            this.Month1.Name = "Month1";
            this.Month1.ReadOnly = true;
            // 
            // Month1_Minus
            // 
            this.Month1_Minus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Month1_Minus.DataPropertyName = "Month1_Minus";
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Month1_Minus.DefaultCellStyle = dataGridViewCellStyle6;
            this.Month1_Minus.HeaderText = "M1_Minus";
            this.Month1_Minus.Name = "Month1_Minus";
            this.Month1_Minus.ReadOnly = true;
            // 
            // Month2
            // 
            this.Month2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Month2.DataPropertyName = "Month2";
            this.Month2.HeaderText = "M2";
            this.Month2.Name = "Month2";
            this.Month2.ReadOnly = true;
            // 
            // Month2_Minus
            // 
            this.Month2_Minus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Month2_Minus.DataPropertyName = "Month2_Minus";
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Month2_Minus.DefaultCellStyle = dataGridViewCellStyle7;
            this.Month2_Minus.HeaderText = "M2_Minus";
            this.Month2_Minus.Name = "Month2_Minus";
            this.Month2_Minus.ReadOnly = true;
            // 
            // Month3
            // 
            this.Month3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Month3.DataPropertyName = "Month3";
            this.Month3.HeaderText = "M3";
            this.Month3.Name = "Month3";
            this.Month3.ReadOnly = true;
            // 
            // Month3_Minus
            // 
            this.Month3_Minus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Month3_Minus.DataPropertyName = "Month3_Minus";
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Month3_Minus.DefaultCellStyle = dataGridViewCellStyle8;
            this.Month3_Minus.HeaderText = "M3_Minus";
            this.Month3_Minus.Name = "Month3_Minus";
            this.Month3_Minus.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Total.DataPropertyName = "Total";
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Total.DefaultCellStyle = dataGridViewCellStyle9;
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // frmPlanPackingMaterial_Full
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 354);
            this.Controls.Add(this.dgvTotal);
            this.Controls.Add(this.btnff);
            this.Controls.Add(this.txtMonth3);
            this.Controls.Add(this.txtYear3);
            this.Controls.Add(this.txtMonth2);
            this.Controls.Add(this.txtYear2);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.cmbMonth);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbYear);
            this.Controls.Add(this.label1);
            this.Name = "frmPlanPackingMaterial_Full";
            this.Text = "frmPlanPackingMaterial_Full";
            this.Load += new System.EventHandler(this.frmPlanPackingMaterial_Full_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMonth3;
        private System.Windows.Forms.TextBox txtYear3;
        private System.Windows.Forms.TextBox txtMonth2;
        private System.Windows.Forms.TextBox txtYear2;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnff;
        private System.Windows.Forms.DataGridView dgvTotal;
        private System.Windows.Forms.BindingSource bsTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn RMCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn RMName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Week1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Week1_Minus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Week2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Week2_Minus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Week3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Week3_Minus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Week4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Week4_Minus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Month1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Month1_Minus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Month2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Month2_Minus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Month3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Month3_Minus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
    }
}