using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DL;
using SESD.MRP.REF;


namespace MRP_GUI
{
    public partial class frmBinCards_Raw : System.Windows.Forms.Form
    {
        public frmBinCards_Raw(User objUser, string _TheStore)
        {
            InitializeComponent();

            CurrentUser = objUser;
            TheStore = _TheStore;
        }

        private User _objCurrentUser;
        string TheStore;

        Material_DL objMaterial_DL = new Material_DL(ConnectionStringClass.GetConnection());
        Stock_DL objStock_DL = new Stock_DL(ConnectionStringClass.GetConnection());
        Store_DL objStore_DL = new Store_DL(ConnectionStringClass.GetConnection());

        DataTable dtStock = new DataTable();
        DataTable dtBalancStock = new DataTable();

        Material objMaterial = new Material();
        Store objStore = new Store();      

        DataTable dt = new DataTable();

        public User CurrentUser
        {
            get { return _objCurrentUser; }
            set { _objCurrentUser = value; }
        }

        private void frmBinCard_Load(object sender, EventArgs e)
        {
            try
            {
                objStore = objStore_DL.Get(TheStore);

                txtStore.Text = objStore.StoreDescription;
                txtDepartment.Text = objStore.StoreDepartment.DepName;

                LoadMaterial();

                Load_BinCard();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void Load_BinCard()
        {

            try
            {
            
            dt = objStock_DL.GetBinCard(TheStore, dtvFromDate.Value, cmMaterial.SelectedValue.ToString());

            dgvBinCard.AutoGenerateColumns = false;
            objSource.DataSource = dt;
            dgvBinCard.DataSource = objSource;
            objSource.ResetBindings(true);


            dtBalancStock.Clear();

            dgvBalanceStock.AutoGenerateColumns = false;
            objSourceBalanceStock.DataSource = dtBalancStock;
            dgvBalanceStock.DataSource = objSourceBalanceStock;
            objSourceBalanceStock.ResetBindings(true);


            Load_BalanceStocks();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void LoadMaterial()
        {
            try
            {
                DataTable dt = objMaterial_DL.GetDataView("Raw");

                objSourceMaterials.DataSource = dt;
                cmMaterial.DataSource = objSourceMaterials;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }


        }


        private void LoadStock()
        {
            try
            {
                
                    dtStock = objStock_DL.GetStock(TheStore, cmMaterial.SelectedValue.ToString());

                    if (dtStock.Rows.Count > 0)
                    {
                        txtCurrentStock.Text = dtStock.Rows[0]["StockQty"].ToString();
                        txtEOQ.Text = dtStock.Rows[0]["StockEconomicalQty"].ToString();
                        txtROL.Text = dtStock.Rows[0]["StockReorderLevel"].ToString();
                        txtUnitPrice.Text = dtStock.Rows[0]["StockUnitPrice"].ToString();

                        lblUnit1.Text = dtStock.Rows[0]["UnitCode"].ToString();
                    }
                    else
                    {
                        Clear();

                    }
                    
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }


        }


        private void Clear()
        {
            txtCurrentStock.Text = "0";
            txtUnitPrice.Text = "0";
            txtROL.Text = "0";
            txtEOQ.Text = "0";
        }

        private void cmMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmMaterial.SelectedValue != null)
                {
                    objMaterial = objMaterial_DL.Get(cmMaterial.SelectedValue.ToString());

                    txtMaterialCode.Text = cmMaterial.SelectedValue.ToString();

                    lblUnit1.Text = objMaterial.MatUnit.UnitCode;
                    lblUnit2.Text = objMaterial.MatUnit.UnitCode;
                    lblUnit3.Text = objMaterial.MatUnit.UnitCode;


                    LoadStock();
                    Load_BinCard();


                }
                else
                {
                    Clear();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void Load_BalanceStocks()
        {
            try
            {
                if (dgvBinCard.Rows.Count > 0)
                {
                    dtBalancStock.Clear();
                    if (dtBalancStock.Columns.Count > 0)
                    {
                        dtBalancStock.Columns.Remove("BalanceStock");
                    }

                    decimal CurrentStock = Convert.ToDecimal(dtStock.Rows[0]["StockQty"]);

                    bool EditforMR = false;
                    bool EditforGRN = false;

                    dtBalancStock.Columns.Add("BalanceStock");
                    dtBalancStock.Rows.Add(CurrentStock);

                    for (int i = 0; i < dgvBinCard.Rows.Count; i++)
                    {
                        if (dgvBinCard.Rows[i].Cells["GRNQty"].Value.ToString() != "-")
                        {
                            CurrentStock = CurrentStock - Convert.ToDecimal(dgvBinCard.Rows[i].Cells["GRNQty"].Value);

                            EditforGRN = true;

                           
                        }

                        if (dgvBinCard.Rows[i].Cells["IssuedQty"].Value.ToString() != "-")
                        {
                            CurrentStock = CurrentStock + Convert.ToDecimal(dgvBinCard.Rows[i].Cells["IssuedQty"].Value);

                            EditforMR = true;
                        }


                        if ((EditforGRN == true) | (EditforMR == true))
                        {
                            dtBalancStock.Rows.Add(CurrentStock);
                        }

                        EditforMR = false;
                        EditforGRN = false;



                    }

                    dgvBalanceStock.AutoGenerateColumns = false;
                    objSourceBalanceStock.DataSource = dtBalancStock;
                    dgvBalanceStock.DataSource = objSourceBalanceStock;
                    objSourceBalanceStock.ResetBindings(true);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

    }
}
