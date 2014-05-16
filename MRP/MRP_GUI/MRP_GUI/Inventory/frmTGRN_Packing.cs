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
    public partial class frmTGRN_Packing : System.Windows.Forms.Form
    {
        public frmTGRN_Packing(User objUser)
        {
            InitializeComponent();
            CurrentUser = objUser;
        }

        User CurrentUser = new User();

        DataTable dtDeliverNotes = new DataTable();


        Material objMaterial = new Material();
        DeliverNoteMaterialsCollec objCollec = new DeliverNoteMaterialsCollec();

        Material_DL objMaterial_DL = new Material_DL(ConnectionStringClass.GetConnection());
        Employee_DL objEmployee_DL = new Employee_DL(ConnectionStringClass.GetConnection());
        DeliverNote_DL objDeliverNote_DL = new DeliverNote_DL(ConnectionStringClass.GetConnection());
        Supplier_DL objSupplier_DL = new Supplier_DL(ConnectionStringClass.GetConnection());


      
        private void txtMaterial_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                frmMaterialSelection objForm = new frmMaterialSelection("Packing");
                objForm.ShowDialog(this);


                objMaterial = objMaterial_DL.Get(objForm.SelectedItemCode);

                txtMaterial.Text = objMaterial.MaterialDescription;
              txtMaterialCode.Text = objMaterial.MaterialCode;

                txtQuantity.Select();
                lblUnit.Text = objMaterial.MatUnit.UnitCode;

            }
        }

        private void frmTGRN_Load(object sender, EventArgs e)
        {
            //Load_Data();
        }

        private void Load_Data()
        {
            try
            {

                DeliverNoteMaterials obj = new DeliverNoteMaterials();
                bool DuplicateFound = false;
              

                obj.AcceptQty = 0;
                obj.ActualReceivedQty = 0;
                obj.DeleverdMaterialQty = Convert.ToDecimal(txtQuantity.Text);
                obj.MaterialCode = objMaterial.MaterialCode;
                obj.MaterialName = objMaterial.MaterialDescription;
                obj.RejectQty = 0;
                obj.RejectRemarks = "No";
                obj.ReworkQty = 0;
                obj.ReworkRemarks = "No";
                obj.ReworkUnitPrice = 0;
                obj.Unit = objMaterial.MatUnit.UnitCode;
                

                foreach (DeliverNoteMaterials dn in objCollec)
                {
                    if (dn.MaterialCode == obj.MaterialCode)
                    {
                        DuplicateFound = true;
                        break;
                    }
                }

                if(DuplicateFound==false)
                {
                    if (obj.DeleverdMaterialQty > 0)
                    {
                        objCollec.Add(obj);
                    }
                    else
                    {
                        MessageBox.Show(this, "Can not GRN to Zero Qty", "Wrong Attempt", MessageBoxButtons.OK);
                    }

                }


                dgvDeliverNoteList.AutoGenerateColumns = false;
               
                objSourceDeliverNotes.DataSource = objCollec;
                dgvDeliverNoteList.DataSource = objSourceDeliverNotes;
                objSourceDeliverNotes.ResetBindings(true);



            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex); ;
            }
        }
        

        private void txtQuantity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtQuantity.Text != "")
                {

                    txtRemarks.Select();
                }
                

            }
        }


protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
{
    if (keyData == Keys.End)
    {

        DialogResult TheResult= MessageBox.Show(this, "Have you Finished Entering Details", "Confirmation", MessageBoxButtons.YesNo);

        if (TheResult == System.Windows.Forms.DialogResult.Yes)
        {
            if (objCollec.Count > 0)
            {
                DeliverNoteMaterials_DL objDeliverNoteMaterials_DL = new DeliverNoteMaterials_DL(ConnectionStringClass.GetConnection());

                DeliverNote obj = new DeliverNote();

                obj.DeleveryNoteID = txtDeliverNote.Text;
                obj.DeleveryNoteEnterdBy = objEmployee_DL.Get(CurrentUser.EmployeeID);
                obj.DeleveryNoteStatus = DeliverNote.Status.Initial;
                obj.DeleveryNoteDate = DateTime.Today;
                obj.DeleveryNotePO = "N/A";
                obj.Remarks = txtRemarks.Text;
                obj.Supplier = Convert.ToInt64(txtSupplierCode.Text);

                objDeliverNote_DL.Add(obj);


                foreach (DeliverNoteMaterials tmpobj in objCollec)
                {
                    tmpobj.DeliverNote = obj.DeleveryNoteID;

                    objDeliverNoteMaterials_DL.Add(tmpobj);
                }

                objCollec = null;

                dgvDeliverNoteList.AutoGenerateColumns = false;

                objSourceDeliverNotes.DataSource = objCollec;
                dgvDeliverNoteList.DataSource = objSourceDeliverNotes;
                objSourceDeliverNotes.ResetBindings(true);

                txtDeliverNote.Text = "";
                txtDeliverNote.Select();
            }

        }

    


        return true;    // indicate that you handled this keystroke
    }

    if (keyData == Keys.F1)
    {
        frmTGRNList objForm = new frmTGRNList(CurrentUser,"Packing");
        objForm.ShowDialog(this);
    }


    if (keyData == Keys.Escape)
    {
        DialogResult Result = MessageBox.Show(this, "Do you want to Exit", "Confirm", MessageBoxButtons.YesNo);

        if (Result == System.Windows.Forms.DialogResult.Yes)
        {

            this.Close();
        }
    }
    // Call the base class
    return base.ProcessCmdKey(ref msg, keyData);
}

private void txtDeliverNote_KeyDown(object sender, KeyEventArgs e)
{
    if (e.KeyCode == Keys.Enter)
    {
        if (txtDeliverNote.Text != "")
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtSupplier.Select();
            }
        }
    }
}

private void txtSupplier_KeyDown(object sender, KeyEventArgs e)
{
    if (e.KeyCode == Keys.Enter)
    {
        frmSupplierSelection objForm = new frmSupplierSelection("Packing");
        objForm.ShowDialog(this);

        Supplier objSupplier = new Supplier();


        objSupplier = objSupplier_DL.Get(objForm.SelectedSupplier);

        txtSupplierCode.Text = objSupplier.SupplierID.ToString();
        txtSupplier.Text = objSupplier.SupplieName;
        txtMaterial.Select();


    }
}

private void txtRemarks_KeyDown(object sender, KeyEventArgs e)
{
    if (e.KeyCode == Keys.Enter)
    {
        Load_Data();

        txtMaterial.Text = "";
        txtMaterialCode.Text = "";
        txtQuantity.Text = "";
        txtRemarks.Text = "";
        txtSupplier.Text = "";
        

        txtMaterial.Select();
    }
}




    }
}
