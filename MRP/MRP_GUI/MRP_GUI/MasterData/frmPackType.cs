using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SESD.MRP.REF;
using SESD.MRP.BL;
using DL;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Data.Sql;

namespace MRP_GUI
{
    public partial class frmPackType : System.Windows.Forms.Form
    {
        public frmPackType(User objUser)
        {
            CurrentUser = objUser;
            InitializeComponent();
        }


        private User _objCurrentUser;

        public User CurrentUser
        {
            get { return _objCurrentUser; }
            set { _objCurrentUser = value; }
        }
        //---------------GUI Control Variables-------------------------

        private bool PackingTypeSelect = false;
        private PackingType objSelectedPackingType = new PackingType();

        DataTable dtUnits = new DataTable();

        PackingType_DL objPackingTypeDL = new PackingType_DL(ConnectionStringClass.GetConnection());
        Unit_DL objUnitDL = new Unit_DL(ConnectionStringClass.GetConnection());

        //----- Form Load Event ----------------------------------------------

        //----- Packing Type Events ----------------------------------------

        private void btnPackinTypeSave_Click(object sender, EventArgs e)
        {
          
            if (txtPackingTypeName.Text.Equals("")||
                txtPackingTypeSize.Text.Equals(""))
            {
                MessageBox.Show(this, "Please Fill all Fields", "Blank Fields", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {

                try
                {
                    objSelectedPackingType.PackingQty = Convert.ToDecimal(txtPackingTypeSize.Text);
                    objSelectedPackingType.PackingTitle = txtPackingTypeName.Text;
                    objSelectedPackingType.PackingUnit = objUnitDL.Get(Convert.ToInt64(cmbUnit.SelectedValue));
                    objSelectedPackingType.PackingID = Convert.ToInt64(gvPackingType.CurrentRow.Cells["ColPackingID"].Value);

                    if (rdbTertiary.Checked == true)
                    {
                        objSelectedPackingType.Type = "Tertiary";
                    }
                    else if (rdbSecondary.Checked == true)
                    {
                        objSelectedPackingType.Type = "Secondary";
                    }
                    else
                    {
                        objSelectedPackingType.Type = "Primary";
                    }
                    int x;

                    x=objPackingTypeDL.Add(objSelectedPackingType);

                        if (x > 0)
                        {
                            Load_Data();
                            MessageBox.Show(this, "Succesfully Saved", "Succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }


                    this.PackingTypeSelect = false;

                }
                catch (FormatException )
                {

                    MessageBox.Show(this, "Please enter valid data", "Input Data Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                catch (Exception ex)
                {

                    MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                }
            }
        }

        private void btnPackinTypeDelete_Click(object sender, EventArgs e)
        {
            if (this.PackingTypeSelect)
            {
                DialogResult dr = MessageBox.Show(this, "Are you sure, You want to Delete selected Record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {

                    PackingType_DL objpackingTypeDL = new PackingType_DL(ConnectionStringClass.GetConnection());
                    try
                    {

                        int x = objpackingTypeDL.Delete(objSelectedPackingType.PackingID);

                        gvPackingType.DataSource = objpackingTypeDL.GetDataView();

                        cmbUnit.SelectedIndex = 0;
                        txtPackingTypeName.Text = "";
                        txtPackingTypeSize.Text = "0.00";

                        this.PackingTypeSelect = false;
                        if (x > 0)
                        {
                            MessageBox.Show(this, "Succesfully Deleted", "Succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        objpackingTypeDL = null;
                    }

                }
            }
            else
            {
                MessageBox.Show(this, "Select a Record from the List", "Select a Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnPackinTypeClear_Click(object sender, EventArgs e)
        {
            
            cmbUnit.SelectedIndex = 0;
            txtPackingTypeName.Text = "";
            txtPackingTypeSize.Text = "0.00";
            this.PackingTypeSelect = false;
        }

        private void gvPackingType_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex>=0)
            {
                PackingType_DL objPackingTypeDL = new PackingType_DL(ConnectionStringClass.GetConnection());
                Form_DL objFormDL = new Form_DL(ConnectionStringClass.GetConnection());
                Unit_DL objUnitDL = new Unit_DL(ConnectionStringClass.GetConnection());
                try
                {
                    txtPackingID.Text = Convert.ToString(gvPackingType.CurrentRow.Cells["ColPackingID"].Value);

                    objSelectedPackingType.Type = Convert.ToString(gvPackingType.Rows[e.RowIndex].Cells["ColType"].Value);
                    objSelectedPackingType.PackingID = Convert.ToInt64(gvPackingType.Rows[e.RowIndex].Cells["ColPackingID"].Value);
                    objSelectedPackingType.PackingQty = Convert.ToDecimal(gvPackingType.Rows[e.RowIndex].Cells["ColPackingQty"].Value);
                    objSelectedPackingType.PackingTitle = gvPackingType.Rows[e.RowIndex].Cells["ColPackingTitle"].Value.ToString();
                    objSelectedPackingType.PackingUnit = objUnitDL.Get(Convert.ToInt64(gvPackingType.Rows[e.RowIndex].Cells["colPackingUnitID"].Value));

                    txtPackingTypeName.Text = objSelectedPackingType.PackingTitle;
                    txtPackingTypeSize.Text = objSelectedPackingType.PackingQty.ToString();
                    cmbUnit.SelectedValue = objSelectedPackingType.PackingUnit.UnitID.ToString();

                    this.PackingTypeSelect = true;

                }
                catch (Exception ex)
                {

                    MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } 
            }
        }

        private void frmPackType_Load(object sender, EventArgs e)
        {
            try
            {
                Load_Data();


            dtUnits= objUnitDL.GetDataView();
            bindUnits.DataSource = dtUnits;
            cmbUnit.DataSource = bindUnits;

            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }

        private void Load_Data()
        {
            try
            {
            gvPackingType.DataSource = objPackingTypeDL.GetDataView();
            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }



    }
}