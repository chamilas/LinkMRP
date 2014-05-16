using SESD.MRP.REF;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace DL
{
    public class BatchActivity_DL
    {
        SqlConnection Connection = new SqlConnection();
        public BatchActivity_DL(SqlConnection Conn)
        {
            Connection = Conn;
        }
        public long Add(BatchActivity objBatchActivity)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@BatchActID", objBatchActivity.BatchActID),
                new SqlParameter("@BatchID",objBatchActivity.Batch.BatchID),
                new SqlParameter("@ActID", objBatchActivity.MainActivity.MainActID),
                new SqlParameter("@BatchActStatus",Convert.ToInt32(objBatchActivity.BatchActStatus)),
                new SqlParameter("@SequenceNo", objBatchActivity.SequenceNo),
                new SqlParameter("@Part",objBatchActivity.Part),
                new SqlParameter("@ActType",objBatchActivity.ActType),
                new SqlParameter("@BlockNextActivity", objBatchActivity.BlockNextActivity),
                new SqlParameter("@ActMethod", objBatchActivity.ActMethod),
                new SqlParameter("@outParam",SqlDbType.Int){Direction=ParameterDirection.Output}};

                return Execute.RunSP_Int(Connection, "SPADD_BatchActivity_Update", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }



        }

        public long Add_QCFail(string BatchID,string InstructedBy,long MainActID,string Part)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@BatchID",BatchID),
                 new SqlParameter("@InstructedBy",InstructedBy),
                new SqlParameter("@MainActID", MainActID),
                new SqlParameter("@Part",Part)
               
                };

                return Execute.RunSP_Int(Connection, "SPADD_BatchActivity_QCFail", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }



        }


        public long Add_Packing(string BatchID, int BatchStatus, string StartProductCode, string EndProductCode, decimal PackingQty, string ChangedBy, string ActMethod)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@BatchID",BatchID),
                new SqlParameter("@BatchStatus",BatchStatus),
                new SqlParameter("@StartProductCode",StartProductCode),
                new SqlParameter("@EndProductCode",EndProductCode),
                new SqlParameter("@PackingQty",PackingQty),
                new SqlParameter("@ChangedBy",ChangedBy),
                new SqlParameter("@ActMethod" , ActMethod),
                new SqlParameter("@outParam",SqlDbType.Int){Direction=ParameterDirection.Output}};

                return Execute.RunSP_Output(Connection, "SPADD_BatchActivity_Packing", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }



        }

        public long Add_Packing_Rework(string BatchID, int BatchStatus, string StartProductCode, string EndProductCode, decimal PackingQty, string ChangedBy, string ActMethod)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@BatchID",BatchID),
                new SqlParameter("@BatchStatus",BatchStatus),
                new SqlParameter("@StartProductCode",StartProductCode),
                new SqlParameter("@EndProductCode",EndProductCode),
                new SqlParameter("@PackingQty",PackingQty),
                new SqlParameter("@ChangedBy",ChangedBy),
                new SqlParameter("@ActMethod" , ActMethod),
                new SqlParameter("@outParam",SqlDbType.Int){Direction=ParameterDirection.Output}};

                return Execute.RunSP_Output(Connection, "SPADD_BatchActivity_Rework", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }



        }


        public long Add_Packing_Secondary(string BatchID,int BatchStatus, int BatchActStatus_Finshed, int BatchActStatus_SecondaryPacking, string StartProductCode, string EndProductCode, decimal PackingQty, string ChangedBy, string ActMethod, int PrimaryBatchActID)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@BatchID",BatchID),
                new SqlParameter("@BatchStatus",BatchStatus),
                new SqlParameter("@BatchActStatus_Finished",BatchActStatus_Finshed),
                new SqlParameter("@BatchActStatus_SecondaryPacking",BatchActStatus_SecondaryPacking),
                new SqlParameter("@StartProductCode",StartProductCode),
                new SqlParameter("@EndProductCode",EndProductCode),
                new SqlParameter("@PackingQty",PackingQty),
                new SqlParameter("@ChangedBy",ChangedBy),
                new SqlParameter("@ActMethod",ActMethod),
                new SqlParameter("@PrimaryBatchActID",PrimaryBatchActID),
                new SqlParameter("@outParam",SqlDbType.Int){Direction=ParameterDirection.Output}};

                return Execute.RunSP_Output(Connection, "SPADD_BatchActivity_Packing_Secondary", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }



        }

        public long Update_All(BatchActivity objBatchActivity)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@BatchActID", objBatchActivity.BatchActID),
                new SqlParameter("@StartQty",objBatchActivity.StartQty),
                new SqlParameter("@EndProductCode",objBatchActivity.EndProductCode),
                 new SqlParameter("@StopQty",objBatchActivity.StopQty)
                };

                return Execute.RunSP_Int(Connection, "SPUPDATE_BatchActivity_All", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }



        }




    public long Update_Initial(BatchActivity objBatchActivity)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@BatchActID", objBatchActivity.BatchActID),
                new SqlParameter("@StartQty",objBatchActivity.StartQty),
                new SqlParameter("@EndProductCode",objBatchActivity.EndProductCode),
                };

                return Execute.RunSP_Int(Connection, "SPUPDATE_BatchActivity_Initial", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }



        }


        public long Update(BatchActivity objBatchActivity)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@BatchActID", objBatchActivity.BatchActID),
                new SqlParameter("@StopQty",objBatchActivity.StopQty),
                new SqlParameter("@BatchActStatus",Convert.ToInt32(objBatchActivity.BatchActStatus)),
                new SqlParameter("@ActMethod",objBatchActivity.ActMethod),
                };

                return Execute.RunSP_Int(Connection, "SPUPDATE_BatchActivity", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }



        }

        public int Update_FinalQty_WIP(decimal FinalQty,int BatchActID)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@StopQty",FinalQty),
                new SqlParameter("@BatchActID",BatchActID)
                };

                return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_BatchActivity_FinalQty_WIP", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }



        }


        public BatchActivity Get(string BatchID, long ActID)
        {
            BatchActivity objBatchActivity = new BatchActivity();
            Batch_DL objBatch_DL = new Batch_DL(Connection);
            Employee_DL objEmployee_DL = new Employee_DL(Connection);
            MainActivity_DL objMainActivity_DL = new MainActivity_DL(Connection);


            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@ActID",ActID),
                new SqlParameter("@BatchID",BatchID)
                };

                DataTable dt= Execute.RunSP_DataTable(Connection, "SPGET_BatchActivity_By_Batch_Act", paramList);

                if (dt.Rows.Count != 0)
                {

                    objBatchActivity.MainActivity = objMainActivity_DL.Get(Convert.ToInt64(dt.Rows[0]["ActID"]));
                    objBatchActivity.BatchActID = Convert.ToInt64(dt.Rows[0]["BatchActID"]);
                    objBatchActivity.Batch = objBatch_DL.Get(dt.Rows[0]["BatchID"].ToString());

                    objBatchActivity.BatchActStatus = (BatchActivity.Status)dt.Rows[0]["BatchActStatus"];

                    if (dt.Rows[0]["SequenceNo"] != DBNull.Value)
                    {
                        objBatchActivity.SequenceNo = Convert.ToInt32(dt.Rows[0]["SequenceNo"]);
                    }
                    objBatchActivity.Part = dt.Rows[0]["Part"].ToString();

                    objBatchActivity.LastEdited = Convert.ToDateTime(dt.Rows[0]["LastEdited"]);
                    objBatchActivity.BlockNextActivity = Convert.ToBoolean(dt.Rows[0]["BlockNextActivity"]);
                    objBatchActivity.ActMethod = Convert.ToString(dt.Rows[0]["ActMethod"]);

                    if (dt.Rows[0]["StartQty"] != DBNull.Value)
                    {
                        objBatchActivity.StartQty = Convert.ToDecimal(dt.Rows[0]["StartQty"]);
                    }

                    if (dt.Rows[0]["StopQty"] != DBNull.Value)
                    {
                        objBatchActivity.StopQty = Convert.ToDecimal(dt.Rows[0]["StopQty"]);
                    }
                    if (dt.Rows[0]["SupervisedBy"] != DBNull.Value)
                    {
                        objBatchActivity.SupervisedBy = objEmployee_DL.Get(dt.Rows[0]["SupervisedBy"].ToString());
                    }
                }

                return objBatchActivity;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }


            }


        public BatchActivity GetByID(int BatchActID)
        {
            BatchActivity objBatchActivity = new BatchActivity();
            Batch_DL objBatch_DL = new Batch_DL(Connection);
            Employee_DL objEmployee_DL = new Employee_DL(Connection);
            MainActivity_DL objMainActivity_DL = new MainActivity_DL(Connection);


            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@BatchActID",BatchActID)

                };

                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_BatchActivity_By_ID", paramList);

                if (dt.Rows.Count != 0)
                {

                    objBatchActivity.MainActivity = objMainActivity_DL.Get(Convert.ToInt64(dt.Rows[0]["ActID"]));
                    objBatchActivity.BatchActID = Convert.ToInt64(dt.Rows[0]["BatchActID"]);
                    objBatchActivity.Batch = objBatch_DL.Get(dt.Rows[0]["BatchID"].ToString());

                    if (dt.Rows[0]["BatchActStatus"] != DBNull.Value)
                    {
                        objBatchActivity.BatchActStatus = (BatchActivity.Status)dt.Rows[0]["BatchActStatus"];
                    }

                    if (dt.Rows[0]["SequenceNo"] != DBNull.Value)
                    {
                        objBatchActivity.SequenceNo = Convert.ToInt32(dt.Rows[0]["SequenceNo"]);
                    }
                    objBatchActivity.Part = dt.Rows[0]["Part"].ToString();

                    objBatchActivity.LastEdited = Convert.ToDateTime(dt.Rows[0]["LastEdited"]);
                    objBatchActivity.BlockNextActivity = Convert.ToBoolean(dt.Rows[0]["BlockNextActivity"]);

                    if (dt.Rows[0]["StartQty"] != DBNull.Value)
                    {
                        objBatchActivity.StartQty = Convert.ToDecimal(dt.Rows[0]["StartQty"]);
                    }

                    if (dt.Rows[0]["StopQty"] != DBNull.Value)
                    {
                        objBatchActivity.StopQty = Convert.ToDecimal(dt.Rows[0]["StopQty"]);
                    }
                    if (dt.Rows[0]["SupervisedBy"] != DBNull.Value)
                    {
                        objBatchActivity.SupervisedBy = objEmployee_DL.Get(dt.Rows[0]["SupervisedBy"].ToString());
                    }

                    if (dt.Rows[0]["StartProductCode"] != DBNull.Value)
                    {
                        objBatchActivity.StartProductCode = dt.Rows[0]["StartProductCode"].ToString();
                    }

                    if (dt.Rows[0]["EndProductCode"] != DBNull.Value)
                    {
                        objBatchActivity.EndProductCode = dt.Rows[0]["EndProductCode"].ToString();
                    }

                    objBatchActivity.ActType = dt.Rows[0]["ActType"].ToString();

                    if (dt.Rows[0]["ActMethod"] != DBNull.Value)
                    {
                        objBatchActivity.ActMethod = dt.Rows[0]["ActMethod"].ToString();
                    }
                }

                return objBatchActivity;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }


        }


       

        public DataTable GetView(String BatchID)
        {

            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@BatchID", BatchID)};

                return Execute.RunSP_DataTable(Connection, "SPGET_BatchActivity_By_BatchID", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }



        public DataTable GetView_Packing(String BatchID)
        {

            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@BatchID", BatchID)};

                return Execute.RunSP_DataTable(Connection, "SPGET_BatchActivity_Packing", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public DataTable GetView_Packing_Secondary(int BatchActStatus1, int BatchActStatus2)
        {

            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                  new SqlParameter("@BatchActStatus1", BatchActStatus1),
                new SqlParameter("@BatchActStatus2", BatchActStatus2)};

                return Execute.RunSP_DataTable(Connection, "SPGET_BatchActivity_Packing_Secondary", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }


        public DataTable GetView_Packing_Secondary_Admin(int BatchActStatus1, int BatchActStatus2, int BatchActStatus3)
        {

            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                  new SqlParameter("@BatchActStatus1", BatchActStatus1),
                new SqlParameter("@BatchActStatus2", BatchActStatus2),
                new SqlParameter("@BatchActStatus3", BatchActStatus3)};

                return Execute.RunSP_DataTable(Connection, "SPGET_BatchActivity_Packing_Secondary_Admin", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }


        public DataTable GetView_Packing_Secondary(String BatchID, int BatchActID)
        {

            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@BatchID", BatchID),
               new SqlParameter("@BatchActID", BatchActID) };

                return Execute.RunSP_DataTable(Connection, "SPGET_BatchActivity_Packing_SecondaryOnly", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }


        public DataTable GetView_ToTransfer(String BatchID, int BatchActStatus)
        {

            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@BatchID", BatchID),
                new SqlParameter("@BatchActStatus", BatchActStatus)};

                return Execute.RunSP_DataTable(Connection, "SPGET_BatchActivity_ToTransfer", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public DataTable Get_DataView_Rework(string BatchID,int BatchStatus, string BatchType1, string BatchType2, int BatchActivity_Initial, int BatchActivity_Start)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                 new SqlParameter("@BatchID",BatchID),
                new SqlParameter("@BatchStatus",BatchStatus),
                new SqlParameter("@BatchType1",BatchType1),
                 new SqlParameter("@BatchType2",BatchType2),
                  new SqlParameter("@BatchActivity_Initial",BatchActivity_Initial),
                   new SqlParameter("@BatchActivity_Start",BatchActivity_Start)
                };

                return Execute.RunSP_DataTable(Connection, "SPGET_Batch_By_Status_view_Rework", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public DataTable GetView_To_FinishPriamryPacking(int BatchActStatus)
        {

            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@BatchActStatus", BatchActStatus)};

                return Execute.RunSP_DataTable(Connection, "SPGET_BatchActivity_ToTransfer_Secondary", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

         public DataTable GetView_ToTransfer_ToSecondary(int BatchActStatus)
        {

            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@BatchActStatus", BatchActStatus)};

                return Execute.RunSP_DataTable(Connection, "SPGET_BatchActivity_ToTransfer_To_Secondary", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }


         public DataTable GetView_ToTransfer_Secondary(int BatchActStatus)
        {

            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@BatchActStatus", BatchActStatus)};

                return Execute.RunSP_DataTable(Connection, "SPGET_BatchActivity_ToTransfer_Secondary", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

          public DataTable GetView_ToTransfer_Primary(String BatchID,int BatchActStatus_Secondary, int BatchActStatus_Finished)
        {

            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@BatchID", BatchID),
                new SqlParameter("@BatchActStatus_Secondary", BatchActStatus_Secondary),
                new SqlParameter("@BatchActStatus_Finished", BatchActStatus_Finished)};

                return Execute.RunSP_DataTable(Connection, "SPGET_BatchActivity_ToTransfer_Primary", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

          public DataTable GetView_ToTransfer_Rework(String BatchID, int BatchActStatus_Finished)
          {

              try
              {


                  SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@BatchID", BatchID),
                new SqlParameter("@BatchActStatus_Finished", BatchActStatus_Finished)};

                  return Execute.RunSP_DataTable(Connection, "SPGET_BatchActivity_ToTransfer_Rework", paramList);

              }
              catch (Exception ex)
              {

                  throw new Exception(ex.Message, ex);
              }
          }


        public DataTable GetView_Remaining_ToTransfer(String BatchID,int BatchActStatus_Secondary, int BatchActStatus_Finished)
        {

            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@BatchID", BatchID),
                new SqlParameter("@BatchActStatus_Secondary", BatchActStatus_Secondary),
                new SqlParameter("@BatchActStatus_Finished", BatchActStatus_Finished)};

                return Execute.RunSP_DataTable(Connection, "SPGET_BatchActivity_Remaining_ToTransfer", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }
        
        
        
        
    }
}
