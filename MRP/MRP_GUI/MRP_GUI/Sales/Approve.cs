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
    public partial class Approve : Form
    {
        private CustomerRegisteration_DL dl = new CustomerRegisteration_DL(ConnectionStringClass.GetConnection());
        private int UserID;
        public Approve(int userID)
        {
            InitializeComponent();
            this.UserID = userID;
            cmb_approve.SelectedIndex = 0;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                int UserID = this.UserID;
                int Customer_code = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex + 1].Value.ToString());
                if (cmb_approve.SelectedIndex == 0)
                {
                    long rows = dl.ApproveCustomer(Customer_code,1,UserID);
                    if (rows > 0)
                    {
                        MessageBox.Show("Customer Approved...!", "Approve Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataGridView1.DataSource = dl.AppCustomerMaster();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Please try again...!", "Approve Customer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                if (cmb_approve.SelectedIndex == 1)
                {
                    long rows = dl.ApproveCompanyRegDetails(Customer_code, 1, UserID);
                    if (rows > 0)
                    {
                        MessageBox.Show("Company Register Details Approved...!", "Approve Company Register Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataGridView1.DataSource = dl.AppCustomerCompanyRegDetails();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Please try again...!", "Approve Company Register Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                if (cmb_approve.SelectedIndex == 2)
                {
                    long rows = dl.ApproveCompanyDetails(Customer_code, 1, UserID);
                    if (rows > 0)
                    {
                        MessageBox.Show("Company Details Approved...!", "Approve Company Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataGridView1.DataSource = dl.AppCustomerCompanyDetails();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Please try again...!", "Approve Company Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                if (cmb_approve.SelectedIndex == 3)
                {
                    long rows = dl.ApproveCustomerTransaction(Customer_code, 1, UserID);
                    if (rows > 0)
                    {
                        MessageBox.Show("Transaction Details Approved...!", "Approve Transaction Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataGridView1.DataSource = dl.AppCustomerTransactionDetails();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Please try again...!", "Approve Transaction Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                if (cmb_approve.SelectedIndex == 4)
                {
                    long rows = dl.ApproveCompanyFinanceDetails(Customer_code, 1, UserID);
                    if (rows > 0)
                    {
                        MessageBox.Show("Finance Details Approved...!", "Approve Finance Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataGridView1.DataSource = dl.AppCustomerFinanceDetails();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Please try again...!", "Approve Finance Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            if (cmb_approve.SelectedIndex == 0)
            {
                dataGridView1.DataSource = dl.AppCustomerMaster();
            }

            if (cmb_approve.SelectedIndex == 1)
            {
                dataGridView1.DataSource = dl.AppCustomerCompanyRegDetails();
            }

            if (cmb_approve.SelectedIndex == 2)
            {
                dataGridView1.DataSource = dl.AppCustomerCompanyDetails();
            }

            if (cmb_approve.SelectedIndex == 3)
            {
                dataGridView1.DataSource = dl.AppCustomerTransactionDetails();
            }

            if (cmb_approve.SelectedIndex == 4)
            {
                dataGridView1.DataSource = dl.AppCustomerFinanceDetails();
            }
        }
    }
}
