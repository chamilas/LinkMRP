using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SESD.MRP.REF;
using DL;

namespace MRP_GUI.Components.MaterialSelection
{
    public partial class frmMaterialList : System.Windows.Forms.Form
    { 
        String Key;
        public frmMaterialList(String Key)
        {
            this.Key = Key;
            Type = ControllerType.All;
            InitializeComponent();
        }

        private void frmMaterialList_Load(object sender, EventArgs e)
        {
            
            try
            {
                LoadMaterial(Key);
            }
            catch (Exception ex)
            {

                MessageBox.Show(this,"Material loading Error","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void LoadMaterial(String Key)
        {

            txtmat.Text = Key;
            Material_DL objMatDL = new Material_DL(ConnectionStringClass.GetConnection());
            if (Type == ControllerType.All)
            {
                bindMaterials.DataSource = objMatDL.Search(Key, 1);
            }
            else if (Type == ControllerType.Category)
            {
                bindMaterials.DataSource = objMatDL.Search(Key, Category, 1);
            }
            else if (Type == ControllerType.MainType)
            {
                bindMaterials.DataSource = objMatDL.Search_MainType(Key, MainType, 1);
            }
            else if (Type == ControllerType.MainType_Category)
            {
                bindMaterials.DataSource = objMatDL.Search_MainType_Category(Key, MainType,Category ,1);
            }
        }

        public enum ControllerType
        {
            All,
            Category,
            MainType,
            MainType_Category,
            SubCategory
        }

        private ControllerType _Type;

        public ControllerType Type
        {
            get { return _Type; }
            set { _Type = value; }
        }

        private String _Category;

        public String Category
        {
            get { return _Category; }
            set { _Category = value; }
        }


        private String _MainType;

        public String MainType
        {
            get { return _MainType; }
            set { _MainType = value; }
        }

        private Material _Material;

        public Material Material
        {
            get { return _Material; }
            set { _Material = value; }
        }
	

        private void txtmat_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void txtmat_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Down)
                {
                    gvMaterials.Focus();
                }
                else if (e.KeyCode == Keys.Escape)
                {
                    this.Close();
                }
                else if (e.KeyCode == Keys.Enter)
                {
                    try
                    {
                        e.Handled = true;
                        Material_DL objMatDL = new Material_DL(ConnectionStringClass.GetConnection());
                        Material = objMatDL.Get(gvMaterials.SelectedRows[0].Cells["Column1"].Value.ToString());
                        this.Close();
                    }
                    catch (Exception)
                    {

                        MessageBox.Show(this, "Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

            }
            catch (Exception)
            {

                MessageBox.Show(this,"Error occured","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gvMaterials_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void gvMaterials_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void gvMaterials_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Material_DL objMatDL = new Material_DL(ConnectionStringClass.GetConnection());
                Material = objMatDL.Get(gvMaterials.Rows[e.RowIndex].Cells["Column1"].Value.ToString());
                this.Close();
            }
            catch (Exception)
            {

                MessageBox.Show(this,"Error Occured","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void gvMaterials_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                try
                {
                    Material_DL objMatDL = new Material_DL(ConnectionStringClass.GetConnection());
                    Material = objMatDL.Get(gvMaterials.SelectedRows[0].Cells["Column1"].Value.ToString());
                    this.Close();
                }
                catch (Exception)
                {

                    MessageBox.Show(this, "Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void txtmat_TextChanged(object sender, EventArgs e)
        {
            LoadMaterial(txtmat.Text);
        }
	
	
	
	
    }
}