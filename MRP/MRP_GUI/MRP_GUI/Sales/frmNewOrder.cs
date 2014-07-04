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
    public partial class frmNewOrder : Form
    {
        private Territory_DL ter = new Territory_DL(ConnectionStringClass.GetConnection());
        private CustomerProducts_DL cus = new CustomerProducts_DL(ConnectionStringClass.GetConnection());
        private NewOrder_DL ord = new NewOrder_DL(ConnectionStringClass.GetConnection());
        public frmNewOrder()
        {
            InitializeComponent();
            ord.Clear_TempProducts();
            cmb_customers.DataSource = ter.GetActiveCustomers();
            cmb_product.DataSource = cus.GetCustomersProduct(ter.GetActiveCustomersIDByName(cmb_customers.Text.ToString()));

            if (cmb_customers.Items.Count == 0 || cmb_product.Items.Count == 0)
            {
                button1.Enabled = false;
            }
        }

        private void cmb_customers_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_product.DataSource = cus.GetCustomersProduct(ter.GetActiveCustomersIDByName(cmb_customers.Text.ToString()));
        }

        private bool IsNum(string text)
        {
            try
            {
                int num = int.Parse(text.Trim().ToString());
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (txt_quantity.Text.Trim().ToString() == "")
            {
                MessageBox.Show("Please fill Quantity to continue...!", "Fill Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_quantity.Text = "";
                return;
            }

            if (!IsNum(txt_quantity.Text.Trim().ToString()))
            {
                MessageBox.Show("Please fill Quantity as number to continue...!", "Numbers Only", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_quantity.Text = "";
                return;
            }

            string code = cmb_product.Text.ToString().Split('-')[0];
            int rows = ord.IsAddedProduct(code);

            if (rows > 0)
            {
                MessageBox.Show("Product is already added...!", "Order Products", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ord.AddTemp(code, int.Parse(txt_quantity.Text.ToString()));
            grid_order.DataSource=ord.GetTempProducts();
            cmb_customers.Enabled = false;
        }

        private void grid_order_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult rs = MessageBox.Show("Do you wish to continue...?", "Remove Product", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.No)
            {
                return;
            }

            if (e.ColumnIndex == 0)
            {
                string code = grid_order.Rows[e.RowIndex].Cells[e.ColumnIndex + 1].Value.ToString().Split('-')[0];
                ord.Remove_TempProducts(code);
                grid_order.DataSource = ord.GetTempProducts();
                
                if (grid_order.Rows.Count == 0)
                {
                    cmb_customers.Enabled = true;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (grid_order.Rows.Count != 0)
            {
                DialogResult rs = MessageBox.Show("Do you want to cancel the order...?", "Order Products", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.No)
                {
                    return;
                }

                else
                {
                    ord.Clear_TempProducts();
                    this.Close();
                }

            }
            else
            {
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (grid_order.Rows.Count != 0)
            {
                DialogResult rs = MessageBox.Show("Do you want to place the order...?", "Order Products", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.No)
                {
                    return;
                }

                else
                {
                    if (ord.FillDetails(ter.GetActiveCustomersIDByName(cmb_customers.Text.ToString())))
                    {
                        MessageBox.Show("Order is added Successfully...!", "Order Products", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        ord.Clear_TempProducts();
                        grid_order.DataSource = ord.GetTempProducts();
                        cmb_customers.Enabled = true;
                    }

                }

            }

            else
            {
                MessageBox.Show("No any products in the list to continue...", "Order Products", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
        }

        private void frmNewOrder_Load(object sender, EventArgs e)
        {

        }
    }
}
