namespace MRP_GUI.Components
{
    partial class ucDivision
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnManagerClear = new System.Windows.Forms.Button();
            this.btnMangerDelete = new System.Windows.Forms.Button();
            this.gvManagers = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEmpID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindManagers = new System.Windows.Forms.BindingSource(this.components);
            this.btnManagerAdd = new System.Windows.Forms.Button();
            this.cmbManagers = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBasicProductClear = new System.Windows.Forms.Button();
            this.btnBasicProductDelete = new System.Windows.Forms.Button();
            this.btnBasicProductAdd = new System.Windows.Forms.Button();
            this.gvDivisions = new System.Windows.Forms.DataGridView();
            this.colDivisionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvManagers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindManagers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDivisions)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnBasicProductClear);
            this.groupBox1.Controls.Add(this.btnBasicProductDelete);
            this.groupBox1.Controls.Add(this.btnBasicProductAdd);
            this.groupBox1.Controls.Add(this.gvDivisions);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbType);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(938, 502);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Division Management";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnManagerClear);
            this.groupBox2.Controls.Add(this.btnMangerDelete);
            this.groupBox2.Controls.Add(this.gvManagers);
            this.groupBox2.Controls.Add(this.btnManagerAdd);
            this.groupBox2.Controls.Add(this.cmbManagers);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(463, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(454, 164);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Managers";
            // 
            // btnManagerClear
            // 
            this.btnManagerClear.Enabled = false;
            this.btnManagerClear.Location = new System.Drawing.Point(211, 43);
            this.btnManagerClear.Name = "btnManagerClear";
            this.btnManagerClear.Size = new System.Drawing.Size(75, 23);
            this.btnManagerClear.TabIndex = 17;
            this.btnManagerClear.Text = "Clear";
            this.btnManagerClear.UseVisualStyleBackColor = true;
            this.btnManagerClear.Click += new System.EventHandler(this.btnManagerClear_Click);
            // 
            // btnMangerDelete
            // 
            this.btnMangerDelete.Enabled = false;
            this.btnMangerDelete.Location = new System.Drawing.Point(292, 43);
            this.btnMangerDelete.Name = "btnMangerDelete";
            this.btnMangerDelete.Size = new System.Drawing.Size(75, 23);
            this.btnMangerDelete.TabIndex = 16;
            this.btnMangerDelete.Text = "Delete";
            this.btnMangerDelete.UseVisualStyleBackColor = true;
            this.btnMangerDelete.Click += new System.EventHandler(this.btnMangerDelete_Click);
            // 
            // gvManagers
            // 
            this.gvManagers.AllowUserToAddRows = false;
            this.gvManagers.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gvManagers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gvManagers.AutoGenerateColumns = false;
            this.gvManagers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvManagers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.ColEmpID});
            this.gvManagers.DataSource = this.bindManagers;
            this.gvManagers.Location = new System.Drawing.Point(6, 72);
            this.gvManagers.Name = "gvManagers";
            this.gvManagers.ReadOnly = true;
            this.gvManagers.RowTemplate.Height = 20;
            this.gvManagers.Size = new System.Drawing.Size(442, 86);
            this.gvManagers.TabIndex = 2;
            this.gvManagers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvManagers_CellClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "Employee";
            this.Column1.HeaderText = "Manager";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // ColEmpID
            // 
            this.ColEmpID.DataPropertyName = "ManagerID";
            this.ColEmpID.HeaderText = "Column4";
            this.ColEmpID.Name = "ColEmpID";
            this.ColEmpID.ReadOnly = true;
            this.ColEmpID.Visible = false;
            // 
            // btnManagerAdd
            // 
            this.btnManagerAdd.Enabled = false;
            this.btnManagerAdd.Location = new System.Drawing.Point(369, 43);
            this.btnManagerAdd.Name = "btnManagerAdd";
            this.btnManagerAdd.Size = new System.Drawing.Size(75, 23);
            this.btnManagerAdd.TabIndex = 15;
            this.btnManagerAdd.Text = "Add";
            this.btnManagerAdd.UseVisualStyleBackColor = true;
            this.btnManagerAdd.Click += new System.EventHandler(this.btnManagerAdd_Click);
            // 
            // cmbManagers
            // 
            this.cmbManagers.DisplayMember = "Employee";
            this.cmbManagers.FormattingEnabled = true;
            this.cmbManagers.Location = new System.Drawing.Point(90, 17);
            this.cmbManagers.Name = "cmbManagers";
            this.cmbManagers.Size = new System.Drawing.Size(354, 21);
            this.cmbManagers.TabIndex = 1;
            this.cmbManagers.ValueMember = "EmpID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Manager";
            // 
            // btnBasicProductClear
            // 
            this.btnBasicProductClear.Location = new System.Drawing.Point(220, 150);
            this.btnBasicProductClear.Name = "btnBasicProductClear";
            this.btnBasicProductClear.Size = new System.Drawing.Size(75, 23);
            this.btnBasicProductClear.TabIndex = 12;
            this.btnBasicProductClear.Text = "Clear";
            this.btnBasicProductClear.UseVisualStyleBackColor = true;
            this.btnBasicProductClear.Click += new System.EventHandler(this.btnBasicProductClear_Click);
            // 
            // btnBasicProductDelete
            // 
            this.btnBasicProductDelete.Location = new System.Drawing.Point(301, 150);
            this.btnBasicProductDelete.Name = "btnBasicProductDelete";
            this.btnBasicProductDelete.Size = new System.Drawing.Size(75, 23);
            this.btnBasicProductDelete.TabIndex = 13;
            this.btnBasicProductDelete.Text = "Delete";
            this.btnBasicProductDelete.UseVisualStyleBackColor = true;
            this.btnBasicProductDelete.Click += new System.EventHandler(this.btnBasicProductDelete_Click);
            // 
            // btnBasicProductAdd
            // 
            this.btnBasicProductAdd.Location = new System.Drawing.Point(382, 150);
            this.btnBasicProductAdd.Name = "btnBasicProductAdd";
            this.btnBasicProductAdd.Size = new System.Drawing.Size(75, 23);
            this.btnBasicProductAdd.TabIndex = 11;
            this.btnBasicProductAdd.Text = "Save";
            this.btnBasicProductAdd.UseVisualStyleBackColor = true;
            this.btnBasicProductAdd.Click += new System.EventHandler(this.btnBasicProductAdd_Click);
            // 
            // gvDivisions
            // 
            this.gvDivisions.AllowUserToAddRows = false;
            this.gvDivisions.AllowUserToDeleteRows = false;
            this.gvDivisions.AllowUserToOrderColumns = true;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gvDivisions.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.gvDivisions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gvDivisions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDivisions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDivisionID,
            this.Column2,
            this.Column3});
            this.gvDivisions.Location = new System.Drawing.Point(6, 179);
            this.gvDivisions.MultiSelect = false;
            this.gvDivisions.Name = "gvDivisions";
            this.gvDivisions.ReadOnly = true;
            this.gvDivisions.RowTemplate.Height = 20;
            this.gvDivisions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvDivisions.Size = new System.Drawing.Size(926, 317);
            this.gvDivisions.TabIndex = 7;
            this.gvDivisions.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvDivisions_CellClick);
            // 
            // colDivisionID
            // 
            this.colDivisionID.DataPropertyName = "DivisionID";
            this.colDivisionID.HeaderText = "Division ID";
            this.colDivisionID.Name = "colDivisionID";
            this.colDivisionID.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "DivisionName";
            this.Column2.HeaderText = "Division Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "DivisionType";
            this.Column3.HeaderText = "Type";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 150;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Divisions";
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "Production",
            "Finance",
            "Supply",
            "Marketing",
            "Sales",
            "R&D",
            "HR",
            "Maintenance"});
            this.cmbType.Location = new System.Drawing.Point(126, 85);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(132, 21);
            this.cmbType.TabIndex = 5;
            this.cmbType.SelectedIndexChanged += new System.EventHandler(this.cmbType_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Division Type";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(126, 59);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(317, 20);
            this.txtName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Division Name";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(126, 33);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(132, 20);
            this.txtID.TabIndex = 1;
            this.txtID.Text = "[Auto]";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Division ID";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "DivisionID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Division ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "DivisionName";
            this.dataGridViewTextBoxColumn2.HeaderText = "Division Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DivisionType";
            this.dataGridViewTextBoxColumn3.HeaderText = "Type";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DivisionType";
            this.dataGridViewTextBoxColumn4.HeaderText = "Type";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "DivisionType";
            this.dataGridViewTextBoxColumn5.HeaderText = "Type";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // ucDivision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "ucDivision";
            this.Size = new System.Drawing.Size(938, 502);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvManagers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindManagers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDivisions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gvDivisions;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBasicProductClear;
        private System.Windows.Forms.Button btnBasicProductDelete;
        private System.Windows.Forms.Button btnBasicProductAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDivisionID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnMangerDelete;
        private System.Windows.Forms.DataGridView gvManagers;
        private System.Windows.Forms.Button btnManagerAdd;
        private System.Windows.Forms.ComboBox cmbManagers;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.BindingSource bindManagers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEmpID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button btnManagerClear;
    }
}
