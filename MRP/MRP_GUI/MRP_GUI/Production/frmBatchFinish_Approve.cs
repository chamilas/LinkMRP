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
    public partial class frmBatchFinish_Approve : System.Windows.Forms.Form
    {

        User CurrentUser = new User();


        public frmBatchFinish_Approve(User objUser)
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
        BatchFormulaBasicProducts_DL objBatchFormulaBasicProducts_DL = new BatchFormulaBasicProducts_DL(ConnectionStringClass.GetConnection());
        BatchFormulaMaterial_DL objBatchFormulaMaterial_DL = new BatchFormulaMaterial_DL(ConnectionStringClass.GetConnection());
        QCReport_DL objQCReport_DL = new QCReport_DL(ConnectionStringClass.GetConnection());

        Batch objBatch = new Batch();
        BatchActivity objBatchActivity = new BatchActivity();
        MainActivity objActivity = new MainActivity();

        private void frmBatchList_Load(object sender, EventArgs e)
        {

            Load_Batch_List();
        }

        private void Load_Batch_List()
        {
            try
            {

                DataTable dt = objBatch_DL.Get_Batch_ToFinish(CurrentUser.UserID,(int)Batch.Status.QCPass);
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


        private void Load_Activity_List()
        {
            try
            {
                if ((dgvBatcList.CurrentRow != null) && (dgvBatcList.CurrentRow.IsNewRow == false))
                {
                    DataTable dt = objBatchActivity_DL.GetView(dgvBatcList.CurrentRow.Cells["BatchNo"].Value.ToString());
                    objSourceActivityList.DataSource = dt;

                    dgvActivity.AutoGenerateColumns = false;
                    dgvActivity.DataSource = objSourceActivityList;
                    objSourceActivityList.ResetBindings(true);

                    objBatch = objBatch_DL.Get(dgvBatcList.CurrentRow.Cells["BatchNo"].Value.ToString());
                }
                else
                {
                    DataTable dt =  null;
                    objSourceActivityList.DataSource = dt;

                    dgvActivity.AutoGenerateColumns = false;
                    dgvActivity.DataSource = objSourceActivityList;
                    objSourceActivityList.ResetBindings(true);

                    objBatch = null;
                
                }
                SetColors();

            }
            catch (Exception)
            {

                MessageBox.Show(this, "Error occured while loading Activity List", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



        }


        private void SetColors()
        {
            for (int i = 0; i < dgvActivity.Rows.Count; i++)
            {

                objBatchActivity = objBatchActivity_DL.GetByID(Convert.ToInt32(dgvActivity.Rows[i].Cells["BatchActID"].Value));

                if (objBatchActivity.BatchActStatus == BatchActivity.Status.Finished)
                {
                    dgvActivity.Rows[i].DefaultCellStyle.BackColor = Color.Green;

                }
                else if (objBatchActivity.BatchActStatus == BatchActivity.Status.Start)
                {
                    dgvActivity.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                }
                else
                {
                    dgvActivity.Rows[i].DefaultCellStyle.BackColor = Color.White;
                }


            }

        }



        private void dgvBatcList_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {

            Load_Activity_List();

            if ((dgvBatcList.CurrentRow.IsNewRow == false) && (dgvBatcList.CurrentRow != null))
            {
                objBatch = objBatch_DL.Get(dgvBatcList.CurrentRow.Cells["BatchNo"].Value.ToString());

                lblUnit.Text = objBatch.StandardBatch.STDBatchBasicProduct.BasicProductUnit.UnitCode;

                Load_Material();

                dgvActivity_CellClick(sender, e);

                txtFinalQty.Select();
            }

            }
            catch (Exception)
            {

                MessageBox.Show(this, "Error occured while loading Main Activity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void Load_Material()
        {
            try
            {

                DataTable dtMaterialList = new DataTable();

                if(dgvBatcList.CurrentRow!=null)
                {
               dtMaterialList=  objBatch_DL.Get_BatchMaterial_RequestedState(dgvBatcList.CurrentRow.Cells["BatchNo"].Value.ToString());
                }

              if (dtMaterialList.Rows.Count > 0)
              {

                  objSourceMaterialList.DataSource = dtMaterialList;
                  dgvMaterialList.AutoGenerateColumns = false;
                  dgvMaterialList.DataSource = objSourceMaterialList;
                  objSourceMaterialList.ResetBindings(true);
              }
              else
              {

                  objSourceMaterialList.DataSource = null;
                  dgvMaterialList.AutoGenerateColumns = false;
                  dgvMaterialList.DataSource = objSourceMaterialList;
                  objSourceMaterialList.ResetBindings(true);
              }

            }
            catch (Exception)
            {

                MessageBox.Show(this, "Error occured while loading Materials", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvActivity_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvActivity.CurrentRow.IsNewRow == false)
            {
                try
                {

                   objBatchActivity = objBatchActivity_DL.GetByID(Convert.ToInt32(dgvActivity.CurrentRow.Cells["BatchActID"].Value));


                   objActivity = objMainActivity_DL.Get(Convert.ToInt64(dgvActivity.CurrentRow.Cells["MainActID"].Value));

                   Load_BatchLabourDetails();

                   Load_BatchMachineDetails();

                   SetColors();

                }
                catch (Exception)
                {

                    MessageBox.Show(this, "Error occured while loading Main Activity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            Load_BatchLabourDetails();
            Load_BatchMachineDetails();
        }

      
   


    
        private void Load_BatchLabourDetails()
        {
            try
            {
                if (dgvActivity.Rows.Count > 0)
                {
                    DataTable dt = objBatchLabourDetails_DL.Get_ByBatchActID(Convert.ToInt32(dgvActivity.CurrentRow.Cells["BatchActID"].Value));

                    dgvBatchLabourDetails.AutoGenerateColumns = false;
                    objSourceBatchLabour.DataSource = dt;
                    dgvBatchLabourDetails.DataSource = objSourceBatchLabour;
                    objSourceBatchLabour.ResetBindings(true);
                }
                else
                {
                    DataTable dt = null;

                    dgvBatchLabourDetails.AutoGenerateColumns = false;
                    objSourceBatchLabour.DataSource = dt;
                    dgvBatchLabourDetails.DataSource = objSourceBatchLabour;
                    objSourceBatchLabour.ResetBindings(true);
                }


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
                if (dgvActivity.Rows.Count > 0)
                {
                    DataTable dt = objBatchMachineDetails_DL.Get_ByBatchActID(Convert.ToInt32(dgvActivity.CurrentRow.Cells["BatchActID"].Value));

                    dgvMachineDetails.AutoGenerateColumns = false;
                    objSourceBatchMachine.DataSource = dt;
                    dgvMachineDetails.DataSource = objSourceBatchMachine;
                    objSourceBatchMachine.ResetBindings(true);
                }

                else
                {
                    DataTable dt = null;

                    dgvMachineDetails.AutoGenerateColumns = false;
                    objSourceBatchMachine.DataSource = dt;
                    dgvMachineDetails.DataSource = objSourceBatchMachine;
                    objSourceBatchMachine.ResetBindings(true);

                }

            }
            catch (Exception)
            {

                MessageBox.Show(this, "Error occured while loading Machine Details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

     

        private void btnFinishActivity_Click(object sender, EventArgs e)
        {
          DialogResult theResult=  MessageBox.Show(this, "Have you finish recording all the details of the actitivy", "Confirmation", MessageBoxButtons.YesNo);

          if (theResult == System.Windows.Forms.DialogResult.Yes)
          {
              if (objBatchActivity.BatchActID != 0)
              {
                  frmBatchActivity objForm = new frmBatchActivity(objBatchActivity);
                  objForm.ShowDialog(this);
                  objForm.StartPosition = FormStartPosition.CenterScreen;
              }
              else
              {
                  MessageBox.Show("Please select a Activity");
              }
          }
           
        }

        private void btnFinishBatch_Click(object sender, EventArgs e)
        {
            try
            {

                DialogResult theResult= MessageBox.Show(this, "Do you want to finish the Batch", "Confirmation", MessageBoxButtons.YesNo);

                if (theResult == System.Windows.Forms.DialogResult.Yes)
                {
                    DialogResult theResult1 = MessageBox.Show(this, "Have you properly recorded all the Materials taken into the Batch ? ", "Please Confirm", MessageBoxButtons.YesNo);

                    if (theResult1 == System.Windows.Forms.DialogResult.Yes)
                    {
                        if (txtFinalQty.Text != "")
                        {
                            objBatch.BatchFinalQty = Convert.ToDecimal(txtFinalQty.Text);
                        }
                        objBatch.FinalizedBy = objEmployee_DL.Get(CurrentUser.EmployeeID);
                        objBatch.BatchStatus = Batch.Status.To_Finish;

                        if (objBatch.BatchFinalQty == 0)
                        {
                            MessageBox.Show(this, "Please Enter a Valid Quantity ", "wrong Attempt", MessageBoxButtons.OK);
                        }
                        else
                        {
                            if (objQCReport_DL.Get_IsManufacturingQCPass(objBatch.BatchID, (int)QCReport.ReportStatus.Accept).Rows.Count > 0)
                            {
                                int BasicCount = objBatchFormulaBasicProducts_DL.GetBasicProduct_NotReceived(objBatch.BatchID).Rows.Count;
                                int MatCount = objBatchFormulaMaterial_DL.GetMaterial_NotReceived(objBatch.BatchID).Rows.Count;

                                //if (BasicCount == 0 && MatCount == 0)
                                //{
                                objBatch_DL.Update_Finish_Approve(objBatch,(int)QCReport.ReportStatus.Accept);

                                Load_Batch_List();

                                Load_Activity_List();
                                Load_BatchLabourDetails();
                                Load_BatchMachineDetails();

                                Load_Material();

                                txtFinalQty.Text = "";
                                //}
                                //else
                                //{
                                //    MessageBox.Show(this, "Required Items in the Batch Formula is Not Taken into the Batch", "Missing Items", MessageBoxButtons.OK);
                                //}
                            }
                            else
                            {
                                MessageBox.Show(this, "QC Report is not passed yet", "Quality Checking", MessageBoxButtons.OK);
                            }

                        }
                    }

                }




            }
            catch (Exception)
            {

                MessageBox.Show(this, "Error occured while Saving/Loading Records", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void CheckQCStata()
        {
       

            if (objQCReport_DL.Get_IsManufacturingQCPass(objBatch.BatchID, (int)QCReport.ReportStatus.Accept).Rows.Count > 0)
            {

            }
        }

    }
}
