using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using DL;
using SESD.MRP.REF;


namespace MRP_GUI
{
    public partial class frmPlanMaterial_Full : System.Windows.Forms.Form
    {



        public frmPlanMaterial_Full(User objuser, string _Type)
        {
            InitializeComponent();
            CurrentUser = objuser;
            PlanType = _Type;
        }

        User CurrentUser = new User();

        string PlanType = "";

        PlanMaterials_DL objPlanMaterials_DL = new PlanMaterials_DL(ConnectionStringClass.GetConnection());
        PlanWeek_DL objPlanWeek_DL = new PlanWeek_DL(ConnectionStringClass.GetConnection());
        Employee_DL objEmployee_DL = new Employee_DL(ConnectionStringClass.GetConnection());
        Department_DL objDepartment_DL = new Department_DL(ConnectionStringClass.GetConnection());
        Stock_DL objStock_DL = new Stock_DL(ConnectionStringClass.GetConnection());
        User_DL objUser_DL = new User_DL(ConnectionStringClass.GetConnection());
        Stock_DL objStocks_DL = new Stock_DL(ConnectionStringClass.GetConnection());

        Department objDepartment = new Department();

        DataTable dt = new DataTable();

        
        private void frmRPDMaterialRequirement_Load(object sender, EventArgs e)
        {
            
            try
            {

                cmbYear.Text = DateTime.Today.Year.ToString();
                cmbMonth.Text = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(DateTime.Today.Month);
 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());

            }
            

        }

        private void ColorGrid()
        {
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (Convert.ToString(dt.Rows[i]["MatMainType"]) == "Basic")
                {
                    dgvTotal.Rows[i].DefaultCellStyle.BackColor=Color.BurlyWood;
                }
                else
                {
                   dgvTotal.Rows[i].DefaultCellStyle.BackColor=Color.Coral;
                }
            }
        }

      

        private void LoadData()
        {
            try
            {
                bool PlanShow = false;

                if ((cmbMonth.Text != "") && (cmbYear.Text != ""))
                {
                    int x = objPlanMaterials_DL.GetPlan_Availability(PlanType, Convert.ToInt32(cmbYear.Text),
                    cmbMonth.Text, objPlanWeek_DL.SetPlanYear2(Convert.ToInt32(cmbYear.Text), cmbMonth.Text)
                   , objPlanWeek_DL.SetPlanMonth2(cmbMonth.Text),
                   objPlanWeek_DL.SetPlanYear3(Convert.ToInt32(cmbYear.Text), cmbMonth.Text)
                   , objPlanWeek_DL.SetPlanMonth3(cmbMonth.Text));

                    if (x == 2)
                    {
                        PlanShow = true;
                    }
                    else if (x == 1)
                    {
                        DialogResult theResult = MessageBox.Show(this, "Plan for Month2 or Month3 is Not Generated. Still you want to Load the Generated Data ?", "Missing Info", MessageBoxButtons.YesNo);

                        if (theResult == DialogResult.Yes)
                        {
                            PlanShow = true;
                        }
                        else
                        {
                            PlanShow = false;
                        }
                    }
                    else
                    {
                        PlanShow = false;
                    }

                    if (PlanShow == true)
                    {
                        Load_Plans();
                    }
                    else
                    {
                        MessageBox.Show("There are Plans which are not Generated");

                        Load_Plans();
                    }
                }
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());

            }
        }

        private void Load_Plans()
        {
            dt = objPlanMaterials_DL.GetRequirement_Full(PlanType, Convert.ToInt32(cmbYear.Text),
               cmbMonth.Text, objPlanWeek_DL.SetPlanYear2(Convert.ToInt32(cmbYear.Text), cmbMonth.Text)
              , objPlanWeek_DL.SetPlanMonth2(cmbMonth.Text),
              objPlanWeek_DL.SetPlanYear3(Convert.ToInt32(cmbYear.Text), cmbMonth.Text)
              , objPlanWeek_DL.SetPlanMonth3(cmbMonth.Text));

            dgvTotal.AutoGenerateColumns = false;
            objSourceWeeklyRunning.DataSource = dt;
            dgvTotal.DataSource = objSourceWeeklyRunning;
            objSourceWeeklyRunning.ResetBindings(true);
        }

        private void tbpWeeklyRequirement_Enter(object sender, EventArgs e)
        {
            LoadData();
        }


        private void dtpFirstWeekStart_ValueChanged(object sender, EventArgs e)
        {
        }

        private void dgvWeekly_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
        }


        private void btnGenerate_Click(object sender, EventArgs e)
        {
                objPlanMaterials_DL.Add(Convert.ToInt32(cmbYear.Text),cmbMonth.Text, PlanType,0);

            LoadData();
        }

        private void cmbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();

            if ((cmbYear.Text != "") && (cmbMonth.Text != ""))
            {
                txtMonth2.Text = objPlanWeek_DL.SetPlanMonth2(cmbMonth.Text);
                txtMonth3.Text = objPlanWeek_DL.SetPlanMonth3(cmbMonth.Text);

                txtYear2.Text = objPlanWeek_DL.SetPlanYear2(Convert.ToInt32(cmbYear.Text), cmbMonth.Text).ToString();
                txtYear3.Text = objPlanWeek_DL.SetPlanYear3(Convert.ToInt32(cmbYear.Text), cmbMonth.Text).ToString();
            }
        }

        private void cmbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
            if ((cmbYear.Text != "") && (cmbMonth.Text != ""))
            {
                txtMonth2.Text = objPlanWeek_DL.SetPlanMonth2(cmbMonth.Text);
                txtMonth3.Text = objPlanWeek_DL.SetPlanMonth3(cmbMonth.Text);

                txtYear2.Text = objPlanWeek_DL.SetPlanYear2(Convert.ToInt32(cmbYear.Text), cmbMonth.Text).ToString();
                txtYear3.Text = objPlanWeek_DL.SetPlanYear3(Convert.ToInt32(cmbYear.Text), cmbMonth.Text).ToString();
            }
        }

        private void btnFix_Click(object sender, EventArgs e)
        {
            try
            {

                for (int i = 1; i < 5; i++)
                {
                    objPlanMaterials_DL.Update_Fix(Convert.ToInt32(cmbYear.Text), cmbMonth.Text, i, PlanType, 1);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());

            }
        }

        private void btnFix_Click_1(object sender, EventArgs e)
        {
        }


      

    }
}