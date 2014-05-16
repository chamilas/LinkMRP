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
    public partial class frmRPDBatchList : System.Windows.Forms.Form
    {
        private User _CurrentUser;

        public User CurrentUser
        {
            get { return _CurrentUser; }
            set { _CurrentUser = value; }
        }
        private RPDBatch_DL objRPDBatchDL = new RPDBatch_DL(ConnectionStringClass.GetConnection());
        private RPDBatch.RPDBatchStatus Status;
        private RPDBatch objRPDBatch = null;
        public frmRPDBatchList(User objUser)
        {
            CurrentUser = objUser;
            InitializeComponent();
        }

        private void frmRPDBatchList_Load(object sender, EventArgs e)
        {
            try
            {
                cmbStatus.DataSource = Enum.GetValues(typeof(RPDBatch.RPDBatchStatus));
            }
            catch (Exception)
            {

                MessageBox.Show(this,"Error occured while loading","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void Load_List()
        {
            try
            {
                bindRPDBatch.DataSource = null;
                Status = (RPDBatch.RPDBatchStatus)cmbStatus.SelectedValue;
               
                gvRPDBatch.AutoGenerateColumns = false;
                bindRPDBatch.DataSource = objRPDBatchDL.GetDataViewByState(Status, true);
                gvRPDBatch.DataSource = bindRPDBatch;
                bindRPDBatch.ResetBindings(true);

            }
            catch (Exception)
            {

                MessageBox.Show(this, "Error occured while loading RPD Batch", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            Load_List();
        }

        private void gvRPDBatch_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    String ID = gvRPDBatch.CurrentRow.Cells["RPDBatchID"].Value.ToString();

                    objRPDBatch = objRPDBatchDL.Get(ID);

                    if (objRPDBatch != null)
                    {
                        RPD.frmRPDBatchFileView objFrm = new frmRPDBatchFileView(CurrentUser, objRPDBatch);
                        objFrm.ShowDialog(this);

                    }
                    else
                    {
                        //btnEdit.Enabled = false;
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show(this,"Error occured while loading Batch File","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}