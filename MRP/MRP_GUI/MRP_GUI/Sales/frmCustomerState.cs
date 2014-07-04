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
    public partial class frmCustomerState : Form
    {
        private Territory_DL ter = new Territory_DL(ConnectionStringClass.GetConnection());
        public frmCustomerState()
        {
            InitializeComponent();
            grid_deactive.DataSource = ter.GetCustomer(1);
            grid_active.DataSource = ter.GetCustomer(0);

        }

        private void grid_deactive_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                long rows = ter.Customer_State(int.Parse(grid_deactive.Rows[e.RowIndex].Cells[e.ColumnIndex + 1].Value.ToString()), 0);
                grid_deactive.DataSource = ter.GetCustomer(1);
                grid_active.DataSource = ter.GetCustomer(0);
            }
        }

        private void grid_active_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                long rows = ter.Customer_State(int.Parse(grid_active.Rows[e.RowIndex].Cells[e.ColumnIndex + 1].Value.ToString()), 1);
                grid_deactive.DataSource = ter.GetCustomer(1);
                grid_active.DataSource = ter.GetCustomer(0);
            }
        }

        private void frmCustomerState_Load(object sender, EventArgs e)
        {

        }
    }
}
