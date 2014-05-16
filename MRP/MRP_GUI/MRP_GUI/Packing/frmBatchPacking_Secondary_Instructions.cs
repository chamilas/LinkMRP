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
    public partial class frmBatchPacking_Secondary_Instructions : System.Windows.Forms.Form
    {

        User CurrentUser = new User();

        public frmBatchPacking_Secondary_Instructions(User objUser)
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

            objActivity = objMainActivity_DL.GetByName("Packing_Secondary");

            txtActivity.Text = objActivity.MainActivityTitle;

        }

        private void Load_Activity()
        {
            try
            {
                
                    DataTable dt = objBatchActivity_DL.GetView_Packing(dgvActivity.CurrentRow.Cells["BatchNo"].Value.ToString());

                    objSourceActivityList.DataSource = dt;
                    dgvActivity.AutoGenerateColumns = false;
                    dgvActivity.DataSource = objSourceActivityList;
                    objSourceActivityList.ResetBindings(true);

                
                SetColors();
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

        private void Load_Batch_List()
        {
            try
            {

                DataTable dt = objBatch_DL.Get_DataView_Packing_Secondary_Instructions(BatchActivity.Status.Finished,BatchActivity.Status.SecondaryPacking, CurrentUser.UserID);
                objSourceBatchList.DataSource = dt;

                dgvBatchList.AutoGenerateColumns = false;
                dgvBatchList.DataSource = objSourceBatchList;
                objSourceBatchList.ResetBindings(true);


            }
            catch (Exception)
            {

                MessageBox.Show(this, "Error occured while loading Batch List", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

     

       
       

  

   
      

        private void btnStartPacking_Click(object sender, EventArgs e)
        {
            if (DataValidation.Is3DecimalPointNumber(txtPackingQty.Text))
            {
                try
                {
                    DialogResult dr = MessageBox.Show(this, "Do you want to add a new Packing Batch to " + objBatch.BatchID + "from  " + cmbFinishedProduct.SelectedValue.ToString(), "Confirmation", MessageBoxButtons.YesNo);
                    long i;

                    if (dr == DialogResult.Yes)
                    {
                        if (Convert.ToDecimal(dgvBatchList.CurrentRow.Cells["Remaining"].Value) > 0)
                        {
                            string ActMethod = "";
                            if (chkOutsource.Checked == true)
                            {
                                ActMethod = "Outsource";
                            }
                            else
                            {
                                ActMethod = "Normal";
                            }
                            i = objBatchActivity_DL.Add_Packing_Secondary(objBatch.BatchID, Convert.ToInt32(Batch.Status.Packing), (int)BatchActivity.Status.Finished,
                                (int)BatchActivity.Status.SecondaryPacking, dgvBatchList.CurrentRow.Cells["OutputProduct"].Value.ToString(), cmbFinishedProduct.SelectedValue.ToString()
                                , Convert.ToDecimal(txtPackingQty.Text), CurrentUser.EmployeeID, ActMethod, Convert.ToInt32(dgvBatchList.CurrentRow.Cells["pBatchActID"].Value));


                            if (i == 0)
                            {
                                MessageBox.Show(this, "Quantity you are trying to packing is not a realistic Value", "Wrong Attempt", MessageBoxButtons.OK);
                            }
                            else
                            {
                                Load_SecondaryActivityList();
                                Load_Batch_List();

                            }
                        }
                        else
                        {
                            MessageBox.Show(this, "Invalid Qty", "Wrong Attempt", MessageBoxButtons.OK);
                        }

                    }


                    txtPackingQty.Text = "";
                    cmbFinishedProduct.Select();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
            else
            {
                MessageBox.Show(this, "please enter valid quantity", "MRP System", MessageBoxButtons.OK);
            }
        }

        private void dgvActivity_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {

            objBatchActivity = objBatchActivity_DL.GetByID(Convert.ToInt32(dgvActivity.CurrentRow.Cells["BatchActID"].Value));


            if (objBatchActivity.BatchActStatus == BatchActivity.Status.Finished)
            {
             
                btnStartPacking.Enabled = false;

            }
            else if (objBatchActivity.BatchActStatus == BatchActivity.Status.Initial)
            {
               
                btnStartPacking.Enabled = false;
            }
            else
            {
         
                btnStartPacking.Enabled = false;
            }

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

                    frmBatchActivity_Packing objForm = new frmBatchActivity_Packing(objBatchActivity);
                    objForm.ShowDialog(this);

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

        private void txtPackingQty_Click(object sender, EventArgs e)
        {
            btnStartPacking.Enabled = true;
        }

        private void dgvBatchList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Load_SecondaryProductList();

            Load_SecondaryActivityList();

            Load_TransferredList();

        }

        private void Load_TransferredList()
        {
            try
            {
                objBatch = objBatch_DL.Get(dgvBatchList.CurrentRow.Cells["BatchID"].Value.ToString());

                DataTable dt = objBatch_DL.GetTransferred_AsPrimary(dgvBatchList.CurrentRow.Cells["BatchID"].Value.ToString(), dgvBatchList.CurrentRow.Cells["OutputProduct"].Value.ToString(), Convert.ToInt32(dgvBatchList.CurrentRow.Cells["pBatchActID"].Value));

                dgvTransferred.AutoGenerateColumns = false;
                objSourceTransferredList.DataSource = dt;
                dgvTransferred.DataSource = objSourceTransferredList;
                objSourceTransferredList.ResetBindings(true);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }



        private void Load_SecondaryProductList()
        {
            try
            {
                objBatch = objBatch_DL.Get(dgvBatchList.CurrentRow.Cells["BatchID"].Value.ToString());
                txtBatchID.Text = objBatch.BatchID;

                DataTable dt=objFinishProduct_DL.Get_SecondaryProductList(dgvBatchList.CurrentRow.Cells["OutputProduct"].Value.ToString());

                objSourceSecondaryProduct.DataSource = dt;
                cmbFinishedProduct.DataSource = objSourceSecondaryProduct;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }



        private void Load_SecondaryActivityList()
        {
            try
            {

                DataTable dt = objBatchActivity_DL.GetView_Packing_Secondary(objBatch.BatchID, Convert.ToInt32(dgvBatchList.CurrentRow.Cells["pBatchActID"].Value));

                dgvActivity.AutoGenerateColumns = false;
                objSourceSecondaryActivityList.DataSource = dt;
                dgvActivity.DataSource = objSourceSecondaryActivityList;
                objSourceSecondaryActivityList.ResetBindings(true);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

       

    }
}
