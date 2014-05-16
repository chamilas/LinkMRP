using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DL;
using SESD.MRP.REF;

namespace MRP_GUI
{
    public partial class frmPRPDPreperationBatchManagement : System.Windows.Forms.Form
    {
        public frmPRPDPreperationBatchManagement()
        {
            InitializeComponent();
        }


        public frmPRPDPreperationBatchManagement(User objUser)
        {
            InitializeComponent();
            CurrentUser = objUser;
        }



        private User _CurrentUser;

        public User CurrentUser
        {
            get { return _CurrentUser; }
            set { _CurrentUser = value; }
        }



        PRPDBatch_DL objPRPDBatch_DL = new PRPDBatch_DL(ConnectionStringClass.GetConnection());
        MainActivity_DL objMainActivity_DL = new MainActivity_DL(ConnectionStringClass.GetConnection());
        Department_DL objDepartment_DL = new Department_DL(ConnectionStringClass.GetConnection());
        MachineActivity_DL objMachineActivity_DL = new MachineActivity_DL(ConnectionStringClass.GetConnection());
        Machine_DL objMachine_DL = new Machine_DL(ConnectionStringClass.GetConnection());
        Store_DL objStore_DL = new Store_DL(ConnectionStringClass.GetConnection());
        Employee_DL objEmployee_DL = new Employee_DL(ConnectionStringClass.GetConnection());

        DataTable dtStaff = new DataTable();
        DataTable dtPRPDBatches = new DataTable();
        DataTable dtPRPDBatchInstructions = new DataTable();
        QCReport_DL objQCReport_DL = new QCReport_DL(ConnectionStringClass.GetConnection());
        QCReport objQCReport = new QCReport();



        BindingSource objSourcePRPDBatches = new BindingSource();
       // BindingSource objSourceInstructions = new BindingSource();
        BindingSource objSourceStaff = new BindingSource();

        PRPDBatchActivityInstructions_DL objPRPDBatchActivityInstructions_DL = new PRPDBatchActivityInstructions_DL(ConnectionStringClass.GetConnection());
        PRPDBatch objPRPDBatch = new PRPDBatch();
        Store objStore;
        private void frmPRPDCAP_ReworkBatchManagement_Load(object sender, EventArgs e)
        {
            try
            {
                
                objStore = objStore_DL.Get_Default(objDepartment_DL.GetByDepType("Store").DepID);
                txtStore.Text = objStore.StoreName;

                cmbPRPDBatchStatus.DataSource = Enum.GetNames(typeof(PRPDBatch.PRPDBatchStatus));
                cmbStores.DataSource = objStore_DL.Get(objDepartment_DL.GetByDepType("Store").DepID);

                dtStaff = objEmployee_DL.Get_By_RoleType("Staff", true);

                objSourceStaff.DataSource = dtStaff;
                //cmbSupervisedBy.DataSource = objSourceStaff;


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());

            }
        }

        private void ManageButtons()
        {

            if (cmbPRPDBatchStatus.SelectedValue.ToString() == "Created")
            {
                btnEditMode.Enabled = true;
                //btnApprove.Enabled = true;
                pnlStore.Visible = true;

            }
            else if (cmbPRPDBatchStatus.SelectedValue.ToString() == "Approved")
            {
                btnEditMode.Enabled = true;
                btnApprove.Enabled = false;
                pnlStore.Visible = true;
                btnBatchDelete.Enabled = false;

            }
            else if (cmbPRPDBatchStatus.SelectedValue.ToString() == "Started")
            {
                btnEditMode.Enabled = true;
                btnApprove.Enabled = false;
                pnlStore.Visible = false;
                btnBatchDelete.Enabled = false;
            }
            else if (cmbPRPDBatchStatus.SelectedValue.ToString() == "Finished")
            {
                btnEditMode.Enabled = false;
                btnApprove.Enabled = false;
                pnlStore.Visible = false;
                btnBatchDelete.Enabled = false;
            }
            else
            {
                btnEditMode.Enabled = false;
                btnApprove.Enabled = false;
                pnlStore.Visible = false;
                btnBatchDelete.Enabled = false;
            }
        }

        private void cmbPRPDBatchStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            Load_Batch_List();

            if ((PRPDBatch.PRPDBatchStatus)Enum.Parse(typeof(PRPDBatch.PRPDBatchStatus), cmbPRPDBatchStatus.SelectedItem.ToString()) != PRPDBatch.PRPDBatchStatus.Created)
            {
                btnApprove.Enabled = false;
                btnEditMode.Enabled = false;
            }

        }

        private void Load_Batch_List()
        {
            ManageButtons();
            PRPDBatch.PRPDType theType;


            try
            {
                objSourceInstructions.DataSource = null;
                objSourcePRPDBatches.DataSource = null;
                PRPDBatch.PRPDBatchStatus state = (PRPDBatch.PRPDBatchStatus)Enum.Parse(typeof(PRPDBatch.PRPDBatchStatus), cmbPRPDBatchStatus.SelectedItem.ToString());
                if (rdbPP.Checked == true)
                {
                    theType = PRPDBatch.PRPDType.PrimaryPreperation;
                }
                else if (rdbPPRe.Checked == true)
                {
                    theType = PRPDBatch.PRPDType.PrimaryOutsource;
                }
                else
                {
                    theType = PRPDBatch.PRPDType.Rework;
                }
                dtPRPDBatches = objPRPDBatch_DL.GetDataByState_Type((PRPDBatch.PRPDBatchStatus)Enum.Parse(typeof(PRPDBatch.PRPDBatchStatus), cmbPRPDBatchStatus.SelectedValue.ToString()), theType);

                dgvPRPDbatchByState.AutoGenerateColumns = false;
                dgvPRPDbatchByState.DataSource = objSourcePRPDBatches;
                objSourcePRPDBatches.DataSource = dtPRPDBatches;
                objSourcePRPDBatches.ResetBindings(true);



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnEditMode_Click(object sender, EventArgs e)
        {
            if (btnEditMode.Text == "Edit Mode")
            {
                grpBatchInstructions.Enabled = true;
                btnEditMode.Text = "Normal Mode";
            }
            else
            {
                grpBatchInstructions.Enabled = false;
                btnEditMode.Text = "Edit Mode";
            }
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbActivity.SelectedValue == null)
                {
                    MessageBox.Show(this, "Please Fill All Fields", "Fill Records", MessageBoxButtons.OK);
                }
                else
                {
                    PRPDBatchActivityInstructions obj = new PRPDBatchActivityInstructions();

                    obj.Activity = objMainActivity_DL.Get(Convert.ToInt64(cmbActivity.SelectedValue));
                    if (cmbMachine.SelectedValue != null)
                    {
                        obj.Machine = objMachine_DL.Get(cmbMachine.SelectedValue.ToString());
                        obj.MachineCode = obj.Machine.MachineCode;
                    }
                    else
                    {
                        obj.MachineCode = "No Machine";
                    }
                    
                    obj.ParticleSize = "N/A";
                    if (txtInstruction.Text != "")
                    {
                        obj.InstructionDesc = txtInstruction.Text;
                    }
                    else
                    {
                        obj.InstructionDesc = "No";
                    }
                    obj.PRPDBatch = objPRPDBatch_DL.Get(txtPRPDBatch.Text);

                    objPRPDBatchActivityInstructions_DL.Add(obj);

                    dtPRPDBatchInstructions = objPRPDBatchActivityInstructions_DL.GetDataByBatchID(txtPRPDBatch.Text);

                    dgvActivityInstructions.AutoGenerateColumns = false;
                    dgvActivityInstructions.DataSource = objSourceInstructions;
                    objSourceInstructions.DataSource = dtPRPDBatchInstructions;
                    objSourceInstructions.ResetBindings(true);

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
               DialogResult Result = new DialogResult();

               Result=MessageBox.Show(this, "Are You Sure You Want to Delete the Selected Instructions ", "Delete Instructions", MessageBoxButtons.YesNo);

               if (Result == DialogResult.Yes)
               {
                PRPDBatchActivityInstructions obj = new PRPDBatchActivityInstructions();

                obj = objPRPDBatchActivityInstructions_DL.Get(Convert.ToInt64(dgvActivityInstructions.CurrentRow.Cells["colPRPDBatchActivityInstructionsID"].Value));

                objPRPDBatchActivityInstructions_DL.Delete(obj);

                dtPRPDBatchInstructions = objPRPDBatchActivityInstructions_DL.GetDataByBatchID(txtPRPDBatch.Text);

                dgvActivityInstructions.AutoGenerateColumns = false;
                dgvActivityInstructions.DataSource = objSourceInstructions;
                objSourceInstructions.DataSource = dtPRPDBatchInstructions;
                objSourceInstructions.ResetBindings(true);
                }
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
        
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {

                 DialogResult Result = new DialogResult();

                Result = MessageBox.Show(this, "Are You Sure You Want to Edit the Instruction", "Edit Instructions", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (Result == DialogResult.Yes)
                {

                    PRPDBatchActivityInstructions obj = new PRPDBatchActivityInstructions();

                    obj = objPRPDBatchActivityInstructions_DL.Get(Convert.ToInt64(dgvActivityInstructions.CurrentRow.Cells["colPRPDBatchActivityInstructionsID"].Value));

                    obj.Activity = objMainActivity_DL.Get(Convert.ToInt64(cmbActivity.SelectedValue));
                    obj.ParticleSize = "N/A";
                    obj.InstructionDesc = txtInstruction.Text;
                    obj.PRPDBatch = objPRPDBatch_DL.Get(txtPRPDBatch.Text);

                    if (cmbMachine.SelectedValue != null)
                    {
                        obj.Machine = objMachine_DL.Get(cmbMachine.SelectedValue.ToString());
                        objPRPDBatchActivityInstructions_DL.Update(obj);
                    }
                    else
                    {
                        obj.Machine = new Machine();
                        objPRPDBatchActivityInstructions_DL.Update_withoutMachine(obj);
                    }
                    
                   

                    

                    dtPRPDBatchInstructions = objPRPDBatchActivityInstructions_DL.GetDataByBatchID(txtPRPDBatch.Text);

                    dgvActivityInstructions.AutoGenerateColumns = false;
                    dgvActivityInstructions.DataSource = objSourceInstructions;
                    objSourceInstructions.DataSource = dtPRPDBatchInstructions;
                    objSourceInstructions.ResetBindings(true);

                    grpBatchInstructions.Enabled = false;
                    btnEditMode.Text = "Edit Mode";
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void dgvPRPDbatchByState_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {

                    objSourceInstructions.DataSource = null;
                    txtPRPDBatch.Text = dgvPRPDbatchByState.CurrentRow.Cells["PRPDBatchID"].Value.ToString();
                    objPRPDBatch = objPRPDBatch_DL.Get(txtPRPDBatch.Text);

                    dtPRPDBatchInstructions = objPRPDBatchActivityInstructions_DL.GetDataByBatchID(txtPRPDBatch.Text);

                    dgvActivityInstructions.AutoGenerateColumns = false;
                    dgvActivityInstructions.DataSource = objSourceInstructions;
                    objSourceInstructions.DataSource = dtPRPDBatchInstructions;
                    objSourceInstructions.ResetBindings(true);

                    MR_DL objMRDL = new MR_DL(ConnectionStringClass.GetConnection());

                    if (objPRPDBatch.Status == PRPDBatch.PRPDBatchStatus.Approved)
                    {
                        if (objMRDL.Get(objPRPDBatch.MRIN).MRStatus == MR.Status.Reject)
                        {
                            btnSendMR.Enabled = true;
                            btnSendMR.Visible = true;
                            btnBatchDelete.Enabled = true;
                            btnApprove.Enabled = false;
                        }
                        else
                        {
                            btnSendMR.Enabled = false;
                            btnBatchDelete.Enabled = false;
                            btnApprove.Enabled = false;
                        }
                    }
                    else if (objPRPDBatch.Status == PRPDBatch.PRPDBatchStatus.Created)
                    {
                        btnSendMR.Enabled = false;
                        btnSendMR.Visible = false;
                        btnBatchDelete.Enabled = true;
                        btnApprove.Enabled = true;

                    }
                    else
                    {
                        btnSendMR.Enabled = false;
                        btnSendMR.Visible = false;
                        btnBatchDelete.Enabled = false;
                        btnApprove.Enabled = false;
                    }

                    if (objPRPDBatch.Status == PRPDBatch.PRPDBatchStatus.Started)
                    {
                        if (dgvPRPDbatchByState.CurrentRow.Cells["PRPDBatchID"].Value != null)
                        {
                            objQCReport = objQCReport_DL.Get_PRPD_Quality_Passed(dgvPRPDbatchByState.CurrentRow.Cells["PRPDBatchID"].Value.ToString());
                            if (objQCReport == null)
                            {

                                btnEditMode.Enabled = true;
                            }
                            else
                            {
                                btnEditMode.Enabled = false;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());

            }
        }

        private void dgvActivityInstructions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                PRPDBatchActivityInstructions obj = new PRPDBatchActivityInstructions();

                obj = objPRPDBatchActivityInstructions_DL.Get(Convert.ToInt64(dgvActivityInstructions.CurrentRow.Cells["colPRPDBatchActivityInstructionsID"].Value));

                cmbActivity.SelectedValue = obj.Activity.MainActID;
                if (obj.Machine != null)
                {
                    cmbMachine.SelectedValue = obj.Machine.MachineCode;
                }
                
                txtInstruction.Text = obj.InstructionDesc;


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
        }

        //public long GenerateMR(PRPDBatch objPRPD)
        //{
        //    MR objMR = new MR();
        //    MRMaterialCollec objMRMatCollec = new MRMaterialCollec();
        //    MRFinishProductCollec objMRFinishProductCollec = new MRFinishProductCollec();
        //    MRBasicProductCollec objMRBasicProductCollec = new MRBasicProductCollec();
        //    BatchMR objBatchMR = new BatchMR();
        //    Department_DL objDepDL = new Department_DL(ConnectionStringClass.GetConnection());
        //    MR_DL objMRDL = new MR_DL(ConnectionStringClass.GetConnection());
        //    MRMaterial_DL objMRMaterialDL = new MRMaterial_DL(ConnectionStringClass.GetConnection());
        //    Store_DL objStoreDL = new Store_DL(ConnectionStringClass.GetConnection());
        //    try
        //    {

        //        objMR.MRDate = DateTime.Now;
        //        objMR.MRDepartmentFrom = objDepDL.GetByDepType("PRPD");
        //        objMR.MREnterdBy = CurrentUser.UserEmp;
        //        objMR.MRStatus = MR.Status.Initial;
        //        Store objStore = (Store)cmbStores.SelectedItem;
        //        objMR.MRStore = objStoreDL.Get(objStore.StoreID);
        //        objMR.MRType = MR.Type.Material;
        //        objMR.MRRemarks = "Material Requition(Materials) for PRPD Batch NO " + objPRPD.PRPDBatchID.ToString();

        //        MRMaterial obj = new MRMaterial();
        //        obj.Description = "PRPD Batch Material Requition";
        //        obj.Material = objPRPD.PRPDBatchMaterial;
        //        obj.MRBINNo = "";
        //        obj.ReqdQty = objPRPDBatch.PRPDBatchQty;

        //        long MRNO = objMRDL.Add(objMR);
        //        if (MRNO > 0)
        //        {
        //            objMR.MRNO = MRNO;
        //            obj.MR = objMR;
        //            objMRMaterialDL.Add(obj);


        //        }
        //        return MRNO;


        //    }
        //    catch (Exception ex)
        //    {

        //        return 0;
        //    }
        //}

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grpBatchInstructions_EnabledChanged(object sender, EventArgs e)
        {

            try
            {
                cmbActivity.DataSource = objMainActivity_DL.GetByDepID(objDepartment_DL.GetByDepType("PRPD").DepID);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void cmbActivity_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {


                cmbMachine.DataSource = objMachine_DL.GetDataView_By_Activity(Convert.ToInt64(cmbActivity.SelectedValue));

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnSendMR_Click(object sender, EventArgs e)
        {
            long newMRNo = 0;
            long x = 0;

            try
            {
                newMRNo = GenerateMR(objPRPDBatch);
                x = objPRPDBatch_DL.UpdateMR(objPRPDBatch.PRPDBatchID,newMRNo);

                if (x > 0)
                {
                    MessageBox.Show(this, "Successfully Raised a MR \n\nMRNO :- " + newMRNo, "MR Is Raised", MessageBoxButtons.OK);
                    btnSendMR.Visible = false;
                    btnSendMR.Enabled = false;
                }
            }
            catch (Exception)
            {
                
                throw;
            }


        }

        private void btnButtonDelete_Click(object sender, EventArgs e)
        {

        }

        public long GenerateMR(PRPDBatch objPRPD)
        {
            MR objMR = new MR();
            MRMaterialCollec objMRMatCollec = new MRMaterialCollec();
            MRFinishProductCollec objMRFinishProductCollec = new MRFinishProductCollec();
            MRBasicProductCollec objMRBasicProductCollec = new MRBasicProductCollec();
            BatchMR objBatchMR = new BatchMR();
            Department_DL objDepDL = new Department_DL(ConnectionStringClass.GetConnection());
            MR_DL objMRDL = new MR_DL(ConnectionStringClass.GetConnection());
            MRMaterial_DL objMRMaterialDL = new MRMaterial_DL(ConnectionStringClass.GetConnection());
            Store_DL objStoreDL = new Store_DL(ConnectionStringClass.GetConnection());
            try
            {

                objMR.MRDate = DateTime.Now;
                objMR.MRDepartmentFrom = objDepDL.GetByDepType("PRPD");
                objMR.MREnterdBy =CurrentUser.EmployeeID;
                objMR.MRStatus = MR.Status.Initial;

                objMR.MRStore = objStore;
                objMR.MRType = MR.Type.Material;
                objMR.MRRemarks = "Material Requition(Materials) for PRPD Batch NO " + objPRPD.PRPDBatchID.ToString();
                objMR.OriginType = MR.Origin.ToBatch;

                MRMaterial obj = new MRMaterial();
                obj.Description = "PRPD Batch Material Requition";
                obj.Material = objPRPD.PRPDBatchMaterial;
                obj.MRBINNo = "";
                obj.ReqdQty = objPRPD.PRPDBatchQty;
                

                long MRNO = objMRDL.Add_M(objMR);
                if (MRNO > 0)
                {
                    objMR.MRNO = MRNO;
                    obj.MR = objMR;
                    objMRMaterialDL.Add(obj);





                }
                return MRNO;


            }
            catch (Exception ex)
            {

                return 0;
            }

        }


        private void btnApprove_Click_1(object sender, EventArgs e)
        {
            try
            {
                DialogResult Result = new DialogResult();

                Result = MessageBox.Show(this, "Are You Sure You Want to Approve the Batch", "Approve Batch", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (Result == DialogResult.Yes)
                {
                    if (objPRPDBatch != null)
                    {
                        PRPDBatch obj = objPRPDBatch;
                        //obj = objPRPDBatch_DL.Get(dgvPRPDbatchByState.CurrentRow.Cells["PRPDBatchID"].Value.ToString());


                        long res = GenerateMR(objPRPDBatch);
                        int x = 0;
                        if (res > 0)
                        {
                            obj.MRIN = res;
                            x = objPRPDBatch_DL.UpdateMR(obj.PRPDBatchID, res);

                        }
                        
                        obj.Status = PRPDBatch.PRPDBatchStatus.Approved;
                        obj.PRPDBatchApprovedBy = CurrentUser.UserEmp;
                        int res1 = objPRPDBatch_DL.Update_Apprve(obj);
                        if (x >= 0)
                        {
                            MessageBox.Show(this,"PRPD batch approved. MR sent to "+objStore.StoreName+"\nMR No :- "+obj.MRIN.ToString(),"Successful",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        }


                        dtPRPDBatches = objPRPDBatch_DL.GetDataByState_Type((PRPDBatch.PRPDBatchStatus)Enum.Parse(typeof(PRPDBatch.PRPDBatchStatus), cmbPRPDBatchStatus.SelectedValue.ToString()), PRPDBatch.PRPDType.PrimaryPreperation);
                        dgvPRPDbatchByState.AutoGenerateColumns = false;
                        dgvPRPDbatchByState.DataSource = objSourcePRPDBatches;
                        objSourcePRPDBatches.DataSource = null;
                        objSourcePRPDBatches.ResetBindings(false);
                        objSourceInstructions.DataSource = null;
                        objSourceInstructions.ResetBindings(false);
                        objPRPDBatch = null;
                        btnApprove.Enabled = false;
                        btnBatchDelete.Enabled = false;






                        this.cmbPRPDBatchStatus_SelectedIndexChanged(sender, e);
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(this, "Error occured while Approving", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBatchDelete_Click(object sender, EventArgs e)
        {
            try
            {
                PRPDBatch obj = objPRPDBatch;
                //obj = objPRPDBatch_DL.Get(dgvPRPDbatchByState.CurrentRow.Cells["PRPDBatchID"].Value.ToString());
                if (obj != null)
                {
                    DialogResult dr = MessageBox.Show(this, "Are you sure you want to delete selected PRPD Batch\n\nClick Yes to delete", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                    if (dr == DialogResult.Yes)
                    {
                        //MR_DL objMRDL = new MR_DL(ConnectionStringClass.GetConnection());
                        //MR objMR = objMRDL.Get(obj.MRIN);
                        //if (objMR.MRNO <= 0 || objMR.MRStatus == MR.Status.Initial || objMR.MRStatus == MR.Status.Reject)
                        {
                            int res = objPRPDBatch_DL.Delete(obj.PRPDBatchID);
                            //if (objMR.MRStatus == MR.Status.Initial)
                            //{
                            //    objMR.MRStatus = MR.Status.Reject;
                            //    objMR.MRApprovedBy = CurrentUser.UserEmp;
                            //    int x = objMRDL.Update(objMR);
                                
                            //}
                            
                            if (res > 0)
                            {
                                dtPRPDBatches = objPRPDBatch_DL.GetDataByState_Type((PRPDBatch.PRPDBatchStatus)Enum.Parse(typeof(PRPDBatch.PRPDBatchStatus), cmbPRPDBatchStatus.SelectedValue.ToString()), PRPDBatch.PRPDType.PrimaryPreperation);

                                dgvPRPDbatchByState.AutoGenerateColumns = false;
                                dgvPRPDbatchByState.DataSource = objSourcePRPDBatches;
                                objSourcePRPDBatches.DataSource = dtPRPDBatches;
                                objSourcePRPDBatches.ResetBindings(true);


                                objSourceInstructions.DataSource = null;
                                objSourceInstructions.ResetBindings(false);
                                objPRPDBatch = null;
                                btnApprove.Enabled = false;
                                btnBatchDelete.Enabled = false;
                            }
                        }
                        //else
                        //{
                        //    MessageBox.Show(this, "MR Approved,You cant delete this Batch Files. Please contact the system administrator", "Delete Fail", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        //}
                    }
                 


                }
            }
            catch (Exception)
            {

                MessageBox.Show(this, "Error occured while deleting", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void rdbPP_CheckedChanged(object sender, EventArgs e)
        {
            Load_Batch_List();
        }

        private void rdbPPRe_CheckedChanged(object sender, EventArgs e)
        {
            Load_Batch_List();
        }

        private void rdbRework_CheckedChanged(object sender, EventArgs e)
        {
            Load_Batch_List();
        }
    }
}