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
    public partial class frmMRReceive_toDep : System.Windows.Forms.Form
    {
        public frmMRReceive_toDep()
        {
            InitializeComponent();
        }

        public frmMRReceive_toDep(User objUser)
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
        UserDepartments_DL objUserDepartments_DL = new UserDepartments_DL(ConnectionStringClass.GetConnection());

        MR objMR = new MR();
        MR_DL objMRDL = new MR_DL(ConnectionStringClass.GetConnection());
        MRMaterial_DL objMRMaterialDL = new MRMaterial_DL(ConnectionStringClass.GetConnection());
        MRMaterialCollec objMRMaterialCollec = new MRMaterialCollec();


        MRMaterial objMRMaterial = new MRMaterial();
        Department objDepartment = new Department();
        Store objStore = new Store();

        DataTable dt = new DataTable();

        bool ItemSelect = false;
        //-------------------Methods------------------------
        public void Clear()
        {
            txtDepartment.Text = "";
            ItemSelect = false;

        }

        //-------------------Events ------------------------
        private void frmMaterialsReceipt_Load(object sender, EventArgs e)
        {
            try
            {

                dt = objUserDepartments_DL.Get_Default(CurrentUser.UserID);
                objDepartment=objDepDL.Get(Convert.ToInt64((dt.Rows[0]["Department"])));
                objStore=objStoreDL.Get_Default(objDepartment.DepID);
               
                txtDepartment.Text =objDepartment.DepName;
                txtStore.Text = objStore.StoreID;

                Load_MRList();

                

            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Load_MRItem()
        {
            if (gvMRList.SelectedRows.Count > 0)
            {
                try
                {
                    //if (e.RowIndex >= 0)
                    {
                        bindItemList.DataSource = null;
                        long MRNO = Convert.ToInt64(gvMRList.SelectedRows[0].Cells["MRNO"].Value);
                        MR objMRTemp = objMRDL.Get(MRNO);

                        objMR = new MR();
                        objMR = objMRTemp;

                        DataTable dt = objMRMaterialDL.GetDataView(objMRTemp.MRNO);
                        bindItemList.DataSource = dt;

                        gvItemList.AutoGenerateColumns = false;
                        gvItemList.DataSource = bindItemList;
                        bindItemList.ResetBindings(true);

                        txtDepartment.Text = objMR.MRDepartmentFrom.DepName;

                        ItemSelect = true;

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Load_MRList()
        {
                DataTable MRList = objMRDL.GetDataView(CurrentUser.UserID, MR.Status.Issued, MR.Origin.ToDepartment);

                bindMRList.DataSource = MRList;
                gvMRList.AutoGenerateColumns = false;
                gvMRList.DataSource = bindMRList;
                bindMRList.ResetBindings(true);
           
        }


        private void ClearMRItemGrid()
        {
            if (gvMRList.Rows.Count == 0)
            {
                bindItemList.DataSource = null;
                bindItemList.ResetBindings(true);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void gvMRList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    bindItemList.DataSource = null;
                    long MRNO = Convert.ToInt64(gvMRList.Rows[e.RowIndex].Cells["MRNO"].Value);
                    MR objMRTemp = objMRDL.Get(MRNO);

                    objMR = new MR();
                    objMR = objMRTemp;


                    Load_MRItem();
                   

                    txtDepartment.Text = objMR.MRDepartmentFrom.DepName;

                    ItemSelect = true;

                    Section_DL objSectionDL = new Section_DL(ConnectionStringClass.GetConnection());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                if (this.ItemSelect)
                {                
                    DialogResult dr = MessageBox.Show(this,"Are you sure you want received selected Material Requisition?\n\nClick Yes to Receive","Confirmation",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2);
                    if (dr == DialogResult.Yes)
                    {
                        objMR.MRReceivedBy = CurrentUser.UserEmp.EmployeeID;
                        objMR.MRStatus = MR.Status.Recevied;

                        int x = objMRDL.Update_Received(objMR);

                        Load_MRList();
                        Load_MRItem();
                       
                    }

                }
                else
                {
                    MessageBox.Show(this, "Please Select a Material Requition", "Selection Empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Error occured while Receiving", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}