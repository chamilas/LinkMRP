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
    public partial class frmAddStock : System.Windows.Forms.Form
    {
        private User _objCurrentUser;

        public User CurrentUser
        {
            get { return _objCurrentUser; }
            set { _objCurrentUser = value; }
        }

        Department_DL objDepartmentDL = new Department_DL(ConnectionStringClass.GetConnection());
        Store_DL objStoreDL = new Store_DL(ConnectionStringClass.GetConnection());
        MR_DL objMRDL = new MR_DL(ConnectionStringClass.GetConnection());
        MTN_DL objMTNDL = new MTN_DL(ConnectionStringClass.GetConnection());

        Department objDepartment = new Department();
        Store objStore = new Store();

        MTN objMTN = new MTN();
        MR objMR = new MR();

        Material_DL objMaterialDL = new Material_DL(ConnectionStringClass.GetConnection());
        BasicProduct_DL objBasicProductDL = new BasicProduct_DL(ConnectionStringClass.GetConnection());
        FinishProduct_DL objFinishProductDL = new FinishProduct_DL(ConnectionStringClass.GetConnection());

        GRN objGRN = new GRN();
        GRN_DL objGRNDL = new GRN_DL(ConnectionStringClass.GetConnection());

        GRNMaterials objGRNMaterials = new GRNMaterials();
        GRNBasicProducts objGRNBasicProduct = new GRNBasicProducts();
        GRNFinishProducts objGRNFinishProduct = new GRNFinishProducts();

        GRNMaterialsCollec objGRNMaterialsCollec = new GRNMaterialsCollec();
        GRNBasicProductsCollec objGRNBasicProductCollec = new GRNBasicProductsCollec();
        GRNFinishProductsCollec objGRNFinishProductCollec = new GRNFinishProductsCollec();

        GRNMaterials_DL objGRNMaterialsDL = new GRNMaterials_DL(ConnectionStringClass.GetConnection());
        GRNBasicProducts_DL objGRNBasicProductDL = new GRNBasicProducts_DL(ConnectionStringClass.GetConnection());
        GRNFinishProducts_DL objGRNFinishProductDL = new GRNFinishProducts_DL(ConnectionStringClass.GetConnection());

        MRMaterial_DL objMRMaterialDL = new MRMaterial_DL(ConnectionStringClass.GetConnection());
        MRBasicProduct_DL objMRBasicProductDL = new MRBasicProduct_DL(ConnectionStringClass.GetConnection());
        MRFinishProduct_DL objMRFiishProductDL = new MRFinishProduct_DL(ConnectionStringClass.GetConnection());

        MTNMaterial_DL objMTNMaterialDL = new MTNMaterial_DL(ConnectionStringClass.GetConnection());
        MTNBasicProduct_DL objMTNBasicProductDL = new MTNBasicProduct_DL(ConnectionStringClass.GetConnection());
        MTNFinishProduct_DL objMTNFinishProductDL = new MTNFinishProduct_DL(ConnectionStringClass.GetConnection());


        bool ItemSelect = false;

        //--------------- Methods --------------------

        public void LoadDirect()
        {
            try
            {
                if (cmbGRNType.SelectedItem.Equals("Material"))
                {
                    cmbItem.DataSource = objMaterialDL.GetDataView();
                    cmbItem.DisplayMember = "Material";
                    cmbItem.ValueMember = "MaterialCode";
                    objGRN.GRNType = GRN.Type.Material;
                }
                else if (cmbGRNType.SelectedItem.Equals("Basic Product"))
                {
                    cmbItem.DataSource = objBasicProductDL.GetDataView();
                    cmbItem.DisplayMember = "BasicProduct";
                    cmbItem.ValueMember = "BasicProductCode";
                    objGRN.GRNType = GRN.Type.BasicProduct;
                }
                else if (cmbGRNType.SelectedItem.Equals("Finish Product"))
                {
                    cmbItem.DataSource = objFinishProductDL.GetDataView(1);
                    cmbItem.DisplayMember = "FinishProduct";
                    cmbItem.ValueMember = "FinishProductCode";
                    objGRN.GRNType = GRN.Type.FinishProduct;
                }
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
                txtRemarks.Text = "";
                txtUnitCost.Text = "0.00";
                ItemSelect = false;

                if (cmbItem.Items.Count > 0)
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

        public frmAddStock()
        {
            InitializeComponent();
        }


        public frmAddStock(User objUser)
        {
            InitializeComponent();
            CurrentUser = objUser;
        }

        private void cmbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                objDepartment = (Department)cmbDepartment.SelectedItem;
                cmbStore.DataSource = objStoreDL.Get(objDepartment.DepID);
                cmbStore.DisplayMember = "StoreName";


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
                objStore = (Store)cmbStore.SelectedItem;
            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbGRNType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearItem();
            try
            {

                objGRNMaterialsCollec.Clear();
                objGRNBasicProductCollec.Clear();
                objGRNFinishProductCollec.Clear();
                bindItemList.DataSource = null;
                LoadDirect();



            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtItemDetails.Clear();
            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            BasicProduct objBasic = new BasicProduct();
            FinishProduct objFinishProduct = new FinishProduct();
            Material objMaterial = new Material();

            GRNMaterials objGRNMaterialsTemp = new GRNMaterials();
            GRNBasicProducts objGRNBasicProductTemp = new GRNBasicProducts();
            GRNFinishProducts objGRNFinishProductTemp = new GRNFinishProducts();

            bool ItemInList = false;
            try
            {
                if (txtNetQty.Text.Equals("") || txtUnitCost.Text.Equals(""))
                {
                    MessageBox.Show(this, "Please Fill all fields", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    bool Quantity = true;
                    
                    if (Quantity)
                    {
                        if (objGRN.GRNType == GRN.Type.Material)
                        {
                            if (ItemSelect)
                            {
                                objGRNMaterialsCollec.Delete(objGRNMaterials);

                            }
                            objMaterial = objMaterialDL.Get(cmbItem.SelectedValue.ToString());

                            objGRNMaterialsTemp.Material = objMaterial;

                            objGRNMaterialsTemp.GrossQty = Convert.ToDecimal(txtNetQty.Text);
                            objGRNMaterialsTemp.NetQty = Convert.ToDecimal(txtNetQty.Text);


                            objGRNMaterialsTemp.Remarks = txtRemarks.Text;
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
                        }
                        else if (objGRN.GRNType == GRN.Type.BasicProduct)
                        {
                            if (ItemSelect)
                            {
                                objGRNBasicProductCollec.Delete(objGRNBasicProduct);

                            }
                            objBasic = objBasicProductDL.Get(cmbItem.SelectedValue.ToString());
                            objGRNBasicProductTemp.GrossQty = Convert.ToDecimal(txtNetQty.Text);
                            objGRNBasicProductTemp.BasicProduct = objBasic;
                            objGRNBasicProductTemp.NetQty = Convert.ToDecimal(txtNetQty.Text);
                            objGRNBasicProductTemp.Remarks = txtRemarks.Text;
                            objGRNBasicProductTemp.UnitPrice = Convert.ToDecimal(txtUnitCost.Text);
                            foreach (GRNBasicProducts obj in objGRNBasicProductCollec)
                            {
                                if (obj.BasicProduct.BasicProductCode == objBasic.BasicProductCode)
                                {
                                    MessageBox.Show(this, "This item already added to the list, You can't add same item repeatedly to a GRN. If you want GRN same item again Please create a another GRN", "Item already Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    ItemInList = true;
                                    break;
                                }
                            }
                            if (!ItemInList)
                            {
                                objGRNBasicProductCollec.Add(objGRNBasicProductTemp);
                                bindItemList.DataSource = objGRNBasicProductCollec;
                                ClearItem();
                            }
                            ItemInList = false;
                            bindItemList.ResetBindings(false);
                        }
                        else if (objGRN.GRNType == GRN.Type.FinishProduct)
                        {

                            if (ItemSelect)
                            {
                                objGRNFinishProductCollec.Delete(objGRNFinishProduct);

                            }
                            objFinishProduct = objFinishProductDL.Get(cmbItem.SelectedValue.ToString());
                            objGRNFinishProductTemp.GrossQty = Convert.ToDecimal(txtNetQty.Text);
                            objGRNFinishProductTemp.FinishProducts = objFinishProduct;
                            objGRNFinishProductTemp.NetQty = Convert.ToDecimal(txtNetQty.Text);
                            objGRNFinishProductTemp.Remarks = txtRemarks.Text;
                            objGRNFinishProductTemp.UnitPrice = Convert.ToDecimal(txtUnitCost.Text);
                            foreach (GRNFinishProducts obj in objGRNFinishProductCollec)
                            {
                                if (obj.FinishProducts.FinishProductCode == objFinishProduct.FinishProductCode)
                                {
                                    MessageBox.Show(this, "This item already added to the list, You can't add same item repeatedly to a GRN. If you want GRN same item again Please create a another GRN", "Item already Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    ItemInList = true;
                                    break;
                                }
                            }
                            if (!ItemInList)
                            {
                                objGRNFinishProductCollec.Add(objGRNFinishProductTemp);
                                bindItemList.DataSource = objGRNFinishProductCollec;
                                ClearItem();
                            }
                            ItemInList = false;
                            bindItemList.ResetBindings(false);
                        }
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
                objBasic = null;
                objFinishProduct = null;
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
                else if (objGRN.GRNType == GRN.Type.BasicProduct)
                {
                    objGRNBasicProductCollec.Delete(objGRNBasicProduct);
                    ClearItem();
                }
                else if (objGRN.GRNType == GRN.Type.FinishProduct)
                {
                    objGRNFinishProductCollec.Delete(objGRNFinishProduct);
                    ClearItem();
                }
                bindItemList.ResetBindings(false);
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

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGRN_Click(object sender, EventArgs e)
        {
            try
            {
                if (gvItemList.Rows.Count > 0)
                {
                    objGRN.GRNApprovedBy = "N/A";
                    objGRN.GRNApprovedDate = DateTime.Now;
                    objGRN.GRNDate = DateTime.Now;
                    objGRN.GRNEnterdBy = CurrentUser.UserEmp.EmployeeID;
                    objGRN.GRNRPDBatch = null;
                    objGRN.GRNStatus = GRN.Status.Initial;
                    objGRN.GRNStore = objStore;
                    objGRN.GRNCategory = 1;
                    objGRN.GRNNo = objGRNDL.Add_Direct(objGRN);
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
                        else if (objGRN.GRNType == GRN.Type.BasicProduct)
                        {
                            foreach (GRNBasicProducts obj in objGRNBasicProductCollec)
                            {
                                obj.GRN = objGRN;
                                objGRNBasicProductDL.Add(obj);
                            }
                        }
                        else if (objGRN.GRNType == GRN.Type.FinishProduct)
                        {
                            foreach (GRNFinishProducts obj in objGRNFinishProductCollec)
                            {
                                obj.GRN = objGRN;
                                objGRNFinishProductDL.Add(obj);
                            }
                        }

                        objGRNDL.Approve(objGRN);
                        MessageBox.Show(this, "Suceessfully add to the Stock", "Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();

                    }
                }
                else
                {
                    MessageBox.Show(this, "There are no Items in the List, Please add Items before Continue", "Item List Empty", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void frmAddStock_Load(object sender, EventArgs e)
        {
            try
            {
                
                cmbGRNType.SelectedIndex = 0;


                cmbDepartment.DataSource = objDepartmentDL.GetDataView();
                LoadDirect();
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
                    if (objGRN.GRNType == GRN.Type.Material)
                    {
                        objGRNMaterials = (GRNMaterials)gvItemList.Rows[e.RowIndex].DataBoundItem;
                        cmbItem.SelectedValue = objGRNMaterials.Material.MaterialCode;

                        txtNetQty.Text = objGRNMaterials.NetQty.ToString();
                        txtRemarks.Text = objGRNMaterials.Remarks;
                        txtUnitCost.Text = objGRNMaterials.UnitPrice.ToString();
                        ItemSelect = true;
                        btnSave.Text = "Save";

                    }
                    else if (objGRN.GRNType == GRN.Type.BasicProduct)
                    {
                        objGRNBasicProduct = (GRNBasicProducts)gvItemList.Rows[e.RowIndex].DataBoundItem;
                        cmbItem.SelectedValue = objGRNBasicProduct.BasicProduct.BasicProductCode;

                        txtNetQty.Text = objGRNBasicProduct.NetQty.ToString();
                        txtRemarks.Text = objGRNBasicProduct.Remarks;
                        txtUnitCost.Text = objGRNBasicProduct.UnitPrice.ToString();
                        ItemSelect = true;
                        btnSave.Text = "Save";


                    }
                    else if (objGRN.GRNType == GRN.Type.FinishProduct)
                    {
                        objGRNFinishProduct = (GRNFinishProducts)gvItemList.Rows[e.RowIndex].DataBoundItem;
                        cmbItem.SelectedValue = objGRNFinishProduct.FinishProducts.FinishProductCode;

                        txtNetQty.Text = objGRNFinishProduct.NetQty.ToString();
                        txtRemarks.Text = objGRNFinishProduct.Remarks;
                        txtUnitCost.Text = objGRNFinishProduct.UnitPrice.ToString();
                        ItemSelect = true;
                        btnSave.Text = "Save";

                    } 
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}