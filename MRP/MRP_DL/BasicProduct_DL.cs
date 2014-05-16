using System;
using System.Collections.Generic;
using System.Text;
using SESD.MRP.REF;
using System.Data;
using System.Data.SqlClient;

namespace DL
{
    public class BasicProduct_DL
    {
        SqlConnection Connection = new SqlConnection();
        SqlDataReader rdr = null;

        Unit_DL objUnit_DL = new Unit_DL(ConnectionStringClass.GetConnection());
        ProductCategory_DL objProductCategory_DL = new ProductCategory_DL(ConnectionStringClass.GetConnection());
        ProductSubCategory_DL objProductSubCategory_DL = new ProductSubCategory_DL(ConnectionStringClass.GetConnection());
        Formula_DL objFormula_DL = new Formula_DL(ConnectionStringClass.GetConnection());
        Form_DL objForm_DL = new Form_DL(ConnectionStringClass.GetConnection());

        public BasicProduct_DL(SqlConnection Conn)
        {
            Connection = Conn;
        }

        public int Add(BasicProduct objBasicProduct,int DepID,int SectionID)
        {


            try
            {
                

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@BasicProductCode", objBasicProduct.BasicProductCode),
                new SqlParameter("@BasicProductName", objBasicProduct.BasicProductName),
                new SqlParameter("@BasicProductDescription", objBasicProduct.BasicProductDescription),
                new SqlParameter("@BasicProductSubCatID", objBasicProduct.BasicProductSubCategory.CategoryID),
                new SqlParameter("@BasicProductCatID", objBasicProduct.BasicProductCategory.CategoryID),
                new SqlParameter("@BasicProductUnitID", objBasicProduct.BasicProductUnit.UnitID),
                new SqlParameter("@BasicProductFormID", objBasicProduct.BasicProductForm.FormID),
                new SqlParameter("@BasicProductAvgCost", objBasicProduct.BasicProductAVGCost),
                new SqlParameter("@BasicProductStatus", objBasicProduct.BasicProductStatus),
                new SqlParameter("@BasicProductType", objBasicProduct.BasicProductType),
                 new SqlParameter("@STDBatchSize", objBasicProduct.STDBatchSize),
                new SqlParameter("@DepID", DepID),
                new SqlParameter("@SectionID", SectionID)
                };

                return Execute.RunSP_RowsEffected(Connection, "SPADD_BasicProduct", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
            
        }

        public int Update(BasicProduct objBasicProduct, String OriginalBasicCode)
        {
            

            try
            {
                

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@BasicProductCode", objBasicProduct.BasicProductCode),
                new SqlParameter("@BasicProductName", objBasicProduct.BasicProductName),
                new SqlParameter("@BasicProductDescription", objBasicProduct.BasicProductDescription),
                new SqlParameter("@BasicProductSubCatID", objBasicProduct.BasicProductSubCategory.CategoryID),
                new SqlParameter("@BasicProductCatID", objBasicProduct.BasicProductCategory.CategoryID),
                new SqlParameter("@BasicProductUnitID", objBasicProduct.BasicProductUnit.UnitID),
                new SqlParameter("@BasicProductFormID", objBasicProduct.BasicProductForm.FormID),
                new SqlParameter("@BasicProductFormulaID", objBasicProduct.BasicProductFormula.FormulaID),
                new SqlParameter("@BasicProductAvgCost", objBasicProduct.BasicProductAVGCost),
                new SqlParameter("@BasicProductStatus", objBasicProduct.BasicProductStatus),
                new SqlParameter("@BasicProductType", objBasicProduct.BasicProductType),
                new SqlParameter("@Original_BasicProductCode", OriginalBasicCode)};

                return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_BasicProduct", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
            



        }

        public int Delete(String BasicProductID)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@Original_BasicProductCode", BasicProductID)};

                return Execute.RunSP_RowsEffected(Connection, "SPDELETE_BasicProduct", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }



        public BasicProduct Get(String BasicProductCode)
        {

            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@BasicProductCode", BasicProductCode)};

                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_BasicProductByID", paramList);


                BasicProduct obj = new BasicProduct();

                if (dt.Rows.Count > 0)
                {
                    obj.BasicProductAVGCost = Convert.ToDecimal(dt.Rows[0]["BasicProductAVGCost"]);
                    obj.BasicProductCategory = objProductCategory_DL.Get(Convert.ToString(dt.Rows[0]["BasicProductCatID"]));
                    obj.BasicProductCode = Convert.ToString(dt.Rows[0]["BasicProductCode"]);
                    obj.BasicProductDescription = Convert.ToString(dt.Rows[0]["BasicProductDescription"]);
                    obj.BasicProductForm = objForm_DL.Get(Convert.ToInt64(dt.Rows[0]["BasicProductFormID"]));
                    obj.BasicProductFormula = objFormula_DL.Get(Convert.ToInt32(dt.Rows[0]["BasicProductFormulaID"]));
                    obj.BasicProductName = Convert.ToString(dt.Rows[0]["BasicProductName"]);
                    obj.BasicProductStatus = Convert.ToBoolean(dt.Rows[0]["BasicProductStatus"]);
                    obj.BasicProductSubCategory = objProductSubCategory_DL.Get(Convert.ToString(dt.Rows[0]["BasicProductSubCatID"]));
                    obj.BasicProductType = Convert.ToString(dt.Rows[0]["BasicProductType"]);
                    obj.BasicProductUnit = objUnit_DL.Get(Convert.ToInt64(dt.Rows[0]["BasicProductUnitID"]));
                    
                }


                return obj;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
          


        }

        public System.Data.DataTable GetDataView()
        {

            try
            {


                return Execute.RunSP_DataTable(Connection, "SPGET_BasicProduct_DataView");

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public System.Data.DataTable GetDataView_Store(String StoreID)
        {
            try
            {
                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@StoreID", StoreID)};

                return Execute.RunSP_DataTable(Connection, "SPGET_BasicProduct_Dataview_ByStore",paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public System.Data.DataTable GetDataView_All(String Type1,String Type2, bool Status)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@Key1", Type1),
                new SqlParameter("@Key2", Type2),
                new SqlParameter("@BasicProductStatus", Status)};

                return Execute.RunSP_DataTable(Connection, "SPGET_BasicProduct_DataView_Search_All", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public System.Data.DataTable GetDataView(String Type,bool Status)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@Key", Type),
                new SqlParameter("@BasicProductStatus", Status)};

                return Execute.RunSP_DataTable(Connection, "SPGET_BasicProduct_DataView_Search", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public System.Data.DataTable GetDataView(bool Status)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@Status", Status)};

                return Execute.RunSP_DataTable(Connection, "SPGET_BasicProduct_DataView_Status",paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

       

        public System.Data.DataTable GetDataView_Category(bool Status, String SubCatID)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@Status", Status),
                new SqlParameter("@ProductCat", SubCatID)};

                return Execute.RunSP_DataTable(Connection, "SPGET_BasicProduct_By_Cat",paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }


        public System.Data.DataTable GetDataView_By_Category(String category)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@Category", category)};

                return Execute.RunSP_DataTable(Connection, "SPGET_BasicProduct_DataView_Category",paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }



        public long Get_Department(String ProductCode,String Type)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@ProductCode", ProductCode),
                new SqlParameter("@Type", Type)};

                return Execute.RunSP_Long(Connection, "SPGET_ProductManufacturing_ByID", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }




    }
}
