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
    public partial class frmPOSelection : Form
    {
        public frmPOSelection(string _catID)
        {
            InitializeComponent();
            CatID = _catID;
        }


        string _SelectedPO;
        string CatID = "";

        DataTable dtPOs = new DataTable();
        PO_DL objPO_DL = new PO_DL(ConnectionStringClass.GetConnection());

        public string SelectedPO
        {

            set { _SelectedPO = value; }
            get { return _SelectedPO; }

        }


        private void ReLoad(string POCategory,string search)
        {
            try
            {

                dtPOs = objPO_DL.GetView_Search(POCategory,search);

                objSource.DataSource = dtPOs;


                dgvPOs.AutoGenerateColumns = false;
                objSource.DataSource = dtPOs;
                dgvPOs.DataSource = objSource;
                objSource.ResetBindings(true);


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex); ;
            }
        }

        private void frmSupplierSelection_Load(object sender, EventArgs e)
        {
            ReLoad(CatID,"");
        }

        private void txtSupplier_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                dgvPOs.Focus();
                dgvPOs.Rows[0].Selected = true;
            }
        }

        private void dgvSuppliers_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;

                if (dgvPOs.CurrentRow.Cells["PONO"].Value != null)
                {
                    SelectedPO = Convert.ToString(dgvPOs.CurrentRow.Cells["PONO"].Value);

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
            ReLoad(CatID,txtPONO.Text);

           


        }


    }
}
