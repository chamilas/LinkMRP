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
    public partial class frmQCDetailView : System.Windows.Forms.Form
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
        public frmQCDetailView()
        {
            InitializeComponent();
        }

        public frmQCDetailView(User objUser, QCReport QCReport)
        {
            CurrentUser = objUser;
            objQCReport = QCReport;
            InitializeComponent();
        }

        private void frmQCDetailView_Load(object sender, EventArgs e)
        {
            try
            {
             if (objQCReport != null)
                {                

                    if (objQCReport.ReportType.Equals("RPD"))
                    {
                        txtBatch.Text = objQCReport.RPDBatchID;
                        //cmbMaterial.DataSource = objMaterial_DL.Get_RPD_DataView(objQCReport.RPDBatchID);
                    }
                    else if (objQCReport.ReportType.Equals("PRPD"))
                    {
                        txtBatch.Text = objQCReport.PRPDBatchID;
                        //cmbMaterial.DataSource = objMaterial_DL.Get_RPD_DataView(objQCReport.PRPDBatchID);
                    }
                    txtReportID.Text = objQCReport.QCReportID.ToString();
                    txtReportType.Text = objQCReport.ReportType;
                    txtSampleSize.Text = objQCReport.SampleSize;
                    txtSendBy.Text = objEmployee_DL.Get(objQCReport.SendBy).EmployeeNameID;
                    txtSendDate.Text = objQCReport.SendDate.Value.ToShortDateString();
                    if (objQCReport.RDQAOfficer != null)
                    {
                        txtRDQAOfficer.Text = objEmployee_DL.Get(objQCReport.RDQAOfficer).EmployeeNameID;
                    }

                    if (objQCReport.AnalyzedBy != null)
                    {
                        txtAnalyzedBy.Text = objEmployee_DL.Get(objQCReport.AnalyzedBy).EmployeeNameID;
                    }

                    if (objQCReport.TestBy != null)
                    {
                        txtTestBy.Text = objEmployee_DL.Get(objQCReport.TestBy).EmployeeNameID;
                    }
                    txtRemarks.Text = objQCReport.Remarks;
                    bindDetails.DataSource = objQCReportDetails_DL.GetView(objQCReport.QCReportID);
                    if (objQCReport.Status == Convert.ToInt32(QCReport.ReportStatus.Accept))
                    {
                        lblStatus.Text = "Accepted";
                    }else if (objQCReport.Status == Convert.ToInt32(QCReport.ReportStatus.Reject))
                    {
                        lblStatus.Text = "Rejected";
                    }
                    else
                    {
                        lblStatus.Text = "Initial";
                    }
  
                    
                }
            }
            catch (Exception)
            {

                MessageBox.Show(this,"Error occured while loading","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);


            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gvTest_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}