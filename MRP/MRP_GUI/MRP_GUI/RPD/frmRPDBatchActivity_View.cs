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
    public partial class frmRPDBatchActivity_View : System.Windows.Forms.Form
    {

        User CurrentUser = new User();

        public frmRPDBatchActivity_View(User objUser, long _RPDBatchActivityID)
        {
            InitializeComponent();
            CurrentUser = objUser;
            RPDBatchActivityID = _RPDBatchActivityID;
        }

        RPDBatch_DL objRPDBatch_DL = new RPDBatch_DL(ConnectionStringClass.GetConnection());
        MainActivity_DL objMainActivity_DL = new MainActivity_DL(ConnectionStringClass.GetConnection());
        RPDBatchActivity_DL objRPDBatchActivity_DL = new RPDBatchActivity_DL(ConnectionStringClass.GetConnection());
        MachineActivity_DL objMachineActivity_DL = new MachineActivity_DL(ConnectionStringClass.GetConnection());
        RPDActivityDetailsLabour_DL objRPDActivityDetailsLabour_DL = new RPDActivityDetailsLabour_DL(ConnectionStringClass.GetConnection());
        RPDActivityDetailsMachine_DL objRPDActivityDetailsMachine_DL = new RPDActivityDetailsMachine_DL(ConnectionStringClass.GetConnection());
        Machine_DL objMachine_DL = new Machine_DL(ConnectionStringClass.GetConnection());
        Employee_DL objEmployee_DL = new Employee_DL(ConnectionStringClass.GetConnection());

        RPDBatch objRPDBatch = new RPDBatch();
        RPDBatchActivity objRPDBatchActivity = new RPDBatchActivity();
        MainActivity objActivity = new MainActivity();

        Section_DL objSection_DL = new Section_DL(ConnectionStringClass.GetConnection());
        Sections objSection = new Sections();
        DataTable dtSections = new DataTable();

        long RPDBatchActivityID = 0;
        bool Loaded = false;

        private void frmBatchList_Load(object sender, EventArgs e)
        {
            objRPDBatchActivity = objRPDBatchActivity_DL.Get(RPDBatchActivityID);
            objActivity = objMainActivity_DL.Get(objRPDBatchActivity.MainActID);
            txtActivity.Text = objActivity.MainActivityTitle;

            Load_Machine();
            Load_employee();
            Load_Labour_List();
            Load_Machine_List();

            rdbPermanentSection.Checked = true;
           

        }

        private void Load_Sections()
        {
            try
            {

                dtSections = objSection_DL.GetDataView();

                objSourceSections.DataSource = dtSections;
                cmbSections.DataSource = objSourceSections;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }



        private void Load_Labour_List()
        {
            try
            {
                DataTable dt = objRPDActivityDetailsLabour_DL.GetData_By_BatchAct(RPDBatchActivityID);
                objSourceBatchLabour.DataSource = dt;

                   dgvBatchLabourDetails.AutoGenerateColumns = false;
                   dgvBatchLabourDetails.DataSource = objSourceBatchLabour;
                   objSourceBatchLabour.ResetBindings(true);


              //  SetColors();

            }
            catch (Exception)
            {

                MessageBox.Show(this, "Error occured while loading Activity List", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



        }

        private void Load_Machine_List()
        {
            try
            {
                DataTable dt =objRPDActivityDetailsMachine_DL.GetData_By_BatchAct(RPDBatchActivityID);
                
             objSourceBatchMachine.DataSource = dt;

               dgvMachineDetails.AutoGenerateColumns = false;
               dgvMachineDetails.DataSource = objSourceBatchMachine;
               objSourceBatchMachine.ResetBindings(true);


                //SetColors();

            }
            catch (Exception)
            {

                MessageBox.Show(this, "Error occured while loading Activity List", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



        }


        //private void SetColors()
        //{
        //    for (int i=0;i<dgvActivity.Rows.Count;i++)
        //    {
                
        //            objBatchActivity = objRPDBatchActivity_DL.GetByID(Convert.ToInt32(dgvActivity.Rows[i].Cells["BatchActID"].Value));

        //            if (objBatchActivity.BatchActStatus == BatchActivity.Status.Finished)
        //            {
        //                dgvActivity.Rows[i].DefaultCellStyle.BackColor = Color.Green;

        //            }
        //            else if (objBatchActivity.BatchActStatus == BatchActivity.Status.Start)
        //            {
        //                dgvActivity.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
        //            }
        //            else
        //            {
        //                dgvActivity.Rows[i].DefaultCellStyle.BackColor = Color.White;
        //            }

                
        //    }

        //}



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
                    if (objRPDBatchActivity.ActivityStatus ==RPDBatchActivity.Status.Finalized)
                    {
                        MessageBox.Show(this,"Activity is already Finished","Wrong Attempt",MessageBoxButtons.OK);

                        txtMachineStart.Text = "";
                        txtMachineStop.Text = "";
                    }
                    else
                    {
                        RPDActivityDetailsMachine obj = new RPDActivityDetailsMachine();

                        obj.BatchActID = RPDBatchActivityID;
                        obj.StartTime = txtMachineStart.Text;
                        obj.StopTime = txtMachineStop.Text;
                        obj.Description ="No";
                        obj.MachineCode = cmbMachine.SelectedValue.ToString();
                        obj.MeshSize = "N/A";

                      objRPDActivityDetailsMachine_DL.Add(obj);

                      Load_Machine_List();

                        txtMachineStart.Text = "";
                        txtMachineStop.Text = "";

                        //SetColors();

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
            txtOTMinutes.Text = "";
            cmbEmployee.Select();
        }

        private void rdbPermanentSection_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbPermanentSection.Checked == true)
            {
                txtNos.ReadOnly = false;
                btnMultiple.Enabled = true;
                Load_Sections();
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
                btnMultiple.Enabled = false;
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
                btnMultiple.Enabled = false;
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
                    DataTable dt = objEmployee_DL.Get_Workers_BySection(Convert.ToInt32(cmbSections.SelectedValue));
                    objSourceEmployee.DataSource = dt;
                    cmbEmployee.DataSource = objSourceEmployee;
                }
                else
                {
                    DataTable dt = objEmployee_DL.Get_Workers_Outsource(Convert.ToInt32(Convert.ToInt32(cmbSections.SelectedValue)));
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

                if (objRPDBatchActivity.ActivityStatus == RPDBatchActivity.Status.Finalized)
                {
                    MessageBox.Show(this, "This Activity Is Finished.", "Wrong Attempt", MessageBoxButtons.OK);
                }
                else
                {
                        DialogResult theResult = new DialogResult();

                        theResult = MessageBox.Show(this, "Do you Want to Delete this Record", "Confirmation", MessageBoxButtons.YesNo);

                        if (theResult == System.Windows.Forms.DialogResult.Yes)
                        {
                            BatchLabourDetails obj = new BatchLabourDetails();

                            objRPDActivityDetailsLabour_DL.Delete(Convert.ToInt32(dgvBatchLabourDetails.CurrentRow.Cells["LabourRecID"].Value));

                            Load_Labour_List();
                        }
                }


            }
        }

        private void dgvMachineDetails_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DialogResult theResult = MessageBox.Show(this, "Do you want to delete the selected Record", "Confirmation", MessageBoxButtons.YesNo);

                if (objRPDBatchActivity.ActivityStatus == RPDBatchActivity.Status.Finalized)
                {
                    MessageBox.Show(this, "This Activity Is Finished.", "Wrong Attempt", MessageBoxButtons.OK);
                }
                else
                {
                    if (theResult == System.Windows.Forms.DialogResult.Yes)
                    {
                        BatchMachineDetails obj = new BatchMachineDetails();

                       objRPDActivityDetailsMachine_DL.Delete(Convert.ToInt32(dgvMachineDetails.CurrentRow.Cells["MachineRecID"].Value));

                       Load_Machine_List();
                    }
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
                    if (objRPDBatchActivity.ActivityStatus == RPDBatchActivity.Status.Finalized)
                    {
                        MessageBox.Show(this, "Activity is already Finished", "Wrong Attempt", MessageBoxButtons.OK);

                        Clear_Labour();
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

                            RPDActivityDetailsLabour obj = new RPDActivityDetailsLabour();


                            obj.BatchActID = RPDBatchActivityID;
                            obj.Helper = cmbEmployee.SelectedValue.ToString();
                            obj.OTHours = Calculate.CalOTHours(OTHours, OTMinutes);
                            obj.StartTime = txtFrom.Text;
                            obj.StopTime = txtTo.Text;
                            obj.Description = "No";


                            if (rdbOutsource.Checked == true)
                            {
                                int theCount = Convert.ToInt32(txtNos.Text);

                                for (int i = 0; i < theCount; i++)
                                {
                                    objRPDActivityDetailsLabour_DL.Add(obj);
                                }
                            }
                            else
                            {
                                objRPDActivityDetailsLabour_DL.Add(obj);
                            }



                            Load_Labour_List();

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
        }

        private void btnMultiple_Click(object sender, EventArgs e)
        {
            try
            {
                frmMultipleLabour_RPD objForm = new frmMultipleLabour_RPD(objRPDBatchActivity, (int)objActivity.SectionID);
                objForm.ShowDialog(this);

                Load_Labour_List();
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

                MessageBox.Show(this, "Error occured while loading Labour Details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


       


    }
}
