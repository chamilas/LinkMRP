using DL;
using MRP_GUI.Report;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MRP_GUI
{
    public partial class frmWIP_PRPD : Form
    {

        PRPDBatch_DL objPRPDBatch_DL = new PRPDBatch_DL(ConnectionStringClass.GetConnection());
        DataTable dt = new DataTable();

        public frmWIP_PRPD()
        {
            InitializeComponent();
            LoadData();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData() 
        {
            dgvWIP_PRPD.AutoGenerateColumns = false;
            dt=objPRPDBatch_DL.GetWIP_PRPD(dateTimePicker1.Value);
            bsWIP_PRPD.DataSource = dt;
            dgvWIP_PRPD.DataSource = bsWIP_PRPD;
            bsWIP_PRPD.ResetBindings(true);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            frmRptWIP_PRPD frm = new frmRptWIP_PRPD(dateTimePicker1.Value);
            frm.Show();
        }
    }

}
