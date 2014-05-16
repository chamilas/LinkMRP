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
    public partial class frmBatchPacking_Rework : System.Windows.Forms.Form
    {

        User CurrentUser = new User();

        public frmBatchPacking_Rework(User objUser)
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

         QCReport_DL objQCReport_DL = new QCReport_DL(ConnectionStringClass.GetConnection());
        Department_DL objDepartment_DL= new Department_DL(ConnectionStringClass.GetConnection());
        MTN_DL objMTN_DL = new MTN_DL(ConnectionStringClass.GetConnection());

        Section_DL objSection_DL = new Section_DL(ConnectionStringClass.GetConnection());
        Sections objSections = new Sections();

        Batch objBatch = new Batch();
        BatchActivity objBatchActivity = new BatchActivity();
        MainActivity objActivity = new MainActivity();
        DataTable dtSections = new DataTable();


        private void frmBatchList_Load(object sender, EventArgs e)
        {
            Load_Sections();

            Load_Batch_List();

            objActivity = objMainActivity_DL.GetByName("Packing");

            txtActivity.Text = objActivity.MainActivityTitle;

            if (dgvBatcList.Rows.Count > 0)
            {
                dgvBatcList.Rows[0].Selected = true;
                objBatch = objBatch_DL.Get(dgvBatcList.CurrentRow.Cells["BatchNo"].Value.ToString());
                txtBatchID.Text = objBatch.BatchID;
                
            }
            
            Load_Machine();
            Load_employee();

            rdbPermanentSection.Checked = true;
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

        private void Load_Batch_List()
        {
            try
            {

                DataTable dt = objBatch_DL.Get_DataView_ReworkBatchList((int)Batch.Status.In_Progress, "Rework", "Repack");

                if (dt.Rows.Count > 0)
                {
                    objSourceBatchList.DataSource = dt;

                    dgvBatcList.AutoGenerateColumns = false;
                    dgvBatcList.DataSource = objSourceBatchList;
                    objSourceBatchList.ResetBindings(true);

                }
                else
                {
                    objSourceBatchList.DataSource = null;

                    dgvBatcList.AutoGenerateColumns = false;
                    dgvBatcList.DataSource = objSourceBatchList;
                    objSourceBatchList.ResetBindings(true);
                }
            }
            catch (Exception)
            {

                MessageBox.Show(this, "Error occured while loading Batch List", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }


        private void Load_Activity()
        {
            try
            {
                if (dgvBatcList.Rows.Count > 0)
                {

                    DataTable dt = objBatchActivity_DL.Get_DataView_Rework(dgvBatcList.CurrentRow.Cells["BatchNo"].Value.ToString(), (int)Batch.Status.In_Progress, "Rework", "Repack", (int)BatchActivity.Status.Initial, (int)BatchActivity.Status.Start);

                    objSourceActivityList.DataSource = dt;
                    dgvActivity.AutoGenerateColumns = false;
                    dgvActivity.DataSource = objSourceActivityList;
                    objSourceActivityList.ResetBindings(true);


                }
            

                SetColors();
            }
            catch (Exception)
            {

                MessageBox.Show(this, "Error occured while loading Batch List", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SetColors()
        {
            for (int i = 0; i < dgvActivity.Rows.Count; i++)
            {
                if ((dgvActivity.Rows[i].Cells["BatchActStatus"].Value).ToString() == "1")
                {
                    dgvActivity.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                }
                else
                {
                    dgvActivity.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                }
            }
        }

        private void dgvBatcList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvBatcList.Rows.Count > 0)
                {
                    objBatch = objBatch_DL.Get(dgvBatcList.CurrentRow.Cells["BatchNo"].Value.ToString());
                    txtBatchID.Text = objBatch.BatchID;

                    //DataTable dtBatchActivity = objBatchActivity_DL.Get_DataView_Rework(objBatch.BatchID,(int)Batch.Status.In_Progress,"Rework","Repack",(int)BatchActivity.Status.Initial,(int)BatchActivity.Status.Start);

                    //DataTable dt = objFinishProduct_DL.GetBy_TypeandBasicProduct(objBatch.StandardBatch.STDBatchBasicProduct.BasicProductCode, true, "Primary");

                    Load_Activity();

                }


             

            }
            catch (Exception)
            {

                MessageBox.Show(this, "Error occured while loading Batch List", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void Load_Machine_List()

    {
        try
        {

            DataTable dt = objMachineActivity_DL.GetDataByAct(objActivity.MainActID);

            objSourceMachineList.DataSource = dt;
            cmbMachine.DataSource = objSourceMachineList;



        }
        catch (Exception)
        {

            MessageBox.Show(this, "Error occured while loading Labour Details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        MessageBox.Show(this,"Activity is already Finished","Wrong Attempt",MessageBoxButtons.OK);

                        txtMachineStart.Text = "";
                        txtMachineStop.Text = "";
                    }
                    else
                    {
                        if (!DataValidation.IsTimeShift(txtMachineStart.Text, txtMachineStop.Text))
                        {
                            MessageBox.Show(this, "please enter valid time period", "MRP System", MessageBoxButtons.OK);
                        }
                        else
                        {
                            BatchMachineDetails obj = new BatchMachineDetails();

                            obj.BatchAct = objBatchActivity;
                            obj.StartTime = txtMachineStart.Text;
                            obj.StopTime = txtMachineStop.Text;
                            obj.TheMachine = objMachine_DL.Get(cmbMachine.SelectedValue.ToString());

                            objBatchMachineDetails_DL.Add(obj);

                            Load_BatchMachineDetails();

                            txtMachineStart.Text = "";
                            txtMachineStop.Text = "";
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
            txtOT.Text = "";
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
                    DataTable dt = objEmployee_DL.Get_Workers_BySection(Convert.ToInt32(objSections.SectionID));
                    objSourceEmployee.DataSource = dt;
                    cmbEmployee.DataSource = objSourceEmployee;
                }
                else
                {
                    DataTable dt = objEmployee_DL.Get_Workers_Outsource(Convert.ToInt32(objSections.SectionID));
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

        private void dgvMachineDetails_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DialogResult theResult = MessageBox.Show(this, "Do you want to delete the selected Record", "Confirmation", MessageBoxButtons.YesNo);

                if (objBatchActivity.BatchActStatus == BatchActivity.Status.Finished)
                {
                    MessageBox.Show(this, "This Activity Is Finished.", "Wrong Attempt", MessageBoxButtons.OK);
                }
                else
                {
                    if (theResult == System.Windows.Forms.DialogResult.Yes)
                    {
                        BatchMachineDetails obj = new BatchMachineDetails();

                        objBatchMachineDetails_DL.Delete(Convert.ToInt32(dgvMachineDetails.CurrentRow.Cells["MachineRecID"].Value));

                        Load_BatchMachineDetails();
                    }
                }

            }
        }

        private void dgvActivity_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {

                objBatchActivity = objBatchActivity_DL.GetByID(Convert.ToInt32(dgvActivity.CurrentRow.Cells["BatchActID"].Value));

            Load_BatchLabourDetails();
            Load_BatchMachineDetails();

            if (objBatchActivity.BatchActStatus == BatchActivity.Status.Finished)
            {
                btnFinishPacking.Enabled = false;

            }
            else if (objBatchActivity.BatchActStatus == BatchActivity.Status.Initial)
            {
                btnFinishPacking.Enabled = true;
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

        private void btnFinishPacking_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show(this,"Do you want to finish the Activity","Confirmation",MessageBoxButtons.YesNo);

                if(dr== DialogResult.Yes)
                {

                    objBatchActivity = objBatchActivity_DL.GetByID(Convert.ToInt32(dgvActivity.CurrentRow.Cells["BatchActID"].Value));

                    frmBatchActivity_Packing objForm = new frmBatchActivity_Packing(objBatchActivity);
                    objForm.ShowDialog(this);

                    if (dgvActivity.Rows.Count == 1)
                    {
                        objBatch_DL.Update_QCStatus(objBatch.BatchID, CurrentUser.EmployeeID, Batch.Status.Finished);

                        Load_Batch_List();
                    }


                }

                Load_Activity();

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
                if ((objBatch.BatchType == "Rework") | (objBatch.BatchType == "Repack"))
                {
                    string x = objBatch_DL.Get_BasicProduct_Rework(objBatch.BatchID);
                    if (dgvActivity.Rows.Count > 0)
                    {
                        if (Convert.ToInt64(dgvActivity.CurrentRow.Cells["BatchActID"].Value) != 0)
                        {
                            frmBatchPackingMR objForm = new frmBatchPackingMR(x, objBatch.BatchID, CurrentUser, Convert.ToInt64(dgvActivity.CurrentRow.Cells["BatchActID"].Value));
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
                else
                {
                    if (dgvActivity.Rows.Count > 0)
                    {
                        if (Convert.ToInt64(dgvActivity.CurrentRow.Cells["BatchActID"].Value) != 0)
                        {
                            frmBatchPackingMR objForm = new frmBatchPackingMR(objBatch.StandardBatch.STDBatchBasicProduct.BasicProductCode, objBatch.BatchID, CurrentUser, Convert.ToInt64(dgvActivity.CurrentRow.Cells["BatchActID"].Value));

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
            }

            return base.ProcessCmdKey(ref msg, keyData);

            // Call the base class
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void txtPackingQty_Click(object sender, EventArgs e)
        {
            btnFinishPacking.Enabled = false;
        }

        private void btnTransferBP_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult theResult = MessageBox.Show(this, "Do You Need to Transfer Basic Product to RPD Stores", "Confirmation", MessageBoxButtons.YesNo);

                if (theResult == System.Windows.Forms.DialogResult.Yes)
                {

                    DataTable dtReports = objQCReport_DL.Get_IsManufacturingQCPass(objBatch.BatchID, Convert.ToInt32(QCReport.ReportStatus.Accept));

                    if (dtReports.Rows.Count > 0)
                    {

                        MTN objMTN = new MTN();
                        objMTN.MTNBatch = Convert.ToString(dgvBatcList.CurrentRow.Cells["BatchNo"].Value);
                        objMTN.MTNEnterdBy = objEmployee_DL.Get(CurrentUser.EmployeeID);
                        objMTN.MTNDepartmentTo = objDepartment_DL.GetByDepType("RPD");
                        objMTN.MTNStatus = MTN.Status.Initial;
                        objMTN.MTNType = MTN.Type.Batch;
                        objMTN.MTNItemType = MTN.ItemType.Basic_Product;



                        //int i = objMTN_DL.CreateBasicProductTransfer_toRPD(objMTN, BatchActivity.Status.Transferred, objBatch.StandardBatch.STDBatchBasicProduct.BasicProductCode, Convert.ToDecimal(txtBasicQty.Text));

                        //if (i > 0)
                        //{
                        //    MessageBox.Show(this, "Successfully sent to Stores. MTN No is :" + i.ToString(), "Successful", MessageBoxButtons.OK);
                        //}

                        //Load_Activity();

                        //if (dgvBatcList.Rows.Count > 0)
                        //{

                        //    DataGridViewCellEventArgs dr = new DataGridViewCellEventArgs(1, 0);
                        //    dgvBatcList_CellClick(sender, dr);
                        //    dgvActivity_CellClick(sender, dr);

                        //}

                    }
                    else
                    {
                        MessageBox.Show(this, "Packing QC is Not Passed", "Can not Proceed", MessageBoxButtons.OK);
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }

        private void txtOTMinutes_KeyDown(object sender, KeyEventArgs e)
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
                                        objBatchLabourDetails_DL.Add(obj);
                                    }
                                }
                                else
                                {
                                    objBatchLabourDetails_DL.Add(obj);
                                }



                                Load_BatchLabourDetails();

                                Clear_Labour();



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
                    MessageBox.Show(this, "Please Select a Packing Batch  Before Entering Labour", "Warning", MessageBoxButtons.OK);
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







    }
}
