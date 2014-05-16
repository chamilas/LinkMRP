using System;
using System.Collections.Generic;
using System.Text;
using DL;
using SESD.MRP.REF;
using System.Data.SqlClient;
using System.Data;

namespace DL
{
    public class BatchFormualFinishProducts_DL
    {
        SqlConnection Connection = new SqlConnection();
        public BatchFormualFinishProducts_DL(SqlConnection Conn)
        {
            Connection = Conn;
        }

        //public int Add(BatchFormualFinishProducts obj)
        //{
        //    try
        //    {
        //        return da.Insert(obj.FinishProductCode,
        //            obj.BatchID,
        //            obj.Qty,
        //            obj.Part,
        //            obj.Type,
        //            obj.AddedBy,
        //            obj.AddedDate,
        //            obj.Remarks,
        //            obj.Status);
        //    }
        //    catch (Exception ex)
        //    {
                
        //        throw ex;
        //    }
        //}

        //public int Delete(String FinishCode, String BatchID, String Part)
        //{
        //    try
        //    {
        //        return da.Delete(FinishCode, BatchID, Part);
        //    }
        //    catch (Exception ex)
        //    {
                
        //        throw ex;
        //    }
        //}

        //public int Update(BatchFormualFinishProducts obj, BatchFormualFinishProducts OriginalObj)
        //{
        //    try
        //    {
        //        return da.Update(obj.FinishProductCode,
        //            obj.BatchID,
        //            obj.Qty,
        //            obj.Part,
        //            obj.Type,
        //            obj.AddedBy,
        //            obj.AddedDate,
        //            obj.Remarks,
        //            obj.Status,
        //            OriginalObj.FinishProductCode,
        //            OriginalObj.BatchID,
        //            OriginalObj.Part);
        //    }
        //    catch (Exception ex)
        //    {
                
        //        throw ex;
        //    }
        //}

        //public int Update_Weigh(BatchFormualFinishProducts obj)
        //{
        //    try
        //    {
        //        return da.SPUPDATE_BatchFormualFinishProducts_Weigh(obj.FinishProductCode,
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


        //public int Update_Check(BatchFormualFinishProducts obj)
        //{
        //    try
        //    {
        //        return da.SPUPDATE_BatchFormualFinishProducts_Check(obj.FinishProductCode,
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

        //public BatchFormualFinishProducts Get(String MaterialCode, String BatchID, String Part)
        //{
        //    MRPDataSetProduction.tblBatchFormualFinishProductsDataTable dt = new MRPDataSetProduction.tblBatchFormualFinishProductsDataTable();
        //    try
        //    {
        //        da.FillByID(dt, MaterialCode,
        //            BatchID,
        //            Part);

        //        if (dt.Rows.Count > 0)
        //        {
        //            MRPDataSetProduction.tblBatchFormualFinishProductsRow dr = (MRPDataSetProduction.tblBatchFormualFinishProductsRow)dt.Rows[0];

        //            BatchFormualFinishProducts obj = new BatchFormualFinishProducts();
        //            obj.AddedBy = dr.AddedBy;
        //            if (!dr.IsAddedDateNull())
        //            {
        //                obj.AddedDate = dr.AddedDate;
        //            }
                    
        //            obj.BatchID = dr.BatchID;
        //            obj.FinishProductCode = dr.FinishProductCode;
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

        //public DataTable GetView(String BatchID)
        //{
        //    try
        //    {
        //        return daView.GetDataByBatchID(BatchID);
        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }
        //}

        //public DataTable GetView(String BatchID, String Part, bool Weigh)
        //{
        //    try
        //    {
        //        return daView.GetDataByWeigh(BatchID, Part, Weigh);
        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }
        //}

        //public DataTable GetView(String BatchID, String Part)
        //{
        //    try
        //    {
        //        return daView.GetDataByBatchIDPart(BatchID,Part);
        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }
        //}

    }
}
