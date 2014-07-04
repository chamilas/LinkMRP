using DL;
using MRP_DL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SESD.MRP.REF;

namespace MRP_GUI.Sales
{
    public partial class frmCustomerProducts : System.Windows.Forms.Form
    {
        private Territory_DL ter = new Territory_DL(ConnectionStringClass.GetConnection());
        private CustomerProducts_DL cus = new CustomerProducts_DL(ConnectionStringClass.GetConnection());
        private Region_DL reg = new Region_DL(ConnectionStringClass.GetConnection());
        private delegate void InvokeDel();
        private string SalesMethod;

        public frmCustomerProducts(string SalesMethod)
        {
            InitializeComponent();
            this.SalesMethod = SalesMethod;
            try
            {
                
                cmb_discountType.SelectedIndex = 0;
                cmb_customer.DataSource = ter.GetCustomers("Company Outlet");
                cmb_productCatType.DataSource = cus.GetCustomersProductCategory(ter.GetCustomersIDByName(cmb_customer.Text.ToString(), this.SalesMethod));
                cmb_products.DataSource = cus.GetCustomersProductList(reg.GetProductCatID(cmb_productCatType.Text.ToString()));
                grid_itemsPerPrice.DataSource = cus.GetPricePerItem();
                grid_itemsPerDiscount.DataSource = cus.GetDiscountPerItem();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No any Customers in this sales method...!", "No Customers", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btn_save.Enabled = false;
            }
        }

        private void cmb_customer_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_productCatType.DataSource = cus.GetCustomersProductCategory(ter.GetCustomersIDByName(cmb_customer.Text.ToString(), this.SalesMethod));
            cmb_products.DataSource = cus.GetCustomersProductList(reg.GetProductCatID(cmb_productCatType.Text.ToString()));
        }

        private void cmb_productCatType_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_products.DataSource = cus.GetCustomersProductList(reg.GetProductCatID(cmb_productCatType.Text.ToString()));

            if (cmb_products.Items.Count == 0)
            {
                btn_save.Enabled = false;
            }
            else
            {
                btn_save.Enabled = true;
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (txt_tpye.Text.Trim().ToString() == "")
            {
                MessageBox.Show("Please fill Price/Discount Per Item to continue...!", "Fill Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_tpye.Text= "";
                return;
            }

            if (!IsNum(txt_tpye.Text.Trim().ToString()))
            {
                MessageBox.Show("Please fill Price/Discount Per Item as number to continue...!", "Numbers Only", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_tpye.Text = "";
                return;
            }

            if (cmb_products.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Please select a product to continue...!", "No Products", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int type = 0;
            float amount = float.Parse(txt_tpye.Text.ToString());
            float Price_Per_Quantity = amount;
            float Discount_Per_Quantity = 0;
            if (cmb_discountType.SelectedIndex == 1)
            {
                type = 1;
                Price_Per_Quantity = 0;
                Discount_Per_Quantity = amount;
            }

            string code = cmb_products.Text.ToString().Split('-')[0];

            if (cus.IsAddedProduct(ter.GetCustomersIDByName(cmb_customer.Text.ToString(),this.SalesMethod), code) > 0)
            {
                MessageBox.Show("Product is already added...!", "Assign Products", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CustomerProducts obj = new CustomerProducts();
            obj.Customer_Code = ter.GetCustomersIDByName(cmb_customer.Text.ToString(),this.SalesMethod);
            obj.Basic_Product_ID = code;
            obj.Discount_Type = type;
            obj.Price_Per_Quantity = Price_Per_Quantity;
            obj.Discount_Per_Quantity = Discount_Per_Quantity;

            long rows = cus.Add(obj);

            if (rows > 0)
            {
                MessageBox.Show("Product is Added...!", "Assign Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_tpye.Text = "";
                grid_itemsPerPrice.DataSource = cus.GetPricePerItem();
                grid_itemsPerDiscount.DataSource = cus.GetDiscountPerItem();
                return;
            }
            else
            {
                MessageBox.Show("Recode is not added. Please try again...!", "Assign Product", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


        }

        private bool IsNum(string text)
        {
            try
            {
                float num = float.Parse(text.Trim().ToString());
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        private void Cancel()
        {
            this.Close();
        }

        private void grid_itemsPerPrice_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                long rows = cus.CustomerProductRemove(int.Parse(grid_itemsPerPrice.Rows[e.RowIndex].Cells[e.ColumnIndex + 1].Value.ToString()), grid_itemsPerPrice.Rows[e.RowIndex].Cells[e.ColumnIndex + 2].Value.ToString());

                if (rows > 0)
                {
                    MessageBox.Show("Product is Removed...!", "Remove Products", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    grid_itemsPerPrice.DataSource = cus.GetPricePerItem();
                    grid_itemsPerDiscount.DataSource = cus.GetDiscountPerItem();
                    return;
                }
                else
                {
                    MessageBox.Show("Recode is not removed. Please try again...!", "Remove Products", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void grid_itemsPerDiscount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                long rows = cus.CustomerProductRemove(int.Parse(grid_itemsPerDiscount.Rows[e.RowIndex].Cells[e.ColumnIndex + 1].Value.ToString()), grid_itemsPerDiscount.Rows[e.RowIndex].Cells[e.ColumnIndex + 2].Value.ToString());

                if (rows > 0)
                {
                    MessageBox.Show("Product is Removed...!", "Remove Products", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    grid_itemsPerPrice.DataSource = cus.GetPricePerItem();
                    grid_itemsPerDiscount.DataSource = cus.GetDiscountPerItem();
                    return;
                }
                else
                {
                    MessageBox.Show("Recode is not removed. Please try again...!", "Remove Products", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void frmCustomerProducts_Load(object sender, EventArgs e)
        {

        }
    }
}
