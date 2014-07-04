namespace MRP_GUI.Sales
{
    partial class frmNewTerritory
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
            this.txt_territoryName = new System.Windows.Forms.TextBox();
            this.cmb_salesRep = new System.Windows.Forms.ComboBox();
            this.cmb_district = new System.Windows.Forms.ComboBox();
            this.cmb_region = new System.Windows.Forms.ComboBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Territory Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sales Rep";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "District";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Region";
            // 
            // txt_territoryName
            // 
            this.txt_territoryName.Location = new System.Drawing.Point(149, 26);
            this.txt_territoryName.Name = "txt_territoryName";
            this.txt_territoryName.Size = new System.Drawing.Size(158, 20);
            this.txt_territoryName.TabIndex = 4;
            // 
            // cmb_salesRep
            // 
            this.cmb_salesRep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_salesRep.FormattingEnabled = true;
            this.cmb_salesRep.Location = new System.Drawing.Point(149, 60);
            this.cmb_salesRep.Name = "cmb_salesRep";
            this.cmb_salesRep.Size = new System.Drawing.Size(158, 21);
            this.cmb_salesRep.TabIndex = 5;
            // 
            // cmb_district
            // 
            this.cmb_district.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_district.FormattingEnabled = true;
            this.cmb_district.Items.AddRange(new object[] {
            "Ampara",
            "Anuradhapura",
            "Badulla",
            "Batticaloa",
            "Colombo",
            "Galle",
            "Gampaha",
            "Hambantota",
            "Jaffna",
            "Kalutara",
            "Kandy",
            "Kegalla",
            "Kilinochchi",
            "Kurunegala",
            "Mannar",
            "Matale",
            "Matara",
            "Moneragala",
            "Mullaitivu",
            "Nuwara Eliya",
            "Polonnaruwa",
            "Puttalam",
            "Ratnapura",
            "Trincomalee",
            "Vavuniya"});
            this.cmb_district.Location = new System.Drawing.Point(149, 130);
            this.cmb_district.Name = "cmb_district";
            this.cmb_district.Size = new System.Drawing.Size(158, 21);
            this.cmb_district.TabIndex = 6;
            // 
            // cmb_region
            // 
            this.cmb_region.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_region.FormattingEnabled = true;
            this.cmb_region.Location = new System.Drawing.Point(149, 95);
            this.cmb_region.Name = "cmb_region";
            this.cmb_region.Size = new System.Drawing.Size(158, 21);
            this.cmb_region.TabIndex = 7;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(149, 170);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 8;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(232, 170);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 9;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // frmNewTerritory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 214);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.cmb_region);
            this.Controls.Add(this.cmb_district);
            this.Controls.Add(this.cmb_salesRep);
            this.Controls.Add(this.txt_territoryName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "frmNewTerritory";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Territory";
            this.Load += new System.EventHandler(this.frmNewTerritory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_territoryName;
        private System.Windows.Forms.ComboBox cmb_salesRep;
        private System.Windows.Forms.ComboBox cmb_district;
        private System.Windows.Forms.ComboBox cmb_region;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_cancel;
    }
}