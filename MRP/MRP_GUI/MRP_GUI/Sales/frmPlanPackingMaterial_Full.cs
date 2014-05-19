using DL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MRP_GUI.Sales
{
    public partial class frmPlanPackingMaterial_Full : Form
    {
        PlanWeek_DL objPlanWeek_DL = new PlanWeek_DL(ConnectionStringClass.GetConnection());
        PlanMaterials_DL objPlanMaterials_DL = new PlanMaterials_DL(ConnectionStringClass.GetConnection());
        DataTable dt = new DataTable();
        DataTable dtCheck = new DataTable();
        public frmPlanPackingMaterial_Full()
        {
            InitializeComponent();
        }

        private void cmbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {

            if ((cmbYear.Text != "") && (cmbMonth.Text != ""))
            {
                txtMonth2.Text = objPlanWeek_DL.SetPlanMonth2(cmbMonth.Text);
                txtMonth3.Text = objPlanWeek_DL.SetPlanMonth3(cmbMonth.Text);

                txtYear2.Text = objPlanWeek_DL.SetPlanYear2(Convert.ToInt32(cmbYear.Text), cmbMonth.Text).ToString();
                txtYear3.Text = objPlanWeek_DL.SetPlanYear3(Convert.ToInt32(cmbYear.Text), cmbMonth.Text).ToString();
                Load_Plans();
            }
        }

        private void frmPlanPackingMaterial_Full_Load(object sender, EventArgs e)
        {
            cmbYear.Text = DateTime.Today.Year.ToString();
            cmbMonth.Text = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(DateTime.Today.Month);
        }

        private void cmbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((cmbYear.Text != "") && (cmbMonth.Text != ""))
            {
                txtMonth2.Text = objPlanWeek_DL.SetPlanMonth2(cmbMonth.Text);
                txtMonth3.Text = objPlanWeek_DL.SetPlanMonth3(cmbMonth.Text);

                txtYear2.Text = objPlanWeek_DL.SetPlanYear2(Convert.ToInt32(cmbYear.Text), cmbMonth.Text).ToString();
                txtYear3.Text = objPlanWeek_DL.SetPlanYear3(Convert.ToInt32(cmbYear.Text), cmbMonth.Text).ToString();
                Load_Plans();
            }
        }

        private void btnff_Click(object sender, EventArgs e)
        {

        }

        private void Load_Plans()
        {
            dt = objPlanMaterials_DL.GetPackingMaterialsForecastFull( Convert.ToInt32(cmbYear.Text),
               cmbMonth.Text, objPlanWeek_DL.SetPlanYear2(Convert.ToInt32(cmbYear.Text), cmbMonth.Text)
              , objPlanWeek_DL.SetPlanMonth2(cmbMonth.Text),
              objPlanWeek_DL.SetPlanYear3(Convert.ToInt32(cmbYear.Text), cmbMonth.Text)
              , objPlanWeek_DL.SetPlanMonth3(cmbMonth.Text));

            dgvTotal.AutoGenerateColumns = false;
            bsTable.DataSource = dt;
            dgvTotal.DataSource = bsTable;
            bsTable.ResetBindings(true);
        }

        private void CheckPackingPaterial(int Year, string Month, int Week) 
        {
            dtCheck = objPlanMaterials_DL.CkeckPackingMaterialsForecast(Year,Month, Week);
            if (dtCheck.Rows.Count > 0)
            {

            }
        }
    }
}
