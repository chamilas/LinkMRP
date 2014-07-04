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
    public partial class frmViewOrder : Form
    {
        private OrderSorting_DL ors = new OrderSorting_DL(ConnectionStringClass.GetConnection());
        public frmViewOrder(string orderID)
        {
            InitializeComponent();
            grid_viewOrder.DataSource = ors.GetOrderDetailsByManager(orderID);
        }
    }
}
