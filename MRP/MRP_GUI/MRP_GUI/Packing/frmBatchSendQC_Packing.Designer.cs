namespace MRP_GUI
{
    partial class frmBatchSendQC_Packing
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
            this.BatchFinalQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RemainingQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.objSourceBatchList = new System.Windows.Forms.BindingSource(this.components);
            this.dgvBatchLabourDetails = new System.Windows.Forms.DataGridView();
            this.LabourRecID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.From_emp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.To_emp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMachineDetails = new System.Windows.Forms.DataGridView();
            this.MachineRecID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MachineCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Machine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.From_Machine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.To_Machine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.objSourceBatchLabour = new System.Windows.Forms.BindingSource(this.components);
            this.objSourceBatchMachine = new System.Windows.Forms.BindingSource(this.components);
            this.txtBatchID = new System.Windows.Forms.TextBox();
            this.txtActivity = new System.Windows.Forms.TextBox();
            this.dgvActivity = new System.Windows.Forms.DataGridView();
            this.BatchActStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BatchActID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrimaryFinishProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvQCReports = new System.Windows.Forms.DataGridView();
            this.ReportID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReportStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReqestedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RequestedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSendQC = new System.Windows.Forms.Button();
            this.cmbSample = new System.Windows.Forms.ComboBox();
            this.txtSampleQty = new System.Windows.Forms.TextBox();
            this.objSourceActivityList = new System.Windows.Forms.BindingSource(this.components);
            this.objSourceQCReports = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBatcList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceBatchList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBatchLabourDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMachineDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceBatchLabour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceBatchMachine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQCReports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceActivityList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceQCReports)).BeginInit();
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
            this.BatchFinalQty,
            this.RemainingQty,
            this.Unit});
            this.dgvBatcList.Location = new System.Drawing.Point(12, 54);
            this.dgvBatcList.Name = "dgvBatcList";
            this.dgvBatcList.ReadOnly = true;
            this.dgvBatcList.Size = new System.Drawing.Size(321, 546);
            this.dgvBatcList.TabIndex = 0;
            this.dgvBatcList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBatcList_CellClick);
            // 
            // BatchNo
            // 
            this.BatchNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BatchNo.DataPropertyName = "BatchID";
            this.BatchNo.FillWeight = 150F;
            this.BatchNo.HeaderText = "Batch No";
            this.BatchNo.Name = "BatchNo";
            this.BatchNo.ReadOnly = true;
            // 
            // BatchFinalQty
            // 
            this.BatchFinalQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BatchFinalQty.DataPropertyName = "BatchFinalQty";
            this.BatchFinalQty.HeaderText = "Final Qty";
            this.BatchFinalQty.Name = "BatchFinalQty";
            this.BatchFinalQty.ReadOnly = true;
            // 
            // RemainingQty
            // 
            this.RemainingQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RemainingQty.DataPropertyName = "RemainingQty";
            this.RemainingQty.HeaderText = "Rem. Qty";
            this.RemainingQty.Name = "RemainingQty";
            this.RemainingQty.ReadOnly = true;
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
            // dgvBatchLabourDetails
            // 
            this.dgvBatchLabourDetails.AllowUserToAddRows = false;
            this.dgvBatchLabourDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBatchLabourDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBatchLabourDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LabourRecID,
            this.EmployeeID,
            this.EmployeeName,
            this.From_emp,
            this.To_emp,
            this.OT});
            this.dgvBatchLabourDetails.Location = new System.Drawing.Point(349, 402);
            this.dgvBatchLabourDetails.Name = "dgvBatchLabourDetails";
            this.dgvBatchLabourDetails.ReadOnly = true;
            this.dgvBatchLabourDetails.Size = new System.Drawing.Size(653, 198);
            this.dgvBatchLabourDetails.TabIndex = 4;
            this.dgvBatchLabourDetails.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvBatchLabourDetails_KeyDown);
            // 
            // LabourRecID
            // 
            this.LabourRecID.DataPropertyName = "LabourRecID";
            this.LabourRecID.HeaderText = "LabourRecID";
            this.LabourRecID.Name = "LabourRecID";
            this.LabourRecID.ReadOnly = true;
            this.LabourRecID.Visible = false;
            // 
            // EmployeeID
            // 
            this.EmployeeID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EmployeeID.DataPropertyName = "EmployeeID";
            this.EmployeeID.HeaderText = "EmployeeID";
            this.EmployeeID.Name = "EmployeeID";
            this.EmployeeID.ReadOnly = true;
            // 
            // EmployeeName
            // 
            this.EmployeeName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EmployeeName.DataPropertyName = "EmpName";
            this.EmployeeName.FillWeight = 200F;
            this.EmployeeName.HeaderText = "EmployeeName";
            this.EmployeeName.Name = "EmployeeName";
            this.EmployeeName.ReadOnly = true;
            // 
            // From_emp
            // 
            this.From_emp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.From_emp.DataPropertyName = "WorkStart";
            this.From_emp.HeaderText = "From";
            this.From_emp.Name = "From_emp";
            this.From_emp.ReadOnly = true;
            // 
            // To_emp
            // 
            this.To_emp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.To_emp.DataPropertyName = "WorkStop";
            this.To_emp.HeaderText = "To";
            this.To_emp.Name = "To_emp";
            this.To_emp.ReadOnly = true;
            // 
            // OT
            // 
            this.OT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.OT.DataPropertyName = "OTHours";
            this.OT.HeaderText = "OT";
            this.OT.Name = "OT";
            this.OT.ReadOnly = true;
            // 
            // dgvMachineDetails
            // 
            this.dgvMachineDetails.AllowUserToAddRows = false;
            this.dgvMachineDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMachineDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMachineDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MachineRecID,
            this.MachineCode,
            this.Machine,
            this.From_Machine,
            this.To_Machine});
            this.dgvMachineDetails.Location = new System.Drawing.Point(349, 191);
            this.dgvMachineDetails.Name = "dgvMachineDetails";
            this.dgvMachineDetails.ReadOnly = true;
            this.dgvMachineDetails.Size = new System.Drawing.Size(653, 205);
            this.dgvMachineDetails.TabIndex = 5;
            this.dgvMachineDetails.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvMachineDetails_KeyDown);
            // 
            // MachineRecID
            // 
            this.MachineRecID.DataPropertyName = "MachineRecID";
            this.MachineRecID.HeaderText = "MachineRecID";
            this.MachineRecID.Name = "MachineRecID";
            this.MachineRecID.ReadOnly = true;
            this.MachineRecID.Visible = false;
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
            this.Machine.FillWeight = 150F;
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
            // txtBatchID
            // 
            this.txtBatchID.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtBatchID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBatchID.ForeColor = System.Drawing.Color.LightCoral;
            this.txtBatchID.Location = new System.Drawing.Point(12, 11);
            this.txtBatchID.Name = "txtBatchID";
            this.txtBatchID.Size = new System.Drawing.Size(153, 29);
            this.txtBatchID.TabIndex = 186;
            this.txtBatchID.Text = "<Batch ID>";
            // 
            // txtActivity
            // 
            this.txtActivity.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtActivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtActivity.ForeColor = System.Drawing.Color.LightCoral;
            this.txtActivity.Location = new System.Drawing.Point(181, 11);
            this.txtActivity.Name = "txtActivity";
            this.txtActivity.Size = new System.Drawing.Size(152, 29);
            this.txtActivity.TabIndex = 187;
            this.txtActivity.Text = "<Activity Name>";
            // 
            // dgvActivity
            // 
            this.dgvActivity.AllowUserToAddRows = false;
            this.dgvActivity.AllowUserToDeleteRows = false;
            this.dgvActivity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActivity.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BatchActStatus,
            this.BatchActID,
            this.PrimaryFinishProduct,
            this.Qty});
            this.dgvActivity.Location = new System.Drawing.Point(349, 12);
            this.dgvActivity.Name = "dgvActivity";
            this.dgvActivity.ReadOnly = true;
            this.dgvActivity.Size = new System.Drawing.Size(343, 170);
            this.dgvActivity.TabIndex = 188;
            this.dgvActivity.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvActivity_CellClick);
            // 
            // BatchActStatus
            // 
            this.BatchActStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BatchActStatus.DataPropertyName = "BatchActStatus";
            this.BatchActStatus.HeaderText = "BatchActStatus";
            this.BatchActStatus.Name = "BatchActStatus";
            this.BatchActStatus.ReadOnly = true;
            this.BatchActStatus.Visible = false;
            // 
            // BatchActID
            // 
            this.BatchActID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BatchActID.DataPropertyName = "BatchActID";
            this.BatchActID.FillWeight = 50F;
            this.BatchActID.HeaderText = "ID";
            this.BatchActID.Name = "BatchActID";
            this.BatchActID.ReadOnly = true;
            // 
            // PrimaryFinishProduct
            // 
            this.PrimaryFinishProduct.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PrimaryFinishProduct.DataPropertyName = "EndProductCode";
            this.PrimaryFinishProduct.HeaderText = "Primary Finish Product";
            this.PrimaryFinishProduct.Name = "PrimaryFinishProduct";
            this.PrimaryFinishProduct.ReadOnly = true;
            // 
            // Qty
            // 
            this.Qty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Qty.DataPropertyName = "StopQty";
            this.Qty.FillWeight = 50F;
            this.Qty.HeaderText = "Qty";
            this.Qty.Name = "Qty";
            this.Qty.ReadOnly = true;
            // 
            // dgvQCReports
            // 
            this.dgvQCReports.AllowUserToAddRows = false;
            this.dgvQCReports.AllowUserToDeleteRows = false;
            this.dgvQCReports.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvQCReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQCReports.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ReportID,
            this.ReportStatus,
            this.ReqestedBy,
            this.RequestedDate});
            this.dgvQCReports.Location = new System.Drawing.Point(698, 75);
            this.dgvQCReports.Name = "dgvQCReports";
            this.dgvQCReports.ReadOnly = true;
            this.dgvQCReports.Size = new System.Drawing.Size(304, 107);
            this.dgvQCReports.TabIndex = 191;
            // 
            // ReportID
            // 
            this.ReportID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ReportID.DataPropertyName = "QCReportID";
            this.ReportID.FillWeight = 75F;
            this.ReportID.HeaderText = "ReportID";
            this.ReportID.Name = "ReportID";
            this.ReportID.ReadOnly = true;
            // 
            // ReportStatus
            // 
            this.ReportStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ReportStatus.DataPropertyName = "StatusName";
            this.ReportStatus.FillWeight = 50F;
            this.ReportStatus.HeaderText = "ReportStatus";
            this.ReportStatus.Name = "ReportStatus";
            this.ReportStatus.ReadOnly = true;
            // 
            // ReqestedBy
            // 
            this.ReqestedBy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ReqestedBy.DataPropertyName = "SendByName";
            this.ReqestedBy.HeaderText = "RequestedBy";
            this.ReqestedBy.Name = "ReqestedBy";
            this.ReqestedBy.ReadOnly = true;
            // 
            // RequestedDate
            // 
            this.RequestedDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RequestedDate.DataPropertyName = "SendDate";
            this.RequestedDate.HeaderText = "RequestedDate";
            this.RequestedDate.Name = "RequestedDate";
            this.RequestedDate.ReadOnly = true;
            // 
            // btnSendQC
            // 
            this.btnSendQC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSendQC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendQC.Location = new System.Drawing.Point(880, 41);
            this.btnSendQC.Name = "btnSendQC";
            this.btnSendQC.Size = new System.Drawing.Size(122, 28);
            this.btnSendQC.TabIndex = 192;
            this.btnSendQC.Text = "Send QC";
            this.btnSendQC.UseVisualStyleBackColor = true;
            this.btnSendQC.Click += new System.EventHandler(this.btnSendQC_Click);
            // 
            // cmbSample
            // 
            this.cmbSample.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbSample.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSample.FormattingEnabled = true;
            this.cmbSample.Items.AddRange(new object[] {
            "30 ml ",
            "180 ml",
            "200 ml",
            "100 ml",
            "4g",
            "100g",
            "50g",
            "30ml",
            "180ml",
            "3g",
            "7g",
            "25g",
            "50g",
            "25g",
            "45g",
            "80g",
            "30nos",
            "60nos",
            "120nos",
            "300nos",
            "500nos",
            "180g"});
            this.cmbSample.Location = new System.Drawing.Point(793, 12);
            this.cmbSample.Name = "cmbSample";
            this.cmbSample.Size = new System.Drawing.Size(209, 23);
            this.cmbSample.TabIndex = 193;
            // 
            // txtSampleQty
            // 
            this.txtSampleQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSampleQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSampleQty.Location = new System.Drawing.Point(793, 48);
            this.txtSampleQty.Name = "txtSampleQty";
            this.txtSampleQty.Size = new System.Drawing.Size(58, 21);
            this.txtSampleQty.TabIndex = 194;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(699, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 195;
            this.label1.Text = "Sample Code";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(699, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 15);
            this.label2.TabIndex = 195;
            this.label2.Text = "No of Samples";
            // 
            // frmBatchSendQC_Packing
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1004, 612);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSampleQty);
            this.Controls.Add(this.cmbSample);
            this.Controls.Add(this.btnSendQC);
            this.Controls.Add(this.dgvQCReports);
            this.Controls.Add(this.dgvActivity);
            this.Controls.Add(this.txtActivity);
            this.Controls.Add(this.txtBatchID);
            this.Controls.Add(this.dgvMachineDetails);
            this.Controls.Add(this.dgvBatchLabourDetails);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.dgvBatcList);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmBatchSendQC_Packing";
            this.Text = "Batch List - Packaging Primary";
            this.Load += new System.EventHandler(this.frmBatchList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBatcList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceBatchList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBatchLabourDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMachineDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceBatchLabour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceBatchMachine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQCReports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceActivityList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceQCReports)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBatcList;
        private System.Windows.Forms.BindingSource objSourceBatchList;
        private System.Windows.Forms.DataGridView dgvBatchLabourDetails;
        private System.Windows.Forms.DataGridView dgvMachineDetails;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.BindingSource objSourceBatchLabour;
        private System.Windows.Forms.BindingSource objSourceBatchMachine;
        private System.Windows.Forms.DataGridViewTextBoxColumn LabourRecID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn From_emp;
        private System.Windows.Forms.DataGridViewTextBoxColumn To_emp;
        private System.Windows.Forms.DataGridViewTextBoxColumn OT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MachineRecID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MachineCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Machine;
        private System.Windows.Forms.DataGridViewTextBoxColumn From_Machine;
        private System.Windows.Forms.DataGridViewTextBoxColumn To_Machine;
        private System.Windows.Forms.TextBox txtBatchID;
        private System.Windows.Forms.TextBox txtActivity;
        private System.Windows.Forms.DataGridView dgvActivity;
        private System.Windows.Forms.DataGridView dgvQCReports;
        private System.Windows.Forms.Button btnSendQC;
        private System.Windows.Forms.ComboBox cmbSample;
        private System.Windows.Forms.TextBox txtSampleQty;
        private System.Windows.Forms.BindingSource objSourceActivityList;
        private System.Windows.Forms.BindingSource objSourceQCReports;
        private System.Windows.Forms.DataGridViewTextBoxColumn BatchNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn BatchFinalQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn RemainingQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn BatchActStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn BatchActID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrimaryFinishProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReportID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReportStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReqestedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn RequestedDate;
    }
}