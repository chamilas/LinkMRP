namespace MRP_GUI
{
    partial class frmGRNApproval_FG
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGRNApproval_FG));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMTNNO = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStore = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.gvItemList = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindItemList = new System.Windows.Forms.BindingSource(this.components);
            this.txtBatchNo = new System.Windows.Forms.TextBox();
            this.txtGRNNO = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gvGRNList = new System.Windows.Forms.DataGridView();
            this.ColGRNNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColRecevedBY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindGRNList = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvItemList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindItemList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvGRNList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindGRNList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMTNNO);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtStore);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.gvItemList);
            this.groupBox1.Controls.Add(this.txtBatchNo);
            this.groupBox1.Controls.Add(this.txtGRNNO);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.gvGRNList);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1002, 616);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Good Receive Notes";
            // 
            // txtMTNNO
            // 
            this.txtMTNNO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMTNNO.Location = new System.Drawing.Point(740, 118);
            this.txtMTNNO.Name = "txtMTNNO";
            this.txtMTNNO.ReadOnly = true;
            this.txtMTNNO.Size = new System.Drawing.Size(247, 21);
            this.txtMTNNO.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(657, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 20;
            this.label3.Text = "MTNNO";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(657, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "Batch No";
            // 
            // txtStore
            // 
            this.txtStore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStore.Location = new System.Drawing.Point(740, 28);
            this.txtStore.Name = "txtStore";
            this.txtStore.ReadOnly = true;
            this.txtStore.Size = new System.Drawing.Size(247, 22);
            this.txtStore.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(657, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Store";
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(15, 570);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 42);
            this.button3.TabIndex = 15;
            this.button3.Text = "Reject";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(831, 569);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 43);
            this.button2.TabIndex = 14;
            this.button2.Text = "Approve";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(912, 570);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 42);
            this.button1.TabIndex = 13;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.Column2,
            this.Column1,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            this.gvItemList.DataSource = this.bindItemList;
            this.gvItemList.Location = new System.Drawing.Point(12, 301);
            this.gvItemList.Name = "gvItemList";
            this.gvItemList.ReadOnly = true;
            this.gvItemList.RowHeadersVisible = false;
            this.gvItemList.RowTemplate.Height = 23;
            this.gvItemList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvItemList.Size = new System.Drawing.Size(975, 262);
            this.gvItemList.TabIndex = 11;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "ItemCode";
            this.Column2.HeaderText = "Item Code";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ItemName";
            this.Column1.HeaderText = "Item";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 200;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "GrossQty";
            dataGridViewCellStyle2.Format = "N3";
            dataGridViewCellStyle2.NullValue = null;
            this.Column7.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column7.HeaderText = "Qty Gross";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 130;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "NetQty";
            dataGridViewCellStyle3.Format = "N3";
            dataGridViewCellStyle3.NullValue = null;
            this.Column8.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column8.HeaderText = "Qty Net";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 130;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "UnitPrice";
            dataGridViewCellStyle4.Format = "N2";
            this.Column9.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column9.HeaderText = "Price";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 130;
            // 
            // Column10
            // 
            this.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column10.DataPropertyName = "Remarks";
            this.Column10.HeaderText = "Remarks";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // txtBatchNo
            // 
            this.txtBatchNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBatchNo.Location = new System.Drawing.Point(740, 158);
            this.txtBatchNo.Name = "txtBatchNo";
            this.txtBatchNo.ReadOnly = true;
            this.txtBatchNo.Size = new System.Drawing.Size(247, 21);
            this.txtBatchNo.TabIndex = 3;
            // 
            // txtGRNNO
            // 
            this.txtGRNNO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGRNNO.Location = new System.Drawing.Point(740, 81);
            this.txtGRNNO.Name = "txtGRNNO";
            this.txtGRNNO.ReadOnly = true;
            this.txtGRNNO.Size = new System.Drawing.Size(247, 21);
            this.txtGRNNO.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(657, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "GRN No";
            // 
            // gvGRNList
            // 
            this.gvGRNList.AllowUserToAddRows = false;
            this.gvGRNList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gvGRNList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.gvGRNList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvGRNList.AutoGenerateColumns = false;
            this.gvGRNList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvGRNList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColGRNNO,
            this.ColDate,
            this.ColRecevedBY});
            this.gvGRNList.DataSource = this.bindGRNList;
            this.gvGRNList.Location = new System.Drawing.Point(12, 26);
            this.gvGRNList.Name = "gvGRNList";
            this.gvGRNList.ReadOnly = true;
            this.gvGRNList.RowHeadersVisible = false;
            this.gvGRNList.RowTemplate.Height = 23;
            this.gvGRNList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvGRNList.Size = new System.Drawing.Size(619, 255);
            this.gvGRNList.TabIndex = 0;
            this.gvGRNList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvGRNList_CellClick);
            // 
            // ColGRNNO
            // 
            this.ColGRNNO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColGRNNO.DataPropertyName = "GRNNO";
            this.ColGRNNO.HeaderText = "GRNNO";
            this.ColGRNNO.Name = "ColGRNNO";
            this.ColGRNNO.ReadOnly = true;
            // 
            // ColDate
            // 
            this.ColDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColDate.DataPropertyName = "GRNDate";
            dataGridViewCellStyle6.Format = "d";
            this.ColDate.DefaultCellStyle = dataGridViewCellStyle6;
            this.ColDate.HeaderText = "Entered Date";
            this.ColDate.Name = "ColDate";
            this.ColDate.ReadOnly = true;
            // 
            // ColRecevedBY
            // 
            this.ColRecevedBY.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColRecevedBY.DataPropertyName = "EnterdByName";
            this.ColRecevedBY.HeaderText = "Entered By";
            this.ColRecevedBY.Name = "ColRecevedBY";
            this.ColRecevedBY.ReadOnly = true;
            // 
            // frmGRN_FG_Herbal_Approval
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1002, 616);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGRN_FG_Herbal_Approval";
            this.Text = "GRN Approval";
            this.Load += new System.EventHandler(this.frmGRNApproval_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvItemList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindItemList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvGRNList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindGRNList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtGRNNO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gvGRNList;
        private System.Windows.Forms.DataGridView gvItemList;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.BindingSource bindGRNList;
        private System.Windows.Forms.BindingSource bindItemList;
        private System.Windows.Forms.TextBox txtStore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBatchNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColGRNNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColRecevedBY;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.TextBox txtMTNNO;
        private System.Windows.Forms.Label label3;
    }
}