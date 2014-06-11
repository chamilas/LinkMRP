namespace MRP_GUI.Sales
{
    partial class NewCustomer
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmb_discountType = new System.Windows.Forms.ComboBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.txt_creditsLimites = new System.Windows.Forms.TextBox();
            this.txt_discountApply = new System.Windows.Forms.TextBox();
            this.cmb_territory = new System.Windows.Forms.ComboBox();
            this.cmb_area = new System.Windows.Forms.ComboBox();
            this.cmb_category = new System.Windows.Forms.ComboBox();
            this.cmb_customerType = new System.Windows.Forms.ComboBox();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.txt_otherNames = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.cmb_discountType);
            this.panel1.Controls.Add(this.btn_clear);
            this.panel1.Controls.Add(this.btn_save);
            this.panel1.Controls.Add(this.txt_creditsLimites);
            this.panel1.Controls.Add(this.txt_discountApply);
            this.panel1.Controls.Add(this.cmb_territory);
            this.panel1.Controls.Add(this.cmb_area);
            this.panel1.Controls.Add(this.cmb_category);
            this.panel1.Controls.Add(this.cmb_customerType);
            this.panel1.Controls.Add(this.txt_address);
            this.panel1.Controls.Add(this.txt_otherNames);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_name);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(37, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(924, 446);
            this.panel1.TabIndex = 21;
            // 
            // cmb_discountType
            // 
            this.cmb_discountType.FormattingEnabled = true;
            this.cmb_discountType.Items.AddRange(new object[] {
            "Precentage",
            "Amount"});
            this.cmb_discountType.Location = new System.Drawing.Point(356, 284);
            this.cmb_discountType.Name = "cmb_discountType";
            this.cmb_discountType.Size = new System.Drawing.Size(121, 21);
            this.cmb_discountType.TabIndex = 41;
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(728, 346);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(141, 43);
            this.btn_clear.TabIndex = 40;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(573, 346);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(141, 43);
            this.btn_save.TabIndex = 39;
            this.btn_save.Text = "Create Customer";
            this.btn_save.UseVisualStyleBackColor = true;
            // 
            // txt_creditsLimites
            // 
            this.txt_creditsLimites.Location = new System.Drawing.Point(197, 369);
            this.txt_creditsLimites.Name = "txt_creditsLimites";
            this.txt_creditsLimites.Size = new System.Drawing.Size(280, 20);
            this.txt_creditsLimites.TabIndex = 38;
            // 
            // txt_discountApply
            // 
            this.txt_discountApply.Location = new System.Drawing.Point(197, 285);
            this.txt_discountApply.Name = "txt_discountApply";
            this.txt_discountApply.Size = new System.Drawing.Size(150, 20);
            this.txt_discountApply.TabIndex = 37;
            // 
            // cmb_territory
            // 
            this.cmb_territory.FormattingEnabled = true;
            this.cmb_territory.Location = new System.Drawing.Point(745, 284);
            this.cmb_territory.Name = "cmb_territory";
            this.cmb_territory.Size = new System.Drawing.Size(121, 21);
            this.cmb_territory.TabIndex = 36;
            // 
            // cmb_area
            // 
            this.cmb_area.FormattingEnabled = true;
            this.cmb_area.Location = new System.Drawing.Point(745, 212);
            this.cmb_area.Name = "cmb_area";
            this.cmb_area.Size = new System.Drawing.Size(121, 21);
            this.cmb_area.TabIndex = 35;
            // 
            // cmb_category
            // 
            this.cmb_category.FormattingEnabled = true;
            this.cmb_category.Items.AddRange(new object[] {
            "Hotels",
            "Agent",
            "Pharmacy",
            "Doctor",
            "Normal"});
            this.cmb_category.Location = new System.Drawing.Point(745, 140);
            this.cmb_category.Name = "cmb_category";
            this.cmb_category.Size = new System.Drawing.Size(121, 21);
            this.cmb_category.TabIndex = 34;
            // 
            // cmb_customerType
            // 
            this.cmb_customerType.FormattingEnabled = true;
            this.cmb_customerType.Items.AddRange(new object[] {
            "Local",
            "Foreign"});
            this.cmb_customerType.Location = new System.Drawing.Point(745, 71);
            this.cmb_customerType.Name = "cmb_customerType";
            this.cmb_customerType.Size = new System.Drawing.Size(121, 21);
            this.cmb_customerType.TabIndex = 33;
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(197, 213);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(280, 20);
            this.txt_address.TabIndex = 32;
            // 
            // txt_otherNames
            // 
            this.txt_otherNames.Location = new System.Drawing.Point(197, 141);
            this.txt_otherNames.Name = "txt_otherNames";
            this.txt_otherNames.Size = new System.Drawing.Size(280, 20);
            this.txt_otherNames.TabIndex = 31;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(53, 376);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 30;
            this.label9.Text = "Credits Limits";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(53, 292);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "Discount_Apply";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(587, 292);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Territory";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(587, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Area";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(587, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Category";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(587, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Customer Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Other Names";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(197, 72);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(280, 20);
            this.txt_name.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Name";
            // 
            // NewCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 657);
            this.Controls.Add(this.panel1);
            this.Name = "NewCustomer";
            this.Text = "New Customer";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmb_discountType;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox txt_creditsLimites;
        private System.Windows.Forms.TextBox txt_discountApply;
        private System.Windows.Forms.ComboBox cmb_territory;
        private System.Windows.Forms.ComboBox cmb_area;
        private System.Windows.Forms.ComboBox cmb_category;
        private System.Windows.Forms.ComboBox cmb_customerType;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.TextBox txt_otherNames;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label1;

    }
}