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
    public partial class frmNewCustomer : System.Windows.Forms.Form
    {
       // private DataLoading_DL dl = new DataLoading_DL(ConnectionStringClass.GetConnection());
        private int UserID;
        public frmNewCustomer(int UserID)
        {
            InitializeComponent();
            load();
            this.UserID = UserID;

        }

        private void load()
        {
            cmb_customerType.SelectedIndex = 0;
            cmb_category.SelectedIndex = 0;
            cmb_discountType.SelectedIndex = 0;

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            int UserID = this.UserID;

            if (txt_address.Text.Trim().ToString() == "" &&
                txt_creditsLimites.Text.Trim().ToString() == "" &&
                txt_discountApply.Text.Trim().ToString() == "" &&
                txt_name.Text.Trim().ToString() == "" &&
                txt_otherNames.Text.Trim().ToString() == "")
            {
                MessageBox.Show("Please fill all the details to continue...!","Fill Details",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            if (txt_name.Text.Trim().ToString() == "")
            {
                MessageBox.Show("Please fill name to continue...!", "Fill Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (txt_otherNames.Text.Trim().ToString() == "")
            {
                MessageBox.Show("Please fill other names to continue...!", "Fill Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (txt_address.Text.Trim().ToString() == "")
            {
                MessageBox.Show("Please fill address to continue...!", "Fill Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (txt_creditsLimites.Text.Trim().ToString() == "")
            {
                MessageBox.Show("Please fill credit limits to continue...!", "Fill Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (txt_discountApply.Text.Trim().ToString() == "")
            {
                MessageBox.Show("Please fill discount apply to continue...!", "Fill Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!IsNum(txt_discountApply.Text.Trim().ToString()))
            {
                MessageBox.Show("Please enter a valid number for Discount Apply...!", "Numbers Only", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!IsNum(txt_creditsLimites.Text.Trim().ToString()))
            {
                MessageBox.Show("Please enter a valid number for Creadit Limites...!", "Numbers Only", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                int Discount_type=0;
                if (cmb_discountType.SelectedIndex == 1)
                {
                    Discount_type = 1;
                }

                CustomerRegisteration_DL cr = new CustomerRegisteration_DL(ConnectionStringClass.GetConnection());

                NewCustomer nc=new NewCustomer();
                nc.Name = txt_name.Text.Trim().ToString();
                nc.OtherNames = txt_otherNames.Text.Trim().ToString();
                nc.Address = txt_address.Text.Trim().ToString();
                nc.Discount_Apply = txt_discountApply.Text.Trim().ToString();
                nc.Credits_Limits = float.Parse(txt_creditsLimites.Text.Trim().ToString());
                nc.Customer_Type = cmb_customerType.Text.ToString();
                nc.Category = cmb_category.Text.ToString();
                nc.Area = 1;
                nc.Discount_Type = Discount_type;
                nc.UserID = UserID;
                long rows=cr.Add(nc);

                if (rows > 0)
                {
                    MessageBox.Show("New Customer created...!", "New Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                    return;
                }
                else
                {
                    MessageBox.Show("Recode is not added. Please try again...!", "New Customer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private bool IsNum(string text)
        {
            try
            {
                float num = float.Parse(text.ToString());
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }

        }

        private void clear()
        {
            txt_address.Text = "";
            txt_creditsLimites.Text = "";
            txt_discountApply.Text = "";
            txt_name.Text = "";
            txt_otherNames.Text = "";
        }
    }
}
