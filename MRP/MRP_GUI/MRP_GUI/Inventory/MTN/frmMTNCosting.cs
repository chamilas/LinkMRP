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
    public partial class frmMTNCosting : System.Windows.Forms.Form
    {
        public frmMTNCosting()
        {
            InitializeComponent();
        }


        public frmMTNCosting(User objUser)
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
        private MTNFinishProduct_DL objMTNFinishProduct_DL = new MTNFinishProduct_DL(ConnectionStringClass.GetConnection());
        private MTNBasicProduct_DL objMTNBasicProduct_DL = new MTNBasicProduct_DL(ConnectionStringClass.GetConnection());
        private MTNCollec objMTNCollec = new MTNCollec();

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void frmMTNReceive_Load(object sender, EventArgs e)
        {
            Load_Data();
        }

        private void Load_Data()
        {
            try
            {
                gvMTNList.AutoGenerateColumns = false;

                DataTable dtMTNList = objMTNDL.GetDataView(CurrentUser.UserID, MTN.Status.Received);
                bindMTNList.DataSource = dtMTNList;
                gvMTNList.DataSource = bindMTNList;
                bindMTNList.ResetBindings(true);
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void gvMTNList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                long MTNNO = Convert.ToInt64(gvMTNList.CurrentRow.Cells[0].Value);
                objMTN = objMTNDL.Get(MTNNO);
                bindItemList.DataSource = objMTNDL.GetDataView(MTNNO);


            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReceive_Click(object sender, EventArgs e)
        {
            try
            {
                bool CanSubmit = true;

                for (int i = 0; i < gvItemList.Rows.Count; i++)
                {
                    if (gvItemList.Rows[i].Cells["UnitCost"].Value.ToString() == "")
                    {
                        CanSubmit = false;
                        break;
                    }
                }

                if (chkBudget.Checked == true)
                {
                    if (CanSubmit == true)
                    {
                        DialogResult theResult = MessageBox.Show(this, "Do you want to Send this MTN with Budgeted Costing", "Confirmation", MessageBoxButtons.YesNo);

                        if (theResult == System.Windows.Forms.DialogResult.Yes)
                        {
                            objMTNDL.Budget_Cost(MTN.Status.Cost, objMTN.MTNNo, CurrentUser.EmployeeID);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Cost Can not be Null");
                    }

                }

                else
                {
                    DialogResult theResult = MessageBox.Show(this, "Do you want to Send this MTN with System Generated Costing", "Confirmation", MessageBoxButtons.YesNo);

                    if (theResult == System.Windows.Forms.DialogResult.Yes)
                    {
                        objMTNDL.Actual_Cost(MTN.Status.Cost, objMTN.MTNNo, CurrentUser.EmployeeID);
                    }
                }


                Load_Data();

                if (gvMTNList.Rows.Count > 0)
                {
                    long MTNNO = Convert.ToInt64(gvMTNList.CurrentRow.Cells[0].Value);
                    objMTN = objMTNDL.Get(MTNNO);
                    bindItemList.DataSource = objMTNDL.GetDataView(MTNNO);
                }
                else
                {
                    bindItemList.DataSource = null;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gvMTNList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                gvItemList.Focus();

                gvItemList.CurrentCell = gvItemList.Rows[0].Cells["UnitCost"];
                 
            }
        }

        private void gvItemList_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                Load_CostingResultSheet();
                Load_Data();


            }
        }

        private void gvItemList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (chkBudget.Checked == true)
            {
                Load_CostingResultSheet();
            }
            else
            {
                MessageBox.Show("Please check the Button");
            }
        }

        private void Load_CostingResultSheet()
        {
            if (gvItemList.CurrentRow.Index != -1)
            {
                if (gvItemList.CurrentRow.Cells["ItemCode"].Value != null)
                {

                    if (objMTN.MTNItemType == MTN.ItemType.Finish_Product)
                    {
                        MTNFinishProduct obj = new MTNFinishProduct();

                        obj = objMTNFinishProduct_DL.Get(objMTN.MTNNo, Convert.ToString(gvItemList.CurrentRow.Cells["ItemCode"].Value));

                        frmCostingResults_FinishedProduct objForm = new frmCostingResults_FinishedProduct(obj);
                        objForm.ShowDialog(this);
                        objForm.StartPosition = FormStartPosition.CenterParent;
                    }

                    if (objMTN.MTNItemType == MTN.ItemType.Basic_Product)
                    {
                        MTNBasicProduct obj = new MTNBasicProduct();

                        obj = objMTNBasicProduct_DL.Get(objMTN.MTNNo, Convert.ToString(gvItemList.CurrentRow.Cells["ItemCode"].Value));

                        frmCostingResults_BasicProduct objForm = new frmCostingResults_BasicProduct(obj);
                        objForm.ShowDialog(this);
                        objForm.StartPosition = FormStartPosition.CenterParent;
                    }

                    bindItemList.DataSource = objMTNDL.GetDataView(objMTN.MTNNo);
                }

            }
        }

        private void btnCostReport_Click(object sender, EventArgs e)
        {
            try
            {
                MTN obj = new MTN();
                obj=objMTNDL.Get(Convert.ToInt64(gvMTNList.CurrentRow.Cells["Column1"].Value));

                if (obj.MTNType == MTN.Type.Batch)
                {

                    MRP_GUI.Report.frmRptProductionCost objForm = new Report.frmRptProductionCost(Convert.ToString(gvMTNList.CurrentRow.Cells["BatchID"].Value));
                    objForm.Show();
                }
                else
                {
                    MRP_GUI.Report.frmRptManufactPackCost objForm = new Report.frmRptManufactPackCost(Convert.ToInt64(gvMTNList.CurrentRow.Cells["PackingID"].Value));
                    objForm.Show();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}