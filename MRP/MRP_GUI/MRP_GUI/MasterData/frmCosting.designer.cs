namespace MRP_GUI
{
    partial class frmCosting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCosting));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.gvStockHoldingRates = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindStockHolding = new System.Windows.Forms.BindingSource(this.components);
            this.btnSet = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNewRate = new System.Windows.Forms.TextBox();
            this.txtEnterdBy = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEnterdDate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCurrentRate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtSection = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnClearDep = new System.Windows.Forms.Button();
            this.txtDID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDepartmentName = new System.Windows.Forms.TextBox();
            this.btnSaveDep = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.gvDepartment = new System.Windows.Forms.DataGridView();
            this.ColDepID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDepName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindDepartment = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.txtDepEnterdBy = new System.Windows.Forms.TextBox();
            this.txtDepEnterdDate = new System.Windows.Forms.TextBox();
            this.txtDepCurrent = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnComSave = new System.Windows.Forms.Button();
            this.txtComEnterd = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtComDate = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtComRate = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvStockHoldingRates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindStockHolding)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvDepartment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindDepartment)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.gvStockHoldingRates);
            this.groupBox1.Controls.Add(this.btnSet);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtNewRate);
            this.groupBox1.Controls.Add(this.txtEnterdBy);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtEnterdDate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtCurrentRate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(926, 130);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stock Holding Cost";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Previous Rates";
            // 
            // gvStockHoldingRates
            // 
            this.gvStockHoldingRates.AllowUserToAddRows = false;
            this.gvStockHoldingRates.AllowUserToDeleteRows = false;
            this.gvStockHoldingRates.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gvStockHoldingRates.AutoGenerateColumns = false;
            this.gvStockHoldingRates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvStockHoldingRates.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.gvStockHoldingRates.DataSource = this.bindStockHolding;
            this.gvStockHoldingRates.Location = new System.Drawing.Point(9, 32);
            this.gvStockHoldingRates.Name = "gvStockHoldingRates";
            this.gvStockHoldingRates.ReadOnly = true;
            this.gvStockHoldingRates.RowHeadersVisible = false;
            this.gvStockHoldingRates.RowTemplate.Height = 18;
            this.gvStockHoldingRates.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvStockHoldingRates.Size = new System.Drawing.Size(557, 92);
            this.gvStockHoldingRates.TabIndex = 9;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "FromDate";
            dataGridViewCellStyle1.Format = "d";
            this.Column1.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column1.HeaderText = "From Date";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "ToDate";
            dataGridViewCellStyle2.Format = "d";
            this.Column2.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column2.HeaderText = "To Date";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Rate";
            this.Column3.HeaderText = "Rate";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "ChangedBy";
            this.Column4.HeaderText = "Changed By";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // btnSet
            // 
            this.btnSet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSet.Location = new System.Drawing.Point(844, 101);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(75, 23);
            this.btnSet.TabIndex = 8;
            this.btnSet.Text = "Save";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(595, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "New Rate*";
            // 
            // txtNewRate
            // 
            this.txtNewRate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNewRate.Location = new System.Drawing.Point(660, 100);
            this.txtNewRate.Name = "txtNewRate";
            this.txtNewRate.Size = new System.Drawing.Size(100, 20);
            this.txtNewRate.TabIndex = 6;
            this.txtNewRate.Text = "0.00";
            this.txtNewRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNewRate_KeyPress);
            // 
            // txtEnterdBy
            // 
            this.txtEnterdBy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEnterdBy.Location = new System.Drawing.Point(660, 74);
            this.txtEnterdBy.Name = "txtEnterdBy";
            this.txtEnterdBy.ReadOnly = true;
            this.txtEnterdBy.Size = new System.Drawing.Size(248, 20);
            this.txtEnterdBy.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(601, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Enterd By";
            // 
            // txtEnterdDate
            // 
            this.txtEnterdDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEnterdDate.Location = new System.Drawing.Point(660, 53);
            this.txtEnterdDate.Name = "txtEnterdDate";
            this.txtEnterdDate.ReadOnly = true;
            this.txtEnterdDate.Size = new System.Drawing.Size(110, 20);
            this.txtEnterdDate.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(590, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enterd Date";
            // 
            // txtCurrentRate
            // 
            this.txtCurrentRate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCurrentRate.Location = new System.Drawing.Point(660, 32);
            this.txtCurrentRate.Name = "txtCurrentRate";
            this.txtCurrentRate.ReadOnly = true;
            this.txtCurrentRate.Size = new System.Drawing.Size(110, 20);
            this.txtCurrentRate.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(587, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current Rate";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.txtSection);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.btnClearDep);
            this.groupBox3.Controls.Add(this.txtDID);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtDepartmentName);
            this.groupBox3.Controls.Add(this.btnSaveDep);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.gvDepartment);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label44);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.label33);
            this.groupBox3.Controls.Add(this.label27);
            this.groupBox3.Controls.Add(this.txtDepEnterdBy);
            this.groupBox3.Controls.Add(this.txtDepEnterdDate);
            this.groupBox3.Controls.Add(this.txtDepCurrent);
            this.groupBox3.Controls.Add(this.label24);
            this.groupBox3.Location = new System.Drawing.Point(3, 236);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(926, 214);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Overhead Calculation Rate";
            // 
            // txtSection
            // 
            this.txtSection.Location = new System.Drawing.Point(638, 75);
            this.txtSection.Name = "txtSection";
            this.txtSection.ReadOnly = true;
            this.txtSection.Size = new System.Drawing.Size(245, 20);
            this.txtSection.TabIndex = 18;
            this.txtSection.Text = "N/A";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(589, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Section";
            // 
            // btnClearDep
            // 
            this.btnClearDep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearDep.Location = new System.Drawing.Point(763, 185);
            this.btnClearDep.Name = "btnClearDep";
            this.btnClearDep.Size = new System.Drawing.Size(75, 23);
            this.btnClearDep.TabIndex = 16;
            this.btnClearDep.Text = "Clear";
            this.btnClearDep.UseVisualStyleBackColor = true;
            this.btnClearDep.Click += new System.EventHandler(this.btnClearDep_Click);
            // 
            // txtDID
            // 
            this.txtDID.Location = new System.Drawing.Point(638, 31);
            this.txtDID.Name = "txtDID";
            this.txtDID.ReadOnly = true;
            this.txtDID.Size = new System.Drawing.Size(100, 20);
            this.txtDID.TabIndex = 15;
            this.txtDID.Text = "N/A";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(556, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Department ID";
            // 
            // txtDepartmentName
            // 
            this.txtDepartmentName.Location = new System.Drawing.Point(638, 52);
            this.txtDepartmentName.Name = "txtDepartmentName";
            this.txtDepartmentName.ReadOnly = true;
            this.txtDepartmentName.Size = new System.Drawing.Size(245, 20);
            this.txtDepartmentName.TabIndex = 13;
            this.txtDepartmentName.Text = "N/A";
            // 
            // btnSaveDep
            // 
            this.btnSaveDep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveDep.Location = new System.Drawing.Point(844, 185);
            this.btnSaveDep.Name = "btnSaveDep";
            this.btnSaveDep.Size = new System.Drawing.Size(75, 23);
            this.btnSaveDep.TabIndex = 12;
            this.btnSaveDep.Text = "Save";
            this.btnSaveDep.UseVisualStyleBackColor = true;
            this.btnSaveDep.Click += new System.EventHandler(this.btnSaveDep_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(570, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Department";
            // 
            // gvDepartment
            // 
            this.gvDepartment.AllowUserToAddRows = false;
            this.gvDepartment.AllowUserToDeleteRows = false;
            this.gvDepartment.AutoGenerateColumns = false;
            this.gvDepartment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDepartment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColDepID,
            this.colDepName,
            this.Column5,
            this.ColRate});
            this.gvDepartment.DataSource = this.bindDepartment;
            this.gvDepartment.Location = new System.Drawing.Point(6, 43);
            this.gvDepartment.MultiSelect = false;
            this.gvDepartment.Name = "gvDepartment";
            this.gvDepartment.ReadOnly = true;
            this.gvDepartment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvDepartment.Size = new System.Drawing.Size(544, 160);
            this.gvDepartment.TabIndex = 9;
            this.gvDepartment.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvDepartment_CellClick);
            // 
            // ColDepID
            // 
            this.ColDepID.DataPropertyName = "SectionID";
            this.ColDepID.HeaderText = "DepID";
            this.ColDepID.Name = "ColDepID";
            this.ColDepID.ReadOnly = true;
            this.ColDepID.Visible = false;
            // 
            // colDepName
            // 
            this.colDepName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDepName.DataPropertyName = "DepName";
            this.colDepName.HeaderText = "Department ";
            this.colDepName.MinimumWidth = 200;
            this.colDepName.Name = "colDepName";
            this.colDepName.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "SectionName";
            this.Column5.HeaderText = "Section";
            this.Column5.MinimumWidth = 200;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 200;
            // 
            // ColRate
            // 
            this.ColRate.DataPropertyName = "Rate";
            this.ColRate.HeaderText = "Rate";
            this.ColRate.Name = "ColRate";
            this.ColRate.ReadOnly = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Department List";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(573, 186);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(59, 13);
            this.label44.TabIndex = 7;
            this.label44.Text = "New Rate*";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(638, 183);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "0.00";
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNewRate_KeyPress);
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(579, 160);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(53, 13);
            this.label33.TabIndex = 5;
            this.label33.Text = "Enterd By";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(568, 139);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(64, 13);
            this.label27.TabIndex = 4;
            this.label27.Text = "Enterd Date";
            // 
            // txtDepEnterdBy
            // 
            this.txtDepEnterdBy.Location = new System.Drawing.Point(638, 157);
            this.txtDepEnterdBy.Name = "txtDepEnterdBy";
            this.txtDepEnterdBy.ReadOnly = true;
            this.txtDepEnterdBy.Size = new System.Drawing.Size(245, 20);
            this.txtDepEnterdBy.TabIndex = 3;
            this.txtDepEnterdBy.Text = "N/A";
            // 
            // txtDepEnterdDate
            // 
            this.txtDepEnterdDate.Location = new System.Drawing.Point(638, 136);
            this.txtDepEnterdDate.Name = "txtDepEnterdDate";
            this.txtDepEnterdDate.ReadOnly = true;
            this.txtDepEnterdDate.Size = new System.Drawing.Size(100, 20);
            this.txtDepEnterdDate.TabIndex = 2;
            this.txtDepEnterdDate.Text = "N/A";
            // 
            // txtDepCurrent
            // 
            this.txtDepCurrent.Location = new System.Drawing.Point(638, 115);
            this.txtDepCurrent.Name = "txtDepCurrent";
            this.txtDepCurrent.ReadOnly = true;
            this.txtDepCurrent.Size = new System.Drawing.Size(100, 20);
            this.txtDepCurrent.TabIndex = 1;
            this.txtDepCurrent.Text = "N/A";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(565, 118);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(67, 13);
            this.label24.TabIndex = 0;
            this.label24.Text = "Current Rate";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnComSave);
            this.groupBox2.Controls.Add(this.txtComEnterd);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtComDate);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtComRate);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Location = new System.Drawing.Point(3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(926, 92);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Company Overhead Rate";
            // 
            // btnComSave
            // 
            this.btnComSave.Location = new System.Drawing.Point(371, 63);
            this.btnComSave.Name = "btnComSave";
            this.btnComSave.Size = new System.Drawing.Size(75, 23);
            this.btnComSave.TabIndex = 12;
            this.btnComSave.Text = "Save";
            this.btnComSave.UseVisualStyleBackColor = true;
            this.btnComSave.Click += new System.EventHandler(this.btnComSave_Click);
            // 
            // txtComEnterd
            // 
            this.txtComEnterd.Location = new System.Drawing.Point(95, 66);
            this.txtComEnterd.Name = "txtComEnterd";
            this.txtComEnterd.ReadOnly = true;
            this.txtComEnterd.Size = new System.Drawing.Size(248, 20);
            this.txtComEnterd.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(36, 69);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Enterd By";
            // 
            // txtComDate
            // 
            this.txtComDate.Location = new System.Drawing.Point(95, 45);
            this.txtComDate.Name = "txtComDate";
            this.txtComDate.ReadOnly = true;
            this.txtComDate.Size = new System.Drawing.Size(110, 20);
            this.txtComDate.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(25, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "Enterd Date";
            // 
            // txtComRate
            // 
            this.txtComRate.Location = new System.Drawing.Point(95, 24);
            this.txtComRate.Name = "txtComRate";
            this.txtComRate.Size = new System.Drawing.Size(110, 20);
            this.txtComRate.TabIndex = 7;
            this.txtComRate.Text = "0.00";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(59, 27);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "Rate";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "FromDate";
            dataGridViewCellStyle3.Format = "d";
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn1.HeaderText = "From Date";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ToDate";
            dataGridViewCellStyle4.Format = "d";
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTextBoxColumn2.HeaderText = "To Date";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Rate";
            this.dataGridViewTextBoxColumn3.HeaderText = "Rate";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ChangedBy";
            this.dataGridViewTextBoxColumn4.HeaderText = "Changed By";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "DepID";
            this.dataGridViewTextBoxColumn5.HeaderText = "DepID";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "DepName";
            this.dataGridViewTextBoxColumn6.HeaderText = "Department ";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 200;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Rate";
            this.dataGridViewTextBoxColumn7.HeaderText = "Rate";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 200;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 200;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Rate";
            this.dataGridViewTextBoxColumn8.HeaderText = "Rate";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // frmCosting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 462);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCosting";
            this.Text = "Stock Holding Cost & Overhead Calculation Rates";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCosting_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvStockHoldingRates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindStockHolding)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvDepartment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindDepartment)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView gvStockHoldingRates;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNewRate;
        private System.Windows.Forms.TextBox txtEnterdBy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEnterdDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCurrentRate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.BindingSource bindStockHolding;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox txtDepEnterdBy;
        private System.Windows.Forms.TextBox txtDepEnterdDate;
        private System.Windows.Forms.TextBox txtDepCurrent;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.DataGridView gvDepartment;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource bindDepartment;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSaveDep;
        private System.Windows.Forms.TextBox txtDID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDepartmentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Button btnClearDep;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDepID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDepName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColRate;
        private System.Windows.Forms.TextBox txtSection;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnComSave;
        private System.Windows.Forms.TextBox txtComEnterd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtComDate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtComRate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}