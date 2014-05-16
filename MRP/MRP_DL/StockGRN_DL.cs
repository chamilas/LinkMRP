using SESD.MRP.REF;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DL
{
    public class StockGRN_DL
    {
        SqlConnection Connection = new SqlConnection();


        public StockGRN_DL(SqlConnection Conn)
        {
            Connection = Conn;
        }


        public int Add(StockGRN obj)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@StockID", obj.Stock.StockID),
                new SqlParameter("@StockGRNNO", obj.GRN.GRNNo),
                 new SqlParameter("@StockDate", obj.StockGRNDate),
                 new SqlParameter("@StockIssuedQty", obj.IssuedQty)};

                return Execute.RunSP_RowsEffected(Connection, "SPADD_StockGRN", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public int Update(StockGRN obj, long OriginalStockID, long OriginalGRNNO)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@StockID", obj.Stock.StockID),
                new SqlParameter("@StockGRNNO", obj.GRN.GRNNo),
                 new SqlParameter("@StockDate", obj.StockGRNDate),
                 new SqlParameter("@StockIssuedQty", obj.IssuedQty),
                new SqlParameter("@Original_StockID", OriginalStockID),
                new SqlParameter("@Original_StockGRNNO", OriginalGRNNO)};

                return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_StockGRN", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public int Delete(long StockID, long GRNNO)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                new SqlParameter("@Original_StockID",StockID),
                new SqlParameter("@Original_StockGRNNO", GRNNO)};

                return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_StockGRN", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public StockGRNCollec Get()
        {
            return null;
        }

        public StockGRN Get(long StockID,long GRNNO)
        {
            GRN_DL objGRNDL = new GRN_DL(Connection);
            Stock_DL objStockDL = new Stock_DL(Connection);

            StockGRN objStockGRN = new StockGRN();

            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                new SqlParameter("@Original_StockID",StockID),
                new SqlParameter("@Original_StockGRNNO", GRNNO)};

                DataTable dt= Execute.RunSP_DataTable(Connection, "SPGET_StockGRNByID", paramList);

                objStockGRN.GRN = objGRNDL.Get(Convert.ToInt64(dt.Rows[0]["StockGRNNO"]));
                objStockGRN.IssuedQty = Convert.ToInt64(dt.Rows[0]["StockIssuedQty"]);
                objStockGRN.Stock = objStockDL.Get(Convert.ToInt64(dt.Rows[0]["StockID"]));
                objStockGRN.StockGRNDate = Convert.ToDateTime(dt.Rows[0]["StockDate"]);

                return objStockGRN;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }

            

        }
    }
}
