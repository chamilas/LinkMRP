namespace MRP_GUI
{
    partial class frmWIP
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
            this.objSourceWIP = new System.Windows.Forms.BindingSource(this.components);
            this.objSourceWIPStock = new System.Windows.Forms.BindingSource(this.components);
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.cmbSections = new System.Windows.Forms.ComboBox();
            this.objSourceSections = new System.Windows.Forms.BindingSource(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.dgvWIP = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFinalQty = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgvWIPStock = new System.Windows.Forms.DataGridView();
            this.Material = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPrint = new System.Windows.Forms.Button();
            this.BatchStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BatchID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WIPQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceWIP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceWIPStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceSections)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWIP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWIPStock)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(766, -195);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(278, 21);
            this.textBox2.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(676, -363);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(278, 21);
            this.textBox4.TabIndex = 2;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(636, -124);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 21);
            this.textBox5.TabIndex = 2;
            // 
            // btnLoad
            // 
            this.btnLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoad.Location = new System.Drawing.Point(535, 8);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(106, 25);
            this.btnLoad.TabIndex = 188;
            this.btnLoad.Text = "Load Data";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // cmbSections
            // 
            this.cmbSections.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbSections.DisplayMember = "SectionName";
            this.cmbSections.FormattingEnabled = true;
            this.cmbSections.Location = new System.Drawing.Point(116, 10);
            this.cmbSections.Name = "cmbSections";
            this.cmbSections.Size = new System.Drawing.Size(413, 23);
            this.cmbSections.TabIndex = 189;
            this.cmbSections.ValueMember = "SectionID";
            this.cmbSections.SelectedIndexChanged += new System.EventHandler(this.cmbSections_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 15);
            this.label8.TabIndex = 190;
            this.label8.Text = "Section Name";
            // 
            // dgvWIP
            // 
            this.dgvWIP.AllowUserToAddRows = false;
            this.dgvWIP.AllowUserToDeleteRows = false;
            this.dgvWIP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvWIP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWIP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BatchStatus,
            this.BatchID,
            this.WIPQty,
            this.Unit});
            this.dgvWIP.Location = new System.Drawing.Point(12, 56);
            this.dgvWIP.Name = "dgvWIP";
            this.dgvWIP.ReadOnly = true;
            this.dgvWIP.Size = new System.Drawing.Size(768, 544);
            this.dgvWIP.TabIndex = 191;
            this.dgvWIP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWIP_CellClick);
            this.dgvWIP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWIP_CellContentClick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(656, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 192;
            this.label1.Text = "Final Qty";
            // 
            // txtFinalQty
            // 
            this.txtFinalQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFinalQty.Location = new System.Drawing.Point(716, 12);
            this.txtFinalQty.Name = "txtFinalQty";
            this.txtFinalQty.Size = new System.Drawing.Size(100, 21);
            this.txtFinalQty.TabIndex = 193;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(917, 10);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 194;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgvWIPStock
            // 
            this.dgvWIPStock.AllowUserToAddRows = false;
            this.dgvWIPStock.AllowUserToDeleteRows = false;
            this.dgvWIPStock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvWIPStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWIPStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Material,
            this.StockQty});
            this.dgvWIPStock.Location = new System.Drawing.Point(786, 56);
            this.dgvWIPStock.Name = "dgvWIPStock";
            this.dgvWIPStock.ReadOnly = true;
            this.dgvWIPStock.Size = new System.Drawing.Size(215, 544);
            this.dgvWIPStock.TabIndex = 195;
            // 
            // Material
            // 
            this.Material.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Material.DataPropertyName = "Material";
            this.Material.FillWeight = 200F;
            this.Material.HeaderText = "Material";
            this.Material.Name = "Material";
            this.Material.ReadOnly = true;
            // 
            // StockQty
            // 
            this.StockQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StockQty.DataPropertyName = "Qty";
            this.StockQty.HeaderText = "StockQty";
            this.StockQty.Name = "StockQty";
            this.StockQty.ReadOnly = true;
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.Location = new System.Drawing.Point(836, 11);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 196;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // BatchStatus
            // 
            this.BatchStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BatchStatus.DataPropertyName = "BatchStatus";
            this.BatchStatus.HeaderText = "Batch Status";
            this.BatchStatus.Name = "BatchStatus";
            this.BatchStatus.ReadOnly = true;
            // 
            // BatchID
            // 
            this.BatchID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BatchID.DataPropertyName = "BatchID";
            this.BatchID.HeaderText = "Batch ID";
            this.BatchID.Name = "BatchID";
            this.BatchID.ReadOnly = true;
            // 
            // WIPQty
            // 
            this.WIPQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.WIPQty.DataPropertyName = "WIPQty";
            this.WIPQty.HeaderText = "Basic Product WIP Quantity";
            this.WIPQty.Name = "WIPQty";
            this.WIPQty.ReadOnly = true;
            // 
            // Unit
            // 
            this.Unit.DataPropertyName = "Unit";
            this.Unit.HeaderText = "Unit";
            this.Unit.Name = "Unit";
            this.Unit.ReadOnly = true;
            // 
            // frmWIP
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1004, 612);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.dgvWIPStock);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtFinalQty);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvWIP);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbSections);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmWIP";
            this.Text = "Batch List";
            this.Load += new System.EventHandler(this.frmBatchList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.objSourceWIP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceWIPStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceSections)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWIP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWIPStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource objSourceWIP;
        private System.Windows.Forms.BindingSource objSourceWIPStock;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.ComboBox cmbSections;
        private System.Windows.Forms.BindingSource objSourceSections;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvWIP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFinalQty;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgvWIPStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Material;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockQty;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.DataGridViewTextBoxColumn BatchStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn BatchID;
        private System.Windows.Forms.DataGridViewTextBoxColumn WIPQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
    }
}