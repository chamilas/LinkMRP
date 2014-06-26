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
    public partial class ucEmployee : UserControl
    {
        public ucEmployee()
        {
            InitializeComponent();



        }
        //------------------- Form Variables -------------------
        private bool EmployeeSelect = false;

        private Employee objEmp = new Employee();


        private DataTable dtDepEmployee = new DataTable();
        private DataTable dtDep = new DataTable();
        private String OriginalEmpID = "";
        private DepartmentCollec objDepartmentComboList = new DepartmentCollec();
        private DepartmentEmployeeCollec objDepEmpDeletedCollec = new DepartmentEmployeeCollec();




        private Department_DL objDepDL ;
        private EmployeeRole_DL objEmpRoleDL ;
        private Employee_DL objEmpDL ;
        private Section_DL objSectionDL;

        public void Initialize(SqlConnection Conn)
        {
            objDepDL = new Department_DL(Conn);
            objEmpRoleDL = new EmployeeRole_DL(Conn);
            objEmpDL = new Employee_DL(Conn);
            objSectionDL = new Section_DL(Conn);
            ucSectionFilter1.Load(Conn);
        }

       

        //------------------- Form Methods ---------------------
        public void LoadEmployee()
        {
            
        }

        public void EmployeeLoad()
        {
            try
            {
                bindEmployee.DataSource = objEmpDL.GetDataView_All();
                cmbEmployeeRole.DataSource = objEmpRoleDL.GetDataView();
                cmbEmpTYpe.SelectedIndex = 0;
                
                

            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        public void ClearEmployee()
        {
            txtEmployeeID.Text = "";
            txtName.Text = "";
            cbStatus.Checked = true;
            cmbEmployeeRole.SelectedIndex = 0;
            txtOTRate.Text = "0.00";
            txtRate.Text = "0.00";
            cmbEmpTYpe.SelectedIndex = 0;
            this.EmployeeSelect = false;
        }

   

        private void ucEmployee_Load(object sender, EventArgs e)
        {
            LoadEmployee();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtEmployeeID.Text.Equals("") || txtName.Text.Equals("") || txtRate.Text.Equals("") || txtOTRate.Text.Equals(""))
            {
                MessageBox.Show(this, "Please Fill all Fields", "Blank Fields", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {

                try
                {
                    long? SectionID = null;
                    objEmp.EmployeeID = txtEmployeeID.Text;
                    objEmp.EmployeeName = txtName.Text;
                    objEmp.EmployeeRole = objEmpRoleDL.Get(Convert.ToInt64(cmbEmployeeRole.SelectedValue));
                    if (objEmp.EmployeeRole.Type.Equals("Workforce"))
                    {
                        SectionID = ucSectionFilter1.Section.SectionID;
                    }
                    objEmp.Section = SectionID;
                    objEmp.EmpStatus = cbStatus.Checked;
                    objEmp.EmpType = cmbEmpTYpe.SelectedItem.ToString();
                    objEmp.OTRatePerHour = Convert.ToDecimal("0.00");
                    objEmp.RatePerHour = Convert.ToDecimal("0.00");
                    
                    int x;

                    if (this.EmployeeSelect)
                    {
                        if (objEmp.EmployeeRole.Type.Equals("Workforce"))
                        {
                            x = objEmpDL.Update(objEmp);
                        }
                        else
                        {
                            x = objEmpDL.Update_Staff(objEmp, OriginalEmpID);
                        }
                        
                      

                        if (x > 0)
                        {
                            bindEmployee.DataSource = objEmpDL.GetDataView_All();
                         
                            MessageBox.Show(this, "Succesfully Updated the Database", "Succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            int counter = 0;
                            foreach (DataGridViewRow var in gvEmployee.Rows)
                            {
                                if (var.Cells["ColEmpID"].Value.Equals(objEmp.EmployeeID))
                                {

                                    gvEmployee.CurrentCell = gvEmployee[1, counter];
                                    gvEmployee.FirstDisplayedScrollingRowIndex = counter;

                                    break;
                                }
                                counter++;
                            }
                            
                            this.ClearEmployee();
                         
                        }
                    }
                    else
                    {
                        if (objEmp.EmployeeRole.Type.Equals("Workforce"))
                        {
                            x = objEmpDL.Add(objEmp);
                        }
                        else
                        {
                            x = objEmpDL.Add_Staff(objEmp);
                        }
                      
                        if (x > 0)
                        {
                            DialogResult dr;
                            bindEmployee.DataSource = objEmpDL.GetDataView();
                            dr = MessageBox.Show(this, "Succesfully Added to Database", "Succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            int counter = 0;
                            
                            foreach (DataGridViewRow var in gvEmployee.Rows)
                            {
                                if (var.Cells["ColEmpID"].Value.Equals(objEmp.EmployeeID))
                                {

                                    gvEmployee.CurrentCell = gvEmployee[1, counter];
                                    gvEmployee.FirstDisplayedScrollingRowIndex = counter;

                                    break;
                                }
                                counter++;
                            }
                            this.ClearEmployee();
                        }
                        else if (x == -1)
                        {
                            MessageBox.Show(this, "Employee ID already in the Database,Please enter another Employee ID", "Problem with Employee ID", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                finally
                {


                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.EmployeeSelect)
            {
                DialogResult dr = MessageBox.Show(this, "Are you sure, You want to Delete selected Record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {


                    try
                    {

                        int x = objEmpDL.Delete(OriginalEmpID);

                        bindEmployee.DataSource = objEmpDL.GetDataView_All();

                        if (x > 0)
                        {
                            
                            MessageBox.Show(this, "Succesfully Deleted From Database", "Succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearEmployee();
                    
                        }

                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                }
            }
            else
            {
                MessageBox.Show(this, "Select a Record from the List", "Select a Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearEmployee();
          
        }

        private void gvEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try

            {
                if (e.RowIndex >= 0)
                {


                    objEmp = objEmpDL.Get(gvEmployee.Rows[e.RowIndex].Cells["ColEmpID"].Value.ToString());
                    txtEmployeeID.Text = objEmp.EmployeeID;
                    txtName.Text = objEmp.EmployeeName;
                    cmbEmployeeRole.SelectedValue = objEmp.EmployeeRole.EmpRoleID;
                    cbStatus.Checked = objEmp.EmpStatus;

                    cmbEmpTYpe.SelectedItem = objEmp.EmpType;
                    txtRate.Text = objEmp.RatePerHour.ToString();
                    txtOTRate.Text = objEmp.OTRatePerHour.ToString();
                    ucSectionFilter1.Section = objSectionDL.Get(objEmp.Section.Value);
                    this.EmployeeSelect = true;
                    this.OriginalEmpID = objEmp.EmployeeID;

                }

            }
            catch (Exception ex)
            {
                
               MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 
            }
        }

                    
            
    

   

  



        private void groupBox7_Enter(object sender, EventArgs e)
        {

        }

        private void Rate_Keypress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar) || (e.KeyChar == (char)46)))
            {
                e.Handled = true;
            }
        }

        private void cmbEmployeeRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbEmployeeRole.Items.Count > 0)
                {
                    EmployeeRole objEmpRole = objEmpRoleDL.Get(Convert.ToInt64(cmbEmployeeRole.SelectedValue));
                    if (objEmpRole.Type.Equals("Workforce"))
                    {
                        ucSectionFilter1.Visible = true;
                    }
                    else
                    {
                        ucSectionFilter1.Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(this,"Error occured while loading","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }


    }
}
