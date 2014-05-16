namespace MRP_GUI
{
    partial class frmPO
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
            this.lblPoNo = new System.Windows.Forms.Label();
            this.lblPOSupplierID = new System.Windows.Forms.Label();
            this.lblSupplierDetails = new System.Windows.Forms.Label();
            this.lblPOPaymentType = new System.Windows.Forms.Label();
            this.txtPOReference = new System.Windows.Forms.TextBox();
            this.txtPONO = new System.Windows.Forms.TextBox();
            this.txtSupplierDetails = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDeliveryShedules = new System.Windows.Forms.Button();
            this.chkImport = new System.Windows.Forms.CheckBox();
            this.nudValid = new System.Windows.Forms.NumericUpDown();
            this.lblDays = new System.Windows.Forms.Label();
            this.cmbPOPaymentType = new System.Windows.Forms.ComboBox();
            this.cmbSupplier = new System.Windows.Forms.ComboBox();
            this.dtpReqDate = new System.Windows.Forms.DateTimePicker();
            this.lblPOReference = new System.Windows.Forms.Label();
            this.lblPOValidityPeriod = new System.Windows.Forms.Label();
            this.lblPORequiredDate = new System.Windows.Forms.Label();
            this.lblMaterialCode = new System.Windows.Forms.Label();
            this.lblPOQty = new System.Windows.Forms.Label();
            this.cmbMaterials = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblUnit = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.txtReqQty = new System.Windows.Forms.TextBox();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.gvMaterialList = new System.Windows.Forms.DataGridView();
            this.MaterialCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.POQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.objSource = new System.Windows.Forms.BindingSource(this.components);
            this.objSourceMaterials = new System.Windows.Forms.BindingSource(this.components);
            this.objSourceMaterialList = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudValid)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvMaterialList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceMaterials)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceMaterialList)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPoNo
            // 
            this.lblPoNo.AutoSize = true;
            this.lblPoNo.Location = new System.Drawing.Point(64, 25);
            this.lblPoNo.Name = "lblPoNo";
            this.lblPoNo.Size = new System.Drawing.Size(39, 13);
            this.lblPoNo.TabIndex = 0;
            this.lblPoNo.Text = "PO No";
            // 
            // lblPOSupplierID
            // 
            this.lblPOSupplierID.AutoSize = true;
            this.lblPOSupplierID.Location = new System.Drawing.Point(426, 57);
            this.lblPOSupplierID.Name = "lblPOSupplierID";
            this.lblPOSupplierID.Size = new System.Drawing.Size(77, 13);
            this.lblPOSupplierID.TabIndex = 1;
            this.lblPOSupplierID.Text = "PO Supplier ID";
            // 
            // lblSupplierDetails
            // 
            this.lblSupplierDetails.AutoSize = true;
            this.lblSupplierDetails.Location = new System.Drawing.Point(423, 82);
            this.lblSupplierDetails.Name = "lblSupplierDetails";
            this.lblSupplierDetails.Size = new System.Drawing.Size(80, 13);
            this.lblSupplierDetails.TabIndex = 2;
            this.lblSupplierDetails.Text = "Supplier Details";
            // 
            // lblPOPaymentType
            // 
            this.lblPOPaymentType.AutoSize = true;
            this.lblPOPaymentType.Location = new System.Drawing.Point(10, 48);
            this.lblPOPaymentType.Name = "lblPOPaymentType";
            this.lblPOPaymentType.Size = new System.Drawing.Size(93, 13);
            this.lblPOPaymentType.TabIndex = 4;
            this.lblPOPaymentType.Text = "PO Payment Type";
            // 
            // txtPOReference
            // 
            this.txtPOReference.Location = new System.Drawing.Point(115, 116);
            this.txtPOReference.Name = "txtPOReference";
            this.txtPOReference.Size = new System.Drawing.Size(262, 20);
            this.txtPOReference.TabIndex = 7;
            // 
            // txtPONO
            // 
            this.txtPONO.Location = new System.Drawing.Point(115, 23);
            this.txtPONO.Name = "txtPONO";
            this.txtPONO.Size = new System.Drawing.Size(152, 20);
            this.txtPONO.TabIndex = 8;
            // 
            // txtSupplierDetails
            // 
            this.txtSupplierDetails.Location = new System.Drawing.Point(518, 79);
            this.txtSupplierDetails.Multiline = true;
            this.txtSupplierDetails.Name = "txtSupplierDetails";
            this.txtSupplierDetails.ReadOnly = true;
            this.txtSupplierDetails.Size = new System.Drawing.Size(313, 52);
            this.txtSupplierDetails.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnDeliveryShedules);
            this.groupBox1.Controls.Add(this.chkImport);
            this.groupBox1.Controls.Add(this.nudValid);
            this.groupBox1.Controls.Add(this.lblDays);
            this.groupBox1.Controls.Add(this.cmbPOPaymentType);
            this.groupBox1.Controls.Add(this.txtPOReference);
            this.groupBox1.Controls.Add(this.cmbSupplier);
            this.groupBox1.Controls.Add(this.dtpReqDate);
            this.groupBox1.Controls.Add(this.txtSupplierDetails);
            this.groupBox1.Controls.Add(this.lblPOReference);
            this.groupBox1.Controls.Add(this.txtPONO);
            this.groupBox1.Controls.Add(this.lblPOValidityPeriod);
            this.groupBox1.Controls.Add(this.lblPORequiredDate);
            this.groupBox1.Controls.Add(this.lblPOSupplierID);
            this.groupBox1.Controls.Add(this.lblSupplierDetails);
            this.groupBox1.Controls.Add(this.lblPoNo);
            this.groupBox1.Controls.Add(this.lblPOPaymentType);
            this.groupBox1.Location = new System.Drawing.Point(17, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(843, 145);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Purchase Order";
            // 
            // btnDeliveryShedules
            // 
            this.btnDeliveryShedules.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeliveryShedules.Location = new System.Drawing.Point(662, 15);
            this.btnDeliveryShedules.Name = "btnDeliveryShedules";
            this.btnDeliveryShedules.Size = new System.Drawing.Size(169, 27);
            this.btnDeliveryShedules.TabIndex = 19;
            this.btnDeliveryShedules.Text = "Delivery Shedules";
            this.btnDeliveryShedules.UseVisualStyleBackColor = true;
            // 
            // chkImport
            // 
            this.chkImport.AutoSize = true;
            this.chkImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkImport.Location = new System.Drawing.Point(518, 19);
            this.chkImport.Name = "chkImport";
            this.chkImport.Size = new System.Drawing.Size(70, 20);
            this.chkImport.TabIndex = 18;
            this.chkImport.Text = "Import";
            this.chkImport.UseVisualStyleBackColor = true;
            // 
            // nudValid
            // 
            this.nudValid.Location = new System.Drawing.Point(115, 70);
            this.nudValid.Name = "nudValid";
            this.nudValid.Size = new System.Drawing.Size(80, 20);
            this.nudValid.TabIndex = 17;
            // 
            // lblDays
            // 
            this.lblDays.AutoSize = true;
            this.lblDays.Location = new System.Drawing.Point(201, 71);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(31, 13);
            this.lblDays.TabIndex = 16;
            this.lblDays.Text = "Days";
            // 
            // cmbPOPaymentType
            // 
            this.cmbPOPaymentType.FormattingEnabled = true;
            this.cmbPOPaymentType.Items.AddRange(new object[] {
            "Cash",
            "Credit"});
            this.cmbPOPaymentType.Location = new System.Drawing.Point(115, 46);
            this.cmbPOPaymentType.Name = "cmbPOPaymentType";
            this.cmbPOPaymentType.Size = new System.Drawing.Size(121, 21);
            this.cmbPOPaymentType.TabIndex = 15;
            // 
            // cmbSupplier
            // 
            this.cmbSupplier.DisplayMember = "SupName";
            this.cmbSupplier.FormattingEnabled = true;
            this.cmbSupplier.Location = new System.Drawing.Point(518, 54);
            this.cmbSupplier.Name = "cmbSupplier";
            this.cmbSupplier.Size = new System.Drawing.Size(313, 21);
            this.cmbSupplier.TabIndex = 14;
            this.cmbSupplier.ValueMember = "SupplierID";
            this.cmbSupplier.SelectedIndexChanged += new System.EventHandler(this.cmbSupplier_SelectedIndexChanged);
            // 
            // dtpReqDate
            // 
            this.dtpReqDate.Location = new System.Drawing.Point(115, 93);
            this.dtpReqDate.Name = "dtpReqDate";
            this.dtpReqDate.Size = new System.Drawing.Size(200, 20);
            this.dtpReqDate.TabIndex = 12;
            // 
            // lblPOReference
            // 
            this.lblPOReference.AutoSize = true;
            this.lblPOReference.Location = new System.Drawing.Point(28, 117);
            this.lblPOReference.Name = "lblPOReference";
            this.lblPOReference.Size = new System.Drawing.Size(75, 13);
            this.lblPOReference.TabIndex = 10;
            this.lblPOReference.Text = "PO Reference";
            this.lblPOReference.Click += new System.EventHandler(this.label11_Click);
            // 
            // lblPOValidityPeriod
            // 
            this.lblPOValidityPeriod.AutoSize = true;
            this.lblPOValidityPeriod.Location = new System.Drawing.Point(12, 71);
            this.lblPOValidityPeriod.Name = "lblPOValidityPeriod";
            this.lblPOValidityPeriod.Size = new System.Drawing.Size(91, 13);
            this.lblPOValidityPeriod.TabIndex = 9;
            this.lblPOValidityPeriod.Text = "PO Validity Period";
            this.lblPOValidityPeriod.Click += new System.EventHandler(this.label10_Click);
            // 
            // lblPORequiredDate
            // 
            this.lblPORequiredDate.AutoSize = true;
            this.lblPORequiredDate.Location = new System.Drawing.Point(9, 94);
            this.lblPORequiredDate.Name = "lblPORequiredDate";
            this.lblPORequiredDate.Size = new System.Drawing.Size(94, 13);
            this.lblPORequiredDate.TabIndex = 7;
            this.lblPORequiredDate.Text = "PO Required Date";
            // 
            // lblMaterialCode
            // 
            this.lblMaterialCode.AutoSize = true;
            this.lblMaterialCode.Location = new System.Drawing.Point(6, 27);
            this.lblMaterialCode.Name = "lblMaterialCode";
            this.lblMaterialCode.Size = new System.Drawing.Size(72, 13);
            this.lblMaterialCode.TabIndex = 11;
            this.lblMaterialCode.Text = "Material Code";
            // 
            // lblPOQty
            // 
            this.lblPOQty.AutoSize = true;
            this.lblPOQty.Location = new System.Drawing.Point(6, 51);
            this.lblPOQty.Name = "lblPOQty";
            this.lblPOQty.Size = new System.Drawing.Size(49, 13);
            this.lblPOQty.TabIndex = 8;
            this.lblPOQty.Text = "Req. Qty";
            // 
            // cmbMaterials
            // 
            this.cmbMaterials.DisplayMember = "Material";
            this.cmbMaterials.FormattingEnabled = true;
            this.cmbMaterials.Location = new System.Drawing.Point(114, 24);
            this.cmbMaterials.Name = "cmbMaterials";
            this.cmbMaterials.Size = new System.Drawing.Size(388, 21);
            this.cmbMaterials.TabIndex = 11;
            this.cmbMaterials.ValueMember = "MaterialCode";
            this.cmbMaterials.SelectedIndexChanged += new System.EventHandler(this.cmbMaterials_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.lblUnit);
            this.groupBox2.Controls.Add(this.btnClear);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.txtUnitPrice);
            this.groupBox2.Controls.Add(this.txtReqQty);
            this.groupBox2.Controls.Add(this.lblUnitPrice);
            this.groupBox2.Controls.Add(this.cmbMaterials);
            this.groupBox2.Controls.Add(this.lblMaterialCode);
            this.groupBox2.Controls.Add(this.lblPOQty);
            this.groupBox2.Location = new System.Drawing.Point(18, 163);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(843, 98);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Item List";
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Location = new System.Drawing.Point(272, 51);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(32, 13);
            this.lblUnit.TabIndex = 19;
            this.lblUnit.Text = "[Unit]";
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Location = new System.Drawing.Point(759, 65);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 18;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(677, 66);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(595, 66);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(114, 73);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(152, 20);
            this.txtUnitPrice.TabIndex = 15;
            // 
            // txtReqQty
            // 
            this.txtReqQty.Location = new System.Drawing.Point(114, 48);
            this.txtReqQty.Name = "txtReqQty";
            this.txtReqQty.Size = new System.Drawing.Size(152, 20);
            this.txtReqQty.TabIndex = 14;
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Location = new System.Drawing.Point(6, 76);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(53, 13);
            this.lblUnitPrice.TabIndex = 13;
            this.lblUnitPrice.Text = "Unit Price";
            // 
            // gvMaterialList
            // 
            this.gvMaterialList.AllowUserToAddRows = false;
            this.gvMaterialList.AllowUserToDeleteRows = false;
            this.gvMaterialList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvMaterialList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvMaterialList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaterialCode,
            this.Description,
            this.POQty,
            this.UnitPrice});
            this.gvMaterialList.Location = new System.Drawing.Point(17, 268);
            this.gvMaterialList.Name = "gvMaterialList";
            this.gvMaterialList.ReadOnly = true;
            this.gvMaterialList.Size = new System.Drawing.Size(843, 190);
            this.gvMaterialList.TabIndex = 13;
            this.gvMaterialList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // MaterialCode
            // 
            this.MaterialCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaterialCode.DataPropertyName = "MaterialCode";
            this.MaterialCode.HeaderText = "Material Code";
            this.MaterialCode.Name = "MaterialCode";
            this.MaterialCode.ReadOnly = true;
            this.MaterialCode.Visible = false;
            // 
            // Description
            // 
            this.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Description.DataPropertyName = "Material";
            this.Description.FillWeight = 200F;
            this.Description.HeaderText = "Material";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // POQty
            // 
            this.POQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.POQty.DataPropertyName = "POQty";
            this.POQty.HeaderText = "Req Qty";
            this.POQty.Name = "POQty";
            this.POQty.ReadOnly = true;
            // 
            // UnitPrice
            // 
            this.UnitPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UnitPrice.DataPropertyName = "UnitPrice";
            this.UnitPrice.HeaderText = "Unit Price";
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.ReadOnly = true;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(701, 464);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Location = new System.Drawing.Point(786, 464);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 20;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // frmPO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 499);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.gvMaterialList);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPO";
            this.Text = "Purchase Order";
            this.Load += new System.EventHandler(this.POEntering_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudValid)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvMaterialList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceMaterials)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceMaterialList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPoNo;
        private System.Windows.Forms.Label lblPOSupplierID;
        private System.Windows.Forms.Label lblSupplierDetails;
        private System.Windows.Forms.Label lblPOPaymentType;
        private System.Windows.Forms.TextBox txtPOReference;
        private System.Windows.Forms.TextBox txtPONO;
        private System.Windows.Forms.TextBox txtSupplierDetails;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblMaterialCode;
        private System.Windows.Forms.Label lblPOReference;
        private System.Windows.Forms.Label lblPOValidityPeriod;
        private System.Windows.Forms.Label lblPOQty;
        private System.Windows.Forms.Label lblPORequiredDate;
        private System.Windows.Forms.ComboBox cmbPOPaymentType;
        private System.Windows.Forms.ComboBox cmbSupplier;
        private System.Windows.Forms.DateTimePicker dtpReqDate;
        private System.Windows.Forms.ComboBox cmbMaterials;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.TextBox txtReqQty;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView gvMaterialList;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.NumericUpDown nudValid;
        private System.Windows.Forms.Label lblDays;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.BindingSource objSource;
        private System.Windows.Forms.BindingSource objSourceMaterials;
        private System.Windows.Forms.BindingSource objSourceMaterialList;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaterialCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn POQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.CheckBox chkImport;
        private System.Windows.Forms.Button btnDeliveryShedules;
    }
}