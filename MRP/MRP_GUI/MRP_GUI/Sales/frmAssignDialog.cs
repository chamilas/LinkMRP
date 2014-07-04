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
    public partial class frmAssignDialog : Form
    {
        private string OID;
        private string PID;
        private OrderSorting_DL ors = new OrderSorting_DL(ConnectionStringClass.GetConnection());
        public frmAssignDialog(string orderID, string productID)
        {
            InitializeComponent();
            this.OID = orderID;
            this.PID = productID;
            int count=ors.GetQuantity(productID);

            if (count > 0)
            {
                for (int x = 1; x <= count; x++)
                {
                    cmb_quantity.Items.Add(x);
                }
            }
            else
            {
                cmb_quantity.Items.Add(count);
            }
            cmb_quantity.SelectedIndex = 0;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool IsNum(string text)
        {
            try
            {
                int num = int.Parse(text);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (txt_batch.Text.Trim().ToString() == "" && txt_quantity.Text.Trim().ToString() == "")
            {
                MessageBox.Show("Please fill all details to continue...!", "Fill Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txt_quantity.Text.Trim().ToString() == "")
            {
                MessageBox.Show("Please fill quantity to continue...!", "Fill Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txt_batch.Text.Trim().ToString() == "")
            {
                MessageBox.Show("Please fill batch to continue...!", "Fill Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!IsNum(txt_quantity.Text.Trim().ToString()))
            {
                MessageBox.Show("Please fill quantity as a number to continue...!", "Numbers Only", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            long rows= ors.UpdateOrderDetails(OID, PID, int.Parse(txt_quantity.Text.Trim().ToString()), txt_batch.Text.Trim().ToString());
            if (rows > 0)
            {
                this.Close();
            }

            else
            {
                MessageBox.Show("Try again...!","Quantity Assign",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
            }

        }

        private void cmb_quantity_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_quantity.Text = cmb_quantity.SelectedItem.ToString();
        }
    }
}
