using System;
using System.Collections.Generic;
using System.Text;
using DL;
using SESD.MRP.REF;
using System.Data.SqlClient;
using System.Data;

namespace DL
{
    public class BatchFormulaBasicProducts_DL
    {
        SqlConnection Connection = new SqlConnection();
        
        public BatchFormulaBasicProducts_DL(SqlConnection Conn)
        {
            Connection = Conn;
        }

        public int Add(BatchFormulaBasicProducts obj)
        {
              try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@MaterialCode", obj.BasicProductCode),
                new SqlParameter("@BatchID", obj.BatchID),
                new SqlParameter("@Qty",obj.Qty),
                new SqlParameter("@Part", obj.Part),
                new SqlParameter("@Type", obj.Type),
                new SqlParameter("@AddedBy", obj.AddedBy),
                new SqlParameter("@Remarks", obj.Remarks),
                new SqlParameter("@Status", obj.Status),
     };

                return Execute.RunSP_Int(Connection, "SPADD_BatchFormulaBasicProducts", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

       public int Update(BatchFormulaBasicProducts obj)
        {
              try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@BasicProductCode", obj.BasicProductCode),
                 new SqlParameter("@Qty", obj.Qty),
                new SqlParameter("@BatchID", obj.BatchID),
                new SqlParameter("@Part", obj.Part),
                 new SqlParameter("@AddedBy", obj.AddedBy),
                 new SqlParameter("@Remarks", obj.Remarks)
     };

                return Execute.RunSP_Int(Connection, "SPUPDATE_BatchFormulaBasicProducts", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }



        

        //public int Update(BatchFormulaBasicProducts obj, BatchFormulaBasicProducts OriginalObj)
        //{
        //    try
        //    {
        //        return da.Update(obj.BasicProductCode,
        //            obj.BatchID,
        //            obj.Qty,
        //            obj.Part,
        //            obj.Type,
        //            obj.AddedBy,
        //            obj.AddedDate,
        //            obj.Remarks,
        //            obj.Status,
        //            OriginalObj.BasicProductCode,
        //            OriginalObj.BatchID,
        //            OriginalObj.Part);
        //    }
        //    catch (Exception ex)
        //    {
                
        //        throw ex;
        //    }
        //}

        //public int Update_Weigh(BatchFormulaBasicProducts obj)
        //{
        //    try
        //    {
        //        return da.SPUPDATE_BatchFormulaBasicProducts_Weigh(obj.BasicProductCode,
        //            obj.BatchID,
        //            obj.Part,
        //            obj.Weigh,
        //            obj.WeighBy);
        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }
        //}


        //public int Update_Check(BatchFormulaBasicProducts obj)
        //{
        //    try
        //    {
        //        return da.SPUPDATE_BatchFormulaBasicProducts_Check(obj.BasicProductCode,
        //            obj.BatchID,
        //            obj.Part,
        //            obj.WeighingCheck,
        //            obj.WeighingCheckBy);
        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }
        //}

        //public BatchFormulaBasicProducts Get(String BatchFormulaBasicProducts, String BatchID, String Part)
        //{
        //    MRPDataSetProduction.tblBatchFormulaBasicProductsDataTable dt = new MRPDataSetProduction.tblBatchFormulaBasicProductsDataTable();
        //    try
        //    {
        //        da.FillByID(dt, BatchFormulaBasicProducts,
        //            BatchID,
        //            Part);

        //        if (dt.Rows.Count > 0)
        //        {
        //            MRPDataSetProduction.tblBatchFormulaBasicProductsRow dr = (MRPDataSetProduction.tblBatchFormulaBasicProductsRow)dt.Rows[0];

        //            BatchFormulaBasicProducts obj = new BatchFormulaBasicProducts();
        //            obj.AddedBy = dr.AddedBy;
        //            if (!dr.IsAddedDateNull())
        //            {
        //                obj.AddedDate = dr.AddedDate;
        //            }
        //            obj.BatchID = dr.BatchID;
        //            obj.BasicProductCode = dr.BasicProductCode;
        //            obj.Part = dr.Part;
        //            obj.Qty = dr.Qty;
        //            obj.Remarks = dr.Remarks;
        //            obj.Status = dr.Status;
        //            obj.Type = dr.Type;


        //            if (!dr.IsWeighByNull())
        //            {
        //                obj.WeighBy = dr.WeighBy;
        //            }

        //            if (!dr.IsWeighDateNull())
        //            {
        //                obj.WeighDate = dr.WeighDate;
        //            }

        //            if (!dr.IsWeighNull())
        //            {
        //                obj.Weigh = dr.Weigh;
        //            }

        //            if (!dr.IsWeighingCheckByNull())
        //            {
        //                obj.WeighingCheckBy = dr.WeighingCheckBy;
        //            }

        //            if (!dr.IsWeighingCheckDateNull())
        //            {
        //                obj.WeighingCheckDate = dr.WeighingCheckDate;
        //            }

        //            if (!dr.IsWeighingCheckNull())
        //            {
        //                obj.WeighingCheck = dr.WeighingCheck;
        //            }



        //            if (!dr.IsMissedNull())
        //            {
        //                obj.Missed = dr.Missed;
        //            }

        //            if (!dr.IsMissedWeighByNull())
        //            {
        //                obj.MissedWeighBy = dr.MissedWeighBy;
        //            }

        //            if (!dr.IsMissedWeighDateNull())
        //            {
        //                obj.MissedWeighDate = dr.MissedWeighDate;
        //            }

        //            return obj;
        //        }
        //        return null;
        //    }
        //    catch (Exception ex)
        //    {
                
        //        throw ex;
        //    }
        //}

        //public DataTable GetView()
        //{
        //    try
        //    {
        //        return daView.GetData();
        //    }
        //    catch (Exception ex)
        //    {
                
        //        throw ex;
        //    }
        //}

        public DataTable GetBasicProduct_NotReceived(String BatchID)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@BatchID", BatchID)
     };

                return Execute.RunSP_DataTable(Connection, "SPGET_BatchFormulaBasicProduct_NotReceived", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public DataTable GetView(String BatchID, String Part)
        {
            

             try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@BatchID", BatchID),
                new SqlParameter("@Part", Part)
                };

                return Execute.RunSP_DataTable(Connection, "SPGET_BatchFormulaBasicProducts_View_By_BatchID_Part", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }


        public DataTable GetSemiFinished(String BatchID)
        {


            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@BatchID", BatchID)
                };

                return Execute.RunSP_DataTable(Connection, "SPGET_BatchFormulaBasicProducts_View_By_BatchID", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }



        //public DataTable GetView(String BatchID, String Part, bool Weigh)
        //{
        //    try
        //    {
        //        return daView.GetDataByWeigh(BatchID, Part,Weigh);
        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }
        //}


        //public DataTable GetView_Qty(String BatchID, String Part)
        //{
        //    try
        //    {
        //        return daQtyView.GetDataByBatchID(Part,BatchID);
        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        ////    }
        //}
    }




}
