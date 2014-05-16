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
    public partial class frmQC : System.Windows.Forms.Form
    {
        private User _curreUser;

        public User CurrentUser
        {
            get { return _curreUser; }
            set { _curreUser = value; }
        }
	
        private QCReport objQCReport = null;
        private QCReportDetails objQCReportDetails = null;
        private QCReport_DL objQCReport_DL = new QCReport_DL(ConnectionStringClass.GetConnection());
        private QCReportDetails_DL objQCReportDetails_DL = new QCReportDetails_DL(ConnectionStringClass.GetConnection());
        private Material_DL objMaterial_DL = new Material_DL(ConnectionStringClass.GetConnection());
        private Employee_DL objEmployee_DL = new Employee_DL(ConnectionStringClass.GetConnection());
        private TestParameter_DL objTestParameter_DL = new TestParameter_DL(ConnectionStringClass.GetConnection());
        private RPDBatch objRPDBatch = new RPDBatch();
        private RPDBatch_DL objRPDBatch_DL = new RPDBatch_DL(ConnectionStringClass.GetConnection());
        private PRPDBatch objPRPDBatch = new PRPDBatch();
        private PRPDBatch_DL objPRPDBatch_DL = new PRPDBatch_DL(ConnectionStringClass.GetConnection());
        private Batch_DL objBatch_DL = new Batch_DL(ConnectionStringClass.GetConnection());
        private Batch objBatch = new Batch();
        public frmQC()
        {
            InitializeComponent();
        }

        public frmQC(User objuser, QCReport QCReport)
        {
            objQCReport = QCReport;
            CurrentUser = objuser;
            InitializeComponent();
        }

        private void frmQC_Load(object sender, EventArgs e)
        {
            try
            {

                if (objQCReport != null)
                {                
                    cmbTestBy.DataSource = objEmployee_DL.Get_By_DepType("LAB", true);
                    cmbRDQAOfficer.DataSource = objEmployee_DL.Get_By_DepType("LAB", true);
                    cmbAnalizedBy.DataSource = objEmployee_DL.Get_By_DepType("LAB", true);
                    cmbParameter.DataSource = objTestParameter_DL.GetView(objQCReport.ReportType);
                    bindDetails.DataSource = objQCReportDetails_DL.GetView(objQCReport.QCReportID);

                    if (objQCReport.ReportType.Equals("RPD"))
                    {
                        txtBatch.Text = objQCReport.RPDBatchID;
                        objRPDBatch = objRPDBatch_DL.Get(objQCReport.RPDBatchID);
                        cmbMaterial.DataSource = objMaterial_DL.GetDataViewIntermediates(objRPDBatch.RPDBatchMaterial.MaterialCode);
                        //cmbMaterial.DataSource = objMaterial_DL.Get_RPD_DataView(objQCReport.RPDBatchID);
                        txtBatch.Text = objRPDBatch.RPDBatchID;
                    }
                    else if (objQCReport.ReportType.Equals("PRPD"))
                    {
                        txtBatch.Text = objQCReport.RPDBatchID;
                        objPRPDBatch = objPRPDBatch_DL.Get(objQCReport.PRPDBatchID);
                        cmbMaterial.DataSource = objMaterial_DL.GetDataViewIntermediates( objPRPDBatch.PRPDBatchMaterial.MaterialCode);
                        txtBatch.Text = objPRPDBatch.PRPDBatchID;
                    }

                    else if (objQCReport.ReportType.Equals("PRODUCTION"))
                    {
                        txtBatch.Text = objQCReport.ProductionBatchID;
                        objBatch = objBatch_DL.Get(objQCReport.ProductionBatchID);
                        //cmbMaterial.DataSource = objMaterial_DL.GetDataViewIntermediates("", "", objPRPDBatch.PRPDBatchMaterial.MaterialCode);
                        lblItem.Text = "Product";
                        BasicProductCollec objCollec = new BasicProductCollec();
                        objCollec.Add(objBatch.StandardBatch.STDBatchBasicProduct);


                        cmbMaterial.DataSource = objCollec;
                        cmbMaterial.DisplayMember = "Code";
                        cmbMaterial.ValueMember = "BasicProductCode";
                    
                    }
                    txtReportID.Text = objQCReport.QCReportID.ToString();
                    txtReportType.Text = objQCReport.ReportType;
                    txtSampleSize.Text = objQCReport.SampleSize;
                    txtSendBy.Text = objEmployee_DL.Get(objQCReport.SendBy).EmployeeNameID;
                    txtSendDate.Text = objQCReport.SendDate.Value.ToShortDateString();
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
                    txtRemarks.Text = objQCReport.Remarks;

                    if (objQCReport.Status != Convert.ToInt32(QCReport.ReportStatus.Initial))
                    {
                        grpDetails.Enabled = false;
                    }
  
                    
                }
            }
            catch (Exception)
            {

                MessageBox.Show(this,"Error occured while loading","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void cbFinalized_CheckedChanged(object sender, EventArgs e)
        {
            if (cbFinalized.Checked)
            {
                grpFinalized.Enabled = true;
            }
            else
            {
                grpFinalized.Enabled = false;
            }
        }

       
        private void btnSaveReport_Click(object sender, EventArgs e)
        {

            try
            {
                if (objQCReport != null)
                {
                    if((cmbAnalizedBy.SelectedValue==null)|(cmbRDQAOfficer.SelectedValue==null)|(cmbTestBy.SelectedValue==null))
                    {
                        MessageBox.Show(this, "Empty Records", "Empty", MessageBoxButtons.OK);
                    }
                    else
                    {
                    objQCReport.AnalyzedBy = cmbAnalizedBy.SelectedValue.ToString();
                    objQCReport.RDQAOfficer = cmbRDQAOfficer.SelectedValue.ToString();
                    objQCReport.Remarks = txtRemarks.Text;
                    objQCReport.TestBy = cmbTestBy.SelectedValue.ToString();
                    if (cbFinalized.Checked)
                    {
                        if (rbAccept.Checked)
                        {
                            objQCReport.Status = Convert.ToInt32(QCReport.ReportStatus.Accept);

                        }
                        else if (rbReject.Checked)
                        {
                             objQCReport.Status = Convert.ToInt32(QCReport.ReportStatus.Reject);

                        }
                    }

                    if (objQCReport.ReportType == "RPD")
                    {

                        long ID = objQCReport_DL.Update_RPD(objQCReport, objRPDBatch.RPDBatchID, (int)RPDBatch.RPDBatchStatus.Finished);
                        if (ID > 0)
                        {
                            grpDetails.Enabled = false;
                            this.Close();


                        }
                    }
                    else
                    {
                        long ID = objQCReport_DL.Update_PRPD(objQCReport, objPRPDBatch.PRPDBatchID, (int)PRPDBatch.PRPDBatchStatus.Finished);
                        if (ID > 0)
                        {
                            grpDetails.Enabled = false;
                            this.Close();
                        }
                    }


                   

                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show(this,"Error Occured while saving","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

        }

        private void btnSaveTest_Click(object sender, EventArgs e)
        {
            try
            {
                if (objQCReport != null)
                {
                    if (objQCReportDetails == null)
                    {
                        objQCReportDetails = new QCReportDetails();
                    }
                    objQCReportDetails.Acceptence = cbAccept.Checked;
                    objQCReportDetails.Comment = txtComment.Text;
                    if (cmbMaterial.SelectedValue != null)
                    {
                        objQCReportDetails.MaterialCode = cmbMaterial.SelectedValue.ToString();
                    }
                    else
                    {
                        objQCReportDetails.MaterialCode = "No";
                    }
                    objQCReportDetails.QCReportID = objQCReport.QCReportID;
                    objQCReportDetails.Result = txtResult.Text;
                    
                    objQCReportDetails.TestParameterID = Convert.ToInt64(cmbParameter.SelectedValue);

                    long ID = objQCReportDetails_DL.Add(objQCReportDetails);
                    if (ID > 0)
                    {
                        ClearDetails();
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show(this,"Error occured while saving details","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (objQCReportDetails != null)
                {
                    DialogResult dr = MessageBox.Show(this,"Are you sure you want to delete selected test detail?Click Yes to delete","Confirm Delete",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2);
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
                
                MessageBox.Show(this,"Error occured while deleting","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void ClearDetails()
        {
            cbAccept.Checked = true;
            txtComment.Text = "";
            cmbMaterial.SelectedIndex = 0;
            cmbParameter.SelectedIndex = 0;
            txtResult.Text = "";
            txtTestID.Text = "[Auto]";
            objQCReportDetails = null;
            btnDelete.Enabled = false;
            bindDetails.DataSource = objQCReportDetails_DL.GetView(objQCReport.QCReportID);

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
                            cmbMaterial.SelectedValue = objQCReportDetails.MaterialCode;
                            cmbParameter.SelectedValue = objQCReportDetails.TestParameterID;
                            txtResult.Text = objQCReportDetails.Result;
                            txtTestID.Text = objQCReportDetails.TestDetailsID.ToString();
                            btnDelete.Enabled = true;
                        }
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show(this,"Erro occured while selecting Test Details","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}