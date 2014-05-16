namespace MRP_GUI
{
    partial class frmMaterialRegistration
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMaterialRegistration));
            this.label9 = new System.Windows.Forms.Label();
            this.cmbMainType = new System.Windows.Forms.ComboBox();
            this.pblBasic2 = new System.Windows.Forms.Panel();
            this.rdbGreen = new System.Windows.Forms.RadioButton();
            this.rdbDry = new System.Windows.Forms.RadioButton();
            this.cmbToMonth = new System.Windows.Forms.ComboBox();
            this.cmbFromMonth = new System.Windows.Forms.ComboBox();
            this.label32 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.cbMaterialLocal = new System.Windows.Forms.CheckBox();
            this.cbMaterialImport = new System.Windows.Forms.CheckBox();
            this.cbMaterialSeasonal = new System.Windows.Forms.CheckBox();
            this.pnlInter = new System.Windows.Forms.Panel();
            this.lblMaterialBasicMaterialUnit = new System.Windows.Forms.Label();
            this.txtMaterialBasicPartialSize = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMaterialQtyPerUnit = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbMaterialBasicMaterial = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlMaterial = new System.Windows.Forms.Panel();
            this.txtMaterialCode = new System.Windows.Forms.MaskedTextBox();
            this.txtAcgUnitCost = new System.Windows.Forms.TextBox();
            this.label63 = new System.Windows.Forms.Label();
            this.cmbMaterialUnit = new System.Windows.Forms.ComboBox();
            this.label30 = new System.Windows.Forms.Label();
            this.cmbMaterialForm = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbMaterialType = new System.Windows.Forms.ComboBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtmaterialName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnMaterialClear = new System.Windows.Forms.Button();
            this.btnMaterialDelete = new System.Windows.Forms.Button();
            this.btnMaterialSave = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbLab = new System.Windows.Forms.RadioButton();
            this.rdbPacking = new System.Windows.Forms.RadioButton();
            this.rdbRaw = new System.Windows.Forms.RadioButton();
            this.gvMaterialList = new System.Windows.Forms.DataGridView();
            this.ColMaterialCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMaterialName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMatMainType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMaterialCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMaterialType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMaterialForm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMaterialUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAVGCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColBasicMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColBasicQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColParticalSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColLocal = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColImport = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColSeasonal = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColSeasanFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSeasanTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMatCatID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMatSubCatID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMatTypeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColItemFormID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColUnitID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindMaterials = new System.Windows.Forms.BindingSource(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.bindCategory = new System.Windows.Forms.BindingSource(this.components);
            this.bindMainCategory = new System.Windows.Forms.BindingSource(this.components);
            this.bindSubCat1 = new System.Windows.Forms.BindingSource(this.components);
            this.bindSubCat2 = new System.Windows.Forms.BindingSource(this.components);
            this.bindBasicMaterials = new System.Windows.Forms.BindingSource(this.components);
            this.objsourceMaterialBasic = new System.Windows.Forms.BindingSource(this.components);
            this.pnlBasic1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pblBasic2.SuspendLayout();
            this.pnlInter.SuspendLayout();
            this.pnlMaterial.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvMaterialList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindMaterials)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindMainCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindSubCat1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindSubCat2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindBasicMaterials)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objsourceMaterialBasic)).BeginInit();
            this.pnlBasic1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 111;
            this.label9.Text = "Type";
            // 
            // cmbMainType
            // 
            this.cmbMainType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMainType.FormattingEnabled = true;
            this.cmbMainType.Items.AddRange(new object[] {
            "Basic",
            "Intermediate",
            "Processed"});
            this.cmbMainType.Location = new System.Drawing.Point(61, 22);
            this.cmbMainType.Name = "cmbMainType";
            this.cmbMainType.Size = new System.Drawing.Size(140, 21);
            this.cmbMainType.TabIndex = 110;
            this.cmbMainType.SelectedIndexChanged += new System.EventHandler(this.cmbMainType_SelectedIndexChanged);
            // 
            // pblBasic2
            // 
            this.pblBasic2.Controls.Add(this.cmbToMonth);
            this.pblBasic2.Controls.Add(this.cmbFromMonth);
            this.pblBasic2.Controls.Add(this.label32);
            this.pblBasic2.Controls.Add(this.label31);
            this.pblBasic2.Controls.Add(this.cbMaterialSeasonal);
            this.pblBasic2.Location = new System.Drawing.Point(448, 61);
            this.pblBasic2.Name = "pblBasic2";
            this.pblBasic2.Size = new System.Drawing.Size(351, 34);
            this.pblBasic2.TabIndex = 4;
            // 
            // rdbGreen
            // 
            this.rdbGreen.AutoSize = true;
            this.rdbGreen.Location = new System.Drawing.Point(74, 7);
            this.rdbGreen.Name = "rdbGreen";
            this.rdbGreen.Size = new System.Drawing.Size(54, 17);
            this.rdbGreen.TabIndex = 102;
            this.rdbGreen.TabStop = true;
            this.rdbGreen.Text = "Green";
            this.rdbGreen.UseVisualStyleBackColor = true;
            // 
            // rdbDry
            // 
            this.rdbDry.AutoSize = true;
            this.rdbDry.Location = new System.Drawing.Point(21, 7);
            this.rdbDry.Name = "rdbDry";
            this.rdbDry.Size = new System.Drawing.Size(41, 17);
            this.rdbDry.TabIndex = 102;
            this.rdbDry.TabStop = true;
            this.rdbDry.Text = "Dry";
            this.rdbDry.UseVisualStyleBackColor = true;
            // 
            // cmbToMonth
            // 
            this.cmbToMonth.AutoCompleteCustomSource.AddRange(new string[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.cmbToMonth.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbToMonth.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbToMonth.Enabled = false;
            this.cmbToMonth.FormattingEnabled = true;
            this.cmbToMonth.Items.AddRange(new object[] {
            "Any",
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.cmbToMonth.Location = new System.Drawing.Point(255, 5);
            this.cmbToMonth.Name = "cmbToMonth";
            this.cmbToMonth.Size = new System.Drawing.Size(93, 21);
            this.cmbToMonth.TabIndex = 2;
            this.cmbToMonth.Text = "-- Select Month --";
            // 
            // cmbFromMonth
            // 
            this.cmbFromMonth.AutoCompleteCustomSource.AddRange(new string[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.cmbFromMonth.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbFromMonth.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbFromMonth.Enabled = false;
            this.cmbFromMonth.FormattingEnabled = true;
            this.cmbFromMonth.Items.AddRange(new object[] {
            "Any",
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.cmbFromMonth.Location = new System.Drawing.Point(115, 5);
            this.cmbFromMonth.Name = "cmbFromMonth";
            this.cmbFromMonth.Size = new System.Drawing.Size(107, 21);
            this.cmbFromMonth.TabIndex = 1;
            this.cmbFromMonth.Text = "-- Select Month --";
            // 
            // label32
            // 
            this.label32.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(79, 12);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(30, 13);
            this.label32.TabIndex = 101;
            this.label32.Text = "From";
            // 
            // label31
            // 
            this.label31.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(229, 9);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(20, 13);
            this.label31.TabIndex = 100;
            this.label31.Text = "To";
            // 
            // cbMaterialLocal
            // 
            this.cbMaterialLocal.AutoSize = true;
            this.cbMaterialLocal.Location = new System.Drawing.Point(287, 8);
            this.cbMaterialLocal.Name = "cbMaterialLocal";
            this.cbMaterialLocal.Size = new System.Drawing.Size(52, 17);
            this.cbMaterialLocal.TabIndex = 4;
            this.cbMaterialLocal.Text = "Local";
            this.cbMaterialLocal.UseVisualStyleBackColor = true;
            // 
            // cbMaterialImport
            // 
            this.cbMaterialImport.AutoSize = true;
            this.cbMaterialImport.Location = new System.Drawing.Point(226, 7);
            this.cbMaterialImport.Name = "cbMaterialImport";
            this.cbMaterialImport.Size = new System.Drawing.Size(55, 17);
            this.cbMaterialImport.TabIndex = 3;
            this.cbMaterialImport.Text = "Import";
            this.cbMaterialImport.UseVisualStyleBackColor = true;
            // 
            // cbMaterialSeasonal
            // 
            this.cbMaterialSeasonal.AutoSize = true;
            this.cbMaterialSeasonal.Location = new System.Drawing.Point(3, 10);
            this.cbMaterialSeasonal.Name = "cbMaterialSeasonal";
            this.cbMaterialSeasonal.Size = new System.Drawing.Size(70, 17);
            this.cbMaterialSeasonal.TabIndex = 0;
            this.cbMaterialSeasonal.Text = "Seasonal";
            this.cbMaterialSeasonal.UseVisualStyleBackColor = true;
            this.cbMaterialSeasonal.CheckedChanged += new System.EventHandler(this.cbMaterialSeasonal_CheckedChanged);
            // 
            // pnlInter
            // 
            this.pnlInter.Controls.Add(this.lblMaterialBasicMaterialUnit);
            this.pnlInter.Controls.Add(this.txtMaterialBasicPartialSize);
            this.pnlInter.Controls.Add(this.label8);
            this.pnlInter.Controls.Add(this.txtMaterialQtyPerUnit);
            this.pnlInter.Controls.Add(this.label6);
            this.pnlInter.Controls.Add(this.cmbMaterialBasicMaterial);
            this.pnlInter.Controls.Add(this.label1);
            this.pnlInter.Location = new System.Drawing.Point(448, 108);
            this.pnlInter.Name = "pnlInter";
            this.pnlInter.Size = new System.Drawing.Size(432, 94);
            this.pnlInter.TabIndex = 5;
            this.pnlInter.Visible = false;
            // 
            // lblMaterialBasicMaterialUnit
            // 
            this.lblMaterialBasicMaterialUnit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMaterialBasicMaterialUnit.AutoSize = true;
            this.lblMaterialBasicMaterialUnit.Location = new System.Drawing.Point(223, 40);
            this.lblMaterialBasicMaterialUnit.Name = "lblMaterialBasicMaterialUnit";
            this.lblMaterialBasicMaterialUnit.Size = new System.Drawing.Size(0, 13);
            this.lblMaterialBasicMaterialUnit.TabIndex = 3;
            // 
            // txtMaterialBasicPartialSize
            // 
            this.txtMaterialBasicPartialSize.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaterialBasicPartialSize.Location = new System.Drawing.Point(133, 57);
            this.txtMaterialBasicPartialSize.Name = "txtMaterialBasicPartialSize";
            this.txtMaterialBasicPartialSize.Size = new System.Drawing.Size(90, 20);
            this.txtMaterialBasicPartialSize.TabIndex = 2;
            this.txtMaterialBasicPartialSize.Text = "0.00";
            this.txtMaterialBasicPartialSize.Validated += new System.EventHandler(this.txtMaterialBasicPartialSize_Validated);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(57, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 105;
            this.label8.Text = "Partical Size";
            // 
            // txtMaterialQtyPerUnit
            // 
            this.txtMaterialQtyPerUnit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaterialQtyPerUnit.Location = new System.Drawing.Point(133, 36);
            this.txtMaterialQtyPerUnit.Name = "txtMaterialQtyPerUnit";
            this.txtMaterialQtyPerUnit.Size = new System.Drawing.Size(90, 20);
            this.txtMaterialQtyPerUnit.TabIndex = 1;
            this.txtMaterialQtyPerUnit.Text = "0.00";
            this.txtMaterialQtyPerUnit.Validated += new System.EventHandler(this.txtMaterialQtyPerUnit_Validated);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 97;
            this.label6.Text = "Basic Material Qty";
            // 
            // cmbMaterialBasicMaterial
            // 
            this.cmbMaterialBasicMaterial.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbMaterialBasicMaterial.DisplayMember = "Material";
            this.cmbMaterialBasicMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaterialBasicMaterial.FormattingEnabled = true;
            this.cmbMaterialBasicMaterial.Location = new System.Drawing.Point(133, 14);
            this.cmbMaterialBasicMaterial.Name = "cmbMaterialBasicMaterial";
            this.cmbMaterialBasicMaterial.Size = new System.Drawing.Size(272, 21);
            this.cmbMaterialBasicMaterial.TabIndex = 0;
            this.cmbMaterialBasicMaterial.ValueMember = "MaterialCode";
            this.cmbMaterialBasicMaterial.SelectedIndexChanged += new System.EventHandler(this.cmbMaterialBasicMaterial_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 95;
            this.label1.Text = "Basic Material";
            // 
            // pnlMaterial
            // 
            this.pnlMaterial.Controls.Add(this.txtMaterialCode);
            this.pnlMaterial.Controls.Add(this.txtAcgUnitCost);
            this.pnlMaterial.Controls.Add(this.label63);
            this.pnlMaterial.Controls.Add(this.cmbMaterialUnit);
            this.pnlMaterial.Controls.Add(this.label30);
            this.pnlMaterial.Controls.Add(this.cmbMaterialForm);
            this.pnlMaterial.Controls.Add(this.label7);
            this.pnlMaterial.Controls.Add(this.cmbMaterialType);
            this.pnlMaterial.Controls.Add(this.label29);
            this.pnlMaterial.Controls.Add(this.label5);
            this.pnlMaterial.Controls.Add(this.txtmaterialName);
            this.pnlMaterial.Controls.Add(this.label4);
            this.pnlMaterial.Location = new System.Drawing.Point(7, 57);
            this.pnlMaterial.Name = "pnlMaterial";
            this.pnlMaterial.Size = new System.Drawing.Size(427, 145);
            this.pnlMaterial.TabIndex = 3;
            // 
            // txtMaterialCode
            // 
            this.txtMaterialCode.Location = new System.Drawing.Point(96, 9);
            this.txtMaterialCode.Name = "txtMaterialCode";
            this.txtMaterialCode.Size = new System.Drawing.Size(204, 20);
            this.txtMaterialCode.TabIndex = 0;
            // 
            // txtAcgUnitCost
            // 
            this.txtAcgUnitCost.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAcgUnitCost.Location = new System.Drawing.Point(96, 117);
            this.txtAcgUnitCost.Name = "txtAcgUnitCost";
            this.txtAcgUnitCost.Size = new System.Drawing.Size(126, 20);
            this.txtAcgUnitCost.TabIndex = 5;
            this.txtAcgUnitCost.Text = "0.00";
            this.txtAcgUnitCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAcgUnitCost_KeyPress);
            this.txtAcgUnitCost.Validated += new System.EventHandler(this.txtAcgUnitCost_Validated);
            // 
            // label63
            // 
            this.label63.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label63.AutoSize = true;
            this.label63.Location = new System.Drawing.Point(2, 120);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(90, 13);
            this.label63.TabIndex = 102;
            this.label63.Text = "Avg Cost per Unit";
            // 
            // cmbMaterialUnit
            // 
            this.cmbMaterialUnit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbMaterialUnit.DisplayMember = "UnitCode";
            this.cmbMaterialUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaterialUnit.FormattingEnabled = true;
            this.cmbMaterialUnit.Items.AddRange(new object[] {
            "KG",
            "L",
            "BOTTLE",
            "BOX",
            "CAN"});
            this.cmbMaterialUnit.Location = new System.Drawing.Point(96, 95);
            this.cmbMaterialUnit.Name = "cmbMaterialUnit";
            this.cmbMaterialUnit.Size = new System.Drawing.Size(126, 21);
            this.cmbMaterialUnit.TabIndex = 4;
            this.cmbMaterialUnit.ValueMember = "UnitID";
            // 
            // label30
            // 
            this.label30.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(66, 98);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(26, 13);
            this.label30.TabIndex = 99;
            this.label30.Text = "Unit";
            // 
            // cmbMaterialForm
            // 
            this.cmbMaterialForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbMaterialForm.DisplayMember = "Form";
            this.cmbMaterialForm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaterialForm.FormattingEnabled = true;
            this.cmbMaterialForm.Items.AddRange(new object[] {
            "POWDER",
            "LIQUID"});
            this.cmbMaterialForm.Location = new System.Drawing.Point(96, 73);
            this.cmbMaterialForm.Name = "cmbMaterialForm";
            this.cmbMaterialForm.Size = new System.Drawing.Size(204, 21);
            this.cmbMaterialForm.TabIndex = 3;
            this.cmbMaterialForm.ValueMember = "FormID";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(61, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 96;
            this.label7.Text = "Form";
            // 
            // cmbMaterialType
            // 
            this.cmbMaterialType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbMaterialType.DisplayMember = "MaterialType";
            this.cmbMaterialType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaterialType.FormattingEnabled = true;
            this.cmbMaterialType.Items.AddRange(new object[] {
            "CRYSTAL",
            "FLOWERS",
            "FRUITS",
            "PHIZOME",
            "ROOTS",
            "TUBERS",
            "BARK",
            "WHOLE PLANT",
            "SEEDS"});
            this.cmbMaterialType.Location = new System.Drawing.Point(96, 51);
            this.cmbMaterialType.Name = "cmbMaterialType";
            this.cmbMaterialType.Size = new System.Drawing.Size(204, 21);
            this.cmbMaterialType.TabIndex = 2;
            this.cmbMaterialType.ValueMember = "MatType";
            // 
            // label29
            // 
            this.label29.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(61, 54);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(31, 13);
            this.label29.TabIndex = 93;
            this.label29.Text = "Type";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 88;
            this.label5.Text = "Code";
            // 
            // txtmaterialName
            // 
            this.txtmaterialName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtmaterialName.Location = new System.Drawing.Point(96, 30);
            this.txtmaterialName.Name = "txtmaterialName";
            this.txtmaterialName.Size = new System.Drawing.Size(328, 20);
            this.txtmaterialName.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 86;
            this.label4.Text = "Material Name";
            // 
            // btnMaterialClear
            // 
            this.btnMaterialClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaterialClear.Location = new System.Drawing.Point(805, 70);
            this.btnMaterialClear.Name = "btnMaterialClear";
            this.btnMaterialClear.Size = new System.Drawing.Size(75, 23);
            this.btnMaterialClear.TabIndex = 8;
            this.btnMaterialClear.Text = "Clear";
            this.btnMaterialClear.UseVisualStyleBackColor = true;
            this.btnMaterialClear.Click += new System.EventHandler(this.btnMaterialClear_Click);
            // 
            // btnMaterialDelete
            // 
            this.btnMaterialDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaterialDelete.Location = new System.Drawing.Point(805, 41);
            this.btnMaterialDelete.Name = "btnMaterialDelete";
            this.btnMaterialDelete.Size = new System.Drawing.Size(75, 23);
            this.btnMaterialDelete.TabIndex = 7;
            this.btnMaterialDelete.Text = "Delete";
            this.btnMaterialDelete.UseVisualStyleBackColor = true;
            this.btnMaterialDelete.Click += new System.EventHandler(this.btnMaterialDelete_Click);
            // 
            // btnMaterialSave
            // 
            this.btnMaterialSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaterialSave.Location = new System.Drawing.Point(805, 12);
            this.btnMaterialSave.Name = "btnMaterialSave";
            this.btnMaterialSave.Size = new System.Drawing.Size(75, 23);
            this.btnMaterialSave.TabIndex = 6;
            this.btnMaterialSave.Text = "Save";
            this.btnMaterialSave.UseVisualStyleBackColor = true;
            this.btnMaterialSave.Click += new System.EventHandler(this.btnMaterialSave_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.pnlBasic1);
            this.groupBox2.Controls.Add(this.rdbLab);
            this.groupBox2.Controls.Add(this.rdbPacking);
            this.groupBox2.Controls.Add(this.rdbRaw);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.cmbMainType);
            this.groupBox2.Controls.Add(this.pblBasic2);
            this.groupBox2.Controls.Add(this.pnlInter);
            this.groupBox2.Controls.Add(this.pnlMaterial);
            this.groupBox2.Controls.Add(this.btnMaterialClear);
            this.groupBox2.Controls.Add(this.btnMaterialDelete);
            this.groupBox2.Controls.Add(this.btnMaterialSave);
            this.groupBox2.Controls.Add(this.gvMaterialList);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(886, 564);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Material";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // rdbLab
            // 
            this.rdbLab.AutoSize = true;
            this.rdbLab.Location = new System.Drawing.Point(341, 24);
            this.rdbLab.Name = "rdbLab";
            this.rdbLab.Size = new System.Drawing.Size(43, 17);
            this.rdbLab.TabIndex = 115;
            this.rdbLab.TabStop = true;
            this.rdbLab.Text = "Lab";
            this.rdbLab.UseVisualStyleBackColor = true;
            this.rdbLab.CheckedChanged += new System.EventHandler(this.rdbLab_CheckedChanged);
            // 
            // rdbPacking
            // 
            this.rdbPacking.AutoSize = true;
            this.rdbPacking.Location = new System.Drawing.Point(271, 24);
            this.rdbPacking.Name = "rdbPacking";
            this.rdbPacking.Size = new System.Drawing.Size(64, 17);
            this.rdbPacking.TabIndex = 115;
            this.rdbPacking.TabStop = true;
            this.rdbPacking.Text = "Packing";
            this.rdbPacking.UseVisualStyleBackColor = true;
            this.rdbPacking.CheckedChanged += new System.EventHandler(this.rdbPacking_CheckedChanged);
            // 
            // rdbRaw
            // 
            this.rdbRaw.AutoSize = true;
            this.rdbRaw.Location = new System.Drawing.Point(218, 24);
            this.rdbRaw.Name = "rdbRaw";
            this.rdbRaw.Size = new System.Drawing.Size(47, 17);
            this.rdbRaw.TabIndex = 115;
            this.rdbRaw.TabStop = true;
            this.rdbRaw.Text = "Raw";
            this.rdbRaw.UseVisualStyleBackColor = true;
            this.rdbRaw.CheckedChanged += new System.EventHandler(this.rdbRaw_CheckedChanged);
            // 
            // gvMaterialList
            // 
            this.gvMaterialList.AllowUserToAddRows = false;
            this.gvMaterialList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvMaterialList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gvMaterialList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvMaterialList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gvMaterialList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvMaterialList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColMaterialCode,
            this.ColMaterialName,
            this.ColMatMainType,
            this.ColMaterialCategory,
            this.ColMaterialType,
            this.ColMaterialForm,
            this.ColMaterialUnit,
            this.ColAVGCost,
            this.ColBasicMaterial,
            this.ColBasicQty,
            this.ColParticalSize,
            this.ColLocal,
            this.ColImport,
            this.ColSeasonal,
            this.ColSeasanFrom,
            this.ColSeasanTo,
            this.ColMatCatID,
            this.ColMatSubCatID,
            this.ColMatTypeID,
            this.ColItemFormID,
            this.ColUnitID,
            this.ColStatus,
            this.ColMaterial});
            this.gvMaterialList.Location = new System.Drawing.Point(6, 262);
            this.gvMaterialList.MultiSelect = false;
            this.gvMaterialList.Name = "gvMaterialList";
            this.gvMaterialList.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvMaterialList.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.gvMaterialList.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvMaterialList.RowTemplate.Height = 18;
            this.gvMaterialList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvMaterialList.Size = new System.Drawing.Size(874, 296);
            this.gvMaterialList.TabIndex = 1;
            this.gvMaterialList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvMaterialList_CellClick);
            // 
            // ColMaterialCode
            // 
            this.ColMaterialCode.DataPropertyName = "MaterialCode";
            this.ColMaterialCode.Frozen = true;
            this.ColMaterialCode.HeaderText = "Code";
            this.ColMaterialCode.MinimumWidth = 120;
            this.ColMaterialCode.Name = "ColMaterialCode";
            this.ColMaterialCode.ReadOnly = true;
            this.ColMaterialCode.Width = 120;
            // 
            // ColMaterialName
            // 
            this.ColMaterialName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColMaterialName.DataPropertyName = "MaterialDescription";
            this.ColMaterialName.Frozen = true;
            this.ColMaterialName.HeaderText = "Description";
            this.ColMaterialName.MinimumWidth = 150;
            this.ColMaterialName.Name = "ColMaterialName";
            this.ColMaterialName.ReadOnly = true;
            this.ColMaterialName.Width = 150;
            // 
            // ColMatMainType
            // 
            this.ColMatMainType.DataPropertyName = "MatMainType";
            this.ColMatMainType.HeaderText = "Main Type";
            this.ColMatMainType.Name = "ColMatMainType";
            this.ColMatMainType.ReadOnly = true;
            // 
            // ColMaterialCategory
            // 
            this.ColMaterialCategory.DataPropertyName = "MaterialCategory";
            this.ColMaterialCategory.HeaderText = "Main Category";
            this.ColMaterialCategory.Name = "ColMaterialCategory";
            this.ColMaterialCategory.ReadOnly = true;
            // 
            // ColMaterialType
            // 
            this.ColMaterialType.DataPropertyName = "MaterialType";
            this.ColMaterialType.HeaderText = "Type";
            this.ColMaterialType.Name = "ColMaterialType";
            this.ColMaterialType.ReadOnly = true;
            // 
            // ColMaterialForm
            // 
            this.ColMaterialForm.DataPropertyName = "Form";
            this.ColMaterialForm.HeaderText = "Form";
            this.ColMaterialForm.Name = "ColMaterialForm";
            this.ColMaterialForm.ReadOnly = true;
            this.ColMaterialForm.Width = 50;
            // 
            // ColMaterialUnit
            // 
            this.ColMaterialUnit.DataPropertyName = "UnitCode";
            this.ColMaterialUnit.HeaderText = "Unit";
            this.ColMaterialUnit.Name = "ColMaterialUnit";
            this.ColMaterialUnit.ReadOnly = true;
            this.ColMaterialUnit.Width = 50;
            // 
            // ColAVGCost
            // 
            this.ColAVGCost.DataPropertyName = "AVGCost";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ColAVGCost.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColAVGCost.HeaderText = "AVG Cost";
            this.ColAVGCost.Name = "ColAVGCost";
            this.ColAVGCost.ReadOnly = true;
            this.ColAVGCost.Width = 80;
            // 
            // ColBasicMaterial
            // 
            this.ColBasicMaterial.DataPropertyName = "BasicMaterialCode";
            this.ColBasicMaterial.HeaderText = "Basic Code";
            this.ColBasicMaterial.MinimumWidth = 120;
            this.ColBasicMaterial.Name = "ColBasicMaterial";
            this.ColBasicMaterial.ReadOnly = true;
            this.ColBasicMaterial.Width = 120;
            // 
            // ColBasicQty
            // 
            this.ColBasicQty.DataPropertyName = "BasicQty";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ColBasicQty.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColBasicQty.HeaderText = "Basic Qty";
            this.ColBasicQty.Name = "ColBasicQty";
            this.ColBasicQty.ReadOnly = true;
            this.ColBasicQty.Width = 80;
            // 
            // ColParticalSize
            // 
            this.ColParticalSize.DataPropertyName = "ParticalSize";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ColParticalSize.DefaultCellStyle = dataGridViewCellStyle4;
            this.ColParticalSize.HeaderText = "Partical Size";
            this.ColParticalSize.Name = "ColParticalSize";
            this.ColParticalSize.ReadOnly = true;
            // 
            // ColLocal
            // 
            this.ColLocal.DataPropertyName = "Local";
            this.ColLocal.HeaderText = "Local";
            this.ColLocal.Name = "ColLocal";
            this.ColLocal.ReadOnly = true;
            this.ColLocal.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColLocal.Width = 50;
            // 
            // ColImport
            // 
            this.ColImport.DataPropertyName = "Export";
            this.ColImport.HeaderText = "Import";
            this.ColImport.Name = "ColImport";
            this.ColImport.ReadOnly = true;
            this.ColImport.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColImport.Width = 50;
            // 
            // ColSeasonal
            // 
            this.ColSeasonal.DataPropertyName = "Seasanal";
            this.ColSeasonal.HeaderText = "Seasonal";
            this.ColSeasonal.Name = "ColSeasonal";
            this.ColSeasonal.ReadOnly = true;
            this.ColSeasonal.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColSeasonal.Width = 60;
            // 
            // ColSeasanFrom
            // 
            this.ColSeasanFrom.DataPropertyName = "SeasanFrom";
            this.ColSeasanFrom.HeaderText = "SeasanFrom";
            this.ColSeasanFrom.Name = "ColSeasanFrom";
            this.ColSeasanFrom.ReadOnly = true;
            // 
            // ColSeasanTo
            // 
            this.ColSeasanTo.DataPropertyName = "SeasanTo";
            this.ColSeasanTo.HeaderText = "SeasanTo";
            this.ColSeasanTo.Name = "ColSeasanTo";
            this.ColSeasanTo.ReadOnly = true;
            // 
            // ColMatCatID
            // 
            this.ColMatCatID.DataPropertyName = "MatCatID";
            this.ColMatCatID.HeaderText = "MatCatID";
            this.ColMatCatID.Name = "ColMatCatID";
            this.ColMatCatID.ReadOnly = true;
            this.ColMatCatID.Visible = false;
            // 
            // ColMatSubCatID
            // 
            this.ColMatSubCatID.DataPropertyName = "MatSubCategoryID";
            this.ColMatSubCatID.HeaderText = "MatSubCatID";
            this.ColMatSubCatID.Name = "ColMatSubCatID";
            this.ColMatSubCatID.ReadOnly = true;
            this.ColMatSubCatID.Visible = false;
            // 
            // ColMatTypeID
            // 
            this.ColMatTypeID.DataPropertyName = "MatTypeID";
            this.ColMatTypeID.HeaderText = "MatTypeID";
            this.ColMatTypeID.Name = "ColMatTypeID";
            this.ColMatTypeID.ReadOnly = true;
            this.ColMatTypeID.Visible = false;
            // 
            // ColItemFormID
            // 
            this.ColItemFormID.DataPropertyName = "ItemFormID";
            this.ColItemFormID.HeaderText = "ItemFormID";
            this.ColItemFormID.Name = "ColItemFormID";
            this.ColItemFormID.ReadOnly = true;
            this.ColItemFormID.Visible = false;
            // 
            // ColUnitID
            // 
            this.ColUnitID.DataPropertyName = "UnitID";
            this.ColUnitID.HeaderText = "UnitID";
            this.ColUnitID.Name = "ColUnitID";
            this.ColUnitID.ReadOnly = true;
            this.ColUnitID.Visible = false;
            // 
            // ColStatus
            // 
            this.ColStatus.DataPropertyName = "Status";
            this.ColStatus.HeaderText = "Status";
            this.ColStatus.Name = "ColStatus";
            this.ColStatus.ReadOnly = true;
            this.ColStatus.Visible = false;
            // 
            // ColMaterial
            // 
            this.ColMaterial.DataPropertyName = "Material";
            this.ColMaterial.HeaderText = "Material";
            this.ColMaterial.Name = "ColMaterial";
            this.ColMaterial.ReadOnly = true;
            this.ColMaterial.Visible = false;
            // 
            // bindMaterials
            // 
            this.bindMaterials.Sort = "";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pnlBasic1
            // 
            this.pnlBasic1.Controls.Add(this.rdbDry);
            this.pnlBasic1.Controls.Add(this.rdbGreen);
            this.pnlBasic1.Controls.Add(this.cbMaterialImport);
            this.pnlBasic1.Controls.Add(this.cbMaterialLocal);
            this.pnlBasic1.Location = new System.Drawing.Point(448, 19);
            this.pnlBasic1.Name = "pnlBasic1";
            this.pnlBasic1.Size = new System.Drawing.Size(351, 30);
            this.pnlBasic1.TabIndex = 116;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(102, 219);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(328, 20);
            this.textBox1.TabIndex = 117;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 118;
            this.label2.Text = "Search For";
            // 
            // frmMaterialRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 564);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMaterialRegistration";
            this.Text = "Material Registration";
            this.Load += new System.EventHandler(this.frmMaterialRegistration_Load);
            this.pblBasic2.ResumeLayout(false);
            this.pblBasic2.PerformLayout();
            this.pnlInter.ResumeLayout(false);
            this.pnlInter.PerformLayout();
            this.pnlMaterial.ResumeLayout(false);
            this.pnlMaterial.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvMaterialList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindMaterials)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindMainCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindSubCat1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindSubCat2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindBasicMaterials)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objsourceMaterialBasic)).EndInit();
            this.pnlBasic1.ResumeLayout(false);
            this.pnlBasic1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbMainType;
        private System.Windows.Forms.Panel pblBasic2;
        private System.Windows.Forms.ComboBox cmbToMonth;
        private System.Windows.Forms.ComboBox cmbFromMonth;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.CheckBox cbMaterialLocal;
        private System.Windows.Forms.CheckBox cbMaterialImport;
        private System.Windows.Forms.CheckBox cbMaterialSeasonal;
        private System.Windows.Forms.Panel pnlInter;
        private System.Windows.Forms.Label lblMaterialBasicMaterialUnit;
        private System.Windows.Forms.TextBox txtMaterialBasicPartialSize;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMaterialQtyPerUnit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbMaterialBasicMaterial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlMaterial;
        private System.Windows.Forms.MaskedTextBox txtMaterialCode;
        private System.Windows.Forms.TextBox txtAcgUnitCost;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.ComboBox cmbMaterialUnit;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.ComboBox cmbMaterialForm;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbMaterialType;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtmaterialName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnMaterialClear;
        private System.Windows.Forms.Button btnMaterialDelete;
        private System.Windows.Forms.Button btnMaterialSave;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView gvMaterialList;
        private System.Windows.Forms.BindingSource bindMaterials;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.BindingSource bindCategory;
        private System.Windows.Forms.BindingSource bindMainCategory;
        private System.Windows.Forms.BindingSource bindSubCat1;
        private System.Windows.Forms.BindingSource bindSubCat2;
        private System.Windows.Forms.BindingSource bindBasicMaterials;
        private System.Windows.Forms.RadioButton rdbLab;
        private System.Windows.Forms.RadioButton rdbPacking;
        private System.Windows.Forms.RadioButton rdbRaw;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMaterialCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMaterialName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMatMainType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMaterialCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMaterialType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMaterialForm;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMaterialUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAVGCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColBasicMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColBasicQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColParticalSize;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColLocal;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColImport;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColSeasonal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSeasanFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSeasanTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMatCatID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMatSubCatID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMatTypeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColItemFormID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColUnitID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMaterial;
        private System.Windows.Forms.RadioButton rdbGreen;
        private System.Windows.Forms.RadioButton rdbDry;
        private System.Windows.Forms.BindingSource objsourceMaterialBasic;
        private System.Windows.Forms.Panel pnlBasic1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;

    }
}