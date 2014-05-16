namespace MRP_GUI.Sales
{
    partial class frmRegisterProject
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
            this.btnSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProName = new System.Windows.Forms.TextBox();
            this.cmbProType = new System.Windows.Forms.ComboBox();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.bsDepList = new System.Windows.Forms.BindingSource(this.components);
            this.dgvProjects = new System.Windows.Forms.DataGridView();
            this.ProjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StoreID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bsDGVProjects = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bsDepList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjects)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsDGVProjects)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(247, 99);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 28);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Project Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Project Type :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Department :";
            // 
            // txtProName
            // 
            this.txtProName.Location = new System.Drawing.Point(92, 21);
            this.txtProName.Name = "txtProName";
            this.txtProName.Size = new System.Drawing.Size(349, 20);
            this.txtProName.TabIndex = 6;
            // 
            // cmbProType
            // 
            this.cmbProType.DisplayMember = "DepName";
            this.cmbProType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProType.FormattingEnabled = true;
            this.cmbProType.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmbProType.Location = new System.Drawing.Point(91, 45);
            this.cmbProType.Name = "cmbProType";
            this.cmbProType.Size = new System.Drawing.Size(350, 21);
            this.cmbProType.TabIndex = 7;
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.DisplayMember = "DepName";
            this.cmbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Location = new System.Drawing.Point(91, 72);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(350, 21);
            this.cmbDepartment.TabIndex = 8;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(347, 99);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(94, 28);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // dgvProjects
            // 
            this.dgvProjects.AllowUserToAddRows = false;
            this.dgvProjects.AllowUserToDeleteRows = false;
            this.dgvProjects.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProjects.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProjectName,
            this.Department,
            this.ProjectType,
            this.StoreID});
            this.dgvProjects.Location = new System.Drawing.Point(12, 168);
            this.dgvProjects.MultiSelect = false;
            this.dgvProjects.Name = "dgvProjects";
            this.dgvProjects.ReadOnly = true;
            this.dgvProjects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProjects.Size = new System.Drawing.Size(710, 210);
            this.dgvProjects.TabIndex = 10;
            // 
            // ProjectName
            // 
            this.ProjectName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProjectName.DataPropertyName = "ProjectName";
            this.ProjectName.HeaderText = "Project Name";
            this.ProjectName.Name = "ProjectName";
            this.ProjectName.ReadOnly = true;
            // 
            // Department
            // 
            this.Department.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Department.DataPropertyName = "Department";
            this.Department.HeaderText = "Department";
            this.Department.Name = "Department";
            this.Department.ReadOnly = true;
            // 
            // ProjectType
            // 
            this.ProjectType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProjectType.DataPropertyName = "ProjectType";
            this.ProjectType.HeaderText = "Project Type";
            this.ProjectType.Name = "ProjectType";
            this.ProjectType.ReadOnly = true;
            // 
            // StoreID
            // 
            this.StoreID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StoreID.DataPropertyName = "StoreID";
            this.StoreID.HeaderText = "Store Name";
            this.StoreID.Name = "StoreID";
            this.StoreID.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbDepartment);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbProType);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtProName);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(710, 150);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // frmRegisterProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 417);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvProjects);
            this.Name = "frmRegisterProject";
            this.Text = "frmRegisterProject";
            ((System.ComponentModel.ISupportInitialize)(this.bsDepList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjects)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsDGVProjects)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtProName;
        private System.Windows.Forms.ComboBox cmbProType;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.BindingSource bsDepList;
        private System.Windows.Forms.DataGridView dgvProjects;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Department;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectType;
        private System.Windows.Forms.DataGridViewTextBoxColumn StoreID;
        private System.Windows.Forms.BindingSource bsDGVProjects;
    }
}