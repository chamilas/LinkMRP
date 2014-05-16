using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using SESD.MRP.REF;
using DL;

namespace MRP_GUI
{
    public partial class frmSupplier : System.Windows.Forms.Form
    {
        public frmSupplier()
        {
            InitializeComponent();
        }

        private Supplier objSupplier = new Supplier();
        private Supplier_DL objSupplierDL = new Supplier_DL(ConnectionStringClass.GetConnection());
        private Material_DL objMaterialDL = new Material_DL(ConnectionStringClass.GetConnection());

        private MaterialSupply objMatSupply = new MaterialSupply();


        private bool SupplierSelect = false;
        DataTable dtSuppliers = new DataTable();


        //-------------- Form Methods ------------------------
        public void ClearSupplier()
        {
            txtAddress.Text = "";
            txtEmail.Text = "";
            txtFax.Text = "";
            txtMobile.Text = "";
            txtName.Text = "";
            txtPhone.Text = "";
            txtVATNumber.Text = "";
            txtContactPerson.Text = "";
            txtCode.Text = "";

            cbVAT.Checked = false;
            this.SupplierSelect = false;

        }


        private void frmSupplier_Load(object sender, EventArgs e)
        {
            cmbSupplierCategory.Text = "Raw";

            Load_Suppliers();
            
        }

        private void Load_Suppliers()
        {

            try
            {
            dtSuppliers = objSupplierDL.GetDataView(cmbSupplierCategory.Text);

            gvSupplier.AutoGenerateColumns = false;
            objSourceSuppliers.DataSource = dtSuppliers;
            gvSupplier.DataSource = objSourceSuppliers;
            objSourceSuppliers.ResetBindings(true);
                }
                   catch (Exception ex)
                {

                    MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Equals(""))
            {
                MessageBox.Show(this, "Please Enter a Name for Supplier", "Blank Fields", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                try
                {
                    objSupplier.SupplieName = txtName.Text;
                    objSupplier.SupplierAddress = txtAddress.Text;
                    objSupplier.SupplierContactPerson = txtContactPerson.Text;
                    objSupplier.SupplierEmail = txtEmail.Text;
                    objSupplier.SupplierFax = txtFax.Text;
                    objSupplier.SupplierMobile = txtMobile.Text;
                    objSupplier.SupplierPhone = txtPhone.Text;
                    objSupplier.SupplierStatus = cbEnable.Checked;
                    objSupplier.SupplierType = cmbSupplierCategory.Text;
                    objSupplier.SupplierVat = cbVAT.Checked;
                    objSupplier.SupplierVATNo = txtVATNumber.Text;
                    objSupplier.SupplierCode = txtCode.Text;

                    long x;

                    if (this.SupplierSelect)
                    {
                        x = objSupplierDL.Update(objSupplier);
                        Load_Suppliers();


                        if (x > 0)
                        {
                            MessageBox.Show(this, "Succesfully Updated the Database", "Succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            this.ClearSupplier();
                        }


                    }
                    else
                    {
                        x = objSupplierDL.Add(objSupplier);


                        Load_Suppliers();

                        if (x > 0)
                        {
                            MessageBox.Show(this, "Succesfully Added to Database", "Succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //int counter = 0;
                            //foreach (DataGridViewRow var in gvSupplier.Rows)
                            //{
                            //    if (var.Cells["ColSupplierID1"].Value.ToString() == x.ToString())
                            //    {

                            //        gvSupplier.CurrentCell = gvSupplier[3, counter];
                            //        gvSupplier.FirstDisplayedScrollingRowIndex = counter;

                            //        break;
                            //    }
                            //    counter++;
                            //}



                            this.ClearSupplier();
                        }

                    }




                }
                catch (FormatException)
                {

                    MessageBox.Show(this, "Please enter valid data", "Input Data Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                catch (Exception ex)
                {

                    MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {


                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.SupplierSelect)
            {
                DialogResult dr = MessageBox.Show(this, "Are you sure, You want to Delete selected Record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {


                    try
                    {
                        int x = objSupplierDL.Delete(objSupplier.SupplierID);


                        if (x > 0)
                        {
                            MessageBox.Show(this, "Succesfully Deleted From Database", "Succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.ClearSupplier();
                            Load_Suppliers();
                        }
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show(this, "Select a Record from the List", "Select a Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void cbVAT_CheckedChanged(object sender, EventArgs e)
        {
            if (cbVAT.Checked)
            {
                txtVATNumber.Visible = true;
                lblVatNumber.Visible = true;

            }
            else
            {
                txtVATNumber.Visible = false;
                lblVatNumber.Visible = false;
            }
        }

        private void gvSupplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

       

       

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearSupplier();
        }



        private void txtMaterialLeadTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar) || (e.KeyChar == (char)46)))
            {
                e.Handled = true;
            }
        }

        private void cmbSupplierCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            Load_Suppliers();
        }

        private void gvSupplier_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                objSupplier = objSupplierDL.Get(Convert.ToInt64(gvSupplier.CurrentRow.Cells["SupplierID"].Value));

                txtAddress.Text = objSupplier.SupplierAddress;
                txtContactPerson.Text = objSupplier.SupplierContactPerson;
                txtEmail.Text = objSupplier.SupplierEmail;
                txtFax.Text = objSupplier.SupplierFax;
                txtMobile.Text = objSupplier.SupplierMobile;
                txtName.Text = objSupplier.SupplieName;
                txtPhone.Text = objSupplier.SupplierPhone;
                txtVATNumber.Text = objSupplier.SupplierVATNo;
                cbVAT.Checked = objSupplier.SupplierVat;
                cbEnable.Checked = objSupplier.SupplierStatus;
                txtCode.Text = objSupplier.SupplierCode;

                cmbSupplierCategory.Text = objSupplier.SupplierType;

                this.SupplierSelect = true;

            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
