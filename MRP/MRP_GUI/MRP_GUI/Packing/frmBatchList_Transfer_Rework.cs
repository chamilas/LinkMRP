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
    public partial class frmBatchList_Transfer_Rework : System.Windows.Forms.Form
    {

        User CurrentUser = new User();

        public frmBatchList_Transfer_Rework(User objUser)
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
        MTN_DL objMTN_DL = new MTN_DL(ConnectionStringClass.GetConnection());
        Department_DL objDepartment_DL = new Department_DL(ConnectionStringClass.GetConnection());

        Batch objBatch = new Batch();
        BatchActivity objBatchActivity = new BatchActivity();
        MainActivity objActivity = new MainActivity();

        bool Loaded = false;

        private void frmBatchList_Load(object sender, EventArgs e)
        {

            Load_Batch_List();

            objActivity = objMainActivity_DL.GetByName("Packing");

            txtActivity.Text = objActivity.MainActivityTitle;

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

                DataTable dt = objBatch_DL.Get_DataView_ReworkBatchList((int)Batch.Status.QCPass, "Rework", "Repack");
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


        private void Load_Activity()
        {
            try
            {
                if (dgvBatcList.Rows.Count > 0)
                {

                    DataTable dt = objBatchActivity_DL.GetView_ToTransfer_Rework(dgvBatcList.CurrentRow.Cells["BatchNo"].Value.ToString(),
                       Convert.ToInt32(BatchActivity.Status.Finished));

                    objSourceActivityList.DataSource = dt;
                    dgvActivity.AutoGenerateColumns = false;
                    dgvActivity.DataSource = objSourceActivityList;
                    objSourceActivityList.ResetBindings(true);

                    //DataTable dtRemaining = objBatchActivity_DL.GetView_Remaining_ToTransfer(dgvBatcList.CurrentRow.Cells["BatchNo"].Value.ToString(),
                    //    Convert.ToInt32(BatchActivity.Status.SecondaryPacking), Convert.ToInt32(BatchActivity.Status.Finished));

                    //objSourceRemaining.DataSource = dtRemaining;
                    //dgvRemaining.AutoGenerateColumns = false;
                    //dgvRemaining.DataSource = objSourceRemaining;
                    //objSourceRemaining.ResetBindings(true);


                }


               // SetColors();
            }
            catch (Exception)
            {

                MessageBox.Show(this, "Error occured while loading Batch List", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SetColors()
        {
            for (int i = 0; i < dgvActivity.Rows.Count; i++)
            {
                if ((dgvActivity.Rows[i].Cells["BatchActStatus"].Value).ToString() == "2")
                {
                    dgvActivity.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                }
                else
                {
                    dgvActivity.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                }
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
                    objBatchActivity = objBatchActivity_DL.Get(objBatch.BatchID,objActivity.MainActID);

                    Load_Activity();

                }


             

            }
            catch (Exception)
            {

                MessageBox.Show(this, "Error occured while loading Batch List", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        private void Load_BatchLabourDetails()
        {
            try
            {

                DataTable dt = new DataTable();

                if (objBatchActivity.BatchActID != 0)
                {
                     dt = objBatchLabourDetails_DL.Get_ByBatchActID(Convert.ToInt32(objBatchActivity.BatchActID));
                }
                else
                {
                    dt = null;
                }


               dgvBatchLabourDetails.AutoGenerateColumns=false;
                objSourceBatchLabour.DataSource=dt;
                dgvBatchLabourDetails.DataSource=objSourceBatchLabour;
                objSourceBatchLabour.ResetBindings(true);


            }
            catch (Exception)
            {

                MessageBox.Show(this, "Error occured while loading Labour Details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void Load_BatchMachineDetails()
        {
            try
            {
                DataTable dt = new DataTable();

                if (objBatchActivity.BatchActID != 0)
                {
                    dt = objBatchMachineDetails_DL.Get_ByBatchActID(Convert.ToInt32(objBatchActivity.BatchActID));
                }
                else
                {
                    dt = null;
                }

                dgvMachineDetails.AutoGenerateColumns = false;
              objSourceBatchMachine.DataSource = dt;
              dgvMachineDetails.DataSource = objSourceBatchMachine;
              objSourceBatchMachine.ResetBindings(true);


            }
            catch (Exception)
            {

                MessageBox.Show(this, "Error occured while loading Machine Details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

 
      
        private void dgvBatchLabourDetails_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {

                if (objBatchActivity.BatchActStatus == BatchActivity.Status.Finished)
                {
                    MessageBox.Show(this, "This Activity Is Finished.", "Wrong Attempt", MessageBoxButtons.OK);
                }
                else
                {
                    BatchLabourDetails obj = new BatchLabourDetails();

                    objBatchLabourDetails_DL.Delete(Convert.ToInt32(dgvBatchLabourDetails.CurrentRow.Cells["LabourRecID"].Value));

                    Load_BatchLabourDetails();
                }


            }
        }

        private void dgvMachineDetails_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DialogResult theResult = MessageBox.Show(this, "Do you want to delete the selected Record", "Confirmation", MessageBoxButtons.YesNo);

                if (objBatchActivity.BatchActStatus == BatchActivity.Status.Finished)
                {
                    MessageBox.Show(this, "This Activity Is Finished.", "Wrong Attempt", MessageBoxButtons.OK);
                }
                else
                {
                    if (theResult == System.Windows.Forms.DialogResult.Yes)
                    {
                        BatchMachineDetails obj = new BatchMachineDetails();

                        objBatchMachineDetails_DL.Delete(Convert.ToInt32(dgvMachineDetails.CurrentRow.Cells["MachineRecID"].Value));

                        Load_BatchMachineDetails();
                    }
                }

            }
        }

        

        private void dgvActivity_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {

                FinishProduct objFinishProduct = new FinishProduct();

                objFinishProduct = objFinishProduct_DL.Get(dgvActivity.CurrentRow.Cells["SecondaryFinishProduct"].Value.ToString());



                objBatchActivity = objBatchActivity_DL.GetByID(Convert.ToInt32(dgvActivity.CurrentRow.Cells["BatchActID"].Value));

                Load_BatchLabourDetails();
                Load_BatchMachineDetails();

                txtProductCode.Text = objFinishProduct.FinishProductCode;
                txtTransferQty.Text = objBatchActivity.StopQty.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnFinishPacking_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show(this,"Do you want to finish the Activity","Confirmation",MessageBoxButtons.YesNo);

                if(dr== DialogResult.Yes)
                {

                objBatchActivity = objBatchActivity_DL.GetByID(Convert.ToInt32(dgvActivity.CurrentRow.Cells["BatchActID"].Value));

                objBatchActivity.BatchActStatus = BatchActivity.Status.Finished;

                objBatchActivity_DL.Update(objBatchActivity);


                }

                Load_Activity();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
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

        private void btnSendtoPacking_Click(object sender, EventArgs e)
        {

            try
            {
                 DataTable dtReports=  objQCReport_DL.Get_IsPackingQCPass(objBatch.BatchID, Convert.ToInt32(QCReport.ReportStatus.Accept),"Packing");

                 if (dtReports.Rows.Count > 0)
                 {
                     objBatchActivity.BatchActStatus = BatchActivity.Status.SecondaryPacking;

                     objBatchActivity_DL.Update(objBatchActivity);

                     Load_Activity();
                 }
                 else
                 {
                     MessageBox.Show(this, "Packing QC is Not Passed", "Can not Proceed", MessageBoxButtons.OK);
                 }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnSendToStore_Click(object sender, EventArgs e)
        {
            try
            {
                
              DataTable dtReports=  objQCReport_DL.Get_IsPackingQCPass(objBatch.BatchID, Convert.ToInt32(QCReport.ReportStatus.Accept),"Rework");

              if (dtReports.Rows.Count > 0)
              {
                      MTN objMTN = new MTN();
                      objMTN.PackingBatch = Convert.ToInt64(dgvActivity.CurrentRow.Cells["BatchActID"].Value);
                      objMTN.MTNEnterdBy = objEmployee_DL.Get(CurrentUser.EmployeeID);
                      objMTN.MTNDepartmentTo = objDepartment_DL.GetByDepType("STORE");
                      objMTN.MTNStatus = MTN.Status.Initial;
                      objMTN.MTNType = MTN.Type.Packing;
                      objMTN.MTNItemType = MTN.ItemType.Finish_Product;



                      int i = objMTN_DL.CreatePackingMTN_toStores(objMTN, BatchActivity.Status.Transferred, dgvActivity.CurrentRow.Cells["SecondaryFinishProduct"].Value.ToString(), Convert.ToInt32(dgvActivity.CurrentRow.Cells["Qty"].Value), BatchActivity.Status.Finished, BatchActivity.Status.SecondaryPacking);

                      if (i > 0)
                      {
                          MessageBox.Show(this, "Successfully sent to Stores. MTN No is :" + i.ToString(), "Successful", MessageBoxButtons.OK);
                      }
                      else
                      {
                          MessageBox.Show(this, "Invalid Qty", "Unsuccessful", MessageBoxButtons.OK);
                      }

                      Load_Activity();

                      if (dgvBatcList.Rows.Count > 0)
                      {
                          if (dgvActivity.Rows.Count > 0)
                          {
                              DataGridViewCellEventArgs dr = new DataGridViewCellEventArgs(1, 0);
                              dgvBatcList_CellClick(sender, dr);
                              dgvActivity_CellClick(sender, dr);
                          }
                          else
                          {
                              dgvBatchLabourDetails.AutoGenerateColumns = false;
                              objSourceBatchLabour.DataSource = null;
                              dgvBatchLabourDetails.DataSource = objSourceBatchLabour;
                              objSourceBatchLabour.ResetBindings(true);

                          }

                      }

                      objBatch_DL.Update_Packed(objBatch.BatchID, (int)Batch.Status.Packed, (int)BatchActivity.Status.Transferred, (int)MTN.Status.Reject);

                      txtTransferQty.Text = "";
              }
              else
              {
                  MessageBox.Show(this, "Packing QC is Not Passed" ,"Can not Proceed", MessageBoxButtons.OK);
              }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }


        }

        private void btnTransferBP_Click(object sender, EventArgs e)
        {

        }

        
       


    }
}
