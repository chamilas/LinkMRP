using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DL;
using SESD.MRP.REF;

namespace MRP_GUI.Components
{
    public partial class ucEmployeeSelect : UserControl
    {
        Section_DL objSectionDL;
        Employee_DL objEmployeeDL;
        public ucEmployeeSelect()
        {
            InitializeComponent();
        }
        private String EmployeeRole;
        private Employee _Emp;

        public Employee Employee
        {
            get 
            {
                if (cmbEmployee.SelectedValue != null)
                {
                    _Emp = objEmployeeDL.Get(cmbEmployee.SelectedValue.ToString());
                    return _Emp; 
                }
                return null; 
            }
            set 
            { 
                _Emp = value;
                if (cmbSection.Items.Count>0)
                {
                    cmbSection.SelectedValue = _Emp.Section;
                    if (cmbEmployee.Items.Count > 0)
                    {
                        cmbEmployee.SelectedValue = _Emp.EmployeeID;
                    }
                }
            }
        }

        public void Clear()
        {
            try
            {
                if (cmbEmployee.Items.Count > 0)
                {
                    cmbEmployee.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                    
                throw ex;
            }
        }
	

        private void ucEmployeeSelect_Load(object sender, EventArgs e)
        {
            

        }

        public void LoadForm(String EmpRole)
        {
            objSectionDL = new Section_DL(ConnectionStringClass.GetConnection());
            objEmployeeDL = new Employee_DL(ConnectionStringClass.GetConnection());
            cmbSection.DataSource = objSectionDL.GetDataView();
            EmployeeRole = EmpRole; 
        }

        public void LoadForm(String EmpRole,String DivisionType)
        {
            objSectionDL = new Section_DL(ConnectionStringClass.GetConnection());
            objEmployeeDL = new Employee_DL(ConnectionStringClass.GetConnection());
           // cmbSection.DataSource = objSectionDL.Get);
            cmbSection.DataSource = objSectionDL.GetData(DivisionType);
            EmployeeRole = EmpRole; 

        }

        public void SetDefault(long SectionID)
        {
            try
            {
                if (cmbSection.Items.Count > 0)
                {
                    cmbSection.SelectedValue = SectionID;
                }
            }
            catch (Exception ex)
            {
                    
                throw ex;
            }
        }

        private void cmbEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            OnEmployeeSelectedIndexChanged(e);
        }

        public delegate void EmployeeSelectedIndexChangedHandler(object sender, EventArgs e);
        [Category("Options"), Browsable(true), Description("Event associate with the Employee drop down list")]
        public event EmployeeSelectedIndexChangedHandler EmployeeSelectedIndexChanged;

        protected virtual void OnEmployeeSelectedIndexChanged(EventArgs e)
        {
            if (EmployeeSelectedIndexChanged != null)
            {
                EmployeeSelectedIndexChanged(this, e);
            }
        }

        private void cmbSection_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cmbEmployee.Enabled = false;
                if (cmbSection.Items.Count > 0 && cmbSection.SelectedValue != null)
                {
                    bindEmp.DataSource = objEmployeeDL.GetDataView_By_Section(EmployeeRole,Convert.ToInt64(cmbSection.SelectedValue),true);
                    cmbEmployee.DataSource = bindEmp;
                    if (cmbEmployee.Items.Count > 0)
                    {
                        cmbEmployee.Enabled = true;
                        OnEmployeeSelectedIndexChanged(e);
                    }

                }
                else
                {
                    bindEmp.DataSource= null;
                    
                }
            }
            catch (Exception)
            {

                MessageBox.Show(this,"Error occured while laoding Employees","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

    }
}
