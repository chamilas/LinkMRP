using SESD.MRP.REF;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DL
{
    public class Batch_DL
    {
        SqlConnection Connection = new SqlConnection();


        public Batch_DL(SqlConnection Conn)
        {
            Connection = Conn;
        }
   
    
        //---------------------ADD REGION------------------------------

        public String Add(Batch objBatch,String Prefix, bool Isprefix)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@BatchSTDBatchID", objBatch.StandardBatch.STDBatchID),
                new SqlParameter("@BatchGeneratedBy",objBatch.BatchGenerateBy.EmployeeID),
                new SqlParameter("@BatchDivideCount", objBatch.BatchDivideCount),
                new SqlParameter("@BatchStatus", objBatch.BatchStatus),
                new SqlParameter("@BatchType", objBatch.BatchType),
                new SqlParameter("@Prefix", Prefix),
                new SqlParameter("@IsPrefix", Isprefix),
                new SqlParameter("@NewBatchSize", objBatch.BatchSize),
                new SqlParameter("@outParam",SqlDbType.VarChar,50){Direction=ParameterDirection.Output}};

                return Execute.RunSP_Output_String(Connection, "SPADD_Batch_STD", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }

        }


        public int Add_Re(string BatchID, string ParentBatches,decimal BatchSize,string CreatedBy, int BatchStatus, string BatchType)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                new SqlParameter("@BatchID", BatchID),
                new SqlParameter("@ParentBatches", ParentBatches),
                new SqlParameter("@BatchGeneratedBy",CreatedBy),
                 new SqlParameter("@BatchStatus", BatchStatus),
                new SqlParameter("@BatchSize", BatchSize),
                new SqlParameter("@BatchType", BatchType)};

                return Execute.RunSP_Int(Connection, "SPADD_Batch_Re", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }

        }


        //---------------------END-------------------------------------


        //---------------------UPDATE REGION------------------------------

        public int Update_Approve(Batch objBatch)
        {

            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@BatchID", objBatch.BatchID),
                new SqlParameter("@BatchApprovedBy",objBatch.BatchApprovedBy.EmployeeID),
                new SqlParameter("@BatchStatus", objBatch.BatchStatus)};

                return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_Batch_Approve", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }

        }

        public int Update_Initiate(Batch objBatch)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@BatchID", objBatch.BatchID),
                new SqlParameter("@BatchInitiatedBy",objBatch.InitiatedBy),
                new SqlParameter("@BatchStatus", objBatch.BatchStatus)};

                return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_Batch_Initiate", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public int Update_Initiate_Direct(Batch objBatch)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@BatchID", objBatch.BatchID),
                new SqlParameter("@BatchInitiatedBy",objBatch.InitiatedBy),
                new SqlParameter("@BatchStatus", objBatch.BatchStatus)};

                return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_Batch_Initiate_Direct", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }


        public int Update_Packed(String BatchID, int BatchStatus_Packed, int BatchActivity_Transferred, int MTNStatus_Reject)
        {
            try
            {
                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@BatchID", BatchID),
                new SqlParameter("@BatchStatus_Packed", BatchStatus_Packed),
                new SqlParameter("@BatchActStatus_Transferred", BatchActivity_Transferred),
                new SqlParameter("@MTNStatus_Reject", MTNStatus_Reject)
                };

                return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_Batch_To_Packed", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public int Update_Packed_Secondary(String BatchID, int BatchStatus, int BatchActivity_Transferred, int BatchActStatus_Secondary)
        {
            try
            {
                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@BatchID", BatchID),
                new SqlParameter("@BatchStatus", BatchStatus),
                new SqlParameter("@BatchActStatus_Transferred", BatchActivity_Transferred),
                new SqlParameter("@BatchActStatus_Secondary", BatchActivity_Transferred)
                };

                return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_Batch_To_Packed_Secondary", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }


        public int Update_Finish(Batch objBatch)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@BatchID", objBatch.BatchID),
                new SqlParameter("@FinalizedBy",objBatch.FinalizedBy.EmployeeID),
                new SqlParameter("@BatchStatus",Convert.ToInt32(objBatch.BatchStatus))};

                return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_Batch_Finish", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }


        public int Update_BatchCost(Batch objBatch)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@BatchID", objBatch.BatchID)};

                return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_Batch_Cost", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }


        public int Update_BatchPackingCost(long BatchPackingID)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@BatchPackingID", BatchPackingID)};

                return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_BatchPacking_Cost", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public int Update_BatchSeconderyPackingCost(long BatchPackingID)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@BatchPackingID", BatchPackingID)};

                return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_BatchSecondaryPacking_Cost", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }



        public int Update_Finish_Approve(Batch objBatch, int ReportStatus_Passed)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@BatchID", objBatch.BatchID),
                new SqlParameter("@FinalizedBy",objBatch.FinalizedBy.EmployeeID),
                new SqlParameter("@BatchFinalQty",objBatch.BatchFinalQty),
                new SqlParameter("@ReportStatus",ReportStatus_Passed),
                new SqlParameter("@BatchStatus",Convert.ToInt32(objBatch.BatchStatus))};

                return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_Batch_Finish_Approve", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }






        public int Update_FinalQty_Admin(Batch objBatch)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@BatchID", objBatch.BatchID),
                new SqlParameter("@FinalizedBy",objBatch.FinalizedBy.EmployeeID),
                new SqlParameter("@BatchFinalQty",objBatch.BatchFinalQty)};

                return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_Batch_FinalQty", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }



        public int Update_QCStatus(string BatchID, string ChangedBy, Batch.Status TheStatus)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@BatchID", BatchID),
                new SqlParameter("@ChangedBy",ChangedBy),
                new SqlParameter("@BatchStatus",Convert.ToInt32(TheStatus))};

                return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_Batch_QCStatus", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public int Update_QCStatus_ForReworkBatches(string BatchID, string ChangedBy, Batch.Status TheStatus)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@BatchID", BatchID),
                new SqlParameter("@ChangedBy",ChangedBy),
                new SqlParameter("@BatchStatus",Convert.ToInt32(TheStatus))};

                return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_Batch_QCStatus_ForReworkBatches", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }


        //---------------------END-------------------------------------


        //---------------------DELETE REGION------------------------------

        public int Delete(String BatchID)
        {

            try
            {
                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@BatchID", BatchID)};

                return Execute.RunSP_RowsEffected(Connection, "SPDELETE_Batch", paramList);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }

        }

        //---------------------END-------------------------------------


        public DataTable  Get_BatchMaterial_RequestedState(String BatchID)
        {
            
            try
            {
                  SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@BatchID", BatchID)};

                  return Execute.RunSP_DataTable(Connection, "SPGET_BatchMaterial_RequestedState", paramList);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
           
        }


        public DataTable  Get_BatchMaterial_Packing_RequestedState(String BatchID)
        {
            
            try
            {
                  SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@BatchID", BatchID)};

                  return Execute.RunSP_DataTable(Connection, "SPGET_BatchMaterial_Packing_RequestedState", paramList);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
           
        }


        public int Get_NotWeighingChecked_Count(string BatchID)
        {

            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
               
                new SqlParameter("@BatchID", BatchID),
               new SqlParameter("@outParam",SqlDbType.Int){Direction=ParameterDirection.Output}
                                    };

                return Execute.RunSP_Output(Connection, "SPGET_BatchFormulaMaterial_IsWeighingChecked", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public DataTable GetTransferred_AsPrimary_All(String BatchID)
        {

            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
               
                new SqlParameter("@BatchID", BatchID)
                
                                    };

                return Execute.RunSP_DataTable(Connection, "SPGET_Batch_Transferred_AsPrimary_All", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public DataTable  GetTransferred_AsPrimary(String BatchID, string FinishProductID,int BatchActID)
        {

            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
               
                new SqlParameter("@BatchID", BatchID),
                new SqlParameter("@BatchActID", BatchActID),
                new SqlParameter("@MTNFinishProductID", FinishProductID)
                
                                    };

                return Execute.RunSP_DataTable(Connection, "SPGET_Batch_Transferred_AsPrimary", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }


        public int GetMaterialRequisitionStatus_ByPart(String BatchID,string Part)
        {
            

            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@BatchID", BatchID),
                new SqlParameter("@PartID",Part),
                new SqlParameter("@outParam",SqlDbType.Int){Direction=ParameterDirection.Output}};

                return Execute.RunSP_Output(Connection, "SPGET_BatchByMaterialRequisitionState", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }

        }


        public DataTable GetBatchMRMaterial(String BatchID,string MatCatID)
        {


            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@BatchID", BatchID),
                 new SqlParameter("@MatCat", MatCatID)};

                return Execute.RunSP_DataTable(Connection, "SPGET_BatchMRMaterial_By_Batch_MatCat", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }

        }


        public DataTable GetBatchMRSemi(String BatchID)
        {


            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@BatchID", BatchID)};

                return Execute.RunSP_DataTable(Connection, "SPGET_BatchMRSemi", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }

        }


        public DataTable GetBatchMRPacking(String BatchID)
        {


            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@BatchID", BatchID)};

                return Execute.RunSP_DataTable(Connection, "SPGET_BatchMRPacking_By_Batch", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }

        }


        public int GetSemiFinishedRequisitionStatus_ByPart(String BatchID,string Part)
        {
            

            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@BatchID", BatchID),
                new SqlParameter("@PartID",Part)};

                return Execute.RunSP_Int(Connection, "SPGET_BatchBySemiFinishedRequisitionState", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }

        }

       
        public Batch Get(String BatchID)
        {
            Batch objBatch = new Batch();
            Employee_DL objEmplyeeDL = new Employee_DL(Connection);
            Batch_DL objBatchDL = new Batch_DL(Connection);
            STDBatch_DL objSTDBatchDL = new STDBatch_DL(Connection);


            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@BatchID",BatchID)
                };

                DataTable dt= Execute.RunSP_DataTable(Connection, "SPGET_Batch_By_ID", paramList);


                if (dt.Rows.Count > 0)
                {
                    if (dt.Rows[0]["BatchApprovedBy"].ToString() != "N/A")
                    {
                        objBatch.BatchApprovedBy = objEmplyeeDL.Get(Convert.ToString(dt.Rows[0]["BatchApprovedBy"]));
                    }
                    if (dt.Rows[0]["BatchApprovedDate"] != null)
                    {
                        objBatch.BatchApprovedDate = Convert.ToDateTime(dt.Rows[0]["BatchApprovedDate"]);
                    }

                    objBatch.BatchDivideCount = Convert.ToInt32(dt.Rows[0]["BatchDivideCount"]);

                    if (dt.Rows[0]["BatchEndDate"] != null)
                    {
                        objBatch.BatchEndDate = Convert.ToDateTime(dt.Rows[0]["BatchEndDate"]);
                    }

                    if (dt.Rows[0]["BatchGeneratedBy"].ToString() != "N/A")
                    {
                        objBatch.BatchGenerateBy = objEmplyeeDL.Get(Convert.ToString(dt.Rows[0]["BatchGeneratedBy"]));
                    }

                    objBatch.BatchGenerateDate = Convert.ToDateTime(dt.Rows[0]["BatchGeneratedDate"]);
                    objBatch.BatchID = Convert.ToString(dt.Rows[0]["BatchID"]);

                    if (dt.Rows[0]["BatchStartDate"] != null)
                    {
                        objBatch.BatchStartDate = Convert.ToDateTime(dt.Rows[0]["BatchStartDate"]);
                    }

                    objBatch.BatchStatus =(Batch.Status) dt.Rows[0]["BatchStatus"];

                    if (dt.Rows[0]["BatchSuperviser"].ToString() != "N/A")
                    {
                        objBatch.BatchSuperviser = objEmplyeeDL.Get(Convert.ToString(dt.Rows[0]["BatchSuperviser"]));
                    }

                    objBatch.BatchType = Convert.ToString(dt.Rows[0]["BatchType"]);

                    if (dt.Rows[0]["BatchFinalQty"] != DBNull.Value)
                    {
                        objBatch.BatchFinalQty = Convert.ToDecimal(dt.Rows[0]["BatchFinalQty"]);

                    }

                    objBatch.BatchSize = Convert.ToDecimal(dt.Rows[0]["BatchSize"]);

                    if (dt.Rows[0]["FinalizedBy"].ToString() != "")
                    {
                        objBatch.FinalizedBy = objEmplyeeDL.Get(Convert.ToString(dt.Rows[0]["FinalizedBy"]));
                    }

                    if (dt.Rows[0]["FinalizedDate"] != DBNull.Value)
                    {
                        objBatch.FinalizedDate = Convert.ToDateTime(dt.Rows[0]["FinalizedDate"]);
                    }

                    objBatch.StandardBatch = objSTDBatchDL.Get(Convert.ToString(dt.Rows[0]["BatchSTDBatchID"]));
                }

                return objBatch;



            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }


            

           
               
              
        }


        public DataTable Get_BatchList_ToSendMR(int Status1, int Status2, int Status3, int Status4, long UserID)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                new SqlParameter("@Status1",Status1),
                 new SqlParameter("@Status2",Status2),
                  new SqlParameter("@Status3",Status3),
                   new SqlParameter("@Status4",Status4),
                 new SqlParameter("@UserID",UserID)
                };

                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_Batch_By_MRRaise", paramList);


                return dt;



            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }


            

        }


        public DataTable Get_BatchList_ToSendMR_Rework(int Status1, int Status2, int Status3, int Status4,int Status5, long UserID)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                new SqlParameter("@Status1",Status1),
                 new SqlParameter("@Status2",Status2),
                  new SqlParameter("@Status3",Status3),
                   new SqlParameter("@Status4",Status4),
                    new SqlParameter("@Status5",Status5),
                 new SqlParameter("@UserID",UserID)
                };

                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_Batch_By_MRRaise_Rework", paramList);


                return dt;



            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }




        }




        public DataTable Get_BatchList_ToReceiveMR(int Status, long UserID)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@Status",Status),
                 new SqlParameter("@UserID",UserID)
                };

                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_Batch_By_MRReceive", paramList);


                return dt;



            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }




        }


        public DataTable Get_DataView_Packing_Secondary_Instructions(BatchActivity.Status Status_Finished,BatchActivity.Status Status_Secondary,long UserID)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@BatchActStatus_Finished",Status_Finished),
                 new SqlParameter("@BatchActStatus_Secondary",Status_Secondary),
                 new SqlParameter("@UserID",UserID)
                };

                return Execute.RunSP_DataTable(Connection, "SPGET_Batch_By_Status_view_Packing_Secondary_Instructions", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public DataTable Get_Packing_PrimaryBatchRemainningQty(int PrimaryBatchID, BatchActivity.Status Status_Finished, BatchActivity.Status Status_Secondary)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@BatchActStatus_Finished",Status_Finished),
                 new SqlParameter("@BatchActStatus_Secondary",Status_Secondary),
                 new SqlParameter("@PrimaryBatchID",PrimaryBatchID)
                };

                return Execute.RunSP_DataTable(Connection, "SPGET_Packing_PrimaryBatchRemainningQty", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public DataTable Get_DataView_Packing_Secondary(BatchActivity.Status Status, long UserID)
              {
                  try
                  {


                      SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@BatchActStatus",Status),
                 new SqlParameter("@UserID",UserID)
                };

                      return Execute.RunSP_DataTable(Connection, "SPGET_Batch_By_Status_view_Packing_Secondary", paramList);

                  }
                  catch (Exception ex)
                  {

                      throw new Exception(ex.Message, ex);
                  }
              }


        public DataTable Get_DataView_Packing(Batch.Status Status1, Batch.Status Status2, long UserID, string BasicProductType)
              {
                  try
                  {


                      SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@Status1",Status1),
                new SqlParameter("@Status2",Status2),
                 new SqlParameter("@UserID",UserID),
                  new SqlParameter("@BasicProductType",BasicProductType)
                };

                      return Execute.RunSP_DataTable(Connection, "SPGET_Batch_By_Status_view_Packing", paramList);

                  }
                  catch (Exception ex)
                  {

                      throw new Exception(ex.Message, ex);
                  }
              }

        public DataTable Get_DataView_Packing_All(Batch.Status Status1, Batch.Status Status2,Batch.Status Status3, Batch.Status Status4, Batch.Status Status5, long UserID, string BasicProductType)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@Status1",Status1),
                new SqlParameter("@Status2",Status2),
                new SqlParameter("@Status3",Status3),
                new SqlParameter("@Status4",Status4),
                 new SqlParameter("@Status5",Status5),
                 new SqlParameter("@UserID",UserID),
                  new SqlParameter("@BasicProductType",BasicProductType)
                };

                return Execute.RunSP_DataTable(Connection, "SPGET_Batch_By_Status_view_Packing_All", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public DataTable Get_DataView_PrimaryPacking(Batch.Status Status1, Batch.Status Status2, long UserID, string BasicProductType,string ActType, int BatchActivity_Initial,int BatchActivity_Start)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@Status1",Status1),
                new SqlParameter("@Status2",Status2),
                 new SqlParameter("@UserID",UserID),
                  new SqlParameter("@BasicProductType",BasicProductType),
                   new SqlParameter("@ActType",ActType),
                   new SqlParameter("@BatchActivity_Initial",BatchActivity_Initial),
                    new SqlParameter("@BatchActivity_Start",BatchActivity_Start)
                };

                return Execute.RunSP_DataTable(Connection, "SPGET_Batch_By_Status_view_PrimaryPacking", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public DataTable Get_DataView_PrimaryPacking_Edit(Batch.Status Status1, Batch.Status Status2, long UserID, string BasicProductType, string ActType, int BatchActivity_Initial, int BatchActivity_Start, int BatchActivity_Finish)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@Status1",Status1),
                new SqlParameter("@Status2",Status2),
                 new SqlParameter("@UserID",UserID),
                  new SqlParameter("@BasicProductType",BasicProductType),
                   new SqlParameter("@ActType",ActType),
                   new SqlParameter("@BatchActivity_Initial",BatchActivity_Initial),
                    new SqlParameter("@BatchActivity_Start",BatchActivity_Start),
                    new SqlParameter("@BatchActivity_Finish",BatchActivity_Finish)
                };

                return Execute.RunSP_DataTable(Connection, "SPGET_Batch_By_Status_view_PrimaryPacking_Edit", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }


        public DataTable Get_DataView_ReworkBatchList(int BatchStatus, string BatchType1, string BatchType2)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@BatchStatus",BatchStatus),
                new SqlParameter("@BatchType1",BatchType1),
                 new SqlParameter("@BatchType2",BatchType2)
                };

                return Execute.RunSP_DataTable(Connection, "SPGET_Batch_By_Status_view_ReworkBatchList", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }



        public DataTable Get_DataView_Admin(Batch.Status Status1, Batch.Status Status2, Batch.Status Status3, Batch.Status Status4, Batch.Status Status5)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@Status1",(int)Status1),
                new SqlParameter("@Status2",(int)Status2),
                new SqlParameter("@Status3",(int)Status3),
                   new SqlParameter("@Status4",(int)Status4),
                        new SqlParameter("@Status5",(int)Status5)
                };

                return Execute.RunSP_DataTable(Connection, "SPGET_Batch_By_Status_view_Admin", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }


        public DataTable Get_DataView(Batch.Status Status,long UserID)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@Status",Status),
                 new SqlParameter("@UserID",UserID)
                };

                return Execute.RunSP_DataTable(Connection, "SPGET_Batch_By_Status_view", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public DataTable Get_DataView_TransferPrimary(int BatchStatus_Finished, int BatchStatus_Secondary, int BatchStatus_SecondaryStarted, int QCReportStatus_pass, int MTNStatus_Reject)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@BatchActStatus_Finished",BatchStatus_Finished),
                new SqlParameter("@BatchActStatus_Secondary",BatchStatus_Secondary),
                new SqlParameter("@BatchActStatus_SecondaryStart",BatchStatus_SecondaryStarted),
                 new SqlParameter("@QCReportStatus_Passed",QCReportStatus_pass),
                 new SqlParameter("@MTNStatus_Reject",MTNStatus_Reject)
                };

                return Execute.RunSP_DataTable(Connection, "SPGET_Batch_By_Status_view_TransferPrimary", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public DataTable Get_DataView_Rework(Batch.Status Status, string BatchType1, string BatchType2)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@BatchStatus",Status),
                new SqlParameter("@BatchType1",BatchType1),
                new SqlParameter("@BatchType2",BatchType2)

                };

                return Execute.RunSP_DataTable(Connection, "SPGET_Batch_By_Status_view_ReworkBatchList", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }
   
        public DataTable Get_DataView_FinishPrimaryPacking(Batch.Status Status, long UserID,int BatchActivity_Finished,string ActType)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@Status",Status),
                 new SqlParameter("@UserID",UserID),
                  new SqlParameter("@BatchActivity_Finished",BatchActivity_Finished),
                     new SqlParameter("@ActType",ActType)
                };

                return Execute.RunSP_DataTable(Connection, "SPGET_Batch_By_Status_view_FinishPrimaryPacking", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public DataTable Get_DataView_ToQC(Batch.Status Status,QCReport.ReportStatus QCReportStatus,long UserID)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@Status",Status),
                 new SqlParameter("@QCReportStatus",Convert.ToInt32(QCReportStatus)),
                 new SqlParameter("@UserID",UserID)
                };

                return Execute.RunSP_DataTable(Connection, "SPGET_Batch_By_Status_view_ToQC", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }


        public DataTable Get_Batch_ToFinish(long UserID,int BatchStatus)
           {
               try
               {

                   SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@UserID",UserID),
                new SqlParameter("@BatchStatus",BatchStatus)
                };


                   return Execute.RunSP_DataTable(Connection, "SPGET_Batch_To_Finish", paramList);

               }
               catch (Exception ex)
               {

                   throw new Exception(ex.Message, ex);
               }
           }


        public DataTable Get_Batch_ToSendQC(long UserID, int BatchStatus_In_Progress)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@UserID",UserID),
                new SqlParameter("@BatchStatus_In_Progress",BatchStatus_In_Progress)
                };


                return Execute.RunSP_DataTable(Connection, "SPGET_Batch_To_SendQC", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }


        public DataTable Get_DataView_Weigh()
        {
            try
            {


                return Execute.RunSP_DataTable(Connection, "SPGET_Batch_By_Status_view_Weighing");

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }


        public decimal Get_Remaining_Of_Manufacturing(string BatchID)
        {
            try
            {
                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@BatchID",BatchID)
                };


                return Execute.RunSP_Q_Output_Decimal(Connection, "SPGET_Batch_Remaining_Of_Manufacturing", paramList);

                

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }



        public string Get_BasicProduct_Rework(string BatchID)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@BatchID",BatchID),
                   new SqlParameter("@outParam",SqlDbType.VarChar,50){Direction=ParameterDirection.Output}
                };

                return Execute.RunSP_Output_String(Connection, "SPGET_Batch_Rework_BasicProduct", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }


        public DataTable Get_MachineCost(string BatchID)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@BatchID",BatchID)};

                return Execute.RunSP_DataTable(Connection, "SPGET_Batch_MachineCost", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        
    
             public DataTable Get_OHCost(string BatchID)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@BatchID",BatchID)};

                return Execute.RunSP_DataTable(Connection, "SPGET_Batch_OH_Summery", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }


        public DataTable Get_LabourCost(string BatchID)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@BatchID",BatchID)};

                return Execute.RunSP_DataTable(Connection, "SPGET_Batch_LabourCost", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }
        

             public DataTable Get_BatchCost_Previous(string BatchID)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@BatchID",BatchID)};

                return Execute.RunSP_DataTable(Connection, "SPGET_Batch_PreviousCost", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }



        public DataTable Get_BatchCost_Summary(string BatchID)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@BatchID",BatchID)};

                return Execute.RunSP_DataTable(Connection, "SPGET_Batch_Cost_Summary", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }



     public DataTable Get_BatchCost_Material(string BatchID)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@BatchID",BatchID)};

                return Execute.RunSP_DataTable(Connection, "SPGET_Batch_Cost_Materials", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

       
        public DataTable Get_BatchPacking_Summary(long BatchPackingID)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@BatchPackingID",BatchPackingID)};

                return Execute.RunSP_DataTable(Connection, "SPGET_BatchPacking_Cost_Summary", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public DataTable Get_BatchPacking_Material_Summary(long BatchPackingID)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@BatchPackingID",BatchPackingID)};

                return Execute.RunSP_DataTable(Connection, "SPGET_BatchPacking_Cost_Materials", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public DataTable Get_BatchPacking_Machine_Summary(long BatchPackingID)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@BatchPackingID",BatchPackingID)};

                return Execute.RunSP_DataTable(Connection, "SPGET_BatchPacking_MachineCost", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public DataTable Get_BatchPacking_Labour_Summary(long BatchPackingID)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@BatchPackingID",BatchPackingID)};

                return Execute.RunSP_DataTable(Connection, "SPGET_BatchPacking_LabourCost", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public DataTable Get_BatchPacking_OH_Summary(long BatchPackingID)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@BatchPackingID",BatchPackingID)};

                return Execute.RunSP_DataTable(Connection, "SPGET_PackingBatch_OH_Summery", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public DataTable GetWIP_Files(int SectionID, int BatchStatus_Packing)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@SectionID",SectionID),
                new SqlParameter("@BatchStatus_Packing",BatchStatus_Packing)};

                return Execute.RunSP_DataTable(Connection, "SPGET_WIP_Files_BySectionID", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public DataTable GetWIP_Files_Packing(int SectionID,int BatchStatus_Packing)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@SectionID",SectionID),
                new SqlParameter("@BatchStatus_Packing",BatchStatus_Packing)};

                return Execute.RunSP_DataTable(Connection, "SPGET_WIP_PackingFiles_BySectionID", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }




        public DataTable GetWIP(int SectionID)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@SectionID",SectionID)};

                return Execute.RunSP_DataTable(Connection, "SPGET_WIP_BySectionID", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }


        public int UpdateFinalQty(Decimal FinalQty,string BatchID)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@BatchFinalQty", FinalQty),
                new SqlParameter("@BatchID", BatchID)
                };

                return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_Batch_FinalQty_WIP", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }


    }
}
