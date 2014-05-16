using SESD.MRP.REF;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DL
{
    public class MTNFinishProduct_DL
    {
        SqlConnection Connection = new SqlConnection();


        public MTNFinishProduct_DL(SqlConnection Conn)
        {
            Connection = Conn;
        }
        public int Add(MTNFinishProduct obj)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@MTNNO", obj.MTN.MTNNo),
                new SqlParameter("@MTNBasicProductID", obj.FinishProduct.FinishProductCode),
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


        public int Add(MTNFinishProduct obj,String StoreID, long GRNNO)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@MTNNO", obj.MTN.MTNNo),
                new SqlParameter("@@MTNFinishProductID", obj.FinishProduct.FinishProductCode),
                new SqlParameter("@MTNDescription", obj.Description),
                new SqlParameter("@MTNTransferQty", obj.TransferQty),
                new SqlParameter("@MTNUnitRate", obj.UnitRate),
                new SqlParameter("@GRNNO", GRNNO),
                new SqlParameter("@StoreID",  StoreID)
        };

                return Execute.RunSP_RowsEffected(Connection, "SPADD_MTNFinishProduct_BY_GRN", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }

        }

        


         public int Update_Cost(MTNFinishProduct obj, long OriginalMTNNO,String OriginalFinisProductCode)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@MTNUnitRate", obj.UnitRate_Budget),
                new SqlParameter("@Original_MTNNO",  OriginalMTNNO),
                new SqlParameter("@Original_MTNFinishProductID", OriginalFinisProductCode)
        };

                return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_MTNFinishProduct_Cost", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }



        public int Update(MTNFinishProduct obj, long OriginalMTNNO,String OriginalFinisProductCode)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@MTNNO", obj.MTN.MTNNo),
                new SqlParameter("@MTNBasicProductID", obj.FinishProduct.FinishProductCode),
                new SqlParameter("@MTNBatchNo", obj.Batch),
                new SqlParameter("@MTNDescription", obj.Description),
                new SqlParameter("@MTNTransferQty", obj.TransferQty),
                new SqlParameter("@MTNUnitRate", obj.UnitRate),
                new SqlParameter("@MTNRceivedQty",  obj.ReceivedQty),
                new SqlParameter("@Original_MTNNO",  OriginalMTNNO),
                new SqlParameter("@Original_MTNFinishProductID", OriginalFinisProductCode)
        };

                return Execute.RunSP_RowsEffected(Connection, "SPADD_MTNFinishProduct", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public int Update(long MTNNO,String FinishProductCode,Decimal ReceivedQty)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@MTNNO", MTNNO),
                new SqlParameter("@MTNFinishProductID", FinishProductCode),
                new SqlParameter("@MTNRceivedQty",  ReceivedQty)
        };

                return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_MTNFinishProduct_GRN", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        //public int Issue_GRN(MTN objMTN)
        //{
        //    tblMTNFinishProductTableAdapter da = new tblMTNFinishProductTableAdapter();
        //    da.Connection = Connection;
        //    try
        //    {
        //        return Convert.ToInt32(da.SPUPDATE_GRN_MTN_ISSUE_FinishProduct_FOR_GRN(objMTN.MTNNo, objMTN.MTNStore.StoreID, objMTN.MTNGRN.GRNNo, Convert.ToInt32(MTN.Status.Approved), objMTN.MTNApprovedBy.EmployeeID));

        //    }

        //    catch (Exception ex)
        //    {

        //        throw new Exception(ex.Message, ex);
        //    }
        //    finally
        //    {
        //        da.Dispose();
        //    }
        //}

        public int Delete(long MTNNO, String FinishProductCode)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@Original_MTNNO", MTNNO),
                new SqlParameter("@Original_MTNFinishProductID", FinishProductCode)
        };

                return Execute.RunSP_RowsEffected(Connection, "SPDELETE_MTNFinishProduct", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
            
            
        }

        public MTNFinishProductCollec Get()
        {
            return null;
        }

        public MTNFinishProduct Get(long MTNNO, String FinishProductCode)
        {
            FinishProduct_DL objFinishProduct_DL = new FinishProduct_DL(Connection);
            MTN_DL objMTN_DL = new MTN_DL(Connection);

            MTNFinishProduct objMTNFinishProduct = new MTNFinishProduct();

            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@MTNNO", MTNNO),
                new SqlParameter("@FinishProductCode", FinishProductCode)
        };

                DataTable dt= Execute.RunSP_DataTable(Connection, "SPGET_MTNFinishProductByID", paramList);

                if (dt.Rows.Count > 0)
                {

                    objMTNFinishProduct.FinishProduct = objFinishProduct_DL.Get(Convert.ToString(dt.Rows[0]["MTNFinishProductID"]));
                    objMTNFinishProduct.Batch = "No";
                    objMTNFinishProduct.Description = "No";
                    objMTNFinishProduct.MTN = objMTN_DL.Get(Convert.ToInt64(dt.Rows[0]["MTNNO"]));
                    objMTNFinishProduct.ReceivedQty = Convert.ToDecimal(dt.Rows[0]["MTNRceivedQty"]);

                    if (dt.Rows[0]["MTNUnitRate"] != DBNull.Value)
                    {
                        objMTNFinishProduct.UnitRate = Convert.ToDecimal(dt.Rows[0]["MTNUnitRate"]);
                    }
                    else
                    {
                        objMTNFinishProduct.UnitRate = 0;
                    }
                    objMTNFinishProduct.TransferQty = Convert.ToDecimal(dt.Rows[0]["MTNTransferQty"]);
                }
                
                return objMTNFinishProduct;



            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }



            }
        }
