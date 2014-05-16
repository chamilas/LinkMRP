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
    public partial class frmMTN : System.Windows.Forms.Form
    {
        public frmMTN()
        {
            InitializeComponent();
        }

        public frmMTN(User objUser)
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

        MTN objMTN = new MTN();
        MTN_DL objMTNDL = new MTN_DL(ConnectionStringClass.GetConnection());
        MTNBasicProductCollec objMTNBasicProductCollec = new MTNBasicProductCollec();
        MTNBasicProduct_DL objMTNBasicProductDL = new MTNBasicProduct_DL(ConnectionStringClass.GetConnection());
        MTNFinishProductCollec objFinishProductCollec = new MTNFinishProductCollec();
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

        //-------------------- Methods ----------------------

        


        //-------------------- Events -----------------------
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMTN_Load(object sender, EventArgs e)
        {
            try
            {
                cmbMTNType.SelectedIndex = 0;
                cmbDepartmentFrom.DataSource = objDepartmentDL.GetDataView(CurrentUser.EmployeeID);
                cmbDepartmentTo.DataSource = objDepartmentDL.GetDataView();


                dt.Columns.Add("Item");
                dt.Columns.Add("GRNNO");
                dt.Columns.Add("Qty");
                dt.Columns.Add("GRNUnitCost");
                dt.Columns.Add("StockCost");
                dt.Columns.Add("Total");
                dt.Columns.Add("Remarks");
           
                

            }
            catch (Exception ex)
            {
                
               MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void cmbMTNType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cmbItem.DataSource = null;

                if (cmbStoreFrom.Items.Count >0)
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

                cmbStoreFrom.DataSource = objStoreDL.Get(Convert.ToInt64(cmbDepartmentFrom.SelectedValue));
                cmbStoreFrom.DisplayMember = "StoreName";

            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbDepartmentTo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbStoreFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                cmbItem.DataSource = null;
                if (cmbStoreFrom.Items.Count>0)
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
            txtGRNUnitCost.Text = "0.00";
            cmbGRNNO.Text = "";
            txtAvailableQty.Text = "0.00";
            txtStockHoldingCost.Text = "0.00";
            txtGRNQty.Text = "0.00";

            Material objMat = new Material();
            BasicProduct objBasic = new BasicProduct();
            FinishProduct objFinish = new FinishProduct();
            Store objStore = new Store();

            try
            {
                String ItemCode = "";
                txtUnit.Text = "";
                if (cmbItem.Items.Count > 0 && cmbItem.SelectedValue != null)
                {
                    ItemCode = cmbItem.SelectedValue.ToString();
                }


                if (cmbStoreFrom.Items.Count > 0)
                {
                  objStore = (Store)cmbStoreFrom.SelectedItem;
                }

                if (!ItemCode.Equals(""))
                {
                    if (cmbMTNType.SelectedItem.Equals("Material"))
                    {
                        cmbGRNNO.DataSource = objGRNDL.Get_GEN_BY_Material(ItemCode,objStore.StoreID);
                        objMat = objMaterialDL.Get(ItemCode);
                        txtUnit.Text = objMat.MatUnit.UnitName;
                    }
                    else if (cmbMTNType.SelectedItem.Equals("Basic Product"))
                    {
                        cmbGRNNO.DataSource = objGRNDL.Get_GEN_BY_BasicProduct(ItemCode, objStore.StoreID);
                        objBasic = objBasicProductDL.Get(ItemCode);
                        txtUnit.Text = objBasic.BasicProductUnit.UnitName;
                    }
                    else if (cmbMTNType.SelectedItem.Equals("Finish Product"))
                    {
                        cmbGRNNO.DataSource = objGRNDL.Get_GEN_BY_FinishProduct(ItemCode, objStore.StoreID);
                        objFinish = objFinishProductDL.Get(ItemCode);
                        txtUnit.Text = objFinish.FinishProductPackingType.PackingTitle;
                    } 
                }


               
            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbGRNNO_SelectedIndexChanged(object sender, EventArgs e)
        {
            GRNMaterials objGRNMat = new GRNMaterials();
            GRNBasicProducts objGRNBasic = new GRNBasicProducts();
            GRNFinishProducts objGRNFinish = new GRNFinishProducts();

            GRNMaterials_DL objGRNMatDL = new GRNMaterials_DL(ConnectionStringClass.GetConnection());
            GRNBasicProducts_DL objGRNBasicDL = new GRNBasicProducts_DL(ConnectionStringClass.GetConnection());
            GRNFinishProducts_DL objGRNFinishDL = new GRNFinishProducts_DL(ConnectionStringClass.GetConnection());

            GRN_DL objGRNDL = new GRN_DL(ConnectionStringClass.GetConnection());

            try
            {
                long GRNNO = 0;
                if (cmbGRNNO.Items.Count > 0 && cmbGRNNO.SelectedValue != null)
                {
                    GRNNO = Convert.ToInt64(cmbGRNNO.SelectedValue);
                }

                String ItemCode = "";
                if (cmbItem.Items.Count > 0 && cmbItem.SelectedValue != null)
                {
                    ItemCode = cmbItem.SelectedValue.ToString();
                }



                if (!ItemCode.Equals("") && !GRNNO.Equals(""))
                {
                    if (cmbMTNType.SelectedItem.Equals("Material"))
                    {
                        objGRNMat = objGRNMatDL.Get(GRNNO, ItemCode);
                        if (objGRNMat != null)
                        {
                            txtGRNUnitCost.Text = objGRNMat.UnitPrice.ToString();
                            txtAvailableQty.Text = objGRNMatDL.Get_AvailableQty(GRNNO, ItemCode).ToString();
                            txtGRNQty.Text = objGRNMat.NetQty.ToString();
                            //txtStockHoldingCost.Text = objGRNDL.Get_StockHoldingCost(GRNNO, objGRNMat.UnitPrice).ToString();
                        }
                    }
                    else if (cmbMTNType.SelectedItem.Equals("Basic Product"))
                    {
                        objGRNBasic = objGRNBasicDL.Get(GRNNO, ItemCode);
                        if (objGRNBasic != null)
                        {
                            txtGRNUnitCost.Text = objGRNBasic.UnitPrice.ToString();
                            txtAvailableQty.Text = objGRNBasicDL.Get_AvailableQty(GRNNO, ItemCode).ToString();
                            txtGRNQty.Text = objGRNBasic.NetQty.ToString();
                            //txtStockHoldingCost.Text = objGRNDL.Get_StockHoldingCost(GRNNO, objGRNBasic.UnitPrice).ToString();

                        }

                    }
                    else if (cmbMTNType.SelectedItem.Equals("Finish Product"))
                    {
                        objGRNFinish = objGRNFinishDL.Get(GRNNO, ItemCode);
                        if (objGRNFinish != null)
                        {
                            txtGRNUnitCost.Text = objGRNFinish.UnitPrice.ToString();
                            txtAvailableQty.Text = objGRNFinishDL.Get_AvailableQty(GRNNO, ItemCode).ToString();
                            txtGRNQty.Text = objGRNFinish.NetQty.ToString();
                           // txtStockHoldingCost.Text = objGRNDL.Get_StockHoldingCost(GRNNO, objGRNFinish.UnitPrice).ToString();

                        }
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                objGRNMat = null;
                objGRNBasic = null;
                objGRNFinish = null;
                objGRNMatDL = null;
                objGRNBasicDL = null;
                objGRNFinishDL = null;
            }
        }

        private void btnItemAdd_Click(object sender, EventArgs e)
        {
           
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

        private void groupBox2_Enter(object sender, EventArgs e)
        {

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

                if (cmbGRNNO.Items.Count > 0 && cmbGRNNO.SelectedValue != null)
                {
                    objGRN.GRNNo = Convert.ToInt64(cmbGRNNO.SelectedValue);
                }

                String ItemCode = "";
                if (cmbItem.Items.Count > 0 && cmbItem.SelectedValue != null)
                {
                    ItemCode = cmbItem.SelectedValue.ToString();
                }


                if (cmbDepartmentFrom.Items.Count > 0)
                {
                    objDepFrom = objDepartmentDL.Get(Convert.ToInt64(cmbDepartmentFrom.SelectedValue));
                }

                if (cmbDepartmentTo.Items.Count > 0)
                {
                    objDepTo = objDepartmentDL.Get(Convert.ToInt64(cmbDepartmentTo.SelectedValue));
                }

                if (cmbStoreFrom.Items.Count > 0)
                {
                    objStore = (Store)cmbStoreFrom.SelectedItem;
                }

                if (!ItemCode.Equals("") && !objGRN.GRNNo.Equals("") && objDepTo != null && objDepFrom != null)
                {
                    if (txtQty.Text.Equals(""))
                    {
                        MessageBox.Show(this, "Please enter Valid Quantity for Transfer", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (Convert.ToDecimal(txtQty.Text) > Convert.ToDecimal(txtAvailableQty.Text))
                        {
                            MessageBox.Show(this, "Available Quantity is " + txtAvailableQty.Text + ",Transfer quantity cannot be more than available", "Available Quantity Exceed", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                        {
                            objMTN.MTNDepartmentFrom = objDepFrom;
                            objMTN.MTNDepartmentTo = objDepTo;
                            objMTN.MTNEnterdBy = CurrentUser.UserEmp;
                            objMTN.MTNStatus = MTN.Status.Initial;
                            objMTN.MTNType = MTN.Type.General;
                            objMTN.MTNStore = objStore;
                            if (cmbMTNType.SelectedItem.Equals("Basic Product"))
                            {

                                objMTN.MTNItemType = MTN.ItemType.Basic_Product;


                                objMTN.MTNNo = objMTNDL.Add(objMTN);

                                if (objMTN.MTNNo > 0)
                                {
                                    objBasicProduct = objBasicProductDL.Get((cmbItem.SelectedValue.ToString()));


                                    objMTNBasic.Batch = "No";
                                    objMTNBasic.Description = txtRemarks.Text;
                                    objMTNBasic.BasicProduct = objBasicProduct;
                                    objMTNBasic.MTN = objMTN;
                                    objMTNBasic.TransferQty = Convert.ToDecimal(txtQty.Text);
                                    objMTNBasic.UnitRate = Convert.ToDecimal(txtGRNUnitCost.Text) + Convert.ToDecimal(txtStockHoldingCost.Text);


                                    objMTNBasicProductDL.Add(objMTNBasic);

                                    MessageBox.Show(this, "Successfully Saved, MTN No is " + objMTN.MTNNo, "Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }

                            }
                            else if (cmbMTNType.SelectedItem.Equals("Material"))
                            {
                                objMTN.MTNItemType = MTN.ItemType.Material;


                                objMTN.MTNNo = objMTNDL.Add(objMTN);

                                if (objMTN.MTNNo > 0)
                                {
                                    objMaterial = objMaterialDL.Get(cmbItem.SelectedValue.ToString());


                                    objMTNMat.Batch = "No";
                                    objMTNMat.Description = txtRemarks.Text;
                                    objMTNMat.Material = objMaterial;
                                    objMTNMat.MTN = objMTN;
                                    objMTNMat.TransferQty = Convert.ToDecimal(txtQty.Text);
                                    objMTNMat.UnitRate = Convert.ToDecimal(txtGRNUnitCost.Text) + Convert.ToDecimal(txtStockHoldingCost.Text);


                                    objMTNMaterialDL.Add(objMTNMat);

                                    MessageBox.Show(this, "Successfully Saved, MTN No is " + objMTN.MTNNo, "Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                            else if (cmbMTNType.SelectedItem.Equals("Finish Product"))
                            {
                                objMTN.MTNItemType = MTN.ItemType.Finish_Product;


                                objMTN.MTNNo = objMTNDL.Add(objMTN);

                                if (objMTN.MTNNo > 0)
                                {
                                    objFinishProduct = objFinishProductDL.Get((cmbItem.SelectedValue.ToString()));


                                    objMTNFinish.Batch = "No";
                                    objMTNFinish.Description = txtRemarks.Text;
                                    objMTNFinish.FinishProduct = objFinishProduct;
                                    objMTNFinish.MTN = objMTN;
                                    objMTNFinish.TransferQty = Convert.ToDecimal(txtQty.Text);
                                    objMTNFinish.UnitRate = Convert.ToDecimal(txtGRNUnitCost.Text) + Convert.ToDecimal(txtStockHoldingCost.Text);


                                    objMTNFinisProductDL.Add(objMTNFinish);

                                    MessageBox.Show(this, "Successfully Saved, MTN No is " + objMTN.MTNNo, "Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show(this, "Please check Item, Department and GRN that you selected", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar) || (e.KeyChar == (char)46)))
            {
                e.Handled = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}