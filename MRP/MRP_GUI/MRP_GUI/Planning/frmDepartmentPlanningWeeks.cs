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
    public partial class frmDepartmentPlanningWeeks : Form
    {
        public frmDepartmentPlanningWeeks(User objUser)
        {
            InitializeComponent();
            CurrentUser = objUser;
        }

        User CurrentUser = new User();

        RPDMaterialRequirement_DL objRPDMaterialRequirement_DL = new RPDMaterialRequirement_DL(ConnectionStringClass.GetConnection());
        DepartmentPlan_DL objDepartmentPlan_DL = new DepartmentPlan_DL(ConnectionStringClass.GetConnection());
        DepartmentalPlanningWeeks_DL objDepartmentalPlanningWeeks_DL = new DepartmentalPlanningWeeks_DL(ConnectionStringClass.GetConnection());
        DepartmentalPlanningMaterials_DL objDepartmentalPlanningMaterials_DL = new DepartmentalPlanningMaterials_DL(ConnectionStringClass.GetConnection());
        Employee_DL objEmployee_DL = new Employee_DL(ConnectionStringClass_MRP.GetConnection());
        Department_DL objDepartment_DL = new Department_DL(ConnectionStringClass_MRP.GetConnection());
        Stock_DL objStock_DL = new Stock_DL(ConnectionStringClass_MRP.GetConnection());
        User_DL objUser_DL = new User_DL(ConnectionStringClass_MRP.GetConnection());
        Stocks_DL objStocks_DL = new Stocks_DL(ConnectionStringClass.GetConnection());

        Department objDepartment = new Department();

        DataTable dt = new DataTable();
        DataTable dt1 = new DataTable();
        DataTable dt2 = new DataTable();
        DataTable dt3 = new DataTable();
        DataTable dt4 = new DataTable();
        DataTable dtWeekly = new DataTable();
        DataTable dtWeeklyRunning = new DataTable();


        private void frmDepartmentPlanningWeeks_Load(object sender, EventArgs e)
        {
            Load_Data();

        }

        private void Load_Data()
        {
            try
            {
                dt = objDepartmentalPlanningWeeks_DL.GetData();

                dgvDepartmentPlanningList.AutoGenerateColumns = false;
                objSource.DataSource = dt;
                dgvDepartmentPlanningList.DataSource = objSource;
                objSource.ResetBindings(true);

                objDepartment = objDepartment_DL.GetByDepType("RPD");

                ColorGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());

            }
        }


        private void CreatePlanningWeeks()
        {

            //dt1 = objRPDMaterialRequirement_DL.GetData(dtpFirstWeekStop.Value, dtpFirstWeekStart.Value, "All");
            //dt2 = objRPDMaterialRequirement_DL.GetData(dtpSecondWeekStop.Value, dtpSecondWeekStart.Value, "All");
            //dt3 = objRPDMaterialRequirement_DL.GetData(dtpThirdWeekStop.Value, dtpThirdWeekStart.Value, "All");
            //dt4 = objRPDMaterialRequirement_DL.GetData(dtpFourthWeekStop.Value, dtpFourthWeekStart.Value, "All");

            

            DepartmentPlans objDepartmentPlans = new DepartmentPlans();
            objDepartmentPlans.CreatedBy ="1676";
            objDepartmentPlans.CreatedDate = DateTime.Now;
            objDepartmentPlans.DepID = objDepartment.DepID;
            objDepartmentPlans.Freeze = false;
            objDepartmentPlans.LastUpdatedBy = objDepartmentPlans.CreatedBy;
            objDepartmentPlans.LastUpdatedOn = DateTime.Now;
            objDepartmentPlans.Month = dtpFirstWeekStart.Value.Month.ToString();
            objDepartmentPlans.Year = dtpFirstWeekStart.Value.Year;

            objDepartmentPlan_DL.Add(objDepartmentPlans);

            DepartmentalPlanningWeeks objDepartmentalPlanningWeeks1 = new DepartmentalPlanningWeeks();
            DepartmentalPlanningWeeks objDepartmentalPlanningWeeks2 = new DepartmentalPlanningWeeks();
            DepartmentalPlanningWeeks objDepartmentalPlanningWeeks3 = new DepartmentalPlanningWeeks();
            DepartmentalPlanningWeeks objDepartmentalPlanningWeeks4 = new DepartmentalPlanningWeeks();

            objDepartmentalPlanningWeeks1.MonthlyDeptPlanningID = Convert.ToInt32(objDepartmentPlan_DL.Get(dtpFirstWeekStart.Value.Year, dtpFirstWeekStart.Value.Month.ToString(), Convert.ToInt32(objDepartment.DepID)).MonthlyDeptPlanningID);
            objDepartmentalPlanningWeeks1.FromDate = dtpFirstWeekStart.Value;
            objDepartmentalPlanningWeeks1.ToDate = dtpFirstWeekStop.Value;
            objDepartmentalPlanningWeeks1.WeekID = 1;

            objDepartmentalPlanningWeeks2.MonthlyDeptPlanningID = objDepartmentalPlanningWeeks1.MonthlyDeptPlanningID;
            objDepartmentalPlanningWeeks2.FromDate = dtpSecondWeekStart.Value;
            objDepartmentalPlanningWeeks2.ToDate = dtpSecondWeekStop.Value;
            objDepartmentalPlanningWeeks2.WeekID = 2;

            objDepartmentalPlanningWeeks3.MonthlyDeptPlanningID = objDepartmentalPlanningWeeks1.MonthlyDeptPlanningID;
            objDepartmentalPlanningWeeks3.FromDate = dtpThirdWeekStart.Value;
            objDepartmentalPlanningWeeks3.ToDate = dtpThirdWeekStop.Value;
            objDepartmentalPlanningWeeks3.WeekID = 3;

            objDepartmentalPlanningWeeks4.MonthlyDeptPlanningID = objDepartmentalPlanningWeeks1.MonthlyDeptPlanningID;
            objDepartmentalPlanningWeeks4.FromDate = dtpFourthWeekStart.Value;
            objDepartmentalPlanningWeeks4.ToDate = dtpFourthWeekStop.Value;
            objDepartmentalPlanningWeeks4.WeekID = 4;

            objDepartmentalPlanningWeeks_DL.Add(objDepartmentalPlanningWeeks1);
            objDepartmentalPlanningWeeks_DL.Add(objDepartmentalPlanningWeeks2);
            objDepartmentalPlanningWeeks_DL.Add(objDepartmentalPlanningWeeks3);
            objDepartmentalPlanningWeeks_DL.Add(objDepartmentalPlanningWeeks4);
        }

        

        private void btnCreate_Click(object sender, EventArgs e)
        {
            CreatePlanningWeeks();
            Load_Data();
        }

        private void dtpFirstWeekStart_ValueChanged(object sender, EventArgs e)
        {
            dtpFourthWeekStop.Value = dtpFirstWeekStart.Value.AddMonths(1).AddDays(-1);
        }

        private void dtpFirstWeekStop_ValueChanged(object sender, EventArgs e)
        {
            dtpSecondWeekStart.Value = dtpFirstWeekStop.Value;
        }

        private void dtpSecondWeekStop_ValueChanged(object sender, EventArgs e)
        {
            dtpThirdWeekStart.Value = dtpSecondWeekStop.Value;

        }

        private void dtpThirdWeekStop_ValueChanged(object sender, EventArgs e)
        {
            dtpFourthWeekStart.Value = dtpThirdWeekStop.Value;
        }


        public void ColorGrid()
        {
            foreach (DataGridViewRow dr in dgvDepartmentPlanningList.Rows)
            {
                if (Convert.ToInt32(dr.Cells["ID"].Value) % 2 == 0)
                {
                    dgvDepartmentPlanningList.Rows[dr.Index].DefaultCellStyle.BackColor = Color.Aquamarine;
                }
            }
        }

    }
}
