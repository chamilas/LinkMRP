namespace MRP_GUI.Components.MaterialSelection
{
    partial class frmMaterialList
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
            this.txtmat = new System.Windows.Forms.TextBox();
            this.gvMaterials = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindMaterials = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gvMaterials)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindMaterials)).BeginInit();
            this.SuspendLayout();
            // 
            // txtmat
            // 
            this.txtmat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtmat.Location = new System.Drawing.Point(0, 0);
            this.txtmat.Name = "txtmat";
            this.txtmat.Size = new System.Drawing.Size(444, 20);
            this.txtmat.TabIndex = 0;
            this.txtmat.TextChanged += new System.EventHandler(this.txtmat_TextChanged);
            this.txtmat.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtmat_KeyDown);
            this.txtmat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmat_KeyPress);
            // 
            // gvMaterials
            // 
            this.gvMaterials.AllowUserToAddRows = false;
            this.gvMaterials.AllowUserToDeleteRows = false;
            this.gvMaterials.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gvMaterials.AutoGenerateColumns = false;
            this.gvMaterials.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvMaterials.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.gvMaterials.DataSource = this.bindMaterials;
            this.gvMaterials.Location = new System.Drawing.Point(0, 20);
            this.gvMaterials.Name = "gvMaterials";
            this.gvMaterials.ReadOnly = true;
            this.gvMaterials.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvMaterials.RowTemplate.Height = 20;
            this.gvMaterials.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvMaterials.Size = new System.Drawing.Size(470, 130);
            this.gvMaterials.TabIndex = 1;
            this.gvMaterials.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvMaterials_CellClick);
            this.gvMaterials.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gvMaterials_KeyDown);
            this.gvMaterials.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gvMaterials_KeyPress);
            this.gvMaterials.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gvMaterials_KeyUp);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaterialCode";
            this.Column1.HeaderText = "Code";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "Material";
            this.Column2.HeaderText = "Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(445, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 20);
            this.button1.TabIndex = 2;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaterialCode";
            this.dataGridViewTextBoxColumn1.HeaderText = "Code";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Material";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // frmMaterialList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 150);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gvMaterials);
            this.Controls.Add(this.txtmat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMaterialList";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Materials";
            this.Load += new System.EventHandler(this.frmMaterialList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvMaterials)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindMaterials)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtmat;
        private System.Windows.Forms.DataGridView gvMaterials;
        private System.Windows.Forms.BindingSource bindMaterials;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button button1;
    }
}