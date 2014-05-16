using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ProductionPlan_DL;
using ProductionPlan_REF;

namespace ProductionPlan
{
    public partial class frmBatchPlan : Form
    {
        public frmBatchPlan(User objUser)
        {
            InitializeComponent();
            CurrentUser = objUser;
        }

        User CurrentUser = new User();

        BasicProducts_DL objBasicProducts_DL = new BasicProducts_DL(ConnectionStringClass.GetConnection());
        STDBatch_DL objSTDBatch_DL = new STDBatch_DL(ConnectionStringClass.GetConnection());
        DepartmentPlan_DL objDepartmentPlan_DL = new DepartmentPlan_DL(ConnectionStringClass.GetConnection());
        Department_DL objDepartment_DL = new Department_DL(ConnectionStringClass_MRP.GetConnection());
        Batch_DL objBatch_DL = new Batch_DL(ConnectionStringClass.GetConnection());
             
        Department objRPD = new Department();
        Department objPRPD = new Department();
        DepartmentPlans objDepartmentPlans = new DepartmentPlans();

        DataTable dtCategoryList = new DataTable();
        DataTable dtBasicProductList = new DataTable();
        DataTable dtSTDBatchList = new DataTable();
        DataTable dtBatchPlanWeekly = new DataTable();
        
        int WeekID = 0;
        int MonthlyPlanningID = 0;
        int WeekCount = 0;
        
        private void frmBatchPlan_Load(object sender, EventArgs e)
        {

            try

            {

                cmbMonth.DataSource =Enum.GetValues(typeof(DepartmentPlans.Months));
                cmbMonth.SelectedItem = Enum.GetName(typeof(DepartmentPlans.Months), DateTime.Today.Month);
                cmbYear.Text = DateTime.Today.Year.ToString();


                dtCategoryList=objBasicProducts_DL.GetCategoryList();

                objRPD = objDepartment_DL.GetByDepType("RPD");
                objPRPD = objDepartment_DL.GetByDepType("PRPD");

                if (dtCategoryList.Rows.Count != 0)
                {
                    objSourceCategoryList.DataSource = dtCategoryList;
                    cmbCategoryList.DataSource = objSourceCategoryList;
                }

                rdbWeek01_CheckedChanged(sender, e);
                cmbCategoryList_SelectedIndexChanged(sender, e);



                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());

            }

        }

        public int LoadWeeks()
        {
            try
            {

                DepartmentalPlanningWeeks_DL objDepartmentalPlanningWeeks_DL = new DepartmentalPlanningWeeks_DL(ConnectionStringClass.GetConnection());
                DepartmentalPlanningWeeks.DepartmentalPlanningWeeksCollec objDepartmentalPlanningWeeksCollec = new DepartmentalPlanningWeeks.DepartmentalPlanningWeeksCollec();

                if ((cmbMonth.Text != "") && (cmbYear.Text != ""))
                {
                    objDepartmentalPlanningWeeksCollec = objDepartmentalPlanningWeeks_DL.Get(
                        Convert.ToInt32(cmbYear.Text), Convert.ToString(Convert.ToInt32(Enum.Parse(typeof(DepartmentPlans.Months), cmbMonth.Text.ToString()))), (int)objRPD.DepID);

                }
                if (objDepartmentalPlanningWeeksCollec.Count > 0)
                {


                    foreach (DepartmentalPlanningWeeks obj in objDepartmentalPlanningWeeksCollec)
                    {
                        if (obj.WeekID == 1)
                        {
                            dtpWeek1Start.Value = obj.FromDate;
                            dtpWeek1Stop.Value = obj.ToDate;
                        }

                        if (obj.WeekID == 2)
                        {
                            dtpWeek2Start.Value = obj.FromDate;
                            dtpWeek2Stop.Value = obj.ToDate;
                        }


                        if (obj.WeekID == 3)
                        {
                            dtpWeek3Start.Value = obj.FromDate;
                            dtpWeek3Stop.Value = obj.ToDate;
                        }

                        if (obj.WeekID == 4)
                        {
                            dtpWeek4Start.Value = obj.FromDate;
                            dtpWeek4Stop.Value = obj.ToDate;
                        }

                    }
                    return 1;


                }
                else
                {
                    dtpWeek1Start.Value = DateTime.Today;
                    dtpWeek1Stop.Value = DateTime.Today;
                    dtpWeek2Start.Value = DateTime.Today;
                    dtpWeek2Stop.Value = DateTime.Today;
                    dtpWeek3Start.Value = DateTime.Today;
                    dtpWeek3Stop.Value = DateTime.Today;
                    dtpWeek4Start.Value = DateTime.Today;
                    dtpWeek4Stop.Value = DateTime.Today;


                    return 0;



                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());

            }

            return 0;

        }

        private void GetMonthlyPlanningID()
        {
            try
            {
                if ((cmbMonth.Text != "") && (cmbYear.Text != ""))
                {

                    objDepartmentPlans = objDepartmentPlan_DL.Get(Convert.ToInt32(cmbYear.Text),Convert.ToString(Convert.ToInt32(Enum.Parse(typeof(DepartmentPlans.Months),cmbMonth.Text))), (int)objRPD.DepID);
                    MonthlyPlanningID = objDepartmentPlans.MonthlyDeptPlanningID;

                    if (objDepartmentPlans.Freeze == true)
                    {
                        btnCreate.Enabled = false;
                        btnDelete.Enabled = false;
                    }
                    else
                    {
                        btnCreate.Enabled = true;
                        btnDelete.Enabled = true;
                    }
                }
            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());

            }
        }

        private void cmbCategoryList_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                

                if (cmbCategoryList.SelectedValue != null)
                {
                    dtBasicProductList = objBasicProducts_DL.GetDataByCategory(cmbCategoryList.SelectedValue.ToString());
                }

               if (dtBasicProductList.Rows.Count != 0)
               {
                   objSourceBasicProductList.DataSource = dtBasicProductList;
                   lstBasicProductList.DataSource = objSourceBasicProductList;

               }
               


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());

            }



            
        }


        private void cmbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            Refresh_Data();
            WeekCount = LoadWeeks(); 
            GetMonthlyPlanningID();

        }




        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {


                if ((rdbWeek01.Checked == true) | (rdbWeek02.Checked == true) | (rdbWeek03.Checked == true) | (rdbWeek04.Checked == true))
                    {
                        if (WeekCount > 0)
                        {
                            Batch obj = new Batch();


                            obj.MonthlyPlanningID = MonthlyPlanningID;
                            obj.WeekID = WeekID;
                            obj.BatchSize = Convert.ToDecimal(txtBatchSize.Text);
                            obj.BatchType = "Basic";
                            obj.BasicProductCode = lstBasicProductList.SelectedValue.ToString();

                            objBatch_DL.Add(obj);

                            Load_Data();
                        }
                        else
                        {
                            MessageBox.Show(this, "Weeks Of this Month Is Not Defined", "Please Define Weeks", MessageBoxButtons.OK);

                        }

                    }
                else
                    {

                        MessageBox.Show(this, "Please Select the Week","Week Is Not Defined", MessageBoxButtons.OK);

                    }

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());

            }
        }

        private void Load_Data()
        {
            try
            {
            
                if ((cmbYear.Text != "") && (cmbMonth.Text != ""))
                {
                        GetMonthlyPlanningID();

                       dtBatchPlanWeekly= objBatch_DL.GetDataByWeek(MonthlyPlanningID, WeekID);

                       dgvBatchList.AutoGenerateColumns = false;
                       objSourceBatchListWeekly.DataSource = dtBatchPlanWeekly;
                       dgvBatchList.DataSource = objSourceBatchListWeekly;
                       objSourceBatchListWeekly.ResetBindings(true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());

            }


        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                Batch obj = new Batch();
                DialogResult Result = new DialogResult();
                obj=objBatch_DL.GetByID(MonthlyPlanningID,WeekID,dgvBatchList.CurrentRow.Cells["Product"].Value.ToString(),Convert.ToDecimal(dgvBatchList.CurrentRow.Cells["BatchSize"].Value));

                Result= MessageBox.Show(this, "Are You Sure You want to Delete " + obj.BasicProductCode + "  From Week" + obj.WeekID, "Please Verify", MessageBoxButtons.YesNo);

                if (Result == DialogResult.Yes)
                {
                    objBatch_DL.Delete(obj);

                    Load_Data();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());

            }
        }

        private void cmbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            Refresh_Data();
            GetMonthlyPlanningID();
            WeekCount = LoadWeeks();

        }

        private void Refresh_Data()
        {
            rdbWeek01.Checked = false;
            rdbWeek02.Checked = false;
            rdbWeek03.Checked = false;
            rdbWeek04.Checked = false;
            objSourceBatchListWeekly.DataSource = null;
            objSourceBatchListWeekly.ResetBindings(true);
        }

        private void rdbWeek01_CheckedChanged(object sender, EventArgs e)
        {
            WeekID = 1;
            Load_Data();
        }

        private void rdbWeek02_CheckedChanged(object sender, EventArgs e)
        {
            WeekID = 2;
            Load_Data();
        }

        private void rdbWeek03_CheckedChanged(object sender, EventArgs e)
        {
            WeekID = 3;
            Load_Data();
        }

        private void rdbWeek04_CheckedChanged(object sender, EventArgs e)
        {
            WeekID = 4;
            Load_Data();
        }

        private void lstBasicProductList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstBasicProductList.SelectedValue != null)
            {
                dtSTDBatchList = objSTDBatch_DL.GetDataByBasicProductCode(lstBasicProductList.SelectedValue.ToString());

                objSourceSTDBatches.DataSource = dtSTDBatchList;
                cmbBatchSize.DataSource = objSourceSTDBatches;

               cmbBatchSize_SelectedIndexChanged(sender, e);
            }

            cmbBatchSize.Select();
        }

        private void cmbBatchSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBatchSize.Text = cmbBatchSize.Text;
        }

        private void cmbBatchSize_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                txtBatchSize.Select();
            }
        }

    }
}
