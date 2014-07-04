namespace MRP_GUI.Sales
{
    partial class frmSalesFinishProducts
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grid_change_price = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.grid_add_price = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid_change_price)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_add_price)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_change_price
            // 
            this.grid_change_price.AllowUserToAddRows = false;
            this.grid_change_price.AllowUserToDeleteRows = false;
            this.grid_change_price.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_change_price.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.grid_change_price.Location = new System.Drawing.Point(12, 33);
            this.grid_change_price.Name = "grid_change_price";
            this.grid_change_price.ReadOnly = true;
            this.grid_change_price.Size = new System.Drawing.Size(623, 216);
            this.grid_change_price.TabIndex = 0;
            this.grid_change_price.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_change_price_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "FinishProductCode";
            this.Column1.HeaderText = "Product ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "FinishedProductName";
            this.Column2.HeaderText = "Product Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "IsSellable";
            this.Column3.HeaderText = "State";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 110;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "MRP";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column4.HeaderText = "Selling Price (Rs.)";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 115;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Update";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 50;
            // 
            // grid_add_price
            // 
            this.grid_add_price.AllowUserToAddRows = false;
            this.grid_add_price.AllowUserToDeleteRows = false;
            this.grid_add_price.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_add_price.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column7,
            this.Column8});
            this.grid_add_price.Location = new System.Drawing.Point(12, 279);
            this.grid_add_price.Name = "grid_add_price";
            this.grid_add_price.ReadOnly = true;
            this.grid_add_price.Size = new System.Drawing.Size(623, 216);
            this.grid_add_price.TabIndex = 1;
            this.grid_add_price.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_add_price_CellClick);
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "FinishProductCode";
            this.Column6.HeaderText = "Product ID";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column7.DataPropertyName = "FinishProdutDescription";
            this.Column7.HeaderText = "Product Name";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Add Price";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Change Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Add Price";
            // 
            // frmSalesFinishProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 507);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grid_add_price);
            this.Controls.Add(this.grid_change_price);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmSalesFinishProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Finish Products";
            this.Load += new System.EventHandler(this.frmSalesFinishProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_change_price)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_add_price)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_change_price;
        private System.Windows.Forms.DataGridView grid_add_price;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewButtonColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewButtonColumn Column5;
    }
}