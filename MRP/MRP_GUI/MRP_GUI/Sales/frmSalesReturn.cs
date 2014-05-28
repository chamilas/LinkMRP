using DL;
using SESD.MRP.REF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MRP_GUI.Sales
{
    public partial class frmSalesReturn : System.Windows.Forms.Form
    {
        private Customer_DL objCustomer_DL = new Customer_DL(ConnectionStringClass.GetConnection());
        private Store_DL objStoreDL = new Store_DL(ConnectionStringClass.GetConnection());
        GRN_DL objGRNDL = new GRN_DL(ConnectionStringClass.GetConnection());
        GRN_Payment_DL objGRN_Payment_DL = new GRN_Payment_DL(ConnectionStringClass.GetConnection());
        //FinishProduct_DL objFinishProductDL = new FinishProduct_DL(ConnectionStringClass.GetConnection());
        GRNFinishProducts_DL objGRNFinishProductDL = new GRNFinishProducts_DL(ConnectionStringClass.GetConnection());
        FinishGoodsReturn_DL objFinishGoodsReturn_DL = new FinishGoodsReturn_DL(ConnectionStringClass.GetConnection());
        

        GRN objGRN = new GRN();
        Store objStore = new Store();
        GRN_Payment objGRN_Payment = new GRN_Payment();
        GRNFinishProducts objGRNFinishProduct = new GRNFinishProducts();
        FinishProduct objFinishProduct = new FinishProduct();

        DataTable dtCustomers = new DataTable();

        DataTable dtCustomerTerritory = new DataTable();
        DataTable dtFinishProductList = new DataTable();
        String ProductType = "none";
        String CurrStore = "none";

        public frmSalesReturn(User objUser, String tProductType,String tStore)
        {
            ProductType = tProductType;
            CurrentUser = objUser;
            CurrStore = tStore;
            InitializeComponent();
        }

        private User _objCurrentUser;

        public User CurrentUser
        {
            get { return _objCurrentUser; }
            set { _objCurrentUser = value; }
        }

        private void frmSalesReturn_Load(object sender, EventArgs e)
        {
            txtSalesType.Text = ProductType;
            txtStore.Text = CurrStore;
            //Load_CustomerTerritory();
            LoadFinishProductList();
            
            ///cmbTerritory.DataSource = null;
            //cmbTerritory.Items.Clear();
            cmbTerritory.Enabled = false;
            LoadCustomers();
        }

        private void LoadCustomers()
        {
            try
            {
                cmbCustomer.DataSource = null;
                cmbCustomer.Items.Clear();
                dtCustomers = objCustomer_DL.GegCustomerBySalesMethod("Distributor");
                cmbCustomer.DataSource = dtCustomers;
                cmbCustomer.BindingContext = this.BindingContext;
                cmbCustomer.DisplayMember = "Customer";
                cmbCustomer.ValueMember = "CustomerID";

            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
/*
        private void Load_CustomerTerritory()
        {

            try
            {
                cmbTerritory.Items.Clear();
                dtCustomerTerritory = objCustomer_DL.GetDistributorTerritory("test");
                cmbTerritory.DataSource = dtCustomerTerritory;
                cmbTerritory.BindingContext = this.BindingContext;

            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
*/
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
            cmbTerritory.DataSource = null;
            cmbTerritory.Items.Clear();
            txtQuantity.Text = "0";
            dgvProduct.Rows.Clear();
            dgvProduct.Refresh();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (cmbTerritory.SelectedIndex != -1)
            {
                try
                {
                    if (dgvProduct.Rows.Count > 0)
                    {

                        objStore = objStoreDL.Get(txtStore.Text);

                        objGRN.GRNApprovedBy = "N/A";
                        objGRN.GRNApprovedDate = DateTime.Now;
                        objGRN.GRNDate = DateTime.Now;
                        objGRN.GRNEnterdBy = CurrentUser.UserEmp.EmployeeID;
                        objGRN.GRNType = GRN.Type.FinishProduct;
                        // objGRN.GRNMR = objMR;
                        //objGRN.GRNMTNNo = objMTN;
                        objGRN.GRNRPDBatch = "N/A";

                        objGRN.GRNStatus = GRN.Status.Initial;
                        objGRN.GRNStore = objStore;
                        objGRN.GRNCategory = 0;


                        objGRN_Payment.InvoiceNo = "N/A";
                        objGRN_Payment.PONo = "N/A";
                        objGRN_Payment.Supplier = "N/A";

                        objGRN_Payment.InvoiceType = "N/A";



                        if ((objGRN_Payment.PONo == "") | (objGRN_Payment.InvoiceNo == "") | (objGRN_Payment.Supplier == ""))
                        {
                            MessageBox.Show(this, "Can Not Allow to GRN", "Missing PO/Invoice/Supplier", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        {
                            objGRN.GRNNo = objGRNDL.Add_Direct(objGRN);

                            objGRN_Payment.GRNNo = objGRN.GRNNo;

                            //
                            objGRN_Payment_DL.Add(objGRN_Payment);
                            objFinishGoodsReturn_DL.Add(objGRN.GRNNo, cmbCustomer.SelectedValue.ToString(), Convert.ToInt32(cmbTerritory.SelectedValue.ToString()));
                            //
                        }

                        if (objGRN.GRNNo > 0)
                        {
                            foreach (DataGridViewRow dr in dgvProduct.Rows)
                            {
                                String tempproductCode = dr.Cells[0].Value.ToString();
                                String tempproduct = dr.Cells[1].Value.ToString();
                                long tempqty = Convert.ToInt64(dr.Cells[2].Value.ToString());
                                string tempstore = dr.Cells[3].Value.ToString();

                                objFinishProduct.FinishProductCode = tempproductCode;
                                objGRNFinishProduct.NetQty = tempqty;
                                objGRNFinishProduct.GrossQty = tempqty;
                                objGRNFinishProduct.GRN = objGRN;
                                objGRNFinishProduct.Remarks = "No";
                                objGRNFinishProduct.UnitPrice = 55;
                                objGRNFinishProduct.FinishProducts = objFinishProduct;

                                objGRNFinishProductDL.Add(objGRNFinishProduct);
                                //obj.GRN = objGRN;
                                //objGRNMaterialsDL.Add(obj);
                                //objGRNFinishProduct
                            }



                            clear();
                            MessageBox.Show(this, "Suceessfully add to the Dispose Stock", "Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();

                        }
                    }
                    else
                    {
                        MessageBox.Show(this, "There are no Items in the List, Please add Items before Continue", "Item List Empty", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                catch (Exception ex)
                {

                    MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else 
            {
                MessageBox.Show(this, "Please Select Customer", "MRP System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbTerritory.Enabled = true;
            LoadCustomerTerritory();
        }

        private void LoadCustomerTerritory()
        {
            try
            {
                cmbTerritory.DataSource = null;
                cmbTerritory.Items.Clear();
                dtCustomerTerritory = objCustomer_DL.GetTerritoryByCustomerID(cmbCustomer.SelectedValue.ToString());
                cmbTerritory.DataSource = dtCustomerTerritory;
                cmbTerritory.BindingContext = this.BindingContext;
                cmbTerritory.DisplayMember = "TerritoryName";
                cmbTerritory.ValueMember = "TerritoryID";
            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
