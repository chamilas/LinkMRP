using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SESD.MRP.REF;
using DL;

namespace MRP_GUI
{
    public partial class frmCostingResults_BasicProduct : System.Windows.Forms.Form
    {
        public frmCostingResults_BasicProduct(MTNBasicProduct obj)
        {
            InitializeComponent();
            objMTNBasicProduct = obj;
        }


        MTNBasicProduct objMTNBasicProduct = new MTNBasicProduct();
        MTNBasicProduct_DL objMTNBasicProduct_DL = new MTNBasicProduct_DL(ConnectionStringClass.GetConnection());


        private void txtUnitPrice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtUnitCost.Text != "")
                {
                    if (Convert.ToDecimal(txtUnitCost.Text) == 0)
                    {
                        MessageBox.Show(this, "Please enter a Valid UnitPrice", "Wrong Attempt", MessageBoxButtons.OK);
                    }
                    else
                    {
                        objMTNBasicProduct.UnitRate_Budget = Convert.ToDecimal(txtUnitCost.Text);

                        objMTNBasicProduct_DL.Update_Cost(objMTNBasicProduct, objMTNBasicProduct.MTN.MTNNo, objMTNBasicProduct.BasicProduct.BasicProductCode);

                        this.Close();
                    }
                }
            }
        }

        private void txtUnitPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.Validate_2Decimals(sender, e);
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.Validate_3Decimals(sender, e);
        }

        private void frmMRAResults_Load(object sender, EventArgs e)
        {
            if (objMTNBasicProduct.ReceivedQty != 0)
            {
                txtQuantity.Text = objMTNBasicProduct.ReceivedQty.ToString();
            }
            if (objMTNBasicProduct.UnitRate_Budget != 0)
            {
                txtUnitCost.Text = objMTNBasicProduct.UnitRate_Budget.ToString();
            }

            txtUnitCost.Select();
        }


        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {

                this.Close();
                return true;    // indicate that you handled this keystroke
            }

            return false;
        }


    }
}
