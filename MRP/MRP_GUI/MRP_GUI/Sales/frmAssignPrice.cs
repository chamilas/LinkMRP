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
    public partial class frmAssignPrice : System.Windows.Forms.Form
    {
        private SalesFinishProduct_DL sfp = new SalesFinishProduct_DL(ConnectionStringClass.GetConnection());
        private int type;
        public frmAssignPrice(SalesFinishProducts obj,int type)
        {
            InitializeComponent();
            txt_ProductID.Text = obj.finishProductCode;
            txt_Name.Text = obj.finishProductName;
            txt_Price.Text = obj.price.ToString();
            cmb_Sate.SelectedIndex = obj.isSellable;
            this.type = type;

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_Name.Text = "";
            txt_Price.Text = "";
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (txt_Name.Text.Trim().ToString() == "" && txt_Price.Text.Trim().ToString() == "")
            {
                MessageBox.Show("Please fill all the details to continue...!", "Fill Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txt_Name.Text.Trim().ToString() == "")
            {
                MessageBox.Show("Please fill Name to continue...!", "Fill Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txt_Price.Text.Trim().ToString() == "")
            {
                MessageBox.Show("Please fill Price to continue...!", "Fill Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!IsValidPrice(txt_Price.Text.Trim().ToString()))
            {
                MessageBox.Show("Please fill Price as a valid number to continue...!", "Numbers Only", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SalesFinishProducts obj = new SalesFinishProducts();
            obj.finishProductCode = txt_ProductID.Text.Trim().ToString();
            obj.finishProductName = txt_Name.Text.Trim().ToString();
            obj.isSellable = cmb_Sate.SelectedIndex;
            obj.price = double.Parse(txt_Price.Text.Trim().ToString());

            long rows = 0;
            if (type == 0)
            {
                rows=sfp.UpdateSalesFinishProduct(obj);
            }

            else
            {
                rows=sfp.AddSalesFinishProduct(obj);
            }

            if (rows > 0)
            {
                this.Close();
                return;
            }
            else
            {
                MessageBox.Show("Recode is not added. Please try again...!", "Change Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private bool IsValidPrice(string text)
        {
            try
            {
                double price = double.Parse(text);

                if (price >= 0)
                {
                    return true;
                }

                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        private void frmAssignPrice_Load(object sender, EventArgs e)
        {

        }
    }
}
