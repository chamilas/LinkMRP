using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DL;
using SESD.MRP.REF;

namespace MRP_GUI
{
    public partial class frmGRN : System.Windows.Forms.Form
    {

        public frmGRN(User objUser,string _storeID,string _matCat)
        {
            InitializeComponent();
            CurrentUser = objUser;
            StoreID = _storeID;
            MatCat = _matCat;
        }



        private User _objCurrentUser;

        public User CurrentUser
        {
            get { return _objCurrentUser; }
            set { _objCurrentUser = value; }
        }

        Department_DL objDepartmentDL = new Department_DL(ConnectionStringClass.GetConnection());
        Store_DL objStoreDL = new Store_DL(ConnectionStringClass.GetConnection());
        DeliverNote_DL objDeliverNote_DL = new DeliverNote_DL(ConnectionStringClass.GetConnection());
        DeliverNoteMaterials_DL objDeliverNoteMaterials_DL = new DeliverNoteMaterials_DL(ConnectionStringClass.GetConnection());
        Supplier_DL objSupplier_DL = new Supplier_DL(ConnectionStringClass.GetConnection());

        Department objDepartment = new Department();
        Store objStore = new Store();
        Material_DL objMaterialDL = new Material_DL(ConnectionStringClass.GetConnection());

        GRN objGRN = new GRN();
        GRN_Payment objGRN_Payment = new GRN_Payment();
        GRN_DL objGRNDL = new GRN_DL(ConnectionStringClass.GetConnection());
        GRN_Payment_DL objGRN_Payment_DL = new GRN_Payment_DL(ConnectionStringClass.GetConnection());

        GRNMaterials objGRNMaterials = new GRNMaterials();

        GRNMaterialsCollec objGRNMaterialsCollec = new GRNMaterialsCollec();

        GRNMaterials_DL objGRNMaterialsDL = new GRNMaterials_DL(ConnectionStringClass.GetConnection());

        bool ItemSelect = false;
        string SelectedTGRN = "";
        string StoreID = "";
        string MatCat = "";

        DataTable dt = new DataTable();

        //--------------- Methods --------------------

       public void LoadDirect()
       {
           try
           {
               
                   objGRN.GRNType = GRN.Type.Material;
              
              
           }
           catch (Exception ex)
           {
                
               MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
       }

       

      

        private void frmGRNMATDirect_Load(object sender, EventArgs e)
        {
            try
            {
                objDepartment = objDepartmentDL.GetByDepType("STORE");

               LoadDirect();

               objStore = objStoreDL.Get(StoreID);

               txtDepartment.Text = objDepartment.DepName;
               txtStores.Text = objStore.StoreName;

            }
            catch (Exception ex)
            {
                
               MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

  

        private void txtUnitCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.Validate_2Decimals(sender, e);
        }

        private void txtDeliverNote_KeyDown(object sender, KeyEventArgs e)
        {
             try
            {
            if (e.KeyCode == Keys.Enter)
            {
                frmTGRNSelection objForm = new frmTGRNSelection(CurrentUser, MatCat);
                objForm.ShowDialog(this);
                SelectedTGRN = objForm.SelectedTGRN;

                Load_Data();

                txtDeliverNote.Text = dt.Rows[0]["DeliverNoteNo"].ToString();
                txtSupplier.Text =objSupplier_DL.Get(Convert.ToInt64(dt.Rows[0]["SupplierCode"])).SupplieName;
                txtDeliverNote.ReadOnly = true;
                txtPONo.Select();
                txtRemarks.Text = dt.Rows[0]["Remarks"].ToString();

                
            }

            }
             catch (Exception ex)
             {

                 MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
        }

        private void Load_Data()
        {
            if (SelectedTGRN != null)
            {
                dt = objDeliverNote_DL.GetData(SelectedTGRN);

                dgvItemList.AutoGenerateColumns = false;
                objSource.DataSource = dt;
                dgvItemList.DataSource = objSource;
                objSource.ResetBindings(true);

                txtPONo.Text = dt.Rows[0]["DeliverPONO"].ToString();

            }
        }

    

        private void txtPONo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtPONo.Text != "")
                {
                    dgvItemList.Focus();

                    dgvItemList.CurrentCell = dgvItemList.Rows[0].Cells["TGRNQuantity"];
                }
            }
        }


        private void dgvItemList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (dgvItemList.CurrentRow.Index!=-1)
                {
                    if (dgvItemList.CurrentRow.Cells["ID"].Value != null)
                    {
                        DeliverNoteMaterials obj = new DeliverNoteMaterials();

                        obj = objDeliverNoteMaterials_DL.Get(Convert.ToInt64(dgvItemList.CurrentRow.Cells["ID"].Value));

                        frmMRAResults objForm = new frmMRAResults(obj);
                        objForm.ShowDialog(this);

                    }
                }
                Load_Data();

                
            }
        }

        private void btnGRN_Click(object sender, EventArgs e)
        {
            DialogResult TheResult = MessageBox.Show(this, "Have you Finished Entering Details", "Confirmation", MessageBoxButtons.YesNo);

            if (TheResult == System.Windows.Forms.DialogResult.Yes)
            {
                int count = 0;
                bool CanRaiseGRN = false;

                foreach (DataGridViewRow dgr in dgvItemList.Rows)
                {
                    if (Convert.ToBoolean(dgr.Cells["Select"].Value) == true)
                    {
                        count = count + 1;


                    }

                    if (Convert.ToDecimal(dgr.Cells["Quantity"].Value) > 0)
                    {
                        if (Convert.ToDecimal(dgr.Cells["UnitPrice"].Value) > 0)
                        {
                            CanRaiseGRN = true;
                        }
                        else
                        {
                            if (Convert.ToBoolean(dgr.Cells["Select"].Value) == true)
                            {
                                MessageBox.Show(this, "There are some Unit Price With Zeros which is Not allowed", "Error", MessageBoxButtons.OK);
                            }

                        }
                    }
                    else
                    {
                        if (Convert.ToBoolean(dgr.Cells["Select"].Value) == true)
                        {
                            if (Convert.ToDecimal(dgr.Cells["Quantity"].Value) + Convert.ToDecimal(dgr.Cells["RejectQty"].Value) == Convert.ToDecimal(dgr.Cells["TGRNQuantity"].Value))
                            {
                                DeliverNoteMaterials obj = new DeliverNoteMaterials();
                                obj = objDeliverNoteMaterials_DL.Get(Convert.ToInt64(dgr.Cells["ID"].Value));
                                objDeliverNoteMaterials_DL.Update(obj);

                                Clear();
                            }
                            else
                            {
                                break;
                            }

                        }
                    }
                }





                if ((count > 0) && (CanRaiseGRN == true))
                {
                    GRN objGRN = new GRN();

                    objGRN.GRNEnterdBy = CurrentUser.EmployeeID;
                    objGRN.GRNStore = objStore;
                    objGRN.GRNType = GRN.Type.Material;
                    objGRN.GRNStatus = GRN.Status.Initial;
                    objGRN.GRNCategory = 0;


                    int newGRNNO = objGRNDL.Add_Direct_TGRN(objGRN, txtDeliverNote.Text, txtPONo.Text);

                    objGRN.GRNNo = newGRNNO;

                    foreach (DataGridViewRow dgr in dgvItemList.Rows)
                    {
                        if (Convert.ToBoolean(dgr.Cells["Select"].Value) == true)
                        {
                            if (Convert.ToDecimal(dgr.Cells["Quantity"].Value) > 0)
                            {
                                if (Convert.ToDecimal(dgr.Cells["UnitPrice"].Value) > 0)
                                {
                                    objGRNMaterials.GRN = objGRN;
                                    objGRNMaterials.Material = objMaterialDL.Get(Convert.ToString(dgr.Cells["MaterialCode"].Value));
                                    objGRNMaterials.GrossQty = Convert.ToDecimal(dgr.Cells["Quantity"].Value);
                                    objGRNMaterials.NetQty = Convert.ToDecimal(dgr.Cells["Quantity"].Value);
                                    objGRNMaterials.UnitPrice = Convert.ToDecimal(dgr.Cells["UnitPrice"].Value);
                                    objGRNMaterials.Remarks = "No";


                                    objGRNMaterialsDL.Add_FromDeliverNote(objGRNMaterials, txtDeliverNote.Text);
                                }
                            }

                        }
                    }

                    MessageBox.Show(this, "Sucessfully GRN : GRNNO " + newGRNNO.ToString(), "Successful", MessageBoxButtons.OK);

                    Clear();
                }


            }



        }

        private void Clear()
        {
            txtDeliverNote.Text = "";
            txtPONo.Text = "";
            txtSupplier.Text = "";
            txtDeliverNote.ReadOnly = false;
            txtRemarks.Text = "";

            dt = null;

            dgvItemList.AutoGenerateColumns = false;
            objSource.DataSource = dt;
            dgvItemList.DataSource = objSource;
            objSource.ResetBindings(true);



            txtDeliverNote.Select();
        }


    }
}