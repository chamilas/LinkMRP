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
    public partial class frmPRPDBatchTransfer_Preperation : System.Windows.Forms.Form
    {
        public frmPRPDBatchTransfer_Preperation()
        {
            InitializeComponent();
        }

        public frmPRPDBatchTransfer_Preperation(User objUser)
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
        PRPDBatchActivityInstructions_DL objPRPDBatchActivityInstructions_DL = new PRPDBatchActivityInstructions_DL(ConnectionStringClass.GetConnection());
        Department_DL objDepartment_DL = new Department_DL(ConnectionStringClass.GetConnection());
        Employee_DL objEmployee_DL = new Employee_DL(ConnectionStringClass.GetConnection());
        MTN_DL objMTN_DL = new MTN_DL(ConnectionStringClass.GetConnection());
        MTNMaterial_DL objMTNMaterial_DL = new MTNMaterial_DL(ConnectionStringClass.GetConnection());
        Material_DL objMaterial_DL = new Material_DL(ConnectionStringClass.GetConnection());
        MRMaterial_DL objMRMaterial_DL = new MRMaterial_DL(ConnectionStringClass.GetConnection());
        PRPDBatch objPRPDBatch = new PRPDBatch();
        Material objProcessed = new Material();

        DataTable dtPRPDBatches = new DataTable();
        DataTable dtPRPDBatchActivity = new DataTable();

        private void frmPRPDBatchTransfer_Preperation_Load(object sender, EventArgs e)
        {
            try
            {

                dtPRPDBatches = objPRPDBatch_DL.GetDataByState(PRPDBatch.PRPDBatchStatus.Cost);
                if (dtPRPDBatches.Rows.Count != 0)
                {
                    
                   objSourcePRPDBatches.DataSource = dtPRPDBatches;
                   cmbPRPDBatch.DataSource = objSourcePRPDBatches; 
                }

                else
                {
                    objSourcePRPDBatches.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void cmbPRPDBatch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPRPDBatch.SelectedValue != null)
            {
                       
                    try
                    {
                        objPRPDBatch = objPRPDBatch_DL.Get(cmbPRPDBatch.SelectedValue.ToString());


                        dtPRPDBatchActivity = objPRPDBatchActivityInstructions_DL.GetDataByBatchID(cmbPRPDBatch.SelectedValue.ToString());

                        dgvActivities.AutoGenerateColumns = false;
                        dgvActivities.DataSource = objSourcePRPDBatchActivity;
                        objSourcePRPDBatchActivity.DataSource = dtPRPDBatchActivity;
                        objSourcePRPDBatchActivity.ResetBindings(true);
                        txtAddedUnitCost.Text = objPRPDBatch_DL.UnitPrice(objPRPDBatch.PRPDBatchID).ToString();

                        
                        txtBatchState.Text = Enum.GetName(typeof(PRPDBatch.PRPDBatchStatus), objPRPDBatch.Status);

                        txtMRNo.Text = objPRPDBatch.MRIN.ToString();
                        txtUnitPrice.Text = objMRMaterial_DL.Get(objPRPDBatch.MRIN,objPRPDBatch.PRPDBatchMaterial.MaterialCode).UniRate.ToString();
                        txtMaterialCode.Text = objPRPDBatch.PRPDBatchMaterial.MaterialCode;
                        txtMaterialName.Text = objPRPDBatch.PRPDBatchMaterial.MaterialNameCode;

                        txtStartDate.Text = objPRPDBatch.PRPDBatchInstructedDate.ToShortDateString();

                        txtStopDate.Text = objPRPDBatch.PRPDBatchEndDate.ToShortDateString();
                        txtPRPDBatchQty.Text = objPRPDBatch.PRPDBatchFinalQty.ToString();
                        txtInstructedBy.Text = objPRPDBatch.PRPDBatchInstructedBy.EmployeeName;
                        txtAfterReworkQty.Text = objPRPDBatch.PRPDBatchFinalQty.ToString();
                        txtDescription.Text = objPRPDBatch.PRPDBatchComments;
                        lblUnit.Text = objPRPDBatch.PRPDBatchMaterial.MatUnit.UnitCode;
                        lblUnit1.Text = objPRPDBatch.PRPDBatchMaterial.MatUnit.UnitCode;


                        if (objPRPDBatch.Type == PRPDBatch.PRPDType.Rework)
                        {
                            objProcessed = objMaterial_DL.GetDryMaterial(objPRPDBatch.PRPDBatchMaterial.MaterialCode);
                            txtMaterial.Text = objProcessed.MaterialCode + " - " + objProcessed.MaterialDescription;
                        }
                        else
                        {
                            objProcessed = objMaterial_DL.GetProcessdMaterial(objPRPDBatch.PRPDBatchMaterial.MaterialCode);
                            txtMaterial.Text = objProcessed.MaterialCode + " - " + objProcessed.MaterialDescription;
                        }

                        if (objProcessed.MaterialCode == null)
                        {
                            btnTransfer.Enabled = false;
                        }
                        else
                        {
                            btnTransfer.Enabled = true;
                        }
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message.ToString());
                    }
               
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {

            
            try
            {
                if (objPRPDBatch.Type != PRPDBatch.PRPDType.Rework)
                {
                    if (objProcessed.MaterialCode != "")
                    {


                        MTN objMTN = new MTN();

                        objMTN.MTNDate = DateTime.Today;
                        objMTN.MTNDepartmentFrom = objDepartment_DL.GetByDepType("PRPD");
                        objMTN.MTNDepartmentFromName = objMTN.MTNDepartmentFrom.DepName;
                        objMTN.MTNDepartmentTo = objDepartment_DL.GetByDepType("Store");
                        objMTN.MTNEnterdBy = objEmployee_DL.Get(CurrentUser.EmployeeID);
                        objMTN.MTNItemType = MTN.ItemType.Material;
                        objMTN.MTNStatus = MTN.Status.Initial;
                        objMTN.MTNType = MTN.Type.PRPD;

                        int ID = objMTN_DL.Add_PRPDTransfer(objMTN);

                        if (ID > 0)
                        {
                            objMTN.MTNNo = ID;

                            MTNMaterial objMTNMat = new MTNMaterial();
                            objMTNMat.Description = "PRPD batch Transfer";
                            objMTNMat.Material = objProcessed;
                            objMTNMat.MTN = objMTN;
                            objMTNMat.TransferQty = objPRPDBatch.PRPDBatchFinalQty;
                            objMTNMat.UnitRate = objPRPDBatch_DL.UnitPrice(objPRPDBatch.PRPDBatchID);
                            objMTNMat.Batch = "No";
                            int res = objMTNMaterial_DL.Add(objMTNMat);

                            if (res > 0)
                            {
                                objPRPDBatch.UnitCost = objPRPDBatch_DL.UnitPrice(objPRPDBatch.PRPDBatchID);
                                objPRPDBatch.Status = PRPDBatch.PRPDBatchStatus.Transfered;
                                objPRPDBatch.PRPDBatchHandOverBy = CurrentUser.UserEmp;
                                objPRPDBatch.PRPDBatchMTNOUT = objMTN;


                                objPRPDBatch_DL.Update_Transfer(objPRPDBatch);

                                MessageBox.Show(this, "Successfully Transferd, MTN No :- " + objMTN.MTNNo.ToString(), "Successful", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                Clear();
                                this.frmPRPDBatchTransfer_Preperation_Load(sender, e);

                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show(this, "There are no Processed Materials", "Invalid Material", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                else
                {

                    MTN objMTN = new MTN();

                    objMTN.MTNDate = DateTime.Today;
                    objMTN.MTNDepartmentFrom = objDepartment_DL.GetByDepType("PRPD");
                    objMTN.MTNDepartmentFromName = objMTN.MTNDepartmentFrom.DepName;
                    objMTN.MTNDepartmentTo = objDepartment_DL.GetByDepType("Store");
                    objMTN.MTNEnterdBy = objEmployee_DL.Get(CurrentUser.EmployeeID);
                    objMTN.MTNItemType = MTN.ItemType.Material;
                    objMTN.MTNStatus = MTN.Status.Initial;
                    objMTN.MTNType = MTN.Type.PRPD;

                    int ID = objMTN_DL.Add_PRPDTransfer(objMTN);

                    if (ID > 0)
                    {
                        objMTN.MTNNo = ID;

                        MTNMaterial objMTNMat = new MTNMaterial();
                        objMTNMat.Description = "PRPD batch Transfer";
                        objMTNMat.Material = objProcessed;
                        objMTNMat.MTN = objMTN;
                        objMTNMat.TransferQty = objPRPDBatch.PRPDBatchFinalQty;
                        objMTNMat.UnitRate = objPRPDBatch_DL.UnitPrice(objPRPDBatch.PRPDBatchID);
                        objMTNMat.Batch = "No";
                        int res = objMTNMaterial_DL.Add(objMTNMat);

                        if (res > 0)
                        {
                            objPRPDBatch.UnitCost = objPRPDBatch_DL.UnitPrice(objPRPDBatch.PRPDBatchID);
                            objPRPDBatch.Status = PRPDBatch.PRPDBatchStatus.Transfered;
                            objPRPDBatch.PRPDBatchHandOverBy = CurrentUser.UserEmp;
                            objPRPDBatch.PRPDBatchMTNOUT = objMTN;


                            objPRPDBatch_DL.Update_Transfer(objPRPDBatch);

                            MessageBox.Show(this, "Successfully Transferd, MTN No :- " + objMTN.MTNNo.ToString(), "Successful", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            Clear();
                            this.frmPRPDBatchTransfer_Preperation_Load(sender, e);

                        }
                    }
                }
                




            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }

        }
        public void Clear()
        {



            txtBatchState.Text = "";
           
            txtMaterialCode.Text = "";
            txtMaterialName.Text = "";

            txtPRPDBatchQty.Text = "";
            txtInstructedBy.Text = "";
            txtAddedUnitCost.Text = "";

            txtAfterReworkQty.Text = "";
            txtDescription.Text = "";
            objSourcePRPDBatchActivity.DataSource = null;

            try
            {
                            dtPRPDBatches = objPRPDBatch_DL.GetDataByState(PRPDBatch.PRPDBatchStatus.Finished);
            if (dtPRPDBatches.Rows.Count != 0)
            {

                objSourcePRPDBatches.DataSource = dtPRPDBatches;
                cmbPRPDBatch.DataSource = objSourcePRPDBatches;
            }

            else
            {
                objSourcePRPDBatches.DataSource = null;
            }
            }
            catch (Exception)
            {

                MessageBox.Show(this,"Error occured while clearing the form","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            
        }
      
    }
}