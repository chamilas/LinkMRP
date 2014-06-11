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

namespace MRP_GUI.Sales
{
    public partial class FinanceDetails : Form
    {
        //private CustomerRegisteration_DL cr = new CustomerRegisteration_DL(ConnectionStringClass.GetConnection());
        private int UserID;
        private int Customer_Code;
        public FinanceDetails(int UserID, int Customer_Code)
        {
            InitializeComponent();
            this.UserID = UserID;
            this.Customer_Code = Customer_Code;

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            /*
            if (txt_BankGuarantyAmount.Text.Trim().ToString() == "" &&
                txt_branch.Text.Trim().ToString() == "" &&
                txt_exceedPrecentage.Text.Trim().ToString() == "" &&
                txt_guarantyBank.Text.Trim().ToString() == "" &&
                txt_remainingDates.Text.Trim().ToString() == "")
            {
                MessageBox.Show("Please fill all the details to continue...!", "Fill Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txt_BankGuarantyAmount.Text.Trim().ToString() == "")
            {
                MessageBox.Show("Please fill bank guaranty amount to continue...!", "Fill Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txt_guarantyBank.Text.Trim().ToString() == "")
            {
                MessageBox.Show("Please fill guaranty bank to continue...!", "Fill Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txt_branch.Text.Trim().ToString() == "")
            {
                MessageBox.Show("Please fill branch to continue...!", "Fill Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txt_exceedPrecentage.Text.Trim().ToString() == "")
            {
                MessageBox.Show("Please fill bank guaranty exceed precentage to continue...!", "Fill Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txt_remainingDates.Text.Trim().ToString() == "")
            {
                MessageBox.Show("Please fill remaining dates to continue...!", "Fill Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!IsNumInt(txt_remainingDates.Text.Trim().ToString()))
            {
                MessageBox.Show("Please enter a number to remaining dates to continue...!", "Numbers Only", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!IsNumfloat(txt_exceedPrecentage.Text.Trim().ToString()))
            {
                MessageBox.Show("Please enter a number to bank guaranty exceed precentage to continue...!", "Numbers Only", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string renewdate = dpk_renewDate.Value.ToShortDateString();
            MRP_REF.FinanceDetails fd = new MRP_REF.FinanceDetails();
            fd.Renew_Date = renewdate;
            fd.Remaing_Dates = int.Parse(txt_remainingDates.Text.Trim().ToString());
            fd.Status = 0;
            fd.UserID = UserID;
            fd.Customer_Code = Customer_Code;
            fd.Bank_Guaranty_Amount=txt_remainingDates.Text.Trim().ToString();
            fd.Bank_Guaranty_Exceed_Pre=float.Parse(txt_remainingDates.Text.Trim().ToString());
            fd.Branch=txt_branch.Text.Trim().ToString();
            fd.Guaranty_Bank = txt_guarantyBank.Text.Trim().ToString();
            cr.AddCompanyFinanceDetails(fd);

            long rows = cr.AddCompanyFinanceDetails(fd);

            if (rows > 0)
            {
                MessageBox.Show("Finance Details Added...!", "Finance Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                return;
            }
            else
            {
                MessageBox.Show("Recode is not added. Please try again...!", "Finance Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            */
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_BankGuarantyAmount.Text = "";
            txt_branch.Text = "";
            txt_exceedPrecentage.Text = "";
            txt_guarantyBank.Text = "";
            txt_remainingDates.Text = "";
        }

        private bool IsNumInt(string text)
        {
            try
            {
                int num = int.Parse(text.ToString());
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        private bool IsNumfloat(string text)
        {
            try
            {
                int num = int.Parse(text.ToString());
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
    }
}
