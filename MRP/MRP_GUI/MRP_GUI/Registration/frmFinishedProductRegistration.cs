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
    public partial class frmFinishedProductRegistration : System.Windows.Forms.Form
    {
        public frmFinishedProductRegistration()
        {
            InitializeComponent();
        }

        private BasicProduct objBasicProduct = new BasicProduct();
        DataTable dtSecondaryProducts = new DataTable();
        DataTable dtTertiaryProducts = new DataTable();

        private FinishProduct objFinishProduct = new FinishProduct();
        private FinishProduct objFinishProductSec = new FinishProduct();
        private FinishProduct objFinishProductTer = new FinishProduct();
        private String OriginalFinishProductCode = "";

        private bool FinishProductSelect = false;



        private Unit_DL objUnitDL = new Unit_DL(ConnectionStringClass.GetConnection());
        private Form_DL objFormDL = new Form_DL(ConnectionStringClass.GetConnection());
        private ProductCategory_DL objProductCategoryDL = new ProductCategory_DL(ConnectionStringClass.GetConnection());
        private ProductSubCategory_DL objProductSubCategory = new ProductSubCategory_DL(ConnectionStringClass.GetConnection());
        private Formula_DL objFormulaDL = new Formula_DL(ConnectionStringClass.GetConnection());
        private PackingType_DL objPackingTypeDL = new PackingType_DL(ConnectionStringClass.GetConnection());
        private FinishProduct_DL objFinishProductDL = new FinishProduct_DL(ConnectionStringClass.GetConnection());
        private BasicProduct_DL objbasicProductDL = new BasicProduct_DL(ConnectionStringClass.GetConnection());

        public void ProductLoad()
        {

            try
            {
                BasicProductBinidinSourse.DataSource = objbasicProductDL.GetDataView(true);
                cmbBasicProduct.DataSource = BasicProductBinidinSourse;


                bindPackType.DataSource = objPackingTypeDL.GetDataByType("Primary");
                cmbPackType.DataSource = bindPackType;

                bindPackType2.DataSource = objPackingTypeDL.GetDataByType("Secondary");
                cmbPackTypeSec.DataSource = bindPackType2;

                bindPackType3.DataSource = objPackingTypeDL.GetDataByType("Tertiary");
                cmbPackTypeTer.DataSource = bindPackType3;


            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

            }
        }

        public void ClearFinishProduct()
        {
            txtBasicProductQty.Text = "0.00";
            txtFinishProductAvgCost.Text = "0.00";
            txtFinishProductDescription.Text = "";
            chkEnablePr.Checked = false;
            cmbPackType.SelectedIndex = 0;
            //cmbBasicProduct.SelectedIndex = 0;
            this.FinishProductSelect = false;


        }

        private void frmProductRegistration_Load(object sender, EventArgs e)
        {
            ProductLoad();
        }
        private void txtBasicProductQty_Validated(object sender, EventArgs e)
        {
            try
            {
                Convert.ToDecimal(txtBasicProductQty.Text);
            }
            catch (Exception)
            {

                //errorProvider1.SetError(txtBasicProductQty, "Quantity should be a Numaric value");
            }
        }

        private void btnAddFinishProduct_Click(object sender, EventArgs e)
        {
            if (txtFinishProductAvgCost.Text.Equals("") || txtProductCode.Text.Equals("") || txtFinishProductDescription.Text.Equals(""))
            {
                MessageBox.Show(this, "Please Fill all Fields", "Blank Fields", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {

                try
                {
                    objFinishProduct.FinishProductCode = txtProductCode.Text;
                    objFinishProduct.BasicProduct = objbasicProductDL.Get(cmbBasicProduct.SelectedValue.ToString());
                    objFinishProduct.FinishProductPackingType = objPackingTypeDL.Get(Convert.ToInt64(cmbPackType.SelectedValue));
                    objFinishProduct.FinishProductDescription = txtFinishProductDescription.Text;
                    objFinishProduct.BasicProductQty = Convert.ToDecimal(txtBasicProductQty.Text);
                    objFinishProduct.FinishProductAvgCost = Convert.ToDecimal(txtFinishProductAvgCost.Text);
                    if (chkEnablePr.Checked == true)
                    {
                        objFinishProduct.FinishProductStatus = true;
                    }
                    else
                    {
                        objFinishProduct.FinishProductStatus = false;
                    }
                    objFinishProduct.PrimaryFinishProductCode = txtProductCode.Text ;
                    objFinishProduct.PrimaryFinishProductQty = 1;
                    objFinishProduct.FinishProductType = "Primary";

                    int x;
                        x = objFinishProductDL.Add(objFinishProduct);
                        gvFinishProduct.DataSource = objFinishProductDL.GetDataView("Primary", cmbBasicProduct.SelectedValue.ToString());

                        if (x > 0)
                        {
                            MessageBox.Show(this, "Succesfully Added to Database", "Succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            this.ClearFinishProduct();

                        }
                        else if (x == -1)
                        {
                            MessageBox.Show(this, "Product Code already in the Database,Please enter another Product Code", "Problem with Product Code", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
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

        private void cmbBasicProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtProductCode.Text = "";
            if (cmbBasicProduct.SelectedValue != null)
            {
                try
                {
                    gvFinishProduct.AutoGenerateColumns = false;
                    bindPrimaryProduct.DataSource = objFinishProductDL.GetDataView("Primary", cmbBasicProduct.SelectedValue.ToString());
                    gvFinishProduct.DataSource = bindPrimaryProduct;
                    bindPrimaryProduct.ResetBindings(true);


                    txtProductCode.Text = cmbBasicProduct.SelectedValue.ToString();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            
        }

        private void gvFinishProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                objFinishProduct.BasicProduct = objbasicProductDL.Get(gvFinishProduct.Rows[e.RowIndex].Cells["ColBasicProductCode1"].Value.ToString());

                objFinishProduct.BasicProductQty = Convert.ToDecimal(gvFinishProduct.Rows[e.RowIndex].Cells["ColFinishProductBasicQty"].Value);
                objFinishProduct.FinishProductCode = gvFinishProduct.Rows[e.RowIndex].Cells["ColFinishProductCode"].Value.ToString();
                objFinishProduct.FinishProductAvgCost = Convert.ToDecimal(gvFinishProduct.Rows[e.RowIndex].Cells["ColFinishProductAvgCost"].Value);
                objFinishProduct.FinishProductDescription = gvFinishProduct.Rows[e.RowIndex].Cells["ColFinishProductDescription"].Value.ToString();

                objFinishProduct.FinishProductPackingType = objPackingTypeDL.Get(Convert.ToInt64(gvFinishProduct.Rows[e.RowIndex].Cells["ColFinishProductPackingID"].Value));
                objFinishProduct.FinishProductStatus = Convert.ToBoolean(gvFinishProduct.Rows[e.RowIndex].Cells["ColFinishProductStatus"].Value);

                txtFinishProductAvgCost.Text = objFinishProduct.FinishProductAvgCost.ToString();
                txtProductCode.Text = objFinishProduct.FinishProductCode;
                txtFinishProductDescription.Text = objFinishProduct.FinishProductDescription;
                cmbBasicProduct.SelectedValue = objFinishProduct.BasicProduct.BasicProductCode;
                txtBasicProductQty.Text = objFinishProduct.BasicProductQty.ToString();
                cmbPackType.SelectedValue = objFinishProduct.FinishProductPackingType.PackingID;
                if (objFinishProduct.FinishProductStatus == true)
                {
                    chkEnablePr.Checked = true;
                }
                else
                {
                    chkEnablePr.Checked = false;
                }
                OriginalFinishProductCode = objFinishProduct.FinishProductCode;

                this.FinishProductSelect = true;
                
                Load_SecondaryProductList();

                Load_TertiaryProductList();


            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Load_SecondaryProductList()
        {
            try
            {
                if (gvFinishProduct.CurrentRow != null)
                {
                    dtSecondaryProducts = objFinishProductDL.Get_SecondaryProductList_All(gvFinishProduct.CurrentRow.Cells["ColFinishProductCode"].Value.ToString());
                    dgvProductListSecondary.AutoGenerateColumns = false;
                    bindSecondaryProduct.DataSource = dtSecondaryProducts;
                    dgvProductListSecondary.DataSource = bindSecondaryProduct;
                    bindSecondaryProduct.ResetBindings(true);

                    txtPrimaryProductCode.Text = gvFinishProduct.CurrentRow.Cells["ColFinishProductCode"].Value.ToString();
                }
                else
                {
                    dtSecondaryProducts = null;
                    dgvProductListSecondary.AutoGenerateColumns = false;
                    bindSecondaryProduct.DataSource = dtSecondaryProducts;
                    dgvProductListSecondary.DataSource = bindSecondaryProduct;
                    bindSecondaryProduct.ResetBindings(true);
                }

            
            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void Load_TertiaryProductList()
        {
            try
            {
                if (dgvProductListSecondary.CurrentRow!= null)
                {
                    dtTertiaryProducts = objFinishProductDL.Get_TertiaryProductList_All(dgvProductListSecondary.CurrentRow.Cells["ProductCode"].Value.ToString());
                    dgvProductListTertiary.AutoGenerateColumns = false;
                    bindTertiaryProduct.DataSource = dtTertiaryProducts;
                    dgvProductListTertiary.DataSource = bindTertiaryProduct;
                    bindTertiaryProduct.ResetBindings(true);

                    txtSecondaryProductCode.Text = dgvProductListSecondary.CurrentRow.Cells["ProductCode"].Value.ToString();
                }
                else
                {
                    dtTertiaryProducts = null;
                    dgvProductListTertiary.AutoGenerateColumns = false;
                    bindTertiaryProduct.DataSource = dtTertiaryProducts;
                    dgvProductListTertiary.DataSource = bindTertiaryProduct;
                    bindTertiaryProduct.ResetBindings(true);
                }

               
            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteFinishProduct_Click(object sender, EventArgs e)
        {
            if (this.FinishProductSelect)
            {
                DialogResult dr = MessageBox.Show(this, "Are you sure, You want to Delete selected Record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {

                    try
                    {

                        int x = objFinishProductDL.Delete(OriginalFinishProductCode);
                        gvFinishProduct.DataSource = objFinishProductDL.GetDataView("Primary", cmbBasicProduct.SelectedValue.ToString());



                        if (x > 0)
                        {
                            MessageBox.Show(this, "Succesfully Deleted From Database", "Succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearFinishProduct();
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

        private void txtFinishProductAvgCost_Validated(object sender, EventArgs e)
        {
            try
            {
                Convert.ToDecimal(txtFinishProductAvgCost.Text);
            }
            catch (Exception)
            {

               // errorProvider1.SetError(txtFinishProductAvgCost, "Quantity should be a Numaric value");
            }
        }

        private void btnFinishProductClear_Click(object sender, EventArgs e)
        {
            ClearFinishProduct();
        }

        private void listCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    if (listCategory.SelectedValue != null)
            //    {
            //        BasicProductBinidinSourse.DataSource = objbasicProductDL.GetDataView_By_Category(listCategory.SelectedValue.ToString());
            //        if (cmbBasicProduct.Items.Count > 0)
            //        {
            //            cmbBasicProduct.SelectedIndex = 0;
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{

            //    MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void dgvProductListSecondary_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                objFinishProductSec = objFinishProductDL.Get(dgvProductListSecondary.CurrentRow.Cells["ProductCode"].Value.ToString());
                
                txtSecondaryProduct.Text = objFinishProductSec.FinishProductCode;
                txtDescriptionSec.Text = objFinishProductSec.FinishProductDescription;
                txtPrimaryQty.Text = objFinishProductSec.PrimaryFinishProductQty.ToString();
                txtPeiceRateSec.Text = objFinishProductSec.FinishProductAvgCost.ToString();

                txtSecondaryProductCode.Text = dgvProductListSecondary.CurrentRow.Cells["ProductCode"].Value.ToString();

                Load_TertiaryProductList();
             }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtSecondaryProduct.Text.Equals("") || txtDescriptionSec.Text.Equals("") || txtPrimaryQty.Text.Equals("") | (cmbPackTypeSec.SelectedValue==null))
            {
                MessageBox.Show(this, "Please Fill all Fields", "Blank Fields", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {

                try
                {
                    objFinishProductSec.FinishProductCode = txtSecondaryProduct.Text;
                    objFinishProductSec.BasicProduct = objbasicProductDL.Get(cmbBasicProduct.SelectedValue.ToString());
                    objFinishProductSec.FinishProductPackingType = objPackingTypeDL.Get(Convert.ToInt64(cmbPackTypeSec.SelectedValue));
                    objFinishProductSec.FinishProductDescription = txtDescriptionSec.Text;
                    objFinishProductSec.BasicProductQty = 0;
                    objFinishProductSec.FinishProductAvgCost = Convert.ToDecimal(txtPeiceRateSec.Text);
                    if (chkEnableSec.Checked == true)
                    {
                        objFinishProductSec.FinishProductStatus = true;
                    }
                    else
                    {
                        objFinishProductSec.FinishProductStatus = false;
                    }

                    objFinishProductSec.PrimaryFinishProductCode = gvFinishProduct.CurrentRow.Cells["ColFinishProductCode"].Value.ToString();
                    objFinishProductSec.PrimaryFinishProductQty = Convert.ToInt32(txtPrimaryQty.Text);
                    objFinishProductSec.FinishProductType = "Secondary";

                    int x;
                    x = objFinishProductDL.Add(objFinishProductSec);

                    Load_SecondaryProductList();

                        if (x > 0)
                        {
                            MessageBox.Show(this, "Succesfully Added to Database", "Succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.ClearFinishProduct();

                        }
                        else if (x == -1)
                        {
                            MessageBox.Show(this, "Product Code already in the Database,Please enter another Product Code", "Problem with Product Code", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
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

        private void btnDeleteSec_Click(object sender, EventArgs e)
        {
            if (dgvProductListSecondary.CurrentRow.Cells["ProductCode"].Value != null)
            {
                DialogResult dr = MessageBox.Show(this, "Are you sure, You want to Delete selected Record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {

                    try
                    {

                        int x = objFinishProductDL.Delete(dgvProductListSecondary.CurrentRow.Cells["ProductCode"].Value.ToString());

                        Load_SecondaryProductList();


                        if (x > 0)
                        {
                            MessageBox.Show(this, "Succesfully Deleted From Database", "Succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearFinishProduct();
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

        private void btnSaveTer_Click(object sender, EventArgs e)
        {
            if (txtProductCodeTer.Text.Equals("") || txtDescriptionTer.Text.Equals("") ||txtSecondaryQty.Text.Equals("") | (cmbPackTypeTer.SelectedValue == null))
            {
                MessageBox.Show(this, "Please Fill all Fields", "Blank Fields", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {

                try
                {
                    objFinishProductTer.FinishProductCode = txtProductCodeTer.Text;
                    objFinishProductTer.BasicProduct = objbasicProductDL.Get(cmbBasicProduct.SelectedValue.ToString());
                    objFinishProductTer.FinishProductPackingType = objPackingTypeDL.Get(Convert.ToInt64(cmbPackTypeTer.SelectedValue));
                    objFinishProductTer.FinishProductDescription = txtDescriptionTer.Text;
                    objFinishProductTer.BasicProductQty = 0;
                    objFinishProductTer.FinishProductAvgCost = Convert.ToDecimal(txtPeiceRateTer.Text);
                    if (chkEnableTer.Enabled == true)
                    {
                        objFinishProductTer.FinishProductStatus = true;
                    }
                    else
                    {
                        objFinishProductTer.FinishProductStatus = false;
                    }
                    objFinishProductTer.PrimaryFinishProductCode = dgvProductListSecondary.CurrentRow.Cells["ProductCode"].Value.ToString();
                    objFinishProductTer.PrimaryFinishProductQty = Convert.ToInt32(txtSecondaryQty.Text);
                    objFinishProductTer.FinishProductType = "Tertiary";

                    int x;
                    x = objFinishProductDL.Add(objFinishProductTer);

                    Load_TertiaryProductList();

                    if (x > 0)
                    {
                        MessageBox.Show(this, "Succesfully Added to Database", "Succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.ClearFinishProduct();

                    }
                    else if (x == -1)
                    {
                        MessageBox.Show(this, "Product Code already in the Database,Please enter another Product Code", "Problem with Product Code", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
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

        private void dgvProductListTertiary_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                objFinishProductTer = objFinishProductDL.Get(dgvProductListTertiary.CurrentRow.Cells["TertiaryProductCode"].Value.ToString());

                txtProductCodeTer.Text = objFinishProductTer.FinishProductCode;
                txtDescriptionTer.Text = objFinishProductTer.FinishProductDescription;
               txtSecondaryQty.Text = objFinishProductTer.PrimaryFinishProductQty.ToString();
               txtPeiceRateTer.Text = objFinishProductTer.FinishProductAvgCost.ToString();

            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteTer_Click(object sender, EventArgs e)
        {
            if (dgvProductListTertiary.CurrentRow.Cells["TertiaryProductCode"].Value != null)
            {
                DialogResult dr = MessageBox.Show(this, "Are you sure, You want to Delete selected Record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {

                    try
                    {

                        int x = objFinishProductDL.Delete(dgvProductListTertiary.CurrentRow.Cells["TertiaryProductCode"].Value.ToString());

                        Load_TertiaryProductList();


                        if (x > 0)
                        {
                            MessageBox.Show(this, "Succesfully Deleted From Database", "Succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearFinishProduct();
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

        private void dgvProductListSecondary_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}