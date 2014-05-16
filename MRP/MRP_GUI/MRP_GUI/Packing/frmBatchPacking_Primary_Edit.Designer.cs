namespace MRP_GUI
{
    partial class frmBatchPacking_Priamry_Edit
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
            this.dgvBatcList = new System.Windows.Forms.DataGridView();
            this.BatchNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BatchFinalQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RemainingQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.txtBatchID = new System.Windows.Forms.TextBox();
            this.txtActivity = new System.Windows.Forms.TextBox();
            this.dgvActivity = new System.Windows.Forms.DataGridView();
            this.BatchActStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BatchActID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InputCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OutputCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OutputQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTransferBP = new System.Windows.Forms.Button();
            this.btnStartPacking = new System.Windows.Forms.Button();
            this.txtPackingQty = new System.Windows.Forms.TextBox();
            this.cmbFinishedProduct = new System.Windows.Forms.ComboBox();
            this.objSourceFinishedProducts = new System.Windows.Forms.BindingSource(this.components);
            this.btnFinishPacking = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBasicQty = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtOTMinutes = new System.Windows.Forms.TextBox();
            this.btnMultiple = new System.Windows.Forms.Button();
            this.cmbSection = new System.Windows.Forms.ComboBox();
            this.objSourceSections = new System.Windows.Forms.BindingSource(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblUnit1 = new System.Windows.Forms.Label();
            this.btnEditBatch = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtOutputQty = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBatcList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceBatchList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceActivityList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBatchLabourDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMachineDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceBatchLabour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceBatchMachine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceMachineList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceFinishedProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceSections)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBatcList
            // 
            this.dgvBatcList.AllowUserToAddRows = false;
            this.dgvBatcList.AllowUserToDeleteRows = false;
            this.dgvBatcList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvBatcList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBatcList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BatchNo,
            this.BatchFinalQty,
            this.RemainingQty,
            this.Unit});
            this.dgvBatcList.Location = new System.Drawing.Point(12, 54);
            this.dgvBatcList.Name = "dgvBatcList";
            this.dgvBatcList.ReadOnly = true;
            this.dgvBatcList.Size = new System.Drawing.Size(321, 473);
            this.dgvBatcList.TabIndex = 0;
            this.dgvBatcList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBatcList_CellClick);
            // 
            // BatchNo
            // 
            this.BatchNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BatchNo.DataPropertyName = "BatchID";
            this.BatchNo.FillWeight = 150F;
            this.BatchNo.HeaderText = "Batch No";
            this.BatchNo.Name = "BatchNo";
            this.BatchNo.ReadOnly = true;
            // 
            // BatchFinalQty
            // 
            this.BatchFinalQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BatchFinalQty.DataPropertyName = "BatchFinalQty";
            this.BatchFinalQty.HeaderText = "Final Qty";
            this.BatchFinalQty.Name = "BatchFinalQty";
            this.BatchFinalQty.ReadOnly = true;
            // 
            // RemainingQty
            // 
            this.RemainingQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RemainingQty.DataPropertyName = "RemainingQty";
            this.RemainingQty.HeaderText = "Rem. Qty";
            this.RemainingQty.Name = "RemainingQty";
            this.RemainingQty.ReadOnly = true;
            // 
            // Unit
            // 
            this.Unit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Unit.DataPropertyName = "UnitCode";
            this.Unit.FillWeight = 50F;
            this.Unit.HeaderText = "Unit";
            this.Unit.Name = "Unit";
            this.Unit.ReadOnly = true;
            // 
            // txtOT
            // 
            this.txtOT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOT.Location = new System.Drawing.Point(864, 314);
            this.txtOT.Name = "txtOT";
            this.txtOT.Size = new System.Drawing.Size(42, 22);
            this.txtOT.TabIndex = 2;
            this.txtOT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtOT_KeyDown);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(794, 283);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(919, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "To";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(794, 320);
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
            this.dgvBatchLabourDetails.Location = new System.Drawing.Point(349, 339);
            this.dgvBatchLabourDetails.Name = "dgvBatchLabourDetails";
            this.dgvBatchLabourDetails.ReadOnly = true;
            this.dgvBatchLabourDetails.Size = new System.Drawing.Size(653, 261);
            this.dgvBatchLabourDetails.TabIndex = 4;
            this.dgvBatchLabourDetails.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvBatchLabourDetails_KeyDown);
            // 
            // LabourRecID
            // 
            this.LabourRecID.DataPropertyName = "LabourRecID";
            this.LabourRecID.HeaderText = "LabourRecID";
            this.LabourRecID.Name = "LabourRecID";
            this.LabourRecID.ReadOnly = true;
            this.LabourRecID.Visible = false;
            // 
            // EmployeeID
            // 
            this.EmployeeID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EmployeeID.DataPropertyName = "EmployeeID";
            this.EmployeeID.HeaderText = "EmployeeID";
            this.EmployeeID.Name = "EmployeeID";
            this.EmployeeID.ReadOnly = true;
            // 
            // EmployeeName
            // 
            this.EmployeeName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EmployeeName.DataPropertyName = "EmpName";
            this.EmployeeName.FillWeight = 200F;
            this.EmployeeName.HeaderText = "EmployeeName";
            this.EmployeeName.Name = "EmployeeName";
            this.EmployeeName.ReadOnly = true;
            // 
            // From_emp
            // 
            this.From_emp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.From_emp.DataPropertyName = "WorkStart";
            this.From_emp.HeaderText = "From";
            this.From_emp.Name = "From_emp";
            this.From_emp.ReadOnly = true;
            // 
            // To_emp
            // 
            this.To_emp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.To_emp.DataPropertyName = "WorkStop";
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
            this.dgvMachineDetails.Location = new System.Drawing.Point(827, 54);
            this.dgvMachineDetails.Name = "dgvMachineDetails";
            this.dgvMachineDetails.ReadOnly = true;
            this.dgvMachineDetails.Size = new System.Drawing.Size(175, 205);
            this.dgvMachineDetails.TabIndex = 5;
            this.dgvMachineDetails.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvMachineDetails_KeyDown);
            // 
            // MachineRecID
            // 
            this.MachineRecID.DataPropertyName = "MachineRecID";
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
            this.From_Machine.DataPropertyName = "MachineStart";
            this.From_Machine.HeaderText = "From";
            this.From_Machine.Name = "From_Machine";
            this.From_Machine.ReadOnly = true;
            // 
            // To_Machine
            // 
            this.To_Machine.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.To_Machine.DataPropertyName = "MachineStop";
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
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(672, 283);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Nos";
            // 
            // txtNos
            // 
            this.txtNos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNos.Location = new System.Drawing.Point(708, 277);
            this.txtNos.Name = "txtNos";
            this.txtNos.Size = new System.Drawing.Size(39, 22);
            this.txtNos.TabIndex = 2;
            this.txtNos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNos_KeyDown);
            // 
            // cmbMachine
            // 
            this.cmbMachine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbMachine.DisplayMember = "MachineName";
            this.cmbMachine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbMachine.FormattingEnabled = true;
            this.cmbMachine.Location = new System.Drawing.Point(797, 12);
            this.cmbMachine.Name = "cmbMachine";
            this.cmbMachine.Size = new System.Drawing.Size(21, 24);
            this.cmbMachine.TabIndex = 6;
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
            this.txtMachineStart.TabIndex = 7;
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
            this.txtMachineStop.TabIndex = 7;
            this.txtMachineStop.ValidatingType = typeof(System.DateTime);
            this.txtMachineStop.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMachineStop_KeyDown);
            // 
            // rdbOutsource
            // 
            this.rdbOutsource.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbOutsource.AutoSize = true;
            this.rdbOutsource.Location = new System.Drawing.Point(627, 315);
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
            this.rdbPermanentSection.Location = new System.Drawing.Point(349, 313);
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
            this.rdbPermanentAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbPermanentAll.AutoSize = true;
            this.rdbPermanentAll.Location = new System.Drawing.Point(720, 315);
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
            this.cmbEmployee.Location = new System.Drawing.Point(349, 276);
            this.cmbEmployee.Name = "cmbEmployee";
            this.cmbEmployee.Size = new System.Drawing.Size(314, 24);
            this.cmbEmployee.TabIndex = 182;
            this.cmbEmployee.ValueMember = "EmpID";
            this.cmbEmployee.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbEmployee_KeyDown);
            // 
            // txtFrom
            // 
            this.txtFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFrom.Location = new System.Drawing.Point(864, 277);
            this.txtFrom.Mask = "00:00";
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(42, 24);
            this.txtFrom.TabIndex = 183;
            this.txtFrom.ValidatingType = typeof(System.DateTime);
            this.txtFrom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFrom_KeyDown);
            // 
            // txtTo
            // 
            this.txtTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTo.Location = new System.Drawing.Point(957, 278);
            this.txtTo.Mask = "00:00";
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(42, 24);
            this.txtTo.TabIndex = 184;
            this.txtTo.ValidatingType = typeof(System.DateTime);
            this.txtTo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTo_KeyDown);
            // 
            // txtBatchID
            // 
            this.txtBatchID.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtBatchID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBatchID.ForeColor = System.Drawing.Color.Black;
            this.txtBatchID.Location = new System.Drawing.Point(12, 11);
            this.txtBatchID.Name = "txtBatchID";
            this.txtBatchID.Size = new System.Drawing.Size(153, 29);
            this.txtBatchID.TabIndex = 186;
            this.txtBatchID.Text = "<Batch ID>";
            // 
            // txtActivity
            // 
            this.txtActivity.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtActivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtActivity.ForeColor = System.Drawing.Color.Black;
            this.txtActivity.Location = new System.Drawing.Point(181, 11);
            this.txtActivity.Name = "txtActivity";
            this.txtActivity.Size = new System.Drawing.Size(152, 29);
            this.txtActivity.TabIndex = 187;
            this.txtActivity.Text = "<Activity Name>";
            // 
            // dgvActivity
            // 
            this.dgvActivity.AllowUserToAddRows = false;
            this.dgvActivity.AllowUserToDeleteRows = false;
            this.dgvActivity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActivity.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BatchActStatus,
            this.BatchActID,
            this.InputCode,
            this.Qty,
            this.OutputCode,
            this.OutputQty});
            this.dgvActivity.Location = new System.Drawing.Point(347, 89);
            this.dgvActivity.Name = "dgvActivity";
            this.dgvActivity.ReadOnly = true;
            this.dgvActivity.Size = new System.Drawing.Size(474, 170);
            this.dgvActivity.TabIndex = 188;
            this.dgvActivity.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvActivity_CellClick);
            // 
            // BatchActStatus
            // 
            this.BatchActStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BatchActStatus.DataPropertyName = "BatchActStatus";
            this.BatchActStatus.HeaderText = "BatchActStatus";
            this.BatchActStatus.Name = "BatchActStatus";
            this.BatchActStatus.ReadOnly = true;
            this.BatchActStatus.Visible = false;
            // 
            // BatchActID
            // 
            this.BatchActID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BatchActID.DataPropertyName = "BatchActID";
            this.BatchActID.FillWeight = 50F;
            this.BatchActID.HeaderText = "ID";
            this.BatchActID.Name = "BatchActID";
            this.BatchActID.ReadOnly = true;
            // 
            // InputCode
            // 
            this.InputCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.InputCode.DataPropertyName = "StartProductCode";
            this.InputCode.FillWeight = 75F;
            this.InputCode.HeaderText = "Input Code";
            this.InputCode.Name = "InputCode";
            this.InputCode.ReadOnly = true;
            // 
            // Qty
            // 
            this.Qty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Qty.DataPropertyName = "StartQty";
            this.Qty.FillWeight = 50F;
            this.Qty.HeaderText = "InputQty";
            this.Qty.Name = "Qty";
            this.Qty.ReadOnly = true;
            // 
            // OutputCode
            // 
            this.OutputCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.OutputCode.DataPropertyName = "EndProductCode";
            this.OutputCode.HeaderText = "Output Code";
            this.OutputCode.Name = "OutputCode";
            this.OutputCode.ReadOnly = true;
            // 
            // OutputQty
            // 
            this.OutputQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.OutputQty.DataPropertyName = "StopQty";
            this.OutputQty.FillWeight = 75F;
            this.OutputQty.HeaderText = "Output Qty";
            this.OutputQty.Name = "OutputQty";
            this.OutputQty.ReadOnly = true;
            // 
            // btnTransferBP
            // 
            this.btnTransferBP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTransferBP.Location = new System.Drawing.Point(12, 533);
            this.btnTransferBP.Name = "btnTransferBP";
            this.btnTransferBP.Size = new System.Drawing.Size(173, 30);
            this.btnTransferBP.TabIndex = 190;
            this.btnTransferBP.Text = "Transfer Basic Product";
            this.btnTransferBP.UseVisualStyleBackColor = true;
            this.btnTransferBP.Click += new System.EventHandler(this.btnTransferBP_Click);
            // 
            // btnStartPacking
            // 
            this.btnStartPacking.Enabled = false;
            this.btnStartPacking.Location = new System.Drawing.Point(751, 54);
            this.btnStartPacking.Name = "btnStartPacking";
            this.btnStartPacking.Size = new System.Drawing.Size(10, 29);
            this.btnStartPacking.TabIndex = 191;
            this.btnStartPacking.Text = "Start";
            this.btnStartPacking.UseVisualStyleBackColor = true;
            this.btnStartPacking.Visible = false;
            this.btnStartPacking.Click += new System.EventHandler(this.btnStartPacking_Click);
            // 
            // txtPackingQty
            // 
            this.txtPackingQty.BackColor = System.Drawing.SystemColors.Window;
            this.txtPackingQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPackingQty.ForeColor = System.Drawing.Color.Black;
            this.txtPackingQty.Location = new System.Drawing.Point(420, 54);
            this.txtPackingQty.Name = "txtPackingQty";
            this.txtPackingQty.Size = new System.Drawing.Size(74, 29);
            this.txtPackingQty.TabIndex = 192;
            this.txtPackingQty.Click += new System.EventHandler(this.txtPackingQty_Click);
            // 
            // cmbFinishedProduct
            // 
            this.cmbFinishedProduct.BackColor = System.Drawing.SystemColors.Window;
            this.cmbFinishedProduct.DisplayMember = "FinishProduct";
            this.cmbFinishedProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFinishedProduct.ForeColor = System.Drawing.Color.Black;
            this.cmbFinishedProduct.FormattingEnabled = true;
            this.cmbFinishedProduct.Location = new System.Drawing.Point(347, 10);
            this.cmbFinishedProduct.Name = "cmbFinishedProduct";
            this.cmbFinishedProduct.Size = new System.Drawing.Size(443, 32);
            this.cmbFinishedProduct.TabIndex = 193;
            this.cmbFinishedProduct.ValueMember = "FinishProductCode";
            // 
            // btnFinishPacking
            // 
            this.btnFinishPacking.Enabled = false;
            this.btnFinishPacking.Location = new System.Drawing.Point(765, 54);
            this.btnFinishPacking.Name = "btnFinishPacking";
            this.btnFinishPacking.Size = new System.Drawing.Size(56, 29);
            this.btnFinishPacking.TabIndex = 194;
            this.btnFinishPacking.Text = "Finish";
            this.btnFinishPacking.UseVisualStyleBackColor = true;
            this.btnFinishPacking.Click += new System.EventHandler(this.btnFinishPacking_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(346, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 16);
            this.label7.TabIndex = 195;
            this.label7.Text = "Input Qty";
            // 
            // txtBasicQty
            // 
            this.txtBasicQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtBasicQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBasicQty.Location = new System.Drawing.Point(225, 534);
            this.txtBasicQty.Name = "txtBasicQty";
            this.txtBasicQty.Size = new System.Drawing.Size(77, 26);
            this.txtBasicQty.TabIndex = 196;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(919, 320);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 16);
            this.label8.TabIndex = 197;
            this.label8.Text = "Min";
            // 
            // txtOTMinutes
            // 
            this.txtOTMinutes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOTMinutes.Location = new System.Drawing.Point(957, 314);
            this.txtOTMinutes.Name = "txtOTMinutes";
            this.txtOTMinutes.Size = new System.Drawing.Size(42, 22);
            this.txtOTMinutes.TabIndex = 198;
            this.txtOTMinutes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtOTMinutes_KeyDown);
            // 
            // btnMultiple
            // 
            this.btnMultiple.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMultiple.Location = new System.Drawing.Point(529, 306);
            this.btnMultiple.Name = "btnMultiple";
            this.btnMultiple.Size = new System.Drawing.Size(92, 27);
            this.btnMultiple.TabIndex = 199;
            this.btnMultiple.Text = "Multilpe";
            this.btnMultiple.UseVisualStyleBackColor = true;
            this.btnMultiple.Click += new System.EventHandler(this.btnMultiple_Click);
            // 
            // cmbSection
            // 
            this.cmbSection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbSection.DisplayMember = "SectionName";
            this.cmbSection.FormattingEnabled = true;
            this.cmbSection.Location = new System.Drawing.Point(426, 309);
            this.cmbSection.Name = "cmbSection";
            this.cmbSection.Size = new System.Drawing.Size(86, 24);
            this.cmbSection.TabIndex = 200;
            this.cmbSection.ValueMember = "SectionID";
            this.cmbSection.SelectedIndexChanged += new System.EventHandler(this.cmbSection_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 587);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(290, 16);
            this.label9.TabIndex = 201;
            this.label9.Text = "F2 - To Issue Packing Materials to Batch ";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 567);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(274, 16);
            this.label10.TabIndex = 201;
            this.label10.Text = "F1 - To View Materials Taken to Batch ";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(191, 544);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 16);
            this.label11.TabIndex = 202;
            this.label11.Text = "Qty";
            // 
            // lblUnit1
            // 
            this.lblUnit1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblUnit1.AutoSize = true;
            this.lblUnit1.Location = new System.Drawing.Point(305, 544);
            this.lblUnit1.Name = "lblUnit1";
            this.lblUnit1.Size = new System.Drawing.Size(42, 16);
            this.lblUnit1.TabIndex = 202;
            this.lblUnit1.Text = "<unit>";
            // 
            // btnEditBatch
            // 
            this.btnEditBatch.Location = new System.Drawing.Point(675, 54);
            this.btnEditBatch.Name = "btnEditBatch";
            this.btnEditBatch.Size = new System.Drawing.Size(85, 29);
            this.btnEditBatch.TabIndex = 204;
            this.btnEditBatch.Text = "Edit Batch";
            this.btnEditBatch.UseVisualStyleBackColor = true;
            this.btnEditBatch.Click += new System.EventHandler(this.btnEditBatch_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(509, 67);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 16);
            this.label12.TabIndex = 195;
            this.label12.Text = "Output Qty";
            // 
            // txtOutputQty
            // 
            this.txtOutputQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutputQty.Location = new System.Drawing.Point(594, 54);
            this.txtOutputQty.Name = "txtOutputQty";
            this.txtOutputQty.Size = new System.Drawing.Size(69, 29);
            this.txtOutputQty.TabIndex = 205;
            // 
            // frmBatchPacking_Priamry_Edit
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1004, 612);
            this.Controls.Add(this.txtOutputQty);
            this.Controls.Add(this.btnEditBatch);
            this.Controls.Add(this.lblUnit1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbSection);
            this.Controls.Add(this.btnMultiple);
            this.Controls.Add(this.txtOTMinutes);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtBasicQty);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnFinishPacking);
            this.Controls.Add(this.cmbFinishedProduct);
            this.Controls.Add(this.txtPackingQty);
            this.Controls.Add(this.btnStartPacking);
            this.Controls.Add(this.btnTransferBP);
            this.Controls.Add(this.dgvActivity);
            this.Controls.Add(this.txtActivity);
            this.Controls.Add(this.txtBatchID);
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
            this.Controls.Add(this.dgvBatcList);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmBatchPacking_Priamry_Edit";
            this.Text = "Batch List - Packaging Primary";
            this.Load += new System.EventHandler(this.frmBatchList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBatcList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceBatchList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceActivityList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBatchLabourDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMachineDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceBatchLabour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceBatchMachine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceMachineList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceFinishedProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceSections)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBatcList;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn LabourRecID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn From_emp;
        private System.Windows.Forms.DataGridViewTextBoxColumn To_emp;
        private System.Windows.Forms.DataGridViewTextBoxColumn OT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MachineRecID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MachineCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Machine;
        private System.Windows.Forms.DataGridViewTextBoxColumn From_Machine;
        private System.Windows.Forms.DataGridViewTextBoxColumn To_Machine;
        private System.Windows.Forms.TextBox txtBatchID;
        private System.Windows.Forms.TextBox txtActivity;
        private System.Windows.Forms.DataGridView dgvActivity;
        private System.Windows.Forms.Button btnTransferBP;
        private System.Windows.Forms.Button btnStartPacking;
        private System.Windows.Forms.TextBox txtPackingQty;
        private System.Windows.Forms.ComboBox cmbFinishedProduct;
        private System.Windows.Forms.BindingSource objSourceFinishedProducts;
        private System.Windows.Forms.Button btnFinishPacking;
        private System.Windows.Forms.DataGridViewTextBoxColumn BatchActStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn BatchActID;
        private System.Windows.Forms.DataGridViewTextBoxColumn InputCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn OutputCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn OutputQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn BatchNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn BatchFinalQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn RemainingQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBasicQty;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtOTMinutes;
        private System.Windows.Forms.Button btnMultiple;
        private System.Windows.Forms.ComboBox cmbSection;
        private System.Windows.Forms.BindingSource objSourceSections;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblUnit1;
        private System.Windows.Forms.Button btnEditBatch;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtOutputQty;
    }
}