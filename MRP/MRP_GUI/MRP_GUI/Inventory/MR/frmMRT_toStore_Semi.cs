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
    public partial class frmMRT_toStore_Semi : System.Windows.Forms.Form
    {

        public frmMRT_toStore_Semi(User objUser, string _StoreID)
        {
            InitializeComponent();
            CurrentUser = objUser;
            StoreID = _StoreID;


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

        MR objMR = new MR();
        MR_DL objMRDL = new MR_DL(ConnectionStringClass.GetConnection());
        MRBasicProduct_DL objMRBasicProduct_DL = new MRBasicProduct_DL(ConnectionStringClass.GetConnection());
        MRBasicProductCollec objMRBasicProductCollec = new MRBasicProductCollec();
        Store objStore = new Store();

        MRBasicProduct objMRBasicProduct = new MRBasicProduct();

        bool ItemSelect = false;
        string StoreID = "";
        string MaterialCat = "";
        //-------------------Methods------------------------

        public void ClearMR()
        {
            cmbDepartment.SelectedIndex = 0;
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

                BasicProduct objBasic = new BasicProduct();
                DataTable dt = new DataTable();

                bindItemList.DataSource = null;
                objMRBasicProductCollec.Clear();

                cmbDepartment.DataSource = objUserDepartments_DL.Get(CurrentUser.UserID);

                objStore = objStoreDL.Get(StoreID);

                txtStore.Text = objStore.StoreName;

                dt = objBasicProduct_DL.GetDataView();
                objSourceMaterial.DataSource = dt;

                cmbItem.DataSource = objSourceMaterial;



                objBasic = objBasicProduct_DL.Get(cmbItem.SelectedValue.ToString());
                if (objBasic != null)
                {
                    lblUnit.Text = objBasic.BasicProductUnit.UnitCode;
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
                MRBasicProduct objMRBasic = new MRBasicProduct();
                
                try
                {
                    if (ItemSelect)
                    {

                        objMRBasic.Description = txtDescription.Text;
                        objMRBasic.BasicProduct = objBasicProduct_DL.Get(cmbItem.SelectedValue.ToString());
                        objMRBasic.ReqdQty = Convert.ToDecimal(txtQty.Text);
                        objMRBasic.MRBINNo = "N/A";
                        objMRBasic.Item = objMRBasic.BasicProduct.BasicProductCode + "-" + objMRBasic.BasicProduct.BasicProductDescription;
                        objMRBasic.ItemCode = objMRBasic.BasicProduct.BasicProductCode;


                        if (objMRBasicProduct.BasicProduct.BasicProductCode != objMRBasic.BasicProduct.BasicProductCode)
                            {
                                foreach (MRBasicProduct obj in objMRBasicProductCollec)
                                {
                                    if (objMRBasicProduct.BasicProduct.BasicProductCode == objMRBasic.BasicProduct.BasicProductCode)
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
                                    objMRBasicProductCollec.Add(objMRBasic);
                                    ClearItem();
                                }
                            }
                            else
                            {
                                objMRBasicProductCollec.Delete(objMRBasicProduct);
                                objMRBasicProductCollec.Add(objMRBasic);
                                ClearItem();
                            }


                            bindItemList.DataSource = objMRBasicProductCollec;
                            bindItemList.ResetBindings(false);
                        
                    
                    }
                    else
                    {

                        objMRBasic.Description = txtDescription.Text;
                        objMRBasic.BasicProduct = objBasicProduct_DL.Get(cmbItem.SelectedValue.ToString());
                            objMRBasic.ReqdQty = Convert.ToDecimal(txtQty.Text);

                            objMRBasic.MRBINNo = "N/A";
                            objMRBasic.Item = objMRBasic.BasicProduct.BasicProductCode + "-" + objMRBasic.BasicProduct.BasicProductDescription;
                            objMRBasic.ItemCode = objMRBasic.BasicProduct.BasicProductCode;
                            objMRBasic.UnitCode = objMRBasic.BasicProduct.BasicProductUnit.UnitCode;

                            if (objMRBasicProductCollec.Count > 0)
                            {
                                foreach (MRBasicProduct obj in objMRBasicProductCollec)
                                {
                                    if (obj.BasicProduct.BasicProductCode == objMRBasic.BasicProduct.BasicProductCode)
                                    {
                                        MessageBox.Show(this, "This item already in the list,Please Select the item from List and Update", "Item in the List", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        ItemList = true;
                                        break;
                                    }
                                }
                                if (!ItemList)
                                {
                                    objMRBasicProductCollec.Add(objMRBasic);
                                    ClearItem();
                                }
                            }
                            else
                            {
                                objMRBasicProductCollec.Add(objMRBasic);
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
                finally 
                {
                    objMRBasic = null;
                }
            }
        }

        private void cmbItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            BasicProduct objBasic = new BasicProduct();

            try
            {
             
                   
                        if (cmbItem.SelectedValue != null)
                        {
                            objBasic = objBasicProduct_DL.Get(cmbItem.SelectedValue.ToString());
                            if (objBasic != null)
                            {
                                lblUnit.Text = objBasic.BasicProductUnit.UnitCode;
                                txtMaterialCode.Text = objBasic.BasicProductCode;
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
                objMR.MRDepartmentFrom = objDepDL.Get(Convert.ToInt64(cmbDepartment.SelectedValue));
                objMR.MREnterdBy = CurrentUser.UserEmp.EmployeeID;
                if (txtDescription.Text != "")
                {
                    objMR.MRRemarks = txtDescription.Text;
                }
                else
                {
                    objMR.MRRemarks = "No";
                }
                objMR.MRStore = objStore;
                objMR.MRStatus = MR.Status.Initial;
                objMR.MRType = MR.Type.BasicProduct;
                objMR.OriginType = MR.Origin.ToStore;
               
                
                   if (objMRBasicProductCollec.Count > 0)
                   {
                       long MRNO = objMRDL.Add_M(objMR);
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

        private void cmbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbDepartment.SelectedValue != null)
                {
                    

                }
            }
            catch (Exception)
            {

                MessageBox.Show(this,"Error occured while loading Sections","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.Validate_3Decimals(sender, e);
        }


     
      

    }
}