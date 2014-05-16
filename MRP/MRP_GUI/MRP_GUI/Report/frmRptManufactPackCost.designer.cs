namespace MRP_GUI.Report
{
    partial class frmRptManufactPackCost
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dsReports = new MRP_GUI.Report.dsReports();
            this.ManufactPackCostSummaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ManufactPackMaterialCostBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ManufactPackLaborCostBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dsReports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ManufactPackCostSummaryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ManufactPackMaterialCostBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ManufactPackLaborCostBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "MRP_GUI.Report.RptManufactPackCost.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(809, 506);
            this.reportViewer1.TabIndex = 0;
            // 
            // dsReports
            // 
            this.dsReports.DataSetName = "dsReports";
            this.dsReports.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ManufactPackCostSummaryBindingSource
            // 
            this.ManufactPackCostSummaryBindingSource.DataMember = "ManufactPackCostSummary";
            this.ManufactPackCostSummaryBindingSource.DataSource = this.dsReports;
            // 
            // ManufactPackMaterialCostBindingSource
            // 
            this.ManufactPackMaterialCostBindingSource.DataMember = "ManufactPackMaterialCost";
            this.ManufactPackMaterialCostBindingSource.DataSource = this.dsReports;
            // 
            // ManufactPackLaborCostBindingSource
            // 
            this.ManufactPackLaborCostBindingSource.DataMember = "ManufactPackLaborCost";
            this.ManufactPackLaborCostBindingSource.DataSource = this.dsReports;
            // 
            // frmRptManufactPackCost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 506);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmRptManufactPackCost";
            this.Text = "frmRptManufactPackCost";
            this.Load += new System.EventHandler(this.frmRptManufactPackCost_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsReports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ManufactPackCostSummaryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ManufactPackMaterialCostBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ManufactPackLaborCostBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private dsReports dsReports;
        private System.Windows.Forms.BindingSource ManufactPackCostSummaryBindingSource;
        private System.Windows.Forms.BindingSource ManufactPackMaterialCostBindingSource;
        private System.Windows.Forms.BindingSource ManufactPackLaborCostBindingSource;
    }
}