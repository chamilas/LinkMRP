using System;
using System.Collections.Generic;
using System.Text;
using SESD.MRP.REF;
using System.Data.SqlClient;
using System.Data;
using System.Data.Sql;

namespace DL
{
    public class RPDBatchActualProduction_DL
    {

        SqlConnection Connection = new SqlConnection();

        public RPDBatchActualProduction_DL(SqlConnection Conn)
       {
           Connection = Conn;
       }

        public int Add(String RPDBatchID)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@RPDBatchID", RPDBatchID)};

                return Execute.RunSP_RowsEffected(Connection, "SPADD_RPDBatchActualProduction_Insert", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }

        }

        public DataTable Get(String RPDBatchID)
        {


            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@RPDBatchID", RPDBatchID)};

                return Execute.RunSP_DataTable(Connection, "SPGET_RPDBatchActualProduction_By_RPDBatchID", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }

        }


      
    }
}
