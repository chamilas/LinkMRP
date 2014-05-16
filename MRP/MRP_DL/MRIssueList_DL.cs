using SESD.MRP.REF;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DL
{
    public class MRIssueList_DL
    {
        SqlConnection Connection = new SqlConnection();
        
        MR_DL objMR_DL = new MR_DL(ConnectionStringClass.GetConnection());
        GRN_DL objGRN_DL = new GRN_DL(ConnectionStringClass.GetConnection());
        Stock_DL objStock_DL = new Stock_DL(ConnectionStringClass.GetConnection());

        public MRIssueList_DL(SqlConnection Conn)
        {
            Connection = Conn;
        }

        public int Add(MRIssueList obj)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@MRNO", obj.MR.MRNO),
                new SqlParameter("@StockID", obj.Stock.StockID),
                new SqlParameter("@GRNNO", obj.GRN.GRNNo),
                new SqlParameter("@Qty", obj.Qty)
                
             };

                return Execute.RunSP_RowsEffected(Connection, "SPADD_MRIssueList", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public int Update(MRIssueList obj,long OriginalMRNO,long OriginalStockNo,long OriginalGRNNO)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@MRNO", obj.MR.MRNO),
                new SqlParameter("@StockID", obj.Stock.StockID),
                new SqlParameter("@GRNNO", obj.GRN.GRNNo),
                new SqlParameter("@Qty", obj.Qty),
                new SqlParameter("@Original_MRNO",OriginalMRNO),
                new SqlParameter("@Original_StockID",OriginalStockNo),
                new SqlParameter("@Original_GRNNO", OriginalGRNNO)
                
             };

                return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_MRIssueList", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public int Delete(long MRNO, long StockID,long GRNNO)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                new SqlParameter("@Original_MRNO",MRNO),
                new SqlParameter("@Original_StockID",StockID),
                new SqlParameter("@Original_GRNNO", GRNNO)
                
             };

                return Execute.RunSP_RowsEffected(Connection, "SPDELETE_MRIssueList", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public MRIssueListCollec Get()
        {
            return null;
        }

        public MRIssueList Get(long MRNO, long StockID, long GRNNO)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                new SqlParameter("@MRNO",MRNO),
                new SqlParameter("@StockID",StockID),
                new SqlParameter("@GRNNO", GRNNO)
                
             };

                DataTable dt= Execute.RunSP_DataTable(Connection, "SPGET_MRIssueListByID", paramList);

                MRIssueList objMRIssueList = new MRIssueList();

                objMRIssueList.GRN = objGRN_DL.Get(Convert.ToInt64(dt.Rows[0]["GRNNO"]));
                objMRIssueList.MR = objMR_DL.Get(Convert.ToInt64(dt.Rows[0]["MRNO"]));
                objMRIssueList.Qty = Convert.ToDecimal(dt.Rows[0]["Qty"]);
                objMRIssueList.Stock = objStock_DL.Get(Convert.ToInt64(dt.Rows[0]["StockID"]));

                return objMRIssueList;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }



            

        }
    }
}
