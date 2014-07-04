namespace MRP_GUI.Sales
{
    partial class frmOrderSorting
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
            this.grid_unsortedOrders = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grid_unsortedOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_unsortedOrders
            // 
            this.grid_unsortedOrders.AllowUserToAddRows = false;
            this.grid_unsortedOrders.AllowUserToDeleteRows = false;
            this.grid_unsortedOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_unsortedOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3,
            this.Column4,
            this.Column5});
            this.grid_unsortedOrders.Location = new System.Drawing.Point(21, 42);
            this.grid_unsortedOrders.Name = "grid_unsortedOrders";
            this.grid_unsortedOrders.ReadOnly = true;
            this.grid_unsortedOrders.Size = new System.Drawing.Size(601, 340);
            this.grid_unsortedOrders.TabIndex = 2;
            this.grid_unsortedOrders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_unsortedOrders_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "OrderID";
            this.Column1.HeaderText = "Order ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "Name";
            this.Column3.HeaderText = "Customer Name";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "count";
            this.Column4.HeaderText = "Number of Items";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 130;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Assign Quantity for Order";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 130;
            // 
            // frmOrderSorting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 406);
            this.Controls.Add(this.grid_unsortedOrders);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmOrderSorting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order Sorting";
            ((System.ComponentModel.ISupportInitialize)(this.grid_unsortedOrders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_unsortedOrders;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewButtonColumn Column5;
    }
}