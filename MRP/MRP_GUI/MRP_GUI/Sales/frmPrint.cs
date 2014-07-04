using DL;
using MRP_DL;
using MRP_GUI.Report;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MRP_GUI.Sales
{
    public partial class frmPrint : Form
    {
        private Invoice_DL invoice = new Invoice_DL(ConnectionStringClass.GetConnection());
        public frmPrint()
        {
            InitializeComponent();
            grid_print.DataSource = invoice.GetInvoicePrint();
            grid_dispatch.DataSource = invoice.GetDispatchPrint();

        }

        private void grid_print_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                string code = grid_print.Rows[e.RowIndex].Cells[e.ColumnIndex + 1].Value.ToString();

                DialogResult rs = MessageBox.Show("Do you wish to continue...?", "Print Invoice", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.No)
                {
                    return;
                }

                frmInvoice frm=new frmInvoice(code);
                frm.ShowDialog();
                grid_print.DataSource = invoice.GetInvoicePrint();
                grid_dispatch.DataSource = invoice.GetDispatchPrint();

            }
        }

        private void grid_dispatch_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                string code = grid_dispatch.Rows[e.RowIndex].Cells[e.ColumnIndex + 1].Value.ToString();

                DialogResult rs = MessageBox.Show("Do you wish to continue...?", "Print Dispatch", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.No)
                {
                    return;
                }

                frmDispatch frm = new frmDispatch(code);
                frm.ShowDialog();
                grid_print.DataSource = invoice.GetInvoicePrint();
                grid_dispatch.DataSource = invoice.GetDispatchPrint();

            }
        }
    }
}
