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
    public partial class frmMRT_Section : System.Windows.Forms.Form
    {
        public frmMRT_Section()
        {
            InitializeComponent();
        }

        public frmMRT_Section(User objUser)
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
        Department_DL objDepDL = new Department_DL(ConnectionStringClass.GetConnection());
        Store_DL objStoreDL = new Store_DL(ConnectionStringClass.GetConnection());
        Material_DL objMaterialDL = new Material_DL(ConnectionStringClass.GetConnection());
        BasicProduct_DL objBasicProductDL = new BasicProduct_DL(ConnectionStringClass.GetConnection());
        FinishProduct_DL objFinishProductDL = new FinishProduct_DL(ConnectionStringClass.GetConnection());

        MR objMR = new MR();
        MR_DL objMRDL = new MR_DL(ConnectionStringClass.GetConnection());
        MRBasicProduct_DL objMRBasicProductDL = new MRBasicProduct_DL(ConnectionStringClass.GetConnection());
        MRBasicProductCollec objMRBasicProductCollec = new MRBasicProductCollec();
        MRFinishProduct_DL objMRFinishProductDL = new MRFinishProduct_DL(ConnectionStringClass.GetConnection());
        MRFinishProductCollec objMRFinishhProductCollec = new MRFinishProductCollec();
        MRMaterial_DL objMRMaterialDL = new MRMaterial_DL(ConnectionStringClass.GetConnection());
        MRMaterialCollec objMRMaterialCollec = new MRMaterialCollec();


        MRMaterial objMRMaterial = new MRMaterial();
        MRBasicProduct objMRBasicProduct = new MRBasicProduct();
        MRFinishProduct objMRFinishProduct = new MRFinishProduct();

        bool ItemSelect = false;
        //-------------------Methods------------------------

        public void ClearMR()
        {
            txtRemarks.Text = "";
            cmbDepartment.SelectedIndex = 0;
            cmbMRType.SelectedIndex = 0;
            cmbStore.SelectedIndex = 0;
            bindItemList.DataSource = null;

            objMRBasicProductCollec.Clear();
            objMRMaterialCollec.Clear();
            objMRFinishhProductCollec.Clear();
        }

        public void ClearItem()
        {
            txtDescription.Text = "";
            txtQty.Text = "0.00";
            cmbItem.SelectedIndex = 0;
            this.ItemSelect = false;
        }

        //-------------------Events-------------------------
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMRT_Load(object sender, EventArgs e)
        {
            try
            {
                cmbDepartment.DataSource = objDepDL.GetDataView(CurrentUser.EmployeeID);
                cmbStore.DataSource = objStoreDL.Get();
                cmbMRType.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                
               MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbMRType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Material objMat = new Material();
            BasicProduct objBasic = new BasicProduct();
            FinishProduct objFinish = new FinishProduct();

            bindItemList.DataSource = null;
            objMRFinishhProductCollec.Clear();
            objMRMaterialCollec.Clear();
            objMRBasicProductCollec.Clear();

            try
            {
                if (cmbMRType.SelectedItem.Equals("Material"))
                {

                    cmbItem.DataSource = objMaterialDL.GetDataView();                    
                    cmbItem.DisplayMember = "Material";
                    cmbItem.ValueMember = "MaterialCode";
 


                    objMat = objMaterialDL.Get(cmbItem.SelectedValue.ToString());
                    if (objMat != null)
                    {
                        lblUnit.Text = objMat.MatUnit.UnitCode;
                    }

                }
                else if (cmbMRType.SelectedItem.Equals("Basic Products"))
                {

                    cmbItem.DataSource = objBasicProductDL.GetDataView(true);                   
                    cmbItem.DisplayMember = "Code";
                    cmbItem.ValueMember = "BasicProductCode";



                    objBasic = objBasicProductDL.Get(cmbItem.SelectedValue.ToString());
                    if (objBasic != null)
                    {
                        lblUnit.Text = objBasic.BasicProductUnit.UnitCode;
                    }


                }
                else if (cmbMRType.SelectedItem.Equals("Finish Products"))
                {
                    cmbItem.DataSource = objFinishProductDL.GetDataView(1);
                    cmbItem.DisplayMember = "Code";
                    cmbItem.ValueMember = "FinishProductCode";


                    objFinish = objFinishProductDL.Get(cmbItem.SelectedValue.ToString());
                    if (objFinish != null)
                    {
                        lblUnit.Text = objFinish.FinishProductPackingType.PackingTitle;
                    }

                }
            }
            catch (Exception ex)
            {
                
                    MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnItemAdd_Click(object sender, EventArgs e)
        {
            if (txtQty.Text.Equals(""))
            {
                MessageBox.Show(this,"Please fill the quantity field","Empty Field",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                bool ItemList = false;
                MRMaterial objMRMat = new MRMaterial();
                MRBasicProduct objMRBasic = new MRBasicProduct();
                MRFinishProduct objMRFinish = new MRFinishProduct();
                try
                {
                    if (this.ItemSelect)
                    {
                        if (cmbMRType.SelectedItem.Equals("Material"))
                        {
                            objMRMat.Description = txtDescription.Text;
                            objMRMat.Material = objMaterialDL.Get(cmbItem.SelectedValue.ToString());
                            objMRMat.ReqdQty = Convert.ToDecimal(txtQty.Text);

                            
                            if (objMRMaterial.Material.MaterialCode != objMRMat.Material.MaterialCode)
                            {
                                foreach (MRMaterial obj in objMRMaterialCollec)
                                {
                                    if (obj.Material.MaterialCode == objMRMat.Material.MaterialCode)
                                    {


                                        MessageBox.Show(this, 
                                            "This item already in the list,Please Select the item from List and Update", 
                                            "Item in the List", 
                                            MessageBoxButtons.OK, 
                                            MessageBoxIcon.Information);

                                        ItemList = true;
                                        break;
                                    }
                                }
                                if (!ItemList)
                                {
                                    objMRMaterialCollec.Delete(objMRMaterial);
                                    objMRMaterialCollec.Add(objMRMat);
                                    ClearItem();
                                }
                            }
                            else
                            {
                                objMRMaterialCollec.Delete(objMRMaterial);
                                objMRMaterialCollec.Add(objMRMat);
                                ClearItem();
                            }


                            bindItemList.DataSource = objMRMaterialCollec;
                            bindItemList.ResetBindings(false);
                        }
                        else if (cmbMRType.SelectedItem.Equals("Basic Products"))
                        {
                            objMRBasic.BasicProduct = objBasicProductDL.Get(cmbItem.SelectedValue.ToString());
                            objMRBasic.Description = txtDescription.Text;
                            objMRBasic.ReqdQty = Convert.ToDecimal(txtQty.Text);


                            if (objMRBasicProduct.BasicProduct.BasicProductCode != objMRBasic.BasicProduct.BasicProductCode)
                            {
                                foreach (MRBasicProduct obj in objMRBasicProductCollec)
                                {
                                    if (obj.BasicProduct.BasicProductCode == objMRBasic.BasicProduct.BasicProductCode)
                                    {
                                        MessageBox.Show(this, "This item already in the list,Please Select the item from List and Update", "Item in the List", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        ItemList = true;
                                        break;
                                    }
                                } 
                                if (!ItemList)
                                {
                                    objMRBasicProductCollec.Delete(objMRBasicProduct);
                                    objMRBasicProductCollec.Add(objMRBasic);
                                    ClearItem();
                                }
                            }
                            else
                            {
                                objMRBasicProductCollec.Delete(objMRBasicProduct);
                                objMRBasicProductCollec.Add(objMRBasic);
                                ClearItem();
                            }

                            bindItemList.DataSource = objMRBasicProductCollec;
                            bindItemList.ResetBindings(false);
                        }
                        else if (cmbMRType.SelectedItem.Equals("Finish Products"))
                        {
                            objMRFinish.Description = txtDescription.Text;
                            objMRFinish.FinishProduct = objFinishProductDL.Get(cmbItem.SelectedValue.ToString());
                            objMRFinish.ReqdQty = Convert.ToDecimal(txtQty.Text);

                            if (objMRFinishProduct.FinishProduct.FinishProductCode != objMRFinish.FinishProduct.FinishProductCode)
                            {
                                foreach (MRFinishProduct obj in objMRFinishhProductCollec)
                                {
                                    if (obj.FinishProduct.FinishProductCode == objMRFinish.FinishProduct.FinishProductCode)
                                    {
                                        MessageBox.Show(this, "This item already in the list,Please Select the item from List and Update", "Item in the List", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        ItemList = true;
                                        break;
                                    }
                                } 
                                if (!ItemList)
                                {
                                    objMRFinishhProductCollec.Delete(objMRFinishProduct);
                                    objMRFinishhProductCollec.Add(objMRFinish);
                                    ClearItem();
                                }
                            }
                            else
                            {
                                objMRFinishhProductCollec.Delete(objMRFinishProduct);
                                objMRFinishhProductCollec.Add(objMRFinish);
                                ClearItem();
                            }

                            bindItemList.DataSource = objMRFinishhProductCollec;
                            bindItemList.ResetBindings(false);

                        } 
                    
                    }
                    else
                    {
                        if (cmbMRType.SelectedItem.Equals("Material"))
                        {
                            objMRMat.Description = txtDescription.Text;
                            objMRMat.Material = objMaterialDL.Get(cmbItem.SelectedValue.ToString());
                            objMRMat.ReqdQty = Convert.ToDecimal(txtQty.Text);

                            if (objMRMaterialCollec.Count > 0)
                            {
                                foreach (MRMaterial obj in objMRMaterialCollec)
                                {
                                    if (obj.Material.MaterialCode == objMRMat.Material.MaterialCode)
                                    {
                                        MessageBox.Show(this, "This item already in the list,Please Select the item from List and Update", "Item in the List", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        ItemList = true;
                                        break;
                                    }
                                }
                                if (!ItemList)
                                {
                                    objMRMaterialCollec.Add(objMRMat);
                                    ClearItem();
                                }
                            }
                            else
                            {
                                objMRMaterialCollec.Add(objMRMat);
                                ClearItem();
                            }
                            bindItemList.DataSource = objMRMaterialCollec;
                            bindItemList.ResetBindings(false);
                        }
                        else if (cmbMRType.SelectedItem.Equals("Basic Products"))
                        {
                            objMRBasic.BasicProduct = objBasicProductDL.Get(cmbItem.SelectedValue.ToString());
                            objMRBasic.Description = txtDescription.Text;
                            objMRBasic.ReqdQty = Convert.ToDecimal(txtQty.Text);
                            if (objMRBasicProductCollec.Count > 0)
                            {
                                foreach (MRBasicProduct obj in objMRBasicProductCollec)
                                {
                                    if (obj.BasicProduct.BasicProductCode == objMRBasic.BasicProduct.BasicProductCode)
                                    {
                                        MessageBox.Show(this, "This item already in the list,Please Select the item from List and Update", "Item in the List", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        ItemList = true;
                                        break;
                                    }
                                }
                                if (!ItemList)
                                {
                                    objMRBasicProductCollec.Add(objMRBasic);
                                    ClearItem();
                                }
                            }
                            else
                            {
                                objMRBasicProductCollec.Add(objMRBasic);
                                ClearItem();
                            }

                            bindItemList.DataSource = objMRBasicProductCollec;
                            bindItemList.ResetBindings(false);
                        }
                        else if (cmbMRType.SelectedItem.Equals("Finish Products"))
                        {
                            objMRFinish.Description = txtDescription.Text;
                            objMRFinish.FinishProduct = objFinishProductDL.Get(cmbItem.SelectedValue.ToString());
                            objMRFinish.ReqdQty = Convert.ToDecimal(txtQty.Text);
                            if (objMRFinishhProductCollec.Count > 0)
                            {
                                foreach (MRFinishProduct obj in objMRFinishhProductCollec)
                                {
                                    if (obj.FinishProduct.FinishProductCode == objMRFinish.FinishProduct.FinishProductCode)
                                    {
                                        MessageBox.Show(this, "This item already in the list,Please Select the item from List and Update", "Item in the List", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        ItemList = true;
                                        break;
                                    }
                                }
                                if (!ItemList)
                                {
                                    objMRFinishhProductCollec.Add(objMRFinish);
                                    ClearItem();
                                }
                            }
                            else
                            {
                                objMRFinishhProductCollec.Add(objMRFinish);
                                ClearItem();
                            }
                            bindItemList.DataSource = objMRFinishhProductCollec;
                            bindItemList.ResetBindings(false);

                        } 
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally 
                {
                    objMRMat = null;
                }
            }
        }

        private void cmbItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            Material objMat = new Material();
            BasicProduct objBasic = new BasicProduct();
            FinishProduct objFinish = new FinishProduct();
            try
            {
             
                    if (cmbMRType.SelectedItem.Equals("Material"))
                    {
                        if (cmbItem.SelectedValue != null)
                        {
                            objMat = objMaterialDL.Get(cmbItem.SelectedValue.ToString());
                            if (objMat != null)
                            {
                                lblUnit.Text = objMat.MatUnit.UnitCode;
                            }
                            else
                            {
                                lblUnit.Text = "";
                            }
                        }

                    }
                    else if (cmbMRType.SelectedItem.Equals("Basic Products"))
                    {
                        objBasic = objBasicProductDL.Get(cmbItem.SelectedValue.ToString());
                        if (objBasic.BasicProductCode != null)
                        {
                            lblUnit.Text = objBasic.BasicProductUnit.UnitCode;
                        }
                        else
                        {
                            lblUnit.Text = "";
                        }
                    }
                    else if (cmbMRType.SelectedItem.Equals("Finish Products"))
                    {
                        objFinish = objFinishProductDL.Get(cmbItem.SelectedValue.ToString());
                        if (objFinish.FinishProductCode != null)
                        {
                            lblUnit.Text = objFinish.FinishProductPackingType.PackingTitle;
                        }
                        else
                        {
                            lblUnit.Text = "";
                        }
                    }
            }
            catch (Exception ex)
            {
                
                    MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gvItemList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    if (cmbMRType.SelectedItem.Equals("Material"))
                    {
                        objMRMaterial = (MRMaterial)gvItemList.Rows[e.RowIndex].DataBoundItem;
                        txtDescription.Text = objMRMaterial.Description;
                        txtQty.Text = objMRMaterial.ReqdQty.ToString();
                        cmbItem.SelectedValue = objMRMaterial.Material.MaterialCode;
                    }
                    else if (cmbMRType.SelectedItem.Equals("Basic Products"))
                    {
                        objMRBasicProduct = (MRBasicProduct)gvItemList.Rows[e.RowIndex].DataBoundItem;
                        txtDescription.Text = objMRBasicProduct.Description;
                        txtQty.Text = objMRBasicProduct.ReqdQty.ToString();
                        cmbItem.SelectedValue = objMRBasicProduct.BasicProduct.BasicProductCode;
                    }
                    else if (cmbMRType.SelectedItem.Equals("Finish Products"))
                    {
                        objMRFinishProduct = (MRFinishProduct)gvItemList.Rows[e.RowIndex].DataBoundItem;
                        txtDescription.Text = objMRFinishProduct.Description;
                        txtQty.Text = objMRFinishProduct.ReqdQty.ToString();
                        cmbItem.SelectedItem = objMRFinishProduct.FinishProduct.FinishProductCode;
                    }
                    ItemSelect = true; 
                }
            }
            catch (Exception ex)
            {
                    MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);    
            }
        }

        private void btnItemDel_Click(object sender, EventArgs e)
        {
            try
            {
                    if (cmbMRType.SelectedItem.Equals("Material"))
                    {
                        objMRMaterialCollec.Delete(objMRMaterial);
                    }
                    else if (cmbMRType.SelectedItem.Equals("Basic Products"))
                    {
                        objMRBasicProductCollec.Delete(objMRBasicProduct);
                    }
                    else if (cmbMRType.SelectedItem.Equals("Finish Products"))
                    {
                        objMRFinishhProductCollec.Delete(objMRFinishProduct);
                    }
                    bindItemList.ResetBindings(false);
                    ClearItem();
            }
            catch (Exception ex)
            {
                  MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);    
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ClearItem();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                objMR.MRDate = DateTime.Now;
                objMR.MRDepartmentFrom = objDepDL.Get(Convert.ToInt64(cmbDepartment.SelectedValue));
                objMR.MREnterdBy = CurrentUser.UserEmp.EmployeeID;
                objMR.MRRemarks = txtRemarks.Text;
                objMR.MRStatus = MR.Status.Initial;
                objMR.MRStore = (Store)cmbStore.SelectedItem;
                if (cbSection.Checked)
                {
                    objMR.SectionID = Convert.ToInt64(cmbSection.SelectedValue);
                }
                else
                {
                    objMR.SectionID = null;
                }
                
                if (cmbMRType.SelectedItem.Equals("Material"))
                {
                   objMR.MRType = MR.Type.Material;
                   if (objMRMaterialCollec.Count > 0)
                   {
                       long MRNO = objMRDL.Add_M(objMR);
                       if (MRNO > 0)
                       {
                           objMR.MRNO = MRNO;
                           foreach (MRMaterial obj in objMRMaterialCollec)
                           {
                               obj.MR = objMR;
                               objMRMaterialDL.Add(obj);
                           }
                           MessageBox.Show(this,"Successfully Added to Database","Successfull",MessageBoxButtons.OK,MessageBoxIcon.Information);
                           ClearItem();
                           ClearMR();
                       }
                   }
                   else
                   {
                       MessageBox.Show(this,"Item List is Empty,Please add Items before continue","Item List is Empty",MessageBoxButtons.OK,MessageBoxIcon.Information);
                   }
                }
                else if (cmbMRType.SelectedItem.Equals("Basic Products"))
                {
                    objMR.MRType = MR.Type.BasicProduct;
                    if (objMRBasicProductCollec.Count > 0)
                    {
                        long MRNO = objMRDL.Add_M(objMR);
                        if (MRNO > 0)
                        {
                            objMR.MRNO = MRNO;
                            foreach (MRBasicProduct obj in objMRBasicProductCollec)
                            {
                                obj.MR = objMR;
                                objMRBasicProductDL.Add(obj);
                            }
                            MessageBox.Show(this, "Successfully Added to Database", "Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearItem();
                            ClearMR();
                        }
                    }
                    else
                    {
                        MessageBox.Show(this, "Item List is Empty,Please add Items before continue", "Item List is Empty", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (cmbMRType.SelectedItem.Equals("Finish Products"))
                {
                    objMR.MRType = MR.Type.FinishProduct;
                    if (objMRFinishhProductCollec.Count > 0)
                    {
                        long MRNO = objMRDL.Add_M(objMR);
                        if (MRNO > 0)
                        {
                            objMR.MRNO = MRNO;
                            foreach (MRFinishProduct obj in objMRFinishhProductCollec)
                            {
                                obj.MR = objMR;
                                objMRFinishProductDL.Add(obj);
                            }
                            MessageBox.Show(this, "Successfully Added to Database", "Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearItem();
                            ClearMR();
                            objMRMaterialCollec.Clear();
                        }
                    }
                    else
                    {
                        MessageBox.Show(this, "Item List is Empty,Please add Items before continue", "Item List is Empty", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void cmbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbDepartment.SelectedValue != null)
                {
                    Section_DL objSectionDL = new Section_DL(ConnectionStringClass.GetConnection());
                    cmbSection.DataSource = objSectionDL.GetDataView(Convert.ToInt64(cmbDepartment.SelectedValue));

                }
            }
            catch (Exception)
            {

                MessageBox.Show(this,"Error occured while loading Sections","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar) || (e.KeyChar == (char)46)))
            {
                e.Handled = true;
            }
        }

        private void cbSection_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSection.Checked)
            {
                cmbSection.Enabled = true;
            }
            else
            {
                cmbSection.Enabled = false;
            }
        }

    }
}