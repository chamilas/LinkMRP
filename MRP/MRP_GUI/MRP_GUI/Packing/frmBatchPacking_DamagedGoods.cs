using DL;
using MRP_GUI.Sales;
using SESD.MRP.REF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MRP_GUI.Packing
{
    public partial class frmBatchPacking_DamagedGoods : System.Windows.Forms.Form
    {
        BatchMachineDetails_DL objBatchMachineDetails_DL = new BatchMachineDetails_DL(ConnectionStringClass.GetConnection());
        BatchActivityMachineDetails_DL objBatchActivityMachineDetails_DL = new BatchActivityMachineDetails_DL(ConnectionStringClass.GetConnection());
        BatchActivityMachineDetails objBatchActivityMachineDetails = new BatchActivityMachineDetails();

        private long BatchActID;
        private String PackingType;

        public frmBatchPacking_DamagedGoods(long prmBatchActID, String prmPackingType)
        {
            BatchActID = prmBatchActID;
            PackingType = prmPackingType;
            InitializeComponent();
        }

        private void Load_BatchMachineDetails()
        {
            try
            {
                DataTable dt = new DataTable();

                if (BatchActID != 0)
                {
                    if (PackingType == "Primary")
                    {
                        dt = objBatchMachineDetails_DL.Get_ByBatchActID(Convert.ToInt32(BatchActID));
                    }
                    else if (PackingType == "Secondary") 
                    {
                        dt = objBatchMachineDetails_DL.Get_BySecondaryPackingBatchActID(Convert.ToInt32(BatchActID));
                    }
                }
                else
                {
                    dt = null;
                }

                dgvMachineDetails.AutoGenerateColumns = false;
                objSourceBatchMachine.DataSource = dt;
                dgvMachineDetails.DataSource = objSourceBatchMachine;
                objSourceBatchMachine.ResetBindings(true);


            }
            catch (Exception)
            {

                MessageBox.Show(this, "Error occured while loading Machine Details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void frmBatchPacking_DamagedGoods_Load(object sender, EventArgs e)
        {
            Load_BatchMachineDetails();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (dgvMachineDetails.CurrentRow != null)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (!DataValidation.Is2DecimalPointNumber(txtRejectedQty.Text) || !DataValidation.Is2DecimalPointNumber(txtOutputQty.Text) || !DataValidation.Is2DecimalPointNumber(txtInputQty.Text))
                    {
                        MessageBox.Show(this, "please enter valid Quantity ", "MRP System", MessageBoxButtons.OK);
                    }
                    else
                    {
                        objBatchActivityMachineDetails.InputQty = Convert.ToDecimal(txtInputQty.Text);
                        objBatchActivityMachineDetails.OutputQty = Convert.ToDecimal(txtOutputQty.Text);
                        objBatchActivityMachineDetails.RejectedQty = Convert.ToDecimal(txtRejectedQty.Text);
                        objBatchActivityMachineDetails.BatchID = BatchActID.ToString();
                        objBatchActivityMachineDetails.MachineID = dgvMachineDetails.CurrentRow.Cells["MachineCode"].Value.ToString();
                        objBatchActivityMachineDetails_DL.Add(objBatchActivityMachineDetails);
                        MessageBox.Show(this, "record successfully added", "MRP System", MessageBoxButtons.OK);
                        this.Dispose();
                        //MessageBox.Show("In " + objBatchActivityMachineDetails.InputQty + " Out " + objBatchActivityMachineDetails.OutputQty + " Rej " + objBatchActivityMachineDetails.RejectedQty + " Bat " + objBatchActivityMachineDetails.BatchID + " Mac " + objBatchActivityMachineDetails.MachineID);
                    }
                }
            }
            else
            {
                MessageBox.Show(this, "please Select a Machine ", "MRP System", MessageBoxButtons.OK);
            }
        }

        private void txtInputQty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtOutputQty.Select();
            }
        }

        private void txtOutputQty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtRejectedQty.Select();
            }
        }
    }
}
