namespace MRP_GUI
{
    partial class frmPRPDPreperationBatchManagement
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbRework = new System.Windows.Forms.RadioButton();
            this.rdbPPRe = new System.Windows.Forms.RadioButton();
            this.rdbPP = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSendMR = new System.Windows.Forms.Button();
            this.txtStore = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBatchDelete = new System.Windows.Forms.Button();
            this.btnApprove = new System.Windows.Forms.Button();
            this.pnlStore = new System.Windows.Forms.Panel();
            this.cmbStores = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvPRPDbatchByState = new System.Windows.Forms.DataGridView();
            this.PRPDBatchID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaterialName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BatchQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MRNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRPDBatchInstructedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRPDBatchMaterialCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbPRPDBatchStatus = new System.Windows.Forms.ComboBox();
            this.btnEditMode = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grpBatchInstructions = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtPRPDBatch = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbMachine = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbActivity = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtInstruction = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvActivityInstructions = new System.Windows.Forms.DataGridView();
            this.colPRPDBatchActivityInstructionsID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MachineID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MachineName_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MainActivity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InstructionDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExit = new System.Windows.Forms.Button();
            this.objSourceInstructions = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.pnlStore.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPRPDbatchByState)).BeginInit();
            this.grpBatchInstructions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivityInstructions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceInstructions)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbRework);
            this.groupBox1.Controls.Add(this.rdbPPRe);
            this.groupBox1.Controls.Add(this.rdbPP);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnBatchDelete);
            this.groupBox1.Controls.Add(this.btnApprove);
            this.groupBox1.Controls.Add(this.pnlStore);
            this.groupBox1.Controls.Add(this.dgvPRPDbatchByState);
            this.groupBox1.Controls.Add(this.cmbPRPDBatchStatus);
            this.groupBox1.Controls.Add(this.btnEditMode);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.grpBatchInstructions);
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1012, 616);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // rdbRework
            // 
            this.rdbRework.AutoSize = true;
            this.rdbRework.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbRework.Location = new System.Drawing.Point(609, 23);
            this.rdbRework.Name = "rdbRework";
            this.rdbRework.Size = new System.Drawing.Size(68, 17);
            this.rdbRework.TabIndex = 49;
            this.rdbRework.Text = "Rework";
            this.rdbRework.UseVisualStyleBackColor = true;
            this.rdbRework.CheckedChanged += new System.EventHandler(this.rdbRework_CheckedChanged);
            // 
            // rdbPPRe
            // 
            this.rdbPPRe.AutoSize = true;
            this.rdbPPRe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbPPRe.Location = new System.Drawing.Point(413, 22);
            this.rdbPPRe.Name = "rdbPPRe";
            this.rdbPPRe.Size = new System.Drawing.Size(205, 17);
            this.rdbPPRe.TabIndex = 50;
            this.rdbPPRe.Text = "Primary Preparation (Outsource)";
            this.rdbPPRe.UseVisualStyleBackColor = true;
            this.rdbPPRe.CheckedChanged += new System.EventHandler(this.rdbPPRe_CheckedChanged);
            // 
            // rdbPP
            // 
            this.rdbPP.AutoSize = true;
            this.rdbPP.Checked = true;
            this.rdbPP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbPP.Location = new System.Drawing.Point(272, 23);
            this.rdbPP.Name = "rdbPP";
            this.rdbPP.Size = new System.Drawing.Size(135, 17);
            this.rdbPP.TabIndex = 51;
            this.rdbPP.TabStop = true;
            this.rdbPP.Text = "Primary Preparation";
            this.rdbPP.UseVisualStyleBackColor = true;
            this.rdbPP.CheckedChanged += new System.EventHandler(this.rdbPP_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSendMR);
            this.groupBox2.Controls.Add(this.txtStore);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 208);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(623, 52);
            this.groupBox2.TabIndex = 48;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Store";
            // 
            // btnSendMR
            // 
            this.btnSendMR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSendMR.Location = new System.Drawing.Point(448, 17);
            this.btnSendMR.Name = "btnSendMR";
            this.btnSendMR.Size = new System.Drawing.Size(115, 23);
            this.btnSendMR.TabIndex = 32;
            this.btnSendMR.Text = "Send New MR";
            this.btnSendMR.UseVisualStyleBackColor = true;
            this.btnSendMR.Visible = false;
            this.btnSendMR.Click += new System.EventHandler(this.btnSendMR_Click);
            // 
            // txtStore
            // 
            this.txtStore.Location = new System.Drawing.Point(72, 19);
            this.txtStore.Name = "txtStore";
            this.txtStore.ReadOnly = true;
            this.txtStore.Size = new System.Drawing.Size(349, 20);
            this.txtStore.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Store";
            // 
            // btnBatchDelete
            // 
            this.btnBatchDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBatchDelete.BackColor = System.Drawing.Color.Gray;
            this.btnBatchDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBatchDelete.ForeColor = System.Drawing.Color.Maroon;
            this.btnBatchDelete.Location = new System.Drawing.Point(12, 583);
            this.btnBatchDelete.Name = "btnBatchDelete";
            this.btnBatchDelete.Size = new System.Drawing.Size(160, 29);
            this.btnBatchDelete.TabIndex = 46;
            this.btnBatchDelete.Text = "Delete Batch";
            this.btnBatchDelete.UseVisualStyleBackColor = false;
            this.btnBatchDelete.Click += new System.EventHandler(this.btnBatchDelete_Click);
            // 
            // btnApprove
            // 
            this.btnApprove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApprove.Enabled = false;
            this.btnApprove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApprove.ForeColor = System.Drawing.Color.Maroon;
            this.btnApprove.Location = new System.Drawing.Point(820, 583);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(100, 29);
            this.btnApprove.TabIndex = 45;
            this.btnApprove.Text = "Approve";
            this.btnApprove.UseVisualStyleBackColor = true;
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click_1);
            // 
            // pnlStore
            // 
            this.pnlStore.Controls.Add(this.cmbStores);
            this.pnlStore.Controls.Add(this.label2);
            this.pnlStore.Location = new System.Drawing.Point(706, 12);
            this.pnlStore.Name = "pnlStore";
            this.pnlStore.Size = new System.Drawing.Size(294, 34);
            this.pnlStore.TabIndex = 41;
            this.pnlStore.Visible = false;
            // 
            // cmbStores
            // 
            this.cmbStores.DisplayMember = "StoreName";
            this.cmbStores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStores.FormattingEnabled = true;
            this.cmbStores.Location = new System.Drawing.Point(51, 7);
            this.cmbStores.Name = "cmbStores";
            this.cmbStores.Size = new System.Drawing.Size(240, 21);
            this.cmbStores.TabIndex = 39;
            this.cmbStores.ValueMember = "StoreID";
            this.cmbStores.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Store";
            this.label2.Visible = false;
            // 
            // dgvPRPDbatchByState
            // 
            this.dgvPRPDbatchByState.AllowUserToAddRows = false;
            this.dgvPRPDbatchByState.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvPRPDbatchByState.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPRPDbatchByState.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPRPDbatchByState.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPRPDbatchByState.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PRPDBatchID,
            this.MaterialName,
            this.Column1,
            this.BatchQty,
            this.MRNO,
            this.PRPDBatchInstructedBy,
            this.PRPDBatchMaterialCode});
            this.dgvPRPDbatchByState.Location = new System.Drawing.Point(12, 52);
            this.dgvPRPDbatchByState.Name = "dgvPRPDbatchByState";
            this.dgvPRPDbatchByState.ReadOnly = true;
            this.dgvPRPDbatchByState.RowTemplate.Height = 20;
            this.dgvPRPDbatchByState.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPRPDbatchByState.Size = new System.Drawing.Size(988, 150);
            this.dgvPRPDbatchByState.TabIndex = 30;
            this.dgvPRPDbatchByState.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPRPDbatchByState_CellClick);
            // 
            // PRPDBatchID
            // 
            this.PRPDBatchID.DataPropertyName = "PRPDBatchID";
            this.PRPDBatchID.FillWeight = 25.77319F;
            this.PRPDBatchID.HeaderText = "PRPDBatchID";
            this.PRPDBatchID.MinimumWidth = 150;
            this.PRPDBatchID.Name = "PRPDBatchID";
            this.PRPDBatchID.ReadOnly = true;
            this.PRPDBatchID.Width = 150;
            // 
            // MaterialName
            // 
            this.MaterialName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaterialName.DataPropertyName = "Material";
            this.MaterialName.HeaderText = "Material Name";
            this.MaterialName.MinimumWidth = 200;
            this.MaterialName.Name = "MaterialName";
            this.MaterialName.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "UnitCode";
            this.Column1.HeaderText = "Unit";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // BatchQty
            // 
            this.BatchQty.DataPropertyName = "PRPDBatchQty";
            this.BatchQty.FillWeight = 25.77319F;
            this.BatchQty.HeaderText = "Quantity";
            this.BatchQty.Name = "BatchQty";
            this.BatchQty.ReadOnly = true;
            // 
            // MRNO
            // 
            this.MRNO.DataPropertyName = "MRIN";
            this.MRNO.FillWeight = 25.77319F;
            this.MRNO.HeaderText = "MRNO";
            this.MRNO.Name = "MRNO";
            this.MRNO.ReadOnly = true;
            this.MRNO.Width = 75;
            // 
            // PRPDBatchInstructedBy
            // 
            this.PRPDBatchInstructedBy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PRPDBatchInstructedBy.DataPropertyName = "InspetedByName";
            this.PRPDBatchInstructedBy.HeaderText = "Instructed By";
            this.PRPDBatchInstructedBy.MinimumWidth = 200;
            this.PRPDBatchInstructedBy.Name = "PRPDBatchInstructedBy";
            this.PRPDBatchInstructedBy.ReadOnly = true;
            // 
            // PRPDBatchMaterialCode
            // 
            this.PRPDBatchMaterialCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PRPDBatchMaterialCode.DataPropertyName = "PRPDBatchMaterialCode";
            this.PRPDBatchMaterialCode.HeaderText = "PRPDBatchMaterialCode";
            this.PRPDBatchMaterialCode.Name = "PRPDBatchMaterialCode";
            this.PRPDBatchMaterialCode.ReadOnly = true;
            this.PRPDBatchMaterialCode.Visible = false;
            // 
            // cmbPRPDBatchStatus
            // 
            this.cmbPRPDBatchStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPRPDBatchStatus.FormattingEnabled = true;
            this.cmbPRPDBatchStatus.Items.AddRange(new object[] {
            "Created",
            "Approve",
            "Finish",
            "Transfered"});
            this.cmbPRPDBatchStatus.Location = new System.Drawing.Point(116, 19);
            this.cmbPRPDBatchStatus.Name = "cmbPRPDBatchStatus";
            this.cmbPRPDBatchStatus.Size = new System.Drawing.Size(150, 21);
            this.cmbPRPDBatchStatus.TabIndex = 28;
            this.cmbPRPDBatchStatus.SelectedIndexChanged += new System.EventHandler(this.cmbPRPDBatchStatus_SelectedIndexChanged);
            // 
            // btnEditMode
            // 
            this.btnEditMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditMode.Location = new System.Drawing.Point(920, 220);
            this.btnEditMode.Name = "btnEditMode";
            this.btnEditMode.Size = new System.Drawing.Size(80, 23);
            this.btnEditMode.TabIndex = 29;
            this.btnEditMode.Text = "Edit Mode";
            this.btnEditMode.UseVisualStyleBackColor = true;
            this.btnEditMode.Click += new System.EventHandler(this.btnEditMode_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "PRPDBatch Status";
            // 
            // grpBatchInstructions
            // 
            this.grpBatchInstructions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBatchInstructions.Controls.Add(this.btnUpdate);
            this.grpBatchInstructions.Controls.Add(this.txtPRPDBatch);
            this.grpBatchInstructions.Controls.Add(this.label12);
            this.grpBatchInstructions.Controls.Add(this.cmbMachine);
            this.grpBatchInstructions.Controls.Add(this.label11);
            this.grpBatchInstructions.Controls.Add(this.cmbActivity);
            this.grpBatchInstructions.Controls.Add(this.label7);
            this.grpBatchInstructions.Controls.Add(this.btnDelete);
            this.grpBatchInstructions.Controls.Add(this.btnAdd);
            this.grpBatchInstructions.Controls.Add(this.txtInstruction);
            this.grpBatchInstructions.Controls.Add(this.label9);
            this.grpBatchInstructions.Controls.Add(this.dgvActivityInstructions);
            this.grpBatchInstructions.Enabled = false;
            this.grpBatchInstructions.Location = new System.Drawing.Point(12, 266);
            this.grpBatchInstructions.Name = "grpBatchInstructions";
            this.grpBatchInstructions.Size = new System.Drawing.Size(994, 315);
            this.grpBatchInstructions.TabIndex = 23;
            this.grpBatchInstructions.TabStop = false;
            this.grpBatchInstructions.Text = "Batch Instructions";
            this.grpBatchInstructions.EnabledChanged += new System.EventHandler(this.grpBatchInstructions_EnabledChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(781, 40);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 37;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtPRPDBatch
            // 
            this.txtPRPDBatch.Location = new System.Drawing.Point(97, 23);
            this.txtPRPDBatch.Name = "txtPRPDBatch";
            this.txtPRPDBatch.ReadOnly = true;
            this.txtPRPDBatch.Size = new System.Drawing.Size(121, 20);
            this.txtPRPDBatch.TabIndex = 36;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 30);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 13);
            this.label12.TabIndex = 35;
            this.label12.Text = "PRPDBatch ID";
            // 
            // cmbMachine
            // 
            this.cmbMachine.DisplayMember = "MachineName";
            this.cmbMachine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMachine.FormattingEnabled = true;
            this.cmbMachine.Location = new System.Drawing.Point(97, 70);
            this.cmbMachine.Name = "cmbMachine";
            this.cmbMachine.Size = new System.Drawing.Size(253, 21);
            this.cmbMachine.TabIndex = 34;
            this.cmbMachine.ValueMember = "MachinceCode";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(38, 74);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 13);
            this.label11.TabIndex = 33;
            this.label11.Text = "Machine";
            // 
            // cmbActivity
            // 
            this.cmbActivity.DisplayMember = "MainActivity";
            this.cmbActivity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbActivity.FormattingEnabled = true;
            this.cmbActivity.Location = new System.Drawing.Point(97, 47);
            this.cmbActivity.Name = "cmbActivity";
            this.cmbActivity.Size = new System.Drawing.Size(253, 21);
            this.cmbActivity.TabIndex = 32;
            this.cmbActivity.ValueMember = "MainActID";
            this.cmbActivity.SelectedIndexChanged += new System.EventHandler(this.cmbActivity_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Activity";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(781, 65);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 30;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(781, 16);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 29;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtInstruction
            // 
            this.txtInstruction.Location = new System.Drawing.Point(427, 20);
            this.txtInstruction.Multiline = true;
            this.txtInstruction.Name = "txtInstruction";
            this.txtInstruction.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInstruction.Size = new System.Drawing.Size(348, 68);
            this.txtInstruction.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(365, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Instruction";
            // 
            // dgvActivityInstructions
            // 
            this.dgvActivityInstructions.AllowUserToAddRows = false;
            this.dgvActivityInstructions.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvActivityInstructions.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvActivityInstructions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvActivityInstructions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActivityInstructions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPRPDBatchActivityInstructionsID,
            this.MachineID,
            this.MachineName_,
            this.MainActivity,
            this.InstructionDesc});
            this.dgvActivityInstructions.Location = new System.Drawing.Point(6, 97);
            this.dgvActivityInstructions.Name = "dgvActivityInstructions";
            this.dgvActivityInstructions.ReadOnly = true;
            this.dgvActivityInstructions.RowTemplate.Height = 20;
            this.dgvActivityInstructions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvActivityInstructions.Size = new System.Drawing.Size(982, 212);
            this.dgvActivityInstructions.TabIndex = 7;
            this.dgvActivityInstructions.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvActivityInstructions_CellClick);
            // 
            // colPRPDBatchActivityInstructionsID
            // 
            this.colPRPDBatchActivityInstructionsID.DataPropertyName = "PRPDBatchActivityInstructionsID";
            this.colPRPDBatchActivityInstructionsID.HeaderText = "PRPDBatchActivityInstructionsID";
            this.colPRPDBatchActivityInstructionsID.Name = "colPRPDBatchActivityInstructionsID";
            this.colPRPDBatchActivityInstructionsID.ReadOnly = true;
            this.colPRPDBatchActivityInstructionsID.Visible = false;
            // 
            // MachineID
            // 
            this.MachineID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MachineID.DataPropertyName = "MachineID";
            this.MachineID.FillWeight = 50F;
            this.MachineID.HeaderText = "MachineID";
            this.MachineID.Name = "MachineID";
            this.MachineID.ReadOnly = true;
            // 
            // MachineName_
            // 
            this.MachineName_.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MachineName_.DataPropertyName = "MachineName";
            this.MachineName_.HeaderText = "MachineName";
            this.MachineName_.Name = "MachineName_";
            this.MachineName_.ReadOnly = true;
            // 
            // MainActivity
            // 
            this.MainActivity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MainActivity.DataPropertyName = "MainActivity";
            this.MainActivity.HeaderText = "MainActivity";
            this.MainActivity.Name = "MainActivity";
            this.MainActivity.ReadOnly = true;
            // 
            // InstructionDesc
            // 
            this.InstructionDesc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.InstructionDesc.DataPropertyName = "InstructionDesc";
            this.InstructionDesc.HeaderText = "InstructionDesc";
            this.InstructionDesc.Name = "InstructionDesc";
            this.InstructionDesc.ReadOnly = true;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Location = new System.Drawing.Point(926, 583);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(80, 29);
            this.btnExit.TabIndex = 24;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PRPDBatchID";
            this.dataGridViewTextBoxColumn1.FillWeight = 25.77319F;
            this.dataGridViewTextBoxColumn1.HeaderText = "PRPDBatchID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 150;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Material";
            this.dataGridViewTextBoxColumn2.HeaderText = "Material Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 200;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "UnitCode";
            this.dataGridViewTextBoxColumn3.HeaderText = "Unit";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "PRPDBatchQty";
            this.dataGridViewTextBoxColumn4.FillWeight = 25.77319F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "MRIN";
            this.dataGridViewTextBoxColumn5.FillWeight = 25.77319F;
            this.dataGridViewTextBoxColumn5.HeaderText = "MRNO";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 75;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "InspetedByName";
            this.dataGridViewTextBoxColumn6.HeaderText = "Instructed By";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 200;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "PRPDBatchMaterialCode";
            this.dataGridViewTextBoxColumn7.HeaderText = "PRPDBatchMaterialCode";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "PRPDBatchActivityInstructionsID";
            this.dataGridViewTextBoxColumn8.HeaderText = "PRPDBatchActivityInstructionsID";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Visible = false;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "MainActivity";
            this.dataGridViewTextBoxColumn9.HeaderText = "Activity";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 250;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "MachineName";
            this.dataGridViewTextBoxColumn10.HeaderText = "Machine";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 200;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn11.DataPropertyName = "InstructionDesc";
            this.dataGridViewTextBoxColumn11.FillWeight = 600F;
            this.dataGridViewTextBoxColumn11.HeaderText = "Instructions";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 600;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // frmPRPDPreperationBatchManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 616);
            this.Controls.Add(this.groupBox1);
            this.Location = new System.Drawing.Point(5, 60);
            this.Name = "frmPRPDPreperationBatchManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Primary Preparation Batch Management";
            this.Load += new System.EventHandler(this.frmPRPDCAP_ReworkBatchManagement_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.pnlStore.ResumeLayout(false);
            this.pnlStore.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPRPDbatchByState)).EndInit();
            this.grpBatchInstructions.ResumeLayout(false);
            this.grpBatchInstructions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivityInstructions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceInstructions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvPRPDbatchByState;
        private System.Windows.Forms.ComboBox cmbPRPDBatchStatus;
        private System.Windows.Forms.Button btnEditMode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpBatchInstructions;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtPRPDBatch;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbMachine;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbActivity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtInstruction;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvActivityInstructions;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel pnlStore;
        private System.Windows.Forms.Button btnSendMR;
        private System.Windows.Forms.ComboBox cmbStores;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRPDBatchActivityInstructionsID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActivityName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MachineName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Instructions;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRPDBatchID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaterialName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn BatchQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn MRNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRPDBatchInstructedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRPDBatchMaterialCode;
        private System.Windows.Forms.Button btnBatchDelete;
        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.BindingSource objSourceInstructions;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtStore;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rdbRework;
        private System.Windows.Forms.RadioButton rdbPPRe;
        private System.Windows.Forms.RadioButton rdbPP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPRPDBatchActivityInstructionsID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MachineID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MachineName_;
        private System.Windows.Forms.DataGridViewTextBoxColumn MainActivity;
        private System.Windows.Forms.DataGridViewTextBoxColumn InstructionDesc;
    }
}