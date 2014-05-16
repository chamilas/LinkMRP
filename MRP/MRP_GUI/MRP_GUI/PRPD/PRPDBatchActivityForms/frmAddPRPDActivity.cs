using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DL;
using SESD.MRP.REF;

namespace MRP_GUI.PRPD.PRPDBatchActivityForms
{
    public partial class frmAddPRPDActivity : System.Windows.Forms.Form
    {
        private PRPDBatchActivity_DL objPRPDBatchActivityDL = new PRPDBatchActivity_DL(ConnectionStringClass.GetConnection());
        private Employee_DL objEmployeeDL = new Employee_DL(ConnectionStringClass.GetConnection());
        private MainActivity_DL objMainActivityDL = new MainActivity_DL(ConnectionStringClass.GetConnection());
        private Department_DL objDepartment_DL = new Department_DL(ConnectionStringClass.GetConnection());
        private User _CurrentUser;
        private SESD.MRP.REF.PRPDBatchActivity objPRPDBatchActivity = new SESD.MRP.REF.PRPDBatchActivity();
        public User CurrentUser
        {
            get { return _CurrentUser; }
            set { _CurrentUser = value; }
        }
        private PRPDBatch objPRPDBatch = null;

        public frmAddPRPDActivity(User objuser, PRPDBatch objPRPDBatch)
        {
            this.objPRPDBatch = objPRPDBatch;
            CurrentUser = objuser;
            objPRPDBatchActivity.PRPDBatchActivityID = 0;
            InitializeComponent();
        }

        public frmAddPRPDActivity(User objuser, PRPDBatch objPRPDBatch, PRPDBatchActivity objPRPDBatchAct)
        {
            this.objPRPDBatch = objPRPDBatch;
            CurrentUser = objuser;
            objPRPDBatchActivity = objPRPDBatchAct;
            InitializeComponent();
            txtComment.Text = objPRPDBatchActivity.Comments;
            //cmbSupervisedBy.SelectedValue = objPRPDBatchActivity.SupervisedBy;
        }

        private void frmAddPRPDActivity_Load(object sender, EventArgs e)
        {
            try
            {
                cmbActivity.DataSource = objMainActivityDL.GetByDepID(objDepartment_DL.GetByDepType("PRPD").DepID);
                //cmbSupervisedBy.DataSource = objEmployeeDL.Get_By_RoleType( EmployeeRole.RoleType.Staff.ToString(), true);
            }
            catch (Exception)
            {

                MessageBox.Show(this, "Error occured while loading New RPD Batch Activity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                objPRPDBatchActivity.Comments = txtComment.Text;
                objPRPDBatchActivity.MainActID = Convert.ToInt64(cmbActivity.SelectedValue);
                objPRPDBatchActivity.PRPDBatchID = objPRPDBatch.PRPDBatchID;
                objPRPDBatchActivity.State = PRPDBatchActivity.ActStatus.Started;
                objPRPDBatchActivity.StartQty = Convert.ToDecimal(txtStartQty.Text);
                objPRPDBatchActivity.SupervisedBy =objEmployeeDL.Get(CurrentUser.EmployeeID);

                long ID = objPRPDBatchActivityDL.Add_Initial(objPRPDBatchActivity);
                if (ID > 0)
                {
                    this.Close();
                }


            }
            catch (Exception)
            {

                MessageBox.Show(this,"Error occured while saving","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
    }
}