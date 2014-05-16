using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MRP_GUI.Report
{
    public partial class frmBatchPackingMRBulk : Form
    {
        public frmBatchPackingMRBulk()
        {
            InitializeComponent();
        }

        private void frmBatchPackingMRBulk_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
