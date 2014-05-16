using System;
using System.Windows.Forms;
using DL;
using SESD.MRP.REF;

namespace MRP_GUI
{
    public partial class frmMTNReceiveGRN_Rejects : System.Windows.Forms.Form
    {
        private User _objCurrentUser;

        public User CurrentUser
        {
            get { return _objCurrentUser; }
            set { _objCurrentUser = value; }
        }

        private MTN_DL objMTNDL = new MTN_DL(ConnectionStringClass.GetConnection());
        private Department_DL objDepDL = new Department_DL(ConnectionStringClass.GetConnection());
        private Store_DL objStoreDL = new Store_DL(ConnectionStringClass.GetConnection());
        private MTN objMTN = new MTN();
        private GRN_DL objGRNDL = new GRN_DL(ConnectionStringClass.GetConnection());
        private MTNMaterial_DL objMTNMaterialDL = new MTNMaterial_DL(ConnectionStringClass.GetConnection());
        private MTNBasicProduct_DL objMTNBasicProductDL = new MTNBasicProduct_DL(ConnectionStringClass.GetConnection());
        private MTNFinishProduct_DL objMTNFinishProductDL = new MTNFinishProduct_DL(ConnectionStringClass.GetConnection());
        private GRNBasicProducts_DL objGRNBasicDL = new GRNBasicProducts_DL(ConnectionStringClass.GetConnection());
        private GRNMaterials_DL objGRNMatDL = new GRNMaterials_DL(ConnectionStringClass.GetConnection());
        private GRNFinishProducts_DL objGRNFinishDL = new GRNFinishProducts_DL(ConnectionStringClass.GetConnection());
        private Material_DL objMaterialDL = new Material_DL(ConnectionStringClass.GetConnection());
        private BasicProduct_DL objBasicProductDL = new BasicProduct_DL(ConnectionStringClass.GetConnection());
        private FinishProduct_DL objFinishProductDL = new FinishProduct_DL(ConnectionStringClass.GetConnection());

        Store objStore = new Store();

        public frmMTNReceiveGRN_Rejects(User objUser)
        {
            InitializeComponent();
            CurrentUser = objUser;
        }

        private void frmMTNReceiveGRN_Load(object sender, EventArgs e)
        {
            try
            {
                objStore = objStoreDL.Get("Rejects");

                bindMTNList.DataSource = objMTNDL.Get_From_Rejects(Convert.ToInt64(MTN.Type.Reject), Convert.ToInt32(MTN.Status.Received));

            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(this, "Are you sure you want to close? Click Yes to close", "Confirm Closing", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
        }





        private void btnGRN_Click(object sender, EventArgs e)
        {
            try
            {

                objMTN = objMTNDL.Get(objMTN.MTNNo);

                if (objMTN.MTNStatus == MTN.Status.Received)
                {

                    if ((objMTN != null) && (objStore != null))
                    {


                        if (objMTN.MTNItemType == MTN.ItemType.Material)
                        {
                            long GRNNO = objMTNDL.AddGRN(objMTN.MTNNo,MTN.Status.ReceviedGRN, CurrentUser.EmployeeID, objStore.StoreID, GRN.Type.Material, GRN.Status.Initial);
                            MessageBox.Show(this, "Successfully Raised a GRN. The GRNNO is : " + GRNNO.ToString(), "Successful", MessageBoxButtons.OK);
                        }

                        bindMTNList.DataSource = objMTNDL.Get_From_Rejects(Convert.ToInt64(MTN.Type.Reject), Convert.ToInt32(MTN.Status.Received));

                        if (gvMTNList.Rows.Count > 0)
                        {
                            DataGridViewCellEventArgs dr = new DataGridViewCellEventArgs(1, 0);

                            gvMTNList_CellClick(sender, dr);
                        }
                        else
                        {
                            bindItemList.DataSource = null;
                        }


                    }
                }



            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gvMTNList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    objMTN = objMTNDL.Get(Convert.ToInt64(gvMTNList.Rows[e.RowIndex].Cells["colMTN"].Value));
                    if (objMTN != null)
                    {
                        bindItemList.DataSource = objMTNDL.GetDataView(objMTN.MTNNo);
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


    }
}