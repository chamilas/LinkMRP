using SESD.MRP.REF;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DL
{
    public class FinishProduct_DL
    {
        SqlConnection Connection = new SqlConnection();

        BasicProduct_DL objBasicProduct_DL = new BasicProduct_DL(ConnectionStringClass.GetConnection());
        Formula_DL objFormula_DL = new Formula_DL(ConnectionStringClass.GetConnection());
        PackingType_DL objPackingType_DL = new PackingType_DL(ConnectionStringClass.GetConnection());

        public FinishProduct_DL(SqlConnection Conn)
        {
            Connection = Conn;
        }
        public int Add(FinishProduct objFinishProduct)
        {
            try
            {

                
                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@FinishProductCode",  objFinishProduct.FinishProductCode),
                new SqlParameter("@BasicProductCode",  objFinishProduct.BasicProduct.BasicProductCode),
                new SqlParameter("@FinishProdutPackingTypeID",  objFinishProduct.FinishProductPackingType.PackingID),
                new SqlParameter("@FinishProdutDescription",  objFinishProduct.FinishProductDescription),
                new SqlParameter("@FinishProdutBasicQty",  objFinishProduct.BasicProductQty),
                new SqlParameter("@FinishProdutAvgCost",  objFinishProduct.FinishProductAvgCost),
                new SqlParameter("@FinishProdutStatus",  objFinishProduct.FinishProductStatus),
                new SqlParameter("@PrimaryFinishProductCode",  objFinishProduct.PrimaryFinishProductCode),
                new SqlParameter("@PrimaryFinishProductQty",  objFinishProduct.PrimaryFinishProductQty),
                new SqlParameter("@FinishProductType",  objFinishProduct.FinishProductType)
                };

                return Execute.RunSP_RowsEffected(Connection, "SPADD_FinishProduct", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public int Update(FinishProduct objFinishProduct,String OriginalCode)
        {

             try
            {
                  


                if (objFinishProduct.FinishProductFormula == null)
                {

                    SqlParameter[] paramList = new SqlParameter[] {
                new SqlParameter("@FinishProductCode",  objFinishProduct.FinishProductCode),
                new SqlParameter("@BasicProductCode",  objFinishProduct.BasicProduct.BasicProductCode),
                new SqlParameter("@FinishProdutFormulaID",  null),
                new SqlParameter("@FinishProdutPackingTypeID",  objFinishProduct.FinishProductPackingType.PackingID),
                new SqlParameter("@FinishProdutDescription",  objFinishProduct.FinishProductDescription),
                new SqlParameter("@FinishProdutBasicQty",  objFinishProduct.BasicProductQty),
                new SqlParameter("@FinishProdutAvgCost",  objFinishProduct.FinishProductAvgCost),
                new SqlParameter("@FinishProdutStatus",  objFinishProduct.FinishProductStatus),
                new SqlParameter("@PrimaryFinishProductCode",  objFinishProduct.FinishProductCode),
                new SqlParameter("@PrimaryFinishProductQty",  objFinishProduct.PrimaryFinishProductQty),
                new SqlParameter("@FinishProductType",  objFinishProduct.FinishProductType),
                new SqlParameter("@SKUID",  objFinishProduct.SKUID),
                new SqlParameter("@Original_FinishProductCode",  OriginalCode)};

                    return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_FinishProduct", paramList);
               
                }

                 else
                {
                    SqlParameter[] paramList = new SqlParameter[] {
                  new SqlParameter("@FinishProdutCode",  objFinishProduct.FinishProductCode),
                new SqlParameter("@BasicProductCode",  objFinishProduct.BasicProduct.BasicProductCode),
                new SqlParameter("@FinishProdutFormulaID",  objFinishProduct.FinishProductFormula.FormulaID),
                new SqlParameter("@FinishProdutPackingTypeID",  objFinishProduct.FinishProductPackingType.PackingID),
                new SqlParameter("@FinishProdutDescription",  objFinishProduct.FinishProductDescription),
                new SqlParameter("@FinishProdutBasicQty",  objFinishProduct.BasicProductQty),
                new SqlParameter("@FinishProdutAvgCost",  objFinishProduct.FinishProductAvgCost),
                new SqlParameter("@FinishProdutStatus",  objFinishProduct.FinishProductStatus),
                new SqlParameter("@PrimaryFinishProductCode",  objFinishProduct.FinishProductCode),
                new SqlParameter("@PrimaryFinishProductQty",  objFinishProduct.PrimaryFinishProductQty),
                new SqlParameter("@FinishProductType",  objFinishProduct.FinishProductType),
                new SqlParameter("@SKUID",  objFinishProduct.SKUID),
                new SqlParameter("@Original_FinishProductCode",  OriginalCode)};

                    return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_FinishProduct", paramList);
                }
               

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }




        public int Delete(String FinishProductCode)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@Original_FinishProductCode", FinishProductCode)};

                return Execute.RunSP_RowsEffected(Connection, "SPDELETE_FinishProduct", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public FinishProductCollec Get()
        {

            try
            {


                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_FinishProduct_DataView");

                FinishProductCollec objCollec = new FinishProductCollec();


                for (int i = 0; i < dt.Rows.Count;i++ )
                {
                    FinishProduct objFinishProduct = new FinishProduct();

                    objFinishProduct.BasicProduct = objBasicProduct_DL.Get(Convert.ToString(dt.Rows[i]["BasicProductCode"]));
                    objFinishProduct.BasicProductQty = Convert.ToDecimal(dt.Rows[i]["FinishProdutBasicQty"]);
                    objFinishProduct.FinishProductAvgCost = Convert.ToDecimal(dt.Rows[i]["FinishProdutAvgCost"]);
                    objFinishProduct.FinishProductCode = Convert.ToString(dt.Rows[i]["FinishProductCode"]);
                    objFinishProduct.FinishProductDescription = Convert.ToString(dt.Rows[i]["FinishProductDescription"]);
                    objFinishProduct.FinishProductFormula = objFormula_DL.Get(Convert.ToInt32(dt.Rows[i]["FinishProdutFormulaID"]));
                    objFinishProduct.FinishProductPackingType = objPackingType_DL.Get(Convert.ToInt64(dt.Rows[i]["FinishProdutPackingTypeID"]));
                    objFinishProduct.FinishProductStatus = Convert.ToBoolean(dt.Rows[i]["FinishProductStatus"]);
                    objFinishProduct.FinishProductType = Convert.ToString(dt.Rows[i]["FinishProductType"]);
                    objFinishProduct.PrimaryFinishProductQty = Convert.ToDecimal(dt.Rows[i]["PrimaryFinishProductQty"]);
                    objFinishProduct.SKUID = Convert.ToInt32(dt.Rows[i]["SKUID"]);


                    objCollec.Add(objFinishProduct);

                }

                return objCollec;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }

            
             
              
        }

        public FinishProduct Get(String FinishProductCode)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@FinishProductCode", FinishProductCode)};


                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_FinishProductByID",paramList);

                FinishProduct objFinishProduct = new FinishProduct();

                if (dt.Rows.Count > 0)
                {

                    objFinishProduct.BasicProduct = objBasicProduct_DL.Get(Convert.ToString(dt.Rows[0]["BasicProductCode"]));
                    objFinishProduct.BasicProductQty = Convert.ToDecimal(dt.Rows[0]["FinishProdutBasicQty"]);
                    objFinishProduct.FinishProductAvgCost = Convert.ToDecimal(dt.Rows[0]["FinishProdutAvgCost"]);
                    objFinishProduct.FinishProductCode = Convert.ToString(dt.Rows[0]["FinishProductCode"]);
                    objFinishProduct.FinishProductDescription = Convert.ToString(dt.Rows[0]["FinishProdutDescription"]);
                    if (dt.Rows[0]["FinishProdutFormulaID"] != null)
                    {
                        objFinishProduct.FinishProductFormula = objFormula_DL.Get(Convert.ToInt32(dt.Rows[0]["FinishProdutFormulaID"]));
                    }
                    objFinishProduct.FinishProductPackingType = objPackingType_DL.Get(Convert.ToInt64(dt.Rows[0]["FinishProdutPackingTypeID"]));
                    objFinishProduct.FinishProductStatus = Convert.ToBoolean(dt.Rows[0]["FinishProdutStatus"]);
                    objFinishProduct.FinishProductType = Convert.ToString(dt.Rows[0]["FinishProductType"]);
                    objFinishProduct.PrimaryFinishProductQty = Convert.ToDecimal(dt.Rows[0]["PrimaryFinishProductQty"]);

                }
                    return objFinishProduct;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }

            
             
        }

        public System.Data.DataTable GetDataView(string Type,String BasicProduct)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@BasicProdcut", BasicProduct),
                new SqlParameter("@Type", Type)};

                return Execute.RunSP_DataTable(Connection, "SPGET_FinishProduct_DataView", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public System.Data.DataTable GetData_ByCategory(bool Status, String CatID)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@Status", Status),
                new SqlParameter("@ProductCategory", CatID)
                };

                return Execute.RunSP_DataTable(Connection, "SPGET_FinishProduct_ByCategory", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }



        public System.Data.DataTable GetDataView(String BasicProduct)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@BasicProductCode", BasicProduct)};

                return Execute.RunSP_DataTable(Connection, "SPGET_FinishProduct_ByBasicProduct", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }


        public System.Data.DataTable Get_SecondaryProductList(String FinishProduct)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@FinishProduct", FinishProduct)};

                return Execute.RunSP_DataTable(Connection, "SPGET_FinishProduct_SecondaryProductList", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public System.Data.DataTable Get_SecondaryProductList_All(String FinishProduct)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@FinishProduct", FinishProduct)};

                return Execute.RunSP_DataTable(Connection, "SPGET_FinishProduct_SecondaryProductList_All", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }


        public System.Data.DataTable Get_TertiaryProductList(String FinishProduct)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@FinishProduct", FinishProduct)};

                return Execute.RunSP_DataTable(Connection, "SPGET_FinishProduct_TertiaryProductList", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public System.Data.DataTable Get_TertiaryProductList_All(String FinishProduct)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@FinishProduct", FinishProduct)};

                return Execute.RunSP_DataTable(Connection, "SPGET_FinishProduct_TertiaryProductList_All", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public System.Data.DataTable GetDataView(int Status)
        {
            

            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                 new SqlParameter("@Status", Status)};

                return Execute.RunSP_DataTable(Connection, "SPGET_FinishProduct_DataView_Status", paramList);

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

                return Execute.RunSP_DataTable(Connection, "SPGET_FinishProduct_DataView_Search", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }



        public System.Data.DataTable GetBy_TypeandBasicProduct(String BasicProductCode,bool Status,string ProductType)
        {
            

            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@BasicProductCode", BasicProductCode),
                 new SqlParameter("@Status", Status),
                new SqlParameter("@ProductType", ProductType)};

                return Execute.RunSP_DataTable(Connection, "SPGET_FinishProduct_By_BasicProduct_and_Type", paramList);

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

                return Execute.RunSP_DataTable(Connection, "SPGET_FinishProduct_Dataview_ByStore", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }



        
    
    }
}
