using DL;
using MRP_DL;
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
    public partial class frmInvoiceApprove : Form
    {
        private Invoice_DL invoice = new Invoice_DL(ConnectionStringClass.GetConnection());
        private OrderSorting_DL ors = new OrderSorting_DL(ConnectionStringClass.GetConnection());
        public frmInvoiceApprove()
        {
            InitializeComponent();
            grid_approval.DataSource = invoice.GetInvoiceForApproval();
        }

        private void grid_approval_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                string code = grid_approval.Rows[e.RowIndex].Cells[e.ColumnIndex + 1].Value.ToString();

                DialogResult rs = MessageBox.Show("Do you wish to continue...?", "Confirm Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.No)
                {
                    return;
                }

                if (invoice.UpdateInvoiceStatus(code,1,0) > 0)
                {
                    ors.Confirm_Reserved(ors.GetOrderIDByInvoiceID(code));
                    MessageBox.Show("Invoice is confirmed...!", "Confirm Invoice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    grid_approval.DataSource = invoice.GetInvoiceForApproval();
                }

                else
                {
                    MessageBox.Show("Try again...!", "Confirm Invoice", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }
    }
}
