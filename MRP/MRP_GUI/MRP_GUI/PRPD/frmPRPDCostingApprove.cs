using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SESD.MRP.REF;
using DL;

namespace MRP_GUI.PRPD
{
    public partial class frmPRPDCostingApprove : System.Windows.Forms.Form
    {

        public frmPRPDCostingApprove(User objUser)
        {
            CurrentUser = objUser;
            InitializeComponent();
        }
        private User _CurrentUser;

        public User CurrentUser
        {
            get { return _CurrentUser; }
            set { _CurrentUser = value; }
        }
        private PRPDBatch_DL objPRPDBatch_DL = new PRPDBatch_DL(ConnectionStringClass.GetConnection());
  

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPRPDCostingApprove_Load(object sender, EventArgs e)
        {
            Load_Batch_List();
        }

        private void Load_Batch_List()
        {
            try
            {
                dgvPRPDbatchByState.AutoGenerateColumns = false;
                bindPRPD.DataSource = objPRPDBatch_DL.GetDataView(PRPDBatch.PRPDBatchStatus.Finished);
                dgvPRPDbatchByState.DataSource = bindPRPD;
                bindPRPD.ResetBindings(true);

            }
            catch (Exception)
            {

                MessageBox.Show(this, "Error occured while loading Batch List", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvPRPDbatchByState_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    PRPDBatch obj = objPRPDBatch_DL.Get(dgvPRPDbatchByState.Rows[e.RowIndex].Cells["PRPDBatchID"].Value.ToString());

                    frmRptPRPDBatchCost objFrm = new  frmRptPRPDBatchCost(CurrentUser,obj.PRPDBatchID);
                    objFrm.ShowDialog(this);

                    Load_Batch_List();

                }
                catch (Exception)
                {

                    MessageBox.Show(this, "Error occurred while loading PRPD Batch details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult theResult = new System.Windows.Forms.DialogResult();
                theResult = MessageBox.Show(this, "Do you want to Approve this Costing File?", "Confirmation", MessageBoxButtons.YesNo);

                if (theResult == System.Windows.Forms.DialogResult.Yes)
                {
                    PRPDBatch objPRPDBatch = new PRPDBatch();
                    if (dgvPRPDbatchByState.CurrentRow.Cells["PRPDBatchID"].Value != null)
                    {
                        objPRPDBatch = objPRPDBatch_DL.Get(dgvPRPDbatchByState.CurrentRow.Cells["PRPDBatchID"].Value.ToString());

                        objPRPDBatch_DL.Update_BatchCost(objPRPDBatch.PRPDBatchID, CurrentUser.EmployeeID, (int)objPRPDBatch.Type);

                        objPRPDBatch.Status = PRPDBatch.PRPDBatchStatus.Cost;

                        objPRPDBatch_DL.UpdateStatus(objPRPDBatch);

                        Load_Batch_List();
                    }
                }



            }
            catch (Exception)
            {

                MessageBox.Show(this, "Error occurred while loading PRPD Batch details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvPRPDbatchByState_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPRPDbatchByState.CurrentRow.Cells["DryerRate"].Value != null)
            {
                txtDryerRate.Text = dgvPRPDbatchByState.CurrentRow.Cells["DryerRate"].Value.ToString();
            }
        }

        private void btnUpdateDryerRate_Click(object sender, EventArgs e)
        {
            try
            {
                objPRPDBatch_DL.UpdateDryerDate(dgvPRPDbatchByState.CurrentRow.Cells["PRPDBatchID"].Value.ToString(), Convert.ToDecimal(txtDryerRate.Text));

                Load_Batch_List();
            }
            catch (Exception)
            {

                MessageBox.Show(this, "Error occured while loading Batch details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}