namespace MRP_GUI
{
    partial class frmPRPDBatchTransfer_Preperation
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtStopDate = new System.Windows.Forms.TextBox();
            this.txtStartDate = new System.Windows.Forms.TextBox();
            this.txtInstructedBy = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dgvActivities = new System.Windows.Forms.DataGridView();
            this.ActivityName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblUnit = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPRPDBatchQty = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMaterialCode = new System.Windows.Forms.TextBox();
            this.txtMaterialName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBatchState = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbPRPDBatch = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMRNo = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtMaterial = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblUnit1 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtAddedUnitCost = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtAfterReworkQty = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.objSourcePRPDBatchActivity = new System.Windows.Forms.BindingSource(this.components);
            this.objSourcePRPDBatches = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivities)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objSourcePRPDBatchActivity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourcePRPDBatches)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Location = new System.Drawing.Point(789, 576);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.groupBox6);
            this.groupBox3.Controls.Add(this.btnClose);
            this.groupBox3.Controls.Add(this.btnTransfer);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1012, 616);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Transfer Details";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 17);
            this.label1.TabIndex = 46;
            this.label1.Text = "Primary Preparation - Transfer";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.txtUnitPrice);
            this.groupBox4.Controls.Add(this.txtStopDate);
            this.groupBox4.Controls.Add(this.txtStartDate);
            this.groupBox4.Controls.Add(this.txtInstructedBy);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.lblUnit);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.txtPRPDBatchQty);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.txtMaterialCode);
            this.groupBox4.Controls.Add(this.txtMaterialName);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.txtBatchState);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.cmbPRPDBatch);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.txtMRNo);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Location = new System.Drawing.Point(12, 53);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(994, 278);
            this.groupBox4.TabIndex = 45;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Primary Preparation Batch Details";
            // 
            // txtStopDate
            // 
            this.txtStopDate.BackColor = System.Drawing.SystemColors.Control;
            this.txtStopDate.Enabled = false;
            this.txtStopDate.Location = new System.Drawing.Point(124, 199);
            this.txtStopDate.Name = "txtStopDate";
            this.txtStopDate.Size = new System.Drawing.Size(200, 20);
            this.txtStopDate.TabIndex = 40;
            // 
            // txtStartDate
            // 
            this.txtStartDate.BackColor = System.Drawing.SystemColors.Control;
            this.txtStartDate.Enabled = false;
            this.txtStartDate.Location = new System.Drawing.Point(124, 174);
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.Size = new System.Drawing.Size(200, 20);
            this.txtStartDate.TabIndex = 39;
            // 
            // txtInstructedBy
            // 
            this.txtInstructedBy.Location = new System.Drawing.Point(124, 246);
            this.txtInstructedBy.Name = "txtInstructedBy";
            this.txtInstructedBy.ReadOnly = true;
            this.txtInstructedBy.Size = new System.Drawing.Size(303, 20);
            this.txtInstructedBy.TabIndex = 38;
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.dgvActivities);
            this.groupBox5.Location = new System.Drawing.Point(539, 19);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(449, 233);
            this.groupBox5.TabIndex = 37;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Processed Activities";
            // 
            // dgvActivities
            // 
            this.dgvActivities.AllowUserToAddRows = false;
            this.dgvActivities.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvActivities.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvActivities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActivities.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ActivityName});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvActivities.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvActivities.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvActivities.Location = new System.Drawing.Point(3, 16);
            this.dgvActivities.Name = "dgvActivities";
            this.dgvActivities.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvActivities.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvActivities.Size = new System.Drawing.Size(443, 214);
            this.dgvActivities.TabIndex = 0;
            // 
            // ActivityName
            // 
            this.ActivityName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ActivityName.DataPropertyName = "MainActivity";
            this.ActivityName.HeaderText = "ActivityName";
            this.ActivityName.Name = "ActivityName";
            this.ActivityName.ReadOnly = true;
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Location = new System.Drawing.Point(331, 227);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(38, 13);
            this.lblUnit.TabIndex = 36;
            this.lblUnit.Text = "<Unit>";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(45, 253);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 13);
            this.label12.TabIndex = 34;
            this.label12.Text = "Instructed By";
            // 
            // txtPRPDBatchQty
            // 
            this.txtPRPDBatchQty.BackColor = System.Drawing.SystemColors.Control;
            this.txtPRPDBatchQty.Enabled = false;
            this.txtPRPDBatchQty.Location = new System.Drawing.Point(124, 221);
            this.txtPRPDBatchQty.Name = "txtPRPDBatchQty";
            this.txtPRPDBatchQty.Size = new System.Drawing.Size(200, 20);
            this.txtPRPDBatchQty.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 227);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "PRPDBatch Qty";
            // 
            // txtMaterialCode
            // 
            this.txtMaterialCode.BackColor = System.Drawing.SystemColors.Control;
            this.txtMaterialCode.Enabled = false;
            this.txtMaterialCode.Location = new System.Drawing.Point(87, 111);
            this.txtMaterialCode.Name = "txtMaterialCode";
            this.txtMaterialCode.Size = new System.Drawing.Size(148, 20);
            this.txtMaterialCode.TabIndex = 31;
            // 
            // txtMaterialName
            // 
            this.txtMaterialName.BackColor = System.Drawing.SystemColors.Control;
            this.txtMaterialName.Enabled = false;
            this.txtMaterialName.Location = new System.Drawing.Point(241, 112);
            this.txtMaterialName.Name = "txtMaterialName";
            this.txtMaterialName.Size = new System.Drawing.Size(292, 20);
            this.txtMaterialName.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Material ";
            // 
            // txtBatchState
            // 
            this.txtBatchState.BackColor = System.Drawing.SystemColors.Control;
            this.txtBatchState.Enabled = false;
            this.txtBatchState.Location = new System.Drawing.Point(87, 61);
            this.txtBatchState.Name = "txtBatchState";
            this.txtBatchState.Size = new System.Drawing.Size(264, 20);
            this.txtBatchState.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Batch End Date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 177);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Batch Started Date";
            // 
            // cmbPRPDBatch
            // 
            this.cmbPRPDBatch.DisplayMember = "PRPDBatchID";
            this.cmbPRPDBatch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPRPDBatch.FormattingEnabled = true;
            this.cmbPRPDBatch.Location = new System.Drawing.Point(87, 35);
            this.cmbPRPDBatch.Name = "cmbPRPDBatch";
            this.cmbPRPDBatch.Size = new System.Drawing.Size(264, 21);
            this.cmbPRPDBatch.TabIndex = 24;
            this.cmbPRPDBatch.ValueMember = "PRPDBatchID";
            this.cmbPRPDBatch.SelectedIndexChanged += new System.EventHandler(this.cmbPRPDBatch_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Batch No";
            // 
            // txtMRNo
            // 
            this.txtMRNo.BackColor = System.Drawing.SystemColors.Control;
            this.txtMRNo.Enabled = false;
            this.txtMRNo.Location = new System.Drawing.Point(87, 86);
            this.txtMRNo.Name = "txtMRNo";
            this.txtMRNo.Size = new System.Drawing.Size(264, 20);
            this.txtMRNo.TabIndex = 21;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(38, 89);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 13);
            this.label14.TabIndex = 19;
            this.label14.Text = "MR No";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(14, 66);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(63, 13);
            this.label15.TabIndex = 4;
            this.label15.Text = "Batch State";
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.Controls.Add(this.txtMaterial);
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Controls.Add(this.lblUnit1);
            this.groupBox6.Controls.Add(this.txtDescription);
            this.groupBox6.Controls.Add(this.label16);
            this.groupBox6.Controls.Add(this.txtAddedUnitCost);
            this.groupBox6.Controls.Add(this.label17);
            this.groupBox6.Controls.Add(this.txtAfterReworkQty);
            this.groupBox6.Controls.Add(this.label18);
            this.groupBox6.Location = new System.Drawing.Point(12, 337);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(994, 172);
            this.groupBox6.TabIndex = 44;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Rework Details";
            // 
            // txtMaterial
            // 
            this.txtMaterial.Location = new System.Drawing.Point(120, 17);
            this.txtMaterial.Name = "txtMaterial";
            this.txtMaterial.ReadOnly = true;
            this.txtMaterial.Size = new System.Drawing.Size(307, 20);
            this.txtMaterial.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Processed Material";
            // 
            // lblUnit1
            // 
            this.lblUnit1.AutoSize = true;
            this.lblUnit1.Location = new System.Drawing.Point(331, 46);
            this.lblUnit1.Name = "lblUnit1";
            this.lblUnit1.Size = new System.Drawing.Size(38, 13);
            this.lblUnit1.TabIndex = 40;
            this.lblUnit1.Text = "<Unit>";
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.SystemColors.Control;
            this.txtDescription.Location = new System.Drawing.Point(120, 87);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(507, 52);
            this.txtDescription.TabIndex = 39;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(54, 90);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(60, 13);
            this.label16.TabIndex = 38;
            this.label16.Text = "Description";
            // 
            // txtAddedUnitCost
            // 
            this.txtAddedUnitCost.BackColor = System.Drawing.SystemColors.Control;
            this.txtAddedUnitCost.Location = new System.Drawing.Point(120, 65);
            this.txtAddedUnitCost.Name = "txtAddedUnitCost";
            this.txtAddedUnitCost.Size = new System.Drawing.Size(192, 20);
            this.txtAddedUnitCost.TabIndex = 37;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(8, 69);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(106, 13);
            this.label17.TabIndex = 36;
            this.label17.Text = "Added Unit Cost(Rs.)";
            // 
            // txtAfterReworkQty
            // 
            this.txtAfterReworkQty.BackColor = System.Drawing.SystemColors.Control;
            this.txtAfterReworkQty.Location = new System.Drawing.Point(120, 43);
            this.txtAfterReworkQty.Name = "txtAfterReworkQty";
            this.txtAfterReworkQty.Size = new System.Drawing.Size(192, 20);
            this.txtAfterReworkQty.TabIndex = 35;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(23, 48);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(91, 13);
            this.label18.TabIndex = 34;
            this.label18.Text = "After Rework Qty.";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(931, 587);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnTransfer
            // 
            this.btnTransfer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTransfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransfer.ForeColor = System.Drawing.Color.Maroon;
            this.btnTransfer.Location = new System.Drawing.Point(840, 587);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(85, 23);
            this.btnTransfer.TabIndex = 14;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MainActivity";
            this.dataGridViewTextBoxColumn1.HeaderText = "ActivityName";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(357, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Input Unit Price Rs.";
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(462, 86);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.ReadOnly = true;
            this.txtUnitPrice.Size = new System.Drawing.Size(70, 20);
            this.txtUnitPrice.TabIndex = 41;
            // 
            // frmPRPDBatchTransfer_Preperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 616);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnExit);
            this.Location = new System.Drawing.Point(5, 60);
            this.Name = "frmPRPDBatchTransfer_Preperation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "PRPD BatchTransfer-Preperation";
            this.Load += new System.EventHandler(this.frmPRPDBatchTransfer_Preperation_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivities)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objSourcePRPDBatchActivity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourcePRPDBatches)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dgvActivities;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActivityName;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtPRPDBatchQty;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMaterialCode;
        private System.Windows.Forms.TextBox txtMaterialName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBatchState;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbPRPDBatch;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtAddedUnitCost;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtAfterReworkQty;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.TextBox txtInstructedBy;
        private System.Windows.Forms.TextBox txtMRNo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.BindingSource objSourcePRPDBatchActivity;
        private System.Windows.Forms.BindingSource objSourcePRPDBatches;
        private System.Windows.Forms.TextBox txtStopDate;
        private System.Windows.Forms.TextBox txtStartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label lblUnit1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaterial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.Label label3;
    }
}