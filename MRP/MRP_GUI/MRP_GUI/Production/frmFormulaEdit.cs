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

namespace MRP_GUI.Production
{
    public partial class frmFormulaEdit : System.Windows.Forms.Form
    {
        public frmFormulaEdit(Batch _objBatch,User objUser)
        {
            InitializeComponent();
            objBatch = _objBatch;
            CurrentUser = objUser;
        }

        User CurrentUser = new User();


        Batch objBatch = new Batch();
        Batch_DL objBatchDL = new Batch_DL(ConnectionStringClass.GetConnection());
        BatchFormulaMaterial_DL objBatchFormulaMaterial_DL = new BatchFormulaMaterial_DL(ConnectionStringClass.GetConnection());
        BatchFormulaBasicProducts_DL objBatchFormulaBasicProducts_DL = new BatchFormulaBasicProducts_DL(ConnectionStringClass.GetConnection());
        Material_DL objMaterial_DL = new Material_DL(ConnectionStringClass.GetConnection());
        BasicProduct_DL objBasicProduct_DL = new BasicProduct_DL(ConnectionStringClass.GetConnection());

        DataTable dtMaterials = new DataTable();
        DataTable dtSemi = new DataTable();

        DataTable dtFormulaMaterials = new DataTable();
        DataTable dtFormulaSemi = new DataTable();

        private void frmFormulaEdit_Load(object sender, EventArgs e)
        {
            try
            {
                Load_FormulaMaterial();

                Load_SemiList();

                Load_MaterialList();

            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Load_MaterialList()
        {

            try
            {
            dtMaterials = objMaterial_DL.GetDataView("Raw");
            objSourceMaterial.DataSource = dtMaterials;

            cmbMaterial.DataSource = objSourceMaterial;
            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Load_SemiList()
        {
            try
            {
            dtSemi = objBasicProduct_DL.GetDataView("Semi Processed Product", true);
            objSourceSemi.DataSource = dtSemi;

            cmbSemiFinished.DataSource = objSourceSemi;
            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Load_FormulaMaterial()
        {
            try
            {
            if (objBatch.BatchID != "")
            {

                dtFormulaMaterials = objBatchFormulaMaterial_DL.GetMaterial(objBatch.BatchID);

                dgvFormulaMaterial.AutoGenerateColumns = false;
                objSourceFormulaMaterials.DataSource = dtFormulaMaterials;
                dgvFormulaMaterial.DataSource = objSourceFormulaMaterials;
                objSourceFormulaMaterials.ResetBindings(true);
            }
            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Load_FormulaSemi()
        {
            try
            {
            if (objBatch.BatchID != "")
            {

                dtFormulaSemi = objBatchFormulaBasicProducts_DL.GetSemiFinished(objBatch.BatchID);

                dgvFormulaMaterial.AutoGenerateColumns = false;
                objSourceFormulaMaterials.DataSource = dtFormulaSemi;
                dgvFormulaMaterial.DataSource = objSourceFormulaMaterials;
                objSourceFormulaMaterials.ResetBindings(true);
            }
            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void dgvFormulaMaterial_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (chkMaterial.Checked == true)
            {
                if ((dgvFormulaMaterial.CurrentRow.IsNewRow == false) && (dgvFormulaMaterial.CurrentRow != null))
                {
                    cmbMaterial.SelectedValue = dtFormulaMaterials.Rows[dgvFormulaMaterial.CurrentRow.Index]["ItemCode"].ToString();
                    txtNewQty.Text = dtFormulaMaterials.Rows[dgvFormulaMaterial.CurrentRow.Index]["Qty"].ToString();
                    txtPart.Text = dtFormulaMaterials.Rows[dgvFormulaMaterial.CurrentRow.Index]["Part"].ToString();
                }

                
            }
            else
            {
                if ((dgvFormulaMaterial.CurrentRow.IsNewRow == false) && (dgvFormulaMaterial.CurrentRow != null))
                {
                    cmbSemiFinished.SelectedValue = dtFormulaSemi.Rows[dgvFormulaMaterial.CurrentRow.Index]["ItemCode"].ToString();
                    txtNewQty.Text = dtFormulaSemi.Rows[dgvFormulaMaterial.CurrentRow.Index]["Qty"].ToString();
                    txtPart.Text = dtFormulaSemi.Rows[dgvFormulaMaterial.CurrentRow.Index]["Part"].ToString();
                }

              
            }

           
        }

        private void chkMaterial_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMaterial.Checked == true)
            {
                cmbMaterial.Visible = true;
                cmbSemiFinished.Visible = false;

                Load_MaterialList();
                chkSemiFinished.Checked = false;
                Load_FormulaMaterial();

            }
            else
            {
                chkSemiFinished.Checked = true;
            }
        }

        private void chkSemiFinished_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSemiFinished.Checked == true)
            {
                cmbMaterial.Visible = false;
                cmbSemiFinished.Visible = true;

                Load_SemiList();
                chkMaterial.Checked = false;
                Load_FormulaSemi();
            }
            else
            {
                chkMaterial.Checked = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (chkMaterial.Checked == true)
            {
                BatchFormulaMaterial obj = new BatchFormulaMaterial();

                obj.AddedBy = CurrentUser.EmployeeID;
                obj.BatchID = objBatch.BatchID;
                obj.MaterialCode = cmbMaterial.SelectedValue.ToString();
                obj.Part = txtPart.Text;
                obj.Qty =Convert.ToDecimal(txtNewQty.Text);
                obj.Remarks = txtRemarks.Text;

                objBatchFormulaMaterial_DL.Update(obj);

                Load_FormulaMaterial();

            }


            if (chkSemiFinished.Checked == true)
            {
                BatchFormulaBasicProducts obj = new BatchFormulaBasicProducts();

                obj.AddedBy = CurrentUser.EmployeeID;
                obj.BatchID = objBatch.BatchID;
                obj.BasicProductCode = cmbSemiFinished.SelectedValue.ToString();
                obj.Part = txtPart.Text;
                obj.Qty = Convert.ToDecimal(txtNewQty.Text);
                obj.Remarks = txtRemarks.Text;

                objBatchFormulaBasicProducts_DL.Update(obj);

                Load_FormulaSemi();

            }


        }
    }
}
