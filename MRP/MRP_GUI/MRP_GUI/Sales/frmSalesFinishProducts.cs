using DL;
using MRP_DL;
using MRP_GUI.Sales;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SESD.MRP.REF;

namespace MRP_GUI.Sales
{
    public partial class frmSalesFinishProducts : System.Windows.Forms.Form
    {
        private SalesFinishProduct_DL sfp = new SalesFinishProduct_DL(ConnectionStringClass.GetConnection());
        public frmSalesFinishProducts()
        {
            InitializeComponent();
            grid_change_price.DataSource = sfp.GetSalesFinishProduct();
            grid_add_price.DataSource = sfp.GetSalesFinishProduct_NOTSET();
        }

        private void grid_change_price_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                SalesFinishProducts obj = new SalesFinishProducts();
                obj.finishProductCode = grid_change_price.Rows[e.RowIndex].Cells[e.ColumnIndex + 1].Value.ToString();
                obj.finishProductName = grid_change_price.Rows[e.RowIndex].Cells[e.ColumnIndex + 2].Value.ToString();
                string state = grid_change_price.Rows[e.RowIndex].Cells[e.ColumnIndex + 3].Value.ToString();
                obj.price= double.Parse(grid_change_price.Rows[e.RowIndex].Cells[e.ColumnIndex + 4].Value.ToString());
                obj.isSellable = 0;

                if (state != "Non Selling Item")
                {
                    obj.isSellable = 1;
                }

                frmAssignPrice frm = new frmAssignPrice(obj,0);
                frm.ShowDialog();
                grid_change_price.DataSource = sfp.GetSalesFinishProduct();
                grid_add_price.DataSource = sfp.GetSalesFinishProduct_NOTSET();

            }
        }

        private void grid_add_price_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                SalesFinishProducts obj = new SalesFinishProducts();
                obj.finishProductCode = grid_add_price.Rows[e.RowIndex].Cells[e.ColumnIndex + 1].Value.ToString();
                obj.finishProductName = grid_add_price.Rows[e.RowIndex].Cells[e.ColumnIndex + 2].Value.ToString();
                obj.price = 0.00;
                obj.isSellable = 0;

                frmAssignPrice frm = new frmAssignPrice(obj,1);
                frm.ShowDialog();
                grid_change_price.DataSource = sfp.GetSalesFinishProduct();
                grid_add_price.DataSource = sfp.GetSalesFinishProduct_NOTSET();
            }
        }

        private void frmSalesFinishProducts_Load(object sender, EventArgs e)
        {

        }
    }
}
