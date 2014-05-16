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
    public partial class frmPlanMaterial : System.Windows.Forms.Form
    {



        public frmPlanMaterial(User objuser, string _Type)
        {
            InitializeComponent();
            CurrentUser = objuser;
            PlanType = _Type;
        }

        User CurrentUser = new User();

        string PlanType = "";

        PlanMaterials_DL objPlanMaterials_DL = new PlanMaterials_DL(ConnectionStringClass.GetConnection());
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

               dt= objPlanMaterials_DL.GetRequirement(PlanType, Convert.ToInt32(cmbYear.Text), cmbMonth.Text);

               dgvTotal.AutoGenerateColumns = false;
               objSourceWeeklyRunning.DataSource = dt;
               dgvTotal.DataSource = objSourceWeeklyRunning;
               objSourceWeeklyRunning.ResetBindings(true);

                if(dt.Rows.Count>0)
                {
                    if (Convert.ToInt32(dt.Rows[0]["Status"]) == 1)
                    {
                        btnFix.Enabled = false;
                        btnGenerate.Enabled = false;
                    }
                    else
                    {
                        btnFix.Enabled = true;
                        btnGenerate.Enabled = true;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());

            }
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
            if (PlanType == "RPD")
            {
                objPlanMaterials_DL.Add(Convert.ToInt32(cmbYear.Text), cmbMonth.Text, PlanType, 0);
            }
            else if (PlanType == "PRPD")
            {
                objPlanMaterials_DL.Add_PRPD(Convert.ToInt32(cmbYear.Text), cmbMonth.Text, PlanType, 0);
            }
            else
            {
                objPlanMaterials_DL.Add_Stores(Convert.ToInt32(cmbYear.Text), cmbMonth.Text, PlanType, 0);
            }
            LoadData();
        }

        private void cmbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void cmbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnFix_Click(object sender, EventArgs e)
        {
            try
            {
                if (PlanType == "RPD")
                {
                    objPlanMaterials_DL.Add(Convert.ToInt32(cmbYear.Text), cmbMonth.Text, PlanType, 0);

                    for (int i = 1; i < 5; i++)
                    {
                        objPlanMaterials_DL.Update_Fix(Convert.ToInt32(cmbYear.Text), cmbMonth.Text, i, PlanType, 1);
                    }

                    MessageBox.Show(this, "RPD Plan is Fixed and Now you can Generate RPD Plan Report", "Fixed", MessageBoxButtons.OK); 

                }
                else if (PlanType == "PRPD")
                {
                    objPlanMaterials_DL.Add_PRPD(Convert.ToInt32(cmbYear.Text), cmbMonth.Text, PlanType, 0);

                    for (int i = 1; i < 5; i++)
                    {
                        objPlanMaterials_DL.Update_Fix(Convert.ToInt32(cmbYear.Text), cmbMonth.Text, i, PlanType, 1);
                    }

                    MessageBox.Show(this, "PRPD Plan is Fixed and Now you can Generate PRPD Plan Report", "Fixed", MessageBoxButtons.OK); 
                }
                else
                {
                    objPlanMaterials_DL.Add_PRPD(Convert.ToInt32(cmbYear.Text), cmbMonth.Text, PlanType, 0);

                    for (int i = 1; i < 5; i++)
                    {
                        objPlanMaterials_DL.Update_Fix(Convert.ToInt32(cmbYear.Text), cmbMonth.Text, i, PlanType, 1);
                    }

                    MessageBox.Show(this, "Stores Plan is Fixed and Now you can Generate Stores Plan Report", "Fixed", MessageBoxButtons.OK); 
                }

               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());

            }
        }


      

    }
}