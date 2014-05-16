namespace MRP_GUI
{
    partial class frmBinCards_Packing
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtvFromDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cmMaterial = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCurrentStock = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtROL = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEOQ = new System.Windows.Forms.TextBox();
            this.lblUnit1 = new System.Windows.Forms.Label();
            this.dgvBinCard = new System.Windows.Forms.DataGridView();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GRNNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GRNQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MRNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IssuedQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BatchNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.objSource = new System.Windows.Forms.BindingSource(this.components);
            this.objSourceMaterials = new System.Windows.Forms.BindingSource(this.components);
            this.txtMaterialCode = new System.Windows.Forms.TextBox();
            this.lblUnit2 = new System.Windows.Forms.Label();
            this.lblUnit3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtStore = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvBalanceStock = new System.Windows.Forms.DataGridView();
            this.BalancStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.objSourceBalanceStock = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBinCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceMaterials)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBalanceStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceBalanceStock)).BeginInit();
            this.SuspendLayout();
            // 
            // dtvFromDate
            // 
            this.dtvFromDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtvFromDate.Location = new System.Drawing.Point(109, 63);
            this.dtvFromDate.Name = "dtvFromDate";
            this.dtvFromDate.Size = new System.Drawing.Size(254, 21);
            this.dtvFromDate.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "From Date";
            // 
            // cmMaterial
            // 
            this.cmMaterial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmMaterial.DisplayMember = "MaterialDescription";
            this.cmMaterial.FormattingEnabled = true;
            this.cmMaterial.Location = new System.Drawing.Point(109, 102);
            this.cmMaterial.Name = "cmMaterial";
            this.cmMaterial.Size = new System.Drawing.Size(392, 23);
            this.cmMaterial.TabIndex = 2;
            this.cmMaterial.ValueMember = "MaterialCode";
            this.cmMaterial.SelectedIndexChanged += new System.EventHandler(this.cmMaterial_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Material Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Current Stock";
            // 
            // txtCurrentStock
            // 
            this.txtCurrentStock.Location = new System.Drawing.Point(153, 15);
            this.txtCurrentStock.Name = "txtCurrentStock";
            this.txtCurrentStock.ReadOnly = true;
            this.txtCurrentStock.Size = new System.Drawing.Size(127, 21);
            this.txtCurrentStock.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Unit Price";
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(155, 44);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.ReadOnly = true;
            this.txtUnitPrice.Size = new System.Drawing.Size(125, 21);
            this.txtUnitPrice.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Re-Order Level";
            // 
            // txtROL
            // 
            this.txtROL.Location = new System.Drawing.Point(155, 73);
            this.txtROL.Name = "txtROL";
            this.txtROL.ReadOnly = true;
            this.txtROL.Size = new System.Drawing.Size(125, 21);
            this.txtROL.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Economical Order Qty.";
            // 
            // txtEOQ
            // 
            this.txtEOQ.Location = new System.Drawing.Point(155, 102);
            this.txtEOQ.Name = "txtEOQ";
            this.txtEOQ.ReadOnly = true;
            this.txtEOQ.Size = new System.Drawing.Size(125, 21);
            this.txtEOQ.TabIndex = 12;
            // 
            // lblUnit1
            // 
            this.lblUnit1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUnit1.AutoSize = true;
            this.lblUnit1.Location = new System.Drawing.Point(290, 18);
            this.lblUnit1.Name = "lblUnit1";
            this.lblUnit1.Size = new System.Drawing.Size(21, 15);
            this.lblUnit1.TabIndex = 5;
            this.lblUnit1.Text = "<>";
            // 
            // dgvBinCard
            // 
            this.dgvBinCard.AllowUserToAddRows = false;
            this.dgvBinCard.AllowUserToDeleteRows = false;
            this.dgvBinCard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBinCard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBinCard.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.GRNNO,
            this.GRNQty,
            this.UnitPrice,
            this.MRNO,
            this.IssuedQty,
            this.BatchNo});
            this.dgvBinCard.Location = new System.Drawing.Point(15, 167);
            this.dgvBinCard.Name = "dgvBinCard";
            this.dgvBinCard.ReadOnly = true;
            this.dgvBinCard.Size = new System.Drawing.Size(819, 351);
            this.dgvBinCard.TabIndex = 15;
            // 
            // Date
            // 
            this.Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Date.DataPropertyName = "TheDate";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date.DefaultCellStyle = dataGridViewCellStyle1;
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // GRNNO
            // 
            this.GRNNO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GRNNO.DataPropertyName = "GRNNO";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.GRNNO.DefaultCellStyle = dataGridViewCellStyle2;
            this.GRNNO.HeaderText = "GRNNO";
            this.GRNNO.Name = "GRNNO";
            this.GRNNO.ReadOnly = true;
            // 
            // GRNQty
            // 
            this.GRNQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GRNQty.DataPropertyName = "GRNQty";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.Format = "N3";
            dataGridViewCellStyle3.NullValue = null;
            this.GRNQty.DefaultCellStyle = dataGridViewCellStyle3;
            this.GRNQty.HeaderText = "GRN Qty";
            this.GRNQty.Name = "GRNQty";
            this.GRNQty.ReadOnly = true;
            // 
            // UnitPrice
            // 
            this.UnitPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UnitPrice.DataPropertyName = "UnitPrice";
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.UnitPrice.DefaultCellStyle = dataGridViewCellStyle4;
            this.UnitPrice.HeaderText = "Unit Price";
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.ReadOnly = true;
            // 
            // MRNO
            // 
            this.MRNO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MRNO.DataPropertyName = "MRNO";
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.MRNO.DefaultCellStyle = dataGridViewCellStyle5;
            this.MRNO.HeaderText = "MRNO";
            this.MRNO.Name = "MRNO";
            this.MRNO.ReadOnly = true;
            // 
            // IssuedQty
            // 
            this.IssuedQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IssuedQty.DataPropertyName = "IssuedQty";
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle6.Format = "N3";
            dataGridViewCellStyle6.NullValue = null;
            this.IssuedQty.DefaultCellStyle = dataGridViewCellStyle6;
            this.IssuedQty.HeaderText = "Issued Qty";
            this.IssuedQty.Name = "IssuedQty";
            this.IssuedQty.ReadOnly = true;
            // 
            // BatchNo
            // 
            this.BatchNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BatchNo.DataPropertyName = "BatchNo";
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BatchNo.DefaultCellStyle = dataGridViewCellStyle7;
            this.BatchNo.HeaderText = "Batch No";
            this.BatchNo.Name = "BatchNo";
            this.BatchNo.ReadOnly = true;
            // 
            // txtMaterialCode
            // 
            this.txtMaterialCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaterialCode.Location = new System.Drawing.Point(518, 102);
            this.txtMaterialCode.Name = "txtMaterialCode";
            this.txtMaterialCode.Size = new System.Drawing.Size(136, 21);
            this.txtMaterialCode.TabIndex = 4;
            // 
            // lblUnit2
            // 
            this.lblUnit2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUnit2.AutoSize = true;
            this.lblUnit2.Location = new System.Drawing.Point(290, 73);
            this.lblUnit2.Name = "lblUnit2";
            this.lblUnit2.Size = new System.Drawing.Size(21, 15);
            this.lblUnit2.TabIndex = 5;
            this.lblUnit2.Text = "<>";
            // 
            // lblUnit3
            // 
            this.lblUnit3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUnit3.AutoSize = true;
            this.lblUnit3.Location = new System.Drawing.Point(290, 105);
            this.lblUnit3.Name = "lblUnit3";
            this.lblUnit3.Size = new System.Drawing.Size(21, 15);
            this.lblUnit3.TabIndex = 5;
            this.lblUnit3.Text = "<>";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(124, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 15);
            this.label9.TabIndex = 5;
            this.label9.Text = "Rs.";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 15);
            this.label10.TabIndex = 1;
            this.label10.Text = "Stores Name";
            // 
            // txtStore
            // 
            this.txtStore.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStore.Location = new System.Drawing.Point(109, 23);
            this.txtStore.Name = "txtStore";
            this.txtStore.Size = new System.Drawing.Size(254, 21);
            this.txtStore.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(380, 69);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(172, 15);
            this.label11.TabIndex = 1;
            this.label11.Text = "To Date is taken as Today";
            // 
            // lblDepartment
            // 
            this.lblDepartment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartment.Location = new System.Drawing.Point(389, 29);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(82, 15);
            this.lblDepartment.TabIndex = 1;
            this.lblDepartment.Text = "Department";
            // 
            // txtDepartment
            // 
            this.txtDepartment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDepartment.Location = new System.Drawing.Point(518, 23);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(136, 21);
            this.txtDepartment.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtEOQ);
            this.panel1.Controls.Add(this.lblUnit3);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lblUnit2);
            this.panel1.Controls.Add(this.txtCurrentStock);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtROL);
            this.panel1.Controls.Add(this.lblUnit1);
            this.panel1.Controls.Add(this.txtUnitPrice);
            this.panel1.Location = new System.Drawing.Point(660, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(332, 132);
            this.panel1.TabIndex = 17;
            // 
            // dgvBalanceStock
            // 
            this.dgvBalanceStock.AllowUserToAddRows = false;
            this.dgvBalanceStock.AllowUserToDeleteRows = false;
            this.dgvBalanceStock.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBalanceStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBalanceStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BalancStock});
            this.dgvBalanceStock.Location = new System.Drawing.Point(844, 167);
            this.dgvBalanceStock.Name = "dgvBalanceStock";
            this.dgvBalanceStock.ReadOnly = true;
            this.dgvBalanceStock.Size = new System.Drawing.Size(148, 351);
            this.dgvBalanceStock.TabIndex = 19;
            // 
            // BalancStock
            // 
            this.BalancStock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BalancStock.DataPropertyName = "BalanceStock";
            dataGridViewCellStyle8.Format = "N3";
            dataGridViewCellStyle8.NullValue = null;
            this.BalancStock.DefaultCellStyle = dataGridViewCellStyle8;
            this.BalancStock.HeaderText = "BalanceStock";
            this.BalancStock.Name = "BalancStock";
            this.BalancStock.ReadOnly = true;
            // 
            // frmBinCards_Packing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 530);
            this.Controls.Add(this.dgvBalanceStock);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtDepartment);
            this.Controls.Add(this.txtStore);
            this.Controls.Add(this.txtMaterialCode);
            this.Controls.Add(this.dgvBinCard);
            this.Controls.Add(this.cmMaterial);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtvFromDate);
            this.Controls.Add(this.lblDepartment);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmBinCards_Packing";
            this.Text = "Bin Card";
            this.Load += new System.EventHandler(this.frmBinCard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBinCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceMaterials)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBalanceStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceBalanceStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtvFromDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmMaterial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCurrentStock;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtROL;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEOQ;
        private System.Windows.Forms.Label lblUnit1;
        private System.Windows.Forms.DataGridView dgvBinCard;
        private System.Windows.Forms.BindingSource objSource;
        private System.Windows.Forms.BindingSource objSourceMaterials;
        private System.Windows.Forms.TextBox txtMaterialCode;
        private System.Windows.Forms.Label lblUnit2;
        private System.Windows.Forms.Label lblUnit3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtStore;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn GRNNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn GRNQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn MRNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn IssuedQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn BatchNo;
        private System.Windows.Forms.DataGridView dgvBalanceStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn BalancStock;
        private System.Windows.Forms.BindingSource objSourceBalanceStock;
    }
}