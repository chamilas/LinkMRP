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
    public partial class frmPRPDQCReport : System.Windows.Forms.Form
    {
        public frmPRPDQCReport()
        {
            InitializeComponent();
        }
        private PRPDBatch objPRPDBatch;
        private PRPDBatch_DL objPRPDBatchDL = new PRPDBatch_DL(ConnectionStringClass.GetConnection());
        private QCReport_DL objQCReportDL = new QCReport_DL(ConnectionStringClass.GetConnection());
        private QCReportDetails_DL objQCReportDetailsDL = new QCReportDetails_DL(ConnectionStringClass.GetConnection());
 
        public frmPRPDQCReport(PRPDBatch obj)
        {
            InitializeComponent();
            objPRPDBatch = obj;
        }

        private void frmPRPDQCReport_Load(object sender, EventArgs e)
        {
            try
            {
                txtPRPDBatchID.Text = objPRPDBatch.PRPDBatchID;
                txtMaterial.Text = objPRPDBatch.PRPDBatchMaterial.MaterialNameCode;
                txtQuantity.Text = objPRPDBatch.PRPDBatchFinalQty.ToString();
                txtInstructedBy.Text = objPRPDBatch.PRPDBatchInstructedBy.EmployeeNameID;
                txtHandOverBy.Text = objPRPDBatch.PRPDBatchHandOverBy.EmployeeNameID;
                txtApprovedBy.Text = objPRPDBatch.PRPDBatchApprovedBy.EmployeeNameID;
                txtInspectedBy.Text = objPRPDBatch.PRPDBatchInspectedBy.EmployeeNameID;
                txtComment.Text = objPRPDBatch.PRPDBatchComments;
                txtTotalImpurities.Text = objPRPDBatch.PRPDBatchTotalImpurities.ToString();
                txtSupervisedBy.Text = objPRPDBatch.PRPDBatchSuperviser.EmployeeNameID;

                QCReport objQCReport = objQCReportDL.Get_PRPD_Quality_Passed(objPRPDBatch.PRPDBatchID);
                if (objQCReport != null)
                {
                    txtReportID.Text = objQCReport.QCReportID.ToString();
                    txtAnalyzedBy.Text = objQCReport.AnalyzedBy;
                    txtRDQAOffice.Text = objQCReport.RDQAOfficer;
                    txtSendBy.Text = objQCReport.SendBy;
                    txtTestBy.Text = objQCReport.TestBy;
                    txtSampleSize.Text = objQCReport.SampleSize;
                    txtRemarks.Text = objQCReport.Remarks;

                    gvTestParameters.DataSource = objQCReportDetailsDL.GetView(objQCReport.QCReportID);
                }

                
            }
            catch (Exception)
            {

                MessageBox.Show(this,"Error occured while loading","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}