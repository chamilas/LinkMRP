using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using DL;
using SESD.MRP.REF;

namespace MRP_GUI.Components
{
    public partial class ucMaterialCategory : UserControl
    {
        private bool IsSelect = false;
        private String SelectedCode = "";
        private MaterialCategory_DL objMatCatDL;

        public ucMaterialCategory()
        {
            InitializeComponent();
        }

        public void Load(SqlConnection Conn)
        {
            objMatCatDL = new MaterialCategory_DL(Conn);
            gvCategory.DataSource = objMatCatDL.GetDataView();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtCategoryName.Text = "";
            txtID.Text = "";
            SelectedCode = "";
            IsSelect = false;
            btnDelete.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Equals(""))
            {
                MessageBox.Show(this,"Please enter Category Code","Empty Fields",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    MaterialCategory obj = new MaterialCategory();
                    obj.MatCatID = txtID.Text;
                    obj.MaterialCategoryName = txtCategoryName.Text;
                    int res = objMatCatDL.Add(obj);

                    if (res > 0)
                    {
                        gvCategory.DataSource = objMatCatDL.GetDataView();
                        ClearForm();
                    }

                }
                catch (SqlException sqlex)
                {
                    if (sqlex.Number == 2627)
                    {
                          MessageBox.Show(this,"Category code already in the database, Please enter another one","Duplicate Data",MessageBoxButtons.OK,MessageBoxIcon.Warning);

                      }
                      else
                      {
                          MessageBox.Show(this, "Database Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                      }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(this, "Error occured while saving", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (IsSelect)
            {
                DialogResult dr = MessageBox.Show(this,"Are you sure you want to delete selected Category?\n\nClick Yes to Delete","Confirm Delete",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2);

                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        int res = objMatCatDL.Delete(SelectedCode);
                        if (res > 0)
                        {
                            ClearForm();
                            gvCategory.DataSource = objMatCatDL.GetDataView();
                        }
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(this, "Error occured while Deleting", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        
                    }
                }

                
            }
        }

        private void gvCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    SelectedCode = gvCategory.Rows[e.RowIndex].Cells["colCode"].Value.ToString();
                    MaterialCategory obj = objMatCatDL.Get(SelectedCode);
                    txtCategoryName.Text = obj.MaterialCategoryName;
                    txtID.Text = obj.MatCatID;
                    IsSelect = true;
                    btnDelete.Enabled = true;
                }
                catch (Exception ex)
                {
                    
                    
                }
            }
        }


    }
}
