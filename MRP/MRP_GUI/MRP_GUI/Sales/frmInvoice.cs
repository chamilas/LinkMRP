using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using MRP_DL;
using DL;

namespace MRP_GUI.Report
{
    public partial class frmInvoice : Form
    {
        private Invoice_DL ter = new Invoice_DL(ConnectionStringClass.GetConnection());
        private string id;
        public frmInvoice( string id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void frmInvoice_Load(object sender, EventArgs e)
        {
            LoadReport(this.id);
            this.rptViewer.RefreshReport();

        }

        private void LoadReport(string id)
        {
            try
            {
                rptViewer.ProcessingMode = ProcessingMode.Local;

                DataTable dt = ter.GetInvoice(id);

                ReportDataSource source1 = new ReportDataSource();
                source1.Name = "InvoicePrint";
                source1.Value = dt;

                #region Report Parameters
                ReportParameter p1 = new ReportParameter("InvoiceID", this.id);
                rptViewer.LocalReport.SetParameters(p1);
                ReportParameter p2 = new ReportParameter("CustomerName", ter.GetCustomerName(this.id));
                rptViewer.LocalReport.SetParameters(p2);
                ReportParameter p3 = new ReportParameter("Date", System.DateTime.Now.ToShortDateString());
                rptViewer.LocalReport.SetParameters(p3);
                ReportParameter p4 = new ReportParameter("Price", String.Format("{0:0.00}",ter.GetSumDetails(dt,3)));
                rptViewer.LocalReport.SetParameters(p4);
                ReportParameter p5 = new ReportParameter("Quantity", ter.GetSumDetails(dt, 2).ToString());
                rptViewer.LocalReport.SetParameters(p5);
                #endregion

                rptViewer.LocalReport.DataSources.Clear();
                rptViewer.LocalReport.DataSources.Add(source1);

                rptViewer.LocalReport.Refresh();
                rptViewer.RefreshReport();
            }
            catch (Exception ee)
            {
                MessageBox.Show(this, ee.Message.ToString(), "Error Loading the Report", MessageBoxButtons.OK,MessageBoxIcon.Error);

            }
        }

        private void rptViewer_Print(object sender, ReportPrintEventArgs e)
        {
            //MessageBox.Show("print button");
        }

        private void rptViewer_PrintingBegin(object sender, ReportPrintEventArgs e)
        {
           // MessageBox.Show("print begin");
            if (ter.UpdatePrintStatus(this.id, 1) <= 0)
            {
                MessageBox.Show("Print Status not updated...?", "Print Status", MessageBoxButtons.OK,MessageBoxIcon.Error);
                this.Close();
            }
        }
    }
}
