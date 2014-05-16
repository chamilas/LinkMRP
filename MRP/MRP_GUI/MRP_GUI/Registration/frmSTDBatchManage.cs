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
    public partial class frmSTDBatchManage : System.Windows.Forms.Form
    {
        public frmSTDBatchManage(User objUser)
        {
            InitializeComponent();
            CurrentUser = objUser;
        }

        private User _objCurrentUser;

        public User CurrentUser
        {
            get { return _objCurrentUser; }
            set { _objCurrentUser = value; }
        }
        STDBatch_DL objSTDBatchDL = new STDBatch_DL(ConnectionStringClass.GetConnection());
        Activity_DL objActivityDL = new Activity_DL(ConnectionStringClass.GetConnection());
        ActivityMachine_DL objActivityMachineDL = new ActivityMachine_DL(ConnectionStringClass.GetConnection());


        private void frmSTDBatchManage_Load(object sender, EventArgs e)
        {
            try
            {
                bindSTDBatch.DataSource = objSTDBatchDL.Get_DataView();
            }
            catch (Exception ex)
            {
                
               MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gvSTDBatch_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                bindActivity.DataSource = null;
               
                bindMachines.DataSource = null;
                bindSubInstructions.DataSource = null;
                string ID = Convert.ToString(gvSTDBatch.Rows[e.RowIndex].Cells["ColBatchID"].Value);
                bindActivity.DataSource = objActivityDL.Get_DataView(ID);
                STDBatch obj = objSTDBatchDL.Get(ID);
                //if (e.ColumnIndex == 0)
                //{
                //    //frmStandardBatch objFrm = new frmStandardBatch(CurrentUser, obj);

                //    frmStandardBatch objFrm = new  frmStandardBatch(obj, CurrentUser);
                //    objFrm.MdiParent = this.MdiParent;
                //    objFrm.Show();
                //    this.Close();
                //}
            }
            catch (Exception ex)
            {
                
               MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gvActivity_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                bindInstructions.DataSource = null;
                long ID = Convert.ToInt64(gvActivity.Rows[e.RowIndex].Cells["ColActID"].Value);
                Activity objAct = new Activity();
                objAct.ActivityID = ID;
                
                bindMachines.DataSource = objActivityMachineDL.Get(objAct);
            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}