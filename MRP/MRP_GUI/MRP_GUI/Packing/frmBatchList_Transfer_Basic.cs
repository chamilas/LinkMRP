using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DL;
using SESD.MRP.REF;
using MRP_GUI.Production;


namespace MRP_GUI
{
    public partial class frmBatchList_Transfer_Basic : System.Windows.Forms.Form
    {

        User CurrentUser = new User();

        public frmBatchList_Transfer_Basic(User objUser)
        {
            InitializeComponent();
            CurrentUser = objUser;
        }

        Batch_DL objBatch_DL = new Batch_DL(ConnectionStringClass.GetConnection());
        MainActivity_DL objMainActivity_DL = new MainActivity_DL(ConnectionStringClass.GetConnection());
        BatchActivity_DL objBatchActivity_DL = new BatchActivity_DL(ConnectionStringClass.GetConnection());
        MachineActivity_DL objMachineActivity_DL = new MachineActivity_DL(ConnectionStringClass.GetConnection());
        BatchLabourDetails_DL objBatchLabourDetails_DL = new BatchLabourDetails_DL(ConnectionStringClass.GetConnection());
        BatchMachineDetails_DL objBatchMachineDetails_DL = new BatchMachineDetails_DL(ConnectionStringClass.GetConnection());
        Machine_DL objMachine_DL = new Machine_DL(ConnectionStringClass.GetConnection());
        Employee_DL objEmployee_DL = new Employee_DL(ConnectionStringClass.GetConnection());
        FinishProduct_DL objFinishProduct_DL = new FinishProduct_DL(ConnectionStringClass.GetConnection());

         QCReport_DL objQCReport_DL = new QCReport_DL(ConnectionStringClass.GetConnection());
        Department_DL objDepartment_DL= new Department_DL(ConnectionStringClass.GetConnection());
        MTN_DL objMTN_DL = new MTN_DL(ConnectionStringClass.GetConnection());

        Batch objBatch = new Batch();
        BatchActivity objBatchActivity = new BatchActivity();
        MainActivity objActivity = new MainActivity();

        bool Loaded = false;

        private void frmBatchList_Load(object sender, EventArgs e)
        {

            Load_Batch_List();


            if (dgvBatcList.Rows.Count > 0)
            {
                dgvBatcList.Rows[0].Selected = true;
                objBatch = objBatch_DL.Get(dgvBatcList.CurrentRow.Cells["BatchNo"].Value.ToString());
                txtBatchID.Text = objBatch.BatchID;
                
            }
            
        }

        private void Load_Batch_List()
        {
            try
            {

                DataTable dt = objBatch_DL.Get_DataView_Packing(Batch.Status.Finished, Batch.Status.Finished, CurrentUser.UserID, "Semi Processed Product");
                objSourceBatchList.DataSource = dt;

                dgvBatcList.AutoGenerateColumns = false;
                dgvBatcList.DataSource = objSourceBatchList;
                objSourceBatchList.ResetBindings(true);

                
            }
            catch (Exception)
            {

                MessageBox.Show(this, "Error occured while loading Batch List", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }


       

       





        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
          
            
            if (keyData == Keys.F1)
            {
                frmBatchMaterial objForm = new frmBatchMaterial(objBatch.BatchID);
                objForm.ShowDialog(this);
            }


            // Call the base class
            return base.ProcessCmdKey(ref msg, keyData);
        }

        

        private void btnTransferBP_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult theResult = MessageBox.Show(this, "Do You Need to Transfer Basic Product to RPD Stores", "Confirmation", MessageBoxButtons.YesNo);

                if (theResult == System.Windows.Forms.DialogResult.Yes)
                {
                    if (dgvBatcList.Rows.Count > 0)
                    {
                        objBatch = objBatch_DL.Get(dgvBatcList.CurrentRow.Cells["BatchNo"].Value.ToString());
                        txtBatchID.Text = objBatch.BatchID;
                    }

                    DataTable dtReports = objQCReport_DL.Get_IsManufacturingQCPass(objBatch.BatchID, Convert.ToInt32(QCReport.ReportStatus.Accept));

                    if (dtReports.Rows.Count > 0)
                    {

                        MTN objMTN = new MTN();
                        objMTN.MTNBatch = Convert.ToString(dgvBatcList.CurrentRow.Cells["BatchNo"].Value);
                        objMTN.MTNEnterdBy = objEmployee_DL.Get(CurrentUser.EmployeeID);
                        objMTN.MTNDepartmentTo = objDepartment_DL.GetByDepType("RPD");
                        objMTN.MTNStatus = MTN.Status.Initial;
                        objMTN.MTNType = MTN.Type.Batch;
                        objMTN.MTNItemType = MTN.ItemType.Basic_Product;



                        int i = objMTN_DL.CreateBasicProductTransfer_Semi_toRPD(objMTN, Batch.Status.Transferred, objBatch.StandardBatch.STDBatchBasicProduct.BasicProductCode, Convert.ToDecimal(dgvBatcList.CurrentRow.Cells["BatchFinalQty"].Value));

                        if (i > 0)
                        {
                            MessageBox.Show(this, "Successfully sent to Stores. MTN No is :" + i.ToString(), "Successful", MessageBoxButtons.OK);
                        }


                        Load_Batch_List();


                    }
                    else
                    {
                        MessageBox.Show(this, "Packing QC is Not Passed", "Can not Proceed", MessageBoxButtons.OK);
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }

        private void dgvBatcList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvBatcList.Rows.Count > 0)
                {
                    objBatch = objBatch_DL.Get(dgvBatcList.CurrentRow.Cells["BatchNo"].Value.ToString());
                    txtBatchID.Text = objBatch.BatchID;
                }




            }
            catch (Exception)
            {

                MessageBox.Show(this, "Error occured while loading Batch List", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


    }
}
