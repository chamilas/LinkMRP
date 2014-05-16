namespace MRP_GUI
{
    partial class frmMachineRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMachineRegistration));
            this.ucMachine1 = new MRP_GUI.ucMachine();
            this.SuspendLayout();
            // 
            // ucMachine1
            // 
            this.ucMachine1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucMachine1.Location = new System.Drawing.Point(1, -1);
            this.ucMachine1.Name = "ucMachine1";
            this.ucMachine1.Size = new System.Drawing.Size(977, 606);
            this.ucMachine1.TabIndex = 0;
            this.ucMachine1.Load += new System.EventHandler(this.ucMachine1_Load);
            // 
            // frmMachineRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 604);
            this.Controls.Add(this.ucMachine1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMachineRegistration";
            this.Text = "Machine Registration";
            this.Load += new System.EventHandler(this.frmMachineRegistration_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ucMachine ucMachine1;
    }
}