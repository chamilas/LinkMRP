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
    public partial class frmMRT_Batch_Partial : System.Windows.Forms.Form
    {
        public frmMRT_Batch_Partial(User objUser)
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

        MR objMR = new MR();
        MR_DL objMRDL = new MR_DL(ConnectionStringClass.GetConnection());
        MRBasicProduct_DL objMRBasicProductDL = new MRBasicProduct_DL(ConnectionStringClass.GetConnection());
        MRMaterial_DL objMRMaterialDL = new MRMaterial_DL(ConnectionStringClass.GetConnection());
        
        MRMaterialCollec objMRMaterialCollec = new MRMaterialCollec();
        MRBasicProductCollec objMRBasicProductCollec = new MRBasicProductCollec();

        MRMaterial objMRMaterial = new MRMaterial();
        MRBasicProduct objMRBasicProduct = new MRBasicProduct();
        Store objStore = new Store();

        long DepID;
        bool ItemSelect = false;
        //-------------------Methods------------------------

        public void ClearMR()
        {
            objsourceRequested.DataSource = null;

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

                DataTable dt = objBatch_DL.Get_BatchList_ToSendMR((int)Batch.Status.In_Progress, (int)Batch.Status.In_Progress, (int)Batch.Status.QCFail, (int)Batch.Status.QCFail, CurrentUser.UserID);

                cmbBatchNo_SelectedIndexChanged(sender, e);
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

                if (cmbBatchNo.SelectedValue != null)
                {
                    DepID = objBasicProductDL.Get_Department(objBatch_DL.Get(cmbBatchNo.SelectedValue.ToString()).StandardBatch.STDBatchBasicProduct.BasicProductCode, "Manf");

                    if (cmbPart.Text != "")
                    {
                        if (objBatch_DL.GetMaterialRequisitionStatus_ByPart(cmbBatchNo.SelectedValue.ToString(), cmbPart.Text) == 0)
                        {
                            btnAdd.Enabled = false;
                            btnSendMR.Enabled = false;
                            btnRemove.Enabled = false;
                        }
                        else
                        {
                            btnAdd.Enabled = true;
                            btnSendMR.Enabled = true;
                            btnRemove.Enabled = true;
                        }


                    }
                }

                    BatchFormulaMaterial_DL objBatchFormulaMaterial_DL = new BatchFormulaMaterial_DL(ConnectionStringClass.GetConnection());

                    if ((cmbBatchNo.SelectedValue != null) && (cmbPart.Text != ""))
                    {
                        DataTable dt = objBatchFormulaMaterial_DL.GetView(cmbBatchNo.SelectedValue.ToString(), cmbPart.Text);

                        dgvItemList.AutoGenerateColumns = false;
                        objSourceMaterialList.DataSource = dt;
                        dgvItemList.DataSource = objSourceMaterialList;
                        objSourceMaterialList.ResetBindings(true);

                        DataTable dtRequested = objMRMaterialDL.Get_RequestedMaterial(cmbBatchNo.SelectedValue.ToString(), cmbPart.Text);

                        dgvItemRequested.AutoGenerateColumns = false;
                        objsourceRequested.DataSource = dtRequested;
                        dgvItemRequested.DataSource = objsourceRequested;
                        objsourceRequested.ResetBindings(true);


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



        private void LoadSemiFinishedList()
        {
            try
            {

                if (cmbBatchNo.SelectedValue != null)
                {
                    DepID = objBasicProductDL.Get_Department(objBatch_DL.Get(cmbBatchNo.SelectedValue.ToString()).StandardBatch.STDBatchBasicProduct.BasicProductCode, "Manf");

                    if (cmbPart.Text != "")
                    {
                        if (objBatch_DL.GetSemiFinishedRequisitionStatus_ByPart(cmbBatchNo.SelectedValue.ToString(), cmbPart.Text) == 0)
                        {
                            btnAdd.Enabled = false;
                            btnSendMR.Enabled = false;
                            btnRemove.Enabled = false;
                        }
                        else
                        {
                            btnAdd.Enabled = true;
                            btnSendMR.Enabled = true;
                            btnRemove.Enabled = true;
                        }




                    }
                }


                BatchFormulaBasicProducts_DL objBatchFormulaBasicProducts_DL = new BatchFormulaBasicProducts_DL(ConnectionStringClass.GetConnection());

                if ((cmbBatchNo.SelectedValue != null) && (cmbPart.Text != ""))
                {
                    DataTable dt = objBatchFormulaBasicProducts_DL.GetView(cmbBatchNo.SelectedValue.ToString(), cmbPart.Text);

                    dgvItemList.AutoGenerateColumns = false;
                    objSourceMaterialList.DataSource = dt;
                    dgvItemList.DataSource = objSourceMaterialList;
                    objSourceMaterialList.ResetBindings(true);


                    DataTable dtMR = objMRDL.GetActiveMR(cmbBatchNo.SelectedValue.ToString(), cmbPart.Text, (int)BatchMR.Status.Rejected, (int)MR.Type.BasicProduct, objStore.StoreID);

                    DataTable dtRequested =objMRBasicProductDL.Get_RequestedSemiFinished(cmbBatchNo.SelectedValue.ToString(), cmbPart.Text);

                    dgvItemRequested.AutoGenerateColumns = false;
                    objsourceRequested.DataSource = dtRequested;
                    dgvItemRequested.DataSource = objsourceRequested;
                    objsourceRequested.ResetBindings(true);

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
                dgvItem_toRequest.Visible = true;
                dgvItem_toRequest_BP.Visible = false;
            }
            else
            {
                LoadSemiFinishedList();
                dgvItem_toRequest_BP.Visible = true;
                dgvItem_toRequest.Visible = false;

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (rdbMaterial.Checked == true)
            {
                MRMaterial obj = new MRMaterial();
                bool duplicate = false;

                obj.Material =objMaterialDL.Get(dgvItemList.CurrentRow.Cells["ItemCode"].Value.ToString());
                obj.ReqdQty = Convert.ToDecimal(dgvItemList.CurrentRow.Cells["ReqQty"].Value);
                obj.IssuedQty = 0;
                obj.Description = "Batch Material Requisition";
                obj.MRBINNo = "N/A";
                obj.MaterialCode = obj.Material.MaterialCode;
                obj.MaterialName = obj.Material.MaterialDescription;


                foreach (MRMaterial _obj in objMRMaterialCollec)
                {
                    if (_obj.MaterialCode == obj.MaterialCode)
                    {
                        duplicate = true;

                        break;
                    }
                }

                for (int i = 0; i < dgvItemRequested.Rows.Count;i++ )
                {
                    if (dgvItemRequested.Rows[i].Cells["MaterialCode"].Value.ToString() == obj.MaterialCode)
                    {
                        duplicate = true;

                        break;
                    }
                }



                if (duplicate == false)
                {
                    objMRMaterialCollec.Add(obj);

                }

                dgvItem_toRequest.AutoGenerateColumns = false;
                objSourceItems_toRequest.DataSource = objMRMaterialCollec;
                dgvItem_toRequest.DataSource = objSourceItems_toRequest;
                objSourceItems_toRequest.ResetBindings(true);


            }
            else
            {
                MRBasicProduct obj = new MRBasicProduct();

                obj.BasicProduct = objBasicProductDL.Get(dgvItemList.CurrentRow.Cells["ItemCode"].Value.ToString());

                obj.ReqdQty = Convert.ToDecimal(dgvItemList.CurrentRow.Cells["ReqQty"].Value);
                obj.ItemCode = obj.BasicProduct.BasicProductCode;
                obj.Item = obj.BasicProduct.BasicProductDescription;
                obj.Description = "No";
                obj.MRBINNo = "No";

                objMRBasicProductCollec.Add(obj);

                dgvItem_toRequest_BP.AutoGenerateColumns = false;
                objSourceItems_toRequest.DataSource = objMRBasicProductCollec;
                dgvItem_toRequest_BP.DataSource = objSourceItems_toRequest;
                objSourceItems_toRequest.ResetBindings(true);


            }
        }

        private void btnSendMR_Click(object sender, EventArgs e)
        {
            try
            {
                int NewMRNO = 0;

                if (rdbMaterial.Checked == true)
                {

                     NewMRNO = objMRDL.Add_BatchMR_Partial(cmbPart.Text, cmbBatchNo.SelectedValue.ToString(), objStore.StoreID, CurrentUser.EmployeeID, DepID, "MR For Batch No  " + cmbBatchNo.SelectedValue.ToString(), MR.Status.Initial, MR.Type.Material, (int)MR.Origin.ToBatch);

                }
                else
                {
                    NewMRNO = objMRDL.Add_BatchMR_Partial(cmbPart.Text, cmbBatchNo.SelectedValue.ToString(), objStore.StoreID, CurrentUser.EmployeeID, DepID, "MR For Batch No  " + cmbBatchNo.SelectedValue.ToString(), MR.Status.Initial, MR.Type.BasicProduct, (int)MR.Origin.ToBatch);
                }
               if (rdbMaterial.Checked == true)
               {
                   foreach (MRMaterial obj in objMRMaterialCollec)
                   {
                       obj.MR = objMRDL.Get(NewMRNO);

                       objMRMaterialDL.Add(obj);

                   }

                   objMRMaterialCollec.Clear();
               }

               if (rdbSemiFinished.Checked == true)
               {
                   foreach (MRBasicProduct obj in objMRBasicProductCollec)
                   {
                       obj.MR = objMRDL.Get(NewMRNO);

                       objMRBasicProductDL.Add(obj);

                   }

                   objMRBasicProductCollec.Clear();
               }

               if (NewMRNO > 0)
               {

                   MessageBox.Show(this, "MR is sent to RPD Stores. MRNO is : " + NewMRNO.ToString(), "Successful", MessageBoxButtons.OK);

                   if (rdbMaterial.Checked == true)
                   {
                       LoadMaterialList();
                   }
                   else
                   {
                       LoadSemiFinishedList();
                   }

                   this.Close();
               }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (rdbMaterial.Checked == true)
            {

                 objMRMaterialCollec.RemoveAt(dgvItem_toRequest.CurrentRow.Index);

                dgvItem_toRequest.AutoGenerateColumns = false;
                objSourceItems_toRequest.DataSource = objMRMaterialCollec;
                dgvItem_toRequest.DataSource = objSourceItems_toRequest;
                objSourceItems_toRequest.ResetBindings(true);


            }
            else
            {

                objMRBasicProductCollec.RemoveAt(dgvItem_toRequest.CurrentRow.Index);

                dgvItem_toRequest.AutoGenerateColumns = false;
                objSourceItems_toRequest.DataSource = objMRBasicProductCollec;
                dgvItem_toRequest.DataSource = objSourceItems_toRequest;
                objSourceItems_toRequest.ResetBindings(true);


            }
        }

        private void dgvItemList_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



    }
}