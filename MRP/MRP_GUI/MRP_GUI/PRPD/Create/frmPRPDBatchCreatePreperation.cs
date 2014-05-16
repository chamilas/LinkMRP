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
    public partial class frmPRPDBatchCreatePreperation : System.Windows.Forms.Form
    {
        public frmPRPDBatchCreatePreperation()
        {
            
            InitializeComponent();
        }

        public frmPRPDBatchCreatePreperation(User objUser)
        {
            CurrentUser = objUser;
            InitializeComponent();
        }

        private User _CurrentUser;

        public User CurrentUser
        {
            get { return _CurrentUser; }
            set { _CurrentUser = value; }
        }
	

        PRPDBatch_DL objPRPDBatch_DL = new PRPDBatch_DL(ConnectionStringClass.GetConnection());
        Material_DL objMaterial_DL = new Material_DL(ConnectionStringClass.GetConnection());
        Employee_DL objEmployee_DL = new Employee_DL(ConnectionStringClass.GetConnection());
        RPDActivityMachine_DL objRPDActivityMachine_DL = new RPDActivityMachine_DL(ConnectionStringClass.GetConnection());
        MainActivity_DL objMainActivity_DL = new MainActivity_DL(ConnectionStringClass.GetConnection());
        Machine_DL objMachine_DL = new Machine_DL(ConnectionStringClass.GetConnection());
        PRPDBatchActivityInstructions_DL objPRPDBatchActivityInstructions_DL = new PRPDBatchActivityInstructions_DL(ConnectionStringClass.GetConnection());
        MachineActivity_DL objMachineActivity_DL = new MachineActivity_DL(ConnectionStringClass.GetConnection());

        DataTable dtMaterials = new DataTable();
        DataTable dtEmployees = new DataTable();
        DataTable dtActivityMachine = new DataTable();
        DataTable bdtStores = new DataTable();
        Store objStore;
        RPDActivityMachineCollec objRPDActivityMachineCollec = new RPDActivityMachineCollec();
        PRPDBatchActivityInstructions.PRPDBatchActivityInstructionsCollec objPRPDBatchActivityInstructionsCollec = new PRPDBatchActivityInstructions.PRPDBatchActivityInstructionsCollec();

        BindingSource objSource = new BindingSource();
        Store_DL objStoreDL = new Store_DL(ConnectionStringClass.GetConnection());

        Department_DL objDepDL = new Department_DL(ConnectionStringClass.GetConnection());

        private void frmPrimaryPreperationBatchCreateIndependent_Load(object sender, EventArgs e)
        {

            //cmbStores.DataSource = objStoreDL.Get(objDepDL.GetByDepType("Store").DepID);
            objStore = objStoreDL.Get_Default(objDepDL.GetByDepType("Store").DepID);
            try
            {
                txtStore.Text = objStore.StoreName;
                dtMaterials = objMaterial_DL.GetDataView("Raw");
                dtEmployees = objEmployee_DL.Get_By_RoleType("Staff", true);
                dtActivityMachine = objMachineActivity_DL.GetDataByAct(Convert.ToInt64(cmbActivityID.SelectedValue));

                objSourceMaterial.DataSource = dtMaterials;
                cmbMaterial.DataSource = objSourceMaterial;

                Department objDep = objDepDL.GetByDepType("PRPD");

                cmbActivityID.DataSource = objMainActivity_DL.GetByDepID(objDepDL.GetByDepType("PRPD").DepID);
                cmbActivityID.DisplayMember = "MainActivity";
                cmbActivityID.ValueMember = "MainActID";

                txtInstructedBy.Text = CurrentUser.UserEmp.EmployeeNameID;

            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cmbActivityID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Machine_DL objMachineDL = new Machine_DL(ConnectionStringClass.GetConnection());
                if (cmbActivityID.SelectedItem != null)
                {
                   dtActivityMachine= objMachineActivity_DL.GetDataByAct(Convert.ToInt64(cmbActivityID.SelectedValue));
                   cmbMachine.DataSource = dtActivityMachine;

                    cmbMachine.ValueMember = "MachineID";
                    cmbMachine.DisplayMember = "MachineName";

                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());

            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           cmbMachine.ValueMember = "MachineID";
            cmbMachine.DisplayMember = "MachineName";

            PRPDBatchActivityInstructions obj = new PRPDBatchActivityInstructions();
            try
            {
            obj.Activity = objMainActivity_DL.Get(Convert.ToInt64(cmbActivityID.SelectedValue));
            if (txtInstruction.Text != "")
            {
                obj.InstructionDesc = txtInstruction.Text;
            }
            else
            {
                obj.InstructionDesc = "No";
            }
            obj.ParticleSize = "N/A";
            if (cmbMachine.SelectedValue != null)
            {
                   obj.MachineCode = cmbMachine.SelectedValue.ToString();
                   obj.Machine = objMachine_DL.Get(cmbMachine.SelectedValue.ToString());
                   obj.MachineName = obj.Machine.MachineName;

               }
               else
               {
                   obj.MachineCode = "No Machine";
                   obj.MachineName = "No Machine";
               }

            objPRPDBatchActivityInstructionsCollec.Add(obj);

            dgvActivityInstructions.AutoGenerateColumns = false;
            dgvActivityInstructions.DataSource = objSource;
            objSource.DataSource = objPRPDBatchActivityInstructionsCollec;
            objSource.ResetBindings(true);


            txtInstruction.Text = "";
            cmbActivityID.SelectedIndex = 0;
            

            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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
                objMR.MREnterdBy = CurrentUser.EmployeeID;
                objMR.MRStatus = MR.Status.Initial;

                objMR.MRStore = objStore;
                objMR.MRType = MR.Type.Material;
                objMR.MRRemarks = "Material Requition(Materials) for PRPD Batch NO " + objPRPD.PRPDBatchID.ToString();

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
        private void btnSave_Click(object sender, EventArgs e)
        {
            PRPDBatch objPRPDBatch = new PRPDBatch();

            DialogResult dr = MessageBox.Show(this, "Are you sure you want to Create a PRPD Batch?\n\nThis will Create a new PRPD Batch and send to approval\nClick Yes to Create", "Confirmation ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2); 
            if (dr == DialogResult.Yes)
            {
                if (cmbMaterial.SelectedValue == null)
                {
                    MessageBox.Show(this,"Please select a material","Empty Fields",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else if (txtNewBatchQuantity.Text.Equals(""))
                {
                    MessageBox.Show(this,"Please enter a Quantity","Empty Fields",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else if (Convert.ToDecimal(txtNewBatchQuantity.Text) <= 0)
                {
                    MessageBox.Show(this, "Please enter a valid Quantity", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    try
                    {

                        objPRPDBatch.PRPDBatchInstructedBy = CurrentUser.UserEmp;
                        objPRPDBatch.PRPDBatchInstructedDate = DateTime.Today;
                        objPRPDBatch.PRPDBatchMaterial = objMaterial_DL.Get(cmbMaterial.SelectedValue.ToString());
                        objPRPDBatch.PRPDBatchQty = Convert.ToDecimal(txtNewBatchQuantity.Text);
                        objPRPDBatch.MRIN = 0;
                        objPRPDBatch.Status = PRPDBatch.PRPDBatchStatus.Created;
                        if (rdbPP.Checked == true)
                        {
                            objPRPDBatch.Type = PRPDBatch.PRPDType.PrimaryPreperation;
                        }
                        else if (rdbPPOutsource.Checked == true)
                        {
                            objPRPDBatch.Type = PRPDBatch.PRPDType.PrimaryOutsource;
                        }
                        else
                        {
                            objPRPDBatch.Type = PRPDBatch.PRPDType.Rework;
                        }
                        objPRPDBatch.PRPDBatchComments = "N/A";

                        String PRPDID = objPRPDBatch_DL.AddPP(objPRPDBatch);


                        if (PRPDID != null)
                        {
                            objPRPDBatch.PRPDBatchID = PRPDID;
                            foreach (PRPDBatchActivityInstructions _obj in objPRPDBatchActivityInstructionsCollec)
                            {
                                _obj.PRPDBatch = objPRPDBatch;

                                objPRPDBatchActivityInstructions_DL.Add(_obj);


                            }

                            //long res = GenerateMR(objPRPDBatch);
                            //int x = 0;
                            //if (res > 0)
                            //{
                            //    objPRPDBatch.MRIN = res;
                            //    x = objPRPDBatch_DL.UpdateMR(objPRPDBatch.PRPDBatchID, res);

                            //}
                            //if (x > 0)
                            //{
                                MessageBox.Show(this, "Successfully Created a PRPD Batch \n\nPRPD Batch ID :- " + PRPDID , "Successfull Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                
                                frmPRPDBatchCreatePreperation objFrm = new frmPRPDBatchCreatePreperation(CurrentUser);
                                objFrm.MdiParent = this.MdiParent;
                                
                                this.Close();
                                objFrm.Show();


                            

                            //}
                            //else
                            //{
                            //    objPRPDBatch_DL.Delete(PRPDID);
                            //    MessageBox.Show(this, "Error occuerd while saving, PRPD batch does not save", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            //}
                        }
                        else
                        {
                            MessageBox.Show(this, "Error occuerd while saving, PRPD batch does not save", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(this, "Error occuerd while saving,Please check the enterd data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }

        //private void cmbBatchMaterial_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (cmbBatchMaterial.SelectedValue != null)
        //    {
        //        Material obj = ucMaterialSelect1.Material;
        //        lblUnit.Text = obj.MatUnit.UnitCode;
        //    }
        //}

        private void btnDelete_Click(object sender, EventArgs e)
        {
            PRPDBatchActivityInstructions obj = new PRPDBatchActivityInstructions();
            if (dgvActivityInstructions.CurrentRow != null && dgvActivityInstructions.CurrentRow.Selected)
            {
                DialogResult dr = MessageBox.Show(this,"Are you sure you want to delete selected record?","Confirm Delete",MessageBoxButtons.YesNo,MessageBoxIcon.Warning,MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.Yes)
                {
                    obj = (PRPDBatchActivityInstructions)dgvActivityInstructions.CurrentRow.DataBoundItem;

                    objPRPDBatchActivityInstructionsCollec.Delete(obj);

                    dgvActivityInstructions.AutoGenerateColumns = false;
                    dgvActivityInstructions.DataSource = objSource;
                    objSource.DataSource = objPRPDBatchActivityInstructionsCollec;
                    objSource.ResetBindings(true);
                }

            }
            else
            {
                MessageBox.Show(this,"Please select the record you want to delete","Empty Selection",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
          
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNewBatchQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar) || (e.KeyChar == (char)46)))
            {
                e.Handled = true;
            }
        }

        private void materialSelect1_MaterialSelectedChanged(object sender, EventArgs e)
        {
        }

        private void cmbMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}