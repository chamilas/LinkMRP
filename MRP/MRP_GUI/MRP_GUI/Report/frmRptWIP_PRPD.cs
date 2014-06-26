using DL;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MRP_GUI.Report
{
    public partial class frmRptWIP_PRPD : Form
    {
        PRPDBatch_DL objPRPDBatch_DL = new PRPDBatch_DL(ConnectionStringClass.GetConnection());
        DataTable datatable = new DataTable();
        DateTime WIPDate = DateTime.Now;

        public frmRptWIP_PRPD(DateTime _WIPDate)
        {
            WIPDate = _WIPDate;
            InitializeComponent();
            LoadReport();
        }

        private void frmRptWIP_PRPD_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void LoadReport()
        {
            try
            {

                reportViewer1.ProcessingMode = ProcessingMode.Local;
                datatable = objPRPDBatch_DL.GetWIP_PRPD(WIPDate);

                ReportDataSource source1 = new ReportDataSource();
                source1.Name = "DataSet1";
                source1.Value = datatable;

                // #region Report Parameters
                // ReportParameter p1 = new ReportParameter("SupervisorName", SupervisorName);
                // reportViewer1.LocalReport.SetParameters(p1);

                // ReportParameter p2 = new ReportParameter("SectionID", SectionName);
                // reportViewer1.LocalReport.SetParameters(p2);

                // #endregion

                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(source1);


                reportViewer1.LocalReport.Refresh();
                reportViewer1.RefreshReport();
            }
            catch (Exception ee)
            {
                MessageBox.Show(this, ee.Message.ToString(), "Error Loading the Report", MessageBoxButtons.OK);

            }
        }
    }
}
