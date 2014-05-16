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
using MRP_GUI.Sales;


namespace MRP_GUI
{
    public partial class frmBatchList_Transfer_Primary : System.Windows.Forms.Form
    {

        User CurrentUser = new User();

        public frmBatchList_Transfer_Primary(User objUser)
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
            
        }

        private void Load_Batch_List()
        {
            try
            {

                DataTable dt = objBatch_DL.Get_DataView_TransferPrimary((int)BatchActivity.Status.Finished,(int)BatchActivity.Status.SecondaryPacking,(int)BatchActivity.Status.SecondaryPacking_Start,(int)QCReport.ReportStatus.Accept,(int)MTN.Status.Reject);
                objSourceBatchList.DataSource = dt;

                dgvActivity.AutoGenerateColumns = false;
                dgvActivity.DataSource = objSourceBatchList;
                objSourceBatchList.ResetBindings(true);

                
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




        

        private void dgvActivity_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {

                FinishProduct objFinishProduct = new FinishProduct();

                objFinishProduct = objFinishProduct_DL.Get(dgvActivity.CurrentRow.Cells["SecondaryFinishProduct"].Value.ToString());



                objBatchActivity = objBatchActivity_DL.GetByID(Convert.ToInt32(dgvActivity.CurrentRow.Cells["BatchActID"].Value));

                btnSendToStore.Enabled = true;

                txtProductCode.Text = objFinishProduct.FinishProductCode;

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

        private void btnSendToStore_Click(object sender, EventArgs e)
        {
            try
            {
                
              DataTable dtReports=  objQCReport_DL.Get_IsPackingQCPass(dgvActivity.CurrentRow.Cells["BatchID"].Value.ToString(), Convert.ToInt32(QCReport.ReportStatus.Accept),"Packing");

              if (dtReports.Rows.Count > 0)
              {
                  if (!String.IsNullOrWhiteSpace(txtTransferQty.Text) && DataValidation.IsNumericNumber(txtTransferQty.Text))
                  {
                      MTN objMTN = new MTN();
                      objMTN.PackingBatch = Convert.ToInt64(dgvActivity.CurrentRow.Cells["BatchActID"].Value);
                      objMTN.MTNEnterdBy = objEmployee_DL.Get(CurrentUser.EmployeeID);
                      objMTN.MTNDepartmentTo = objDepartment_DL.GetByDepType("STORE");
                      objMTN.MTNStatus = MTN.Status.Initial;
                      objMTN.MTNType = MTN.Type.Packing;
                      objMTN.MTNItemType = MTN.ItemType.Finish_Product;


                      if (Convert.ToInt32(dgvActivity.CurrentRow.Cells["RemainningQty"].Value) < Convert.ToInt32(txtTransferQty.Text))
                      {
                          MessageBox.Show(this, "Invalid Qty to Transfer", "UnSuccessful", MessageBoxButtons.OK);
                      }
                      else
                      {

                          int i = objMTN_DL.CreatePackingMTN_toStores(objMTN, BatchActivity.Status.Transferred, dgvActivity.CurrentRow.Cells["SecondaryFinishProduct"].Value.ToString(), Convert.ToInt32(txtTransferQty.Text), BatchActivity.Status.Finished, BatchActivity.Status.SecondaryPacking);
                          //objBatch_DL.Update_BatchPackingCost(objBatchActivity.BatchActID);

                          if (i > 0)
                          {
                              MessageBox.Show(this, "Successfully sent to Stores. MTN No is :" + i.ToString(), "Successful", MessageBoxButtons.OK);
                          }
                          else
                          {
                              MessageBox.Show(this, "Invalid Qty", "Unsuccessful", MessageBoxButtons.OK);
                          }

                          objBatch_DL.Update_Packed(dgvActivity.CurrentRow.Cells["BatchID"].Value.ToString(), (int)Batch.Status.Packed, (int)BatchActivity.Status.Transferred, (int)MTN.Status.Reject);

                          Load_Batch_List();
                      }


                      txtTransferQty.Text = "";

                      btnSendToStore.Enabled = false;
                  }
                  else
                  {
                      MessageBox.Show(this, "please enter valid quantity", "MRP System", MessageBoxButtons.OK);
                  }
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
