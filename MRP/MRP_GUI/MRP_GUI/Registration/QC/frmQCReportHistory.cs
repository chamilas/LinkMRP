using DL;
using SESD.MRP.REF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MRP_GUI
{
    public partial class frmQCReportHistory : System.Windows.Forms.Form
    {
        private QCReport_DL objQCReport_DL = new QCReport_DL(ConnectionStringClass.GetConnection());
        private String CueeQCReportType;


        public frmQCReportHistory(String reportType)
        {
            CueeQCReportType = reportType;
            InitializeComponent();
        }

        private void Load_QCreports() 
        {
            bsAcceptedReports.DataSource = objQCReport_DL.GetView(CueeQCReportType, Convert.ToInt32(QCReport.ReportStatus.Accept));

            dgvAcceptedReports.AutoGenerateColumns = false;
            //bsAcceptedReports.DataSource = dt;
            dgvAcceptedReports.DataSource = bsAcceptedReports;
            bsAcceptedReports.ResetBindings(true);

            bsRejectedReports.DataSource = objQCReport_DL.GetView(CueeQCReportType, Convert.ToInt32(QCReport.ReportStatus.Reject));

            dgvRejectedReports.AutoGenerateColumns = false;
            //bsAcceptedReports.DataSource = dt;
            dgvRejectedReports.DataSource = bsRejectedReports;
            bsRejectedReports.ResetBindings(true);

        }

        private void frmQCReportHistory_Load(object sender, EventArgs e)
        {
            Load_QCreports();
        }


    }
}
