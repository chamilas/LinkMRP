using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SESD.MRP.REF;
using DL;
using System.Data.SqlClient;


namespace MRP_GUI
{
    public partial class usProductInsert : UserControl
    {
        public usProductInsert()
        {
            InitializeComponent();
        }

        //--------------- Form Variables -----------------------------

        private BasicProduct objBasicProduct = new BasicProduct();
        private String OriginalBasicProduct ="";

        private FinishProduct objFinishProduct = new FinishProduct();
        private String OriginalFinishProductCode = "";

        private bool ProductSelect = false;
        private bool FinishProductSelect = false;



        private Unit_DL objUnitDL;
        private Form_DL objFormDL ;
        private ProductCategory_DL objProductCategoryDL;
        private ProductSubCategory_DL objProductSubCategory ;
        private Formula_DL objFormulaDL;
        private PackingType_DL objPackingTypeDL;
        private FinishProduct_DL objFinishProductDL;
        private BasicProduct_DL objbasicProductDL ;

        public void Initialize(SqlConnection Conn)
        {
           objUnitDL = new Unit_DL(Conn);
            objFormDL = new Form_DL(Conn);
           objProductCategoryDL = new ProductCategory_DL(Conn);
           objProductSubCategory = new ProductSubCategory_DL(Conn);
           objFormulaDL = new Formula_DL(Conn);
           objPackingTypeDL = new PackingType_DL(Conn);
           objFinishProductDL = new FinishProduct_DL(Conn);
          objbasicProductDL = new BasicProduct_DL(Conn);
        }


        //------------------ Form Load Event --------------------------------------
        private void usProductInsert_Load(object sender, EventArgs e)
        {
            
        }


        // ---------------------- MRP Define Methods ------------------------------
      

        //------------- Add,Delete,Update Events of Basic Products ------------------
        private void btnBasicProductAdd_Click(object sender, EventArgs e)
        {


        }

        private void btnBasicProductDelete_Click(object sender, EventArgs e)
        {
            
        }

        private void btnBasicProductClear_Click(object sender, EventArgs e)
        {
            
        }

        private void gvBasicProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }


        private void txtAvgCost_Validated(object sender, EventArgs e)
        {
           
        }

        private void txtBasicProductQty_Validated(object sender, EventArgs e)
        {
           
        }

        private void btnAddFinishProduct_Click(object sender, EventArgs e)
        {
            
        }

        private void cmbBasicProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void gvFinishProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void gvBasicProduct_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteFinishProduct_Click(object sender, EventArgs e)
        {
           
        }

        private void btnFinishProductClear_Click(object sender, EventArgs e)
        {
            
        }

        private void txtFinishProductAvgCost_Validated(object sender, EventArgs e)
        {
           
        }

        private void txtProductCode_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtAvgCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar) || (e.KeyChar == (char)46)))
            {
                e.Handled = true;
            }
        }


        private void listCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }




    }
}
