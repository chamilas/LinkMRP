using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DL;
using SESD.MRP.REF;

namespace MRP_GUI.RPD.RPDBatchActivityForms
{
    public partial class frmAddActivity : System.Windows.Forms.Form
    {
        private RPDBatchActivity_DL objRPDBatchActivityDL = new RPDBatchActivity_DL(ConnectionStringClass.GetConnection());
        private Employee_DL objEmployeeDL = new Employee_DL(ConnectionStringClass.GetConnection());
        private MainActivity_DL objMainActivityDL = new MainActivity_DL(ConnectionStringClass.GetConnection()); 
        private User _CurrentUser;
        private SESD.MRP.REF.RPDBatchActivity objRPDBatchActivity = new SESD.MRP.REF.RPDBatchActivity();
        public User CurrentUser
        {
            get { return _CurrentUser; }
            set { _CurrentUser = value; }
        }
        private RPDBatch objRPDBatch = null;
        public frmAddActivity()
        {
            InitializeComponent();
        }



        public frmAddActivity(User objuser, RPDBatch objRpdbatch)
        {
            objRPDBatch = objRpdbatch;
            CurrentUser = objuser;
            objRPDBatchActivity.RPDBatchActID = 0;
            InitializeComponent();
        }

        public frmAddActivity(User objuser, RPDBatch objRpdbatch,SESD.MRP.REF.RPDBatchActivity objRPDBatchAct)
        {
            objRPDBatch = objRpdbatch;
            CurrentUser = objuser;
            objRPDBatchActivity = objRPDBatchAct;
            InitializeComponent();
            txtComment.Text = objRPDBatchActivity.Comments;
            //cmbInstructedBy.SelectedValue = objRPDBatchActivity.InspectedBy;
            cmbSupervisedBy.SelectedValue = objRPDBatchActivity.SupervisedBy;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddActivity_Load(object sender, EventArgs e)
        {
            try
            {
                Department_DL objDepartment_DL = new Department_DL(ConnectionStringClass.GetConnection());


                cmbActivity.DataSource = objMainActivityDL.GetByDepID(objDepartment_DL.GetByDepType("RPD").DepID);
                cmbInstructedBy.DataSource = objEmployeeDL.Get_By_RoleType(EmployeeRole.RoleType.Manager.ToString(), true);
                cmbSupervisedBy.DataSource = objEmployeeDL.Get_By_RoleType(EmployeeRole.RoleType.Staff.ToString(), true);
            }
            catch (Exception)
            {

                MessageBox.Show(this,"Error occured while loading New RPD Batch Activity","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                objRPDBatchActivity.ActivityStatus = SESD.MRP.REF.RPDBatchActivity.Status.Started;
                if(txtComment.Text!="")
                {
                objRPDBatchActivity.Comments = txtComment.Text;
                }
                else
                {
                    objRPDBatchActivity.Comments = "N/A";
                }
                objRPDBatchActivity.MainActID = Convert.ToInt64(cmbActivity.SelectedValue);

                objRPDBatchActivity.RPDBatchID = objRPDBatch.RPDBatchID;
                objRPDBatchActivity.SupervisedBy = cmbSupervisedBy.SelectedValue.ToString();
                objRPDBatchActivity.StartQty = Convert.ToDecimal(txtStartQty.Text);
                
                MainActivity objMainAct = objMainActivityDL.GetByName("Packing-RPD");

                if (objMainAct.MainActID == objRPDBatchActivity.MainActID)
                {
                    RPDBatchActivity obj = objRPDBatchActivityDL.Get("Packing-RPD", objRPDBatch.RPDBatchID);
                    if (obj.RPDBatchActID != 0)
                    {
                        MessageBox.Show(this,"Pakcing Activity already added, You can't add more than one Packing Activity","Packing Activity already added",MessageBoxButtons.OK,MessageBoxIcon.Information);

                    }
                    else
                    {
                        long ID = objRPDBatchActivityDL.Add(objRPDBatchActivity);
                        if (ID > 0)
                        {
                            this.Close();
                        }
                    }
                }
                else
                {
                    long ID = objRPDBatchActivityDL.Add(objRPDBatchActivity);
                    if (ID > 0)
                    {
                        this.Close();
                    }
                }




            }
            catch (Exception)
            {

                MessageBox.Show(this,"Error occured while saving batch activity","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void cmbActivity_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}