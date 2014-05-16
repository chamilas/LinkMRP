using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DL
{
    public class SalesMethod_DL
    {
        SqlConnection Connection = new SqlConnection();

        public SalesMethod_DL(SqlConnection Conn)
        {
            Connection = Conn;
        }

        public long Add(String SalesMethodID, String SMDesctiption)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@SalesMethodID", SalesMethodID),
                new SqlParameter("@SMDesctiption", SMDesctiption),
                new SqlParameter("@outParam",SqlDbType.Int,120){Direction=ParameterDirection.Output}
                };

                return Execute.RunSP_RowsEffected(Connection, "SPADD_SalesMethod", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public int Update(String SalesMethodID, String SMDesctiption)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {

                new SqlParameter("@SalesMethodID", SalesMethodID),
                new SqlParameter("@SMDesctiption", SMDesctiption)
                };

                return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_SalesMethod", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public int Delete(String SalesMethodID)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@SalesMethodID", SalesMethodID)};

                return Execute.RunSP_RowsEffected(Connection, "SPDELETE_SalesMethod", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public System.Data.DataTable Get()
        {
            try
            {

                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_SalesMethod");

                return dt;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

    }
}
