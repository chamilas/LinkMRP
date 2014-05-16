using SESD.MRP.REF;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DL
{
    public class MaterialType_DL
    {
        SqlConnection Connection = new SqlConnection();


        public MaterialType_DL(SqlConnection Conn)
        {
            Connection = Conn;
        }


        public int Add(MaterialType obj)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@MatType", obj.MatType),
                new SqlParameter("@MaterialType", obj.MaterialTypeTitle),
                new SqlParameter("@LeadTime", obj.LeadTime)};

                return Execute.RunSP_RowsEffected(Connection, "SPADD_MaterialType", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }

        }

        public int Update(MaterialType obj,String OriginalMatTypeID)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@MatType", obj.MatType),
                new SqlParameter("@MaterialType", obj.MaterialTypeTitle),
                new SqlParameter("@LeadTime", obj.LeadTime),
                new SqlParameter("@Original_MatType", OriginalMatTypeID)};

                return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_MaterialType", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public int Delete(String MaterialTypeID)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@Original_MatType", MaterialTypeID)};

                return Execute.RunSP_RowsEffected(Connection, "SPDELETE_MaterialType", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public MaterialTypeCollec Get()
        {
            return null;
        }

        public MaterialType Get(String MaterialTypeID)
        {
           

                    try
                    {


                        SqlParameter[] paramList = new SqlParameter[] {new SqlParameter("@MatTypeID", MaterialTypeID)};

                        DataTable dt= Execute.RunSP_DataTable(Connection, "SPGET_MaterialTypeByID", paramList);

                        MaterialType obj = new MaterialType();

                        obj.MaterialTypeTitle =Convert.ToString(dt.Rows[0]["MaterialType"]);
                        obj.MatType = Convert.ToString(dt.Rows[0]["MatType"]);

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

                return Execute.RunSP_DataTable(Connection, "SPGET_MaterialType");

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }
    }
}
