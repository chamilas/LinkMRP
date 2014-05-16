using SESD.MRP.REF;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DL
{
    public class BatchPackingMR_DL
    {
        SqlConnection Connection = new SqlConnection();
        public BatchPackingMR_DL(SqlConnection Conn)
        {
            Connection = Conn;
        }
      
        

        public String Add(BatchPackingMR obj)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@BatchNo", obj.BatchID),
                new SqlParameter("@MRNO",obj.MRNO),
                new SqlParameter("@BatchUsed", obj.BatchUsed),
                new SqlParameter("@BatchDamaged", obj.BatchDamaged),
                new SqlParameter("@BatchReturned", obj.BatchReturned),
                new SqlParameter("@MRState", obj.State),
                 new SqlParameter("@IssuedBy", obj.IssuedBy),
                new SqlParameter("@IssuedDate", obj.IssuedDate),
                new SqlParameter("@BulkPrint", obj.BulkPrint)};

                return Execute.RunSP_Output_String(Connection, "SPADD_BatchPackingMR", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

     public int Update(BatchPackingMR obj,MTN.Status MTNState,MTN.Type MTNType,MTN.ItemType MTNItemType,string EnteredBy)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                 new SqlParameter("@BatchID", obj.BatchID),
                new SqlParameter("@BatchUsed", obj.BatchUsed),
                new SqlParameter("@BatchDamaged", obj.BatchDamaged),
                new SqlParameter("@BatchReturned", obj.BatchReturned),
                new SqlParameter("@State", obj.State),
                 new SqlParameter("@MTNStatus",Convert.ToInt32(MTNState)),
                 new SqlParameter("@MTNType", Convert.ToInt32(MTNType)),
                 new SqlParameter("@MTNItemType", Convert.ToInt32(MTNItemType)),
                 new SqlParameter("@EnteredBy",EnteredBy),
                 new SqlParameter("@IssuedBy", Convert.ToInt32(MTNType)),
                 new SqlParameter("@BatchPackingID", obj.BatchPackingID),
                new SqlParameter("@ID", obj.ID)};

                return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_BatchPackingMR", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

     public int Update_RPD(BatchPackingMR obj, MTN.Status MTNState, MTN.Type MTNType, MTN.ItemType MTNItemType, string EnteredBy)
     {
         try
         {


             SqlParameter[] paramList = new SqlParameter[] {
                 new SqlParameter("@BatchID", obj.BatchID),
                new SqlParameter("@BatchUsed", obj.BatchUsed),
                new SqlParameter("@BatchDamaged", obj.BatchDamaged),
                new SqlParameter("@BatchReturned", obj.BatchReturned),
                new SqlParameter("@State", obj.State),
                 new SqlParameter("@MTNStatus",Convert.ToInt32(MTNState)),
                 new SqlParameter("@MTNType", Convert.ToInt32(MTNType)),
                 new SqlParameter("@MTNItemType", Convert.ToInt32(MTNItemType)),
                 new SqlParameter("@EnteredBy",EnteredBy),
                 new SqlParameter("@IssuedBy", Convert.ToInt32(MTNType)),
                 new SqlParameter("@StartQty", obj.StartQty),
                new SqlParameter("@ID", obj.ID)};

             return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_BatchPackingMR_RPD", paramList);

         }
         catch (Exception ex)
         {

             throw new Exception(ex.Message, ex);
         }
     }



     public DataTable GetData_ByBatchID(string BatchID)
     {

         try
         {
             SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@BatchID", BatchID)};


             return Execute.RunSP_DataTable(Connection, "SPGET_BatchPackingMR_ByBatchID", paramList);
         }
         catch (Exception ex)
         {

             throw new Exception(ex.Message, ex);
         }

     }

    

     public DataTable GetData(string BasicProductCode,string MaterialCode)
        {
            
            try
            {
                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@BasicProductCode", BasicProductCode),
                new SqlParameter("@MaterialCode", MaterialCode)};


                return Execute.RunSP_DataTable(Connection, "SPGET_BatchPackingMR",paramList);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
           
        }

     public DataTable GetData_Packing_ToSection(int DepID,int MRStatus,int OriginType)
     {

         try
         {
             SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@DepID", DepID),
             new SqlParameter("@MRStatus", MRStatus),
              new SqlParameter("@OriginType", OriginType)};


             return Execute.RunSP_DataTable(Connection, "SPGET_MR_Packing_ToSection", paramList);
         }
         catch (Exception ex)
         {

             throw new Exception(ex.Message, ex);
         }

     }



     public DataTable GetData_ByDepID(int DepID)
     {

         try
         {
             SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@DepID", DepID)};


             return Execute.RunSP_DataTable(Connection, "SPGET_BatchPackingMR", paramList);
         }
         catch (Exception ex)
         {

             throw new Exception(ex.Message, ex);
         }

     }

 public DataTable GetData_WIP(int SectionID)
        {
            
            try
            {
                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@SectionID", SectionID)
                };


                return Execute.RunSP_DataTable(Connection, "SPGET_BatchPackingMR_WIP", paramList);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
           
        }

 public DataTable GetStock(string BasicProduct,string MaterialCode)
 {

     try
     {
         SqlParameter[] paramList = new SqlParameter[] {
                
                 new SqlParameter("@BasicProductCode", BasicProduct),
                 new SqlParameter("@MaterialCode", MaterialCode)
         };


         return Execute.RunSP_DataTable(Connection, "SPGET_BatchPackingMR_MaterialStock", paramList);
     }
     catch (Exception ex)
     {

         throw new Exception(ex.Message, ex);
     }

 }




 public DataTable GetMaterialList(string BasicProduct)
 {

     try
     {
         SqlParameter[] paramList = new SqlParameter[] {
                
                 new SqlParameter("@BasicProductCode", BasicProduct)};


         return Execute.RunSP_DataTable(Connection, "SPGET_BatchPackingMR_MaterialList", paramList);
     }
     catch (Exception ex)
     {

         throw new Exception(ex.Message, ex);
     }

 }



     public DataTable GetData(long MRNO,string MaterialCode)
        {
            
            try
            {
                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@MRNO", MRNO),
                 new SqlParameter("@MaterialCode", MaterialCode)};


                return Execute.RunSP_DataTable(Connection, "SPGET_BatchPackingMR_Count", paramList);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
           
        }



        public BatchPackingMR Get(long ID)
        {

            try
            {
                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@ID", ID)};


                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_BatchPackingMR_ByID",paramList);

                BatchPackingMR obj = new BatchPackingMR();

                if (dt.Rows.Count != 0)
                {

                    obj.BatchDamaged = Convert.ToDecimal(dt.Rows[0]["BatchDamaged"]);
                    if (dt.Rows[0]["BatchNO"] != DBNull.Value)
                    {
                        obj.BatchID = Convert.ToString(dt.Rows[0]["BatchNO"]);
                    }
                    obj.BatchReturned = Convert.ToDecimal(dt.Rows[0]["BatchReturned"]);
                    obj.BatchUsed = Convert.ToDecimal(dt.Rows[0]["BatchUsed"]);
                    obj.ID = Convert.ToInt64(dt.Rows[0]["ID"]);
                    obj.State = Convert.ToInt32(dt.Rows[0]["State"]);
                    obj.MRNO = Convert.ToInt64(dt.Rows[0]["MRNO"]);
                    obj.MaterialCode = Convert.ToString(dt.Rows[0]["MaterialCode"]);
                    obj.StartQty = Convert.ToDecimal(dt.Rows[0]["StartQty"]);
                    
                }

                return obj;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }

        }





    }
}
