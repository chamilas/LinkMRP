using SESD.MRP.REF;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DL
{
    public class ProductSubCategory_DL
    {
        SqlConnection Connection = new SqlConnection();
        public ProductSubCategory_DL(SqlConnection Conn)
        {
            Connection = Conn;
        }
        public int Add(ProductSubCategory obj)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@ProductSubCatID", obj.CategoryID),
                new SqlParameter("@ProductSubCategory", obj.Category)};

                return Execute.RunSP_RowsEffected(Connection, "SPADD_ProductSubCategory", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public int Update(ProductSubCategory obj,String Original_ProductSubCatID)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@ProductSubCatID", obj.CategoryID),
                new SqlParameter("@ProductSubCategory", obj.Category),
                new SqlParameter("@ProductSubCategory", Original_ProductSubCatID)};

                return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_ProductSubCategory", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }

        }

        public int Delete(String ProductSubCategoryID)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@Original_ProductSubCatID", ProductSubCategoryID)};

                return Execute.RunSP_RowsEffected(Connection, "SPDELETE_ProductSubCategory", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }



        public ProductSubCategory Get(String ProductSubCategoryID)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@ProductSubCategory", ProductSubCategoryID)};

                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_ProductSubCategoryByID", paramList);


                ProductSubCategory obj = new ProductSubCategory();


                obj.CategoryID = Convert.ToString(dt.Rows[0]["ProductSubCatID"]);
                obj.Category = Convert.ToString(dt.Rows[0]["ProductSubCategory"]);


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


                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_ProductSubCategory");



                return dt;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }
    }
}
