namespace MRP_GUI
{
    partial class frmActivityManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmActivityManagement));
            this.label1 = new System.Windows.Forms.Label();
            this.gvActivityList = new System.Windows.Forms.DataGridView();
            this.bindActivity = new System.Windows.Forms.BindingSource(this.components);
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtActivity = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.grpMachine = new System.Windows.Forms.GroupBox();
            this.btnClearMachine = new System.Windows.Forms.Button();
            this.btnMachineAdd = new System.Windows.Forms.Button();
            this.cmbMachineList = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gvMachine = new System.Windows.Forms.DataGridView();
            this.bindMachineList = new System.Windows.Forms.BindingSource(this.components);
            this.bindMachine = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.cmbTemplate = new System.Windows.Forms.ComboBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMachineID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ucSectionFilter1 = new MRP_GUI.Components.ucSectionFilter();
            this.colActID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colActivity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDepartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gvActivityList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindActivity)).BeginInit();
            this.grpMachine.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvMachine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindMachineList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindMachine)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Activity List";
            // 
            // gvActivityList
            // 
            this.gvActivityList.AllowUserToAddRows = false;
            this.gvActivityList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gvActivityList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gvActivityList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gvActivityList.AutoGenerateColumns = false;
            this.gvActivityList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvActivityList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colActID,
            this.colActivity,
            this.colDepartment,
            this.Column1,
            this.Column2});
            this.gvActivityList.DataSource = this.bindActivity;
            this.gvActivityList.Location = new System.Drawing.Point(15, 226);
            this.gvActivityList.Name = "gvActivityList";
            this.gvActivityList.ReadOnly = true;
            this.gvActivityList.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvActivityList.RowTemplate.Height = 20;
            this.gvActivityList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvActivityList.Size = new System.Drawing.Size(957, 184);
            this.gvActivityList.TabIndex = 1;
            this.gvActivityList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvActivityList_CellClick);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(307, 197);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Location = new System.Drawing.Point(897, 416);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Activity";
            // 
            // txtActivity
            // 
            this.txtActivity.Location = new System.Drawing.Point(109, 25);
            this.txtActivity.Name = "txtActivity";
            this.txtActivity.Size = new System.Drawing.Size(262, 20);
            this.txtActivity.TabIndex = 7;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(226, 197);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // grpMachine
            // 
            this.grpMachine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpMachine.Controls.Add(this.btnClearMachine);
            this.grpMachine.Controls.Add(this.btnMachineAdd);
            this.grpMachine.Controls.Add(this.cmbMachineList);
            this.grpMachine.Controls.Add(this.label3);
            this.grpMachine.Controls.Add(this.gvMachine);
            this.grpMachine.Enabled = false;
            this.grpMachine.Location = new System.Drawing.Point(388, 13);
            this.grpMachine.Name = "grpMachine";
            this.grpMachine.Size = new System.Drawing.Size(584, 207);
            this.grpMachine.TabIndex = 13;
            this.grpMachine.TabStop = false;
            this.grpMachine.Text = "Machine List";
            // 
            // btnClearMachine
            // 
            this.btnClearMachine.Location = new System.Drawing.Point(428, 15);
            this.btnClearMachine.Name = "btnClearMachine";
            this.btnClearMachine.Size = new System.Drawing.Size(75, 23);
            this.btnClearMachine.TabIndex = 4;
            this.btnClearMachine.Text = "Clear";
            this.btnClearMachine.UseVisualStyleBackColor = true;
            this.btnClearMachine.Click += new System.EventHandler(this.btnClearMachine_Click);
            // 
            // btnMachineAdd
            // 
            this.btnMachineAdd.Location = new System.Drawing.Point(347, 15);
            this.btnMachineAdd.Name = "btnMachineAdd";
            this.btnMachineAdd.Size = new System.Drawing.Size(75, 23);
            this.btnMachineAdd.TabIndex = 3;
            this.btnMachineAdd.Text = "Add";
            this.btnMachineAdd.UseVisualStyleBackColor = true;
            this.btnMachineAdd.Click += new System.EventHandler(this.btnMachineAdd_Click);
            // 
            // cmbMachineList
            // 
            this.cmbMachineList.DisplayMember = "MachineName";
            this.cmbMachineList.FormattingEnabled = true;
            this.cmbMachineList.Location = new System.Drawing.Point(81, 17);
            this.cmbMachineList.Name = "cmbMachineList";
            this.cmbMachineList.Size = new System.Drawing.Size(260, 21);
            this.cmbMachineList.TabIndex = 2;
            this.cmbMachineList.ValueMember = "MachineCode";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Machine";
            // 
            // gvMachine
            // 
            this.gvMachine.AllowUserToAddRows = false;
            this.gvMachine.AllowUserToDeleteRows = false;
            this.gvMachine.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gvMachine.AutoGenerateColumns = false;
            this.gvMachine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvMachine.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColMachineID,
            this.Column3});
            this.gvMachine.DataSource = this.bindMachineList;
            this.gvMachine.Location = new System.Drawing.Point(6, 44);
            this.gvMachine.Name = "gvMachine";
            this.gvMachine.ReadOnly = true;
            this.gvMachine.Size = new System.Drawing.Size(572, 157);
            this.gvMachine.TabIndex = 0;
            this.gvMachine.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvMachine_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Type";
            // 
            // cmbTemplate
            // 
            this.cmbTemplate.DisplayMember = "LayoutType";
            this.cmbTemplate.FormattingEnabled = true;
            this.cmbTemplate.Items.AddRange(new object[] {
            "Template 01",
            "Template 02",
            "Template 03"});
            this.cmbTemplate.Location = new System.Drawing.Point(109, 137);
            this.cmbTemplate.Name = "cmbTemplate";
            this.cmbTemplate.Size = new System.Drawing.Size(121, 21);
            this.cmbTemplate.TabIndex = 15;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MainActID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MainActID";
            this.dataGridViewTextBoxColumn2.HeaderText = "Activity";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DepID";
            this.dataGridViewTextBoxColumn3.HeaderText = "Department";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.Width = 250;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "SectionName";
            this.dataGridViewTextBoxColumn4.HeaderText = "Section";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 250;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "MachineID";
            this.dataGridViewTextBoxColumn5.HeaderText = "Machine Code";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "MachineName";
            this.dataGridViewTextBoxColumn6.HeaderText = "Machine Name";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // ColMachineID
            // 
            this.ColMachineID.DataPropertyName = "MachineID";
            this.ColMachineID.HeaderText = "Machine Code";
            this.ColMachineID.Name = "ColMachineID";
            this.ColMachineID.ReadOnly = true;
            this.ColMachineID.Width = 150;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "MachineName";
            this.Column3.HeaderText = "Machine Name";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // ucSectionFilter1
            // 
            this.ucSectionFilter1.Department = null;
            this.ucSectionFilter1.Division = null;
            this.ucSectionFilter1.Location = new System.Drawing.Point(26, 50);
            this.ucSectionFilter1.Name = "ucSectionFilter1";
            this.ucSectionFilter1.Section = null;
            this.ucSectionFilter1.Size = new System.Drawing.Size(274, 83);
            this.ucSectionFilter1.TabIndex = 12;
            // 
            // colActID
            // 
            this.colActID.DataPropertyName = "MainActID";
            this.colActID.HeaderText = "ID";
            this.colActID.Name = "colActID";
            this.colActID.ReadOnly = true;
            this.colActID.Width = 50;
            // 
            // colActivity
            // 
            this.colActivity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colActivity.DataPropertyName = "MainActivity";
            this.colActivity.HeaderText = "Activity";
            this.colActivity.Name = "colActivity";
            this.colActivity.ReadOnly = true;
            // 
            // colDepartment
            // 
            this.colDepartment.DataPropertyName = "DepName";
            this.colDepartment.HeaderText = "Department";
            this.colDepartment.Name = "colDepartment";
            this.colDepartment.ReadOnly = true;
            this.colDepartment.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colDepartment.Width = 250;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "SectionName";
            this.Column1.HeaderText = "Section";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 250;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Type";
            this.Column2.HeaderText = "Type";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // frmActivityManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 453);
            this.Controls.Add(this.cmbTemplate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.grpMachine);
            this.Controls.Add(this.ucSectionFilter1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtActivity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gvActivityList);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmActivityManagement";
            this.Text = "Activity Management";
            this.Load += new System.EventHandler(this.frmActivityManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvActivityList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindActivity)).EndInit();
            this.grpMachine.ResumeLayout(false);
            this.grpMachine.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvMachine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindMachineList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindMachine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gvActivityList;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtActivity;
        private System.Windows.Forms.Button btnClear;
        private MRP_GUI.Components.ucSectionFilter ucSectionFilter1;
        private System.Windows.Forms.BindingSource bindActivity;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.GroupBox grpMachine;
        private System.Windows.Forms.ComboBox cmbMachineList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView gvMachine;
        private System.Windows.Forms.Button btnClearMachine;
        private System.Windows.Forms.Button btnMachineAdd;
        private System.Windows.Forms.BindingSource bindMachine;
        private System.Windows.Forms.BindingSource bindMachineList;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMachineID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbTemplate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colActID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colActivity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDepartment;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}