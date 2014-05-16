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
    public partial class frmDispatch : System.Windows.Forms.Form
    {
        //---------------- Variables -------------------------------------
        private User _objCurrentUser;

        public User CurrentUser
        {
            get { return _objCurrentUser; }
            set { _objCurrentUser = value; }
        }
        FinishProduct objFinishProduct = new FinishProduct();
        FinishProduct_DL objFinishProductDL = new FinishProduct_DL(ConnectionStringClass.GetConnection());

        DispatchNote objDispatch = new DispatchNote();
        DispatchNote_DL objDispathcNoteDL = new DispatchNote_DL(ConnectionStringClass.GetConnection());
        DispatchNoteListCollec objDispatchCollec = new DispatchNoteListCollec();

        DispatchProducts objDispatchProduct = new DispatchProducts();
        DispatchProducts_DL objDispatchProductDL = new DispatchProducts_DL(ConnectionStringClass.GetConnection());
        DispatchProductsCollec objDispatchProductCollec = new DispatchProductsCollec();

        Stock_DL objStockDL = new Stock_DL(ConnectionStringClass.GetConnection());

        bool ItemSelect = false;
        //----------------------- Methods ----------------------------
        public void LoadItems()
        {
            try
            {
                cmbFinishProduct.DataSource = objFinishProductDL.GetDataView(1);
            }
            catch (Exception ex)
            {
                
               MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ClearItem()
        {
            txtQuantity.Text = "0.00";
            cmbFinishProduct.SelectedIndex = 0;
            ItemSelect = false;
            btnSave.Text = "Add";

        }
        //------------------------------------------------------------
        public frmDispatch()
        {
            InitializeComponent();
        }

        public frmDispatch(User objUser)
        {
            InitializeComponent();
            CurrentUser = objUser;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDispatch_Load(object sender, EventArgs e)
        {
            LoadItems();
        }

        private void cmbFinishProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                objFinishProduct = objFinishProductDL.Get(cmbFinishProduct.SelectedValue.ToString());
                lblUnit.Text = objFinishProduct.FinishProductPackingType.PackingTitle;
            }
            catch (Exception ex )
            {
                
               MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbFinishProduct.Items.Count <= 0 || txtQuantity.Text.Equals(""))
                {
                    MessageBox.Show(this, "Please Select a Product and enter the Quantity", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {

                    if (ItemSelect)
                    {
                        objDispatchProductCollec.Delete(objDispatchProduct);
                    }
                        bool ItemInList = true;
                        objFinishProduct = objFinishProductDL.Get(cmbFinishProduct.SelectedValue.ToString());
                        foreach (DispatchProducts obj in objDispatchProductCollec)
                        {
                            if (obj.DispatchFinishProduct.FinishProductCode == objFinishProduct.FinishProductCode)
                            {
                                MessageBox.Show(this, "This Product Already added to List, Please select the item from list and update", "Item Already Added", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                ItemInList = false;
                                break;
                            }
                        }
                        if (ItemInList)
                        {
                            DispatchProducts objTemp = new DispatchProducts();
                            objTemp.DispatchFinishProduct = objFinishProduct;
                            objTemp.DispatchQty = Convert.ToDecimal(txtQuantity.Text);

                            objDispatchProductCollec.Add(objTemp);

                            ItemInList = true;
                            ClearItem();
                        } 
                        else
                        {
                            if (ItemSelect)
                            {
                                objDispatchProductCollec.Add(objDispatchProduct);
                            }
                        }
                        bindProductList.DataSource = objDispatchProductCollec;
                        bindProductList.ResetBindings(false);
                }
            }
            catch (FormatException fex)
            {
                MessageBox.Show(this,"Quantity should be a Numaric value","Invalid Type",MessageBoxButtons.OK,MessageBoxIcon.Error);
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
                    if (ItemSelect)
                    {
                        objDispatchProductCollec.Delete(objDispatchProduct);
                        ClearItem();
                        bindProductList.DataSource = objDispatchProductCollec;
                    }
            }
            catch (Exception ex)
            {
                
               MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtQuantity_Validated(object sender, EventArgs e)
        {
            try
            {
                Convert.ToDecimal(txtQuantity.Text);
                errorProvider1.SetError(txtQuantity, "");
            }
            catch (Exception)
            {

                errorProvider1.SetError(txtQuantity, "Quantity should be a Numaric value");
            }
        }

        private void gvProductList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                objDispatchProduct = (DispatchProducts)gvProductList.Rows[e.RowIndex].DataBoundItem;
                cmbFinishProduct.SelectedValue = objDispatchProduct.DispatchFinishProduct.FinishProductCode;
                txtQuantity.Text = objDispatchProduct.DispatchQty.ToString();
                ItemSelect = true;
                btnSave.Text = "Save";
            }
            catch (Exception ex)
            {
                
               MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearItem();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                DialogResult dr = MessageBox.Show(this,"Are you sure you want to Dispatch Items in the List? Click Yes to continue","Confirm Dispatch",MessageBoxButtons.YesNo,MessageBoxIcon.Question);


                if (dr == DialogResult.Yes)
                {
                    objDispatch.DispatchNoteDate = dtDispatchOrderDate.Value;
                    objDispatch.DispatchNoteEnterdBy = CurrentUser.UserEmp;
                    objDispatch.DispatchNoteEnterdDate = DateTime.Now;
                    objDispatch.DispatchNoteID = txtDispatchNoteNo.Text;

                    bool IsStock = true;
                    foreach (DispatchProducts obj in objDispatchProductCollec)
                    {
                        Decimal qty = objStockDL.GetAvailableQty("MAIN", obj.DispatchFinishProduct.FinishProductCode, Stock.Type.FinishProduct);
                        if (qty < obj.DispatchQty)
                        {
                            IsStock = false;
                            break;
                        }
                    }



                    if (IsStock)
                    {
                        //int x = objDispathcNoteDL.Add(objDispatch);
                        //if (x > 0)
                        //{
                        //    foreach (DispatchProducts obj in objDispatchProductCollec)
                        //    {
                        //        obj.DispatchNote = objDispatch;
                        //        int y = objDispatchProductDL.Add(obj);
                        //        if (y == -1)
                        //        {
                        //            MessageBox.Show(this, "Stock is below than dispatch," + obj.DispatchFinishProduct.Code + " will not be dispatched", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //        }
                        //    }
                        //}

                        //this.Close();
                    }
                    else
                    {
                        MessageBox.Show(this, "Current Stock low, Please Try other time", "Insufficient Stock", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    } 
                }

            }
            catch (Exception ex)
            {
                
               MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar) || (e.KeyChar == (char)46)))
            {
                e.Handled = true;
            }
        }
    }
}