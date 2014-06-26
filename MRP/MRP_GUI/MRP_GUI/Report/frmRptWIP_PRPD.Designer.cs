namespace MRP_GUI.Report
{
    partial class frmRptWIP_PRPD
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dsReports = new MRP_GUI.Report.dsReports();
            this.BatchPackingMR_WIPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dsReports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BatchPackingMR_WIPBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.BatchPackingMR_WIPBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "MRP_GUI.Report.rptWIP_PRPD.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(810, 455);
            this.reportViewer1.TabIndex = 0;
            // 
            // dsReports
            // 
            this.dsReports.DataSetName = "dsReports";
            this.dsReports.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BatchPackingMR_WIPBindingSource
            // 
            this.BatchPackingMR_WIPBindingSource.DataMember = "BatchPackingMR_WIP";
            this.BatchPackingMR_WIPBindingSource.DataSource = this.dsReports;
            // 
            // frmRptWIP_PRPD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 455);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmRptWIP_PRPD";
            this.Text = "frmRptWIP_PRPD";
            this.Load += new System.EventHandler(this.frmRptWIP_PRPD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsReports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BatchPackingMR_WIPBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource BatchPackingMR_WIPBindingSource;
        private dsReports dsReports;
    }
}