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
        public frmOrderSorting()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAssignQuantity frm = new frmAssignQuantity();
            frm.ShowDialog();
        }
    }
}
