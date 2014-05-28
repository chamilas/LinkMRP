using DL;
using MRP_GUI.Sales;
using SESD.MRP.REF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MRP_GUI
{
    public partial class frmStockAdjustment : System.Windows.Forms.Form
    {
        private Customer_DL objCustomer_DL = new Customer_DL(ConnectionStringClass.GetConnection());
        private Department_DL objDepartmentDL = new Department_DL(ConnectionStringClass.GetConnection());
        MTN objMTN = new MTN();
        MTNFinishProduct_DL objMTNFinisProductDL = new MTNFinishProduct_DL(ConnectionStringClass.GetConnection());

        MTNFinishProduct objMTNFinish = new MTNFinishProduct();
        MTN_DL objMTNDL = new MTN_DL(ConnectionStringClass.GetConnection());
        FinishProduct objFinishProduct = new FinishProduct();
        FinishProduct_DL objFinishProductDL = new FinishProduct_DL(ConnectionStringClass.GetConnection());
        DataTable dtFinishProductList = new DataTable();

        Department objDepFrom = new Department();
        Department objDepTo = new Department();

        String Category = "none";
        String ProductType = "none";
        String CurrStore = "none";

        public frmStockAdjustment(User objUser, String tProductType, String tCategory,String tstore)
        {
            Category = tCategory;
            ProductType = tProductType;
            CurrentUser = objUser;
            CurrStore = tstore;
            InitializeComponent();

        }

        private User _objCurrentUser;

        public User CurrentUser
        {
            get { return _objCurrentUser; }
            set { _objCurrentUser = value; }
        }

        private void frmStockAdjustment_Load(object sender, EventArgs e)
        {
            txtType.Text = Category;
            txtStore.Text = CurrStore;
            LoadFinishProductList();
        }

        private void LoadFinishProductList()
        {
            try
            {
                cmbProduct.Items.Clear();
                dtFinishProductList = objCustomer_DL.GetFinishProduct(ProductType);
                bsFinishProductList.DataSource = dtFinishProductList;
                cmbProduct.DataSource = bsFinishProductList;
            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            String temptxtProduct = dtFinishProductList.Rows[cmbProduct.SelectedIndex].ItemArray[0].ToString();
            if (txtQuantity.Text != "" && DataValidation.IsNumericNumber(txtQuantity.Text))
            {
                bool availability = false;
                foreach (DataGridViewRow row2 in dgvProduct.Rows)
                {
                    String tempcheckproduct = row2.Cells[1].Value.ToString();
                    if (tempcheckproduct == temptxtProduct)
                    {
                        availability = true;
                        //break;
                    }
                }
                if (dgvProduct.Rows.Count == 0 || !availability)
                {
                    dgvProduct.Rows.Add(cmbProduct.SelectedValue.ToString(), temptxtProduct, txtQuantity.Text, txtStore.Text);
                }
                else
                {
                    MessageBox.Show(this, "Product is already added", "MRP System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show(this, "please insert valid quantity", "Blank Fields", MessageBoxButtons.OK, MessageBoxIcon.Stop);
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void clear()
        {
            txtQuantity.Text = "0";
            dgvProduct.Rows.Clear();
            dgvProduct.Refresh();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Store objStore = new Store();
            objStore.StoreID = CurrStore;
            objDepTo = objDepartmentDL.Get(25);
            objDepFrom = objDepartmentDL.Get(25);

            //objMTN.MTNDate = DateTime.Now;
            //objMTN.MTNApprovedBy = null;
            objMTN.MTNDepartmentFrom = objDepFrom;
            objMTN.MTNDepartmentTo = objDepTo;
            objMTN.MTNEnterdBy = CurrentUser.UserEmp;
            objMTN.MTNStatus = MTN.Status.Initial;
            objMTN.MTNType = MTN.Type.Dispose;
            objMTN.MTNStore = objStore;
            objMTN.MTNItemType = MTN.ItemType.Finish_Product;

            objMTN.MTNItemType = MTN.ItemType.Finish_Product;

            objMTN.MTNNo = objMTNDL.Add_FinishedGoodsReturns(objMTN);
            

            //objMTN.MTNNo = 
                //objMTNDL.Add(objMTN);

            if (objMTN.MTNNo > 0)
            {
                foreach (DataGridViewRow dr in dgvProduct.Rows)
                {
                    String tempproductCode = dr.Cells[0].Value.ToString();
                    String tempproduct = dr.Cells[1].Value.ToString();
                    long tempqty = Convert.ToInt64(dr.Cells[2].Value.ToString());
                    string tempstore = dr.Cells[3].Value.ToString();


                    objFinishProduct = objFinishProductDL.Get(tempproductCode);
                    //objMTNFinish.Batch = "No";
                    //objMTNFinish.Description = "No";
                    objMTNFinish.FinishProduct = objFinishProduct;
                    objMTNFinish.MTN = objMTN;
                    objMTNFinish.ReceivedQty = 0;
                    objMTNFinish.UnitRate = 0;
                    objMTNFinish.UnitRate_Budget = 0;
                    objMTNFinish.TransferQty = tempqty;
                    objMTNFinisProductDL.Add(objMTNFinish);
                }
                MessageBox.Show(this, "Successfully Saved, MTN No is " + objMTN.MTNNo, "Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

    }
}
