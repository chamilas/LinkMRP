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
    public partial class frmMRT_Batch_FG : System.Windows.Forms.Form
    {

        public frmMRT_Batch_FG(User objUser,string _productCategory)
        {
            InitializeComponent();
            CurrentUser = objUser;
            ProductCategory = _productCategory;

        }
        //-------------------- Variables ---------------------


        private User _objCurrentUser;
        string ProductCategory = "";

        public User CurrentUser
        {
            get { return _objCurrentUser; }
            set { _objCurrentUser = value; }
        }
        Department_DL objDepDL = new Department_DL(ConnectionStringClass.GetConnection());
        Store_DL objStoreDL = new Store_DL(ConnectionStringClass.GetConnection());
        FinishProduct_DL objFinishProduct_DL = new FinishProduct_DL(ConnectionStringClass.GetConnection());
        UserDepartments_DL objUserDepartments_DL = new UserDepartments_DL(ConnectionStringClass.GetConnection());
        Batch_DL objBatch_DL = new Batch_DL(ConnectionStringClass.GetConnection());
        OptionalFormula_DL objOptionalFormula_DL = new OptionalFormula_DL(ConnectionStringClass.GetConnection());

        MR objMR = new MR();
        MR_DL objMRDL = new MR_DL(ConnectionStringClass.GetConnection());
        MRFinishProduct_DL objMRFinishProductDL = new MRFinishProduct_DL(ConnectionStringClass.GetConnection());
        MRFinishProductCollec objMRFinishProductCollec = new MRFinishProductCollec();
        Store objStore = new Store();
        Batch objBatch = new Batch();

        MRFinishProduct objMRFinishProduct = new MRFinishProduct();

        bool ItemSelect = false;
        //-------------------Methods------------------------

        public void ClearMR()
        {
            bindItemList.DataSource = null;

            objMRFinishProductCollec.Clear();
        }

        public void ClearItem()
        {
            txtDescription.Text = "";
            txtQty.Text = "0.00";
            cmbItem.SelectedIndex = 0;
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
                objMRFinishProductCollec.Clear();


                DataTable dtBatchList = objBatch_DL.Get_BatchList_ToSendMR_Rework((int)Batch.Status.In_Progress, (int)Batch.Status.In_Progress, (int)Batch.Status.QCFail, (int)Batch.Status.QCFail,(int)Batch.Status.Rework, CurrentUser.UserID);

                objSourceBatchist.DataSource = dtBatchList;
                cmbBatchNo.DataSource = objSourceBatchist;

                if (ProductCategory == "AP")
                {
                    objStore = objStoreDL.Get("Finished_Goods_Ayurveda");
                }
                else if (ProductCategory == "HP")
                {
                    objStore = objStoreDL.Get("Finished_Goods_Consumer");

                }
                else
                {

                }
                
                txtStore.Text = objStore.StoreName;

                Load_FG();

               
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
                MRFinishProduct objMRMat = new MRFinishProduct();
                
                try
                {
                    if (ItemSelect)
                    {
                       
                            objMRMat.Description = txtDescription.Text;
                            objMRMat.FinishProduct =objFinishProduct_DL.Get(cmbItem.SelectedValue.ToString());
                            objMRMat.ReqdQty = Convert.ToDecimal(txtQty.Text);
                            objMRMat.MRBINNo = "N/A";

                            
                            if (objMRFinishProduct.FinishProduct.FinishProductCode != objMRMat.FinishProduct.FinishProductCode)
                            {
                                foreach (MRFinishProduct obj in objMRFinishProductCollec)
                                {
                                    if (obj.FinishProduct.FinishProductCode == objMRMat.FinishProduct.FinishProductCode)
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
                                    objMRFinishProductCollec.Delete(objMRFinishProduct);
                                    objMRFinishProductCollec.Add(objMRMat);
                                    ClearItem();
                                }
                            }
                            else
                            {
                                objMRFinishProductCollec.Delete(objMRFinishProduct);
                                objMRFinishProductCollec.Add(objMRMat);
                                ClearItem();
                            }


                            bindItemList.DataSource = objMRFinishProductCollec;
                            bindItemList.ResetBindings(false);
                        
                    
                    }
                    else
                    {
                        
                            objMRMat.Description = txtDescription.Text;
                            objMRMat.FinishProduct =objFinishProduct_DL.Get(cmbItem.SelectedValue.ToString());
                            objMRMat.ReqdQty = Convert.ToDecimal(txtQty.Text);

                            objMRMat.MRBINNo = "N/A";

                            if (objMRFinishProductCollec.Count > 0)
                            {
                                foreach (MRFinishProduct obj in objMRFinishProductCollec)
                                {
                                    if (obj.FinishProduct.FinishProductCode == objMRMat.FinishProduct.FinishProductCode)
                                    {
                                        MessageBox.Show(this, "This item already in the list,Please Select the item from List and Update", "Item in the List", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        ItemList = true;
                                        break;
                                    }
                                }
                                if (!ItemList)
                                {
                                    objMRFinishProductCollec.Add(objMRMat);
                                    ClearItem();
                                }
                            }
                            else
                            {
                                objMRFinishProductCollec.Add(objMRMat);
                                ClearItem();
                            }
                            bindItemList.DataSource = objMRFinishProductCollec;
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
            FinishProduct objMat = new FinishProduct();

            try
            {


                        if (cmbItem.SelectedValue != null)
                        {
                            objMat =objFinishProduct_DL.Get(cmbItem.SelectedValue.ToString());
                            if (objMat != null)
                            {
                               //
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
                    
                        objMRFinishProduct = (MRFinishProduct)gvItemList.Rows[e.RowIndex].DataBoundItem;
                        txtDescription.Text = objMRFinishProduct.Description;
                        txtQty.Text = objMRFinishProduct.ReqdQty.ToString();
                        cmbItem.SelectedValue = objMRFinishProduct.FinishProduct.FinishProductCode;
                    
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
                    
                        objMRFinishProductCollec.Delete(objMRFinishProduct);
                  
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
                
                   if (objMRFinishProductCollec.Count > 0)
                   {
                       long MRNO = objMRDL.Add_BatchMR_Optional("N/A", objBatch.BatchID, objStore.StoreID, CurrentUser.EmployeeID, "Optional MR", MR.Status.Initial, MR.Type.FinishProduct, (int)MR.Origin.ToBatch);

                       if (MRNO > 0)
                       {
                           objMR.MRNO = MRNO;
                           foreach (MRFinishProduct obj in objMRFinishProductCollec)
                           {
                               obj.MR = objMR;
                               objMRFinishProductDL.Add(obj);
                           }
                           MessageBox.Show(this,"Successfully Added to Database","Successfull",MessageBoxButtons.OK,MessageBoxIcon.Information);
                           ClearItem();
                           ClearMR();
                       }
                   }
                   else
                   {
                       MessageBox.Show(this,"Item List is Empty,Please add Items before continue","Item List is Empty",MessageBoxButtons.OK,MessageBoxIcon.Information);
                   }
               

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

        private void cmbBatchNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbBatchNo.SelectedValue != null)
                {
                    

                    objBatch = objBatch_DL.Get(cmbBatchNo.SelectedValue.ToString());


                    


                }


            }
            catch (Exception)
            {

                MessageBox.Show(this, "Error occured while loading Sections", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void Load_FG()
        {
            DataTable dt = objFinishProduct_DL.GetData_ByCategory(true,ProductCategory);
            objSourceMaterial.DataSource = dt;

            cmbItem.DataSource = objSourceMaterial;
        }


     
      

    }
}