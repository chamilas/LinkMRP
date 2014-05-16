using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SESD.MRP.REF;
using DL;
using MRP_GUI.Sales;

namespace MRP_GUI
{
    public partial class frmIssueFinishedGoods : System.Windows.Forms.Form
    {
        public frmIssueFinishedGoods(User _objUser,string _StoreID,string _productCategory)
        {
            InitializeComponent();
            CurrentUser = _objUser;
            StoreID = _StoreID;
            ProductCategory = _productCategory;
        }

        User CurrentUser = new User();
        string StoreID = "";
        string ProductCategory = "";
        FinishProduct_DL objFinishProduct_DL = new FinishProduct_DL(ConnectionStringClass.GetConnection());
        Distributor_DL objDistributor_DL = new Distributor_DL(ConnectionStringClass.GetConnection());
        DispathcNoteListCollec objCollec = new DispathcNoteListCollec();

        DataTable dtProducts = new DataTable();
        DataTable dtDistributors = new DataTable();

       

        private void frmIssueFinishedGoods_Load(object sender, EventArgs e)
        {
            Load_Products();
            Load_Distributors();
        }

        private void Load_Products()
        {
            try
            {

                dtProducts = objFinishProduct_DL.GetData_ByCategory(true,ProductCategory);

                objsourceProducts.DataSource = dtProducts;
                cmbProductCode.DataSource = objsourceProducts;
            }
            catch (Exception ex)
            {

            }
        }

        private void Load_Distributors()
        {
            try
            {
                dtDistributors = objDistributor_DL.GetData();

                SourceDistributor.DataSource = dtDistributors;
                cmbDistributor.DataSource = SourceDistributor;
            }
            catch (Exception ex)
            {

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DispatchNoteList objRemove = new DispatchNoteList();
           
            DispatchNoteList obj = new DispatchNoteList();


            if ((txtDiaptchNote.Text != "") && (cmbProductCode.SelectedValue != null) && (txtIssuedQty.Text != ""))
            {
                if (DataValidation.IsNumericNumber(txtIssuedQty.Text))
                {
                    if (txtBatchID.Text != "")
                    {
                        obj.BatchNo = txtBatchID.Text;

                    }
                    else
                    {
                        obj.BatchNo = "No";
                    }

                    obj.DispatchID = txtDiaptchNote.Text;
                    obj.FinishProduct = Convert.ToString(cmbProductCode.SelectedValue);
                    obj.Qty = Convert.ToUInt32(txtIssuedQty.Text);
                    obj.ProductName = objFinishProduct_DL.Get(obj.FinishProduct).FinishProductDescription;

                    objCollec.Add(obj);
                }
                else 
                {
                    MessageBox.Show(this, "please enter valid quantity", "MRP System", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Please Fill All Fields");
            }

            gvProductList.AutoGenerateColumns = false;
            objSource.DataSource = objCollec;
            gvProductList.DataSource = objSource;
            objSource.ResetBindings(true);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                DispatchNote_DL objDispatchNote_DL = new DispatchNote_DL(ConnectionStringClass.GetConnection());
                DispatchNoteList_DL objDispatchNoteList_DL = new DispatchNoteList_DL(ConnectionStringClass.GetConnection());

                DispatchNote objDispatchNote = new DispatchNote();
                objDispatchNote.DispatchID = txtDiaptchNote.Text;
                objDispatchNote.DistributorID = cmbDistributor.SelectedValue.ToString();
                objDispatchNote.EnteredBy = CurrentUser.EmployeeID;

                int x=objDispatchNote_DL.Add(objDispatchNote);

                if (x > 0)
                {
                    foreach (DispatchNoteList _obj in objCollec)
                    {
                        objDispatchNoteList_DL.Add(_obj,StoreID);

                    }

                    MessageBox.Show("Successfully Saved");

                    Clear_Data();

                }

            }
            catch (Exception ex)
            {

            }

        }


        private void Clear_Data()
        {
                try
                {
                    objCollec = null;

                    gvProductList.AutoGenerateColumns = false;
                    objSource.DataSource = objCollec;
                    gvProductList.DataSource = objSource;
                    objSource.ResetBindings(true);

                    txtBatchID.Text = "";
                    txtDiaptchNote.Text = "";
                    txtIssuedQty.Text = "";
                }
                catch (Exception ex)
                {

                }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

    }
}
