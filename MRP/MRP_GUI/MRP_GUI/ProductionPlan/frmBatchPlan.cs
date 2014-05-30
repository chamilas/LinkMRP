﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Windows.Forms;
using DL;
using SESD.MRP.REF;

namespace MRP_GUI
{
    public partial class frmBatchPlan : System.Windows.Forms.Form
    {
        public frmBatchPlan(User objUser)
        {
            InitializeComponent();
            CurrentUser = objUser;
        }

        User CurrentUser = new User();

        ProductCategory_DL objProductCategory_DL = new ProductCategory_DL(ConnectionStringClass.GetConnection());
        BasicProduct_DL objBasicProducts_DL = new BasicProduct_DL(ConnectionStringClass.GetConnection());
        PlanWeek_DL objPlanWeek_DL = new PlanWeek_DL(ConnectionStringClass.GetConnection());
        PlanBatch_DL objPlanBatch_DL = new PlanBatch_DL(ConnectionStringClass.GetConnection());
        Department_DL objDepartment_DL = new Department_DL(ConnectionStringClass.GetConnection());
        Batch_DL objBatch_DL = new Batch_DL(ConnectionStringClass.GetConnection());

        SalesForeCast_DL objSalesForeCast_DL = new SalesForeCast_DL(ConnectionStringClass.GetConnection());

        DataTable dtCategoryList = new DataTable();
        DataTable dtBasicProductList = new DataTable();
        DataTable dtSTDBatchList = new DataTable();
        DataTable dtBatchPlanWeekly = new DataTable();
        DataTable dtWeeks = new DataTable();
        
        
        private void frmBatchPlan_Load(object sender, EventArgs e)
        {

            try

            {

                cmbYear.Text = DateTime.Today.Year.ToString();
                cmbMonth.Text = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(DateTime.Today.Month);

                dtCategoryList = objProductCategory_DL.GetDataView();

                if (dtCategoryList.Rows.Count != 0)
                {
                    objSourceCategoryList.DataSource = dtCategoryList;
                    cmbCategoryList.DataSource = objSourceCategoryList;
                }

                cmbCategoryList_SelectedIndexChanged(sender, e);



                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());

            }

        }

        public int LoadWeeks()
        {
            try
            {

                if ((cmbMonth.Text != "") && (cmbYear.Text != ""))
                {
                    dtWeeks = objPlanWeek_DL.GetDataByMonth_Fixed(Convert.ToInt32(cmbYear.Text), cmbMonth.Text);
                   dgvWeeks.AutoGenerateColumns = false;
                   objSourceWeeks.DataSource = dtWeeks;
                   dgvWeeks.DataSource = objSourceWeeks;
                   objSourceWeeks.ResetBindings(true);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());

            }

            return 0;

        }

        private void cmbCategoryList_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                

                if (cmbCategoryList.SelectedValue != null)
                {
                    dtBasicProductList = objBasicProducts_DL.GetDataView_By_Category(cmbCategoryList.SelectedValue.ToString());
                }

               if (dtBasicProductList.Rows.Count != 0)
               {
                   objSourceBasicProductList.DataSource = dtBasicProductList;
                   lstBasicProductList.DataSource = objSourceBasicProductList;

               }
               


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());

            }



            
        }


        private void cmbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Refresh_Data();
            LoadWeeks(); 
            //GetMonthlyPlanningID();

        }




        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                PlanBatch obj = new PlanBatch();

                obj.BatchSize = Convert.ToDecimal(txtBatchSize.Text);
                obj.WeekID = Convert.ToInt32(dgvWeeks.CurrentRow.Cells["WeekIDD"].Value);
                obj.Month = Convert.ToString(cmbMonth.Text);
                obj.Nos = Convert.ToInt32(txtNos.Text);
                obj.ProductCode = lstBasicProductList.SelectedValue.ToString();
                obj.Year = Convert.ToInt32(cmbYear.Text);
                obj.RevisionID = Convert.ToInt32(dgvWeeks.CurrentRow.Cells["RevisionID"].Value);
                obj.Status = 0;
                obj.BatchLevel = 0;

                objPlanBatch_DL.Add(obj);
                Load_Data();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());

            }
        }

        private void Load_Data()
        {
            try
            {
            
                if ((cmbYear.Text != "") && (cmbMonth.Text != ""))
                {

                    dtBatchPlanWeekly = objPlanBatch_DL.Get(Convert.ToInt32(cmbYear.Text), cmbMonth.Text,
                        Convert.ToInt32(dgvWeeks.CurrentRow.Cells["WeekIDD"].Value), Convert.ToInt32(dgvWeeks.CurrentRow.Cells["RevisionID"].Value));

                       dgvBatchList.AutoGenerateColumns = false;
                       objSourceBatchListWeekly.DataSource = dtBatchPlanWeekly;
                       dgvBatchList.DataSource = objSourceBatchListWeekly;
                       objSourceBatchListWeekly.ResetBindings(true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());

            }


        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                Batch obj = new Batch();
                DialogResult Result = new DialogResult();

                Result = MessageBox.Show(this, "Are You Sure You want to Delete ", "Please Verify", MessageBoxButtons.YesNo);

                if (Result == DialogResult.Yes)
                {
                    objPlanBatch_DL.Delete(Convert.ToInt32(cmbYear.Text), cmbMonth.Text,
                        Convert.ToInt32(dgvBatchList.CurrentRow.Cells["Week"].Value),
                        Convert.ToInt32(dgvBatchList.CurrentRow.Cells["RevisionIDD"].Value),
                        Convert.ToString(dgvBatchList.CurrentRow.Cells["Product"].Value));

                    Load_Data();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());

            }
        }

        private void cmbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadWeeks();
           // Refresh_Data();
           // GetMonthlyPlanningID();
             

        }

        private void Refresh_Data()
        {
            objSourceBatchListWeekly.DataSource = null;
            objSourceBatchListWeekly.ResetBindings(true);
        }


        private void lstBasicProductList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("" + lstBasicProductList.Text);
            //if (dgvWeeks.RowCount > 0)
            //{
           //     long cc = objSalesForeCast_DL.GetBasicProductForecastByBPandDate(Convert.ToInt16(cmbYear.Text), cmbMonth.Text, Convert.ToInt16(dgvWeeks.CurrentRow.Cells["WeekIDD"].Value), lstBasicProductList.SelectedValue.ToString());
              //  //MessageBox.Show(""+cc);
               // lblAvailability.Text = ""+cc;
           // }
          //  else 
          //  {
            //    lblAvailability.Text = "000";
            //    MessageBox.Show(this, "Please Select week", "Blank Fields", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        //    }
        }

        private void cmbBatchSize_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cmbBatchSize_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                txtBatchSize.Select();
            }
        }

        private void dgvWeeks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            long cc = objSalesForeCast_DL.GetBasicProductForecastByBPandDate(Convert.ToInt16(cmbYear.Text), cmbMonth.Text, lstBasicProductList.SelectedValue.ToString());
            String unit = dtBasicProductList.Rows[lstBasicProductList.SelectedIndex]["UnitCode"].ToString();
            lblAvailability.Text = "Forecasted Requirement: " + cc + " " + unit;
            Load_Data();

        }

    }
}
