using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DL;
using SESD.MRP.REF;
using SESD.MRP.BL;

namespace MRP_GUI
{
    public partial class frmSystemMgt : System.Windows.Forms.Form
    {
        public frmSystemMgt()
        {
            InitializeComponent();
        }

        //--------------- Form variables ------------------------
        private bool DepSelect = false;
        private Department objDepartment = new Department();
        private Department_DL objDepDL = new Department_DL(ConnectionStringClass.GetConnection());
        private Employee_DL objEmpDL = new Employee_DL(ConnectionStringClass.GetConnection());

        private bool StoreSelect = false;
        private Store objStore = new Store();
        private Store_DL objStoreDL = new Store_DL(ConnectionStringClass.GetConnection());

        private UserRole_DL objUserRoleDL = new UserRole_DL(ConnectionStringClass.GetConnection());
        private bool UserSelect = false;
        private User objUser = new User();
        private Division_DL objDivisionDL = new Division_DL(ConnectionStringClass.GetConnection());

        //-------------- Department Methods ---------------------

        public void LoadDepartment()
        {
            try
            {

                bindDivisions.DataSource = objDivisionDL.GetDataView();
                cmbDivision.DataSource = bindDivisions;
               cmbDepHead.DataSource = objEmpDL.Get_By_RoleType("Workforce",false);

            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }

        public void LoadStore()
        {
            try
            {
                cmbDepartment.DataSource = objDepDL.Get();
                cmbStoreKeeper.DataSource = objEmpDL.Get();
                bindStoreList.DataSource = objStoreDL.Get();
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                    
        }

        public void ClearDepartment()
        {
            txtDepartmentDescription.Text = "";
            txtDepartmentName.Text = "";
            cmbDepHead.SelectedIndex = 0;
            txtID.Text = "[Auto]";
            rbOther.Checked = true;
            this.DepSelect = false;
        }

        public void ClearStore()
        {
            txtStoreName.Text = "";
            txtStoreID.Text = "";
            txtStoreDesc.Text = "";
            StoreSelect = false;
        }

        public void LoadUser()
        {
            Employee_DL objEmpDL = new Employee_DL(ConnectionStringClass.GetConnection());
            User_DL objUserDL = new User_DL(ConnectionStringClass.GetConnection());
            try
            {
                cmbEmp.DataSource = objEmpDL.Get();
                bindUserList.DataSource = objUserDL.Get();
                cmbUserRole.DataSource = objUserRoleDL.GetDataview();
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ClearUser()
        {
            txtUserName.Text = "";
            if (cmbEmp.Items.Count > 0)
            {
                cmbEmp.SelectedIndex = 0;
            }
            cbUser.Checked = false;
            UserSelect = false;
            txtUserName.ReadOnly = false;
            cmbEmp.Enabled = true;
            btnClearPassword.Enabled = false;

        }


        private void frmSystemMgt_Load(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tbDepartment)
            {
                LoadDepartment();
            }
            else if (tabControl1.SelectedTab == tbUser)
            {
                LoadUser();
            }
            else if (tabControl1.SelectedTab == tbStores)
            {
                LoadStore();
            }
            else if (tabControl1.SelectedTab == tbDivision)
            {
                ucDivision1.Load(ConnectionStringClass.GetConnection());

            }
            else if (tabControl1.SelectedTab == tbSection)
            {
                ucSection1.Load(ConnectionStringClass.GetConnection());

            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbDivision.SelectedValue != null)
            {


                if (txtDepartmentDescription.Text.Equals("") || txtDepartmentName.Text.Equals(""))
                {
                    MessageBox.Show(this, "Please Fill all Fields", "Blank Fields", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {

                    try
                    {
                        long ID = 0;
                        if (!txtID.Text.Equals("[Auto]"))
                        {
                            ID = Convert.ToInt64(txtID.Text);
                        }


                        objDepartment.DepID = ID;

                        objDepartment.DepDescription = txtDepartmentDescription.Text;
                        objDepartment.DepHead = objEmpDL.Get(cmbDepHead.SelectedValue.ToString());
                        objDepartment.DepName = txtDepartmentName.Text;

                        long DivisionID = Convert.ToInt64(cmbDivision.SelectedValue);
                        objDepartment.DivisionID = DivisionID;
                        

                        if (rbOther.Checked)
                        {
                            objDepartment.DepType = "OTHER";
                        }

                        if (rbSales.Checked)
                        {
                            objDepartment.DepType = "LAB";
                        }

                        if (rbStores.Checked)
                        {
                            objDepartment.DepType = Department.Type.STORE.ToString();
                        }
                        if (rbPRPD.Checked)
                        {
                            objDepartment.DepType = Department.Type.PRPD.ToString();
                        }
                        if (rbRPD.Checked)
                        {
                            objDepartment.DepType = Department.Type.RPD.ToString();
                        }
                        if (rbAgri.Checked)
                        {
                            objDepartment.DepType = Department.Type.AGRI.ToString();
                        }
                        if (rbSupply.Checked)
                        {
                            objDepartment.DepType = Department.Type.SUPPLY.ToString();
                        } if (rbProduction.Checked)
                        {
                            objDepartment.DepType = Department.Type.PRODUCTION.ToString();
                        }



                        long NewID = objDepDL.Add_New(objDepartment);
                        if (NewID > 0)
                        {
                            ClearDepartment();
                            bindDep.DataSource = objDepDL.GetDataView(DivisionID);
                            MessageBox.Show(this, "Succesfully Added to Database", "Succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            
                        }

                        //int x = 0;

                        //if (this.DepSelect)
                        //{
                        //    // x = objDepDL.Update(objDepartment);



                        //    if (x > 0)
                        //    {
                        //        ClearDepartment();
                        //        bindDep.DataSource = objDepDL.GetDataView();
                        //        MessageBox.Show(this, "Succesfully Updated the Database", "Succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //    }

                        //}
                        //else
                        //{
                        //    x = objDepDL.Add(objDepartment);


                        //    if (x > 0)
                        //    {
                        //        ClearDepartment();
                        //        bindDep.DataSource = objDepDL.GetDataView();
                        //        MessageBox.Show(this, "Succesfully Added to Database", "Succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //    }


                        //}



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
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearDepartment();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.DepSelect)
            {
                DialogResult dr = MessageBox.Show(this, "Are you sure, You want to Delete selected Record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    try
                    {

                        int x = objDepDL.Delete(objDepartment.DepID);
                        
                        if (x > 0)
                        {
                            bindDep.DataSource = objDepDL.GetDataView();
                            MessageBox.Show(this, "Succesfully Deleted From Database", "Succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearDepartment();
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

        private void gvDepartment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try

            {
                if (e.RowIndex >= 0)
                {

                    objDepartment = objDepDL.Get(Convert.ToInt64(gvDepartment.Rows[e.RowIndex].Cells["ColDepID"].Value));
                    if (objDepartment.DepType.Equals("STORE"))
                    {
                        rbStores.Checked = true;
                    }
                    else if (objDepartment.DepType.Equals("SALES"))
                    {
                        rbSales.Checked = true;

                    }
                    else if (objDepartment.DepType.Equals("RPD"))
                    {
                        rbRPD.Checked = true;
                    }
                    else if (objDepartment.DepType.Equals("PRPD"))
                    {
                        rbPRPD.Checked = true;
                    }
                    else if (objDepartment.DepType.Equals("AGRI"))
                    {
                        rbAgri.Checked = true;
                    }
                    else if (objDepartment.DepType.Equals("SUPPLY"))
                    {
                        rbSupply.Checked = true;
                    }
                    else if (objDepartment.DepType.Equals("LAB"))
                    {
                        rbSales.Checked = true;
                    }
                    else
                    {
                        rbOther.Checked = true;
                    }

                    this.DepSelect = true;

                    txtDepartmentDescription.Text = objDepartment.DepDescription;
                    txtDepartmentName.Text = objDepartment.DepName;
                    if (objDepartment.DepHead.EmployeeID != null)
                    {
                        cmbDepHead.SelectedValue = objDepartment.DepHead.EmployeeID;
                    }

                    txtID.Text = objDepartment.DepID.ToString();
                }
                
                
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tbDepartment)
            {
                LoadDepartment();
            }
            else if (tabControl1.SelectedTab == tbUser)
            {
                LoadUser();
            }
            else if (tabControl1.SelectedTab == tbStores)
            {
                LoadStore();
            }
            else if (tabControl1.SelectedTab == tbDivision)
            {
                ucDivision1.Load(ConnectionStringClass.GetConnection());

            }
            else if (tabControl1.SelectedTab == tbSection)
            {
                ucSection1.Load(ConnectionStringClass.GetConnection());

            }
        }

        private void btnStoreSave_Click(object sender, EventArgs e)
        {
            try
            {
                Store objStoreTemp = new Store();
                Department objDep = (Department)cmbDepartment.SelectedItem;
                Employee objSK = (Employee)cmbStoreKeeper.SelectedItem;
                objStoreTemp.StoreDepartment = objDep;
                objStoreTemp.StoreDescription = txtStoreDesc.Text;
                objStoreTemp.StoreID = txtStoreID.Text;
                objStoreTemp.StoreKeeper = objSK;
                objStoreTemp.StoreName = txtStoreName.Text;

                if (this.StoreSelect) 
                {
                    int x = objStoreDL.Update(objStoreTemp,objStore.StoreID);
                    if (x > 0)
                    {
                        MessageBox.Show(this, "Succesfully Updated to Database", "Succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadStore();
                        ClearStore();

                    }
                    else
                    {
                        MessageBox.Show(this, "Store ID is already in the Database, Please add another Store ID", "Store ID in Database", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    } 
                }
                else
                {
                    int x = objStoreDL.Add(objStoreTemp);
                    if (x > 0)
                    {
                        MessageBox.Show(this, "Succesfully Added to Database", "Succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadStore();
                        ClearStore();

                    }
                    else
                    {
                        MessageBox.Show(this, "Store ID is already in the Database, Please add another Store ID", "Store ID in Database", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    } 
                }
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                objStore =(Store) dataGridView1.Rows[e.RowIndex].DataBoundItem;
                this.StoreSelect = true;

                txtStoreDesc.Text = objStore.StoreDescription;
                txtStoreID.Text = objStore.StoreID;
                txtStoreName.Text = objStore.StoreName;
                cmbDepartment.SelectedValue = objStore.StoreDepartment.DepID;
                cmbStoreKeeper.SelectedValue = objStore.StoreKeeper.EmployeeID;
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnStoreClear_Click(object sender, EventArgs e)
        {
            LoadStore();
            ClearStore();
        }

        private void btnStoreDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.StoreSelect)
                {
                    int x = objStoreDL.Delete(objStore.StoreID);
                    if (x > 0)
                    {
                        MessageBox.Show(this, "Succesfully Deleted from Database", "Succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadStore();
                        ClearStore();

                    }

                }
                else
                {
                    MessageBox.Show(this, "Select a Record from the List", "Select a Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {

                MessageBox.Show(this,"Error occured while deleting","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void btnUserSave_Click(object sender, EventArgs e)
        {
            
            User_DL objUserDL = new User_DL(ConnectionStringClass.GetConnection());
            User_BL objUserBL = new User_BL(ConnectionStringClass.GetConnection());
            Employee objEmployee = new Employee();
            objEmployee = (Employee)cmbEmp.SelectedItem;
            try
            {
                objUser.UserName = txtUserName.Text;
                objUser.UserStatus = cbUser.Checked;
                objUser.UserRoleID = Convert.ToInt64(cmbUserRole.SelectedValue);
                if (this.UserSelect)
                {
                    int x = objUserBL.Update(objUser);
                    if (x == -1)
                    {
                        MessageBox.Show(this, "User Name is already in the database,Please enter another User Name", "User Name invalid", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (x == -2)
                    {
                        MessageBox.Show(this, "Selected Employee already has an Account ", "Already has Account", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (x == 1)
                    {
                        MessageBox.Show(this, "Successfully Saved", "Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        bindUserList.DataSource = objUserDL.Get();
                        ClearUser();
                    }
                }
                else
                {
                    objUser.UserPassword = txtUserName.Text;
                    objUser.UserEmp = objEmployee;
                    objUser.UserQuestion = "N/A";
                    objUser.UserAnswer = "N/A";
                    objUser.UserRoleID = Convert.ToInt64(cmbUserRole.SelectedValue);

                    int x = objUserBL.Add(objUser);
                    if (x == -1)
                    {
                        MessageBox.Show(this, "User Name is already in the database,Please enter another User Name", "User Name invalid", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (x == -2)
                    {
                        MessageBox.Show(this, "Selected Employee already has an Account ", "Already has Account", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (x == 1)
                    {
                        MessageBox.Show(this, "Successfully Saved", "Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        bindUserList.DataSource = objUserDL.Get();
                        ClearUser();
                    }
                }
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                objUserBL = null;
                objUserDL = null;
            }
        }

        private void gvUserList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
              objUser = (User)gvUserList.Rows[e.RowIndex].DataBoundItem;
                txtUserName.Text = objUser.UserName;
                cbUser.Checked = objUser.UserStatus;
                cmbEmp.SelectedValue = objUser.UserEmp.EmployeeID;
                cmbUserRole.SelectedValue = objUser.UserRoleID;
                this.UserSelect = true;
                txtUserName.ReadOnly = true;
                cmbEmp.Enabled = false;
                btnClearPassword.Enabled = true;
            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUserClear_Click(object sender, EventArgs e)
        {
            ClearUser();
        }

        private void btnUserDelete_Click(object sender, EventArgs e)
        {                
            User_BL objUserBL = new User_BL(ConnectionStringClass.GetConnection());
                
            User_DL objUserDL = new User_DL(ConnectionStringClass.GetConnection());
            try
            {

                if (this.UserSelect)
                {
                    DialogResult dr = MessageBox.Show(this, "Are you sure you want to delete Selected User? Click Yes to Delete", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                       int x= objUserBL.Delete(objUser.UserID);

                       if (x > 0)
                       {
                           MessageBox.Show(this, "User Deleted Successfully", "Successful", MessageBoxButtons.OK);
                           bindUserList.DataSource = objUserDL.Get();

                       }
                       else
                       {
                           MessageBox.Show(this, "This User Cann't be deleted", "UnSuccessful", MessageBoxButtons.OK);
                       }
                        ClearUser();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                objUserBL = null;
                objUserDL = null;
            }
        }

        private void btnClearPassword_Click(object sender, EventArgs e)
        {
            User_DL objUserDL = new User_DL(ConnectionStringClass.GetConnection());
            User_BL objUserBL = new User_BL(ConnectionStringClass.GetConnection());
            Employee objEmployee = new Employee();
            objEmployee = (Employee)cmbEmp.SelectedItem;
            try
            {

                if (this.UserSelect)
                {
                    int x = objUserBL.Clear_Password(objUser);
                    if (x == -1)
                    {
                        MessageBox.Show(this, "User Name is already in the database,Please enter another User Name", "User Name invalid", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (x == -2)
                    {
                        MessageBox.Show(this, "Selected Employee already has an Account ", "Already has Account", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (x == 1)
                    {
                        MessageBox.Show(this, "Successfully Saved", "Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        bindUserList.DataSource = objUserDL.Get();
                        ClearUser();
                    }
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                objUserBL = null;
                objUserDL = null;
            }
        }

        private void rbSales_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cmbDepartmentList_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            try
            {
                if (cmbDepartmentList.Items.Count > 0)
                {
                    bindDepStores.DataSource = objStoreDL.Get(Convert.ToInt64(cmbDepartmentList.SelectedValue));
                    cmbDepartmenttores.DataSource = bindDepStores;

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(this,"Error occured while loading Stores","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void btnSaveDefault_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbDepartmentList.Items.Count >0 && cmbDepartmenttores.Items.Count > 0)
                {
                    DialogResult dr = MessageBox.Show(this,"Are you sure you want to change default store?","Confirm",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2);
                    if (dr == DialogResult.Yes)
                    {
                        int res = objStoreDL.SetDefault(cmbDepartmenttores.SelectedValue.ToString(), Convert.ToInt64(cmbDepartmentList.SelectedValue));
                        if (res > 0)
                        {
                            MessageBox.Show(this, "Successfully changed the default store", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show(this, "Error occured while saving default Stores", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        }
                    }
                }
                else
                {
                    MessageBox.Show(this,"Please select a department and a Store","Empty List",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {
                    
                MessageBox.Show(this,"Error occured while saving default Stores","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
               
            }
        }

        private void cmbDivision_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDivision.Items.Count > 0)
            {
                long DivisionID = Convert.ToInt64(cmbDivision.SelectedValue);
                bindDep.DataSource = objDepDL.GetDataView(DivisionID);
                cmbDepartmentList.DataSource = bindDep;
                

            }
        }

        private void rbSupply_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbOther_CheckedChanged(object sender, EventArgs e)
        {

        }




    }
}