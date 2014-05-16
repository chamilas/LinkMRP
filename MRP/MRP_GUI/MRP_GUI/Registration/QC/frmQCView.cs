using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SESD.MRP.REF;
using DL;

namespace MRP_GUI
{
    public partial class frmQCView : System.Windows.Forms.Form
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
        public frmQCView()
        {
            InitializeComponent();
        }

        public frmQCView(User objUser)
        {
            CurrentUser = objUser;
            InitializeComponent();
        }



        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmQCView_Load(object sender, EventArgs e)
        {
            cmbType.SelectedIndex = 0;
        }

        private void gvReports_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {

                    objQCReport = objQCReport_DL.Get(Convert.ToInt64(gvReports.Rows[e.RowIndex].Cells["colID"].Value));
                    if (objQCReport != null)
                    {
                        Clear();
                        if (objQCReport.ReportType.Equals("RPD"))
                        {
                            txtBatch.Text = objQCReport.RPDBatchID;
                        }
                        else if (objQCReport.ReportType.Equals("PRPD"))
                        {
                            txtBatch.Text = objQCReport.RPDBatchID;
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
                           txtAnalizedBy.Text = objEmployee_DL.Get(objQCReport.AnalyzedBy).EmployeeNameID;
                        }

                        if (objQCReport.TestBy != null)
                        {
                            txtTestBy.Text =objEmployee_DL.Get(objQCReport.TestBy).EmployeeNameID;
                        }
                        txtRemarks.Text = objQCReport.Remarks;

                        if (rbInitial.Checked == true)
                        {
                            btnMore.Enabled = true;
                        }
                        else
                        {
                            btnMore.Enabled = false;
                        }

                    }
                }
                catch (Exception)
                {

                    MessageBox.Show(this, "Error occured while loading", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void Clear()
        {
                txtBatch.Text = "";

                txtReportID.Text = "";
                txtReportType.Text = "";
                txtSampleSize.Text = "";
                txtSendBy.Text = "";
                txtSendDate.Text = "";
                txtRDQAOfficer.Text = "";
                txtAnalizedBy.Text = "";
                txtTestBy.Text = "";

                txtRemarks.Text = "";


            btnMore.Enabled = false;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                LoadReports();

                if (rbInitial.Checked == true)
                {
                    btnMore.Enabled = true;
                }

            }
            catch (Exception)
            {

                MessageBox.Show(this, "Error occured while loading", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                LoadReports();

                if (rcAccept.Checked == true)
                {
                    btnMore.Enabled = false;
                }
            }
            catch (Exception)
            {

                MessageBox.Show(this,"Error occured while loading","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void LoadReports()
        {
            QCReport.ReportStatus state = QCReport.ReportStatus.Initial;
            if (rbInitial.Checked)
            {
                state = QCReport.ReportStatus.Initial;
            }
            else if (rbReject.Checked)
            {
                state = QCReport.ReportStatus.Reject;
                btnMore.Enabled = false;
            }
            else if (rcAccept.Checked)
            {
                state = QCReport.ReportStatus.Accept;
                btnMore.Enabled = false;
            }
            bindReports.DataSource = objQCReport_DL.GetView(cmbType.SelectedItem.ToString(), (int)state);
            if (cmbType.SelectedItem.Equals("RPD"))
            {
                colRPD.Visible = true;
                colPRPD.Visible = false;
                colProduction.Visible = false;
            }
            else if (cmbType.SelectedItem.Equals("PRPD"))
            {
                colPRPD.Visible = true;
                colRPD.Visible = false;
                colProduction.Visible = false;
            }
            else
            {
                //colProduction.Visible = true;
                //colPRPD.Visible = false;
                //colRPD.Visible = false;
            }
        }

        private void btnMore_Click(object sender, EventArgs e)
        {
            try
            {
                frmQC objfrm = new frmQC(CurrentUser,objQCReport);
                objfrm.ShowDialog(this);
                LoadReports();

            }
            catch (Exception)
            {

                MessageBox.Show(this,"Error occured while loading details window","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void rbReject_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                LoadReports();

                if (rbReject.Checked == true)
                {
                    btnMore.Enabled = true;
                }

            }
            catch (Exception)
            {

                MessageBox.Show(this, "Error occured while loading", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                LoadReports();
            }
            catch (Exception)
            {

                MessageBox.Show(this, "Error occured while loading", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            try
            {
                frmQCDetailView objfrm = new frmQCDetailView(CurrentUser, objQCReport);
                objfrm.ShowDialog(this);


            }
            catch (Exception)
            {

                MessageBox.Show(this, "Error occured while loading details window", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}