using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DL;
using SESD.MRP.REF;
using MRP_GUI.Production;
using MRP_GUI.Packing;
using MRP_GUI.Sales;



namespace MRP_GUI
{
    public partial class frmBatchPacking_Secondary : System.Windows.Forms.Form
    {

        User CurrentUser = new User();

        public frmBatchPacking_Secondary(User objUser)
        {
            InitializeComponent();
            CurrentUser = objUser;
        }

        Batch_DL objBatch_DL = new Batch_DL(ConnectionStringClass.GetConnection());
        MainActivity_DL objMainActivity_DL = new MainActivity_DL(ConnectionStringClass.GetConnection());
        BatchActivity_DL objBatchActivity_DL = new BatchActivity_DL(ConnectionStringClass.GetConnection());
        MachineActivity_DL objMachineActivity_DL = new MachineActivity_DL(ConnectionStringClass.GetConnection());
        BatchLabourDetails_DL objBatchLabourDetails_DL = new BatchLabourDetails_DL(ConnectionStringClass.GetConnection());
        BatchMachineDetails_DL objBatchMachineDetails_DL = new BatchMachineDetails_DL(ConnectionStringClass.GetConnection());
        Machine_DL objMachine_DL = new Machine_DL(ConnectionStringClass.GetConnection());
        Employee_DL objEmployee_DL = new Employee_DL(ConnectionStringClass.GetConnection());
        FinishProduct_DL objFinishProduct_DL = new FinishProduct_DL(ConnectionStringClass.GetConnection());
        Section_DL objSection_DL = new Section_DL(ConnectionStringClass.GetConnection());
        QCReport_DL objQCReport_DL = new QCReport_DL(ConnectionStringClass.GetConnection());

        Batch objBatch = new Batch();
        BatchActivity objBatchActivity = new BatchActivity();
        MainActivity objActivity = new MainActivity();
        Sections objSections = new Sections();

        DataTable dtSections = new DataTable();

        bool Loaded = false;

        private void frmBatchList_Load(object sender, EventArgs e)
        {

            Load_Sections();
            

            objActivity = objMainActivity_DL.GetByName("Packing_Secondary");

            txtActivity.Text = objActivity.MainActivityTitle;
            Load_Machine();
            Load_employee();
            

            rdbPermanentSection.Checked = true;

            Load_SecondaryActivityList();
        }

        private void Load_Sections()
        {

            try
            {
            dtSections = objSection_DL.GetData("Production");

            objSourceSections.DataSource = dtSections;
            cmbSection.DataSource = objSourceSections;

            }
            catch (Exception)
            {

                MessageBox.Show(this, "Error occured while loading Labour Details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

       


        private void SetColors()
        {
            for (int i = 0; i < dgvActivity.Rows.Count; i++)
            {
                if ((dgvActivity.Rows[i].Cells["BatchActStatus"].Value).ToString() == "2")
                {
                    dgvActivity.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                }
                else
                {
                    dgvActivity.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                }
            }
        }


        private void Load_BatchLabourDetails()
        {
            try
            {

                DataTable dt = new DataTable();

                if (objBatchActivity.BatchActID != 0)
                {
                     dt = objBatchLabourDetails_DL.Get_ByBatchActID(Convert.ToInt32(objBatchActivity.BatchActID));
                }
                else
                {
                    dt = null;
                }


               dgvBatchLabourDetails.AutoGenerateColumns=false;
                objSourceBatchLabour.DataSource=dt;
                dgvBatchLabourDetails.DataSource=objSourceBatchLabour;
                objSourceBatchLabour.ResetBindings(true);


            }
            catch (Exception)
            {

                MessageBox.Show(this, "Error occured while loading Labour Details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

       
        private void txtOT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtOTMinutes.Select();
            }
        }

        private void Clear_Labour()
        {
            txtFrom.Text = "";
            txtTo.Text = "";
            txtNos.Text = "";
            txtOT.Text = "00";
            txtOTMinutes.Text = "00";
            cmbEmployee.Select();
        }

        private void rdbPermanentSection_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbOutsource.Checked == true)
            {
                txtNos.ReadOnly = false;
            }
            else
            {
                txtNos.ReadOnly = true;
            }
            Load_employee();
        }

        private void rdbOutsource_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbOutsource.Checked == true)
            {
                txtNos.ReadOnly = false;
            }
            else
            {
                txtNos.ReadOnly = true;
            }

            Load_employee();
        }

        private void rdbPermanentAll_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbOutsource.Checked == true)
            {
                txtNos.ReadOnly = false;
            }
            else
            {
                txtNos.ReadOnly = true;
            }
            Load_employee();
        }


        private void Load_employee()
        {
            try
            {
                if (rdbPermanentAll.Checked == true)
                {

                    DataTable dt = objEmployee_DL.Get_Workers();
                    objSourceEmployee.DataSource = dt;
                    cmbEmployee.DataSource = objSourceEmployee;
                }
                else if (rdbPermanentSection.Checked == true)
                {
                    DataTable dt = objEmployee_DL.Get_Workers_BySection(Convert.ToInt32(cmbSection.SelectedValue));
                    objSourceEmployee.DataSource = dt;
                    cmbEmployee.DataSource = objSourceEmployee;
                }
                else
                {
                    DataTable dt = objEmployee_DL.Get_Workers_Outsource(Convert.ToInt32(cmbSection.SelectedValue));
                    objSourceEmployee.DataSource = dt;
                    cmbEmployee.DataSource = objSourceEmployee;
                }
            }
            catch (Exception)
            {

                MessageBox.Show(this, "Error occured while loading Batch List", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void cmbEmployee_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (rdbOutsource.Checked == true)
                {
                    txtNos.Select();
                }
                else
                {
                    txtFrom.Select();
                }
            }
        }

        private void txtFrom_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtTo.Select();
            }
        }

        private void txtTo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtOT.Select();
            }
        }

  

        private void txtNos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtFrom.Select();
            }
        }

        private void dgvBatchLabourDetails_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {

                if (objBatchActivity.BatchActStatus == BatchActivity.Status.Finished)
                {
                    MessageBox.Show(this, "This Activity Is Finished.", "Wrong Attempt", MessageBoxButtons.OK);
                }
                else
                {
                    BatchLabourDetails obj = new BatchLabourDetails();

                    objBatchLabourDetails_DL.Delete(Convert.ToInt32(dgvBatchLabourDetails.CurrentRow.Cells["LabourRecID"].Value));

                    Load_BatchLabourDetails();
                }


            }
        }


     

        private void btnFinishPacking_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show(this,"Do you want to finish the Activity","Confirmation",MessageBoxButtons.YesNo);

                if(dr== DialogResult.Yes)
                {
                    DataTable dtReports = objQCReport_DL.Get_IsPackingQCPass(objBatch.BatchID, Convert.ToInt32(QCReport.ReportStatus.Accept), "Packing_Secondary");

                    if (dtReports.Rows.Count > 0)
                    {
                        objBatchActivity = objBatchActivity_DL.GetByID(Convert.ToInt32(dgvActivity.CurrentRow.Cells["BatchActID"].Value));

                        frmBatchActivity_Packing objForm = new frmBatchActivity_Packing(objBatchActivity);
                        objForm.ShowDialog(this);

                        objBatch_DL.Update_BatchSeconderyPackingCost(objBatchActivity.BatchActID);
                    }
                    else
                    {
                        MessageBox.Show(this, "Secondary QC Is Not Passed", "Wrong Attempt", MessageBoxButtons.OK);
                    }

                }

                Load_SecondaryActivityList();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }


        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {


            if (keyData == Keys.F1)
            {
                frmBatchMaterial objForm = new frmBatchMaterial(objBatch.BatchID);
                objForm.ShowDialog(this);
            }


            if (keyData == Keys.F2)
            {
                if (dgvActivity.Rows.Count > 0)
                {
                    if (Convert.ToInt64(dgvActivity.CurrentRow.Cells["BatchActID"].Value) != 0)
                    {
                        frmBatchPackingMR objForm = new frmBatchPackingMR(objBatch.StandardBatch.STDBatchBasicProduct.BasicProductCode, objBatch.BatchID, CurrentUser,Convert.ToInt64(dgvActivity.CurrentRow.Cells["BatchActID"].Value));
                        objForm.ShowDialog(this);
                    }
                    else
                    {
                        MessageBox.Show("Please select a Packing Batch");
                    }
                }
                else
                {
                    MessageBox.Show("Please select a Packing Batch");
                }
            }
            if (keyData == Keys.F3)
            {
                if (dgvActivity.CurrentRow != null)
                {

                    frmBatchPacking_DamagedGoods objForm = new frmBatchPacking_DamagedGoods(Convert.ToInt64(dgvActivity.CurrentRow.Cells["BatchActID"].Value), "Secondary");
                    objForm.ShowDialog(this);
                }
                else
                {
                    MessageBox.Show("Please select a Packing Batch");
                }
            }


            return base.ProcessCmdKey(ref msg, keyData);

            // Call the base class
            return base.ProcessCmdKey(ref msg, keyData);
        }


        private void Load_SecondaryActivityList()
        {
            try
            {

                DataTable dt = objBatchActivity_DL.GetView_Packing_Secondary((int)BatchActivity.Status.SecondaryPacking,(int)BatchActivity.Status.SecondaryPacking_Start);

                dgvActivity.AutoGenerateColumns = false;
                objSourceSecondaryActivityList.DataSource = dt;
                dgvActivity.DataSource = objSourceSecondaryActivityList;
                objSourceSecondaryActivityList.ResetBindings(true);

                
               // SetColors();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void dgvActivity_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                objBatch = objBatch_DL.Get(dgvActivity.CurrentRow.Cells["BatchID"].Value.ToString());
                txtBatchID.Text = objBatch.BatchID;

                
                objBatchActivity = objBatchActivity_DL.GetByID(Convert.ToInt32(dgvActivity.CurrentRow.Cells["BatchActID"].Value));
                
                Load_BatchLabourDetails();
                Load_BatchMachineDetails();

                if (objBatchActivity.BatchActStatus == BatchActivity.Status.SecondaryPacking_Start)
                {
                    btnFinishPacking.Enabled = true;

                }
                else if (objBatchActivity.BatchActStatus == BatchActivity.Status.SecondaryPacking_Finish)
                {
                    btnFinishPacking.Enabled = false;
                }
                else
                {
                    btnFinishPacking.Enabled = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (objBatchActivity.BatchActStatus == BatchActivity.Status.Finished)
                    {
                        MessageBox.Show(this, "Activity is already Finished", "Wrong Attempt", MessageBoxButtons.OK);

                        Clear_Labour();
                    }
                    else
                    {
                        if (!DataValidation.IsTimeShift(txtFrom.Text, txtTo.Text))
                        {
                            MessageBox.Show(this, "please enter valid time period", "MRP System", MessageBoxButtons.OK);
                        }
                        else if (!DataValidation.IsHours(txtOT.Text) || !DataValidation.IsMinutes(txtOTMinutes.Text))
                        {
                            MessageBox.Show(this, "please enter valid OT Details", "MRP System", MessageBoxButtons.OK);
                        }
                        else
                        {
                            try
                            {
                                Decimal OTHours = 0;
                                Decimal OTMinutes = 0;

                                if (txtOT.Text != "")
                                {
                                    OTHours = Convert.ToDecimal(txtOT.Text);
                                }
                                if (txtOTMinutes.Text != "")
                                {
                                    OTMinutes = Convert.ToDecimal(txtOTMinutes.Text);
                                }


                                BatchLabourDetails obj = new BatchLabourDetails();


                                obj.BatchAct = objBatchActivity;
                                obj.Emp = objEmployee_DL.Get(cmbEmployee.SelectedValue.ToString());
                                obj.OTHours = Calculate.CalOTHours(OTHours, OTMinutes);
                                obj.WorkStart = txtFrom.Text;
                                obj.WorkStop = txtTo.Text;


                                if (rdbOutsource.Checked == true)
                                {
                                    int theCount = Convert.ToInt32(txtNos.Text);

                                    for (int i = 0; i < theCount; i++)
                                    {
                                        objBatchLabourDetails_DL.Add_Secondary(obj);
                                    }
                                }
                                else
                                {
                                    objBatchLabourDetails_DL.Add_Secondary(obj);
                                }



                                Load_BatchLabourDetails();

                                Clear_Labour();

                                if (dgvActivity.Rows.Count > 0)
                                {
                                    DataGridViewCellEventArgs ee = new DataGridViewCellEventArgs(1, 0);

                                    dgvActivity_CellClick(sender, ee);
                                }

                            }
                            catch (Exception)
                            {

                                MessageBox.Show(this, "Error occured while loading Labour Details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
            }
        }

        private void btnMultiple_Click(object sender, EventArgs e)
        {
            try
            {
                if (objBatchActivity.BatchActID != 0)
                {
                    if (objSections.SectionID != 0)
                    {
                        frmMultipleLabour objForm = new frmMultipleLabour(objBatchActivity, (int)objSections.SectionID);
                        objForm.ShowDialog(this);

                        Load_BatchLabourDetails();
                    }
                    else
                    {
                        MessageBox.Show(this, "Please Select a Section Before Entering Labour", "Warning", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show(this, "Please Select a Packing Batch Before Entering Labour", "Warning", MessageBoxButtons.OK);
                }
            }
            catch (Exception)
            {

                MessageBox.Show(this, "Error occured while loading Labour Details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cmbSection_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbSection.SelectedValue != null)
                {
                    objSections = objSection_DL.Get(Convert.ToInt64(cmbSection.SelectedValue));

                    Load_employee();


                }
            }
            catch (Exception)
            {

                MessageBox.Show(this, "Error occured while loading Labour Details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void Load_Machine()
        {
            try
            {
                DataTable dt = objMachineActivity_DL.GetDataByAct(objActivity.MainActID);

                objSourceMachineList.DataSource = dt;
                cmbMachine.DataSource = objSourceMachineList;
            }
            catch (Exception)
            {

                MessageBox.Show(this, "Error occured while loading Machine List", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void txtMachineStart_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtMachineStop.Select();
            }

            if (e.KeyCode == Keys.End)
            {
                cmbEmployee.Select();
            }
        }

        private void txtMachineStop_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    if (objBatchActivity.BatchActStatus == BatchActivity.Status.Finished)
                    {
                        MessageBox.Show(this, "Activity is already Finished", "Wrong Attempt", MessageBoxButtons.OK);

                        txtMachineStart.Text = "";
                        txtMachineStop.Text = "";
                    }
                    else
                    {
                        if (DataValidation.IsTimeShift(txtMachineStart.Text, txtMachineStop.Text))
                        {
                            BatchMachineDetails obj = new BatchMachineDetails();

                            obj.BatchAct = objBatchActivity;
                            obj.StartTime = txtMachineStart.Text;
                            obj.StopTime = txtMachineStop.Text;
                            obj.TheMachine = objMachine_DL.Get(cmbMachine.SelectedValue.ToString());
                            //MessageBox.Show(""+obj.BatchAct.BatchActID);
                            objBatchMachineDetails_DL.Add(obj);
                            Load_BatchMachineDetails();

                            txtMachineStart.Text = "";
                            txtMachineStop.Text = "";
                        }
                        else
                        {
                            MessageBox.Show(this, "please enter valid time period", "MRP System", MessageBoxButtons.OK);
                        }
                    }

                }
                catch (Exception)
                {

                    MessageBox.Show(this, "Error occured while loading Machine Details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMachineStart.Text = "";
                    txtMachineStop.Text = "";
                    cmbMachine.Select();
                }
            }
        }

        private void Load_BatchMachineDetails()
        {
            try
            {
                DataTable dt = new DataTable();

                if (objBatchActivity.BatchActID != 0)
                {
                    dt = objBatchMachineDetails_DL.Get_ByBatchActID(Convert.ToInt32(objBatchActivity.BatchActID));
                }
                else
                {
                    dt = null;
                }

                dgvMachineDetails.AutoGenerateColumns = false;
                objSourceBatchMachine.DataSource = dt;
                dgvMachineDetails.DataSource = objSourceBatchMachine;
                objSourceBatchMachine.ResetBindings(true);


            }
            catch (Exception)
            {

                MessageBox.Show(this, "Error occured while loading Machine Details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void cmbMachine_KeyDown(object sender, KeyEventArgs e)
        {
           
            if (cmbMachine.SelectedValue != null)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtMachineStart.Select();
                }
            }

            if (e.KeyCode == Keys.End)
            {
                cmbEmployee.Select();
            }
        }
    }
}
