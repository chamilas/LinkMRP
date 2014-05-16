using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DL;
using SESD.MRP.REF;

namespace MRP_GUI
{
    public partial class frmBatchPackingMR_RPD : System.Windows.Forms.Form
    {
        private User _objCurrentUser;

        public User CurrentUser
        {
            get { return _objCurrentUser; }
            set { _objCurrentUser = value; }
        }


        public frmBatchPackingMR_RPD(int _DepID,string _BatchID,User objUser)
        {
            InitializeComponent();
            DepID = _DepID;
            BatchID = _BatchID;
            CurrentUser = objUser;
        }

        BatchPackingMR_DL objBatchPackingMR_DL = new BatchPackingMR_DL(ConnectionStringClass.GetConnection());
        MRMaterial_DL objMRMaterial_DL = new MRMaterial_DL(ConnectionStringClass.GetConnection());
        Material_DL objMaterial_DL = new Material_DL(ConnectionStringClass.GetConnection());

        DataTable dt = new DataTable();

        int DepID;
        string BatchID = "";

        private void frmBatchPackingMR_Load(object sender, EventArgs e)
        {

            try
            {

                Load_MRList();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Load_MRList()
        {

            try
            {

                dt = objBatchPackingMR_DL.GetData_Packing_ToSection(DepID,(int)MR.Status.Recevied,(int)MR.Origin.ToSection);

                if (dt.Rows.Count > 0)
                {
                    objSource.DataSource = dt;
                    cmbMRNO.DataSource = objSource;
                }
                else
                {
                    objSource.DataSource = null;
                    cmbMRNO.DataSource = objSource;
                    txtQunatityReceived.Text = "";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cmbMRNO_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                BatchPackingMR obj = new BatchPackingMR();
                MRMaterial objMRMaterial = new MRMaterial();

                Material objMaterial = new Material();

                obj = objBatchPackingMR_DL.Get(Convert.ToInt64(cmbMRNO.SelectedValue));


                objMaterial = objMaterial_DL.Get(obj.MaterialCode);
                lblUnit1.Text = objMaterial.MatUnit.UnitCode;
                lblUnit2.Text = objMaterial.MatUnit.UnitCode;
                lblUnit3.Text = objMaterial.MatUnit.UnitCode;


                txtQunatityReceived.Text = obj.StartQty.ToString();

              //  txtDamagedQty.Text = obj.BatchDamaged.ToString();
               // txtBatchReturned.Text = obj.BatchReturned.ToString();
               // txtBatchUsed.Text = obj.BatchUsed.ToString();

                


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnFinalize_Click(object sender, EventArgs e)
        {
            try
            {
                BatchPackingMR obj = new BatchPackingMR();

                obj = objBatchPackingMR_DL.Get(Convert.ToInt64(cmbMRNO.SelectedValue));

                
                    if (obj.StartQty >= Convert.ToDecimal(txtDamagedQty.Text) + Convert.ToDecimal(txtBatchReturned.Text) + Convert.ToDecimal(txtBatchUsed.Text))
                    {
                        obj.BatchID = BatchID;
                        obj.BatchDamaged = Convert.ToDecimal(txtDamagedQty.Text);
                        obj.BatchReturned = Convert.ToDecimal(txtBatchReturned.Text);
                        obj.BatchUsed = Convert.ToDecimal(txtBatchUsed.Text);
                        obj.State = 1;


                        objBatchPackingMR_DL.Update_RPD(obj, MTN.Status.Initial, MTN.Type.Reject, MTN.ItemType.Material, CurrentUser.EmployeeID);

                    }
                    else
                    {
                        MessageBox.Show("Invalid Qty");
                    }
                


                Load_MRList();

                cmbMRNO_SelectedIndexChanged(sender, e);

                txtBatchReturned.Text = "";
                txtBatchUsed.Text = "";
                txtDamagedQty.Text = "";

                txtBatchUsed.Select();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


    }
}
