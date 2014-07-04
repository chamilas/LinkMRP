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
    public partial class frmOrderApprovalByStoreManager : Form
    {
        private OrderSorting_DL ors = new OrderSorting_DL(ConnectionStringClass.GetConnection());
        private Invoice_DL invoice = new Invoice_DL(ConnectionStringClass.GetConnection());
        public frmOrderApprovalByStoreManager()
        {
            InitializeComponent();
            grid_orderByStoreManage.DataSource = ors.GetOrdersBySate(3);
        }

        private void grid_orderByStoreManage_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                string code = grid_orderByStoreManage.Rows[e.RowIndex].Cells[e.ColumnIndex + 2].Value.ToString();

                DialogResult rs = MessageBox.Show("Do you wish to continue...?", "Confirm Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.No)
                {
                    return;
                }

                if (ors.UpdateOrderState(code, 4) > 0)
                {
                    if (invoice.FillDetails(code))
                    {

                        MessageBox.Show("Order is confirmed...!", "Confirm Order", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        grid_orderByStoreManage.DataSource = ors.GetOrdersBySate(3);
                    }
                }
                 

                else
                {
                    MessageBox.Show("Try again...!", "Confirm Order", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (e.ColumnIndex == 1)
            {
                string code = grid_orderByStoreManage.Rows[e.RowIndex].Cells[e.ColumnIndex + 1].Value.ToString();
                frmViewOrder frm = new frmViewOrder(code);
                frm.ShowDialog();
            }
        }
    }
}
