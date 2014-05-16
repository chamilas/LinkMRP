namespace MRP_GUI.Sales
{
    partial class frmPackingMaterialsForecast
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
            this.dgvMaterialForcast = new System.Windows.Forms.DataGridView();
            this.btnGenarate = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.bsMaterialForcast = new System.Windows.Forms.BindingSource(this.components);
            this.FormulaMaterialCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaterialDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FormulaQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterialForcast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMaterialForcast)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMaterialForcast
            // 
            this.dgvMaterialForcast.AllowUserToAddRows = false;
            this.dgvMaterialForcast.AllowUserToDeleteRows = false;
            this.dgvMaterialForcast.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMaterialForcast.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaterialForcast.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FormulaMaterialCode,
            this.MaterialDescription,
            this.FormulaQty});
            this.dgvMaterialForcast.Location = new System.Drawing.Point(12, 46);
            this.dgvMaterialForcast.Name = "dgvMaterialForcast";
            this.dgvMaterialForcast.Size = new System.Drawing.Size(818, 384);
            this.dgvMaterialForcast.TabIndex = 0;
            // 
            // btnGenarate
            // 
            this.btnGenarate.Location = new System.Drawing.Point(381, 17);
            this.btnGenarate.Name = "btnGenarate";
            this.btnGenarate.Size = new System.Drawing.Size(100, 23);
            this.btnGenarate.TabIndex = 1;
            this.btnGenarate.Text = "Genarate";
            this.btnGenarate.UseVisualStyleBackColor = true;
            this.btnGenarate.Click += new System.EventHandler(this.btnGenarate_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(173, 20);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(43, 13);
            this.label14.TabIndex = 26;
            this.label14.Text = "Month :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Year :";
            // 
            // cmbMonth
            // 
            this.cmbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.cmbMonth.Location = new System.Drawing.Point(222, 17);
            this.cmbMonth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(153, 21);
            this.cmbMonth.TabIndex = 24;
            // 
            // cmbYear
            // 
            this.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.cmbYear.Location = new System.Drawing.Point(53, 17);
            this.cmbYear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(114, 21);
            this.cmbYear.TabIndex = 23;
            // 
            // FormulaMaterialCode
            // 
            this.FormulaMaterialCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FormulaMaterialCode.DataPropertyName = "FormulaMaterialCode";
            this.FormulaMaterialCode.HeaderText = "Formula Material Code";
            this.FormulaMaterialCode.Name = "FormulaMaterialCode";
            // 
            // MaterialDescription
            // 
            this.MaterialDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaterialDescription.DataPropertyName = "MaterialDescription";
            this.MaterialDescription.HeaderText = "Material Description";
            this.MaterialDescription.Name = "MaterialDescription";
            // 
            // FormulaQty
            // 
            this.FormulaQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FormulaQty.DataPropertyName = "Qty";
            this.FormulaQty.HeaderText = "Quantity";
            this.FormulaQty.Name = "FormulaQty";
            // 
            // frmPackingMaterialsForecast
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 442);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbMonth);
            this.Controls.Add(this.cmbYear);
            this.Controls.Add(this.btnGenarate);
            this.Controls.Add(this.dgvMaterialForcast);
            this.Name = "frmPackingMaterialsForecast";
            this.Text = "frmPackingMaterialsForecast";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterialForcast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMaterialForcast)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMaterialForcast;
        private System.Windows.Forms.Button btnGenarate;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.BindingSource bsMaterialForcast;
        private System.Windows.Forms.DataGridViewTextBoxColumn FormulaMaterialCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaterialDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn FormulaQty;
    }
}