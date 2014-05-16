using DL;
using SESD.MRP.REF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MRP_GUI.Sales
{
    public partial class frmProjectMaterials : System.Windows.Forms.Form
    {
        private User _objCurrentUser;

        public User CurrentUser
        {
            get { return _objCurrentUser; }
            set { _objCurrentUser = value; }
        }

        Stock_DL objStock_DL = new Stock_DL(ConnectionStringClass.GetConnection());
        private Projects_DL objProjects_DL = new Projects_DL(ConnectionStringClass.GetConnection());
        private ProjectMaterials_DL objProjectMaterials_DL = new ProjectMaterials_DL(ConnectionStringClass.GetConnection());
        ProjectMaterials objProjectMaterial = new ProjectMaterials();


        DataTable dtMt =new DataTable();
        DataTable tempAvailabalProduct = new DataTable();

        public frmProjectMaterials(User objUser)
        {
            InitializeComponent();
            CurrentUser = objUser;
            LoadData();
        }

        private void LoadData() 
        {
            bsProjets.DataSource = objProjects_DL.GetProjects();
            cmbProjectName.DataSource = bsProjets;        
        }

        private void cmbProjectName_SelectedIndexChanged(object sender, EventArgs e)
        {
            objProjectMaterial.ProjectID = Convert.ToInt32(((DataRowView)this.bsProjets.Current).Row["ProjectID"].ToString());
            LoadMaterials();
            //System.Threading.Thread.Sleep(2000);
            LoadDGVmaterials();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //objProjectMaterials_DL.GetProjectMaterials_DataView(((DataRowView)this.bsProjets.Current).Row["ProjectID"].ToString());
            //bsMaterials.DataSource = objStock_DL.GetDataView(((DataRowView)this.bsProjets.Current).Row["StoreID"].ToString());
            //cbmMaterial.DataSource = bsMaterials;

            if (cbmMaterial.SelectedValue == null) 
            {
                MessageBox.Show(this, "Pleace Select Material", "MRP System", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (!DataValidation.Is2DecimalPointNumber(txtQty.Text) || !DataValidation.Is2DecimalPointNumber(txtDamageQty.Text))
            {
                MessageBox.Show(this, "Pleace Enter Valid Quantity", "MRP System", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                objProjectMaterial.ProjectID = Convert.ToInt32(((DataRowView)bsProjets.Current).Row["ProjectID"].ToString());
                objProjectMaterial.MaterialID = cbmMaterial.SelectedValue.ToString();
                objProjectMaterial.UsedQty = Convert.ToDouble(txtQty.Text);
                objProjectMaterial.DamagedQty = Convert.ToDouble(txtDamageQty.Text);
                objProjectMaterial.EnteredBy = CurrentUser.UserEmp.EmployeeID;
                objProjectMaterial.ItemTypeName = ((DataRowView)bsMaterials.Current).Row["StockTypeName"].ToString();
                objProjectMaterial.UnitPrice = Convert.ToDouble(((DataRowView)bsMaterials.Current).Row["StockUnitPrice"].ToString());

                tempAvailabalProduct = objProjectMaterials_DL.GetProjectMaterial_Availability(objProjectMaterial.MaterialID, objProjectMaterial.UsedQty, objProjectMaterial.ItemTypeName);
                if (tempAvailabalProduct.Rows.Count > 0)
                {
                    objProjectMaterials_DL.Add(objProjectMaterial);
                    LoadDGVmaterials();
                }
                else
                {
                    MessageBox.Show(this, "selected quantity is unavailable", "MRP System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } 
            }
        }

        private void LoadMaterials()
        {
            try
            {
                String storeID = cmbProjectName.SelectedValue.ToString();
                bsMaterials.DataSource = objProjectMaterials_DL.GetDataView(storeID);
                cbmMaterial.DataSource = bsMaterials;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }
        private void LoadDGVmaterials() 
        {
            //
            dgvMaterials.AutoGenerateColumns = false;
            bsDGVmaterial.DataSource = objProjectMaterials_DL.GetProjectMaterials_DataView(objProjectMaterial.ProjectID);
            //bsDGVmaterial.
            dgvMaterials.DataSource = bsDGVmaterial;
            bsDGVmaterial.ResetBindings(true);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            
        }

        private void cbmMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbmMaterial.SelectedValue != null)
            {
                String availableQty = ((DataRowView)this.bsMaterials.Current).Row["StockQty"].ToString();
                lblAvailaableQty.Text = "Available Quantity : " + availableQty;
            }
        }

    }
}
