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
    public partial class frmMRPrint : System.Windows.Forms.Form
    {
        public frmMRPrint(User objUser, long _MRNO)
        {
            InitializeComponent();
            MRNO = _MRNO;
            CurrentUser = objUser;
        }

        DataTable dt = new DataTable();
        MRMaterial_DL objMRMaterial_DL = new MRMaterial_DL(ConnectionStringClass.GetConnection());
        MR_DL objMR_DL = new MR_DL(ConnectionStringClass.GetConnection());
        long MRNO;
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

                    dt = objMR_DL.GetItems(MRNO);

                ReportDataSource source1 = new ReportDataSource();
                source1.Name = "dsReports";
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
                objMR_DL.Update_Print(MRNO);

                rptViewer.PrintDialog();

                this.Close();

            }
            catch (Exception ee)
            {
                MessageBox.Show(this, ee.Message.ToString(), "Error Loading the Report", MessageBoxButtons.OK);

            }
        }


    }
}
