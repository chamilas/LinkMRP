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
    public partial class frmGRN_Direct : System.Windows.Forms.Form
    {

        public frmGRN_Direct(User objUser,string _storeID,string _MatCat)
        {
            InitializeComponent();
            CurrentUser = objUser;
            StoreID = _storeID;
            MatCat = _MatCat;
        }

        private User _objCurrentUser;

        public User CurrentUser
        {
            get { return _objCurrentUser; }
            set { _objCurrentUser = value; }
        }

        string StoreID="";
        string MatCat="";

        Department_DL objDepartmentDL = new Department_DL(ConnectionStringClass.GetConnection());
        Store_DL objStoreDL = new Store_DL(ConnectionStringClass.GetConnection());

        Department objDepartment = new Department();
        Store objStore = new Store();

        Material_DL objMaterialDL = new Material_DL(ConnectionStringClass.GetConnection());

        GRN objGRN = new GRN();
        GRN_Payment objGRN_Payment = new GRN_Payment();
        GRN_DL objGRNDL = new GRN_DL(ConnectionStringClass.GetConnection());
        GRN_Payment_DL objGRN_Payment_DL = new GRN_Payment_DL(ConnectionStringClass.GetConnection());

        GRNMaterials objGRNMaterials = new GRNMaterials();

        GRNMaterialsCollec objGRNMaterialsCollec = new GRNMaterialsCollec();

        GRNMaterials_DL objGRNMaterialsDL = new GRNMaterials_DL(ConnectionStringClass.GetConnection());

        bool ItemSelect = false;

        //--------------- Methods --------------------

       public void LoadDirect()
       {
           try
           {
               
                   cmbItem.DataSource = objMaterialDL.GetDataView(MatCat);
                   cmbItem.DisplayMember = "Material";
                   cmbItem.ValueMember = "MaterialCode";
                   objGRN.GRNType = GRN.Type.Material;
              
              
           }
           catch (Exception ex)
           {
                
               MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
       }

        public void ClearItem()
        {
            try
            {
               
                txtNetQty.Text = "0.00";
         
                txtUnitCost.Text = "0.00";
         
                
                ItemSelect = false;

                if (cmbItem.Items.Count>0)
                {
                    cmbItem.SelectedIndex = 0;
                    
                }
                btnSave.Text = "Add";
                
            }
            catch (Exception ex)
            {
                
               MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmGRNMATDirect_Load(object sender, EventArgs e)
        {
            try
            {
                
                
               LoadDirect();

               objStore = objStoreDL.Get(StoreID);
               objDepartment = objDepartmentDL.Get(objStore.StoreDepartment.DepID);
               txtDepartment.Text = objDepartment.DepName;
               txtStores.Text = objStore.StoreDescription;

            }
            catch (Exception ex)
            {
                
               MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ValidateQuantity()
        {
             try
            {
                if(Convert.ToDecimal(txtNetQty.Text)!=0)
                {
                    //if(txtNetQty.Text.SkipWhile(c => c!='.').Skip(1).Count()
                    //{

                    //    ItemSelect=true;
                    //}
                    //else
                    //{
                    //    ItemSelect=false;
                    //}
                }

            }
            catch (Exception ex)
            {
                ItemSelect=false;

                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        private void cmbGRN_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ClearItem();
                cmbItem.DataSource = null;
                cmbItem.Text = "";
                objGRNMaterialsCollec.Clear();
                bindItemList.DataSource = null;
                txtUnitCost.ReadOnly = true;

            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            Material objMaterial = new Material();
            GRNMaterials objGRNMaterialsTemp = new GRNMaterials();

            bool ItemInList = false;
            try
            {
                if (txtNetQty.Text.Equals("") || txtUnitCost.Text.Equals(""))
                {
                    MessageBox.Show(this, "Please Fill all fields", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else 
                {
                
                    if (txtNetQty.Text != "0")
                    {
                            if (ItemSelect)
                            {
                                objGRNMaterialsCollec.Delete(objGRNMaterials);

                            }
                            objMaterial = objMaterialDL.Get(cmbItem.SelectedValue.ToString());

                            objGRNMaterialsTemp.Material = objMaterial;

                            objGRNMaterialsTemp.GrossQty = Convert.ToDecimal(txtNetQty.Text);
                            objGRNMaterialsTemp.NetQty = Convert.ToDecimal(txtNetQty.Text);


                            objGRNMaterialsTemp.Remarks = "N/A";
                            objGRNMaterialsTemp.UnitPrice = Convert.ToDecimal(txtUnitCost.Text);
                            foreach (GRNMaterials obj in objGRNMaterialsCollec)
                            {
                                if (obj.Material.MaterialCode == objMaterial.MaterialCode)
                                {
                                    MessageBox.Show(this, "This item already added to the list, You can't add same item repeatedly to a GRN. If you want GRN same item again Please create a another GRN", "Item already Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    ItemInList = true;
                                    break;
                                }
                            }
                            if (!ItemInList)
                            {
                                objGRNMaterialsCollec.Add(objGRNMaterialsTemp);
                                bindItemList.DataSource = objGRNMaterialsCollec;
                                ClearItem();
                            }
                            ItemInList = false;
                            bindItemList.ResetBindings(false);
                      
                       
                            ItemInList = false;
                            bindItemList.ResetBindings(false);
                        }
                    }
                }
            catch (FormatException fex)
            {
                MessageBox.Show(this, fex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                objMaterial = null;
            } 
	}
        

        private void gvItemList_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                if (objGRN.GRNType == GRN.Type.Material)
                {
                    objGRNMaterials = (GRNMaterials)gvItemList.Rows[e.RowIndex].DataBoundItem;
                    cmbItem.SelectedValue = objGRNMaterials.Material.MaterialCode;
                    
                    txtNetQty.Text = objGRNMaterials.NetQty.ToString();
                    txtUnitCost.Text = objGRNMaterials.UnitPrice.ToString();
                    ItemSelect = true;
                    btnSave.Text = "Save";

                }
         
            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearItem();
        }

        private void txtNetQty_Validated(object sender, EventArgs e)
        {
            try
            {
                Convert.ToDecimal(txtNetQty.Text);
                errorProvider1.SetError(txtNetQty, "");
            }
            catch (Exception)
            {

                errorProvider1.SetError(txtNetQty, "Quantity should be a Numaric value");
            }
        }


        private void txtUnitCost_Validated(object sender, EventArgs e)
        {
            try
            {
                Convert.ToDecimal(txtUnitCost.Text);
                errorProvider1.SetError(txtUnitCost, "");
            }
            catch (Exception)
            {

                errorProvider1.SetError(txtUnitCost, "Unit Cost should be a Numaric value");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (objGRN.GRNType == GRN.Type.Material)
                {
                    if (ItemSelect)
                    {
                        objGRNMaterialsCollec.Delete(objGRNMaterials);
                        ClearItem();
                    }

                }
                bindItemList.ResetBindings(false);
            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnGRN_Click(object sender, EventArgs e)
        {
            try
            {
                if (gvItemList.Rows.Count>0)
                {
                    objGRN.GRNApprovedBy = "N/A";
                    objGRN.GRNApprovedDate = DateTime.Now;
                    objGRN.GRNDate = DateTime.Now;
                    objGRN.GRNEnterdBy = CurrentUser.UserEmp.EmployeeID;
                    // objGRN.GRNMR = objMR;
                    //objGRN.GRNMTNNo = objMTN;
                    objGRN.GRNRPDBatch = "N/A";
                    objGRN.GRNStatus = GRN.Status.Initial;
                    objGRN.GRNStore = objStore;
                    objGRN.GRNCategory = 0;


                    objGRN_Payment.InvoiceNo = "N/A";
                    objGRN_Payment.PONo = "N/A";
                    objGRN_Payment.Supplier = "N/A";

                    objGRN_Payment.InvoiceType = "N/A";
                    


                    if ((objGRN_Payment.PONo == "") | (objGRN_Payment.InvoiceNo == "") | (objGRN_Payment.Supplier == ""))
                    {
                        MessageBox.Show(this, "Can Not Allow to GRN", "Missing PO/Invoice/Supplier", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    {
                        objGRN.GRNNo = objGRNDL.Add_Direct(objGRN);

                        objGRN_Payment.GRNNo = objGRN.GRNNo;

                        //
                        objGRN_Payment_DL.Add(objGRN_Payment);

                        //
                    }

                    if (objGRN.GRNNo > 0)
                    {
                        if (objGRN.GRNType == GRN.Type.Material)
                        {
                            foreach (GRNMaterials obj in objGRNMaterialsCollec)
                            {
                                obj.GRN = objGRN;
                                objGRNMaterialsDL.Add(obj);
                            }
                        }


                        

                        MessageBox.Show(this, "Suceessfully add to the Stock", "Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();


                    }
                }
                else
                {
                    MessageBox.Show(this,"There are no Items in the List, Please add Items before Continue","Item List Empty",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbStore_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtNetQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.Validate_3Decimals(sender, e);
        }

        private void txtUnitCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.Validate_2Decimals(sender, e);
        }
    }
}