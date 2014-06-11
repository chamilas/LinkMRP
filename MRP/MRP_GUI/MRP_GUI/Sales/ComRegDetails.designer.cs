namespace MRP_GUI.Sales
{
    partial class ComRegDetails
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
            this.cmb_companyRegNum = new System.Windows.Forms.ComboBox();
            this.cmb_busReg_num = new System.Windows.Forms.ComboBox();
            this.txt_vatRegNum = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Company Register Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Business Register Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Vat Register Number";
            // 
            // cmb_companyRegNum
            // 
            this.cmb_companyRegNum.FormattingEnabled = true;
            this.cmb_companyRegNum.Location = new System.Drawing.Point(210, 40);
            this.cmb_companyRegNum.Name = "cmb_companyRegNum";
            this.cmb_companyRegNum.Size = new System.Drawing.Size(121, 21);
            this.cmb_companyRegNum.TabIndex = 3;
            // 
            // cmb_busReg_num
            // 
            this.cmb_busReg_num.FormattingEnabled = true;
            this.cmb_busReg_num.Location = new System.Drawing.Point(210, 82);
            this.cmb_busReg_num.Name = "cmb_busReg_num";
            this.cmb_busReg_num.Size = new System.Drawing.Size(121, 21);
            this.cmb_busReg_num.TabIndex = 4;
            // 
            // txt_vatRegNum
            // 
            this.txt_vatRegNum.Location = new System.Drawing.Point(210, 124);
            this.txt_vatRegNum.Name = "txt_vatRegNum";
            this.txt_vatRegNum.Size = new System.Drawing.Size(121, 20);
            this.txt_vatRegNum.TabIndex = 5;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(157, 176);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 6;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(256, 176);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 7;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // ComRegDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 231);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txt_vatRegNum);
            this.Controls.Add(this.cmb_busReg_num);
            this.Controls.Add(this.cmb_companyRegNum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ComRegDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Company Register Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_companyRegNum;
        private System.Windows.Forms.ComboBox cmb_busReg_num;
        private System.Windows.Forms.TextBox txt_vatRegNum;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_cancel;
    }
}