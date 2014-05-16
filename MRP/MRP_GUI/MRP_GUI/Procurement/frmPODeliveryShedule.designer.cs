namespace MRP_GUI
{
    partial class frmPODeliveryShedule
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
            this.lblSupplierDetails = new System.Windows.Forms.Label();
            this.lblPOPaymentType = new System.Windows.Forms.Label();
            this.txtPOReference = new System.Windows.Forms.TextBox();
            this.txtPONO = new System.Windows.Forms.TextBox();
            this.txtSupplierDetails = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPaymentType = new System.Windows.Forms.TextBox();
            this.gvPOMaterials = new System.Windows.Forms.DataGridView();
            this.Material = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpReqDate = new System.Windows.Forms.DateTimePicker();
            this.lblPOReference = new System.Windows.Forms.Label();
            this.lblPORequiredDate = new System.Windows.Forms.Label();
            this.lblMaterialCode = new System.Windows.Forms.Label();
            this.lblPOQty = new System.Windows.Forms.Label();
            this.cmbMaterials = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.chkShipmentDate = new System.Windows.Forms.CheckBox();
            this.dtpDeliveryDate = new System.Windows.Forms.DateTimePicker();
            this.dtpShipmentDate = new System.Windows.Forms.DateTimePicker();
            this.lblUnit = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtReqQty = new System.Windows.Forms.TextBox();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.gvPODeliveryShedule = new System.Windows.Forms.DataGridView();
            this.objSource = new System.Windows.Forms.BindingSource(this.components);
            this.objSourceMaterials = new System.Windows.Forms.BindingSource(this.components);
            this.objSourcePOMaterials = new System.Windows.Forms.BindingSource(this.components);
            this.objSourcePODelivery = new System.Windows.Forms.BindingSource(this.components);
            this.txtDeliveryOrder = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaterialCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.POQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeliveryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShipmentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvPOMaterials)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvPODeliveryShedule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceMaterials)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourcePOMaterials)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourcePODelivery)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPoNo
            // 
            this.lblPoNo.AutoSize = true;
            this.lblPoNo.Location = new System.Drawing.Point(8, 25);
            this.lblPoNo.Name = "lblPoNo";
            this.lblPoNo.Size = new System.Drawing.Size(39, 13);
            this.lblPoNo.TabIndex = 0;
            this.lblPoNo.Text = "PO No";
            // 
            // lblSupplierDetails
            // 
            this.lblSupplierDetails.AutoSize = true;
            this.lblSupplierDetails.Location = new System.Drawing.Point(8, 122);
            this.lblSupplierDetails.Name = "lblSupplierDetails";
            this.lblSupplierDetails.Size = new System.Drawing.Size(80, 13);
            this.lblSupplierDetails.TabIndex = 2;
            this.lblSupplierDetails.Text = "Supplier Details";
            // 
            // lblPOPaymentType
            // 
            this.lblPOPaymentType.AutoSize = true;
            this.lblPOPaymentType.Location = new System.Drawing.Point(8, 50);
            this.lblPOPaymentType.Name = "lblPOPaymentType";
            this.lblPOPaymentType.Size = new System.Drawing.Size(93, 13);
            this.lblPOPaymentType.TabIndex = 4;
            this.lblPOPaymentType.Text = "PO Payment Type";
            // 
            // txtPOReference
            // 
            this.txtPOReference.Location = new System.Drawing.Point(118, 96);
            this.txtPOReference.Name = "txtPOReference";
            this.txtPOReference.ReadOnly = true;
            this.txtPOReference.Size = new System.Drawing.Size(200, 20);
            this.txtPOReference.TabIndex = 7;
            // 
            // txtPONO
            // 
            this.txtPONO.Location = new System.Drawing.Point(118, 18);
            this.txtPONO.Name = "txtPONO";
            this.txtPONO.ReadOnly = true;
            this.txtPONO.Size = new System.Drawing.Size(200, 20);
            this.txtPONO.TabIndex = 8;
            // 
            // txtSupplierDetails
            // 
            this.txtSupplierDetails.Location = new System.Drawing.Point(118, 122);
            this.txtSupplierDetails.Multiline = true;
            this.txtSupplierDetails.Name = "txtSupplierDetails";
            this.txtSupplierDetails.ReadOnly = true;
            this.txtSupplierDetails.Size = new System.Drawing.Size(200, 30);
            this.txtSupplierDetails.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtPaymentType);
            this.groupBox1.Controls.Add(this.gvPOMaterials);
            this.groupBox1.Controls.Add(this.txtPOReference);
            this.groupBox1.Controls.Add(this.dtpReqDate);
            this.groupBox1.Controls.Add(this.txtSupplierDetails);
            this.groupBox1.Controls.Add(this.lblPOReference);
            this.groupBox1.Controls.Add(this.txtPONO);
            this.groupBox1.Controls.Add(this.lblPORequiredDate);
            this.groupBox1.Controls.Add(this.lblSupplierDetails);
            this.groupBox1.Controls.Add(this.lblPoNo);
            this.groupBox1.Controls.Add(this.lblPOPaymentType);
            this.groupBox1.Location = new System.Drawing.Point(3, -2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(866, 159);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // txtPaymentType
            // 
            this.txtPaymentType.Location = new System.Drawing.Point(118, 44);
            this.txtPaymentType.Name = "txtPaymentType";
            this.txtPaymentType.ReadOnly = true;
            this.txtPaymentType.Size = new System.Drawing.Size(200, 20);
            this.txtPaymentType.TabIndex = 25;
            // 
            // gvPOMaterials
            // 
            this.gvPOMaterials.AllowUserToAddRows = false;
            this.gvPOMaterials.AllowUserToDeleteRows = false;
            this.gvPOMaterials.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvPOMaterials.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvPOMaterials.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Material,
            this.OrderQty});
            this.gvPOMaterials.Enabled = false;
            this.gvPOMaterials.Location = new System.Drawing.Point(353, 18);
            this.gvPOMaterials.Name = "gvPOMaterials";
            this.gvPOMaterials.ReadOnly = true;
            this.gvPOMaterials.Size = new System.Drawing.Size(507, 134);
            this.gvPOMaterials.TabIndex = 24;
            // 
            // Material
            // 
            this.Material.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Material.DataPropertyName = "Material";
            this.Material.FillWeight = 200F;
            this.Material.HeaderText = "Material";
            this.Material.Name = "Material";
            this.Material.ReadOnly = true;
            // 
            // OrderQty
            // 
            this.OrderQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.OrderQty.DataPropertyName = "POQty";
            this.OrderQty.HeaderText = "Order Qty";
            this.OrderQty.Name = "OrderQty";
            this.OrderQty.ReadOnly = true;
            // 
            // dtpReqDate
            // 
            this.dtpReqDate.Location = new System.Drawing.Point(118, 70);
            this.dtpReqDate.Name = "dtpReqDate";
            this.dtpReqDate.Size = new System.Drawing.Size(200, 20);
            this.dtpReqDate.TabIndex = 12;
            // 
            // lblPOReference
            // 
            this.lblPOReference.AutoSize = true;
            this.lblPOReference.Location = new System.Drawing.Point(8, 101);
            this.lblPOReference.Name = "lblPOReference";
            this.lblPOReference.Size = new System.Drawing.Size(75, 13);
            this.lblPOReference.TabIndex = 10;
            this.lblPOReference.Text = "PO Reference";
            this.lblPOReference.Click += new System.EventHandler(this.label11_Click);
            // 
            // lblPORequiredDate
            // 
            this.lblPORequiredDate.AutoSize = true;
            this.lblPORequiredDate.Location = new System.Drawing.Point(8, 77);
            this.lblPORequiredDate.Name = "lblPORequiredDate";
            this.lblPORequiredDate.Size = new System.Drawing.Size(94, 13);
            this.lblPORequiredDate.TabIndex = 7;
            this.lblPORequiredDate.Text = "PO Required Date";
            // 
            // lblMaterialCode
            // 
            this.lblMaterialCode.AutoSize = true;
            this.lblMaterialCode.Location = new System.Drawing.Point(6, 47);
            this.lblMaterialCode.Name = "lblMaterialCode";
            this.lblMaterialCode.Size = new System.Drawing.Size(72, 13);
            this.lblMaterialCode.TabIndex = 11;
            this.lblMaterialCode.Text = "Material Code";
            // 
            // lblPOQty
            // 
            this.lblPOQty.AutoSize = true;
            this.lblPOQty.Location = new System.Drawing.Point(6, 71);
            this.lblPOQty.Name = "lblPOQty";
            this.lblPOQty.Size = new System.Drawing.Size(46, 13);
            this.lblPOQty.TabIndex = 8;
            this.lblPOQty.Text = "Quantity";
            // 
            // cmbMaterials
            // 
            this.cmbMaterials.DisplayMember = "Material";
            this.cmbMaterials.FormattingEnabled = true;
            this.cmbMaterials.Location = new System.Drawing.Point(117, 44);
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
            this.groupBox2.Controls.Add(this.txtDeliveryOrder);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.btnEdit);
            this.groupBox2.Controls.Add(this.chkShipmentDate);
            this.groupBox2.Controls.Add(this.dtpDeliveryDate);
            this.groupBox2.Controls.Add(this.dtpShipmentDate);
            this.groupBox2.Controls.Add(this.lblUnit);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.txtReqQty);
            this.groupBox2.Controls.Add(this.lblUnitPrice);
            this.groupBox2.Controls.Add(this.cmbMaterials);
            this.groupBox2.Controls.Add(this.lblMaterialCode);
            this.groupBox2.Controls.Add(this.lblPOQty);
            this.groupBox2.Location = new System.Drawing.Point(3, 163);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(858, 145);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Item List";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Delivery Order";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(384, 68);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 24;
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Location = new System.Drawing.Point(770, 58);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 23;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // chkShipmentDate
            // 
            this.chkShipmentDate.AutoSize = true;
            this.chkShipmentDate.Location = new System.Drawing.Point(10, 118);
            this.chkShipmentDate.Name = "chkShipmentDate";
            this.chkShipmentDate.Size = new System.Drawing.Size(96, 17);
            this.chkShipmentDate.TabIndex = 22;
            this.chkShipmentDate.Text = "Shipment Date";
            this.chkShipmentDate.UseVisualStyleBackColor = true;
            this.chkShipmentDate.CheckedChanged += new System.EventHandler(this.chkShipmentDate_CheckedChanged);
            // 
            // dtpDeliveryDate
            // 
            this.dtpDeliveryDate.Location = new System.Drawing.Point(117, 94);
            this.dtpDeliveryDate.Name = "dtpDeliveryDate";
            this.dtpDeliveryDate.Size = new System.Drawing.Size(200, 20);
            this.dtpDeliveryDate.TabIndex = 21;
            // 
            // dtpShipmentDate
            // 
            this.dtpShipmentDate.Location = new System.Drawing.Point(117, 118);
            this.dtpShipmentDate.Name = "dtpShipmentDate";
            this.dtpShipmentDate.Size = new System.Drawing.Size(200, 20);
            this.dtpShipmentDate.TabIndex = 20;
            this.dtpShipmentDate.Visible = false;
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Location = new System.Drawing.Point(275, 71);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(32, 13);
            this.lblUnit.TabIndex = 19;
            this.lblUnit.Text = "[Unit]";
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(770, 94);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(770, 22);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtReqQty
            // 
            this.txtReqQty.Location = new System.Drawing.Point(117, 68);
            this.txtReqQty.Name = "txtReqQty";
            this.txtReqQty.Size = new System.Drawing.Size(152, 20);
            this.txtReqQty.TabIndex = 14;
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Location = new System.Drawing.Point(6, 96);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(71, 13);
            this.lblUnitPrice.TabIndex = 13;
            this.lblUnitPrice.Text = "Delivery Date";
            // 
            // gvPODeliveryShedule
            // 
            this.gvPODeliveryShedule.AllowUserToAddRows = false;
            this.gvPODeliveryShedule.AllowUserToDeleteRows = false;
            this.gvPODeliveryShedule.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvPODeliveryShedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvPODeliveryShedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.MaterialCode,
            this.Description,
            this.POQty,
            this.DeliveryDate,
            this.ShipmentDate});
            this.gvPODeliveryShedule.Location = new System.Drawing.Point(17, 314);
            this.gvPODeliveryShedule.Name = "gvPODeliveryShedule";
            this.gvPODeliveryShedule.ReadOnly = true;
            this.gvPODeliveryShedule.Size = new System.Drawing.Size(843, 173);
            this.gvPODeliveryShedule.TabIndex = 13;
            this.gvPODeliveryShedule.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvPODeliveryShedule_CellClick);
            this.gvPODeliveryShedule.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtDeliveryOrder
            // 
            this.txtDeliveryOrder.Location = new System.Drawing.Point(118, 15);
            this.txtDeliveryOrder.Name = "txtDeliveryOrder";
            this.txtDeliveryOrder.Size = new System.Drawing.Size(100, 20);
            this.txtDeliveryOrder.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "(1 or 2 or 3 or 4 )";
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "Delivery Order";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
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
            this.POQty.DataPropertyName = "Qty";
            this.POQty.HeaderText = "Req Qty";
            this.POQty.Name = "POQty";
            this.POQty.ReadOnly = true;
            // 
            // DeliveryDate
            // 
            this.DeliveryDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DeliveryDate.DataPropertyName = "ExpectedDate";
            this.DeliveryDate.HeaderText = "DeliveryDate";
            this.DeliveryDate.Name = "DeliveryDate";
            this.DeliveryDate.ReadOnly = true;
            // 
            // ShipmentDate
            // 
            this.ShipmentDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ShipmentDate.DataPropertyName = "ShipmentDate";
            this.ShipmentDate.HeaderText = "ShipmentDate";
            this.ShipmentDate.Name = "ShipmentDate";
            this.ShipmentDate.ReadOnly = true;
            // 
            // frmPODeliveryShedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 499);
            this.Controls.Add(this.gvPODeliveryShedule);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPODeliveryShedule";
            this.Text = "Purchase Order- Delivery Shedule";
            this.Load += new System.EventHandler(this.POEntering_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvPOMaterials)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvPODeliveryShedule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceMaterials)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourcePOMaterials)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourcePODelivery)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPoNo;
        private System.Windows.Forms.Label lblSupplierDetails;
        private System.Windows.Forms.Label lblPOPaymentType;
        private System.Windows.Forms.TextBox txtPOReference;
        private System.Windows.Forms.TextBox txtPONO;
        private System.Windows.Forms.TextBox txtSupplierDetails;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblMaterialCode;
        private System.Windows.Forms.Label lblPOReference;
        private System.Windows.Forms.Label lblPOQty;
        private System.Windows.Forms.Label lblPORequiredDate;
        private System.Windows.Forms.DateTimePicker dtpReqDate;
        private System.Windows.Forms.ComboBox cmbMaterials;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtReqQty;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView gvPODeliveryShedule;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.BindingSource objSource;
        private System.Windows.Forms.BindingSource objSourceMaterials;
        private System.Windows.Forms.BindingSource objSourcePOMaterials;
        private System.Windows.Forms.DateTimePicker dtpShipmentDate;
        private System.Windows.Forms.DateTimePicker dtpDeliveryDate;
        private System.Windows.Forms.CheckBox chkShipmentDate;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.DataGridView gvPOMaterials;
        private System.Windows.Forms.DataGridViewTextBoxColumn Material;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderQty;
        private System.Windows.Forms.BindingSource objSourcePODelivery;
        private System.Windows.Forms.TextBox txtPaymentType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtDeliveryOrder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaterialCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn POQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeliveryDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShipmentDate;
    }
}