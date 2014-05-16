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
    public partial class frmWIP_Packing_MaterialTablePrint : Form
    {
        BatchPackingMR_DL objBatchPackingMR_DL = new BatchPackingMR_DL(ConnectionStringClass.GetConnection());

        DataTable datatable = new DataTable();
        private int SectionID = 45;
        private String SupervisorName = "";
        private String SectionName = "";

        public frmWIP_Packing_MaterialTablePrint(int _sectionID, String _SupervisorName, String _SectionName)
        {
            SectionID = _sectionID;
            SupervisorName = _SupervisorName;
            SectionName = _SectionName;
            InitializeComponent();
            LoadReport();
        }

        private void frmWIP_Packing_MaterialTablePrint_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void LoadReport()
        {

            try
            {

                reportViewer1.ProcessingMode = ProcessingMode.Local;
                datatable = objBatchPackingMR_DL.GetData_WIP(SectionID);

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
