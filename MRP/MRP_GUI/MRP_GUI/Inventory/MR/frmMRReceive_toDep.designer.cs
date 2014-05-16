namespace MRP_GUI
{
    partial class frmMRReceive_toDep
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMRReceive_toDep));
            this.gvMRList = new System.Windows.Forms.DataGridView();
            this.MRNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MRDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindMRList = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gvItemList = new System.Windows.Forms.DataGridView();
            this.ColMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColIssuedQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindItemList = new System.Windows.Forms.BindingSource(this.components);
            this.btnReceive = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
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
            this.txtStore = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.objSourceDepartments = new System.Windows.Forms.BindingSource(this.components);
            this.txtDepartment = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gvMRList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindMRList)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvItemList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindItemList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceDepartments)).BeginInit();
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
            this.MRNO,
            this.MRDate,
            this.Column4,
            this.Column12});
            this.gvMRList.DataSource = this.bindMRList;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvMRList.DefaultCellStyle = dataGridViewCellStyle3;
            this.gvMRList.Location = new System.Drawing.Point(12, 53);
            this.gvMRList.MultiSelect = false;
            this.gvMRList.Name = "gvMRList";
            this.gvMRList.ReadOnly = true;
            this.gvMRList.RowHeadersVisible = false;
            this.gvMRList.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvMRList.RowTemplate.Height = 30;
            this.gvMRList.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gvMRList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvMRList.Size = new System.Drawing.Size(982, 249);
            this.gvMRList.TabIndex = 5;
            this.gvMRList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvMRList_CellClick);
            // 
            // MRNO
            // 
            this.MRNO.DataPropertyName = "MRNO";
            this.MRNO.HeaderText = "MRN No";
            this.MRNO.Name = "MRNO";
            this.MRNO.ReadOnly = true;
            // 
            // MRDate
            // 
            this.MRDate.DataPropertyName = "MRDate";
            dataGridViewCellStyle2.Format = "d";
            this.MRDate.DefaultCellStyle = dataGridViewCellStyle2;
            this.MRDate.HeaderText = "Date";
            this.MRDate.Name = "MRDate";
            this.MRDate.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "MREnterdBy";
            this.Column4.HeaderText = "Request By";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 130;
            // 
            // Column12
            // 
            this.Column12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column12.DataPropertyName = "MRRemarks";
            this.Column12.HeaderText = "Remarks";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.gvItemList);
            this.groupBox2.Controls.Add(this.btnReceive);
            this.groupBox2.Controls.Add(this.btnClose);
            this.groupBox2.Location = new System.Drawing.Point(12, 308);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(988, 305);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Material List";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
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
            this.dataGridViewTextBoxColumn1,
            this.Column3,
            this.dataGridViewTextBoxColumn3,
            this.ColIssuedQty});
            this.gvItemList.DataSource = this.bindItemList;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvItemList.DefaultCellStyle = dataGridViewCellStyle6;
            this.gvItemList.Location = new System.Drawing.Point(6, 19);
            this.gvItemList.Name = "gvItemList";
            this.gvItemList.ReadOnly = true;
            this.gvItemList.RowHeadersVisible = false;
            this.gvItemList.RowTemplate.Height = 30;
            this.gvItemList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvItemList.Size = new System.Drawing.Size(972, 251);
            this.gvItemList.TabIndex = 46;
            // 
            // ColMaterial
            // 
            this.ColMaterial.DataPropertyName = "MRMaterialCode";
            this.ColMaterial.HeaderText = "Item";
            this.ColMaterial.Name = "ColMaterial";
            this.ColMaterial.ReadOnly = true;
            this.ColMaterial.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColMaterial.Width = 175;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MRDescription";
            this.dataGridViewTextBoxColumn1.HeaderText = "Description of Item";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
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
            dataGridViewCellStyle4.Format = "N3";
            dataGridViewCellStyle4.NullValue = null;
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTextBoxColumn3.HeaderText = "Reqd Qty.";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 120;
            // 
            // ColIssuedQty
            // 
            this.ColIssuedQty.DataPropertyName = "MRIssuedQty";
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Format = "N3";
            dataGridViewCellStyle5.NullValue = null;
            this.ColIssuedQty.DefaultCellStyle = dataGridViewCellStyle5;
            this.ColIssuedQty.HeaderText = "Issued Qty";
            this.ColIssuedQty.Name = "ColIssuedQty";
            this.ColIssuedQty.ReadOnly = true;
            // 
            // btnReceive
            // 
            this.btnReceive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReceive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReceive.Location = new System.Drawing.Point(788, 276);
            this.btnReceive.Name = "btnReceive";
            this.btnReceive.Size = new System.Drawing.Size(113, 23);
            this.btnReceive.TabIndex = 15;
            this.btnReceive.Text = "Receive";
            this.btnReceive.UseVisualStyleBackColor = true;
            this.btnReceive.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(907, 276);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.button1_Click);
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
            dataGridViewCellStyle7.Format = "d";
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle7;
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
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            this.dataGridViewTextBoxColumn12.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewTextBoxColumn12.HeaderText = "Issued Qty";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // txtStore
            // 
            this.txtStore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStore.Location = new System.Drawing.Point(636, 12);
            this.txtStore.Name = "txtStore";
            this.txtStore.ReadOnly = true;
            this.txtStore.Size = new System.Drawing.Size(358, 22);
            this.txtStore.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Your Department";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(539, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Store Name";
            // 
            // txtDepartment
            // 
            this.txtDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepartment.Location = new System.Drawing.Point(133, 12);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.ReadOnly = true;
            this.txtDepartment.Size = new System.Drawing.Size(372, 22);
            this.txtDepartment.TabIndex = 9;
            // 
            // frmMRReceive_toDep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 616);
            this.Controls.Add(this.txtDepartment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtStore);
            this.Controls.Add(this.gvMRList);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMRReceive_toDep";
            this.Text = "MR -GRN Material";
            this.Load += new System.EventHandler(this.frmMaterialsReceipt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvMRList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindMRList)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvItemList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindItemList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceDepartments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnReceive;
        private System.Windows.Forms.Button btnClose;
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
        private System.Windows.Forms.TextBox txtStore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource objSourceDepartments;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColIssuedQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn MRNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn MRDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
    }
}