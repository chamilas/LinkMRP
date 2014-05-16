namespace MRP_GUI
{
    partial class frmMRReceive_toBatch
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMRReceive_toBatch));
            this.gvMRList = new System.Windows.Forms.DataGridView();
            this.BatchID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MRNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Part = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RequestedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RequestedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IssuedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IssuedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindMRList = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gvItemList = new System.Windows.Forms.DataGridView();
            this.ColMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColIssuedQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindItemList = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.txtStore = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvMRList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindMRList)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvItemList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindItemList)).BeginInit();
            this.SuspendLayout();
            // 
            // gvMRList
            // 
            this.gvMRList.AllowUserToAddRows = false;
            this.gvMRList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gvMRList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gvMRList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvMRList.AutoGenerateColumns = false;
            this.gvMRList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvMRList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BatchID,
            this.MRNO,
            this.Part,
            this.RequestedBy,
            this.RequestedDate,
            this.IssuedBy,
            this.IssuedDate});
            this.gvMRList.DataSource = this.bindMRList;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvMRList.DefaultCellStyle = dataGridViewCellStyle2;
            this.gvMRList.Location = new System.Drawing.Point(12, 38);
            this.gvMRList.MultiSelect = false;
            this.gvMRList.Name = "gvMRList";
            this.gvMRList.ReadOnly = true;
            this.gvMRList.RowHeadersVisible = false;
            this.gvMRList.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvMRList.RowTemplate.Height = 30;
            this.gvMRList.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gvMRList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvMRList.Size = new System.Drawing.Size(982, 264);
            this.gvMRList.TabIndex = 5;
            this.gvMRList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvMRList_CellClick);
            // 
            // BatchID
            // 
            this.BatchID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BatchID.DataPropertyName = "BatchID";
            this.BatchID.HeaderText = "Batch ID";
            this.BatchID.Name = "BatchID";
            this.BatchID.ReadOnly = true;
            // 
            // MRNO
            // 
            this.MRNO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MRNO.DataPropertyName = "MRNO";
            this.MRNO.HeaderText = "MRN No";
            this.MRNO.Name = "MRNO";
            this.MRNO.ReadOnly = true;
            // 
            // Part
            // 
            this.Part.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Part.DataPropertyName = "Part";
            this.Part.HeaderText = "Part";
            this.Part.Name = "Part";
            this.Part.ReadOnly = true;
            // 
            // RequestedBy
            // 
            this.RequestedBy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RequestedBy.DataPropertyName = "MREnterdBy";
            this.RequestedBy.HeaderText = "Requested By";
            this.RequestedBy.Name = "RequestedBy";
            this.RequestedBy.ReadOnly = true;
            // 
            // RequestedDate
            // 
            this.RequestedDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RequestedDate.DataPropertyName = "MRDate";
            this.RequestedDate.HeaderText = "Requested Date";
            this.RequestedDate.Name = "RequestedDate";
            this.RequestedDate.ReadOnly = true;
            // 
            // IssuedBy
            // 
            this.IssuedBy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IssuedBy.DataPropertyName = "MRIssuedBy";
            this.IssuedBy.HeaderText = "Issued By";
            this.IssuedBy.Name = "IssuedBy";
            this.IssuedBy.ReadOnly = true;
            // 
            // IssuedDate
            // 
            this.IssuedDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IssuedDate.DataPropertyName = "MRIssuedDate";
            this.IssuedDate.HeaderText = "Issued Date";
            this.IssuedDate.Name = "IssuedDate";
            this.IssuedDate.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.gvItemList);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Location = new System.Drawing.Point(12, 308);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(988, 305);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Material List";
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
            this.Column3,
            this.dataGridViewTextBoxColumn3,
            this.ColIssuedQty});
            this.gvItemList.DataSource = this.bindItemList;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvItemList.DefaultCellStyle = dataGridViewCellStyle5;
            this.gvItemList.Location = new System.Drawing.Point(6, 19);
            this.gvItemList.Name = "gvItemList";
            this.gvItemList.ReadOnly = true;
            this.gvItemList.RowHeadersVisible = false;
            this.gvItemList.RowTemplate.Height = 30;
            this.gvItemList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvItemList.Size = new System.Drawing.Size(972, 240);
            this.gvItemList.TabIndex = 46;
            // 
            // ColMaterial
            // 
            this.ColMaterial.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColMaterial.DataPropertyName = "Item";
            this.ColMaterial.FillWeight = 200F;
            this.ColMaterial.HeaderText = "Item";
            this.ColMaterial.Name = "ColMaterial";
            this.ColMaterial.ReadOnly = true;
            this.ColMaterial.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Unit";
            this.Column3.HeaderText = "Unit";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "MRReqdQty";
            dataGridViewCellStyle3.Format = "N3";
            dataGridViewCellStyle3.NullValue = null;
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn3.HeaderText = "Reqd Qty.";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 120;
            // 
            // ColIssuedQty
            // 
            this.ColIssuedQty.DataPropertyName = "MRIssuedQty";
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Format = "N3";
            dataGridViewCellStyle4.NullValue = null;
            this.ColIssuedQty.DefaultCellStyle = dataGridViewCellStyle4;
            this.ColIssuedQty.HeaderText = "Issued Qty";
            this.ColIssuedQty.Name = "ColIssuedQty";
            this.ColIssuedQty.ReadOnly = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(826, 265);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 34);
            this.button2.TabIndex = 15;
            this.button2.Text = "Receive to Batch";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MRNO";
            this.dataGridViewTextBoxColumn2.HeaderText = "MRN No";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "MRDate";
            dataGridViewCellStyle6.Format = "d";
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewTextBoxColumn4.HeaderText = "Date";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "EnterdBy";
            this.dataGridViewTextBoxColumn5.HeaderText = "Request By";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 130;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "MRApprovedBy";
            this.dataGridViewTextBoxColumn6.HeaderText = "Certify By";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 130;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "MRRemarks";
            this.dataGridViewTextBoxColumn7.HeaderText = "Remarks";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "ItemCode";
            this.dataGridViewTextBoxColumn8.HeaderText = "Item";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn8.Width = 175;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn9.HeaderText = "Description of Item";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "UnitCode";
            this.dataGridViewTextBoxColumn10.HeaderText = "Unit";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "ReqdQty";
            this.dataGridViewTextBoxColumn11.HeaderText = "Reqd Qty.";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Width = 120;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "IssuedQty";
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            this.dataGridViewTextBoxColumn12.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewTextBoxColumn12.HeaderText = "Issued Qty";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // txtDepartment
            // 
            this.txtDepartment.Location = new System.Drawing.Point(579, 8);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.ReadOnly = true;
            this.txtDepartment.Size = new System.Drawing.Size(46, 20);
            this.txtDepartment.TabIndex = 6;
            this.txtDepartment.Visible = false;
            // 
            // txtStore
            // 
            this.txtStore.Location = new System.Drawing.Point(700, 12);
            this.txtStore.Name = "txtStore";
            this.txtStore.ReadOnly = true;
            this.txtStore.Size = new System.Drawing.Size(294, 20);
            this.txtStore.TabIndex = 7;
            this.txtStore.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(486, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Your Department";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(631, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Store Name";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "MR List to Receive";
            // 
            // frmMRReceive_toBatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 616);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtStore);
            this.Controls.Add(this.txtDepartment);
            this.Controls.Add(this.gvMRList);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMRReceive_toBatch";
            this.Text = "Raw Material Receive to Batch";
            this.Load += new System.EventHandler(this.frmMaterialsReceipt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvMRList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindMRList)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvItemList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindItemList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView gvMRList;
        private System.Windows.Forms.DataGridView gvItemList;
        private System.Windows.Forms.BindingSource bindMRList;
        private System.Windows.Forms.BindingSource bindItemList;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.TextBox txtStore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn BatchID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MRNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Part;
        private System.Windows.Forms.DataGridViewTextBoxColumn RequestedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn RequestedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn IssuedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn IssuedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColIssuedQty;
        private System.Windows.Forms.Label label3;
    }
}