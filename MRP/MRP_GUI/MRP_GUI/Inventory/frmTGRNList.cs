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
    public partial class frmTGRNList : System.Windows.Forms.Form
    {
        public frmTGRNList(User objUser,string _cat)
        {
            InitializeComponent();
            CurrentUser = objUser;
            Cat = _cat;
        }

        User CurrentUser = new User();

        DataTable dtDeliverNotes = new DataTable();
        String Cat = "";

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


        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            
            if (keyData == Keys.Escape)
            {
                this.Close();
            }

            // Call the base class
            return base.ProcessCmdKey(ref msg, keyData);
        }





    }
}
