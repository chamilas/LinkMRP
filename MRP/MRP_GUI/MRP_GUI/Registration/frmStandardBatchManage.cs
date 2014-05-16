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
    public partial class frmStandardBatchManage : System.Windows.Forms.Form
    {
        //----------------------------------------------------------------
        private User _objCurrentUser;

        public User CurrentUser
        {
            get { return _objCurrentUser; }
            set { _objCurrentUser = value; }
        }
        
        
        Material_DL objMaterialDL = new Material_DL(ConnectionStringClass.GetConnection());
        FinishProduct_DL objFinishProductDL = new FinishProduct_DL(ConnectionStringClass.GetConnection());
        BasicProduct_DL objBasicProductDL = new BasicProduct_DL(ConnectionStringClass.GetConnection());
        FinishProduct objFinishProduct = new FinishProduct();
        BasicProduct objBasicProduct = new BasicProduct();
        Formula_DL objFormulaDL = new Formula_DL(ConnectionStringClass.GetConnection());
        MainActivity_DL objMainActivtyDL = new MainActivity_DL(ConnectionStringClass.GetConnection());
        Machine_DL objMachineDL = new Machine_DL(ConnectionStringClass.GetConnection());
        Panel CurrentPanel;
        ActivityMachine_DL objActMachineDL = new ActivityMachine_DL(ConnectionStringClass.GetConnection());
        ActivityCollec objActivityCollec = new ActivityCollec();
        STDBatch objStdBatch = new STDBatch();
        STDBatch_DL objSTDBatchDL = new STDBatch_DL(ConnectionStringClass.GetConnection());
        Activity objActivitySelected = new Activity();
        
        DataTable dt = new DataTable();

        DataTable dtProducts = new DataTable();
         DataTable dtBatchList = new DataTable();
        DataTable dtActivity = new DataTable();

        Activity_DL objActivityDL = new Activity_DL(ConnectionStringClass.GetConnection());


        public string Save_STDBatch()
        {
            try
            {
                objStdBatch.STDBatchDescription = txtRemarks.Text;
                objStdBatch.STDBatchInstructedBy = CurrentUser.UserEmp;
                objStdBatch.STDBatchSize = Convert.ToDecimal(txtBatchSize.Text);
                objStdBatch.STDInstructedDate = DateTime.Now;
                objStdBatch.STDDuration = Convert.ToDecimal(txtBatchDuration.Text);

                if (cmbProductType.SelectedIndex == 0 || cmbProductType.SelectedIndex == 1)
                {
                    BasicProduct objBasic = objBasicProductDL.Get(cmbProductCode.SelectedValue.ToString());

                    objStdBatch.STDBatchBasicProduct = objBasic;
                    objStdBatch.STDBatchFinishProduct = new FinishProduct();
                    objStdBatch.STDBatchType = "Basic";

                    objStdBatch.STDBatchID = objSTDBatchDL.Add_Basic(objStdBatch);
                }
                else if (cmbProductType.SelectedIndex == 2)
                {
                    FinishProduct objFinish = objFinishProductDL.Get(cmbProductCode.SelectedValue.ToString());
                    objStdBatch.STDBatchBasicProduct = new BasicProduct();
                    objStdBatch.STDBatchFinishProduct = objFinish;
                    objStdBatch.STDBatchType = "Finish";
                }
                
             


                return objStdBatch.STDBatchID;
            }
            catch (FormatException fex)
            {

                MessageBox.Show(this, "Invalid Data, Please check Standard Batch Size and Duration", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return "No";
            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "No";
            }

        
        }
        
        public frmStandardBatchManage(User objUser)
        {
            CurrentPanel = new Panel();
            InitializeComponent();
           this.CurrentUser = objUser;

        }


        private void Load_Data()
        {
            try
            {

                dtActivity = objMainActivtyDL.Get_Data_View();


                objSourceMainActivityList.DataSource = dtActivity;
                cmbActivity.DataSource = objSourceMainActivityList;

            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }



        private void Load_Products()
        {
            try
            {

            if ((cmbProductType.Text == "Semi Processed Product") | (cmbProductType.Text == "Basic Product"))
            {
                if (cmbProductType.Text == "Semi Processed Product")
                {
                    dtProducts = objBasicProductDL.GetDataView("Semi Processed Product", true);

                    cmbProductCode.DisplayMember = "BasicProductDescription";
                    cmbProductCode.ValueMember="BasicProductCode";

                }
                else
                {
                    dtProducts = objBasicProductDL.GetDataView("Product", true);

                    cmbProductCode.DisplayMember = "BasicProductDescription";
                    cmbProductCode.ValueMember = "BasicProductCode";
                }
            }
            else if (cmbProductType.Text == "Finish Product")
            {

                dtProducts = objFinishProductDL.GetDataView(true);

                cmbProductCode.DisplayMember = "FinishProdutDescription";
                cmbProductCode.ValueMember = "FinishProductCode";
            }


            objSourceProducts.DataSource = dtProducts;
            cmbProductCode.DataSource = objSourceProducts;


             }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        private void frmStandardBatch_Load(object sender, EventArgs e)
        {
            try
            {

                Load_Data();
                

               
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbProductType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Load_Products();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
           
            
            }
        }

        private void Set_STDBatchCode()
        {
            if((cmbProductCode.SelectedValue!=null && (txtBatchSize.Text!="")))
            {
            txtSTDBatchID.Text = cmbProductCode.SelectedValue.ToString() +"-"+ txtBatchSize.Text;
            }
        }

        private void Load_BatchList()
        {
            try
            {

                dtBatchList= objSTDBatchDL.Get_Data_ByProduct(cmbProductCode.SelectedValue.ToString());
                dgvBatchList.AutoGenerateColumns = false;
                bindBatchList.DataSource=dtBatchList;
                dgvBatchList.DataSource=bindBatchList;
                bindBatchList.ResetBindings(true);

         
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void cmbProductCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Load_BatchList();
                Set_STDBatchCode();
         
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

            

        private void gvActivityList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Activity objActivity = (Activity)gvActivityList.Rows[e.RowIndex].DataBoundItem;


                ActivityMachineCollec objActMachineCollec = objActMachineDL.Get(objActivity);
                dt.Clear();
                foreach (ActivityMachine obj in objActMachineCollec)
                {
                    dt.Rows.Add(obj.Machine.MachineCode, obj.EstimatedHour);
                }


               
                objActivitySelected = objActivity;

            }
            catch (Exception ex)
            {
                
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActivityDelete_Click(object sender, EventArgs e)
        {


            try
            {

                DeleteActivity();

            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteActivity()
        {
            DialogResult dr = MessageBox.Show(this, "You are about to delete a Activity\n\nClick yes to permently delete. you won't be able to undo these deletions", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Yes)
            {
                objActivityCollec.RemoveAt(gvActivityList.CurrentRow.Index);


            }


        }

        private void gvActivityList_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      


        private void txtBatchSize_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar) || (e.KeyChar == (char)46)))
            {
                e.Handled = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {

                bool Duplicate = false;

                if ((cmbActivity.SelectedValue != null)&&(cmbPart.Text!=""))
                {
                        Activity obj = new Activity();

                        obj.ActCost = 0;
                        obj.ActDuration = 0;
                        obj.ActMainActivity = objMainActivtyDL.Get(Convert.ToInt64(cmbActivity.SelectedValue));
                        obj.ActManHours = 0;
                        obj.BlockNextActivity = false;
                        obj.InstructedBy = CurrentUser.EmployeeID;
                        obj.Part = cmbPart.Text;
                        obj.SequenceNo = 1;
                      

                    objActivityDL.Add(obj);

                    Load_ActivityList();

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


            DeleteActivity();

            gvActivityList.AutoGenerateColumns = false;
            objSourceActivity.DataSource = objActivityCollec;
            gvActivityList.DataSource = objSourceActivity;
            objSourceActivity.ResetBindings(true);

             }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbProductCode.SelectedValue != null)
                {
                    if (objActivityCollec.Count > 0)
                    {

                        if (objSTDBatchDL.Get_Count(cmbProductCode.SelectedValue.ToString(), Convert.ToInt32(txtBatchSize.Text)) ==0) 
                        {

                            string TheBatchID = Save_STDBatch();

                            objStdBatch = objSTDBatchDL.Get(TheBatchID);
                            


                            foreach (Activity obj in objActivityCollec)
                            {
                                obj.ActSTDBatch = objStdBatch;

                                objActivityDL.Add(obj);
                            }

                            MessageBox.Show(TheBatchID + "  is Created");

                            objActivityCollec = null;
                            //objSourceActivity = null;


                            gvActivityList.AutoGenerateColumns = false;
                            objSourceActivity.DataSource = objActivityCollec;
                            gvActivityList.DataSource = objSourceActivity;
                            objSourceActivity.ResetBindings(true);


                        }
                        else
                        {
                            MessageBox.Show(this, "There is a Standard Batch already with the same size", "Duplicate Found", MessageBoxButtons.OK);
                        }


                    }
                    else
                    {
                        MessageBox.Show(this, "No Activities are assigned to STD Batch","Missing Info", MessageBoxButtons.OK);
                    }
                }

                else
                {

                    MessageBox.Show(this, "Please select a Product", "Missing Info", MessageBoxButtons.OK);
                }
                
            }
            catch (FormatException fex)
            {

                MessageBox.Show(this, "Invalid Data type, Please check Standard Batch Size", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtBatchSize_TextChanged(object sender, EventArgs e)
        {
            Set_STDBatchCode();
        }

        private void dgvBatchList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Load_ActivityList();
        }

       private void Load_ActivityList()
        {
            try
            {

                objActivityCollec= objActivityDL.Get_STDBatch(dgvBatchList.CurrentRow.Cells["STDBatchID"].Value.ToString());
                bindActivity.DataSource = objActivityCollec;
                gvActivityList.DataSource = bindActivity;
                bindActivity.ResetBindings(true);

         
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
      

        
    }
}