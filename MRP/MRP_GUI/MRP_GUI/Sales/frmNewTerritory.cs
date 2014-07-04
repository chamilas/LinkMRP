using DL;
using MRP_DL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SESD.MRP.REF;

namespace MRP_GUI.Sales
{
    public partial class frmNewTerritory : System.Windows.Forms.Form
    {
        private Region_DL reg = new Region_DL(ConnectionStringClass.GetConnection());
        private Territory_DL ter = new Territory_DL(ConnectionStringClass.GetConnection());
        public frmNewTerritory()
        {
            InitializeComponent();
            cmb_district.SelectedIndex = 0;
            cmb_region.DataSource = reg.GetRegion();
            cmb_salesRep.DataSource = ter.GetSalesRep();

            if (cmb_region.Items.Count == 0 || cmb_salesRep.Items.Count == 0)
            {
                btn_save.Enabled = false;
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (txt_territoryName.Text.Trim().ToString() == "")
            {
                MessageBox.Show("Please fill Territory Name to continue...!", "Fill Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Territory tr = new Territory();
            tr.Name = txt_territoryName.Text.Trim().ToString();
            tr.SalesRep = ter.GetSalesRepIDByName(cmb_salesRep.Text.ToString());
            tr.RegionID = reg.GetRegionIDByName(cmb_region.Text.ToString());
            tr.District = cmb_district.Text.ToString();

            if (ter.IsAdd(tr) > 0)
            {
                MessageBox.Show("Recode is alrady added...!", "New Territory", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            long rows = ter.Add(tr);

            if (rows > 0)
            {
                MessageBox.Show("New Territory Added...!", "New Territory", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_territoryName.Text = "";
                return;
            }
            else
            {
                MessageBox.Show("Recode is not added. Please try again...!", "New Territory", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void frmNewTerritory_Load(object sender, EventArgs e)
        {

        }


    }
}
