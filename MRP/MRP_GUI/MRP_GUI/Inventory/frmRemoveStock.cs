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
    public partial class frmRemoveStock : System.Windows.Forms.Form
    {
        //-------------------- Variables ---------------------
        private User _objCurrentUser;

        public User CurrentUser
        {
            get { return _objCurrentUser; }
            set { _objCurrentUser = value; }
        }

        MTN objMTN = new MTN();
        MTN_DL objMTNDL = new MTN_DL(ConnectionStringClass.GetConnection());
        MTNBasicProductCollec objMTNBasicProductCollec = new MTNBasicProductCollec();
        MTNBasicProduct_DL objMTNBasicProductDL = new MTNBasicProduct_DL(ConnectionStringClass.GetConnection());
        MTNFinishProductCollec objMTNFinishProductCollec = new MTNFinishProductCollec();
        MTNFinishProduct_DL objMTNFinisProductDL = new MTNFinishProduct_DL(ConnectionStringClass.GetConnection());
        MTNMaterial_DL objMTNMaterialDL = new MTNMaterial_DL(ConnectionStringClass.GetConnection());
        MTNMaterialCollc objMTNMaterialCollec = new MTNMaterialCollc();

        Department_DL objDepartmentDL = new Department_DL(ConnectionStringClass.GetConnection());
        Store_DL objStoreDL = new Store_DL(ConnectionStringClass.GetConnection());

        Material_DL objMaterialDL = new Material_DL(ConnectionStringClass.GetConnection());
        BasicProduct_DL objBasicProductDL = new BasicProduct_DL(ConnectionStringClass.GetConnection());
        FinishProduct_DL objFinishProductDL = new FinishProduct_DL(ConnectionStringClass.GetConnection());

        GRN_DL objGRNDL = new GRN_DL(ConnectionStringClass.GetConnection());

        DataTable dt = new DataTable();

        Material objMaterial = new Material();
        BasicProduct objBasicProduct = new BasicProduct();
        FinishProduct objFinishProduct = new FinishProduct();

        MTNBasicProduct objMtnBasic = new MTNBasicProduct();
        MTNFinishProduct objMTNFinish = new MTNFinishProduct();
        MTNMaterial objMTNMaterial = new MTNMaterial();


        bool ItemSelect = false;
        public frmRemoveStock(User objUser)
        {
            CurrentUser = objUser;
            InitializeComponent();
        }

        public void ClearItem()
        {
            txtQty.Text = "0.00";
            txtRemarks.Text = "";
            ItemSelect = false;
        }
        private void cmbMTNType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cmbItem.DataSource = null;

                if (cmbStoreFrom.Items.Count > 0)
                {
                    Store objStore = (Store)cmbStoreFrom.SelectedItem;

                    if (cmbMTNType.SelectedItem.Equals("Material"))
                    {
                        cmbItem.DisplayMember = "Item";
                        cmbItem.ValueMember = "ItemCode";
                        cmbItem.DataSource = objMaterialDL.GetDataView_Store(objStore.StoreID);

                    }
                    else if (cmbMTNType.SelectedItem.Equals("Basic Product"))
                    {
                        cmbItem.DisplayMember = "Item";
                        cmbItem.ValueMember = "ItemCode";
                        cmbItem.DataSource = objBasicProductDL.GetDataView_Store(objStore.StoreID);

                    }
                    else if (cmbMTNType.SelectedItem.Equals("Finish Product"))
                    {
                        cmbItem.DisplayMember = "Item";
                        cmbItem.ValueMember = "ItemCode";
                        cmbItem.DataSource = objFinishProductDL.GetDataView_Store(objStore.StoreID);


                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbDepartmentFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Department objDep = (Department)cmbDepartmentFrom.SelectedItem;
                cmbStoreFrom.DataSource = objStoreDL.Get(objDep.DepID);
                cmbStoreFrom.DisplayMember = "StoreName";

            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbStoreFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                dt.Rows.Clear();
                this.ClearItem();
                cmbItem.DataSource = null;
                if (cmbStoreFrom.Items.Count > 0)
                {
                    Store objStore = (Store)cmbStoreFrom.SelectedItem;
                    cmbItem.DisplayMember = "Item";
                    cmbItem.ValueMember = "ItemCode";
                    if (cmbMTNType.SelectedItem.Equals("Material"))
                    {

                        cmbItem.DataSource = objMaterialDL.GetDataView_Store(objStore.StoreID);

                    }
                    else if (cmbMTNType.SelectedItem.Equals("Basic Product"))
                    {

                        cmbItem.DataSource = objBasicProductDL.GetDataView_Store(objStore.StoreID);

                    }
                    else if (cmbMTNType.SelectedItem.Equals("Finish Product"))
                    {
                        cmbItem.DataSource = objFinishProductDL.GetDataView_Store(objStore.StoreID);
                    }
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            Material objMat = new Material();
            BasicProduct objBasic = new BasicProduct();
            FinishProduct objFinish = new FinishProduct();
            Store objStore = new Store();
            Stock_DL objStockDL = new Stock_DL(ConnectionStringClass.GetConnection());


            try
            {
                String ItemCode = "";
                txtUnit.Text = "";
                txtAvailableQty.Text = "";
                if (cmbItem.Items.Count > 0 && cmbItem.SelectedValue != null)
                {

                    ItemCode = cmbItem.SelectedValue.ToString();

                    objStore = (Store)cmbStoreFrom.SelectedItem;
                    if (cmbMTNType.SelectedItem.Equals("Material"))
                    {
                        objMat = objMaterialDL.Get(ItemCode);
                        txtUnit.Text = objMat.MatUnit.UnitName;
                        //txtGRNUnitCost.Text = objStockDL.GetAVGUnitPrice_Material(objStore.StoreID, ItemCode).ToString();
                        txtAvailableQty.Text = objStockDL.GetAvailableQty(objStore.StoreID, ItemCode, Stock.Type.Material).ToString();
                    }
                    else if (cmbMTNType.SelectedItem.Equals("Basic Product"))
                    {
                        objBasic = objBasicProductDL.Get(ItemCode);
                        txtUnit.Text = objBasic.BasicProductUnit.UnitName;
                        //txtGRNUnitCost.Text = objStockDL.GetAVGUnitPrice_BasicProduct(objStore.StoreID, ItemCode).ToString();
                        txtAvailableQty.Text = objStockDL.GetAvailableQty(objStore.StoreID, ItemCode, Stock.Type.BasicProduct).ToString();
                    }
                    else if (cmbMTNType.SelectedItem.Equals("Finish Product"))
                    {
                        objFinish = objFinishProductDL.Get(ItemCode);
                        txtUnit.Text = objFinish.FinishProductPackingType.PackingTitle;
                        //txtGRNUnitCost.Text = objStockDL.GetAVGUnitPrice_FinishProduct(objStore.StoreID, ItemCode).ToString();
                        txtAvailableQty.Text = objStockDL.GetAvailableQty(objStore.StoreID, ItemCode, Stock.Type.FinishProduct).ToString();
                    }
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

        private void btnItemAdd_Click(object sender, EventArgs e)
        {
            if (cmbItem.Items.Count <= 0)
            {
                MessageBox.Show(this, "There are no Items in the List,Selected a Store does not have any Stock", "Empty Item List", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtQty.Text.Equals(""))
            {
                MessageBox.Show(this, "Please enter quantity you want to Transfer", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Convert.ToDecimal(txtAvailableQty.Text) < Convert.ToDecimal(txtQty.Text))
            {
                MessageBox.Show(this, "Insufficient Available Quantity, Please check the quantity that you enterd", "Insufficient Stock", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                try
                {


                    String ItemCode = "";
                    if (cmbItem.Items.Count > 0 && cmbItem.SelectedValue != null)
                    {

                        ItemCode = cmbItem.SelectedValue.ToString();
                        bool IsInList = false;

                        if (ItemSelect)
                        {
                            foreach (DataRow dr in dt.Rows)
                            {
                                if (ItemCode == dr["ItemCode"].ToString())
                                {
                                    dt.Rows.Remove(dr);
                                    ItemSelect = false;
                                    break;
                                }
                            }
                        }


                        foreach (DataRow dr in dt.Rows)
                        {
                            if (ItemCode == dr["ItemCode"].ToString())
                            {
                                MessageBox.Show(this, "Selected Item Already in the List,Please Select the record and Update", "Item Already Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                IsInList = true;
                                break;
                            }
                        }

                        if (!IsInList)
                        {
                            if (cmbMTNType.SelectedItem.Equals("Material"))
                            {
                                objMaterial = objMaterialDL.Get(ItemCode);
                                objMTNMaterial.Batch = "";
                                objMTNMaterial.Description = txtRemarks.Text;
                                objMTNMaterial.Material = objMaterial;
                                objMTNMaterial.MTN = new MTN();
                                objMTNMaterial.ReceivedQty = 0;
                                objMTNMaterial.TransferQty = Convert.ToDecimal(txtQty.Text);
                                objMTNMaterial.UnitRate = 0;

                                dt.Rows.Add(objMTNMaterial.Material.MaterialCode, objMTNMaterial.Material.MaterialNameCode, objMTNMaterial.Description, objMTNMaterial.TransferQty, objMTNMaterial.Material.MatUnit.UnitCode);
                                bindMTNList.DataSource = dt;

                            }
                            else if (cmbMTNType.SelectedItem.Equals("Basic Product"))
                            {
                                objBasicProduct = objBasicProductDL.Get(ItemCode);
                                objMtnBasic.BasicProduct = objBasicProduct;
                                objMtnBasic.Batch = "";
                                objMtnBasic.Description = txtRemarks.Text;
                                objMtnBasic.MTN = new MTN();
                                objMtnBasic.ReceivedQty = 0;
                                objMtnBasic.TransferQty = Convert.ToDecimal(txtQty.Text);
                                objMtnBasic.UnitRate = 0;

                                dt.Rows.Add(objMtnBasic.BasicProduct.BasicProductCode, objMtnBasic.BasicProduct.Code, objMtnBasic.Description, objMtnBasic.TransferQty, objMtnBasic.BasicProduct.BasicProductUnit.UnitCode);
                                bindMTNList.DataSource = dt;

                            }
                            else if (cmbMTNType.SelectedItem.Equals("Finish Product"))
                            {
                                objFinishProduct = objFinishProductDL.Get(ItemCode);
                                objMTNFinish.Batch = "";
                                objMTNFinish.Description = txtRemarks.Text;
                                objMTNFinish.FinishProduct = objFinishProduct;
                                objMTNFinish.MTN = new MTN();
                                objMTNFinish.ReceivedQty = 0;
                                objMTNFinish.TransferQty = Convert.ToDecimal(txtQty.Text);
                                objMTNFinish.UnitRate = 0;

                                dt.Rows.Add(objMTNFinish.FinishProduct.FinishProductCode, objMTNFinish.FinishProduct.Code, objMTNFinish.Description, objMTNFinish.TransferQty, objMTNFinish.FinishProduct.FinishProductPackingType.PackingTitle);
                                bindMTNList.DataSource = dt;
                            }

                            ClearItem();
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

                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearItem();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MTNMaterial objMTNMat = new MTNMaterial();
            MTNBasicProduct objMTNBasic = new MTNBasicProduct();
            MTNFinishProduct objMTNFinish = new MTNFinishProduct();

            Department objDepFrom = new Department();
            Department objDepTo = new Department();

            Store objStore = new Store();
            Material objMaterial = new Material();
            FinishProduct objFinishProduct = new FinishProduct();
            BasicProduct objBasicProduct = new BasicProduct();
            GRN objGRN = new GRN();

            try
            {


                String ItemCode = "";
                if (cmbItem.Items.Count > 0 && cmbItem.SelectedValue != null)
                {
                    ItemCode = cmbItem.SelectedValue.ToString();
                }


                if (cmbDepartmentFrom.Items.Count > 0)
                {
                    objDepFrom = (Department)cmbDepartmentFrom.SelectedItem;
                    objDepTo = (Department)cmbDepartmentFrom.SelectedItem;
                }

                if (cmbStoreFrom.Items.Count > 0)
                {
                    objStore = (Store)cmbStoreFrom.SelectedItem;
                }

                objMTN.MTNDepartmentFrom = objDepFrom;
                objMTN.MTNDepartmentTo = objDepTo;
                objMTN.MTNEnterdBy = CurrentUser.UserEmp;
                objMTN.MTNStatus = MTN.Status.Initial;
                objMTN.MTNType = MTN.Type.Dispose;
                objMTN.MTNStore = objStore;
                if (cmbMTNType.SelectedItem.Equals("Basic Product"))
                {

                    objMTN.MTNItemType = MTN.ItemType.Basic_Product;


                    objMTN.MTNNo = objMTNDL.Add_Other(objMTN);

                    if (objMTN.MTNNo > 0)
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            objBasicProduct = objBasicProductDL.Get(dr["ItemCode"].ToString());
                            objMTNBasic.Batch = "";
                            objMTNBasic.Description = dr["Remarks"].ToString();
                            objMTNBasic.BasicProduct = objBasicProduct;
                            objMTNBasic.MTN = objMTN;
                            objMTNBasic.TransferQty = Convert.ToDecimal(dr["Qty"].ToString());
                            objMTNBasicProductDL.Add(objMTNBasic);
                        }


                    }

                }
                else if (cmbMTNType.SelectedItem.Equals("Material"))
                {
                    objMTN.MTNItemType = MTN.ItemType.Material;


                    objMTN.MTNNo = objMTNDL.Add_Other(objMTN);

                    if (objMTN.MTNNo > 0)
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            objMaterial = objMaterialDL.Get(dr["ItemCode"].ToString());


                            objMTNMat.Batch = "";
                            objMTNMat.Description = dr["Remarks"].ToString();
                            objMTNMat.Material = objMaterial;
                            objMTNMat.MTN = objMTN;
                            objMTNMat.TransferQty = Convert.ToDecimal(dr["Qty"]);
                            objMTNMaterialDL.Add(objMTNMat);
                        }

                    }
                }
                else if (cmbMTNType.SelectedItem.Equals("Finish Product"))
                {
                    objMTN.MTNItemType = MTN.ItemType.Finish_Product;


                    objMTN.MTNNo = objMTNDL.Add_Other(objMTN);

                    if (objMTN.MTNNo > 0)
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            objFinishProduct = objFinishProductDL.Get((cmbItem.SelectedValue.ToString()));
                            objMTNFinish.Batch = "";
                            objMTNFinish.Description = dr["Remarks"].ToString();
                            objMTNFinish.FinishProduct = objFinishProduct;
                            objMTNFinish.MTN = objMTN;
                            objMTNFinish.TransferQty = Convert.ToDecimal(dr["Qty"]);
                            objMTNFinisProductDL.Add(objMTNFinish);
                        }

                    }
                }
                int x = Approve();
                if (x > 0)
                {
                    MessageBox.Show(this,"Stock Reduced","Successfull",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    this.Close();
                }
               


            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int Approve()
        {
            MTNMaterial_DL objMTNMatDL = new MTNMaterial_DL(ConnectionStringClass.GetConnection());
            MTNBasicProduct_DL objMTNBasicDL = new MTNBasicProduct_DL(ConnectionStringClass.GetConnection());
            MTNFinishProduct_DL objMTNFinishDL = new MTNFinishProduct_DL(ConnectionStringClass.GetConnection());
            try
            {
                objMTN.MTNStatus = MTN.Status.Approved;
                objMTN.MTNApprovedBy = CurrentUser.UserEmp;
                objMTN.MTNApprovedDate = DateTime.Now;

                if (objMTN.MTNType == MTN.Type.Dispose)
                {

                    int result = 0;
                    #region
                    if (objMTN.MTNItemType == MTN.ItemType.Material)
                    {
                        result = objMTNDL.Approve((int)MR.Status.Approved, CurrentUser.UserEmp.EmployeeID, objMTN.MTNStore.StoreID, objMTN.MTNNo);
                        if (result == 1)
                        {

                        }
                        else if (result == -1)
                        {
                            MessageBox.Show(this, "Cannot perform the Request, Stock level is low than Requested. Please Check the Stock Levels and GRN Quantity", "Stock Level is Low", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    #endregion
                    #region
                    else if (objMTN.MTNItemType == MTN.ItemType.Basic_Product)
                    {
                        result = objMTNDL.Approve((int)MR.Status.Approved,CurrentUser.UserEmp.EmployeeID, objMTN.MTNStore.StoreID, objMTN.MTNNo);
                        if (result == 1)
                        {

                        }
                        else if (result == -1)
                        {
                            MessageBox.Show(this, "Cannot perform the Request, Stock level is low than Requested. Please Check the Stock Levels and GRN Quantity", "Stock Level is Low", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    #endregion
                    #region
                    else if (objMTN.MTNItemType == MTN.ItemType.Finish_Product)
                    {
                        //result = objMTNFinishDL.Issue_GRN(objMTN);
                        if (result == 1)
                        {

                        }
                        else if (result == -1)
                        {
                            MessageBox.Show(this, "Cannot perform the Request, Stock level is low than Requested. Please Check the Stock Levels and GRN Quantity", "Stock Level is Low", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    #endregion
                    return 1;
                }
                return 0;
            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }





        private void gvMTNList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataRow dr = dt.Rows[e.RowIndex];
                txtQty.Text = dr["Qty"].ToString();
                txtRemarks.Text = dr["Remarks"].ToString();
                cmbItem.SelectedValue = dr["ItemCode"].ToString();
                ItemSelect = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmRemoveStock_Load(object sender, EventArgs e)
        {
            try
            {
                cmbMTNType.SelectedIndex = 0;
                cmbDepartmentFrom.DataSource = objDepartmentDL.Get();
                //cmbDepartmentTo.DataSource = objDepartmentDL.Get();

                dt.Columns.Add("ItemCode");
                dt.Columns.Add("Item");
                dt.Columns.Add("Remarks");
                dt.Columns.Add("Qty");
                dt.Columns.Add("Unit");


            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gvMTNList_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            
        }

        private void gvMTNList_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult dr = MessageBox.Show(this,"Are you sure you want to delete selected record?","Confirm Delete",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.No)
            {
                e.Cancel = true;
                
            }
        }
    }
}