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
    public partial class frmRPDBatchFileView : System.Windows.Forms.Form
    {
        private User _CurrentUser;

        public User CurrentUser
        {
            get { return _CurrentUser; }
            set { _CurrentUser = value; }
        }
        private MR_DL objMRDL = new MR_DL(ConnectionStringClass.GetConnection());
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
        public frmRPDBatchFileView(User objUser,RPDBatch objRPDBatch)
        {
            this.objRPDBatch = objRPDBatch;
            CurrentUser = objUser;
            InitializeComponent();
        }

        private void frmRPDBatchFileView_Load(object sender, EventArgs e)
        {
            try
            {
                if (objRPDBatch != null)
                {
                    txtApprovedBy.Text = objRPDBatch.ApprovedBy.EmployeeNameID;
                    txtEndBy.Text = objRPDBatch.EndBy.EmployeeNameID;
                    txtInstructedBy.Text = objRPDBatch.RPDBatchInstructedBy.EmployeeNameID;
                    txtMaterial.Text = objRPDBatch.RPDBatchMaterial.MaterialNameCode;
                    lblunit.Text = objRPDBatch.RPDBatchMaterial.MatUnit.UnitCode;
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
                    //bindMaterials.DataSource = objRPDBatchPackingMaterialUsageDL.GetDataByBatchID(objRPDBatch.RPDBatchID);
                    //if (Status == RPDBatch.RPDBatchStatus.Created)
                    //{
                    //    btnEdit.Enabled = true;

                    //}
                    bindProduction.DataSource = objRPDBatchProductionDL.GetDataByBatchID(objRPDBatch.RPDBatchID);
                    bindMaterialUsage.DataSource = objRPDBatchPackingMaterialUsageDL.GetDataByBatchID(objRPDBatch.RPDBatchID);
                    bindReports.DataSource = objQCReport_DL.GetView_RPD(objRPDBatch.RPDBatchID);
                    bindActual.DataSource = objRPDBatchActualProductionDL.Get(objRPDBatch.RPDBatchID);
                    //if (objQCReport_DL.IsRPDBatchAccept(objRPDBatch.RPDBatchID))
                    //{
                    //    grpActual.Enabled = true;
                    //}
                    //else
                    //{
                    //    grpActual.Enabled = false;
                    //}
                    txtBatchState.Text = objRPDBatch.Status.ToString();
                   
                    if (objRPDBatch.Status == RPDBatch.RPDBatchStatus.Approved)
                    {
                        if (objRPDBatch.RPDBatchMR.MRStatus != MR.Status.Recevied)
                        {

                            txtBatchState.Text = "MR Not Received";
                        }
                        else
                        {
                           
                        }

                    }
                    objRPDBatchPackingActivity = objRPDBatchActivityDL.Get("Packing-RPD", objRPDBatch.RPDBatchID);
                    if (objRPDBatchPackingActivity != null)
                    {
                         bindPackingDetails.DataSource = objRPDBatchActPackingDetailsDL.Get_By_BatchAct_View(objRPDBatchPackingActivity.RPDBatchActID);
 
                    }





                }
            }
            catch (Exception )
            {

                MessageBox.Show(this,"Error occured while loading the RPD Batch File","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gvReports_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {


                    objQCReport = objQCReport_DL.Get(Convert.ToInt64(gvReports.Rows[e.RowIndex].Cells["colQCReportID"].Value));
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
            }
            catch (Exception)
            {

                MessageBox.Show(this, "Error occured while loading report", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

                MessageBox.Show(this, "Error occured while loading Report details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void gvActivity_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (gvActivity.Rows[e.RowIndex].Cells[e.ColumnIndex].OwningColumn.Name.Equals("colAddDetails"))
                {
                    //objRPDBatchActivity = objRPDBatchActivityDL.Get(Convert.ToInt64(gvActivity.Rows[e.RowIndex].Cells["colRPDBatchActID"].Value));
                    //RPD.RPDBatchActivityForms.frmViewActivityDetails objFrm = new MRP_GUI.RPD.RPDBatchActivityForms.frmViewActivityDetails(objRPDBatchActivity);
                    //objFrm.ShowDialog(this);
                }
            }
            catch (Exception)
            {

                MessageBox.Show(this,"Error occured","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void gvActivity_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            objRPDBatchActivity = objRPDBatchActivityDL.Get(Convert.ToInt64(gvActivity.Rows[e.RowIndex].Cells["colRPDBatchActID"].Value));
            frmRPDBatchActivity_View objFrm = new frmRPDBatchActivity_View(CurrentUser,objRPDBatchActivity.RPDBatchActID);
            objFrm.ShowDialog(this);

            
        }
    }
}