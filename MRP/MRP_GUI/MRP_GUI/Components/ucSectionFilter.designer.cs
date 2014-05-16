namespace MRP_GUI.Components
{
    partial class ucSectionFilter
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbDivision = new System.Windows.Forms.ComboBox();
            this.cmDepartment = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbSection = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bindDepartment = new System.Windows.Forms.BindingSource(this.components);
            this.bindDivision = new System.Windows.Forms.BindingSource(this.components);
            this.bindSection = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindDepartment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindDivision)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindSection)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Division";
            // 
            // cmbDivision
            // 
            this.cmbDivision.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbDivision.DisplayMember = "DivisionName";
            this.cmbDivision.FormattingEnabled = true;
            this.cmbDivision.Location = new System.Drawing.Point(76, 7);
            this.cmbDivision.Name = "cmbDivision";
            this.cmbDivision.Size = new System.Drawing.Size(185, 21);
            this.cmbDivision.TabIndex = 1;
            this.cmbDivision.ValueMember = "DivisionID";
            this.cmbDivision.SelectedIndexChanged += new System.EventHandler(this.cmbDivision_SelectedIndexChanged);
            // 
            // cmDepartment
            // 
            this.cmDepartment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmDepartment.DisplayMember = "DepName";
            this.cmDepartment.FormattingEnabled = true;
            this.cmDepartment.Location = new System.Drawing.Point(76, 31);
            this.cmDepartment.Name = "cmDepartment";
            this.cmDepartment.Size = new System.Drawing.Size(185, 21);
            this.cmDepartment.TabIndex = 3;
            this.cmDepartment.ValueMember = "DepID";
            this.cmDepartment.SelectedIndexChanged += new System.EventHandler(this.cmDepartment_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Department";
            // 
            // cmbSection
            // 
            this.cmbSection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbSection.DisplayMember = "SectionName";
            this.cmbSection.FormattingEnabled = true;
            this.cmbSection.Location = new System.Drawing.Point(76, 55);
            this.cmbSection.Name = "cmbSection";
            this.cmbSection.Size = new System.Drawing.Size(185, 21);
            this.cmbSection.TabIndex = 5;
            this.cmbSection.ValueMember = "SectionID";
            this.cmbSection.SelectedIndexChanged += new System.EventHandler(this.cmbSection_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Section";
            // 
            // ucSectionFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmbSection);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmDepartment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbDivision);
            this.Controls.Add(this.label1);
            this.Name = "ucSectionFilter";
            this.Size = new System.Drawing.Size(268, 83);
            ((System.ComponentModel.ISupportInitialize)(this.bindDepartment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindDivision)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindSection)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbDivision;
        private System.Windows.Forms.ComboBox cmDepartment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbSection;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource bindDepartment;
        private System.Windows.Forms.BindingSource bindDivision;
        private System.Windows.Forms.BindingSource bindSection;
    }
}
