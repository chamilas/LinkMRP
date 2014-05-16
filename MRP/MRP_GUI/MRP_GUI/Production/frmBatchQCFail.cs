using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DL;
using SESD.MRP.REF;
using MRP_GUI.Production;

namespace MRP_GUI
{
    public partial class frmBatchQCFail : System.Windows.Forms.Form
    {
        private User _objCurrentUser;

        public User CurrentUser
        {
            get { return _objCurrentUser; }
            set { _objCurrentUser = value; }
        }

        public frmBatchQCFail()
        {
            InitializeComponent();
        }

        public frmBatchQCFail(User objUser)
        {
            InitializeComponent();
            CurrentUser = objUser;
        }

        ProductCategory_DL objProductCatergoryDL = new ProductCategory_DL(ConnectionStringClass.GetConnection());
        FinishProduct_DL objFinishProductDL = new FinishProduct_DL(ConnectionStringClass.GetConnection());
        BasicProduct_DL objBasicProductDL = new BasicProduct_DL(ConnectionStringClass.GetConnection());
        STDBatch_DL objSTDBatchDL = new STDBatch_DL(ConnectionStringClass.GetConnection());
        ProductSubCategory_DL objProductSubCatDL = new ProductSubCategory_DL(ConnectionStringClass.GetConnection());
        BatchProductionCollec objBatchProductCollec = new BatchProductionCollec();
        DataTable dt = new DataTable();
        Formula_DL objFormulaDL = new Formula_DL(ConnectionStringClass.GetConnection());
        Batch objBatch = new Batch();
        Batch_DL objBatchDL = new Batch_DL(ConnectionStringClass.GetConnection());
        BatchActivity_DL objBatchActivity_DL = new BatchActivity_DL(ConnectionStringClass.GetConnection());
        BatchFormulaMaterial_DL objBatchFormulaMaterial_DL = new BatchFormulaMaterial_DL(ConnectionStringClass.GetConnection());
        MainActivity_DL objMainActivity_DL = new MainActivity_DL(ConnectionStringClass.GetConnection());


        DataTable dtFormulaMaterials = new DataTable();
        DataTable dtBatchList = new DataTable();


        public void LoadBatches(Batch.Status Status)
        {
            try
            {


                dtBatchList = objBatchDL.Get_DataView(Status, CurrentUser.UserID);

                if (dtBatchList.Rows.Count > 0)
                {
                    gvBatchList.AutoGenerateColumns = false;
                    bindBatch.DataSource = dtBatchList;
                    gvBatchList.DataSource = bindBatch;
                    bindBatch.ResetBindings(true);
                }
                else
                {
                    
                    gvBatchList.AutoGenerateColumns = false;
                    bindBatch.DataSource = null;
                    gvBatchList.DataSource = bindBatch;
                    bindBatch.ResetBindings(true);

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmBatchApproving_Load(object sender, EventArgs e)
        {
            Clear();
            LoadBatches(Batch.Status.QCFail);
            //btnApprove.Enabled = true;

            Load_Activity();
        }

        private void Load_Activity()
        {
            try
            {
                DataTable dt = new DataTable();
                
                dt = objMainActivity_DL.Get_Data_View();
                objsourceActivity.DataSource = dt;

                cmbActivity.DataSource = objsourceActivity;

            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gvBatchList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            objBatch = objBatchDL.Get(gvBatchList.Rows[e.RowIndex].Cells["ColBatchNo"].Value.ToString());

            Load_Details();
        }

        private void Load_Details()
        {
            try
            {

                dtFormulaMaterials = objBatchFormulaMaterial_DL.GetView(objBatch.BatchID);

                txtBatchNo.Text = objBatch.BatchID;
                txtBatchSize.Text = objBatch.BatchSize.ToString();
                txtProduct.Text = objBatch.StandardBatch.STDBatchBasicProduct.Code;
                bindActivityList.DataSource = objBatchActivity_DL.GetView(objBatch.BatchID);
                lblUnit1.Text = objBatch.StandardBatch.STDBatchBasicProduct.BasicProductUnit.UnitCode;


                if (dtFormulaMaterials.Rows.Count > 0)
                {
                    dgvFormulaMaterial.AutoGenerateColumns = false;
                    objSourceFormulaMaterials.DataSource = dtFormulaMaterials;
                    dgvFormulaMaterial.DataSource = objSourceFormulaMaterials;
                    objSourceFormulaMaterials.ResetBindings(true);
                }
                else
                {
                    dgvFormulaMaterial.AutoGenerateColumns = false;
                    objSourceFormulaMaterials.DataSource = null;
                    dgvFormulaMaterial.DataSource = objSourceFormulaMaterials;
                    objSourceFormulaMaterials.ResetBindings(true);
                }



            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnApprove_Click(object sender, EventArgs e)
        {
            try
            {
                MainActivity_DL objMainActivity_DL = new MainActivity_DL(ConnectionStringClass.GetConnection());
                DialogResult dr = MessageBox.Show(this,"Do you want to Approve Selected Batch?\n\nClick Yes to Approve","Are you sure?",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.Yes)
                {
                    objBatch.BatchApprovedBy = CurrentUser.UserEmp;
                    objBatch.BatchStatus = Batch.Status.Approved;
                    int x = objBatchDL.Update_Approve(objBatch);
                    if (x > 0)
                    {
                        BatchActivity objWeigh = new BatchActivity();
                        MainActivity objMainAct = objMainActivity_DL.GetByName("Weighing");
                        objWeigh.Batch = objBatch;
                        objWeigh.BatchActStatus = BatchActivity.Status.Initial;
                        objWeigh.BlockNextActivity = false;
                        objWeigh.SequenceNo = -1;
                        objWeigh.Part = "N/A";
                        objWeigh.MainActivity = objMainAct;
                        objWeigh.LastEdited = DateTime.Now;
                        objWeigh.ActType = "Manufacturing";
                        objWeigh.ActMethod = "Normal";

                        objBatchActivity_DL.Add(objWeigh);


                        Clear();

                        LoadBatches(Batch.Status.Initial);

                        objBatch = new Batch();


                    }                 
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Clear()
        {
            bindActivityList.DataSource = null;
            objSourceFormulaMaterials.DataSource = null;
            txtBatchNo.Text = "";
            txtBatchSize.Text = "";
            txtProduct.Text = "";
            lblUnit1.Text = "<Unit>";
        }

        private void btnInitiate_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show(this, "Do you want to Initiate Selected Batch?\n\nClick Yes to Initiate", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.Yes)
                {
                    objBatch.InitiatedBy = CurrentUser.UserEmp.EmployeeID;
                    objBatch.BatchStatus = Batch.Status.In_Progress;
                    int x = objBatchDL.Update_Initiate(objBatch);
                    if (x > 0)
                    {
                        Clear();
                        LoadBatches(Batch.Status.Approved);
                        objBatch = new Batch();

                        bindBatch.DataSource = objBatchDL.Get_DataView(Batch.Status.Approved, CurrentUser.UserID);

                    }
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnEditFormula_Click(object sender, EventArgs e)
        {
            if (objBatch.BatchID != "")
            {
                frmFormulaEdit objForm = new frmFormulaEdit(objBatch,CurrentUser);
                objForm.ShowDialog(this);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult theResult = new System.Windows.Forms.DialogResult();

                theResult = MessageBox.Show(this, "Do you want to delete this Batch", "Confirmation", MessageBoxButtons.YesNo);

                if (theResult == System.Windows.Forms.DialogResult.Yes)
                {

                  int x=  objBatchDL.Delete(gvBatchList.CurrentRow.Cells["ColBatchNo"].Value.ToString());

                    LoadBatches(Batch.Status.Initial);

                    if(x>0)
                    {
                        MessageBox.Show(this, "Successfully Deleted", "Successful", MessageBoxButtons.OK);
                    }
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {

                objBatchActivity_DL.Add_QCFail(objBatch.BatchID, CurrentUser.EmployeeID, Convert.ToInt64(cmbActivity.SelectedValue), cmbPart.Text);
                bindActivityList.DataSource = objBatchActivity_DL.GetView(objBatch.BatchID);


            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSendToProduction_Click(object sender, EventArgs e)
        {
            try
            {

                objBatch.BatchStatus = Batch.Status.In_Progress;
                objBatch.InitiatedBy = CurrentUser.EmployeeID;

                objBatchDL.Update_Initiate(objBatch);

                LoadBatches(Batch.Status.QCFail);

                if (gvBatchList.Rows.Count > 0)
                {

                    DataGridViewCellEventArgs ee = new DataGridViewCellEventArgs(1, 0);

                    gvBatchList_CellClick(sender, ee);
                }
                else
                {
                    gvBatchList.AutoGenerateColumns = false;
                    bindBatch.DataSource = null;
                    gvBatchList.DataSource = bindBatch;
                    bindBatch.ResetBindings(true);
                }

         }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}