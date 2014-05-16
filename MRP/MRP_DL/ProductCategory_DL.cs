using SESD.MRP.REF;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DL
{
    public class ProductCategory_DL
    {
        SqlConnection Connection = new SqlConnection();

       public ProductCategory_DL(SqlConnection Conn)
        {
            Connection = Conn;
        }
        
        
        public int Add(ProductCategory obj)
        {
              try
            {
                

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@ProductCatID", obj.CategoryID),
                new SqlParameter("@ProductCategory", obj.Category)};

               return  Execute.RunSP_RowsEffected(Connection, "SPADD_ProductCategory", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
            
        }

        
        

        public int Update(ProductCategory obj,String Original_CatID)
        {
             try
            {
                

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@ProductCatID", obj.CategoryID),
                new SqlParameter("@ProductCategory", obj.Category),
                new SqlParameter("@Original_ProductCatID", obj.Category)};

                return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_ProductCategory", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
            
        }

        public int Delete(String ProductCatID)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@ProductCatID", ProductCatID)};

                return Execute.RunSP_RowsEffected(Connection, "SPDELETE_ProductCategory", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }



        public ProductCategory Get(String ProductCatID)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@ProductCategoryID", ProductCatID)};

                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_ProductCategoryByID", paramList);


                ProductCategory obj = new ProductCategory();


                obj.CategoryID = Convert.ToString(dt.Rows[0]["ProductCatID"]);
                obj.Category = Convert.ToString(dt.Rows[0]["ProductCategory"]);


                return obj;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public DataTable GetDataView()
        {
            try
            {

                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_ProductCategory");

                return dt;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public DataTable GetDataView_WithRate()
        {
            try
            {

                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_ProductCategory");

                return dt;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }
    }
}
