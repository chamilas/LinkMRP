namespace MRP_GUI
{
    partial class frmMRT_Batch_FG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMRT_Batch_FG));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbBatchNo = new System.Windows.Forms.ComboBox();
            this.txtStore = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.btnSave = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.gvItemList = new System.Windows.Forms.DataGridView();
            this.ColMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindItemList = new System.Windows.Forms.BindingSource(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.objSourceMaterial = new System.Windows.Forms.BindingSource(this.components);
            this.objSourceBatchist = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvItemList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindItemList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceMaterial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceBatchist)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbBatchNo);
            this.groupBox1.Controls.Add(this.txtStore);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.gvItemList);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1002, 616);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Material Requisition Note";
            // 
            // cmbBatchNo
            // 
            this.cmbBatchNo.DisplayMember = "BatchID";
            this.cmbBatchNo.FormattingEnabled = true;
            this.cmbBatchNo.Location = new System.Drawing.Point(127, 31);
            this.cmbBatchNo.Name = "cmbBatchNo";
            this.cmbBatchNo.Size = new System.Drawing.Size(420, 23);
            this.cmbBatchNo.TabIndex = 16;
            this.cmbBatchNo.ValueMember = "BatchID";
            this.cmbBatchNo.SelectedIndexChanged += new System.EventHandler(this.cmbBatchNo_SelectedIndexChanged);
            // 
            // txtStore
            // 
            this.txtStore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStore.Location = new System.Drawing.Point(660, 35);
            this.txtStore.Name = "txtStore";
            this.txtStore.ReadOnly = true;
            this.txtStore.Size = new System.Drawing.Size(320, 22);
            this.txtStore.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(580, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "To Store";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Batch No";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.groupBox2.Location = new System.Drawing.Point(12, 62);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(984, 188);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Items";
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Location = new System.Drawing.Point(894, 31);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(74, 25);
            this.button4.TabIndex = 9;
            this.button4.Text = "Clear";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnItemDel
            // 
            this.btnItemDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnItemDel.Location = new System.Drawing.Point(894, 67);
            this.btnItemDel.Name = "btnItemDel";
            this.btnItemDel.Size = new System.Drawing.Size(74, 25);
            this.btnItemDel.TabIndex = 8;
            this.btnItemDel.Text = "Delete";
            this.btnItemDel.UseVisualStyleBackColor = true;
            this.btnItemDel.Click += new System.EventHandler(this.btnItemDel_Click);
            // 
            // btnItemAdd
            // 
            this.btnItemAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnItemAdd.Location = new System.Drawing.Point(894, 151);
            this.btnItemAdd.Name = "btnItemAdd";
            this.btnItemAdd.Size = new System.Drawing.Size(74, 25);
            this.btnItemAdd.TabIndex = 7;
            this.btnItemAdd.Text = "Add>>";
            this.btnItemAdd.UseVisualStyleBackColor = true;
            this.btnItemAdd.Click += new System.EventHandler(this.btnItemAdd_Click);
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Location = new System.Drawing.Point(221, 77);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(35, 15);
            this.lblUnit.TabIndex = 6;
            this.lblUnit.Text = "[Unit]";
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.Location = new System.Drawing.Point(115, 107);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(633, 69);
            this.txtDescription.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 15);
            this.label8.TabIndex = 4;
            this.label8.Text = "Description";
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(115, 71);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(100, 21);
            this.txtQty.TabIndex = 3;
            this.txtQty.Text = "0.00";
            this.txtQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQty_KeyPress);
            this.txtQty.Validated += new System.EventHandler(this.txtQty_Validated);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 15);
            this.label7.TabIndex = 2;
            this.label7.Text = "Reqd. Quantity";
            // 
            // cmbItem
            // 
            this.cmbItem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbItem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbItem.DisplayMember = "FinishProduct";
            this.cmbItem.FormattingEnabled = true;
            this.cmbItem.Location = new System.Drawing.Point(115, 35);
            this.cmbItem.Name = "cmbItem";
            this.cmbItem.Size = new System.Drawing.Size(420, 23);
            this.cmbItem.TabIndex = 1;
            this.cmbItem.ValueMember = "FinishProductCode";
            this.cmbItem.SelectedIndexChanged += new System.EventHandler(this.cmbItem_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Item";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(834, 573);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 34);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(915, 573);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 34);
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
            this.Column2,
            this.Column3});
            this.gvItemList.DataSource = this.bindItemList;
            this.gvItemList.Location = new System.Drawing.Point(12, 268);
            this.gvItemList.Name = "gvItemList";
            this.gvItemList.ReadOnly = true;
            this.gvItemList.RowHeadersVisible = false;
            this.gvItemList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvItemList.Size = new System.Drawing.Size(984, 299);
            this.gvItemList.TabIndex = 4;
            this.gvItemList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvItemList_CellClick);
            // 
            // ColMaterial
            // 
            this.ColMaterial.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColMaterial.DataPropertyName = "ItemCode";
            this.ColMaterial.FillWeight = 300F;
            this.ColMaterial.HeaderText = "Item";
            this.ColMaterial.Name = "ColMaterial";
            this.ColMaterial.ReadOnly = true;
            this.ColMaterial.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "UnitCode";
            this.Column2.HeaderText = "Unit";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "ReqdQty";
            this.Column3.HeaderText = "Reqd Qty.";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmMRT_Batch_FG
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1002, 616);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMRT_Batch_FG";
            this.Text = "Batch MR - Optional";
            this.Load += new System.EventHandler(this.frmMRT_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvItemList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindItemList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceMaterial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceBatchist)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView gvItemList;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnItemDel;
        private System.Windows.Forms.Button btnItemAdd;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.BindingSource bindItemList;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.BindingSource objSourceMaterial;
        private System.Windows.Forms.TextBox txtStore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBatchNo;
        private System.Windows.Forms.BindingSource objSourceBatchist;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}