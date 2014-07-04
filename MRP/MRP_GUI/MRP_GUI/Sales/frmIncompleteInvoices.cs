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
    public partial class frmIncompleteInvoices : Form
    {
        private OrderSorting_DL cus = new OrderSorting_DL(ConnectionStringClass.GetConnection());
        public frmIncompleteInvoices()
        {
            InitializeComponent();
            grid_incomplete.DataSource = cus.GetIncompleteInvoices();
        }

        private void grid_incomplete_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                string code = grid_incomplete.Rows[e.RowIndex].Cells[e.ColumnIndex + 2].Value.ToString();
                string Remain = grid_incomplete.Rows[e.RowIndex].Cells[e.ColumnIndex + 5].Value.ToString();

                DialogResult rs = MessageBox.Show("Do you wish to continue...?", "Request Qunatity", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.No)
                {
                    return;
                }

                if (cus.UpdateQuantityReserved(code,int.Parse(Remain))>0)
                {
                    MessageBox.Show("Requset Quantity is updated...!", "Request Qunatity", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    grid_incomplete.DataSource = cus.GetIncompleteInvoices();
                }

                else
                {
                    MessageBox.Show("Try again...!", "Request Qunatity", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }
    }
}
