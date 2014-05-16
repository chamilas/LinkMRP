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
    public partial class frmRPDBatchManage : System.Windows.Forms.Form
    {
        private User _CurrentUser;

        public User CurrentUser
        {
            get { return _CurrentUser; }
            set { _CurrentUser = value; }
        }
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

        QCReport_DL objQCReport_DL = new QCReport_DL(ConnectionStringClass.GetConnection());
        QCReport objQCReport = new QCReport();


        public frmRPDBatchManage()
        {
            InitializeComponent();
        }
        public frmRPDBatchManage(User objUser)
        {

            InitializeComponent();
            CurrentUser = objUser;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmRPDBatchManage_Load(object sender, EventArgs e)
        {
            try
            {
                Department objStoreDep = objDepartmentDL.GetByDepType("Store");
                cmbStores.DataSource = objStoreDL.Get(objStoreDep.DepID);
                cmbStores.SelectedValue = "RM_Processed";
                cmbStatus.DataSource = Enum.GetValues(typeof(RPDBatch.RPDBatchStatus));
            }
            catch (Exception)
            {

                MessageBox.Show(this,"Error occured while loading","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {                
                ClearForm();
                Load_Batch_List();

            }
            catch (Exception )
            {

                MessageBox.Show(this,"Error occured while loading RPD Batch","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void Load_Batch_List()
        {
            Status = (RPDBatch.RPDBatchStatus)cmbStatus.SelectedValue;

            gvRPDBatch.AutoGenerateColumns = false;
            bindRPDBatch.DataSource = objRPDBatchDL.GetDataViewByState(Status, true);
            gvRPDBatch.DataSource = bindRPDBatch;
            bindRPDBatch.ResetBindings(true);

            btnDelete.Enabled = false;
            btnSendMR.Visible = false;
            if (Status == RPDBatch.RPDBatchStatus.Created)
            {
                btnManage.Text = "Approve";
                btnDelete.Enabled = true;
                btnManage.Visible = true;

            }
            else if (Status == RPDBatch.RPDBatchStatus.Approved)
            {
                btnManage.Text = "Discarded";
                btnManage.Visible = true;
            }
            else
            {
                btnManage.Visible = false;
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
            txtMRNO.Text = "";
            txtMRStatus.Text = "";

            bindInstructions.DataSource = null;
            bindActivities.DataSource = null;
            bindMaterials.DataSource = null;
            btnEdit.Enabled = false;
            
        }


        public long GenerateMR(RPDBatch objRPD)
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
                objMR.MRDepartmentFrom = objDepDL.GetByDepType("RPD");
                objMR.MREnterdBy = CurrentUser.EmployeeID;
                objMR.MRStatus = MR.Status.Initial;
                Store objStore = (Store)cmbStores.SelectedItem;
                objMR.MRStore = objStoreDL.Get(objStore.StoreID);
                objMR.MRType = MR.Type.Material;
                objMR.MRRemarks = "Material Requition(Materials) for RPD Batch NO " + objRPD.RPDBatchID;
                objMR.OriginType = MR.Origin.ToBatch;

                MRMaterial obj = new MRMaterial();
                obj.Description = "RPD Batch Material Requition";
                obj.Material = objRPD.RPDBatchMaterial;
                obj.MRBINNo = "";
                obj.ReqdQty = objRPD.RPDBatchQty;

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


        private void gvRPDBatch_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex>=0)
            {
                try
                {
                    String ID = gvRPDBatch.Rows[e.RowIndex].Cells["RPDBatchID"].Value.ToString();

                    objRPDBatch = objRPDBatchDL.Get(ID);

                    if (objRPDBatch != null)
                    {
                        LoadBatch();

                        if (objRPDBatch.Status == RPDBatch.RPDBatchStatus.Started)
                        {
                            bool x = objQCReport_DL.IsRPDBatchAccept(gvRPDBatch.CurrentRow.Cells["RPDBatchID"].Value.ToString(),(int)QCReport.ReportStatus.Accept);
                            if (x == false)
                            {

                               btnEdit.Enabled = true;
                            }
                            else
                            {
                                btnEdit.Enabled = false;
                            }

                        }
                    }
                    else
                    {
                        btnEdit.Enabled = false;
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show(this, "Error occured while Loading the RPD Batch","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
        }

        private void LoadBatch()
        {
            txtApprovedBy.Text = objRPDBatch.ApprovedBy.EmployeeNameID;
            txtEndBy.Text = objRPDBatch.EndBy.EmployeeNameID;
            txtInstructedBy.Text = objRPDBatch.RPDBatchInstructedBy.EmployeeNameID;
            txtMaterial.Text = objRPDBatch.RPDBatchMaterial.MaterialNameCode;
            txtPRPDBatchID.Text = objRPDBatch.RPDBatchID;
            txtQuantity.Text = objRPDBatch.RPDBatchQty.ToString();
            lblUnit.Text = objRPDBatch.RPDBatchMaterial.MatUnit.UnitCode;
            txtSupervisedBy.Text = objRPDBatch.RPDBatchSupervisedBy.EmployeeNameID;

            gvInstructions.AutoGenerateColumns = false;
            bindInstructions.DataSource = objRPDBatchActivityInstructionsDL.GetDataView(objRPDBatch.RPDBatchID);
            gvInstructions.DataSource = bindInstructions;
            bindInstructions.ResetBindings(true);

            gvProduction.AutoGenerateColumns = false;
            bindProduction.DataSource = objRPDBatchProductionDL.GetDataByBatchID(objRPDBatch.RPDBatchID);
            gvProduction.DataSource = bindProduction;
            bindProduction.ResetBindings(true);


           dgvActivities.AutoGenerateColumns = false;
            bindActivities.DataSource = objRPDBatchActivityDL.GetDataView(objRPDBatch.RPDBatchID);
            dgvActivities.DataSource = bindActivities;
            bindActivities.ResetBindings(true);


           gvMaterialUsage.AutoGenerateColumns = false;
           bindMaterials.DataSource = objRPDBatchPackingMaterialUsageDL.GetDataByBatchID(objRPDBatch.RPDBatchID);
           gvMaterialUsage.DataSource = bindMaterials;
           bindMaterials.ResetBindings(true);

           
            
            
            if (Status == RPDBatch.RPDBatchStatus.Created)
            {
                btnEdit.Enabled = true;

            }


            if (objRPDBatch.RPDBatchMR.MRNO >= 0)
            {
                txtMRNO.Text = objRPDBatch.RPDBatchMR.MRNO.ToString();
                txtMRStatus.Text = objRPDBatch.RPDBatchMR.MRStatus.ToString();
            }
            else
            {
                txtMRNO.Text = "N/A";
                txtMRStatus.Text = "N/A";
            }

            if (objRPDBatch.Status == RPDBatch.RPDBatchStatus.Created)
            {
                // checkBox1.Enabled = false;
                btnSendMR.Visible = false;
            }
            else if (objRPDBatch.Status == RPDBatch.RPDBatchStatus.Approved && objRPDBatch.RPDBatchMR.MRStatus == MR.Status.Reject)
            {
                checkBox1.Enabled = true;
                btnSendMR.Visible = true;
            }
            else
            {
                checkBox1.Enabled = false;
                btnSendMR.Visible = false;
            }
        }

        private void btnManage_Click(object sender, EventArgs e)
        {
            if (Status == RPDBatch.RPDBatchStatus.Created)
            {

                if (objRPDBatch != null)
                {

                    DialogResult dr = MessageBox.Show(this, "Are you sure you want to approve selected RPD Batch?\nThis will raise a Material Requsition and send to the selected Store\n\nClick Yes to continue", "Confirm Approve", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dr == DialogResult.Yes)
                    {


                        {
                            long MRNO = GenerateMR(objRPDBatch);

                            if (MRNO >= 0)
                            {
                                objRPDBatchDL.Update(objRPDBatch.RPDBatchID, MRNO);
                                objRPDBatch.Status = RPDBatch.RPDBatchStatus.Approved;
                                objRPDBatch.ApprovedBy = CurrentUser.UserEmp;

                                int res = objRPDBatchDL.Approve(objRPDBatch);
                                if (res > 0)
                                {
                                    Load_Batch_List();
                                    ClearForm();
                                    objRPDBatch = null;
                                }
                            }


                        }



                    }
                }
                else
                {
                    MessageBox.Show(this, "Please select a RPD Batch File you want to approve", "Empty Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (Status == RPDBatch.RPDBatchStatus.Approved)
            {
                if (objRPDBatch != null)
                {
                    if (objRPDBatch.RPDBatchMR.MRStatus != MR.Status.Reject)
                    {
                        MessageBox.Show(this, "You should reject the MR before Discarding RPD batch", "Action Denied", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    {


                        DialogResult dr = MessageBox.Show(this, "Are you sure you want to Discard selected RPD Batch File?\n\nClick Yes to Discard", "Confirm Discard", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                        if (dr == DialogResult.Yes)
                        {



                            objRPDBatch.Status = RPDBatch.RPDBatchStatus.Discarded;
                            int res = objRPDBatchDL.Update(objRPDBatch);
                            if (res > 0)
                            {
                                bindRPDBatch.DataSource = objRPDBatchDL.GetDataViewByState(Status, true);
                                ClearForm();
                                objRPDBatch = null;
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show(this, "Please select the RPD batch you want to Discard", "Empty Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (objRPDBatch != null)
                {


                    DialogResult dr = MessageBox.Show(this, "Are you sure you want to delete Selected RPD batch?\n\nClick Yes to delete", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                    if (dr == DialogResult.Yes)
                    {
                        MR_DL objMRDL = new MR_DL(ConnectionStringClass.GetConnection());
                        if (objRPDBatch.RPDBatchMR.MRStatus == MR.Status.Initial || objRPDBatch.RPDBatchMR.MRStatus == MR.Status.Reject)
                        {
                            if (objRPDBatch.RPDBatchMR.MRStatus == MR.Status.Initial)
                            {
                                objMRDL.Delete(objRPDBatch.RPDBatchMR.MRNO);
                            }

                            int res = objRPDBatchDL.Delete(objRPDBatch.RPDBatchID);

                            if (res > 0)
                            {
                                bindRPDBatch.DataSource = objRPDBatchDL.GetDataViewByState(Status, true);
                                ClearForm();
                                objRPDBatch = null;
                            }
                        }
                        else
                        {
                            MessageBox.Show(this, "Material Requsition In Prograss, You can't delete this RPD Batch File\nReject the Material Requsition and Try again.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                else
                {
                    MessageBox.Show(this,"Please select the RPD Batch file you want to delete","Empty Selection",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {

                MessageBox.Show(this,"Error occured while deleting","Error",MessageBoxButtons.OK,MessageBoxIcon.Question);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                frmRPDBatchEditMode obj = new frmRPDBatchEditMode(CurrentUser, objRPDBatch);
               
                obj.ShowDialog(this);
            }
            catch (Exception)
            {

                MessageBox.Show(this,"Error occure while loading Edit Form","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                cmbStores.Enabled = true;
            }
            else
            {
                cmbStores.Enabled = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnSendMR_Click(object sender, EventArgs e)
        {
            try
            {
                long MRNO = GenerateMR(objRPDBatch);

                if (MRNO >= 0)
                {
                    objRPDBatchDL.Update(objRPDBatch.RPDBatchID, MRNO);
                    objRPDBatch = objRPDBatchDL.Get(objRPDBatch.RPDBatchID);
                    LoadBatch();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(this, "Error occured while Sending MR", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}