namespace MRP_GUI
{
    partial class frmEmployeeRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployeeRegistration));
            this.ucEmployee1 = new MRP_GUI.ucEmployee();
            this.SuspendLayout();
            // 
            // ucEmployee1
            // 
            this.ucEmployee1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucEmployee1.Location = new System.Drawing.Point(0, -1);
            this.ucEmployee1.Name = "ucEmployee1";
            this.ucEmployee1.Size = new System.Drawing.Size(976, 599);
            this.ucEmployee1.TabIndex = 0;
            this.ucEmployee1.Load += new System.EventHandler(this.ucEmployee1_Load);
            // 
            // frmEmployeeRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 604);
            this.Controls.Add(this.ucEmployee1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEmployeeRegistration";
            this.Text = "Employee Registration";
            this.Load += new System.EventHandler(this.frmEmployeeRegistration_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ucEmployee ucEmployee1;
    }
}