namespace MRP_GUI.Components
{
    partial class ucEmployeeSelect
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
            this.cmbSection = new System.Windows.Forms.ComboBox();
            this.cmbEmployee = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bindEmp = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindEmp)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "From Other Section";
            // 
            // cmbSection
            // 
            this.cmbSection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbSection.DisplayMember = "SectionName";
            this.cmbSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSection.FormattingEnabled = true;
            this.cmbSection.Location = new System.Drawing.Point(112, 26);
            this.cmbSection.Name = "cmbSection";
            this.cmbSection.Size = new System.Drawing.Size(212, 21);
            this.cmbSection.TabIndex = 1;
            this.cmbSection.ValueMember = "SectionID";
            this.cmbSection.SelectedIndexChanged += new System.EventHandler(this.cmbSection_SelectedIndexChanged);
            // 
            // cmbEmployee
            // 
            this.cmbEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbEmployee.DisplayMember = "Employee";
            this.cmbEmployee.FormattingEnabled = true;
            this.cmbEmployee.Location = new System.Drawing.Point(67, 2);
            this.cmbEmployee.Name = "cmbEmployee";
            this.cmbEmployee.Size = new System.Drawing.Size(257, 21);
            this.cmbEmployee.TabIndex = 3;
            this.cmbEmployee.ValueMember = "EmpID";
            this.cmbEmployee.SelectedIndexChanged += new System.EventHandler(this.cmbEmployee_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Employee";
            // 
            // ucEmployeeSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.cmbEmployee);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbSection);
            this.Controls.Add(this.label1);
            this.Name = "ucEmployeeSelect";
            this.Size = new System.Drawing.Size(327, 48);
            this.Load += new System.EventHandler(this.ucEmployeeSelect_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindEmp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSection;
        private System.Windows.Forms.ComboBox cmbEmployee;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource bindEmp;
    }
}
