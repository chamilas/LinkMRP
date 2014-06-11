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
    public partial class TransactionDetails : Form
    {
       // private CustomerRegisteration_DL cr = new CustomerRegisteration_DL(ConnectionStringClass.GetConnection());
        private int UserID;
        private int Customer_Code;
        public TransactionDetails(int UserID, int Customer_Code)
        {
            InitializeComponent();
            this.UserID = UserID;
            this.Customer_Code = Customer_Code;
            drp_customerStatus.SelectedIndex = 0;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_dueAmount.Text = "";
            txt_openingBalanace.Text = "";
            txt_receviedCheques.Text = "";
            txt_returnedCheques.Text = "";
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            /*
            if (txt_dueAmount.Text.Trim().ToString() == "" &&
               txt_openingBalanace.Text.Trim().ToString() == "" &&
               txt_receviedCheques.Text.Trim().ToString() == "" &&
               txt_returnedCheques.Text.Trim().ToString() == "")
            {
                  MessageBox.Show("Please fill all the details to continue...!", "Fill Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                  return;
            }
            if (txt_openingBalanace.Text.Trim().ToString() == "")
            {
                MessageBox.Show("Please fill opening balance to continue...!", "Fill Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txt_receviedCheques.Text.Trim().ToString() == "")
            {
                MessageBox.Show("Please fill recevied cheques to continue...!", "Fill Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txt_returnedCheques.Text.Trim().ToString() == "")
            {
                MessageBox.Show("Please fill return cheques to continue...!", "Fill Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txt_dueAmount.Text.Trim().ToString() == "")
            {
                MessageBox.Show("Please fill due amount to continue...!", "Fill Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!IsNumfloat(txt_openingBalanace.Text.Trim().ToString()))
            {
                MessageBox.Show("Please fill opening balance as a number to continue...!", "Numbers Only", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!IsNumInt(txt_receviedCheques.Text.Trim().ToString()))
            {
                MessageBox.Show("Please fill recevied cheques as a number to continue...!", "Numbers Only", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!IsNumInt(txt_returnedCheques.Text.Trim().ToString()))
            {
                MessageBox.Show("Please fill retured cheques as a number to continue...!", "Numbers Only", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!IsNumfloat(txt_dueAmount.Text.Trim().ToString()))
            {
                MessageBox.Show("Please fill due amount as a number to continue...!", "Numbers Only", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MRP_REF.TransactionDetails td = new MRP_REF.TransactionDetails();
            td.Customer_Code = Customer_Code;
            td.Status = 0;
            td.Opening_Balanace=float.Parse(txt_openingBalanace.Text.Trim().ToString());
            td.Recived_Cheques=int.Parse(txt_receviedCheques.Text.Trim().ToString());
            td.Return_Cheques=int.Parse(txt_returnedCheques.Text.Trim().ToString());;
            td.UserID=UserID;
            td.Due_Amount = float.Parse(txt_dueAmount.Text.Trim().ToString()); ;
            td.Customer_Status=drp_customerStatus.Text.ToString();

            long rows = cr.AddCompanyTransactionDetails(td);

            if (rows > 0)
            {
                MessageBox.Show("Transaction Details Added...!", "Transaction Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                return;
            }
            else
            {
                MessageBox.Show("Recode is not added. Please try again...!", "Transaction Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            */
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
