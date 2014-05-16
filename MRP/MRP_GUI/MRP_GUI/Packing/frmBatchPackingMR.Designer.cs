namespace MRP_GUI.Packing
{
    partial class frmBatchPackingMR
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
            this.txtProductCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbMRNO = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDamagedQty = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBatchReturned = new System.Windows.Forms.TextBox();
            this.txtBatchUsed = new System.Windows.Forms.TextBox();
            this.btnFinalize = new System.Windows.Forms.Button();
            this.lblUnit2 = new System.Windows.Forms.Label();
            this.lblUnit3 = new System.Windows.Forms.Label();
            this.lblUnit1 = new System.Windows.Forms.Label();
            this.objSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtQunatityReceived = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPackingBatch = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbMaterial = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSectionStock = new System.Windows.Forms.TextBox();
            this.lblUnit4 = new System.Windows.Forms.Label();
            this.objSourceMaterialList = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.objSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceMaterialList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Batch No";
            // 
            // txtProductCode
            // 
            this.txtProductCode.Location = new System.Drawing.Point(107, 18);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.ReadOnly = true;
            this.txtProductCode.Size = new System.Drawing.Size(161, 21);
            this.txtProductCode.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "MR No";
            // 
            // cmbMRNO
            // 
            this.cmbMRNO.DisplayMember = "MRNO";
            this.cmbMRNO.FormattingEnabled = true;
            this.cmbMRNO.Location = new System.Drawing.Point(107, 128);
            this.cmbMRNO.Name = "cmbMRNO";
            this.cmbMRNO.Size = new System.Drawing.Size(163, 23);
            this.cmbMRNO.TabIndex = 0;
            this.cmbMRNO.ValueMember = "ID";
            this.cmbMRNO.SelectedIndexChanged += new System.EventHandler(this.cmbMRNO_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Damaged Qty";
            // 
            // txtDamagedQty
            // 
            this.txtDamagedQty.Location = new System.Drawing.Point(107, 202);
            this.txtDamagedQty.Name = "txtDamagedQty";
            this.txtDamagedQty.Size = new System.Drawing.Size(163, 21);
            this.txtDamagedQty.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Coral;
            this.label4.Location = new System.Drawing.Point(12, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Returned Qty";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Batch Used Qty";
            // 
            // txtBatchReturned
            // 
            this.txtBatchReturned.BackColor = System.Drawing.Color.Coral;
            this.txtBatchReturned.Location = new System.Drawing.Point(107, 238);
            this.txtBatchReturned.Name = "txtBatchReturned";
            this.txtBatchReturned.Size = new System.Drawing.Size(163, 21);
            this.txtBatchReturned.TabIndex = 3;
            // 
            // txtBatchUsed
            // 
            this.txtBatchUsed.Location = new System.Drawing.Point(107, 166);
            this.txtBatchUsed.Name = "txtBatchUsed";
            this.txtBatchUsed.Size = new System.Drawing.Size(163, 21);
            this.txtBatchUsed.TabIndex = 1;
            // 
            // btnFinalize
            // 
            this.btnFinalize.Location = new System.Drawing.Point(503, 237);
            this.btnFinalize.Name = "btnFinalize";
            this.btnFinalize.Size = new System.Drawing.Size(84, 33);
            this.btnFinalize.TabIndex = 4;
            this.btnFinalize.Text = "Issue";
            this.btnFinalize.UseVisualStyleBackColor = true;
            this.btnFinalize.Click += new System.EventHandler(this.btnFinalize_Click);
            // 
            // lblUnit2
            // 
            this.lblUnit2.AutoSize = true;
            this.lblUnit2.Location = new System.Drawing.Point(282, 205);
            this.lblUnit2.Name = "lblUnit2";
            this.lblUnit2.Size = new System.Drawing.Size(41, 15);
            this.lblUnit2.TabIndex = 13;
            this.lblUnit2.Text = "<unit>";
            // 
            // lblUnit3
            // 
            this.lblUnit3.AutoSize = true;
            this.lblUnit3.BackColor = System.Drawing.Color.Coral;
            this.lblUnit3.Location = new System.Drawing.Point(282, 240);
            this.lblUnit3.Name = "lblUnit3";
            this.lblUnit3.Size = new System.Drawing.Size(41, 15);
            this.lblUnit3.TabIndex = 14;
            this.lblUnit3.Text = "<unit>";
            // 
            // lblUnit1
            // 
            this.lblUnit1.AutoSize = true;
            this.lblUnit1.Location = new System.Drawing.Point(284, 170);
            this.lblUnit1.Name = "lblUnit1";
            this.lblUnit1.Size = new System.Drawing.Size(41, 15);
            this.lblUnit1.TabIndex = 12;
            this.lblUnit1.Text = "<unit>";
            // 
            // txtQunatityReceived
            // 
            this.txtQunatityReceived.Location = new System.Drawing.Point(378, 135);
            this.txtQunatityReceived.Name = "txtQunatityReceived";
            this.txtQunatityReceived.ReadOnly = true;
            this.txtQunatityReceived.Size = new System.Drawing.Size(119, 21);
            this.txtQunatityReceived.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(371, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Packing Batch";
            // 
            // txtPackingBatch
            // 
            this.txtPackingBatch.Location = new System.Drawing.Point(468, 18);
            this.txtPackingBatch.Name = "txtPackingBatch";
            this.txtPackingBatch.ReadOnly = true;
            this.txtPackingBatch.Size = new System.Drawing.Size(119, 21);
            this.txtPackingBatch.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(284, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "Remaining Qty";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 15);
            this.label8.TabIndex = 8;
            this.label8.Text = "Material";
            // 
            // cmbMaterial
            // 
            this.cmbMaterial.DisplayMember = "Material";
            this.cmbMaterial.FormattingEnabled = true;
            this.cmbMaterial.Location = new System.Drawing.Point(107, 54);
            this.cmbMaterial.Name = "cmbMaterial";
            this.cmbMaterial.Size = new System.Drawing.Size(480, 23);
            this.cmbMaterial.TabIndex = 16;
            this.cmbMaterial.ValueMember = "MaterialCode";
            this.cmbMaterial.SelectedIndexChanged += new System.EventHandler(this.cmbMaterial_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 15);
            this.label9.TabIndex = 8;
            this.label9.Text = "Section Stock";
            // 
            // txtSectionStock
            // 
            this.txtSectionStock.Location = new System.Drawing.Point(107, 92);
            this.txtSectionStock.Name = "txtSectionStock";
            this.txtSectionStock.ReadOnly = true;
            this.txtSectionStock.Size = new System.Drawing.Size(163, 21);
            this.txtSectionStock.TabIndex = 17;
            // 
            // lblUnit4
            // 
            this.lblUnit4.AutoSize = true;
            this.lblUnit4.Location = new System.Drawing.Point(282, 100);
            this.lblUnit4.Name = "lblUnit4";
            this.lblUnit4.Size = new System.Drawing.Size(41, 15);
            this.lblUnit4.TabIndex = 12;
            this.lblUnit4.Text = "<unit>";
            // 
            // frmBatchPackingMR
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(601, 279);
            this.Controls.Add(this.txtSectionStock);
            this.Controls.Add(this.cmbMaterial);
            this.Controls.Add(this.txtPackingBatch);
            this.Controls.Add(this.txtQunatityReceived);
            this.Controls.Add(this.btnFinalize);
            this.Controls.Add(this.txtBatchUsed);
            this.Controls.Add(this.txtBatchReturned);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDamagedQty);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblUnit4);
            this.Controls.Add(this.lblUnit1);
            this.Controls.Add(this.lblUnit3);
            this.Controls.Add(this.lblUnit2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbMRNO);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtProductCode);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmBatchPackingMR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Batch Packing MR";
            this.Load += new System.EventHandler(this.frmBatchPackingMR_Load);
            ((System.ComponentModel.ISupportInitialize)(this.objSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceMaterialList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProductCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbMRNO;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDamagedQty;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBatchReturned;
        private System.Windows.Forms.TextBox txtBatchUsed;
        private System.Windows.Forms.Button btnFinalize;
        private System.Windows.Forms.Label lblUnit2;
        private System.Windows.Forms.Label lblUnit3;
        private System.Windows.Forms.Label lblUnit1;
        private System.Windows.Forms.BindingSource objSource;
        private System.Windows.Forms.TextBox txtQunatityReceived;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPackingBatch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbMaterial;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSectionStock;
        private System.Windows.Forms.Label lblUnit4;
        private System.Windows.Forms.BindingSource objSourceMaterialList;
    }
}