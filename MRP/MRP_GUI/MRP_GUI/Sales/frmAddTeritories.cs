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
    public partial class frmAddTerritories : Form
    {
        private Territory_DL ter = new Territory_DL(ConnectionStringClass.GetConnection());
        public frmAddTerritories()
        {
            InitializeComponent();
            cmb_territory.DataSource = ter.GetTerritory();
            cmb_customer.DataSource = ter.GetActiveCustomers();
            dataGridView1.DataSource = ter.GetTerritoryNamesByCustomer(ter.GetActiveCustomersIDByName(cmb_customer.Text.ToString()));

            if (cmb_customer.Items.Count == 0 || cmb_territory.Items.Count == 0)
            {
                btn_add.Enabled = false;
            }

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Do you wish to continue?","Assign Territories",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation);

            if (rs == DialogResult.Yes)
            {
                int num = ter.IsAddedTerritory(ter.GetActiveCustomersIDByName(cmb_customer.Text.ToString()), ter.GetTerritoryIDByName(cmb_territory.Text.ToString()));
                if (num > 0)
                {
                    MessageBox.Show("Recode is added already...!", "Assign Territory", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                long rows=ter.Assign_Territory(ter.GetActiveCustomersIDByName(cmb_customer.Text.ToString()), ter.GetTerritoryIDByName(cmb_territory.Text.ToString()));

                if (rows > 0)
                {
                    MessageBox.Show("New Territory Assign...!", "Assign Territory", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = ter.GetTerritoryNamesByCustomer(ter.GetActiveCustomersIDByName(cmb_customer.Text.ToString()));
                    return;
                }
                else
                {
                    MessageBox.Show("Recode is not added. Please try again...!", "Assign Territory", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void cmb_customer_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ter.GetTerritoryNamesByCustomer(ter.GetActiveCustomersIDByName(cmb_customer.Text.ToString()));
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                DialogResult rs = MessageBox.Show("Do you wish to continue?", "Remove Territories", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (rs == DialogResult.Yes)
                {
                    long rows = ter.Remove_Assign_Territory(ter.GetActiveCustomersIDByName(cmb_customer.Text.ToString()), ter.GetTerritoryIDByName(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex + 1].Value.ToString()));

                    if (rows > 0)
                    {
                        MessageBox.Show("Territory has been remove...!", "Remove Territory", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataGridView1.DataSource = ter.GetTerritoryNamesByCustomer(ter.GetActiveCustomersIDByName(cmb_customer.Text.ToString()));
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Recode is not added. Please try again...!", "Remove Territory", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                }
                
            }
        }

        private void frmAddTerritories_Load(object sender, EventArgs e)
        {

        }
    }
}
