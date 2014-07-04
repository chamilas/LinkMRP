using DL;
using MRP_DL;
using MRP_GUI.Sales;
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
    public partial class frmNewRegion : System.Windows.Forms.Form
    {
        private Region_DL reg = new Region_DL(ConnectionStringClass.GetConnection());
        public frmNewRegion()
        {
            InitializeComponent();
            cmb_salesMethod.DataSource = reg.GetSalesMethods();
            cmb_productCategory.DataSource = reg.GetProductCategory();
            cmb_ASM.DataSource = reg.GetASM();
            cmb_province.SelectedIndex = 0;

            if (cmb_ASM.Items.Count == 0 || cmb_productCategory.Items.Count == 0 || cmb_salesMethod.Items.Count == 0)
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
            if (txt_name.Text.Trim().ToString() == "")
            {
                MessageBox.Show("Please fill Region Name to continue...!", "Fill Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SESD.MRP.REF.Region rg = new SESD.MRP.REF.Region();
            rg.Name = txt_name.Text.ToString();
            rg.ASM = reg.GetASMByID(cmb_ASM.Text.ToString());
            rg.Province = cmb_province.Text.ToString();
            rg.ProductCatID = reg.GetProductCatID(cmb_productCategory.Text.ToString());
            rg.SalesMethodID=reg.GetSalesMethodsID(cmb_salesMethod.Text.ToString());

            if (reg.IsAdd(rg) > 0)
            {
                MessageBox.Show("Recode is alrady added...!", "New Region", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            long rows = reg.Add(rg);

            if (rows > 0)
            {
                MessageBox.Show("New Region " + txt_name.Text.ToString().Trim() + " Added...!", "New Region", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_name.Text = "";
                return;
            }
            else
            {
                MessageBox.Show("Recode is not added. Please try again...!", "New Region", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void frmNewRegion_Load(object sender, EventArgs e)
        {

        }
    }
}
