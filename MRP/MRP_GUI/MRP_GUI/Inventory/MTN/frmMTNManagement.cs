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
    public partial class frmMTNManagement : System.Windows.Forms.Form
    {
        public frmMTNManagement(User objUser)
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
        private MTN objMTN = new MTN();
        private MTN_DL objMTNDL = new MTN_DL(ConnectionStringClass.GetConnection());
        private MTNCollec objMTNCollec = new MTNCollec();
        UserDepartments_DL objUserDepartments_DL = new UserDepartments_DL(ConnectionStringClass.GetConnection());

        private void frmMTNManagement_Load(object sender, EventArgs e)
        {
            try
            {
                cmbStatus.DataSource = Enum.GetNames(typeof(MTN.Status));
                cmbDepartment.DataSource = objUserDepartments_DL.Get(CurrentUser.UserID);

            }
            catch (Exception)
            {

                MessageBox.Show(this, "Error occured while loading MTN", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            try
            {
                bindMtnList.DataSource = objMTNDL.GetDataView(dtTo.Value, dtFrom.Value, Convert.ToInt64(cmbDepartment.SelectedValue), (MTN.Status)Enum.Parse(typeof(MTN.Status), cmbStatus.SelectedItem.ToString()));


            }
            catch (Exception ex)
            {

                MessageBox.Show(this, "Error occured while loading Material Transfer Notes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); ;
            }
        }

        private void gvMTNList_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    long MTNNO = Convert.ToInt64(gvMTNList.Rows[e.RowIndex].Cells[0].Value);
                    objMTN = objMTNDL.Get(MTNNO);
                    bindMaterialList.DataSource = objMTNDL.GetDataView(MTNNO);
                }
                catch (Exception ex)
                {

                    MessageBox.Show(this, "Error occured while loading Item List", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cmbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
