using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DL;
using SESD.MRP.REF;

namespace MRP_GUI.RPD
{
    public partial class frmRPDCostApprove : System.Windows.Forms.Form
    {

        RPDBatch_DL objRPDBatch_DL = new RPDBatch_DL(ConnectionStringClass.GetConnection());
        RPDBatch objRPDBatch;
        private User _CurrentUser;

        public User CurrentUser
        {
            get { return _CurrentUser; }
            set { _CurrentUser = value; }
        }


	
        public frmRPDCostApprove(User objUser)
        {

            InitializeComponent();
            CurrentUser = objUser;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmRPDCostApprove_Load(object sender, EventArgs e)
        {
            Load_List();
        }

        private void Load_List()
        {
            try
            {
                gvRPDBatch.AutoGenerateColumns = false;
                bindRPD.DataSource = objRPDBatch_DL.GetDataViewByState(RPDBatch.RPDBatchStatus.Cost, true);
                gvRPDBatch.DataSource = bindRPD;
                bindRPD.ResetBindings(true);
            }
            catch (Exception ex)
            {

                MessageBox.Show(this, "Error occured while loading", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void gvRPDBatch_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gvRPDBatch.CurrentRow.Cells["DryerRate"].Value != null)
            {
                txtDryerRate.Text = gvRPDBatch.CurrentRow.Cells["DryerRate"].Value.ToString();
            }

            
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult theResult = new DialogResult();

                theResult = MessageBox.Show(this, "Do You want to Approve the Costing Report?", "Confirmation", MessageBoxButtons.YesNo);
               
                if (theResult == System.Windows.Forms.DialogResult.Yes)
                {

                    if (gvRPDBatch.CurrentRow.Cells["RPDBatchID"].Value != null)
                    {
                        txtDryerRate.Text = gvRPDBatch.CurrentRow.Cells["DryerRate"].Value.ToString();

                        Employee_DL objEmployee_DL = new Employee_DL(ConnectionStringClass.GetConnection());

                        objRPDBatch = objRPDBatch_DL.Get(gvRPDBatch.CurrentRow.Cells["RPDBatchID"].Value.ToString());

                        objRPDBatch.Status = RPDBatch.RPDBatchStatus.Finished;

                        objRPDBatch_DL.Update_Cost(objRPDBatch.RPDBatchID, CurrentUser.EmployeeID);

                        int x = objRPDBatch_DL.Update_ApproveCost(objRPDBatch);

                        if (x > 0)
                        {
                            MessageBox.Show(this, "Successfully Approved", "Successful", MessageBoxButtons.OK);

                        }
                        Load_List();
                    }
                }

            }
            catch (Exception)
            {

                MessageBox.Show(this, "Error occured while loading Batch details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void gvRPDBatch_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    objRPDBatch = objRPDBatch_DL.Get(gvRPDBatch.CurrentRow.Cells["RPDBatchID"].Value.ToString());
                    if (objRPDBatch != null)
                    {
                        frmRptRPDBatchCost objFrm = new frmRptRPDBatchCost(CurrentUser, objRPDBatch.RPDBatchID);
                        objFrm.ShowDialog(this);

                        Load_List();

                    }
                }
                catch (Exception)
                {

                    MessageBox.Show(this, "Error occured while loading Batch details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                objRPDBatch_DL.UpdateDryerDate(gvRPDBatch.CurrentRow.Cells["RPDBatchID"].Value.ToString(), Convert.ToDecimal(txtDryerRate.Text));

                Load_List();
            }
            catch (Exception)
            {

                MessageBox.Show(this, "Error occured while loading Batch details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}