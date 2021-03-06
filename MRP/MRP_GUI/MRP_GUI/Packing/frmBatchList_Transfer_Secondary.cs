﻿using System;
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
    public partial class frmBatchList_Transfer_Secondary : System.Windows.Forms.Form
    {

        User CurrentUser = new User();

        public frmBatchList_Transfer_Secondary(User objUser)
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


        private void frmBatchList_Load(object sender, EventArgs e)
        {


            objActivity = objMainActivity_DL.GetByName("Packing_Secondary");

            Load_Activity();
            
        }

        private void Load_Activity()
        {
            try
            {
                    DataTable dt = objBatchActivity_DL.GetView_ToTransfer_Secondary(Convert.ToInt32(BatchActivity.Status.SecondaryPacking_Finish));

                    objSourceActivityList.DataSource = dt;
                    dgvActivity.AutoGenerateColumns = false;
                    dgvActivity.DataSource = objSourceActivityList;
                    objSourceActivityList.ResetBindings(true);



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





        

        private void dgvActivity_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {

                FinishProduct objFinishProduct = new FinishProduct();

                objFinishProduct = objFinishProduct_DL.Get(dgvActivity.CurrentRow.Cells["SecondaryFinishProduct"].Value.ToString());



            objBatchActivity = objBatchActivity_DL.GetByID(Convert.ToInt32(dgvActivity.CurrentRow.Cells["BatchActID"].Value));



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
                 DataTable dtReports=  objQCReport_DL.Get_IsPackingQCPass(objBatch.BatchID, Convert.ToInt32(QCReport.ReportStatus.Accept),"Packing_Secondary");

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
                
              DataTable dtReports=  objQCReport_DL.Get_IsPackingQCPass(dgvActivity.CurrentRow.Cells["BatchID"].Value.ToString(), Convert.ToInt32(QCReport.ReportStatus.Accept),"Packing_Secondary");

              if (dtReports.Rows.Count > 0)
              {

                  MTN objMTN = new MTN();
                  objMTN.PackingBatch = Convert.ToInt64(dgvActivity.CurrentRow.Cells["BatchActID"].Value);
                  objMTN.MTNEnterdBy = objEmployee_DL.Get(CurrentUser.EmployeeID);
                  objMTN.MTNDepartmentTo = objDepartment_DL.GetByDepType("STORE");
                  objMTN.MTNStatus = MTN.Status.Initial;
                  objMTN.MTNType = MTN.Type.Packing;
                  objMTN.MTNItemType = MTN.ItemType.Finish_Product;



                  int i = objMTN_DL.CreatePackingMTN_Secondary_toStores(objMTN, BatchActivity.Status.Transferred, dgvActivity.CurrentRow.Cells["SecondaryFinishProduct"].Value.ToString(), Convert.ToInt32(dgvActivity.CurrentRow.Cells["Qty"].Value), BatchActivity.Status.Finished, BatchActivity.Status.SecondaryPacking);

                  if (i > 0)
                  {
                      MessageBox.Show(this, "Successfully sent to Stores. MTN No is :" + i.ToString(), "Successful", MessageBoxButtons.OK);
                  }

                  objBatch_DL.Update_Packed(dgvActivity.CurrentRow.Cells["BatchID"].Value.ToString(), (int)Batch.Status.Packed, (int)BatchActivity.Status.Transferred, (int)MTN.Status.Reject);
                  //objBatch_DL.Update_BatchPackingCost(objBatchActivity.BatchActID);
                  objBatch_DL.Update_BatchSeconderyPackingCost(objBatchActivity.BatchActID);
                  Load_Activity();
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
