using DL;
using MRP_GUI.Sales;
using SESD.MRP.REF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MRP_GUI.Packing
{
    public partial class frmBatchPackingMR : System.Windows.Forms.Form
    {
        private User _objCurrentUser;

        public User CurrentUser
        {
            get { return _objCurrentUser; }
            set { _objCurrentUser = value; }
        }


        public frmBatchPackingMR(string _ProductCode,string _BatchID,User objUser,long _packingBatchID)
        {
            InitializeComponent();
            ProductCode = _ProductCode;
            BatchID = _BatchID;
            PackingBatchID = _packingBatchID;
            CurrentUser = objUser;
        }

        BatchPackingMR_DL objBatchPackingMR_DL = new BatchPackingMR_DL(ConnectionStringClass.GetConnection());
        MRMaterial_DL objMRMaterial_DL = new MRMaterial_DL(ConnectionStringClass.GetConnection());
        Material_DL objMaterial_DL = new Material_DL(ConnectionStringClass.GetConnection());

        BatchPackingMR obj = new BatchPackingMR();
        MRMaterial objMRMaterial = new MRMaterial();

        Material objMaterial = new Material();

        DataTable dt = new DataTable();
        DataTable dtMaterialList = new DataTable();

        String ProductCode = "";
        String BatchID = "";
        long PackingBatchID =0;

        private void frmBatchPackingMR_Load(object sender, EventArgs e)
        {

            try
            {

                txtProductCode.Text = BatchID;
                txtPackingBatch.Text = PackingBatchID.ToString();

                Load_MaterialList();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

          private void Load_MaterialList()
        {
            try
                        {

                            dtMaterialList = objBatchPackingMR_DL.GetMaterialList(ProductCode);
                            objSourceMaterialList.DataSource = dtMaterialList;
                            cmbMaterial.DataSource = objSourceMaterialList;

                        }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Load_MRList()
        {

            try
            {

                dt = objBatchPackingMR_DL.GetData(ProductCode,cmbMaterial.SelectedValue.ToString());

                if (dt.Rows.Count > 0)
                {
                    objSource.DataSource = dt;
                    cmbMRNO.DataSource = objSource;
                }
                else
                {
                    objSource.DataSource = null;
                    cmbMRNO.DataSource = objSource;
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
              

                obj = objBatchPackingMR_DL.Get(Convert.ToInt64(cmbMRNO.SelectedValue));


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
            if (DataValidation.IsNumericNumber(txtDamagedQty.Text) && DataValidation.IsNumericNumber(txtBatchUsed.Text))
            {
                try
                {
                    BatchPackingMR obj = new BatchPackingMR();
                    BatchActivity objBatchActivity = new BatchActivity();
                    BatchActivity_DL objBatchActivity_DL = new BatchActivity_DL(ConnectionStringClass.GetConnection());

                    obj = objBatchPackingMR_DL.Get(Convert.ToInt64(cmbMRNO.SelectedValue));

                    objBatchActivity = objBatchActivity_DL.GetByID(Convert.ToInt32(txtPackingBatch.Text));

                    if ((objBatchActivity.BatchActStatus == BatchActivity.Status.Finished) | (objBatchActivity.BatchActStatus == BatchActivity.Status.SecondaryPacking_Finish) | (objBatchActivity.BatchActStatus == BatchActivity.Status.Transferred))
                    {
                        MessageBox.Show("Activity is Already Finished");
                    }
                    else
                    {

                        if (obj.StartQty >= Convert.ToDecimal(txtDamagedQty.Text) + Convert.ToDecimal(txtBatchReturned.Text) + Convert.ToDecimal(txtBatchUsed.Text))
                        {
                            obj.BatchID = BatchID;
                            obj.BatchDamaged = Convert.ToDecimal(txtDamagedQty.Text);
                            obj.BatchReturned = Convert.ToDecimal(txtBatchReturned.Text);
                            obj.BatchUsed = Convert.ToDecimal(txtBatchUsed.Text);
                            obj.State = 1;
                            obj.BatchPackingID = Convert.ToInt64(txtPackingBatch.Text);


                            objBatchPackingMR_DL.Update(obj, MTN.Status.Initial, MTN.Type.Reject, MTN.ItemType.Material, CurrentUser.EmployeeID);

                        }
                        else
                        {
                            MessageBox.Show("Invalid Qty");
                        }

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
            else 
            {
                MessageBox.Show(this, "please enter valid quantity", "MRP System", MessageBoxButtons.OK);
            }
        }

        private void cmbMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                objMaterial = objMaterial_DL.Get(cmbMaterial.SelectedValue.ToString());
                lblUnit1.Text = objMaterial.MatUnit.UnitCode;
                lblUnit2.Text = objMaterial.MatUnit.UnitCode;
                lblUnit3.Text = objMaterial.MatUnit.UnitCode;
                lblUnit4.Text = objMaterial.MatUnit.UnitCode;

               DataTable dtStock= new DataTable();

              
                   dtStock = objBatchPackingMR_DL.GetStock(ProductCode, cmbMaterial.SelectedValue.ToString());

                   if (dtStock.Rows.Count > 0)
                   {
                   txtSectionStock.Text=dtStock.Rows[0]["StockQty"].ToString();
               }
               else
               {
                   txtSectionStock.Text = "0";
               }
            Load_MRList();

            cmbMRNO.DisplayMember = "MRNO";
            cmbMRNO.ValueMember = "ID";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }



    }
}
