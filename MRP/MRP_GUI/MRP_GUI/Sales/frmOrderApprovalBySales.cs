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
    public partial class frmOrderApprovalBySales : Form
    {
        private OrderSorting_DL ors = new OrderSorting_DL(ConnectionStringClass.GetConnection());
        public frmOrderApprovalBySales()
        {
            InitializeComponent();
            grid_orderBySales.DataSource = ors.GetOrdersBySate(0);
        }

        private void grid_orderBySales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                string code = grid_orderBySales.Rows[e.RowIndex].Cells[e.ColumnIndex + 1].Value.ToString();

                DialogResult rs = MessageBox.Show("Do you wish to continue...?", "Confirm Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.No)
                {
                    return;
                }

                if (ors.UpdateOrderState(code, 1) > 0)
                {
                    MessageBox.Show("Order is confirmed...!", "Confirm Order", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    grid_orderBySales.DataSource = ors.GetOrdersBySate(0);
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
