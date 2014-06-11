namespace MRP_GUI.Sales
{
    partial class FinanceDetails
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_BankGuarantyAmount = new System.Windows.Forms.TextBox();
            this.txt_guarantyBank = new System.Windows.Forms.TextBox();
            this.txt_branch = new System.Windows.Forms.TextBox();
            this.txt_exceedPrecentage = new System.Windows.Forms.TextBox();
            this.txt_remainingDates = new System.Windows.Forms.TextBox();
            this.dpk_renewDate = new System.Windows.Forms.DateTimePicker();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bank Guaranty Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Guaranty Bank";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bank Guaranty Exceed Precentage";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Branch";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Renew Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Remaining Dates";
            // 
            // txt_BankGuarantyAmount
            // 
            this.txt_BankGuarantyAmount.Location = new System.Drawing.Point(239, 32);
            this.txt_BankGuarantyAmount.Name = "txt_BankGuarantyAmount";
            this.txt_BankGuarantyAmount.Size = new System.Drawing.Size(149, 20);
            this.txt_BankGuarantyAmount.TabIndex = 6;
            // 
            // txt_guarantyBank
            // 
            this.txt_guarantyBank.Location = new System.Drawing.Point(239, 67);
            this.txt_guarantyBank.Name = "txt_guarantyBank";
            this.txt_guarantyBank.Size = new System.Drawing.Size(149, 20);
            this.txt_guarantyBank.TabIndex = 7;
            // 
            // txt_branch
            // 
            this.txt_branch.Location = new System.Drawing.Point(239, 101);
            this.txt_branch.Name = "txt_branch";
            this.txt_branch.Size = new System.Drawing.Size(149, 20);
            this.txt_branch.TabIndex = 8;
            // 
            // txt_exceedPrecentage
            // 
            this.txt_exceedPrecentage.Location = new System.Drawing.Point(239, 136);
            this.txt_exceedPrecentage.Name = "txt_exceedPrecentage";
            this.txt_exceedPrecentage.Size = new System.Drawing.Size(149, 20);
            this.txt_exceedPrecentage.TabIndex = 9;
            // 
            // txt_remainingDates
            // 
            this.txt_remainingDates.Location = new System.Drawing.Point(239, 213);
            this.txt_remainingDates.Name = "txt_remainingDates";
            this.txt_remainingDates.Size = new System.Drawing.Size(149, 20);
            this.txt_remainingDates.TabIndex = 11;
            // 
            // dpk_renewDate
            // 
            this.dpk_renewDate.Location = new System.Drawing.Point(239, 175);
            this.dpk_renewDate.Name = "dpk_renewDate";
            this.dpk_renewDate.Size = new System.Drawing.Size(149, 20);
            this.dpk_renewDate.TabIndex = 12;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(151, 252);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 13;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(232, 252);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 23);
            this.btn_clear.TabIndex = 14;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(313, 252);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 15;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // FinanceDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 306);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.dpk_renewDate);
            this.Controls.Add(this.txt_remainingDates);
            this.Controls.Add(this.txt_exceedPrecentage);
            this.Controls.Add(this.txt_branch);
            this.Controls.Add(this.txt_guarantyBank);
            this.Controls.Add(this.txt_BankGuarantyAmount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FinanceDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Finance Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_BankGuarantyAmount;
        private System.Windows.Forms.TextBox txt_guarantyBank;
        private System.Windows.Forms.TextBox txt_branch;
        private System.Windows.Forms.TextBox txt_exceedPrecentage;
        private System.Windows.Forms.TextBox txt_remainingDates;
        private System.Windows.Forms.DateTimePicker dpk_renewDate;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_cancel;
    }
}