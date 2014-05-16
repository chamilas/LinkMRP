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
    public partial class frmBatchSendQC : System.Windows.Forms.Form
    {

        User CurrentUser = new User();


        public frmBatchSendQC(User objUser)
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
        QCReport_DL objQCReport_DL = new QCReport_DL(ConnectionStringClass.GetConnection());

        Batch objBatch = new Batch();
        BatchActivity objBatchActivity = new BatchActivity();
        MainActivity objActivity = new MainActivity();
        QCReport objQCReport = new QCReport();

        DataTable dtBatchList = new DataTable();

        private void frmBatchList_Load(object sender, EventArgs e)
        {

            Load_Batch_List();
        }

        private void Load_Batch_List()
        {
            try
            {

                dtBatchList = objBatch_DL.Get_Batch_ToSendQC(CurrentUser.UserID,(int)Batch.Status.In_Progress);

                if (dtBatchList.Rows.Count > 0)
                {
                    objSourceBatchList.DataSource = dtBatchList;
                    dgvBatcList.AutoGenerateColumns = false;
                    dgvBatcList.DataSource = objSourceBatchList;
                    objSourceBatchList.ResetBindings(true);
                }
                else
                {
                    objSourceBatchList.DataSource = null;
                    dgvBatcList.AutoGenerateColumns = false;
                    dgvBatcList.DataSource = objSourceBatchList;
                    objSourceBatchList.ResetBindings(true);
                }


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
                if (dtBatchList.Rows.Count > 0)
                {
                    if ((dgvBatcList.CurrentRow.Cells["BatchNo"].Value != null) && (dgvBatcList.CurrentRow.IsNewRow == false))
                    {
                        DataTable dt = objBatchActivity_DL.GetView(dgvBatcList.CurrentRow.Cells["BatchNo"].Value.ToString());

                        objSourceActivityList.DataSource = dt;
                        dgvActivity.AutoGenerateColumns = false;
                        dgvActivity.DataSource = objSourceActivityList;
                        objSourceActivityList.ResetBindings(true);

                        objBatch = objBatch_DL.Get(dgvBatcList.CurrentRow.Cells["BatchNo"].Value.ToString());
                    }
                }
                else
                {
                    objSourceActivityList.DataSource = null;
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

                dgvActivity_CellClick(sender, e);
            }

            }
            catch (Exception)
            {

                MessageBox.Show(this, "Error occured while loading Main Activity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                if (dtBatchList.Rows.Count > 0)
                {
                    DataTable dt = objBatchLabourDetails_DL.Get_ByBatchActID(Convert.ToInt32(dgvActivity.CurrentRow.Cells["BatchActID"].Value));

                    if (dt.Rows.Count > 0)
                    {
                        dgvBatchLabourDetails.AutoGenerateColumns = false;
                        objSourceBatchLabour.DataSource = dt;
                        dgvBatchLabourDetails.DataSource = objSourceBatchLabour;
                        objSourceBatchLabour.ResetBindings(true);
                    }
                    else
                    {
                        dgvBatchLabourDetails.AutoGenerateColumns = false;
                        objSourceBatchLabour.DataSource = null;
                        dgvBatchLabourDetails.DataSource = objSourceBatchLabour;
                        objSourceBatchLabour.ResetBindings(true);
                    }
                }
                else
                {
                    dgvBatchLabourDetails.AutoGenerateColumns = false;
                    objSourceBatchLabour.DataSource = null;
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
                if (dtBatchList.Rows.Count > 0)
                {
                    DataTable dt = objBatchMachineDetails_DL.Get_ByBatchActID(Convert.ToInt32(dgvActivity.CurrentRow.Cells["BatchActID"].Value));

                    if (dt.Rows.Count > 0)
                    {
                        dgvMachineDetails.AutoGenerateColumns = false;
                        objSourceBatchMachine.DataSource = dt;
                        dgvMachineDetails.DataSource = objSourceBatchMachine;
                        objSourceBatchMachine.ResetBindings(true);
                    }
                    else
                    {
                        dgvMachineDetails.AutoGenerateColumns = false;
                        objSourceBatchMachine.DataSource = null;
                        dgvMachineDetails.DataSource = objSourceBatchMachine;
                        objSourceBatchMachine.ResetBindings(true);
                    }
                }
                else
                {
                    dgvMachineDetails.AutoGenerateColumns = false;
                    objSourceBatchMachine.DataSource = null;
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

        private void dgvBatcList_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnFinishBatch_Click(object sender, EventArgs e)
        {

            DialogResult thResult = MessageBox.Show(this, "Do you want to Send this file to QC", "Confirmation", MessageBoxButtons.YesNo);

            if (thResult == System.Windows.Forms.DialogResult.Yes)
            {

                try
                {

                    objBatch.BatchStatus = Batch.Status.QC;

                    objQCReport.ProductionBatchID = objBatch.BatchID;
                    objQCReport.SampleSize = "0";
                    objQCReport.SendBy = CurrentUser.EmployeeID;
                    objQCReport.Status = Convert.ToInt32(QCReport.ReportStatus.Initial);
                    objQCReport.SpecificGravity = 1;
                    objQCReport.Remarks = "No";
                   
                    objQCReport_DL.Add_Production(objQCReport);

                    objBatch_DL.Update_QCStatus(objBatch.BatchID, CurrentUser.EmployeeID, Batch.Status.QC);

                    Load_Batch_List();

                    Load_Activity_List();
                    Load_BatchLabourDetails();
                    Load_BatchMachineDetails();


                }
                catch (Exception)
                {

                    MessageBox.Show(this, "Error occured while loading Machine Details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }


    }
}
