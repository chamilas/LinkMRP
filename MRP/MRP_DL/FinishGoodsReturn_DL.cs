using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DL
{
    public class FinishGoodsReturn_DL
    {
        SqlConnection Connection = new SqlConnection();

        public FinishGoodsReturn_DL(SqlConnection Conn)
        {
            Connection = Conn;
        }

        public long Add(long GRNNo, String CustomerID, int TerritoryID)
        {
            try
            {
                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@GRNNo", GRNNo),
                new SqlParameter("@CustomerID", CustomerID),
                new SqlParameter("@TerritoryID", TerritoryID)};

                return Execute.RunSP_RowsEffected(Connection, "SPADD_FinishGoodsReturn", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

    }
}
