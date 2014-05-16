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
    public partial class frmBatchSendQC_Packing : System.Windows.Forms.Form
    {

        User CurrentUser = new User();

        public frmBatchSendQC_Packing(User objUser)
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

                DataTable dt = objBatch_DL.Get_DataView(Batch.Status.Packing, CurrentUser.UserID);
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

                    DataTable dt = objBatchActivity_DL.GetView_Packing(dgvBatcList.CurrentRow.Cells["BatchNo"].Value.ToString());

                    objSourceActivityList.DataSource = dt;
                    dgvActivity.AutoGenerateColumns = false;
                    dgvActivity.DataSource = objSourceActivityList;
                    objSourceActivityList.ResetBindings(true);


                }


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
                    Load_ReportList();

                    SetColors();

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

            objBatchActivity = objBatchActivity_DL.GetByID(Convert.ToInt32(dgvActivity.CurrentRow.Cells["BatchActID"].Value));

            Load_BatchLabourDetails();
            Load_BatchMachineDetails();

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

        private void btnSendQC_Click(object sender, EventArgs e)
        {
            if (DataValidation.IsNumericNumber(txtSampleQty.Text))
            {
                try
                {

                    objBatch.BatchStatus = Batch.Status.QC;

                    QCReport objQCReport = new QCReport();

                    objQCReport.PackingBatchID = objBatch.BatchID;
                    objQCReport.SampleSize = cmbSample.Text;
                    objQCReport.SendBy = CurrentUser.EmployeeID;
                    objQCReport.Status = Convert.ToInt32(QCReport.ReportStatus.Initial);
                    objQCReport.SpecificGravity = 1;
                    objQCReport.Remarks = "No";
                    objQCReport.SpecificGravity = Convert.ToInt32(txtSampleQty.Text);

                    objQCReport_DL.Add_Packing(objQCReport);


                    Load_ReportList();

                }
                catch (Exception)
                {

                    MessageBox.Show(this, "Error occured while Saving Report Details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else 
            {
                MessageBox.Show(this, "please enter valid sample quantity", "MRP System", MessageBoxButtons.OK);
            }
        }


        private void Load_ReportList()
        {
            try
            {
               DataTable dtQc= objQCReport_DL.GetView_PackingQC(objBatch.BatchID);

                dgvQCReports.AutoGenerateColumns = false;
                objSourceQCReports.DataSource = dtQc;
                dgvQCReports.DataSource=objSourceQCReports;
                objSourceQCReports.ResetBindings(true);

                
            }
            catch (Exception)
            {

                MessageBox.Show(this, "Error occured while loading Machine Details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


    }
}
