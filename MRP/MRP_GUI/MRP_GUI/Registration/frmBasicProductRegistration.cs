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
    public partial class frmBasicProductRegistration : System.Windows.Forms.Form
    {
        public frmBasicProductRegistration()
        {
            InitializeComponent();
        }

        private BasicProduct objBasicProduct = new BasicProduct();
        private String OriginalBasicProduct = "";

        private FinishProduct objFinishProduct = new FinishProduct();

        private bool ProductSelect = false;



        private Unit_DL objUnitDL = new Unit_DL(ConnectionStringClass.GetConnection());
        private Form_DL objFormDL = new Form_DL(ConnectionStringClass.GetConnection());
        private ProductCategory_DL objProductCategoryDL = new ProductCategory_DL(ConnectionStringClass.GetConnection());
        private ProductSubCategory_DL objProductSubCategory_DL = new ProductSubCategory_DL(ConnectionStringClass.GetConnection());
        private Formula_DL objFormulaDL = new Formula_DL(ConnectionStringClass.GetConnection());
        private PackingType_DL objPackingTypeDL = new PackingType_DL(ConnectionStringClass.GetConnection());
        private FinishProduct_DL objFinishProductDL = new FinishProduct_DL(ConnectionStringClass.GetConnection());
        private BasicProduct_DL objbasicProductDL = new BasicProduct_DL(ConnectionStringClass.GetConnection());
        private Department_DL objDepartment_DL = new Department_DL(ConnectionStringClass.GetConnection());
        private Section_DL objSection_DL = new Section_DL(ConnectionStringClass.GetConnection());

        public void ProductLoad()
        {

            try
            {
                bindCategory.DataSource = objProductCategoryDL.GetDataView();
                cmbCategory.DataSource = bindCategory;

                bindSubCategory.DataSource = objProductSubCategory_DL.GetDataView();
                cmbProductSubCategory.DataSource = bindSubCategory;

                bindUnits.DataSource = objUnitDL.GetDataView();
                cmbUnit.DataSource = bindUnits;

                bindForm.DataSource = objFormDL.GetDataView();
                cmbForm.DataSource = bindForm;

                bindDepartment.DataSource = objDepartment_DL.GetDataView();
                cmbDepartment.DataSource = bindDepartment;

                bindSections.DataSource = objSection_DL.GetDataView();
               cmbSections.DataSource = bindSections;

               
            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

            }
        }

        public void ClearBasicProduct()
        {
            txtRate.Text = "0.00";
            txtProductDescription.Text = "";
            txtProductCode.Text = "";
            //cmbCategory.SelectedIndex = 0;
            cmbForm.SelectedIndex = 0;
            cmbProductType.SelectedIndex = 0;
            cmbProductSubCategory.SelectedIndex = 0;
            cmbUnit.SelectedIndex = 0;
            chkDisable.Checked = false;
            this.ProductSelect = false;
        }


        private void frmProductRegistration_Load(object sender, EventArgs e)
        {
            ProductLoad();
        }

        private void button11_Click(object sender, EventArgs e)
        {

            if (txtRate.Text.Equals("") || cmbProductSubCategory.Text.Equals("") || txtProductCode.Text.Equals("") | (cmbDepartment.SelectedValue == null)| (cmbSections.SelectedValue == null))
            {
                MessageBox.Show(this, "Please Fill all Fields", "Blank Fields", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {

                try
                {
                    objBasicProduct.BasicProductAVGCost = Convert.ToDecimal(txtRate.Text);
                    objBasicProduct.BasicProductCategory = objProductCategoryDL.Get(cmbCategory.SelectedValue.ToString());
                    objBasicProduct.BasicProductCode = txtProductCode.Text;
                    objBasicProduct.BasicProductDescription = txtProductDescription.Text;
                    objBasicProduct.BasicProductForm = objFormDL.Get(Convert.ToInt64(cmbForm.SelectedValue));
                    // objBasicProduct.BasicProductFormula = null;
                    objBasicProduct.BasicProductName = "";
                    objBasicProduct.BasicProductStatus = !chkDisable.Checked;
                    objBasicProduct.BasicProductSubCategory = objProductSubCategory_DL.Get(cmbProductSubCategory.SelectedValue.ToString());
                    objBasicProduct.BasicProductType = cmbProductType.SelectedItem.ToString();
                    objBasicProduct.BasicProductUnit = objUnitDL.Get(Convert.ToInt64(cmbUnit.SelectedValue));
                    objBasicProduct.STDBatchSize = Convert.ToDecimal(txtSTDBatchSize.Text);



                    int x;

                        x = objbasicProductDL.Add(objBasicProduct, Convert.ToInt32(cmbDepartment.SelectedValue), Convert.ToInt32(cmbSections.SelectedValue));

                        if (x > 0)
                        {
                            MessageBox.Show(this, "Succesfully Added to Database", "Succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.ClearBasicProduct();
                        }

                        BasicProductBinidinSourse.DataSource = objbasicProductDL.GetDataView_By_Category(cmbCategory.SelectedValue.ToString());
                        gvBasicProduct.DataSource = BasicProductBinidinSourse;

                        
                        
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


                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (this.ProductSelect)
            {
                DialogResult dr = MessageBox.Show(this, "Are you sure, You want to Delete selected Record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {

                    BasicProduct_DL objbasicProduct = new BasicProduct_DL(ConnectionStringClass.GetConnection());
                    try
                    {

                        int x = objbasicProductDL.Delete(txtProductCode.Text);
                        BasicProductBinidinSourse.DataSource = objbasicProductDL.GetDataView_By_Category(cmbCategory.SelectedValue.ToString());


                        this.ProductSelect = false;
                        if (x > 0)
                        {
                            MessageBox.Show(this, "Succesfully Deleted From Database", "Succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.ClearBasicProduct();

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

        private void button9_Click(object sender, EventArgs e)
        {
            ClearBasicProduct();
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void textBox18_Validated(object sender, EventArgs e)
        {
            try
            {
                Convert.ToDecimal(txtRate.Text);
                errorProvider1.SetError(txtRate, "");
            }
            catch (Exception)
            {

                errorProvider1.SetError(txtRate, "Average Unit Cost should be a Numaric value");
            }
        }



        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbCategory.SelectedValue != null)
                {
                    BasicProductBinidinSourse.DataSource = objbasicProductDL.GetDataView_By_Category(cmbCategory.SelectedValue.ToString());
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox13_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvBasicProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                objBasicProduct.BasicProductCode = Convert.ToString(gvBasicProduct.CurrentRow.Cells["ColBasicProductCode"].Value);
                objBasicProduct.BasicProductAVGCost = Convert.ToDecimal(gvBasicProduct.CurrentRow.Cells["ColBasicProductAvgCost"].Value);
                objBasicProduct.BasicProductDescription = gvBasicProduct.CurrentRow.Cells["ColBasicProductDescription"].Value.ToString();
                objBasicProduct.BasicProductForm = objFormDL.Get(Convert.ToInt64(gvBasicProduct.CurrentRow.Cells["ColBasicProductFormID"].Value));

                if (gvBasicProduct.CurrentRow.Cells["ColBasicProductFormulaID"].Value.ToString().Equals(""))
                {
                    objBasicProduct.BasicProductFormula = null;
                }
                else
                {
                    objBasicProduct.BasicProductFormula = objFormulaDL.Get(Convert.ToInt64(gvBasicProduct.CurrentRow.Cells["ColBasicProductFormulaID"].Value));
                }


                objBasicProduct.BasicProductStatus = Convert.ToBoolean(gvBasicProduct.CurrentRow.Cells["ColBasicProductStatus"].Value);
                objBasicProduct.BasicProductSubCategory = objProductSubCategory_DL.Get(gvBasicProduct.CurrentRow.Cells["ColBasicProductSubCatID"].Value.ToString());
                objBasicProduct.BasicProductType = gvBasicProduct.CurrentRow.Cells["ColBasicProductType"].Value.ToString();
                objBasicProduct.BasicProductUnit = objUnitDL.Get(Convert.ToInt64(gvBasicProduct.CurrentRow.Cells["ColBasicProductUnitID"].Value));

                txtRate.Text = objBasicProduct.BasicProductAVGCost.ToString();
                txtProductDescription.Text = objBasicProduct.BasicProductDescription;
                txtProductCode.Text = objBasicProduct.BasicProductCode;
                txtSTDBatchSize.Text = gvBasicProduct.CurrentRow.Cells["STDBatchSize"].Value.ToString();

                cmbForm.SelectedValue = objBasicProduct.BasicProductForm.FormID;
                cmbProductType.SelectedValue = objBasicProduct.BasicProductType;
                cmbProductSubCategory.SelectedValue = objBasicProduct.BasicProductSubCategory.CategoryID;
                cmbUnit.SelectedValue = objBasicProduct.BasicProductUnit.UnitID;
                chkDisable.Checked = !objBasicProduct.BasicProductStatus;
                cmbProductType.Text = gvBasicProduct.CurrentRow.Cells["ColBasicProductType"].Value.ToString();

                OriginalBasicProduct = objBasicProduct.BasicProductCode;

               cmbDepartment.SelectedValue = Convert.ToInt32(gvBasicProduct.CurrentRow.Cells["DepID"].Value);
                cmbSections.SelectedValue = Convert.ToInt32(gvBasicProduct.CurrentRow.Cells["SectionID"].Value);


                this.ProductSelect = true;

            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}