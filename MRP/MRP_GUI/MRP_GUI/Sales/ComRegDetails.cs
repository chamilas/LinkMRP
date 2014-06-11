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
    public partial class ComRegDetails : Form
    {
        //private CustomerRegisteration_DL cr = new CustomerRegisteration_DL(ConnectionStringClass.GetConnection());
        private int UserID;
        private int Customer_Code;
        public ComRegDetails(int UserID, int Customer_Code)
        {
            InitializeComponent();
            this.UserID = UserID;
            this.Customer_Code = Customer_Code;
            for (int x = 1970; x < System.DateTime.Today.Year; x++)
            {
                cmb_companyRegNum.Items.Add(x);
                cmb_busReg_num.Items.Add(x);
            }

            cmb_busReg_num.SelectedIndex = cmb_busReg_num.Items.Count-1;
            cmb_companyRegNum.SelectedIndex = cmb_companyRegNum.Items.Count - 1;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {/*
            if (!IsNum(txt_vatRegNum.Text.Trim().ToString()))
            {
                MessageBox.Show("Please enter a number as Vat Register...!", "Numbers Only", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CompanyRegDetails crd = new CompanyRegDetails();
            crd.Customer_Code = Customer_Code;
            crd.BusinessRegNum = int.Parse(cmb_busReg_num.Text.ToString());
            crd.CompanyRegNum = int.Parse(cmb_companyRegNum.Text.ToString());
            crd.VatRegNum = int.Parse(txt_vatRegNum.Text.Trim().ToString());
            crd.Status = 0;
            crd.UserID=UserID;
            
            CustomerRegisteration_DL cr = new CustomerRegisteration_DL(ConnectionStringClass.GetConnection());
            long rows=cr.AddCompanyRegDetails(crd);

            if (rows > 0)
            {
                MessageBox.Show("Company Register Details Added...!", "Company Register Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                return;
            }
            else
            {
                MessageBox.Show("Recode is not added. Please try again...!", "Company Register Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            */
        }

        private bool IsNum(string text)
        {
            try
            {
                float num = float.Parse(text.ToString());
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
