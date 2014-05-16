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
    public partial class frmPODeliveryShedule : System.Windows.Forms.Form
    {
        public frmPODeliveryShedule(User objUser, string _PONO)
        {
            InitializeComponent();
            CurrentUser = objUser;
            PONO = _PONO;

        }

        User CurrentUser = new User();
        string PONO = "";
        Supplier_DL objSupplier_DL = new Supplier_DL(ConnectionStringClass.GetConnection());
        Material_DL objMaterial_DL = new Material_DL(ConnectionStringClass.GetConnection());
        PO_DL objPO_DL = new PO_DL(ConnectionStringClass.GetConnection());
        POMaterials_DL objPOMaterials_DL = new POMaterials_DL(ConnectionStringClass.GetConnection());
        PODeliveryShedules_DL objPODeliveryShedules_DL = new PODeliveryShedules_DL(ConnectionStringClass.GetConnection());

        POMaterialsCollec objPOMaterialsCollec = new POMaterialsCollec();
        PO objPO = new PO();

        Supplier objPOMaterials = new Supplier();
        DataTable dtPOMaterials = new DataTable();
        DataTable dtPODeliveryShedule = new DataTable();
        DataTable dtMaterials = new DataTable();




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
            try
            {

                txtPONO.Text = PONO;
                objPO = objPO_DL.Get(txtPONO.Text);
                Supplier objSup = objSupplier_DL.Get(objPO.POSupplierID);

                dtpReqDate.Value = objPO.PORequiredDate;
                txtPaymentType.Text = objPO.POPaymentType;
                txtPOReference.Text = objPO.POReference;
                txtSupplierDetails.Text = objSup.SupplieName+" - " + objSup.SupplierAddress;

                dtPOMaterials = objPOMaterials_DL.Get_ByPOID(PONO);

                gvPOMaterials.AutoGenerateColumns = false;
                objSourcePOMaterials.DataSource = dtPOMaterials;
                gvPOMaterials.DataSource = objSourcePOMaterials;
                objSourcePOMaterials.ResetBindings(true);

                dtMaterials = objPOMaterials_DL.Get_ByPOID(PONO);
                objSourceMaterials.DataSource = dtMaterials;
                cmbMaterials.DataSource = objSourceMaterials;

                Load_DeliveryShedules();

            }
            catch (Exception ex)
            {

            }
        }

        private void cmbSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //if(cmbSupplier.SelectedValue!=null)
                //{
                //objSupplier = objSupplier_DL.Get(Convert.ToInt64(cmbSupplier.SelectedValue));

                // txtSupplierDetails.Text=objSupplier.SupplieName+" - "+objSupplier.SupplierAddress+" Phone :"+objSupplier.SupplierPhone+" Mob : "+objSupplier.SupplierMobile;

                //}


               
            }
            catch (Exception ex)
            {

            }
        }

        private void cmbMaterials_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Material objMaterial = new Material();
                objMaterial = objMaterial_DL.Get(cmbMaterials.SelectedValue.ToString());
                lblUnit.Text = objMaterial.MatUnit.UnitCode;
            }
            catch (Exception ex)
            {

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                PODeliveryShedule objPODeliveryShedule = new PODeliveryShedule();
                
                objPODeliveryShedule.MaterialCode = cmbMaterials.SelectedValue.ToString();
                objPODeliveryShedule.PONO = txtPONO.Text;
                objPODeliveryShedule.ExpectedDate = dtpDeliveryDate.Value;
                objPODeliveryShedule.ID = Convert.ToInt32(txtDeliveryOrder.Text);

                if (chkShipmentDate.Checked == false)
                {
                    objPODeliveryShedule.ShipmentDate = Convert.ToDateTime("1900-01-01 00:00:00.000");
                }
                else
                {
                    objPODeliveryShedule.ShipmentDate = dtpShipmentDate.Value;
                }

                objPODeliveryShedule.Qty = Convert.ToDecimal(txtReqQty.Text);

                objPODeliveryShedules_DL.Add(objPODeliveryShedule);


                Load_DeliveryShedules();

            }
            catch (Exception ex)
            {

            }
        }

        private void Load_DeliveryShedules()
        {
           try
           {
            dtPODeliveryShedule = objPODeliveryShedules_DL.Get_ByPOID(txtPONO.Text);


            gvPODeliveryShedule.AutoGenerateColumns = false;
            objSourcePODelivery.DataSource = dtPODeliveryShedule;
            gvPODeliveryShedule.DataSource = objSourcePODelivery;
            objSourcePODelivery.ResetBindings(true);

           }
           catch (Exception ex)
           {

           }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                //if ((txtPONO.Text == "") | (cmbSupplier.SelectedValue == null) | (cmbPOPaymentType.Text == ""))
                //{
                //    MessageBox.Show("Required Fields are Missing");
                //}
                //else
                //{
                //    PO objPO = new PO();

                //    objPO.PONO = txtPONO.Text;
                //    objPO.POStatus = 0;
                //    objPO.POSupplierID = Convert.ToInt32(cmbSupplier.SelectedValue);
                //    objPO.POReference = txtPOReference.Text;
                //    objPO.POEnterdBy = CurrentUser.EmployeeID;
                //    objPO.PORequiredDate = dtpReqDate.Value;
                //    objPO.POValidityPeriod = Convert.ToInt64(nudValid.Value);
                //    objPO.POPaymentType = cmbPOPaymentType.Text;
                //    objPO.POType = POType;

                //    long x = objPO_DL.Add(objPO);

                //    if (x > 0)
                //    {
                //        foreach (POMaterials obj in objPOMaterialsCollec)
                //        {
                //            objPOMaterials_DL.Add(obj);
                //        }

                //        MessageBox.Show("Successfully Saved");
                //        objPOMaterialsCollec.Clear();

                //        gvMaterialList.AutoGenerateColumns = false;
                //        objSource.DataSource = null;
                //        gvMaterialList.DataSource = objSource;
                //        objSource.ResetBindings(true);

                //        txtPONO.Text = "";
                //        txtPOReference.Text = "";
                //        nudValid.Value = 0;


                //    }
                //}

            }
            catch (Exception ex)
            {

            }
        }

        private void chkShipmentDate_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShipmentDate.Checked == true)
            {
                dtpShipmentDate.Visible = true;
            }
            else
            {
                dtpShipmentDate.Visible = false;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gvPODeliveryShedule_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                PODeliveryShedule obj = new PODeliveryShedule();

                obj = objPODeliveryShedules_DL.Get(txtPONO.Text);

                txtReqQty.Text = obj.Qty.ToString();
                dtpDeliveryDate.Value = obj.ExpectedDate;
                dtpShipmentDate.Value = obj.ShipmentDate;

            }
            catch (Exception ex)
            {

            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                PODeliveryShedule objPODeliveryShedule = new PODeliveryShedule();

                objPODeliveryShedule.MaterialCode = cmbMaterials.SelectedValue.ToString();
                objPODeliveryShedule.PONO = txtPONO.Text;
                objPODeliveryShedule.ExpectedDate = dtpDeliveryDate.Value;

                if (chkShipmentDate.Checked == false)
                {
                    objPODeliveryShedule.ShipmentDate = Convert.ToDateTime("1900-01-01 00:00:00.000");
                }
                else
                {
                    objPODeliveryShedule.ShipmentDate = dtpShipmentDate.Value;
                }

                objPODeliveryShedule.Qty = Convert.ToDecimal(txtReqQty.Text);

                objPODeliveryShedules_DL.Update(objPODeliveryShedule);


                Load_DeliveryShedules();

            }
            catch (Exception ex)
            {

            }
        }
    }
}
