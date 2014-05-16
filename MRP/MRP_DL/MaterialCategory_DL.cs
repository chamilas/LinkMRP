using SESD.MRP.REF;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DL
{
    public class MaterialCategory_DL
    {
        SqlConnection Connection = new SqlConnection();


        public MaterialCategory_DL(SqlConnection Conn)
        {
            Connection = Conn;
        }
        public int Add(MaterialCategory obj)
        {
            try
            {
                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@MatCatID",obj.MatCatID),
                new SqlParameter("@MaterialCategory", obj.MaterialCategoryName)};


                return Execute.RunSP_RowsEffected(Connection, "SPADD_MaterialCategory", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }


        }


        public int Update(MaterialCategory obj,String OriginalCatID)
        {
            try
            {
                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@MatCatID",obj.MatCatID),
                new SqlParameter("@MaterialCategory", obj.MaterialCategoryName),
                 new SqlParameter("@Original_MatCatID", OriginalCatID)};


                return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_MaterialCategory", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

       

        public int Delete(String MaterialCategoryCode)
        {
            try
            {
                SqlParameter[] paramList = new SqlParameter[] {
                
                 new SqlParameter("@Original_MatCatID", MaterialCategoryCode)};


                return Execute.RunSP_RowsEffected(Connection, "SPDELETE_MaterialCategory", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public MaterialCategoryCollec Get()
        {
            try
            {

                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_MaterialCategory");

                
                MaterialCategoryCollec obj = new MaterialCategoryCollec();

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    MaterialCategory objMatCat = new MaterialCategory();
                    objMatCat.MatCatID = Convert.ToString(dt.Rows[0]["MatCatID"]);
                    objMatCat.MaterialCategoryName = Convert.ToString(dt.Rows[0]["MaterialCategory"]);
                    obj.Add(objMatCat);
                }
                return obj;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
            
            
        }

        public MaterialCategory Get(String MaterialCategoryCode)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                 new SqlParameter("@MatCategory", MaterialCategoryCode)};


                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_MaterialCategoryByID", paramList);


                MaterialCategory objMatCat = new MaterialCategory();

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    
                    objMatCat.MatCatID = Convert.ToString(dt.Rows[0]["MatCatID"]);
                    objMatCat.MaterialCategoryName = Convert.ToString(dt.Rows[0]["MaterialCategory"]);
                }

                return objMatCat;

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

                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_MaterialCategory");

                return dt;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
            
        }
    }
}
