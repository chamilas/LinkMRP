using DL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using SESD.MRP.REF;

namespace MRP_DL
{
    public class SalesFinishProduct_DL
    {
        SqlConnection Connection = new SqlConnection();
        private SqlConnection sqlConnection;

        public SalesFinishProduct_DL(SqlConnection Conn)
        {
            Connection = Conn;
        }

        public long AddSalesFinishProduct(SalesFinishProducts obj)
        {

            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@FinishProductCode", obj.finishProductCode),
                new SqlParameter("@FinishedProductName ", obj.finishProductName),
                new SqlParameter("@IsSellable", obj.isSellable),
                new SqlParameter("@MRP", obj.price)
        };

                return Execute.RunSP_RowsEffected(Connection, "SPADD_SalesFinishProducts", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public long UpdateSalesFinishProduct(SalesFinishProducts obj)
        {

            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@FinishProductCode", obj.finishProductCode),
                new SqlParameter("@FinishedProductName ", obj.finishProductName),
                new SqlParameter("@IsSellable", obj.isSellable),
                new SqlParameter("@MRP", obj.price)
        };

                return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_SalesFinishProduct", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public DataTable GetSalesFinishProduct()
        {
            try
            {
                DataTable dt = new DataTable();

                dt = Execute.RunSP_DataTable(Connection, "SPGET_SalesFinishProducts");
                return dt;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public DataTable GetSalesFinishProduct_NOTSET()
        {
            try
            {
                DataTable dt = new DataTable();

                dt = Execute.RunSP_DataTable(Connection, "SPGET_SalesFinishProducts_NOTSET");
                return dt;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }
    }
}
