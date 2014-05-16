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
    public partial class frmCostingResults_FinishedProduct : System.Windows.Forms.Form
    {
        public frmCostingResults_FinishedProduct(MTNFinishProduct obj)
        {
            InitializeComponent();
            objMTNFinishProduct = obj;
        }


        MTNFinishProduct objMTNFinishProduct = new MTNFinishProduct();
        MTNFinishProduct_DL objMTNFinishProduct_DL = new MTNFinishProduct_DL(ConnectionStringClass.GetConnection());


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
                        objMTNFinishProduct.UnitRate_Budget = Convert.ToDecimal(txtUnitCost.Text);

                        objMTNFinishProduct_DL.Update_Cost(objMTNFinishProduct,objMTNFinishProduct.MTN.MTNNo, objMTNFinishProduct.FinishProduct.FinishProductCode);

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
            if (objMTNFinishProduct.ReceivedQty != 0)
            {
                txtQuantity.Text = objMTNFinishProduct.ReceivedQty.ToString();
            }
            if (objMTNFinishProduct.UnitRate_Budget != 0)
            {
                txtUnitCost.Text = objMTNFinishProduct.UnitRate_Budget.ToString();
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
