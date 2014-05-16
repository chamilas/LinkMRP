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
    public partial class frmBatchPlanExclusive : System.Windows.Forms.Form
    {
        public frmBatchPlanExclusive(User objUser)
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


        string BatchID = "";

        DataTable dtCategoryList = new DataTable();
        DataTable dtBasicProductList = new DataTable();
        DataTable dtSTDBatchList = new DataTable();
        DataTable dtBatchPlanWeekly = new DataTable();

        private void frmBatchPlan_Load(object sender, EventArgs e)
        {

            try
            {

                ProductSubCategory_DL objProductSubCategory_DL = new ProductSubCategory_DL(ConnectionStringClass.GetConnection());

                dtCategoryList = objProductSubCategory_DL.GetDataView();

                //dtCategoryList=objBasicProduct_DL.GetDataView_By_Category(lstBasicProductList.SelectedValue.ToString());


                if (dtCategoryList.Rows.Count != 0)
                {
                    objSourceCategoryList.DataSource = dtCategoryList;
                    cmbCategoryList.DataSource = objSourceCategoryList;
                }

                //cmbCategoryList_SelectedIndexChanged(sender, e);


                txtBatchNo.Select();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());

            }
        }

       


        private void cmbCategoryList_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                

                if (cmbCategoryList.SelectedValue != null)
                {
                    lstBasicProductList_SelectedIndexChanged(sender, e);

                    dtBasicProductList = objBasicProduct_DL.GetDataView_Category(true,Convert.ToString(cmbCategoryList.SelectedValue));
                }

               if (dtBasicProductList.Rows.Count != 0)
               {
                   objSourceBasicProductList.DataSource = dtBasicProductList;
                   lstBasicProductList.DataSource = objSourceBasicProductList;

               }


               btnCreate.Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());

            }



            
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string BatchType = "";

                if (rdbRepack.Checked == true)
                {
                    BatchType = "Repack";
                }
                else if (rdbRework.Checked == true)
                {
                    BatchType = "Rework";
                }

                    objBatch_DL.Add_Re(txtBatch.Text+txtBatchNo.Text,txtParentBatches.Text,0,CurrentUser.EmployeeID,(int)Batch.Status.Rework,BatchType);

                    BatchID = txtBatch.Text + txtBatchNo.Text;

                    MessageBox.Show(this, "Successfully Created Batch ", "Successful", MessageBoxButtons.OK);

                btnCreate.Visible = false;
                pnlBatchActivity.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());

            }
        }

        private void lstBasicProductList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstBasicProductList.SelectedValue != null)
            {

               btnCreate.Visible = true;
               txtBatchSize.Text = "0";
               txtBatchNo.Select();
               txtBatch.Text = lstBasicProductList.SelectedValue.ToString()+"-";

               Load_ProductList();

            }

        }

        private void Load_ProductList()
        {
            try
            {
                if (lstBasicProductList.SelectedValue != null)
                {
                    FinishProduct_DL objFinishProduct_DL = new FinishProduct_DL(ConnectionStringClass.GetConnection());

                    DataTable dtStart = objFinishProduct_DL.GetDataView(lstBasicProductList.SelectedValue.ToString());
                    DataTable dtStop = objFinishProduct_DL.GetDataView(lstBasicProductList.SelectedValue.ToString());

                    objSourceFinishProductStart.DataSource = dtStart;
                    objSourceFinishProductStop.DataSource = dtStop;

                    cmbStartProduct.DataSource = objSourceFinishProductStart;
                    cmbEndProduct.DataSource = objSourceFinishProductStop;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());

            }
        }

        private void cmbBatchSize_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                txtBatchSize.Select();
            }
        }


        private void rdbRepack_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbRepack.Checked == true)
            {
                txtBatchNo.Visible = true;
            }
        }


        private void rdbRework_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbRework.Checked == true)
            {
                txtBatchNo.Visible = true;
            }
        }


        private void Load_BatchList()
        {
            try
            {


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

        }

        private void Load_BatchActivity()
        {
            try
            {
                DataTable dt = new DataTable();

                dt=objBatchActivity_DL.GetView(BatchID);

                dgvBatchActivity.AutoGenerateColumns = false;
                objSourceBatchActivity.DataSource = dt;



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());

            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
