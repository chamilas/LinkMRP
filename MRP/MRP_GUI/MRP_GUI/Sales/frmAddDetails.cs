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
    public partial class frmAddDetails : Form
    {
        private CustomerRegisteration_DL dl = new CustomerRegisteration_DL(ConnectionStringClass.GetConnection());
        private static ComRegDetails crd;
        private static CompanyDetails cd;
        private static FinanceDetails fd;
        private static TransactionDetails td;
        private int UserID;
        public frmAddDetails(int userID)
        {
            InitializeComponent();
            this.UserID = userID;
            cmb_edit.SelectedIndex = 0;
            dataGridView2.DataSource = dl.GetCustomerDetails();
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            if (cmb_edit.SelectedIndex == 0)
            {
                dataGridView1.DataSource = dl.GetCustomerCompanyRegDetails();
            }

            if (cmb_edit.SelectedIndex == 1)
            {
                dataGridView1.DataSource = dl.GetCustomerCompanyDetails();
            }

            if (cmb_edit.SelectedIndex == 2)
            {
                dataGridView1.DataSource = dl.GetCustomerFinanceDetails();
            }

            if (cmb_edit.SelectedIndex == 3)
            {
                dataGridView1.DataSource = dl.GetCustomerTransactionDetails();
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                DialogResult rs = MessageBox.Show("Do you wish to continue...?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (rs == DialogResult.No)
                {
                    return;
                }


                int UserID = this.UserID;
                int Customer_code = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex + 1].Value.ToString());
                if (cmb_edit.SelectedIndex == 0)
                {
                    crd = new ComRegDetails(UserID, Customer_code);
                    crd.ShowDialog();
                    dataGridView1.DataSource = dl.GetCustomerCompanyRegDetails();
                }

                if (cmb_edit.SelectedIndex == 1)
                {
                    cd = new CompanyDetails(UserID, Customer_code);
                    cd.ShowDialog();
                    dataGridView1.DataSource = dl.GetCustomerCompanyDetails();
                }

                if (cmb_edit.SelectedIndex == 2)
                {
                    fd = new FinanceDetails(UserID, Customer_code);
                    fd.ShowDialog();
                    dataGridView1.DataSource = dl.GetCustomerFinanceDetails();
                }

                if (cmb_edit.SelectedIndex == 3)
                {
                    td = new TransactionDetails(UserID, Customer_code);
                    td.ShowDialog();
                    dataGridView1.DataSource = dl.GetCustomerTransactionDetails();
                }

            }
        }
    }
}
