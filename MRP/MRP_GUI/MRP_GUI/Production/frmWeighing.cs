using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DL;
using SESD.MRP.REF;
using MRP_GUI.Production;

namespace MRP_GUI
{
    public partial class frmWeighing : System.Windows.Forms.Form
    {
        private User _CurrentUser;

        public User CurrentUser
        {
            get { return _CurrentUser; }
            set { _CurrentUser = value; }
        }
        
        Batch objBatch;
        BatchActivity objBatchActivity = null;
        BatchActivity_DL objBatchActivity_DL = new BatchActivity_DL(ConnectionStringClass.GetConnection());
        Batch_DL objBatch_DL = new Batch_DL(ConnectionStringClass.GetConnection());
        MainActivity_DL objMainActivity_DL = new MainActivity_DL(ConnectionStringClass.GetConnection());
        BatchFormualFinishProducts_DL objBatchFormualFinishProducts_DL = new BatchFormualFinishProducts_DL(ConnectionStringClass.GetConnection());
        BatchFormulaBasicProducts_DL objBatchFormulaBasicProducts_DL = new BatchFormulaBasicProducts_DL(ConnectionStringClass.GetConnection());
        BatchFormulaMaterial_DL objBatchFormulaMaterial_DL = new BatchFormulaMaterial_DL(ConnectionStringClass.GetConnection());
        BatchLabourDetails_DL objBatchLabourDetails_DL = new BatchLabourDetails_DL(ConnectionStringClass.GetConnection());
        Employee_DL objEmployee_DL = new Employee_DL(ConnectionStringClass.GetConnection());
        EmployeeRole_DL objEmployeeRole_DL = new EmployeeRole_DL(ConnectionStringClass.GetConnection());
        Section_DL objSection_DL = new Section_DL(ConnectionStringClass.GetConnection());

        MainActivity objMainAct = new MainActivity();

        DataTable dtSections = new DataTable();
        Sections objSection = new Sections();

        string Part = "A";

        public frmWeighing(User objUser)
        {
            CurrentUser = objUser;
            InitializeComponent();
        }

        private void frmWeighing_Load(object sender, EventArgs e)
        {
            try
            {

                     rdbPermanentSection.Checked = true;

                    objMainAct = objMainActivity_DL.GetByName("Weighing");
                    Load_employee();
                    Load_Batch_List();
                    


                
            }
            catch (Exception)
            {

                MessageBox.Show(this,"Error occured while loading weighing details","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

       

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void LoadMaterials(string Part)
        {
            try
            {
                
                           // bindItem.DataSource = objBatchFormulaMaterial_DL.GetView(objBatch.BatchID, Part);

                           // bindItem.DataSource = objBatchFormulaBasicProducts_DL.GetView(objBatch.BatchID, Part);
                  
            }
            catch (Exception)
            {

                MessageBox.Show(this, "Error occured while loading Materil List", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        

        private void btnSave_Click(object sender, EventArgs e)
        {
           // try
            //{
            //    DialogResult dialogres = MessageBox.Show(this,"Are you sure you want to save Weighed Items?\n\nClick Yes to Save","Error",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2);

            //    if (dialogres == DialogResult.Yes)
            //    {


            //        if (cmbItemType.SelectedItem.Equals("Raw Material"))
            //        {

            //            String Part = cmbPart.SelectedItem.ToString();

            //            foreach (DataGridViewRow dr in gvItems.Rows)
            //            {
            //                String MatCode = dr.Cells["ColMaterialCode"].Value.ToString();

            //                if (dr.Cells["colWeigh"].Value != null)
            //                {

            //                    BatchFormulaMaterial obj = new BatchFormulaMaterial();
            //                    obj.BatchID = objBatch.BatchID;
            //                    obj.Part = Part;
            //                    obj.MaterialCode = MatCode;
            //                    obj.WeighBy = CurrentUser.EmployeeID;

            //                    obj.Weigh = Convert.ToBoolean(dr.Cells["colWeigh"].Value);
            //                    obj.WeighDate = DateTime.Now;

            //                    objBatchFormulaMaterial_DL.Update_Weigh(obj);
            //                }


            //            }

                        
            //        }
            //        else
            //        {

            //            String Part = cmbPart.SelectedItem.ToString();

            //            foreach (DataGridViewRow dr in gvItems.Rows)
            //            {
            //                String BasicCode = dr.Cells["ColBasicProductCode"].Value.ToString();

            //                if (dr.Cells["colWeigh"].Value != null)
            //                {

            //                    BatchFormulaBasicProducts obj = new BatchFormulaBasicProducts();
            //                    obj.BatchID = objBatch.BatchID;
            //                    obj.Part = Part;
            //                    obj.BasicProductCode = BasicCode;
            //                    obj.WeighBy = CurrentUser.EmployeeID;

            //                    obj.Weigh = Convert.ToBoolean(dr.Cells["colWeigh"].Value);
            //                    obj.WeighDate = DateTime.Now;

            //                    objBatchFormulaBasicProducts_DL.Update_Weigh(obj);
            //                }


            //            }
            //            //bindItem.DataSource = objBatchFormulaBasicProducts_DL.GetView(objBatch.BatchID, cmbPart.SelectedItem.ToString());
            //            //ColMaterial.Visible = false;
            //            //ColBasic.Visible = true;
            //        }
            //    }
            //}
            //catch (Exception)
            //{

            //    MessageBox.Show(this,"Error occured while saving Weighed Items","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            //}
        //}

        //private void chkSectionLabour_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (chkSectionLabour.Checked == true)
        //    {

        //    }
        }

        private void txtBatch_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                frmBatchList objForm = new frmBatchList(CurrentUser);
                objForm.ShowDialog();

            }
        }


        private void Load_Batch_List()
        {
            try
            {

                DataTable dt = objBatch_DL.Get_DataView_Weigh();
                objSourceBatchList.DataSource = dt;

                dgvBatcList.AutoGenerateColumns = false;
                dgvBatcList.DataSource = objSourceBatchList;
                objSourceBatchList.ResetBindings(true);


            }
            catch (Exception)
            {

                MessageBox.Show(this, "Error occured while loading Batch List", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }


        private void Load_Formula(string BatchID, string Part)
        {
            try
            {

                DataTable dt = objBatchFormulaMaterial_DL.GetView_Full(BatchID, Part);
              
                objSourceMaterial.DataSource = dt;

               dgvFormula.AutoGenerateColumns = false;
               dgvFormula.DataSource = objSourceMaterial;
               objSourceMaterial.ResetBindings(true);



               if (objBatchFormulaMaterial_DL.Get_WeighedCount(BatchID, Part) > 0)
               {
                   btnWeigh.Enabled = false;
               }
               else
               {
                   if (dt.Rows.Count > 0)
                   {
                       btnWeigh.Enabled = true;
                   }
                   else
                   {
                       btnWeigh.Enabled = false;
                   }
               }

               if (objBatchFormulaMaterial_DL.Get_WeighCheckedCount(BatchID, Part) > 0)
               {
                   dgvFormula.DefaultCellStyle.BackColor = Color.Green;
               }
               else if (objBatchFormulaMaterial_DL.Get_WeighedCount(BatchID, Part) > 0)
               {
                   dgvFormula.DefaultCellStyle.BackColor = Color.Yellow;

               }
               else
               {

                   dgvFormula.DefaultCellStyle.BackColor = Color.White;
               }



            }
            catch (Exception)
            {

                MessageBox.Show(this, "Error occured while loading Batch List", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }


        private void dgvBatcList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           try
           {
               if (dgvBatcList.CurrentRow.IsNewRow == false)
               {
               
               objBatch = objBatch_DL.Get(dgvBatcList.CurrentRow.Cells["BatchNo"].Value.ToString());

               objBatchActivity = objBatchActivity_DL.Get(objBatch.BatchID, objMainAct.MainActID);

               if (objBatchActivity.BatchActID != 0)
               {


               }
               else
               {
                   objBatchActivity = new BatchActivity();
                   objBatchActivity.Batch = objBatch;
                   objBatchActivity.BatchActStatus = BatchActivity.Status.Initial;
                   objBatchActivity.BlockNextActivity = true;
                   objBatchActivity.SequenceNo = -1;
                   objBatchActivity.Part = "N/A";
                   objBatchActivity.MainActivity = objMainAct;
                   objBatchActivity.LastEdited = DateTime.Now;
                   objBatchActivity.ActType = "Manufacturing";

                   long ID = objBatchActivity_DL.Add(objBatchActivity);
                   if (ID > 0)
                   {
                       objBatchActivity.BatchActID = ID;
                   }

               }

               Load_LabourDetails();
               Load_Formula(objBatch.BatchID, Part);
                

            }

           }
           catch (Exception)
           {

               MessageBox.Show(this, "Error occured while loading", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
           }
        }

      

     


        private void rdbPartA_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbPartA.Checked == true)
            {
                Part = "A";
                Load_Formula(objBatch.BatchID, Part);
            }
        }

        private void rdbPartB_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbPartB.Checked == true)
            {
                Part = "B";
                Load_Formula(objBatch.BatchID, Part);
            }
        }

        private void rdbPartC_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbPartC.Checked == true)
            {
                Part = "C";
                Load_Formula(objBatch.BatchID, Part);
            }
        }

        private void rdbPartD_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbPartD.Checked == true)
            {
                Part = "D";
                Load_Formula(objBatch.BatchID, Part);
            }
        }

        private void btnWeigh_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult theResult = new DialogResult();

                theResult = MessageBox.Show(this, "Did you finish the weighing of this Part", "Confirmation", MessageBoxButtons.YesNo);

                if (theResult == System.Windows.Forms.DialogResult.Yes)
                {

                    objBatchFormulaMaterial_DL.Update_Weigh(objBatch.BatchID, Part, CurrentUser.EmployeeID);

                    Load_Formula(objBatch.BatchID, Part);
                }
                
            }
            catch (Exception)
            {

                MessageBox.Show(this, "Error occured while loading Batch List", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cmbEmployee_KeyUp(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Enter)
            {
                if (rdbOutsource.Checked == true)
                {
                    txtNos.Select();
                }
                else
                {
                    txtFrom.Select();
                }
            }
        }

        private void txtFrom_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtTo.Select();
            }
        }

        private void txtTo_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtOT.Select();
            }
        }


        private void SaveRecord()
        {
            try
            {

                Decimal OTHours = 0;
                Decimal OTMinutes = 0;

                if (txtOT.Text != "")
                {
                    OTHours = Convert.ToDecimal(txtOT.Text);
                }
                if (txtOTMinutes.Text != "")
                {
                    OTMinutes = Convert.ToDecimal(txtOTMinutes.Text);
                }


                BatchLabourDetails obj = new BatchLabourDetails();
                obj.BatchAct = objBatchActivity;
                obj.Emp = objEmployee_DL.Get(cmbEmployee.SelectedValue.ToString());
                obj.OTHours = Calculate.CalOTHours(OTHours, OTMinutes);
                obj.WorkStart = txtFrom.Text;
                obj.WorkStop = txtTo.Text;


                if (rdbOutsource.Checked == true)
                {
                    int theCount = Convert.ToInt32(txtNos.Text);

                    for (int i = 0; i < theCount; i++)
                    {
                        objBatchLabourDetails_DL.Add(obj);
                    }
                }
                else
                {
                    objBatchLabourDetails_DL.Add(obj);
                }



            }
            catch (Exception)
            {

                MessageBox.Show(this, "Error occured while loading Batch List", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void Load_employee()
        {
            try
            {
                if (rdbPermanentAll.Checked==true)
                {

                    DataTable dt = objEmployee_DL.Get_Workers();
                    objSourceEmployee.DataSource = dt;
                    cmbEmployee.DataSource = objSourceEmployee;
                }
                else if (rdbPermanentSection.Checked == true)
                {
                    DataTable dt = objEmployee_DL.Get_Workers_BySection(Convert.ToInt32(objSection.SectionID));
                    objSourceEmployee.DataSource = dt;
                    cmbEmployee.DataSource = objSourceEmployee;
                }
                else
                {
                    DataTable dt = objEmployee_DL.Get_Workers_Outsource(Convert.ToInt32(objSection.SectionID));
                    objSourceEmployee.DataSource = dt;
                    cmbEmployee.DataSource = objSourceEmployee;
                }
            }
            catch (Exception)
            {

                MessageBox.Show(this, "Error occured while loading Batch List", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void Load_LabourDetails()
        {
            try
            {
                if (objBatchActivity != null)
                {

                    DataTable dt = objBatchLabourDetails_DL.Get_ByBatchActID(Convert.ToInt32(objBatchActivity.BatchActID));

                    dgvEmployeeDetails.AutoGenerateColumns = false;
                    objSourceLabour.DataSource = dt;
                    dgvEmployeeDetails.DataSource = objSourceLabour;
                    objSourceLabour.ResetBindings(true);
                }

            }
            catch (Exception)
            {

                MessageBox.Show(this, "Error occured while loading Batch List", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }


        private void txtOT_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtOTMinutes.Select();

            }
        }

        
        private void rdbPermanentSection_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbOutsource.Checked == true)
            {
                txtNos.ReadOnly = false;
            }
            else
            {
                txtNos.ReadOnly = true;
            }
            Load_Sections();

            Load_employee();
        }

        private void rdbOutsource_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbOutsource.Checked == true)
            {
                txtNos.ReadOnly = false;
            }
            else
            {
                txtNos.ReadOnly = true;
            }

            Load_employee();
        }

        private void rdbPermanentAll_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbOutsource.Checked == true)
            {
                txtNos.ReadOnly = false;
            }
            else
            {
                txtNos.ReadOnly = true;
            }
            Load_employee();
        }

        private void txtNos_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtFrom.Select();
            }
        }

        private void txtOTMinutes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SaveRecord();
                Load_LabourDetails();

                txtFrom.Text = "";
                txtTo.Text = "";
                txtOT.Text = "";
                txtNos.Text = "";
                txtOTMinutes.Text = "";

                cmbEmployee.Select();
            }
        }

        private void btnMultiple_Click(object sender, EventArgs e)
        {
            try
            {
                frmMultipleLabour objForm = new frmMultipleLabour(objBatchActivity, Convert.ToInt32(cmbSection.SelectedValue));
                objForm.ShowDialog(this);

                Load_LabourDetails();
            }
            catch (Exception)
            {

                MessageBox.Show(this, "Error occured while loading Labour Details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Load_Sections()
        {
            try
            {

                dtSections = objSection_DL.GetDataView();

                objSourceSections.DataSource = dtSections;
                cmbSection.DataSource = objSourceSections;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }



        private void cmbSections_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                objSection = objSection_DL.Get(Convert.ToInt32(cmbSection.SelectedValue));

                Load_employee();

                Load_LabourDetails();
            }
            catch (Exception)
            {

                MessageBox.Show(this, "Error occured while loading Labour Details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvEmployeeDetails_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {

                if (objBatchActivity.BatchActStatus == BatchActivity.Status.Finished)
                {
                    MessageBox.Show(this, "This Activity Is Finished.", "Wrong Attempt", MessageBoxButtons.OK);
                }
                else
                {
                    BatchLabourDetails obj = new BatchLabourDetails();

                    objBatchLabourDetails_DL.Delete(Convert.ToInt32(dgvEmployeeDetails.CurrentRow.Cells["LabourRecID"].Value));

                    Load_LabourDetails();
                }


            }
        }

     

      


    }
}