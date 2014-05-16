namespace MRP_GUI.Inventory.MR
{
    partial class frmMRManagePOPUP
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
            this.lblMRNo = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblReruestedBy = new System.Windows.Forms.Label();
            this.lblReruestedDate = new System.Windows.Forms.Label();
            this.lblIssuedBy = new System.Windows.Forms.Label();
            this.lblIssuedDate = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblReceivedBy = new System.Windows.Forms.Label();
            this.lblReceivedDate = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.groupBoxMaterials = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescriptionOfItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RequestedQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IssuedQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnReject = new System.Windows.Forms.Button();
            this.btnApprove = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblMaterialRequisitionNote = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblRemarks = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.groupBoxMaterials.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMRNo
            // 
            this.lblMRNo.AutoSize = true;
            this.lblMRNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMRNo.Location = new System.Drawing.Point(30, 49);
            this.lblMRNo.Name = "lblMRNo";
            this.lblMRNo.Size = new System.Drawing.Size(67, 17);
            this.lblMRNo.TabIndex = 0;
            this.lblMRNo.Text = "MRN No";
            this.lblMRNo.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(30, 75);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(62, 13);
            this.lblDepartment.TabIndex = 1;
            this.lblDepartment.Text = "Department";
            // 
            // lblReruestedBy
            // 
            this.lblReruestedBy.AutoSize = true;
            this.lblReruestedBy.Location = new System.Drawing.Point(30, 101);
            this.lblReruestedBy.Name = "lblReruestedBy";
            this.lblReruestedBy.Size = new System.Drawing.Size(71, 13);
            this.lblReruestedBy.TabIndex = 2;
            this.lblReruestedBy.Text = "Reruested By";
            // 
            // lblReruestedDate
            // 
            this.lblReruestedDate.AutoSize = true;
            this.lblReruestedDate.Location = new System.Drawing.Point(30, 127);
            this.lblReruestedDate.Name = "lblReruestedDate";
            this.lblReruestedDate.Size = new System.Drawing.Size(82, 13);
            this.lblReruestedDate.TabIndex = 3;
            this.lblReruestedDate.Text = "Reruested Date";
            // 
            // lblIssuedBy
            // 
            this.lblIssuedBy.AutoSize = true;
            this.lblIssuedBy.Location = new System.Drawing.Point(30, 153);
            this.lblIssuedBy.Name = "lblIssuedBy";
            this.lblIssuedBy.Size = new System.Drawing.Size(53, 13);
            this.lblIssuedBy.TabIndex = 4;
            this.lblIssuedBy.Text = "Issued By";
            // 
            // lblIssuedDate
            // 
            this.lblIssuedDate.AutoSize = true;
            this.lblIssuedDate.Location = new System.Drawing.Point(30, 179);
            this.lblIssuedDate.Name = "lblIssuedDate";
            this.lblIssuedDate.Size = new System.Drawing.Size(64, 13);
            this.lblIssuedDate.TabIndex = 5;
            this.lblIssuedDate.Text = "Issued Date";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(303, 49);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(35, 13);
            this.lblType.TabIndex = 6;
            this.lblType.Text = "Type";
            // 
            // lblReceivedBy
            // 
            this.lblReceivedBy.AutoSize = true;
            this.lblReceivedBy.Location = new System.Drawing.Point(526, 49);
            this.lblReceivedBy.Name = "lblReceivedBy";
            this.lblReceivedBy.Size = new System.Drawing.Size(68, 13);
            this.lblReceivedBy.TabIndex = 7;
            this.lblReceivedBy.Text = "Received By";
            // 
            // lblReceivedDate
            // 
            this.lblReceivedDate.AutoSize = true;
            this.lblReceivedDate.Location = new System.Drawing.Point(526, 75);
            this.lblReceivedDate.Name = "lblReceivedDate";
            this.lblReceivedDate.Size = new System.Drawing.Size(79, 13);
            this.lblReceivedDate.TabIndex = 8;
            this.lblReceivedDate.Text = "Received Date";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.Location = new System.Drawing.Point(130, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(152, 20);
            this.textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Control;
            this.textBox2.Location = new System.Drawing.Point(130, 68);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(152, 20);
            this.textBox2.TabIndex = 10;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Control;
            this.textBox3.Location = new System.Drawing.Point(130, 94);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(152, 20);
            this.textBox3.TabIndex = 11;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.Control;
            this.textBox4.Location = new System.Drawing.Point(130, 120);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(152, 20);
            this.textBox4.TabIndex = 12;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.Control;
            this.textBox5.Location = new System.Drawing.Point(130, 146);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(152, 20);
            this.textBox5.TabIndex = 13;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.Control;
            this.textBox6.Location = new System.Drawing.Point(130, 172);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(152, 20);
            this.textBox6.TabIndex = 14;
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.SystemColors.Control;
            this.textBox7.Location = new System.Drawing.Point(340, 46);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(147, 20);
            this.textBox7.TabIndex = 15;
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.SystemColors.Control;
            this.textBox8.Location = new System.Drawing.Point(611, 42);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(158, 20);
            this.textBox8.TabIndex = 16;
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.SystemColors.Control;
            this.textBox9.Location = new System.Drawing.Point(611, 68);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(158, 20);
            this.textBox9.TabIndex = 17;
            // 
            // groupBoxMaterials
            // 
            this.groupBoxMaterials.Controls.Add(this.dataGridView1);
            this.groupBoxMaterials.Location = new System.Drawing.Point(3, 217);
            this.groupBoxMaterials.Name = "groupBoxMaterials";
            this.groupBoxMaterials.Size = new System.Drawing.Size(814, 288);
            this.groupBoxMaterials.TabIndex = 18;
            this.groupBoxMaterials.TabStop = false;
            this.groupBoxMaterials.Text = "Materials";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Item,
            this.DescriptionOfItem,
            this.RequestedQty,
            this.IssuedQty,
            this.Unit});
            this.dataGridView1.Location = new System.Drawing.Point(7, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(801, 260);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Item
            // 
            this.Item.HeaderText = "Item";
            this.Item.Name = "Item";
            this.Item.Width = 250;
            // 
            // DescriptionOfItem
            // 
            this.DescriptionOfItem.HeaderText = "Description Of Item";
            this.DescriptionOfItem.Name = "DescriptionOfItem";
            this.DescriptionOfItem.Width = 250;
            // 
            // RequestedQty
            // 
            this.RequestedQty.HeaderText = "Reqd Qty";
            this.RequestedQty.Name = "RequestedQty";
            // 
            // IssuedQty
            // 
            this.IssuedQty.HeaderText = "Issued Qty ";
            this.IssuedQty.Name = "IssuedQty";
            // 
            // Unit
            // 
            this.Unit.HeaderText = "Unit";
            this.Unit.Name = "Unit";
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(412, 522);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 19;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(493, 522);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnReject
            // 
            this.btnReject.Location = new System.Drawing.Point(574, 522);
            this.btnReject.Name = "btnReject";
            this.btnReject.Size = new System.Drawing.Size(75, 23);
            this.btnReject.TabIndex = 21;
            this.btnReject.Text = "Reject";
            this.btnReject.UseVisualStyleBackColor = true;
            // 
            // btnApprove
            // 
            this.btnApprove.Location = new System.Drawing.Point(655, 522);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(75, 23);
            this.btnApprove.TabIndex = 22;
            this.btnApprove.Text = "Approve";
            this.btnApprove.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(736, 522);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 23;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // lblMaterialRequisitionNote
            // 
            this.lblMaterialRequisitionNote.AutoSize = true;
            this.lblMaterialRequisitionNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaterialRequisitionNote.Location = new System.Drawing.Point(30, 9);
            this.lblMaterialRequisitionNote.Name = "lblMaterialRequisitionNote";
            this.lblMaterialRequisitionNote.Size = new System.Drawing.Size(191, 17);
            this.lblMaterialRequisitionNote.TabIndex = 24;
            this.lblMaterialRequisitionNote.Text = "Material Requisition Note";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(732, 9);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 25;
            this.lblStatus.Text = "Status";
            // 
            // lblRemarks
            // 
            this.lblRemarks.AutoSize = true;
            this.lblRemarks.Location = new System.Drawing.Point(529, 101);
            this.lblRemarks.Name = "lblRemarks";
            this.lblRemarks.Size = new System.Drawing.Size(49, 13);
            this.lblRemarks.TabIndex = 26;
            this.lblRemarks.Text = "Remarks";
            // 
            // textBox10
            // 
            this.textBox10.BackColor = System.Drawing.SystemColors.Control;
            this.textBox10.Location = new System.Drawing.Point(611, 101);
            this.textBox10.Multiline = true;
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(158, 91);
            this.textBox10.TabIndex = 27;
            // 
            // frmMRManagePOPUP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 566);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.lblRemarks);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblMaterialRequisitionNote);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnApprove);
            this.Controls.Add(this.btnReject);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.groupBoxMaterials);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblReceivedDate);
            this.Controls.Add(this.lblReceivedBy);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblIssuedDate);
            this.Controls.Add(this.lblIssuedBy);
            this.Controls.Add(this.lblReruestedDate);
            this.Controls.Add(this.lblReruestedBy);
            this.Controls.Add(this.lblDepartment);
            this.Controls.Add(this.lblMRNo);
            this.Name = "frmMRManagePOPUP";
            this.Text = "Material Requisition Note";
            this.Load += new System.EventHandler(this.frmMRManagePOPUP_Load);
            this.groupBoxMaterials.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMRNo;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblReruestedBy;
        private System.Windows.Forms.Label lblReruestedDate;
        private System.Windows.Forms.Label lblIssuedBy;
        private System.Windows.Forms.Label lblIssuedDate;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblReceivedBy;
        private System.Windows.Forms.Label lblReceivedDate;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.GroupBox groupBoxMaterials;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnReject;
        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescriptionOfItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn RequestedQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn IssuedQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private System.Windows.Forms.Label lblMaterialRequisitionNote;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblRemarks;
        private System.Windows.Forms.TextBox textBox10;
    }
}