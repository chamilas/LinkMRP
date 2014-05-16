namespace MRP_GUI.Report
{
    partial class frmGRNBulkPrint
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.GRNBulkPrintBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsReports = new MRP_GUI.Report.dsReports();
            this.rptViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnPrint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GRNBulkPrintBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReports)).BeginInit();
            this.SuspendLayout();
            // 
            // GRNBulkPrintBindingSource
            // 
            this.GRNBulkPrintBindingSource.DataMember = "GRNBulkPrint";
            this.GRNBulkPrintBindingSource.DataSource = this.dsReports;
            // 
            // dsReports
            // 
            this.dsReports.DataSetName = "dsReports";
            this.dsReports.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rptViewer
            // 
            this.rptViewer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.GRNBulkPrintBindingSource;
            this.rptViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.rptViewer.LocalReport.ReportEmbeddedResource = "MRP_GUI.Report.rptGRNBulkPrint.rdlc";
            this.rptViewer.Location = new System.Drawing.Point(12, 52);
            this.rptViewer.Name = "rptViewer";
            this.rptViewer.ShowExportButton = false;
            this.rptViewer.ShowPrintButton = false;
            this.rptViewer.ShowRefreshButton = false;
            this.rptViewer.ShowStopButton = false;
            this.rptViewer.Size = new System.Drawing.Size(609, 298);
            this.rptViewer.TabIndex = 0;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(12, 12);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 1;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // frmGRNBulkPrint
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(621, 350);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.rptViewer);
            this.Name = "frmGRNBulkPrint";
            this.Text = "GRN Bulk Print";
            this.Load += new System.EventHandler(this.frmGRNBulkPrint_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GRNBulkPrintBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReports)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptViewer;
        private System.Windows.Forms.BindingSource GRNBulkPrintBindingSource;
        private dsReports dsReports;
        private System.Windows.Forms.Button btnPrint;
    }
}