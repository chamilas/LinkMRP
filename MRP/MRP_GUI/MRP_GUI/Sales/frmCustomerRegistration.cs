using DL;
using SESD.MRP.REF;
using System;
using System.Data;
using System.Windows.Forms;

namespace MRP_GUI.Sales
{
    public partial class frmCustomerRegistration : System.Windows.Forms.Form
    {
        private Customer objCustomer = new Customer();
        private Customer_DL objCustomer_DL = new Customer_DL(ConnectionStringClass.GetConnection());

        private CustomerTerritoryList objCustomerTerritoryList = new CustomerTerritoryList();
        private CustomerTerritoryList_DL objCustomerTerritoryList_DL = new CustomerTerritoryList_DL(ConnectionStringClass.GetConnection());
        private SalesMethod_DL objSalesMethod_DL = new SalesMethod_DL(ConnectionStringClass.GetConnection());
        private ProductCategory_DL objProductCategory_DL = new ProductCategory_DL(ConnectionStringClass.GetConnection());
        DataTable dtCustomerTerritory = new DataTable();
        DataTable dtCustomers = new DataTable();
        DataTable dtCustomerTerritoryList = new DataTable();

        public frmCustomerRegistration()
        {
            
            InitializeComponent();
            LoadCustomers();
            LoadSalesMethodandProductCategory();
            //cmbProductType.SelectedIndex = 0;
            //cmbSelectMethod.SelectedIndex = 0;

        }

        private void LoadSalesMethodandProductCategory()
        {
            bsSalesMethod.DataSource = objSalesMethod_DL.Get();
            cmbSelectMethod.DataSource = bsSalesMethod;

            bsProductType.DataSource = objProductCategory_DL.GetDataView();
            cmbProductType.DataSource = bsProductType;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            try
            { 

                if (String.IsNullOrWhiteSpace(txtCustomerID.Text) || String.IsNullOrWhiteSpace(txtCustomerName.Text) || String.IsNullOrWhiteSpace(txtAddress.Text) || String.IsNullOrWhiteSpace(txtTelephone.Text))
                {
                    MessageBox.Show(this, "Please Fill all Fields", "Blank Fields", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else if (!DataValidation.IsPhoneNumber(txtTelephone.Text))
                {
                    MessageBox.Show(this, "Please Enter Valid Phone Number", "Phone Number", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else 
                {
                        objCustomer.CustomerID = txtCustomerID.Text;
                        objCustomer.Name = txtCustomerName.Text;
                        objCustomer.Address = txtAddress.Text;
                        objCustomer.ProductType = cmbProductType.Text;
                        objCustomer.SalesMethod = cmbSelectMethod.Text;
                        objCustomer.Telephone = txtTelephone.Text;
                        objCustomer.Territory = "none";
                        foreach (ListItem item in lbTerritory.Items)
                        {
                            objCustomer.Territory = "available";
                        }
                        long x = objCustomer_DL.Add(objCustomer);


                        foreach (ListItem item in lbTerritory.Items)
                        {
                            objCustomerTerritoryList.CustomerID = txtCustomerID.Text;
                            objCustomerTerritoryList.TerritoryName = item.getValue();
                            objCustomerTerritoryList.TerritoryID = Convert.ToInt32(item.getID());
                            objCustomerTerritoryList_DL.Add(objCustomerTerritoryList);
                        }
                        MessageBox.Show(this, "New Customer successfully added", "Successful", MessageBoxButtons.OK, MessageBoxIcon.None);
                        ClearScreen();
                        LoadCustomers();
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
                //MessageBox.Show(this, "This Customer ID already exists.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell.RowIndex > -1)
            {
                DialogResult dr = MessageBox.Show(this, "Are you sure, You want to Delete selected Record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    objCustomer_DL.Delete(dataGridView1.CurrentRow.Cells["CustomerID"].Value.ToString());
                    objCustomerTerritoryList_DL.Delete(dataGridView1.CurrentRow.Cells["CustomerID"].Value.ToString());
                    LoadCustomers();
                }
            }
            else 
            {
                MessageBox.Show(this, "please select a record to delete", "MRP System", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


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

        private void button3_Click(object sender, EventArgs e)
        {
            ClearScreen();
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSelectMethod.Text.Equals("Distributor"))
            {
                lbTerritory.Items.Clear();
                cmbTerritory.Enabled = true;
                Load_CustomerTerritory();
            }
            else 
            {
                lbTerritory.Items.Clear();
                cmbTerritory.DataSource = null;
                cmbTerritory.Items.Clear();
                //cmbTerritory.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool territoryavailability = false;

            if (cmbTerritory.Text != "")
            {
                foreach (ListItem item in lbTerritory.Items)
                {
                    if (item.getValue() == cmbTerritory.Text)
                    {
                        territoryavailability = true;
                    }
                }

                if (!territoryavailability)
                {
                    //lbTerritory.Items.Add(cmbTerritory.Text);
                    lbTerritory.Items.Add(new ListItem(cmbTerritory.SelectedValue.ToString(),cmbTerritory.Text));
                    territoryavailability = false;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (lbTerritory.SelectedIndex != -1)
            {
                //MessageBox.Show(lbTerritory.SelectedItem.ToString());
                lbTerritory.Items.Remove(lbTerritory.SelectedItem);
            }
        }

        private void ClearScreen() 
        {
            txtAddress.Text = "";
            txtTelephone.Text = "";
            txtCustomerName.Text = "";
            txtCustomerID.Text = "";
            lbTerritory.Items.Clear();
            cmbProductType.Text = "- Select ProductType -";
            cmbSelectMethod.Text = "- Select Sales Method -";
            cmbTerritory.Text = "- Select Territory -";
            LoadCustomers();
            cmbProductType.SelectedIndex = 0;
            cmbSelectMethod.SelectedIndex = 0;
            cmbTerritory.DataSource = null;
            cmbTerritory.Items.Clear();
        }

        private void LoadCustomers()
        {
            //
            //dtCustomers = objCustomer_DL.TestPro("RP/BBL/JD", 500, "Dispose_RM");
            dtCustomers = objCustomer_DL.GetCustomers();
            objCustomerBindingSourse.DataSource = dtCustomers;
            
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = objCustomerBindingSourse;
            objCustomerBindingSourse.ResetBindings(true);
        }

        private void frmCustomerRegistration_Load(object sender, EventArgs e)
        {

        }

    }

    public class ListItem
    {
        private string id = string.Empty;
        private string value = string.Empty;

        public ListItem(string name, string tvalue)
        {
            id = name;
            value = tvalue;
        }

        public override string ToString()
        {
            return this.value;
        }

        public string getID()
        {
            return this.id;
        }

        public string getValue()
        {
            return this.value;
        }

        public string ID
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }

        public string Value
        {
            get
            {
                return this.value;
            }
            set
            {
                this.value = value;
            }
        }
    }
}
