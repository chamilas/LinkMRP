using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SESD.MRP.REF;
using SESD.MRP.BL;
using DL;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Data.Sql;

namespace MRP_GUI
{
    public partial class frmCatTypeUnit : System.Windows.Forms.Form
    {
        public frmCatTypeUnit(User objUser)
        {
            CurrentUser = objUser;
            InitializeComponent();
            LoadSMTable();
        }


        private User _objCurrentUser;

        public User CurrentUser
        {
            get { return _objCurrentUser; }
            set { _objCurrentUser = value; }
        }
        //---------------GUI Control Variables-------------------------
        private bool MaterialCategorySelect = false;
        private MaterialCategory objSelectedMatCategory;

        private bool MaterialSubCategorySelect = false;

        private bool MaterialTypeSelect = false;
        private MaterialType objSelectedMaterialType = new MaterialType();

        private bool ProductCategorySelect = false;
        private ProductCategory objSelectedProductCategory = new ProductCategory();

        private bool ProductSubCategorySelect = false;
        private ProductSubCategory objSelectedProductSubCategory = new ProductSubCategory();

        private bool UnitSelect = false;
        private Unit objSelectedUnit = new Unit();

        private bool FormSelect = false;
        private SESD.MRP.REF.Form objSelectedForm = new SESD.MRP.REF.Form();

        private bool PackingTypeSelect = false;
        private PackingType objSelectedPackingType = new PackingType();

        private bool SKUSelect = false;
        private SKU objSelectedSKU = new SKU();

        private bool ShiftSelect = false;
        private WorkShift objSelectedShift = new WorkShift();

        private bool SupplierTypeSelect = false;

        private bool MachineTypeSelect = false;
        private MachineType objSelectedMachineType = new MachineType();

        private bool EmpRoleSelect = false;
        private EmployeeRole objEmployeeRole = new EmployeeRole();

        private SalesMethod_DL objSalesMethod_DL = new SalesMethod_DL(ConnectionStringClass.GetConnection());

        //----- Form Load Event ----------------------------------------------
        private void frmCatTypeUnit_Load(object sender, EventArgs e)
        {
           
            //--------------------Materila Catergory Gridview Load------------------------

            ucMaterialCategory1.Load(ConnectionStringClass.GetConnection());
            
           
            //--------------------Material Sub Catergory Gridview Load------------------------
            //MaterialSubCategory_DL objMatSubCatDL = new MaterialSubCategory_DL(ConnectionStringClass.GetConnection());

            //try
            //{

            //    gvMaterialSubCategary.DataSource = objMatSubCatDL.GetDataView();

            //}
            //catch (Exception ex)
            //{

            //    MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //finally
            //{
            //    objMatSubCatDL = null;
            //}
            //ucMaterialSubCatL11.LoadForm(ConnectionStringClass.GetConnection());
            //ucMaterialSubCatL21.Load(ConnectionStringClass.GetConnection());
            //--------------------Material Type Gridview Load------------------------
            MaterialType_DL objMatTypeDL = new MaterialType_DL(ConnectionStringClass.GetConnection());

            try
            {

                gvMaterialType.DataSource = objMatTypeDL.GetDataView();

            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                objMatTypeDL = null;
            }

            //--------------------Product Category Gridview Load------------------------
            ProductCategory_DL objProductCatDL = new ProductCategory_DL(ConnectionStringClass.GetConnection());

            try
            {
                gvProductCategory.DataSource = objProductCatDL.GetDataView_WithRate();

            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                objProductCatDL = null;
            }

            //--------------------Product Sub Category Gridview Load------------------------
            ProductSubCategory_DL objProductSubCatDL = new ProductSubCategory_DL(ConnectionStringClass.GetConnection());

            try
            {
                gvProductSubCategory.DataSource = objProductSubCatDL.GetDataView();


            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                objProductSubCatDL = null;
            }

            //-------------------Unit Gridview Load------------------------
            Unit_DL objUnitDL = new Unit_DL(ConnectionStringClass.GetConnection());

            try
            {

                gvUnit.DataSource = objUnitDL.GetDataView();

            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                objUnitDL = null;
            }

            //-------------------Form Gridview Load------------------------
            Form_DL objFormDL1 = new Form_DL(ConnectionStringClass.GetConnection());

            try
            {

                gvForm.DataSource = objFormDL1.GetDataView();

            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                objFormDL1 = null;
            }
            
            //-------------------Packing Type Gridview & Combo Box Load------------------------
            PackingType_DL objPackingTypeDL = new PackingType_DL(ConnectionStringClass.GetConnection());
            Form_DL objFormDL = new Form_DL(ConnectionStringClass.GetConnection());
            Unit_DL objUnit = new Unit_DL(ConnectionStringClass.GetConnection());

            try
            {
                cmbPackingTypeContentForm.DataSource = objFormDL.GetDataView();
                gvPackingType.DataSource = objPackingTypeDL.GetDataView();
                cmbUnit.DataSource = objUnit.GetDataView();

            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                objUnit = null;
                objFormDL = null;
            }

            //-------------------SKU Gridview & Combo Box Load------------------------
            PackingType_DL objPackingTypeDL1 = new PackingType_DL(ConnectionStringClass.GetConnection());
            SKU_DL objSKUDL = new SKU_DL(ConnectionStringClass.GetConnection());

            try
            {
                cmbPackingType.DataSource = objPackingTypeDL1.GetDataComboList();
                gvSKU.DataSource = objSKUDL.GetDataView();
               
            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                objPackingTypeDL = null;
                objSKUDL = null;
            }

            //-------------------Work Shift Gridview Load------------------------
           // WorkShift_DL objWorkShiftDL = new WorkShift_DL(ConnectionStringClass.GetConnection());

            try
            {

              //  gvShift.DataSource = objWorkShiftDL.GetDataView();

            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
              //  objWorkShiftDL = null;
            }

            //-------------------Supplier type Gridview Load------------------------
         /*   SupplierType_DL objSupplierTypeDL = new SupplierType_DL(ConnectionStringClass.GetConnection());

            try
            {

                gvSupplierType.DataSource = objSupplierTypeDL.GetDataView();

            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                objSupplierTypeDL = null;
            }*/

            //-------------------Machine type Gridview Load------------------------
            MachineType_DL objMachineTypeDL = new MachineType_DL(ConnectionStringClass.GetConnection());

            try
            {

                dataGridView1.DataSource = objMachineTypeDL.GetDataView();

            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                objMachineTypeDL = null;
            }


            //-------------------Employee Role Gridview Load------------------------
            
            EmployeeRole_DL objEmpRole = new EmployeeRole_DL(ConnectionStringClass.GetConnection());
            try
            {
                cmbEmployeeRoleType.SelectedIndex = 0;
                gvEmployeeRoleList.DataSource = objEmpRole.GetDataView();

            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                objEmpRole = null;
            }



        }//End Page load event

        //--------------- Validation Events ------------------------------------
        private void txtPackingTypeSize_Validated(object sender, EventArgs e)
        {
            try
            {
                Convert.ToDecimal(txtPackingTypeSize.Text);
                errorProvider1.SetError(txtPackingTypeSize, "");
            }
            catch (Exception)
            {

                errorProvider1.SetError(txtPackingTypeSize, "Packing size should be a Numaric value");
            }
        }

        private void txtSKYQty_Validated(object sender, EventArgs e)
        {
            try
            {
                Convert.ToDecimal(txtSKYQty.Text);
                errorProvider1.SetError(txtSKYQty, "");
            }
            catch (Exception)
            {

                errorProvider1.SetError(txtSKYQty, "Quantity should be a Numaric value");
            }
        }

        private void txtSKUCostperUnit_Validated(object sender, EventArgs e)
        {
            try
            {
                Convert.ToDecimal(txtSKUCostperUnit.Text);
                errorProvider1.SetError(txtSKUCostperUnit, "");
            }
            catch (Exception)
            {

                errorProvider1.SetError(txtSKUCostperUnit, "Unit Cost should be a Numaric value");
            }
        }

     
        //----- Material Category Events -------------------------------------
        /*
        private void button1_Click(object sender, EventArgs e)
        {
            MaterialCategory objMatCat = new MaterialCategory();
            MaterialCategory_DL objMatCatDL = new MaterialCategory_DL(ConnectionStringClass.GetConnection());

            if (txtMaterialCatergory.Text.Equals("") || txtMaterialCatergoryDescription.Text.Equals(""))
            {
                MessageBox.Show(this,"Please Fill all Fields","Blank Fields",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }
            else
            {
                objMatCat.MatCatID = txtMaterialCatergory.Text;
                objMatCat.MaterialCategoryName = txtMaterialCatergoryDescription.Text;
                int x;
                try
                {
                    if (this.MaterialCategorySelect)
                    {
                        x = objMatCatDL.Update(objMatCat, objSelectedMatCategory.MatCatID);
                        gvMaterialCategory.DataSource = objMatCatDL.GetDataView();
                        txtMaterialCatergory.Text = "";
                        txtMaterialCatergoryDescription.Text = "";
                        if (x > 0)
                        {
                            MessageBox.Show(this, "Succesfully Updated the Database", "Succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                    else
                    {
                        x = objMatCatDL.Add(objMatCat);
                        gvMaterialCategory.DataSource = objMatCatDL.GetDataView();
                        txtMaterialCatergory.Text = "";
                        txtMaterialCatergoryDescription.Text = "";
                        if (x > 0)
                        {
                            MessageBox.Show(this, "Succesfully Added to Database", "Succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }

                    this.MaterialCategorySelect = false;

                }

                catch (Exception ex)
                {

                    MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.MaterialCategorySelect)
            {
                DialogResult dr = MessageBox.Show(this,"Are you sure, You want to Delete selected Record?","Confirm Delete",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    MaterialCategory objMatCat = new MaterialCategory();
                    MaterialCategory_DL objMatCatDL = new MaterialCategory_DL(ConnectionStringClass.GetConnection());
                    try
                    {
                        objMatCatDL.Delete(txtMaterialCatergory.Text);
                        gvMaterialCategory.DataSource = objMatCatDL.GetDataView();
                        txtMaterialCatergory.Text = "";
                        txtMaterialCatergoryDescription.Text = "";
                        this.MaterialCategorySelect = false;
                        MessageBox.Show(this, "Succesfully Deleted From Database", "Succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show(this, "Select a Record from the List", "Select a Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void gvMaterialCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            MaterialCategory_DL objMatCatDL = new MaterialCategory_DL(ConnectionStringClass.GetConnection());

            try
            {
                objSelectedMatCategory = objMatCatDL.Get(gvMaterialCategory.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtMaterialCatergory.Text = objSelectedMatCategory.MatCatID;

                txtMaterialCatergoryDescription.Text = objSelectedMatCategory.MaterialCategoryName;
                this.MaterialCategorySelect = true;
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtMaterialCatergory.Text = "";
            txtMaterialCatergoryDescription.Text = "";
            this.MaterialCategorySelect = false;

        }
        */
        //----- Material Sub Category Events ---------------------------------

    

        

        //----- Material Type Events ----------------------------------------

        private void btnMaterialTypeSave_Click(object sender, EventArgs e)
        {
            MaterialType objMaterialType = new MaterialType();
            MaterialType_DL objMaterialTypeDL = new MaterialType_DL(ConnectionStringClass.GetConnection());
            if (txtMaterialType.Text.Equals("") || txtMaterialTypeDescription.Text.Equals(""))
            {
                MessageBox.Show(this, "Please Fill all Fields", "Blank Fields", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                objMaterialType.MaterialTypeTitle = txtMaterialTypeDescription.Text;
                objMaterialType.MatType = txtMaterialType.Text;
                objMaterialType.LeadTime = Convert.ToDecimal(txtLeadTime.Text);

                int x;
                try
                {
                    if (this.MaterialTypeSelect)
                    {
                        x = objMaterialTypeDL.Update(objMaterialType, objSelectedMaterialType.MatType);
                        gvMaterialType.DataSource = objMaterialTypeDL.GetDataView();
                        txtMaterialType.Text = "";
                        txtMaterialTypeDescription.Text = "";
                        if (x > 0)
                        {
                            MessageBox.Show(this, "Succesfully Updated", "Succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                    else
                    {
                        x = objMaterialTypeDL.Add(objMaterialType);
                        gvMaterialType.DataSource = objMaterialTypeDL.GetDataView();
                        txtMaterialType.Text = "";
                        txtMaterialTypeDescription.Text = "";
                        if (x > 0)
                        {
                            MessageBox.Show(this, "Succesfully Saved", "Succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }

                    this.MaterialTypeSelect = false;

                }

                catch (Exception ex)
                {

                    MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnMaterialTypeDelete_Click(object sender, EventArgs e)
        {
            if (this.MaterialTypeSelect)
            {
                DialogResult dr = MessageBox.Show(this, "Are you sure, You want to Delete selected Record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    MaterialType objMaterialType = new MaterialType();
                    MaterialType_DL objMaterialTypeDL = new MaterialType_DL(ConnectionStringClass.GetConnection());
                    try
                    {
                        objMaterialTypeDL.Delete(objSelectedMaterialType.MatType);
                        gvMaterialType.DataSource = objMaterialTypeDL.GetDataView();
                        txtMaterialType.Text = "";
                        txtMaterialTypeDescription.Text = "";
                        this.MaterialTypeSelect = false;
                        MessageBox.Show(this, "Succesfully Deleted", "Succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show(this, "Select a Record from the List", "Select a Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnMaterialTypeClear_Click(object sender, EventArgs e)
        {
            txtMaterialType.Text = "";
            txtMaterialTypeDescription.Text = "";
            this.MaterialTypeSelect = false;
        }

        private void gvMaterialType_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {


               txtMaterialTypeDescription.Text = gvMaterialType.Rows[e.RowIndex].Cells[1].Value.ToString();
               txtMaterialType.Text = gvMaterialType.Rows[e.RowIndex].Cells[0].Value.ToString();
              txtLeadTime.Text = gvMaterialType.Rows[e.RowIndex].Cells[2].Value.ToString();

               objSelectedMaterialType.MaterialTypeTitle = gvMaterialType.Rows[e.RowIndex].Cells[1].Value.ToString();
               objSelectedMaterialType.MatType = gvMaterialType.Rows[e.RowIndex].Cells[0].Value.ToString();
                this.MaterialTypeSelect = true;

            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //----- Product Category Events -------------------------------------
        private void btnProductCatSave_Click(object sender, EventArgs e)
        {
            ProductCategory objProductCat = new ProductCategory();
            ProductCategory_DL objProductCatDL = new ProductCategory_DL(ConnectionStringClass.GetConnection());
            if (txtProductCatDescription.Text.Equals("") || txtProductCatID.Text.Equals(""))
            {
                MessageBox.Show(this, "Please Fill all Fields", "Blank Fields", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                objProductCat.CategoryID = txtProductCatID.Text;
                objProductCat.Category = txtProductCatDescription.Text;

                
                int x;
                try
                {
                    if (this.ProductCategorySelect)
                    {
                        x = objProductCatDL.Update(objProductCat, objSelectedProductCategory.CategoryID);
                        
                        
                        if (x > 0)
                        {
                            
                            gvProductCategory.DataSource = objProductCatDL.GetDataView_WithRate();
                            ClearProductCategory();
                            MessageBox.Show(this, "Succesfully Updated", "Succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                    else
                    {
                        x = objProductCatDL.Add(objProductCat);
                        
                        
                        if (x > 0)
                        {
                            
                            gvProductCategory.DataSource = objProductCatDL.GetDataView_WithRate();
                            ClearProductCategory();
                            MessageBox.Show(this, "Succesfully Saved", "Succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }

                    

                    this.ProductCategorySelect = false;

                }

                catch (Exception ex)
                {

                    MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

       

        private void btnProductCatDelete_Click(object sender, EventArgs e)
        {
            if (this.ProductCategorySelect)
            {
                DialogResult dr = MessageBox.Show(this, "Are you sure, You want to Delete selected Record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    ProductCategory objProductCat = new ProductCategory();
                    ProductCategory_DL objProductCatDL = new ProductCategory_DL(ConnectionStringClass.GetConnection());
                    try
                    {
                        objProductCatDL.Delete(objSelectedProductCategory.CategoryID);
                        gvProductCategory.DataSource = objProductCatDL.GetDataView_WithRate();
                        ClearProductCategory();
                        this.ProductCategorySelect = false;
                        MessageBox.Show(this, "Succesfully Deleted", "Succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show(this, "Select a Record from the List", "Select a Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void ClearProductCategory()
        {
            txtProductCatDescription.Text = "";
            txtProductCatID.Text = "";
          
        }

        private void btnProductCatClear_Click(object sender, EventArgs e)
        {
            ClearProductCategory();
            this.ProductCategorySelect = false;
        }

        private void gvProductCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            OverheadRates objOverHead = new OverheadRates();
            OverheadRates_DL objOverHeadDL = new OverheadRates_DL(ConnectionStringClass.GetConnection());
            Employee_DL objEmpDL = new Employee_DL(ConnectionStringClass.GetConnection());
            Employee objEmp = new Employee();
            try
            {

                ClearProductCategory();
                txtProductCatDescription.Text = gvProductCategory.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtProductCatID.Text = gvProductCategory.Rows[e.RowIndex].Cells[0].Value.ToString();

                objSelectedProductCategory.Category = gvProductCategory.Rows[e.RowIndex].Cells[1].Value.ToString();
                objSelectedProductCategory.CategoryID = gvProductCategory.Rows[e.RowIndex].Cells[0].Value.ToString();

               this.ProductCategorySelect = true;

            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        //----- Product Sub Category Events ---------------------------------
        private void btnProductSubCatSave_Click(object sender, EventArgs e)
        {
            ProductSubCategory objProductSubCat = new ProductSubCategory();
            ProductSubCategory_DL objProductSubCatDL = new ProductSubCategory_DL(ConnectionStringClass.GetConnection());
            if (txtProductSubCatDescription.Text.Equals("") || txtProductSubCatID.Text.Equals(""))
            {
                MessageBox.Show(this, "Please Fill all Fields", "Blank Fields", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                objProductSubCat.Category = txtProductSubCatDescription.Text;
                objProductSubCat.CategoryID = txtProductSubCatID.Text;
                int x;
                try
                {
                    if (this.ProductSubCategorySelect)
                    {
                        x = objProductSubCatDL.Update(objProductSubCat, objSelectedProductSubCategory.CategoryID);
                        gvProductSubCategory.DataSource = objProductSubCatDL.GetDataView();
                        txtProductSubCatDescription.Text = "";
                        txtProductSubCatID.Text = "";
                        if (x > 0)
                        {
                            MessageBox.Show(this, "Succesfully Updated", "Succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                    else
                    {
                        x = objProductSubCatDL.Add(objProductSubCat);
                        gvProductSubCategory.DataSource = objProductSubCatDL.GetDataView();
                        txtProductSubCatDescription.Text = "";
                        txtProductSubCatID.Text = "";
                        if (x > 0)
                        {
                            MessageBox.Show(this, "Succesfully Saved", "Succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }

                    this.FormSelect = false;

                }

                catch (Exception ex)
                {

                    MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnProductSubCatDelete_Click(object sender, EventArgs e)
        {
            if (this.ProductSubCategorySelect)
            {
                DialogResult dr = MessageBox.Show(this, "Are you sure, You want to Delete selected Record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    ProductSubCategory objProductSubCat = new ProductSubCategory();
                    ProductSubCategory_DL objProductSubCatDL = new ProductSubCategory_DL(ConnectionStringClass.GetConnection());
                    try
                    {
                        objProductSubCatDL.Delete(objSelectedProductSubCategory.CategoryID);
                        gvProductSubCategory.DataSource = objProductSubCatDL.GetDataView();
                        txtProductSubCatDescription.Text = "";
                        txtProductSubCatID.Text = "";
                        this.ProductSubCategorySelect = false;
                        MessageBox.Show(this, "Succesfully Deleted", "Succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show(this, "Select a Record from the List", "Select a Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnProductSubCatClear_Click(object sender, EventArgs e)
        {
            txtProductSubCatID.Text = "";
            txtProductSubCatDescription.Text = "";
            this.ProductSubCategorySelect = false;
        }

        private void gvProductSubCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ProductSubCategory_DL objProductSubCatDL = new ProductSubCategory_DL(ConnectionStringClass.GetConnection());

            try
            {


                txtProductSubCatDescription.Text = gvProductSubCategory.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtProductSubCatID.Text = gvProductSubCategory.Rows[e.RowIndex].Cells[0].Value.ToString();

                objSelectedProductSubCategory.Category = gvProductSubCategory.Rows[e.RowIndex].Cells[1].Value.ToString();
                objSelectedProductSubCategory.CategoryID = gvProductSubCategory.Rows[e.RowIndex].Cells[0].Value.ToString();

                this.ProductSubCategorySelect = true;

            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //----- Unit Events -------------------------------------------------
        private void btnUnitSave_Click(object sender, EventArgs e)
        {
            Unit objUnit = new Unit();
            Unit_DL objUntDL = new Unit_DL(ConnectionStringClass.GetConnection());
            if (txtUnitCode.Text.Equals("") || txtUnitName.Text.Equals(""))
            {
                MessageBox.Show(this, "Please Fill all Fields", "Blank Fields", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                objSelectedUnit.UnitCode = txtUnitCode.Text;
                objSelectedUnit.UnitName = txtUnitName.Text;
                int x;
                try
                {
                    if (this.UnitSelect)
                    {
                        x = objUntDL.Update(objSelectedUnit);
                        gvUnit.DataSource = objUntDL.GetDataView();
                        txtUnitCode.Text = "";
                        txtUnitName.Text = "";
                        if (x > 0)
                        {
                            MessageBox.Show(this, "Succesfully Updated", "Succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                    else
                    {
                        x = objUntDL.Add(objSelectedUnit);
                        gvUnit.DataSource = objUntDL.GetDataView();
                        txtUnitCode.Text = "";
                        txtUnitName.Text = "";
                        if (x > 0)
                        {
                            MessageBox.Show(this, "Succesfully Saved", "Succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }

                    this.UnitSelect = false;

                }

                catch (Exception ex)
                {

                    MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnUnitDelete_Click(object sender, EventArgs e)
        {
            if (this.UnitSelect)
            {
                DialogResult dr = MessageBox.Show(this, "Are you sure, You want to Delete selected Record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    
                    Unit_DL objUntDL = new Unit_DL(ConnectionStringClass.GetConnection());
                    try
                    {
                        objUntDL.Delete(objSelectedUnit.UnitID);
                        gvUnit.DataSource = objUntDL.GetDataView();
                        txtUnitCode.Text = "";
                        txtUnitName.Text = "";
                        this.UnitSelect = false;
                        MessageBox.Show(this, "Succesfully Deleted", "Succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show(this, "Select a Record from the List", "Select a Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnUnitClear_Click(object sender, EventArgs e)
        {
            this.UnitSelect = false;
            txtUnitCode.Text = "";
            txtUnitName.Text = "";
        }

        private void gvUnit_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            try
            {


                txtUnitCode.Text = gvUnit.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtUnitName.Text = gvUnit.Rows[e.RowIndex].Cells[1].Value.ToString();

                objSelectedUnit.UnitCode = gvUnit.Rows[e.RowIndex].Cells[1].Value.ToString();
                objSelectedUnit.UnitID = Convert.ToInt64(gvUnit.Rows[e.RowIndex].Cells[0].Value.ToString());
                objSelectedUnit.UnitName = gvUnit.Rows[e.RowIndex].Cells[2].Value.ToString();

                this.UnitSelect = true;

            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //----- Item Form Events -------------------------------------------

        private void btnFormSave_Click(object sender, EventArgs e)
        {
            SESD.MRP.REF.Form objForm = new SESD.MRP.REF.Form();
            Form_DL objFormDL = new Form_DL(ConnectionStringClass.GetConnection());
            if (txtFormName.Text.Equals(""))
            {
                MessageBox.Show(this, "Please Fill all Fields", "Blank Fields", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
               
                objSelectedForm.FormName = txtFormName.Text;
                int x;
                try
                {
                    if (this.FormSelect)
                    {
                        x = objFormDL.Update(objSelectedForm);
                        gvForm.DataSource = objFormDL.GetDataView();
                        txtFormName.Text = "";
                        if (x > 0)
                        {
                            MessageBox.Show(this, "Succesfully Updated", "Succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                    else
                    {
                        x = objFormDL.Add(objSelectedForm);
                        gvForm.DataSource = objFormDL.GetDataView();
                        txtFormName.Text = "";
                        if (x > 0)
                        {
                            MessageBox.Show(this, "Succesfully Saved", "Succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }

                    this.ProductSubCategorySelect = false;

                }

                catch (Exception ex)
                {

                    MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnFormDelete_Click(object sender, EventArgs e)
        {
            if (this.FormSelect)
            {
                DialogResult dr = MessageBox.Show(this, "Are you sure, You want to Delete selected Record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {

                    Form_DL objFormDL = new Form_DL(ConnectionStringClass.GetConnection());
                    try
                    {
                        
                        int x = objFormDL.Delete(objSelectedForm.FormID);
                        gvForm.DataSource = objFormDL.GetDataView();
                        txtFormName.Text = "";
                        this.FormSelect = false;
                        if (x>0)
                        {
                            MessageBox.Show(this, "Succesfully Deleted", "Succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show(this, "Select a Record from the List", "Select a Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnFormClear_Click(object sender, EventArgs e)
        {
            txtFormName.Text = "";
            this.FormSelect = false;
        }

        private void gvForm_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtFormName.Text = gvForm.Rows[e.RowIndex].Cells[1].Value.ToString();
               
                objSelectedForm.FormID = Convert.ToInt64(gvForm.Rows[e.RowIndex].Cells[0].Value.ToString());
                objSelectedForm.FormName = gvForm.Rows[e.RowIndex].Cells[0].Value.ToString();


                this.FormSelect = true;

            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //----- Tab Controller's Events Events -----------------------------
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab.Equals(tpPackingType))
            {
                Form_DL objFormDL = new Form_DL(ConnectionStringClass.GetConnection());
                Unit_DL objUnitDL = new Unit_DL(ConnectionStringClass.GetConnection());
                
                try
                {
                    cmbPackingTypeContentForm.DataSource = objFormDL.GetDataView();
                    cmbUnit.DataSource = objUnitDL.GetDataView();
                    

                }
                catch (Exception ex)
                {

                    MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    objUnitDL = null;
                    objFormDL = null;
                }
            }
            else if(tabControl1.SelectedTab == tpMaterialMainCategory)
            {
                ucMaterialCategory1.Load(ConnectionStringClass.GetConnection());

            }
            
        }


        //----- Packing Type Events ----------------------------------------

        private void btnPackinTypeSave_Click(object sender, EventArgs e)
        {
            PackingType_DL objPackingTypeDL = new PackingType_DL(ConnectionStringClass.GetConnection());
            Form_DL objFormDL = new Form_DL(ConnectionStringClass.GetConnection());
            Unit_DL objUnitDL = new Unit_DL(ConnectionStringClass.GetConnection());
            if (txtPackingTypeName.Text.Equals("")||
                txtPackingTypeSize.Text.Equals(""))
            {
                MessageBox.Show(this, "Please Fill all Fields", "Blank Fields", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {

                try
                {
                    objSelectedPackingType.Type =Convert.ToString(cmbPackingTypeContentForm.SelectedValue);
                    objSelectedPackingType.PackingQty = Convert.ToDecimal(txtPackingTypeSize.Text);
                    objSelectedPackingType.PackingTitle = txtPackingTypeName.Text;
                    objSelectedPackingType.PackingUnit = objUnitDL.Get(Convert.ToInt64(cmbUnit.SelectedValue));



                int x;

                    if (this.PackingTypeSelect)
                    {
                        x = objPackingTypeDL.Update(objSelectedPackingType);
                        gvPackingType.DataSource = objPackingTypeDL.GetDataView();
                        cmbUnit.SelectedIndex = 0;
                        cmbPackingTypeContentForm.SelectedIndex = 0;
                        txtPackingTypeName.Text = "";
                        txtPackingTypeSize.Text = "0.00";
                        
                        if (x > 0)
                        {
                            MessageBox.Show(this, "Succesfully Updated", "Succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                    else
                    {
                        x = objPackingTypeDL.Add(objSelectedPackingType);
                        gvPackingType.DataSource = objPackingTypeDL.GetDataView();
                        cmbUnit.SelectedIndex = 0;
                        cmbPackingTypeContentForm.SelectedIndex = 0;
                        txtPackingTypeName.Text = "";
                        txtPackingTypeSize.Text = "0.00";
                        if (x > 0)
                        {
                            MessageBox.Show(this, "Succesfully Saved", "Succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }

                    this.PackingTypeSelect = false;

                }
                catch (FormatException )
                {

                    MessageBox.Show(this, "Please enter valid data", "Input Data Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                catch (Exception ex)
                {

                    MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    objFormDL = null;
                    objPackingTypeDL = null;
                }
            }
        }

        private void btnPackinTypeDelete_Click(object sender, EventArgs e)
        {
            if (this.PackingTypeSelect)
            {
                DialogResult dr = MessageBox.Show(this, "Are you sure, You want to Delete selected Record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {

                    PackingType_DL objpackingTypeDL = new PackingType_DL(ConnectionStringClass.GetConnection());
                    try
                    {

                        int x = objpackingTypeDL.Delete(objSelectedPackingType.PackingID);
                        gvPackingType.DataSource = objpackingTypeDL.GetDataView();
                        cmbUnit.SelectedIndex = 0;
                        cmbPackingTypeContentForm.SelectedIndex = 0;
                        txtPackingTypeName.Text = "";
                        txtPackingTypeSize.Text = "0.00";
                        this.PackingTypeSelect = false;
                        if (x > 0)
                        {
                            MessageBox.Show(this, "Succesfully Deleted", "Succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        objpackingTypeDL = null;
                    }

                }
            }
            else
            {
                MessageBox.Show(this, "Select a Record from the List", "Select a Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnPackinTypeClear_Click(object sender, EventArgs e)
        {
            
            cmbUnit.SelectedIndex = 0;
            cmbPackingTypeContentForm.SelectedIndex = 0;
            txtPackingTypeName.Text = "";
            txtPackingTypeSize.Text = "0.00";
            this.PackingTypeSelect = false;
        }

        private void gvPackingType_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex>=0)
            {
                PackingType_DL objPackingTypeDL = new PackingType_DL(ConnectionStringClass.GetConnection());
                Form_DL objFormDL = new Form_DL(ConnectionStringClass.GetConnection());
                Unit_DL objUnitDL = new Unit_DL(ConnectionStringClass.GetConnection());
                try
                {

                    objSelectedPackingType.Type = Convert.ToString(gvPackingType.Rows[e.RowIndex].Cells["ColPackingFormID"].Value);
                    objSelectedPackingType.PackingID = Convert.ToInt64(gvPackingType.Rows[e.RowIndex].Cells["ColPackingID"].Value);
                    objSelectedPackingType.PackingQty = Convert.ToDecimal(gvPackingType.Rows[e.RowIndex].Cells["ColPackingQty"].Value);
                    objSelectedPackingType.PackingTitle = gvPackingType.Rows[e.RowIndex].Cells["ColPackingTitle"].Value.ToString();
                    objSelectedPackingType.PackingUnit = objUnitDL.Get(Convert.ToInt64(gvPackingType.Rows[e.RowIndex].Cells["colPackingUnitID"].Value));

                    txtPackingTypeName.Text = objSelectedPackingType.PackingTitle;
                    txtPackingTypeSize.Text = objSelectedPackingType.PackingQty.ToString();
                    cmbPackingTypeContentForm.SelectedValue = objSelectedPackingType.Type;
                    cmbUnit.SelectedValue = objSelectedPackingType.PackingUnit.UnitID.ToString();

                    this.PackingTypeSelect = true;

                }
                catch (Exception ex)
                {

                    MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } 
            }
        }

        //----- SKU Events -------------------------------------------------
        private void btnSKUSave_Click(object sender, EventArgs e)
        {
            PackingType_DL objPackingTypeDL = new PackingType_DL(ConnectionStringClass.GetConnection());
            SKU_DL objSKUDL = new SKU_DL(ConnectionStringClass.GetConnection());
           
            if (txtSKUCostperUnit.Text.Equals("") ||txtSKUDescription.Text.Equals("")||
                txtSKYQty.Text.Equals(""))
            {
                MessageBox.Show(this, "Please Fill all Fields", "Blank Fields", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {

                try
                {
                    objSelectedSKU.SKUCost = Convert.ToDecimal(txtSKUCostperUnit.Text);
                    objSelectedSKU.SKUDescription = txtSKUDescription.Text;
                    objSelectedSKU.SKUPackingType = objPackingTypeDL.Get(Convert.ToInt64(cmbPackingType.SelectedValue));
                    objSelectedSKU.SKUQty = Convert.ToDecimal(txtSKYQty.Text);

                    
                    int x;

                    if (this.SKUSelect)
                    {
                        x = objSKUDL.Update(objSelectedSKU);
                        gvSKU.DataSource = objSKUDL.GetDataView();
                        txtSKUCostperUnit.Text = "";
                        txtSKUDescription.Text = "";
                        txtSKYQty.Text = "";
                        cmbPackingType.SelectedIndex = 0;

                        if (x > 0)
                        {
                            MessageBox.Show(this, "Succesfully Updated", "Succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                    else
                    {
                        x = objSKUDL.Add(objSelectedSKU);
                        gvSKU.DataSource = objSKUDL.GetDataView();
                        txtSKUCostperUnit.Text = "";
                        txtSKUDescription.Text = "";
                        txtSKYQty.Text = "";
                        cmbPackingType.SelectedIndex = 0;
                        if (x > 0)
                        {
                            MessageBox.Show(this, "Succesfully Saved", "Succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }

                    this.SKUSelect = false;

                }
                catch (FormatException)
                {

                    MessageBox.Show(this, "Please enter valid data", "Input Data Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                catch (Exception ex)
                {

                    MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    objSKUDL = null;
                    objPackingTypeDL = null;
                    
                }
            }
        }

        private void btnSKUDelete_Click(object sender, EventArgs e)
        {
            if (this.SKUSelect)
            {
                DialogResult dr = MessageBox.Show(this, "Are you sure, You want to Delete selected Record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {

                    SKU_DL objSKUDL = new SKU_DL(ConnectionStringClass.GetConnection());
                    try
                    {

                        int x = objSKUDL.Delete(objSelectedSKU.SKUID);
                        gvSKU.DataSource = objSKUDL.GetDataView();
                        txtSKUCostperUnit.Text = "";
                        txtSKUDescription.Text = "";
                        txtSKYQty.Text = "";
                        cmbPackingType.SelectedIndex = 0;
                        this.SKUSelect = false;
                        if (x > 0)
                        {
                            MessageBox.Show(this, "Succesfully Deleted", "Succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        objSKUDL = null;
                    }

                }
            }
            else
            {
                MessageBox.Show(this, "Select a Record from the List", "Select a Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSKUClear_Click(object sender, EventArgs e)
        {
            
            
            txtSKUCostperUnit.Text = "";
            txtSKUDescription.Text = "";
            txtSKYQty.Text = "";
            cmbPackingType.SelectedIndex = 0;
            this.SKUSelect = false;
        }

        private void gvSKU_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                SKU_DL objSKUDL = new SKU_DL(ConnectionStringClass.GetConnection());
                PackingType_DL objPackingTypeDL = new PackingType_DL(ConnectionStringClass.GetConnection());
                try
                {
                    objSelectedSKU.SKUCost = Convert.ToDecimal(gvSKU.Rows[e.RowIndex].Cells["ColSKUCost"].Value);
                    objSelectedSKU.SKUDescription = gvSKU.Rows[e.RowIndex].Cells["ColSKUDescription"].Value.ToString();
                    objSelectedSKU.SKUID = Convert.ToInt64(gvSKU.Rows[e.RowIndex].Cells["ColSKUID"].Value);
                    objSelectedSKU.SKUPackingType = objPackingTypeDL.Get(Convert.ToInt64(gvSKU.Rows[e.RowIndex].Cells["ColSKUPackingID"].Value));
                    objSelectedSKU.SKUQty = Convert.ToDecimal(gvSKU.Rows[e.RowIndex].Cells["ColSKUQty"].Value);


                    txtSKUCostperUnit.Text = objSelectedSKU.SKUCost.ToString();
                    txtSKUDescription.Text = objSelectedSKU.SKUDescription;
                    txtSKYQty.Text = objSelectedSKU.SKUQty.ToString();
                    cmbPackingType.SelectedValue = objSelectedSKU.SKUPackingType.PackingID.ToString();

                    this.SKUSelect = true;

                }
                catch (Exception ex)
                {

                    MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    objSKUDL = null;
                    objPackingTypeDL = null;
                } 
            }
        }

        //----- PackingType Tab Controller Events -------------------------
        private void tabControlPackingType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlPackingType.SelectedTab.Equals(tpPackingTypeBulkPacks))
            {

                PackingType_DL objPackingTypeDL = new PackingType_DL(ConnectionStringClass.GetConnection());
                try
                {
                    cmbPackingType.DataSource = objPackingTypeDL.GetDataComboList();

                }
                catch (Exception ex)
                {

                    MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    objPackingTypeDL = null;
 
                }
            }
        }

        //----- Shift Events ----------------------------------------------
        private void btnShiftSave_Click(object sender, EventArgs e)
        {
            //WorkShift_DL objWorkShiftDL = new WorkShift_DL(ConnectionStringClass.GetConnection());


            //if (txtShiftName.Text.Equals(""))
            //{
            //    MessageBox.Show(this, "Please Fill all Fields", "Blank Fields", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            //}
            //else
            //{

            //    try
            //    {
            //        objSelectedShift.ShiftEnd = Convert.ToDateTime(dtShiftEnd.Value);
            //        objSelectedShift.ShiftName = txtShiftName.Text;
            //        objSelectedShift.ShiftStart = Convert.ToDateTime(dtShiftStart.Value);



            //        int x;

            //        if (this.ShiftSelect)
            //        {
            //            x = objWorkShiftDL.Update(objSelectedShift);
            //            txtShiftName.Text = "";
            //            dtShiftStart.Value = new DateTime(1999, 9, 9, 12, 0, 0);
            //            dtShiftEnd.Value = new DateTime(1999, 9, 9, 12, 0, 0);
            //            gvShift.DataSource = objWorkShiftDL.GetDataView();

            //            if (x > 0)
            //            {
            //                MessageBox.Show(this, "Succesfully Updated", "Succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //            }

            //        }
            //        else
            //        {
            //            x = objWorkShiftDL.Add(objSelectedShift);
            //            txtShiftName.Text = "";
            //            dtShiftStart.Value = new DateTime(1999, 9, 9, 12, 0, 0);
            //            dtShiftEnd.Value = new DateTime(1999, 9, 9, 12, 0, 0);
            //            gvShift.DataSource = objWorkShiftDL.GetDataView();
            //            if (x > 0)
            //            {
            //                MessageBox.Show(this, "Succesfully Saved", "Succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //            }

            //        }

            //        this.ShiftSelect = false;

            //    }
            //    catch (FormatException)
            //    {

            //        MessageBox.Show(this, "Please enter valid data", "Input Data Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }

            //    catch (Exception ex)
            //    {

            //        MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //    finally
            //    {
            //        objWorkShiftDL = null;
                    

            //    }
            //}
        }

        private void btnShiftDelete_Click(object sender, EventArgs e)
        {
            //if (this.ShiftSelect)
            //{
            //    DialogResult dr = MessageBox.Show(this, "Are you sure, You want to Delete selected Record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //    if (dr == DialogResult.Yes)
            //    {

            //        WorkShift_DL objWorkshiftDL = new WorkShift_DL(ConnectionStringClass.GetConnection());
            //        try
            //        {

            //            int x = objWorkshiftDL.Delete(objSelectedShift.ShiftID);
            //            txtShiftName.Text = "";
            //            dtShiftStart.Value = new DateTime(1999, 9, 9, 12, 0, 0);
            //            dtShiftEnd.Value = new DateTime(1999, 9, 9, 12, 0, 0);
            //            gvShift.DataSource = objWorkshiftDL.GetDataView();
            //            this.ShiftSelect = false;
            //            if (x > 0)
            //            {
            //                MessageBox.Show(this, "Succesfully Deleted", "Succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //            }

            //        }
            //        catch (Exception ex)
            //        {

            //            MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        }
            //        finally
            //        {
            //            objWorkshiftDL = null;
            //        }

            //    }
            //}
            //else
            //{
            //    MessageBox.Show(this, "Select a Record from the List", "Select a Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
        }

        private void btnShiftClear_Click(object sender, EventArgs e)
        {
           
            txtShiftName.Text = "";
            dtShiftStart.Value = new DateTime(1999, 9, 9, 12, 0, 0);
            dtShiftEnd.Value = new DateTime(1999, 9, 9, 12, 0, 0);
            this.ShiftSelect = false;
        }

        private void gvShift_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex>=0)
            {
                try
                {
                    objSelectedShift.ShiftEnd = Convert.ToDateTime(gvShift.Rows[e.RowIndex].Cells["ColShiftEnd"].Value);
                    objSelectedShift.ShiftStart = Convert.ToDateTime(gvShift.Rows[e.RowIndex].Cells["ColShiftStart"].Value);
                    objSelectedShift.ShiftID = Convert.ToInt64(gvShift.Rows[e.RowIndex].Cells["ColShiftID"].Value);
                    objSelectedShift.ShiftName = gvShift.Rows[e.RowIndex].Cells["ColShift"].Value.ToString();

                    dtShiftEnd.Value = objSelectedShift.ShiftEnd;
                    dtShiftStart.Value = objSelectedShift.ShiftStart;
                    txtShiftName.Text = objSelectedShift.ShiftName;

                    this.ShiftSelect = true;

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

        //----- Supplier type Events ----------------------------------------------
   /*     private void btnSupplierTypeSave_Click(object sender, EventArgs e)
        {
            SupplierType_DL objSupplierTypeDL = new SupplierType_DL(ConnectionStringClass.GetConnection());


            if (txtSupplierType.Text.Equals(""))
            {
                MessageBox.Show(this, "Please Fill all Fields", "Blank Fields", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {

                try
                {
                    objSelectedSupplierType.SupplerTypeTitle = txtSupplierType.Text;



                    int x;

                    if (this.SupplierTypeSelect)
                    {
                        x = objSupplierTypeDL.Update(objSelectedSupplierType);
                        txtSupplierType.Text = "";
                        gvSupplierType.DataSource = objSupplierTypeDL.GetDataView();
                        

                        if (x > 0)
                        {
                            MessageBox.Show(this, "Succesfully Updated", "Succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                    else
                    {
                        x = objSupplierTypeDL.Add(objSelectedSupplierType);
                        txtSupplierType.Text = "";
                        gvSupplierType.DataSource = objSupplierTypeDL.GetDataView();
                        
                        if (x > 0)
                        {
                            MessageBox.Show(this, "Succesfully Saved", "Succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }

                    this.SupplierTypeSelect = false;

                }
                catch (FormatException)
                {

                    MessageBox.Show(this, "Please enter valid data", "Input Data Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                catch (Exception ex)
                {

                    MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    objSupplierTypeDL = null;


                }
            }
        }

        private void btnSupplierTypeDelete_Click(object sender, EventArgs e)
        {
            if (this.SupplierTypeSelect)
            {
                DialogResult dr = MessageBox.Show(this, "Are you sure, You want to Delete selected Record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {

                    SupplierType_DL objSupplierTypeDL = new SupplierType_DL(ConnectionStringClass.GetConnection());
                    try
                    {

                        int x = objSupplierTypeDL.Delete(objSelectedSupplierType.SupplierTypeId);
                        txtSupplierType.Text = "";
                        gvSupplierType.DataSource = objSupplierTypeDL.GetDataView();
                        this.SupplierTypeSelect = false;
                        if (x > 0)
                        {
                            MessageBox.Show(this, "Succesfully Deleted", "Succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        objSupplierTypeDL = null;
                    }

                }
            }
            else
            {
                MessageBox.Show(this, "Select a Record from the List", "Select a Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSupplierTypeClear_Click(object sender, EventArgs e)
        {
            txtSupplierType.Text = "";
            this.SupplierTypeSelect = false;
        }

        private void gvSupplierType_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                objSelectedSupplierType.SupplierTypeId = Convert.ToInt32(gvSupplierType.Rows[e.RowIndex].Cells[0].Value);
                objSelectedSupplierType.SupplerTypeTitle = gvSupplierType.Rows[e.RowIndex].Cells[1].Value.ToString();

                txtSupplierType.Text = objSelectedSupplierType.SupplerTypeTitle;
                this.SupplierTypeSelect = true;

            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

            }
        }*/

        //---------- Machine Category Events --------------------------------------
        private void btnMachineCatSave_Click(object sender, EventArgs e)
        {
            MachineType_DL objMachineTypeDL = new MachineType_DL(ConnectionStringClass.GetConnection());


            if (txtMachineCategory.Text.Equals(""))
            {
                MessageBox.Show(this, "Please Fill all Fields", "Blank Fields", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {

                try
                {
                    objSelectedMachineType.MachineTypeTitle = txtMachineCategory.Text;

                    int x;

                    if (this.MachineTypeSelect)
                    {
                        x = objMachineTypeDL.Update(objSelectedMachineType);
                        txtMachineCategory.Text = "";
                        dataGridView1.DataSource = objMachineTypeDL.GetDataView();


                        if (x > 0)
                        {
                            MessageBox.Show(this, "Succesfully Updated", "Succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                    else
                    {
                        x = objMachineTypeDL.Add(objSelectedMachineType);
                        txtMachineCategory.Text = "";
                        dataGridView1.DataSource = objMachineTypeDL.GetDataView();

                        if (x > 0)
                        {
                            MessageBox.Show(this, "Succesfully Saved", "Succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }

                    this.SupplierTypeSelect = false;

                }
                catch (FormatException)
                {

                    MessageBox.Show(this, "Please enter valid data", "Input Data Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                catch (Exception ex)
                {

                    MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    objMachineTypeDL = null;


                }
            }
        }

        private void btnMachineCatDelete_Click(object sender, EventArgs e)
        {
            if (this.MachineTypeSelect)
            {
                DialogResult dr = MessageBox.Show(this, "Are you sure, You want to Delete selected Record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {

                    MachineType_DL objMachineTypeDL = new MachineType_DL(ConnectionStringClass.GetConnection());
                    try
                    {

                        int x = objMachineTypeDL.Add(objSelectedMachineType);
                        txtMachineCategory.Text = "";
                        dataGridView1.DataSource = objMachineTypeDL.GetDataView();
                        this.MachineTypeSelect = false;
                        if (x > 0)
                        {
                            MessageBox.Show(this, "Succesfully Deleted", "Succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        objMachineTypeDL = null;
                    }

                }
            }
            else
            {
                MessageBox.Show(this, "Select a Record from the List", "Select a Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnMachineCatClear_Click(object sender, EventArgs e)
        {
            txtMachineCategory.Text = "";
            this.MachineTypeSelect = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex>=0)
            {
                try
                {
                    objSelectedMachineType.MachineTypeID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                    objSelectedMachineType.MachineTypeTitle = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();

                    txtMachineCategory.Text = objSelectedMachineType.MachineTypeTitle;
                    this.MachineTypeSelect = true;

                }
                catch (Exception ex)
                {

                    MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } 
            }
        }


        //-------------------------- Employee role Events --------------------------
        private void gvEmployeeRoleList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    EmployeeRole_DL objEmpRoleDL = new EmployeeRole_DL(ConnectionStringClass.GetConnection());
                    long ID = Convert.ToInt64(gvEmployeeRoleList.Rows[e.RowIndex].Cells[0].Value);

                    objEmployeeRole = objEmpRoleDL.Get(ID);




                    this.EmpRoleSelect = true;
                    txtEmployeeRole.Text = objEmployeeRole.RoleTitle;
                    cmbEmployeeRoleType.SelectedItem = objEmployeeRole.Type;



                }
                catch (Exception ex)
                {

                    MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } 
            }
        }

        private void btnEmpClear_Click(object sender, EventArgs e)
        {
            txtEmployeeRole.Text = "";

            this.EmpRoleSelect = false;
        }

        private void betEmpDelete_Click(object sender, EventArgs e)
        {
            if (this.EmpRoleSelect)
            {
                DialogResult dr = MessageBox.Show(this, "Are you sure, You want to Delete selected Record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    EmployeeRole_DL objEmpRoleDL = new EmployeeRole_DL(ConnectionStringClass.GetConnection());
                    try
                    {

                        int x = objEmpRoleDL.Delete(objEmployeeRole.EmpRoleID);
                        gvEmployeeRoleList.DataSource = objEmpRoleDL.GetDataView();
                        
                        if (x > 0)
                        {
                            MessageBox.Show(this, "Succesfully Deleted", "Succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtEmployeeRole.Text = "";
                            cmbEmployeeRoleType.SelectedIndex = 0;
                            this.EmpRoleSelect = false;
                        }

                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        objEmpRoleDL = null;
                    }

                }
            }
            else
            {
                MessageBox.Show(this, "Select a Record from the List", "Select a Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnEmpSave_Click(object sender, EventArgs e)
        {
            EmployeeRole_DL objEmployeeDL = new EmployeeRole_DL(ConnectionStringClass.GetConnection());
            if (txtEmployeeRole.Text.Equals("") )
            {
                MessageBox.Show(this, "Please Fill all Fields", "Blank Fields", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {

                try
                {
                    objEmployeeRole.Type = cmbEmployeeRoleType.SelectedItem.ToString();
                    objEmployeeRole.RoleTitle = txtEmployeeRole.Text;

                    int x;

                    if (this.EmpRoleSelect)
                    {
                        x = objEmployeeDL.Update(objEmployeeRole);

                        gvEmployeeRoleList.DataSource = objEmployeeDL.GetDataView();


                        if (x > 0)
                        {
                            MessageBox.Show(this, "Succesfully Updated", "Succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtEmployeeRole.Text = "";
                            cmbEmployeeRoleType.SelectedIndex = 0;
                            this.EmpRoleSelect = false;
                        }

                    }
                    else
                    {
                        x = objEmployeeDL.Add(objEmployeeRole);

                        gvEmployeeRoleList.DataSource = objEmployeeDL.GetDataView();

                        if (x > 0)
                        {
                            MessageBox.Show(this, "Succesfully Saved", "Succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtEmployeeRole.Text = "";
                            cmbEmployeeRoleType.SelectedIndex = 0;
                            this.EmpRoleSelect = false;
                        }

                    }

                    this.SupplierTypeSelect = false;

                }
                catch (FormatException)
                {

                    MessageBox.Show(this, "Please enter valid data", "Input Data Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                catch (Exception ex)
                {

                    MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    objEmployeeDL = null;


                }
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar) || (e.KeyChar == (char)46)))
            {
                e.Handled = true;
            }
        }

        private void txtNewRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar) || (e.KeyChar == (char)46)))
            {
                e.Handled = true;
            }
        }

        private void groupBox7_Enter(object sender, EventArgs e)
        {

        }

        private void ucMaterialSubCatL11_Load(object sender, EventArgs e)
        {

        }

        private void btnSMsave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtSMID.Text) || String.IsNullOrWhiteSpace(txtSMDesctiption.Text))
            {
                MessageBox.Show(this, "Please Fill all Fields", "Blank Fields", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                objSalesMethod_DL.Add(txtSMID.Text, txtSMDesctiption.Text);
                MessageBox.Show(this, "Succesfully Added to Database", "Succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadSMTable();
            }
        }

        private void btnSMDelete_Click(object sender, EventArgs e)
        {
            if (dgvSM.CurrentCell.RowIndex > -1)
            {
                DialogResult dr = MessageBox.Show(this, "Are you sure, You want to Delete selected Record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    objSalesMethod_DL.Delete(dgvSM.CurrentRow.Cells["SMID"].Value.ToString());
                    MessageBox.Show(this, "Succesfully Deleted from Database", "Succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadSMTable();
                }
            }
            else
            {
                MessageBox.Show(this, "please select a record to delete", "MRP System", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void LoadSMTable()
        {
            dgvSM.DataSource = objSalesMethod_DL.Get();
        }


    }
}