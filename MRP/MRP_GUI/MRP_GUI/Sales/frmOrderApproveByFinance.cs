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
    public partial class frmOrderApproveByFinance : Form
    {
        private OrderSorting_DL ors = new OrderSorting_DL(ConnectionStringClass.GetConnection());
        public frmOrderApproveByFinance()
        {
            InitializeComponent();
            grid_orderByFinance.DataSource = ors.GetOrdersBySate(1);
        }

        private void grid_orderByFinance_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                string code = grid_orderByFinance.Rows[e.RowIndex].Cells[e.ColumnIndex+3].Value.ToString();

                DialogResult rs = MessageBox.Show("Do you wish to continue...?", "Confirm Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.No)
                {
                    return;
                }

                if (ors.UpdateOrderState(code, 2) > 0)
                {
                    ors.Reserved(code);
                    MessageBox.Show("Order is confirmed...!", "Confirm Order", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    grid_orderByFinance.DataSource = ors.GetOrdersBySate(1);
                }

                else
                {
                    MessageBox.Show("Try again...!", "Confirm Order", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }
    }
}
