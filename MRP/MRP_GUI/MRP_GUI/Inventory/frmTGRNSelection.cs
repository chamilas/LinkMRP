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
    public partial class frmTGRNSelection : System.Windows.Forms.Form
    {
        public frmTGRNSelection(User objUser,string _cat)
        {
            InitializeComponent();
            CurrentUser = objUser;
            Cat = _cat;
        }

        string _SelectedTGRN;

        public string SelectedTGRN
        {

            set { _SelectedTGRN = value; }
            get { return _SelectedTGRN; }

        }



        User CurrentUser = new User();
        String Cat;

        DataTable dtDeliverNotes = new DataTable();

        DeliverNoteMaterials_DL objDeliverNoteMaterials_DL = new DeliverNoteMaterials_DL(ConnectionStringClass.GetConnection());
        DeliverNoteMaterials objDeliverNoteMaterials = new DeliverNoteMaterials();

        DeliverNote_DL objDeliverNote_DL = new DeliverNote_DL(ConnectionStringClass.GetConnection());


        private void frmTGRN_Load(object sender, EventArgs e)
        {
            Load_Data();
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




    }
}
