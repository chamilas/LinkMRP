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
    public partial class ucSection : UserControl
    {
        private Employee_DL objEmpDL;
        private Department_DL objDepDL;
        private Division_DL objDivisionDL;
        private Section_DL objSectionDL;
        private bool IsSelect = false; 
        public ucSection()
        {
            InitializeComponent();
        }

        public void Load(SqlConnection conn)
        {
            
            try
            {
                objSectionDL = new Section_DL(conn);
                objEmpDL = new Employee_DL(conn);
                objDepDL = new Department_DL(conn);
                objDivisionDL = new Division_DL(conn);




                bindDivisions.DataSource = objDivisionDL.GetDataView();
                cmbDivision.DataSource = bindDivisions;

                cmbSupervisor.DataSource = objEmpDL.Get_By_RoleType("Staff",true);

               


            }
            catch (Exception)
            {

                MessageBox.Show(this,"Error occured while loading","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void cmbDivision_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbDivision.Items.Count > 0)
                {
                     bindDepartments.DataSource = objDepDL.GetDataView(Convert.ToInt64(cmbDivision.SelectedValue));
                     cmbDepartment.DataSource = bindDepartments;
 
                }
            }
            catch (Exception ex)
            {
                
                 MessageBox.Show(this,"Error occured while loading","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
               
            }
        }

        private void cmbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbDepartment.Items.Count > 0)
                {
                    long DepID = Convert.ToInt64(cmbDepartment.SelectedValue);
                    gvSections.DataSource = objSectionDL.GetDataView(DepID);

                }
            }
            catch (Exception)
            {
                
                 MessageBox.Show(this,"Error occured while loading","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbDepartment.SelectedValue != null)
                {
                    long ID = 0;
                    if (!txtID.Text.Equals("[Auto]"))
                    {
                        ID = Convert.ToInt64(txtID.Text);
                    }
                    

                    Sections obj = new Sections();
                    obj.DepID = Convert.ToInt64(cmbDepartment.SelectedValue);
                    obj.SectionHead = objEmpDL.Get(cmbSupervisor.SelectedValue.ToString());
                    obj.SectionID = ID;
                    obj.SectionName = txtName.Text;


                    long NewID = objSectionDL.Add(obj);
                    if (NewID > 0)
                    {
                        if (cmbDepartment.Items.Count > 0)
                        {
                            long DepID = Convert.ToInt64(cmbDepartment.SelectedValue);
                            gvSections.DataSource = objSectionDL.GetDataView(DepID);

                        }
                        ClearForm();

                    }
                }
                
            }
            catch (Exception)
            {
                    
                 MessageBox.Show(this,"Error occured while saving","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void ClearForm()
        {
            txtID.Text = "[Auto]";
            txtName.Text = "";
            cmbSupervisor.SelectedIndex = 0;
            IsSelect = false;

            dtMorningFrom.Value = Convert.ToDateTime("11/12/2009 10:15 AM");
            dtMorningTo.Value = Convert.ToDateTime("11/12/2009 10:30 AM");

            dtLunchFrom.Value = Convert.ToDateTime("11/12/2009 12:30 PM");
            dtLunchTo.Value = Convert.ToDateTime("11/12/2009 1:00 PM");

            dtEveFrom.Value = Convert.ToDateTime("11/12/2009 4:00 PM");
            dtEveTo.Value = Convert.ToDateTime("11/12/2009 4:15 PM");

            brkFrm1.Value = Convert.ToDateTime("11/12/2009 8:30 AM");
            brkFrm2.Value = Convert.ToDateTime("11/12/2009 8:30 AM");
            brkFrm3.Value = Convert.ToDateTime("11/12/2009 8:30 AM");

            brkTo1.Value = Convert.ToDateTime("11/12/2009 8:30 AM");
            brkTo2.Value = Convert.ToDateTime("11/12/2009 8:30 AM");
           brkTo3.Value = Convert.ToDateTime("11/12/2009 8:30 AM");




        }

        private void gvSections_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex>= 0)
            {
                try
                {
                    long ID = Convert.ToInt64(gvSections.Rows[e.RowIndex].Cells["colSectionID"].Value);
                    Sections obj = objSectionDL.Get(ID);
                    if (obj != null)
                    {
                        txtID.Text = obj.SectionID.ToString();
                        txtName.Text = obj.SectionName;
                        cmbSupervisor.SelectedValue = obj.SectionHead.EmployeeID;

                        IsSelect = true;

                        

                    }
                }
                catch (Exception)
                {

                    MessageBox.Show(this,"Error occured while loading","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (IsSelect)
            {
                try
                {
                    long ID = 0;
                    if (!txtID.Text.Equals("[Auto]"))
                    {
                        ID = Convert.ToInt64(txtID.Text);
                    }

                    int res = objSectionDL.Delete(ID);
                    if (res > 0)
                    {
                        if (cmbDepartment.Items.Count > 0)
                        {
                            long DepID = Convert.ToInt64(cmbDepartment.SelectedValue);
                            gvSections.DataSource = objSectionDL.GetDataView(DepID);

                        }
                        ClearForm();
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show(this,"Error occured while deleting","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show(this,"Please select a Section","Selection Empty",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void dtLunchFrom_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
