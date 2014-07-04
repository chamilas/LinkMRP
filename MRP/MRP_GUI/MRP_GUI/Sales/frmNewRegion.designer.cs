namespace MRP_GUI.Sales
{
    partial class frmNewRegion
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
            this.txt_name = new System.Windows.Forms.TextBox();
            this.cmb_ASM = new System.Windows.Forms.ComboBox();
            this.cmb_province = new System.Windows.Forms.ComboBox();
            this.cmb_productCategory = new System.Windows.Forms.ComboBox();
            this.cmb_salesMethod = new System.Windows.Forms.ComboBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Region Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ASM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Province";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Product Category";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Sales Method";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(183, 30);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(185, 20);
            this.txt_name.TabIndex = 5;
            // 
            // cmb_ASM
            // 
            this.cmb_ASM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_ASM.FormattingEnabled = true;
            this.cmb_ASM.Location = new System.Drawing.Point(183, 69);
            this.cmb_ASM.Name = "cmb_ASM";
            this.cmb_ASM.Size = new System.Drawing.Size(185, 21);
            this.cmb_ASM.TabIndex = 6;
            // 
            // cmb_province
            // 
            this.cmb_province.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_province.FormattingEnabled = true;
            this.cmb_province.Items.AddRange(new object[] {
            "Central",
            "Eastern",
            "North Central",
            "Northern",
            "North Western",
            "Sabaragamuwa",
            "Southern",
            "Uva",
            "Western"});
            this.cmb_province.Location = new System.Drawing.Point(183, 109);
            this.cmb_province.Name = "cmb_province";
            this.cmb_province.Size = new System.Drawing.Size(185, 21);
            this.cmb_province.TabIndex = 7;
            // 
            // cmb_productCategory
            // 
            this.cmb_productCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_productCategory.FormattingEnabled = true;
            this.cmb_productCategory.Location = new System.Drawing.Point(183, 149);
            this.cmb_productCategory.Name = "cmb_productCategory";
            this.cmb_productCategory.Size = new System.Drawing.Size(185, 21);
            this.cmb_productCategory.TabIndex = 8;
            // 
            // cmb_salesMethod
            // 
            this.cmb_salesMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_salesMethod.FormattingEnabled = true;
            this.cmb_salesMethod.Location = new System.Drawing.Point(183, 191);
            this.cmb_salesMethod.Name = "cmb_salesMethod";
            this.cmb_salesMethod.Size = new System.Drawing.Size(185, 21);
            this.cmb_salesMethod.TabIndex = 9;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(183, 237);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(86, 23);
            this.btn_save.TabIndex = 10;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(282, 237);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(86, 23);
            this.btn_cancel.TabIndex = 11;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // frmNewRegion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 286);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.cmb_salesMethod);
            this.Controls.Add(this.cmb_productCategory);
            this.Controls.Add(this.cmb_province);
            this.Controls.Add(this.cmb_ASM);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "frmNewRegion";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Region";
            this.Load += new System.EventHandler(this.frmNewRegion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.ComboBox cmb_ASM;
        private System.Windows.Forms.ComboBox cmb_province;
        private System.Windows.Forms.ComboBox cmb_productCategory;
        private System.Windows.Forms.ComboBox cmb_salesMethod;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_cancel;
    }
}