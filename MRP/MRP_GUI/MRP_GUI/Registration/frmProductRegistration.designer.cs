namespace MRP_GUI
{
    partial class frmProductRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductRegistration));
            this.usProductInsert1 = new MRP_GUI.usProductInsert();
            this.SuspendLayout();
            // 
            // usProductInsert1
            // 
            this.usProductInsert1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.usProductInsert1.Location = new System.Drawing.Point(-5, 0);
            this.usProductInsert1.Name = "usProductInsert1";
            this.usProductInsert1.Size = new System.Drawing.Size(981, 603);
            this.usProductInsert1.TabIndex = 0;
            // 
            // frmProductRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 604);
            this.Controls.Add(this.usProductInsert1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmProductRegistration";
            this.Text = "Product Registration";
            this.Load += new System.EventHandler(this.frmProductRegistration_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private usProductInsert usProductInsert1;
    }
}