namespace MRP_GUI
{
    partial class frmPOSelection
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtPONO = new System.Windows.Forms.TextBox();
            this.dgvPOs = new System.Windows.Forms.DataGridView();
            this.objSource = new System.Windows.Forms.BindingSource(this.components);
            this.PONO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPOs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "PONO";
            // 
            // txtPONO
            // 
            this.txtPONO.Location = new System.Drawing.Point(65, 23);
            this.txtPONO.Name = "txtPONO";
            this.txtPONO.Size = new System.Drawing.Size(422, 22);
            this.txtPONO.TabIndex = 1;
            this.txtPONO.TextChanged += new System.EventHandler(this.txtSupplier_TextChanged);
            this.txtPONO.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSupplier_KeyDown);
            // 
            // dgvPOs
            // 
            this.dgvPOs.AllowUserToAddRows = false;
            this.dgvPOs.AllowUserToDeleteRows = false;
            this.dgvPOs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPOs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPOs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PONO,
            this.SupplierCode,
            this.SupplierName});
            this.dgvPOs.Location = new System.Drawing.Point(12, 68);
            this.dgvPOs.Name = "dgvPOs";
            this.dgvPOs.ReadOnly = true;
            this.dgvPOs.Size = new System.Drawing.Size(697, 325);
            this.dgvPOs.TabIndex = 2;
            this.dgvPOs.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvSuppliers_KeyDown);
            // 
            // PONO
            // 
            this.PONO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PONO.DataPropertyName = "PONO";
            this.PONO.HeaderText = "PONO";
            this.PONO.Name = "PONO";
            this.PONO.ReadOnly = true;
            // 
            // SupplierCode
            // 
            this.SupplierCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SupplierCode.DataPropertyName = "SupplierCode";
            this.SupplierCode.HeaderText = "SupplierCode";
            this.SupplierCode.Name = "SupplierCode";
            this.SupplierCode.ReadOnly = true;
            this.SupplierCode.Visible = false;
            // 
            // SupplierName
            // 
            this.SupplierName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SupplierName.DataPropertyName = "SupName";
            this.SupplierName.FillWeight = 300F;
            this.SupplierName.HeaderText = "SupplierName";
            this.SupplierName.Name = "SupplierName";
            this.SupplierName.ReadOnly = true;
            // 
            // frmPOSelection
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(721, 405);
            this.Controls.Add(this.dgvPOs);
            this.Controls.Add(this.txtPONO);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmPOSelection";
            this.Text = "PO Selection";
            this.Load += new System.EventHandler(this.frmSupplierSelection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPOs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPONO;
        private System.Windows.Forms.DataGridView dgvPOs;
        private System.Windows.Forms.BindingSource objSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn PONO;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierName;
    }
}