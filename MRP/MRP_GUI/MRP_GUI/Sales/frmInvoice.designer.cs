namespace MRP_GUI.Report
{
    partial class frmInvoice
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource6 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource7 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.rptViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rptViewer
            // 
            this.rptViewer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "PRPDBatchMachineCost";
            reportDataSource1.Value = null;
            reportDataSource2.Name = "PRPDBatchMaterialCost";
            reportDataSource2.Value = null;
            reportDataSource3.Name = "PRPDBatchOHCost";
            reportDataSource3.Value = null;
            reportDataSource4.Name = "PRPDBatchCostSummary";
            reportDataSource4.Value = null;
            reportDataSource5.Name = "PRPDBatchLabourCost";
            reportDataSource5.Value = null;
            reportDataSource6.Name = "PRPDBatchPrevious";
            reportDataSource6.Value = null;
            reportDataSource7.Name = "DataSet1";
            reportDataSource7.Value = null;
            this.rptViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.rptViewer.LocalReport.DataSources.Add(reportDataSource2);
            this.rptViewer.LocalReport.DataSources.Add(reportDataSource3);
            this.rptViewer.LocalReport.DataSources.Add(reportDataSource4);
            this.rptViewer.LocalReport.DataSources.Add(reportDataSource5);
            this.rptViewer.LocalReport.DataSources.Add(reportDataSource6);
            this.rptViewer.LocalReport.DataSources.Add(reportDataSource7);
            this.rptViewer.LocalReport.ReportEmbeddedResource = "MRP_GUI.Report.rptInvoice.rdlc";
            this.rptViewer.Location = new System.Drawing.Point(12, 12);
            this.rptViewer.Name = "rptViewer";
            this.rptViewer.Size = new System.Drawing.Size(760, 537);
            this.rptViewer.TabIndex = 0;
            this.rptViewer.Print += new Microsoft.Reporting.WinForms.ReportPrintEventHandler(this.rptViewer_Print);
            this.rptViewer.PrintingBegin += new Microsoft.Reporting.WinForms.ReportPrintEventHandler(this.rptViewer_PrintingBegin);
            // 
            // frmInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.rptViewer);
            this.Name = "frmInvoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Invoice";
            this.Load += new System.EventHandler(this.frmInvoice_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptViewer;
    }
}