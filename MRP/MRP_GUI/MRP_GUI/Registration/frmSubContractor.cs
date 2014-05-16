using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SESD.MRP.REF;
using DL;

namespace MRP_GUI.Registration
{
    public partial class frmSubContractor : System.Windows.Forms.Form
    {
        private User _CurrentUser;

        public User CurrentUser
        {
            get { return _CurrentUser; }
            set { _CurrentUser = value; }
        }
        SubContractor_DL objSubContractor_DL = new SubContractor_DL(ConnectionStringClass.GetConnection());
        SubContractor objSubContractor;

        public frmSubContractor(User objUser)
        {
            CurrentUser = objUser;
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSubContractor_Load(object sender, EventArgs e)
        {
            try
            {
                bindSub.DataSource = objSubContractor_DL.GetView();
            }
            catch (Exception ex)
            {

                MessageBox.Show(this,"Error occured while loading","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (objSubContractor == null)
                {
                    objSubContractor = new SubContractor();
                }
                objSubContractor.SubAddress = txtAddress.Text;
                objSubContractor.SubCode = txtCode.Text;
                objSubContractor.SubContactPerson = txtContactPerson.Text;
                objSubContractor.SubEmail = txtEmail.Text;
                objSubContractor.SubFax = txtFax.Text;
                objSubContractor.SubMobile = txtMobile.Text;
                objSubContractor.SubName = txtName.Text;
                objSubContractor.SubPhone = txtPhone.Text;
                objSubContractor.SubStatus = true;

                long ID = objSubContractor_DL.Add(objSubContractor);
                if (ID > 0)
                {
                    MessageBox.Show(this, "Successfuly Saved", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    bindSub.DataSource = objSubContractor_DL.GetView();


                    Clear();

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(this,"Error occured while saving","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void Clear()
        {
            txtPhone.Text = "";
            txtName.Text = "";
            txtMobile.Text = "";
            txtFax.Text = "";
            txtEmail.Text = "";
            txtContactPerson.Text = "";
            txtCode.Text = "";
            txtAddress.Text = "";
            objSubContractor = null;
            lblID.Text = "[Auto]";
            btnDelete.Enabled = false;
        }

        private void gvSubContractors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show(this,"Are you sure you want Delete selected Record?\n\nClick Yes to delete","Confirm Delete",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    //int res = objSubContractor_DL.Delete(objSubContractor.SubContractorID);

                    //if (res > 0)
                    //{
                    //    Clear();
                    //    bindSub.DataSource = objSubContractor_DL.GetView();

                    //}
                }
            }
            catch (Exception)
            {

                MessageBox.Show(this,"Error occured while Deleting","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void gvSubContractors_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {


                    long ID = Convert.ToInt64(gvSubContractors.Rows[e.RowIndex].Cells["ColID"].Value);
                    objSubContractor = objSubContractor_DL.Get(ID);
                    if (objSubContractor != null)
                    {
                        txtPhone.Text = objSubContractor.SubPhone;
                        txtName.Text = objSubContractor.SubName;
                        txtMobile.Text = objSubContractor.SubMobile;
                        txtFax.Text = objSubContractor.SubFax;
                        txtEmail.Text = objSubContractor.SubEmail;
                        txtContactPerson.Text = objSubContractor.SubContactPerson;
                        txtCode.Text = objSubContractor.SubCode;
                        txtAddress.Text = objSubContractor.SubAddress;
                        lblID.Text = objSubContractor.SubContractorID.ToString();
                        btnDelete.Enabled = true;
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show(this, "Error occured while loading Sub Contractor details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}