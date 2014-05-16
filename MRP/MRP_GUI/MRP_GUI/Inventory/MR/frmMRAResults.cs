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
    public partial class frmMRAResults : System.Windows.Forms.Form
    {
        public frmMRAResults(DeliverNoteMaterials obj )
        {
            InitializeComponent();
            objDeliverNoteMaterials = obj;
        }


        DeliverNoteMaterials objDeliverNoteMaterials = new DeliverNoteMaterials();
        DeliverNoteMaterials_DL objDeliverNoteMaterials_DL = new DeliverNoteMaterials_DL(ConnectionStringClass.GetConnection());


        private void txtQuantity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtQuantity.Text != "")
                {
                    if(Convert.ToDecimal(txtQuantity.Text)==0)
                    {
                        MessageBox.Show(this, "Please enter a Valid Qty", "Wrong Attempt", MessageBoxButtons.OK);
                    }
                    else
                    {
                        if (Convert.ToDecimal(txtQuantity.Text) > objDeliverNoteMaterials.ActualReceivedQty)
                        {
                            MessageBox.Show(this, "Accepted Qty can not be Greater than Delivered Qty", "Wrong Attempt", MessageBoxButtons.OK);
                        }
                        else
                        {
                            txtUnitPrice.Select();
                        }
                    }
                }
            }
        }

        private void txtUnitPrice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtUnitPrice.Text != "")
                {
                    if (Convert.ToDecimal(txtUnitPrice.Text) == 0)
                    {
                        MessageBox.Show(this, "Please enter a Valid UnitPrice", "Wrong Attempt", MessageBoxButtons.OK);
                    }
                    else
                    {
                        objDeliverNoteMaterials.AcceptQty = Convert.ToDecimal(txtQuantity.Text);
                        objDeliverNoteMaterials.ReworkUnitPrice = Convert.ToDecimal(txtUnitPrice.Text);
                        

                        objDeliverNoteMaterials_DL.Update(objDeliverNoteMaterials);

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
            if (objDeliverNoteMaterials.AcceptQty != 0)
            {
                txtQuantity.Text = objDeliverNoteMaterials.AcceptQty.ToString();
            }
            if (objDeliverNoteMaterials.ReworkUnitPrice != 0)
            {
                txtUnitPrice.Text = objDeliverNoteMaterials.ReworkUnitPrice.ToString();
            }
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
