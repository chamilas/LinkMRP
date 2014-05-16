using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DL;
using SESD.MRP.REF;
using System.Data.SqlClient;

namespace MRP_GUI
{
    public partial class frmRPDBatchEditMode : System.Windows.Forms.Form
    {
        private Material_DL objMaterialDL = new Material_DL(ConnectionStringClass.GetConnection());
        private Store_DL objStoreDL = new Store_DL(ConnectionStringClass.GetConnection());
        GRN_DL objGRN_DL = new GRN_DL(ConnectionStringClass.GetConnection());
        private Employee_DL objEmployeeDL = new Employee_DL(ConnectionStringClass.GetConnection());
        private MachineActivity_DL objMachineActivityDL = new MachineActivity_DL(ConnectionStringClass.GetConnection());
        private Department_DL objDepartmentDL = new Department_DL(ConnectionStringClass.GetConnection());
        private PRPDBatch_DL objPRPDBatchDL = new PRPDBatch_DL(ConnectionStringClass.GetConnection());
        private RPDBatch_DL objRPDBatchDL = new RPDBatch_DL(ConnectionStringClass.GetConnection());
        private Machine_DL objMachineDL = new Machine_DL(ConnectionStringClass.GetConnection());
        private MainActivity_DL objMainActivityDL = new MainActivity_DL(ConnectionStringClass.GetConnection());
        private RPDBatchActivityInstructions_DL objRPDBatchActivityInstructionsDL = new RPDBatchActivityInstructions_DL(ConnectionStringClass.GetConnection());
        private RPDBatchActivityInstructionsCollec objBatchActivityInstructionsCollec = new RPDBatchActivityInstructionsCollec(); 
        private User _CurrentUser;
        private String BatchType = "Normal";
        private long InstructionID = 0;
        private RPDBatchProduction objRPDBatchProduction = null;
        private RPDBatchProduction_DL objRPDBatchProductionDL = new RPDBatchProduction_DL(ConnectionStringClass.GetConnection());

        public User CurrentUser
        {
            get { return _CurrentUser; }
            set { _CurrentUser = value; }
        }

        
        private RPDBatch objRPDBatch = new RPDBatch();

        

        public frmRPDBatchEditMode(User objUser, RPDBatch obj)
        {
            InitializeComponent();
            CurrentUser = objUser;
            objRPDBatch = obj;
        }



        private void frmRPDBatchInitialize_Load(object sender, EventArgs e)
        {
            
            try
            {
                Department objDep = objDepartmentDL.GetByDepType("RPD");
                Department objStoreDep = objDepartmentDL.GetByDepType("Store");
                
                cmbActivityInstructions.DataSource = objMainActivityDL.GetByDepID(objDep.DepID);


                    txtQtyBasic.Text = objRPDBatch.RPDBatchQty.ToString();
                    lblID.Text = objRPDBatch.RPDBatchID;
                    txtMateral.Text = objRPDBatch.RPDBatchMaterial.MaterialCode + " - " + objRPDBatch.RPDBatchMaterial.MaterialDescription;

                    if (objRPDBatch.RPDBatchID != null)
                    {
                        dgvActivityInstructions.AutoGenerateColumns = false;
                        bindInstructions.DataSource = objRPDBatchActivityInstructionsDL.GetDataView(objRPDBatch.RPDBatchID);
                        dgvActivityInstructions.DataSource = bindInstructions;
                        bindInstructions.ResetBindings(true);

                        gvProduction.AutoGenerateColumns = false;
                        bindProduction.DataSource = objRPDBatchProductionDL.GetDataByBatchID(objRPDBatch.RPDBatchID);
                        gvProduction.DataSource = bindProduction;
                        bindProduction.ResetBindings(true);

                    }

                    bindMaterial_Inter.DataSource = objMaterialDL.GetDataViewIntermediates(objRPDBatch.RPDBatchMaterial.MaterialCode);
                    cmbMaterialInter.DataSource = bindMaterial_Inter;


            }
            catch (Exception)
            {

                MessageBox.Show(this,"Error occcured while loading","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }



        private void cmbActivityInstructions_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbActivityInstructions.SelectedValue != null)
                {
                    DataTable dt = new DataTable();

                   dt  = objMachineDL.GetDataView_By_Activity(Convert.ToInt64(cmbActivityInstructions.SelectedValue));

                   bindMachine.DataSource = dt;
                   cmbMachine.DataSource = bindMachine;

                }
            }
            catch (Exception)
            {

                MessageBox.Show(this,"Error occured while loading Machines","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }


      
        private void btnAddInstructions_Click(object sender, EventArgs e)
        {
            try
            {

                if (cmbMachine.SelectedValue != null && cmbActivityInstructions.SelectedValue != null)
                {
                    RPDBatchActivityInstructions obj = new RPDBatchActivityInstructions();
                    obj.Activity = objMainActivityDL.Get(Convert.ToInt64(cmbActivityInstructions.SelectedValue));
                    obj.Description = txtDescription.Text;
                    obj.ID = InstructionID;
                    obj.Machine = objMachineDL.Get(cmbMachine.SelectedValue.ToString());
                    obj.ParticleSize = txtParticleSize.Text;
                    obj.RPDBatch = objRPDBatch;
                    obj.Type = "";
                    long NewID = objRPDBatchActivityInstructionsDL.Add(obj);

                    if (NewID > 0)
                    {
                        dgvActivityInstructions.AutoGenerateColumns = false;
                        bindInstructions.DataSource = objRPDBatchActivityInstructionsDL.GetDataView(objRPDBatch.RPDBatchID);
                        dgvActivityInstructions.DataSource = bindInstructions;
                        bindInstructions.ResetBindings(true);

                        ClearInstructionForm();
                    }
                    
                }
            }
            catch (Exception)
            {

                MessageBox.Show(this,"Error occured while saving Instruction","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void ClearInstructionForm()
        {

            cmbActivityInstructions.SelectedIndex = -1;
            cmbMachine.SelectedIndex = -1;
            txtDescription.Text = "";
            InstructionID = 0;
            txtParticleSize.Text = "";
            btnDeleteInstruction.Enabled = false;
        }

        private void dgvActivityInstructions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    long ID = Convert.ToInt64(dgvActivityInstructions.Rows[e.RowIndex].Cells["RPDBatchActivityInstructionsID"].Value);

                    RPDBatchActivityInstructions obj = objRPDBatchActivityInstructionsDL.Get(ID);
                    if (obj!=null)
                    {
                        cmbActivityInstructions.SelectedValue = obj.Activity.MainActID;
                        if (cmbMachine.Items.Count > 0)
                        {
                             cmbMachine.SelectedValue = obj.Machine.MachineCode;
                             txtDescription.Text = obj.Description;
                             txtParticleSize.Text = obj.ParticleSize;
                             InstructionID = obj.ID;
                             btnDeleteInstruction.Enabled = true;
                        }
                        
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(this,"Error occured while loading","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDeleteInstruction_Click(object sender, EventArgs e)
        {
            try
            {
                if (InstructionID > 0)
                {
                     DialogResult dr = MessageBox.Show(this,"Are you sure you want to delete selected Instruction?\n\nClick Yes to delete","Confirm Delete",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2);

                    if (dr == DialogResult.Yes)
                    {
                        int res = objRPDBatchActivityInstructionsDL.Delete(InstructionID);
                        if (res > 0)
                        {
                            bindInstructions.DataSource = objRPDBatchActivityInstructionsDL.GetDataView(objRPDBatch.RPDBatchID);
                            ClearInstructionForm();
                        }
                    }
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(this,"Error occured while deleting Instruction","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void btnClearInstruction_Click(object sender, EventArgs e)
        {
            ClearInstructionForm();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            RPD.frmRPDBatchManage obj = new MRP_GUI.RPD.frmRPDBatchManage(CurrentUser);
            obj.Show();
        }

        private void btnMaterialClear_Click(object sender, EventArgs e)
        {
            ClearProduction();

        }

        private void ClearProduction()
        {
            if (cmbMaterialInter.Items.Count > 0)
            {
                cmbMaterialInter.SelectedIndex = 0;
            }
            txtMaterialQty.Text = "0.00";
            objRPDBatchProduction = null;
            btnMaterialDelete.Enabled = false;
        }

        private void gvProduction_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                String Material = (gvProduction.Rows[e.RowIndex].Cells["MaterialCode"].Value.ToString());

                objRPDBatchProduction = objRPDBatchProductionDL.Get(objRPDBatch.RPDBatchID, Material);
                txtMaterialQty.Text = objRPDBatchProduction.MaterialQuantity.ToString();
                cmbMaterialInter.SelectedValue = objRPDBatchProduction.Material.MaterialCode;
                btnMaterialDelete.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show(this,"Error occured while selecting record","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void btnAddMaterial_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDecimal(txtMaterialQty.Text) <= 0)
                {
                    MessageBox.Show(this, "Invalid Quantity", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    String OriginalMaterilCode = "";
                    if (objRPDBatchProduction != null)
                    {
                        OriginalMaterilCode = objRPDBatchProduction.Material.MaterialCode;
                    }
                    else
                    {
                        objRPDBatchProduction = new RPDBatchProduction();
                    }
                    objRPDBatchProduction.Material = objMaterialDL.Get(cmbMaterialInter.SelectedValue.ToString());
                    objRPDBatchProduction.MaterialQuantity = Convert.ToDecimal(txtMaterialQty.Text);
                    objRPDBatchProduction.RPDBatch = objRPDBatch;
                    int res = objRPDBatchProductionDL.Add(objRPDBatchProduction, OriginalMaterilCode);
                    if (res > 0)
                    {
                        ClearProduction();

                        gvProduction.AutoGenerateColumns = false;
                        bindProduction.DataSource = objRPDBatchProductionDL.GetDataByBatchID(objRPDBatch.RPDBatchID);
                        gvProduction.DataSource = bindProduction;
                        bindProduction.ResetBindings(true);
                    }
                }
            }
            catch (SqlException sqlex)
            {
                if (sqlex.Number == 2627)
                {
                    MessageBox.Show(this,"Selected material already added","Duplicate Data",MessageBoxButtons.OK,MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show(this,"SQL error occured","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {
                MessageBox.Show(this, "Error occured while saving production details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnMaterialDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show(this,"Are you sure you want to delete selected record?\n\nClick Yes to delete","Confirm Delete",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.Yes)
                {
                    int res = objRPDBatchProductionDL.Delete(objRPDBatchProduction.RPDBatch.RPDBatchID,objRPDBatchProduction.Material.MaterialCode);
                    if (res > 0)
                    {
                        bindProduction.DataSource = objRPDBatchProductionDL.GetDataByBatchID(objRPDBatch.RPDBatchID);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show(this, "Error occured while deleting production details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if ((objRPDBatch.RPDBatchMR.MRNO ==0) | (objRPDBatch.RPDBatchMR.MRStatus == MR.Status.Initial) | (objRPDBatch.RPDBatchMR.MRStatus == MR.Status.Reject))
                {
                objRPDBatch.RPDBatchQty = Convert.ToDecimal(txtQtyBasic.Text);
                objRPDBatch.RPDBatchInstructedBy = CurrentUser.UserEmp;
                if (objRPDBatch.RPDBatchQty <= 0)
                {
                    MessageBox.Show(this, "Invalid Quantity", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    int x= objRPDBatchDL.Update_BatchSize(objRPDBatch);

                    if (x>0)
                    {
                        txtQtyBasic.ReadOnly = true;
                        grpInstructions.Enabled = true;
                        grpProduction.Enabled = true;

                        objRPDBatch = objRPDBatchDL.Get(objRPDBatch.RPDBatchID);

                        MessageBox.Show(this, "Successfully Edited", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        pnlBatchDetails.Enabled = false;
                        grpInstructions.Enabled = true;
                        grpProduction.Enabled = true;

                    }
                }
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDeleteBatch_Click(object sender, EventArgs e)
        {

        }


    }
}