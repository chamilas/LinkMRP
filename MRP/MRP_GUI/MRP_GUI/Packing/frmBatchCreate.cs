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
using MRP_GUI.Sales;

namespace MRP_GUI
{
    public partial class frmBatchCreate : System.Windows.Forms.Form
    {
        public frmBatchCreate(User objUser)
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


        Batch obj = new Batch();

        DataTable dtCategoryList = new DataTable();
        DataTable dtBasicProductList = new DataTable();
        DataTable dtSTDBatchList = new DataTable();
        DataTable dtBatchPlanWeekly = new DataTable();
        
        int WeekID = 0;
        int MonthlyPlanningID = 0;
        int WeekCount = 0;
        
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


                txtBatchSize.Select();
                
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
            if (DataValidation.Is3DecimalPointNumber(txtBatchSize.Text))
            {
                try
                {


                    string Prefix = "";
                    bool isPrefixed = false;

                    if (chkPrefix.Checked == true)
                    {
                        if (txtPrefix.Text != "")
                        {
                            isPrefixed = true;
                            Prefix = txtPrefix.Text;
                        }
                        else
                        {
                            MessageBox.Show("No Prefix");
                            isPrefixed = false;
                        }

                    }


                    obj.BatchDivideCount = 1;
                    obj.BatchGenerateBy = objEmployee_DL.Get(CurrentUser.EmployeeID);
                    obj.BatchStatus = Batch.Status.Initial;
                    obj.BatchType = "Basic";
                    obj.StandardBatch = objSTDBatch_DL.Get(cmbBatchSize.SelectedValue.ToString());

                    if (txtBatchSize.Text != "")
                    {
                        obj.BatchSize = Convert.ToDecimal(txtBatchSize.Text);
                    }

                    if (obj.BatchSize == 0)
                    {
                        MessageBox.Show(this, "Please Enter a Valid Quantity ", "wrong Attempt", MessageBoxButtons.OK);
                    }
                    else
                    {
                        obj.BatchID = objBatch_DL.Add(obj, Prefix, isPrefixed);


                        MessageBox.Show(this, "Successfully Created Batch : " + obj.BatchID, "Successful", MessageBoxButtons.OK);

                        Load_Data();


                    }

                    btnCreate.Visible = false;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
            else
            {
                MessageBox.Show(this, "Please Enter Valid Batch Size", "MRP System", MessageBoxButtons.OK);
            }
        }


        private void Load_Data()
        {
            try
            {
                if (obj.BatchID != "")
                {
                    DataTable dtBatchFormula = new DataTable();


                    dtBatchFormula = objBatchFormulaMaterial_DL.GetView(obj.BatchID);

                    dgvBatchFormula.AutoGenerateColumns = false;
                    objSourceFormula.DataSource = dtBatchFormula;
                    dgvBatchFormula.DataSource = objSourceFormula;
                    objSourceFormula.ResetBindings(true);
                }
            
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
                dtSTDBatchList = objSTDBatch_DL.Get_Data_ByProduct(lstBasicProductList.SelectedValue.ToString());

                objSourceSTDBatches.DataSource = dtSTDBatchList;
                cmbBatchSize.DataSource = objSourceSTDBatches;

               cmbBatchSize_SelectedIndexChanged(sender, e);


                DataTable  dtBatchFormula = null;

               dgvBatchFormula.AutoGenerateColumns = false;
               objSourceFormula.DataSource = dtBatchFormula;
               dgvBatchFormula.DataSource = objSourceFormula;
               objSourceFormula.ResetBindings(true);

                dgPreviousBatch.AutoGenerateColumns = false;
                bsPreviousBatch.DataSource=objBatch_DL.GetPreviousBatchDetails(lstBasicProductList.SelectedValue.ToString());
                dgPreviousBatch.DataSource = bsPreviousBatch;
                bsPreviousBatch.ResetBindings(true);             
                
                btnCreate.Visible = true;
               txtBatchSize.Text = "";
               txtBatchSize.Select();
               txtPrefix.Text = "";
               chkPrefix.Checked = false;
               
            }

            cmbBatchSize.Select();
        }

        private void cmbBatchSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            //txtBatchSize.Text = cmbBatchSize.Text;
        }

        private void cmbBatchSize_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                txtBatchSize.Select();
            }
        }

        private void chkPrefix_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPrefix.Checked == true)
            {
                txtPrefix.ReadOnly = false;
            }
            else
            {
                txtPrefix.ReadOnly = true;

            }
        }

    }
}
