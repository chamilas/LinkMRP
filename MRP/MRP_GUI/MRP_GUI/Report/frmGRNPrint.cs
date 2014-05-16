using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DL;
using Microsoft.Reporting.WinForms;
using SESD.MRP.REF;

namespace MRP_GUI
{
    public partial class frmGRNPrint : System.Windows.Forms.Form
    {
        public frmGRNPrint(User objUser, long _GRNNO)
        {
            InitializeComponent();
            GRNNO = _GRNNO;
            CurrentUser = objUser;
        }

        DataTable dt = new DataTable();
        GRN_DL objGRN_DL = new GRN_DL(ConnectionStringClass.GetConnection());
        long GRNNO;
        User CurrentUser = new User();


        private void frmMRPrint_Load(object sender, EventArgs e)
        {
            LoadReport();
            this.rptViewer.RefreshReport();
        }


        private void LoadReport()
        {
            try
            {
                rptViewer.ProcessingMode = ProcessingMode.Local;

                dt = objGRN_DL.GetDataView_Items_Print(GRNNO);

                ReportDataSource source1 = new ReportDataSource();
                source1.Name = "DataSet1";
                source1.Value = dt;


                #region Report Parameters
                ReportParameter p1 = new ReportParameter("UserID", CurrentUser.EmployeeID);
                rptViewer.LocalReport.SetParameters(p1);
                #endregion


                rptViewer.LocalReport.DataSources.Clear();
                rptViewer.LocalReport.DataSources.Add(source1);

                rptViewer.LocalReport.Refresh();
                rptViewer.RefreshReport();
            }
            catch (Exception ee)
            {
                MessageBox.Show(this, ee.Message.ToString(), "Error Loading the Report", MessageBoxButtons.OK);

            }


        }

        private void btnPrintMR_Click(object sender, EventArgs e)
        {
            try
            {

                rptViewer.PrintDialog();

                LoadReport();

            }
            catch (Exception ee)
            {
                MessageBox.Show(this, ee.Message.ToString(), "Error Loading the Report", MessageBoxButtons.OK);

            }
        }


    }
}
