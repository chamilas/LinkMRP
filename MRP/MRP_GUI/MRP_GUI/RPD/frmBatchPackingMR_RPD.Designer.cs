namespace MRP_GUI
{
    partial class frmBatchPackingMR_RPD
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
            ((System.ComponentModel.ISupportInitialize)(this.objSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "MRNo";
            // 
            // cmbMRNO
            // 
            this.cmbMRNO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbMRNO.DisplayMember = "Item";
            this.cmbMRNO.FormattingEnabled = true;
            this.cmbMRNO.Location = new System.Drawing.Point(134, 12);
            this.cmbMRNO.Name = "cmbMRNO";
            this.cmbMRNO.Size = new System.Drawing.Size(163, 23);
            this.cmbMRNO.TabIndex = 0;
            this.cmbMRNO.ValueMember = "ID";
            this.cmbMRNO.SelectedIndexChanged += new System.EventHandler(this.cmbMRNO_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Damaged Qty";
            // 
            // txtDamagedQty
            // 
            this.txtDamagedQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDamagedQty.Location = new System.Drawing.Point(134, 68);
            this.txtDamagedQty.Name = "txtDamagedQty";
            this.txtDamagedQty.Size = new System.Drawing.Size(163, 21);
            this.txtDamagedQty.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(48, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Returned Qty";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Batch Used Qty";
            // 
            // txtBatchReturned
            // 
            this.txtBatchReturned.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBatchReturned.BackColor = System.Drawing.SystemColors.Window;
            this.txtBatchReturned.Location = new System.Drawing.Point(134, 95);
            this.txtBatchReturned.Name = "txtBatchReturned";
            this.txtBatchReturned.Size = new System.Drawing.Size(163, 21);
            this.txtBatchReturned.TabIndex = 3;
            // 
            // txtBatchUsed
            // 
            this.txtBatchUsed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBatchUsed.Location = new System.Drawing.Point(134, 41);
            this.txtBatchUsed.Name = "txtBatchUsed";
            this.txtBatchUsed.Size = new System.Drawing.Size(163, 21);
            this.txtBatchUsed.TabIndex = 1;
            // 
            // btnFinalize
            // 
            this.btnFinalize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFinalize.Location = new System.Drawing.Point(380, 79);
            this.btnFinalize.Name = "btnFinalize";
            this.btnFinalize.Size = new System.Drawing.Size(84, 33);
            this.btnFinalize.TabIndex = 4;
            this.btnFinalize.Text = "Issue";
            this.btnFinalize.UseVisualStyleBackColor = true;
            this.btnFinalize.Click += new System.EventHandler(this.btnFinalize_Click);
            // 
            // lblUnit2
            // 
            this.lblUnit2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUnit2.AutoSize = true;
            this.lblUnit2.Location = new System.Drawing.Point(303, 71);
            this.lblUnit2.Name = "lblUnit2";
            this.lblUnit2.Size = new System.Drawing.Size(29, 15);
            this.lblUnit2.TabIndex = 13;
            this.lblUnit2.Text = "Nos";
            // 
            // lblUnit3
            // 
            this.lblUnit3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUnit3.AutoSize = true;
            this.lblUnit3.BackColor = System.Drawing.SystemColors.Control;
            this.lblUnit3.Location = new System.Drawing.Point(303, 98);
            this.lblUnit3.Name = "lblUnit3";
            this.lblUnit3.Size = new System.Drawing.Size(29, 15);
            this.lblUnit3.TabIndex = 14;
            this.lblUnit3.Text = "Nos";
            // 
            // lblUnit1
            // 
            this.lblUnit1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUnit1.AutoSize = true;
            this.lblUnit1.Location = new System.Drawing.Point(303, 41);
            this.lblUnit1.Name = "lblUnit1";
            this.lblUnit1.Size = new System.Drawing.Size(29, 15);
            this.lblUnit1.TabIndex = 12;
            this.lblUnit1.Text = "Nos";
            // 
            // txtQunatityReceived
            // 
            this.txtQunatityReceived.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQunatityReceived.Location = new System.Drawing.Point(364, 10);
            this.txtQunatityReceived.Name = "txtQunatityReceived";
            this.txtQunatityReceived.ReadOnly = true;
            this.txtQunatityReceived.Size = new System.Drawing.Size(100, 21);
            this.txtQunatityReceived.TabIndex = 6;
            // 
            // frmBatchPackingMR_RPD
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(513, 128);
            this.Controls.Add(this.txtQunatityReceived);
            this.Controls.Add(this.btnFinalize);
            this.Controls.Add(this.txtBatchUsed);
            this.Controls.Add(this.txtBatchReturned);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDamagedQty);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblUnit1);
            this.Controls.Add(this.lblUnit3);
            this.Controls.Add(this.lblUnit2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbMRNO);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmBatchPackingMR_RPD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Batch Packing MR - RPD";
            this.Load += new System.EventHandler(this.frmBatchPackingMR_Load);
            ((System.ComponentModel.ISupportInitialize)(this.objSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
    }
}