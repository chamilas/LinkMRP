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
    public partial class frmMRApproval_Batch : System.Windows.Forms.Form
    {
        public frmMRApproval_Batch()
        {
            InitializeComponent();
        }

        public frmMRApproval_Batch(User objUser)
        {
            InitializeComponent();
            CurrentUser = objUser;
        }

        //-------------------- Variables ---------------------


        private User _objCurrentUser;

        public User CurrentUser
        {
            get { return _objCurrentUser; }
            set { _objCurrentUser = value; }
        }
        Department_DL objDepDL = new Department_DL(ConnectionStringClass.GetConnection());
        Store_DL objStoreDL = new Store_DL(ConnectionStringClass.GetConnection());
        Material_DL objMaterialDL = new Material_DL(ConnectionStringClass.GetConnection());
        BasicProduct_DL objBasicProductDL = new BasicProduct_DL(ConnectionStringClass.GetConnection());
        FinishProduct_DL objFinishProductDL = new FinishProduct_DL(ConnectionStringClass.GetConnection());
        UserDepartments_DL objUserDepartments_DL = new UserDepartments_DL(ConnectionStringClass.GetConnection());

        MR objMR;
        MR_DL objMRDL = new MR_DL(ConnectionStringClass.GetConnection());
        MRBasicProduct_DL objMRBasicProductDL = new MRBasicProduct_DL(ConnectionStringClass.GetConnection());
        MRBasicProductCollec objMRBasicProductCollec = new MRBasicProductCollec();
        MRFinishProduct_DL objMRFinishProductDL = new MRFinishProduct_DL(ConnectionStringClass.GetConnection());
        MRFinishProductCollec objMRFinishhProductCollec = new MRFinishProductCollec();
        MRMaterial_DL objMRMaterialDL = new MRMaterial_DL(ConnectionStringClass.GetConnection());
        MRMaterialCollec objMRMaterialCollec = new MRMaterialCollec();


        MRMaterial objMRMaterial = new MRMaterial();
        MRBasicProduct objMRBasicProduct = new MRBasicProduct();
        MRFinishProduct objMRFinishProduct = new MRFinishProduct();
        //------------------ Methods -------------------------------

        public void Clear()
        {
            txtDate.Text = "";
            txtDepartment.Text = "";
            txtMRNo.Text = "";
            txtRemarks.Text = "";
            txtReqestBy.Text = "";
            txtType.Text = "";
            bindItemList.DataSource = null;
            objMR = null;
            try
            {
                if (rbInitial.Checked)
                {
                    bindMRList.DataSource = objMRDL.GetMR_ToBatch(CurrentUser.UserID, MR.Status.Initial, MR.Origin.ToBatch);
                }
                else if (rbApproved.Checked)
                {
                    bindMRList.DataSource = objMRDL.GetMR_ToBatch(CurrentUser.UserID, MR.Status.Approved, MR.Origin.ToBatch);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //------------------ Events --------------------------------
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMRApproval_Load(object sender, EventArgs e)
        {
            try
            {
                bindItemList.DataSource = null;
                bindMRList.DataSource = null;

                  if (rbInitial.Checked)
                    {
                        bindMRList.DataSource = objMRDL.GetMR_ToBatch(CurrentUser.UserID, MR.Status.Initial, MR.Origin.ToBatch);
                    }
                    else if (rbApproved.Checked)
                    {
                        bindMRList.DataSource = objMRDL.GetMR_ToBatch(CurrentUser.UserID, MR.Status.Approved, MR.Origin.ToBatch);
                    }
                

            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      

        private void gvMRList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    bindItemList.DataSource = null;
                    long MRNO = Convert.ToInt64(gvMRList.Rows[e.RowIndex].Cells[0].Value);
                    MR objMRTemp = objMRDL.Get(MRNO);

                    objMR = new MR();
                    objMR = objMRTemp;
                    txtDate.Text = objMRTemp.MRDate.ToShortDateString();
                    txtDepartment.Text = objMRTemp.MRDepartmentFrom.DepName;
                    txtMRNo.Text = objMRTemp.MRNO.ToString();
                    txtRemarks.Text = objMRTemp.MRRemarks;
                    txtReqestBy.Text = objMRTemp.MREnterdBy;
                    txtType.Text = objMRTemp.MRType.ToString();

                    if (objMRTemp.MRType == MR.Type.Material)
                    {
                        bindItemList.DataSource = objMRMaterialDL.GetDataView(objMRTemp.MRNO);
                    }

                    if (objMRTemp.MRType == MR.Type.BasicProduct)
                    {
                        bindItemList.DataSource = objMRBasicProductDL.GetBasicProductList(objMRTemp.MRNO);
                    }

                    if (objMRTemp.MRType == MR.Type.FinishProduct)
                    {
                        bindItemList.DataSource = objMRFinishProductDL.GetDataView(objMRTemp.MRNO);
                    }
                    
                    
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            try
            {
                if (objMR != null)
                {
                    DialogResult dr = MessageBox.Show(this, "Are you sure you want to Approve selected Material Requisition?\n\nClick yes to Approve", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question,MessageBoxDefaultButton.Button2);

                    if (dr == DialogResult.Yes)
                    {
                        objMR.MRStatus = MR.Status.Approved;
                        objMR.MRApprovedBy = CurrentUser.UserEmp.EmployeeID;
                        int x = objMRDL.Update_Approve(objMR);
                        if (x > 0)
                        {
                            MessageBox.Show(this, "Material Requition Approved", "Aproved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Clear();

                        } 
                    }
                }
                else
                {
                    MessageBox.Show(this,"Please select a MR before click Approve","Select a MR",MessageBoxButtons.OK,MessageBoxIcon.Information);
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
                if (objMR != null)
                {
                    DialogResult dr = MessageBox.Show(this, "Are you sure you want to Reject selected MR?\n\nClick yes to reject", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        objMR.MRStatus = MR.Status.Reject;
                        objMR.MRApprovedBy = CurrentUser.UserEmp.EmployeeID;
                        int x = objMRDL.Update_Approve(objMR);
                        if (x > 0)
                        {
                            MessageBox.Show(this, "Material Requition Rejected", "Rejected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Clear();

                           
                        }
                    }
                }
                else
                {
                    MessageBox.Show(this, "Please select a MR before click Reject", "Select a MR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (objMR != null)
                {
                    DialogResult dr = MessageBox.Show(this, "Are you sure you want to Delete selected MR?\n\nClick yes to Delete", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        int x = objMRDL.Delete(objMR.MRNO);
                        if (x > 0)
                        {
                            MessageBox.Show(this, "Material Requition Deleted", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Clear();

                        }
                    }
                }
                else
                {
                    MessageBox.Show(this, "Please select a MR before click Delete", "Select a MR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rbInitial_CheckedChanged(object sender, EventArgs e)
        {
            btnApprove.Enabled = true;
            btnDelete.Enabled = true;
            btnReject.Enabled = true;
            btnPrint.Enabled = false;

            if (rbInitial.Checked)
            {
                bindMRList.DataSource = objMRDL.GetMR_ToBatch(CurrentUser.UserID, MR.Status.Initial, MR.Origin.ToBatch);
            }
            else if (rbApproved.Checked)
            {
                bindMRList.DataSource = objMRDL.GetMR_ToBatch(CurrentUser.UserID, MR.Status.Approved, MR.Origin.ToBatch);
            }
                
        }

        private void rbApproved_CheckedChanged(object sender, EventArgs e)
        {
            btnApprove.Enabled = false;
            btnDelete.Enabled = false;
            btnReject.Enabled = true;
            btnPrint.Enabled = true;

            if (rbInitial.Checked)
            {
                bindMRList.DataSource = objMRDL.GetMR_ToBatch(CurrentUser.UserID, MR.Status.Initial, MR.Origin.ToBatch);
            }
            else if (rbApproved.Checked)
            {
                bindMRList.DataSource = objMRDL.GetMR_ToBatch(CurrentUser.UserID, MR.Status.Approved, MR.Origin.ToBatch);
            }
                
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            //if (objMR.MRType == MR.Type.Material)
            //{
            //    ReportForm.frmRptMatrialMR objFrm = new MRP_GUI.ReportForm.frmRptMatrialMR(objMR.MRNO);
            //    objFrm.MdiParent = this.MdiParent;
            //    objFrm.Show();
            //}
            //else if (objMR.MRType == MR.Type.BasicProduct)
            //{
            //    ReportForm.frmRptBasicProductMR objFrm = new MRP_GUI.ReportForm.frmRptBasicProductMR(objMR.MRNO);
            //    objFrm.MdiParent = this.MdiParent;
            //    objFrm.Show();
            //}
            //else if (objMR.MRType == MR.Type.FinishProduct)
            //{
            //    ReportForm.frmRptFinishProductMR objFrm = new MRP_GUI.ReportForm.frmRptFinishProductMR(objMR.MRNO);
            //    objFrm.MdiParent = this.MdiParent;
            //    objFrm.Show();
            //}
        }

    }
}