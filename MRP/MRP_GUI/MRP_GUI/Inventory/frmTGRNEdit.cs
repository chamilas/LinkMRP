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
    public partial class frmTGRNEdit : System.Windows.Forms.Form
    {
        public frmTGRNEdit(User objUser)
        {
            InitializeComponent();
            CurrentUser = objUser;
        }

        string _SelectedTGRN;

        public string SelectedTGRN
        {

            set { _SelectedTGRN = value; }
            get { return _SelectedTGRN; }

        }



        User CurrentUser = new User();
        String Cat="Raw";

        DataTable dtDeliverNotes = new DataTable();
        DataTable dtMaterials = new DataTable();

        DeliverNoteMaterials_DL objDeliverNoteMaterials_DL = new DeliverNoteMaterials_DL(ConnectionStringClass.GetConnection());
        DeliverNoteMaterials objDeliverNoteMaterials = new DeliverNoteMaterials();

        DeliverNote_DL objDeliverNote_DL = new DeliverNote_DL(ConnectionStringClass.GetConnection());
        Material_DL objMaterial_DL = new Material_DL(ConnectionStringClass.GetConnection());

        private void frmTGRN_Load(object sender, EventArgs e)
        {
            Load_Data();
            Load_Material();

        }

        private void Load_Data()
        {
            try
            {

                dtDeliverNotes = objDeliverNote_DL.GetData((int)DeliverNote.Status.Initial, Cat);

                objSourceDeliverNotes.DataSource = dtDeliverNotes;


                dgvDeliverNoteList.AutoGenerateColumns = false;
                objSourceDeliverNotes.DataSource = dtDeliverNotes;
                dgvDeliverNoteList.DataSource = objSourceDeliverNotes;
                objSourceDeliverNotes.ResetBindings(true);
               

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex); ;
            }
        }


        private void Load_Material()
        {
            try
            {

                dtMaterials = objMaterial_DL.GetDataView(Cat);

                objSourceMaterials.DataSource = dtMaterials;
                cmbMaterial.DataSource = objSourceMaterials;


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex); ;
            }
        }
                   


        private void dgvDeliverNoteList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;

                if (dgvDeliverNoteList.CurrentRow.Cells["_DeliverNote"].Value != null)
                {
                    SelectedTGRN = Convert.ToString(dgvDeliverNoteList.CurrentRow.Cells["_DeliverNote"].Value);

                }

                this.Close();
            }
        }

        private void dgvDeliverNoteList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                objDeliverNoteMaterials = objDeliverNoteMaterials_DL.Get(Convert.ToInt64(dgvDeliverNoteList.CurrentRow.Cells["ID"].Value));

                cmbMaterial.SelectedValue = objDeliverNoteMaterials.MaterialCode;
                txtQuantity.Text = objDeliverNoteMaterials.DeleverdMaterialQty.ToString();


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex); ;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                objDeliverNoteMaterials.MaterialCode = cmbMaterial.SelectedValue.ToString();
                objDeliverNoteMaterials.DeleverdMaterialQty = Convert.ToDecimal(txtQuantity.Text);

                objDeliverNoteMaterials_DL.Update_EditOnly(objDeliverNoteMaterials);

                Load_Data();

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex); ;
            }
        }

        private void chkRaw_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRaw.Checked == true)
            {
                chkLab.Checked = false;
                chkPacking.Checked = false;

                Cat = "Raw";

                Load_Data();
                Load_Material();
            }
        }

        private void chkPacking_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPacking.Checked == true)
            {
                chkRaw.Checked = false;
                chkLab.Checked = false;

                Cat = "Packing";

                Load_Data();
                Load_Material();
            }
        }

        private void chkLab_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLab.Checked == true)
            {
                chkRaw.Checked = false;
                chkPacking.Checked = false;

                Cat = "Lab";

                Load_Data();
                Load_Material();
            }
        }





    }
}
