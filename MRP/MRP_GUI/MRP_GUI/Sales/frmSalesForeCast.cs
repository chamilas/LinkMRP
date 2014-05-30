using DL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SESD.MRP.REF;
using System.Globalization;

namespace MRP_GUI.Sales
{
    public partial class frmSalesForeCast : System.Windows.Forms.Form
    {
        DataTable dtCheck = new DataTable();
        private User _objCurrentUser;
        private String CurrentProductType;
        public User CurrentUser
        {
            get { return _objCurrentUser; }
            set { _objCurrentUser = value; }
        }

        private Customer_DL objCustomer_DL = new Customer_DL(ConnectionStringClass.GetConnection());
        private Distributor_DL objDistributor_DL = new Distributor_DL(ConnectionStringClass.GetConnection());
        private PlanMaterials_DL objPlanMaterials_DL = new PlanMaterials_DL(ConnectionStringClass.GetConnection());
        private SalesForeCast_DL objSalesForeCast_DL = new SalesForeCast_DL(ConnectionStringClass.GetConnection());
        private SalesForecast objSalesForeCast = new SalesForecast();

        private SalesForecastDetails_DL objSalesForecastDetails_DL = new SalesForecastDetails_DL(ConnectionStringClass.GetConnection());
        private SalesForecastDetails objSalesForecastDetails = new SalesForecastDetails();

        DataTable dtDistributorsList = new DataTable();
        DataTable dtFinishProductList = new DataTable();

        public frmSalesForeCast(User objUser,String ProductType)
        {
            CurrentUser = objUser;
            CurrentProductType = ProductType;
            InitializeComponent();
            LoadFinishProductList();
            //LoadDistributorsList();
            
        }

        private void frmSalesForeCast_Load(object sender, EventArgs e)
        {
            cmbYear.Text = DateTime.Today.Year.ToString();
            cmbMonth.Text = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(DateTime.Today.Month);
            //cmbForcastedIn.Text = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(DateTime.Today.Month);
            cmbWeekNo.Text = "1";
        }

        private void LoadFinishProductList()
        {
            try
            {
                cmbProductList.Items.Clear();
                dtFinishProductList = objCustomer_DL.GetFinishProduct(CurrentProductType);
                bsFinishProductList.DataSource = dtFinishProductList;
                cmbProductList.DataSource = bsFinishProductList;
                //cmbWeekNo.SelectedIndex = 0;
                //cmbMonth.SelectedIndex = 0;
                //cmbYear.SelectedIndex = 0;
            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddToList_Click(object sender, EventArgs e)
        {
            //String temptxtProduct = dtFinishProductList.Rows[cmbProductList.SelectedIndex].ItemArray[0].ToString();
            
            if (txtQty.Text != "" && DataValidation.IsNumericNumber(txtQty.Text))
            {
                //dgvProduct.Rows.Add(cmbProductList.Text, txtQty.Text);
                bool availability = false;
                foreach (DataGridViewRow row2 in dgvProduct.Rows)
                {
                    String tempcheckproduct = row2.Cells[0].Value.ToString();
                    if (tempcheckproduct == cmbProductList.Text)
                    {
                        availability = true;
                        //break;
                    }
                }
                if (dgvProduct.Rows.Count == 0 || !availability)
                {
                    String temptxtProduct = dtFinishProductList.Rows[cmbProductList.SelectedIndex].ItemArray[0].ToString();
                    dgvProduct.Rows.Add(cmbProductList.Text, cmbProductList.SelectedValue.ToString(), txtQty.Text);
                }
                else
                {
                    MessageBox.Show("Product is already added");
                }


            }
            else
            {
                MessageBox.Show("please insert valid quantity");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvProduct.SelectedRows.Count > 0)
            {
                DialogResult dr = MessageBox.Show(this, "Are you sure, You want to Delete selected Record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    foreach (DataGridViewRow item in this.dgvProduct.SelectedRows)
                    {
                        dgvProduct.Rows.RemoveAt(item.Index);
                    }
                }
            }
            else
            {
                MessageBox.Show(this, "please select a record to delete", "MRP System", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dgvProduct.Rows.Count > 0)
            {
                objSalesForeCast.RevisionNo = 0;
                objSalesForeCast.Year = Convert.ToInt32(cmbYear.Text); //Convert.ToInt32(dtpDate.Value.Date.Year.ToString());
                objSalesForeCast.Month = cmbMonth.Text;//CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(dtpDate.Value.Date.Month);
                objSalesForeCast.State = 0;
                objSalesForeCast.WeekID = Convert.ToInt32(cmbWeekNo.Text);
                objSalesForeCast.Accuracy = "none";
                objSalesForeCast.Date = System.DateTime.Now.ToLocalTime();
                objSalesForeCast.EenteredBy = CurrentUser.UserEmp.EmployeeID;
                long SalesForeCastID= objSalesForeCast_DL.Add(objSalesForeCast);

                int x = 0;
                foreach (DataGridViewRow dr in dgvProduct.Rows)
                {
                    //String temptxtProduct = dtFinishProductList.Rows[x].ItemArray[0].ToString();
                    String temptxtProduct = dr.Cells[1].Value.ToString();
                    long tempqty = Convert.ToInt64(dr.Cells[2].Value.ToString());

                    objSalesForecastDetails.SalesForecastID = Convert.ToInt32(SalesForeCastID);
                    objSalesForecastDetails.RevisionID = 0;
                    objSalesForecastDetails.ProductCode = temptxtProduct;
                    objSalesForecastDetails.Qty = Convert.ToInt32(tempqty);
                    objSalesForecastDetails_DL.Add(objSalesForeCast, objSalesForecastDetails);
                    //objCustomer_DL.test(objSalesForeCast, objSalesForecastDetails);
                    x++;
                }
                MessageBox.Show(this, "Sales Forecast Details successfully added", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear();
            }
            else
            {
                MessageBox.Show(this, "Please add product to Product list", "Blank Fields", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        public static int GetWeekNumber(DateTime dtPassed)
        {
            CultureInfo ciCurr = CultureInfo.CurrentCulture;
            int weekNum = ciCurr.Calendar.GetWeekOfYear(dtPassed, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
            return weekNum;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void clear() 
        {
            dgvProduct.Rows.Clear();
            dgvProduct.Refresh();
            txtQty.Text = "";
        }

        private void CheckPackingPaterial(int Year, string Month, int Week)
        {
            dtCheck = objPlanMaterials_DL.CkeckPackingMaterialsForecast(Year, Month, Week);
            if (dtCheck.Rows.Count > 0)
            {
                int revID = Convert.ToInt32(dtCheck.Rows[0]["RevisionNo"].ToString());
                DateTime Date = Convert.ToDateTime(dtCheck.Rows[0]["EnteredDate"].ToString());
                String StringDate = Date.ToString("yyyy-MM-dd");
                if (revID == 0) 
                {
                    txtRevID.Text = "Annual Forecast Available";
                    txtEnteredDate.Text = StringDate;
                }
                else if (revID == 1) 
                {
                    txtRevID.Text = "Forcast for 1st Month Available";
                    txtEnteredDate.Text = StringDate;
                }
                else if (revID == 2)
                {
                    txtRevID.Text = "Forcast for 2st Month Available";
                    txtEnteredDate.Text = StringDate;
                }
                else 
                {
                    txtRevID.Text = "Error";
                    txtEnteredDate.Text = "Error";
                }
            }
            else 
            {
                txtRevID.Text = "No Forecast";
                txtEnteredDate.Text = "No Data";
            }
        }

        private void cmbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbYear.SelectedIndex != -1 && cmbMonth.SelectedIndex != -1 && cmbWeekNo.SelectedIndex != -1)
            {
                CheckPackingPaterial(Convert.ToInt32(cmbYear.Text), cmbMonth.Text, Convert.ToInt32(cmbWeekNo.Text));
            }
        }
        private void cmbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbYear.SelectedIndex != -1 && cmbMonth.SelectedIndex != -1 && cmbWeekNo.SelectedIndex != -1)
            {
                CheckPackingPaterial(Convert.ToInt32(cmbYear.Text), cmbMonth.Text, Convert.ToInt32(cmbWeekNo.Text));
            }
        }

        private void cmbWeekNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbYear.SelectedIndex != -1 && cmbMonth.SelectedIndex != -1 && cmbWeekNo.SelectedIndex != -1)
            {
                CheckPackingPaterial(Convert.ToInt32(cmbYear.Text), cmbMonth.Text, Convert.ToInt32(cmbWeekNo.Text));
            }
        }
    }
}
