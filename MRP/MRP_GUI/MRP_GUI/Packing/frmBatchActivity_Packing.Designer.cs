namespace MRP_GUI
{
    partial class frmBatchActivity_Packing
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
            this.txtActivity = new System.Windows.Forms.TextBox();
            this.txtFinalQty = new System.Windows.Forms.TextBox();
            this.lblUnit = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFinishedProduct = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Activity Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Packed Quantity";
            // 
            // txtActivity
            // 
            this.txtActivity.Location = new System.Drawing.Point(155, 18);
            this.txtActivity.Name = "txtActivity";
            this.txtActivity.ReadOnly = true;
            this.txtActivity.Size = new System.Drawing.Size(235, 26);
            this.txtActivity.TabIndex = 1;
            // 
            // txtFinalQty
            // 
            this.txtFinalQty.Location = new System.Drawing.Point(155, 102);
            this.txtFinalQty.Name = "txtFinalQty";
            this.txtFinalQty.Size = new System.Drawing.Size(100, 26);
            this.txtFinalQty.TabIndex = 0;
            this.txtFinalQty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFinalQty_KeyDown);
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Location = new System.Drawing.Point(261, 108);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(27, 20);
            this.lblUnit.TabIndex = 0;
            this.lblUnit.Text = "<>";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Finished Product";
            // 
            // txtFinishedProduct
            // 
            this.txtFinishedProduct.Location = new System.Drawing.Point(155, 59);
            this.txtFinishedProduct.Name = "txtFinishedProduct";
            this.txtFinishedProduct.ReadOnly = true;
            this.txtFinishedProduct.Size = new System.Drawing.Size(235, 26);
            this.txtFinishedProduct.TabIndex = 2;
            // 
            // frmBatchActivity_Packing
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(402, 141);
            this.Controls.Add(this.txtFinishedProduct);
            this.Controls.Add(this.txtFinalQty);
            this.Controls.Add(this.txtActivity);
            this.Controls.Add(this.lblUnit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmBatchActivity_Packing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Batch Activity - Packing";
            this.Load += new System.EventHandler(this.frmBatchActivity_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtActivity;
        private System.Windows.Forms.TextBox txtFinalQty;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFinishedProduct;
    }
}