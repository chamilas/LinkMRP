namespace MRP_GUI
{
    partial class frmBatchSendQC
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
            this.dgvBatcList = new System.Windows.Forms.DataGridView();
            this.BatchNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BatchSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.objSourceBatchList = new System.Windows.Forms.BindingSource(this.components);
            this.objSourceActivityList = new System.Windows.Forms.BindingSource(this.components);
            this.dgvActivity = new System.Windows.Forms.DataGridView();
            this.Activity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BatchActID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MainActID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StopQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvBatchLabourDetails = new System.Windows.Forms.DataGridView();
            this.EmployeeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.From_emp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.To_emp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMachineDetails = new System.Windows.Forms.DataGridView();
            this.MachineCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Machine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.From_Machine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.To_Machine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.objSourceBatchLabour = new System.Windows.Forms.BindingSource(this.components);
            this.objSourceBatchMachine = new System.Windows.Forms.BindingSource(this.components);
            this.objSourceMachineList = new System.Windows.Forms.BindingSource(this.components);
            this.objSourceEmployee = new System.Windows.Forms.BindingSource(this.components);
            this.btnSennQC = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBatcList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceBatchList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceActivityList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBatchLabourDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMachineDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceBatchLabour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceBatchMachine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceMachineList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBatcList
            // 
            this.dgvBatcList.AllowUserToAddRows = false;
            this.dgvBatcList.AllowUserToDeleteRows = false;
            this.dgvBatcList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvBatcList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBatcList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BatchNo,
            this.BatchSize,
            this.Unit});
            this.dgvBatcList.Location = new System.Drawing.Point(12, 12);
            this.dgvBatcList.Name = "dgvBatcList";
            this.dgvBatcList.ReadOnly = true;
            this.dgvBatcList.Size = new System.Drawing.Size(321, 561);
            this.dgvBatcList.TabIndex = 0;
            this.dgvBatcList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBatcList_CellClick);
            this.dgvBatcList.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBatcList_RowEnter);
            // 
            // BatchNo
            // 
            this.BatchNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BatchNo.DataPropertyName = "BatchID";
            this.BatchNo.HeaderText = "Batch No";
            this.BatchNo.Name = "BatchNo";
            this.BatchNo.ReadOnly = true;
            // 
            // BatchSize
            // 
            this.BatchSize.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BatchSize.DataPropertyName = "BatchSize";
            this.BatchSize.HeaderText = "Batch Size";
            this.BatchSize.Name = "BatchSize";
            this.BatchSize.ReadOnly = true;
            // 
            // Unit
            // 
            this.Unit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Unit.DataPropertyName = "UnitCode";
            this.Unit.FillWeight = 50F;
            this.Unit.HeaderText = "Unit";
            this.Unit.Name = "Unit";
            this.Unit.ReadOnly = true;
            // 
            // dgvActivity
            // 
            this.dgvActivity.AllowUserToAddRows = false;
            this.dgvActivity.AllowUserToDeleteRows = false;
            this.dgvActivity.AllowUserToResizeColumns = false;
            this.dgvActivity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActivity.ColumnHeadersVisible = false;
            this.dgvActivity.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Activity,
            this.BatchActID,
            this.MainActID,
            this.StopQty});
            this.dgvActivity.Location = new System.Drawing.Point(349, 12);
            this.dgvActivity.Name = "dgvActivity";
            this.dgvActivity.ReadOnly = true;
            this.dgvActivity.Size = new System.Drawing.Size(314, 226);
            this.dgvActivity.TabIndex = 1;
            this.dgvActivity.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvActivity_CellClick);
            // 
            // Activity
            // 
            this.Activity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Activity.DataPropertyName = "MainActivity";
            this.Activity.HeaderText = "Activity";
            this.Activity.Name = "Activity";
            this.Activity.ReadOnly = true;
            // 
            // BatchActID
            // 
            this.BatchActID.DataPropertyName = "BatchActID";
            this.BatchActID.HeaderText = "BatchActID";
            this.BatchActID.Name = "BatchActID";
            this.BatchActID.ReadOnly = true;
            this.BatchActID.Visible = false;
            // 
            // MainActID
            // 
            this.MainActID.DataPropertyName = "ActID";
            this.MainActID.HeaderText = "MainActID";
            this.MainActID.Name = "MainActID";
            this.MainActID.ReadOnly = true;
            this.MainActID.Visible = false;
            // 
            // StopQty
            // 
            this.StopQty.DataPropertyName = "StopQty";
            this.StopQty.HeaderText = "StopQty";
            this.StopQty.Name = "StopQty";
            this.StopQty.ReadOnly = true;
            // 
            // dgvBatchLabourDetails
            // 
            this.dgvBatchLabourDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBatchLabourDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBatchLabourDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmployeeID,
            this.EmployeeName,
            this.From_emp,
            this.To_emp,
            this.OT});
            this.dgvBatchLabourDetails.Location = new System.Drawing.Point(349, 244);
            this.dgvBatchLabourDetails.Name = "dgvBatchLabourDetails";
            this.dgvBatchLabourDetails.Size = new System.Drawing.Size(653, 329);
            this.dgvBatchLabourDetails.TabIndex = 4;
            // 
            // EmployeeID
            // 
            this.EmployeeID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EmployeeID.DataPropertyName = "EmployeeID";
            this.EmployeeID.HeaderText = "EmployeeID";
            this.EmployeeID.Name = "EmployeeID";
            // 
            // EmployeeName
            // 
            this.EmployeeName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EmployeeName.DataPropertyName = "EmpName";
            this.EmployeeName.FillWeight = 200F;
            this.EmployeeName.HeaderText = "EmployeeName";
            this.EmployeeName.Name = "EmployeeName";
            // 
            // From_emp
            // 
            this.From_emp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.From_emp.DataPropertyName = "WorkStart";
            this.From_emp.HeaderText = "From";
            this.From_emp.Name = "From_emp";
            // 
            // To_emp
            // 
            this.To_emp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.To_emp.DataPropertyName = "WorkStop";
            this.To_emp.HeaderText = "To";
            this.To_emp.Name = "To_emp";
            // 
            // OT
            // 
            this.OT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.OT.DataPropertyName = "OTHours";
            this.OT.HeaderText = "OT";
            this.OT.Name = "OT";
            // 
            // dgvMachineDetails
            // 
            this.dgvMachineDetails.AllowUserToAddRows = false;
            this.dgvMachineDetails.AllowUserToDeleteRows = false;
            this.dgvMachineDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMachineDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMachineDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MachineCode,
            this.Machine,
            this.From_Machine,
            this.To_Machine});
            this.dgvMachineDetails.Location = new System.Drawing.Point(672, 12);
            this.dgvMachineDetails.Name = "dgvMachineDetails";
            this.dgvMachineDetails.ReadOnly = true;
            this.dgvMachineDetails.Size = new System.Drawing.Size(330, 226);
            this.dgvMachineDetails.TabIndex = 5;
            // 
            // MachineCode
            // 
            this.MachineCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MachineCode.DataPropertyName = "MachineCode";
            this.MachineCode.HeaderText = "MachineCode";
            this.MachineCode.Name = "MachineCode";
            this.MachineCode.ReadOnly = true;
            this.MachineCode.Visible = false;
            // 
            // Machine
            // 
            this.Machine.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Machine.DataPropertyName = "MachineName";
            this.Machine.FillWeight = 200F;
            this.Machine.HeaderText = "Machine";
            this.Machine.Name = "Machine";
            this.Machine.ReadOnly = true;
            // 
            // From_Machine
            // 
            this.From_Machine.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.From_Machine.DataPropertyName = "MachineStart";
            this.From_Machine.HeaderText = "From";
            this.From_Machine.Name = "From_Machine";
            this.From_Machine.ReadOnly = true;
            // 
            // To_Machine
            // 
            this.To_Machine.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.To_Machine.DataPropertyName = "MachineStop";
            this.To_Machine.HeaderText = "To";
            this.To_Machine.Name = "To_Machine";
            this.To_Machine.ReadOnly = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(766, -195);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(278, 22);
            this.textBox2.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(676, -363);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(278, 22);
            this.textBox4.TabIndex = 2;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(636, -124);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 22);
            this.textBox5.TabIndex = 2;
            // 
            // btnSennQC
            // 
            this.btnSennQC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSennQC.Location = new System.Drawing.Point(863, 578);
            this.btnSennQC.Name = "btnSennQC";
            this.btnSennQC.Size = new System.Drawing.Size(139, 25);
            this.btnSennQC.TabIndex = 8;
            this.btnSennQC.Text = "Send QC";
            this.btnSennQC.UseVisualStyleBackColor = true;
            this.btnSennQC.Click += new System.EventHandler(this.btnFinishBatch_Click);
            // 
            // frmBatchSendQC
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1004, 612);
            this.Controls.Add(this.btnSennQC);
            this.Controls.Add(this.dgvMachineDetails);
            this.Controls.Add(this.dgvBatchLabourDetails);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.dgvActivity);
            this.Controls.Add(this.dgvBatcList);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmBatchSendQC";
            this.Text = "Batch List";
            this.Load += new System.EventHandler(this.frmBatchList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBatcList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceBatchList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceActivityList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBatchLabourDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMachineDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceBatchLabour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceBatchMachine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceMachineList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBatcList;
        private System.Windows.Forms.BindingSource objSourceBatchList;
        private System.Windows.Forms.DataGridViewTextBoxColumn BatchNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn BatchSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private System.Windows.Forms.BindingSource objSourceActivityList;
        private System.Windows.Forms.DataGridView dgvActivity;
        private System.Windows.Forms.DataGridView dgvBatchLabourDetails;
        private System.Windows.Forms.DataGridView dgvMachineDetails;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.BindingSource objSourceBatchLabour;
        private System.Windows.Forms.BindingSource objSourceBatchMachine;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn From_emp;
        private System.Windows.Forms.DataGridViewTextBoxColumn To_emp;
        private System.Windows.Forms.DataGridViewTextBoxColumn OT;
        private System.Windows.Forms.BindingSource objSourceMachineList;
        private System.Windows.Forms.BindingSource objSourceEmployee;
        private System.Windows.Forms.Button btnSennQC;
        private System.Windows.Forms.DataGridViewTextBoxColumn MachineCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Machine;
        private System.Windows.Forms.DataGridViewTextBoxColumn From_Machine;
        private System.Windows.Forms.DataGridViewTextBoxColumn To_Machine;
        private System.Windows.Forms.DataGridViewTextBoxColumn Activity;
        private System.Windows.Forms.DataGridViewTextBoxColumn BatchActID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MainActID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StopQty;
    }
}