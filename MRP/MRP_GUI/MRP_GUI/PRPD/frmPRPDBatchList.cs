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
    public partial class frmPRPDBatchList : System.Windows.Forms.Form
    {
        public frmPRPDBatchList(User objUser)
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
        private void frmPRPDBatchList_Load(object sender, EventArgs e)
        {
            try
            {
                cmbStatus.DataSource = Enum.GetNames(typeof(PRPDBatch.PRPDBatchStatus));
                
            }
            catch (Exception)
            {

                MessageBox.Show(this, "Error occured while loading", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadList()
        {
            try
            {
                dgvPRPDbatchByState.AutoGenerateColumns = false;
                bindPRPD.DataSource=objPRPDBatch_DL.GetDataView((PRPDBatch.PRPDBatchStatus)Enum.Parse(typeof(PRPDBatch.PRPDBatchStatus),cmbStatus.SelectedValue.ToString()));
                dgvPRPDbatchByState.DataSource = bindPRPD;
                bindPRPD.ResetBindings(true);
            }
            catch (Exception)
            {

                MessageBox.Show(this, "Error occured while loading Batch List", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadList();
        }

        private void dgvPRPDbatchByState_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    PRPDBatch obj = objPRPDBatch_DL.Get(dgvPRPDbatchByState.CurrentRow.Cells["PRPDBatchID"].Value.ToString());

                    PRPD.frmViewPRPDBatch objFrm = new frmViewPRPDBatch(CurrentUser, obj);
                    objFrm.ShowDialog(this);
                }
                catch (Exception)
                {

                    MessageBox.Show(this, "Error occurred while loading PRPD Batch details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}