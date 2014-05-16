namespace MRP_GUI
{
    partial class frmPRPDBatchActivity
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
            this.objSourceBatchList = new System.Windows.Forms.BindingSource(this.components);
            this.objSourceActivityList = new System.Windows.Forms.BindingSource(this.components);
            this.txtOT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvBatchLabourDetails = new System.Windows.Forms.DataGridView();
            this.LabourRecID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.From_emp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.To_emp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMachineDetails = new System.Windows.Forms.DataGridView();
            this.MachineRecID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MachineCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Machine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.From_Machine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.To_Machine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNos = new System.Windows.Forms.TextBox();
            this.cmbMachine = new System.Windows.Forms.ComboBox();
            this.objSourceBatchLabour = new System.Windows.Forms.BindingSource(this.components);
            this.objSourceBatchMachine = new System.Windows.Forms.BindingSource(this.components);
            this.objSourceMachineList = new System.Windows.Forms.BindingSource(this.components);
            this.txtMachineStart = new System.Windows.Forms.MaskedTextBox();
            this.txtMachineStop = new System.Windows.Forms.MaskedTextBox();
            this.rdbOutsource = new System.Windows.Forms.RadioButton();
            this.rdbPermanentSection = new System.Windows.Forms.RadioButton();
            this.rdbPermanentAll = new System.Windows.Forms.RadioButton();
            this.cmbEmployee = new System.Windows.Forms.ComboBox();
            this.objSourceEmployee = new System.Windows.Forms.BindingSource(this.components);
            this.txtFrom = new System.Windows.Forms.MaskedTextBox();
            this.txtTo = new System.Windows.Forms.MaskedTextBox();
            this.txtActivity = new System.Windows.Forms.TextBox();
            this.txtOTMinutes = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnMultiple = new System.Windows.Forms.Button();
            this.cmbSections = new System.Windows.Forms.ComboBox();
            this.objSourceSections = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.objSourceBatchList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceActivityList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBatchLabourDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMachineDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceBatchLabour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceBatchMachine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceMachineList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceSections)).BeginInit();
            this.SuspendLayout();
            // 
            // txtOT
            // 
            this.txtOT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOT.Location = new System.Drawing.Point(870, 293);
            this.txtOT.Name = "txtOT";
            this.txtOT.Size = new System.Drawing.Size(44, 22);
            this.txtOT.TabIndex = 7;
            this.txtOT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtOT_KeyDown);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(824, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(918, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "To";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(797, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "OT Hours";
            // 
            // dgvBatchLabourDetails
            // 
            this.dgvBatchLabourDetails.AllowUserToAddRows = false;
            this.dgvBatchLabourDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBatchLabourDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBatchLabourDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LabourRecID,
            this.EmployeeID,
            this.EmployeeName,
            this.From_emp,
            this.To_emp,
            this.OT});
            this.dgvBatchLabourDetails.Location = new System.Drawing.Point(12, 326);
            this.dgvBatchLabourDetails.Name = "dgvBatchLabourDetails";
            this.dgvBatchLabourDetails.ReadOnly = true;
            this.dgvBatchLabourDetails.Size = new System.Drawing.Size(990, 274);
            this.dgvBatchLabourDetails.TabIndex = 4;
            this.dgvBatchLabourDetails.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvBatchLabourDetails_KeyDown);
            // 
            // LabourRecID
            // 
            this.LabourRecID.DataPropertyName = "ActivityDetailsLabourID";
            this.LabourRecID.HeaderText = "LabourRecID";
            this.LabourRecID.Name = "LabourRecID";
            this.LabourRecID.ReadOnly = true;
            this.LabourRecID.Visible = false;
            // 
            // EmployeeID
            // 
            this.EmployeeID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EmployeeID.DataPropertyName = "Helper";
            this.EmployeeID.HeaderText = "EmployeeID";
            this.EmployeeID.Name = "EmployeeID";
            this.EmployeeID.ReadOnly = true;
            this.EmployeeID.Visible = false;
            // 
            // EmployeeName
            // 
            this.EmployeeName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EmployeeName.DataPropertyName = "Employee";
            this.EmployeeName.FillWeight = 200F;
            this.EmployeeName.HeaderText = "EmployeeName";
            this.EmployeeName.Name = "EmployeeName";
            this.EmployeeName.ReadOnly = true;
            // 
            // From_emp
            // 
            this.From_emp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.From_emp.DataPropertyName = "StartTime";
            this.From_emp.HeaderText = "From";
            this.From_emp.Name = "From_emp";
            this.From_emp.ReadOnly = true;
            // 
            // To_emp
            // 
            this.To_emp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.To_emp.DataPropertyName = "StopTime";
            this.To_emp.HeaderText = "To";
            this.To_emp.Name = "To_emp";
            this.To_emp.ReadOnly = true;
            // 
            // OT
            // 
            this.OT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.OT.DataPropertyName = "OTHours";
            this.OT.HeaderText = "OT";
            this.OT.Name = "OT";
            this.OT.ReadOnly = true;
            // 
            // dgvMachineDetails
            // 
            this.dgvMachineDetails.AllowUserToAddRows = false;
            this.dgvMachineDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMachineDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMachineDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MachineRecID,
            this.MachineCode,
            this.Machine,
            this.From_Machine,
            this.To_Machine});
            this.dgvMachineDetails.Location = new System.Drawing.Point(12, 54);
            this.dgvMachineDetails.Name = "dgvMachineDetails";
            this.dgvMachineDetails.ReadOnly = true;
            this.dgvMachineDetails.Size = new System.Drawing.Size(990, 184);
            this.dgvMachineDetails.TabIndex = 5;
            this.dgvMachineDetails.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvMachineDetails_KeyDown);
            // 
            // MachineRecID
            // 
            this.MachineRecID.DataPropertyName = "ActivityDetailsMachineID";
            this.MachineRecID.HeaderText = "MachineRecID";
            this.MachineRecID.Name = "MachineRecID";
            this.MachineRecID.ReadOnly = true;
            this.MachineRecID.Visible = false;
            // 
            // MachineCode
            // 
            this.MachineCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MachineCode.DataPropertyName = "MachineCode";
            this.MachineCode.HeaderText = "MachineCode";
            this.MachineCode.Name = "MachineCode";
            this.MachineCode.ReadOnly = true;
            this.MachineCode.Visible = false;
            // 
            // Machine
            // 
            this.Machine.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Machine.DataPropertyName = "MachineName";
            this.Machine.FillWeight = 150F;
            this.Machine.HeaderText = "Machine";
            this.Machine.Name = "Machine";
            this.Machine.ReadOnly = true;
            // 
            // From_Machine
            // 
            this.From_Machine.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.From_Machine.DataPropertyName = "StartTime";
            this.From_Machine.HeaderText = "From";
            this.From_Machine.Name = "From_Machine";
            this.From_Machine.ReadOnly = true;
            // 
            // To_Machine
            // 
            this.To_Machine.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.To_Machine.DataPropertyName = "StopTime";
            this.To_Machine.HeaderText = "To";
            this.To_Machine.Name = "To_Machine";
            this.To_Machine.ReadOnly = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(766, -195);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(278, 22);
            this.textBox2.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(676, -363);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(278, 22);
            this.textBox4.TabIndex = 2;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(636, -124);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 22);
            this.textBox5.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(824, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "From";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(919, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "To";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(149, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Nos";
            // 
            // txtNos
            // 
            this.txtNos.Location = new System.Drawing.Point(186, 272);
            this.txtNos.Name = "txtNos";
            this.txtNos.ReadOnly = true;
            this.txtNos.Size = new System.Drawing.Size(39, 22);
            this.txtNos.TabIndex = 4;
            this.txtNos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNos_KeyDown);
            // 
            // cmbMachine
            // 
            this.cmbMachine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbMachine.DisplayMember = "MachineName";
            this.cmbMachine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbMachine.FormattingEnabled = true;
            this.cmbMachine.Location = new System.Drawing.Point(344, 12);
            this.cmbMachine.Name = "cmbMachine";
            this.cmbMachine.Size = new System.Drawing.Size(474, 24);
            this.cmbMachine.TabIndex = 0;
            this.cmbMachine.ValueMember = "MachineID";
            this.cmbMachine.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbMachine_KeyDown);
            // 
            // txtMachineStart
            // 
            this.txtMachineStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMachineStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMachineStart.Location = new System.Drawing.Point(858, 10);
            this.txtMachineStart.Mask = "00:00";
            this.txtMachineStart.Name = "txtMachineStart";
            this.txtMachineStart.Size = new System.Drawing.Size(48, 26);
            this.txtMachineStart.TabIndex = 1;
            this.txtMachineStart.ValidatingType = typeof(System.DateTime);
            this.txtMachineStart.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMachineStart_KeyDown);
            // 
            // txtMachineStop
            // 
            this.txtMachineStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMachineStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMachineStop.Location = new System.Drawing.Point(950, 9);
            this.txtMachineStop.Mask = "00:00";
            this.txtMachineStop.Name = "txtMachineStop";
            this.txtMachineStop.Size = new System.Drawing.Size(49, 26);
            this.txtMachineStop.TabIndex = 2;
            this.txtMachineStop.ValidatingType = typeof(System.DateTime);
            this.txtMachineStop.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMachineStop_KeyDown);
            // 
            // rdbOutsource
            // 
            this.rdbOutsource.AutoSize = true;
            this.rdbOutsource.Location = new System.Drawing.Point(12, 272);
            this.rdbOutsource.Name = "rdbOutsource";
            this.rdbOutsource.Size = new System.Drawing.Size(87, 20);
            this.rdbOutsource.TabIndex = 181;
            this.rdbOutsource.TabStop = true;
            this.rdbOutsource.Text = "Outsource";
            this.rdbOutsource.UseVisualStyleBackColor = true;
            this.rdbOutsource.CheckedChanged += new System.EventHandler(this.rdbOutsource_CheckedChanged);
            // 
            // rdbPermanentSection
            // 
            this.rdbPermanentSection.AutoSize = true;
            this.rdbPermanentSection.Location = new System.Drawing.Point(12, 246);
            this.rdbPermanentSection.Name = "rdbPermanentSection";
            this.rdbPermanentSection.Size = new System.Drawing.Size(71, 20);
            this.rdbPermanentSection.TabIndex = 180;
            this.rdbPermanentSection.TabStop = true;
            this.rdbPermanentSection.Text = "Section";
            this.rdbPermanentSection.UseVisualStyleBackColor = true;
            this.rdbPermanentSection.CheckedChanged += new System.EventHandler(this.rdbPermanentSection_CheckedChanged);
            // 
            // rdbPermanentAll
            // 
            this.rdbPermanentAll.AutoSize = true;
            this.rdbPermanentAll.Location = new System.Drawing.Point(12, 298);
            this.rdbPermanentAll.Name = "rdbPermanentAll";
            this.rdbPermanentAll.Size = new System.Drawing.Size(41, 20);
            this.rdbPermanentAll.TabIndex = 179;
            this.rdbPermanentAll.TabStop = true;
            this.rdbPermanentAll.Text = "All";
            this.rdbPermanentAll.UseVisualStyleBackColor = true;
            this.rdbPermanentAll.CheckedChanged += new System.EventHandler(this.rdbPermanentAll_CheckedChanged);
            // 
            // cmbEmployee
            // 
            this.cmbEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbEmployee.DisplayMember = "Employee";
            this.cmbEmployee.FormattingEnabled = true;
            this.cmbEmployee.Location = new System.Drawing.Point(152, 296);
            this.cmbEmployee.Name = "cmbEmployee";
            this.cmbEmployee.Size = new System.Drawing.Size(616, 24);
            this.cmbEmployee.TabIndex = 3;
            this.cmbEmployee.ValueMember = "EmpID";
            this.cmbEmployee.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbEmployee_KeyDown);
            // 
            // txtFrom
            // 
            this.txtFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFrom.Location = new System.Drawing.Point(870, 258);
            this.txtFrom.Mask = "00:00";
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(42, 24);
            this.txtFrom.TabIndex = 5;
            this.txtFrom.ValidatingType = typeof(System.DateTime);
            this.txtFrom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFrom_KeyDown);
            // 
            // txtTo
            // 
            this.txtTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTo.Location = new System.Drawing.Point(950, 258);
            this.txtTo.Mask = "00:00";
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(42, 24);
            this.txtTo.TabIndex = 6;
            this.txtTo.ValidatingType = typeof(System.DateTime);
            this.txtTo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTo_KeyDown);
            // 
            // txtActivity
            // 
            this.txtActivity.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtActivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtActivity.ForeColor = System.Drawing.Color.LightCoral;
            this.txtActivity.Location = new System.Drawing.Point(12, 7);
            this.txtActivity.Name = "txtActivity";
            this.txtActivity.Size = new System.Drawing.Size(314, 29);
            this.txtActivity.TabIndex = 187;
            this.txtActivity.Text = "<Activity Name>";
            // 
            // txtOTMinutes
            // 
            this.txtOTMinutes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOTMinutes.Location = new System.Drawing.Point(950, 293);
            this.txtOTMinutes.Name = "txtOTMinutes";
            this.txtOTMinutes.Size = new System.Drawing.Size(42, 22);
            this.txtOTMinutes.TabIndex = 8;
            this.txtOTMinutes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtOTMinutes_KeyDown);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(915, 299);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 16);
            this.label7.TabIndex = 3;
            this.label7.Text = "Min";
            // 
            // btnMultiple
            // 
            this.btnMultiple.Location = new System.Drawing.Point(503, 245);
            this.btnMultiple.Name = "btnMultiple";
            this.btnMultiple.Size = new System.Drawing.Size(73, 23);
            this.btnMultiple.TabIndex = 188;
            this.btnMultiple.Text = "Multilpe";
            this.btnMultiple.UseVisualStyleBackColor = true;
            this.btnMultiple.Click += new System.EventHandler(this.btnMultiple_Click);
            // 
            // cmbSections
            // 
            this.cmbSections.DisplayMember = "SectionName";
            this.cmbSections.FormattingEnabled = true;
            this.cmbSections.Location = new System.Drawing.Point(152, 245);
            this.cmbSections.Name = "cmbSections";
            this.cmbSections.Size = new System.Drawing.Size(335, 24);
            this.cmbSections.TabIndex = 189;
            this.cmbSections.ValueMember = "SectionID";
            this.cmbSections.SelectedIndexChanged += new System.EventHandler(this.cmbSections_SelectedIndexChanged);
            // 
            // frmPRPDBatchActivity
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1004, 612);
            this.Controls.Add(this.cmbSections);
            this.Controls.Add(this.btnMultiple);
            this.Controls.Add(this.txtOTMinutes);
            this.Controls.Add(this.txtActivity);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.txtFrom);
            this.Controls.Add(this.cmbEmployee);
            this.Controls.Add(this.rdbOutsource);
            this.Controls.Add(this.rdbPermanentSection);
            this.Controls.Add(this.rdbPermanentAll);
            this.Controls.Add(this.txtMachineStop);
            this.Controls.Add(this.txtMachineStart);
            this.Controls.Add(this.cmbMachine);
            this.Controls.Add(this.dgvMachineDetails);
            this.Controls.Add(this.dgvBatchLabourDetails);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOT);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.txtNos);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmPRPDBatchActivity";
            this.Text = "PRPD Batch Activity";
            this.Load += new System.EventHandler(this.frmBatchList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.objSourceBatchList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceActivityList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBatchLabourDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMachineDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceBatchLabour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceBatchMachine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceMachineList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceSections)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource objSourceBatchList;
        private System.Windows.Forms.BindingSource objSourceActivityList;
        private System.Windows.Forms.TextBox txtOT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvBatchLabourDetails;
        private System.Windows.Forms.DataGridView dgvMachineDetails;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNos;
        private System.Windows.Forms.ComboBox cmbMachine;
        private System.Windows.Forms.BindingSource objSourceBatchLabour;
        private System.Windows.Forms.BindingSource objSourceBatchMachine;
        private System.Windows.Forms.BindingSource objSourceMachineList;
        private System.Windows.Forms.MaskedTextBox txtMachineStart;
        private System.Windows.Forms.MaskedTextBox txtMachineStop;
        private System.Windows.Forms.RadioButton rdbOutsource;
        private System.Windows.Forms.RadioButton rdbPermanentSection;
        private System.Windows.Forms.RadioButton rdbPermanentAll;
        private System.Windows.Forms.ComboBox cmbEmployee;
        private System.Windows.Forms.BindingSource objSourceEmployee;
        private System.Windows.Forms.MaskedTextBox txtFrom;
        private System.Windows.Forms.MaskedTextBox txtTo;
        private System.Windows.Forms.TextBox txtActivity;
        private System.Windows.Forms.TextBox txtOTMinutes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnMultiple;
        private System.Windows.Forms.DataGridViewTextBoxColumn LabourRecID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn From_emp;
        private System.Windows.Forms.DataGridViewTextBoxColumn To_emp;
        private System.Windows.Forms.DataGridViewTextBoxColumn OT;
        private System.Windows.Forms.ComboBox cmbSections;
        private System.Windows.Forms.BindingSource objSourceSections;
        private System.Windows.Forms.DataGridViewTextBoxColumn MachineRecID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MachineCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Machine;
        private System.Windows.Forms.DataGridViewTextBoxColumn From_Machine;
        private System.Windows.Forms.DataGridViewTextBoxColumn To_Machine;
    }
}