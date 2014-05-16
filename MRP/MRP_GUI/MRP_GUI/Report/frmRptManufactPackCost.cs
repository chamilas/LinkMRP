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

namespace MRP_GUI.Report
{
    public partial class frmRptManufactPackCost : Form
    {
        public frmRptManufactPackCost(long _batchPackingID)
        {
            InitializeComponent();
            BatchPackingID = _batchPackingID;
        }

        private void frmRptManufactPackCost_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            LoadReport();
        }

        long BatchPackingID = 0;
        Batch_DL objBatch_DL = new Batch_DL(ConnectionStringClass.GetConnection());

        DataTable dtPackingCostSummary = new DataTable();
        DataTable dtPackingMaterialCost = new DataTable();
        DataTable dtPackPrevCost = new DataTable();
        DataTable dtPackingOHCost = new DataTable();
        DataTable dtPackingMachineCost = new DataTable();
        DataTable dtPackingLaborCost = new DataTable();

        private void LoadReport()
        {

            try
            {

                reportViewer1.ProcessingMode = ProcessingMode.Local;

                dtPackingCostSummary = objBatch_DL.Get_BatchPacking_Summary(BatchPackingID);
                dtPackingMaterialCost = objBatch_DL.Get_BatchPacking_Material_Summary(BatchPackingID);
                dtPackingOHCost = objBatch_DL.Get_BatchPacking_OH_Summary(BatchPackingID);
                dtPackingMachineCost = objBatch_DL.Get_BatchPacking_Machine_Summary(BatchPackingID);
                dtPackingLaborCost = objBatch_DL.Get_BatchPacking_Labour_Summary(BatchPackingID);
                dtPackPrevCost = objBatch_DL.Get_BatchPacking_Summary(BatchPackingID);



                ReportDataSource source1 = new ReportDataSource();
                source1.Name = "PackingCostSummary";
                source1.Value = dtPackingCostSummary;

                ReportDataSource source2 = new ReportDataSource();
                source2.Name = "PackingLaborCost";
                source2.Value = dtPackingLaborCost;

                ReportDataSource source3 = new ReportDataSource();
                source3.Name = "PackingOHCost";
                source3.Value = dtPackingOHCost;

                ReportDataSource source4 = new ReportDataSource();
                source4.Name = "PackingMachineCost";
                source4.Value = dtPackingMachineCost;

                ReportDataSource source5 = new ReportDataSource();
                source5.Name = "PackingMaterialCost";
                source5.Value = dtPackingMaterialCost;


                ReportDataSource source6 = new ReportDataSource();
                source6.Name = "PackPrevCost";
                source6.Value = dtPackPrevCost;

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
