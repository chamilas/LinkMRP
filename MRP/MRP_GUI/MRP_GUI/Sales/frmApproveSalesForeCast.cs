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
    public partial class frmApproveSalesForeCast : System.Windows.Forms.Form
    {
        private SalesForeCast_DL objSalesForeCast_DL = new SalesForeCast_DL(ConnectionStringClass.GetConnection());
        private String CurrentProductType;
        private User _objCurrentUser;
        public User CurrentUser
        {
            get { return _objCurrentUser; }
            set { _objCurrentUser = value; }
        }

        public frmApproveSalesForeCast(User objUser, String ProductType)
        {
            CurrentUser = objUser;
            CurrentProductType = ProductType;
            InitializeComponent();
            LoadSalesForecast();
        }

        private void LoadSalesForecast()
        {
            bsSalesForecast.DataSource = objSalesForeCast_DL.GetForeCastByStatus(0, CurrentProductType);
            dgvSalesForcast.AutoGenerateColumns = false;
            dgvSalesForcast.DataSource = bsSalesForecast;
            bsSalesForecast.ResetBindings(true);
        }

        private void LoadProduct(int FSID)
        {
            bssalesFrocastProductList.DataSource = objSalesForeCast_DL.GetForeCastContentByFSID(FSID);
            dgvProduct.AutoGenerateColumns = false;
            dgvProduct.DataSource = bssalesFrocastProductList;
            bssalesFrocastProductList.ResetBindings(true);
        }

        private void dgvSalesForcast_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int FSID = Convert.ToInt32(dgvSalesForcast.CurrentRow.Cells["ID"].Value.ToString());
            LoadProduct(FSID);
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            if (dgvSalesForcast.CurrentCell.RowIndex > -1)
            {
                DialogResult dr = MessageBox.Show(this, "Are you sure, You want to Approve this Forecast ? ", "Approve Forecast", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    int FSID = Convert.ToInt32(dgvSalesForcast.CurrentRow.Cells["ID"].Value.ToString());
                    objSalesForeCast_DL.Update_Status(FSID, 1, CurrentUser.UserEmp.EmployeeID);
                    LoadSalesForecast();
                    dgvProduct.DataSource = null;
                }
            }
            else
            {
                MessageBox.Show(this, "please select a record", "MRP System", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void frmApproveSalesForeCast_Load(object sender, EventArgs e)
        {

        }
    }
}
