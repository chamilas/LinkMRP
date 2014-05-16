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


namespace MRP_GUI
{
    public partial class frmBatchList_Edit : System.Windows.Forms.Form
    {

        User CurrentUser = new User();

        public frmBatchList_Edit(User objUser)
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

        Batch objBatch = new Batch();
        BatchActivity objBatchActivity = new BatchActivity();
        MainActivity objActivity = new MainActivity();

        bool Loaded = false;

        private void frmBatchList_Load(object sender, EventArgs e)
        {

            Load_Batch_List();
            rdbPermanentSection.Checked = true;
        }

        private void Load_Batch_List()
        {
            try
            {
                DataTable dt = objBatch_DL.Get_DataView_Admin(Batch.Status.In_Progress, Batch.Status.QC,Batch.Status.QCPass,Batch.Status.QCFail, Batch.Status.To_Finish);
                objSourceBatchList.DataSource = dt;

                dgvBatcList.AutoGenerateColumns = false;
                dgvBatcList.DataSource = objSourceBatchList;
                objSourceBatchList.ResetBindings(true);

                
            }
            catch (Exception)
            {

                MessageBox.Show(this, "Error occured while loading Batch List", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }


        private void Load_Activity_List()
        {
            try
            {
                if (dgvBatcList.CurrentRow.Cells["BatchNo"].Value != null)
                {
                    DataTable dt = objBatchActivity_DL.GetView(dgvBatcList.CurrentRow.Cells["BatchNo"].Value.ToString());
                    objSourceActivityList.DataSource = dt;

                    dgvActivity.AutoGenerateColumns = false;
                    dgvActivity.DataSource = objSourceActivityList;
                    objSourceActivityList.ResetBindings(true);

                    objBatch = objBatch_DL.Get(dgvBatcList.CurrentRow.Cells["BatchNo"].Value.ToString());
                    txtBatchID.Text = objBatch.BatchID;
                }

                SetColors();

            }
            catch (Exception)
            {

                MessageBox.Show(this, "Error occured while loading Activity List", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



        }


        private void SetColors()
        {
            for (int i=0;i<dgvActivity.Rows.Count;i++)
            {
                
                    objBatchActivity = objBatchActivity_DL.GetByID(Convert.ToInt32(dgvActivity.Rows[i].Cells["BatchActID"].Value));

                    if (objBatchActivity.BatchActStatus == BatchActivity.Status.Finished)
                    {
                        dgvActivity.Rows[i].DefaultCellStyle.BackColor = Color.Green;

                    }
                    else if (objBatchActivity.BatchActStatus == BatchActivity.Status.Start)
                    {
                        dgvActivity.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                    }
                    else
                    {
                        dgvActivity.Rows[i].DefaultCellStyle.BackColor = Color.White;
                    }

                
            }

        }



        private void dgvBatcList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Load_Activity_List();
            Load_BatchLabourDetails();
            Load_BatchMachineDetails();
            SetColors();

            if (dgvBatcList.CurrentRow.Cells["BatchNo"].Value != null)
            {
                objBatch = objBatch_DL.Get(dgvBatcList.CurrentRow.Cells["BatchNo"].Value.ToString());

                txtFinalQty.Text = objBatch.BatchFinalQty.ToString();
                lblUnit.Text = objBatch.StandardBatch.STDBatchBasicProduct.BasicProductUnit.UnitCode.ToString();
            }

            //dgvActivity_CellClick(sender, e);
        }

        private void dgvActivity_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvActivity.CurrentRow.IsNewRow == false)
            {
                try
                {

                    objBatchActivity = objBatchActivity_DL.GetByID(Convert.ToInt32(dgvActivity.CurrentRow.Cells["BatchActID"].Value));


                    objActivity = objMainActivity_DL.Get(Convert.ToInt64(dgvActivity.CurrentRow.Cells["MainActID"].Value));
                    txtActivity.Text = objActivity.MainActivityTitle;

                    Load_Machine();
                    Load_employee();


                   Load_BatchLabourDetails();

                   Load_BatchMachineDetails();

                }
                catch (Exception)
                {

                    MessageBox.Show(this, "Error occured while loading Main Activity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            Load_Machine_List();
            Load_BatchLabourDetails();
            Load_BatchMachineDetails();
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

                DataTable dt = objBatchLabourDetails_DL.Get_ByBatchActID(Convert.ToInt32(dgvActivity.CurrentRow.Cells["BatchActID"].Value));

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

                DataTable dt = objBatchMachineDetails_DL.Get_ByBatchActID(Convert.ToInt32(dgvActivity.CurrentRow.Cells["BatchActID"].Value));

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
            txtOTMinutes.Text = "";
            cmbEmployee.Select();
        }


        private void Load_Sections()
        {
            Section_DL objSection_DL = new Section_DL(ConnectionStringClass.GetConnection());

            try
            {
                objSourceSections.DataSource = objSection_DL.GetDataView();
                cmbSections.DataSource = objSourceSections;
            }
            catch (Exception)
            {

                MessageBox.Show(this, "Error occured while loading Section", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

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

            Load_Sections();
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
            if (rdbPermanentAll.Checked == true)
            {
                txtNos.ReadOnly = false;
                btnMultiple.Enabled = false;
            }
            else
            {
                txtNos.ReadOnly = true;
                btnMultiple.Enabled = true;

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
                    DataTable dt = objEmployee_DL.Get_Workers_BySection(Convert.ToInt32(cmbSections.SelectedValue));
                    objSourceEmployee.DataSource = dt;
                    cmbEmployee.DataSource = objSourceEmployee;
                }
                else
                {
                    DataTable dt = objEmployee_DL.Get_Workers_Outsource(Convert.ToInt32(cmbSections.SelectedValue));
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

        private void btnFinishActivity_Click(object sender, EventArgs e)
        {
          DialogResult theResult=  MessageBox.Show(this, "Have you finish recording all the details of the actitivy", "Confirmation", MessageBoxButtons.YesNo);

          if (theResult == System.Windows.Forms.DialogResult.Yes)
          {
              if (objBatchActivity.BatchActID != 0)
              {
                  if (objBatchActivity.MainActivity.MainActivityTitle == "Weighing")
                  {
                      MessageBox.Show(this, "Please go to the Weighing Screen to Finish the Activity", "Wrong Attempt", MessageBoxButtons.OK);
                  }
                  else
                  {
                      frmBatchActivity objForm = new frmBatchActivity(objBatchActivity);
                      objForm.ShowDialog(this);
                      objForm.StartPosition = FormStartPosition.CenterParent;

                      Load_Activity_List();
                      Load_BatchLabourDetails();
                      Load_BatchMachineDetails();
                      SetColors();
                  }
              }
              else
              {
                  MessageBox.Show("Please select a Activity");
              }
          }
           
        }

        private void dgvBatcList_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
           
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

                    BatchLabourDetails obj = new BatchLabourDetails();

                    objBatchLabourDetails_DL.Delete(Convert.ToInt32(dgvBatchLabourDetails.CurrentRow.Cells["LabourRecID"].Value));

                    Load_BatchLabourDetails();


            }
        }

        private void dgvMachineDetails_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DialogResult theResult = MessageBox.Show(this, "Do you want to delete the selected Record", "Confirmation", MessageBoxButtons.YesNo);

                    if (theResult == System.Windows.Forms.DialogResult.Yes)
                    {
                        BatchMachineDetails obj = new BatchMachineDetails();

                        objBatchMachineDetails_DL.Delete(Convert.ToInt32(dgvMachineDetails.CurrentRow.Cells["MachineRecID"].Value));

                        Load_BatchMachineDetails();
                    }

            }
        }

        private void dgvBatcList_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            //Load_Activity_List();
            //Load_BatchLabourDetails();
            //Load_BatchMachineDetails();
            //SetColors();
        }

        private void txtOTMinutes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (e.KeyCode == Keys.Enter)
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

                            // Load_Activity_List();


                        }
                        catch (Exception)
                        {

                            MessageBox.Show(this, "Error occured while loading Labour Details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                }
            }
        }

        private void btnMultiple_Click(object sender, EventArgs e)
        {
            try

            {
            frmMultipleLabour objForm = new frmMultipleLabour(objBatchActivity,Convert.ToInt32(cmbSections.SelectedValue));
            objForm.ShowDialog(this);

            Load_BatchLabourDetails();
            }
            catch (Exception)
            {

                MessageBox.Show(this, "Error occured while loading Labour Details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cmbSections_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
            Load_employee();
            }
            catch (Exception)
            {

                MessageBox.Show(this, "Error occured while loading Labour ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                objBatch.BatchFinalQty = Convert.ToDecimal(txtFinalQty.Text);
                objBatch.FinalizedBy = objEmployee_DL.Get(CurrentUser.EmployeeID);

                objBatch_DL.Update_FinalQty_Admin(objBatch);

                MessageBox.Show(this, "Successfully Updated", "Successful", MessageBoxButtons.OK);
            }
            catch (Exception)
            {

                MessageBox.Show(this, "Error occured while loading Labour ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


       


    }
}
