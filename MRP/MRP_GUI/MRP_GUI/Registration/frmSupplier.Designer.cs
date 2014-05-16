namespace MRP_GUI
{
    partial class frmSupplier
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFax = new System.Windows.Forms.MaskedTextBox();
            this.txtMobile = new System.Windows.Forms.MaskedTextBox();
            this.txtPhone = new System.Windows.Forms.MaskedTextBox();
            this.cbEnable = new System.Windows.Forms.CheckBox();
            this.txtContactPerson = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblVatNumber = new System.Windows.Forms.Label();
            this.cbVAT = new System.Windows.Forms.CheckBox();
            this.txtVATNumber = new System.Windows.Forms.TextBox();
            this.label55 = new System.Windows.Forms.Label();
            this.cmbSupplierCategory = new System.Windows.Forms.ComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.objSourceSuppliers = new System.Windows.Forms.BindingSource(this.components);
            this.gvSupplier = new System.Windows.Forms.DataGridView();
            this.SupplierID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupMobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupFax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupVat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupVatNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupContactPerson = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceSuppliers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSupplier)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.gvSupplier);
            this.groupBox4.Controls.Add(this.txtCode);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.txtFax);
            this.groupBox4.Controls.Add(this.txtMobile);
            this.groupBox4.Controls.Add(this.txtPhone);
            this.groupBox4.Controls.Add(this.cbEnable);
            this.groupBox4.Controls.Add(this.txtContactPerson);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.lblVatNumber);
            this.groupBox4.Controls.Add(this.cbVAT);
            this.groupBox4.Controls.Add(this.txtVATNumber);
            this.groupBox4.Controls.Add(this.label55);
            this.groupBox4.Controls.Add(this.cmbSupplierCategory);
            this.groupBox4.Controls.Add(this.btnClear);
            this.groupBox4.Controls.Add(this.btnDelete);
            this.groupBox4.Controls.Add(this.btnSave);
            this.groupBox4.Controls.Add(this.txtEmail);
            this.groupBox4.Controls.Add(this.label26);
            this.groupBox4.Controls.Add(this.label25);
            this.groupBox4.Controls.Add(this.label24);
            this.groupBox4.Controls.Add(this.label23);
            this.groupBox4.Controls.Add(this.txtAddress);
            this.groupBox4.Controls.Add(this.label21);
            this.groupBox4.Controls.Add(this.txtName);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Location = new System.Drawing.Point(2, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1001, 588);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Supplier";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(96, 34);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(237, 20);
            this.txtCode.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(52, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Code :";
            // 
            // txtFax
            // 
            this.txtFax.Location = new System.Drawing.Point(434, 58);
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(139, 20);
            this.txtFax.TabIndex = 7;
            // 
            // txtMobile
            // 
            this.txtMobile.Location = new System.Drawing.Point(96, 144);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(139, 20);
            this.txtMobile.TabIndex = 5;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(96, 123);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(139, 20);
            this.txtPhone.TabIndex = 4;
            // 
            // cbEnable
            // 
            this.cbEnable.AutoSize = true;
            this.cbEnable.Checked = true;
            this.cbEnable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbEnable.Location = new System.Drawing.Point(429, 33);
            this.cbEnable.Name = "cbEnable";
            this.cbEnable.Size = new System.Drawing.Size(100, 17);
            this.cbEnable.TabIndex = 6;
            this.cbEnable.Text = "Enable Supplier";
            this.cbEnable.UseVisualStyleBackColor = true;
            // 
            // txtContactPerson
            // 
            this.txtContactPerson.Location = new System.Drawing.Point(434, 100);
            this.txtContactPerson.Name = "txtContactPerson";
            this.txtContactPerson.Size = new System.Drawing.Size(237, 20);
            this.txtContactPerson.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(342, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Contact Person :";
            // 
            // lblVatNumber
            // 
            this.lblVatNumber.AutoSize = true;
            this.lblVatNumber.Location = new System.Drawing.Point(359, 146);
            this.lblVatNumber.Name = "lblVatNumber";
            this.lblVatNumber.Size = new System.Drawing.Size(69, 13);
            this.lblVatNumber.TabIndex = 18;
            this.lblVatNumber.Text = "Vat Number :";
            this.lblVatNumber.Visible = false;
            // 
            // cbVAT
            // 
            this.cbVAT.AutoSize = true;
            this.cbVAT.Location = new System.Drawing.Point(434, 126);
            this.cbVAT.Name = "cbVAT";
            this.cbVAT.Size = new System.Drawing.Size(95, 17);
            this.cbVAT.TabIndex = 10;
            this.cbVAT.Text = "VAT Registerd";
            this.cbVAT.UseVisualStyleBackColor = true;
            this.cbVAT.CheckedChanged += new System.EventHandler(this.cbVAT_CheckedChanged);
            // 
            // txtVATNumber
            // 
            this.txtVATNumber.Location = new System.Drawing.Point(434, 143);
            this.txtVATNumber.Name = "txtVATNumber";
            this.txtVATNumber.Size = new System.Drawing.Size(237, 20);
            this.txtVATNumber.TabIndex = 11;
            this.txtVATNumber.Visible = false;
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(52, 16);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(37, 13);
            this.label55.TabIndex = 23;
            this.label55.Text = "Type :";
            // 
            // cmbSupplierCategory
            // 
            this.cmbSupplierCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSupplierCategory.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbSupplierCategory.FormattingEnabled = true;
            this.cmbSupplierCategory.Items.AddRange(new object[] {
            "Raw",
            "Packing",
            "Lab"});
            this.cmbSupplierCategory.Location = new System.Drawing.Point(96, 13);
            this.cmbSupplierCategory.Name = "cmbSupplierCategory";
            this.cmbSupplierCategory.Size = new System.Drawing.Size(237, 21);
            this.cmbSupplierCategory.TabIndex = 0;
            this.cmbSupplierCategory.SelectedIndexChanged += new System.EventHandler(this.cmbSupplierCategory_SelectedIndexChanged);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(898, 53);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(92, 23);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "New";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(898, 82);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(92, 23);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(898, 126);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(92, 34);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save Supplier";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(434, 79);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(237, 20);
            this.txtEmail.TabIndex = 8;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(390, 82);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(38, 13);
            this.label26.TabIndex = 16;
            this.label26.Text = "Email :";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(398, 61);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(30, 13);
            this.label25.TabIndex = 15;
            this.label25.Text = "Fax :";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(46, 147);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(44, 13);
            this.label24.TabIndex = 19;
            this.label24.Text = "Mobile :";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(46, 126);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(44, 13);
            this.label23.TabIndex = 20;
            this.label23.Text = "Phone :";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(96, 75);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAddress.Size = new System.Drawing.Size(237, 47);
            this.txtAddress.TabIndex = 3;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(39, 78);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(51, 13);
            this.label21.TabIndex = 21;
            this.label21.Text = "Address :";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(96, 54);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(237, 20);
            this.txtName.TabIndex = 2;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(49, 57);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(41, 13);
            this.label19.TabIndex = 24;
            this.label19.Text = "Name :";
            // 
            // gvSupplier
            // 
            this.gvSupplier.AllowUserToAddRows = false;
            this.gvSupplier.AllowUserToDeleteRows = false;
            this.gvSupplier.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvSupplier.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SupplierID,
            this.SupplierCode,
            this.SupName,
            this.SupAddress,
            this.SupPhone,
            this.SupMobile,
            this.SupEmail,
            this.SupFax,
            this.SupVat,
            this.SupVatNumber,
            this.SupContactPerson});
            this.gvSupplier.Location = new System.Drawing.Point(10, 193);
            this.gvSupplier.Name = "gvSupplier";
            this.gvSupplier.ReadOnly = true;
            this.gvSupplier.Size = new System.Drawing.Size(980, 389);
            this.gvSupplier.TabIndex = 25;
            this.gvSupplier.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvSupplier_CellClick_1);
            // 
            // SupplierID
            // 
            this.SupplierID.DataPropertyName = "SupplierID";
            this.SupplierID.HeaderText = "SupplierID";
            this.SupplierID.Name = "SupplierID";
            this.SupplierID.ReadOnly = true;
            this.SupplierID.Visible = false;
            // 
            // SupplierCode
            // 
            this.SupplierCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SupplierCode.DataPropertyName = "SupplierCode";
            this.SupplierCode.FillWeight = 50F;
            this.SupplierCode.HeaderText = "SupplierCode";
            this.SupplierCode.Name = "SupplierCode";
            this.SupplierCode.ReadOnly = true;
            this.SupplierCode.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SupplierCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // SupName
            // 
            this.SupName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SupName.DataPropertyName = "SupName";
            this.SupName.HeaderText = "SupName";
            this.SupName.Name = "SupName";
            this.SupName.ReadOnly = true;
            // 
            // SupAddress
            // 
            this.SupAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SupAddress.DataPropertyName = "SupAddress";
            this.SupAddress.HeaderText = "SupAddress";
            this.SupAddress.Name = "SupAddress";
            this.SupAddress.ReadOnly = true;
            // 
            // SupPhone
            // 
            this.SupPhone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SupPhone.DataPropertyName = "SupPhone";
            this.SupPhone.FillWeight = 30F;
            this.SupPhone.HeaderText = "SupPhone";
            this.SupPhone.Name = "SupPhone";
            this.SupPhone.ReadOnly = true;
            // 
            // SupMobile
            // 
            this.SupMobile.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SupMobile.DataPropertyName = "SupMobile";
            this.SupMobile.FillWeight = 30F;
            this.SupMobile.HeaderText = "SupMobile";
            this.SupMobile.Name = "SupMobile";
            this.SupMobile.ReadOnly = true;
            // 
            // SupEmail
            // 
            this.SupEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SupEmail.DataPropertyName = "SupEmail";
            this.SupEmail.FillWeight = 20F;
            this.SupEmail.HeaderText = "SupEmail";
            this.SupEmail.Name = "SupEmail";
            this.SupEmail.ReadOnly = true;
            this.SupEmail.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SupEmail.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // SupFax
            // 
            this.SupFax.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SupFax.DataPropertyName = "SupFax";
            this.SupFax.FillWeight = 30F;
            this.SupFax.HeaderText = "SupFax";
            this.SupFax.Name = "SupFax";
            this.SupFax.ReadOnly = true;
            this.SupFax.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SupFax.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // SupVat
            // 
            this.SupVat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SupVat.DataPropertyName = "SupVat";
            this.SupVat.FillWeight = 20F;
            this.SupVat.HeaderText = "SupVat";
            this.SupVat.Name = "SupVat";
            this.SupVat.ReadOnly = true;
            this.SupVat.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SupVat.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // SupVatNumber
            // 
            this.SupVatNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SupVatNumber.DataPropertyName = "SupVatNumber";
            this.SupVatNumber.FillWeight = 10F;
            this.SupVatNumber.HeaderText = "SupVatNumber";
            this.SupVatNumber.Name = "SupVatNumber";
            this.SupVatNumber.ReadOnly = true;
            this.SupVatNumber.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SupVatNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // SupContactPerson
            // 
            this.SupContactPerson.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SupContactPerson.DataPropertyName = "SupContactPerson";
            this.SupContactPerson.FillWeight = 10F;
            this.SupContactPerson.HeaderText = "SupContactPerson";
            this.SupContactPerson.Name = "SupContactPerson";
            this.SupContactPerson.ReadOnly = true;
            this.SupContactPerson.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SupContactPerson.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // frmSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 612);
            this.Controls.Add(this.groupBox4);
            this.Name = "frmSupplier";
            this.Text = "Supplier Registration";
            this.Load += new System.EventHandler(this.frmSupplier_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceSuppliers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSupplier)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox txtFax;
        private System.Windows.Forms.MaskedTextBox txtMobile;
        private System.Windows.Forms.MaskedTextBox txtPhone;
        private System.Windows.Forms.CheckBox cbEnable;
        private System.Windows.Forms.TextBox txtContactPerson;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblVatNumber;
        private System.Windows.Forms.CheckBox cbVAT;
        private System.Windows.Forms.TextBox txtVATNumber;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.ComboBox cmbSupplierCategory;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.BindingSource objSourceSuppliers;
        private System.Windows.Forms.DataGridView gvSupplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupMobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupFax;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupVat;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupVatNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupContactPerson;
    }
}