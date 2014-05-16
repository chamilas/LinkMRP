using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SESD.MRP.REF;
using DL;


namespace MRP_GUI
{
    public partial class frmMaterialSelection : System.Windows.Forms.Form
    {
        public frmMaterialSelection(string _MatCatID)
        {
            InitializeComponent();
            MatCatID = _MatCatID;
        }

        string _SelectedItemCode;
        string MatCatID;

        DataTable dtItems = new DataTable();
        Material_DL objMaterial_DL = new Material_DL(ConnectionStringClass.GetConnection());


        public string SelectedItemCode
        {

            set { _SelectedItemCode = value; }
            get { return _SelectedItemCode; }

        }

    

        private void ReLoad(string search)
        {
            try
            {

                dtItems = objMaterial_DL.GetData_Search(search,(int)Material.Status.Enable,MatCatID);

              objSource.DataSource = dtItems;


              dgvItems.AutoGenerateColumns = false;
              objSource.DataSource = dtItems;
              dgvItems.DataSource = objSource;
              objSource.ResetBindings(true);


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex); ;
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                dgvItems.Focus();
                dgvItems.Rows[0].Selected = true;
            }
        }

        private void dgvMaterialList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;

                if (dgvItems.CurrentRow.Cells["MaterialCode"].Value != null)
                {
                    SelectedItemCode = Convert.ToString(dgvItems.CurrentRow.Cells["MaterialCode"].Value);

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

        private void frmSupplierSelection_Load(object sender, EventArgs e)
        {
            ReLoad("");
        }

        private void txtItemName_TextChanged(object sender, EventArgs e)
        {
            ReLoad(txtItemName.Text);
        }

        private void txtItemName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                dgvItems.Focus();
                dgvItems.Rows[0].Selected = true;
            }
        }

        private void dgvItems_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;

                if (dgvItems.CurrentRow.Cells["MaterialCode"].Value != null)
                {
                    SelectedItemCode = Convert.ToString(dgvItems.CurrentRow.Cells["MaterialCode"].Value);

                }

                this.Close();
            }
        }

    }
}
