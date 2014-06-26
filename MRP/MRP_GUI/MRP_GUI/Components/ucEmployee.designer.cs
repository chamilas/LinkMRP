namespace MRP_GUI
{
    partial class ucEmployee
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.ucSectionFilter1 = new MRP_GUI.Components.ucSectionFilter();
            this.txtOTRate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbEmpTYpe = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.CheckBox();
            this.cmbEmployeeRole = new System.Windows.Forms.ComboBox();
            this.label51 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label52 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label53 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.gvEmployee = new System.Windows.Forms.DataGridView();
            this.ColEmpID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEmpName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEmpRoleTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColRatePerHour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColOTRatePerHour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEmp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEmpRoleID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEmpStatus = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bindEmployee = new System.Windows.Forms.BindingSource(this.components);
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.label54 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.ucSectionFilter1);
            this.groupBox7.Controls.Add(this.txtOTRate);
            this.groupBox7.Controls.Add(this.label4);
            this.groupBox7.Controls.Add(this.txtRate);
            this.groupBox7.Controls.Add(this.label5);
            this.groupBox7.Controls.Add(this.cmbEmpTYpe);
            this.groupBox7.Controls.Add(this.label3);
            this.groupBox7.Controls.Add(this.cbStatus);
            this.groupBox7.Controls.Add(this.cmbEmployeeRole);
            this.groupBox7.Controls.Add(this.label51);
            this.groupBox7.Controls.Add(this.txtName);
            this.groupBox7.Controls.Add(this.label52);
            this.groupBox7.Controls.Add(this.btnSave);
            this.groupBox7.Controls.Add(this.btnDelete);
            this.groupBox7.Controls.Add(this.label53);
            this.groupBox7.Controls.Add(this.btnClear);
            this.groupBox7.Controls.Add(this.gvEmployee);
            this.groupBox7.Controls.Add(this.txtEmployeeID);
            this.groupBox7.Controls.Add(this.label54);
            this.groupBox7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox7.Location = new System.Drawing.Point(0, 0);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(994, 640);
            this.groupBox7.TabIndex = 0;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Employee";
            this.groupBox7.Enter += new System.EventHandler(this.groupBox7_Enter);
            // 
            // ucSectionFilter1
            // 
            this.ucSectionFilter1.Department = null;
            this.ucSectionFilter1.Division = null;
            this.ucSectionFilter1.Location = new System.Drawing.Point(373, 26);
            this.ucSectionFilter1.Name = "ucSectionFilter1";
            this.ucSectionFilter1.Section = null;
            this.ucSectionFilter1.Size = new System.Drawing.Size(301, 83);
            this.ucSectionFilter1.TabIndex = 23;
            // 
            // txtOTRate
            // 
            this.txtOTRate.Enabled = false;
            this.txtOTRate.Location = new System.Drawing.Point(118, 144);
            this.txtOTRate.Name = "txtOTRate";
            this.txtOTRate.Size = new System.Drawing.Size(143, 20);
            this.txtOTRate.TabIndex = 21;
            this.txtOTRate.Text = "0.00";
            this.txtOTRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Rate_Keypress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "OT Rate per Hour";
            // 
            // txtRate
            // 
            this.txtRate.Enabled = false;
            this.txtRate.Location = new System.Drawing.Point(118, 122);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(143, 20);
            this.txtRate.TabIndex = 19;
            this.txtRate.Text = "0.00";
            this.txtRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Rate_Keypress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Rate per Hour";
            // 
            // cmbEmpTYpe
            // 
            this.cmbEmpTYpe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmpTYpe.FormattingEnabled = true;
            this.cmbEmpTYpe.Items.AddRange(new object[] {
            "Permanent",
            "Contract",
            "Outsource"});
            this.cmbEmpTYpe.Location = new System.Drawing.Point(118, 26);
            this.cmbEmpTYpe.Name = "cmbEmpTYpe";
            this.cmbEmpTYpe.Size = new System.Drawing.Size(207, 21);
            this.cmbEmpTYpe.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Type";
            // 
            // cbStatus
            // 
            this.cbStatus.AutoSize = true;
            this.cbStatus.Checked = true;
            this.cbStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbStatus.Location = new System.Drawing.Point(19, 173);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(59, 17);
            this.cbStatus.TabIndex = 16;
            this.cbStatus.Text = "Enable";
            this.cbStatus.UseVisualStyleBackColor = true;
            // 
            // cmbEmployeeRole
            // 
            this.cmbEmployeeRole.DisplayMember = "EmpRoleTitle";
            this.cmbEmployeeRole.FormattingEnabled = true;
            this.cmbEmployeeRole.Location = new System.Drawing.Point(118, 52);
            this.cmbEmployeeRole.Name = "cmbEmployeeRole";
            this.cmbEmployeeRole.Size = new System.Drawing.Size(207, 21);
            this.cmbEmployeeRole.TabIndex = 2;
            this.cmbEmployeeRole.Text = "--Select Employee Role--";
            this.cmbEmployeeRole.ValueMember = "EMPRoleID";
            this.cmbEmployeeRole.SelectedIndexChanged += new System.EventHandler(this.cmbEmployeeRole_SelectedIndexChanged);
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(80, 54);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(29, 13);
            this.label51.TabIndex = 11;
            this.label51.Text = "Role";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(118, 100);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(232, 20);
            this.txtName.TabIndex = 1;
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(74, 103);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(35, 13);
            this.label52.TabIndex = 9;
            this.label52.Text = "Name";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(269, 192);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(188, 192);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(6, 224);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(72, 13);
            this.label53.TabIndex = 8;
            this.label53.Text = "Employee List";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(107, 192);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "New";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // gvEmployee
            // 
            this.gvEmployee.AllowUserToAddRows = false;
            this.gvEmployee.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gvEmployee.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gvEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvEmployee.AutoGenerateColumns = false;
            this.gvEmployee.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColEmpID,
            this.ColEmpName,
            this.ColEmpRoleTitle,
            this.ColRatePerHour,
            this.ColOTRatePerHour,
            this.ColEmp,
            this.ColEmpRoleID,
            this.Column1,
            this.ColEmpStatus});
            this.gvEmployee.DataSource = this.bindEmployee;
            this.gvEmployee.Location = new System.Drawing.Point(6, 240);
            this.gvEmployee.Name = "gvEmployee";
            this.gvEmployee.ReadOnly = true;
            this.gvEmployee.RowHeadersVisible = false;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvEmployee.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gvEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvEmployee.Size = new System.Drawing.Size(982, 390);
            this.gvEmployee.TabIndex = 4;
            this.gvEmployee.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvEmployee_CellClick);
            // 
            // ColEmpID
            // 
            this.ColEmpID.DataPropertyName = "EmpID";
            this.ColEmpID.HeaderText = "Employee ID";
            this.ColEmpID.Name = "ColEmpID";
            this.ColEmpID.ReadOnly = true;
            this.ColEmpID.Width = 150;
            // 
            // ColEmpName
            // 
            this.ColEmpName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColEmpName.DataPropertyName = "EmpName";
            this.ColEmpName.HeaderText = "Name";
            this.ColEmpName.Name = "ColEmpName";
            this.ColEmpName.ReadOnly = true;
            // 
            // ColEmpRoleTitle
            // 
            this.ColEmpRoleTitle.DataPropertyName = "EmpRoleTitle";
            this.ColEmpRoleTitle.HeaderText = "Role";
            this.ColEmpRoleTitle.Name = "ColEmpRoleTitle";
            this.ColEmpRoleTitle.ReadOnly = true;
            this.ColEmpRoleTitle.Width = 125;
            // 
            // ColRatePerHour
            // 
            this.ColRatePerHour.DataPropertyName = "RatePerHour";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ColRatePerHour.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColRatePerHour.HeaderText = "Hourly Rate";
            this.ColRatePerHour.Name = "ColRatePerHour";
            this.ColRatePerHour.ReadOnly = true;
            // 
            // ColOTRatePerHour
            // 
            this.ColOTRatePerHour.DataPropertyName = "OTRatePerHour";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ColOTRatePerHour.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColOTRatePerHour.HeaderText = "OT Rate";
            this.ColOTRatePerHour.Name = "ColOTRatePerHour";
            this.ColOTRatePerHour.ReadOnly = true;
            // 
            // ColEmp
            // 
            this.ColEmp.DataPropertyName = "Emp";
            this.ColEmp.HeaderText = "Employee";
            this.ColEmp.Name = "ColEmp";
            this.ColEmp.ReadOnly = true;
            this.ColEmp.Visible = false;
            // 
            // ColEmpRoleID
            // 
            this.ColEmpRoleID.DataPropertyName = "EmpRoleID";
            this.ColEmpRoleID.HeaderText = "RoleID";
            this.ColEmpRoleID.Name = "ColEmpRoleID";
            this.ColEmpRoleID.ReadOnly = true;
            this.ColEmpRoleID.Visible = false;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "SectionID";
            this.Column1.HeaderText = "Section";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // ColEmpStatus
            // 
            this.ColEmpStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ColEmpStatus.DataPropertyName = "EmpStatus";
            this.ColEmpStatus.HeaderText = "Status";
            this.ColEmpStatus.Name = "ColEmpStatus";
            this.ColEmpStatus.ReadOnly = true;
            this.ColEmpStatus.Width = 43;
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Location = new System.Drawing.Point(118, 78);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(232, 20);
            this.txtEmployeeID.TabIndex = 0;
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(41, 81);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(67, 13);
            this.label54.TabIndex = 0;
            this.label54.Text = "Employee ID";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "EmpID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Employee ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "EmpName";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "EmpRoleTitle";
            this.dataGridViewTextBoxColumn3.HeaderText = "Role";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "RatePerHour";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewTextBoxColumn4.HeaderText = "Hourly Rate";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "OTRatePerHour";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewTextBoxColumn5.HeaderText = "OT Rate";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Emp";
            this.dataGridViewTextBoxColumn6.HeaderText = "Employee";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "EmpRoleID";
            this.dataGridViewTextBoxColumn7.HeaderText = "RoleID";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "SectionName";
            this.dataGridViewTextBoxColumn8.HeaderText = "Section";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // ucEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox7);
            this.Name = "ucEmployee";
            this.Size = new System.Drawing.Size(994, 640);
            this.Load += new System.EventHandler(this.ucEmployee_Load);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindEmployee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.ComboBox cmbEmployeeRole;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView gvEmployee;
        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.CheckBox cbStatus;
        private System.Windows.Forms.ComboBox cmbEmpTYpe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOTRate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.Label label5;
        private MRP_GUI.Components.ucSectionFilter ucSectionFilter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.BindingSource bindEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEmpID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEmpName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEmpRoleTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColRatePerHour;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColOTRatePerHour;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEmp;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEmpRoleID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColEmpStatus;
    }
}
