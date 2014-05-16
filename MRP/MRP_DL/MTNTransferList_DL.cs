using SESD.MRP.REF;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DL
{
    public class MTNTransferList_DL
    {
        SqlConnection Connection = new SqlConnection();


        public MTNTransferList_DL(SqlConnection Conn)
        {
            Connection = Conn;
        }
        public int Add(MTNTransferList obj)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@MTNNO", obj.MTN.MTNNo),
                new SqlParameter("@StockID", obj.Stock.StockID),
                new SqlParameter("@GRNNO", obj.GRN.GRNNo),
                new SqlParameter("@Qty", obj.Qty)

        };

                return Execute.RunSP_RowsEffected(Connection, "SPADD_MTNTransferList", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public int Update(MTNTransferList obj,long OriginalMTNNO,long OriginalStockID,long OriginalGRNNO)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@MTNNO", obj.MTN.MTNNo),
                new SqlParameter("@StockID", obj.Stock.StockID),
                new SqlParameter("@GRNNO", obj.GRN.GRNNo),
                new SqlParameter("@Qty", obj.Qty),
                  new SqlParameter("@Original_MTNNO", OriginalMTNNO),
                new SqlParameter("@Original_StockID", OriginalStockID),
                new SqlParameter("@Original_GRNNO", OriginalGRNNO)

        };

                return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_MTNTransferList", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public int Delete(long MTNNO, long StcokID, long GRNNO)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@Original_MTNNO", MTNNO),
                new SqlParameter("@Original_StockID", StcokID),
                new SqlParameter("@Original_GRNNO", GRNNO)

        };

                return Execute.RunSP_RowsEffected(Connection, "SPDELETE_MTNTransferList", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }


        }

        public MTNTransferListCollec Get()
        {
            return null;
        }

        public MTNTransferList Get(long MTNNO, long StcokID,long GRNNO)
        {
            MTN_DL objMTN_DL = new MTN_DL(Connection);
            Stock_DL objStock_DL = new Stock_DL(Connection);
            GRN_DL objGRN_DL = new GRN_DL(Connection);

            MTNTransferList objMTNTransferList = new MTNTransferList();
            
            
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@Original_MTNNO", MTNNO),
                new SqlParameter("@Original_StockID", StcokID),
                new SqlParameter("@Original_GRNNO", GRNNO)

        };

                DataTable dt= Execute.RunSP_DataTable(Connection, "SPGET_MTNTransferListByID", paramList);


                objMTNTransferList.GRN = objGRN_DL.Get(Convert.ToInt64(dt.Rows[0]["GRNNO"]));
                objMTNTransferList.MTN = objMTN_DL.Get(Convert.ToInt64(dt.Rows[0]["MTNNO"]));
                objMTNTransferList.Stock = objStock_DL.Get(Convert.ToInt64(dt.Rows[0]["StockID"]));
                objMTNTransferList.Qty = Convert.ToDecimal(dt.Rows[0]["StockID"]);


                return objMTNTransferList;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }



        }
    }
}
