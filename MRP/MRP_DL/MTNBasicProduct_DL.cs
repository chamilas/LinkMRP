using SESD.MRP.REF;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DL
{
    public class MTNBasicProduct_DL
    {
        SqlConnection Connection = new SqlConnection();
        public MTNBasicProduct_DL(SqlConnection Conn)
        {
            Connection = Conn;
        }
        public int Add(MTNBasicProduct obj)
        {

            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@MTNNO", obj.MTN.MTNNo),
                new SqlParameter("@MTNBasicProductID", obj.BasicProduct.BasicProductCode),
                new SqlParameter("@MTNBatchNo", obj.Batch),
                new SqlParameter("@MTNDescription", obj.Description),
                new SqlParameter("@MTNTransferQty", obj.TransferQty),
                new SqlParameter("@MTNUnitRate", obj.UnitRate),
                new SqlParameter("@MTNRceivedQty",  obj.ReceivedQty)
        };

                return Execute.RunSP_RowsEffected(Connection, "SPADD_MTNBasicProduct", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }


        public int Update_Cost(MTNBasicProduct obj, long OriginalMTNNO, String OriginalBasicProductCode)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@MTNUnitRate", obj.UnitRate_Budget),
                new SqlParameter("@Original_MTNNO",  OriginalMTNNO),
                new SqlParameter("@Original_MTNBasicProductID", OriginalBasicProductCode)
        };

                return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_MTNBasicProduct_Cost", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }


        public int Add(MTNBasicProduct obj, String StoreID, long GRNNO)
        {
            

           try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@MTNNO", obj.MTN.MTNNo),
                new SqlParameter("@MTNBasicProductID", obj.BasicProduct.BasicProductCode),
                new SqlParameter("@MTNDescription", obj.Description),
                new SqlParameter("@MTNTransferQty", obj.TransferQty),
                new SqlParameter("@MTNUnitRate", obj.UnitRate),
                new SqlParameter("@StoreID",  obj.MTN.MTNStore.StoreID)
        };

                return Execute.RunSP_RowsEffected(Connection, "SPADD_MTNBasicProduct_BY_GRN", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public int Update(MTNBasicProduct obj, long OriginalMTNNO, String OriginalBasicProductCode)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@MTNNO", obj.MTN.MTNNo),
                new SqlParameter("@MTNBasicProductID", obj.BasicProduct.BasicProductCode),
                new SqlParameter("@MTNBatchNo", obj.Description),
                new SqlParameter("@MTNDescription", obj.TransferQty),
                new SqlParameter("@MTNTransferQty", obj.UnitRate),
                new SqlParameter("@MTNUnitRate",  obj.MTN.MTNStore.StoreID),
                 new SqlParameter("@MTNRceivedQty",  obj.MTN.MTNStore.StoreID),
                  new SqlParameter("@Original_MTNNO",  obj.MTN.MTNStore.StoreID),
                  new SqlParameter("@Original_MTNBasicProductID",  obj.MTN.MTNStore.StoreID)
        };

                return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_MTNBasicProduct", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }

        }


        public int Update(long MTNNO,Decimal ReceivedQty,String BasicProductCode)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@MTNNO", MTNNO),
                 new SqlParameter("@MTNRceivedQty",  ReceivedQty),
                  new SqlParameter("@BasicProductCode",  BasicProductCode)
        };

                return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_MTNBasicProduct_GRN", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }

        }

        public int Delete(long MTNNO,String BasicProductCode)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@Original_MTNNO", MTNNO),
                 new SqlParameter("@Original_MTNBasicProductID",  BasicProductCode)
        };

                return Execute.RunSP_RowsEffected(Connection, "SPDELETE_MTNBasicProduct", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public MTNBasicProductCollec Get()
        {
            return null;
        }

        public MTNBasicProduct Get(long MTNNO,String BasicProductCode)
        {

            BasicProduct_DL objBasicProduct_DL = new BasicProduct_DL(Connection);
            MTN_DL objMTN_DL = new MTN_DL(Connection);

            MTNBasicProduct objMTNBasicProduct = new MTNBasicProduct();

            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@MTNNO", MTNNO),
                 new SqlParameter("@BasicProductCode",  BasicProductCode)
                };

                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_MTNBasicProductByID", paramList);
                if (dt.Rows.Count > 0)
                {

                    objMTNBasicProduct.BasicProduct = objBasicProduct_DL.Get(Convert.ToString(dt.Rows[0]["MTNBasicProductID"]));
                    objMTNBasicProduct.Batch = "No";
                    objMTNBasicProduct.MTN = objMTN_DL.Get(Convert.ToInt64(dt.Rows[0]["MTNNO"]));
                    objMTNBasicProduct.ReceivedQty = Convert.ToDecimal(dt.Rows[0]["MTNRceivedQty"]);

                    if (dt.Rows[0]["MTNUnitRate"] != DBNull.Value)
                    {
                        objMTNBasicProduct.UnitRate = Convert.ToDecimal(dt.Rows[0]["MTNUnitRate"]);
                    }
                    if (dt.Rows[0]["MTNTransferQty"] != DBNull.Value)
                    {
                        objMTNBasicProduct.TransferQty = Convert.ToDecimal(dt.Rows[0]["MTNTransferQty"]);
                    }
                }
                return objMTNBasicProduct;


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }

        }
    }
}
