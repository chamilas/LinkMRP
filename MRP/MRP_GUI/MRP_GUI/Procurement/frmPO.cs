using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SESD.MRP.REF;
using DL;

namespace MRP_GUI
{
    public partial class frmPO : System.Windows.Forms.Form
    {
        public frmPO(User objUser,string _POType)
        {
            InitializeComponent();
            CurrentUser = objUser;
            POType = _POType;

        }

        User CurrentUser = new User();
        string POType = "";
        Supplier_DL objSupplier_DL = new Supplier_DL(ConnectionStringClass.GetConnection());
        Material_DL objMaterial_DL = new Material_DL(ConnectionStringClass.GetConnection());
        PO_DL objPO_DL = new PO_DL(ConnectionStringClass.GetConnection());
        POMaterials_DL objPOMaterials_DL = new POMaterials_DL(ConnectionStringClass.GetConnection());

        POMaterialsCollec objPOMaterialsCollec = new POMaterialsCollec();

        Supplier objSupplier = new Supplier();
        DataTable dtSuppliers = new DataTable();
        DataTable dtMaterials = new DataTable();




        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void POEntering_Load(object sender, EventArgs e)
        {
            try
            {
               

               dtSuppliers =objSupplier_DL.GetDataView(POType);

                objSource.DataSource = dtSuppliers;
                cmbSupplier.DataSource = objSource;

                dtMaterials = objMaterial_DL.GetDataView(POType);
                objSourceMaterials.DataSource = dtMaterials;
                cmbMaterials.DataSource = objSourceMaterials;

            }
            catch (Exception ex)
            {

            }
        }

        private void cmbSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if(cmbSupplier.SelectedValue!=null)
                {
                objSupplier = objSupplier_DL.Get(Convert.ToInt64(cmbSupplier.SelectedValue));

                 txtSupplierDetails.Text=objSupplier.SupplieName+" - "+objSupplier.SupplierAddress+" Phone :"+objSupplier.SupplierPhone+" Mob : "+objSupplier.SupplierMobile;

                }


               
            }
            catch (Exception ex)
            {

            }
        }

        private void cmbMaterials_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Material objMaterial = new Material();
                objMaterial = objMaterial_DL.Get(cmbMaterials.SelectedValue.ToString());
                lblUnit.Text = objMaterial.MatUnit.UnitCode;
            }
            catch (Exception ex)
            {

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                POMaterials objPOMaterials = new POMaterials();
                
                bool duplicatefound = false;
                int x=-1;

                objPOMaterials.MaterialCode = cmbMaterials.SelectedValue.ToString();
                objPOMaterials.PONO = txtPONO.Text;
                objPOMaterials.POQty =Convert.ToDecimal(txtReqQty.Text);
                objPOMaterials.UnitPrice = Convert.ToDecimal(txtUnitPrice.Text);
                objPOMaterials.Material = objMaterial_DL.Get(cmbMaterials.SelectedValue.ToString()).MaterialCode +" - "+ objMaterial_DL.Get(cmbMaterials.SelectedValue.ToString()).MaterialDescription;


                foreach(POMaterials obj in objPOMaterialsCollec)
                {
                    x=x+1;
                    if (obj.MaterialCode == objPOMaterials.MaterialCode)
                    {
                        duplicatefound = true;
                        break;

                    }
                }

                if (duplicatefound == true)
                {
                    DialogResult theResult = MessageBox.Show(this, "Confirmation", "Do you want to add this product with the new qty", MessageBoxButtons.YesNo);

                    if (theResult == System.Windows.Forms.DialogResult.Yes)
                    {
                        objPOMaterialsCollec.RemoveAt(x);
                        objPOMaterialsCollec.Add(objPOMaterials);
                    }
                }
                else
                {
                    objPOMaterialsCollec.Add(objPOMaterials);
                }

                gvMaterialList.AutoGenerateColumns = false;
                objSourceMaterialList.DataSource = objPOMaterialsCollec;
                gvMaterialList.DataSource = objSourceMaterialList;
                objSourceMaterialList.ResetBindings(true);

                txtReqQty.Text = "";
                txtUnitPrice.Text = "";

            }
            catch (Exception ex)
            {

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                if ((txtPONO.Text == "") | (cmbSupplier.SelectedValue == null) | (cmbPOPaymentType.Text == ""))
                {
                    MessageBox.Show("Required Fields are Missing");
                }
                else
                {
                    PO objPO = new PO();

                    objPO.PONO = txtPONO.Text;
                    objPO.POStatus = 0;
                    objPO.POSupplierID = Convert.ToInt32(cmbSupplier.SelectedValue);
                    objPO.POReference = txtPOReference.Text;
                    objPO.POEnterdBy = CurrentUser.EmployeeID;
                    objPO.PORequiredDate = dtpReqDate.Value;
                    objPO.POValidityPeriod = Convert.ToInt64(nudValid.Value);
                    objPO.POPaymentType = cmbPOPaymentType.Text;
                    objPO.POType = POType;

                    if (chkImport.Checked == true)
                    {
                        objPO.POCategory = "Import";
                    }
                    else
                    {
                        objPO.POCategory = "Local";
                    }

                    long x = objPO_DL.Add(objPO);

                    if (x > 0)
                    {
                        foreach (POMaterials obj in objPOMaterialsCollec)
                        {
                            objPOMaterials_DL.Add(obj);
                        }

                        MessageBox.Show("Successfully Saved");
                        objPOMaterialsCollec.Clear();

                        gvMaterialList.AutoGenerateColumns = false;
                        objSource.DataSource = null;
                        gvMaterialList.DataSource = objSource;
                        objSource.ResetBindings(true);

                        txtPONO.Text = "";
                        txtPOReference.Text = "";
                        nudValid.Value = 0;


                    }
                }

            }
            catch (Exception ex)
            {

            }
        }
    }
}
