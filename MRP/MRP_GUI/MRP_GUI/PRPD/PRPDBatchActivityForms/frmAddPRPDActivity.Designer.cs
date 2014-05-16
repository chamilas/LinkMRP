namespace MRP_GUI.PRPD.PRPDBatchActivityForms
{
    partial class frmAddPRPDActivity
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtStartQty = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbActivity = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.txtStartQty);
            this.groupBox3.Controls.Add(this.btnSave);
            this.groupBox3.Controls.Add(this.btnClose);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtComment);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.cmbActivity);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(497, 190);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Add/Edit Activity";
            // 
            // txtStartQty
            // 
            this.txtStartQty.Location = new System.Drawing.Point(93, 158);
            this.txtStartQty.Name = "txtStartQty";
            this.txtStartQty.Size = new System.Drawing.Size(100, 20);
            this.txtStartQty.TabIndex = 45;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(326, 160);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 44;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(407, 160);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 43;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "Comments";
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(93, 49);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(389, 105);
            this.txtComment.TabIndex = 41;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(28, 165);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 13);
            this.label14.TabIndex = 39;
            this.label14.Text = "Start Qty";
            // 
            // cmbActivity
            // 
            this.cmbActivity.DisplayMember = "MainActivity";
            this.cmbActivity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbActivity.FormattingEnabled = true;
            this.cmbActivity.Location = new System.Drawing.Point(93, 19);
            this.cmbActivity.Name = "cmbActivity";
            this.cmbActivity.Size = new System.Drawing.Size(268, 21);
            this.cmbActivity.TabIndex = 1;
            this.cmbActivity.ValueMember = "MainActID";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(42, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Activity";
            // 
            // frmAddPRPDActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 207);
            this.Controls.Add(this.groupBox3);
            this.Name = "frmAddPRPDActivity";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Activity";
            this.Load += new System.EventHandler(this.frmAddPRPDActivity_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmbActivity;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtStartQty;
        private System.Windows.Forms.Label label1;
    }
}