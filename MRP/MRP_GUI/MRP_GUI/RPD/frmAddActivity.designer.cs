namespace MRP_GUI.RPD.RPDBatchActivityForms
{
    partial class frmAddActivity
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddActivity));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtStartQty = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.cmbSupervisedBy = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbInstructedBy = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
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
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.btnSave);
            this.groupBox3.Controls.Add(this.btnClose);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.txtComment);
            this.groupBox3.Controls.Add(this.cmbSupervisedBy);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.cmbInstructedBy);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.cmbActivity);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Location = new System.Drawing.Point(3, 1);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(507, 217);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Add/Edit Activity";
            // 
            // txtStartQty
            // 
            this.txtStartQty.Location = new System.Drawing.Point(89, 187);
            this.txtStartQty.Name = "txtStartQty";
            this.txtStartQty.Size = new System.Drawing.Size(100, 20);
            this.txtStartQty.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 45;
            this.label1.Text = "Start Qty";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(345, 187);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(426, 187);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(27, 121);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(56, 13);
            this.label15.TabIndex = 42;
            this.label15.Text = "Comments";
            // 
            // txtComment
            // 
            this.txtComment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtComment.Location = new System.Drawing.Point(89, 100);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(412, 81);
            this.txtComment.TabIndex = 3;
            // 
            // cmbSupervisedBy
            // 
            this.cmbSupervisedBy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbSupervisedBy.DisplayMember = "Employee";
            this.cmbSupervisedBy.FormattingEnabled = true;
            this.cmbSupervisedBy.Location = new System.Drawing.Point(90, 46);
            this.cmbSupervisedBy.Name = "cmbSupervisedBy";
            this.cmbSupervisedBy.Size = new System.Drawing.Size(330, 21);
            this.cmbSupervisedBy.TabIndex = 1;
            this.cmbSupervisedBy.ValueMember = "EmpID";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 49);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 13);
            this.label14.TabIndex = 39;
            this.label14.Text = "Supervised By";
            // 
            // cmbInstructedBy
            // 
            this.cmbInstructedBy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbInstructedBy.DisplayMember = "Employee";
            this.cmbInstructedBy.FormattingEnabled = true;
            this.cmbInstructedBy.Location = new System.Drawing.Point(90, 73);
            this.cmbInstructedBy.Name = "cmbInstructedBy";
            this.cmbInstructedBy.Size = new System.Drawing.Size(330, 21);
            this.cmbInstructedBy.TabIndex = 2;
            this.cmbInstructedBy.ValueMember = "EmpID";
            this.cmbInstructedBy.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(14, 81);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 13);
            this.label13.TabIndex = 37;
            this.label13.Text = "Inspected By";
            this.label13.Visible = false;
            // 
            // cmbActivity
            // 
            this.cmbActivity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbActivity.DisplayMember = "MainActivity";
            this.cmbActivity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbActivity.FormattingEnabled = true;
            this.cmbActivity.Location = new System.Drawing.Point(90, 19);
            this.cmbActivity.Name = "cmbActivity";
            this.cmbActivity.Size = new System.Drawing.Size(330, 21);
            this.cmbActivity.TabIndex = 0;
            this.cmbActivity.ValueMember = "MainActID";
            this.cmbActivity.SelectedIndexChanged += new System.EventHandler(this.cmbActivity_SelectedIndexChanged);
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
            // frmAddActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 222);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddActivity";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RPD Batch Activity";
            this.Load += new System.EventHandler(this.frmAddActivity_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.ComboBox cmbSupervisedBy;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmbInstructedBy;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbActivity;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtStartQty;
        private System.Windows.Forms.Label label1;
    }
}