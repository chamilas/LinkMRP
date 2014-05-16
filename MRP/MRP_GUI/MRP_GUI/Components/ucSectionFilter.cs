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
    public partial class ucSectionFilter : UserControl
    {

        Section_DL objSectionDL;
        Division_DL objDivisionDL;
        Department_DL objDepartmentDL;



        public ucSectionFilter()
        {
            InitializeComponent();
        }

        private SqlConnection Connection;
        private Divisions _Division;

        public Divisions Division
        {
            get 
            {
                if (cmbDivision.Items.Count > 0)
                {
                   long ID = Convert.ToInt64(cmbDivision.SelectedValue);
                   _Division = objDivisionDL.Get(ID);
                    return _Division; 
                }
                return null;
            }
            set 
            { 


                _Division = value;
                if (cmbDivision.Items.Count > 0)
                {
                   cmbDivision.SelectedValue = _Division.DivisionID;

                }
            }
        }

        private Department _Department;

        public Department Department
        {
            get
            {
                if (cmDepartment.Items.Count > 0)
                {
                   long ID = Convert.ToInt64(cmDepartment.SelectedValue);
                   _Department = objDepartmentDL.Get(ID);
                    return _Department; 
                }
                return null;
            }
            set 
            { 
                _Department = value;
                if (cmDepartment.Items.Count > 0)
                {
                    Department objDep = objDepartmentDL.Get(_Department.DepID);
                    cmbDivision.SelectedValue = objDep.DivisionID;
                    cmDepartment.SelectedValue = _Department.DepID;

                }
            
            }
        }

        private Sections _Section;

        public Sections Section
        {
            get 
            {
                if (cmbSection.Items.Count > 0)
                {
                    long ID = Convert.ToInt64(cmbSection.SelectedValue);
                    _Section = objSectionDL.Get(ID);
                    return _Section; 
                }
                return null;
            }
            set 
            { 
                _Section = value;
                if (_Section != null)
                {
                    Set(_Section);
                }

            }
        }


        public void Set(Sections obj)
        {
            try
            {
                Department objDep = objDepartmentDL.Get(obj.DepID);
                cmbDivision.SelectedValue = objDep.DivisionID;
                cmDepartment.SelectedValue = objDep.DepID;
                cmbSection.SelectedValue = obj.SectionID;
            }
            catch (Exception)
            {
                
                
            }

        }
       
        public void Load(SqlConnection con)
        {
            try
            {
                Connection = con;
                objDepartmentDL = new Department_DL(Connection);
                objDivisionDL = new Division_DL(Connection);
                objSectionDL = new Section_DL(Connection);
                bindDivision.DataSource = objDivisionDL.GetDataView();
                cmbDivision.DataSource = bindDivision;

            }
            catch (Exception)
            {

                MessageBox.Show(this,"Error Loading while loading","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void cmbDivision_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbDivision.Items.Count > 0)
                {
                    long ID = Convert.ToInt64(cmbDivision.SelectedValue);
                    bindDepartment.DataSource = objDepartmentDL.GetDataView(ID);
                    cmDepartment.DataSource = bindDepartment;
                }
            }
            catch (Exception)
            {

                MessageBox.Show(this, "Error Loading while loading", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cmDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmDepartment.Items.Count > 0)
                {
                    long ID = Convert.ToInt64(cmDepartment.SelectedValue);
                    bindSection.DataSource = objSectionDL.GetDataView(ID);
                    cmbSection.DataSource = bindSection;
                }
            }
            catch (Exception)
            {

                MessageBox.Show(this, "Error Loading while loading", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cmbSection_SelectedIndexChanged(object sender, EventArgs e)
        {
            OnSectionSelectedIndexChanged(e);
        }

        public delegate void SectionSelectedIndexChangedHandler(object sender, EventArgs e);
        [Category("Options"), Browsable(true), Description("Event associate with the Section drop down list")]
        public event SectionSelectedIndexChangedHandler SectionSelectedIndexChanged;

        protected virtual void OnSectionSelectedIndexChanged(EventArgs e)
        {
            if (SectionSelectedIndexChanged != null)
            {
                SectionSelectedIndexChanged(this, e);
            }
        }



    }
}
