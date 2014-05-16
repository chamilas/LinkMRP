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
    public partial class frmCosting : System.Windows.Forms.Form
    {
        Sections objSelectedSections = new Sections();
        private User _objCurrentUser;

        public User CurrentUser
        {
            get { return _objCurrentUser; }
            set { _objCurrentUser = value; }
        }

        public frmCosting(User ObjUser)
        {
            CurrentUser = ObjUser;
            InitializeComponent();

        }
        public frmCosting()
        {

            InitializeComponent();
        }
        CompanyOverHeadRate objCompanyOverHeadRate;
        CompanyOverHeadRate_DL objCompanyOverHeadRate_DL = new CompanyOverHeadRate_DL(ConnectionStringClass.GetConnection());

        private void frmCosting_Load(object sender, EventArgs e)
        {
            StockHoldingRate_DL objStockHoldingRateDL = new StockHoldingRate_DL(ConnectionStringClass.GetConnection());
            Employee_DL objEmpDL = new Employee_DL(ConnectionStringClass.GetConnection());
            Department_DL objDepDL = new Department_DL(ConnectionStringClass.GetConnection());
            Section_DL objSection_DL = new Section_DL(ConnectionStringClass.GetConnection());
 
            try
            {
                StockHoldingRate obj = new StockHoldingRate();
                obj = objStockHoldingRateDL.GetFinal();
                Employee objChangedBy = objEmpDL.Get(obj.ChangedBy);
                txtEnterdBy.Text = objChangedBy.EmployeeName;
                txtEnterdDate.Text = obj.FromDate.Value.ToShortDateString();
                txtCurrentRate.Text = obj.Cost.ToString();
                bindStockHolding.DataSource = objStockHoldingRateDL.Get();

                bindDepartment.DataSource = objSection_DL.GetDataView();
                objCompanyOverHeadRate = objCompanyOverHeadRate_DL.Get();

                if (objCompanyOverHeadRate != null)
                {
                    txtComDate.Text = objCompanyOverHeadRate.EnterdDate.ToShortDateString();
                    txtComEnterd.Text = objCompanyOverHeadRate.EnterdBy.EmployeeNameID;
                    txtComRate.Text = objCompanyOverHeadRate.Rate.ToString();
                }

            }
            catch (Exception ex)
            {
                
               MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            StockHoldingRate_DL objStockHoldingRateDL = new StockHoldingRate_DL(ConnectionStringClass.GetConnection());
            Employee_DL objEmpDL = new Employee_DL(ConnectionStringClass.GetConnection());
            try
            {
                if (!txtNewRate.Text.Equals(""))
                {
                    DialogResult dr = MessageBox.Show(this, "Are you sure you want to change current Stock Holding Rate?\nChanging the rate cannot be Undo, Click Yes to continue, No to cancel", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                    if (dr == DialogResult.Yes)
                    {
                        StockHoldingRate objNewStockHoldingRate = new StockHoldingRate();
                        objNewStockHoldingRate.Cost = Convert.ToDecimal(txtNewRate.Text);
                        objNewStockHoldingRate.ChangedBy = CurrentUser.EmployeeID;
                        objNewStockHoldingRate.FromDate = DateTime.Now;
                        objNewStockHoldingRate.ToDate = DateTime.Now;
                        objStockHoldingRateDL.Add(objNewStockHoldingRate);

                        StockHoldingRate obj = new StockHoldingRate();
                        obj = objStockHoldingRateDL.GetFinal();
                        Employee objChangedBy = objEmpDL.Get(obj.ChangedBy);
                        txtEnterdBy.Text = objChangedBy.EmployeeName;
                        txtEnterdDate.Text = obj.FromDate.Value.ToShortDateString();
                        txtCurrentRate.Text = obj.Cost.ToString();
                        bindStockHolding.DataSource = objStockHoldingRateDL.Get();

                        gvStockHoldingRates.CurrentCell = gvStockHoldingRates[1, gvStockHoldingRates.Rows.Count - 1];
                        gvStockHoldingRates.FirstDisplayedScrollingRowIndex = gvStockHoldingRates.Rows.Count - 1;
                    }
                }
                else
                {
                    MessageBox.Show(this,"Please enter a value as a New Rate","Empty Fields",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void txtNewRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar) || (e.KeyChar == (char)46)))
            {
                e.Handled = true;
            }
        }

        private void cmbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSaveDep_Click(object sender, EventArgs e)
        {
            try
            {
                Section_DL objSection_DL = new Section_DL(ConnectionStringClass.GetConnection());
                Department_DL objDepDL = new Department_DL(ConnectionStringClass.GetConnection());
                OverheadRates objOverheadRates = new OverheadRates();
                OverheadRates_DL objOverheadRates_DL = new OverheadRates_DL(ConnectionStringClass.GetConnection());
                Employee_DL objEmpDL = new Employee_DL(ConnectionStringClass.GetConnection());
                if (objSelectedSections.DepID != 0)
                {
                    Sections objSections = objSelectedSections;

                    if (textBox1.Text != "")
                    {
                        if (objSections.DepID != 0)
                        {
                            objOverheadRates.SectionID = objSections.SectionID;
                            objOverheadRates.EnterdBy = CurrentUser.EmployeeID;
                            objOverheadRates.EnterdDate = DateTime.Now;
                            objOverheadRates.Rate = Convert.ToDecimal(textBox1.Text);

                            objOverheadRates_DL.Add(objOverheadRates);


                            ClearDep();
                            bindDepartment.DataSource = objSection_DL.GetDataView();
                        }
                    }
                    else
                    {
                        MessageBox.Show(this, "Please enter a valid Overhead Rate", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                else
                {
                    MessageBox.Show(this, "Please Select a Department from the list", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            catch (Exception )
            {

                MessageBox.Show(this,"Error occured while saving overhead rate","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void ClearDep()
        {
            textBox1.Text = "0.00";
            txtDepEnterdBy.Text = "N/A";
            txtDepEnterdDate.Text = "N/A";
            txtDID.Text = "N/A";
            txtDepartmentName.Text = "N/A";
            txtSection.Text = "N/A";
            txtDepCurrent.Text = "N/A";
            objSelectedSections = new Sections();
        }

        private void gvDepartment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Department_DL objDepDL = new Department_DL(ConnectionStringClass.GetConnection());
                Section_DL objSection_DL = new Section_DL(ConnectionStringClass.GetConnection());
                OverheadRates objOverheadRates = new OverheadRates();
                OverheadRates_DL objOverheadRates_DL = new OverheadRates_DL(ConnectionStringClass.GetConnection());
                Employee_DL objEmpDL = new Employee_DL(ConnectionStringClass.GetConnection());
                ClearDep();
                if (true)
                {
                    Sections objSection = objSection_DL.Get(Convert.ToInt64(gvDepartment.Rows[e.RowIndex].Cells["colDepID"].Value));
                    Department objDep = objDepDL.Get(objSection.DepID);
                    if (objDep.DepID != 0)
                    {
                        txtSection.Text = objSection.SectionName;
                        objSelectedSections = objSection;
                        txtDID.Text = objDep.DepID.ToString();
                        txtDepartmentName.Text = objDep.DepName;
                        objOverheadRates = objOverheadRates_DL.Get(objSection.SectionID);
                        if (objOverheadRates.SectionID != 0)
                        {
                            txtDepCurrent.Text = objOverheadRates.Rate.ToString();
                            Employee objEmp = objEmpDL.Get(objOverheadRates.EnterdBy);

                            txtDepEnterdBy.Text = objEmp.EmployeeName;
                            txtDepEnterdDate.Text = objOverheadRates.EnterdDate.ToShortDateString();

                        }
                    }



                }
            }
            catch (Exception)
            {

                MessageBox.Show(this,"Error occured","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void btnClearDep_Click(object sender, EventArgs e)
        {
            ClearDep();
        }

        private void btnComSave_Click(object sender, EventArgs e)
        {
            try
            {

                if (objCompanyOverHeadRate == null)
                {
                    objCompanyOverHeadRate = new CompanyOverHeadRate();
                }
                objCompanyOverHeadRate.Rate = Convert.ToDecimal(txtComRate.Text);
                objCompanyOverHeadRate.EnterdBy = CurrentUser.UserEmp;
                objCompanyOverHeadRate.EnterdDate = DateTime.Now;

                long id = objCompanyOverHeadRate_DL.Add(objCompanyOverHeadRate);

                if (id>0)
                {
                    objCompanyOverHeadRate.ID = id;
                }
                if (objCompanyOverHeadRate != null)
                {
                    txtComDate.Text = objCompanyOverHeadRate.EnterdDate.ToShortDateString();
                    txtComEnterd.Text = objCompanyOverHeadRate.EnterdBy.EmployeeNameID;
                    txtComRate.Text = objCompanyOverHeadRate.Rate.ToString();
                }
            }
            catch (Exception)
            {

                MessageBox.Show(this,"Error occured while saving Company Overhead rate","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
    }
}