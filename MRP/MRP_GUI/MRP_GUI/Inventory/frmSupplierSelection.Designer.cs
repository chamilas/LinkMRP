namespace MRP_GUI
{
    partial class frmSupplierSelection
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
            this.txtSupplier = new System.Windows.Forms.TextBox();
            this.dgvSuppliers = new System.Windows.Forms.DataGridView();
            this.objSource = new System.Windows.Forms.BindingSource(this.components);
            this.SupID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuppliers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Supplier Name";
            // 
            // txtSupplier
            // 
            this.txtSupplier.Location = new System.Drawing.Point(129, 29);
            this.txtSupplier.Name = "txtSupplier";
            this.txtSupplier.Size = new System.Drawing.Size(580, 22);
            this.txtSupplier.TabIndex = 1;
            this.txtSupplier.TextChanged += new System.EventHandler(this.txtSupplier_TextChanged);
            this.txtSupplier.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSupplier_KeyDown);
            // 
            // dgvSuppliers
            // 
            this.dgvSuppliers.AllowUserToAddRows = false;
            this.dgvSuppliers.AllowUserToDeleteRows = false;
            this.dgvSuppliers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSuppliers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SupID,
            this.SupplierCode,
            this.SupplierName});
            this.dgvSuppliers.Location = new System.Drawing.Point(12, 68);
            this.dgvSuppliers.Name = "dgvSuppliers";
            this.dgvSuppliers.ReadOnly = true;
            this.dgvSuppliers.Size = new System.Drawing.Size(697, 325);
            this.dgvSuppliers.TabIndex = 2;
            this.dgvSuppliers.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvSuppliers_KeyDown);
            // 
            // SupID
            // 
            this.SupID.DataPropertyName = "SupplierID";
            this.SupID.HeaderText = "SupID";
            this.SupID.Name = "SupID";
            this.SupID.ReadOnly = true;
            this.SupID.Visible = false;
            // 
            // SupplierCode
            // 
            this.SupplierCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SupplierCode.DataPropertyName = "SupplierCode";
            this.SupplierCode.HeaderText = "SupplierCode";
            this.SupplierCode.Name = "SupplierCode";
            this.SupplierCode.ReadOnly = true;
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
            // frmSupplierSelection
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(721, 405);
            this.Controls.Add(this.dgvSuppliers);
            this.Controls.Add(this.txtSupplier);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmSupplierSelection";
            this.Text = "Supplier Selection";
            this.Load += new System.EventHandler(this.frmSupplierSelection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuppliers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSupplier;
        private System.Windows.Forms.DataGridView dgvSuppliers;
        private System.Windows.Forms.BindingSource objSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierName;
    }
}