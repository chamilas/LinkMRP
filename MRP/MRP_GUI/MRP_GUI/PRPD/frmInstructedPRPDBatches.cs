using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DL;
using SESD.MRP.REF;

namespace MRP_GUI.PRPD
{
    public partial class frmInstructedPRPDBatches : System.Windows.Forms.Form
    {
        private User _CurrentUser;

        public User CurrentUser
        {
            get { return _CurrentUser; }
            set { _CurrentUser = value; }
        }
        PRPDBatch_DL objPRPDBatch_DL = new PRPDBatch_DL(ConnectionStringClass.GetConnection());
	
        public frmInstructedPRPDBatches(User objUser)
        {
            CurrentUser = objUser;
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmInstructedPRPDBatches_Load(object sender, EventArgs e)
        {
            try
            {
                cmbStatus.DataSource = Enum.GetNames(typeof(PRPDBatch.PRPDBatchStatus));
                dtFrom.Value = DateTime.Now.AddMonths(-1);
            }
            catch (Exception)
            {

                MessageBox.Show(this,"Error occured while loading","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadList();
        }

        private void LoadList()
        {
            try
            {
                bindPRPD.DataSource = objPRPDBatch_DL.GetDataView(CurrentUser.EmployeeID, (PRPDBatch.PRPDBatchStatus)Enum.Parse(typeof(PRPDBatch.PRPDBatchStatus), cmbStatus.SelectedItem.ToString()),dtFrom.Value,dtTo.Value);
            }
            catch (Exception)
            {

                MessageBox.Show(this, "Error occured while loading Batch List", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvPRPDbatchByState_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex>=0)
            {
                try
                {
                    PRPDBatch obj = objPRPDBatch_DL.Get(dgvPRPDbatchByState.Rows[e.RowIndex].Cells["colPRPDBatchID"].Value.ToString());

                    PRPD.frmViewPRPDBatch objFrm = new frmViewPRPDBatch(CurrentUser, obj);
                    objFrm.ShowDialog(this);
                }
                catch (Exception)
                {

                    MessageBox.Show(this,"Error occurred while loading PRPD Batch details","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
        }

        private void dtTo_ValueChanged(object sender, EventArgs e)
        {
            LoadList();
        }

        private void dtFrom_ValueChanged(object sender, EventArgs e)
        {
            LoadList();
        }
    }
}