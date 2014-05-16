namespace MRP_GUI
{
    partial class frmBatchRegistry
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.objSourceBatchList = new System.Windows.Forms.BindingSource(this.components);
            this.objSourceActivityList = new System.Windows.Forms.BindingSource(this.components);
            this.dgvActivity = new System.Windows.Forms.DataGridView();
            this.BatchActID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MainActID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Activity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtFinalQty = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBatchID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBatchSize = new System.Windows.Forms.TextBox();
            this.lblUnit1 = new System.Windows.Forms.Label();
            this.lblUnit2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBatchState = new System.Windows.Forms.TextBox();
            this.dgvMTItems = new System.Windows.Forms.DataGridView();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MRNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chkRaw = new System.Windows.Forms.CheckBox();
            this.chkPacking = new System.Windows.Forms.CheckBox();
            this.chkSemi = new System.Windows.Forms.CheckBox();
            this.objSourceItemLsit = new System.Windows.Forms.BindingSource(this.components);
            this.dgvTransferred = new System.Windows.Forms.DataGridView();
            this.ProductCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransferredQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.objSourceTransferred = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.objSourceBatchList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceActivityList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBatchLabourDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMachineDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceBatchLabour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceBatchMachine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceMachineList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMTItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceItemLsit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransferred)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceTransferred)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvActivity
            // 
            this.dgvActivity.AllowUserToAddRows = false;
            this.dgvActivity.AllowUserToDeleteRows = false;
            this.dgvActivity.AllowUserToResizeColumns = false;
            this.dgvActivity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvActivity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActivity.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BatchActID,
            this.MainActID,
            this.Activity,
            this.StartProduct,
            this.StartQty,
            this.EndProduct,
            this.StopQty});
            this.dgvActivity.Location = new System.Drawing.Point(349, 12);
            this.dgvActivity.Name = "dgvActivity";
            this.dgvActivity.ReadOnly = true;
            this.dgvActivity.Size = new System.Drawing.Size(643, 137);
            this.dgvActivity.TabIndex = 1;
            this.dgvActivity.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvActivity_CellClick);
            // 
            // BatchActID
            // 
            this.BatchActID.DataPropertyName = "BatchActID";
            this.BatchActID.HeaderText = "BatchActID";
            this.BatchActID.Name = "BatchActID";
            this.BatchActID.ReadOnly = true;
            // 
            // MainActID
            // 
            this.MainActID.DataPropertyName = "ActID";
            this.MainActID.HeaderText = "MainActID";
            this.MainActID.Name = "MainActID";
            this.MainActID.ReadOnly = true;
            this.MainActID.Visible = false;
            // 
            // Activity
            // 
            this.Activity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Activity.DataPropertyName = "MainActivity";
            this.Activity.FillWeight = 180F;
            this.Activity.HeaderText = "Activity";
            this.Activity.Name = "Activity";
            this.Activity.ReadOnly = true;
            // 
            // StartProduct
            // 
            this.StartProduct.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StartProduct.DataPropertyName = "StartProductCode";
            this.StartProduct.FillWeight = 120F;
            this.StartProduct.HeaderText = "StartProduct";
            this.StartProduct.Name = "StartProduct";
            this.StartProduct.ReadOnly = true;
            // 
            // StartQty
            // 
            this.StartQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StartQty.DataPropertyName = "StartQty";
            this.StartQty.HeaderText = "StartQty";
            this.StartQty.Name = "StartQty";
            this.StartQty.ReadOnly = true;
            // 
            // EndProduct
            // 
            this.EndProduct.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EndProduct.DataPropertyName = "EndProductCode";
            this.EndProduct.FillWeight = 120F;
            this.EndProduct.HeaderText = "EndProduct";
            this.EndProduct.Name = "EndProduct";
            this.EndProduct.ReadOnly = true;
            // 
            // StopQty
            // 
            this.StopQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
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
            this.dgvBatchLabourDetails.Location = new System.Drawing.Point(349, 361);
            this.dgvBatchLabourDetails.Name = "dgvBatchLabourDetails";
            this.dgvBatchLabourDetails.Size = new System.Drawing.Size(653, 239);
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
            this.dgvMachineDetails.Location = new System.Drawing.Point(349, 155);
            this.dgvMachineDetails.Name = "dgvMachineDetails";
            this.dgvMachineDetails.ReadOnly = true;
            this.dgvMachineDetails.Size = new System.Drawing.Size(643, 178);
            this.dgvMachineDetails.TabIndex = 5;
            // 
            // MachineCode
            // 
            this.MachineCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MachineCode.DataPropertyName = "MachineCode";
            this.MachineCode.FillWeight = 200F;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Final Qty";
            // 
            // txtFinalQty
            // 
            this.txtFinalQty.Location = new System.Drawing.Point(89, 89);
            this.txtFinalQty.Name = "txtFinalQty";
            this.txtFinalQty.ReadOnly = true;
            this.txtFinalQty.Size = new System.Drawing.Size(123, 22);
            this.txtFinalQty.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Batch ID";
            // 
            // txtBatchID
            // 
            this.txtBatchID.Location = new System.Drawing.Point(89, 13);
            this.txtBatchID.Name = "txtBatchID";
            this.txtBatchID.Size = new System.Drawing.Size(123, 22);
            this.txtBatchID.TabIndex = 10;
            this.txtBatchID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBatchID_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Batch Size";
            // 
            // txtBatchSize
            // 
            this.txtBatchSize.Location = new System.Drawing.Point(89, 52);
            this.txtBatchSize.Name = "txtBatchSize";
            this.txtBatchSize.ReadOnly = true;
            this.txtBatchSize.Size = new System.Drawing.Size(124, 22);
            this.txtBatchSize.TabIndex = 11;
            // 
            // lblUnit1
            // 
            this.lblUnit1.AutoSize = true;
            this.lblUnit1.Location = new System.Drawing.Point(219, 58);
            this.lblUnit1.Name = "lblUnit1";
            this.lblUnit1.Size = new System.Drawing.Size(42, 16);
            this.lblUnit1.TabIndex = 9;
            this.lblUnit1.Text = "<unit>";
            // 
            // lblUnit2
            // 
            this.lblUnit2.AutoSize = true;
            this.lblUnit2.Location = new System.Drawing.Point(218, 95);
            this.lblUnit2.Name = "lblUnit2";
            this.lblUnit2.Size = new System.Drawing.Size(42, 16);
            this.lblUnit2.TabIndex = 9;
            this.lblUnit2.Text = "<unit>";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Batch State";
            // 
            // txtBatchState
            // 
            this.txtBatchState.Location = new System.Drawing.Point(89, 127);
            this.txtBatchState.Name = "txtBatchState";
            this.txtBatchState.ReadOnly = true;
            this.txtBatchState.Size = new System.Drawing.Size(124, 22);
            this.txtBatchState.TabIndex = 13;
            // 
            // dgvMTItems
            // 
            this.dgvMTItems.AllowUserToAddRows = false;
            this.dgvMTItems.AllowUserToDeleteRows = false;
            this.dgvMTItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvMTItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMTItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Item,
            this.MRNO,
            this.Qty,
            this.Unit});
            this.dgvMTItems.Location = new System.Drawing.Point(15, 194);
            this.dgvMTItems.Name = "dgvMTItems";
            this.dgvMTItems.ReadOnly = true;
            this.dgvMTItems.Size = new System.Drawing.Size(328, 240);
            this.dgvMTItems.TabIndex = 14;
            // 
            // Item
            // 
            this.Item.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Item.DataPropertyName = "Item";
            this.Item.HeaderText = "Item";
            this.Item.Name = "Item";
            this.Item.ReadOnly = true;
            // 
            // MRNO
            // 
            this.MRNO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MRNO.DataPropertyName = "MRNO";
            this.MRNO.HeaderText = "MRNO";
            this.MRNO.Name = "MRNO";
            this.MRNO.ReadOnly = true;
            // 
            // Qty
            // 
            this.Qty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Qty.DataPropertyName = "MRIssuedQty";
            dataGridViewCellStyle1.Format = "N3";
            dataGridViewCellStyle1.NullValue = null;
            this.Qty.DefaultCellStyle = dataGridViewCellStyle1;
            this.Qty.FillWeight = 50F;
            this.Qty.HeaderText = "Qty";
            this.Qty.Name = "Qty";
            this.Qty.ReadOnly = true;
            // 
            // Unit
            // 
            this.Unit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Unit.DataPropertyName = "Unit";
            this.Unit.FillWeight = 50F;
            this.Unit.HeaderText = "Unit";
            this.Unit.Name = "Unit";
            this.Unit.ReadOnly = true;
            // 
            // chkRaw
            // 
            this.chkRaw.AutoSize = true;
            this.chkRaw.Checked = true;
            this.chkRaw.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRaw.Location = new System.Drawing.Point(15, 168);
            this.chkRaw.Name = "chkRaw";
            this.chkRaw.Size = new System.Drawing.Size(54, 20);
            this.chkRaw.TabIndex = 15;
            this.chkRaw.Text = "Raw";
            this.chkRaw.UseVisualStyleBackColor = true;
            this.chkRaw.CheckedChanged += new System.EventHandler(this.chkRaw_CheckedChanged);
            // 
            // chkPacking
            // 
            this.chkPacking.AutoSize = true;
            this.chkPacking.Location = new System.Drawing.Point(253, 168);
            this.chkPacking.Name = "chkPacking";
            this.chkPacking.Size = new System.Drawing.Size(76, 20);
            this.chkPacking.TabIndex = 15;
            this.chkPacking.Text = "Packing";
            this.chkPacking.UseVisualStyleBackColor = true;
            this.chkPacking.CheckedChanged += new System.EventHandler(this.chkPacking_CheckedChanged);
            // 
            // chkSemi
            // 
            this.chkSemi.AutoSize = true;
            this.chkSemi.Location = new System.Drawing.Point(114, 168);
            this.chkSemi.Name = "chkSemi";
            this.chkSemi.Size = new System.Drawing.Size(112, 20);
            this.chkSemi.TabIndex = 15;
            this.chkSemi.Text = "Semi Finished";
            this.chkSemi.UseVisualStyleBackColor = true;
            this.chkSemi.CheckedChanged += new System.EventHandler(this.chkSemi_CheckedChanged);
            // 
            // dgvTransferred
            // 
            this.dgvTransferred.AllowUserToAddRows = false;
            this.dgvTransferred.AllowUserToDeleteRows = false;
            this.dgvTransferred.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvTransferred.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransferred.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductCode,
            this.TransferredQty});
            this.dgvTransferred.Location = new System.Drawing.Point(12, 440);
            this.dgvTransferred.Name = "dgvTransferred";
            this.dgvTransferred.ReadOnly = true;
            this.dgvTransferred.Size = new System.Drawing.Size(331, 160);
            this.dgvTransferred.TabIndex = 19;
            // 
            // ProductCode
            // 
            this.ProductCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductCode.DataPropertyName = "MTNFinishProductID";
            this.ProductCode.HeaderText = "ProductCode";
            this.ProductCode.Name = "ProductCode";
            this.ProductCode.ReadOnly = true;
            // 
            // TransferredQty
            // 
            this.TransferredQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TransferredQty.DataPropertyName = "MTNTransferQty";
            this.TransferredQty.FillWeight = 50F;
            this.TransferredQty.HeaderText = "TransferredQty";
            this.TransferredQty.Name = "TransferredQty";
            this.TransferredQty.ReadOnly = true;
            // 
            // frmBatchRegistry
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1004, 612);
            this.Controls.Add(this.dgvTransferred);
            this.Controls.Add(this.chkPacking);
            this.Controls.Add(this.chkSemi);
            this.Controls.Add(this.chkRaw);
            this.Controls.Add(this.dgvMTItems);
            this.Controls.Add(this.txtBatchState);
            this.Controls.Add(this.txtBatchSize);
            this.Controls.Add(this.txtBatchID);
            this.Controls.Add(this.lblUnit2);
            this.Controls.Add(this.lblUnit1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFinalQty);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvMachineDetails);
            this.Controls.Add(this.dgvBatchLabourDetails);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.dgvActivity);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmBatchRegistry";
            this.Text = "Batch List";
            this.Load += new System.EventHandler(this.frmBatchList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.objSourceBatchList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceActivityList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBatchLabourDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMachineDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceBatchLabour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceBatchMachine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceMachineList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMTItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceItemLsit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransferred)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceTransferred)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource objSourceBatchList;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFinalQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn MachineCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Machine;
        private System.Windows.Forms.DataGridViewTextBoxColumn From_Machine;
        private System.Windows.Forms.DataGridViewTextBoxColumn To_Machine;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBatchID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBatchSize;
        private System.Windows.Forms.Label lblUnit1;
        private System.Windows.Forms.Label lblUnit2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBatchState;
        private System.Windows.Forms.DataGridViewTextBoxColumn BatchActID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MainActID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Activity;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn StopQty;
        private System.Windows.Forms.DataGridView dgvMTItems;
        private System.Windows.Forms.CheckBox chkRaw;
        private System.Windows.Forms.CheckBox chkPacking;
        private System.Windows.Forms.CheckBox chkSemi;
        private System.Windows.Forms.BindingSource objSourceItemLsit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn MRNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private System.Windows.Forms.DataGridView dgvTransferred;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransferredQty;
        private System.Windows.Forms.BindingSource objSourceTransferred;
    }
}