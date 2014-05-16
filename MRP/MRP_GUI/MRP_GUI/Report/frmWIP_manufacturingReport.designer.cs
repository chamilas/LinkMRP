namespace MRP_GUI.Report
{
    partial class frmWIP_manufacturingReport
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
            this.MRBulkPrintBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsReports = new MRP_GUI.Report.dsReports();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.MRBulkPrintBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReports)).BeginInit();
            this.SuspendLayout();
            // 
            // MRBulkPrintBindingSource
            // 
            this.MRBulkPrintBindingSource.DataMember = "MRBulkPrint";
            this.MRBulkPrintBindingSource.DataSource = this.dsReports;
            // 
            // dsReports
            // 
            this.dsReports.DataSetName = "dsReports";
            this.dsReports.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.MRBulkPrintBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "MRP_GUI.Report.rptWIP_manufacturingReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(664, 435);
            this.reportViewer1.TabIndex = 0;
            // 
            // frmWIP_manufacturingReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 435);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmWIP_manufacturingReport";
            this.Text = "frmWIP_manufacturingReport";
            this.Load += new System.EventHandler(this.frmWIP_manufacturingReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MRBulkPrintBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReports)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource MRBulkPrintBindingSource;
        private dsReports dsReports;
    }
}