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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnff = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1028, 300);
            this.dataGridView1.TabIndex = 40;
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
            // frmPlanPackingMaterial_Full
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 354);
            this.Controls.Add(this.btnff);
            this.Controls.Add(this.dataGridView1);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnff;
    }
}