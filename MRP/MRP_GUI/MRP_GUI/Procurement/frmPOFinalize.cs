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
    public partial class frmPOFinalize : System.Windows.Forms.Form
    {
        public frmPOFinalize(User objUser, string _POType)
        {
            InitializeComponent();
            CurrentUser = objUser;
            POType = _POType;

        }

        User CurrentUser = new User();
        string POType = "";
        Supplier_DL objSupplier_DL = new Supplier_DL(ConnectionStringClass.GetConnection());
        Material_DL objMaterial_DL = new Material_DL(ConnectionStringClass.GetConnection());
        PO_DL objPO_DL = new PO_DL(ConnectionStringClass.GetConnection());
        POMaterials_DL objPOMaterials_DL = new POMaterials_DL(ConnectionStringClass.GetConnection());

        POMaterialsCollec objPOMaterialsCollec = new POMaterialsCollec();

        Supplier objSupplier = new Supplier();
        DataTable dtPO = new DataTable();
        DataTable dtPOMaterialList = new DataTable();




        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void POEntering_Load(object sender, EventArgs e)
        {
            Load_Data();
        }

        private void Load_Data()
        {
            try
            {
                dtPO = objPO_DL.GetView_Search(POType, "");

                gvPOList.AutoGenerateColumns = false;
                objSource.DataSource = dtPO;
                gvPOList.DataSource = objSource;
                objSource.ResetBindings(true);


            }
            catch (Exception ex)
            {

            }
        }

        private void gvPOList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dtPOMaterialList = objPOMaterials_DL.Get_ByPOID_Detail(gvPOList.CurrentRow.Cells["PONO"].Value.ToString());

                objSourceMaterialList.DataSource = dtPOMaterialList;
                gvMaterialList.AutoGenerateColumns = false;
                gvMaterialList.DataSource = objSourceMaterialList;
                objSourceMaterialList.ResetBindings(true);
               
            }
            catch (Exception ex)
            {

            }
        }

        private void btnFinalize_Click(object sender, EventArgs e)
        {
            try
            {
                PO objPO = new PO();
                objPO = objPO_DL.Get(gvPOList.CurrentRow.Cells["PONO"].Value.ToString());

                objPO.POStatus = 1;
                objPO.POChangedBy = CurrentUser.EmployeeID;

                objPO_DL.Update_Finalize(objPO);

                Load_Data();

                DataGridViewCellEventArgs ee = new DataGridViewCellEventArgs(1, 0);

                gvPOList_CellClick(sender, ee);


            }
            catch (Exception ex)
            {

            }
        }

    }
}
