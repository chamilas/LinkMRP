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
    public partial class frmWIP_manufacturingReport : Form
    {
        Batch_DL objBatch_DL = new Batch_DL(ConnectionStringClass.GetConnection());
        DataTable datatable = new DataTable();
        private int BatchStatus_Packing;
        private int SectionID;
        private String SupervisorName;
        private String SectionName;

        public frmWIP_manufacturingReport(int _BatchStatus_Packing, int _SectionID,String _SectionName, String _SupervisorName)
        {

            BatchStatus_Packing = _BatchStatus_Packing;
            SectionID = _SectionID;
            SupervisorName = _SupervisorName;
            SectionName = _SectionName;
            InitializeComponent();
            LoadReport();
        }

        private void frmWIP_manufacturingReport_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void LoadReport()
        {

            try
            {

                reportViewer1.ProcessingMode = ProcessingMode.Local;
                datatable = objBatch_DL.GetWIP_Files(SectionID, BatchStatus_Packing);

                ReportDataSource source3 = new ReportDataSource();
                source3.Name = "DataSet1";
                source3.Value = datatable;

                #region Report Parameters
                ReportParameter p1 = new ReportParameter("SupervisorName", SupervisorName);
                reportViewer1.LocalReport.SetParameters(p1);

                ReportParameter p2 = new ReportParameter("SectionID", SectionName);
                reportViewer1.LocalReport.SetParameters(p2);
                
                #endregion

                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(source3);


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