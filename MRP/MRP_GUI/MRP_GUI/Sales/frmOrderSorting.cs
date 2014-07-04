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
    public partial class frmOrderSorting : Form
    {
        private OrderSorting_DL ors = new OrderSorting_DL(ConnectionStringClass.GetConnection());
        public frmOrderSorting()
        {
            InitializeComponent();
            grid_unsortedOrders.DataSource = ors.GetUnsortedOrders();
        }

        private void grid_unsortedOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                frmAssignQuantity frm = new frmAssignQuantity(grid_unsortedOrders.Rows[e.RowIndex].Cells[e.ColumnIndex + 1].Value.ToString());
                frm.ShowDialog();
                grid_unsortedOrders.DataSource = ors.GetUnsortedOrders();
            }
        }
    }
}
