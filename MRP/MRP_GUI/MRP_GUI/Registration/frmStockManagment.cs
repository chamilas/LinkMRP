using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SESD.MRP.REF;
using DL;
using System.Data.SqlClient;

namespace MRP_GUI
{
    public partial class frmStockManagment : System.Windows.Forms.Form
    {

        //-------------------------- Variables and Properties ------

        private User _objCurrentUser;

        public User CurrentUser
        {
            get { return _objCurrentUser; }
            set { _objCurrentUser = value; }
        }

        private bool StockSelect = false;

        private Stock objStock = new Stock();
        private Stock_DL objStockDL = new Stock_DL(ConnectionStringClass.GetConnection());
        private StockCollec objStockCollec = new StockCollec();
        private Store_DL objStoreDL = new Store_DL(ConnectionStringClass.GetConnection());
        private Material_DL objMaterialDl = new Material_DL(ConnectionStringClass.GetConnection());
        private BasicProduct_DL objBasicProductDL = new BasicProduct_DL(ConnectionStringClass.GetConnection());
        private FinishProduct_DL objFinishProductDL = new FinishProduct_DL(ConnectionStringClass.GetConnection());

        //------------------------- Methods ------------------------

        public void ClearForm()
        {
            txtEconomicalQty.Text = "0.00";
            txtMaximum.Text = "0.00";
            txtMinimum.Text = "0.00";
            txtReorderLevel.Text = "0.00";
            txtStock.Text = "0.00";
            cmbItem.SelectedIndex = 0;
            cmbStockType.SelectedIndex = 0;

            this.StockSelect = false;
        }

        public void UnitLabel(String unitCode)
        {
            lblUnit1.Text = unitCode;
            lblUnit2.Text = unitCode;
            lblUnit3.Text = unitCode;
            lblUnit4.Text = unitCode;
            lblUnit5.Text = unitCode;
            lblUnit6.Text = unitCode;


        }

        //------------------------- Constructers -------------------

        public frmStockManagment()
        {
            InitializeComponent();
        }

        public frmStockManagment(User objUser)
        {
            InitializeComponent();
        }

        private void frmStockManagment_Load(object sender, EventArgs e)
        {
            try
            {
                cmbStockType.SelectedIndex = -1;
                cmbStores.DataSource = objStoreDL.Get();
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbStores_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Store objStore = (Store)cmbStores.SelectedItem;
                if (objStore != null)
                {
                    bindStockList.DataSource = objStockDL.GetDataView(objStore.StoreID);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Stock objStockTemp = new Stock();
            try
            {
                Store objStore = (Store)cmbStores.SelectedItem;
                objStockTemp.ItemCode = cmbItem.SelectedValue.ToString();
                objStockTemp.StockEconomicalQty = Convert.ToDecimal(txtEconomicalQty.Text);
                objStockTemp.StockMaximumQty = Convert.ToDecimal(txtMaximum.Text);
                objStockTemp.StockMinimumQty = Convert.ToDecimal(txtMinimum.Text);
                objStockTemp.StockReorderLevel = Convert.ToDecimal(txtReorderLevel.Text);
                objStockTemp.StockReservedQty = Convert.ToDecimal(txtReserved.Text);
                objStockTemp.StockQty = Convert.ToDecimal(txtStock.Text);
                objStockTemp.StockStatus = Stock.Status.Enable;
                objStockTemp.StockStore = objStore;
                if (cmbStockType.SelectedItem.Equals("Material"))
                {
                    objStockTemp.StockType = Stock.Type.Material;
                }
                else if (cmbStockType.SelectedItem.Equals("Basic Product"))
                {
                    objStockTemp.StockType = Stock.Type.BasicProduct;
                }
                else if (cmbStockType.SelectedItem.Equals("Finish Product"))
                {
                    objStockTemp.StockType = Stock.Type.FinishProduct;
                }

                if (this.StockSelect)
                {
                    objStockTemp.StockID = objStock.StockID;
                    int x = objStockDL.Update(objStockTemp,objStock.ItemCode);
                    if (x>0)
                    {
                        MessageBox.Show(this, "Successfully Updated to Database", "Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (objStore != null)
                        {
                            bindStockList.DataSource = objStockDL.GetDataView(objStore.StoreID);
                        }
                        ClearForm();
                    }
                    else if (x == -1)
                    {
                        MessageBox.Show(this, "This Item you selected, Already in the List,Please check again", "Item Already in the Database", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    } 
                }
                else
                {
                    int x = objStockDL.Add_All(objStockTemp);
                    if (x > 0)
                    {
                        MessageBox.Show(this, "Successfully Added to Database", "Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if (objStore != null)
                        {
                            bindStockList.DataSource = objStockDL.GetDataView(objStore.StoreID);
                        }
                        ClearForm();
                    }
                    else if (x == -1)
                    {
                        MessageBox.Show(this, "This Item Already in the List, If you want to Edit it Please Select the Item From List", "Item Already in the Database", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    } 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbStockType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //bindItems.DataSource = null;
                if (cmbStockType.SelectedItem.Equals("Material"))
                {
                    bindItems.DataSource = objMaterialDl.GetDataView();
                    cmbItem.ValueMember = "MaterialCode";
                    cmbItem.DisplayMember = "Material";
                    
                    listItemList.ValueMember = "MaterialCode";
                    listItemList.DisplayMember = "Material";
                    


                }
                else if (cmbStockType.SelectedItem.Equals("Basic Product"))
                {
                    bindItems.DataSource = objBasicProductDL.GetDataView(true);
                    cmbItem.DisplayMember = "Code";
                    cmbItem.ValueMember = "BasicProductCode";

                    listItemList.ValueMember = "BasicProductCode";
                    listItemList.DisplayMember = "Code";
                   

                }
                else if (cmbStockType.SelectedItem.Equals("Finish Product"))
                {
                    bindItems.DataSource = objFinishProductDL.GetDataView(1);
                    cmbItem.DisplayMember = "FinishProduct";
                    cmbItem.ValueMember = "FinishProductCode";

                    listItemList.ValueMember = "FinishProductCode";
                    listItemList.DisplayMember = "FinishProduct";
                    

                }
            }
            catch (Exception ex)
            {
                    MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gvStockList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    long StockID = Convert.ToInt64(gvStockList.Rows[e.RowIndex].Cells["ColStockID"].Value);
                    objStock = objStockDL.Get(StockID);
                    txtEconomicalQty.Text = objStock.StockEconomicalQty.ToString();
                    txtMaximum.Text =  objStock.StockMaximumQty.ToString();
                    txtMinimum.Text = objStock.StockMinimumQty.ToString();
                    txtReorderLevel.Text = objStock.StockReorderLevel.ToString();
                    txtStock.Text = objStock.StockQty.ToString();

                    cmbStores.SelectedItem = objStock.StockStore;
                    if (objStock.StockType == Stock.Type.Material)
                    {
                        cmbStockType.SelectedItem = "Material";
                        cmbItem.SelectedValue = objStock.StockMaterial.MaterialCode;
                        objStock.ItemCode = objStock.StockMaterial.MaterialCode;
                    }
                    else if (objStock.StockType == Stock.Type.BasicProduct)
                    {
                        cmbStockType.SelectedItem = "Basic Product";
                        cmbItem.SelectedValue = objStock.StockBasicProduct.BasicProductCode;
                        objStock.ItemCode = objStock.StockBasicProduct.BasicProductCode;
                    }
                    else if (objStock.StockType == Stock.Type.FinishProduct)
                    {
                        cmbStockType.SelectedItem = "Finish Product";
                        cmbItem.SelectedValue = objStock.StockFinishProduct.FinishProductCode;
                        objStock.ItemCode = objStock.StockFinishProduct.FinishProductCode;
                    }
                    this.StockSelect = true;
                    
                }

            }
            catch (Exception ex)
            {
                    MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.StockSelect)
                {
                    DialogResult dr = MessageBox.Show(this, "Are you sure you want to delete Selected Record? Click Yes to delete", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        int x = objStockDL.Delete(objStock.StockID);
                        if (x > 0)
                        {
                            Store objStore = (Store)cmbStores.SelectedItem;
                            if (objStore != null)
                            {
                                bindStockList.DataSource = objStockDL.GetDataView(objStore.StoreID);
                            }
                            ClearForm();
                        }

                    }
                }
            }
            catch (SqlException sqlex)
            {
                if (sqlex.Number == 547)
                {
                    MessageBox.Show(this,"This record has one or many references to another record(s).\nYou can't delete this record","Delete Fail",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show(this, "Database Error ocured while deleteing", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
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
                bindStockList.Filter = string.Format("MaterialIDName LIKE '%{0}%'", cmbItem.Text);
                if (cmbItem.SelectedValue != null)
                {
                    if (cmbStockType.SelectedItem.Equals("Material"))
                    {
                        Material objMat = objMaterialDl.Get(cmbItem.SelectedValue.ToString());
                        if (objMat != null)
                        {
                            UnitLabel(objMat.MatUnit.UnitCode);
 
                        }
                    }
                    else if (cmbStockType.SelectedItem.Equals("Basic Product"))
                    {
                        BasicProduct objBasic = objBasicProductDL.Get(cmbItem.SelectedValue.ToString());
                        if (objBasic.BasicProductCode != null)
                        {
                            UnitLabel(objBasic.BasicProductUnit.UnitCode);
                            
                        }
                    }
                    else if (cmbStockType.SelectedItem.Equals("Finish Product"))
                    {
                        FinishProduct objFinish = objFinishProductDL.Get(cmbItem.SelectedValue.ToString());
                        if (objFinish.FinishProductCode != null)
                        {
                            UnitLabel(objFinish.FinishProductPackingType.PackingTitle);
                            
                        }
                    } 
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtReorderLevel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar) || (e.KeyChar == (char)46)))
            {
                e.Handled = true;
            }
        }

        private void txtMinimum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar) || (e.KeyChar == (char)46)))
            {
                e.Handled = true;
            }
        }

        private void txtMaximum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar) || (e.KeyChar == (char)46)))
            {
                e.Handled = true;
            }
        }

        private void txtEconomicalQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar) || (e.KeyChar == (char)46)))
            {
                e.Handled = true;
            }
        }

        private void cmbItem_KeyDown(object sender, KeyEventArgs e)
        {
            bindStockList.Filter = string.Format("MaterialIDName LIKE '%{0}%'", cmbItem.Text);

            /*
            if (cmbStockType.SelectedItem.Equals("Material"))
            {
                bindItems.Filter = string.Format("MaterialCode LIKE '%{0}%'", cmbItem.Text);
            }
            else if (cmbStockType.SelectedItem.Equals("Basic Product"))
            {
                bindItems.Filter = string.Format("BasicProductCode LIKE '%{0}%'", cmbItem.Text);
            }
            else if (cmbStockType.SelectedItem.Equals("Finish Product"))
            {
                bindItems.Filter = string.Format("FinishProductCode LIKE '%{0}%'", cmbItem.Text);
            }
             */
        }
    }
}