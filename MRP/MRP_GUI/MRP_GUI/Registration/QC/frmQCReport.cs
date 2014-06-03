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

namespace MRP_GUI
{
    public partial class frmQCReport : System.Windows.Forms.Form
    {
        public frmQCReport(User objuser)
        {
            CurrentUser = objuser;
            InitializeComponent();
        }

        private User _curreUser;

        public User CurrentUser
        {
            get { return _curreUser; }
            set { _curreUser = value; }
        }

        private QCReport objQCReport = null;
        private QCReportDetails objQCReportDetails = new QCReportDetails();
        private QCReport_DL objQCReport_DL = new QCReport_DL(ConnectionStringClass.GetConnection());
        private QCReportDetails_DL objQCReportDetails_DL = new QCReportDetails_DL(ConnectionStringClass.GetConnection());
        private Employee_DL objEmployee_DL = new Employee_DL(ConnectionStringClass.GetConnection());
        private TestParameter_DL objTestParameter_DL = new TestParameter_DL(ConnectionStringClass.GetConnection());
        private Batch_DL objBatch_DL = new Batch_DL(ConnectionStringClass.GetConnection());
        private Batch objBatch = new Batch();


        private void Load_Batch_List()
        {

            try
            {
                DataTable dt = objBatch_DL.Get_DataView(Batch.Status.QC, CurrentUser.UserID);

               

            dgvBatchList.AutoGenerateColumns = false;
            objSourceBatchList.DataSource = dt;
            dgvBatchList.DataSource = objSourceBatchList;
            objSourceBatchList.ResetBindings(true);


            }
            catch (Exception)
            {

                MessageBox.Show(this, "Error occured while loading", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frmQCReport_Load(object sender, EventArgs e)
        {
            try
            {
                Load_Batch_List();
                
                cmbTestBy.DataSource = objEmployee_DL.Get_By_DepType("LAB", true);
                    cmbRDQAOfficer.DataSource = objEmployee_DL.Get_By_DepType("LAB", true);
                    cmbAnalizedBy.DataSource = objEmployee_DL.Get_By_DepType("LAB", true);
                    cmbParameter.DataSource = objTestParameter_DL.GetView("Production");
                 


                
            }
            catch (Exception)
            {

                MessageBox.Show(this, "Error occured while loading", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

     

        private void btnSaveReport_Click(object sender, EventArgs e)
        {
            try
            {
                if (objQCReport != null)
                {
                    objQCReport.AnalyzedBy = cmbAnalizedBy.SelectedValue.ToString();
                    objQCReport.RDQAOfficer = cmbRDQAOfficer.SelectedValue.ToString();
                    objQCReport.Remarks = txtRemarks.Text;
                    objQCReport.TestBy = cmbTestBy.SelectedValue.ToString();
                     if (rbAccept.Checked)
                        {
                            objQCReport.Status = Convert.ToInt32(QCReport.ReportStatus.Accept);

                         long x=   objQCReport_DL.Update_Production(objQCReport, Convert.ToInt32(Batch.Status.QCPass), objBatch.BatchID, CurrentUser.EmployeeID);

                         if (x > 0)
                         {
                             MessageBox.Show(this, "Successfully Passed the QC Report", "QC Pass", MessageBoxButtons.OK);
                         }

                        }
                        else if (rbReject.Checked)
                        {
                            objQCReport.Status = Convert.ToInt32(QCReport.ReportStatus.Reject);
                           long x= objQCReport_DL.Update_Production(objQCReport, Convert.ToInt32(Batch.Status.QCFail), objBatch.BatchID, CurrentUser.EmployeeID);

                           if (x > 0)
                           {
                               MessageBox.Show(this, "Successfully Failed the QC Report", "QCFail", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                           }
                        }


                     Load_Batch_List();

                     DataGridViewCellEventArgs er = new DataGridViewCellEventArgs(1, 0);

                     dgvBatchList_CellClick(sender,er);
                   

                }
            }
            catch (Exception)
            {

                MessageBox.Show(this, "Error Occured while saving", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSaveTest_Click(object sender, EventArgs e)
        {
            try
            {
                if (objQCReport != null)
                {
                    objQCReportDetails.Acceptence = cbAccept.Checked;
                    objQCReportDetails.Comment = txtComment.Text;
                    objQCReportDetails.QCReportID = objQCReport.QCReportID;
                    if (txtResult.Text == "")
                    {
                        objQCReportDetails.Result = "No";
                    }
                    else
                    {
                        objQCReportDetails.Result = txtResult.Text;
                    }
                    objQCReportDetails.MaterialCode = "N/A";

                    objQCReportDetails.TestParameterID = Convert.ToInt64(cmbParameter.SelectedValue);

                    long ID = objQCReportDetails_DL.Add(objQCReportDetails);
                    if (ID > 0)
                    {
                        ClearDetails();
                    }

                    Load_ParameterDetails();
                }
            }
            catch (Exception)
            {

                MessageBox.Show(this, "Error occured while saving details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (objQCReportDetails != null)
                {
                    DialogResult dr = MessageBox.Show(this, "Are you sure you want to delete selected test detail?Click Yes to delete", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                    if (dr == DialogResult.Yes)
                    {
                        int res = objQCReportDetails_DL.Delete(objQCReportDetails.TestDetailsID);

                        if (res > 0)
                        {
                            ClearDetails();
                        }
                    }

                }
            }
            catch (Exception)
            {

                MessageBox.Show(this, "Error occured while deleting", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void ClearDetails()
        {
            cbAccept.Checked = true;
            txtComment.Text = "";
            cmbParameter.SelectedIndex = 0;

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearDetails();
        }

        private void gvTest_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    long ID = Convert.ToInt64(gvTest.Rows[e.RowIndex].Cells["colTestDetailsID"].Value);
                    if (ID > 0)
                    {
                        objQCReportDetails = objQCReportDetails_DL.Get(ID);
                        if (objQCReportDetails != null)
                        {
                            cbAccept.Checked = objQCReportDetails.Acceptence;
                            txtComment.Text = objQCReportDetails.Comment;
                            cmbParameter.SelectedValue = objQCReportDetails.TestParameterID;
                        }
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show(this, "Erro occured while selecting Test Details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void dgvBatchList_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {


                if (dgvBatchList.Rows.Count > 0)
                {
                    objBatch = objBatch_DL.Get(dgvBatchList.CurrentRow.Cells["BatchID"].Value.ToString());
                    txtBatch.Text = objBatch.BatchID;

                    objQCReport = objQCReport_DL.Get_ProductionQCReport(objBatch.BatchID, Convert.ToInt32(QCReport.ReportStatus.Initial));



                    txtReportID.Text = objQCReport.QCReportID.ToString();
                    txtSendBy.Text = objEmployee_DL.Get(objQCReport.SendBy).EmployeeName;
                    txtSendDate.Text = objQCReport.SendDate.Value.ToShortDateString();
                    txtRemarks.Text = objQCReport.Remarks;

                    if (objQCReport.RDQAOfficer != null)
                    {
                        cmbRDQAOfficer.SelectedValue = objQCReport.RDQAOfficer;
                    }

                    if (objQCReport.AnalyzedBy != null)
                    {
                        cmbAnalizedBy.SelectedValue = objQCReport.AnalyzedBy;
                    }

                    if (objQCReport.TestBy != null)
                    {
                        cmbTestBy.SelectedValue = objQCReport.TestBy;
                    }

                    Load_ParameterDetails();

                }
                else
                {
                    DataTable dt = null;

                    gvTest.AutoGenerateColumns = false;
                    bindDetails.DataSource = dt;
                    gvTest.DataSource = bindDetails;
                    bindDetails.ResetBindings(true);
                }



            }
            catch (Exception)
            {

                MessageBox.Show(this, "Erro occured while selecting Test Details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void Load_ParameterDetails()
        {
            try
            {
                DataTable dt = objQCReportDetails_DL.GetView(objQCReport.QCReportID);

                gvTest.AutoGenerateColumns = false;
                bindDetails.DataSource = dt;
                gvTest.DataSource = bindDetails;
                bindDetails.ResetBindings(true);

            }
            catch (Exception)
            {

                MessageBox.Show(this, "Error Occured while saving", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            frmQCReportHistory objFrm = new frmQCReportHistory("Production");
            objFrm.Show();
        }

       
    }
}
