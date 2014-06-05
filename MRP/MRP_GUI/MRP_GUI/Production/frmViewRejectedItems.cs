using DL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MRP_GUI.Production
{
    public partial class frmViewRejectedItems : Form
    {
        BatchActivityMachineDetails_DL objBatchActivityMachineDetails_DL = new BatchActivityMachineDetails_DL(ConnectionStringClass.GetConnection());
        String BatchActID;
        DataTable dt = new DataTable();

        public frmViewRejectedItems(String prmBatchActID)
        {
            BatchActID = prmBatchActID;
            InitializeComponent();
        }

        private void frmViewRejectedItems_Load(object sender, EventArgs e)
        {
            dt = objBatchActivityMachineDetails_DL.GetBatchActivityMachineDetails(BatchActID);

            dgvMaterialDetails.AutoGenerateColumns = false;
            objSourceBatchMaterial.DataSource = dt;
            dgvMaterialDetails.DataSource = objSourceBatchMaterial;
            objSourceBatchMaterial.ResetBindings(true);
        }
    }
}
