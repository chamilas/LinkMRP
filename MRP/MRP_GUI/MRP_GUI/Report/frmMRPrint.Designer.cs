namespace MRP_GUI
{
    partial class frmMRPrint
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
            this.rptViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnPrintMR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rptViewer
            // 
            this.rptViewer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rptViewer.LocalReport.ReportEmbeddedResource = "MRP_GUI.Report.rptMRPrint.rdlc";
            this.rptViewer.Location = new System.Drawing.Point(0, 45);
            this.rptViewer.Name = "rptViewer";
            this.rptViewer.Size = new System.Drawing.Size(569, 334);
            this.rptViewer.TabIndex = 0;
            // 
            // btnPrintMR
            // 
            this.btnPrintMR.Location = new System.Drawing.Point(12, 12);
            this.btnPrintMR.Name = "btnPrintMR";
            this.btnPrintMR.Size = new System.Drawing.Size(75, 23);
            this.btnPrintMR.TabIndex = 1;
            this.btnPrintMR.Text = "Print MR";
            this.btnPrintMR.UseVisualStyleBackColor = true;
            this.btnPrintMR.Click += new System.EventHandler(this.btnPrintMR_Click);
            // 
            // frmMRPrint
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(569, 379);
            this.Controls.Add(this.btnPrintMR);
            this.Controls.Add(this.rptViewer);
            this.Name = "frmMRPrint";
            this.Text = "MR - Print";
            this.Load += new System.EventHandler(this.frmMRPrint_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptViewer;
        private System.Windows.Forms.Button btnPrintMR;
    }
}