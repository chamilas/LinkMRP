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

namespace MRP_GUI
{
    public partial class frmBatch_Rework_Approve : System.Windows.Forms.Form
    {
        public frmBatch_Rework_Approve(User objUser)
        {
            InitializeComponent();
            CurrentUser = objUser;
        }

        User CurrentUser = new User();

        BasicProduct_DL objBasicProduct_DL = new BasicProduct_DL(ConnectionStringClass.GetConnection());
        STDBatch_DL objSTDBatch_DL = new STDBatch_DL(ConnectionStringClass.GetConnection());
        Department_DL objDepartment_DL = new Department_DL(ConnectionStringClass.GetConnection());
        Batch_DL objBatch_DL = new Batch_DL(ConnectionStringClass.GetConnection());
        Employee_DL objEmployee_DL = new Employee_DL(ConnectionStringClass.GetConnection());
        BatchFormulaMaterial_DL objBatchFormulaMaterial_DL = new BatchFormulaMaterial_DL(ConnectionStringClass.GetConnection());
        BatchActivity_DL objBatchActivity_DL = new BatchActivity_DL(ConnectionStringClass.GetConnection());
        FinishProduct_DL objFinishProduct_DL = new FinishProduct_DL(ConnectionStringClass.GetConnection());

        BasicProduct objBasicProduct = new BasicProduct();
        string BatchID = "";

        DataTable dtStartProduct = new DataTable();
        DataTable dtEndProduct = new DataTable();
        DataTable dtBatchList = new DataTable();

        Batch objBatch = new Batch();
        
        private void frmBatchPlan_Load(object sender, EventArgs e)
        {

            try

            {

                Load_BatchList();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());

            }

        }






        private void Load_BatchList()
        {
            try
            {
                dtBatchList = objBatch_DL.Get_DataView_ReworkBatchList((int)Batch.Status.Rework, "Rework", "Repack");

                objSourceBatchList.DataSource = dtBatchList;
                cmbBatch.DataSource = objSourceBatchList;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());

            }
        }

        private void cmbEndProduct_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {

            BatchActivity obj = new BatchActivity();


            objBatchActivity_DL.Add_Packing_Rework(BatchID, (int)BatchActivity.Status.Start, cmbStartProduct.SelectedValue.ToString(), cmbEndProduct.SelectedValue.ToString(), Convert.ToDecimal(txtStartQty.Text), CurrentUser.EmployeeID, "Normal");


            Load_BatchActivity();

            Load_BatchList();
        }


        private void Load_Products()
        {
            try
            {
                dtStartProduct=objFinishProduct_DL.GetDataView(objBasicProduct.BasicProductCode);

                objSourceFinishProductStart.DataSource = dtStartProduct;
                cmbStartProduct.DataSource = objSourceFinishProductStart;


                dtEndProduct = objFinishProduct_DL.GetDataView(objBasicProduct.BasicProductCode);

                objSourceFinishProductStop.DataSource = dtEndProduct;
                cmbEndProduct.DataSource = objSourceFinishProductStop;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());

            }
        }
        private void Load_BatchActivity()
        {
            try
            {
                if (cmbBatch.SelectedValue != null)
                {
                    DataTable dt = new DataTable();

                    dt = objBatchActivity_DL.GetView(cmbBatch.SelectedValue.ToString());

                    dgvBatchActivity.AutoGenerateColumns = false;
                    objSourceBatchActivity.DataSource = dt;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());

            }
        }

        private void cmbBatch_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbBatch.SelectedValue != null)
                {
                    objBatch = objBatch_DL.Get(cmbBatch.SelectedValue.ToString());
                    BatchID = objBatch.BatchID;

                   objBasicProduct=objBasicProduct_DL.Get(objBatch_DL.Get_BasicProduct_Rework(objBatch.BatchID));


                    Load_Products();

                    Load_BatchActivity();

                }
                else
                {
                    dgvBatchActivity.AutoGenerateColumns = false;
                    objSourceBatchActivity.DataSource = null;
                    dgvBatchActivity.DataSource = objSourceBatchActivity;
                    objSourceBatchActivity.ResetBindings(true);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());

            }
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            try
            {

                objBatch.InitiatedBy =CurrentUser.EmployeeID;
                objBatch.BatchStatus= Batch.Status.In_Progress;


                objBatch_DL.Update_Initiate_Direct(objBatch);

                Load_BatchList();

                if (dtBatchList.Rows.Count > 0)
                {
                    cmbBatch_SelectedIndexChanged(sender, e);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());

            }
        }

    }
}
