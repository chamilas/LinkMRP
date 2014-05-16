namespace MRP_GUI
{
    partial class frmMRT_Section
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMRT_Section));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbSection = new System.Windows.Forms.CheckBox();
            this.cmbSection = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbMRType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.btnItemDel = new System.Windows.Forms.Button();
            this.btnItemAdd = new System.Windows.Forms.Button();
            this.lblUnit = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbItem = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.gvItemList = new System.Windows.Forms.DataGridView();
            this.ColMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindItemList = new System.Windows.Forms.BindingSource(this.components);
            this.cmbStore = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvItemList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindItemList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbSection);
            this.groupBox1.Controls.Add(this.cmbSection);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cmbMRType);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txtRemarks);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.gvItemList);
            this.groupBox1.Controls.Add(this.cmbDepartment);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbStore);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1002, 616);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Material Requisition Note";
            // 
            // cbSection
            // 
            this.cbSection.AutoSize = true;
            this.cbSection.Location = new System.Drawing.Point(22, 48);
            this.cbSection.Name = "cbSection";
            this.cbSection.Size = new System.Drawing.Size(133, 17);
            this.cbSection.TabIndex = 15;
            this.cbSection.Text = "Requesting by Section";
            this.cbSection.UseVisualStyleBackColor = true;
            this.cbSection.CheckedChanged += new System.EventHandler(this.cbSection_CheckedChanged);
            // 
            // cmbSection
            // 
            this.cmbSection.DisplayMember = "SectionName";
            this.cmbSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSection.Enabled = false;
            this.cmbSection.FormattingEnabled = true;
            this.cmbSection.Location = new System.Drawing.Point(112, 71);
            this.cmbSection.Name = "cmbSection";
            this.cmbSection.Size = new System.Drawing.Size(208, 21);
            this.cmbSection.TabIndex = 14;
            this.cmbSection.ValueMember = "SectionID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(63, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Section";
            // 
            // cmbMRType
            // 
            this.cmbMRType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMRType.FormattingEnabled = true;
            this.cmbMRType.Items.AddRange(new object[] {
            "Material",
            "Basic Products",
            "Finish Products"});
            this.cmbMRType.Location = new System.Drawing.Point(79, 140);
            this.cmbMRType.Name = "cmbMRType";
            this.cmbMRType.Size = new System.Drawing.Size(208, 21);
            this.cmbMRType.TabIndex = 12;
            this.cmbMRType.SelectedIndexChanged += new System.EventHandler(this.cmbMRType_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Item Type";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.btnItemDel);
            this.groupBox2.Controls.Add(this.btnItemAdd);
            this.groupBox2.Controls.Add(this.lblUnit);
            this.groupBox2.Controls.Add(this.txtDescription);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtQty);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cmbItem);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(12, 166);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(311, 412);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Items";
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Location = new System.Drawing.Point(151, 383);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(50, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "Clear";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnItemDel
            // 
            this.btnItemDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnItemDel.Location = new System.Drawing.Point(203, 383);
            this.btnItemDel.Name = "btnItemDel";
            this.btnItemDel.Size = new System.Drawing.Size(50, 23);
            this.btnItemDel.TabIndex = 8;
            this.btnItemDel.Text = "Delete";
            this.btnItemDel.UseVisualStyleBackColor = true;
            this.btnItemDel.Click += new System.EventHandler(this.btnItemDel_Click);
            // 
            // btnItemAdd
            // 
            this.btnItemAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnItemAdd.Location = new System.Drawing.Point(255, 383);
            this.btnItemAdd.Name = "btnItemAdd";
            this.btnItemAdd.Size = new System.Drawing.Size(50, 23);
            this.btnItemAdd.TabIndex = 7;
            this.btnItemAdd.Text = "Add";
            this.btnItemAdd.UseVisualStyleBackColor = true;
            this.btnItemAdd.Click += new System.EventHandler(this.btnItemAdd_Click);
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Location = new System.Drawing.Point(112, 79);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(32, 13);
            this.lblUnit.TabIndex = 6;
            this.lblUnit.Text = "[Unit]";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(6, 117);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(299, 91);
            this.txtDescription.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Description";
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(6, 78);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(100, 20);
            this.txtQty.TabIndex = 3;
            this.txtQty.Text = "0.00";
            this.txtQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQty_KeyPress);
            this.txtQty.Validated += new System.EventHandler(this.txtQty_Validated);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Reqd. Quantity";
            // 
            // cmbItem
            // 
            this.cmbItem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbItem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbItem.FormattingEnabled = true;
            this.cmbItem.Location = new System.Drawing.Point(6, 35);
            this.cmbItem.Name = "cmbItem";
            this.cmbItem.Size = new System.Drawing.Size(299, 21);
            this.cmbItem.TabIndex = 1;
            this.cmbItem.SelectedIndexChanged += new System.EventHandler(this.cmbItem_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Item";
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(436, 18);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRemarks.Size = new System.Drawing.Size(333, 88);
            this.txtRemarks.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(372, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Remarks";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(326, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Required Material List";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(834, 584);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(915, 584);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gvItemList
            // 
            this.gvItemList.AllowUserToAddRows = false;
            this.gvItemList.AllowUserToDeleteRows = false;
            this.gvItemList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gvItemList.AutoGenerateColumns = false;
            this.gvItemList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvItemList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColMaterial,
            this.Column1,
            this.Column2,
            this.Column3});
            this.gvItemList.DataSource = this.bindItemList;
            this.gvItemList.Location = new System.Drawing.Point(329, 147);
            this.gvItemList.Name = "gvItemList";
            this.gvItemList.ReadOnly = true;
            this.gvItemList.RowHeadersVisible = false;
            this.gvItemList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvItemList.Size = new System.Drawing.Size(667, 431);
            this.gvItemList.TabIndex = 4;
            this.gvItemList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvItemList_CellClick);
            // 
            // ColMaterial
            // 
            this.ColMaterial.DataPropertyName = "ItemCode";
            this.ColMaterial.HeaderText = "Item";
            this.ColMaterial.Name = "ColMaterial";
            this.ColMaterial.ReadOnly = true;
            this.ColMaterial.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColMaterial.Width = 200;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "Description";
            this.Column1.HeaderText = "Description of Items";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "UnitCode";
            this.Column2.HeaderText = "Unit";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "ReqdQty";
            this.Column3.HeaderText = "Reqd Qty.";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // cmbStore
            // 
            this.cmbStore.DisplayMember = "StoreName";
            this.cmbStore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStore.FormattingEnabled = true;
            this.cmbStore.Location = new System.Drawing.Point(79, 113);
            this.cmbStore.Name = "cmbStore";
            this.cmbStore.Size = new System.Drawing.Size(208, 21);
            this.cmbStore.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Store From";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Your Department";
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.DisplayMember = "DepName";
            this.cmbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Location = new System.Drawing.Point(112, 18);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(208, 21);
            this.cmbDepartment.TabIndex = 3;
            this.cmbDepartment.ValueMember = "DepID";
            this.cmbDepartment.SelectedIndexChanged += new System.EventHandler(this.cmbDepartment_SelectedIndexChanged);
            // 
            // frmMRT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 616);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMRT";
            this.Text = "Material Requisition Note";
            this.Load += new System.EventHandler(this.frmMRT_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvItemList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindItemList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView gvItemList;
        private System.Windows.Forms.ComboBox cmbStore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbMRType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnItemDel;
        private System.Windows.Forms.Button btnItemAdd;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.BindingSource bindItemList;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox cmbSection;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox cbSection;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.Label label2;
    }
}