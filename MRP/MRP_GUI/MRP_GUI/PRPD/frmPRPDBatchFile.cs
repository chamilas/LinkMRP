using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SESD.MRP.REF;
using DL;


namespace MRP_GUI
{
    public partial class frmPRPDBatchFile : System.Windows.Forms.Form
    {
        private QCReport objQCReport = new QCReport();
        private QCReport_DL objQCReport_DL = new QCReport_DL(ConnectionStringClass.GetConnection());
        BindingSource objBindingourceActDetails = new BindingSource();
        BindingSource objBindingSourceActIns = new BindingSource();
        BindingSource objSourceActInstructions = new BindingSource();
        BindingSource objEmpHan = new BindingSource();
        BindingSource objEmpOpe = new BindingSource();
        BindingSource objEmpIns = new BindingSource();
        BindingSource objEmpSup = new BindingSource();
        BindingSource objEmpRec = new BindingSource();
        
        PRPDBatch objPRPDBatch = new PRPDBatch();
        MainActivity objMainActivity = new MainActivity();
        Department objDepartment = new Department();
        
        PRPDBatch_DL objPRPDBatch_DL = new PRPDBatch_DL(ConnectionStringClass.GetConnection());
        Employee_DL objEmployee_DL = new Employee_DL(ConnectionStringClass.GetConnection());
        MainActivity_DL objMainActivity_DL = new MainActivity_DL(ConnectionStringClass.GetConnection());
        Department_DL objDepartment_DL = new Department_DL(ConnectionStringClass.GetConnection());

        DataTable dtWorkForce = new DataTable();
        DataTable dtStaff = new DataTable();
        DataTable dtPRPDBatcByState = new DataTable();
        DataTable dtPRPDBatchActivityInstructionsCollec = new DataTable();
        DataTable dtPRPDBatchActivityDetails = new DataTable();
        DataTable dtPRPDBatchActivityInstructions = new DataTable();
        DataTable dtMainActtivity_PRPD = new DataTable();

        MTN_DL objMTN_DL = new MTN_DL(ConnectionStringClass.GetConnection());
        MR_DL objMR_DL = new MR_DL(ConnectionStringClass.GetConnection());

        PRPDBatchActivityInstructions_DL objPRPDBatchActivityInstructions_DL = new PRPDBatchActivityInstructions_DL(ConnectionStringClass.GetConnection());
        RPDActivityMachineCollec objRPDActivityMachineCollec = new RPDActivityMachineCollec();
        RPDActivityMachine_DL objRPDActivityMachine_DL = new RPDActivityMachine_DL(ConnectionStringClass.GetConnection());
        PRPDBatchActivity_DL objPRPDBatchActivity_DL = new PRPDBatchActivity_DL(ConnectionStringClass.GetConnection());

        PRPDBatchActivity objPRPDBatchActivity;

        int index = 0;

        public frmPRPDBatchFile()
        {
            InitializeComponent();
          
        }

        public frmPRPDBatchFile(User objUser)
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
	

    
        private void frmPrimaryPreparationBatch_Load(object sender, EventArgs e)
        {
            try
            {
                objDepartment = objDepartment_DL.GetByDepType("PRPD");
                Load_Batches(objDepartment);

                dtStaff = objEmployee_DL.Get_By_RoleType( "Staff", true);

                objSourceSupervisedBy.DataSource = dtStaff;
                cmbSupervisedBy.DataSource = objSourceSupervisedBy;

                txtHandedOver.Text = CurrentUser.UserEmp.EmployeeNameID;
                txtInspected.Text = CurrentUser.UserEmp.EmployeeNameID;

   


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }

        }

        public void Load_Batches(Department objDep)
        {
            PRPDBatch.PRPDType TYPE1 = new PRPDBatch.PRPDType();
            PRPDBatch.PRPDType TYPE2 = new PRPDBatch.PRPDType();
            PRPDBatch.PRPDType TYPE3 = new PRPDBatch.PRPDType();

            try
            {

                //if ((objDep.DepHead.EmployeeID == CurrentUser.EmployeeID)|(objDepartment_DL.GetBySectionID(((int)objEmployee_DL.Get(CurrentUser.EmployeeID).Section))).DepType=="PRPD")
                //{
                    TYPE1 = PRPDBatch.PRPDType.PrimaryPreperation;
                    TYPE2 = PRPDBatch.PRPDType.PrimaryOutsource;
                    TYPE3 = PRPDBatch.PRPDType.Rework;

                    dtPRPDBatcByState = objPRPDBatch_DL.GetDataByStateAndType(PRPDBatch.PRPDBatchStatus.Approved, PRPDBatch.PRPDBatchStatus.Started,
                         TYPE1, TYPE2, TYPE3);


                //}
                
                if (dtPRPDBatcByState.Rows.Count != 0)
                {
                    cmbPRPDBatchID.DataSource = dtPRPDBatcByState;
                    cmbPRPDBatchID.SelectedIndex = 0;
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }

        }
   

        private void cmbPRPDBatchID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPRPDBatchID.Items.Count != 0)
            {
                try
                {
                    bool IsStart = false;

                    objPRPDBatch = objPRPDBatch_DL.Get(cmbPRPDBatchID.SelectedValue.ToString());

                    gvActivity.AutoGenerateColumns = false;
                    bindActivities.DataSource = objPRPDBatchActivity_DL.GetView(objPRPDBatch.PRPDBatchID);
                    gvActivity.DataSource = bindActivities;
                    bindActivities.ResetBindings(true);

                    txtMaterial.Text = objPRPDBatch.PRPDBatchMaterial.MaterialCode + " - " + objPRPDBatch.PRPDBatchMaterial.MaterialDescription;

                    MR obj = new MR();
                    obj = objMR_DL.Get(objPRPDBatch.MRIN);

                    if (obj.MRStatus == MR.Status.Recevied)
                    {
                        IsStart = true;
                    }


                    MRMaterial_DL objMRMaterialDL = new MRMaterial_DL(ConnectionStringClass.GetConnection());
                    MRMaterial objMRMat = objMRMaterialDL.Get(objPRPDBatch.MRIN, objPRPDBatch.PRPDBatchMaterial.MaterialCode);

                    if (objMRMat.IssuedQty <= 0)
                    {
                        IsStart = false;
                    }

                    
                    if (objPRPDBatch.Type == PRPDBatch.PRPDType.Rework)
                    {
                        lblTitle.Text = "Rework - "+objPRPDBatch.PRPDBatchID ;
                        txtNote.Text = obj.MRNO.ToString() + " - " + obj.MRStatus.ToString();
                        txtReceivedQty.Text = objMRMaterialDL.Get(obj.MRNO, objPRPDBatch.PRPDBatchMaterial.MaterialCode).IssuedQty.ToString();
                        lblNote.Text = "MRNO";
                        lblUnit4.Text = objPRPDBatch.PRPDBatchMaterial.MatUnit.UnitCode;
                        
                    }
                    else if (objPRPDBatch.Type == PRPDBatch.PRPDType.PrimaryOutsource)
                    {
                        lblTitle.Text = "Primary Outsource - " + objPRPDBatch.PRPDBatchID;
                        txtNote.Text = obj.MRNO.ToString() + " - " + obj.MRStatus.ToString();
                        txtReceivedQty.Text = objMRMaterialDL.Get(obj.MRNO, objPRPDBatch.PRPDBatchMaterial.MaterialCode).IssuedQty.ToString();
                        lblNote.Text = "MRNO";
                        lblUnit4.Text = objPRPDBatch.PRPDBatchMaterial.MatUnit.UnitCode;
                    }
                    else if (objPRPDBatch.Type == PRPDBatch.PRPDType.PrimaryPreperation)
                    {
                         lblTitle.Text = "Preperation - " + objPRPDBatch.PRPDBatchID;

                         txtNote.Text = obj.MRNO.ToString() + " - " + obj.MRStatus.ToString();
                         txtReceivedQty.Text = objMRMaterialDL.Get(obj.MRNO, objPRPDBatch.PRPDBatchMaterial.MaterialCode).IssuedQty.ToString();
                         lblNote.Text = "MRNO";
                         lblUnit4.Text = objPRPDBatch.PRPDBatchMaterial.MatUnit.UnitCode;

                    }

                    if (IsStart)
                    {
                        btnStartBatch.Enabled = true;
                        tbcPRPDBatchProduction.Enabled = true;

                        if (objPRPDBatch.Status == PRPDBatch.PRPDBatchStatus.Started)
                        {
                            tbcPRPDBatchProduction.Enabled = true;
                            btnStartBatch.Enabled = false;

                            cmbSupervisedBy.Enabled = false;

                        }
                        else if (objPRPDBatch.Status == PRPDBatch.PRPDBatchStatus.Approved)
                        {
                            tbcPRPDBatchProduction.Enabled = false;
                            btnStartBatch.Enabled = true;
                        }
                    }
                    else
                    {
                        btnStartBatch.Enabled = false;
                        tbcPRPDBatchProduction.Enabled = false;
                    }



                    dtMainActtivity_PRPD = objMainActivity_DL.Get_Data_PRPD_Activity(objPRPDBatch.PRPDBatchID);

                    cmbActivity.DataSource = dtMainActtivity_PRPD;

                    if (dtMainActtivity_PRPD.Rows.Count != 0)
                    {

                        cmbActivity.SelectedIndex = 0;
                    }

                    objPRPDBatch = objPRPDBatch_DL.Get(cmbPRPDBatchID.SelectedValue.ToString());


                    txtMaterial.Text = objPRPDBatch.PRPDBatchMaterial.MaterialCode + " - " + objPRPDBatch.PRPDBatchMaterial.MaterialDescription;

                    txtInstructedBy.Text = objPRPDBatch.PRPDBatchInstructedBy.EmployeeName;
                    txtQuantity.Text = objPRPDBatch.PRPDBatchQty.ToString();
                    dtpCreatedDate.Value = objPRPDBatch.PRPDBatchInstructedDate;

                    //Load Instructions

                    dtPRPDBatchActivityInstructions = objPRPDBatchActivityInstructions_DL.GetDataByBatchID(cmbPRPDBatchID.SelectedValue.ToString());

                    objSourceActInstructions.DataSource = dtPRPDBatchActivityInstructions;

                    dgvActivityInstructions.AutoGenerateColumns = false;
                    dgvActivityInstructions.DataSource = objSourceActInstructions;
                    objSourceActInstructions.ResetBindings(true);


                    txtBatchState.Text = Enum.GetName(typeof(PRPDBatch.PRPDBatchStatus), objPRPDBatch.Status).ToString();
                    lblUnit.Text = objPRPDBatch.PRPDBatchMaterial.MatUnit.UnitCode;
                    bindReports.DataSource = objQCReport_DL.GetView_PRPD(objPRPDBatch.PRPDBatchID);
                    if (objQCReport_DL.IsPRPDBatchAccept(objPRPDBatch.PRPDBatchID,(int)QCReport.ReportStatus.Accept))
                    {

                        grpFinalizeDetails.Enabled = true;

                    }
                    else
                    {
                        grpFinalizeDetails.Enabled = false;
                    }

                    lblUnit1.Text = objPRPDBatch.PRPDBatchMaterial.MatUnit.UnitCode;
                    lblUnit2.Text = objPRPDBatch.PRPDBatchMaterial.MatUnit.UnitCode;
                    lblUnit3.Text = objPRPDBatch.PRPDBatchMaterial.MatUnit.UnitCode;
                    lblUnitSample.Text = objPRPDBatch.PRPDBatchMaterial.MatUnit.UnitCode;
                    txtOutsourceQty.Text = "0";


                    //Load Reports

                    Load_Reports();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(this,"Error occured while loading","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);

                }

            }

        }

    
        private void tbpBatchInstructions_Enter(object sender, EventArgs e)
        {
            try
            {


                dtPRPDBatchActivityInstructions=objPRPDBatchActivityInstructions_DL.GetDataByBatchID(cmbPRPDBatchID.SelectedValue.ToString());

                objSourceActInstructions.DataSource = dtPRPDBatchActivityInstructions;

                dgvActivityInstructions.AutoGenerateColumns = false;
                dgvActivityInstructions.DataSource = objSourceActInstructions;
                objSourceActInstructions.ResetBindings(true);


               
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           
            
            if ((txtFinalQty.Text != "") && (txtSampleSize.Text != "") && (txtImpurities.Text != ""))
            {
                try
                {
                    if (objQCReport_DL.IsPRPDBatchAccept(objPRPDBatch.PRPDBatchID,(int)QCReport.ReportStatus.Accept))
                    {
                        if (txtComments.Text == "")
                        {
                            objPRPDBatch.PRPDBatchComments = "N/A";
                        }
                        else
                        {
                            objPRPDBatch.PRPDBatchComments = txtComments.Text;
                        }

                        if (objPRPDBatch.Type == PRPDBatch.PRPDType.PrimaryOutsource)
                        {
                            objPRPDBatch.OutSourceQty = Convert.ToDecimal(txtOutsourceQty.Text);
                        }
                        else
                        {
                            objPRPDBatch.OutSourceQty = 0;
                        }
                        objPRPDBatch.PRPDBatchEndDate = dtpDateHandOver.Value;
                        objPRPDBatch.PRPDBatchFinalQty = Convert.ToDecimal(txtFinalQty.Text);
                        objPRPDBatch.PRPDBatchEndBy = CurrentUser.UserEmp;
                        objPRPDBatch.PRPDBatchTotalImpurities = Convert.ToDecimal(txtImpurities.Text);
                        objPRPDBatch.PRPDSampleSize = txtSampleSize.Text;
                        objPRPDBatch.Status = PRPDBatch.PRPDBatchStatus.Finished;

                        MRMaterial objMRMaterial = new MRMaterial();
                         MRMaterial_DL objMRMaterial_DL = new MRMaterial_DL(ConnectionStringClass.GetConnection());

                        objMRMaterial=objMRMaterial_DL.Get(objPRPDBatch.MRIN,objPRPDBatch.PRPDBatchMaterial.MaterialCode);

                        if ((objPRPDBatch.PRPDBatchFinalQty > 0)&&(objMRMaterial.IssuedQty>=objPRPDBatch.PRPDBatchFinalQty))
                        {

                            if (objPRPDBatch.Type == PRPDBatch.PRPDType.PrimaryOutsource)
                            {
                                if (objPRPDBatch.OutSourceQty > 0)
                                {
                                    Decimal sampleQty = Convert.ToDecimal(objPRPDBatch.PRPDSampleSize);

                                    objPRPDBatch_DL.Update_Finish(objPRPDBatch);

                                    //Update Batch Cost

                                    objPRPDBatch_DL.Update_BatchCost(objPRPDBatch.PRPDBatchID, CurrentUser.EmployeeID,(int)objPRPDBatch.Type);

                                    Load_Batches(objDepartment);

                                    MessageBox.Show(this, "Successfully Saved and the Batch File is sent for Costing Approval", "Save Records", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    if (cmbPRPDBatchID.Items.Count <= 0)
                                    {
                                        MessageBox.Show(this, "Approved Batch file list Empty", "No Approved Batch Files", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        this.Close();
                                    }
                                    else
                                    {
                                        cmbPRPDBatchID_SelectedIndexChanged(sender, e);
                                        grpFinalizeDetails.Enabled = false;
                                    }

                                }
                                else
                                {
                                    MessageBox.Show(this, "Outsource Qty Need to be greater than Zero", "Invalid Qty", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                            else
                            {
                                Decimal sampleQty = Convert.ToDecimal(objPRPDBatch.PRPDSampleSize);

                                objPRPDBatch_DL.Update_Finish(objPRPDBatch);

                                //Update Batch Cost

                                objPRPDBatch_DL.Update_BatchCost(objPRPDBatch.PRPDBatchID, CurrentUser.EmployeeID,(int)objPRPDBatch.Type);

                                Load_Batches(objDepartment);

                                MessageBox.Show(this, "Successfully Saved and the Batch File is sent for Costing Approval", "Save Records", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                if (cmbPRPDBatchID.Items.Count <= 0)
                                {
                                    MessageBox.Show(this, "Approved Batch file list Empty", "No Approved Batch Files", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                }
                                else
                                {
                                    cmbPRPDBatchID_SelectedIndexChanged(sender, e);
                                    grpFinalizeDetails.Enabled = false;
                                }

                            }
                           




                        }
                        else
                        {
                            MessageBox.Show(this, "Invalid Final Quantity", "Invalid Value", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        

                    }
                    else
                    {
                        MessageBox.Show(this,"PRPD Batch Quality test incomplete","Quality Test",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    }




                }
                catch (Exception ex)
                {

                    MessageBox.Show(this,"Error occured while finalizing","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);

                }
            }
            else
            {
                MessageBox.Show(this, "Please Fill All Fields", "Fill Records", MessageBoxButtons.OK);

            }
        }



        private void tbpPRPDBatchFinalize_Enter(object sender, EventArgs e)
        {
            try
            {

                dtStaff = objEmployee_DL.Get_By_RoleType("Staff",true);

                objEmpHan.DataSource = dtStaff;
                objEmpIns.DataSource = dtStaff;
                objEmpRec.DataSource = dtStaff;

             
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnStartBatch_Click(object sender, EventArgs e)
        {
            if (cmbSupervisedBy.SelectedValue != null)
            {
                index = cmbPRPDBatchID.SelectedIndex;

                try
                {

                    objPRPDBatch.Status = PRPDBatch.PRPDBatchStatus.Started;
                    objPRPDBatch.PRPDBatchSuperviser = objEmployee_DL.Get(cmbSupervisedBy.SelectedValue.ToString());
                    objPRPDBatch.PRPDBatchStartDate = DateTime.Today;
                    objPRPDBatch.PRPDBatchStartedBy = objEmployee_DL.Get(CurrentUser.EmployeeID);

                    objPRPDBatch_DL.UpdateStartingDetails(objPRPDBatch);

                    Load_Batches(objDepartment);

                    cmbPRPDBatchID.SelectedIndex = index;
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message.ToString());

                }
            }
            else
            {
                MessageBox.Show(this, "Please Select a Supervisor Before Start the Batch", "Fill Data", MessageBoxButtons.OK);

            }
            }

        private void btnSendReport_Click(object sender, EventArgs e)
        {
            try
            {

                QCReport obj = new QCReport();
                obj.SendBy = CurrentUser.UserEmp.EmployeeID;
                obj.PRPDBatchID = objPRPDBatch.PRPDBatchID;
                obj.ReportType = "PRPD";
                obj.SampleSize = txtReportSampleSize.Text;
                obj.Status = Convert.ToInt32(QCReport.ReportStatus.Initial);
                obj.Remarks = "N/A";

                if ((objPRPDBatchActivity_DL.ActivityCount(objPRPDBatch.PRPDBatchID, PRPDBatchActivity.ActStatus.Initial) > 0) || (objPRPDBatchActivity_DL.ActivityCount(objPRPDBatch.PRPDBatchID, PRPDBatchActivity.ActStatus.Started)) > 0)
                {
                    MessageBox.Show(this,"You should finish all activities before send to the Test","Information",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
                else
                {
                    long ID = objQCReport_DL.Add_PRPD(obj);
                    if (ID > 0)
                    {
                        Load_Reports();

                        txtReportSampleSize.Text = "0.00";

                    }
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void Load_Reports()
        {

            try
            {
            dgvReports.AutoGenerateColumns = false;
            bindReports.DataSource = objQCReport_DL.GetView_PRPD(objPRPDBatch.PRPDBatchID);
            dgvReports.DataSource = bindReports;
            bindReports.ResetBindings(true);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }


        }

        private void btnQCMore_Click(object sender, EventArgs e)
        {
            try
            {
                if (objQCReport != null)
                {
                    //QC.frmQCDetailView objFrm = new MRP_GUI.QC.frmQCDetailView(CurrentUser, objQCReport);
                    //objFrm.ShowDialog(this);
                }
            }
            catch (Exception)
            {

                MessageBox.Show(this, "Error occured while loading Report details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvReports_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    objQCReport = objQCReport_DL.Get(Convert.ToInt64(dgvReports.Rows[e.RowIndex].Cells["QCReportID"].Value));
                    if (objQCReport != null)
                    {
                        txtReportID.Text = objQCReport.QCReportID.ToString();
                        txtReportType.Text = objQCReport.ReportType;
                        txtSampleSize.Text = objQCReport.SampleSize;
                        txtSendBy.Text = objEmployee_DL.Get(objQCReport.SendBy).EmployeeNameID;
                        txtSendDate.Text = objQCReport.SendDate.Value.ToShortDateString();
                        if (objQCReport.RDQAOfficer != null)
                        {
                            txtRDQAOfficer.Text = objEmployee_DL.Get(objQCReport.RDQAOfficer).EmployeeNameID;
                        }

                        if (objQCReport.AnalyzedBy != null)
                        {
                            txtAnalizedBy.Text = objEmployee_DL.Get(objQCReport.AnalyzedBy).EmployeeNameID;
                        }

                        if (objQCReport.TestBy != null)
                        {
                            txtTestBy.Text = objEmployee_DL.Get(objQCReport.TestBy).EmployeeNameID;
                        }

                        lblStatus.Text = ((QCReport.ReportStatus)objQCReport.Status).ToString();

                    }
                }
                catch (Exception)
                {

                    MessageBox.Show(this, "Error occured while loading report", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }

        private void ucsPRPDBatchFileActUseMachines1_Load(object sender, EventArgs e)
        {

        }

        private void btnAddNewActivity_Click(object sender, EventArgs e)
        {
            PRPD.PRPDBatchActivityForms.frmAddPRPDActivity objFrm = new MRP_GUI.PRPD.PRPDBatchActivityForms.frmAddPRPDActivity(CurrentUser, objPRPDBatch);
            objFrm.ShowDialog(this);
            bindActivities.DataSource = objPRPDBatchActivity_DL.GetView(objPRPDBatch.PRPDBatchID);

        }

        private void gvActivity_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                objPRPDBatchActivity = objPRPDBatchActivity_DL.Get(Convert.ToInt64(gvActivity.CurrentRow.Cells["PRPDBatchActID"].Value));
                if (objPRPDBatchActivity.PRPDBatchActivityID != 0)
                {
                    txtID.Text = objPRPDBatchActivity.PRPDBatchActivityID.ToString();
                    MainActivity objmainAct = objMainActivity_DL.Get(objPRPDBatchActivity.MainActID);
                    txtMainActivity.Text = objmainAct.MainActivityTitle;
                    txtStatus.Text = objPRPDBatchActivity.State.ToString();
                    dtStartActivity.Value = objPRPDBatchActivity.StartedDate;
                    txtStartQty.Text = objPRPDBatchActivity.StartQty.ToString();

                    if (objPRPDBatchActivity.StopQty != 0)
                    {
                        txtStopQty.Text = objPRPDBatchActivity.StopQty.ToString();
                    }
                    else
                    {
                        txtStopQty.Text = "0";
                    }

                    //if (objPRPDBatchActivity.EndDate != null)
                    //{
                    //    dtStopActivity.Value = objPRPDBatchActivity.EndDate;
                    //}


                    if (gvActivity.CurrentCell.OwningColumn.Name.Equals("ColAddDetails"))
                    {
                        if (objPRPDBatchActivity.State == PRPDBatchActivity.ActStatus.Started)
                        {
                            //PRPD.PRPDBatchActivityForms.frmPRPDActDetails objFrm = new MRP_GUI.PRPD.PRPDBatchActivityForms.frmPRPDActDetails(CurrentUser, objPRPDBatchActivity);
                            //objFrm.ShowDialog(this);
                            grpActivityDetails.Enabled = true;
                        }
                        else if (objPRPDBatchActivity.State == PRPDBatchActivity.ActStatus.Initial)
                        {
                            MessageBox.Show(this,"Activity not started","Activity Status",MessageBoxButtons.OK,MessageBoxIcon.Warning);

                            grpActivityDetails.Enabled = true;
                        }
                        else if (objPRPDBatchActivity.State == PRPDBatchActivity.ActStatus.Finished)
                        {
                            grpActivityDetails.Enabled = false;
                            MessageBox.Show(this, "Activity Finished", "Activity Status", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        }

                    }


                    if (objPRPDBatchActivity.State == PRPDBatchActivity.ActStatus.Initial)
                    {

                        btnEdit.Enabled = true;
                        btnDelete.Enabled = true;
                        grpActivityDetails.Enabled = true;
                    }
                    else if (objPRPDBatchActivity.State == PRPDBatchActivity.ActStatus.Started)
                    {
                        btnDetails.Enabled = true;
                        grpActivityDetails.Enabled = true;
                    }
                    else if (objPRPDBatchActivity.State == PRPDBatchActivity.ActStatus.Finished)
                    {
                        grpActivityDetails.Enabled = false;
                        btnDetails.Enabled = false;
                        btnEdit.Enabled = false;
                        btnDelete.Enabled = false;
                    }

                }
            }
            catch (Exception)
            {

                MessageBox.Show(this,"Error loading activity","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void btnStartActivity_Click(object sender, EventArgs e)
        {
            try
            {
                objPRPDBatchActivity.StopQty = Convert.ToDecimal(txtStopQty.Text);
                objPRPDBatchActivity.EndDate = dtpStopDate.Value;
               objPRPDBatchActivity.State = PRPDBatchActivity.ActStatus.Finished;
               objPRPDBatchActivity.Comments = "N/A";

               int res = objPRPDBatchActivity_DL.Update(objPRPDBatchActivity);
               if (res > 0)
                {
                    bindActivities.DataSource = objPRPDBatchActivity_DL.GetView(objPRPDBatch.PRPDBatchID);
                    grpActivityDetails.Enabled = false;
                    btnDetails.Enabled = true;
                    btnEdit.Enabled = false;
                    btnDelete.Enabled = false;
                }

            }
            catch (Exception)
            {

                MessageBox.Show(this, "Error occured while Ending Activity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnStopActivity_Click(object sender, EventArgs e)
        {

            try
            {
                objPRPDBatchActivity.EndDate = dtpStopDate.Value;
               // objPRPDBatchActivity.EndBy = CurrentUser.UserEmp;
                objPRPDBatchActivity.State = PRPDBatchActivity.ActStatus.Finished;
                //PRPDBatchActivityDetails_DL objPRPDBatchActivityDetails_DL = new PRPDBatchActivityDetails_DL(ConnectionStringClass.GetConnection());
                //if (objPRPDBatchActivityDetails_DL.GetNotFinishedCount(objPRPDBatchActivity.PRPDBatchActivityID) <= 0)
                //{


                //    int res = objPRPDBatchActivity_DL.Update(objPRPDBatchActivity, objPRPDBatchActivity.PRPDBatchActivityID);
                //    if (res > 0)
                //    {
                //        bindActivities.DataSource = objPRPDBatchActivity_DL.GetView(objPRPDBatch.PRPDBatchID);
                //        grpStartAct.Enabled = false;
                //        grpStopAct.Enabled = false;
                //        btnDetails.Enabled = false;
                //        btnEdit.Enabled = false;
                //        btnDelete.Enabled = false;
                //    }
                //}
                //else
                //{
                //    MessageBox.Show(this, "Please enter the Stop time of all Activity Detail records", "Incomplete Activity Details", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                //}

            }
            catch (Exception)
            {

                MessageBox.Show(this, "Error occured while saving Stop Date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void ClearActivityTab()
        {
            txtStatus.Text = "";
            txtMainActivity.Text = "";
            txtID.Text = "";
            objPRPDBatchActivity = null;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnDetails.Enabled = false;
            grpActivityDetails.Enabled = false;
        }

        private void btnClearActTab_Click(object sender, EventArgs e)
        {
            ClearActivityTab();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show(this, "Are you sure you want to delete selected PRPD batch Activity?\n\nClick Yes to delete", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.Yes)
                {
                    int res = objPRPDBatchActivity_DL.Delete(objPRPDBatchActivity.PRPDBatchActivityID);
                    if (res > 0)
                    {
                        ClearActivityTab();
                        bindActivities.DataSource = objPRPDBatchActivity_DL.GetView(objPRPDBatch.PRPDBatchID);
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show(this, "Error occured while deleting PRPD Batch Activity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                PRPD.PRPDBatchActivityForms.frmAddPRPDActivity objFrm = new MRP_GUI.PRPD.PRPDBatchActivityForms.frmAddPRPDActivity(CurrentUser, objPRPDBatch, objPRPDBatchActivity);
                objFrm.ShowDialog();
                bindActivities.DataSource = objPRPDBatchActivity_DL.GetView(objPRPDBatch.PRPDBatchID);
                ClearActivityTab();
            }
            catch (Exception)
            {

                MessageBox.Show(this, "Error occured while loading PRPD Batch Activity Edit form", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            //PRPD.PRPDBatchActivityForms.frmPRPDActDetails objFrm = new MRP_GUI.PRPD.PRPDBatchActivityForms.frmPRPDActDetails(CurrentUser, objPRPDBatchActivity);
            //objFrm.ShowDialog(this);

        }

        private void tbcPRPDBatchProduction_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cmbPRPDBatchID_SelectedIndexChanged(sender, e);
            if (tbcPRPDBatchProduction.SelectedTab == tbpPRPDBatchFinalize)
            {
                txtFinalQty.Focus();
                txtFinalQty.SelectAll();
            }
        }

        private void gvActivity_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                objPRPDBatchActivity = objPRPDBatchActivity_DL.Get(Convert.ToInt64(gvActivity.Rows[e.RowIndex].Cells["PRPDBatchActID"].Value));
                if (objPRPDBatchActivity != null)
                {
                    txtID.Text = objPRPDBatchActivity.PRPDBatchActivityID.ToString();
                    MainActivity objmainAct = objMainActivity_DL.Get(objPRPDBatchActivity.MainActID);
                    txtMainActivity.Text = objmainAct.MainActivityTitle;
                    txtStatus.Text = objPRPDBatchActivity.State.ToString();

                    //if (objPRPDBatchActivity.State == PRPDBatchActivity.ActStatus.Started)
                    //{

                    //}
                    //else
                    //{
                    //    MessageBox.Show(this, "Activity not started", "Activity Status", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //}


                    if (objPRPDBatchActivity.State == PRPDBatchActivity.ActStatus.Initial)
                    {

                        btnEdit.Enabled = true;
                        btnDelete.Enabled = true;
                        grpActivityDetails.Enabled = true;
                        MessageBox.Show(this, "Activity not started", "Activity Status", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    else if (objPRPDBatchActivity.State == PRPDBatchActivity.ActStatus.Started)
                    {
                        frmPRPDBatchActivity obj = new frmPRPDBatchActivity(_CurrentUser, objPRPDBatchActivity.PRPDBatchActivityID);
                        obj.ShowDialog();
                        obj.StartPosition = FormStartPosition.CenterScreen;
                    }
                    else if (objPRPDBatchActivity.State == PRPDBatchActivity.ActStatus.Finished)
                    {
                        grpActivityDetails.Enabled = false;
                        btnDetails.Enabled = false;
                        btnEdit.Enabled = false;
                        btnDelete.Enabled = false;
                        //MessageBox.Show(this, "Activity Finished", "Activity Status", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        frmPRPDBatchActivity obj = new frmPRPDBatchActivity(_CurrentUser, objPRPDBatchActivity.PRPDBatchActivityID);
                        obj.ShowDialog();
                        obj.StartPosition = FormStartPosition.CenterScreen;


                    }

                }
            }
            catch (Exception)
            {

                MessageBox.Show(this, "Error loading activity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvReports_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                try
                {
                    objQCReport = objQCReport_DL.Get(Convert.ToInt64(dgvReports.Rows[e.RowIndex].Cells["colQCReportID"].Value));
                    if (objQCReport != null)
                    {
                        txtReportID.Text = objQCReport.QCReportID.ToString();
                        txtReportType.Text = objQCReport.ReportType;
                        txtSampleSize.Text = objQCReport.SampleSize;
                        txtSendBy.Text = objEmployee_DL.Get(objQCReport.SendBy).EmployeeNameID;
                        txtSendDate.Text = objQCReport.SendDate.Value.ToShortDateString();
                        if (objQCReport.RDQAOfficer != null)
                        {
                            txtRDQAOfficer.Text = objEmployee_DL.Get(objQCReport.RDQAOfficer).EmployeeNameID;
                        }

                        if (objQCReport.AnalyzedBy != null)
                        {
                            txtAnalizedBy.Text = objEmployee_DL.Get(objQCReport.AnalyzedBy).EmployeeNameID;
                        }

                        if (objQCReport.TestBy != null)
                        {
                            txtTestBy.Text = objEmployee_DL.Get(objQCReport.TestBy).EmployeeNameID;
                        }

                        lblStatus.Text = ((QCReport.ReportStatus)objQCReport.Status).ToString();
                        if (objQCReport != null)
                        {
                            //QC.frmQCDetailView objFrm = new MRP_GUI.QC.frmQCDetailView(CurrentUser, objQCReport);
                            //objFrm.ShowDialog(this);
                        }
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show(this, "Error occured while loading report", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }

        private void dtStartActivity_ValueChanged(object sender, EventArgs e)
        {

        }

      


    }

}