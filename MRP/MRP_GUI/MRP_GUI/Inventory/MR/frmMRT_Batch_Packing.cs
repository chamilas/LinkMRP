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
    public partial class frmMRT_Batch_Packing : System.Windows.Forms.Form
    {
        public frmMRT_Batch_Packing()
        {
            InitializeComponent();
        }

        public frmMRT_Batch_Packing(User objUser)
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
        Material_DL objMaterialDL = new Material_DL(ConnectionStringClass.GetConnection());
        UserDepartments_DL objUserDepartments_DL = new UserDepartments_DL(ConnectionStringClass.GetConnection());
        Batch_DL objBatch_DL = new Batch_DL(ConnectionStringClass.GetConnection());

        MR objMR = new MR();
        MR_DL objMRDL = new MR_DL(ConnectionStringClass.GetConnection());
        MRMaterial_DL objMRMaterialDL = new MRMaterial_DL(ConnectionStringClass.GetConnection());
        MRMaterialCollec objMRMaterialCollec = new MRMaterialCollec();
        Store objStore = new Store();

        MRMaterial objMRMaterial = new MRMaterial();
        Batch objBatch = new Batch();
        Department objFormDep = new Department();


        bool ItemSelect = false;
        //-------------------Methods------------------------

        public void ClearMR()
        {

            objMRMaterialCollec.Clear();

            bindItemList.DataSource = objMRMaterialCollec;
            bindItemList.ResetBindings(true);

        }

        public void ClearItem()
        {
            txtDescription.Text = "";
            txtQty.Text = "0.00";
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

                Material objMat = new Material();
                DataTable dt = new DataTable();

                bindItemList.DataSource = null;
                objMRMaterialCollec.Clear();

                
                objStore = objStoreDL.Get("Packing");

                txtStore.Text = objStore.StoreName;
               
                dt = objMaterialDL.GetDataView("Packing");
                objSourceMaterial.DataSource = dt;

                cmbItem.DataSource = objSourceMaterial;



                objMat = objMaterialDL.Get(cmbItem.SelectedValue.ToString());
                if (objMat != null)
                {
                    lblUnit.Text = objMat.MatUnit.UnitCode;
                }


               
            }
            catch (Exception ex)
            {
                
               MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnItemAdd_Click(object sender, EventArgs e)
        {
            if (txtQty.Text.Equals(""))
            {
                MessageBox.Show(this,"Please fill the quantity field","Empty Field",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                bool ItemList = false;
                MRMaterial objMRMat = new MRMaterial();
                
                try
                {
                    if (ItemSelect)
                    {
                       
                            objMRMat.Description = txtDescription.Text;
                            objMRMat.Material = objMaterialDL.Get(cmbItem.SelectedValue.ToString());
                            objMRMat.ReqdQty = Convert.ToDecimal(txtQty.Text);
                            objMRMat.MRBINNo = "N/A";
                            objMRMat.Item = objMRMat.Material.MaterialCode + " - " + objMRMat.Material.MaterialDescription;
                            objMRMat.UnitCode = objMRMat.Material.MatUnit.UnitCode;

                            
                            if (objMRMaterial.Material.MaterialCode != objMRMat.Material.MaterialCode)
                            {
                                foreach (MRMaterial obj in objMRMaterialCollec)
                                {
                                    if (obj.Material.MaterialCode == objMRMat.Material.MaterialCode)
                                    {


                                        MessageBox.Show(this, 
                                            "This item already in the list,Please Select the item from List and Update", 
                                            "Item in the List", 
                                            MessageBoxButtons.OK, 
                                            MessageBoxIcon.Information);

                                        ItemList = true;
                                        break;
                                    }
                                }
                                if (!ItemList)
                                {
                                    objMRMaterialCollec.Delete(objMRMaterial);
                                    objMRMaterialCollec.Add(objMRMat);
                                    ClearItem();
                                }
                            }
                            else
                            {
                                objMRMaterialCollec.Delete(objMRMaterial);
                                objMRMaterialCollec.Add(objMRMat);
                                ClearItem();
                            }


                            bindItemList.DataSource = objMRMaterialCollec;
                            bindItemList.ResetBindings(false);
                        
                    
                    }
                    else
                    {
                        
                            objMRMat.Description = txtDescription.Text;
                            objMRMat.Material = objMaterialDL.Get(cmbItem.SelectedValue.ToString());
                            objMRMat.ReqdQty = Convert.ToDecimal(txtQty.Text);
                            objMRMat.Item = objMRMat.Material.MaterialCode + " - " + objMRMat.Material.MaterialDescription;
                            objMRMat.UnitCode = objMRMat.Material.MatUnit.UnitCode;

                            objMRMat.MRBINNo = "N/A";

                            if (objMRMaterialCollec.Count > 0)
                            {
                                foreach (MRMaterial obj in objMRMaterialCollec)
                                {
                                    if (obj.Material.MaterialCode == objMRMat.Material.MaterialCode)
                                    {
                                        MessageBox.Show(this, "This item already in the list,Please Select the item from List and Update", "Item in the List", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        ItemList = true;
                                        break;
                                    }
                                }
                                if (!ItemList)
                                {
                                    objMRMaterialCollec.Add(objMRMat);
                                    ClearItem();
                                }
                            }
                            else
                            {
                                objMRMaterialCollec.Add(objMRMat);
                                ClearItem();
                            }
                            bindItemList.DataSource = objMRMaterialCollec;
                            bindItemList.ResetBindings(false);
                        

                        } 
                    
                }
                catch (Exception ex)
                {

                    MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally 
                {
                    objMRMat = null;
                }
            }
        }

        private void cmbItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            Material objMat = new Material();

            try
            {
             
                   
                        if (cmbItem.SelectedValue != null)
                        {
                            objMat = objMaterialDL.Get(cmbItem.SelectedValue.ToString());
                            if (objMat != null)
                            {
                                lblUnit.Text = objMat.MatUnit.UnitCode;
                                txtMaterialCode.Text = objMat.MaterialCode;
                            }
                            else
                            {
                                lblUnit.Text = "";
                            }
                        }

                   
            }
            catch (Exception ex)
            {
                
                    MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gvItemList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    
                        objMRMaterial = (MRMaterial)gvItemList.Rows[e.RowIndex].DataBoundItem;
                        txtDescription.Text = objMRMaterial.Description;
                        txtQty.Text = objMRMaterial.ReqdQty.ToString();
                        cmbItem.SelectedValue = objMRMaterial.Material.MaterialCode;
                    
                    ItemSelect = true; 
                }
            }
            catch (Exception ex)
            {
                    MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);    
            }
        }

        private void btnItemDel_Click(object sender, EventArgs e)
        {
            try
            {
                    
                        objMRMaterialCollec.Delete(objMRMaterial);
                  
                    bindItemList.ResetBindings(false);
                    ClearItem();
            }
            catch (Exception ex)
            {
                  MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);    
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ClearItem();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dtBatches = objBatch_DL.Get_DataView_Packing_All(Batch.Status.In_Progress,Batch.Status.QC,Batch.Status.QCPass, Batch.Status.Packing,Batch.Status.Finished, CurrentUser.UserID, "Product");

                DataTable dtBatches_Rework = objBatch_DL.Get_DataView_Rework(Batch.Status.In_Progress,"Rework","Repack");

                bool isaValidBatch = false;

                for (int i = 0; i < dtBatches.Rows.Count; i++)
                {
                    if (dtBatches.Rows[i]["BatchID"].ToString() == txtBatchNo.Text)
                    {
                        isaValidBatch = true;
                        break;
                    }
                }

                for (int i = 0; i < dtBatches_Rework.Rows.Count; i++)
                {
                    if (dtBatches_Rework.Rows[i]["BatchID"].ToString() == txtBatchNo.Text)
                    {
                        isaValidBatch = true;
                        break;
                    }
                }

                if (isaValidBatch == true)
                {

                    objBatch = objBatch_DL.Get(txtBatchNo.Text);

                    if (objMRMaterialCollec.Count > 0)
                    {
                        long MRNO = objMRDL.Add_BatchMR_Packing("A", objBatch.BatchID, objStore.StoreID, CurrentUser.UserEmp.EmployeeID, "Batch MR to" + objBatch.BatchID, MR.Status.Initial, MR.Type.Material, (int)MR.Origin.ToBatch);
                        if (MRNO > 0)
                        {
                            objMR.MRNO = MRNO;
                            foreach (MRMaterial obj in objMRMaterialCollec)
                            {
                                obj.MR = objMR;
                                objMRMaterialDL.Add(obj);
                            }
                            MessageBox.Show(this, "Successfully Added to Database", "Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearItem();
                            ClearMR();
                        }
                    }
                    else
                    {
                        MessageBox.Show(this, "Item List is Empty,Please add Items before continue", "Item List is Empty", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show(this, "Not a Valid Batch To Send MR", "UnSuccessfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                txtBatchNo.Text = "";

            }
            catch (Exception ex)
            {
                
                  MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);    
            }
        }

        private void txtQty_Validated(object sender, EventArgs e)
        {
            try
            {
                Convert.ToDecimal(txtQty.Text);
                errorProvider1.SetError(txtQty, "");
            }
            catch (Exception)
            {

                errorProvider1.SetError(txtQty, "Quantity should be a Numaric value");
            }
        }

        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.Validate_3Decimals(sender, e);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


     
      

    }
}