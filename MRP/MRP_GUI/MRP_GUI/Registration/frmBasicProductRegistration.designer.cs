namespace MRP_GUI
{
    partial class frmBasicProductRegistration
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBasicProductRegistration));
            this.bindSubCategory = new System.Windows.Forms.BindingSource(this.components);
            this.BasicProductBinidinSourse = new System.Windows.Forms.BindingSource(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cmbForm = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.label64 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.cmbProductType = new System.Windows.Forms.ComboBox();
            this.label46 = new System.Windows.Forms.Label();
            this.cmbProductSubCategory = new System.Windows.Forms.ComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbUnit = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkDisable = new System.Windows.Forms.CheckBox();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtProductCode = new System.Windows.Forms.TextBox();
            this.txtProductDescription = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.gvBasicProduct = new System.Windows.Forms.DataGridView();
            this.bindCategory = new System.Windows.Forms.BindingSource(this.components);
            this.bindUnits = new System.Windows.Forms.BindingSource(this.components);
            this.bindForm = new System.Windows.Forms.BindingSource(this.components);
            this.bindDepartment = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.cmbSections = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSTDBatchSize = new System.Windows.Forms.TextBox();
            this.bindSections = new System.Windows.Forms.BindingSource(this.components);
            this.ColBasicProductType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SectionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColBasicProductFormulaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColBasicProductCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColBasicProductDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColBasicProductSubCatID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColBasicProductUnitID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColBasicProductForm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColBasicProductFormID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColBasicProductAvgCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STDBatchSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColBasicProductStatus = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bindSubCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasicProductBinidinSourse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvBasicProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindUnits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindDepartment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindSections)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // cmbForm
            // 
            this.cmbForm.DisplayMember = "Form";
            this.cmbForm.FormattingEnabled = true;
            this.cmbForm.Items.AddRange(new object[] {
            "POWDER",
            "LIQUID"});
            this.cmbForm.Location = new System.Drawing.Point(447, 43);
            this.cmbForm.Name = "cmbForm";
            this.cmbForm.Size = new System.Drawing.Size(91, 21);
            this.cmbForm.TabIndex = 6;
            this.cmbForm.Text = "--Select Form--";
            this.cmbForm.ValueMember = "FormID";
            // 
            // label20
            // 
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(407, 51);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(39, 13);
            this.label20.TabIndex = 101;
            this.label20.Text = "Form : ";
            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(447, 70);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(91, 20);
            this.txtRate.TabIndex = 7;
            this.txtRate.Validated += new System.EventHandler(this.textBox18_Validated);
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Location = new System.Drawing.Point(308, 75);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(135, 13);
            this.label64.TabIndex = 65;
            this.label64.Text = "Outsource Rate (Per Unit) :";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(27, 58);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(80, 13);
            this.label47.TabIndex = 64;
            this.label47.Text = "Product Type : ";
            // 
            // cmbProductType
            // 
            this.cmbProductType.FormattingEnabled = true;
            this.cmbProductType.Items.AddRange(new object[] {
            "Product",
            "Semi Processed Product"});
            this.cmbProductType.Location = new System.Drawing.Point(114, 55);
            this.cmbProductType.Name = "cmbProductType";
            this.cmbProductType.Size = new System.Drawing.Size(191, 21);
            this.cmbProductType.TabIndex = 0;
            this.cmbProductType.Text = "--Select Product Type--";
            this.cmbProductType.SelectedIndexChanged += new System.EventHandler(this.comboBox13_SelectedIndexChanged);
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(27, 82);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(80, 13);
            this.label46.TabIndex = 61;
            this.label46.Text = "Sub Category : ";
            // 
            // cmbProductSubCategory
            // 
            this.cmbProductSubCategory.DataSource = this.bindSubCategory;
            this.cmbProductSubCategory.DisplayMember = "ProductSubCatID";
            this.cmbProductSubCategory.FormattingEnabled = true;
            this.cmbProductSubCategory.Location = new System.Drawing.Point(114, 80);
            this.cmbProductSubCategory.Name = "cmbProductSubCategory";
            this.cmbProductSubCategory.Size = new System.Drawing.Size(191, 21);
            this.cmbProductSubCategory.TabIndex = 2;
            this.cmbProductSubCategory.ValueMember = "ProductSubCatID";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(859, 42);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 59;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.button9_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(859, 67);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 58;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.button10_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(859, 117);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.button11_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(49, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 55;
            this.label11.Text = "Category : ";
            // 
            // cmbUnit
            // 
            this.cmbUnit.DisplayMember = "UnitCode";
            this.cmbUnit.FormattingEnabled = true;
            this.cmbUnit.Location = new System.Drawing.Point(447, 18);
            this.cmbUnit.Name = "cmbUnit";
            this.cmbUnit.Size = new System.Drawing.Size(91, 21);
            this.cmbUnit.TabIndex = 5;
            this.cmbUnit.Text = "--Select Unit--";
            this.cmbUnit.ValueMember = "UnitID";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.txtSTDBatchSize);
            this.groupBox3.Controls.Add(this.cmbSections);
            this.groupBox3.Controls.Add(this.chkDisable);
            this.groupBox3.Controls.Add(this.cmbDepartment);
            this.groupBox3.Controls.Add(this.cmbForm);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.txtRate);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label64);
            this.groupBox3.Controls.Add(this.label47);
            this.groupBox3.Controls.Add(this.cmbProductType);
            this.groupBox3.Controls.Add(this.label46);
            this.groupBox3.Controls.Add(this.cmbProductSubCategory);
            this.groupBox3.Controls.Add(this.btnClear);
            this.groupBox3.Controls.Add(this.btnDelete);
            this.groupBox3.Controls.Add(this.btnSave);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.cmbUnit);
            this.groupBox3.Controls.Add(this.cmbCategory);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.txtProductCode);
            this.groupBox3.Controls.Add(this.txtProductDescription);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Location = new System.Drawing.Point(6, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(966, 165);
            this.groupBox3.TabIndex = 105;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Basic/Semi Processed Product";
            // 
            // chkDisable
            // 
            this.chkDisable.AutoSize = true;
            this.chkDisable.Location = new System.Drawing.Point(859, 21);
            this.chkDisable.Name = "chkDisable";
            this.chkDisable.Size = new System.Drawing.Size(101, 17);
            this.chkDisable.TabIndex = 103;
            this.chkDisable.Text = "Disable Product";
            this.chkDisable.UseVisualStyleBackColor = true;
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.DisplayMember = "DepName";
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Location = new System.Drawing.Point(447, 96);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(204, 21);
            this.cmbDepartment.TabIndex = 102;
            this.cmbDepartment.ValueMember = "DepID";
            this.cmbDepartment.SelectedIndexChanged += new System.EventHandler(this.cmbDepartment_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(338, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 65;
            this.label1.Text = "Manufacturing Dep :";
            // 
            // cmbCategory
            // 
            this.cmbCategory.DisplayMember = "ProductCategory";
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(114, 19);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(191, 21);
            this.cmbCategory.TabIndex = 1;
            this.cmbCategory.ValueMember = "ProductCatID";
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.comboBox6_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(38, 127);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 13);
            this.label13.TabIndex = 51;
            this.label13.Text = "Description : ";
            // 
            // txtProductCode
            // 
            this.txtProductCode.Location = new System.Drawing.Point(114, 105);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.Size = new System.Drawing.Size(191, 20);
            this.txtProductCode.TabIndex = 3;
            // 
            // txtProductDescription
            // 
            this.txtProductDescription.Location = new System.Drawing.Point(114, 129);
            this.txtProductDescription.Name = "txtProductDescription";
            this.txtProductDescription.Size = new System.Drawing.Size(191, 20);
            this.txtProductDescription.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(411, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 52;
            this.label12.Text = "Unit : ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(26, 105);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(81, 13);
            this.label14.TabIndex = 49;
            this.label14.Text = "Product Code : ";
            // 
            // gvBasicProduct
            // 
            this.gvBasicProduct.AllowUserToAddRows = false;
            this.gvBasicProduct.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gvBasicProduct.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gvBasicProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvBasicProduct.AutoGenerateColumns = false;
            this.gvBasicProduct.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gvBasicProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvBasicProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColBasicProductType,
            this.DepID,
            this.SectionID,
            this.ColBasicProductFormulaID,
            this.ColBasicProductCode,
            this.ColBasicProductDescription,
            this.ColBasicProductSubCatID,
            this.dataGridViewTextBoxColumn15,
            this.ColBasicProductUnitID,
            this.ColBasicProductForm,
            this.ColBasicProductFormID,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19,
            this.ColBasicProductAvgCost,
            this.STDBatchSize,
            this.ColBasicProductStatus});
            this.gvBasicProduct.DataSource = this.BasicProductBinidinSourse;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvBasicProduct.DefaultCellStyle = dataGridViewCellStyle3;
            this.gvBasicProduct.Location = new System.Drawing.Point(6, 183);
            this.gvBasicProduct.MultiSelect = false;
            this.gvBasicProduct.Name = "gvBasicProduct";
            this.gvBasicProduct.ReadOnly = true;
            this.gvBasicProduct.RowHeadersVisible = false;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvBasicProduct.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gvBasicProduct.RowTemplate.Height = 10;
            this.gvBasicProduct.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.gvBasicProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvBasicProduct.Size = new System.Drawing.Size(966, 408);
            this.gvBasicProduct.TabIndex = 102;
            this.gvBasicProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBasicProduct_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(351, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 65;
            this.label2.Text = "Packing Section :";
            // 
            // cmbSections
            // 
            this.cmbSections.DisplayMember = "SectionName";
            this.cmbSections.FormattingEnabled = true;
            this.cmbSections.Location = new System.Drawing.Point(447, 123);
            this.cmbSections.Name = "cmbSections";
            this.cmbSections.Size = new System.Drawing.Size(204, 21);
            this.cmbSections.TabIndex = 104;
            this.cmbSections.ValueMember = "SectionID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(610, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 13);
            this.label3.TabIndex = 65;
            this.label3.Text = "Current STDBatch Size :";
            // 
            // txtSTDBatchSize
            // 
            this.txtSTDBatchSize.Location = new System.Drawing.Point(739, 19);
            this.txtSTDBatchSize.Name = "txtSTDBatchSize";
            this.txtSTDBatchSize.Size = new System.Drawing.Size(100, 20);
            this.txtSTDBatchSize.TabIndex = 105;
            // 
            // ColBasicProductType
            // 
            this.ColBasicProductType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColBasicProductType.DataPropertyName = "BasicProductType";
            this.ColBasicProductType.HeaderText = "Product Type";
            this.ColBasicProductType.Name = "ColBasicProductType";
            this.ColBasicProductType.ReadOnly = true;
            // 
            // DepID
            // 
            this.DepID.DataPropertyName = "DepID";
            this.DepID.HeaderText = "DepID";
            this.DepID.Name = "DepID";
            this.DepID.ReadOnly = true;
            this.DepID.Visible = false;
            // 
            // SectionID
            // 
            this.SectionID.DataPropertyName = "SectionID";
            this.SectionID.HeaderText = "SectionID";
            this.SectionID.Name = "SectionID";
            this.SectionID.ReadOnly = true;
            this.SectionID.Visible = false;
            // 
            // ColBasicProductFormulaID
            // 
            this.ColBasicProductFormulaID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColBasicProductFormulaID.DataPropertyName = "BasicProductFormulaID";
            this.ColBasicProductFormulaID.HeaderText = "ColBasicProductFormulaID";
            this.ColBasicProductFormulaID.Name = "ColBasicProductFormulaID";
            this.ColBasicProductFormulaID.ReadOnly = true;
            this.ColBasicProductFormulaID.Visible = false;
            // 
            // ColBasicProductCode
            // 
            this.ColBasicProductCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColBasicProductCode.DataPropertyName = "BasicProductCode";
            this.ColBasicProductCode.HeaderText = "Product Code";
            this.ColBasicProductCode.Name = "ColBasicProductCode";
            this.ColBasicProductCode.ReadOnly = true;
            // 
            // ColBasicProductDescription
            // 
            this.ColBasicProductDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColBasicProductDescription.DataPropertyName = "BasicProductDescription";
            this.ColBasicProductDescription.FillWeight = 200F;
            this.ColBasicProductDescription.HeaderText = "Description";
            this.ColBasicProductDescription.MinimumWidth = 125;
            this.ColBasicProductDescription.Name = "ColBasicProductDescription";
            this.ColBasicProductDescription.ReadOnly = true;
            // 
            // ColBasicProductSubCatID
            // 
            this.ColBasicProductSubCatID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColBasicProductSubCatID.DataPropertyName = "BasicProductSubCatID";
            this.ColBasicProductSubCatID.HeaderText = "SubCatID";
            this.ColBasicProductSubCatID.Name = "ColBasicProductSubCatID";
            this.ColBasicProductSubCatID.ReadOnly = true;
            this.ColBasicProductSubCatID.Visible = false;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn15.DataPropertyName = "ProductSubCategory";
            this.dataGridViewTextBoxColumn15.HeaderText = "Sub Category";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            // 
            // ColBasicProductUnitID
            // 
            this.ColBasicProductUnitID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColBasicProductUnitID.DataPropertyName = "BasicProductUnitID";
            this.ColBasicProductUnitID.HeaderText = "UnitID";
            this.ColBasicProductUnitID.Name = "ColBasicProductUnitID";
            this.ColBasicProductUnitID.ReadOnly = true;
            this.ColBasicProductUnitID.Visible = false;
            // 
            // ColBasicProductForm
            // 
            this.ColBasicProductForm.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColBasicProductForm.DataPropertyName = "Form";
            this.ColBasicProductForm.HeaderText = "Form";
            this.ColBasicProductForm.Name = "ColBasicProductForm";
            this.ColBasicProductForm.ReadOnly = true;
            // 
            // ColBasicProductFormID
            // 
            this.ColBasicProductFormID.DataPropertyName = "BasicProductFormID";
            this.ColBasicProductFormID.HeaderText = "ColBasicProductFormID";
            this.ColBasicProductFormID.Name = "ColBasicProductFormID";
            this.ColBasicProductFormID.ReadOnly = true;
            this.ColBasicProductFormID.Visible = false;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn18.DataPropertyName = "UnitCode";
            this.dataGridViewTextBoxColumn18.HeaderText = "Unit";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn19.DataPropertyName = "BasicProductFormID";
            this.dataGridViewTextBoxColumn19.HeaderText = "FormID";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.ReadOnly = true;
            this.dataGridViewTextBoxColumn19.Visible = false;
            // 
            // ColBasicProductAvgCost
            // 
            this.ColBasicProductAvgCost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColBasicProductAvgCost.DataPropertyName = "BasicProductAVGCost";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.ColBasicProductAvgCost.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColBasicProductAvgCost.HeaderText = "Outsource Cost(Per Unit)";
            this.ColBasicProductAvgCost.Name = "ColBasicProductAvgCost";
            this.ColBasicProductAvgCost.ReadOnly = true;
            // 
            // STDBatchSize
            // 
            this.STDBatchSize.DataPropertyName = "STDBatchSize";
            this.STDBatchSize.HeaderText = "STDBatchSize";
            this.STDBatchSize.Name = "STDBatchSize";
            this.STDBatchSize.ReadOnly = true;
            // 
            // ColBasicProductStatus
            // 
            this.ColBasicProductStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColBasicProductStatus.DataPropertyName = "BasicProductStatus";
            this.ColBasicProductStatus.HeaderText = "Status";
            this.ColBasicProductStatus.Name = "ColBasicProductStatus";
            this.ColBasicProductStatus.ReadOnly = true;
            this.ColBasicProductStatus.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColBasicProductStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // frmBasicProductRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 604);
            this.Controls.Add(this.gvBasicProduct);
            this.Controls.Add(this.groupBox3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBasicProductRegistration";
            this.Text = "Product Registration- Basic/Semi Processed";
            this.Load += new System.EventHandler(this.frmProductRegistration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindSubCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BasicProductBinidinSourse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvBasicProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindUnits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindDepartment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindSections)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource BasicProductBinidinSourse;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmbForm;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.ComboBox cmbProductType;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.ComboBox cmbProductSubCategory;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbUnit;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtProductCode;
        private System.Windows.Forms.TextBox txtProductDescription;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.BindingSource bindSubCategory;
        private System.Windows.Forms.BindingSource bindCategory;
        private System.Windows.Forms.DataGridView gvBasicProduct;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkDisable;
        private System.Windows.Forms.BindingSource bindUnits;
        private System.Windows.Forms.BindingSource bindForm;
        private System.Windows.Forms.BindingSource bindDepartment;
        private System.Windows.Forms.ComboBox cmbSections;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSTDBatchSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource bindSections;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColBasicProductType;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SectionID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColBasicProductFormulaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColBasicProductCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColBasicProductDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColBasicProductSubCatID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColBasicProductUnitID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColBasicProductForm;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColBasicProductFormID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColBasicProductAvgCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn STDBatchSize;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColBasicProductStatus;

    }
}