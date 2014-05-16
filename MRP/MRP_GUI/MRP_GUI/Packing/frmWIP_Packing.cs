using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DL;
using SESD.MRP.REF;
using MRP_GUI.Production;
using MRP_GUI.Report;
using MRP_GUI.Sales;


namespace MRP_GUI
{
    public partial class frmWIP_Packing : System.Windows.Forms.Form
    {

        User CurrentUser = new User();

        public frmWIP_Packing(User objUser)
        {
            InitializeComponent();
            CurrentUser = objUser;
        }

        Batch_DL objBatch_DL = new Batch_DL(ConnectionStringClass.GetConnection());
        MainActivity_DL objMainActivity_DL = new MainActivity_DL(ConnectionStringClass.GetConnection());
        BatchActivity_DL objBatchActivity_DL = new BatchActivity_DL(ConnectionStringClass.GetConnection());
        MachineActivity_DL objMachineActivity_DL = new MachineActivity_DL(ConnectionStringClass.GetConnection());
        BatchLabourDetails_DL objBatchLabourDetails_DL = new BatchLabourDetails_DL(ConnectionStringClass.GetConnection());
        BatchMachineDetails_DL objBatchMachineDetails_DL = new BatchMachineDetails_DL(ConnectionStringClass.GetConnection());
        Machine_DL objMachine_DL = new Machine_DL(ConnectionStringClass.GetConnection());
        Employee_DL objEmployee_DL = new Employee_DL(ConnectionStringClass.GetConnection());
        Section_DL objSection_DL = new Section_DL(ConnectionStringClass.GetConnection());
        Sections objSection = new Sections();

        DataTable dtWIP = new DataTable();
        DataTable dtWIPStock = new DataTable();


        private void frmBatchList_Load(object sender, EventArgs e)
        {

            Load_Sections();
        }

        private void Load_WIP()
        {
            try
            {

                dtWIP = objBatch_DL.GetWIP_Files_Packing(Convert.ToInt32(cmbSections.SelectedValue),(int)Batch.Status.Packing);

                dgvWIP.AutoGenerateColumns = false;
                objSourceWIP.DataSource = dtWIP;
                dgvWIP.DataSource = objSourceWIP;
                objSourceWIP.ResetBindings(true);
                
            }
            catch (Exception)
            {

                MessageBox.Show(this, "Error occured while loading Batch List", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }


        private void Load_WIP_Stock()
        {
            try
            {

                BatchPackingMR_DL objBatchPackingMR_DL = new BatchPackingMR_DL(ConnectionStringClass.GetConnection());

               dtWIPStock= objBatchPackingMR_DL.GetData_WIP(Convert.ToInt32(cmbSections.SelectedValue));

               dgvWIPStock.AutoGenerateColumns = false;
               objSourceWIPStock.DataSource = dtWIPStock;
               dgvWIPStock.DataSource = objSourceWIPStock;
               objSourceWIPStock.ResetBindings(true);
               
            }
            catch (Exception)
            {

                MessageBox.Show(this, "Error occured while loading Activity List", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



        }


       

        private void Load_Sections()
        {
            Section_DL objSection_DL = new Section_DL(ConnectionStringClass.GetConnection());

            try
            {
                objSourceSections.DataSource = objSection_DL.GetData_ByDepType("Packing", "Packing", "Packing", "Packing");
                cmbSections.DataSource = objSourceSections;
            }
            catch (Exception)
            {

                MessageBox.Show(this, "Error occured while loading Section", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void dgvWIP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbSections_SelectedIndexChanged(object sender, EventArgs e)
        {
            Load_WIP();
            Load_WIP_Stock();
        }

        private void dgvWIP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvWIP.CurrentRow != null)
            {
                txtFinalQty.Text = dgvWIP.CurrentRow.Cells["OutputQty"].Value.ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if ((dgvWIP.CurrentRow != null) && DataValidation.IsNumericNumber(txtFinalQty.Text))
            {
                objBatchActivity_DL.Update_FinalQty_WIP(Convert.ToDecimal(txtFinalQty.Text), Convert.ToInt32(dgvWIP.CurrentRow.Cells["PackingBatchID"].Value));

            Load_WIP();
            }
        }

        private void dgvWIP_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int i = 0; i <dgvWIP.Rows.Count; i++)
            {
                if (Convert.ToString(dgvWIP.Rows[i].Cells["ActType"].Value) == "Packing")
                {
                    dgvWIP.Rows[i].DefaultCellStyle.BackColor = Color.Gray;

                }
                else
                {
                    dgvWIP.Rows[i].DefaultCellStyle.BackColor = Color.Goldenrod;
                }
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {

        }

        private void btnprintBatch_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(""+Convert.ToInt32(cmbSections.SelectedValue));
        }

        private void btnPrintMaterial_Click(object sender, EventArgs e)
        {
            objSection = objSection_DL.Get(Convert.ToInt64(cmbSections.SelectedValue));
            frmWIP_Packing_MaterialTablePrint frm = new frmWIP_Packing_MaterialTablePrint(Convert.ToInt32(cmbSections.SelectedValue),objSection.SectionHead.EmployeeName,cmbSections.Text);
            frm.Show();
        }

    }
}
