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
    public partial class frmDailySales : System.Windows.Forms.Form
    {
        private User _objCurrentUser;

        public User CurrentUser
        {
            get { return _objCurrentUser; }
            set { _objCurrentUser = value; }
        }

        private Customer objCustomer = new Customer();
        private Customer_DL objCustomer_DL = new Customer_DL(ConnectionStringClass.GetConnection());
        
        private DispatchNote objDispatchNote = new DispatchNote();
        private DispatchNote_DL objDispatchNote_DL = new DispatchNote_DL(ConnectionStringClass.GetConnection());

        private DispatchNoteList objDispatchNoteList = new DispatchNoteList();      
        private DispatchNoteList_DL objDispatchNoteList_DL = new DispatchNoteList_DL(ConnectionStringClass.GetConnection());
      
        private FinishProduct_DL objFinishProduct_DL = new FinishProduct_DL(ConnectionStringClass.GetConnection());

        private DispathcNoteListCollec objDispathcNoteListCollec = new DispathcNoteListCollec();

        private SalesMethod_DL objSalesMethod_DL = new SalesMethod_DL(ConnectionStringClass.GetConnection());

        private Stock objStock = new Stock();
        private Stock_DL objStock_DL = new Stock_DL(ConnectionStringClass.GetConnection());

        DataTable dtCustomerTerritory = new DataTable();
        DataTable dtFinishProductList = new DataTable();
        DataTable dtCustomers = new DataTable();
        DataTable dtOrderList = new DataTable();

        public frmDailySales(User objUser)
        {
            InitializeComponent();
            CurrentUser = objUser;
            LoadFinishProductListandSalesMethod();
        }

        private void cmbSalesMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!cmbSalesMethod.Text.Equals(null))
            {
                LoadCustomers();
            }
        }

        private void LoadCustomerTerritory() 
        {
            try
            {
                cmbTerritory.DataSource = null;
                cmbTerritory.Items.Clear();
                dtCustomerTerritory = objCustomer_DL.GetTerritoryByCustomerID(cmbCustomer.Text);
                cmbTerritory.DataSource = dtCustomerTerritory;
                cmbTerritory.BindingContext = this.BindingContext;
                cmbTerritory.DisplayMember = "TerritoryName";

            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void LoadCustomers()
        {
            try
            {
                cmbCustomer.DataSource = null;
                cmbCustomer.Items.Clear();
                dtCustomers = objCustomer_DL.GegCustomerBySalesMethod(cmbSalesMethod.Text);
                cmbCustomer.DataSource = dtCustomers;
                cmbCustomer.BindingContext = this.BindingContext;
                cmbCustomer.DisplayMember = "CustomerID";

            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void LoadFinishProductListandSalesMethod()
        {
            try
            {
                cmbProduct.Items.Clear();
                dtFinishProductList = objCustomer_DL.GetFinishProduct();
                cmbProduct.DataSource = dtFinishProductList;
                cmbProduct.BindingContext = this.BindingContext;
                //cmbProduct.DisplayMember = "FinishProduct";

                bsSalesMethod.DataSource = objSalesMethod_DL.Get();
                cmbSalesMethod.DataSource = bsSalesMethod;

            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            String temptxtProduct = dtFinishProductList.Rows[cmbProduct.SelectedIndex].ItemArray[0].ToString();
            if (txtQuantity.Text != "" && DataValidation.IsNumericNumber(txtQuantity.Text))
            {
                bool availability = false;
                foreach (DataGridViewRow row2 in dgvProduct.Rows)
                {
                    String tempcheckproduct = row2.Cells[0].Value.ToString();
                    if (tempcheckproduct == temptxtProduct)
                    {
                        availability = true;
                        //break;
                    }
                }
                if (dgvProduct.Rows.Count == 0 || !availability)
                {
                    CheckProductAvailability(temptxtProduct); 
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

        private void CheckProductAvailability(String productID) 
        {
            dtOrderList = objStock_DL.GetFinishProduct_Availability(productID, Convert.ToInt32(txtQuantity.Text));
            
            if (dtOrderList.Rows.Count > 0)
            {
                String tmpProductName = dtFinishProductList.Rows[cmbProduct.SelectedIndex].ItemArray[8].ToString();
                string stockid = "";
                string storeid = "";
                foreach (DataRow trow in dtOrderList.Rows)
                {
                    stockid = trow["StockID"].ToString();
                    storeid = trow["StoreID"].ToString();
                }
                dgvProduct.Rows.Add(tmpProductName, productID, stockid, storeid, txtQuantity.Text);
            }
            else
            {
                MessageBox.Show(this, "selected quantity is unavailable", "MRP System", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            if (dgvProduct.SelectedRows.Count>0)
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
            if (!String.IsNullOrWhiteSpace(txtDispatchID.Text))
            {
                if (cmbCustomer.Text != "")
                {
                    if (dgvProduct.Rows.Count > 0)
                    {
                        String DISPATCHID = txtDispatchID.Text;

                        if (cmbTerritory.SelectedValue != null)
                        {
                            objDispatchNote.TerritoryID = Convert.ToInt32(cmbTerritory.SelectedValue.ToString());
                        }
                        else
                        {
                            objDispatchNote.TerritoryID = 0;
                        }

                        objDispatchNote.DispatchID = DISPATCHID;
                        objDispatchNote.DistributorID = cmbCustomer.Text;
                        objDispatchNote.EnteredBy = CurrentUser.UserEmp.EmployeeID;
                        objDispatchNote_DL.Add(objDispatchNote);


                        foreach (DataGridViewRow dr in dgvProduct.Rows)
                        {
                            string tempproduct = dr.Cells[1].Value.ToString();
                            string tempstore = dr.Cells[3].Value.ToString();
                            long tempqty = Convert.ToInt64(dr.Cells[4].Value.ToString());

                            objDispatchNoteList.DispatchID = DISPATCHID;
                            objDispatchNoteList.FinishProduct = tempproduct;
                            objDispatchNoteList.BatchNo = "1";
                            objDispatchNoteList.Qty = tempqty;
                            objDispatchNoteList_DL.Add(objDispatchNoteList, tempstore);

                            objStock_DL.UpdateFinishProductAvailability(DISPATCHID, tempproduct, Convert.ToInt32(tempqty));
                            MessageBox.Show(this, "Dispatch Note successfully added", "Successful", MessageBoxButtons.OK, MessageBoxIcon.None);
                            ClearFields();
                        }
                    }
                    else
                    {
                        MessageBox.Show(this, "Please add product to Order list", "Blank Fields", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }

                }
                else
                {
                    MessageBox.Show(this, "Please Select a Customer", "Blank Fields", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            else 
            {
                MessageBox.Show(this, "Please Enter DispatchID", "Blank Fields", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void cmbCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (!cmbCustomer.Text.Equals(null))
            {
                //MessageBox.Show("thjfjhfgjg" + comboBox1.SelectedText);
                LoadCustomerTerritory();
            }
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields() 
        {
            txtQuantity.Text = "";
            dgvProduct.DataSource = null;
            dgvProduct.Rows.Clear();
            dgvProduct.Refresh();
        }


    }
}
