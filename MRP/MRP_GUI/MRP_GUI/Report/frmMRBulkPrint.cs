using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using DL;
using Microsoft.Reporting.WinForms;
using SESD.MRP.REF;

namespace MRP_GUI
{
    public partial class frmMRBulkPrint : System.Windows.Forms.Form
    {
        public frmMRBulkPrint(User objUser, string _StoreID)
        {
            InitializeComponent();
            StoreID = _StoreID;
            CurrentUser = objUser;

        }

        DataTable dt = new DataTable();

        User CurrentUser = new User();
        MR_DL objMR_DL = new MR_DL(ConnectionStringClass.GetConnection());
        string StoreID = "";



        private void frmPrint_Load(object sender, EventArgs e)
        {
            LoadReport();
            this.rptViewer.RefreshReport();
        }

        private void LoadReport()
        {
            try
            {
                rptViewer.ProcessingMode = ProcessingMode.Local;

                //if (StoreID == "Packing")
                //{
                //    dt = objMR_DL.GetMR_BulkPrint_Material_Packing(StoreID,(int)MR.Origin.ToBatch,MR.Status.Issued,MR.Status.Recevied,MR.Status.ReceviedGRN,MR.Status.ReceviedSubStock);
                //}
                //else
                //{
                    dt = objMR_DL.GetMR_BulkPrint_Material(StoreID,MR.Status.Issued,MR.Status.Recevied,MR.Status.ReceviedGRN,MR.Status.ReceviedSubStock);
                //}

                ReportDataSource source1 = new ReportDataSource();
                source1.Name = "dsReports";
                source1.Value = dt;


                #region Report Parameters
                ReportParameter p1 = new ReportParameter("StoreID", StoreID);
                rptViewer.LocalReport.SetParameters(p1);

                ReportParameter p2 = new ReportParameter("UserID", CurrentUser.EmployeeID);
                rptViewer.LocalReport.SetParameters(p2);
                #endregion

                //  rptViewer.LocalReport.ReportEmbeddedResource = null;
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

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    objMR_DL.Update_BulkPrint(Convert.ToInt64(dt.Rows[i]["MRNO"]));
                }

                LoadReport();
            }
            catch (Exception ee)
            {
                MessageBox.Show(this, ee.Message.ToString(), "Error Loading the Report", MessageBoxButtons.OK);

            }

        }


    }
}
