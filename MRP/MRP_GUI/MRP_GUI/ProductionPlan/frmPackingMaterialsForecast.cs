using DL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MRP_GUI.Sales
{
    public partial class frmPackingMaterialsForecast : Form
    {
        PlanMaterials_DL objPlanMaterials_DL = new PlanMaterials_DL(ConnectionStringClass.GetConnection());

        public frmPackingMaterialsForecast()
        {
            InitializeComponent();
            cmbMonth.SelectedIndex = 0;
            cmbYear.SelectedIndex = 0;
        }

        private void btnGenarate_Click(object sender, EventArgs e)
        {
            LoadPackingMaterialForecast(Convert.ToInt32(cmbYear.Text),cmbMonth.Text);
        }

        private void LoadPackingMaterialForecast(int year,String month)
        {
            dgvMaterialForcast.AutoGenerateColumns = false;
            bsMaterialForcast.DataSource = objPlanMaterials_DL.GetPackingMaterialsForecast(year, month);
            dgvMaterialForcast.DataSource = bsMaterialForcast;
            bsMaterialForcast.ResetBindings(true);
        }
    }
}
