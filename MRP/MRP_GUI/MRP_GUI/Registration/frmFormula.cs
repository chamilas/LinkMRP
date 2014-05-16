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
    public partial class frmFormula : System.Windows.Forms.Form
    {
        //-----------------------------------------------------
        private User _objCurrentUser;

        public User CurrentUser
        {
            get { return _objCurrentUser; }
            set { _objCurrentUser = value; }
        }

        Material_DL objMaterialDL = new Material_DL(ConnectionStringClass.GetConnection());
        FinishProduct_DL objFinishProductDL = new FinishProduct_DL(ConnectionStringClass.GetConnection());
        BasicProduct_DL objBasicProductDL = new BasicProduct_DL(ConnectionStringClass.GetConnection());

        FinishProduct objFinishProduct = new FinishProduct();
        BasicProduct objBasicProduct = new BasicProduct();
        Material objMaterial = new Material();

        Formula_DL objFormulaDL = new Formula_DL(ConnectionStringClass.GetConnection());
        Formula objFormula = new Formula();

        FormulaBasicProduct_DL objFormulaBasicProductDL = new FormulaBasicProduct_DL(ConnectionStringClass.GetConnection());
        FormulaFinishProduct_DL objFormulaFinishProductDL = new FormulaFinishProduct_DL(ConnectionStringClass.GetConnection());
        FormulaMaterial_DL objFormulaMaterialDL = new FormulaMaterial_DL(ConnectionStringClass.GetConnection());

        bool SelectMaterial = false;
        bool SelectBasic = false;
        bool SelectFinish = false;


        //-----------------------------------------------------

        public frmFormula()
        {

            InitializeComponent();
        }

        public frmFormula(User objUser)
        {

            InitializeComponent();
            CurrentUser = objUser;
        }

        private void cmbBasicProductCode_SelectedIndexChanged(object sender, EventArgs e)
        {

            txtPackType.Visible = false;
            lblPackType.Visible = false;
            txtBasicProduct.Visible = false;
            txtBasicQty.Visible = false;
            lblBasic.Visible = false;
            lblBasicQty.Visible = false;

            txtBasicProduct.Text = "";
            txtBasicQty.Text = "";
            txtCatergory.Text = "";
            txtPackType.Text = "";
            txtProductCode.Text = "";
            txtProductName.Text = "";
            txtProductType.Text = "";
            txtProductUnit.Text = "";
            txtSubCatergory.Text = "";


            txtFinishProductQty.Text = "0.00";
            txtBasicProductQty.Text = "0.00";
            txtMaterialQty.Text = "0.00";

            cmbFinishPart.SelectedIndex = -1;
            cmbBasicPart.SelectedIndex = -1;
            cmbMaterialPart.SelectedIndex = -1;

            try
            {
                if (cmbProductCode.Items.Count>0 && cmbProductCode.SelectedItem != null)
                {
                    if (cmbProductType.SelectedIndex == 0)
                    {
                        objBasicProduct = objBasicProductDL.Get(cmbProductCode.SelectedValue.ToString());
                        txtCatergory.Text = objBasicProduct.BasicProductCategory.Category;
                        txtProductCode.Text = objBasicProduct.BasicProductCode;
                        txtProductName.Text = objBasicProduct.BasicProductDescription;
                        txtProductType.Text = objBasicProduct.BasicProductType;
                        txtProductUnit.Text = objBasicProduct.BasicProductUnit.UnitCode;
                        txtSubCatergory.Text = objBasicProduct.BasicProductSubCategory.Category;
                        objFormula = objBasicProduct.BasicProductFormula;
                        if (objBasicProduct.BasicProductFormula.FormulaID == 0)
                        {
                            objFormula.FormulaInstructedBy = CurrentUser.UserEmp;
                            objFormula.FormulaInstructedDate = DateTime.Now;
                            objFormula.FormulaQty = 1000;
                            objFormula.FormulaUnit = objBasicProduct.BasicProductUnit;
                            long formulaID = objFormulaDL.Add(objFormula);
                            if (formulaID > 0)
                            {
                                objFormula.FormulaID = formulaID;
                                objBasicProduct.BasicProductFormula = objFormula;
                                objBasicProductDL.Update(objBasicProduct, objBasicProduct.BasicProductCode);
                            }
                            else
                            {
                                MessageBox.Show(this,"There are was an error occured while initializing the Formula, Please Try again","Error",MessageBoxButtons.OK,MessageBoxIcon.Information);
                            }
                        }

                        bindItemList.DataSource = objFormulaDL.GetDataView_Items(objBasicProduct.BasicProductFormula.FormulaID);

                       
                    }
                    else if (cmbProductType.SelectedIndex == 1)
                    {
                        objBasicProduct = objBasicProductDL.Get(cmbProductCode.SelectedValue.ToString());
                        txtCatergory.Text = objBasicProduct.BasicProductCategory.Category;
                        txtProductCode.Text = objBasicProduct.BasicProductCode;
                        txtProductName.Text = objBasicProduct.BasicProductDescription;
                        txtProductType.Text = objBasicProduct.BasicProductType;
                        txtProductUnit.Text = objBasicProduct.BasicProductUnit.UnitCode;
                        txtSubCatergory.Text = objBasicProduct.BasicProductSubCategory.Category;
                        objFormula = objBasicProduct.BasicProductFormula;
                        if (objBasicProduct.BasicProductFormula.FormulaID == 0)
                        {
                            objFormula.FormulaInstructedBy = CurrentUser.UserEmp;
                            objFormula.FormulaInstructedDate = DateTime.Now;
                            objFormula.FormulaQty = 1000;
                            objFormula.FormulaUnit = objBasicProduct.BasicProductUnit;
                            long formulaID = objFormulaDL.Add(objFormula);
                            if (formulaID > 0)
                            {
                                objFormula.FormulaID = formulaID;
                                objBasicProduct.BasicProductFormula = objFormula;
                                objBasicProductDL.Update(objBasicProduct, objBasicProduct.BasicProductCode);
                            }
                            else
                            {
                                MessageBox.Show(this, "There are was an error occured while initializing the Formula, Please Try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        bindItemList.DataSource = objFormulaDL.GetDataView_Items(objBasicProduct.BasicProductFormula.FormulaID);
                    }
                    else if (cmbProductType.SelectedIndex == 2)
                    {
                        objFinishProduct = objFinishProductDL.Get(cmbProductCode.SelectedValue.ToString());
                        txtPackType.Visible = true;
                        lblPackType.Visible = true;
                        txtBasicProduct.Visible = true;
                        txtBasicQty.Visible = true;
                        lblBasic.Visible = true;
                        lblBasicQty.Visible = true;

                        txtCatergory.Text = objFinishProduct.BasicProduct.BasicProductCategory.Category;
                        txtPackType.Text = objFinishProduct.FinishProductPackingType.PackingTitle;
                        txtProductCode.Text = objFinishProduct.FinishProductCode;
                        txtProductName.Text = objFinishProduct.FinishProductDescription;
                        txtProductType.Text = "Finish";
                        txtProductUnit.Text = "N/A";
                        txtBasicProduct.Text = objFinishProduct.BasicProduct.Code;
                        txtBasicQty.Text = objFinishProduct.BasicProductQty.ToString();
                        txtSubCatergory.Text = objFinishProduct.BasicProduct.BasicProductSubCategory.Category;
                        objFormula = objFinishProduct.FinishProductFormula;
                        if (objFormula.FormulaID == 0)
                        {
                            objFormula.FormulaInstructedBy = CurrentUser.UserEmp;
                            objFormula.FormulaInstructedDate = DateTime.Now;
                            objFormula.FormulaQty = 1000;
                            long formulaID = objFormulaDL.Add_FG(objFormula);
                            if (formulaID > 0)
                            {
                                objFormula.FormulaID = formulaID;
                                objFinishProduct.FinishProductFormula = objFormula;
                                objFinishProductDL.Update(objFinishProduct, objFinishProduct.FinishProductCode);
                            }
                            else
                            {
                                MessageBox.Show(this, "There are was an error occured while initializing the Formula, Please Try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }

                        bindItemList.DataSource = objFormulaDL.GetDataView_Items(objFinishProduct.FinishProductFormula.FormulaID);

                    }

                    bindBasicProduct.DataSource = objFormulaBasicProductDL.GetDataView_FormulaID(objFormula.FormulaID);
                    bindFinishProduct.DataSource = objFormulaFinishProductDL.GetDataView_FormulaID(objFormula.FormulaID);
                    bindMaterialList.DataSource = objFormulaMaterialDL.GetDataView_FormulaID(objFormula.FormulaID);
                }
                else
                {
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


       
        }

        private void frmFormula_Load(object sender, EventArgs e)
        {
            try
            {

                cmbMaterials.DataSource = objMaterialDL.GetDataView();
                cmbMaterials.DisplayMember = "Material";
                cmbMaterials.ValueMember = "MaterialCode";


                cmbBasicProducts.DataSource = objBasicProductDL.GetDataView(true);
                cmbBasicProducts.DisplayMember = "BasicProduct";
                cmbBasicProducts.ValueMember = "BasicProductCode";

                cmbFinishProducts.DataSource = objFinishProductDL.GetDataView(1);
                cmbFinishProducts.DisplayMember = "FinishProduct";
                cmbFinishProducts.ValueMember = "FinishProductCode";
            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbProductType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cmbProductCode.DataSource = null;
                cmbProductCode.Text = "";
                if (cmbProductType.SelectedIndex == 0)
                {
                    cmbProductCode.DisplayMember = "BasicProduct";
                    cmbProductCode.ValueMember = "BasicProductCode";
                    cmbProductCode.DataSource = objBasicProductDL.GetDataView("Semi Processed Product", true);
                    gbFinish.Enabled = false;
                }
                else if (cmbProductType.SelectedIndex == 1)
                {
                    cmbProductCode.DisplayMember = "BasicProduct";
                    cmbProductCode.ValueMember = "BasicProductCode";
                    cmbProductCode.DataSource = objBasicProductDL.GetDataView("Product", true);
                    gbFinish.Enabled = false;

                }
                else if (cmbProductType.SelectedIndex == 2)
                {
                    cmbProductCode.DisplayMember = "FinishProduct";
                    cmbProductCode.ValueMember = "FinishProductCode";
                    cmbProductCode.DataSource = objFinishProductDL.GetDataView(true);
                    gbFinish.Enabled = true;


                }
                else
                {
                }
                

            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void cmbMaterials_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMaterialQty.Text = "0.00";
            SelectMaterial = false;
            lblMaterialUnit.Text = "";
            cmbMaterialPart.SelectedIndex = -1;
        }

        private void btnMaterialAdd_Click(object sender, EventArgs e)
        {
            FormulaMaterial objFormulaMat = new FormulaMaterial();
            try
            {
                if (cmbMaterials.Items.Count > 0)
                {
                    objFormulaMat.Material = objMaterialDL.Get(cmbMaterials.SelectedValue.ToString());
                    objFormulaMat.Formula = objFormula;
                    objFormulaMat.FormulaProductQty = Convert.ToDecimal(txtMaterialQty.Text);
                    objFormulaMat.FormulaPart = cmbMaterialPart.Text.ToString();

                    objFormulaMaterialDL.Add(objFormulaMat,CurrentUser.UserEmp);
                    bindMaterialList.DataSource = objFormulaMaterialDL.GetDataView_FormulaID(objFormula.FormulaID);
                    bindItemList.DataSource = objFormulaDL.GetDataView_Items(objFormula.FormulaID);


                }
            }
            catch (FormatException fex)
            {
                MessageBox.Show(this, "Quantity should be a Numaric value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                objFormulaMat = null;
            }
        }

        private void gvMaterials_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                cmbMaterials.SelectedValue = gvMaterials.CurrentRow.Cells["ItemCode"].Value.ToString();
                cmbMaterialPart.Text= gvMaterials.CurrentRow.Cells["Part"].Value.ToString();
                txtMaterialQty.Text = gvMaterials.CurrentRow.Cells["FormulaQty"].Value.ToString();

                SelectMaterial = true;

            }
            catch (Exception ex)
            {
                
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMaterialClear_Click(object sender, EventArgs e)
        {
            try
            {
                if (SelectMaterial)
                {
                    Material objMat = objMaterialDL.Get(cmbMaterials.SelectedValue.ToString());
                    
                    if (objFormula.FormulaID != 0)
                    {
                        DialogResult dr = MessageBox.Show(this,"Are you sure you want to remove selected formula item? Click yes to remove","Confirm Remove",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                        if (dr == DialogResult.Yes)
                        {
                            int x = objFormulaMaterialDL.Delete(objFormula.FormulaID, objMat.MaterialCode,cmbMaterialPart.Text);
                            if (x>0)
                            {
                                bindMaterialList.DataSource = objFormulaMaterialDL.GetDataView_FormulaID(objFormula.FormulaID);
                                bindItemList.DataSource = objFormulaDL.GetDataView_Items(objFormula.FormulaID);
                                txtMaterialQty.Text = "0.00";
                                cmbMaterialPart.SelectedIndex = -1;
                                cmbMaterials.SelectedIndex = -1;
                            }        
                        }
 
                    } 
                }
            }
            catch (Exception ex)
            {
                    
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbBasicProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBasicProductQty.Text = "0.00";
            lblBasicProductUnit.Text = "";
            cmbBasicPart.SelectedIndex = -1;
            SelectBasic = false;
        }

        private void btnBasicAdd_Click(object sender, EventArgs e)
        {
            FormulaBasicProduct objFormulaBasicProduct = new FormulaBasicProduct();
            try
            {
                if (cmbBasicProducts.Items.Count > 0)
                {
                    objFormulaBasicProduct.BasicProduct = objBasicProductDL.Get(cmbBasicProducts.SelectedValue.ToString());
                    objFormulaBasicProduct.Formula = objFormula;
                    objFormulaBasicProduct.FormulaPart = cmbBasicPart.SelectedItem.ToString();
                    objFormulaBasicProduct.FormulaProductQty = Convert.ToDecimal(txtBasicProductQty.Text);

                    objFormulaBasicProductDL.Add(objFormulaBasicProduct,CurrentUser.UserEmp);
                    bindBasicProduct.DataSource = objFormulaBasicProductDL.GetDataView_FormulaID(objFormula.FormulaID);
                    bindItemList.DataSource = objFormulaDL.GetDataView_Items(objFormula.FormulaID);



                }
            }
            catch (FormatException fex)
            {
                MessageBox.Show(this, "Quantity should be a Numaric value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                objFormulaBasicProduct = null;
            }
        }

        private void gvBasicProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataRowView dr = (DataRowView)gvBasicProducts.Rows[e.RowIndex].DataBoundItem;

                cmbBasicProducts.SelectedValue = dr["FormulaBasicProductCode"].ToString();
                
                cmbBasicPart.SelectedItem= dr["FormulaPart"].ToString().Trim();
            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBasicDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (SelectBasic)
                {
                    BasicProduct objBasic = objBasicProductDL.Get(cmbBasicProducts.SelectedValue.ToString());

                    if (objFormula.FormulaID != 0)
                    {
                        DialogResult dr = MessageBox.Show(this, "Are you sure you want to remove selected formula item? Click yes to remove", "Confirm Remove", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dr == DialogResult.Yes)
                        {
                            int x = objFormulaBasicProductDL.Delete(objFormula.FormulaID, objBasic.BasicProductCode,cmbBasicPart.SelectedItem.ToString());
                            if (x > 0)
                            {
                                bindBasicProduct.DataSource = objFormulaBasicProductDL.GetDataView_FormulaID(objFormula.FormulaID);
                                bindItemList.DataSource = objFormulaDL.GetDataView_Items(objFormula.FormulaID);


                                txtBasicProductQty.Text = "0.00";
                                cmbBasicPart.SelectedIndex = -1;
                                cmbBasicProducts.SelectedIndex = -1;
                            }
                        }

                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbFinishProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFinishProductQty.Text = "0.00";
            cmbFinishPart.SelectedIndex = -1;
            lblFinishUnit.Text = "";
            SelectFinish = false;
        }

        private void btnFinishAdd_Click(object sender, EventArgs e)
        {
            FormulaFinishProduct objFormulaFinishProduct = new FormulaFinishProduct();
            try
            {
                if (cmbBasicProducts.Items.Count > 0)
                {
                    objFormulaFinishProduct.FinishProduct = objFinishProductDL.Get(cmbFinishProducts.SelectedValue.ToString());
                    objFormulaFinishProduct.Formula = objFormula;
                    objFormulaFinishProduct.FormulaPart = cmbFinishPart.SelectedItem.ToString();
                    objFormulaFinishProduct.FormulaProductQty = Convert.ToDecimal(txtFinishProductQty.Text);

                    objFormulaFinishProductDL.Add(objFormulaFinishProduct,CurrentUser.UserEmp);
                    bindFinishProduct.DataSource = objFormulaFinishProductDL.GetDataView_FormulaID(objFormula.FormulaID);
                    bindItemList.DataSource = objFormulaDL.GetDataView_Items(objFormula.FormulaID);


                }
            }
            catch (FormatException fex)
            {
                MessageBox.Show(this, "Quantity should be a Numaric value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
     
            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                objFormulaFinishProduct = null;
            }
        }

        private void btnFinishDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (SelectFinish)
                {
                    

                    if (objFormula.FormulaID != 0)
                    {
                        DialogResult dr = MessageBox.Show(this, "Are you sure you want to remove selected formula item? Click yes to remove", "Confirm Remove", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dr == DialogResult.Yes)
                        {
                            int x = objFormulaBasicProductDL.Delete(objFormula.FormulaID, cmbFinishProducts.SelectedValue.ToString(), cmbFinishPart.SelectedItem.ToString());
                            if (x > 0)
                            {
                                bindFinishProduct.DataSource = objFormulaFinishProductDL.GetDataView_FormulaID(objFormula.FormulaID);
                                bindItemList.DataSource = objFormulaDL.GetDataView_Items(objFormula.FormulaID);

                               cmbFinishProducts.SelectedIndex = -1;
                            
                            }
                        }

                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gvFinishProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataRowView dr = (DataRowView)gvFinishProducts.Rows[e.RowIndex].DataBoundItem;

                cmbFinishProducts.SelectedValue = dr["FormulaFinishProductCode"].ToString();
                cmbMaterialPart.SelectedItem = dr["FormulaPart"].ToString().Trim();
            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtBasicProductQty_Validated(object sender, EventArgs e)
        {
            try
            {
                Convert.ToDecimal(txtBasicProductQty.Text);
                errorProvider1.SetError(txtBasicProductQty, "");
            }
            catch (Exception)
            {

                errorProvider1.SetError(txtBasicProductQty, "Quantity should be a Numaric value");
            }
        }

        private void txtMaterialQty_Validated(object sender, EventArgs e)
        {
            try
            {
                Convert.ToDecimal(txtMaterialQty.Text);
                errorProvider1.SetError(txtMaterialQty, "");
            }
            catch (Exception)
            {

                errorProvider1.SetError(txtMaterialQty, "Quantity should be a Numaric value");
            }
        }

        private void txtFinishProductQty_Validated(object sender, EventArgs e)
        {
            try
            {
                Convert.ToDecimal(txtFinishProductQty.Text);
                errorProvider1.SetError(txtFinishProductQty, "");
            }
            catch (Exception)
            {

                errorProvider1.SetError(txtFinishProductQty, "Quantity should be a Numaric value");
            }
        }

        private void txtMaterialQty_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtMaterialQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar) || (e.KeyChar == (char)46)))
            {
                e.Handled = true;
            }
        }

        private void txtBasicProductQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar) || (e.KeyChar == (char)46)))
            {
                e.Handled = true;
            }
        }

        private void txtFinishProductQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar) || (e.KeyChar == (char)46)))
            {
                e.Handled = true;
            }
        }

        private void btnViewReport_Click(object sender, EventArgs e)
        {
            //if (cmbProductCode.Items.Count > 0 && cmbProductCode.SelectedItem != null)
            //{
            //    if (cmbProductType.SelectedIndex == 2)
            //    {
            //        ReportForm.frmRptFormula objFrm = new MRP_GUI.ReportForm.frmRptFormula(objFormula.FormulaID,"Finish");
            //        objFrm.MdiParent = this.MdiParent;
            //        objFrm.Show();
            //    }
            //    else
            //    {
            //        ReportForm.frmRptFormula objFrm = new MRP_GUI.ReportForm.frmRptFormula(objFormula.FormulaID, "Basic");
            //        objFrm.MdiParent = this.MdiParent;
            //        objFrm.Show();
            //    }                    

            //}


        }

        private void cmbMaterialPart_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormulaMaterial objFormulaMat = new FormulaMaterial();
            try
            {
                if (cmbMaterialPart.SelectedIndex != -1)
                {
                    txtMaterialQty.Text = "0.00";
                    SelectMaterial = false;
                    lblMaterialUnit.Text = "";
                    if (cmbMaterials.Items.Count > 0 && cmbMaterials.SelectedItem != null)
                    {
                        Material objMat = objMaterialDL.Get(cmbMaterials.SelectedValue.ToString());
                        lblMaterialUnit.Text = objMat.MatUnit.UnitCode;
                        if (objFormula.FormulaID != 0)
                        {
                            objFormulaMat = objFormulaMaterialDL.Get(objFormula.FormulaID, objMat.MaterialCode, cmbMaterialPart.SelectedItem.ToString());
                            if (objFormulaMat.Formula != null)
                            {
                                txtMaterialQty.Text = objFormulaMat.FormulaProductQty.ToString();

                                //cmbMaterialPart.SelectedItem = objFormulaMat.FormulaPart.Trim();
                                SelectMaterial = true;
                            }
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
                objFormulaMat = null;
            }


        }

        private void cmbBasicPart_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormulaBasicProduct objFormulaBasicProduct = new FormulaBasicProduct();
            try
            {
                if (cmbBasicPart.SelectedIndex != -1)
                {
                    txtBasicProductQty.Text = "0.00";
                    lblBasicProductUnit.Text = "";
                    SelectBasic = false;
                    if (cmbBasicProducts.Items.Count > 0 && cmbBasicProducts.SelectedItem != null)
                    {
                        BasicProduct objBasic = objBasicProductDL.Get(cmbBasicProducts.SelectedValue.ToString());
                        lblBasicProductUnit.Text = objBasic.BasicProductUnit.UnitCode;
                        if (objFormula.FormulaID != 0)
                        {
                            objFormulaBasicProduct = objFormulaBasicProductDL.Get(objFormula.FormulaID, objBasic.BasicProductCode, cmbBasicPart.SelectedItem.ToString());
                            if (objFormulaBasicProduct.Formula != null)
                            {
                                txtBasicProductQty.Text = objFormulaBasicProduct.FormulaProductQty.ToString();
                                //cmbBasicPart.SelectedItem = objFormulaBasicProduct.FormulaPart.Trim();
                                SelectBasic = true;
                            }
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
                objFormulaBasicProduct = null;
            }
        }

        private void cmbFinishPart_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormulaFinishProduct objFormulaFinishProduct = new FormulaFinishProduct();
            try
            {
                if (cmbFinishPart.SelectedIndex != -1)
                {
                    txtFinishProductQty.Text = "0.00";

                    lblFinishUnit.Text = "";
                    SelectFinish = false;
                    if (cmbFinishProducts.Items.Count > 0 && cmbFinishProducts.SelectedItem != null)
                    {
                        FinishProduct objFinishProduct = objFinishProductDL.Get(cmbFinishProducts.SelectedValue.ToString());
                        lblFinishUnit.Text = objFinishProduct.FinishProductPackingType.PackingTitle;
                        if (objFormula.FormulaID != 0)
                        {
                            objFormulaFinishProduct = objFormulaFinishProductDL.Get(objFormula.FormulaID, objFinishProduct.FinishProductCode, cmbFinishPart.SelectedItem.ToString());
                            if (objFormulaFinishProduct.Formula != null)
                            {
                                txtFinishProductQty.Text = objFormulaFinishProduct.FormulaProductQty.ToString();
                                //cmbFinishPart.SelectedItem = objFormulaFinishProduct.FormulaPart.Trim();
                                SelectFinish = true;
                            }
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
                objFormulaFinishProduct = null;
            }
        }
    }
}