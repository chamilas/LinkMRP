namespace MRP_GUI
{
    partial class frmChangePassword
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtRepassword = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCurrentPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtEmpRole = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtExpiryDate = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtRepassword);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtNewPassword);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtCurrentPassword);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(12, 173);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(388, 202);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Change Password";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 112);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Password Tips";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(25, 137);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(257, 52);
            this.label9.TabIndex = 14;
            this.label9.Text = "* Choose a password you\'ll remember\r\n* Use at least 7 characters\r\n* Use a combina" +
    "tion of capital and lowercase letters, \r\n   numbers, and standard symbols (! @ #" +
    " $ % ^ & *)\r\n";
            // 
            // txtRepassword
            // 
            this.txtRepassword.Location = new System.Drawing.Point(184, 80);
            this.txtRepassword.MaxLength = 100;
            this.txtRepassword.Name = "txtRepassword";
            this.txtRepassword.PasswordChar = '*';
            this.txtRepassword.Size = new System.Drawing.Size(175, 20);
            this.txtRepassword.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Re-Enter new Password";
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(184, 51);
            this.txtNewPassword.MaxLength = 100;
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PasswordChar = '*';
            this.txtNewPassword.Size = new System.Drawing.Size(175, 20);
            this.txtNewPassword.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "New Password";
            // 
            // txtCurrentPassword
            // 
            this.txtCurrentPassword.Location = new System.Drawing.Point(184, 22);
            this.txtCurrentPassword.MaxLength = 100;
            this.txtCurrentPassword.Name = "txtCurrentPassword";
            this.txtCurrentPassword.PasswordChar = '*';
            this.txtCurrentPassword.Size = new System.Drawing.Size(175, 20);
            this.txtCurrentPassword.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Current Password";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtExpiryDate);
            this.groupBox1.Controls.Add(this.txtEmpRole);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtEmployeeID);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtUserName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 155);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Information";
            // 
            // txtEmpRole
            // 
            this.txtEmpRole.Location = new System.Drawing.Point(132, 91);
            this.txtEmpRole.Name = "txtEmpRole";
            this.txtEmpRole.ReadOnly = true;
            this.txtEmpRole.Size = new System.Drawing.Size(198, 20);
            this.txtEmpRole.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Employee Role";
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Location = new System.Drawing.Point(132, 65);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.ReadOnly = true;
            this.txtEmployeeID.Size = new System.Drawing.Size(198, 20);
            this.txtEmployeeID.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Employee ID";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(132, 39);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.ReadOnly = true;
            this.txtUserName.Size = new System.Drawing.Size(198, 20);
            this.txtUserName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "User Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(132, 15);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(198, 20);
            this.txtName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(325, 381);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(244, 381);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(75, 23);
            this.btnChange.TabIndex = 15;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(163, 381);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Password Expiry Date";
            // 
            // txtExpiryDate
            // 
            this.txtExpiryDate.Location = new System.Drawing.Point(132, 117);
            this.txtExpiryDate.Name = "txtExpiryDate";
            this.txtExpiryDate.ReadOnly = true;
            this.txtExpiryDate.Size = new System.Drawing.Size(198, 20);
            this.txtExpiryDate.TabIndex = 13;
            // 
            // frmChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 413);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Password";
            this.Load += new System.EventHandler(this.frmChangePassword_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtRepassword;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCurrentPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmpRole;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtExpiryDate;
        private System.Windows.Forms.Label label5;
    }
}