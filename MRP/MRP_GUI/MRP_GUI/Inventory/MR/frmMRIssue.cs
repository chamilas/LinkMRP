using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SESD.MRP.REF;
using DL;

namespace MRP_GUI
{
    public partial class frmMRIssue : System.Windows.Forms.Form
    {
        public frmMRIssue()
        {
            InitializeComponent();
        }

        public frmMRIssue(User objUser)
        {
            InitializeComponent();
            CurrentUser = objUser;
        }
        //-------------------- Variables ---------------------


        private User _objCurrentUser;

        public User CurrentUser
        {
            get { return _objCurrentUser; }
            set { _objCurrentUser = value; }
        }
        Department_DL objDepDL = new Department_DL(ConnectionStringClass.GetConnection());
        Store_DL objStoreDL = new Store_DL(ConnectionStringClass.GetConnection());
        Material_DL objMaterialDL = new Material_DL(ConnectionStringClass.GetConnection());
       

        MR objMR = new MR();
        MR_DL objMRDL = new MR_DL(ConnectionStringClass.GetConnection());
        
        MRMaterial_DL objMRMaterialDL = new MRMaterial_DL(ConnectionStringClass.GetConnection());
        MRBasicProduct_DL objMRBasicProduct_DL = new MRBasicProduct_DL(ConnectionStringClass.GetConnection());
        MRMaterialCollec objMRMaterialCollec = new MRMaterialCollec();
        MRFinishProduct_DL objMRFinishProductDL = new MRFinishProduct_DL(ConnectionStringClass.GetConnection());

        MRMaterial objMRMaterial = new MRMaterial();
       
        bool ItemSelect = false;
        //-------------------Methods------------------------
        public void Clear()
        {
            txtapprovedBy.Text = "";
            txtApprovedDate.Text = "";
            txtDate.Text = "";
            txtDepartment.Text = "";
            txtMRNO.Text = "";
            txtRemarks.Text = "";
            txtRequestedBy.Text = "";
            txtRequestedDate.Text = "";
            ItemSelect = false;

        }

        //-------------------Events ------------------------
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMRIssue_Load(object sender, EventArgs e)
        {
            try
            {

                cmbStore.DataSource = objStoreDL.Get_By_User(CurrentUser.UserID);

            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cmbStore_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                bindMRList.DataSource = null;
                Store objStore = (Store)cmbStore.SelectedItem;
                if (objStore != null)
                {
                    bindMRList.DataSource = objMRDL.GetDataView(objStore.StoreID, MR.Status.Approved);

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gvMRList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    bindItemList.DataSource = null;
                    long MRNO = Convert.ToInt64(gvMRList.Rows[e.RowIndex].Cells[0].Value);
                    MR objMRTemp = objMRDL.Get(MRNO);

                    objMR = new MR();
                    objMR = objMRTemp;

                 //   objMRTemp.MRType = MR.Type.Material;

                    if (objMRTemp.MRType == MR.Type.Material)
                    {
                        bindItemList.DataSource = objMRMaterialDL.Get(objMRTemp.MRNO);
                    }

                    if (objMRTemp.MRType == MR.Type.BasicProduct)
                    {
                        bindItemList.DataSource = objMRBasicProduct_DL.Get(objMRTemp.MRNO);
                    }

                    if (objMRTemp.MRType == MR.Type.FinishProduct)
                    {
                        bindItemList.DataSource = objMRFinishProductDL.GetDataView(objMRTemp.MRNO);
                    }

                    txtapprovedBy.Text = objMR.MRApprovedBy;
                    txtApprovedDate.Text = objMR.MRApprovedDate.ToShortDateString();
                    txtDate.Text = objMR.MRDate.ToShortDateString();
                    txtDepartment.Text = objMR.MRDepartmentFrom.DepName;
                    txtMRNO.Text = objMR.MRNO.ToString();
                    txtRemarks.Text = objMR.MRRemarks;
                    txtRequestedBy.Text = objMR.MREnterdBy;
                    txtRequestedDate.Text = objMR.MRDate.ToShortDateString();

                    ItemSelect = true;

                    if (objMR.Print == true)
                    {
                        btnPrint.Enabled = false;
                    }
                    else
                    {
                        btnPrint.Enabled = true;
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gvItemList_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.Exception.Message.Equals("Qty"))
            {
               MessageBox.Show(this,"You can't Issue more than Requested","Enter Valid Data",MessageBoxButtons.OK,MessageBoxIcon.Information);

           }
           else
           {
                MessageBox.Show(this,"Please Enter a valid numeric value or Press Esc to Cancel Edit","Enter Valid Data",MessageBoxButtons.OK,MessageBoxIcon.Information);
                gvItemList.Rows[e.RowIndex].ErrorText = "Please Enter a valid numeric value or Press Esc to Cancel Edit";

           }
        }

        private void gvItemList_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            gvItemList.Rows[e.RowIndex].ErrorText = String.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dresutl = MessageBox.Show(this,"Are you sure you want to Issue Items for selected Material Requsition?\n\nClick Yes to Issue","Confirmation",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2);
                if (dresutl == DialogResult.Yes)
                {
                    if (cmbStore.Items.Count > 0)
                    {
                        Store objStore = (Store)cmbStore.SelectedItem;
                        if (this.ItemSelect)
                        {
                            if (objMR.MRType == MR.Type.Material)
                            {
                                bool isZero = false;
                                bool Transfer = true;
                                int Stock = 0;
                                int zerocount = 0;
                                foreach (DataGridViewRow dr in gvItemList.Rows)
                                {
                                    MRMaterial objMRMat = new MRMaterial();
                                    objMRMat = (MRMaterial)dr.DataBoundItem;
                                    Stock = objMRMaterialDL.Get_StockByStore(objStore.StoreID, objMRMat.Material.MaterialCode, objMRMat.IssuedQty);
                                    if (Stock == 0 && objMRMat.IssuedQty != 0)
                                    {
                                        MessageBox.Show(this, objMRMat.Material.MaterialCode + " Stock is lower than Issued Quantity,Please enter lower quantity", "Stock is not Enough", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        Transfer = false;
                                        break;
                                    }

                                    if (objMRMat.IssuedQty == 0)
                                    {
                                        isZero = true;
                                        zerocount++;
                                    }
                                }
                                if (Transfer)
                                {
                                    DialogResult drRes;
                                    if (zerocount >= gvItemList.Rows.Count)
                                    {
                                        MessageBox.Show(this, "Please enter a Issue Quantity", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }
                                    else
                                    {



                                        if (isZero)
                                        {
                                            drRes = MessageBox.Show(this, "One more items does not have a quantity, Do you want to continue\n\nClick Yes to continue", "Empty Quantities", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                                            if (drRes == DialogResult.Yes)
                                            {
                                                foreach (DataGridViewRow dr in gvItemList.Rows)
                                                {
                                                    MRMaterial objMRMat = new MRMaterial();
                                                    objMRMat = (MRMaterial)dr.DataBoundItem;
                                                    objMRMaterialDL.Issue(objMRMat, objStore.StoreID);
                                                }
                                                objMR.MRIssuedBy = CurrentUser.UserEmp.EmployeeID;
                                                objMR.MRStatus = MR.Status.Issued;
                                                int x = objMRDL.Update_Issue(objMR);
                                                if (x > 0)
                                                {
                                                    bindItemList.DataSource = null;
                                                    Clear();

                                                    if (objStore != null)
                                                    {
                                                        bindMRList.DataSource = objMRDL.GetDataView(objStore.StoreID, MR.Status.Approved);

                                                    }
                                                }
                                            }
                                        }
                                        else
                                        {
                                            foreach (DataGridViewRow dr in gvItemList.Rows)
                                            {
                                                MRMaterial objMRMat = new MRMaterial();
                                                objMRMat = (MRMaterial)dr.DataBoundItem;
                                                objMRMaterialDL.Issue(objMRMat, objStore.StoreID);
                                            }
                                            objMR.MRIssuedBy = CurrentUser.UserEmp.EmployeeID;
                                            objMR.MRStatus = MR.Status.Issued;
                                            int x = objMRDL.Update_Issue(objMR);
                                            if (x > 0)
                                            {
                                                bindItemList.DataSource = null;
                                                Clear();

                                                if (objStore != null)
                                                {
                                                    bindMRList.DataSource = objMRDL.GetDataView(objStore.StoreID, MR.Status.Approved);

                                                }
                                            }
                                        }
                                    }
                                    
                                }
                            }

                            if (objMR.MRType == MR.Type.BasicProduct)
                            {
                                IssueSemiFinished();
                            }
                           
                        }
                        else
                        {
                            MessageBox.Show(this, "Please Select a Material Requition", "Selection Empty", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show(this,"Stores list is empty","Empty List",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    }

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void IssueSemiFinished()
        {
            if (cmbStore.Items.Count > 0)
            {
                Store objStore = (Store)cmbStore.SelectedItem;
                if (this.ItemSelect)
                {
            if (objMR.MRType == MR.Type.BasicProduct)
            {
                bool isZero = false;
                bool Transfer = true;
                int Stock = 0;
                int zerocount = 0;
                foreach (DataGridViewRow dr in gvItemList.Rows)
                {
                    MRBasicProduct objMRSemi = new MRBasicProduct();
                    objMRSemi = (MRBasicProduct)dr.DataBoundItem;
                    Stock =objMRBasicProduct_DL.Get_StockByStore(objStore.StoreID, objMRSemi.BasicProduct.BasicProductCode, objMRSemi.IssuedQty);
                    if (Stock == 0 && objMRSemi.IssuedQty != 0)
                    {
                        MessageBox.Show(this, objMRSemi.BasicProduct.BasicProductCode + " Stock is lower than Issued Quantity,Please enter lower quantity", "Stock is not Enough", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Transfer = false;
                        break;
                    }

                    if (objMRSemi.IssuedQty == 0)
                    {
                        isZero = true;
                        zerocount++;
                    }
                }
                if (Transfer)
                {
                    DialogResult drRes;
                    if (zerocount >= gvItemList.Rows.Count)
                    {
                        MessageBox.Show(this, "Please enter a Issue Quantity", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {



                        if (isZero)
                        {
                            drRes = MessageBox.Show(this, "One more items does not have a quantity, Do you want to continue\n\nClick Yes to continue", "Empty Quantities", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                            if (drRes == DialogResult.Yes)
                            {
                                foreach (DataGridViewRow dr in gvItemList.Rows)
                                {
                                    MRBasicProduct objMRSemi = new MRBasicProduct();
                                    objMRSemi = (MRBasicProduct)dr.DataBoundItem;
                                  objMRBasicProduct_DL.Issue(objMRSemi, objStore.StoreID);
                                }
                                objMR.MRIssuedBy = CurrentUser.UserEmp.EmployeeID;
                                objMR.MRStatus = MR.Status.Issued;

                                int x = objMRDL.Update_Issue(objMR);
                                if (x > 0)
                                {
                                    bindItemList.DataSource = null;
                                    Clear();

                                    if (objStore != null)
                                    {
                                        bindMRList.DataSource = objMRDL.GetDataView(objStore.StoreID, MR.Status.Approved);

                                    }
                                }
                            }
                        }
                        else
                        {
                            foreach (DataGridViewRow dr in gvItemList.Rows)
                            {
                                MRBasicProduct objMRSemi = new MRBasicProduct();
                                objMRSemi = (MRBasicProduct)dr.DataBoundItem;
                                objMRBasicProduct_DL.Issue(objMRSemi, objStore.StoreID);
                            }
                            objMR.MRIssuedBy = CurrentUser.UserEmp.EmployeeID;
                            objMR.MRStatus = MR.Status.Issued;
                            int x = objMRDL.Update_Issue(objMR);
                            if (x > 0)
                            {
                                bindItemList.DataSource = null;
                                Clear();

                                if (objStore != null)
                                {
                                    bindMRList.DataSource = objMRDL.GetDataView(objStore.StoreID, MR.Status.Approved);

                                }
                            }
                        }
                    }

                }
            }
        }
    }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            frmMRPrint objForm = new frmMRPrint(CurrentUser, Convert.ToInt64(gvMRList.CurrentRow.Cells["MRNO"].Value.ToString()));
            objForm.WindowState = FormWindowState.Maximized;
            objForm.ShowDialog(this);

        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            try
            {
                if (objMR != null)
                {
                    DialogResult dr = MessageBox.Show(this, "Are you sure you want to Reject selected MR?\n\nClick yes to reject", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        objMR.MRStatus = MR.Status.Reject;
                        objMR.MRApprovedBy = CurrentUser.UserEmp.EmployeeID;
                        int x = objMRDL.Update_Approve(objMR);
                        if (x > 0)
                        {
                            MessageBox.Show(this, "Material Requition Rejected", "Rejected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Clear();

                            Store objStore = (Store)cmbStore.SelectedItem;

                            if (objStore != null)
                            {
                                bindMRList.DataSource = objMRDL.GetDataView(objStore.StoreID, MR.Status.Approved);

                                if (objMRDL.GetDataView(objStore.StoreID, MR.Status.Approved).Rows.Count==0)
                                {
                                    gvItemList.AutoGenerateColumns = false;
                                    bindItemList.DataSource = null;
                                    gvItemList.DataSource = bindItemList;
                                    bindItemList.ResetBindings(true);
                                }

                            }

                        }
                    }
                }
                else
                {
                    MessageBox.Show(this, "Please select a MR before click Reject", "Select a MR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}