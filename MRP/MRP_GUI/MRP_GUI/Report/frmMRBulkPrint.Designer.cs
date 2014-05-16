namespace MRP_GUI
{
    partial class frmMRBulkPrint
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
            this.rptViewer.LocalReport.ReportEmbeddedResource = "MRP_GUI.Report.rptMRBulkPrint.rdlc";
            this.rptViewer.Location = new System.Drawing.Point(0, 38);
            this.rptViewer.Name = "rptViewer";
            this.rptViewer.ShowPrintButton = false;
            this.rptViewer.ShowRefreshButton = false;
            this.rptViewer.ShowStopButton = false;
            this.rptViewer.Size = new System.Drawing.Size(509, 302);
            this.rptViewer.TabIndex = 0;
            // 
            // btnPrintMR
            // 
            this.btnPrintMR.Location = new System.Drawing.Point(12, 9);
            this.btnPrintMR.Name = "btnPrintMR";
            this.btnPrintMR.Size = new System.Drawing.Size(75, 23);
            this.btnPrintMR.TabIndex = 1;
            this.btnPrintMR.Text = "Print MR";
            this.btnPrintMR.UseVisualStyleBackColor = true;
            this.btnPrintMR.Click += new System.EventHandler(this.btnPrintMR_Click);
            // 
            // frmMRBulkPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 340);
            this.Controls.Add(this.btnPrintMR);
            this.Controls.Add(this.rptViewer);
            this.Name = "frmMRBulkPrint";
            this.Text = "frmPrint";
            this.Load += new System.EventHandler(this.frmPrint_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptViewer;
        private System.Windows.Forms.Button btnPrintMR;
    }
}