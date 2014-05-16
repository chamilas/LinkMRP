namespace MRP_GUI
{
    partial class frmGRN_Direct_Semi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGRN_Direct));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.txtStores = new System.Windows.Forms.TextBox();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.gvItemList = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindItemList = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtUnitCost = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNetQty = new System.Windows.Forms.TextBox();
            this.cmbItem = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.btnGRN = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvItemList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindItemList)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.gvItemList);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.btnGRN);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1004, 612);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Good Receive Note";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtStores);
            this.panel1.Controls.Add(this.txtDepartment);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(12, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 63);
            this.panel1.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Department";
            // 
            // txtStores
            // 
            this.txtStores.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStores.Location = new System.Drawing.Point(682, 18);
            this.txtStores.Name = "txtStores";
            this.txtStores.ReadOnly = true;
            this.txtStores.Size = new System.Drawing.Size(292, 21);
            this.txtStores.TabIndex = 12;
            // 
            // txtDepartment
            // 
            this.txtDepartment.Location = new System.Drawing.Point(95, 21);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.ReadOnly = true;
            this.txtDepartment.Size = new System.Drawing.Size(522, 21);
            this.txtDepartment.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(623, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "Stores";
            // 
            // gvItemList
            // 
            this.gvItemList.AllowUserToAddRows = false;
            this.gvItemList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gvItemList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gvItemList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvItemList.AutoGenerateColumns = false;
            this.gvItemList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvItemList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column7,
            this.Column9});
            this.gvItemList.DataSource = this.bindItemList;
            this.gvItemList.Location = new System.Drawing.Point(546, 99);
            this.gvItemList.Name = "gvItemList";
            this.gvItemList.ReadOnly = true;
            this.gvItemList.RowHeadersVisible = false;
            this.gvItemList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvItemList.Size = new System.Drawing.Size(452, 473);
            this.gvItemList.TabIndex = 12;
            this.gvItemList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvItemList_CellClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "Item";
            this.Column1.FillWeight = 250F;
            this.Column1.HeaderText = "Item";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column7.DataPropertyName = "GrossQty";
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.Column7.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column7.HeaderText = "Qty Gross";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column9.DataPropertyName = "UnitPrice";
            dataGridViewCellStyle3.Format = "N2";
            this.Column9.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column9.HeaderText = "Price";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnClear);
            this.groupBox5.Controls.Add(this.btnDelete);
            this.groupBox5.Controls.Add(this.btnSave);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.txtUnitCost);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.txtNetQty);
            this.groupBox5.Controls.Add(this.cmbItem);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Location = new System.Drawing.Point(14, 89);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(526, 336);
            this.groupBox5.TabIndex = 17;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Items";
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Location = new System.Drawing.Point(401, 99);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(87, 27);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(401, 131);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(87, 27);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(401, 181);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(87, 27);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Add";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(14, 128);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 15);
            this.label12.TabIndex = 7;
            this.label12.Text = "Unit Price";
            // 
            // txtUnitCost
            // 
            this.txtUnitCost.Location = new System.Drawing.Point(92, 125);
            this.txtUnitCost.Name = "txtUnitCost";
            this.txtUnitCost.Size = new System.Drawing.Size(116, 21);
            this.txtUnitCost.TabIndex = 2;
            this.txtUnitCost.Text = "0.00";
            this.txtUnitCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUnitCost_KeyPress);
            this.txtUnitCost.Validated += new System.EventHandler(this.txtUnitCost_Validated);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "Quantity";
            // 
            // txtNetQty
            // 
            this.txtNetQty.Location = new System.Drawing.Point(92, 82);
            this.txtNetQty.Name = "txtNetQty";
            this.txtNetQty.Size = new System.Drawing.Size(116, 21);
            this.txtNetQty.TabIndex = 1;
            this.txtNetQty.Text = "0.000";
            this.txtNetQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNetQty_KeyPress);
            this.txtNetQty.Validated += new System.EventHandler(this.txtNetQty_Validated);
            // 
            // cmbItem
            // 
            this.cmbItem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbItem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbItem.FormattingEnabled = true;
            this.cmbItem.Location = new System.Drawing.Point(92, 43);
            this.cmbItem.Name = "cmbItem";
            this.cmbItem.Size = new System.Drawing.Size(409, 23);
            this.cmbItem.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Item";
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(905, 578);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 27);
            this.button3.TabIndex = 13;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnGRN
            // 
            this.btnGRN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGRN.Location = new System.Drawing.Point(810, 578);
            this.btnGRN.Name = "btnGRN";
            this.btnGRN.Size = new System.Drawing.Size(87, 27);
            this.btnGRN.TabIndex = 11;
            this.btnGRN.Text = "GRN";
            this.btnGRN.UseVisualStyleBackColor = true;
            this.btnGRN.Click += new System.EventHandler(this.btnGRN_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmGRN_Direct
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1004, 612);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1020, 650);
            this.Name = "frmGRN_Direct";
            this.Text = "Internal GRN Direct";
            this.Load += new System.EventHandler(this.frmGRNMATDirect_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvItemList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindItemList)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnGRN;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtUnitCost;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNetQty;
        private System.Windows.Forms.ComboBox cmbItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.BindingSource bindItemList;
        private System.Windows.Forms.DataGridView gvItemList;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.TextBox txtStores;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
    }
}