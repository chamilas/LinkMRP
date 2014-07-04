namespace MRP_GUI.Sales
{
    partial class frmAssignQuantity
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
            this.grid_sorting = new System.Windows.Forms.DataGridView();
            this.btn_submit = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_orderID = new System.Windows.Forms.TextBox();
            this.Column5 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grid_sorting)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_sorting
            // 
            this.grid_sorting.AllowUserToAddRows = false;
            this.grid_sorting.AllowUserToDeleteRows = false;
            this.grid_sorting.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_sorting.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.grid_sorting.Location = new System.Drawing.Point(27, 39);
            this.grid_sorting.Name = "grid_sorting";
            this.grid_sorting.Size = new System.Drawing.Size(637, 295);
            this.grid_sorting.TabIndex = 0;
            this.grid_sorting.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_sorting_CellClick);
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(508, 340);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(75, 23);
            this.btn_submit.TabIndex = 1;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(589, 340);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 2;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Order ID";
            // 
            // txt_orderID
            // 
            this.txt_orderID.Enabled = false;
            this.txt_orderID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_orderID.Location = new System.Drawing.Point(87, 10);
            this.txt_orderID.Name = "txt_orderID";
            this.txt_orderID.Size = new System.Drawing.Size(148, 20);
            this.txt_orderID.TabIndex = 4;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Assign";
            this.Column5.Name = "Column5";
            this.Column5.Width = 50;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "Name";
            this.Column1.HeaderText = "Product Name";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Quantity";
            this.Column2.HeaderText = "Requested Quantity";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 130;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Assign Quantity";
            this.Column3.HeaderText = "Assign Quantity";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 130;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Batch";
            this.Column4.HeaderText = "Batch";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // frmAssignQuantity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 386);
            this.Controls.Add(this.txt_orderID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.grid_sorting);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAssignQuantity";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Assign Quantity";
            ((System.ComponentModel.ISupportInitialize)(this.grid_sorting)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_sorting;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_orderID;
        private System.Windows.Forms.DataGridViewButtonColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}