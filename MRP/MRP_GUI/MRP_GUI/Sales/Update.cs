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
    public partial class Update : Form
    {
        //private CustomerRegisteration_DL dl = new CustomerRegisteration_DL(ConnectionStringClass.GetConnection());
        private static UpdateName un;
        private static UpdateAddress ua;
        public Update()
        {
            InitializeComponent();
            //dataGridView1.DataSource = dl.GetCustomerDetails();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int UserID = 0;

            DialogResult rs = MessageBox.Show("Do you wish to continue...?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (rs == DialogResult.No)
            {
                return;
            }
            /*
            if (e.ColumnIndex == 0)
            {
                int Customer_code = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex + 2].Value.ToString());
                un = new UpdateName(UserID, Customer_code);
                un.ShowDialog();
            }

            if (e.ColumnIndex == 1)
            {
                int Customer_code = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex + 1].Value.ToString());
                ua = new UpdateAddress(UserID, Customer_code);
                ua.ShowDialog();
            }
             //*/
        }
    }
}
