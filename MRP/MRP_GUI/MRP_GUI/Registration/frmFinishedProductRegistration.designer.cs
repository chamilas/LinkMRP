namespace MRP_GUI
{
    partial class frmFinishedProductRegistration
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFinishedProductRegistration));
            this.txtProductCode = new System.Windows.Forms.TextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.chkEnablePr = new System.Windows.Forms.CheckBox();
            this.btnDeleteFinishProduct = new System.Windows.Forms.Button();
            this.btnAddFinishProduct = new System.Windows.Forms.Button();
            this.txtBasicProductQty = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.cmbPackType = new System.Windows.Forms.ComboBox();
            this.bindPackType = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtFinishProductDescription = new System.Windows.Forms.TextBox();
            this.txtFinishProductAvgCost = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.cmbBasicProduct = new System.Windows.Forms.ComboBox();
            this.BasicProductBinidinSourse = new System.Windows.Forms.BindingSource(this.components);
            this.label25 = new System.Windows.Forms.Label();
            this.gvFinishProduct = new System.Windows.Forms.DataGridView();
            this.bindCategory = new System.Windows.Forms.BindingSource(this.components);
            this.dgvProductListSecondary = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkEnableSec = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDeleteSec = new System.Windows.Forms.Button();
            this.txtPeiceRateSec = new System.Windows.Forms.TextBox();
            this.cmbPackTypeSec = new System.Windows.Forms.ComboBox();
            this.txtPrimaryQty = new System.Windows.Forms.TextBox();
            this.txtDescriptionSec = new System.Windows.Forms.TextBox();
            this.txtPrimaryProductCode = new System.Windows.Forms.TextBox();
            this.txtSecondaryProduct = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bindSecondaryProduct = new System.Windows.Forms.BindingSource(this.components);
            this.bindPackType2 = new System.Windows.Forms.BindingSource(this.components);
            this.bindPrimaryProduct = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvProductListTertiary = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtProductCodeTer = new System.Windows.Forms.TextBox();
            this.txtSecondaryProductCode = new System.Windows.Forms.TextBox();
            this.txtDescriptionTer = new System.Windows.Forms.TextBox();
            this.txtSecondaryQty = new System.Windows.Forms.TextBox();
            this.cmbPackTypeTer = new System.Windows.Forms.ComboBox();
            this.txtPeiceRateTer = new System.Windows.Forms.TextBox();
            this.chkEnableTer = new System.Windows.Forms.CheckBox();
            this.btnDeleteTer = new System.Windows.Forms.Button();
            this.btnSaveTer = new System.Windows.Forms.Button();
            this.ColBasicProductCode1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFinishProductPackingID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFinishProductCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFinishProductDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFinishProductBasicQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPacking = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFinishProductAvgCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFinishProductStatus = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bindTertiaryProduct = new System.Windows.Forms.BindingSource(this.components);
            this.bindPackType3 = new System.Windows.Forms.BindingSource(this.components);
            this.TertiaryProductCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescriptionTer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SecondaryQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PackingTer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OutsourceRateTer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrimaryQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PackingSec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OutsourceRateSec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bindPackType)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BasicProductBinidinSourse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvFinishProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductListSecondary)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindSecondaryProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindPackType2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindPrimaryProduct)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductListTertiary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindTertiaryProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindPackType3)).BeginInit();
            this.SuspendLayout();
            // 
            // txtProductCode
            // 
            this.txtProductCode.Location = new System.Drawing.Point(162, 25);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.Size = new System.Drawing.Size(150, 20);
            this.txtProductCode.TabIndex = 118;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(73, 29);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(81, 13);
            this.label36.TabIndex = 119;
            this.label36.Text = "Product Code : ";
            // 
            // chkEnablePr
            // 
            this.chkEnablePr.AutoSize = true;
            this.chkEnablePr.Checked = true;
            this.chkEnablePr.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEnablePr.Location = new System.Drawing.Point(367, 25);
            this.chkEnablePr.Name = "chkEnablePr";
            this.chkEnablePr.Size = new System.Drawing.Size(59, 17);
            this.chkEnablePr.TabIndex = 104;
            this.chkEnablePr.Text = "Enable";
            this.chkEnablePr.UseVisualStyleBackColor = true;
            // 
            // btnDeleteFinishProduct
            // 
            this.btnDeleteFinishProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteFinishProduct.Location = new System.Drawing.Point(367, 81);
            this.btnDeleteFinishProduct.Name = "btnDeleteFinishProduct";
            this.btnDeleteFinishProduct.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteFinishProduct.TabIndex = 8;
            this.btnDeleteFinishProduct.Text = "Delete";
            this.btnDeleteFinishProduct.UseVisualStyleBackColor = true;
            this.btnDeleteFinishProduct.Click += new System.EventHandler(this.btnDeleteFinishProduct_Click);
            // 
            // btnAddFinishProduct
            // 
            this.btnAddFinishProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddFinishProduct.Location = new System.Drawing.Point(367, 114);
            this.btnAddFinishProduct.Name = "btnAddFinishProduct";
            this.btnAddFinishProduct.Size = new System.Drawing.Size(75, 23);
            this.btnAddFinishProduct.TabIndex = 6;
            this.btnAddFinishProduct.Text = "Save";
            this.btnAddFinishProduct.UseVisualStyleBackColor = true;
            this.btnAddFinishProduct.Click += new System.EventHandler(this.btnAddFinishProduct_Click);
            // 
            // txtBasicProductQty
            // 
            this.txtBasicProductQty.Location = new System.Drawing.Point(162, 69);
            this.txtBasicProductQty.Name = "txtBasicProductQty";
            this.txtBasicProductQty.Size = new System.Drawing.Size(150, 20);
            this.txtBasicProductQty.TabIndex = 3;
            this.txtBasicProductQty.Text = "0.00";
            this.txtBasicProductQty.Validated += new System.EventHandler(this.txtBasicProductQty_Validated);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(30, 74);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(124, 13);
            this.label23.TabIndex = 117;
            this.label23.Text = "Basic Product Quantity : ";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(87, 95);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(68, 13);
            this.label24.TabIndex = 114;
            this.label24.Text = "Pack Type : ";
            // 
            // cmbPackType
            // 
            this.cmbPackType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbPackType.DisplayMember = "Packing";
            this.cmbPackType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPackType.FormattingEnabled = true;
            this.cmbPackType.Location = new System.Drawing.Point(162, 91);
            this.cmbPackType.Name = "cmbPackType";
            this.cmbPackType.Size = new System.Drawing.Size(153, 21);
            this.cmbPackType.TabIndex = 4;
            this.cmbPackType.ValueMember = "PackingID";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtProductCode);
            this.groupBox5.Controls.Add(this.label36);
            this.groupBox5.Controls.Add(this.chkEnablePr);
            this.groupBox5.Controls.Add(this.btnDeleteFinishProduct);
            this.groupBox5.Controls.Add(this.btnAddFinishProduct);
            this.groupBox5.Controls.Add(this.txtBasicProductQty);
            this.groupBox5.Controls.Add(this.label23);
            this.groupBox5.Controls.Add(this.label24);
            this.groupBox5.Controls.Add(this.cmbPackType);
            this.groupBox5.Controls.Add(this.txtFinishProductDescription);
            this.groupBox5.Controls.Add(this.txtFinishProductAvgCost);
            this.groupBox5.Controls.Add(this.label26);
            this.groupBox5.Controls.Add(this.label27);
            this.groupBox5.Location = new System.Drawing.Point(12, 33);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(448, 151);
            this.groupBox5.TabIndex = 110;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Primary Product Details";
            // 
            // txtFinishProductDescription
            // 
            this.txtFinishProductDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFinishProductDescription.Location = new System.Drawing.Point(162, 47);
            this.txtFinishProductDescription.Name = "txtFinishProductDescription";
            this.txtFinishProductDescription.Size = new System.Drawing.Size(208, 20);
            this.txtFinishProductDescription.TabIndex = 2;
            // 
            // txtFinishProductAvgCost
            // 
            this.txtFinishProductAvgCost.Location = new System.Drawing.Point(162, 117);
            this.txtFinishProductAvgCost.Name = "txtFinishProductAvgCost";
            this.txtFinishProductAvgCost.Size = new System.Drawing.Size(150, 20);
            this.txtFinishProductAvgCost.TabIndex = 5;
            this.txtFinishProductAvgCost.Text = "0.00";
            this.txtFinishProductAvgCost.Validated += new System.EventHandler(this.txtFinishProductAvgCost_Validated);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(86, 51);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(69, 13);
            this.label26.TabIndex = 105;
            this.label26.Text = "Description : ";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(85, 118);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(69, 13);
            this.label27.TabIndex = 104;
            this.label27.Text = "Peice Rate : ";
            // 
            // cmbBasicProduct
            // 
            this.cmbBasicProduct.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbBasicProduct.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbBasicProduct.DisplayMember = "Code";
            this.cmbBasicProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBasicProduct.FormattingEnabled = true;
            this.cmbBasicProduct.Location = new System.Drawing.Point(125, 4);
            this.cmbBasicProduct.Name = "cmbBasicProduct";
            this.cmbBasicProduct.Size = new System.Drawing.Size(322, 23);
            this.cmbBasicProduct.TabIndex = 0;
            this.cmbBasicProduct.ValueMember = "BasicProductCode";
            this.cmbBasicProduct.SelectedIndexChanged += new System.EventHandler(this.cmbBasicProduct_SelectedIndexChanged);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(12, 12);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(107, 15);
            this.label25.TabIndex = 111;
            this.label25.Text = "Basic Product : ";
            // 
            // gvFinishProduct
            // 
            this.gvFinishProduct.AllowUserToAddRows = false;
            this.gvFinishProduct.AllowUserToDeleteRows = false;
            this.gvFinishProduct.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gvFinishProduct.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gvFinishProduct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvFinishProduct.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvFinishProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gvFinishProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvFinishProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColBasicProductCode1,
            this.ColFinishProductPackingID,
            this.ColFinishProductCode,
            this.ColFinishProductDescription,
            this.ColFinishProductBasicQty,
            this.ColPacking,
            this.ColFinishProductAvgCost,
            this.ColFinishProductStatus});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvFinishProduct.DefaultCellStyle = dataGridViewCellStyle5;
            this.gvFinishProduct.Location = new System.Drawing.Point(466, 4);
            this.gvFinishProduct.MultiSelect = false;
            this.gvFinishProduct.Name = "gvFinishProduct";
            this.gvFinishProduct.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.gvFinishProduct.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.gvFinishProduct.RowHeadersVisible = false;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvFinishProduct.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.gvFinishProduct.RowTemplate.Height = 15;
            this.gvFinishProduct.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gvFinishProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvFinishProduct.Size = new System.Drawing.Size(500, 180);
            this.gvFinishProduct.TabIndex = 58;
            this.gvFinishProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvFinishProduct_CellClick);
            // 
            // dgvProductListSecondary
            // 
            this.dgvProductListSecondary.AllowUserToAddRows = false;
            this.dgvProductListSecondary.AllowUserToDeleteRows = false;
            this.dgvProductListSecondary.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProductListSecondary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductListSecondary.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductCode,
            this.colSDescription,
            this.PrimaryQty,
            this.PackingSec,
            this.OutsourceRateSec});
            this.dgvProductListSecondary.Location = new System.Drawing.Point(466, 199);
            this.dgvProductListSecondary.Name = "dgvProductListSecondary";
            this.dgvProductListSecondary.ReadOnly = true;
            this.dgvProductListSecondary.Size = new System.Drawing.Size(500, 218);
            this.dgvProductListSecondary.TabIndex = 111;
            this.dgvProductListSecondary.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductListSecondary_CellClick);
            this.dgvProductListSecondary.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductListSecondary_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.chkEnableSec);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnDeleteSec);
            this.groupBox1.Controls.Add(this.txtPeiceRateSec);
            this.groupBox1.Controls.Add(this.cmbPackTypeSec);
            this.groupBox1.Controls.Add(this.txtPrimaryQty);
            this.groupBox1.Controls.Add(this.txtDescriptionSec);
            this.groupBox1.Controls.Add(this.txtPrimaryProductCode);
            this.groupBox1.Controls.Add(this.txtSecondaryProduct);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 190);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(448, 227);
            this.groupBox1.TabIndex = 114;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Secondary Product Details";
            // 
            // chkEnableSec
            // 
            this.chkEnableSec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkEnableSec.AutoSize = true;
            this.chkEnableSec.Checked = true;
            this.chkEnableSec.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEnableSec.Location = new System.Drawing.Point(367, 32);
            this.chkEnableSec.Name = "chkEnableSec";
            this.chkEnableSec.Size = new System.Drawing.Size(59, 17);
            this.chkEnableSec.TabIndex = 128;
            this.chkEnableSec.Text = "Enable";
            this.chkEnableSec.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(367, 133);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 127;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDeleteSec
            // 
            this.btnDeleteSec.Location = new System.Drawing.Point(367, 105);
            this.btnDeleteSec.Name = "btnDeleteSec";
            this.btnDeleteSec.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteSec.TabIndex = 126;
            this.btnDeleteSec.Text = "Delete";
            this.btnDeleteSec.UseVisualStyleBackColor = true;
            this.btnDeleteSec.Click += new System.EventHandler(this.btnDeleteSec_Click);
            // 
            // txtPeiceRateSec
            // 
            this.txtPeiceRateSec.Location = new System.Drawing.Point(161, 143);
            this.txtPeiceRateSec.Name = "txtPeiceRateSec";
            this.txtPeiceRateSec.Size = new System.Drawing.Size(134, 20);
            this.txtPeiceRateSec.TabIndex = 125;
            // 
            // cmbPackTypeSec
            // 
            this.cmbPackTypeSec.DisplayMember = "Packing";
            this.cmbPackTypeSec.FormattingEnabled = true;
            this.cmbPackTypeSec.Location = new System.Drawing.Point(161, 120);
            this.cmbPackTypeSec.Name = "cmbPackTypeSec";
            this.cmbPackTypeSec.Size = new System.Drawing.Size(134, 21);
            this.cmbPackTypeSec.TabIndex = 124;
            this.cmbPackTypeSec.ValueMember = "PackingID";
            // 
            // txtPrimaryQty
            // 
            this.txtPrimaryQty.Location = new System.Drawing.Point(161, 98);
            this.txtPrimaryQty.Name = "txtPrimaryQty";
            this.txtPrimaryQty.Size = new System.Drawing.Size(134, 20);
            this.txtPrimaryQty.TabIndex = 123;
            // 
            // txtDescriptionSec
            // 
            this.txtDescriptionSec.Location = new System.Drawing.Point(161, 76);
            this.txtDescriptionSec.Name = "txtDescriptionSec";
            this.txtDescriptionSec.Size = new System.Drawing.Size(266, 20);
            this.txtDescriptionSec.TabIndex = 122;
            // 
            // txtPrimaryProductCode
            // 
            this.txtPrimaryProductCode.Location = new System.Drawing.Point(161, 54);
            this.txtPrimaryProductCode.Name = "txtPrimaryProductCode";
            this.txtPrimaryProductCode.ReadOnly = true;
            this.txtPrimaryProductCode.Size = new System.Drawing.Size(134, 20);
            this.txtPrimaryProductCode.TabIndex = 121;
            // 
            // txtSecondaryProduct
            // 
            this.txtSecondaryProduct.Location = new System.Drawing.Point(161, 32);
            this.txtSecondaryProduct.Name = "txtSecondaryProduct";
            this.txtSecondaryProduct.Size = new System.Drawing.Size(134, 20);
            this.txtSecondaryProduct.TabIndex = 120;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(77, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 119;
            this.label6.Text = "Product Code: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 119;
            this.label5.Text = "Primary Product : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 104;
            this.label1.Text = "Peice Rate : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 105;
            this.label2.Text = "Description : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 114;
            this.label3.Text = "Pack Type : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 13);
            this.label4.TabIndex = 117;
            this.label4.Text = "Primary Product Quantity : ";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.btnSaveTer);
            this.groupBox2.Controls.Add(this.btnDeleteTer);
            this.groupBox2.Controls.Add(this.chkEnableTer);
            this.groupBox2.Controls.Add(this.txtPeiceRateTer);
            this.groupBox2.Controls.Add(this.cmbPackTypeTer);
            this.groupBox2.Controls.Add(this.txtSecondaryQty);
            this.groupBox2.Controls.Add(this.txtDescriptionTer);
            this.groupBox2.Controls.Add(this.txtSecondaryProductCode);
            this.groupBox2.Controls.Add(this.txtProductCodeTer);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Location = new System.Drawing.Point(12, 423);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(448, 169);
            this.groupBox2.TabIndex = 115;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tertiary Product Deatils";
            // 
            // dgvProductListTertiary
            // 
            this.dgvProductListTertiary.AllowUserToAddRows = false;
            this.dgvProductListTertiary.AllowUserToDeleteRows = false;
            this.dgvProductListTertiary.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProductListTertiary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductListTertiary.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TertiaryProductCode,
            this.DescriptionTer,
            this.SecondaryQty,
            this.PackingTer,
            this.OutsourceRateTer});
            this.dgvProductListTertiary.Location = new System.Drawing.Point(466, 423);
            this.dgvProductListTertiary.Name = "dgvProductListTertiary";
            this.dgvProductListTertiary.ReadOnly = true;
            this.dgvProductListTertiary.Size = new System.Drawing.Size(500, 169);
            this.dgvProductListTertiary.TabIndex = 116;
            this.dgvProductListTertiary.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductListTertiary_CellClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 13);
            this.label7.TabIndex = 117;
            this.label7.Text = "Secondary Product Quantity : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(88, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 114;
            this.label8.Text = "Pack Type : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(87, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 105;
            this.label9.Text = "Description : ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(86, 138);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 13);
            this.label10.TabIndex = 104;
            this.label10.Text = "Peice Rate : ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(49, 51);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 13);
            this.label11.TabIndex = 119;
            this.label11.Text = "Secondary Product : ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(78, 28);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 13);
            this.label12.TabIndex = 119;
            this.label12.Text = "Product Code: ";
            // 
            // txtProductCodeTer
            // 
            this.txtProductCodeTer.Location = new System.Drawing.Point(162, 21);
            this.txtProductCodeTer.Name = "txtProductCodeTer";
            this.txtProductCodeTer.Size = new System.Drawing.Size(134, 20);
            this.txtProductCodeTer.TabIndex = 120;
            // 
            // txtSecondaryProductCode
            // 
            this.txtSecondaryProductCode.Location = new System.Drawing.Point(162, 44);
            this.txtSecondaryProductCode.Name = "txtSecondaryProductCode";
            this.txtSecondaryProductCode.ReadOnly = true;
            this.txtSecondaryProductCode.Size = new System.Drawing.Size(134, 20);
            this.txtSecondaryProductCode.TabIndex = 121;
            // 
            // txtDescriptionTer
            // 
            this.txtDescriptionTer.Location = new System.Drawing.Point(162, 64);
            this.txtDescriptionTer.Name = "txtDescriptionTer";
            this.txtDescriptionTer.Size = new System.Drawing.Size(266, 20);
            this.txtDescriptionTer.TabIndex = 122;
            // 
            // txtSecondaryQty
            // 
            this.txtSecondaryQty.Location = new System.Drawing.Point(162, 86);
            this.txtSecondaryQty.Name = "txtSecondaryQty";
            this.txtSecondaryQty.Size = new System.Drawing.Size(134, 20);
            this.txtSecondaryQty.TabIndex = 123;
            // 
            // cmbPackTypeTer
            // 
            this.cmbPackTypeTer.DisplayMember = "Packing";
            this.cmbPackTypeTer.FormattingEnabled = true;
            this.cmbPackTypeTer.Location = new System.Drawing.Point(162, 108);
            this.cmbPackTypeTer.Name = "cmbPackTypeTer";
            this.cmbPackTypeTer.Size = new System.Drawing.Size(134, 21);
            this.cmbPackTypeTer.TabIndex = 124;
            this.cmbPackTypeTer.ValueMember = "PackingID";
            // 
            // txtPeiceRateTer
            // 
            this.txtPeiceRateTer.Location = new System.Drawing.Point(161, 135);
            this.txtPeiceRateTer.Name = "txtPeiceRateTer";
            this.txtPeiceRateTer.Size = new System.Drawing.Size(135, 20);
            this.txtPeiceRateTer.TabIndex = 125;
            // 
            // chkEnableTer
            // 
            this.chkEnableTer.AutoSize = true;
            this.chkEnableTer.Checked = true;
            this.chkEnableTer.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEnableTer.Location = new System.Drawing.Point(367, 23);
            this.chkEnableTer.Name = "chkEnableTer";
            this.chkEnableTer.Size = new System.Drawing.Size(59, 17);
            this.chkEnableTer.TabIndex = 129;
            this.chkEnableTer.Text = "Enable";
            this.chkEnableTer.UseVisualStyleBackColor = true;
            // 
            // btnDeleteTer
            // 
            this.btnDeleteTer.Location = new System.Drawing.Point(360, 103);
            this.btnDeleteTer.Name = "btnDeleteTer";
            this.btnDeleteTer.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteTer.TabIndex = 130;
            this.btnDeleteTer.Text = "Delete";
            this.btnDeleteTer.UseVisualStyleBackColor = true;
            this.btnDeleteTer.Click += new System.EventHandler(this.btnDeleteTer_Click);
            // 
            // btnSaveTer
            // 
            this.btnSaveTer.Location = new System.Drawing.Point(360, 132);
            this.btnSaveTer.Name = "btnSaveTer";
            this.btnSaveTer.Size = new System.Drawing.Size(75, 23);
            this.btnSaveTer.TabIndex = 131;
            this.btnSaveTer.Text = "Save";
            this.btnSaveTer.UseVisualStyleBackColor = true;
            this.btnSaveTer.Click += new System.EventHandler(this.btnSaveTer_Click);
            // 
            // ColBasicProductCode1
            // 
            this.ColBasicProductCode1.DataPropertyName = "BasicProductCode";
            this.ColBasicProductCode1.HeaderText = "BasicProductCode";
            this.ColBasicProductCode1.Name = "ColBasicProductCode1";
            this.ColBasicProductCode1.ReadOnly = true;
            this.ColBasicProductCode1.Visible = false;
            // 
            // ColFinishProductPackingID
            // 
            this.ColFinishProductPackingID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColFinishProductPackingID.DataPropertyName = "FinishProdutPackingTypeID";
            this.ColFinishProductPackingID.HeaderText = "FinishProductPackingID";
            this.ColFinishProductPackingID.Name = "ColFinishProductPackingID";
            this.ColFinishProductPackingID.ReadOnly = true;
            this.ColFinishProductPackingID.Visible = false;
            // 
            // ColFinishProductCode
            // 
            this.ColFinishProductCode.DataPropertyName = "FinishProductCode";
            this.ColFinishProductCode.HeaderText = "Product Code";
            this.ColFinishProductCode.Name = "ColFinishProductCode";
            this.ColFinishProductCode.ReadOnly = true;
            // 
            // ColFinishProductDescription
            // 
            this.ColFinishProductDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColFinishProductDescription.DataPropertyName = "FinishProdutDescription";
            this.ColFinishProductDescription.HeaderText = "Description";
            this.ColFinishProductDescription.MinimumWidth = 120;
            this.ColFinishProductDescription.Name = "ColFinishProductDescription";
            this.ColFinishProductDescription.ReadOnly = true;
            // 
            // ColFinishProductBasicQty
            // 
            this.ColFinishProductBasicQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ColFinishProductBasicQty.DataPropertyName = "FinishProdutBasicQty";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ColFinishProductBasicQty.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColFinishProductBasicQty.HeaderText = "Basic Qty";
            this.ColFinishProductBasicQty.Name = "ColFinishProductBasicQty";
            this.ColFinishProductBasicQty.ReadOnly = true;
            this.ColFinishProductBasicQty.Width = 77;
            // 
            // ColPacking
            // 
            this.ColPacking.DataPropertyName = "Packing";
            this.ColPacking.HeaderText = "Packaging";
            this.ColPacking.Name = "ColPacking";
            this.ColPacking.ReadOnly = true;
            // 
            // ColFinishProductAvgCost
            // 
            this.ColFinishProductAvgCost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ColFinishProductAvgCost.DataPropertyName = "FinishProdutAvgCost";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ColFinishProductAvgCost.DefaultCellStyle = dataGridViewCellStyle4;
            this.ColFinishProductAvgCost.HeaderText = "Outsource Rate (Rs.)";
            this.ColFinishProductAvgCost.Name = "ColFinishProductAvgCost";
            this.ColFinishProductAvgCost.ReadOnly = true;
            this.ColFinishProductAvgCost.Width = 101;
            // 
            // ColFinishProductStatus
            // 
            this.ColFinishProductStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ColFinishProductStatus.DataPropertyName = "FinishProdutStatus";
            this.ColFinishProductStatus.HeaderText = "Status";
            this.ColFinishProductStatus.Name = "ColFinishProductStatus";
            this.ColFinishProductStatus.ReadOnly = true;
            this.ColFinishProductStatus.Width = 43;
            // 
            // TertiaryProductCode
            // 
            this.TertiaryProductCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TertiaryProductCode.DataPropertyName = "FinishProductCode";
            this.TertiaryProductCode.HeaderText = "ProductCode";
            this.TertiaryProductCode.Name = "TertiaryProductCode";
            this.TertiaryProductCode.ReadOnly = true;
            this.TertiaryProductCode.Visible = false;
            // 
            // DescriptionTer
            // 
            this.DescriptionTer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DescriptionTer.DataPropertyName = "FinishProdutDescription";
            this.DescriptionTer.FillWeight = 150F;
            this.DescriptionTer.HeaderText = "Description";
            this.DescriptionTer.Name = "DescriptionTer";
            this.DescriptionTer.ReadOnly = true;
            // 
            // SecondaryQty
            // 
            this.SecondaryQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SecondaryQty.DataPropertyName = "PrimaryFinishProductQty";
            this.SecondaryQty.HeaderText = "SecondaryQty";
            this.SecondaryQty.Name = "SecondaryQty";
            this.SecondaryQty.ReadOnly = true;
            // 
            // PackingTer
            // 
            this.PackingTer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PackingTer.DataPropertyName = "Packing";
            this.PackingTer.HeaderText = "Packaging";
            this.PackingTer.Name = "PackingTer";
            this.PackingTer.ReadOnly = true;
            // 
            // OutsourceRateTer
            // 
            this.OutsourceRateTer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.OutsourceRateTer.DataPropertyName = "FinishProdutAvgCost";
            this.OutsourceRateTer.HeaderText = "OutsourceRate (Rs.)";
            this.OutsourceRateTer.Name = "OutsourceRateTer";
            this.OutsourceRateTer.ReadOnly = true;
            // 
            // ProductCode
            // 
            this.ProductCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductCode.DataPropertyName = "FinishProductCode";
            this.ProductCode.HeaderText = "PoroductCode";
            this.ProductCode.Name = "ProductCode";
            this.ProductCode.ReadOnly = true;
            this.ProductCode.Visible = false;
            // 
            // colSDescription
            // 
            this.colSDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colSDescription.DataPropertyName = "FinishProdutDescription";
            this.colSDescription.HeaderText = "Description";
            this.colSDescription.Name = "colSDescription";
            this.colSDescription.ReadOnly = true;
            // 
            // PrimaryQty
            // 
            this.PrimaryQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PrimaryQty.DataPropertyName = "PrimaryFinishProductQty";
            this.PrimaryQty.FillWeight = 50F;
            this.PrimaryQty.HeaderText = "Primary Qty";
            this.PrimaryQty.Name = "PrimaryQty";
            this.PrimaryQty.ReadOnly = true;
            // 
            // PackingSec
            // 
            this.PackingSec.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PackingSec.DataPropertyName = "Packing";
            this.PackingSec.HeaderText = "Packaging";
            this.PackingSec.Name = "PackingSec";
            this.PackingSec.ReadOnly = true;
            // 
            // OutsourceRateSec
            // 
            this.OutsourceRateSec.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.OutsourceRateSec.DataPropertyName = "FinishProdutAvgCost";
            this.OutsourceRateSec.HeaderText = "OutsourceRate (Rs.)";
            this.OutsourceRateSec.Name = "OutsourceRateSec";
            this.OutsourceRateSec.ReadOnly = true;
            // 
            // frmFinishedProductRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 604);
            this.Controls.Add(this.dgvProductListTertiary);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvProductListSecondary);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.gvFinishProduct);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.cmbBasicProduct);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFinishedProductRegistration";
            this.Text = "Product Registration";
            this.Load += new System.EventHandler(this.frmProductRegistration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindPackType)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BasicProductBinidinSourse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvFinishProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductListSecondary)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindSecondaryProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindPackType2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindPrimaryProduct)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductListTertiary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindTertiaryProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindPackType3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtProductCode;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.CheckBox chkEnablePr;
        private System.Windows.Forms.Button btnDeleteFinishProduct;
        private System.Windows.Forms.Button btnAddFinishProduct;
        private System.Windows.Forms.TextBox txtBasicProductQty;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.ComboBox cmbPackType;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox cmbBasicProduct;
        private System.Windows.Forms.BindingSource BasicProductBinidinSourse;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtFinishProductDescription;
        private System.Windows.Forms.TextBox txtFinishProductAvgCost;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.DataGridView gvFinishProduct;
        private System.Windows.Forms.BindingSource bindPackType;
        private System.Windows.Forms.BindingSource bindCategory;
        private System.Windows.Forms.DataGridView dgvProductListSecondary;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource bindSecondaryProduct;
        private System.Windows.Forms.TextBox txtPrimaryProductCode;
        private System.Windows.Forms.TextBox txtSecondaryProduct;
        private System.Windows.Forms.TextBox txtPeiceRateSec;
        private System.Windows.Forms.ComboBox cmbPackTypeSec;
        private System.Windows.Forms.TextBox txtPrimaryQty;
        private System.Windows.Forms.TextBox txtDescriptionSec;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDeleteSec;
        private System.Windows.Forms.BindingSource bindPackType2;
        private System.Windows.Forms.BindingSource bindPrimaryProduct;
        private System.Windows.Forms.CheckBox chkEnableSec;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvProductListTertiary;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtPeiceRateTer;
        private System.Windows.Forms.ComboBox cmbPackTypeTer;
        private System.Windows.Forms.TextBox txtSecondaryQty;
        private System.Windows.Forms.TextBox txtDescriptionTer;
        private System.Windows.Forms.TextBox txtSecondaryProductCode;
        private System.Windows.Forms.TextBox txtProductCodeTer;
        private System.Windows.Forms.Button btnSaveTer;
        private System.Windows.Forms.Button btnDeleteTer;
        private System.Windows.Forms.CheckBox chkEnableTer;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColBasicProductCode1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFinishProductPackingID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFinishProductCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFinishProductDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFinishProductBasicQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPacking;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFinishProductAvgCost;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColFinishProductStatus;
        private System.Windows.Forms.BindingSource bindTertiaryProduct;
        private System.Windows.Forms.BindingSource bindPackType3;
        private System.Windows.Forms.DataGridViewTextBoxColumn TertiaryProductCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescriptionTer;
        private System.Windows.Forms.DataGridViewTextBoxColumn SecondaryQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn PackingTer;
        private System.Windows.Forms.DataGridViewTextBoxColumn OutsourceRateTer;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrimaryQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn PackingSec;
        private System.Windows.Forms.DataGridViewTextBoxColumn OutsourceRateSec;

    }
}