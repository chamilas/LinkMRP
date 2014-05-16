using SESD.MRP.REF;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DL
{
    public class SalesForecastDetails_DL
    {
        SqlConnection Connection = new SqlConnection();
        private SqlConnection sqlConnection;

        public SalesForecastDetails_DL(SqlConnection Conn)
        {
            Connection = Conn;
        }

        public long Add(SalesForecastDetails obj)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@SalesForecastID", obj.SalesForecastID),
                new SqlParameter("@RevisionID", obj.RevisionID),
                new SqlParameter("@ProductCode", obj.ProductCode),
                new SqlParameter("@Qty", obj.Qty),
                new SqlParameter("@outParam",SqlDbType.Int,120){Direction=ParameterDirection.Output}
        };

                return Execute.RunSP_RowsEffected(Connection, "SPADD_SalesForecastDetails", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

    }
}
