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
    public partial class UpdateName : Form
    {
        //private CustomerRegisteration_DL dl = new CustomerRegisteration_DL(ConnectionStringClass.GetConnection());
        private int Customer_Code;
        private int UserID;
        public UpdateName(int UserID, int Customer_Code)
        {
            InitializeComponent();
            this.Customer_Code = Customer_Code;
            this.UserID = UserID;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            /*
            if (txt_name.Text.Trim().ToString() == "")
            {
                MessageBox.Show("Please fill name to continue...!", "Fill Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            long rows=dl.UpadeCustomerName(Customer_Code, txt_name.Text.Trim().ToString(), UserID);

            if (rows > 0)
            {
                MessageBox.Show("Name Updated...!", "Update Name", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                return;
            }
            else
            {
                MessageBox.Show("Recode is not added. Please try again...!", "Update Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
             */
        }
    }
}
