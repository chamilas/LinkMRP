namespace MRP_GUI.Sales
{
    partial class frmCustomerState
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
            this.grid_deactive = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid_active = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid_deactive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_active)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_deactive
            // 
            this.grid_deactive.AllowUserToAddRows = false;
            this.grid_deactive.AllowUserToDeleteRows = false;
            this.grid_deactive.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_deactive.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.grid_deactive.Location = new System.Drawing.Point(12, 30);
            this.grid_deactive.Name = "grid_deactive";
            this.grid_deactive.ReadOnly = true;
            this.grid_deactive.Size = new System.Drawing.Size(300, 200);
            this.grid_deactive.TabIndex = 0;
            this.grid_deactive.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_deactive_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Deactive";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 75;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Customer_Code";
            this.Column2.HeaderText = "Customer ID";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 75;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "Name";
            this.Column3.HeaderText = "Customer Name";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // grid_active
            // 
            this.grid_active.AllowUserToAddRows = false;
            this.grid_active.AllowUserToDeleteRows = false;
            this.grid_active.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_active.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column5,
            this.Column6});
            this.grid_active.Location = new System.Drawing.Point(326, 30);
            this.grid_active.Name = "grid_active";
            this.grid_active.ReadOnly = true;
            this.grid_active.Size = new System.Drawing.Size(300, 200);
            this.grid_active.TabIndex = 1;
            this.grid_active.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_active_CellClick);
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Activate";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 75;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Customer_Code";
            this.Column5.HeaderText = "Customer ID";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 75;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.DataPropertyName = "Name";
            this.Column6.HeaderText = "Customer Name";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Deactivate Customer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(329, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Activate Customer";
            // 
            // frmCustomerState
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 240);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grid_active);
            this.Controls.Add(this.grid_deactive);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "frmCustomerState";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Active/Deactive";
            this.Load += new System.EventHandler(this.frmCustomerState_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_deactive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_active)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_deactive;
        private System.Windows.Forms.DataGridView grid_active;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewButtonColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}