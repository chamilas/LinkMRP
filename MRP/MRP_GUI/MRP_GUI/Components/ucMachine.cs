using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SESD.MRP.REF;
using DL;
using System.Data.SqlClient;


namespace MRP_GUI
{
    public partial class ucMachine : UserControl
    {
        public ucMachine()
        {
            InitializeComponent();
        }
        

        //---------------- Form Variables --------------------
        private Unit_DL objUnitDL ;
        private MachineType_DL objMachineTypeDL ;
        private Machine_DL objMachineDL ;

        public void Initialize(SqlConnection Conn)
        {
            objUnitDL = new Unit_DL(Conn);
            objMachineTypeDL = new MachineType_DL(Conn);
            objMachineDL = new Machine_DL(Conn);
        }


        private bool MachineSeletc = false;
        private Machine objMachine = new Machine();
        private String OriginalMachineCode = "";


        public void Clear()
        {
            txtWastagePercentage.Text = "";
            txtBranch.Text = "";
            txtCapacity.Text = "0.00";
            txtMachienDescription.Text = "";
            txtMachineCode.Text = "";
            txtMachineCostPerHour.Text = "0.00";
            txtMachineName.Text = "";
            txtMachineTransferDetails.Text = "";
            txtMachineValue.Text = "0.00";
            txtPropertyTag.Text = "";
            txtWastagePercentage.Text = "0";
            cmbUnit.SelectedIndex = -1;
            this.MachineSeletc = false;
        }

        private void ucMachine_Load(object sender, EventArgs e)
        {
            
            
        }

        public void MachineLoad()
        {
            try
            {
                //cmbMachineSupply.DataSource = objSupplierDL.GetDataView(2, 6);
                cmbUnit.DataSource = objUnitDL.GetDataView();
                cmbMachineType.DataSource = objMachineTypeDL.GetDataView();
                gvMachine.DataSource = objMachineDL.GetDataView();
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {


            if (txtBranch.Text.Equals("") ||
                txtCapacity.Text.Equals("")||
                txtMachienDescription.Text.Equals("")||
                txtMachineCode.Text.Equals("")||
                txtMachineCostPerHour.Text.Equals("")||
                txtMachineName.Text.Equals("") || txtWastagePercentage.Text.Equals(""))
            {
                errorProvider1.SetError(txtMachineCode, "Required Field");
                errorProvider1.SetError(txtCapacity, "Required Field");
                errorProvider1.SetError(txtMachienDescription, "Required Field");
                errorProvider1.SetError(txtMachineCostPerHour, "Required Field");
                errorProvider1.SetError(txtMachineName, "Required Field");
                errorProvider1.SetError(txtWastagePercentage, "Required Field");
                errorProvider1.SetError(txtBranch, "Required Field");

                MessageBox.Show(this, "Please Fill all Fields", "Blank Fields", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                errorProvider1.Clear();

                try
                {
                    objMachine.MachineBranch = txtBranch.Text;
                    objMachine.MachineCapacity = Convert.ToDecimal(txtCapacity.Text);
                    objMachine.MachineCapacityUnit = objUnitDL.Get(Convert.ToInt64(cmbUnit.SelectedValue));
                    objMachine.MachineCode = txtMachineCode.Text;
                    objMachine.MachineDescription = txtMachienDescription.Text;
                    objMachine.MachineHourCost = Convert.ToDecimal("0.00");
                    objMachine.MachineName = txtMachineName.Text;
                    objMachine.MachinePropertyTag = txtPropertyTag.Text;
                    objMachine.MachinePurchaseDate = dtPurchaseDate.Value;
                    objMachine.MachineSupplier = "No";
                    objMachine.MachineTransferDetails = txtMachineTransferDetails.Text;
                    objMachine.MachineType = objMachineTypeDL.Get(Convert.ToInt64(cmbMachineType.SelectedValue));
                    objMachine.MachineValue = Convert.ToDecimal(txtMachineValue.Text);
                    objMachine.MachineWastage = Convert.ToDecimal(txtWastagePercentage.Text);
                    int x;

                    
                        x = objMachineDL.Add(objMachine);
                        gvMachine.DataSource = objMachineDL.GetDataView();

                        if (x > 0)
                        {
                            MessageBox.Show(this, "Succesfully Added to Database", "Succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            this.Clear();
                        }

                }
                catch (FormatException)
                {

                    MessageBox.Show(this, "Please enter valid data", "Input Data Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                catch (Exception ex)
                {

                    MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {


                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.MachineSeletc)
            {
                DialogResult dr = MessageBox.Show(this, "Are you sure, You want to Delete selected Record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {


                    try
                    {

                        int x = objMachineDL.Delete(OriginalMachineCode);
                        gvMachine.DataSource = objMachineDL.GetDataView();
                        

                       
                        if (x > 0)
                        {
                            MessageBox.Show(this, "Succesfully Deleted From Database", "Succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Clear();
                        }

                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                }
            }
            else
            {
                MessageBox.Show(this, "Select a Record from the List", "Select a Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            Clear();


        }

        private void txtCapacity_Validated(object sender, EventArgs e)
        {
            try
            {
                Convert.ToDecimal(txtCapacity.Text);
                errorProvider1.SetError(txtCapacity, "");
            }
            catch (Exception)
            {

                errorProvider1.SetError(txtCapacity, "Quantity should be a Numaric value");
            }
        }

        private void txtWastagePercentage_Validated(object sender, EventArgs e)
        {
            try
            {
                Convert.ToDecimal(txtWastagePercentage.Text);
                errorProvider1.SetError(txtWastagePercentage, "");
            }
            catch (Exception)
            {

                errorProvider1.SetError(txtWastagePercentage, "Quantity should be a Numaric value");
            }
        }

        private void txtMachineValue_Validated(object sender, EventArgs e)
        {
            try
            {
                Convert.ToDecimal(txtMachineValue.Text);
                errorProvider1.SetError(txtMachineValue, "");
            }
            catch (Exception)
            {

                errorProvider1.SetError(txtMachineValue, "Quantity should be a Numaric value");
            }
        }

        private void txtMachineCostPerHour_Validated(object sender, EventArgs e)
        {
            try
            {
                Convert.ToDecimal(txtMachineCostPerHour.Text);
                errorProvider1.SetError(txtMachineCostPerHour, "");
            }
            catch (Exception)
            {

                errorProvider1.SetError(txtMachineCostPerHour, "Quantity should be a Numaric value");
            }
        }

        private void gvMachine_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
               // MessageBox.Show(gvMachine.Rows[e.RowIndex].Cells["Col1MachineCapacityUnitID"].Value.ToString());
               
                objMachine.MachineBranch = gvMachine.Rows[e.RowIndex].Cells["ColMachineBranch"].Value.ToString();
                objMachine.MachineCapacity = Convert.ToDecimal(gvMachine.Rows[e.RowIndex].Cells["ColMachineCapacity"].Value);
                objMachine.MachineCapacityUnit = objUnitDL.Get(Convert.ToInt64(gvMachine.Rows[e.RowIndex].Cells["Col1MachineCapacityUnitID"].Value));
                objMachine.MachineCode = gvMachine.Rows[e.RowIndex].Cells["ColMachineCode"].Value.ToString();
                objMachine.MachineDescription = gvMachine.Rows[e.RowIndex].Cells["ColMachineDescription"].Value.ToString();
                objMachine.MachineHourCost = Convert.ToDecimal(gvMachine.Rows[e.RowIndex].Cells["ColMachineHourCost"].Value);
                objMachine.MachineName = gvMachine.Rows[e.RowIndex].Cells["ColMachineName"].Value.ToString();
                objMachine.MachinePropertyTag = gvMachine.Rows[e.RowIndex].Cells["ColMachinePropertyTag"].Value.ToString();
                objMachine.MachinePurchaseDate = Convert.ToDateTime(gvMachine.Rows[e.RowIndex].Cells["ColMachinePurchaseDate"].Value);
                objMachine.MachineSupplier = "No";
                objMachine.MachineTransferDetails = gvMachine.Rows[e.RowIndex].Cells["ColMachineTransferDetails"].Value.ToString();
                objMachine.MachineType = objMachineTypeDL.Get(Convert.ToInt64(gvMachine.Rows[e.RowIndex].Cells["ColMachineTypeID"].Value));
                objMachine.MachineValue = Convert.ToDecimal(gvMachine.Rows[e.RowIndex].Cells["ColMachineValue"].Value);
                objMachine.MachineWastage = Convert.ToDecimal(gvMachine.Rows[e.RowIndex].Cells["ColMachineWastage"].Value);
                
                txtBranch.Text = objMachine.MachineBranch;
                txtCapacity.Text = objMachine.MachineCapacity.ToString();
                txtMachienDescription.Text = objMachine.MachineDescription;
                txtMachineCode.Text = objMachine.MachineCode;
                txtMachineCostPerHour.Text = objMachine.MachineHourCost.ToString();
                txtMachineName.Text = objMachine.MachineName;
                txtMachineTransferDetails.Text = objMachine.MachineTransferDetails;
                txtMachineValue.Text = objMachine.MachineValue.ToString();
                txtPropertyTag.Text = objMachine.MachinePropertyTag;
                txtWastagePercentage.Text = objMachine.MachineWastage.ToString();

                cmbMachineType.SelectedValue = objMachine.MachineType.MachineTypeID;
                cmbUnit.SelectedValue = objMachine.MachineCapacityUnit.UnitID;

                OriginalMachineCode = objMachine.MachineCode;
                this.MachineSeletc = true;

            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void txtMachineCostPerHour_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar) || (e.KeyChar == (char)46)))
            {
                e.Handled = true;
            }
        }






    }
}
