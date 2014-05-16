using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DL;
using SESD.MRP.REF;
using System.Collections;
using Microsoft.Reporting.WinForms;
using MRP_GUI.Report;

namespace MRP_GUI
{
    public partial class frmRptRPDBatchCost : System.Windows.Forms.Form
    {

        RPDBatch_DL objRPDBatch_DL = new RPDBatch_DL(ConnectionStringClass.GetConnection());

        DataTable dtRPDBatchCost = new DataTable();
        DataTable dtRPDBatchLabourCost = new DataTable();
        DataTable dtRPDBatchMachineCost = new DataTable();
        DataTable dtRPDBatchMaterialCost = new DataTable();
        DataTable dtRPDBatchOHCost = new DataTable();
        DataTable dtRPDBatchActualProduction = new DataTable();
        DataTable dtRPDBatchPrevious = new DataTable();

        string RPDBatchID="";


          private User _CurrentUser;

        public User CurrentUser
        {
            get { return _CurrentUser; }
            set { _CurrentUser = value; }
        }

        public frmRptRPDBatchCost(User objUser, string _RPDBatchID)
        {
            RPDBatchID = _RPDBatchID;
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

                        int res1 = objRPDBatch_DL.Finish(RPDBatchID,RPDBatch.RPDBatchStatus.Finished);

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
               
                rptViewer.ProcessingMode = ProcessingMode.Local;

                dtRPDBatchCost = objRPDBatch_DL.GetRPDBatchCost(RPDBatchID);

                dtRPDBatchLabourCost = objRPDBatch_DL.GetRPDBatchLabourCost(RPDBatchID);

                dtRPDBatchMachineCost = objRPDBatch_DL.GetRPDBatchMachineCost(RPDBatchID);

                dtRPDBatchOHCost = objRPDBatch_DL.GetRPDBatchOHCost(RPDBatchID);

                dtRPDBatchMaterialCost = objRPDBatch_DL.GetRPDBatchMaterialCost(RPDBatchID);

                dtRPDBatchActualProduction = objRPDBatch_DL.GetRPDBatchActualProdution(RPDBatchID);

                dtRPDBatchPrevious = objRPDBatch_DL.GetPrevious(RPDBatchID);

                ReportDataSource source1 = new ReportDataSource();
                source1.Name = "dsRPDBatchCostSummary";
                source1.Value = dtRPDBatchCost;

                ReportDataSource source2 = new ReportDataSource();
                source2.Name = "dsRPDBatchLabourCost";
                source2.Value = dtRPDBatchLabourCost;

                ReportDataSource source3 = new ReportDataSource();
                source3.Name = "dsRPDBatchMachineCost";
                source3.Value = dtRPDBatchMachineCost;

                ReportDataSource source4 = new ReportDataSource();
                source4.Name = "dsRPDBatchOHCost";
                source4.Value = dtRPDBatchOHCost;

                ReportDataSource source5 = new ReportDataSource();
                source5.Name = "dsRPDBatchMaterialCost";
                source5.Value = dtRPDBatchMaterialCost;

                ReportDataSource source6 = new ReportDataSource();
                source6.Name = "dsRPDBatchActualProduction";
                source6.Value = dtRPDBatchActualProduction;

                ReportDataSource source7 = new ReportDataSource();
                source7.Name = "dsRPDBatchPrevious";
                source7.Value = dtRPDBatchPrevious;

                #region Report Parameters
                ReportParameter p1 = new ReportParameter("UserID", CurrentUser.EmployeeID);
                rptViewer.LocalReport.SetParameters(p1);
                ReportParameter p2 = new ReportParameter("RPDBatchID", RPDBatchID);
                rptViewer.LocalReport.SetParameters(p2);
                #endregion


                rptViewer.LocalReport.DataSources.Clear();
                rptViewer.LocalReport.DataSources.Add(source1);
                rptViewer.LocalReport.DataSources.Add(source2);
                rptViewer.LocalReport.DataSources.Add(source3);
                rptViewer.LocalReport.DataSources.Add(source4);
                rptViewer.LocalReport.DataSources.Add(source5);
                rptViewer.LocalReport.DataSources.Add(source6);
                rptViewer.LocalReport.DataSources.Add(source7);

                rptViewer.LocalReport.Refresh();
                rptViewer.RefreshReport();
            }
            catch (Exception ee)
            {
                MessageBox.Show(this, ee.Message.ToString(), "Error Loading the Report", MessageBoxButtons.OK);

            }


        }

        private void frmRptRPDBatchCost_Load(object sender, EventArgs e)
        {
            LoadReport();
            this.rptViewer.RefreshReport();
        }

    }
}