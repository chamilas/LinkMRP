using System;
using System.Collections.Generic;
using System.Text;
using SESD.MRP.REF;
using DL;
using System.Data.SqlClient;
using System.Data;

namespace DL
{
    public class StockHoldingRate_DL
    {
        SqlConnection Connection = new SqlConnection();

        public StockHoldingRate_DL(SqlConnection Conn)
        {
            this.Connection = Conn;
        }


        public int Add(StockHoldingRate obj)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                new SqlParameter("@FromDate",obj.FromDate),
                new SqlParameter("@ToDate", obj.ToDate),
                 new SqlParameter("@Rate", obj.Cost),
                 new SqlParameter("@ChangedBy", obj.ChangedBy)};

                return Execute.RunSP_RowsEffected(Connection, "SPADD_StockHoldingRate", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public StockHoldingRate GetFinal()
        {
            try
            {
                StockHoldingRate obj = new StockHoldingRate();


                DataTable dt= Execute.RunSP_DataTable(Connection, "SPGET_StockHoldingRate_Final");


                obj.ChangedBy = Convert.ToString(dt.Rows[0]["ChangeBy"]);
                obj.Cost = Convert.ToDecimal(dt.Rows[0]["Rate"]);
                obj.FromDate = Convert.ToDateTime(dt.Rows[0]["FromDate"]);
                obj.ID = Convert.ToDecimal(dt.Rows[0]["ID"]);
                obj.ToDate = Convert.ToDateTime(dt.Rows[0]["ToDate"]);


                return obj;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
            
        }


        public DataTable Get()
        {
            try
            {

                return Execute.RunSP_DataTable(Connection, "SPGET_StockHoldingRate");

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

    }
}
