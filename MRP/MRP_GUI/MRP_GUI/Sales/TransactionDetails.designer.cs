namespace MRP_GUI.Sales
{
    partial class TransactionDetails
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
            this.txt_openingBalanace = new System.Windows.Forms.TextBox();
            this.txt_receviedCheques = new System.Windows.Forms.TextBox();
            this.txt_returnedCheques = new System.Windows.Forms.TextBox();
            this.txt_dueAmount = new System.Windows.Forms.TextBox();
            this.drp_customerStatus = new System.Windows.Forms.ComboBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Opening Balance";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Recevied Cheques";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Returned Cheques";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Due Amount";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Customer Status (Blocked)";
            // 
            // txt_openingBalanace
            // 
            this.txt_openingBalanace.Location = new System.Drawing.Point(200, 31);
            this.txt_openingBalanace.Name = "txt_openingBalanace";
            this.txt_openingBalanace.Size = new System.Drawing.Size(133, 20);
            this.txt_openingBalanace.TabIndex = 5;
            // 
            // txt_receviedCheques
            // 
            this.txt_receviedCheques.Location = new System.Drawing.Point(200, 66);
            this.txt_receviedCheques.Name = "txt_receviedCheques";
            this.txt_receviedCheques.Size = new System.Drawing.Size(133, 20);
            this.txt_receviedCheques.TabIndex = 6;
            // 
            // txt_returnedCheques
            // 
            this.txt_returnedCheques.Location = new System.Drawing.Point(200, 102);
            this.txt_returnedCheques.Name = "txt_returnedCheques";
            this.txt_returnedCheques.Size = new System.Drawing.Size(133, 20);
            this.txt_returnedCheques.TabIndex = 7;
            // 
            // txt_dueAmount
            // 
            this.txt_dueAmount.Location = new System.Drawing.Point(200, 137);
            this.txt_dueAmount.Name = "txt_dueAmount";
            this.txt_dueAmount.Size = new System.Drawing.Size(133, 20);
            this.txt_dueAmount.TabIndex = 8;
            // 
            // drp_customerStatus
            // 
            this.drp_customerStatus.FormattingEnabled = true;
            this.drp_customerStatus.Items.AddRange(new object[] {
            "Manual",
            "Automatic",
            "Both"});
            this.drp_customerStatus.Location = new System.Drawing.Point(200, 174);
            this.drp_customerStatus.Name = "drp_customerStatus";
            this.drp_customerStatus.Size = new System.Drawing.Size(133, 21);
            this.drp_customerStatus.TabIndex = 9;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(96, 214);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 10;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(177, 214);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 23);
            this.btn_clear.TabIndex = 11;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(258, 214);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 12;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // TransactionDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 267);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.drp_customerStatus);
            this.Controls.Add(this.txt_dueAmount);
            this.Controls.Add(this.txt_returnedCheques);
            this.Controls.Add(this.txt_receviedCheques);
            this.Controls.Add(this.txt_openingBalanace);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TransactionDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transaction Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_openingBalanace;
        private System.Windows.Forms.TextBox txt_receviedCheques;
        private System.Windows.Forms.TextBox txt_returnedCheques;
        private System.Windows.Forms.TextBox txt_dueAmount;
        private System.Windows.Forms.ComboBox drp_customerStatus;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_cancel;
    }
}