using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DL;
using SESD.MRP.REF;

namespace MRP_GUI.Components.MaterialSelection
{
    public partial class MaterialSelect : UserControl
    {
        public MaterialSelect()
        {
            InitializeComponent();
        }
        private Material _Material;

        public Material Material
        {
            get { return _Material; }
            set { 
                _Material = value;
                if (_Material != null)
                {
                    txtMaterial.Text = _Material.MaterialNameCode;
                    OnMaterialSelectedChanged(new EventArgs());
                }
                else
                {
                    txtMaterial.Text = "";
                }
            }
        }

        private frmMaterialList.ControllerType _Type;

        public frmMaterialList.ControllerType Type
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
	
	
	
	
        private void txtMaterial_Enter(object sender, EventArgs e)
        {
            LoadData("",e);
        }

        private void LoadData(String Key,EventArgs e)
        {
            frmMaterialList obj = new frmMaterialList(Key);
            obj.Location = PointToScreen(txtMaterial.Location);
            obj.Type = this.Type;
            obj.Category = this.Category;
            obj.MainType = this.MainType;
            obj.ShowDialog(this);
            if (obj.Material != null)
            {
               txtMaterial.Text = obj.Material.MaterialNameCode;
              
               Material = obj.Material; 
               OnMaterialSelectedChanged(e);
           }
           else
           {
               Material = null;
           }
            
            
        }

        private void txtMaterial_Click(object sender, EventArgs e)
        {
            LoadData("",e);
        }

        private void txtMaterial_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            LoadData(e.KeyChar.ToString(),e);
        }

        private void txtMaterial_KeyUp(object sender, KeyEventArgs e)
        {
            
           
        }

        private void txtMaterial_KeyDown(object sender, KeyEventArgs e)
        {
 
        }

        public delegate void MaterialSelectedIndexChangedHandler(object sender, EventArgs e);
        [Category("Options"), Browsable(true), Description("Event associate with the material text bex")]
        public event MaterialSelectedIndexChangedHandler MaterialSelectedChanged;

        protected virtual void OnMaterialSelectedChanged(EventArgs e)
        {
            if (MaterialSelectedChanged != null)
            {
                MaterialSelectedChanged(this, e);
            }
        }

        private void txtMaterial_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
