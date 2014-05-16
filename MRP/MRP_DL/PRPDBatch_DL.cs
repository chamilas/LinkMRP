using SESD.MRP.REF;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace DL
{
   public  class PRPDBatch_DL
    {

       SqlConnection Connection = new SqlConnection();

       public PRPDBatch_DL(SqlConnection Conn)
       {
           Connection = Conn;
       }

       Employee_DL objEmployee_DL = new Employee_DL(ConnectionStringClass.GetConnection());
       Material_DL objMaterial_DL = new Material_DL(ConnectionStringClass.GetConnection());
       MTN_DL objMTN_DL = new MTN_DL(ConnectionStringClass.GetConnection());

       public String AddReworkOrPR(PRPDBatch obj)
       {
           try
           {



               SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@PRPDBatchMaterialCode" , obj.PRPDBatchMaterial),
                new SqlParameter("@PRPDBatchQty" , obj.PRPDBatchQty),
                new SqlParameter("@PRPDBatchInstructedBy" , obj.PRPDBatchInstructedBy.EmployeeID),
                new SqlParameter("@PRPDBatchInstructedDate" , obj.PRPDBatchInstructedDate),
                new SqlParameter("@PRPDBatchStatus" , obj.Status),
                new SqlParameter("@MTNIN" , obj.PRPDBatchMTNIN),
                new SqlParameter("@Comments" , obj.PRPDBatchComments),
                new SqlParameter("@BatchType" , obj.Type),
                new SqlParameter("@outParam",SqlDbType.VarChar,50){Direction=ParameterDirection.Output}};

               return Execute.RunSP_Output_String(Connection, "SPADD_PRPDBatch_Initial", paramList);

           }
           catch (Exception ex)
           {

               throw new Exception(ex.Message, ex);
           }

       }

       public String AddPP(PRPDBatch obj)
       {
           try
           {



               SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@PRPDBatchMaterialCode" , obj.PRPDBatchMaterial.MaterialCode),
                new SqlParameter("@PRPDBatchQty" , obj.PRPDBatchQty),
                new SqlParameter("@PRPDBatchInstructedBy" , obj.PRPDBatchInstructedBy.EmployeeID),
                new SqlParameter("@PRPDBatchInstructedDate" , obj.PRPDBatchInstructedDate),
                new SqlParameter("@PRPDBatchStatus" ,(int)obj.Status),
                new SqlParameter("@MRIN" , obj.MRIN),
                new SqlParameter("@Comments" , obj.PRPDBatchComments),
                new SqlParameter("@BatchType" ,(int) obj.Type),
                new SqlParameter("@outParam",SqlDbType.VarChar,50){Direction=ParameterDirection.Output}};

               return Execute.RunSP_Output_String(Connection, "SPADD_PRPDBatch_Initial_PROrPP", paramList);

           }
           catch (Exception ex)
           {

               throw new Exception(ex.Message, ex);
           }

       }

       public int UpdateStatus(PRPDBatch obj)
       {
           try
           {


               SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@PRPDBatchStatus", obj.Status ),
                new SqlParameter("@PRPDBatchID", obj.PRPDBatchID )};

               return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_PRPDBatch_State", paramList);

           }
           catch (Exception ex)
           {

               throw new Exception(ex.Message, ex);
           }
       }

       public int Update_BatchCost(String PRPDBatchID,string GeneratedBy,int BatchType)
       {
           try
           {


               SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@GeneratedBy", GeneratedBy ),
                new SqlParameter("@PRPDBatchID", PRPDBatchID ),
                new SqlParameter("@BatchType", BatchType )
               };

               return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_PRPDBatch_Cost", paramList);

           }
           catch (Exception ex)
           {

               throw new Exception(ex.Message, ex);
           }
       }


       public int UpdateStartingDetails(PRPDBatch obj)
       {
           try
           {


               SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@PRPDBatchSuperviserID", obj.PRPDBatchSuperviser.EmployeeID),
                new SqlParameter("@PRPDBatchStartedBy", obj.PRPDBatchStartedBy.EmployeeID),
                new SqlParameter("@PRPDBatchStartDate", obj.PRPDBatchStartDate),
                new SqlParameter("@PRPDBatchStatus", obj.Status ),
                new SqlParameter("@PRPDBatchID", obj.PRPDBatchID)};

               return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_PRPDBatch_StartingDetails", paramList);

           }
           catch (Exception ex)
           {

               throw new Exception(ex.Message, ex);
           }
       }

       public int Update(PRPDBatch obj, string Original_PRPDBatchID)
       {
           try
           {


               SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@PRPDBatchID",Original_PRPDBatchID)};

               return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_PRPDBatch_Status", paramList);

           }
           catch (Exception ex)
           {

               throw new Exception(ex.Message, ex);
           }
       }

       public int Update_Apprve(PRPDBatch obj)
       {
           try
           {


               SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@PRPDBatchStatus",obj.Status),
                new SqlParameter("@PRPDBatchApprovedBy",obj.PRPDBatchApprovedBy.EmployeeID),
                new SqlParameter("@PRPDBatchID",obj.PRPDBatchID)};

               return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_PRPDBatch_Aprrove", paramList);

           }
           catch (Exception ex)
           {

               throw new Exception(ex.Message, ex);
           }
       }

       public int Update_Finish(PRPDBatch obj)
       {
           try
           {


               SqlParameter[] paramList = new SqlParameter[] {
                
                
                new SqlParameter("@PRPDBatchEndBy",obj.PRPDBatchEndBy.EmployeeID),
                new SqlParameter("@FinalQty",obj.PRPDBatchFinalQty),
                 new SqlParameter("@TotalImpurities",obj.PRPDBatchTotalImpurities),
                new SqlParameter("@SampleSize",obj.PRPDSampleSize),
                new SqlParameter("@PRPDBatchStatus",obj.Status),
                new SqlParameter("@PRPDBatchID",obj.PRPDBatchID)};

               return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_PRPDBatch_Finish", paramList);

           }
           catch (Exception ex)
           {

               throw new Exception(ex.Message, ex);
           }
       }

       public int Update_Transfer(PRPDBatch obj)
       {
           try
           {


               SqlParameter[] paramList = new SqlParameter[] {
                
                
                new SqlParameter("@HandOverBy",obj.PRPDBatchHandOverBy.EmployeeID),
                new SqlParameter("@MTNOUT",obj.PRPDBatchMTNOUT.MTNNo),
                new SqlParameter("@UnitCost",obj.UnitCost),
                new SqlParameter("@PRPDBatchStatus",(int)obj.Status),
                new SqlParameter("@PRPDBatchID",obj.PRPDBatchID)};

               return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_PRPDBatch_Transfer", paramList);

           }
           catch (Exception ex)
           {

               throw new Exception(ex.Message, ex);
           }
       }



       public int Delete(String PRPDBatchID)
        {

            try
            {
                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@Original_PRPDBatchID", PRPDBatchID)};

                return Execute.RunSP_RowsEffected(Connection, "SPDELETE_PRPDBatch", paramList);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }

        }

       public Decimal UnitPrice(String PRPDBatchID)
       {
           try
           {
               SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@PRPDBatchID", PRPDBatchID)};

               return Execute.RunSP_Int(Connection, "SPGET_PRPDBatch_UnitPrice", paramList);

           }
           catch (Exception ex)
           {

               throw new Exception(ex.Message, ex);
           }
       }

       public int UpdateDryerDate(string PRPDBatchID, decimal DryerRate)
       {

           try
           {


               SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@PRPDBatchID",PRPDBatchID),
                 new SqlParameter("@DryerRate",DryerRate)
                };

               return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_PRPDBatch_DryerRate", paramList);

           }
           catch (Exception ex)
           {

               throw new Exception(ex.Message, ex);
           }


       }

       //public Decimal BatchCost(String PRPDBatchID)
       //{
       //    try
       //    {
       //        daPRPDBatchTable.Connection = Connection;

       //        return Convert.ToDecimal(daPRPDBatchTable.SPGET_PRPDBatchCost(PRPDBatchID));
       //    }

       //    catch (Exception ex)
       //    {
       //        throw new Exception(ex.Message, ex);
       //    }

       //    finally
       //    {
       //        daPRPDBatchTable.Dispose();

       //    }
       //}

       public PRPDBatchCollec Get()
      {

           try
           {

               DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_PRPDBatch");

               PRPDBatchCollec objCollec = new PRPDBatchCollec();
               PRPDBatch obj = new PRPDBatch();

               if (dt.Rows.Count > 0)
               {
                   for (int i = 0; i < dt.Rows.Count; i++)
                   {


                       obj.PRPDBatchID = Convert.ToString(dt.Rows[i]["PRPDBatchID"]);
                       obj.PRPDBatchSuperviser = objEmployee_DL.Get(Convert.ToString(dt.Rows[i]["PRPDBatchSuperviserID"]));
                       obj.PRPDBatchMaterial = objMaterial_DL.Get(Convert.ToString(dt.Rows[i]["PRPDBatchMaterialCode"]));
                       obj.PRPDBatchQty = Convert.ToDecimal(dt.Rows[i]["PRPDBatchQty"]);
                       obj.PRPDBatchInstructedBy = objEmployee_DL.Get(Convert.ToString(dt.Rows[i]["PRPDBatchInstructedBy"]));
                       obj.PRPDBatchInstructedDate = Convert.ToDateTime(dt.Rows[i]["PRPDBatchInstructedDate"]);
                       obj.PRPDBatchStartedBy = objEmployee_DL.Get(Convert.ToString(dt.Rows[i]["PRPDBatchStartedBy"]));
                       obj.PRPDBatchStartDate = Convert.ToDateTime(dt.Rows[i]["PRPDBatchStartDate"]);
                       obj.PRPDBatchApprovedBy = objEmployee_DL.Get(Convert.ToString(dt.Rows[i]["PRPDBatchApprovedBy"]));
                       obj.PRPDBatchApprovedDate = Convert.ToDateTime(dt.Rows[i]["PRPDBatchApprovedDate"]);
                       obj.PRPDBatchEndBy = objEmployee_DL.Get(Convert.ToString(dt.Rows[i]["PRPDBatchEndBy"]));
                       obj.PRPDBatchEndDate = Convert.ToDateTime(dt.Rows[i]["PRPDBatchEndDate"]);
                       obj.Status = (PRPDBatch.PRPDBatchStatus)Enum.Parse(typeof(PRPDBatch.PRPDBatchStatus),Convert.ToString(dt.Rows[i]["PRPDBatchStatus"]));
                       obj.PRPDBatchMTNIN = Convert.ToInt64(dt.Rows[i]["MTNIN"]);
                       obj.PRPDBatchMTNOUT = objMTN_DL.Get(Convert.ToInt32(dt.Rows[i]["MTNOUT"]));
                       obj.UnitCost = Convert.ToDecimal(dt.Rows[i]["UnitCost"]);
                       obj.PRPDBatchInspectedBy = objEmployee_DL.Get(Convert.ToString(dt.Rows[i]["InspectedBy"]));
                       obj.PRPDBatchInspectedDate = Convert.ToDateTime(dt.Rows[i]["InspectedDate"]);
                       obj.PRPDBatchHandOverBy = objEmployee_DL.Get(Convert.ToString(dt.Rows[i]["HandOverBy"]));
                       obj.PRPDBatchHandOverDate = Convert.ToDateTime(dt.Rows[i]["HandOverDate"]);
                       obj.PRPDBatchFinalQty = Convert.ToDecimal(dt.Rows[i]["FinalQty"]);
                       obj.PRPDSampleSize = Convert.ToString(dt.Rows[i]["SampleSize"]);
                       obj.PRPDBatchComments = Convert.ToString(dt.Rows[i]["Comments"]);
                       obj.Type = (PRPDBatch.PRPDType) Convert.ToInt64(dt.Rows[i]["BatchType"]);
                       obj.PRPDBatchTotalImpurities = Convert.ToDecimal(dt.Rows[i]["TotalImpurities"]);
                       obj.PRPDCAPID = Convert.ToDecimal(dt.Rows[i]["PRPDCAPID"]);
                       obj.MRIN = Convert.ToInt64(dt.Rows[i]["MRIN"]);
                       if (dt.Rows[i]["OutSourceQty"] != DBNull.Value)
                       {
                           obj.OutSourceQty = Convert.ToDecimal(dt.Rows[i]["OutSourceQty"]);
                       }

                       objCollec.Add(obj);
                   }
               }

               return objCollec;


           }
           catch (Exception ex)
           {

               throw new Exception(ex.Message, ex);
           }
       }

       public Decimal GetReworkQty(long MTNNO,String MaterialCode)
        {
            try
            {
                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@MTNNO", MTNNO),
                new SqlParameter("@MaterialCode", MaterialCode)};

                return Execute.RunSP_Int(Connection, "SPGET_PRPDBatch_RewokedQty", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

       public String GetMaxID()
        {
            return "";
        }

       public System.Data.DataTable GetDataViewByMTNNO(long MTNNO)
      {
          try
          {

              SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@MTNIN", MTNNO)};

              return Execute.RunSP_DataTable(Connection, "SPGET_PRPDBatchByMTNNO", paramList);

          }
          catch (Exception ex)
          {

              throw new Exception(ex.Message, ex);
          }

      }

       public System.Data.DataTable GetDataView()
       {
           try
           {

               return Execute.RunSP_DataTable(Connection, "SPGET_PRPDBatch");

           }
           catch (Exception ex)
           {

               throw new Exception(ex.Message, ex);
           }

       }

       public System.Data.DataTable GetDataView(PRPDBatch.PRPDBatchStatus Status)
       {
           try
           {

               SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@PRPDBatchStatus", Status)};

               return Execute.RunSP_DataTable(Connection, "SPGET_PRPDBatch_View_Status", paramList);

           }
           catch (Exception ex)
           {

               throw new Exception(ex.Message, ex);
           }

       }

       public System.Data.DataTable GetDataView(String InstructedBy, PRPDBatch.PRPDBatchStatus Status, DateTime From, DateTime To)
       {
           try
           {

               SqlParameter[] paramList = new SqlParameter[] {
                
               new SqlParameter("@InstructedBy", InstructedBy),
               new SqlParameter("@PRPDBatchStatus", Status),
               new SqlParameter("@FromDate", From),
               new SqlParameter("@ToDate", To)};

               return Execute.RunSP_DataTable(Connection, "SPGET_PRPDBatch_View_By_InstructedBy", paramList);

           }
           catch (Exception ex)
           {

               throw new Exception(ex.Message, ex);
           }

       }

       public System.Data.DataTable GetDataByBatchID(String PRPDBatchID)
       {
           try
           {

               SqlParameter[] paramList = new SqlParameter[] {
                
               new SqlParameter("@PRPDBatchID" , PRPDBatchID)};

               return Execute.RunSP_DataTable(Connection, "SPGET_PRPDBatchByID", paramList);

           }
           catch (Exception ex)
           {

               throw new Exception(ex.Message, ex);
           }

       }

       public System.Data.DataTable GetDataByState_Type(PRPDBatch.PRPDBatchStatus PRPDBatchStatus,PRPDBatch.PRPDType BatchType)
       {
           try
           {

               SqlParameter[] paramList = new SqlParameter[] {
                
               new SqlParameter("@PRPDBatchStatus" , (int)PRPDBatchStatus),
                new SqlParameter("@BatchType" , (int)BatchType)
               };

               return Execute.RunSP_DataTable(Connection, "SPGET_PRPDBatch_View_Status_Type", paramList);

           }
           catch (Exception ex)
           {

               throw new Exception(ex.Message, ex);
           }

       }

       public System.Data.DataTable GetDataByState(PRPDBatch.PRPDBatchStatus PRPDBatchStatus)
       {
           try
           {

               SqlParameter[] paramList = new SqlParameter[] {
                
               new SqlParameter("@PRPDBatchStatus" , (int)PRPDBatchStatus)
               };

               return Execute.RunSP_DataTable(Connection, "SPGET_PRPDBatch_View_Status", paramList);

           }
           catch (Exception ex)
           {

               throw new Exception(ex.Message, ex);
           }

       }

       public System.Data.DataTable GetDataByStateAndType(PRPDBatch.PRPDBatchStatus PRPDBatchStatus1,PRPDBatch.PRPDBatchStatus PRPDBatchStatus2,
       PRPDBatch.PRPDType BatchType1, PRPDBatch.PRPDType BatchType2, PRPDBatch.PRPDType BatchType3)
       {
           try
           {

               SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@PRPDBatchType1" , (int)BatchType1),
                new SqlParameter("@PRPDBatchType2" , (int)BatchType2),
                new SqlParameter("@PRPDBatchType3" , (int)BatchType3),
                new SqlParameter("@BatchState1" , (int)PRPDBatchStatus1),
                new SqlParameter("@BatchState2" , (int)PRPDBatchStatus2)};

               return Execute.RunSP_DataTable(Connection, "SPGET_PRPDBatchByTypeAndState", paramList);

           }
           catch (Exception ex)
           {

               throw new Exception(ex.Message, ex);
           }

       }

       public int UpdateMR(String PRPDID, long MRIN)
       {
           try
           {


               SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@PRPDBatchID", PRPDID ),
                new SqlParameter("@MRIN", MRIN )};

               return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_PRPDBatch_IN", paramList);

           }
           catch (Exception ex)
           {

               throw new Exception(ex.Message, ex);
           }
       }

       public PRPDBatch Get(String PRPDBatchID)
       {

           try
           {
               SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@PRPDBatchID",PRPDBatchID)};


               DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_PRPDBatchByID", paramList);

               PRPDBatch obj = new PRPDBatch();

               if (dt.Rows.Count > 0)
               {

                   obj.PRPDBatchID = Convert.ToString(dt.Rows[0]["PRPDBatchID"]);
                   obj.PRPDBatchSuperviser = objEmployee_DL.Get(Convert.ToString(dt.Rows[0]["PRPDBatchSuperviserID"]));
                   obj.PRPDBatchMaterial = objMaterial_DL.Get(Convert.ToString(dt.Rows[0]["PRPDBatchMaterialCode"]));
                   obj.PRPDBatchQty= Convert.ToDecimal(dt.Rows[0]["PRPDBatchQty"]);
                   obj.PRPDBatchInstructedBy = objEmployee_DL.Get(Convert.ToString(dt.Rows[0]["PRPDBatchInstructedBy"]));
                   obj.PRPDBatchInstructedDate = Convert.ToDateTime(dt.Rows[0]["PRPDBatchInstructedDate"]);
                   obj.PRPDBatchStartedBy = objEmployee_DL.Get(Convert.ToString(dt.Rows[0]["PRPDBatchStartedBy"]));
                   obj.PRPDBatchStartDate = Convert.ToDateTime(dt.Rows[0]["PRPDBatchStartDate"]);
                   obj.PRPDBatchApprovedBy = objEmployee_DL.Get(Convert.ToString(dt.Rows[0]["PRPDBatchApprovedBy"]));
                   obj.PRPDBatchApprovedDate = Convert.ToDateTime(dt.Rows[0]["PRPDBatchApprovedDate"]);
                   obj.PRPDBatchEndBy = objEmployee_DL.Get(Convert.ToString(dt.Rows[0]["PRPDBatchEndBy"]));
                   obj.PRPDBatchEndDate = Convert.ToDateTime(dt.Rows[0]["PRPDBatchEndDate"]);
                   obj.Status =  (PRPDBatch.PRPDBatchStatus)Enum.Parse(typeof(PRPDBatch.PRPDBatchStatus), Convert.ToString(dt.Rows[0]["PRPDBatchStatus"]));
                   obj.PRPDBatchMTNIN = Convert.ToInt64(dt.Rows[0]["MTNIN"]);
                   obj.PRPDBatchMTNOUT =objMTN_DL.Get(Convert.ToInt64(dt.Rows[0]["MTNOUT"]));
                   obj.UnitCost = Convert.ToDecimal(dt.Rows[0]["UnitCost"]);
                   obj.PRPDBatchInspectedBy = objEmployee_DL.Get(Convert.ToString(dt.Rows[0]["InspectedBy"]));
                   obj.PRPDBatchInspectedDate = Convert.ToDateTime(dt.Rows[0]["InspectedDate"]);
                   obj.PRPDBatchHandOverBy = objEmployee_DL.Get(Convert.ToString(dt.Rows[0]["HandOverBy"]));
                   obj.PRPDBatchHandOverDate = Convert.ToDateTime(dt.Rows[0]["HandOverDate"]);
                   obj.PRPDBatchFinalQty = Convert.ToDecimal(dt.Rows[0]["FinalQty"]);
                   obj.PRPDSampleSize = Convert.ToString(dt.Rows[0]["SampleSize"]);
                   obj.PRPDBatchComments = Convert.ToString(dt.Rows[0]["Comments"]);
                   obj.Type = (PRPDBatch.PRPDType) Convert.ToInt32(dt.Rows[0]["BatchType"]);
                   obj.PRPDBatchTotalImpurities = Convert.ToDecimal(dt.Rows[0]["TotalImpurities"]);
                   obj.PRPDCAPID = Convert.ToDecimal(dt.Rows[0]["PRPDCAPID"]);
                   obj.MRIN = Convert.ToInt64(dt.Rows[0]["MRIN"]);
                   if (dt.Rows[0]["OutSourceQty"] != DBNull.Value)
                   {
                       obj.OutSourceQty = Convert.ToDecimal(dt.Rows[0]["OutSourceQty"]);
                   }
               }

               return obj;


           }
           catch (Exception ex)
           {

               throw new Exception(ex.Message, ex);
           }
       }

       public PRPDBatchCollec Get(int BatchState, int BatchType)
       {

           try
           {
               SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@PRPDBatchStatus",BatchState),
                new SqlParameter("@BatchType",BatchType)};


               DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_PRPDBatchByState", paramList);

               PRPDBatchCollec objCollec = new PRPDBatchCollec();
               PRPDBatch obj = new PRPDBatch();

               if (dt.Rows.Count > 0)
               {
                   for (int i = 0; i < dt.Rows.Count; i++)
                   {


                       obj.PRPDBatchID = Convert.ToString(dt.Rows[i]["PRPDBatchID"]);
                       obj.PRPDBatchSuperviser = objEmployee_DL.Get(Convert.ToString(dt.Rows[i]["PRPDBatchSuperviserID"]));
                       obj.PRPDBatchMaterial = objMaterial_DL.Get(Convert.ToString(dt.Rows[i]["PRPDBatchMaterialCode"]));
                       obj.PRPDBatchQty = Convert.ToDecimal(dt.Rows[i]["PRPDBatchQty"]);
                       obj.PRPDBatchInstructedBy = objEmployee_DL.Get(Convert.ToString(dt.Rows[i]["PRPDBatchInstructedBy"]));
                       obj.PRPDBatchInstructedDate = Convert.ToDateTime(dt.Rows[i]["PRPDBatchInstructedDate"]);
                       obj.PRPDBatchStartedBy = objEmployee_DL.Get(Convert.ToString(dt.Rows[i]["PRPDBatchStartedBy"]));
                       obj.PRPDBatchStartDate = Convert.ToDateTime(dt.Rows[i]["PRPDBatchStartDate"]);
                       obj.PRPDBatchApprovedBy = objEmployee_DL.Get(Convert.ToString(dt.Rows[i]["PRPDBatchApprovedBy"]));
                       obj.PRPDBatchApprovedDate = Convert.ToDateTime(dt.Rows[i]["PRPDBatchApprovedDate"]);
                       obj.PRPDBatchEndBy = objEmployee_DL.Get(Convert.ToString(dt.Rows[i]["PRPDBatchEndBy"]));
                       obj.PRPDBatchEndDate = Convert.ToDateTime(dt.Rows[i]["PRPDBatchEndDate"]);
                       obj.Status = (PRPDBatch.PRPDBatchStatus)Enum.Parse(typeof(PRPDBatch.PRPDBatchStatus),Convert.ToString(dt.Rows[i]["PRPDBatchStatus"]));
                       obj.PRPDBatchMTNIN = Convert.ToInt64(dt.Rows[i]["MTNIN"]);
                       obj.PRPDBatchMTNOUT = objMTN_DL.Get(Convert.ToInt32(dt.Rows[i]["MTNOUT"]));
                       obj.UnitCost = Convert.ToDecimal(dt.Rows[i]["UnitCost"]);
                       obj.PRPDBatchInspectedBy = objEmployee_DL.Get(Convert.ToString(dt.Rows[i]["InspectedBy"]));
                       obj.PRPDBatchInspectedDate = Convert.ToDateTime(dt.Rows[i]["InspectedDate"]);
                       obj.PRPDBatchHandOverBy = objEmployee_DL.Get(Convert.ToString(dt.Rows[i]["HandOverBy"]));
                       obj.PRPDBatchHandOverDate = Convert.ToDateTime(dt.Rows[i]["HandOverDate"]);
                       obj.PRPDBatchFinalQty = Convert.ToDecimal(dt.Rows[i]["FinalQty"]);
                       obj.PRPDSampleSize = Convert.ToString(dt.Rows[i]["SampleSize"]);
                       obj.PRPDBatchComments = Convert.ToString(dt.Rows[i]["Comments"]);
                       obj.Type = (PRPDBatch.PRPDType) Convert.ToInt64(dt.Rows[i]["BatchType"]);
                       obj.PRPDBatchTotalImpurities = Convert.ToDecimal(dt.Rows[i]["TotalImpurities"]);
                       obj.PRPDCAPID = Convert.ToDecimal(dt.Rows[i]["PRPDCAPID"]);
                       obj.MRIN = Convert.ToInt64(dt.Rows[i]["MRIN"]);
                       obj.PRPDBatchMaterialName = Convert.ToString(dt.Rows[i]["MaterialDescription"]);
                       if (dt.Rows[i]["OutSourceQty"] != DBNull.Value)
                       {
                           obj.OutSourceQty = Convert.ToDecimal(dt.Rows[i]["OutSourceQty"]);
                       }

                       objCollec.Add(obj);
                   }
               }

               return objCollec;


           }
           catch (Exception ex)
           {

               throw new Exception(ex.Message, ex);
           }
       }

       public DataTable GetPRPDBatchCost(String PRPDBatchID)
       {
           try
           {


               SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@PRPDBatchID", PRPDBatchID)};

               return Execute.RunSP_DataTable(Connection, "SPGET_PRPDBatch_Cost", paramList);

           }
           catch (Exception ex)
           {

               throw new Exception(ex.Message, ex);
           }
       }






       public DataTable GetPRPDBatchLabourCost(String PRPDBatchID)
       {
           try
           {


               SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@PRPDBatchID", PRPDBatchID)};

               return Execute.RunSP_DataTable(Connection, "SPGET_PRPDBatch_Labour_Summary", paramList);

           }
           catch (Exception ex)
           {

               throw new Exception(ex.Message, ex);
           }
       }


       public DataTable GetPRPDBatchMachineCost(String PRPDBatchID)
       {
           try
           {


               SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@PRPDBatchID", PRPDBatchID)};

               return Execute.RunSP_DataTable(Connection, "SPGET_PRPDBatch_Machine_Summary", paramList);

           }
           catch (Exception ex)
           {

               throw new Exception(ex.Message, ex);
           }
       }

       public DataTable GetPRPDBatchOHCost(String PRPDBatchID)
       {
           try
           {


               SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@PRPDBatchID", PRPDBatchID)};

               return Execute.RunSP_DataTable(Connection, "SPGET_PRPDBatch_Overhead_Summary", paramList);

           }
           catch (Exception ex)
           {

               throw new Exception(ex.Message, ex);
           }
       }



       public DataTable GetPrevious(String PRPDBatchID)
       {
           try
           {


               SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@PRPDBatchID", PRPDBatchID)};

               return Execute.RunSP_DataTable(Connection, "SPGET_PRPDBatch_PreviousBatch", paramList);

           }
           catch (Exception ex)
           {

               throw new Exception(ex.Message, ex);
           }
       }



       public DataTable GetPRPDBatchMaterialCost(String PRPDBatchID)
       {
           try
           {


               SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@PRPDBatchID", PRPDBatchID)};

               return Execute.RunSP_DataTable(Connection, "SPGET_PRPDBatch_Material_Summary", paramList);

           }
           catch (Exception ex)
           {

               throw new Exception(ex.Message, ex);
           }
       }

       public int Finish(string PRPDBatchID, PRPDBatch.PRPDBatchStatus theStatus)
       {
           try
           {


               SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@PRPDBatchID", PRPDBatchID),
                new SqlParameter("@PRPDBatchStatus" , (int)theStatus)};

               return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_PRPDBatch_Finish", paramList);

           }
           catch (Exception ex)
           {

               throw new Exception(ex.Message, ex);
           }
       }

       ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

       public System.Data.DataTable GetDataViewByState(PRPDBatch.PRPDBatchStatus state, bool QueryType)
       {
           try
           {


               SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@PRPDBatchStatus",state),
                 new SqlParameter("@QueryType",QueryType)
                };

               return Execute.RunSP_DataTable(Connection, "SPGET_PRPDBatch_View_By_Status", paramList);

           }
           catch (Exception ex)
           {

               throw new Exception(ex.Message, ex);
           }
       }

    }
}
