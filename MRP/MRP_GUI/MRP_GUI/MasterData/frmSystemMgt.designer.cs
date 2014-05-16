namespace MRP_GUI
{
    partial class frmSystemMgt
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSystemMgt));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbDepartment = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbDivision = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rbSupply = new System.Windows.Forms.RadioButton();
            this.rbAgri = new System.Windows.Forms.RadioButton();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnSaveDefault = new System.Windows.Forms.Button();
            this.cmbDepartmenttores = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cmbDepartmentList = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.rbPRPD = new System.Windows.Forms.RadioButton();
            this.rbRPD = new System.Windows.Forms.RadioButton();
            this.rbOther = new System.Windows.Forms.RadioButton();
            this.rbSales = new System.Windows.Forms.RadioButton();
            this.rbStores = new System.Windows.Forms.RadioButton();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.gvDepartment = new System.Windows.Forms.DataGridView();
            this.ColDepID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDepName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDepDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEmpName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDepManager = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindDep = new System.Windows.Forms.BindingSource(this.components);
            this.cmbDepHead = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDepartmentDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDepartmentName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbUser = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnClearPassword = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbUserRole = new System.Windows.Forms.ComboBox();
            this.cbUser = new System.Windows.Forms.CheckBox();
            this.cmbEmp = new System.Windows.Forms.ComboBox();
            this.btnUserClear = new System.Windows.Forms.Button();
            this.btnUserDelete = new System.Windows.Forms.Button();
            this.btnUserSave = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.gvUserList = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindUserList = new System.Windows.Forms.BindingSource(this.components);
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbStores = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbStoreKeeper = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnStoreClear = new System.Windows.Forms.Button();
            this.btnStoreDelete = new System.Windows.Forms.Button();
            this.btnStoreSave = new System.Windows.Forms.Button();
            this.txtStoreDesc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindStoreList = new System.Windows.Forms.BindingSource(this.components);
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtStoreName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtStoreID = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tbDivision = new System.Windows.Forms.TabPage();
            this.ucDivision1 = new MRP_GUI.Components.ucDivision();
            this.tbSection = new System.Windows.Forms.TabPage();
            this.ucSection1 = new MRP_GUI.Components.ucSection();
            this.bindDepStores = new System.Windows.Forms.BindingSource(this.components);
            this.bindDivisions = new System.Windows.Forms.BindingSource(this.components);
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
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rbProduction = new System.Windows.Forms.RadioButton();
            this.tabControl1.SuspendLayout();
            this.tbDepartment.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvDepartment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindDep)).BeginInit();
            this.tbUser.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvUserList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindUserList)).BeginInit();
            this.tbStores.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindStoreList)).BeginInit();
            this.tbDivision.SuspendLayout();
            this.tbSection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindDepStores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindDivisions)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbDepartment);
            this.tabControl1.Controls.Add(this.tbUser);
            this.tabControl1.Controls.Add(this.tbStores);
            this.tabControl1.Controls.Add(this.tbDivision);
            this.tabControl1.Controls.Add(this.tbSection);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1020, 503);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tbDepartment
            // 
            this.tbDepartment.Controls.Add(this.groupBox1);
            this.tbDepartment.Location = new System.Drawing.Point(4, 22);
            this.tbDepartment.Name = "tbDepartment";
            this.tbDepartment.Padding = new System.Windows.Forms.Padding(3);
            this.tbDepartment.Size = new System.Drawing.Size(1012, 477);
            this.tbDepartment.TabIndex = 0;
            this.tbDepartment.Text = "Department";
            this.tbDepartment.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbDivision);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1006, 471);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Department Management";
            // 
            // cmbDivision
            // 
            this.cmbDivision.DisplayMember = "DivisionName";
            this.cmbDivision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDivision.FormattingEnabled = true;
            this.cmbDivision.Location = new System.Drawing.Point(118, 24);
            this.cmbDivision.Name = "cmbDivision";
            this.cmbDivision.Size = new System.Drawing.Size(223, 21);
            this.cmbDivision.TabIndex = 33;
            this.cmbDivision.ValueMember = "DivisionID";
            this.cmbDivision.SelectedIndexChanged += new System.EventHandler(this.cmbDivision_SelectedIndexChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(68, 27);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(44, 13);
            this.label17.TabIndex = 32;
            this.label17.Text = "Division";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.rbProduction);
            this.groupBox4.Controls.Add(this.rbSupply);
            this.groupBox4.Controls.Add(this.rbAgri);
            this.groupBox4.Controls.Add(this.txtID);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.rbPRPD);
            this.groupBox4.Controls.Add(this.rbRPD);
            this.groupBox4.Controls.Add(this.rbOther);
            this.groupBox4.Controls.Add(this.rbSales);
            this.groupBox4.Controls.Add(this.rbStores);
            this.groupBox4.Controls.Add(this.btnClear);
            this.groupBox4.Controls.Add(this.btnDelete);
            this.groupBox4.Controls.Add(this.btnSave);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.gvDepartment);
            this.groupBox4.Controls.Add(this.cmbDepHead);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.txtDepartmentDescription);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.txtDepartmentName);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Location = new System.Drawing.Point(2, 57);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1001, 404);
            this.groupBox4.TabIndex = 31;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Department";
            // 
            // rbSupply
            // 
            this.rbSupply.AutoSize = true;
            this.rbSupply.Location = new System.Drawing.Point(530, 23);
            this.rbSupply.Name = "rbSupply";
            this.rbSupply.Size = new System.Drawing.Size(57, 17);
            this.rbSupply.TabIndex = 31;
            this.rbSupply.TabStop = true;
            this.rbSupply.Text = "Supply";
            this.rbSupply.UseVisualStyleBackColor = true;
            this.rbSupply.CheckedChanged += new System.EventHandler(this.rbSupply_CheckedChanged);
            // 
            // rbAgri
            // 
            this.rbAgri.AutoSize = true;
            this.rbAgri.Location = new System.Drawing.Point(427, 115);
            this.rbAgri.Name = "rbAgri";
            this.rbAgri.Size = new System.Drawing.Size(75, 17);
            this.rbAgri.TabIndex = 30;
            this.rbAgri.TabStop = true;
            this.rbAgri.Text = "Agriculture";
            this.rbAgri.UseVisualStyleBackColor = true;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(116, 19);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(125, 20);
            this.txtID.TabIndex = 29;
            this.txtID.Text = "[Auto]";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(34, 23);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(76, 13);
            this.label18.TabIndex = 28;
            this.label18.Text = "Department ID";
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.btnSaveDefault);
            this.groupBox5.Controls.Add(this.cmbDepartmenttores);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.cmbDepartmentList);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Location = new System.Drawing.Point(659, 13);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(336, 109);
            this.groupBox5.TabIndex = 27;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Manage default stores";
            // 
            // btnSaveDefault
            // 
            this.btnSaveDefault.Location = new System.Drawing.Point(220, 76);
            this.btnSaveDefault.Name = "btnSaveDefault";
            this.btnSaveDefault.Size = new System.Drawing.Size(102, 23);
            this.btnSaveDefault.TabIndex = 11;
            this.btnSaveDefault.Text = "Save Store";
            this.btnSaveDefault.UseVisualStyleBackColor = true;
            this.btnSaveDefault.Click += new System.EventHandler(this.btnSaveDefault_Click);
            // 
            // cmbDepartmenttores
            // 
            this.cmbDepartmenttores.DisplayMember = "StoreName";
            this.cmbDepartmenttores.FormattingEnabled = true;
            this.cmbDepartmenttores.Location = new System.Drawing.Point(94, 47);
            this.cmbDepartmenttores.Name = "cmbDepartmenttores";
            this.cmbDepartmenttores.Size = new System.Drawing.Size(225, 21);
            this.cmbDepartmenttores.TabIndex = 9;
            this.cmbDepartmenttores.ValueMember = "StoreID";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(26, 50);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(32, 13);
            this.label16.TabIndex = 10;
            this.label16.Text = "Store";
            // 
            // cmbDepartmentList
            // 
            this.cmbDepartmentList.DisplayMember = "DepName";
            this.cmbDepartmentList.FormattingEnabled = true;
            this.cmbDepartmentList.Location = new System.Drawing.Point(94, 20);
            this.cmbDepartmentList.Name = "cmbDepartmentList";
            this.cmbDepartmentList.Size = new System.Drawing.Size(225, 21);
            this.cmbDepartmentList.TabIndex = 7;
            this.cmbDepartmentList.ValueMember = "DepID";
            this.cmbDepartmentList.SelectedIndexChanged += new System.EventHandler(this.cmbDepartmentList_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Department";
            // 
            // rbPRPD
            // 
            this.rbPRPD.AutoSize = true;
            this.rbPRPD.Location = new System.Drawing.Point(427, 92);
            this.rbPRPD.Name = "rbPRPD";
            this.rbPRPD.Size = new System.Drawing.Size(55, 17);
            this.rbPRPD.TabIndex = 14;
            this.rbPRPD.TabStop = true;
            this.rbPRPD.Text = "PRPD";
            this.rbPRPD.UseVisualStyleBackColor = true;
            // 
            // rbRPD
            // 
            this.rbRPD.AutoSize = true;
            this.rbRPD.Location = new System.Drawing.Point(427, 70);
            this.rbRPD.Name = "rbRPD";
            this.rbRPD.Size = new System.Drawing.Size(48, 17);
            this.rbRPD.TabIndex = 13;
            this.rbRPD.TabStop = true;
            this.rbRPD.Text = "RPD";
            this.rbRPD.UseVisualStyleBackColor = true;
            // 
            // rbOther
            // 
            this.rbOther.AutoSize = true;
            this.rbOther.Checked = true;
            this.rbOther.Location = new System.Drawing.Point(427, 138);
            this.rbOther.Name = "rbOther";
            this.rbOther.Size = new System.Drawing.Size(51, 17);
            this.rbOther.TabIndex = 12;
            this.rbOther.TabStop = true;
            this.rbOther.Text = "Other";
            this.rbOther.UseVisualStyleBackColor = true;
            this.rbOther.CheckedChanged += new System.EventHandler(this.rbOther_CheckedChanged);
            // 
            // rbSales
            // 
            this.rbSales.AutoSize = true;
            this.rbSales.Location = new System.Drawing.Point(427, 46);
            this.rbSales.Name = "rbSales";
            this.rbSales.Size = new System.Drawing.Size(43, 17);
            this.rbSales.TabIndex = 11;
            this.rbSales.Text = "Lab";
            this.rbSales.UseVisualStyleBackColor = true;
            // 
            // rbStores
            // 
            this.rbStores.AutoSize = true;
            this.rbStores.Location = new System.Drawing.Point(530, 48);
            this.rbStores.Name = "rbStores";
            this.rbStores.Size = new System.Drawing.Size(55, 17);
            this.rbStores.TabIndex = 10;
            this.rbStores.Text = "Stores";
            this.rbStores.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Location = new System.Drawing.Point(761, 128);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(842, 128);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(923, 128);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Department List";
            // 
            // gvDepartment
            // 
            this.gvDepartment.AllowUserToAddRows = false;
            this.gvDepartment.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gvDepartment.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gvDepartment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gvDepartment.AutoGenerateColumns = false;
            this.gvDepartment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDepartment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColDepID,
            this.ColDepName,
            this.ColDepDescription,
            this.ColEmpName,
            this.Column10,
            this.ColDepManager});
            this.gvDepartment.DataSource = this.bindDep;
            this.gvDepartment.Location = new System.Drawing.Point(6, 176);
            this.gvDepartment.Name = "gvDepartment";
            this.gvDepartment.ReadOnly = true;
            this.gvDepartment.RowHeadersVisible = false;
            this.gvDepartment.RowTemplate.Height = 20;
            this.gvDepartment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvDepartment.Size = new System.Drawing.Size(989, 222);
            this.gvDepartment.TabIndex = 8;
            this.gvDepartment.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvDepartment_CellClick);
            // 
            // ColDepID
            // 
            this.ColDepID.DataPropertyName = "DepID";
            this.ColDepID.HeaderText = "ID";
            this.ColDepID.Name = "ColDepID";
            this.ColDepID.ReadOnly = true;
            // 
            // ColDepName
            // 
            this.ColDepName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColDepName.DataPropertyName = "DepName";
            this.ColDepName.HeaderText = "Name";
            this.ColDepName.Name = "ColDepName";
            this.ColDepName.ReadOnly = true;
            // 
            // ColDepDescription
            // 
            this.ColDepDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColDepDescription.DataPropertyName = "DepDescription";
            this.ColDepDescription.HeaderText = "Description";
            this.ColDepDescription.Name = "ColDepDescription";
            this.ColDepDescription.ReadOnly = true;
            // 
            // ColEmpName
            // 
            this.ColEmpName.DataPropertyName = "Employee";
            this.ColEmpName.HeaderText = "Department Head";
            this.ColEmpName.Name = "ColEmpName";
            this.ColEmpName.ReadOnly = true;
            this.ColEmpName.Width = 250;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "Type";
            this.Column10.HeaderText = "Type";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 75;
            // 
            // ColDepManager
            // 
            this.ColDepManager.DataPropertyName = "DepManager";
            this.ColDepManager.HeaderText = "DepHeadID";
            this.ColDepManager.Name = "ColDepManager";
            this.ColDepManager.ReadOnly = true;
            this.ColDepManager.Visible = false;
            // 
            // cmbDepHead
            // 
            this.cmbDepHead.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbDepHead.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbDepHead.DisplayMember = "Employee";
            this.cmbDepHead.FormattingEnabled = true;
            this.cmbDepHead.Location = new System.Drawing.Point(116, 89);
            this.cmbDepHead.Name = "cmbDepHead";
            this.cmbDepHead.Size = new System.Drawing.Size(293, 21);
            this.cmbDepHead.TabIndex = 2;
            this.cmbDepHead.ValueMember = "EmpID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Department Head";
            // 
            // txtDepartmentDescription
            // 
            this.txtDepartmentDescription.Location = new System.Drawing.Point(116, 67);
            this.txtDepartmentDescription.MaxLength = 2000;
            this.txtDepartmentDescription.Name = "txtDepartmentDescription";
            this.txtDepartmentDescription.Size = new System.Drawing.Size(225, 20);
            this.txtDepartmentDescription.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Description";
            // 
            // txtDepartmentName
            // 
            this.txtDepartmentName.Location = new System.Drawing.Point(116, 45);
            this.txtDepartmentName.MaxLength = 500;
            this.txtDepartmentName.Name = "txtDepartmentName";
            this.txtDepartmentName.Size = new System.Drawing.Size(225, 20);
            this.txtDepartmentName.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // tbUser
            // 
            this.tbUser.Controls.Add(this.groupBox2);
            this.tbUser.Location = new System.Drawing.Point(4, 22);
            this.tbUser.Name = "tbUser";
            this.tbUser.Padding = new System.Windows.Forms.Padding(3);
            this.tbUser.Size = new System.Drawing.Size(1012, 477);
            this.tbUser.TabIndex = 1;
            this.tbUser.Text = "User";
            this.tbUser.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnClearPassword);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cmbUserRole);
            this.groupBox2.Controls.Add(this.cbUser);
            this.groupBox2.Controls.Add(this.cmbEmp);
            this.groupBox2.Controls.Add(this.btnUserClear);
            this.groupBox2.Controls.Add(this.btnUserDelete);
            this.groupBox2.Controls.Add(this.btnUserSave);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.gvUserList);
            this.groupBox2.Controls.Add(this.txtUserName);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1006, 471);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "User";
            // 
            // btnClearPassword
            // 
            this.btnClearPassword.Enabled = false;
            this.btnClearPassword.Location = new System.Drawing.Point(107, 107);
            this.btnClearPassword.Name = "btnClearPassword";
            this.btnClearPassword.Size = new System.Drawing.Size(117, 23);
            this.btnClearPassword.TabIndex = 14;
            this.btnClearPassword.Text = "Clear Password";
            this.btnClearPassword.UseVisualStyleBackColor = true;
            this.btnClearPassword.Click += new System.EventHandler(this.btnClearPassword_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "User Role";
            // 
            // cmbUserRole
            // 
            this.cmbUserRole.DisplayMember = "UserRole";
            this.cmbUserRole.FormattingEnabled = true;
            this.cmbUserRole.Location = new System.Drawing.Point(107, 70);
            this.cmbUserRole.Name = "cmbUserRole";
            this.cmbUserRole.Size = new System.Drawing.Size(225, 21);
            this.cmbUserRole.TabIndex = 12;
            this.cmbUserRole.ValueMember = "UserRoleID";
            // 
            // cbUser
            // 
            this.cbUser.AutoSize = true;
            this.cbUser.Location = new System.Drawing.Point(9, 113);
            this.cbUser.Name = "cbUser";
            this.cbUser.Size = new System.Drawing.Size(59, 17);
            this.cbUser.TabIndex = 11;
            this.cbUser.Text = "Enable";
            this.cbUser.UseVisualStyleBackColor = true;
            // 
            // cmbEmp
            // 
            this.cmbEmp.DisplayMember = "EmployeeNameID";
            this.cmbEmp.FormattingEnabled = true;
            this.cmbEmp.Location = new System.Drawing.Point(107, 23);
            this.cmbEmp.Name = "cmbEmp";
            this.cmbEmp.Size = new System.Drawing.Size(225, 21);
            this.cmbEmp.TabIndex = 10;
            this.cmbEmp.ValueMember = "EmployeeID";
            // 
            // btnUserClear
            // 
            this.btnUserClear.Location = new System.Drawing.Point(338, 70);
            this.btnUserClear.Name = "btnUserClear";
            this.btnUserClear.Size = new System.Drawing.Size(75, 23);
            this.btnUserClear.TabIndex = 6;
            this.btnUserClear.Text = "Clear";
            this.btnUserClear.UseVisualStyleBackColor = true;
            this.btnUserClear.Click += new System.EventHandler(this.btnUserClear_Click);
            // 
            // btnUserDelete
            // 
            this.btnUserDelete.Location = new System.Drawing.Point(338, 44);
            this.btnUserDelete.Name = "btnUserDelete";
            this.btnUserDelete.Size = new System.Drawing.Size(75, 23);
            this.btnUserDelete.TabIndex = 5;
            this.btnUserDelete.Text = "Delete";
            this.btnUserDelete.UseVisualStyleBackColor = true;
            this.btnUserDelete.Click += new System.EventHandler(this.btnUserDelete_Click);
            // 
            // btnUserSave
            // 
            this.btnUserSave.Location = new System.Drawing.Point(338, 18);
            this.btnUserSave.Name = "btnUserSave";
            this.btnUserSave.Size = new System.Drawing.Size(75, 23);
            this.btnUserSave.TabIndex = 4;
            this.btnUserSave.Text = "Save";
            this.btnUserSave.UseVisualStyleBackColor = true;
            this.btnUserSave.Click += new System.EventHandler(this.btnUserSave_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "User List";
            // 
            // gvUserList
            // 
            this.gvUserList.AllowUserToAddRows = false;
            this.gvUserList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gvUserList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.gvUserList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gvUserList.AutoGenerateColumns = false;
            this.gvUserList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gvUserList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvUserList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column1,
            this.Column3,
            this.Column2});
            this.gvUserList.DataSource = this.bindUserList;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvUserList.DefaultCellStyle = dataGridViewCellStyle3;
            this.gvUserList.Location = new System.Drawing.Point(6, 161);
            this.gvUserList.Name = "gvUserList";
            this.gvUserList.ReadOnly = true;
            this.gvUserList.RowHeadersVisible = false;
            this.gvUserList.RowTemplate.Height = 23;
            this.gvUserList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvUserList.Size = new System.Drawing.Size(994, 304);
            this.gvUserList.TabIndex = 8;
            this.gvUserList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvUserList_CellClick);
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column4.DataPropertyName = "UserStatus";
            this.Column4.HeaderText = "Status";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column4.Width = 62;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "EmployeeID";
            this.Column1.HeaderText = "Employee ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 175;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "EmpName";
            this.Column3.HeaderText = "Employee Name";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "UserName";
            this.Column2.HeaderText = "User Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(107, 45);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(225, 20);
            this.txtUserName.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "User Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(37, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Employee";
            // 
            // tbStores
            // 
            this.tbStores.Controls.Add(this.groupBox3);
            this.tbStores.Location = new System.Drawing.Point(4, 22);
            this.tbStores.Name = "tbStores";
            this.tbStores.Size = new System.Drawing.Size(1012, 477);
            this.tbStores.TabIndex = 2;
            this.tbStores.Text = "Stores";
            this.tbStores.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbStoreKeeper);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.btnStoreClear);
            this.groupBox3.Controls.Add(this.btnStoreDelete);
            this.groupBox3.Controls.Add(this.btnStoreSave);
            this.groupBox3.Controls.Add(this.txtStoreDesc);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Controls.Add(this.cmbDepartment);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txtStoreName);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.txtStoreID);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1012, 477);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Stores";
            // 
            // cmbStoreKeeper
            // 
            this.cmbStoreKeeper.DisplayMember = "EmployeeNameID";
            this.cmbStoreKeeper.FormattingEnabled = true;
            this.cmbStoreKeeper.Location = new System.Drawing.Point(94, 112);
            this.cmbStoreKeeper.Name = "cmbStoreKeeper";
            this.cmbStoreKeeper.Size = new System.Drawing.Size(310, 21);
            this.cmbStoreKeeper.TabIndex = 4;
            this.cmbStoreKeeper.ValueMember = "EmployeeID";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(19, 115);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(69, 13);
            this.label15.TabIndex = 25;
            this.label15.Text = "Store Keeper";
            // 
            // btnStoreClear
            // 
            this.btnStoreClear.Location = new System.Drawing.Point(439, 68);
            this.btnStoreClear.Name = "btnStoreClear";
            this.btnStoreClear.Size = new System.Drawing.Size(75, 23);
            this.btnStoreClear.TabIndex = 7;
            this.btnStoreClear.Text = "Clear";
            this.btnStoreClear.UseVisualStyleBackColor = true;
            this.btnStoreClear.Click += new System.EventHandler(this.btnStoreClear_Click);
            // 
            // btnStoreDelete
            // 
            this.btnStoreDelete.Location = new System.Drawing.Point(439, 42);
            this.btnStoreDelete.Name = "btnStoreDelete";
            this.btnStoreDelete.Size = new System.Drawing.Size(75, 23);
            this.btnStoreDelete.TabIndex = 6;
            this.btnStoreDelete.Text = "Delete";
            this.btnStoreDelete.UseVisualStyleBackColor = true;
            this.btnStoreDelete.Click += new System.EventHandler(this.btnStoreDelete_Click);
            // 
            // btnStoreSave
            // 
            this.btnStoreSave.Location = new System.Drawing.Point(439, 16);
            this.btnStoreSave.Name = "btnStoreSave";
            this.btnStoreSave.Size = new System.Drawing.Size(75, 23);
            this.btnStoreSave.TabIndex = 5;
            this.btnStoreSave.Text = "Save";
            this.btnStoreSave.UseVisualStyleBackColor = true;
            this.btnStoreSave.Click += new System.EventHandler(this.btnStoreSave_Click);
            // 
            // txtStoreDesc
            // 
            this.txtStoreDesc.Location = new System.Drawing.Point(94, 67);
            this.txtStoreDesc.Name = "txtStoreDesc";
            this.txtStoreDesc.Size = new System.Drawing.Size(225, 20);
            this.txtStoreDesc.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Store List";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dataGridView1.DataSource = this.bindStoreList;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.Location = new System.Drawing.Point(6, 161);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1000, 310);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "StoreID";
            this.Column5.HeaderText = "Store ID";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 150;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.DataPropertyName = "StoreName";
            this.Column6.HeaderText = "Store Name";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column7.DataPropertyName = "StoreDescription";
            this.Column7.HeaderText = "Description";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column8.DataPropertyName = "DepartmentName";
            this.Column8.HeaderText = "Department";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column9.DataPropertyName = "StoreKeeperName";
            this.Column9.HeaderText = "Store Keeper";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.DisplayMember = "DepName";
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Location = new System.Drawing.Point(94, 89);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(225, 21);
            this.cmbDepartment.TabIndex = 3;
            this.cmbDepartment.ValueMember = "DepID";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(26, 92);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Department";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(28, 70);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "Description";
            // 
            // txtStoreName
            // 
            this.txtStoreName.Location = new System.Drawing.Point(94, 45);
            this.txtStoreName.Name = "txtStoreName";
            this.txtStoreName.Size = new System.Drawing.Size(225, 20);
            this.txtStoreName.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(53, 49);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Name";
            // 
            // txtStoreID
            // 
            this.txtStoreID.Location = new System.Drawing.Point(94, 23);
            this.txtStoreID.Name = "txtStoreID";
            this.txtStoreID.Size = new System.Drawing.Size(121, 20);
            this.txtStoreID.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(42, 26);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Store ID";
            // 
            // tbDivision
            // 
            this.tbDivision.Controls.Add(this.ucDivision1);
            this.tbDivision.Location = new System.Drawing.Point(4, 22);
            this.tbDivision.Name = "tbDivision";
            this.tbDivision.Padding = new System.Windows.Forms.Padding(3);
            this.tbDivision.Size = new System.Drawing.Size(1012, 477);
            this.tbDivision.TabIndex = 3;
            this.tbDivision.Text = "Division";
            this.tbDivision.UseVisualStyleBackColor = true;
            // 
            // ucDivision1
            // 
            this.ucDivision1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucDivision1.Location = new System.Drawing.Point(3, 3);
            this.ucDivision1.Name = "ucDivision1";
            this.ucDivision1.Size = new System.Drawing.Size(1006, 471);
            this.ucDivision1.TabIndex = 0;
            // 
            // tbSection
            // 
            this.tbSection.Controls.Add(this.ucSection1);
            this.tbSection.Location = new System.Drawing.Point(4, 22);
            this.tbSection.Name = "tbSection";
            this.tbSection.Size = new System.Drawing.Size(1012, 477);
            this.tbSection.TabIndex = 4;
            this.tbSection.Text = "Section";
            this.tbSection.UseVisualStyleBackColor = true;
            // 
            // ucSection1
            // 
            this.ucSection1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucSection1.Location = new System.Drawing.Point(0, 0);
            this.ucSection1.Name = "ucSection1";
            this.ucSection1.Size = new System.Drawing.Size(1012, 477);
            this.ucSection1.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "DepID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "DepName";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DepDescription";
            this.dataGridViewTextBoxColumn3.HeaderText = "Description";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "EmpName";
            this.dataGridViewTextBoxColumn4.HeaderText = "Depaetment Head";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 250;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "DepManager";
            this.dataGridViewTextBoxColumn5.HeaderText = "DepHeadID";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Visible = false;
            this.dataGridViewTextBoxColumn5.Width = 75;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "EmployeeID";
            this.dataGridViewTextBoxColumn6.HeaderText = "Employee ID";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Visible = false;
            this.dataGridViewTextBoxColumn6.Width = 175;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "EmpName";
            this.dataGridViewTextBoxColumn7.HeaderText = "Employee Name";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn8.DataPropertyName = "UserName";
            this.dataGridViewTextBoxColumn8.HeaderText = "User Name";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn9.DataPropertyName = "StoreID";
            this.dataGridViewTextBoxColumn9.HeaderText = "Store ID";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn10.DataPropertyName = "StoreName";
            this.dataGridViewTextBoxColumn10.HeaderText = "Store Name";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn11.DataPropertyName = "StoreDescription";
            this.dataGridViewTextBoxColumn11.HeaderText = "Description";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn12.DataPropertyName = "DepartmentName";
            this.dataGridViewTextBoxColumn12.HeaderText = "Department";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn13.DataPropertyName = "StoreKeeperName";
            this.dataGridViewTextBoxColumn13.HeaderText = "Store Keeper";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn14.DataPropertyName = "StoreKeeperName";
            this.dataGridViewTextBoxColumn14.HeaderText = "Store Keeper";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // rbProduction
            // 
            this.rbProduction.AutoSize = true;
            this.rbProduction.Location = new System.Drawing.Point(427, 23);
            this.rbProduction.Name = "rbProduction";
            this.rbProduction.Size = new System.Drawing.Size(76, 17);
            this.rbProduction.TabIndex = 32;
            this.rbProduction.TabStop = true;
            this.rbProduction.Text = "Production";
            this.rbProduction.UseVisualStyleBackColor = true;
            // 
            // frmSystemMgt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 503);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSystemMgt";
            this.Text = "System Management";
            this.Load += new System.EventHandler(this.frmSystemMgt_Load);
            this.tabControl1.ResumeLayout(false);
            this.tbDepartment.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvDepartment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindDep)).EndInit();
            this.tbUser.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvUserList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindUserList)).EndInit();
            this.tbStores.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindStoreList)).EndInit();
            this.tbDivision.ResumeLayout(false);
            this.tbSection.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindDepStores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindDivisions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tbDepartment;
        private System.Windows.Forms.TabPage tbUser;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView gvUserList;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnUserClear;
        private System.Windows.Forms.Button btnUserDelete;
        private System.Windows.Forms.Button btnUserSave;
        public System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbStores;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmbStoreKeeper;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnStoreClear;
        private System.Windows.Forms.Button btnStoreDelete;
        private System.Windows.Forms.Button btnStoreSave;
        private System.Windows.Forms.TextBox txtStoreDesc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtStoreName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtStoreID;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.BindingSource bindStoreList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.ComboBox cmbEmp;
        private System.Windows.Forms.BindingSource bindUserList;
        private System.Windows.Forms.CheckBox cbUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbUserRole;
        private System.Windows.Forms.Button btnClearPassword;
        private System.Windows.Forms.BindingSource bindDep;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.BindingSource bindDepStores;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.TabPage tbDivision;
        private System.Windows.Forms.TabPage tbSection;
        private MRP_GUI.Components.ucSection ucSection1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbDivision;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnSaveDefault;
        private System.Windows.Forms.ComboBox cmbDepartmenttores;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cmbDepartmentList;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rbPRPD;
        private System.Windows.Forms.RadioButton rbRPD;
        private System.Windows.Forms.RadioButton rbOther;
        private System.Windows.Forms.RadioButton rbSales;
        private System.Windows.Forms.RadioButton rbStores;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView gvDepartment;
        private System.Windows.Forms.ComboBox cmbDepHead;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDepartmentDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDepartmentName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource bindDivisions;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label18;
        private MRP_GUI.Components.ucDivision ucDivision1;
        private System.Windows.Forms.RadioButton rbAgri;
        private System.Windows.Forms.RadioButton rbSupply;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDepID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDepName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDepDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEmpName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDepManager;
        private System.Windows.Forms.RadioButton rbProduction;
    }
}