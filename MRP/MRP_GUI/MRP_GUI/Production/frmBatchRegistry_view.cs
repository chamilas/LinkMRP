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
    public partial class frmBatchRegistry_View : System.Windows.Forms.Form
    {

        User CurrentUser = new User();


        public frmBatchRegistry_View(User objUser,string _BatchID)
        {
            InitializeComponent();
            CurrentUser = objUser;
            BatchID = _BatchID;
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

        Batch objBatch = new Batch();
        BatchActivity objBatchActivity = new BatchActivity();
        MainActivity objActivity = new MainActivity();

        String BatchID = "";

        private void frmBatchList_Load(object sender, EventArgs e)
        {

            try
            {
                txtBatchID.Text = BatchID;

                objBatch = objBatch_DL.Get(txtBatchID.Text);

                txtBatchSize.Text = objBatch.BatchSize.ToString();
                txtBatchState.Text = objBatch.BatchStatus.ToString();
                txtFinalQty.Text = objBatch.BatchFinalQty.ToString();


                Load_Activity_List();

                Load_BatchLabourDetails();
                Load_BatchMachineDetails();

                Load_Material_List("Raw");


            }
            catch (Exception)
            {

                MessageBox.Show(this, "Error occured while loading Activity List", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        private void Load_Activity_List()
        {
            try
            {
                if (objBatch.BatchID!="")
                {
                    DataTable dt = objBatchActivity_DL.GetView(objBatch.BatchID);
                    objSourceActivityList.DataSource = dt;

                    dgvActivity.AutoGenerateColumns = false;
                    dgvActivity.DataSource = objSourceActivityList;
                    objSourceActivityList.ResetBindings(true);

                }
                else
                {
                    DataTable dt =  null;
                    objSourceActivityList.DataSource = dt;

                    dgvActivity.AutoGenerateColumns = false;
                    dgvActivity.DataSource = objSourceActivityList;
                    objSourceActivityList.ResetBindings(true);

                
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

                if (objBatchActivity.ActType == "Manufacturing")
                {
                    dgvActivity.Rows[i].DefaultCellStyle.BackColor = Color.LightGreen;

                }
                else
                {
                    dgvActivity.Rows[i].DefaultCellStyle.BackColor = Color.RosyBrown;
                }


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

                //DialogResult theResult= MessageBox.Show(this, "Do you want to finish the Batch", "Confirmation", MessageBoxButtons.YesNo);

                //if (theResult == System.Windows.Forms.DialogResult.Yes)
                //{
                //    if (txtFinalQty.Text != "")
                //    {
                //        objBatch.BatchFinalQty = Convert.ToDecimal(txtFinalQty.Text);
                //    }
                //    objBatch.FinalizedBy = objEmployee_DL.Get(CurrentUser.EmployeeID);
                //    objBatch.BatchStatus = Batch.Status.Finished;

                //    if (objBatch.BatchFinalQty == 0)
                //    {
                //        MessageBox.Show(this, "Please Enter a Valid Quantity ", "wrong Attempt", MessageBoxButtons.OK);
                //    }
                //    else
                //    {

                //       int BasicCount= objBatchFormulaBasicProducts_DL.GetBasicProduct_NotReceived(objBatch.BatchID).Rows.Count;
                //       int MatCount = objBatchFormulaMaterial_DL.GetMaterial_NotReceived(objBatch.BatchID).Rows.Count;

                //       if (BasicCount == 0 && MatCount == 0)
                //       {
                //           objBatch_DL.Update_Finish(objBatch,(int)QCReport.ReportStatus.Accept);

                //           Load_Activity_List();
                //           Load_BatchLabourDetails();
                //           Load_BatchMachineDetails();

                //           txtFinalQty.Text = "";
                //       }
                //       else
                //       {
                //           MessageBox.Show(this, "Required Items in the Batch Formula is Not Taken into the Batch", "Missing Items", MessageBoxButtons.OK);
                //       }

                //    }

                //}




            }
            catch (Exception)
            {

                MessageBox.Show(this, "Error occured while loading Machine Details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }


        private void txtBatchID_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void Load_Material_List(string MatCatID)
        {
            try
            {

                DataTable dt = objBatch_DL.GetBatchMRMaterial(objBatch.BatchID, MatCatID);

                dgvMTItems.AutoGenerateColumns = false;
                objSourceItemLsit.DataSource = dt;
                dgvMTItems.DataSource = objSourceItemLsit;
                objSourceItemLsit.ResetBindings(true);
               
            }
            catch (Exception)
            {

                MessageBox.Show(this, "Error occured while loading Machine Details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void Load_Material_Packing_List()
        {
            try
            {

                DataTable dt = objBatch_DL.GetBatchMRPacking(objBatch.BatchID);

                dgvMTItems.AutoGenerateColumns = false;
                objSourceItemLsit.DataSource = dt;
                dgvMTItems.DataSource = objSourceItemLsit;
                objSourceItemLsit.ResetBindings(true);

            }
            catch (Exception)
            {

                MessageBox.Show(this, "Error occured while loading Machine Details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

          private void Load_Semi_List()
        {
            try
            {

                DataTable dt = objBatch_DL.GetBatchMRSemi(objBatch.BatchID);

                dgvMTItems.AutoGenerateColumns = false;
                objSourceItemLsit.DataSource = dt;
                dgvMTItems.DataSource = objSourceItemLsit;
                objSourceItemLsit.ResetBindings(true);
               
            }
            catch (Exception)
            {

                MessageBox.Show(this, "Error occured while loading Machine Details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        

        private void chkRaw_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRaw.Checked == true)
            {
                chkSemi.Checked = false;
                chkPacking.Checked = false;

                Load_Material_List("Raw");


            }

        }

        private void chkSemi_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSemi.Checked == true)
            {
                chkRaw.Checked = false;
                chkPacking.Checked = false;

                Load_Semi_List();


            }
        }

        private void chkPacking_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPacking.Checked == true)
            {
                chkSemi.Checked = false;
                chkRaw.Checked = false;

                Load_Material_Packing_List();


            }
        }


    }
}
