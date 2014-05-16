using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DL;
using SESD.MRP.REF;
using System.Data.SqlClient;

namespace MRP_GUI
{
    public partial class ucProcessedMaterial : UserControl
    {
        public ucProcessedMaterial()
        {
            InitializeComponent();
        }

        public ucProcessedMaterial(SqlConnection Conn)
        {
            InitializeComponent();

        }

        private Material objMaterial;
        Material_DL objMaterial_DL;
        Store_DL objStore_DL;
        Department_DL objDepartment_DL;

        DataTable dtStores = new DataTable();
        DataTable dtProcessedMaterial = new DataTable();

        string BasicMaterialCode;



        private Material _ProcessedMaterial;

        public Material ProcessedMaterial
        {
            get 
            {
                    return objMaterial;

                
            }
            set { _ProcessedMaterial = value; }
        }



	
	



        public void Load_Data(SqlConnection Conn,string MatCode)
        {
            objMaterial_DL = new Material_DL(Conn);
            objStore_DL = new Store_DL(Conn);
            objDepartment_DL = new Department_DL(Conn);
            BasicMaterialCode = MatCode;

            objMaterial = objMaterial_DL.GetProcessdMaterial(BasicMaterialCode);

            if (objMaterial != null)
            {
                textBox1.Text = objMaterial.MaterialNameCode;
                //cmbStoreTo.DataSource = objStore_DL.GetData();
                //cmbStoreTo.SelectedValue = objStore_DL.Get_Default(objDepartment_DL.GetByDepType("Store").DepID).StoreID;
                //cmbStoreTo.Enabled = true;
               
            }
            else
            {
                //cmbStoreTo.Enabled = false;
                textBox1.Text = "N/A";
            }

           

        }
        private void ucProcessedMaterial_Load(object sender, EventArgs e)
        {
            try
            {
                

            }
            catch (Exception ex)
            {
                
               MessageBox.Show(ex.Message.ToString()) ;
            }
        }

        private void grpTransferLocation_Enter(object sender, EventArgs e)
        {

        }

      


    }
}
