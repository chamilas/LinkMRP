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
    public partial class frmGRNManagement : System.Windows.Forms.Form
    {
        public frmGRNManagement(User objUser)
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

        private Department_DL objDepDL = new Department_DL(ConnectionStringClass.GetConnection());
        private SESD.MRP.REF.GRN objGRN = new SESD.MRP.REF.GRN();
        private GRN_DL objGRN_DL = new GRN_DL(ConnectionStringClass.GetConnection());
        UserDepartments_DL objUserDepartments_DL = new UserDepartments_DL(ConnectionStringClass.GetConnection());


        private void frmGRNManagement_Load(object sender, EventArgs e)
        {
            try
            {
                cmbStatus.DataSource = Enum.GetNames(typeof(SESD.MRP.REF.GRN.Status));
                cmbDepartment.DataSource = objUserDepartments_DL.Get(CurrentUser.UserID);

            }
            catch (Exception)
            {

                MessageBox.Show(this, "Error occured while loading GRN Management", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void gvGRNList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > 0)
                {
                    objGRN = new GRN();
                    bindItemList.DataSource = null;
                    objGRN = objGRN_DL.Get(Convert.ToInt64(gvGRNList.Rows[e.RowIndex].Cells["ColGRNNO"].Value));
                    if (objGRN != null)
                    {
                        bindItemList.DataSource = objGRN_DL.GetDataView_Items(objGRN.GRNNo);
                    }
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                
                bindGRN.DataSource = objGRN_DL.GetDataView(Convert.ToInt64(cmbDepartment.SelectedValue), dtFrom.Value, dtTo.Value, (SESD.MRP.REF.GRN.Status)Enum.Parse(typeof(SESD.MRP.REF.GRN.Status), cmbStatus.SelectedItem.ToString()));
                bindItemList.DataSource = null;
            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            frmGRNPrint objForm = new frmGRNPrint(CurrentUser, Convert.ToInt64(gvGRNList.CurrentRow.Cells["ColGRNNO"].Value));
            objForm.WindowState = FormWindowState.Maximized;
            objForm.ShowDialog(this);
        }
    }
}