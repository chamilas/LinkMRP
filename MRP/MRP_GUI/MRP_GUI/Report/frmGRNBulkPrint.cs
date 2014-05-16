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

namespace MRP_GUI.Report
{
    public partial class frmGRNBulkPrint : System.Windows.Forms.Form
    {
        public frmGRNBulkPrint(User objUser,string _StoreID,int _GRNType)
        {
            InitializeComponent();
            StoreID = _StoreID;
            GRNType = _GRNType;
            CurrentUser = objUser;
        }

        DataTable dt = new DataTable();
        GRN_DL objGRN_DL = new GRN_DL(ConnectionStringClass.GetConnection());

        User CurrentUser = new User();
        string StoreID = "";
        int GRNType = 0;


        private void frmGRNBulkPrint_Load(object sender, EventArgs e)
        {

            LoadReport();
            this.rptViewer.RefreshReport();
        }


        private void LoadReport()
        {
            try
            {
                rptViewer.ProcessingMode = ProcessingMode.Local;

                dt = objGRN_DL.GetGRNBulkPrint(StoreID, GRNType);

                ReportDataSource source1 = new ReportDataSource();
                source1.Name = "DataSet1";
                source1.Value = dt;

                

                #region Report Parameters
                ReportParameter p1 = new ReportParameter("PrintedBy", CurrentUser.EmployeeID);
                rptViewer.LocalReport.SetParameters(p1);

                ReportParameter p2 = new ReportParameter("StoreID", StoreID);
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

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {

            rptViewer.PrintDialog();

                for(int i=0;i<dt.Rows.Count;i++)
                {
                    objGRN_DL.Update_BulkPrinted(Convert.ToInt32(dt.Rows[i]["GRNNO"]));
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
