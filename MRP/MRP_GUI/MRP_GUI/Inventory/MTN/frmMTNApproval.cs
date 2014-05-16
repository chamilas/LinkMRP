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
    public partial class frmMTNApproval : System.Windows.Forms.Form
    {
        public frmMTNApproval()
        {
            InitializeComponent();
        }

        public frmMTNApproval(User objUser)
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

        private Department_DL objDep = new Department_DL(ConnectionStringClass.GetConnection());
        private MTN objMTN = new MTN();
        private MTN_DL objMTNDL = new MTN_DL(ConnectionStringClass.GetConnection());
        private MTNCollec objMTNCollec = new MTNCollec();


//------------------- Events -----------------------------------
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       


        private void gvMTNList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                long MTNNO = Convert.ToInt64(gvMTNList.CurrentRow.Cells["MTNNO"].Value);
                objMTN = objMTNDL.Get(MTNNO);

                DataTable dtItemList = objMTNDL.GetDataView(MTNNO);

                gvItemList.AutoGenerateColumns=false;

                bindItemList.DataSource = dtItemList;
                gvItemList.DataSource = bindItemList;
                bindItemList.ResetBindings(true);

            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            MTNMaterial_DL objMTNMatDL = new MTNMaterial_DL(ConnectionStringClass.GetConnection());
            MTNBasicProduct_DL objMTNBasicDL = new MTNBasicProduct_DL(ConnectionStringClass.GetConnection());
            MTNFinishProduct_DL objMTNFinishDL = new MTNFinishProduct_DL(ConnectionStringClass.GetConnection());
            try
            {
                DialogResult dr = MessageBox.Show(this,"Do you want to Approve Selected MTN? Click Yes to Approve","Approve MTN?",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    objMTN.MTNStatus = MTN.Status.Approved;
                    objMTN.MTNApprovedBy = CurrentUser.UserEmp;
                   
                        objMTNDL.Update(objMTN);

                    Load_MTN();

                    DataGridViewCellEventArgs er = new DataGridViewCellEventArgs(1, 0);

                    gvMTNList_CellClick(sender, er);

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show(this, "Do you want to Reject Selected MTN? Click Yes to Reject", "Reject MTN?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    objMTN.MTNStatus = MTN.Status.Reject;
                    objMTN.MTNApprovedBy = CurrentUser.UserEmp;
                    objMTN.MTNApprovedDate = DateTime.Now;
                    objMTNDL.Update(objMTN);

                   
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmMTNApproval_Load(object sender, EventArgs e)
        {
            try
            {


                Load_MTN();

            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Load_MTN()
        {

            try

            {
            DataTable dtMTNList = objMTNDL.GetDataView(CurrentUser.UserID, MTN.Status.Initial);

            gvMTNList.AutoGenerateColumns = false;
            bindMTNList.DataSource = dtMTNList;
            gvMTNList.DataSource = bindMTNList;
            bindMTNList.ResetBindings(true);

            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnViewBatch_Click(object sender, EventArgs e)
        {
            try
            {
                string BatchID="";
                if (objMTN.MTNType== MTN.Type.Batch)
                {
                    BatchID = gvMTNList.CurrentRow.Cells["BatchID"].Value.ToString();
                }
                else if (objMTN.MTNType == MTN.Type.Packing)
                {
                    BatchID = gvMTNList.CurrentRow.Cells["BatchNo_Packing"].Value.ToString();
                }
                else
                {
                    BatchID = "N/A";
                }

                if (BatchID != "N/A")
                {
                    frmBatchRegistry_View objForm = new frmBatchRegistry_View(CurrentUser, BatchID);
                    objForm.ShowDialog(this);
                }
                else
                {
                    MessageBox.Show(this, "This is not a Batch MTN", "Incorrect Attempt", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}