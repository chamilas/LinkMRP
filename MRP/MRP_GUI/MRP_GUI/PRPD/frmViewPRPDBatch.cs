using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DL;
using SESD.MRP.REF;
using MRP_GUI;

namespace MRP_GUI.PRPD
{
    public partial class frmViewPRPDBatch : System.Windows.Forms.Form
    {
        public frmViewPRPDBatch()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


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

        public frmViewPRPDBatch(User objUser, PRPDBatch objPRPDBatch)
        {
            this.objPRPDBatch = objPRPDBatch;
            InitializeComponent();
            CurrentUser = objUser;
        }
        private User _CurrentUser;

        public User CurrentUser
        {
            get { return _CurrentUser; }
            set { _CurrentUser = value; }
        }
	
        private void frmViewPRPDBatch_Load(object sender, EventArgs e)
        {
            try
            {
                Load_Activity();
                Load_QC();
                Load_Instructions();
                //bool IsStart = false;
                if (objPRPDBatch.Type == PRPDBatch.PRPDType.Rework)
                {
                    lblTitle.Text = "Rework - " + objPRPDBatch.PRPDBatchID;

                    MTN obj = objMTN_DL.Get(objPRPDBatch.PRPDBatchMTNIN);
                      txtNote.Text = obj.MTNNo.ToString() + " - " + obj.MTNStatus.ToString();
                    lblNote.Text = "MTN NO";

                }
                else if (objPRPDBatch.Type == PRPDBatch.PRPDType.PrimaryOutsource)
                {
                    lblTitle.Text = "Primary Outsource - " + objPRPDBatch.PRPDBatchID;
                    MTN obj = objMTN_DL.Get(objPRPDBatch.PRPDBatchMTNIN);


                    txtNote.Text = obj.MTNNo.ToString() + " - " + obj.MTNStatus.ToString();
                    lblNote.Text = "MTN NO";
                }
                else if (objPRPDBatch.Type == PRPDBatch.PRPDType.PrimaryPreperation)
                {
                    lblTitle.Text = "Preperation - " + objPRPDBatch.PRPDBatchID;

                    MR obj = objMR_DL.Get(objPRPDBatch.MRIN);
                    txtNote.Text = obj.MRNO.ToString() + " - " + obj.MRStatus.ToString();
                    lblNote.Text = "MR NO";

                }




                dtMainActtivity_PRPD = objMainActivity_DL.Get_Data_PRPD_Activity(objPRPDBatch.PRPDBatchID);


                //objPRPDBatch = objPRPDBatch_DL.Get(cmbPRPDBatchID.SelectedValue.ToString());


                txtMaterial.Text = objPRPDBatch.PRPDBatchMaterialName;
                txtInstructedBy.Text = objPRPDBatch.PRPDBatchInstructedBy.EmployeeName;
                txtQuantity.Text = objPRPDBatch.PRPDBatchQty.ToString();

                //Load Instructions

                dtPRPDBatchActivityInstructions = objPRPDBatchActivityInstructions_DL.GetDataByBatchID(objPRPDBatch.PRPDBatchID);
                objSourceActInstructions.DataSource = dtPRPDBatchActivityInstructions;
                objSourceActInstructions.ResetBindings(true);
                txtBatchState.Text = Enum.GetName(typeof(PRPDBatch.PRPDBatchStatus), objPRPDBatch.Status).ToString();
                lblUnit.Text = objPRPDBatch.PRPDBatchMaterial.MatUnit.UnitCode;
                lblUnit1.Text = objPRPDBatch.PRPDBatchMaterial.MatUnit.UnitCode;
                lblUnit2.Text = objPRPDBatch.PRPDBatchMaterial.MatUnit.UnitCode;
                lblUnit3.Text = objPRPDBatch.PRPDBatchMaterial.MatUnit.UnitCode;
                txtDate.Text = objPRPDBatch.PRPDBatchStartDate.ToShortDateString();
                txtBatchNo.Text = objPRPDBatch.PRPDBatchID;
                txtCreateDate.Text = objPRPDBatch.PRPDBatchInstructedDate.ToShortDateString();
                txtSupervisedBy.Text = objPRPDBatch.PRPDBatchSuperviser.EmployeeNameID;
                txtHandedOver.Text = objPRPDBatch.PRPDBatchHandOverBy.EmployeeNameID;
                txtInspected.Text = objPRPDBatch.PRPDBatchInspectedBy.EmployeeNameID;
                txtFinalQty.Text = objPRPDBatch.PRPDBatchFinalQty.ToString();
                txtImpurities.Text = objPRPDBatch.PRPDBatchTotalImpurities.ToString();
                txtSampleSize.Text = objPRPDBatch.PRPDSampleSize.ToString();

                if (objPRPDBatch.Status == PRPDBatch.PRPDBatchStatus.Finished || objPRPDBatch.Status == PRPDBatch.PRPDBatchStatus.Transfered)
                {
                    btnCost.Enabled = true;
                }
                else
                {
                    btnCost.Enabled = false;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(this, "Error occured while loading", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void Load_Instructions()
        {
            dgvInstructions.AutoGenerateColumns = false;
            binddgvInstructions.DataSource = objPRPDBatchActivityInstructions_DL.GetDataByBatchID(objPRPDBatch.PRPDBatchID);
            dgvInstructions.DataSource = binddgvInstructions;
            binddgvInstructions.ResetBindings(true);
        }

        private void Load_QC()
        {
            dgvReports.AutoGenerateColumns = false;
            bindReports.DataSource = objQCReport_DL.GetView_PRPD(objPRPDBatch.PRPDBatchID);
            dgvReports.DataSource = bindReports;
            bindReports.ResetBindings(true);
        }

        private void Load_Activity()
        {
           try
           {
            gvActivity.AutoGenerateColumns = false;
            bindActivities.DataSource = objPRPDBatchActivity_DL.GetView(objPRPDBatch.PRPDBatchID);
            gvActivity.DataSource = bindActivities;
            bindActivities.ResetBindings(true);

           }
           catch (Exception ex)
           {

               MessageBox.Show(this, "Error occured while loading", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

           }
        }

        private void gvActivity_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                objPRPDBatchActivity = objPRPDBatchActivity_DL.Get(Convert.ToInt64(gvActivity.CurrentRow.Cells["PRPDBatchActivity"].Value));
                if (objPRPDBatchActivity != null)
                {

                    frmPRPDBatchActivity_View obj = new frmPRPDBatchActivity_View(_CurrentUser, objPRPDBatchActivity.PRPDBatchActivityID);
                        obj.ShowDialog();
                        obj.StartPosition = FormStartPosition.CenterScreen;

                }
            }
            catch (Exception)
            {

                MessageBox.Show(this, "Error loading activity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvReports_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvReports.CurrentRow!=null)
            {
                try
                {
                    objQCReport = objQCReport_DL.Get(Convert.ToInt64(dgvReports.CurrentRow.Cells["QCReportID"].Value));
                    if (objQCReport != null)
                    {
                        txtReportID.Text = objQCReport.QCReportID.ToString();
                        txtReportType.Text = objQCReport.ReportType;
                        //txtSampleSize.Text = objQCReport.SampleSize;
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

        private void btnQCMore_Click(object sender, EventArgs e)
        {
            try
            {
                QCReport objQCReport = new QCReport();
               objQCReport= objQCReport_DL.Get(Convert.ToInt32(dgvReports.CurrentRow.Cells["QCReportID"].Value));

               frmQCDetailView objForm = new frmQCDetailView(CurrentUser, objQCReport);
                objForm.ShowDialog(this);

            }
            catch (Exception)
            {

                MessageBox.Show(this, "Error occured while loading report", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void btnCost_Click(object sender, EventArgs e)
        {

        }

    }
}