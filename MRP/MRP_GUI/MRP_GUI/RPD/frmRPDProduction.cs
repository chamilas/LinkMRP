using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DL;
using SESD.MRP.REF;

namespace MRP_GUI.RPD
{
    public partial class frmRPDProduction : System.Windows.Forms.Form
    {
        private User _CurrentUser;

        public User CurrentUser
        {
            get { return _CurrentUser; }
            set { _CurrentUser = value; }
        }
        private MR_DL objMRDL = new MR_DL(ConnectionStringClass.GetConnection());
        private MRMaterial_DL objMRMaterial_DL = new MRMaterial_DL(ConnectionStringClass.GetConnection());
        private RPDBatchProduction_DL objRPDBatchProductionDL = new RPDBatchProduction_DL(ConnectionStringClass.GetConnection());
        private Store_DL objStoreDL = new Store_DL(ConnectionStringClass.GetConnection());
        private Employee_DL objEmployeeDL = new Employee_DL(ConnectionStringClass.GetConnection());
        private MachineActivity_DL objMachineActivityDL = new MachineActivity_DL(ConnectionStringClass.GetConnection());
        private Department_DL objDepartmentDL = new Department_DL(ConnectionStringClass.GetConnection());
        private PRPDBatch_DL objPRPDBatchDL = new PRPDBatch_DL(ConnectionStringClass.GetConnection());
        private RPDBatch_DL objRPDBatchDL = new RPDBatch_DL(ConnectionStringClass.GetConnection());
        private Machine_DL objMachineDL = new Machine_DL(ConnectionStringClass.GetConnection());
        private MainActivity_DL objMainActivityDL = new MainActivity_DL(ConnectionStringClass.GetConnection());
        private RPDBatchActivityInstructions_DL objRPDBatchActivityInstructionsDL = new RPDBatchActivityInstructions_DL(ConnectionStringClass.GetConnection());
        private RPDBatchActivityInstructionsCollec objBatchActivityInstructionsCollec = new RPDBatchActivityInstructionsCollec();
        private RPDBatchActivity_DL objRPDBatchActivityDL = new RPDBatchActivity_DL(ConnectionStringClass.GetConnection());
        private RPDBatchPackingMaterialUsage_DL objRPDBatchPackingMaterialUsageDL = new RPDBatchPackingMaterialUsage_DL(ConnectionStringClass.GetConnection());
        private RPDBatch.RPDBatchStatus Status;
        private RPDBatch objRPDBatch = null;
        private SESD.MRP.REF.RPDBatchActivity objRPDBatchActivity = null;
        private RPDBatchPackingMaterialUsage objRPDBatchPackingMaterialUsage = null;
        private RPDBatchActivity objRPDBatchPackingActivity = null;
        private RPDBatchActPackingDetails objRPDBatchActPackingDetails = null;
        private RPDBatchActPackingDetails_DL objRPDBatchActPackingDetailsDL = new RPDBatchActPackingDetails_DL(ConnectionStringClass.GetConnection());
        private Material_DL objMaterialDL = new Material_DL(ConnectionStringClass.GetConnection());
        private RPDBatchActualProduction_DL objRPDBatchActualProductionDL = new RPDBatchActualProduction_DL(ConnectionStringClass.GetConnection());
        private QCReport_DL objQCReport_DL = new QCReport_DL(ConnectionStringClass.GetConnection());
        private GRN_DL objGRNDL = new GRN_DL(ConnectionStringClass.GetConnection());
        private GRNMaterials_DL objGRNMaterialsDL = new GRNMaterials_DL(ConnectionStringClass.GetConnection());
        private QCReport objQCReport = null;
        DataTable dtPackingIssued = new DataTable();

        
        public frmRPDProduction()
        {
            InitializeComponent();
        }

        public frmRPDProduction(User objUser)
        {
            CurrentUser = objUser;
            InitializeComponent();
        }

        private void Load_PackingIssued()
        {
            try
            {
                BatchPackingMR_DL objBatchPackingMR_DL = new BatchPackingMR_DL(ConnectionStringClass.GetConnection());

                if (cmbRPDBatchID.SelectedValue != null)
                {
                   dtPackingIssued= objBatchPackingMR_DL.GetData_ByBatchID(cmbRPDBatchID.SelectedValue.ToString());

                   dgvPackingIssued.AutoGenerateColumns = false;
                   objSourcePackingIssued.DataSource = dtPackingIssued;
                   dgvPackingIssued.DataSource = objSourcePackingIssued;
                   objSourcePackingIssued.ResetBindings(true);

                }
                
            }
            catch (Exception)
            {

                MessageBox.Show(this, "Error occured while loading", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frmRPDProduction_Load(object sender, EventArgs e)
        {
            try
            {
                rbStarted.Checked = true;
                cmbSupervisedBy.DataSource = objEmployeeDL.Get_By_RoleType(EmployeeRole.RoleType.Staff.ToString(),true);
                cmbSupervisedByPackingDetails.DataSource = objEmployeeDL.Get_By_RoleType( EmployeeRole.RoleType.Staff.ToString(), true);

            }
            catch (Exception)
            {

                MessageBox.Show(this,"Error occured while loading","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {


            if (keyData == Keys.F2)
            {
                frmBatchPackingMR_RPD objForm = new frmBatchPackingMR_RPD(Convert.ToInt32(objDepartmentDL.GetByDepType("RPD").DepID),objRPDBatch.RPDBatchID,CurrentUser);
                objForm.ShowDialog(this);
            }

            return base.ProcessCmdKey(ref msg, keyData);

        }



        private void rbCheckedChanged(object sender, EventArgs e)
        {
            try
            {
                ClearForm();
                if (rbApproved.Checked)
                {
                    Status = RPDBatch.RPDBatchStatus.Approved;
                    grpStart.Enabled = true;
                    btnAddNewActivity.Enabled = false;
                }
                else if (rbStarted.Checked)
                {
                    Status = RPDBatch.RPDBatchStatus.Started;
                    grpStart.Enabled = false;
                    btnAddNewActivity.Enabled = true;
                }
                else if (rbCostApproved.Checked)
                {
                    Status = RPDBatch.RPDBatchStatus.Finished;
                    grpStart.Enabled = false;
                    btnAddNewActivity.Enabled = false;
                    
                }
                bindRPDBatch.DataSource = objRPDBatchDL.GetDataViewByState(Status, true);
                cmbRPDBatchID.DataSource = bindRPDBatch;
            }
            catch (Exception)
            {

                MessageBox.Show(this,"Error occured while loading Batches","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

        }

        private void gvRPDBatch_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

            }
        }

        private void LoadPackingDetails()
        {
            try
            {
            cmbPackMaterial.DataSource = objMaterialDL.GetDataViewIntermediates(objRPDBatch.RPDBatchMaterial.MaterialCode);
            objRPDBatchPackingActivity = objRPDBatchActivityDL.Get("Packing-RPD", objRPDBatch.RPDBatchID);
            lblTransferd.Visible = false;
            if (objRPDBatchPackingActivity.RPDBatchActID != 0)
            {
                    cmbSupervisedByPackingDetails.SelectedValue = objRPDBatchPackingActivity.SupervisedBy;
                    dtPackingStartDate.Value = objRPDBatchPackingActivity.StartDate;
                    
                    
                dtPackingStartDate.Enabled = false;
                cmbSupervisedByPackingDetails.Enabled = false;
                grpPackingDetails.Enabled = true;
                dtPackingFinishDate.Enabled = true;

                if (objRPDBatchPackingActivity.ActivityStatus == RPDBatchActivity.Status.Started)
                {
                    btnPackingLabour.Visible = true;
                    btnSavePackingAct.Enabled = false;//checking
                    //btnSavePackingAct.Text = "Stop Activity";//checking
                    btnStopPackingAct.Visible = true;

                }
                else if (objRPDBatchPackingActivity.ActivityStatus == RPDBatchActivity.Status.Finalized)
                {
                    dtPackingFinishDate.Value = objRPDBatchPackingActivity.StopDate;
                    txtStopQty.Text = objRPDBatchPackingActivity.StopQty.ToString();

                    dtPackingFinishDate.Enabled = false;
                    btnPackingLabour.Visible = false;
                    grpPackingDetails.Enabled = false;
                    //btnSavePackingAct.Enabled = true;//checking
                    //btnSavePackingAct.Enabled = false;//checking
                    //btnSavePackingAct.Text = "Start Packing Activity";//checking
                    bindActual.DataSource = objRPDBatchActualProductionDL.Get(objRPDBatch.RPDBatchID);
                    //if (objQCReport_DL.IsRPDBatchAccept(objRPDBatch.RPDBatchID,(int)QCReport.ReportStatus.Accept))
                    //{
                    //    grpActual.Enabled = true;
                    //}
                    //else
                    //{
                    //    grpActual.Enabled = false;
                    //}
                    txtStoreID.Text = objStoreDL.Get("RPD_Main").StoreName;
                }
                if (objRPDBatch.Status == RPDBatch.RPDBatchStatus.Transfered)
                {
                    grpActual.Enabled = false;
                    lblTransferd.Visible = true;
                }
                bindPackingDetails.DataSource = objRPDBatchActPackingDetailsDL.Get_By_BatchAct_View(objRPDBatchPackingActivity.RPDBatchActID);
            }
            else
            {
                btnPackingLabour.Visible = false;
                btnSavePackingAct.Enabled = false;
                grpPackingDetails.Enabled = false;
                dtPackingFinishDate.Enabled = false;
                dtPackingStartDate.Enabled = true;
                btnStopPackingAct.Enabled = true; //ckecking
                cmbSupervisedByPackingDetails.Enabled = true;
            }

        }
            catch (Exception ex)
            {

            MessageBox.Show(ex.Message.ToString());
        }
        }

        private void btnStartSave_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show(this,"Are you sure you want to Start selected RPD Batch?\n\nClick Yes to Start","Confirm Start",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button1);
                if (dr == DialogResult.Yes)
                {
                    objRPDBatch.RPDBatchStartDate = dtStart.Value;
                    objRPDBatch.RPDBatchSupervisedBy = objEmployeeDL.Get(cmbSupervisedBy.SelectedValue.ToString());
                    objRPDBatch.Status = RPDBatch.RPDBatchStatus.Started;

                    int res = objRPDBatchDL.Update_Start(objRPDBatch);
                    if (res>0)
                    {
                        rbStarted.Checked = true;
                        rbApproved.Checked = false;

                        txtApprovedBy.Text = objRPDBatch.ApprovedBy.EmployeeNameID;
                        txtEndBy.Text = objRPDBatch.EndBy.EmployeeNameID;
                        txtInstructedBy.Text = objRPDBatch.RPDBatchInstructedBy.EmployeeNameID;
                        txtMaterial.Text = objRPDBatch.RPDBatchMaterial.MaterialNameCode;
                        txtPRPDBatchID.Text = objRPDBatch.RPDBatchID;
                        txtQuantity.Text = objRPDBatch.RPDBatchQty.ToString();
                        txtSupervisedBy.Text = objRPDBatch.RPDBatchSupervisedBy.EmployeeNameID;
                        txtType.Text = objRPDBatch.Type;
                        if (objRPDBatch.RPDBatchStartDate.HasValue)
                        {
                            txtStartedDate.Text = objRPDBatch.RPDBatchStartDate.Value.ToShortDateString();

                        }

                        else
                        {
                            txtStartedDate.Text = "Not Started";
                        }
                        bindInstructions.DataSource = objRPDBatchActivityInstructionsDL.GetDataView(objRPDBatch.RPDBatchID);
                        bindActivities.DataSource = objRPDBatchActivityDL.GetDataView(objRPDBatch.RPDBatchID);
                    }

                }
            }
            catch (Exception)
            {

                MessageBox.Show(this,"Error occured while saving Start Date","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void ClearForm()
        {
            txtApprovedBy.Text = "";
            txtEndBy.Text = "";
            txtInstructedBy.Text = "";
            txtMaterial.Text = "";
            txtPRPDBatchID.Text = "";
            txtQuantity.Text = "";
            txtSupervisedBy.Text = "";
            txtStartedDate.Text = "";

            bindInstructions.DataSource = null;
            bindActivities.DataSource = null;
            //bindMaterials.DataSource = null;
            //btnEdit.Enabled = false;

        }

        private void btnAddNewActivity_Click_1(object sender, EventArgs e)
        {
            RPD.RPDBatchActivityForms.frmAddActivity objFrm = new MRP_GUI.RPD.RPDBatchActivityForms.frmAddActivity(CurrentUser,objRPDBatch);
            objFrm.ShowDialog();
            bindActivities.DataSource = objRPDBatchActivityDL.GetDataView(objRPDBatch.RPDBatchID);
            LoadPackingDetails();
        }

        private void gvActivity_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {


                    ClearActivityTab();
                    long ID = Convert.ToInt64(gvActivity.Rows[e.RowIndex].Cells["RPDBatchActID"].Value);
                    objRPDBatchActivity = objRPDBatchActivityDL.Get(ID);
                    if (objRPDBatchActivity != null)
                    {
                        if (gvActivity.CurrentCell.OwningColumn.Name.Equals("colAddDetails"))
                        {
                            LoadActivityDetails();
                        }

                        dtpStartDate.Value = objRPDBatchActivity.StartDate;
                        txtStartQty.Text = objRPDBatchActivity.StartQty.ToString();
                        if (objRPDBatchActivity.StopDate.ToString() != "1/1/0001 12:00:00 AM")
                        {
                            dtStopActivity.Value = objRPDBatchActivity.StopDate;
                        }
                        else
                        {
                            dtStopActivity.Value = DateTime.Today;
                        }
                        if (objRPDBatchActivity.StopQty != 0)
                        {
                           txtStopQty.Text = objRPDBatchActivity.StopQty.ToString();
                        }
                        txtID.Text = objRPDBatchActivity.RPDBatchActID.ToString();
                        txtMainActivity.Text = objMainActivityDL.Get(objRPDBatchActivity.MainActID).MainActivityTitle;
                        txtStatus.Text = objRPDBatchActivity.ActivityStatus.ToString();
                        if (objRPDBatchActivity.ActivityStatus == SESD.MRP.REF.RPDBatchActivity.Status.Initial)
                        { 
                            
                            btnEdit.Enabled = true; 
                            btnDelete.Enabled = true;
                        }
                        else if (objRPDBatchActivity.ActivityStatus == RPDBatchActivity.Status.Started)
                        {
                            btnDetails.Enabled = true;
                            grpStopAct.Enabled = true;
                        }
                        else if (objRPDBatchActivity.ActivityStatus == RPDBatchActivity.Status.Finalized)
                        {
                            grpStopAct.Enabled = false;
                        }
                        else 
                        {
                            //grpStopAct.Enabled = false;
                        }
                        
                       
                    }

                }
                catch (Exception)
                {

                    MessageBox.Show(this,"Error occured while loading RPD Batch Activity","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
        }

        private void ClearActivityTab()
        {
            txtStatus.Text = "";
            txtMainActivity.Text = "";
            txtID.Text = "";
            objRPDBatchActivity = null;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnDetails.Enabled = false;
        }

        private void btnClearActTab_Click(object sender, EventArgs e)
        {
            ClearActivityTab();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show(this,"Are you sure you want to delete selected RPD batch Activity?\n\nClick Yes to delete","Confirm Delete",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.Yes)
                {
                    int res = objRPDBatchActivityDL.Delete(objRPDBatchActivity.RPDBatchActID);
                    if (res > 0)
                    {
                        ClearActivityTab();
                        bindActivities.DataSource = objRPDBatchActivityDL.GetDataView(objRPDBatch.RPDBatchID);
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show(this,"Error occured while deleting RPD Batch Activity","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                RPD.RPDBatchActivityForms.frmAddActivity objFrm = new MRP_GUI.RPD.RPDBatchActivityForms.frmAddActivity(CurrentUser, objRPDBatch,objRPDBatchActivity);
                objFrm.ShowDialog();
                bindActivities.DataSource = objRPDBatchActivityDL.GetDataView(objRPDBatch.RPDBatchID);
                ClearActivityTab();
            }
            catch (Exception)
            {

                MessageBox.Show(this,"Error occured while loading RPD Batch Activity Edit form","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
                    
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            LoadActivityDetails();

        }

        private void LoadActivityDetails()
        {
            if (objRPDBatchActivity.ActivityStatus == RPDBatchActivity.Status.Initial)
            {
                MessageBox.Show(this, "Activity Not Started", "Activity Status", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (objRPDBatchActivity.ActivityStatus == RPDBatchActivity.Status.Started)
            {
                frmRPDBatchActivity obj = new frmRPDBatchActivity(_CurrentUser, objRPDBatchActivity.RPDBatchActID);
                obj.ShowDialog();
                obj.StartPosition = FormStartPosition.CenterScreen;
            }
            else if (objRPDBatchActivity.ActivityStatus == RPDBatchActivity.Status.Finalized)
            {
                frmRPDBatchActivity obj = new frmRPDBatchActivity(_CurrentUser, objRPDBatchActivity.RPDBatchActID);
                obj.ShowDialog();
                obj.StartPosition = FormStartPosition.CenterScreen;
                //MessageBox.Show(this, "Activity Finished", "Activity Status", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }


        private void btnStopActivity_Click(object sender, EventArgs e)
        {
            try
            {

                    objRPDBatchActivity.StopDate = dtStopActivity.Value;
                    objRPDBatchActivity.ActivityStatus = RPDBatchActivity.Status.Finalized;
                    objRPDBatchActivity.StopQty = Convert.ToDecimal(txtStopQty.Text);

                    long ID = objRPDBatchActivityDL.Update(objRPDBatchActivity);
                    if (ID > 0)
                    {
                        bindActivities.DataSource = objRPDBatchActivityDL.GetDataView(objRPDBatch.RPDBatchID);
                        grpStopAct.Enabled = false;
                        btnDetails.Enabled = false;
                        btnEdit.Enabled = false;
                        btnDelete.Enabled = false;
                        txtStopQty.Text = "";
                    }

            }
            catch (Exception)
            {

                MessageBox.Show(this, "Error occured while saving Start Date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void btnSavePackingAct_Click(object sender, EventArgs e)
        {
            try
            {
                if (!objQCReport_DL.IsRPDBatchAccept(objRPDBatch.RPDBatchID,(int)QCReport.ReportStatus.Accept))
                {
                    MessageBox.Show(this, "Sysem does not allow to start Packing activity until quality test accepted", "QC Check Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {

                    if (objRPDBatchPackingActivity == null)
                    {
                        objRPDBatchPackingActivity = new RPDBatchActivity();
                    }

                    objRPDBatchPackingActivity.Comments = "";
                    objRPDBatchPackingActivity.MainActID = objMainActivityDL.GetByName("Packing-RPD").MainActID;
                    objRPDBatchPackingActivity.StartDate = dtPackingStartDate.Value;
                    objRPDBatchPackingActivity.RPDBatchID = objRPDBatch.RPDBatchID;
                    objRPDBatchPackingActivity.SupervisedBy = cmbSupervisedByPackingDetails.SelectedValue.ToString();
                    //objRPDBatchPackingActivity.InspectedBy = cmbInstructedBy.SelectedValue.ToString();

                    long ID =0;

                    if (dtPackingFinishDate.Checked)
                    {
                        objRPDBatchPackingActivity.StopDate = dtPackingFinishDate.Value;
                        objRPDBatchPackingActivity.ActivityStatus = RPDBatchActivity.Status.Finalized;

                       ID = objRPDBatchActivityDL.Update(objRPDBatchPackingActivity);
                    }
                    else
                    {
                        objRPDBatchPackingActivity.ActivityStatus = SESD.MRP.REF.RPDBatchActivity.Status.Started;
                        ID = objRPDBatchActivityDL.Add(objRPDBatchPackingActivity);
                    }
                    
                    if (ID > 0)
                    {

                        LoadPackingDetails();
                        if (objRPDBatchPackingActivity.ActivityStatus == RPDBatchActivity.Status.Finalized)
                        {
                            objRPDBatchActualProductionDL.Add(objRPDBatch.RPDBatchID);
                            bindActual.DataSource = objRPDBatchActualProductionDL.Get(objRPDBatch.RPDBatchID);
                        }
                        else if (objRPDBatchPackingActivity.ActivityStatus == RPDBatchActivity.Status.Started)
                        {
                            btnSavePackingAct.Text = "Stop Activity";
                        }
                    }


                }
            }
            catch (Exception)
            {

                MessageBox.Show(this, "Error occured while saving packing activity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSavePackingDetails_Click(object sender, EventArgs e)
        {
            try
            {
                if (objRPDBatchActPackingDetails == null)
                {
                    objRPDBatchActPackingDetails = new RPDBatchActPackingDetails();
                }
                objRPDBatchActPackingDetails.MaterialCode = cmbPackMaterial.SelectedValue.ToString();
                objRPDBatchActPackingDetails.NoOfPackets = Convert.ToInt64(txtNoOfPacks.Text);
                objRPDBatchActPackingDetails.PackSize = Convert.ToDecimal(txtPackSize.Text);
                objRPDBatchActPackingDetails.RPDBatchActID = objRPDBatchPackingActivity.RPDBatchActID;

                long ID = objRPDBatchActPackingDetailsDL.Add(objRPDBatchActPackingDetails);
               

                if (ID > 0)
                {
                    ClearPackingDetails();
                }

            }
            catch (Exception)
            {

                MessageBox.Show(this,"Error occured while saving Packing Details","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void btnDeletePackingDetails_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show(this,"Are you sure you want to delete selected Packing Detail?\n\nClick Yes to Delete","Confirm Delete",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.Yes)
                {
                    int res = objRPDBatchActPackingDetailsDL.Delete(objRPDBatchActPackingDetails.RPDPackDetails);
                    if (res > 0)
                    {
                        ClearPackingDetails();
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show(this,"Error occured while deleting the Packing Detail","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void btnClearPackingDetails_Click(object sender, EventArgs e)
        {
            ClearPackingDetails();
        }

        private void ClearPackingDetails()
        {
            if (cmbPackMaterial.Items.Count > 0)
            {
                cmbPackMaterial.SelectedIndex = 0;
            }
            txtNoOfPacks.Text = "0";
            txtPackSize.Text = "0.00";
            objRPDBatchActPackingDetails = null;

            if (cmbRPDBatchID.SelectedValue != null)
            {
                objRPDBatch = objRPDBatchDL.Get(cmbRPDBatchID.SelectedValue.ToString());
            }
            objRPDBatchPackingActivity = objRPDBatchActivityDL.Get("Packing-RPD", objRPDBatch.RPDBatchID);

            if (objRPDBatch != null && objRPDBatchPackingActivity != null)
            {
                gvPackingDetails.AutoGenerateColumns = false;
                bindPackingDetails.DataSource = objRPDBatchActPackingDetailsDL.Get_By_BatchAct_View(objRPDBatchPackingActivity.RPDBatchActID);
                gvPackingDetails.DataSource = bindPackingDetails;
                bindPackingDetails.ResetBindings(true);


            }
            else
            {
                bindPackingDetails.DataSource = null;
            }

        }

        private void tpPacking_Click(object sender, EventArgs e)
        {

        }

        private void gvPackingDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    long ID = Convert.ToInt64(gvPackingDetails.Rows[e.RowIndex].Cells["RPDPackDetails"].Value);
                    objRPDBatchActPackingDetails = objRPDBatchActPackingDetailsDL.Get(ID);

                    if (objRPDBatchActPackingDetails != null)
                    {
                        cmbPackMaterial.SelectedValue = objRPDBatchActPackingDetails.MaterialCode;
                        txtNoOfPacks.Text = objRPDBatchActPackingDetails.NoOfPackets.ToString();
                        txtPackSize.Text = objRPDBatchActPackingDetails.PackSize.ToString();
                        btnDeletePackingDetails.Enabled = true;
                    }
                    else
                    {
                        btnDeletePackingDetails.Enabled = false;
                    }

                }
                catch (Exception)
                {

                    MessageBox.Show(this,"Error occured while loading packing details","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
        }

        private void btnPackingLabour_Click(object sender, EventArgs e)
        {
                try
                {

                    objRPDBatchActivity = objRPDBatchActivityDL.Get("Packing-RPD",objRPDBatch.RPDBatchID);
                    
                    if (objRPDBatchActivity != null)
                    {
                        LoadActivityDetails();

                    }
                }
                catch (Exception)
                {

                    MessageBox.Show(this, "Error occured while loading RPD Batch Activity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            GRN objGRN = new GRN();
            GRNMaterials objGRNMaterials = new GRNMaterials();
            GRNMaterialsCollec objGRNMaterialsCollec = new GRNMaterialsCollec();

            //Fill GRN Data

            objGRN.GRNDate = DateTime.Today;
            objGRN.GRNEnterdBy = CurrentUser.EmployeeID;
            objGRN.GRNRPDBatch = objRPDBatch.RPDBatchID;
            objGRN.GRNStatus = GRN.Status.Initial;
            objGRN.GRNStore = objStoreDL.Get("RPD_Main");
            objGRN.GRNType = GRN.Type.Material;
            

            
            RPDBatchActualProduction_DL objRPDBatchActualProduction_DL = new RPDBatchActualProduction_DL(ConnectionStringClass.GetConnection());
            DataTable dt = objRPDBatchActualProductionDL.Get(objRPDBatch.RPDBatchID);

            try
            {
                DialogResult dr = MessageBox.Show(this, "Do you want to GRN the final production and finalized the batch?\nThis action cannot be undo.\n\nClicl Yes to continue", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.Yes)
                {


                    long GRNNO = objGRNDL.Add_RPD(objGRN);
                    GRN NewGRN = new GRN();
                    NewGRN = objGRNDL.Get(GRNNO);


                    if (GRNNO > 0)
                    {

                        //for (int i = 0; i < dt.Rows.Count; i++)
                        //{
                        //    objGRNMaterials.GRN = NewGRN;
                        //    objGRNMaterials.GrossQty = Convert.ToDecimal(dt.Rows[i]["Quantity"]);
                        //    objGRNMaterials.NetQty = objGRNMaterials.GrossQty;
                        //    objGRNMaterials.Remarks = "RPDBatch Item";
                        //    objGRNMaterials.UnitPrice = Convert.ToDecimal(dt.Rows[i]["UnitCost"]);
                        //    objGRNMaterials.Material = objMaterialDL.Get(Convert.ToString(dt.Rows[i]["MaterialCode"]));

                        //    objGRNMaterialsDL.Add(objGRNMaterials);
                        //}
                     
                        objRPDBatch.Status = RPDBatch.RPDBatchStatus.Transfered;
                        objRPDBatch.EndBy = CurrentUser.UserEmp;
                        
                      
                        int res = objRPDBatchDL.Update_Transfer(objRPDBatch);
                        if (res > 0)
                        {
                            MessageBox.Show(this, "Successfully created a GRN and RPD Batch Finalized", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            bindRPDBatch.DataSource = objRPDBatchDL.GetDataViewByState(Status, true);
                            this.Close();
                        }

                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void gvReports_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                objQCReport = objQCReport_DL.Get(Convert.ToInt64(gvReports.Rows[e.RowIndex].Cells["QCReportID"].Value));
                if (objQCReport != null)
                {
                    txtReportID.Text = objQCReport.QCReportID.ToString();
                    txtReportType.Text = objQCReport.ReportType;
                    txtSampleSize.Text = objQCReport.SampleSize;
                    txtSendBy.Text = objEmployeeDL.Get(objQCReport.SendBy).EmployeeNameID;
                    txtSendDate.Text = objQCReport.SendDate.Value.ToShortDateString();
                    txtQcStatus.Text = Enum.Parse(typeof(QCReport.ReportStatus), objQCReport.Status.ToString()).ToString();
                    if (objQCReport.RDQAOfficer != null)
                    {
                        txtRDQAOfficer.Text = objEmployeeDL.Get(objQCReport.RDQAOfficer).EmployeeNameID;
                    }

                    if (objQCReport.AnalyzedBy != null)
                    {
                        txtAnalizedBy.Text = objEmployeeDL.Get(objQCReport.AnalyzedBy).EmployeeNameID;
                    }

                    if (objQCReport.TestBy != null)
                    {
                        txtTestBy.Text = objEmployeeDL.Get(objQCReport.TestBy).EmployeeNameID;
                    }
                   
                }
            }
            catch (Exception)
            {

                MessageBox.Show(this,"Error occured while loading report","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void btnQCMore_Click(object sender, EventArgs e)
        {
            try
            {
                if (objQCReport != null)
                {
                    frmQCDetailView objFrm = new frmQCDetailView(CurrentUser, objQCReport);
                    objFrm.ShowDialog(this);
                }
            }
            catch (Exception)
            {

                MessageBox.Show(this,"Error occured while loading Report details","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void grpQC_Enter(object sender, EventArgs e)
        {

        }

        private void btnSendReport_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDecimal(txtReportSampleSize.Text) > 0)
                {
                    if (objRPDBatchActivityDL.GetActivityCount_ByStatus(objRPDBatch.RPDBatchID, (int)RPDBatchActivity.Status.Initial, (int)RPDBatchActivity.Status.Started).Rows.Count > 0)
                    {
                        MessageBox.Show(this, "Please Finish all Activities before Send QC", "Wrong Attempt", MessageBoxButtons.OK);
                    }
                    else
                    {
                        QCReport obj = new QCReport();
                        obj.SendBy = CurrentUser.UserEmp.EmployeeID;
                        obj.RPDBatchID = objRPDBatch.RPDBatchID;
                        obj.ReportType = "RPD";
                        obj.Remarks = "N/A";

                        obj.SampleSize = txtReportSampleSize.Text;


                        obj.Status = Convert.ToInt32(QCReport.ReportStatus.Initial);

                        long ID = objQCReport_DL.Add_RPD(obj);
                        if (ID > 0)
                        {
                            bindReports.DataSource = objQCReport_DL.GetView_RPD(objRPDBatch.RPDBatchID);
                            txtReportSampleSize.Text = "";

                        }
                    }
                }
                else
                {
                    MessageBox.Show(this,"Please enter valid Sample Size","Invalid Value",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }

            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void ucMaterialSelect1_MaterialSelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGenCost_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show(this, "Are you sure you want to finalize this RPD batch file?\n\nClick Yes to finalize", "Are yo sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.Yes)
                {
                    int res = objRPDBatchDL.UpdateUnitCost(objRPDBatch.RPDBatchID);

                    int x = objRPDBatchDL.Update_Cost(objRPDBatch.RPDBatchID,CurrentUser.EmployeeID);

                    objRPDBatch.Status = RPDBatch.RPDBatchStatus.Cost;
                    objRPDBatch.EndBy = CurrentUser.UserEmp;
                    int res1 = objRPDBatchDL.Update_Finish(objRPDBatch);

                    if (res1 > 0)
                    {
                        bindActual.DataSource = objRPDBatchActualProductionDL.Get(objRPDBatch.RPDBatchID);
                        //MessageBox.Show(this);
                        objRPDBatch = null;
                        MessageBox.Show(this, "Successfully calculated the cost and sent to Approval", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        rbCheckedChanged(sender, e);
                        //this.cmbRPDBatchID_SelectedIndexChanged(sender, e);
                    }

                }



            }
            catch (Exception)
            {

                MessageBox.Show(this, "Error occured while calculating cost", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Load_PackingMaterials()
        {
            try
            {
                //cmbMaterial_Packing.DataSource=obj
            }
            catch (Exception)
            {

                MessageBox.Show(this, "Error occured while calculating cost", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cmbRPDBatchID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                bindActivities.DataSource = null;
                bindActual.DataSource = null;
                bindingSource1.DataSource = null;
                bindInstructions.DataSource = null;
                bindMaterialUsage.DataSource = null;
                bindMR.DataSource = null;
                bindPackingDetails.DataSource = null;
                bindProduction.DataSource = null;
                bindReports.DataSource = null;


                ClearActivityTab();
                ClearPackingDetails();

                if (cmbRPDBatchID.SelectedValue != null)
                {
                    String ID = cmbRPDBatchID.SelectedValue.ToString();
                    objRPDBatch = objRPDBatchDL.Get(ID);
                    if (objRPDBatch != null)
                    {
                        txtApprovedBy.Text = objRPDBatch.ApprovedBy.EmployeeNameID;
                        txtEndBy.Text = objRPDBatch.EndBy.EmployeeNameID;
                        txtInstructedBy.Text = objRPDBatch.RPDBatchInstructedBy.EmployeeNameID;
                        txtMaterial.Text = objRPDBatch.RPDBatchMaterial.MaterialNameCode;
                        lblunit.Text = objRPDBatch.RPDBatchMaterial.MatUnit.UnitCode;
                        lblUnit3.Text = objRPDBatch.RPDBatchMaterial.MatUnit.UnitCode;
                        txtPRPDBatchID.Text = objRPDBatch.RPDBatchID;
                        txtQuantity.Text = objRPDBatch.RPDBatchQty.ToString();
                        txtSupervisedBy.Text = objRPDBatch.RPDBatchSupervisedBy.EmployeeNameID;
                        txtType.Text = objRPDBatch.Type;
                        txtMRNO.Text = objRPDBatch.RPDBatchMR.MRNO.ToString() + " - " + objRPDBatch.RPDBatchMR.MRStatus.ToString(); ;
                        txtRecQty.Text = objMRMaterial_DL.Get(objRPDBatch.RPDBatchMR.MRNO, objRPDBatch.RPDBatchMaterial.MaterialCode).IssuedQty.ToString();

                        if (objRPDBatch.RPDBatchStartDate.HasValue)
                        {
                            txtStartedDate.Text = objRPDBatch.RPDBatchStartDate.Value.ToShortDateString();
                        }
                        else
                        {
                            txtStartedDate.Text = "Not Started";
                        }

                        gvActivity.AutoGenerateColumns = false;
                        bindActivities.DataSource = objRPDBatchActivityDL.GetDataView(objRPDBatch.RPDBatchID);
                        gvActivity.DataSource = bindActivities;
                        bindActivities.ResetBindings(true);

                        gvInstructions.AutoGenerateColumns = false;
                        bindInstructions.DataSource = objRPDBatchActivityInstructionsDL.GetDataView(objRPDBatch.RPDBatchID);
                        gvInstructions.DataSource = bindInstructions;
                        bindInstructions.ResetBindings(true);

                        
                        gvProduction.AutoGenerateColumns = false;
                        bindProduction.DataSource = objRPDBatchProductionDL.GetDataByBatchID(objRPDBatch.RPDBatchID);
                        gvProduction.DataSource = bindProduction;
                        bindProduction.ResetBindings(true);


                        gvReports.AutoGenerateColumns = false;
                        bindReports.DataSource = objQCReport_DL.GetView_RPD(objRPDBatch.RPDBatchID);
                        gvReports.DataSource = bindReports;
                        bindReports.ResetBindings(true);

                        gvActualProduction.AutoGenerateColumns = false;
                        bindActual.DataSource = objRPDBatchActualProductionDL.Get(objRPDBatch.RPDBatchID);
                        gvActualProduction.DataSource = bindActual;
                        bindActual.ResetBindings(true);

                        txtBatchState.Text = objRPDBatch.Status.ToString();
                        LoadPackingDetails();
                       
                        if (objRPDBatch.Status == RPDBatch.RPDBatchStatus.Approved)
                        {
                            if (objRPDBatch.RPDBatchMR.MRStatus != MR.Status.Recevied)
                            {
                                btnStartSave.Enabled = false;
                                txtBatchState.Text = "MR Not Received";
                            }
                            else
                            {
                                btnStartSave.Enabled = true;
                            }
                            
                        }
                        else if (objRPDBatch.Status == RPDBatch.RPDBatchStatus.Finished)
                        {
                            btnTransfer.Enabled = true;
                            btnGenCost.Enabled = false;
                            btnDelete.Enabled = false;
                        }
                        else if (objRPDBatch.Status == RPDBatch.RPDBatchStatus.Started)
                        {
                            btnTransfer.Enabled = false;
                            btnGenCost.Enabled = true;
                        }
                        else
                        {
                            btnTransfer.Enabled = false;
                            btnGenCost.Enabled = false;
                            btnDelete.Enabled = false;
                        }


                        Load_PackingIssued();
                                
                    }
                    else
                    {
                        //btnEdit.Enabled = false;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show(this, "Error occured while Loading the RPD Batch", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void gvActivity_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    ClearActivityTab();
                    long ID = Convert.ToInt64(gvActivity.Rows[e.RowIndex].Cells["RPDBatchActID"].Value);
                    objRPDBatchActivity = objRPDBatchActivityDL.Get(ID);
                    if (objRPDBatchActivity != null)
                    {

                        txtID.Text = objRPDBatchActivity.RPDBatchActID.ToString();
                        txtMainActivity.Text = objMainActivityDL.Get(objRPDBatchActivity.MainActID).MainActivityTitle;
                        txtStatus.Text = objRPDBatchActivity.ActivityStatus.ToString();
                        if (objRPDBatchActivity.ActivityStatus == SESD.MRP.REF.RPDBatchActivity.Status.Initial)
                        {

                            btnEdit.Enabled = true;
                            btnDelete.Enabled = true;

                        }
                        else if (objRPDBatchActivity.ActivityStatus == RPDBatchActivity.Status.Started)
                        {
                            btnDetails.Enabled = true;
                            grpStopAct.Enabled = true;

                        }
                        else if (objRPDBatchActivity.ActivityStatus == RPDBatchActivity.Status.Finalized)
                        {

                        }

                        LoadActivityDetails();

                    }

                }
                catch (Exception)
                {

                    MessageBox.Show(this, "Error occured while loading RPD Batch Activity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnDeleteUsage_Click_1(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show(this, "Are you sure you want to delete selected Usage detail?\n\nClick Yes to delete", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.Yes)
                {
                    int res = objRPDBatchPackingMaterialUsageDL.Delete(objRPDBatchPackingMaterialUsage.RPDBatch.RPDBatchID,
                        objRPDBatchPackingMaterialUsage.MR.MRNO,
                        objRPDBatchPackingMaterialUsage.Material.MaterialCode);
                }
            }
            catch (Exception)
            {

                MessageBox.Show(this, "Error occured while deleting Usage Detail", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cmbSupervisedByPackingDetails_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbRPDBatch_Click(object sender, EventArgs e)
        {
            LoadPackingDetails();

        }

        private void btnStopPackingAct_Click(object sender, EventArgs e)
        {
            if (!objQCReport_DL.IsRPDBatchAccept(objRPDBatch.RPDBatchID, (int)QCReport.ReportStatus.Accept))
            {
                MessageBox.Show(this, "Sysem does not allow to start Packing activity until quality test accepted", "QC Check Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (objRPDBatchPackingActivity != null)
                {
                    long ID = 0;

                    if (dtPackingFinishDate.Checked)
                    {
                        objRPDBatchPackingActivity.StopDate = dtPackingFinishDate.Value;
                        objRPDBatchPackingActivity.ActivityStatus = RPDBatchActivity.Status.Finalized;

                        ID = objRPDBatchActivityDL.Update(objRPDBatchPackingActivity);
                    }
                    else
                    {
                        objRPDBatchPackingActivity.ActivityStatus = SESD.MRP.REF.RPDBatchActivity.Status.Started;
                        ID = objRPDBatchActivityDL.Add(objRPDBatchPackingActivity);
                    }

                    if (ID > 0)
                    {

                        LoadPackingDetails();
                        if (objRPDBatchPackingActivity.ActivityStatus == RPDBatchActivity.Status.Finalized)
                        {
                            objRPDBatchActualProductionDL.Add(objRPDBatch.RPDBatchID);
                            bindActual.DataSource = objRPDBatchActualProductionDL.Get(objRPDBatch.RPDBatchID);
                        }
                        else if (objRPDBatchPackingActivity.ActivityStatus == RPDBatchActivity.Status.Started)
                        {
                            //btnSavePackingAct.Text = "Stop Activity";
                        }
                    }

                }
            }
        }

    

    }
}