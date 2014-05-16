using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SESD.MRP.REF;
using  DL;
using System.Collections;
using Microsoft.Reporting.WinForms;
using MRP_GUI.Report;
namespace MRP_GUI
{
    public partial class frmRptPRPDBatchCost : System.Windows.Forms.Form
    {
        PRPDBatch_DL objPRPDBatch_DL = new PRPDBatch_DL(ConnectionStringClass.GetConnection());

        DataTable dtPRPDBatchCost = new DataTable();
        DataTable dtPRPDBatchLabourCost = new DataTable();
        DataTable dtPRPDBatchMachineCost = new DataTable();
        DataTable dtPRPDBatchMaterialCost = new DataTable();
        DataTable dtPRPDBatchOHCost = new DataTable();
        DataTable dtPRPDBatchPrevious = new DataTable();

        string PRPDBatchID = "";

         private User _CurrentUser;

        public User CurrentUser
        {
            get { return _CurrentUser; }
            set { _CurrentUser = value; }
        }

        public frmRptPRPDBatchCost(User objUser, string _RPDBatchID)
        {
            PRPDBatchID = _RPDBatchID;
            CurrentUser = objUser;
            InitializeComponent();
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            try
            {

                DialogResult dr = MessageBox.Show(this, "Are you sure you want Approve the selected Cost File?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {

                    int res1 = objPRPDBatch_DL.Finish(PRPDBatchID, PRPDBatch.PRPDBatchStatus.Finished);

                    if (res1 > 0)
                    {
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(this, "Error Occured while approving the Cost File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void LoadReport()

        {

            try
            {

                reportViewer1.ProcessingMode = ProcessingMode.Local;

                dtPRPDBatchCost = objPRPDBatch_DL.GetPRPDBatchCost(PRPDBatchID);

                dtPRPDBatchLabourCost = objPRPDBatch_DL.GetPRPDBatchLabourCost(PRPDBatchID);

                dtPRPDBatchMachineCost = objPRPDBatch_DL.GetPRPDBatchMachineCost(PRPDBatchID);

                dtPRPDBatchOHCost = objPRPDBatch_DL.GetPRPDBatchOHCost(PRPDBatchID);

                dtPRPDBatchMaterialCost = objPRPDBatch_DL.GetPRPDBatchMaterialCost(PRPDBatchID);

                dtPRPDBatchPrevious = objPRPDBatch_DL.GetPrevious(PRPDBatchID);

                ReportDataSource source1 = new ReportDataSource();
                source1.Name = "PRPDBatchCostSummary";
                source1.Value = dtPRPDBatchCost;

                ReportDataSource source2 = new ReportDataSource();
                source2.Name = "PRPDBatchLabourCost";
                source2.Value = dtPRPDBatchLabourCost;

                ReportDataSource source3 = new ReportDataSource();
                source3.Name = "PRPDBatchMachineCost";
                source3.Value = dtPRPDBatchMachineCost;

                ReportDataSource source4 = new ReportDataSource();
                source4.Name = "PRPDBatchOHCost";
                source4.Value = dtPRPDBatchOHCost;

                ReportDataSource source5 = new ReportDataSource();
                source5.Name = "PRPDBatchMaterialCost";
                source5.Value = dtPRPDBatchMaterialCost;


                ReportDataSource source6 = new ReportDataSource();
                source6.Name = "PRPDBatchPrevious";
                source6.Value = dtPRPDBatchPrevious;

/*
                #region Report Parameters
                ReportParameter p1 = new ReportParameter("UserID", CurrentUser.EmployeeID);
                rptViewer.LocalReport.SetParameters(p1);
                ReportParameter p2 = new ReportParameter("RPDBatchID", PRPDBatchID);
                rptViewer.LocalReport.SetParameters(p2);
                #endregion
*/

                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(source1);
                reportViewer1.LocalReport.DataSources.Add(source2);
                reportViewer1.LocalReport.DataSources.Add(source3);
                reportViewer1.LocalReport.DataSources.Add(source4);
                reportViewer1.LocalReport.DataSources.Add(source5);
                reportViewer1.LocalReport.DataSources.Add(source6);


                reportViewer1.LocalReport.Refresh();
                reportViewer1.RefreshReport();
            }
            catch (Exception ee)
            {
                MessageBox.Show(this, ee.Message.ToString(), "Error Loading the Report", MessageBoxButtons.OK);

            }

        
        
        
        
        }
        private void frmRptPRPDBatchCost_Load(object sender, EventArgs e)
        {
            LoadReport();
            this.reportViewer1.RefreshReport();
        }


    }
}