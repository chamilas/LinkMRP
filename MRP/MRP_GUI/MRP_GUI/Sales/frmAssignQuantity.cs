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
    public partial class frmAssignQuantity : Form
    {
        private OrderSorting_DL ors = new OrderSorting_DL(ConnectionStringClass.GetConnection());
        public frmAssignQuantity(string orderID)
        {
            InitializeComponent();
            txt_orderID.Text = orderID;
            grid_sorting.DataSource = ors.GetOrderDetails(orderID);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            if (ors.IsComplete(txt_orderID.Text.ToString()) == 0)
            {
                if (ors.UpdateOrderState(txt_orderID.Text.ToString(), 3) > 0)
                {
                    MessageBox.Show("Order is submited...!", "Order Submition", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }

                else
                {
                    MessageBox.Show("Try again...!", "Order Submition", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Please fill the quantity and batch for all items", "Order Submition", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private bool IsNum(string text)
        {
            try
            {
                int num = int.Parse(text);
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        private void grid_sorting_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                frmAssignDialog frm = new frmAssignDialog(txt_orderID.Text.ToString(), grid_sorting[e.ColumnIndex + 1, e.RowIndex].Value.ToString().Split('-')[0]);
                frm.ShowDialog();
                grid_sorting.DataSource = ors.GetOrderDetails(txt_orderID.Text.ToString());
            }
        }
    }
}
