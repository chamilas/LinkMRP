using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using DL;
using SESD.MRP.REF;


namespace MRP_GUI
{
    public partial class frmDepartmentPlanningWeeks : System.Windows.Forms.Form
    {
        public frmDepartmentPlanningWeeks(User objUser)
        {
            InitializeComponent();
            CurrentUser = objUser;
        }

        User CurrentUser = new User();

        PlanWeek_DL objPlanWeek_DL = new PlanWeek_DL(ConnectionStringClass.GetConnection());
        Employee_DL objEmployee_DL = new Employee_DL(ConnectionStringClass.GetConnection());
        Department_DL objDepartment_DL = new Department_DL(ConnectionStringClass.GetConnection());
        Stock_DL objStock_DL = new Stock_DL(ConnectionStringClass.GetConnection());
        User_DL objUser_DL = new User_DL(ConnectionStringClass.GetConnection());
        Stock_DL objStocks_DL = new Stock_DL(ConnectionStringClass.GetConnection());

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
            cmbYear.Text = DateTime.Today.Year.ToString();
            cmbMonth.Text = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(DateTime.Today.Month);




        }

        private void Load_Data()
        {
            try
            {
                if (cmbYear.Text != "")
                {
                    dt = objPlanWeek_DL.GetDataByMonth(Convert.ToInt32(cmbYear.Text), cmbMonth.Text);

                    dgvDepartmentPlanningList.AutoGenerateColumns = false;
                    objSource.DataSource = dt;
                    dgvDepartmentPlanningList.DataSource = objSource;
                    objSource.ResetBindings(true);

                    if (dt.Rows.Count > 0)
                    {
                        if (dt.Rows.Count == 4)
                        {
                            if (Convert.ToInt32(dt.Rows[0]["State"]) == 1)
                            {
                                btnCreate.Enabled = false;
                                btnFinalize.Enabled = false;
                            }
                            else
                            {
                                btnCreate.Enabled = false;
                                btnFinalize.Enabled = true;
                            }
                        }
                        else
                        {
                            btnCreate.Enabled = true;
                            btnFinalize.Enabled = false;
                        }
                    }
                    else
                    {
                        btnCreate.Enabled = true;
                        btnFinalize.Enabled = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());

            }
        }

        private bool Validate()
        {
            DateTime from = dtpFirstWeekStart.Value;
            DateTime to = dtpFirstWeekStop.Value;

            string cfrom = from.ToString("MMMM", CultureInfo.InvariantCulture);
            string cto = to.ToString("MMMM", CultureInfo.InvariantCulture);

            bool x = false;
            if ((cmbMonth.Text == cfrom) && (cmbMonth.Text == cto)
                && (Convert.ToInt32(cmbYear.Text) == dtpFirstWeekStart.Value.Year)
                && (Convert.ToInt32(cmbYear.Text) == dtpFirstWeekStop.Value.Year))
            {
                if (dtpFirstWeekStart.Value < dtpFirstWeekStop.Value)
                {
                    x = true;
                }
            }

            return x;

        }

        private void CreatePlanningWeeks()
        {

            PlanWeeks objPlanWeeks = new PlanWeeks();

            objPlanWeeks.Year = Convert.ToInt32(cmbYear.Text);
            objPlanWeeks.Month = cmbMonth.Text;
            objPlanWeeks.WeekID = Convert.ToInt32(cmbWeekID.Text);
            objPlanWeeks.FromDate = dtpFirstWeekStart.Value;
            objPlanWeeks.ToDate = dtpFirstWeekStop.Value;
            objPlanWeeks.State = 0;

            bool y = Validate();

            if (y == true)
            {
                objPlanWeek_DL.Add(objPlanWeeks);

            }
            else
            {
                MessageBox.Show(this, "Incorrect Selections", "Incorrect Attempt", MessageBoxButtons.OK);
            }
        }

        

        private void btnCreate_Click(object sender, EventArgs e)
        {
            CreatePlanningWeeks();
            Load_Data();
        }



        private void btnView_Click(object sender, EventArgs e)
        {
            
        }

        private void cmbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            Load_Data();
        }

        private void cmbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            Load_Data();
        }

        private void btnFinalize_Click(object sender, EventArgs e)
        {
            try
            {
                if (dt.Rows.Count == 4)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {

                        objPlanWeek_DL.Update_Fix(Convert.ToInt32(dt.Rows[i]["Year"]), Convert.ToString(dt.Rows[i]["Month"]),
                            Convert.ToInt32(dt.Rows[i]["WeekID"]), Convert.ToInt32(dt.Rows[i]["RevisionID"]),1);
                    }

                    Load_Data();
                }
                else
                {
                    MessageBox.Show("A Month needs to be divided exactly into 4 Weeks");
                }
            }
            catch (Exception ex)
            {

            }
        }

    }
}
