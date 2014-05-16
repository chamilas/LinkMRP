using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DL;
using SESD.MRP.REF;

namespace MRP_GUI
{
    public partial class frmMTNReceive_Rejects : System.Windows.Forms.Form
    {
        public frmMTNReceive_Rejects()
        {
            InitializeComponent();
        }


        public frmMTNReceive_Rejects(User objUser)
        {
            InitializeComponent();
            CurrentUser = objUser;
        }

        //-------------------------- Variables and Properties -------------------------
        private User _objCurrentUser;

        public User CurrentUser
        {
            get { return _objCurrentUser; }
            set { _objCurrentUser = value; }
        }

        private Department_DL objDepDL = new Department_DL(ConnectionStringClass.GetConnection());
        private MTN objMTN = new MTN();
        private MTN_DL objMTNDL = new MTN_DL(ConnectionStringClass.GetConnection());
        private MTNCollec objMTNCollec = new MTNCollec();

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void frmMTNReceive_Load(object sender, EventArgs e)
        {
            try
            {
                gvMTNList.AutoGenerateColumns = false;

                DataTable dtMTNList = objMTNDL.GetDataView(CurrentUser.UserID, MTN.Status.Approved,MTN.Type.Reject);
                bindMTNList.DataSource = dtMTNList;
                gvMTNList.DataSource = bindMTNList;
                bindMTNList.ResetBindings(true);

            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void gvMTNList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if(gvMTNList.Rows.Count>0)
                {
                long MTNNO = Convert.ToInt64(gvMTNList.Rows[e.RowIndex].Cells[0].Value);
                objMTN = objMTNDL.Get(MTNNO);
                bindItemList.DataSource = objMTNDL.GetDataView(MTNNO);
                }
                else
                {
                    bindItemList.DataSource = null;
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReceive_Click(object sender, EventArgs e)
        {
            try
            {


            objMTNDL.Receive(MTN.Status.Received, objMTN.MTNNo, CurrentUser.EmployeeID);

            gvMTNList.AutoGenerateColumns = false;

            DataTable dtMTNList = objMTNDL.GetDataView(CurrentUser.UserID, MTN.Status.Approved,MTN.Type.Reject);
            bindMTNList.DataSource = dtMTNList;
            gvMTNList.DataSource = bindMTNList;
            bindMTNList.ResetBindings(true);

            DataGridViewCellEventArgs dr = new DataGridViewCellEventArgs(1, 0);

            gvMTNList_CellClick(sender, dr);

            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}