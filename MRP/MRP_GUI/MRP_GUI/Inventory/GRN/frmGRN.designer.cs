namespace MRP_GUI
{
    partial class frmGRN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGRN));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGRN = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSupplier = new System.Windows.Forms.TextBox();
            this.txtDeliverNote = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtStores = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.txtPONo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvItemList = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaterialCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaterialName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TGRNQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RejectQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.objSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGRN);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.dgvItemList);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1004, 612);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Good Receive Note";
            // 
            // btnGRN
            // 
            this.btnGRN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGRN.Location = new System.Drawing.Point(902, 567);
            this.btnGRN.Name = "btnGRN";
            this.btnGRN.Size = new System.Drawing.Size(94, 33);
            this.btnGRN.TabIndex = 14;
            this.btnGRN.Text = "GRN";
            this.btnGRN.UseVisualStyleBackColor = true;
            this.btnGRN.Click += new System.EventHandler(this.btnGRN_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Peru;
            this.panel1.Controls.Add(this.txtRemarks);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtSupplier);
            this.panel1.Controls.Add(this.txtDeliverNote);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtStores);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtDepartment);
            this.panel1.Controls.Add(this.txtPONo);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(12, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 139);
            this.panel1.TabIndex = 0;
            // 
            // txtSupplier
            // 
            this.txtSupplier.Location = new System.Drawing.Point(695, 89);
            this.txtSupplier.Name = "txtSupplier";
            this.txtSupplier.ReadOnly = true;
            this.txtSupplier.Size = new System.Drawing.Size(279, 26);
            this.txtSupplier.TabIndex = 14;
            // 
            // txtDeliverNote
            // 
            this.txtDeliverNote.Location = new System.Drawing.Point(111, 59);
            this.txtDeliverNote.Name = "txtDeliverNote";
            this.txtDeliverNote.Size = new System.Drawing.Size(506, 26);
            this.txtDeliverNote.TabIndex = 0;
            this.txtDeliverNote.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDeliverNote_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Department";
            // 
            // txtStores
            // 
            this.txtStores.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStores.Location = new System.Drawing.Point(695, 18);
            this.txtStores.Name = "txtStores";
            this.txtStores.ReadOnly = true;
            this.txtStores.Size = new System.Drawing.Size(279, 26);
            this.txtStores.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(622, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Supplier";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "PO No";
            // 
            // txtDepartment
            // 
            this.txtDepartment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDepartment.Location = new System.Drawing.Point(111, 21);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.ReadOnly = true;
            this.txtDepartment.Size = new System.Drawing.Size(506, 26);
            this.txtDepartment.TabIndex = 12;
            // 
            // txtPONo
            // 
            this.txtPONo.Location = new System.Drawing.Point(111, 95);
            this.txtPONo.Name = "txtPONo";
            this.txtPONo.Size = new System.Drawing.Size(176, 26);
            this.txtPONo.TabIndex = 1;
            this.txtPONo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPONo_KeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Deliver Note";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(623, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Stores";
            // 
            // dgvItemList
            // 
            this.dgvItemList.AllowUserToAddRows = false;
            this.dgvItemList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvItemList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvItemList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvItemList.AutoGenerateColumns = false;
            this.dgvItemList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItemList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.MaterialCode,
            this.MaterialName,
            this.Unit,
            this.TGRNQuantity,
            this.Select,
            this.Quantity,
            this.RejectQty,
            this.UnitPrice});
            this.dgvItemList.DataSource = this.objSource;
            this.dgvItemList.Location = new System.Drawing.Point(12, 176);
            this.dgvItemList.Name = "dgvItemList";
            this.dgvItemList.RowHeadersVisible = false;
            this.dgvItemList.RowTemplate.Height = 40;
            this.dgvItemList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItemList.Size = new System.Drawing.Size(984, 385);
            this.dgvItemList.TabIndex = 12;
            this.dgvItemList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvItemList_KeyDown);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // MaterialCode
            // 
            this.MaterialCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaterialCode.DataPropertyName = "MaterialCode";
            this.MaterialCode.HeaderText = "MaterialCode";
            this.MaterialCode.Name = "MaterialCode";
            this.MaterialCode.ReadOnly = true;
            // 
            // MaterialName
            // 
            this.MaterialName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaterialName.DataPropertyName = "MaterialDescription";
            this.MaterialName.FillWeight = 300F;
            this.MaterialName.HeaderText = "MaterialName";
            this.MaterialName.Name = "MaterialName";
            this.MaterialName.ReadOnly = true;
            // 
            // Unit
            // 
            this.Unit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Unit.DataPropertyName = "UnitCode";
            this.Unit.FillWeight = 50F;
            this.Unit.HeaderText = "Unit";
            this.Unit.Name = "Unit";
            this.Unit.ReadOnly = true;
            // 
            // TGRNQuantity
            // 
            this.TGRNQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TGRNQuantity.DataPropertyName = "Quantity";
            this.TGRNQuantity.HeaderText = "TGRN Quantity";
            this.TGRNQuantity.Name = "TGRNQuantity";
            this.TGRNQuantity.ReadOnly = true;
            // 
            // Select
            // 
            this.Select.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Select.FillWeight = 50F;
            this.Select.HeaderText = "Select";
            this.Select.Name = "Select";
            this.Select.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Select.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Quantity
            // 
            this.Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Quantity.DataPropertyName = "AcceptQty";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Format = "N3";
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.Quantity.DefaultCellStyle = dataGridViewCellStyle2;
            this.Quantity.HeaderText = "Accept Quantity";
            this.Quantity.Name = "Quantity";
            // 
            // RejectQty
            // 
            this.RejectQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RejectQty.DataPropertyName = "RejectQty";
            this.RejectQty.HeaderText = "RejectQty";
            this.RejectQty.Name = "RejectQty";
            // 
            // UnitPrice
            // 
            this.UnitPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UnitPrice.DataPropertyName = "ReworkUnitPrice";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.UnitPrice.DefaultCellStyle = dataGridViewCellStyle3;
            this.UnitPrice.HeaderText = "UnitPrice";
            this.UnitPrice.Name = "UnitPrice";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(623, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Remarks";
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(695, 57);
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(279, 26);
            this.txtRemarks.TabIndex = 16;
            // 
            // frmGRN
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1004, 612);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1020, 650);
            this.Name = "frmGRN";
            this.Text = "Purchase - GRN (Lab)";
            this.Load += new System.EventHandler(this.frmGRNMATDirect_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource objSource;
        private System.Windows.Forms.DataGridView dgvItemList;
        private System.Windows.Forms.TextBox txtPONo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.TextBox txtStores;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDeliverNote;
        private System.Windows.Forms.TextBox txtSupplier;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGRN;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaterialCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaterialName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn TGRNQuantity;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Select;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn RejectQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Label label3;
    }
}