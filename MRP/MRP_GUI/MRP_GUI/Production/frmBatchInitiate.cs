using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DL;
using SESD.MRP.REF;

namespace MRP_GUI
{
    public partial class frmBatchInitiate : System.Windows.Forms.Form
    {
        private User _objCurrentUser;

        public User CurrentUser
        {
            get { return _objCurrentUser; }
            set { _objCurrentUser = value; }
        }

        public frmBatchInitiate()
        {
            InitializeComponent();
        }

        public frmBatchInitiate(User objUser)
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

        DataTable dtFormulaMaterials = new DataTable();

        public void LoadBatches(Batch.Status Status)
        {
            try
            {
                bindBatch.DataSource = objBatchDL.Get_DataView(Status,CurrentUser.UserID);
            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //frmBatchPlanning objFrm = new frmBatchPlanning(CurrentUser, objBatch);
            
            //objFrm.MdiParent = this.MdiParent;
            //objFrm.Show();
            //this.Close();

            //frmBatchEdit objFrm = new frmBatchEdit(objBatch, CurrentUser);
            //objFrm.MdiParent = this.MdiParent;
            //objFrm.Show();
            //this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmBatchApproving_Load(object sender, EventArgs e)
        {
            Clear();
            LoadBatches(Batch.Status.Approved);
            btnInitiate.Enabled = true;
        }

        private void gvBatchList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                objBatch = objBatchDL.Get(gvBatchList.Rows[e.RowIndex].Cells["ColBatchNo"].Value.ToString());

                dtFormulaMaterials = objBatchFormulaMaterial_DL.GetView(objBatch.BatchID);

                txtBatchNo.Text = objBatch.BatchID;
                txtBatchSize.Text = objBatch.BatchSize.ToString();
                txtProduct.Text = objBatch.StandardBatch.STDBatchBasicProduct.Code;
                bindActivityList.DataSource = objBatchActivity_DL.GetView(objBatch.BatchID);
                lblUnit1.Text = objBatch.StandardBatch.STDBatchBasicProduct.BasicProductUnit.UnitCode;


               

                dgvFormulaMaterial.AutoGenerateColumns = false;
                objSourceFormulaMaterials.DataSource = dtFormulaMaterials;
                dgvFormulaMaterial.DataSource = objSourceFormulaMaterials;
                objSourceFormulaMaterials.ResetBindings(true);



            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    DialogResult dr = MessageBox.Show(this,"Are you sure you want to Delete selected Batch?","Confirm Delete",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            //    if (dr == DialogResult.Yes)
            //    {
            //       int x = objBatchDL.Delete(objBatch.BatchID);
            //       if (x>0)
            //       {
            //           Clear();
            //            bindBatch.DataSource = objBatchDL.Get_DataView(Batch.Status.Initial);
            //            objBatch = new Batch(); 
            //       }

            //    }
            //}
            //catch (Exception ex)
            //{

            //    MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
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

                        objBatchActivity_DL.Add(objWeigh);


                        Clear();
                        bindBatch.DataSource = objBatchDL.Get_DataView(Batch.Status.Initial, CurrentUser.UserID);
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


        private void button2_Click_1(object sender, EventArgs e)
        {

        }

     
    }
}