using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using DL;
using SESD.MRP.REF;

namespace MRP_GUI.Components
{
    public partial class ucDivision : UserControl
    {
        private bool IsSelect = false;
        private Division_DL objDivisionDL;
        private Employee_DL objEmpDL;
        private DivisionManage_DL objDivisionManageDL;

        DivisionManage objSelectedManager = new DivisionManage();
        public ucDivision()
        {
            InitializeComponent();
        }

        public void Load(SqlConnection Conn)
        {
            objDivisionDL = new Division_DL(Conn);
            objEmpDL = new Employee_DL(Conn);
            gvDivisions.DataSource = objDivisionDL.GetDataView();
            cmbManagers.DataSource = objEmpDL.Get_By_RoleType("Workforce", false);
            cmbType.SelectedIndex = 0;
            objDivisionManageDL = new DivisionManage_DL(Conn);
            if (cmbManagers.Items.Count>0)
            {
                cmbManagers.SelectedIndex = -1;
            }
        }

        private void btnBasicProductAdd_Click(object sender, EventArgs e)
        {
            try
            {
                long ID = 0;
                if (!txtID.Text.Equals("[Auto]"))
                {
                    ID = Convert.ToInt64(txtID.Text);
                }
                Divisions obj = new Divisions();
                obj.DivisionID = ID;
                obj.DivisionName = txtName.Text;
                obj.DivisionType = cmbType.SelectedItem.ToString();
                long NewID = objDivisionDL.Add(obj);
                if (NewID > 0)
                {


                    txtID.Text = NewID.ToString();
                    gvDivisions.DataSource = objDivisionDL.GetDataView();
                    btnManagerAdd.Enabled = true;
                    btnMangerDelete.Enabled = true;
                    btnManagerClear.Enabled = true;
                    MessageBox.Show(this,"Successfully Saved","Successful",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(this,"Error occured while saving","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void ClearForm()
        {

            txtID.Text = "[Auto]";
            txtName.Text = "";
            cmbType.SelectedIndex = 0;
            IsSelect = false;
            btnManagerAdd.Enabled = false;
            btnMangerDelete.Enabled = false;
            btnManagerClear.Enabled = false;
            objSelectedManager = new DivisionManage();
            bindManagers.DataSource = objDivisionManageDL.Get(0);
        }

        private void btnBasicProductDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsSelect)
                {
                    long ID = Convert.ToInt64(txtID.Text);

                    int res = objDivisionDL.Delete(ID);
                    if (res > 0)
                    {
                        ClearForm();
                        gvDivisions.DataSource = objDivisionDL.GetDataView();
                        MessageBox.Show(this,"Successfully Deleted","Successful",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                }
                else
                {

                }
            }
            catch (Exception)
            {
                    
                MessageBox.Show(this,"Error occured while deleteting","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void btnBasicProductClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void gvDivisions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    long ID = Convert.ToInt64(gvDivisions.Rows[e.RowIndex].Cells["colDivisionID"].Value);

                    Divisions obj = objDivisionDL.Get(ID);
                    if (obj != null)
                    {
                        txtID.Text = obj.DivisionID.ToString();
                        txtName.Text = obj.DivisionName;
                        cmbType.SelectedItem = obj.DivisionType;
                        bindManagers.DataSource = objDivisionManageDL.Get(obj.DivisionID);
                        btnManagerAdd.Enabled = true;
                        btnMangerDelete.Enabled = true;
                        btnManagerClear.Enabled = true;
                        IsSelect = true;
                        if (cmbManagers.Items.Count>0)
                        {
                            cmbManagers.SelectedIndex = -1;
                        }
                        
                    }

                }
            }
            catch (Exception)
            {

                MessageBox.Show(this, "Error occured while loading", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnManagerAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbManagers.Items.Count > 0)
                {
                    DivisionManage obj = new DivisionManage();
                    obj.ManagerID = cmbManagers.SelectedValue.ToString();
                    obj.DivisionID = Convert.ToInt64(txtID.Text);

                    int res = objDivisionManageDL.Add(obj, objSelectedManager);
                    if (res > 0)
                    {
                        bindManagers.DataSource = objDivisionManageDL.Get(obj.DivisionID);
                        objSelectedManager = new DivisionManage();
                        cmbManagers.SelectedIndex = -1;
                    }
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                {
                    MessageBox.Show(this,"Manager already added","Duplicate Record",MessageBoxButtons.OK,MessageBoxIcon.Warning);    
                }
                
            }
            catch (Exception)
            {

                MessageBox.Show(this, "Error occured while saving Manager", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void gvManagers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    String ManagerID = gvManagers.Rows[e.RowIndex].Cells["colEmpID"].Value.ToString();
                    this.objSelectedManager.DivisionID = Convert.ToInt64(txtID.Text);
                    this.objSelectedManager.ManagerID = ManagerID;

                    cmbManagers.SelectedValue = ManagerID;


                }
                catch (Exception)
                {

                    MessageBox.Show(this,"Error occured while loading","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
        }

        private void btnMangerDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (objSelectedManager.DivisionID > 0)
                {
                    DialogResult dr = MessageBox.Show(this, "Are you sure you want to delete Selected manager?\n\nClick Yes to Delete", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                    if (dr == DialogResult.Yes)
                    {
                        int res = objDivisionManageDL.Delete(objSelectedManager);
                        bindManagers.DataSource = objDivisionManageDL.Get(Convert.ToInt64(txtID.Text));
                        objSelectedManager = new DivisionManage();
                    }
                }
                else
                {
                    MessageBox.Show(this,"Please select a Manager","Selection Empty",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {
                
                    MessageBox.Show(this,"Error occured while deleting","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void btnManagerClear_Click(object sender, EventArgs e)
        {
            cmbManagers.SelectedIndex = -1;
            objSelectedManager = new DivisionManage();
        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
