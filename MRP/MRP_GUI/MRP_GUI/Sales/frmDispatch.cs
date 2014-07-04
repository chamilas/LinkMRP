using DL;
using Microsoft.Reporting.WinForms;
using MRP_DL;
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
    public partial class frmDispatch : Form
    {
        private Invoice_DL ter = new Invoice_DL(ConnectionStringClass.GetConnection());
        private string id;
        public frmDispatch(string id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void frmDispatch_Load(object sender, EventArgs e)
        {
            LoadReport(this.id);
            this.rptViewer.RefreshReport();
        }
        private void LoadReport(string id)
        {
            try
            {
                rptViewer.ProcessingMode = ProcessingMode.Local;

                DataTable dt = ter.GetDispatch(id);

                ReportDataSource source1 = new ReportDataSource();
                source1.Name = "DispatchPrint";
                source1.Value = dt;

                #region Report Parameters
                ReportParameter p1 = new ReportParameter("InvoiceID", this.id);
                rptViewer.LocalReport.SetParameters(p1);
                ReportParameter p2 = new ReportParameter("CustomerName", ter.GetCustomerName(this.id));
                rptViewer.LocalReport.SetParameters(p2);
                ReportParameter p3 = new ReportParameter("Date", System.DateTime.Now.ToShortDateString());
                rptViewer.LocalReport.SetParameters(p3);
                ReportParameter p4 = new ReportParameter("Quantity", ter.GetSumDetails(dt, 2).ToString());
                rptViewer.LocalReport.SetParameters(p4);
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

        private void rptViewer_PrintingBegin(object sender, ReportPrintEventArgs e)
        {
            if (ter.UpdateDispatchStatus(this.id, 1) <= 0)
            {
                MessageBox.Show("Dispatch Status not updated...?", "Dispatch Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
    }
}
