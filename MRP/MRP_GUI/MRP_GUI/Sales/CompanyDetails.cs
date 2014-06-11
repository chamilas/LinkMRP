using DL;
using MRP_DL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MRP_GUI.Sales
{
    public partial class CompanyDetails : Form
    {
        //private CustomerRegisteration_DL cr = new CustomerRegisteration_DL(ConnectionStringClass.GetConnection());
        private int UserID;
        private int Customer_Code;
        public CompanyDetails(int UserID, int Customer_Code)
        {
            InitializeComponent();
            this.UserID = UserID;
            this.Customer_Code = Customer_Code;
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_email.Text = "";
            txt_fax.Text = "";
            txt_name.Text = "";
            txt_tel.Text = "";
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            /*
            if (txt_email.Text.Trim().ToString() == "" &&
               txt_fax.Text.Trim().ToString() == "" &&
               txt_name.Text.Trim().ToString() == "" &&
               txt_tel.Text.Trim().ToString() == "")
            {
                MessageBox.Show("Please fill all the details to continue...!", "Fill Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txt_name.Text.Trim().ToString() == "")
            {
                MessageBox.Show("Please fill name to continue...!", "Fill Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txt_tel.Text.Trim().ToString() == "")
            {
                MessageBox.Show("Please fill telephone number to continue...!", "Fill Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txt_fax.Text.Trim().ToString() == "")
            {
                MessageBox.Show("Please fill fax to continue...!", "Fill Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txt_email.Text.Trim().ToString() == "")
            {
                MessageBox.Show("Please fill email to continue...!", "Fill Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!emailIsValid(txt_email.Text.Trim().ToString()))
            {
                MessageBox.Show("Please fill a valid email to continue...!", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!chk_telephone(txt_tel.Text.Trim().ToString()))
            {
                MessageBox.Show("Please fill a valid telephone number to continue...!", "Invalid Telephone Number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MRP_REF.CompanyDetails cd = new MRP_REF.CompanyDetails();
            cd.Customer_Code=Customer_Code;
            cd.Email=txt_email.Text.Trim().ToString();
            cd.Fax=txt_fax.Text.Trim().ToString();
            cd.Owner_name=txt_name.Text.Trim().ToString();
            cd.Telephone = txt_tel.Text.Trim().ToString();
            cd.Status=0;
            cd.UserID = UserID;

            long rows = cr.AddCompanyDetails(cd);

            if (rows > 0)
            {
                MessageBox.Show("Company Details Added...!", "Company Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                return;
            }
            else
            {
                MessageBox.Show("Recode is not added. Please try again...!", "Company Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
             */
        }

        public static bool emailIsValid(string email)
        {
            string expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, string.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private bool chk_telephone(string text)
        {
            try
            {
                if(text.Length==10)
                {
                    int num=int.Parse(text.ToString());
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
    }
}
