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


namespace MRP_GUI
{
    public partial class frmWIP : System.Windows.Forms.Form
    {

        User CurrentUser = new User();

        public frmWIP(User objUser)
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
        //Employee objEmployee = new Employee();

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

                dtWIP = objBatch_DL.GetWIP_Files(Convert.ToInt32(cmbSections.SelectedValue),(int)Batch.Status.Packing);

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
                objSourceSections.DataSource = objSection_DL.GetData_ByDepType("Production", "RPD", "PRPD", "AGRI");
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
              //  txtFinalQty.Text = dgvWIP.CurrentRow.Cells["FinalQty"].Value.ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if((dgvWIP.CurrentRow!=null)&&(txtFinalQty.Text!=""))
            {
            objBatch_DL.UpdateFinalQty(Convert.ToDecimal(txtFinalQty.Text), dgvWIP.CurrentRow.Cells["BatchID"].Value.ToString());

            Load_WIP();
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            objSection = objSection_DL.Get(Convert.ToInt64(cmbSections.SelectedValue));
            frmWIP_manufacturingReport frm = new frmWIP_manufacturingReport((int)Batch.Status.Packing, Convert.ToInt32(cmbSections.SelectedValue), cmbSections.Text, objSection.SectionHead.EmployeeName);
            frm.Show();
        }

    }
}
