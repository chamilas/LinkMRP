using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SESD.MRP.REF;
using DL;
using System.Data.SqlClient;

namespace MRP_GUI
{
    public partial class ucMaterials : UserControl
    {
        public ucMaterials()
        {
            InitializeComponent();
        }
        //------------------ Form Variables --------------------
        private Unit_DL objUnitDL ;
        private MaterialType_DL objMaterialTypeDL ;
        private Form_DL objFormDL ;
        private Material_DL objMaterialDL ;
        private MaterialCategory_DL objMatCatDL ;

        public void Initialize(SqlConnection Conn)
        {
            objUnitDL = new Unit_DL(Conn);
            objMaterialTypeDL = new MaterialType_DL(Conn);
            objFormDL = new Form_DL(Conn);
            objMaterialDL = new Material_DL(Conn);
            objMatCatDL = new MaterialCategory_DL(Conn);

        }
        
        
        private Material objMaterial = new Material();

        private String OriginalMaterialCode = "";

        private bool MaterialSelect = false;
        private Material objSelectedMaterial = new Material();
        private bool IntermediateMaterialSelect = false;

        private String Category = "";
        private String MainType = "Basic";


        //------------------ Form Methods ----------------------

        public void MaterialLoad()
        {
                try
                {
                    cmbMaterialUnit.DataSource = objUnitDL.GetDataView();
                    cmbMaterialType.DataSource = objMaterialTypeDL.GetDataView();
                    cmbMaterialForm.DataSource = objFormDL.GetDataView();
                                       
                    bindCategory.DataSource = objMatCatDL.GetDataView();
                    listBox1.DataSource = bindCategory;
                    cmbCatergory.DataSource = objMatCatDL.GetDataView();
                    cmbFromMonth.SelectedIndex = 0;
                    cmbToMonth.SelectedIndex = 0;
                    cmbCatergory.SelectedIndex = 0;
                    
                    listBox1.SelectedIndex = 0;
                    cmbMainType.SelectedIndex = 0;
                    //rbRaw.Checked = true;
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
            if (cmbMaterialBasicMaterial.Items.Count>0)
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
                            objMaterial.MaterialCode = txtMaterialCode.Text.Replace(" ","");
                            objMaterial.MaterialDescription = txtmaterialName.Text;
                            objMaterial.MaterialStatus = Convert.ToInt32(Material.Status.Enable);
                            
                            objMaterial.MatForm = objFormDL.Get(Convert.ToInt64(cmbMaterialForm.SelectedValue));
                            objMaterial.MatParticleSize = (txtMaterialBasicPartialSize.Text);
                            objMaterial.MatUnit = objUnitDL.Get(Convert.ToInt64(cmbMaterialUnit.SelectedValue));
                            objMaterial.MatSeasonFrom = "N/A";
                            objMaterial.MatSeasonTo = "N/A";


                            int x=0;
                            if (this.MaterialSelect)
                            {
                                //x = objMaterialDL.Add(objMaterial, objSelectedMaterial.MaterialCode,SubcatL1,SubCatL2);
                                MaterialClear();

                                bindMaterials.DataSource = objMaterialDL.GetDataView(cmbCatergory.SelectedValue.ToString());

                                if (x > 0)
                                {
                                    MessageBox.Show(this, "Succesfully Updated the Database", "Succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    int counter = 0;
                                    foreach (DataGridViewRow var in gvMaterialList.Rows)
                                    {
                                        if (var.Cells["ColMaterialCode"].Value.Equals(objMaterial.MaterialCode))
                                        {

                                            gvMaterialList.CurrentCell = gvMaterialList[1, counter];
                                            gvMaterialList.FirstDisplayedScrollingRowIndex = counter;

                                            break;
                                        }
                                        counter++;
                                    }

                                }
                            }
                            else
                            {
                               // x = objMaterialDL.Add(objMaterial,"",SubcatL1,SubCatL2);
                                if (x > 0)
                                {

                                    MaterialClear();
                                    bindMaterials.DataSource = objMaterialDL.GetDataView(cmbCatergory.SelectedValue.ToString());
                                    MessageBox.Show(this, "Succesfully Added to Database", "Succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information);


                                    int counter = 0;
                                    foreach (DataGridViewRow var in gvMaterialList.Rows)
                                    {
                                        if (var.Cells["ColMaterialCode"].Value.Equals(objMaterial.MaterialCode))
                                        {

                                            gvMaterialList.CurrentCell = gvMaterialList[1, counter];
                                            gvMaterialList.FirstDisplayedScrollingRowIndex = counter;

                                            break;
                                        }
                                        counter++;
                                    }

                                }
                                else if (x == -1)
                                {
                                    MessageBox.Show(this, "Material Code already in the Database,Please enter another Material Code", "Problem with Material Code", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                            this.MaterialSelect = false;
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


                            objMaterial.MatUnit = objUnitDL.Get(Convert.ToInt64(cmbMaterialUnit.SelectedValue));
                            int x=0;

                            if (this.MaterialSelect)
                            {
                               // x = objMaterialDL.Add(objMaterial, objSelectedMaterial.MaterialCode,SubcatL1,SubCatL2);
                                MaterialClear();
                                bindMaterials.DataSource = objMaterialDL.GetDataView(cmbCatergory.SelectedValue.ToString());
                                if (x > 0)
                                {
                                    MessageBox.Show(this, "Succesfully Updated the Database", "Succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    int counter = 0;
                                    foreach (DataGridViewRow var in gvMaterialList.Rows)
                                    {
                                        if (var.Cells["ColMaterialCode"].Value.Equals(objMaterial.MaterialCode))
                                        {

                                            gvMaterialList.CurrentCell = gvMaterialList[1, counter];
                                            gvMaterialList.FirstDisplayedScrollingRowIndex = counter;

                                            break;
                                        }
                                        counter++;
                                    }
                                }
                            }
                            else
                            {

                              //  x = objMaterialDL.Add(objMaterial,"",SubcatL1,SubCatL2);


                                if (x > 0)
                                {

                                    MaterialClear();
                                    bindMaterials.DataSource = objMaterialDL.GetDataView(cmbCatergory.SelectedValue.ToString());
                                    MessageBox.Show(this, "Succesfully Added to Database", "Succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    int counter = 0;
                                    foreach (DataGridViewRow var in gvMaterialList.Rows)
                                    {
                                        if (var.Cells["ColMaterialCode"].Value.Equals(objMaterial.MaterialCode))
                                        {

                                            gvMaterialList.CurrentCell = gvMaterialList[1, counter];
                                            gvMaterialList.FirstDisplayedScrollingRowIndex = counter;

                                            break;
                                        }
                                        counter++;
                                    }

                                }
                                else if (x == -1)
                                {
                                    MessageBox.Show(this, "Material Code already in the Database,Please enter another Material Code", "Problem with Material Code", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
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
                panel1.Visible = true;
                pnlMaterial.Location = new Point(3, 88);
                //txtMaterialCode.Mask = ">AA/AAA/AA>";
                IntermediateMaterialSelect = false;
                if (cmbMaterialBasicMaterial.Items.Count > 0)
                {
                       cmbMaterialBasicMaterial.SelectedIndex = 0;

                }
               
                cmbCatergory.SelectedIndex = 0;
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
                        bindMaterials.DataSource = objMaterialDL.GetDataView(cmbCatergory.SelectedValue.ToString());
                        MaterialClear();
                        if (x > 0)
                        {
                            MessageBox.Show(this, "Succesfully Deleted From Database", "Succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (SqlException sqlex)
                    {
                        if (sqlex.Number == 547)
                        {
                            MessageBox.Show(this,"Selected Material has references to another record or more. System will not allow to delete the record\nPlease contact your System Administrator for further information","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
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


                    //cmbCatergory.SelectedValue = objSelectedMaterial.Category.MatCatID;
                    //if (cmbMaterialSubCat1.Items.Count > 0)
                    //{
                    //    cmbMaterialSubCat1.SelectedValue = objSelectedMaterial.SubCatL1;
                    //    if (cmbMaterialSubCategory.Items.Count > 0)
                    //    {
                    //        cmbMaterialSubCategory.SelectedValue = objSelectedMaterial.SubCatL2;
                    //    }
                    //}



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

        private void ucMaterials_Load(object sender, EventArgs e)
        {
            //cmbCatergory.SelectedItem = 0;
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

        private void cmbMaterialSubCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                LoadBasicMaterials();
               

            }
            catch (Exception ex)
            {

                MessageBox.Show(this, "Error occured while loading Basic Materials", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void cmbCatergory_SelectedIndexChanged(object sender, EventArgs e)
        {


            if (cmbCatergory.SelectedValue != null)
            {

                //MaterialSubCatL1_DL objMaterialSubCatL1_DL = new MaterialSubCatL1_DL(ConnectionStringClass.GetConnection());
                //MaterialSubCatL2_DL objMaterialSubCatL2_DL = new MaterialSubCatL2_DL(ConnectionStringClass.GetConnection());

                try
                {
                    if (cmbCatergory.Items.Count > 0 && cmbCatergory.SelectedValue != null)
                    {
                        //bindSubCat1.DataSource = objMaterialSubCatL1_DL.Get_By_MaterialCategory(cmbCatergory.SelectedValue.ToString());
                            bindSubCat2.DataSource = null;
                            bindBasicMaterials.DataSource = null;
                    }
                    else
                    {

                        MaterialClear();
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show(this, "Error occured while loading Category", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                //Category = cmbCatergory.SelectedValue.ToString();
                //cmbMaterialBasicMaterial.DataSource = objMaterialDL.GetDataViewByCategory("Basic", Category, cmbMaterialSubCategory.SelectedValue.ToString(), 1);

                if (cmbMainType.SelectedItem != null && cmbMainType.SelectedItem.Equals("Basic"))
                {
                    //if (cmbCatergory.SelectedValue.Equals("Raw") || cmbCatergory.SelectedValue.Equals("Packing"))
                    //{
                    //    txtMaterialCode.Mask = ">AA/AAA/AA>";
                    //}
                    //else
                    //{
                    //    txtMaterialCode.Mask = ">AA/AAA/AAAA>";
                    //}

                    //txtMaterialCode.Mask = ">AA/AAA/AAAA>";
                }

                if (cmbMainType.SelectedItem != null && cmbMainType.SelectedItem.Equals("Intermediate"))
                {
                //    if (cmbCatergory.SelectedValue.Equals("Raw") || cmbCatergory.SelectedValue.Equals("Packing"))
                //    {
                //        txtMaterialCode.Mask = ">AA/AAA/AA/AA>";
                //    }
                //    else
                //    {
                //        txtMaterialCode.Mask = ">AA/AAA/AAAA/AA>";
                //    } 
                    //txtMaterialCode.Mask = ">AA/AAA/AAAA/AA>";
                }
                if (cmbMainType.SelectedItem != null && cmbMainType.SelectedItem.Equals("Processed"))
                {

                //    if (cmbCatergory.SelectedValue.Equals("Raw") || cmbCatergory.SelectedValue.Equals("Packing"))
                //    {
                //        txtMaterialCode.Mask = ">AA/AAA/AA/AA>";
                //    }
                //    else
                //    {
                //        txtMaterialCode.Mask = ">AA/AAA/AAAA/AA>";
               //    }

                    //txtMaterialCode.Mask = ">AA/AAA/AAAA/AA>";
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MaterialLoad();
        }

        private void txtAcgUnitCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar) || (e.KeyChar == (char)46)))
            {
                e.Handled = true;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (listBox1.SelectedValue != null)
                {
                    bindMaterials.ResetBindings(false);
                    bindMaterials.DataSource = objMaterialDL.GetDataView(listBox1.SelectedValue.ToString());
                    
                }
                
                
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
                panel1.Visible = true;
                pnlMaterial.Location = new Point(3, 88);

                //if (cmbCatergory.SelectedValue.Equals("Raw") || cmbCatergory.SelectedValue.Equals("Packing"))
                //{
                //    txtMaterialCode.Mask = ">AA/AAA/AA>";
                //}
                //else
                //{
                //    txtMaterialCode.Mask = ">AA/AAA/AAAA>";
                //}
                IntermediateMaterialSelect = false;
            }


            if (cmbMainType.SelectedItem.Equals("Intermediate"))
            {
                MainType = "Intermediate";
                //if (cmbCatergory.SelectedValue.Equals("Raw") || cmbCatergory.SelectedValue.Equals("Packing"))
                //{
                //    txtMaterialCode.Mask = ">AA/AAA/AA/AA>";
                //}
                //else
                //{
                //    txtMaterialCode.Mask = ">AA/AAA/AAAA/AA>";
                //}
                MaterialClear();
                pnlInter.Location = new Point(3, 88);
                pnlMaterial.Location = new Point(3, 154);
                pnlInter.Visible = true;
                panel1.Visible = false;


                IntermediateMaterialSelect = true;


 
            }



            if (cmbMainType.SelectedItem.Equals("Processed"))
            {
                MainType = "Processed";
                MaterialClear();
                pnlInter.Visible = false;
                panel1.Visible = true;
                pnlMaterial.Location = new Point(3, 88);

                //if (cmbCatergory.SelectedValue.Equals("Raw") || cmbCatergory.SelectedValue.Equals("Packing"))
                //{
                //    txtMaterialCode.Mask = ">AA/AAA/AA/AA>";
                //}
                //else
                //{
                //    txtMaterialCode.Mask = ">AA/AAA/AAAA/AA>";
                //}
                IntermediateMaterialSelect = false;
            }
        }

        private void LoadBasicMaterials()
        {
            if (cmbCatergory.SelectedValue != null)
            {

               // bindBasicMaterials.DataSource = objMaterialDL.Get_MainType_Category("Processed", Convert.ToInt64(cmbMaterialSubCat1.SelectedValue), Convert.ToInt64(cmbMaterialSubCategory.SelectedValue));
                cmbMaterialBasicMaterial.DataSource = bindBasicMaterials;

            }
        }


    }
}
