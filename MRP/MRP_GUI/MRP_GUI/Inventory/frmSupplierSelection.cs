using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DL;

namespace MRP_GUI
{
    public partial class frmSupplierSelection : Form
    {
        public frmSupplierSelection(string _SupCatID)
        {
            InitializeComponent();
            SupCatID = _SupCatID;
        }


        long _SelectedSupplier;
        string SupCatID;

        DataTable dtSuppliers = new DataTable();
        Supplier_DL objSupplier_DL = new Supplier_DL(ConnectionStringClass.GetConnection());

        public long SelectedSupplier
        {

            set { _SelectedSupplier = value; }
            get { return _SelectedSupplier; }

        }


        private void ReLoad(string search)
        {
            try
            {

                dtSuppliers = objSupplier_DL.GetView_Search(SupCatID, search);

                objSource.DataSource = dtSuppliers;


                dgvSuppliers.AutoGenerateColumns = false;
                objSource.DataSource = dtSuppliers;
                dgvSuppliers.DataSource = objSource;
                objSource.ResetBindings(true);


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex); ;
            }
        }

        private void frmSupplierSelection_Load(object sender, EventArgs e)
        {
            ReLoad("");
        }

        private void txtSupplier_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                dgvSuppliers.Focus();
                dgvSuppliers.Rows[0].Selected = true;
            }
        }

        private void dgvSuppliers_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;

                if (dgvSuppliers.CurrentRow.Cells["SupplierCode"].Value != null)
                {
                    SelectedSupplier = Convert.ToInt64(dgvSuppliers.CurrentRow.Cells["SupID"].Value);

                }

                this.Close();
            }
        }


        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {

            if (keyData == Keys.Escape)
            {
                this.Close();
            }

            // Call the base class
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void txtSupplier_TextChanged(object sender, EventArgs e)
        {
            ReLoad(txtSupplier.Text);
        }


    }
}
