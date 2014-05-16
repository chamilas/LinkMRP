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

        public frmPlanPackingMaterial_Full()
        {
            InitializeComponent();
        }

        private void cmbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            //LoadData();
            if ((cmbYear.Text != "") && (cmbMonth.Text != ""))
            {
                txtMonth2.Text = objPlanWeek_DL.SetPlanMonth2(cmbMonth.Text);
                txtMonth3.Text = objPlanWeek_DL.SetPlanMonth3(cmbMonth.Text);

                txtYear2.Text = objPlanWeek_DL.SetPlanYear2(Convert.ToInt32(cmbYear.Text), cmbMonth.Text).ToString();
                txtYear3.Text = objPlanWeek_DL.SetPlanYear3(Convert.ToInt32(cmbYear.Text), cmbMonth.Text).ToString();
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
            }
        }

        private void btnff_Click(object sender, EventArgs e)
        {

        }
    }
}
