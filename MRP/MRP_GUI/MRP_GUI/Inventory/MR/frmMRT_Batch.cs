using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SESD.MRP.REF;
using DL;

namespace MRP_GUI
{
    public partial class frmMRT_Batch : System.Windows.Forms.Form
    {

        public frmMRT_Batch(User objUser)
        {
            InitializeComponent();
            CurrentUser = objUser;

        }
        //-------------------- Variables ---------------------


        private User _objCurrentUser;


        public User CurrentUser
        {
            get { return _objCurrentUser; }
            set { _objCurrentUser = value; }
        }
        Department_DL objDepDL = new Department_DL(ConnectionStringClass.GetConnection());
        Store_DL objStoreDL = new Store_DL(ConnectionStringClass.GetConnection());
        Batch_DL objBatch_DL = new Batch_DL(ConnectionStringClass.GetConnection());
        Material_DL objMaterialDL = new Material_DL(ConnectionStringClass.GetConnection());
        BasicProduct_DL objBasicProductDL = new BasicProduct_DL(ConnectionStringClass.GetConnection());
        BatchFormulaMaterial_DL objBatchFormulaMaterial_DL = new BatchFormulaMaterial_DL(ConnectionStringClass.GetConnection());
        BatchFormulaBasicProducts_DL objBatchFormulaBasicProducts_DL = new BatchFormulaBasicProducts_DL(ConnectionStringClass.GetConnection());

        MR objMR = new MR();
        MR_DL objMRDL = new MR_DL(ConnectionStringClass.GetConnection());
        MRBasicProduct_DL objMRBasicProductDL = new MRBasicProduct_DL(ConnectionStringClass.GetConnection());
        MRBasicProductCollec objMRBasicProductCollec = new MRBasicProductCollec();
        MRMaterial_DL objMRMaterialDL = new MRMaterial_DL(ConnectionStringClass.GetConnection());
        MRMaterialCollec objMRMaterialCollec = new MRMaterialCollec();


        MRMaterial objMRMaterial = new MRMaterial();
        MRBasicProduct objMRBasicProduct = new MRBasicProduct();
        Store objStore = new Store();
        long DepID;
        Batch objBatch = new Batch();

        DataTable dt = new DataTable();

        bool ItemSelect = false;
        //-------------------Methods------------------------

        public void ClearMR()
        {
            bindItemList.DataSource = null;

            objMRBasicProductCollec.Clear();
            objMRMaterialCollec.Clear();
        }

        public void ClearItem()
        {
            this.ItemSelect = false;
        }

        //-------------------Events-------------------------
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMRT_Load(object sender, EventArgs e)
        {
            try
            {
                objStore = objStoreDL.Get("RPD_Main");

                DataTable dt = objBatch_DL.Get_BatchList_ToSendMR((int)Batch.Status.In_Progress,(int)Batch.Status.In_Progress,(int)Batch.Status.QCFail,(int)Batch.Status.QCFail, CurrentUser.UserID);

                objSourceBatchist.DataSource = dt;
                cmbBatchNo.DataSource = objSourceBatchist;

            }
            catch (Exception ex)
            {
                
               MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void LoadMaterialList()
        {
            try
            {

                

                if ((cmbBatchNo.SelectedValue != null) && (cmbPart.Text !=""))
                {

                   objBatch= objBatch_DL.Get(cmbBatchNo.SelectedValue.ToString());

                   dt = objBatchFormulaMaterial_DL.GetView(objBatch.BatchID, cmbPart.Text);

                   dgvItemList.AutoGenerateColumns = false;
                  objSourceMaterialList.DataSource = dt;
                   dgvItemList.DataSource = objSourceMaterialList;
                   objSourceMaterialList.ResetBindings(true);


                   DepID = objDepDL.Get(objBatch.StandardBatch.STDBatchBasicProduct.BasicProductCode, "Manf");
                   DataTable dtMR = new DataTable();


                   if (rdbMaterial.Checked == true)
                   {
                      dtMR = objMRDL.GetActiveMR(cmbBatchNo.SelectedValue.ToString(), cmbPart.Text, (int)BatchMR.Status.Rejected, (int)MR.Type.Material,objStore.StoreID);
                   }

                   if (rdbSemiFinished.Checked == true)
                   {
                       dtMR = objMRDL.GetActiveMR(cmbBatchNo.SelectedValue.ToString(), cmbPart.Text, (int)BatchMR.Status.Rejected, (int)MR.Type.BasicProduct, objStore.StoreID);
                   }

                  if (dtMR.Rows.Count > 0)
                  {
                      lblMessage.Text = "There is a request already made from MRNO : " + dtMR.Rows[0]["MRNO"].ToString() + ".  Please check the status of that requisition";
                      btnSendMR.Enabled = false;
                  }
                  else
                  {
                      lblMessage.Text = "This will request material list of the selected Part at once";
                      btnSendMR.Enabled = true;
                  }
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void LoadSemiFinishedList()
        {
            try
            {



                if ((cmbBatchNo.SelectedValue != null) && (cmbPart.Text != ""))
                {

                    objBatch = objBatch_DL.Get(cmbBatchNo.SelectedValue.ToString());

                    dt = objBatchFormulaBasicProducts_DL.GetView(objBatch.BatchID, cmbPart.Text);

                    dgvItemList.AutoGenerateColumns = false;
                    objSourceMaterialList.DataSource = dt;
                    dgvItemList.DataSource = objSourceMaterialList;
                    objSourceMaterialList.ResetBindings(true);


                    DepID = objDepDL.Get(objBatch.StandardBatch.STDBatchBasicProduct.BasicProductCode, "Manf");



                    DataTable dtMR = objMRDL.GetActiveMR(cmbBatchNo.SelectedValue.ToString(), cmbPart.Text, (int)BatchMR.Status.Rejected, (int)MR.Type.BasicProduct, objStore.StoreID);

                    if (dtMR.Rows.Count > 0)
                    {
                        lblMessage.Text = "There is a request already made from MRNO : " + dtMR.Rows[0]["MRNO"].ToString() + ".  Please check the status of that requisition";
                        btnSendMR.Enabled = false;
                    }
                    else
                    {
                        lblMessage.Text = "This will request material list of the selected Part at once";
                        btnSendMR.Enabled = true;
                    }
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void cmbPart_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rdbMaterial.Checked == true)
            {
                LoadMaterialList();
            }
            else
            {
                LoadSemiFinishedList();
            }
        }

        private void cmbBatchNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rdbMaterial.Checked == true)
            {
                LoadMaterialList();
            }
            else
            {
                LoadSemiFinishedList();
            }
        }

        private void btnSendMR_Click(object sender, EventArgs e)
        {

            try
            {
                DialogResult theResult = MessageBox.Show(this, "Do You want to Request Items from Stores", "Confirmation", MessageBoxButtons.YesNo);

                if (theResult == System.Windows.Forms.DialogResult.Yes)
                {

                    if ((cmbBatchNo.SelectedValue != null) && (cmbPart.Text != "") && (dgvItemList.Rows.Count > 0))
                    {
                        if (rdbMaterial.Checked == true)
                        {
                            long MRNO = objMRDL.Add_BatchMR(cmbPart.Text, objBatch.BatchID, objStore.StoreID, CurrentUser.EmployeeID, "MR For Batch No  " + cmbBatchNo.SelectedValue.ToString(), MR.Status.Initial, MR.Type.Material, Convert.ToInt32(MR.Origin.ToBatch));

                            if (MRNO > 0)
                            {
                                MessageBox.Show(this, "Successfully Send raised and MR. The MRNO is : " + MRNO, "Successful", MessageBoxButtons.OK);
                            }

                        }

                        if (rdbSemiFinished.Checked == true)
                        {
                            long MRNO = objMRDL.Add_BatchMR_SemiFinished(cmbPart.Text, objBatch.BatchID, objStore.StoreID, CurrentUser.EmployeeID, "MR For Batch No  " + cmbBatchNo.SelectedValue.ToString(), MR.Status.Initial, MR.Type.BasicProduct, Convert.ToInt32(MR.Origin.ToBatch));

                            if (MRNO > 0)
                            {
                                MessageBox.Show(this, "Successfully Send raised and MR. The MRNO is : " + MRNO, "Successful", MessageBoxButtons.OK);
                            }

                        }

                       

                        LoadMaterialList();
                    }
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void rdbMaterial_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbMaterial.Checked == true)
            {
                LoadMaterialList();
            }
            else
            {
                LoadSemiFinishedList();
            }
        }

        private void rdbSemiFinished_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbMaterial.Checked == true)
            {
                LoadMaterialList();
            }
            else
            {
                LoadSemiFinishedList();
            }
        }

    }
}