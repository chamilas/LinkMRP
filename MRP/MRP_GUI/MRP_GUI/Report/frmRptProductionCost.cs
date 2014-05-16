using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SESD.MRP.REF;
using  DL;
using System.Collections;
using Microsoft.Reporting.WinForms;
using MRP_GUI.Report;


namespace MRP_GUI.Report
{
    public partial class frmRptProductionCost : System.Windows.Forms.Form
    {
        public frmRptProductionCost(string _batchID)
        {
            InitializeComponent();
            BatchID = _batchID;
        }

        string BatchID = "";
        Batch_DL objBatch_DL = new Batch_DL(ConnectionStringClass.GetConnection());

        DataTable dtManufactBatchCostSummary = new DataTable();
        DataTable dtManufactBatchMaterialCost = new DataTable();
        DataTable dtManufactPrevBatchCost = new DataTable();
        DataTable dtManufactBatchOHCost = new DataTable();
        DataTable dtManufactBatchMachineCost = new DataTable();
        DataTable dtManufactBatchLaborCost = new DataTable();


        private void frmRptProductionCost_Load(object sender, EventArgs e)
        {
            LoadReport();
            this.reportViewer1.RefreshReport();


        }

        private void LoadReport()
        {

            try
            {

                                reportViewer1.ProcessingMode = ProcessingMode.Local;

                                dtManufactBatchCostSummary = objBatch_DL.Get_BatchCost_Summary(BatchID);

                                dtManufactBatchMaterialCost = objBatch_DL.Get_BatchCost_Material(BatchID);
                                 dtManufactBatchOHCost = objBatch_DL.Get_OHCost(BatchID);
                                 dtManufactBatchMachineCost = objBatch_DL.Get_MachineCost(BatchID);
                                 dtManufactBatchLaborCost = objBatch_DL.Get_LabourCost(BatchID);
                                 dtManufactPrevBatchCost = objBatch_DL.Get_BatchCost_Previous(BatchID);
                


                                ReportDataSource source1 = new ReportDataSource();
                                source1.Name = "BatchCostSumarry";
                                source1.Value = dtManufactBatchCostSummary;

                                ReportDataSource source2 = new ReportDataSource();
                                source2.Name = "BatchLaborCost";
                                source2.Value = dtManufactBatchLaborCost;

                                ReportDataSource source3 = new ReportDataSource();
                                source3.Name = "BatchOverheadCost";
                                source3.Value = dtManufactBatchOHCost;

                                ReportDataSource source4 = new ReportDataSource();
                                source4.Name = "BatchFuelCost";
                                source4.Value = dtManufactBatchMachineCost;

                                ReportDataSource source5 = new ReportDataSource();
                                source5.Name = "BatchMaterialCost";
                                source5.Value = dtManufactBatchMaterialCost;


                                ReportDataSource source6 = new ReportDataSource();
                                source6.Name = "PreviousBatchCost";
                                source6.Value = dtManufactPrevBatchCost;

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
    }
}
