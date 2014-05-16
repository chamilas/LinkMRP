namespace MRP_GUI
{
    partial class frmRPDBatchInitialize
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblID = new System.Windows.Forms.Label();
            this.lblUnitMat = new System.Windows.Forms.Label();
            this.txtQtyBasic = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbBatchType = new System.Windows.Forms.ComboBox();
            this.btnClearInstruction = new System.Windows.Forms.Button();
            this.grpInstructions = new System.Windows.Forms.GroupBox();
            this.cmbMachine = new System.Windows.Forms.ComboBox();
            this.dgvActivityInstructions = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Activity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InstructionDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Machine_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ParticleSize_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtParticleSize = new System.Windows.Forms.TextBox();
            this.lblParticleSize = new System.Windows.Forms.Label();
            this.cmbActivityInstructions = new System.Windows.Forms.ComboBox();
            this.btnDeleteInstruction = new System.Windows.Forms.Button();
            this.lblMachine = new System.Windows.Forms.Label();
            this.btnAddInstructions = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.bindInstructions = new System.Windows.Forms.BindingSource(this.components);
            this.bindMachine = new System.Windows.Forms.BindingSource(this.components);
            this.btnCreate = new System.Windows.Forms.Button();
            this.grpProduction = new System.Windows.Forms.GroupBox();
            this.lblUnit1 = new System.Windows.Forms.Label();
            this.gvProduction = new System.Windows.Forms.DataGridView();
            this.MaterialCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Material_Int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnMaterialClear = new System.Windows.Forms.Button();
            this.btnMaterialDelete = new System.Windows.Forms.Button();
            this.btnAddMaterial = new System.Windows.Forms.Button();
            this.cmbMaterialInter = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtMaterialQty = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.bindProduction = new System.Windows.Forms.BindingSource(this.components);
            this.bindMaterial_Inter = new System.Windows.Forms.BindingSource(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.bindRPDBatch = new System.Windows.Forms.BindingSource(this.components);
            this.gvRPDBatch = new System.Windows.Forms.DataGridView();
            this.RPDBatchID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Material = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RPDBatchQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbMaterialList = new System.Windows.Forms.ComboBox();
            this.dgvGRN_LP = new System.Windows.Forms.DataGridView();
            this.GRNNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GrossQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IssuedQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RemainingQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindMaterail_LP = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.objSourceLPStock = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pnlBatchDetails = new System.Windows.Forms.Panel();
            this.btnFinish = new System.Windows.Forms.Button();
            this.grpInstructions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivityInstructions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindInstructions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindMachine)).BeginInit();
            this.grpProduction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvProduction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindProduction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindMaterial_Inter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindRPDBatch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvRPDBatch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGRN_LP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindMaterail_LP)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceLPStock)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.pnlBatchDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(80, 39);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(35, 13);
            this.lblID.TabIndex = 38;
            this.lblID.Text = "[Auto]";
            // 
            // lblUnitMat
            // 
            this.lblUnitMat.AutoSize = true;
            this.lblUnitMat.Location = new System.Drawing.Point(242, 111);
            this.lblUnitMat.Name = "lblUnitMat";
            this.lblUnitMat.Size = new System.Drawing.Size(38, 13);
            this.lblUnitMat.TabIndex = 37;
            this.lblUnitMat.Text = "<Unit>";
            // 
            // txtQtyBasic
            // 
            this.txtQtyBasic.Location = new System.Drawing.Point(83, 103);
            this.txtQtyBasic.Name = "txtQtyBasic";
            this.txtQtyBasic.Size = new System.Drawing.Size(160, 20);
            this.txtQtyBasic.TabIndex = 36;
            this.txtQtyBasic.Text = "0.00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Quantity*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Batch No";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 40;
            this.label7.Text = "Batch Type";
            // 
            // cmbBatchType
            // 
            this.cmbBatchType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbBatchType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbBatchType.DisplayMember = "MaterialCategoryName";
            this.cmbBatchType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBatchType.FormattingEnabled = true;
            this.cmbBatchType.Items.AddRange(new object[] {
            "Normal",
            "Powder"});
            this.cmbBatchType.Location = new System.Drawing.Point(83, 8);
            this.cmbBatchType.Name = "cmbBatchType";
            this.cmbBatchType.Size = new System.Drawing.Size(149, 21);
            this.cmbBatchType.TabIndex = 41;
            this.cmbBatchType.ValueMember = "MatCatID";
            this.cmbBatchType.SelectedIndexChanged += new System.EventHandler(this.cmbBatchType_SelectedIndexChanged);
            // 
            // btnClearInstruction
            // 
            this.btnClearInstruction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearInstruction.Location = new System.Drawing.Point(179, 140);
            this.btnClearInstruction.Name = "btnClearInstruction";
            this.btnClearInstruction.Size = new System.Drawing.Size(75, 23);
            this.btnClearInstruction.TabIndex = 46;
            this.btnClearInstruction.Text = "Clear";
            this.btnClearInstruction.UseVisualStyleBackColor = true;
            this.btnClearInstruction.Click += new System.EventHandler(this.btnClearInstruction_Click);
            // 
            // grpInstructions
            // 
            this.grpInstructions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpInstructions.Controls.Add(this.cmbMachine);
            this.grpInstructions.Controls.Add(this.dgvActivityInstructions);
            this.grpInstructions.Controls.Add(this.txtParticleSize);
            this.grpInstructions.Controls.Add(this.lblParticleSize);
            this.grpInstructions.Controls.Add(this.cmbActivityInstructions);
            this.grpInstructions.Controls.Add(this.btnClearInstruction);
            this.grpInstructions.Controls.Add(this.btnDeleteInstruction);
            this.grpInstructions.Controls.Add(this.lblMachine);
            this.grpInstructions.Controls.Add(this.btnAddInstructions);
            this.grpInstructions.Controls.Add(this.txtDescription);
            this.grpInstructions.Controls.Add(this.label12);
            this.grpInstructions.Controls.Add(this.label13);
            this.grpInstructions.Enabled = false;
            this.grpInstructions.Location = new System.Drawing.Point(547, 7);
            this.grpInstructions.Name = "grpInstructions";
            this.grpInstructions.Size = new System.Drawing.Size(563, 387);
            this.grpInstructions.TabIndex = 47;
            this.grpInstructions.TabStop = false;
            this.grpInstructions.Text = "Activity Instructions";
            // 
            // cmbMachine
            // 
            this.cmbMachine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbMachine.DisplayMember = "MachineName";
            this.cmbMachine.FormattingEnabled = true;
            this.cmbMachine.Location = new System.Drawing.Point(79, 113);
            this.cmbMachine.Name = "cmbMachine";
            this.cmbMachine.Size = new System.Drawing.Size(337, 21);
            this.cmbMachine.TabIndex = 47;
            this.cmbMachine.ValueMember = "MachinceCode";
            // 
            // dgvActivityInstructions
            // 
            this.dgvActivityInstructions.AllowUserToAddRows = false;
            this.dgvActivityInstructions.AllowUserToDeleteRows = false;
            this.dgvActivityInstructions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvActivityInstructions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvActivityInstructions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActivityInstructions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Activity,
            this.InstructionDesc,
            this.Machine_,
            this.ParticleSize_});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvActivityInstructions.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvActivityInstructions.Location = new System.Drawing.Point(6, 169);
            this.dgvActivityInstructions.Name = "dgvActivityInstructions";
            this.dgvActivityInstructions.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvActivityInstructions.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvActivityInstructions.RowTemplate.Height = 23;
            this.dgvActivityInstructions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvActivityInstructions.Size = new System.Drawing.Size(551, 185);
            this.dgvActivityInstructions.TabIndex = 7;
            this.dgvActivityInstructions.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvActivityInstructions_CellClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "RPDBatchActivityInstructionsID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // Activity
            // 
            this.Activity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Activity.DataPropertyName = "MainActivity";
            this.Activity.HeaderText = "Activity";
            this.Activity.Name = "Activity";
            this.Activity.ReadOnly = true;
            // 
            // InstructionDesc
            // 
            this.InstructionDesc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.InstructionDesc.DataPropertyName = "InstructionDesc";
            this.InstructionDesc.HeaderText = "InstructionDesc";
            this.InstructionDesc.Name = "InstructionDesc";
            this.InstructionDesc.ReadOnly = true;
            // 
            // Machine_
            // 
            this.Machine_.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Machine_.DataPropertyName = "Machine";
            this.Machine_.HeaderText = "Machine";
            this.Machine_.Name = "Machine_";
            this.Machine_.ReadOnly = true;
            // 
            // ParticleSize_
            // 
            this.ParticleSize_.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ParticleSize_.DataPropertyName = "ParticleSize";
            this.ParticleSize_.HeaderText = "ParticleSize";
            this.ParticleSize_.Name = "ParticleSize_";
            this.ParticleSize_.ReadOnly = true;
            // 
            // txtParticleSize
            // 
            this.txtParticleSize.Location = new System.Drawing.Point(74, 140);
            this.txtParticleSize.Name = "txtParticleSize";
            this.txtParticleSize.Size = new System.Drawing.Size(71, 20);
            this.txtParticleSize.TabIndex = 22;
            this.txtParticleSize.Text = "0.00";
            // 
            // lblParticleSize
            // 
            this.lblParticleSize.AutoSize = true;
            this.lblParticleSize.Location = new System.Drawing.Point(8, 144);
            this.lblParticleSize.Name = "lblParticleSize";
            this.lblParticleSize.Size = new System.Drawing.Size(62, 13);
            this.lblParticleSize.TabIndex = 20;
            this.lblParticleSize.Text = "ParticleSize";
            // 
            // cmbActivityInstructions
            // 
            this.cmbActivityInstructions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbActivityInstructions.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbActivityInstructions.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbActivityInstructions.DisplayMember = "MainActivity";
            this.cmbActivityInstructions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbActivityInstructions.FormattingEnabled = true;
            this.cmbActivityInstructions.Location = new System.Drawing.Point(79, 19);
            this.cmbActivityInstructions.Name = "cmbActivityInstructions";
            this.cmbActivityInstructions.Size = new System.Drawing.Size(337, 21);
            this.cmbActivityInstructions.TabIndex = 23;
            this.cmbActivityInstructions.ValueMember = "MainActID";
            this.cmbActivityInstructions.SelectedIndexChanged += new System.EventHandler(this.cmbActivityInstructions_SelectedIndexChanged);
            // 
            // btnDeleteInstruction
            // 
            this.btnDeleteInstruction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteInstruction.Enabled = false;
            this.btnDeleteInstruction.Location = new System.Drawing.Point(260, 140);
            this.btnDeleteInstruction.Name = "btnDeleteInstruction";
            this.btnDeleteInstruction.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteInstruction.TabIndex = 20;
            this.btnDeleteInstruction.Text = "Delete";
            this.btnDeleteInstruction.UseVisualStyleBackColor = true;
            this.btnDeleteInstruction.Click += new System.EventHandler(this.btnDeleteInstruction_Click);
            // 
            // lblMachine
            // 
            this.lblMachine.AutoSize = true;
            this.lblMachine.Location = new System.Drawing.Point(22, 119);
            this.lblMachine.Name = "lblMachine";
            this.lblMachine.Size = new System.Drawing.Size(48, 13);
            this.lblMachine.TabIndex = 19;
            this.lblMachine.Text = "Machine";
            // 
            // btnAddInstructions
            // 
            this.btnAddInstructions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddInstructions.Location = new System.Drawing.Point(341, 140);
            this.btnAddInstructions.Name = "btnAddInstructions";
            this.btnAddInstructions.Size = new System.Drawing.Size(75, 23);
            this.btnAddInstructions.TabIndex = 19;
            this.btnAddInstructions.Text = "Add";
            this.btnAddInstructions.UseVisualStyleBackColor = true;
            this.btnAddInstructions.Click += new System.EventHandler(this.btnAddInstructions_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.Location = new System.Drawing.Point(79, 44);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(337, 68);
            this.txtDescription.TabIndex = 17;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(14, 46);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 13);
            this.label12.TabIndex = 16;
            this.label12.Text = "Instruction";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(29, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 13);
            this.label13.TabIndex = 14;
            this.label13.Text = "Activity";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(381, 101);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(89, 23);
            this.btnCreate.TabIndex = 50;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // grpProduction
            // 
            this.grpProduction.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpProduction.Controls.Add(this.lblUnit1);
            this.grpProduction.Controls.Add(this.gvProduction);
            this.grpProduction.Controls.Add(this.btnMaterialClear);
            this.grpProduction.Controls.Add(this.btnMaterialDelete);
            this.grpProduction.Controls.Add(this.btnAddMaterial);
            this.grpProduction.Controls.Add(this.cmbMaterialInter);
            this.grpProduction.Controls.Add(this.label15);
            this.grpProduction.Controls.Add(this.txtMaterialQty);
            this.grpProduction.Controls.Add(this.label11);
            this.grpProduction.Enabled = false;
            this.grpProduction.Location = new System.Drawing.Point(547, 362);
            this.grpProduction.Name = "grpProduction";
            this.grpProduction.Size = new System.Drawing.Size(563, 218);
            this.grpProduction.TabIndex = 51;
            this.grpProduction.TabStop = false;
            this.grpProduction.Text = "Planned Production";
            // 
            // lblUnit1
            // 
            this.lblUnit1.AutoSize = true;
            this.lblUnit1.Location = new System.Drawing.Point(135, 51);
            this.lblUnit1.Name = "lblUnit1";
            this.lblUnit1.Size = new System.Drawing.Size(38, 13);
            this.lblUnit1.TabIndex = 51;
            this.lblUnit1.Text = "<Unit>";
            // 
            // gvProduction
            // 
            this.gvProduction.AllowUserToAddRows = false;
            this.gvProduction.AllowUserToDeleteRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gvProduction.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.gvProduction.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvProduction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvProduction.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaterialCode,
            this.Material_Int,
            this.Qty});
            this.gvProduction.Location = new System.Drawing.Point(6, 78);
            this.gvProduction.Name = "gvProduction";
            this.gvProduction.ReadOnly = true;
            this.gvProduction.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvProduction.RowTemplate.Height = 20;
            this.gvProduction.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvProduction.Size = new System.Drawing.Size(551, 134);
            this.gvProduction.TabIndex = 50;
            this.gvProduction.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvProduction_CellClick);
            // 
            // MaterialCode
            // 
            this.MaterialCode.DataPropertyName = "MaterialCode";
            this.MaterialCode.HeaderText = "MaterialCode";
            this.MaterialCode.Name = "MaterialCode";
            this.MaterialCode.ReadOnly = true;
            this.MaterialCode.Visible = false;
            // 
            // Material_Int
            // 
            this.Material_Int.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Material_Int.DataPropertyName = "Material";
            this.Material_Int.FillWeight = 250F;
            this.Material_Int.HeaderText = "Material";
            this.Material_Int.Name = "Material_Int";
            this.Material_Int.ReadOnly = true;
            // 
            // Qty
            // 
            this.Qty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Qty.DataPropertyName = "Qty";
            this.Qty.HeaderText = "Qty";
            this.Qty.Name = "Qty";
            this.Qty.ReadOnly = true;
            // 
            // btnMaterialClear
            // 
            this.btnMaterialClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaterialClear.Location = new System.Drawing.Point(179, 46);
            this.btnMaterialClear.Name = "btnMaterialClear";
            this.btnMaterialClear.Size = new System.Drawing.Size(75, 23);
            this.btnMaterialClear.TabIndex = 49;
            this.btnMaterialClear.Text = "Clear";
            this.btnMaterialClear.UseVisualStyleBackColor = true;
            this.btnMaterialClear.Click += new System.EventHandler(this.btnMaterialClear_Click);
            // 
            // btnMaterialDelete
            // 
            this.btnMaterialDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaterialDelete.Enabled = false;
            this.btnMaterialDelete.Location = new System.Drawing.Point(260, 46);
            this.btnMaterialDelete.Name = "btnMaterialDelete";
            this.btnMaterialDelete.Size = new System.Drawing.Size(75, 23);
            this.btnMaterialDelete.TabIndex = 48;
            this.btnMaterialDelete.Text = "Delete";
            this.btnMaterialDelete.UseVisualStyleBackColor = true;
            this.btnMaterialDelete.Click += new System.EventHandler(this.btnMaterialDelete_Click);
            // 
            // btnAddMaterial
            // 
            this.btnAddMaterial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddMaterial.Location = new System.Drawing.Point(341, 46);
            this.btnAddMaterial.Name = "btnAddMaterial";
            this.btnAddMaterial.Size = new System.Drawing.Size(75, 23);
            this.btnAddMaterial.TabIndex = 47;
            this.btnAddMaterial.Text = "Add";
            this.btnAddMaterial.UseVisualStyleBackColor = true;
            this.btnAddMaterial.Click += new System.EventHandler(this.btnAddMaterial_Click);
            // 
            // cmbMaterialInter
            // 
            this.cmbMaterialInter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbMaterialInter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbMaterialInter.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbMaterialInter.DisplayMember = "Material";
            this.cmbMaterialInter.FormattingEnabled = true;
            this.cmbMaterialInter.Location = new System.Drawing.Point(57, 19);
            this.cmbMaterialInter.Name = "cmbMaterialInter";
            this.cmbMaterialInter.Size = new System.Drawing.Size(358, 21);
            this.cmbMaterialInter.TabIndex = 3;
            this.cmbMaterialInter.ValueMember = "MaterialCode";
            this.cmbMaterialInter.SelectedIndexChanged += new System.EventHandler(this.cmbMaterial_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(10, 22);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 13);
            this.label15.TabIndex = 2;
            this.label15.Text = "Material";
            // 
            // txtMaterialQty
            // 
            this.txtMaterialQty.Location = new System.Drawing.Point(57, 48);
            this.txtMaterialQty.Name = "txtMaterialQty";
            this.txtMaterialQty.Size = new System.Drawing.Size(72, 20);
            this.txtMaterialQty.TabIndex = 1;
            this.txtMaterialQty.Text = "0.00";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 51);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Quantity";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 53;
            this.label8.Text = "Material";
            // 
            // gvRPDBatch
            // 
            this.gvRPDBatch.AllowUserToAddRows = false;
            this.gvRPDBatch.AllowUserToDeleteRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gvRPDBatch.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.gvRPDBatch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gvRPDBatch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvRPDBatch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RPDBatchID,
            this.Material,
            this.Status,
            this.RPDBatchQty});
            this.gvRPDBatch.Location = new System.Drawing.Point(6, 25);
            this.gvRPDBatch.Name = "gvRPDBatch";
            this.gvRPDBatch.ReadOnly = true;
            this.gvRPDBatch.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvRPDBatch.RowTemplate.Height = 20;
            this.gvRPDBatch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvRPDBatch.Size = new System.Drawing.Size(517, 212);
            this.gvRPDBatch.TabIndex = 54;
            // 
            // RPDBatchID
            // 
            this.RPDBatchID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RPDBatchID.DataPropertyName = "RPDBatchID";
            this.RPDBatchID.HeaderText = "RPDBatchID";
            this.RPDBatchID.Name = "RPDBatchID";
            this.RPDBatchID.ReadOnly = true;
            // 
            // Material
            // 
            this.Material.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Material.DataPropertyName = "Material";
            this.Material.HeaderText = "Material";
            this.Material.Name = "Material";
            this.Material.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Status.DataPropertyName = "Status";
            this.Status.FillWeight = 70F;
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // RPDBatchQty
            // 
            this.RPDBatchQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RPDBatchQty.DataPropertyName = "RPDBatchQty";
            this.RPDBatchQty.FillWeight = 70F;
            this.RPDBatchQty.HeaderText = "RPDBatchQty";
            this.RPDBatchQty.Name = "RPDBatchQty";
            this.RPDBatchQty.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ActivityName";
            this.dataGridViewTextBoxColumn1.HeaderText = "Instruction";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MachineName";
            this.dataGridViewTextBoxColumn2.HeaderText = "Machine";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Size";
            this.dataGridViewTextBoxColumn3.HeaderText = "ParticleSize";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Type";
            this.dataGridViewTextBoxColumn4.HeaderText = "Type";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn5.HeaderText = "Description";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "MaterialCode";
            this.dataGridViewTextBoxColumn6.HeaderText = "Material Code";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Qty";
            this.dataGridViewTextBoxColumn7.HeaderText = "Qty";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 150;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "UnitCode";
            this.dataGridViewTextBoxColumn8.HeaderText = "Unit";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Material";
            this.dataGridViewTextBoxColumn10.FillWeight = 180F;
            this.dataGridViewTextBoxColumn10.HeaderText = "Material";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 180;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "RPDBatchQty";
            this.dataGridViewTextBoxColumn11.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // cmbMaterialList
            // 
            this.cmbMaterialList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbMaterialList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbMaterialList.DisplayMember = "Material";
            this.cmbMaterialList.FormattingEnabled = true;
            this.cmbMaterialList.Location = new System.Drawing.Point(83, 60);
            this.cmbMaterialList.Name = "cmbMaterialList";
            this.cmbMaterialList.Size = new System.Drawing.Size(387, 21);
            this.cmbMaterialList.TabIndex = 57;
            this.cmbMaterialList.ValueMember = "MaterialCode";
            this.cmbMaterialList.SelectedIndexChanged += new System.EventHandler(this.cmbMaterialList_SelectedIndexChanged);
            // 
            // dgvGRN_LP
            // 
            this.dgvGRN_LP.AllowUserToAddRows = false;
            this.dgvGRN_LP.AllowUserToDeleteRows = false;
            this.dgvGRN_LP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvGRN_LP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGRN_LP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GRNNO,
            this.GrossQty,
            this.IssuedQty,
            this.RemainingQty});
            this.dgvGRN_LP.Location = new System.Drawing.Point(6, 5);
            this.dgvGRN_LP.Name = "dgvGRN_LP";
            this.dgvGRN_LP.ReadOnly = true;
            this.dgvGRN_LP.Size = new System.Drawing.Size(517, 169);
            this.dgvGRN_LP.TabIndex = 58;
            // 
            // GRNNO
            // 
            this.GRNNO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GRNNO.DataPropertyName = "GRNNO";
            this.GRNNO.HeaderText = "GRNNO";
            this.GRNNO.Name = "GRNNO";
            this.GRNNO.ReadOnly = true;
            // 
            // GrossQty
            // 
            this.GrossQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GrossQty.DataPropertyName = "GrossQty";
            this.GrossQty.HeaderText = "GrossQty";
            this.GrossQty.Name = "GrossQty";
            this.GrossQty.ReadOnly = true;
            // 
            // IssuedQty
            // 
            this.IssuedQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IssuedQty.HeaderText = "IssuedQty";
            this.IssuedQty.Name = "IssuedQty";
            this.IssuedQty.ReadOnly = true;
            this.IssuedQty.Visible = false;
            // 
            // RemainingQty
            // 
            this.RemainingQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RemainingQty.HeaderText = "RemainingQty";
            this.RemainingQty.Name = "RemainingQty";
            this.RemainingQty.ReadOnly = true;
            this.RemainingQty.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.gvRPDBatch);
            this.groupBox1.Location = new System.Drawing.Point(12, 151);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(529, 243);
            this.groupBox1.TabIndex = 59;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RPD Batches - Not Finished";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.dgvGRN_LP);
            this.groupBox2.Location = new System.Drawing.Point(12, 400);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(529, 180);
            this.groupBox2.TabIndex = 60;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Processed Stock";
            // 
            // pnlBatchDetails
            // 
            this.pnlBatchDetails.Controls.Add(this.label7);
            this.pnlBatchDetails.Controls.Add(this.label1);
            this.pnlBatchDetails.Controls.Add(this.label6);
            this.pnlBatchDetails.Controls.Add(this.cmbMaterialList);
            this.pnlBatchDetails.Controls.Add(this.txtQtyBasic);
            this.pnlBatchDetails.Controls.Add(this.label8);
            this.pnlBatchDetails.Controls.Add(this.lblUnitMat);
            this.pnlBatchDetails.Controls.Add(this.lblID);
            this.pnlBatchDetails.Controls.Add(this.btnCreate);
            this.pnlBatchDetails.Controls.Add(this.cmbBatchType);
            this.pnlBatchDetails.Location = new System.Drawing.Point(12, 12);
            this.pnlBatchDetails.Name = "pnlBatchDetails";
            this.pnlBatchDetails.Size = new System.Drawing.Size(529, 134);
            this.pnlBatchDetails.TabIndex = 61;
            // 
            // btnFinish
            // 
            this.btnFinish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFinish.Location = new System.Drawing.Point(1029, 580);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(75, 23);
            this.btnFinish.TabIndex = 62;
            this.btnFinish.Text = "Finish";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // frmRPDBatchInitialize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 606);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.pnlBatchDetails);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpProduction);
            this.Controls.Add(this.grpInstructions);
            this.Name = "frmRPDBatchInitialize";
            this.Text = "Create Raw Material Preparation Batch";
            this.Load += new System.EventHandler(this.frmRPDBatchInitialize_Load);
            this.grpInstructions.ResumeLayout(false);
            this.grpInstructions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivityInstructions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindInstructions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindMachine)).EndInit();
            this.grpProduction.ResumeLayout(false);
            this.grpProduction.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvProduction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindProduction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindMaterial_Inter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindRPDBatch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvRPDBatch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGRN_LP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindMaterail_LP)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.objSourceLPStock)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.pnlBatchDetails.ResumeLayout(false);
            this.pnlBatchDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblUnitMat;
        private System.Windows.Forms.TextBox txtQtyBasic;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbBatchType;
        private System.Windows.Forms.Button btnClearInstruction;
        private System.Windows.Forms.GroupBox grpInstructions;
        private System.Windows.Forms.DataGridView dgvActivityInstructions;
        private System.Windows.Forms.TextBox txtParticleSize;
        private System.Windows.Forms.Label lblParticleSize;
        private System.Windows.Forms.ComboBox cmbActivityInstructions;
        private System.Windows.Forms.Button btnDeleteInstruction;
        private System.Windows.Forms.Label lblMachine;
        private System.Windows.Forms.Button btnAddInstructions;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.BindingSource bindMachine;
        private System.Windows.Forms.BindingSource bindInstructions;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Instruction;
        private System.Windows.Forms.DataGridViewTextBoxColumn Machine;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParticleSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.GroupBox grpProduction;
        private System.Windows.Forms.DataGridView gvProduction;
        private System.Windows.Forms.Button btnMaterialClear;
        private System.Windows.Forms.Button btnMaterialDelete;
        private System.Windows.Forms.Button btnAddMaterial;
        private System.Windows.Forms.ComboBox cmbMaterialInter;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtMaterialQty;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.BindingSource bindProduction;
        private System.Windows.Forms.BindingSource bindMaterial_Inter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Label lblUnit1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
       // private MRP_GUI.Components.MaterialSelection.MaterialSelect materialSelect1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.BindingSource bindRPDBatch;
        private System.Windows.Forms.DataGridView gvRPDBatch;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRPDBatchID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.ComboBox cmbMaterialList;
        private System.Windows.Forms.DataGridView dgvGRN_LP;
        private System.Windows.Forms.BindingSource bindMaterail_LP;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource objSourceLPStock;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbMachine;
        private System.Windows.Forms.DataGridViewTextBoxColumn RPDBatchID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Material;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn RPDBatchQty;
        private System.Windows.Forms.Panel pnlBatchDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn GRNNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn GrossQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn IssuedQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn RemainingQty;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Activity;
        private System.Windows.Forms.DataGridViewTextBoxColumn InstructionDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Machine_;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParticleSize_;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaterialCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Material_Int;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
    }
}