namespace MRP_GUI
{
    partial class frmMTNApproval
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMTNApproval));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnViewBatch = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gvItemList = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindItemList = new System.Windows.Forms.BindingSource(this.components);
            this.btnReject = new System.Windows.Forms.Button();
            this.btnApprove = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.gvMTNList = new System.Windows.Forms.DataGridView();
            this.MTNNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BatchID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BatchNo_Packing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindMTNList = new System.Windows.Forms.BindingSource(this.components);
            this.bindDepartment = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvItemList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindItemList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMTNList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindMTNList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindDepartment)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnViewBatch);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.gvMTNList);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1002, 616);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Material Transfer Note - Authorizing";
            // 
            // btnViewBatch
            // 
            this.btnViewBatch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnViewBatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewBatch.Location = new System.Drawing.Point(930, 19);
            this.btnViewBatch.Name = "btnViewBatch";
            this.btnViewBatch.Size = new System.Drawing.Size(66, 282);
            this.btnViewBatch.TabIndex = 2;
            this.btnViewBatch.Text = "View Batch Details";
            this.btnViewBatch.UseVisualStyleBackColor = true;
            this.btnViewBatch.Click += new System.EventHandler(this.btnViewBatch_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.gvItemList);
            this.groupBox2.Controls.Add(this.btnReject);
            this.groupBox2.Controls.Add(this.btnApprove);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(12, 307);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(978, 303);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Approve";
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
            this.Column7,
            this.Column9});
            this.gvItemList.DataSource = this.bindItemList;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvItemList.DefaultCellStyle = dataGridViewCellStyle3;
            this.gvItemList.Location = new System.Drawing.Point(9, 32);
            this.gvItemList.Name = "gvItemList";
            this.gvItemList.ReadOnly = true;
            this.gvItemList.RowHeadersVisible = false;
            this.gvItemList.RowTemplate.Height = 30;
            this.gvItemList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvItemList.Size = new System.Drawing.Size(963, 236);
            this.gvItemList.TabIndex = 15;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column7.DataPropertyName = "Code";
            this.Column7.FillWeight = 300F;
            this.Column7.HeaderText = "Item";
            this.Column7.MinimumWidth = 300;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Column9
            // 
            this.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column9.DataPropertyName = "MTNTransferQty";
            dataGridViewCellStyle2.Format = "N3";
            dataGridViewCellStyle2.NullValue = null;
            this.Column9.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column9.HeaderText = "Transfer Qty";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // btnReject
            // 
            this.btnReject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReject.Location = new System.Drawing.Point(735, 274);
            this.btnReject.Name = "btnReject";
            this.btnReject.Size = new System.Drawing.Size(75, 23);
            this.btnReject.TabIndex = 14;
            this.btnReject.Text = "Reject";
            this.btnReject.UseVisualStyleBackColor = true;
            this.btnReject.Click += new System.EventHandler(this.btnReject_Click);
            // 
            // btnApprove
            // 
            this.btnApprove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApprove.Location = new System.Drawing.Point(816, 274);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(75, 23);
            this.btnApprove.TabIndex = 13;
            this.btnApprove.Text = "Approve";
            this.btnApprove.UseVisualStyleBackColor = true;
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(897, 274);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Material List";
            // 
            // gvMTNList
            // 
            this.gvMTNList.AllowUserToAddRows = false;
            this.gvMTNList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gvMTNList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gvMTNList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvMTNList.AutoGenerateColumns = false;
            this.gvMTNList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvMTNList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MTNNO,
            this.Column3,
            this.Column4,
            this.Column5,
            this.BatchID,
            this.BatchNo_Packing});
            this.gvMTNList.DataSource = this.bindMTNList;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvMTNList.DefaultCellStyle = dataGridViewCellStyle7;
            this.gvMTNList.Location = new System.Drawing.Point(12, 19);
            this.gvMTNList.Name = "gvMTNList";
            this.gvMTNList.ReadOnly = true;
            this.gvMTNList.RowHeadersVisible = false;
            this.gvMTNList.RowTemplate.Height = 30;
            this.gvMTNList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvMTNList.Size = new System.Drawing.Size(912, 282);
            this.gvMTNList.TabIndex = 0;
            this.gvMTNList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvMTNList_CellClick);
            // 
            // MTNNO
            // 
            this.MTNNO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MTNNO.DataPropertyName = "MTNNO";
            this.MTNNO.HeaderText = "MTN No.";
            this.MTNNO.Name = "MTNNO";
            this.MTNNO.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "DepNameTo";
            this.Column3.HeaderText = "To";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "MTNDate";
            dataGridViewCellStyle5.Format = "d";
            this.Column4.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column4.HeaderText = "Date";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.DataPropertyName = "MTNEnterdByName";
            this.Column5.HeaderText = "Enterd By";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // BatchID
            // 
            this.BatchID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BatchID.DataPropertyName = "MTNBatchID";
            dataGridViewCellStyle6.NullValue = "N/A";
            this.BatchID.DefaultCellStyle = dataGridViewCellStyle6;
            this.BatchID.HeaderText = "Batch No";
            this.BatchID.Name = "BatchID";
            this.BatchID.ReadOnly = true;
            // 
            // BatchNo_Packing
            // 
            this.BatchNo_Packing.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BatchNo_Packing.DataPropertyName = "BatchID";
            this.BatchNo_Packing.HeaderText = "Batch No ";
            this.BatchNo_Packing.Name = "BatchNo_Packing";
            this.BatchNo_Packing.ReadOnly = true;
            // 
            // frmMTNApproval
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 616);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMTNApproval";
            this.Text = "Material Transfer Note - Authorizing";
            this.Load += new System.EventHandler(this.frmMTNApproval_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvItemList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindItemList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMTNList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindMTNList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindDepartment)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView gvMTNList;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnReject;
        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView gvItemList;
        private System.Windows.Forms.BindingSource bindDepartment;
        private System.Windows.Forms.BindingSource bindMTNList;
        private System.Windows.Forms.BindingSource bindItemList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.Button btnViewBatch;
        private System.Windows.Forms.DataGridViewTextBoxColumn MTNNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn BatchID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BatchNo_Packing;
    }
}