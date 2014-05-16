namespace MRP_GUI
{
    partial class frmSTDBatchManage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSTDBatchManage));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gvSTDBatch = new System.Windows.Forms.DataGridView();
            this.bindSTDBatch = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gvBlendSubInstructions = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindSubInstructions = new System.Windows.Forms.BindingSource(this.components);
            this.gvMachines = new System.Windows.Forms.DataGridView();
            this.ColMachine_Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEstimatedHour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindMachines = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.bindInstructions = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gvActivity = new System.Windows.Forms.DataGridView();
            this.ColActID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMainActivity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColActDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColActManHours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColActCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindActivity = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ColEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColBatchID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBasicProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColBatchSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColInstructedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColBatchType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvSTDBatch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindSTDBatch)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvBlendSubInstructions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindSubInstructions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMachines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindMachines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindInstructions)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvActivity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindActivity)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.gvSTDBatch);
            this.groupBox1.Location = new System.Drawing.Point(3, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(987, 171);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Standard Batches";
            // 
            // gvSTDBatch
            // 
            this.gvSTDBatch.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gvSTDBatch.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gvSTDBatch.AutoGenerateColumns = false;
            this.gvSTDBatch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColEdit,
            this.ColBatchID,
            this.ColDescription,
            this.colBasicProduct,
            this.Column1,
            this.ColBatchSize,
            this.ColInstructedBy,
            this.ColDate,
            this.Column2,
            this.ColBatchType});
            this.gvSTDBatch.DataSource = this.bindSTDBatch;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvSTDBatch.DefaultCellStyle = dataGridViewCellStyle5;
            this.gvSTDBatch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvSTDBatch.Location = new System.Drawing.Point(3, 16);
            this.gvSTDBatch.Name = "gvSTDBatch";
            this.gvSTDBatch.ReadOnly = true;
            this.gvSTDBatch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvSTDBatch.Size = new System.Drawing.Size(981, 152);
            this.gvSTDBatch.TabIndex = 0;
            this.gvSTDBatch.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvSTDBatch_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.gvBlendSubInstructions);
            this.groupBox2.Controls.Add(this.gvMachines);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(3, 370);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(987, 214);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Instructions && Machines";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Instruction";
            // 
            // gvBlendSubInstructions
            // 
            this.gvBlendSubInstructions.AllowUserToAddRows = false;
            this.gvBlendSubInstructions.AllowUserToDeleteRows = false;
            this.gvBlendSubInstructions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gvBlendSubInstructions.AutoGenerateColumns = false;
            this.gvBlendSubInstructions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvBlendSubInstructions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.gvBlendSubInstructions.DataSource = this.bindSubInstructions;
            this.gvBlendSubInstructions.Location = new System.Drawing.Point(9, 35);
            this.gvBlendSubInstructions.Name = "gvBlendSubInstructions";
            this.gvBlendSubInstructions.ReadOnly = true;
            this.gvBlendSubInstructions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvBlendSubInstructions.Size = new System.Drawing.Size(541, 168);
            this.gvBlendSubInstructions.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "SubActDescription";
            this.dataGridViewTextBoxColumn1.HeaderText = "Instruction";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // gvMachines
            // 
            this.gvMachines.AllowUserToAddRows = false;
            this.gvMachines.AllowUserToDeleteRows = false;
            this.gvMachines.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gvMachines.AutoGenerateColumns = false;
            this.gvMachines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvMachines.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColMachine_Title,
            this.ColEstimatedHour});
            this.gvMachines.DataSource = this.bindMachines;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvMachines.DefaultCellStyle = dataGridViewCellStyle6;
            this.gvMachines.Location = new System.Drawing.Point(556, 35);
            this.gvMachines.Name = "gvMachines";
            this.gvMachines.ReadOnly = true;
            this.gvMachines.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvMachines.Size = new System.Drawing.Size(425, 168);
            this.gvMachines.TabIndex = 5;
            // 
            // ColMachine_Title
            // 
            this.ColMachine_Title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColMachine_Title.DataPropertyName = "Machine_Title";
            this.ColMachine_Title.HeaderText = "Machine Name";
            this.ColMachine_Title.Name = "ColMachine_Title";
            this.ColMachine_Title.ReadOnly = true;
            // 
            // ColEstimatedHour
            // 
            this.ColEstimatedHour.DataPropertyName = "EstimatedHour";
            this.ColEstimatedHour.HeaderText = "Estimated Hours";
            this.ColEstimatedHour.Name = "ColEstimatedHour";
            this.ColEstimatedHour.ReadOnly = true;
            this.ColEstimatedHour.Width = 175;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(556, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Machines";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.gvActivity);
            this.groupBox3.Location = new System.Drawing.Point(6, 207);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(984, 157);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Activity";
            // 
            // gvActivity
            // 
            this.gvActivity.AllowUserToAddRows = false;
            this.gvActivity.AllowUserToDeleteRows = false;
            this.gvActivity.AutoGenerateColumns = false;
            this.gvActivity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvActivity.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColActID,
            this.ColMainActivity,
            this.ColActDuration,
            this.ColActManHours,
            this.ColActCost});
            this.gvActivity.DataSource = this.bindActivity;
            this.gvActivity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvActivity.Location = new System.Drawing.Point(3, 16);
            this.gvActivity.Name = "gvActivity";
            this.gvActivity.ReadOnly = true;
            this.gvActivity.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvActivity.Size = new System.Drawing.Size(978, 138);
            this.gvActivity.TabIndex = 0;
            this.gvActivity.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvActivity_CellClick);
            // 
            // ColActID
            // 
            this.ColActID.DataPropertyName = "ActID";
            this.ColActID.Frozen = true;
            this.ColActID.HeaderText = "Activity";
            this.ColActID.Name = "ColActID";
            this.ColActID.ReadOnly = true;
            // 
            // ColMainActivity
            // 
            this.ColMainActivity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColMainActivity.DataPropertyName = "MainActivity";
            this.ColMainActivity.HeaderText = "Activity Title";
            this.ColMainActivity.Name = "ColMainActivity";
            this.ColMainActivity.ReadOnly = true;
            // 
            // ColActDuration
            // 
            this.ColActDuration.DataPropertyName = "ActDuration";
            dataGridViewCellStyle7.Format = "N2";
            dataGridViewCellStyle7.NullValue = null;
            this.ColActDuration.DefaultCellStyle = dataGridViewCellStyle7;
            this.ColActDuration.HeaderText = "Duration";
            this.ColActDuration.MinimumWidth = 125;
            this.ColActDuration.Name = "ColActDuration";
            this.ColActDuration.ReadOnly = true;
            this.ColActDuration.Width = 125;
            // 
            // ColActManHours
            // 
            this.ColActManHours.DataPropertyName = "ActManHours";
            dataGridViewCellStyle8.Format = "N2";
            dataGridViewCellStyle8.NullValue = null;
            this.ColActManHours.DefaultCellStyle = dataGridViewCellStyle8;
            this.ColActManHours.HeaderText = "Man Hours";
            this.ColActManHours.MinimumWidth = 125;
            this.ColActManHours.Name = "ColActManHours";
            this.ColActManHours.ReadOnly = true;
            this.ColActManHours.Width = 125;
            // 
            // ColActCost
            // 
            this.ColActCost.DataPropertyName = "ActCost";
            dataGridViewCellStyle9.Format = "N2";
            dataGridViewCellStyle9.NullValue = null;
            this.ColActCost.DefaultCellStyle = dataGridViewCellStyle9;
            this.ColActCost.HeaderText = "Cost";
            this.ColActCost.MinimumWidth = 125;
            this.ColActCost.Name = "ColActCost";
            this.ColActCost.ReadOnly = true;
            this.ColActCost.Width = 125;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Standard Batch Management";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(915, 590);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ColEdit
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = "Edit";
            this.ColEdit.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColEdit.Frozen = true;
            this.ColEdit.HeaderText = "Edit";
            this.ColEdit.Name = "ColEdit";
            this.ColEdit.ReadOnly = true;
            this.ColEdit.Text = "Edit";
            this.ColEdit.Width = 50;
            // 
            // ColBatchID
            // 
            this.ColBatchID.DataPropertyName = "STDBatchID";
            this.ColBatchID.Frozen = true;
            this.ColBatchID.HeaderText = "STD Batch";
            this.ColBatchID.Name = "ColBatchID";
            this.ColBatchID.ReadOnly = true;
            // 
            // ColDescription
            // 
            this.ColDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColDescription.DataPropertyName = "Code";
            this.ColDescription.HeaderText = "Code";
            this.ColDescription.Name = "ColDescription";
            this.ColDescription.ReadOnly = true;
            // 
            // colBasicProduct
            // 
            this.colBasicProduct.DataPropertyName = "STDBasicProductCode";
            this.colBasicProduct.HeaderText = "Basic Products";
            this.colBasicProduct.Name = "colBasicProduct";
            this.colBasicProduct.ReadOnly = true;
            this.colBasicProduct.Width = 125;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "STDFinishProductCode";
            this.Column1.HeaderText = "Finish Products";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // ColBatchSize
            // 
            this.ColBatchSize.DataPropertyName = "STDBatchSize";
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.ColBatchSize.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColBatchSize.HeaderText = "Size";
            this.ColBatchSize.Name = "ColBatchSize";
            this.ColBatchSize.ReadOnly = true;
            // 
            // ColInstructedBy
            // 
            this.ColInstructedBy.DataPropertyName = "InstructedBy";
            this.ColInstructedBy.HeaderText = "Instructed By";
            this.ColInstructedBy.Name = "ColInstructedBy";
            this.ColInstructedBy.ReadOnly = true;
            this.ColInstructedBy.Width = 200;
            // 
            // ColDate
            // 
            this.ColDate.DataPropertyName = "STDInstructedDate";
            dataGridViewCellStyle4.Format = "d";
            dataGridViewCellStyle4.NullValue = null;
            this.ColDate.DefaultCellStyle = dataGridViewCellStyle4;
            this.ColDate.HeaderText = "Date";
            this.ColDate.Name = "ColDate";
            this.ColDate.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "STDDuration";
            this.Column2.HeaderText = "Duration";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // ColBatchType
            // 
            this.ColBatchType.DataPropertyName = "STDBatchType";
            this.ColBatchType.HeaderText = "Type";
            this.ColBatchType.Name = "ColBatchType";
            this.ColBatchType.ReadOnly = true;
            // 
            // frmSTDBatchManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 616);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSTDBatchManage";
            this.Text = "Standard Batch Management";
            this.Load += new System.EventHandler(this.frmSTDBatchManage_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvSTDBatch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindSTDBatch)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvBlendSubInstructions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindSubInstructions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMachines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindMachines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindInstructions)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvActivity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindActivity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView gvSTDBatch;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView gvMachines;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView gvActivity;
        private System.Windows.Forms.BindingSource bindSTDBatch;
        private System.Windows.Forms.BindingSource bindActivity;
        private System.Windows.Forms.BindingSource bindInstructions;
        private System.Windows.Forms.BindingSource bindSubInstructions;
        private System.Windows.Forms.BindingSource bindMachines;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMachine_Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEstimatedHour;
        private System.Windows.Forms.DataGridView gvBlendSubInstructions;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColActID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMainActivity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColActDuration;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColActManHours;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColActCost;
        private System.Windows.Forms.DataGridViewButtonColumn ColEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColBatchID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBasicProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColBatchSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColInstructedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColBatchType;
    }
}