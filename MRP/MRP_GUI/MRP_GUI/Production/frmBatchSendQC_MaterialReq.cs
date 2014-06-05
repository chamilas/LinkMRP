using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SESD.MRP.REF;
using DL;

namespace MRP_GUI
{
    public partial class frmBatchSendQC_MaterialReq : System.Windows.Forms.Form
    {
        public frmBatchSendQC_MaterialReq(string _BatchID)
        {
            InitializeComponent();
            BatchID=_BatchID ;
        }


        string BatchID = "";
        Batch_DL objBatch_DL = new Batch_DL(ConnectionStringClass.GetConnection());
        BatchPackingMR_DL objBatchPackingMR_DL = new BatchPackingMR_DL(ConnectionStringClass.GetConnection());

        DataTable dt = new DataTable();
        DataTable dtPacking = new DataTable();

        private void frmBatchMaterial_Load(object sender, EventArgs e)
        {
            try
            {

               dt= objBatch_DL.Get_BatchMaterial_RequestedState(BatchID);

               dgvItems.AutoGenerateColumns = false;
               objSourceItem.DataSource = dt;
               dgvItems.DataSource = objSourceItem;
               objSourceItem.ResetBindings(true);


               dtPacking = objBatchPackingMR_DL.GetData_ByBatchID(BatchID);

               //dgvMaterialPacking.AutoGenerateColumns = false;
               ///objSourceItemPacking.DataSource = dtPacking;
               //dgvMaterialPacking.DataSource = objSourceItemPacking;
               //objSourceItemPacking.ResetBindings(true); 




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }


        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {


            if (keyData == Keys.Escape)
            {
                    this.Close();
            }
            // Call the base class
            return base.ProcessCmdKey(ref msg, keyData);
        }


    }
}
