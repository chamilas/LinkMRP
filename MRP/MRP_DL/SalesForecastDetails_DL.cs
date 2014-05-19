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

        public long Add(SalesForecast obj1, SalesForecastDetails obj2)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                

                new SqlParameter("@prmYear", obj1.Year),
                new SqlParameter("@prmMonth", obj1.Month),
                new SqlParameter("@prmWeekID", obj1.WeekID),
                new SqlParameter("@SalesForecastID", obj2.SalesForecastID),
                new SqlParameter("@ProductCode", obj2.ProductCode),
                new SqlParameter("@Qty", obj2.Qty),
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
