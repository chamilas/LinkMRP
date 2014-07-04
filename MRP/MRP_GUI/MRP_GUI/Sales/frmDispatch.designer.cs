namespace MRP_GUI.Report
{
    partial class frmDispatch
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
            this.dsReports = new MRP_GUI.Report.dsReports();
            ((System.ComponentModel.ISupportInitialize)(this.dsReports)).BeginInit();
            this.SuspendLayout();
            // 
            // rptViewer
            // 
            this.rptViewer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rptViewer.LocalReport.ReportEmbeddedResource = "MRP_GUI.Report.rptDispatch.rdlc";
            this.rptViewer.Location = new System.Drawing.Point(12, 12);
            this.rptViewer.Name = "rptViewer";
            this.rptViewer.Size = new System.Drawing.Size(760, 537);
            this.rptViewer.TabIndex = 0;
            this.rptViewer.PrintingBegin += new Microsoft.Reporting.WinForms.ReportPrintEventHandler(this.rptViewer_PrintingBegin);
            // 
            // dsReports
            // 
            this.dsReports.DataSetName = "dsReports";
            this.dsReports.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frmDispatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.rptViewer);
            this.Name = "frmDispatch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dispatch";
            this.Load += new System.EventHandler(this.frmDispatch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsReports)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptViewer;
        private dsReports dsReports;
    }
}