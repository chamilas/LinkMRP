using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DL;
using System.Data.SqlClient;
using SESD.MRP.REF;

namespace MRP_GUI
{
    public partial class frmMaterialRegistration : System.Windows.Forms.Form
    {
        public frmMaterialRegistration()
        {
            InitializeComponent();
        }

        //------------------ Form Variables --------------------
        private Unit_DL objUnitDL = new Unit_DL(ConnectionStringClass.GetConnection());

        private MaterialType_DL objMaterialTypeDL = new MaterialType_DL(ConnectionStringClass.GetConnection());
        private Form_DL objFormDL = new Form_DL(ConnectionStringClass.GetConnection());
        private Material_DL objMaterialDL = new Material_DL(ConnectionStringClass.GetConnection());
        private MaterialCategory_DL objMatCatDL = new MaterialCategory_DL(ConnectionStringClass.GetConnection());



        private Material objMaterial = new Material();

        private bool MaterialSelect = false;
        private Material objSelectedMaterial = new Material();
        private bool IntermediateMaterialSelect = false;

        private String Category = "";
        private String MainType = "Basic";

        DataTable dtMaterials = new DataTable();


        //------------------ Form Methods ----------------------
        private void LoadMaterials(string Type)
        {
            try
            {
                dtMaterials = objMaterialDL.GetDataView(Type);


                gvMaterialList.AutoGenerateColumns = false;
                bindMaterials.DataSource = dtMaterials;
                gvMaterialList.DataSource = bindMaterials;
                bindMaterials.ResetBindings(true);

            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void Load_BasicDetails()
        {
            try
            {
                cmbMaterialUnit.DataSource = objUnitDL.GetDataView();
                cmbMaterialType.DataSource = objMaterialTypeDL.GetDataView();
                cmbMaterialForm.DataSource = objFormDL.GetDataView();


                cmbFromMonth.SelectedIndex = 0;
                cmbToMonth.SelectedIndex = 0;

                cmbMainType.SelectedIndex = 0;


            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void MaterialClear()
        {
            txtAcgUnitCost.Text = "0.00";
            txtMaterialBasicPartialSize.Text = "0.00";
            txtMaterialCode.Text = "";
            txtmaterialName.Text = "";
            txtMaterialQtyPerUnit.Text = "0.00";



            cmbFromMonth.SelectedIndex = 0;
            if (cmbMaterialBasicMaterial.Items.Count > 0)
            {
                cmbMaterialBasicMaterial.SelectedIndex = 0;
            }

            cmbMaterialForm.SelectedIndex = 0;
            cmbMaterialType.SelectedIndex = 0;
            cmbMaterialUnit.SelectedIndex = 0;
            cmbToMonth.SelectedIndex = 0;


            cbMaterialImport.Checked = false;
            cbMaterialLocal.Checked = false;
            cbMaterialSeasonal.Checked = false;

            this.MaterialSelect = false;
        }

        //-------------- Events ----------------------------------------



        private void frmMaterialRegistration_Load(object sender, EventArgs e)
        {
            try
            {
                Load_BasicDetails();
                rdbRaw.Checked = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }



        private void btnMaterialSave_Click(object sender, EventArgs e)
        {
            if (this.IntermediateMaterialSelect)
            {
                if (txtAcgUnitCost.Text.Equals("") || txtMaterialBasicPartialSize.Text.Equals("") ||
                    txtMaterialCode.Text.Equals("") || txtMaterialQtyPerUnit.Text.Equals("") || txtmaterialName.Text.Equals("")
                   )
                {
                    MessageBox.Show(this, "Please Fill all Fields", "Blank Fields", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    try
                    {

                        objMaterial.MatBasicMaterial = cmbMaterialBasicMaterial.SelectedValue.ToString();
                        objMaterial.MatBasicQty = Convert.ToDecimal(txtMaterialQtyPerUnit.Text);
                        objMaterial.MatCost = Convert.ToDecimal(txtAcgUnitCost.Text);
                        objMaterial.MateialType = objMaterialTypeDL.Get(cmbMaterialType.SelectedValue.ToString());

                        objMaterial.MaterialMainType = MainType;
                        objMaterial.MaterialCode = txtMaterialCode.Text.Replace(" ", "");
                        objMaterial.MaterialDescription = txtmaterialName.Text;
                        objMaterial.MaterialStatus = Convert.ToInt32(Material.Status.Enable);

                        objMaterial.MatForm = objFormDL.Get(Convert.ToInt64(cmbMaterialForm.SelectedValue));
                        objMaterial.MatParticleSize = (txtMaterialBasicPartialSize.Text);
                        objMaterial.MatUnit = objUnitDL.Get(Convert.ToInt64(cmbMaterialUnit.SelectedValue));
                        objMaterial.MatSeasonFrom = "N/A";
                        objMaterial.MatSeasonTo = "N/A";

                        if(rdbDry.Checked==true)
                        {
                            objMaterial.MaterialType = "Dry";
                        }
                            else if (rdbGreen.Checked==true)
                            {
                                objMaterial.MaterialType = "Green";
                            }
                            else
                            {
                                objMaterial.MaterialType = "Normal";
                            }

                        if (rdbRaw.Checked == true)
                        {
                            objMaterial.MaterialCategory = "Raw";
                        }
                        else if (rdbPacking.Checked == true)
                        {
                            objMaterial.MaterialCategory = "Packing";
                        }
                        else
                        {
                            objMaterial.MaterialCategory = "Lab";
                        }

                        int x = 0;
                            x = objMaterialDL.Add(objMaterial);
                            MaterialClear();


                            if (x > 0)
                            {
                                MessageBox.Show(this, "Succesfully Updated the Database", "Succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                Load_Materials();
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
                }
            }
            else
            {
                if (txtAcgUnitCost.Text.Equals("") || txtmaterialName.Text.Equals("") ||
                        txtMaterialCode.Text.Equals(""))
                {
                    MessageBox.Show(this, "Please fill All Fields", "Blank Fields", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    try
                    {
                        objMaterial.MaterialCode = txtMaterialCode.Text;
                        objMaterial.IsExport = cbMaterialImport.Checked;
                        objMaterial.IsLocal = cbMaterialLocal.Checked;
                        objMaterial.IsSeasanal = cbMaterialSeasonal.Checked;
                        objMaterial.MatBasicMaterial = objMaterial.MaterialCode;
                        objMaterial.MatBasicQty = 0;
                        objMaterial.MatCost = Convert.ToDecimal(txtAcgUnitCost.Text);
                        objMaterial.MateialType = objMaterialTypeDL.Get(cmbMaterialType.SelectedValue.ToString());
                        objMaterial.MaterialCategory = Category;
                        objMaterial.MaterialMainType = MainType;
                        objMaterial.MaterialCode = txtMaterialCode.Text;
                        objMaterial.MaterialDescription = txtmaterialName.Text;
                        objMaterial.MaterialStatus = Convert.ToInt32(Material.Status.Enable);
                        objMaterial.MatForm = objFormDL.Get(Convert.ToInt64(cmbMaterialForm.SelectedValue));
                        objMaterial.MatParticleSize = "N/A";

                        if (rdbDry.Checked == true)
                        {
                            objMaterial.MaterialType = "Dry";
                        }
                        else if (rdbGreen.Checked == true)
                        {
                            objMaterial.MaterialType = "Green";
                        }
                        else
                        {
                            objMaterial.MaterialType = "Normal";
                        }

                        if (cbMaterialSeasonal.Checked)
                        {
                            objMaterial.MatSeasonFrom = cmbFromMonth.SelectedItem.ToString();
                            objMaterial.MatSeasonTo = cmbToMonth.SelectedItem.ToString();
                        }
                        else
                        {
                            objMaterial.MatSeasonFrom = "N/A";
                            objMaterial.MatSeasonTo = "N/A";
                        }


                        if (rdbRaw.Checked == true)
                        {
                            objMaterial.MaterialCategory = "Raw";
                        }
                        else if (rdbPacking.Checked == true)
                        {
                            objMaterial.MaterialCategory = "Packing";
                        }
                        else
                        {
                            objMaterial.MaterialCategory = "Lab";
                        }

                        objMaterial.MatUnit = objUnitDL.Get(Convert.ToInt64(cmbMaterialUnit.SelectedValue));
                        int x = 0;

                            x = objMaterialDL.Add(objMaterial);
                            MaterialClear();
                            if (x > 0)
                            {
                                MessageBox.Show(this, "Succesfully Updated the Database", "Succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                }
            }
        }

        private void btnMaterialClear_Click(object sender, EventArgs e)
        {
            if (this.MaterialSelect)
            {
                pnlInter.Visible = false;
                pblBasic2.Visible = true;
               // pnlMaterial.Location = new Point(3, 88);
                //txtMaterialCode.Mask = ">AA/AAA/AA>";
                IntermediateMaterialSelect = false;
                if (cmbMaterialBasicMaterial.Items.Count > 0)
                {
                    cmbMaterialBasicMaterial.SelectedIndex = 0;

                }

            }
            MaterialClear();
        }

        private void btnMaterialDelete_Click(object sender, EventArgs e)
        {
            if (this.MaterialSelect)
            {
                DialogResult dr = MessageBox.Show(this, "Are you sure, You want to Delete selected Record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {

                    Material_DL objMaterialDL = new Material_DL(ConnectionStringClass.GetConnection());
                    try
                    {
                        int x = objMaterialDL.Delete(objSelectedMaterial.MaterialCode);
                        MaterialClear();
                        if (x > 0)
                        {
                            MessageBox.Show(this, "Succesfully Deleted From Database", "Succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Load_Materials();
                        }
                    }
                    catch (SqlException sqlex)
                    {
                        if (sqlex.Number == 547)
                        {
                            MessageBox.Show(this, "Selected Material has references to another record or more. System will not allow to delete the record\nPlease contact your System Administrator for further information", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show(this, "Error occured while deleteing", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(this, "Error occured while deleteing", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show(this, "Select a Record from the List", "Select a Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void gvMaterialList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    cmbFromMonth.SelectedIndex = 0;
                    cmbToMonth.SelectedIndex = 0;

                    String Code = gvMaterialList.Rows[e.RowIndex].Cells["ColMaterialCode"].Value.ToString();

                    objSelectedMaterial = objMaterialDL.Get(Code);
                    cmbMaterialType.SelectedValue = objSelectedMaterial.MateialType.MatType.ToString();

                    cmbMainType.SelectedItem = objSelectedMaterial.MaterialMainType;


                    if (objSelectedMaterial.MaterialMainType.Equals("Intermediate"))
                    {
                        //rbIntermediate.Checked = true;
                        //IntermediateMaterialSelect = true;
                        txtMaterialCode.Text = objSelectedMaterial.MaterialCode;
                        txtmaterialName.Text = objSelectedMaterial.MaterialDescription;
                        txtAcgUnitCost.Text = objSelectedMaterial.MatCost.ToString();
                        txtMaterialQtyPerUnit.Text = objSelectedMaterial.MatBasicQty.ToString();
                        txtMaterialBasicPartialSize.Text = objSelectedMaterial.MatParticleSize.ToString();
                        cmbMaterialBasicMaterial.SelectedValue = objSelectedMaterial.MatBasicMaterial;


                    }
                    else
                    {
                        //rbBasic.Checked = true;
                        //IntermediateMaterialSelect = false;
                        txtMaterialCode.Text = objSelectedMaterial.MaterialCode;
                        txtmaterialName.Text = objSelectedMaterial.MaterialDescription;
                        txtAcgUnitCost.Text = objSelectedMaterial.MatCost.ToString();

                        cbMaterialImport.Checked = objSelectedMaterial.IsExport;
                        cbMaterialLocal.Checked = objSelectedMaterial.IsLocal;
                        cbMaterialSeasonal.Checked = objSelectedMaterial.IsSeasanal;

                        cmbFromMonth.SelectedItem = objSelectedMaterial.MatSeasonFrom;
                        cmbToMonth.SelectedItem = objSelectedMaterial.MatSeasonTo;
                        cmbMainType.SelectedItem = objSelectedMaterial.MaterialMainType;

                        if (objSelectedMaterial.MaterialType == "Dry")
                        {
                            rdbDry.Checked = true;
                        }
                        if (objSelectedMaterial.MaterialType == "Green")
                        {
                            rdbGreen.Checked = true;
                        }

                    }

                    cmbMaterialUnit.SelectedValue = objSelectedMaterial.MatUnit.UnitID.ToString();
                    cmbMaterialForm.SelectedValue = objSelectedMaterial.MatForm.FormID.ToString();

                    this.MaterialSelect = true;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtAcgUnitCost_Validated(object sender, EventArgs e)
        {
            try
            {
                Convert.ToDecimal(txtAcgUnitCost.Text);
                errorProvider1.SetError(txtAcgUnitCost, "");
            }
            catch (Exception)
            {

                errorProvider1.SetError(txtAcgUnitCost, "Average Cost should be a Numaric value");
            }
        }

        private void txtMaterialQtyPerUnit_Validated(object sender, EventArgs e)
        {
            try
            {
                Convert.ToDecimal(txtMaterialQtyPerUnit.Text);
                errorProvider1.SetError(txtMaterialQtyPerUnit, "");
            }
            catch (Exception)
            {

                errorProvider1.SetError(txtMaterialQtyPerUnit, "Quantity should be a Numaric value");
            }
        }

        private void txtMaterialBasicPartialSize_Validated(object sender, EventArgs e)
        {
            try
            {
                Convert.ToDecimal(txtMaterialBasicPartialSize.Text);
                errorProvider1.SetError(txtMaterialBasicPartialSize, "");
            }
            catch (Exception)
            {

                errorProvider1.SetError(txtMaterialBasicPartialSize, "Quantity should be a Numaric value");
            }
        }

        private void cbMaterialSeasonal_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMaterialSeasonal.Checked)
            {
                cmbToMonth.Enabled = true;
                cmbFromMonth.Enabled = true;
            }
            else
            {
                cmbToMonth.Enabled = false;
                cmbFromMonth.Enabled = false;
            }
        }

        private void cmbMaterialBasicMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            Material obj = new Material();

            try
            {
                if (cmbMaterialBasicMaterial.Items.Count > 0 && cmbMaterialBasicMaterial.SelectedValue != null)
                {
                    obj = objMaterialDL.Get(cmbMaterialBasicMaterial.SelectedValue.ToString());
                    lblMaterialBasicMaterialUnit.Text = obj.MatUnit.UnitCode;
                    //txtMaterialCode.Text = obj.MaterialCode.ToString();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtAcgUnitCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar) || (e.KeyChar == (char)46)))
            {
                e.Handled = true;
            }
        }

        private void Load_Materials()
        {
            try
            {
                objsourceMaterialBasic.DataSource= objMaterialDL.GetDataView("Raw");
                cmbMaterialBasicMaterial.DataSource = objsourceMaterialBasic;
            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void cmbMainType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMainType.SelectedItem.Equals("Basic"))
            {
                MainType = "Basic";
                MaterialClear();
                pnlInter.Visible = false;
                pblBasic2.Visible = false;

                IntermediateMaterialSelect = false;
                Load_Materials();
            }


            if (cmbMainType.SelectedItem.Equals("Intermediate"))
            {
                MainType = "Intermediate";
                MaterialClear();
                pnlInter.Visible = true;
                pblBasic2.Visible = false;

                IntermediateMaterialSelect = true;
                Load_Materials();
            }



            if (cmbMainType.SelectedItem.Equals("Processed"))
            {
                MainType = "Processed";
                MaterialClear();
                pnlInter.Visible = true;
                pblBasic2.Visible = false;
               // pnlMaterial.Location = new Point(3, 88);
                Load_Materials();
                IntermediateMaterialSelect = false;
            }
        }

        private void LoadBasicMaterials()
        {
                cmbMaterialBasicMaterial.DataSource = bindBasicMaterials;

        }

        private void rdbRaw_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbRaw.Checked == true)
            {
                LoadMaterials("Raw");
            }

        }

        private void rdbPacking_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbPacking.Checked == true)
            {
                LoadMaterials("Packing");
            }
        }

        private void rdbLab_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbLab.Checked == true)
            {
                LoadMaterials("Lab");
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

    }
}