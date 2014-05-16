namespace MRP_GUI
{
    partial class frmPOMaterialSelection
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
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.objSource = new System.Windows.Forms.BindingSource(this.components);
            this.MaterialCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Material = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.POQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(102, 14);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(604, 22);
            this.txtItemName.TabIndex = 0;
            this.txtItemName.TextChanged += new System.EventHandler(this.txtItemName_TextChanged);
            this.txtItemName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtItemName_KeyDown);
            // 
            // dgvItems
            // 
            this.dgvItems.AllowUserToAddRows = false;
            this.dgvItems.AllowUserToDeleteRows = false;
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaterialCode,
            this.Material,
            this.POQty});
            this.dgvItems.Location = new System.Drawing.Point(16, 56);
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.ReadOnly = true;
            this.dgvItems.Size = new System.Drawing.Size(690, 305);
            this.dgvItems.TabIndex = 2;
            this.dgvItems.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvItems_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Material";
            // 
            // MaterialCode
            // 
            this.MaterialCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaterialCode.DataPropertyName = "MaterialCode";
            this.MaterialCode.HeaderText = "MaterialCode";
            this.MaterialCode.Name = "MaterialCode";
            this.MaterialCode.ReadOnly = true;
            this.MaterialCode.Visible = false;
            // 
            // Material
            // 
            this.Material.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Material.DataPropertyName = "Material";
            this.Material.FillWeight = 300F;
            this.Material.HeaderText = "Material";
            this.Material.Name = "Material";
            this.Material.ReadOnly = true;
            // 
            // POQty
            // 
            this.POQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.POQty.DataPropertyName = "POQty";
            this.POQty.HeaderText = "POQty";
            this.POQty.Name = "POQty";
            this.POQty.ReadOnly = true;
            // 
            // frmPOMaterialSelection
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(718, 373);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvItems);
            this.Controls.Add(this.txtItemName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmPOMaterialSelection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PO Material Selection";
            this.Load += new System.EventHandler(this.frmSupplierSelection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.BindingSource objSourceItems;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource objSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaterialCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Material;
        private System.Windows.Forms.DataGridViewTextBoxColumn POQty;
    }
}