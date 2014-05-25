using DL;
using MRP_GUI.Sales;
using SESD.MRP.REF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MRP_GUI
{
    public partial class frmGRN_Edit : System.Windows.Forms.Form
    {
        private GRN_DL objGRNDL = new GRN_DL(ConnectionStringClass.GetConnection());
        private BasicProduct_DL objBasicProduct_DL = new BasicProduct_DL(ConnectionStringClass.GetConnection());
        private Material_DL objMaterial_DL = new Material_DL(ConnectionStringClass.GetConnection());
        private FinishProduct_DL objFinishProduct_DL = new FinishProduct_DL(ConnectionStringClass.GetConnection());
        private GRNBasicProducts_DL objGRNBasicProducts_DL = new GRNBasicProducts_DL(ConnectionStringClass.GetConnection());
        private GRNFinishProducts_DL objGRNFinishProducts_DL = new GRNFinishProducts_DL(ConnectionStringClass.GetConnection());
        private GRNMaterials_DL objGRNMaterials_DL = new GRNMaterials_DL(ConnectionStringClass.GetConnection());
        
        private GRN objGRN = new GRN();
        private BasicProduct objBasicProduct = new BasicProduct();    
        private FinishProduct objFinishProduct = new FinishProduct();
        private GRNFinishProducts objGRNFinishProducts = new GRNFinishProducts();     
        private GRNBasicProducts objGRNBasicProducts = new GRNBasicProducts();
        private GRNMaterials objGRNMaterials = new GRNMaterials();
        private Material objMaterial = new Material();
        
        public frmGRN_Edit()
        {
            InitializeComponent();
        }

        private void LoadGRN(int GRNType) 
        {
            dgvGRN.AutoGenerateColumns = false;
            bsGRN.DataSource = objGRNDL.GetDataView(GRNType, GRN.Status.Initial);
            dgvGRN.DataSource = bsGRN;
            bsGRN.ResetBindings(true);
        }

        private void LoadMaterial() 
        {
            if (cmbGRNType.SelectedIndex + 1 == Convert.ToInt32(GRN.Type.Material))
            {
                cmbMaterial.DataSource = null;
                cmbMaterial.Items.Clear();
                bsMaterialList.DataSource = objMaterial_DL.GetDataView();
                cmbMaterial.DataSource = bsMaterialList;
                cmbMaterial.BindingContext = this.BindingContext;
                cmbMaterial.DisplayMember = "Material";
                cmbMaterial.ValueMember = "MaterialCode";
                
            }
            else if (cmbGRNType.SelectedIndex + 1 == Convert.ToInt32(GRN.Type.BasicProduct))
            {
                cmbMaterial.DataSource = null;
                cmbMaterial.Items.Clear();
                bsMaterialList.DataSource = objBasicProduct_DL.GetDataView();
                cmbMaterial.DataSource = bsMaterialList;
                cmbMaterial.BindingContext = this.BindingContext;
                cmbMaterial.DisplayMember = "BasicProduct";
                cmbMaterial.ValueMember = "BasicProductCode";

            }
            else if (cmbGRNType.SelectedIndex + 1 == Convert.ToInt32(GRN.Type.FinishProduct))
            {
                cmbMaterial.DataSource = null;
                cmbMaterial.Items.Clear();
                bsMaterialList.DataSource = objFinishProduct_DL.GetDataView(1);
                cmbMaterial.DataSource = bsMaterialList;
                cmbMaterial.BindingContext = this.BindingContext;
                cmbMaterial.DisplayMember = "FinishProduct";
                cmbMaterial.ValueMember = "FinishProductCode";
            }
        }

        private void cmbGRNType_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvGRNMaterial.DataSource = null;
            LoadGRN(cmbGRNType.SelectedIndex + 1);
            LoadMaterial();   
        }

        private void frmGRN_Edit_Load(object sender, EventArgs e)
        {
            cmbGRNType.SelectedIndex = 0;
        }

        private void LoadGRNMaterialTable()
        {
            try
            {
                    dgvGRNMaterial.AutoGenerateColumns = false;
                    bsGRNMaterial.DataSource = objGRNDL.GetDataView_Items_Print(objGRN.GRNNo);
                    dgvGRNMaterial.DataSource = bsGRNMaterial;
                    bsGRNMaterial.ResetBindings(true);
                    cmbMaterial.Enabled = true;
            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void dgvGRN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvGRN.SelectedRows.Count > 0)
                {
                    objGRN.GRNNo = Convert.ToInt32(dgvGRN.Rows[e.RowIndex].Cells["GRNNO"].Value);
                    objGRNBasicProducts.GRN = objGRN;
                    objGRNMaterials.GRN = objGRN;
                    objGRNFinishProducts.GRN = objGRN;
                    LoadGRNMaterialTable();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void dgvGRNMaterial_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUnitPrice.Text = dgvGRNMaterial.Rows[e.RowIndex].Cells["UnitPricem"].Value.ToString();
            txtQty.Text = dgvGRNMaterial.Rows[e.RowIndex].Cells["RacevQtym"].Value.ToString();
            objGRNBasicProducts.Remarks = dgvGRNMaterial.Rows[e.RowIndex].Cells["Remarksm"].Value.ToString();
            objGRNFinishProducts.Remarks = dgvGRNMaterial.Rows[e.RowIndex].Cells["Remarksm"].Value.ToString();
            objBasicProduct.BasicProductCode = dgvGRNMaterial.Rows[e.RowIndex].Cells["ItemCodem"].Value.ToString();
            objFinishProduct.FinishProductCode = dgvGRNMaterial.Rows[e.RowIndex].Cells["ItemCodem"].Value.ToString();
            objMaterial.MaterialCode = dgvGRNMaterial.Rows[e.RowIndex].Cells["ItemCodem"].Value.ToString();
            objGRNBasicProducts.GRN = objGRN;
            objGRNBasicProducts.BasicProduct = objBasicProduct;
            objGRNFinishProducts.FinishProducts = objFinishProduct;
            objGRNMaterials.Material = objMaterial;
            cmbMaterial.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (dgvGRN.SelectedRows.Count > 0)
            {
                String temptxtProduct = cmbMaterial.SelectedValue.ToString();
                if (DataValidation.Is3DecimalPointNumber(txtQty.Text) && DataValidation.Is2DecimalPointNumber(txtUnitPrice.Text))
                {
                    bool availability = false;
                    foreach (DataGridViewRow row2 in dgvGRNMaterial.Rows)
                    {
                        String tempcheckproduct = row2.Cells[0].Value.ToString();
                        if (tempcheckproduct == temptxtProduct)
                        {
                            availability = true;
                            //break;
                        }
                    }
                    if (dgvGRN.Rows.Count == 0 || !availability)
                    {
                        AddProductFunction();
                    }
                    else
                    {
                        MessageBox.Show(this, "Product is already added", "MRP System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show(this, "please Insert Valid Quantity and Unit Price", "MRP System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show(this, "please select GRN", "MRP System", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void AddProductFunction() 
        {
            if (cmbGRNType.SelectedIndex + 1 == Convert.ToInt32(GRN.Type.Material))
            {
                objMaterial.MaterialCode = cmbMaterial.SelectedValue.ToString();
                objGRNMaterials.GrossQty = Convert.ToDecimal(txtQty.Text);
                objGRNMaterials.NetQty = Convert.ToDecimal(txtQty.Text);
                objGRNMaterials.UnitPrice = Convert.ToDecimal(txtUnitPrice.Text);
                objGRNMaterials.Remarks = "No";
                objGRNMaterials.Material = objMaterial;
                objGRNMaterials_DL.Add(objGRNMaterials);
            }
            else if (cmbGRNType.SelectedIndex + 1 == Convert.ToInt32(GRN.Type.BasicProduct))
            {
                objBasicProduct.BasicProductCode = cmbMaterial.SelectedValue.ToString();
                objGRNBasicProducts.GrossQty = Convert.ToDecimal(txtQty.Text);
                objGRNBasicProducts.NetQty = Convert.ToDecimal(txtQty.Text);
                objGRNBasicProducts.UnitPrice = Convert.ToDecimal(txtUnitPrice.Text);
                objGRNBasicProducts.Remarks = "No";
                objGRNBasicProducts.BasicProduct = objBasicProduct;
                objGRNBasicProducts_DL.Add(objGRNBasicProducts);
            }
            else if (cmbGRNType.SelectedIndex + 1 == Convert.ToInt32(GRN.Type.FinishProduct))
            {
                objFinishProduct.FinishProductCode = cmbMaterial.SelectedValue.ToString();
                objGRNFinishProducts.NetQty = Convert.ToDecimal(txtQty.Text);
                objGRNFinishProducts.GrossQty = Convert.ToDecimal(txtQty.Text);
                objGRNFinishProducts.UnitPrice = Convert.ToDecimal(txtUnitPrice.Text);
                objGRNFinishProducts.Remarks = "No";
                objGRNFinishProducts.FinishProducts = objFinishProduct;
                objGRNFinishProducts_DL.Add(objGRNFinishProducts);
            }
            clear();
            LoadGRNMaterialTable();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvGRNMaterial.SelectedRows.Count > 0)
            {
                    DialogResult dr = MessageBox.Show(this, "Are you sure, You want to Delete selected Record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        if (cmbGRNType.SelectedIndex + 1 == Convert.ToInt32(GRN.Type.Material))
                        {
                            objGRNMaterials_DL.Delete(objGRNBasicProducts.GRN.GRNNo, objMaterial.MaterialCode);
                        }
                        else if (cmbGRNType.SelectedIndex + 1 == Convert.ToInt32(GRN.Type.BasicProduct))
                        {
                            objGRNBasicProducts_DL.Delete(objGRNBasicProducts.GRN.GRNNo, objBasicProduct.BasicProductCode);
                        }
                        else if (cmbGRNType.SelectedIndex + 1 == Convert.ToInt32(GRN.Type.FinishProduct))
                        {
                            objGRNFinishProducts_DL.Delete(objGRNBasicProducts.GRN.GRNNo,objFinishProduct.FinishProductCode);
                        }
                        clear();
                        LoadGRNMaterialTable();
                    }
            }
            else
            {
                MessageBox.Show(this, "please select a record to delete", "MRP System", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvGRNMaterial.SelectedRows.Count > 0)
            {
                if (DataValidation.Is3DecimalPointNumber(txtQty.Text) && DataValidation.Is2DecimalPointNumber(txtUnitPrice.Text))
                {
                    DialogResult dr = MessageBox.Show(this, "Are you sure, You want to Delete selected Record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        if (cmbGRNType.SelectedIndex + 1 == Convert.ToInt32(GRN.Type.Material))
                        {
                            objGRNMaterials.GrossQty = Convert.ToDecimal(txtQty.Text);
                            objGRNMaterials.NetQty = Convert.ToDecimal(txtQty.Text);
                            objGRNMaterials.UnitPrice = Convert.ToDecimal(txtUnitPrice.Text);
                            objGRNMaterials_DL.Update(objGRNMaterials, objGRN.GRNNo, objMaterial.MaterialCode);       
                        }
                        else if (cmbGRNType.SelectedIndex + 1 == Convert.ToInt32(GRN.Type.BasicProduct))
                        {                           
                            objGRNBasicProducts.GrossQty = Convert.ToDecimal(txtQty.Text);
                            objGRNBasicProducts.NetQty = Convert.ToDecimal(txtQty.Text);
                            objGRNBasicProducts.UnitPrice = Convert.ToDecimal(txtUnitPrice.Text);
                            objGRNBasicProducts_DL.Update(objGRNBasicProducts, objGRN.GRNNo, objBasicProduct.BasicProductCode);
                        }
                        else if (cmbGRNType.SelectedIndex + 1 == Convert.ToInt32(GRN.Type.FinishProduct))
                        {
                            objGRNFinishProducts.NetQty=Convert.ToDecimal(txtQty.Text);
                            objGRNFinishProducts.GrossQty=Convert.ToDecimal(txtQty.Text);
                            objGRNFinishProducts.UnitPrice=Convert.ToDecimal(txtUnitPrice.Text);
                            objGRNFinishProducts_DL.Update(objGRNFinishProducts, objGRN.GRNNo, objFinishProduct.FinishProductCode);
                        }
                        clear();
                        LoadGRNMaterialTable();
                    }
                }
                else
                {
                    MessageBox.Show(this, "please Insert Valid Quantity and Unit Price", "MRP System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                    MessageBox.Show(this, "please select a record to delete", "MRP System", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void clear() 
        {
            txtUnitPrice.Text = "";
            txtQty.Text = "";
            cmbMaterial.Enabled = true;
        }
    }
}
