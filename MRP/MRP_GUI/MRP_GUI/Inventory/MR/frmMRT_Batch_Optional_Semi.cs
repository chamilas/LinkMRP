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
    public partial class frmMRT_Batch_Optional_Semi : System.Windows.Forms.Form
    {
        public frmMRT_Batch_Optional_Semi()
        {
            InitializeComponent();
        }

        public frmMRT_Batch_Optional_Semi(User objUser)
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
        BasicProduct_DL objBasicProduct_DL = new BasicProduct_DL(ConnectionStringClass.GetConnection());
        UserDepartments_DL objUserDepartments_DL = new UserDepartments_DL(ConnectionStringClass.GetConnection());
        Batch_DL objBatch_DL = new Batch_DL(ConnectionStringClass.GetConnection());
        OptionalFormula_DL objOptionalFormula_DL = new OptionalFormula_DL(ConnectionStringClass.GetConnection());

        MR objMR = new MR();
        MR_DL objMRDL = new MR_DL(ConnectionStringClass.GetConnection());
        MRBasicProduct_DL objMRBasicProduct_DL = new MRBasicProduct_DL(ConnectionStringClass.GetConnection());
        MRBasicProductCollec objMRBasicProductCollec = new MRBasicProductCollec();
        Store objStore = new Store();
        Batch objBatch = new Batch();

        MRBasicProduct objMRBasicProduct = new MRBasicProduct();

        bool ItemSelect = false;
        //-------------------Methods------------------------

        public void ClearMR()
        {
            bindItemList.DataSource = null;

            objMRBasicProductCollec.Clear();
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
                objMRBasicProductCollec.Clear();


                DataTable dtBatchList = objBatch_DL.Get_BatchList_ToSendMR((int)Batch.Status.In_Progress,(int)Batch.Status.In_Progress,(int)Batch.Status.QCFail,(int)Batch.Status.QCFail, CurrentUser.UserID);

                objSourceBatchist.DataSource = dtBatchList;
                cmbBatchNo.DataSource = objSourceBatchist;


                objStore = objStoreDL.Get("RPD_Main");

                txtStore.Text = objStore.StoreName;
               
                

               
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
                MRBasicProduct objMRSemi = new MRBasicProduct();
                
                try
                {
                    if (ItemSelect)
                    {

                        objMRSemi.Description = txtDescription.Text;
                        objMRSemi.BasicProduct = objBasicProduct_DL.Get(cmbItem.SelectedValue.ToString());
                        objMRSemi.ReqdQty = Convert.ToDecimal(txtQty.Text);
                        objMRSemi.MRBINNo = "N/A";
                        objMRSemi.Item = objMRSemi.BasicProduct.BasicProductCode + " - " + objMRSemi.BasicProduct.BasicProductDescription;
                        objMRSemi.UnitCode = objMRSemi.BasicProduct.BasicProductUnit.UnitCode;

                            if (objMRBasicProduct.BasicProduct.BasicProductCode != objMRSemi.BasicProduct.BasicProductCode)
                            {
                                foreach (MRBasicProduct obj in objMRBasicProductCollec)
                                {
                                    if (obj.BasicProduct.BasicProductCode == objMRSemi.BasicProduct.BasicProductCode)
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
                                    objMRBasicProductCollec.Delete(objMRBasicProduct);
                                    objMRBasicProductCollec.Add(objMRSemi);
                                    ClearItem();
                                }
                            }
                            else
                            {
                                objMRBasicProductCollec.Delete(objMRBasicProduct);
                                objMRBasicProductCollec.Add(objMRSemi);
                                ClearItem();
                            }


                            bindItemList.DataSource = objMRBasicProductCollec;
                            bindItemList.ResetBindings(false);
                        
                    
                    }
                    else
                    {

                        objMRSemi.Description = txtDescription.Text;
                        objMRSemi.BasicProduct = objBasicProduct_DL.Get(cmbItem.SelectedValue.ToString());
                        objMRSemi.ReqdQty = Convert.ToDecimal(txtQty.Text);
                        objMRSemi.MRBINNo = "N/A";
                        objMRSemi.ItemCode = objMRSemi.BasicProduct.BasicProductCode;
                        objMRSemi.Item = objMRSemi.BasicProduct.BasicProductCode + " - " + objMRSemi.BasicProduct.BasicProductDescription;
                        objMRSemi.UnitCode = objMRSemi.BasicProduct.BasicProductUnit.UnitCode;

                        if (objMRBasicProductCollec.Count > 0)
                            {
                                foreach (MRBasicProduct obj in objMRBasicProductCollec)
                                {
                                    if (obj.BasicProduct.BasicProductCode == objMRSemi.BasicProduct.BasicProductCode)
                                    {
                                        MessageBox.Show(this, "This item already in the list,Please Select the item from List and Update", "Item in the List", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        ItemList = true;
                                        break;
                                    }
                                }
                                if (!ItemList)
                                {
                                    objMRBasicProductCollec.Add(objMRSemi);
                                    ClearItem();
                                }
                            }
                            else
                            {
                                objMRBasicProductCollec.Add(objMRSemi);
                                ClearItem();
                            }
                            bindItemList.DataSource = objMRBasicProductCollec;
                            bindItemList.ResetBindings(false);
                        

                        } 
                    
                }
                catch (Exception ex)
                {

                    MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               
            }
        }

        private void cmbItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            BasicProduct objBasicProduct = new BasicProduct();

            try
            {


                        if (cmbItem.SelectedValue != null)
                        {
                            objBasicProduct = objBasicProduct_DL.Get(cmbItem.SelectedValue.ToString());
                            if (objBasicProduct != null)
                            {
                                lblUnit.Text = objBasicProduct.BasicProductUnit.UnitCode;
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
                    
                       objMRBasicProduct = (MRBasicProduct)gvItemList.Rows[e.RowIndex].DataBoundItem;
                       txtDescription.Text = objMRBasicProduct.Description;
                       txtQty.Text = objMRBasicProduct.ReqdQty.ToString();
                       cmbItem.SelectedValue = objMRBasicProduct.BasicProduct.BasicProductCode;
                    
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

                objMRBasicProductCollec.Delete(objMRBasicProduct);
                  
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

                if (objMRBasicProductCollec.Count > 0)
                   {
                       long MRNO = objMRDL.Add_BatchMR_Optional("N/A", objBatch.BatchID, objStore.StoreID, CurrentUser.EmployeeID, "Optional MR" + objBatch.BatchID.ToString(), MR.Status.Initial, MR.Type.BasicProduct, (int)MR.Origin.ToBatch);

                       if (MRNO > 0)
                       {
                           objMR.MRNO = MRNO;
                           foreach (MRBasicProduct obj in objMRBasicProductCollec)
                           {
                               obj.MR = objMR;
                               objMRBasicProduct_DL.Add(obj);
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


                    DataTable dt = objOptionalFormula_DL.GetSemiFinishedBy_BasicProduct(objBatch.StandardBatch.STDBatchBasicProduct.BasicProductCode);
                    objSourceMaterial.DataSource = dt;

                    cmbItem.DataSource = objSourceMaterial;


                }


            }
            catch (Exception)
            {

                MessageBox.Show(this, "Error occured while loading Sections", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

     

     
      

    }
}