namespace MRP_GUI.Sales
{
    partial class frmAssignDialog
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
            this.txt_quantity = new System.Windows.Forms.TextBox();
            this.txt_batch = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.cmb_quantity = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quantity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Batch";
            // 
            // txt_quantity
            // 
            this.txt_quantity.Location = new System.Drawing.Point(121, 23);
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.ReadOnly = true;
            this.txt_quantity.Size = new System.Drawing.Size(142, 20);
            this.txt_quantity.TabIndex = 2;
            // 
            // txt_batch
            // 
            this.txt_batch.Location = new System.Drawing.Point(121, 55);
            this.txt_batch.Name = "txt_batch";
            this.txt_batch.Size = new System.Drawing.Size(142, 20);
            this.txt_batch.TabIndex = 3;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(62, 97);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 4;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(152, 97);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 5;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // cmb_quantity
            // 
            this.cmb_quantity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_quantity.FormattingEnabled = true;
            this.cmb_quantity.Location = new System.Drawing.Point(121, 23);
            this.cmb_quantity.Name = "cmb_quantity";
            this.cmb_quantity.Size = new System.Drawing.Size(142, 21);
            this.cmb_quantity.TabIndex = 6;
            this.cmb_quantity.SelectedIndexChanged += new System.EventHandler(this.cmb_quantity_SelectedIndexChanged);
            // 
            // frmAssignDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 132);
            this.Controls.Add(this.cmb_quantity);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txt_batch);
            this.Controls.Add(this.txt_quantity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAssignDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Assign Quantity";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_quantity;
        private System.Windows.Forms.TextBox txt_batch;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.ComboBox cmb_quantity;
    }
}