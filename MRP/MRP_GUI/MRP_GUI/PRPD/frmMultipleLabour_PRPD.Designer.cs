namespace MRP_GUI.Production
{
    partial class frmMultipleLabour_PRPD
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOT = new System.Windows.Forms.TextBox();
            this.txtOTMinutes = new System.Windows.Forms.TextBox();
            this.dgvEmployeeList = new System.Windows.Forms.DataGridView();
            this.objSourceEmp = new System.Windows.Forms.BindingSource(this.components);
            this.Select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.EmpID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTo = new System.Windows.Forms.MaskedTextBox();
            this.txtFrom = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceEmp)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 318);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Start Time";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(167, 321);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Stop Time";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 357);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "OT Hours";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(167, 360);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "OT Minutes";
            // 
            // txtOT
            // 
            this.txtOT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtOT.Location = new System.Drawing.Point(97, 351);
            this.txtOT.Margin = new System.Windows.Forms.Padding(4);
            this.txtOT.Name = "txtOT";
            this.txtOT.Size = new System.Drawing.Size(42, 22);
            this.txtOT.TabIndex = 2;
            this.txtOT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtOT_KeyDown);
            // 
            // txtOTMinutes
            // 
            this.txtOTMinutes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtOTMinutes.Location = new System.Drawing.Point(265, 354);
            this.txtOTMinutes.Margin = new System.Windows.Forms.Padding(4);
            this.txtOTMinutes.Name = "txtOTMinutes";
            this.txtOTMinutes.Size = new System.Drawing.Size(42, 22);
            this.txtOTMinutes.TabIndex = 3;
            this.txtOTMinutes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtOTMinutes_KeyDown);
            // 
            // dgvEmployeeList
            // 
            this.dgvEmployeeList.AllowUserToAddRows = false;
            this.dgvEmployeeList.AllowUserToDeleteRows = false;
            this.dgvEmployeeList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEmployeeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployeeList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Select,
            this.EmpID,
            this.EmpName});
            this.dgvEmployeeList.Location = new System.Drawing.Point(12, 12);
            this.dgvEmployeeList.Name = "dgvEmployeeList";
            this.dgvEmployeeList.Size = new System.Drawing.Size(649, 281);
            this.dgvEmployeeList.TabIndex = 5;
            // 
            // Select
            // 
            this.Select.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Select.FillWeight = 50F;
            this.Select.HeaderText = "Select";
            this.Select.Name = "Select";
            // 
            // EmpID
            // 
            this.EmpID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EmpID.DataPropertyName = "EmpID";
            this.EmpID.HeaderText = "EmpID";
            this.EmpID.Name = "EmpID";
            this.EmpID.ReadOnly = true;
            // 
            // EmpName
            // 
            this.EmpName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EmpName.DataPropertyName = "EmpName";
            this.EmpName.FillWeight = 250F;
            this.EmpName.HeaderText = "EmpName";
            this.EmpName.Name = "EmpName";
            this.EmpName.ReadOnly = true;
            // 
            // txtTo
            // 
            this.txtTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTo.Location = new System.Drawing.Point(265, 316);
            this.txtTo.Mask = "00:00";
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(42, 24);
            this.txtTo.TabIndex = 1;
            this.txtTo.ValidatingType = typeof(System.DateTime);
            this.txtTo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTo_KeyDown);
            // 
            // txtFrom
            // 
            this.txtFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFrom.Location = new System.Drawing.Point(97, 313);
            this.txtFrom.Mask = "00:00";
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(42, 24);
            this.txtFrom.TabIndex = 0;
            this.txtFrom.ValidatingType = typeof(System.DateTime);
            this.txtFrom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFrom_KeyDown);
            // 
            // frmMultipleLabour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 398);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.txtFrom);
            this.Controls.Add(this.dgvEmployeeList);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOTMinutes);
            this.Controls.Add(this.txtOT);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMultipleLabour";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Multiple Labour";
            this.Load += new System.EventHandler(this.frmMultipleLabour_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceEmp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOT;
        private System.Windows.Forms.TextBox txtOTMinutes;
        private System.Windows.Forms.DataGridView dgvEmployeeList;
        private System.Windows.Forms.BindingSource objSourceEmp;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Select;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpName;
        private System.Windows.Forms.MaskedTextBox txtTo;
        private System.Windows.Forms.MaskedTextBox txtFrom;
    }
}