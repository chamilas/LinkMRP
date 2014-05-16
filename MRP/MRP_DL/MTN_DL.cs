using SESD.MRP.REF;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DL
{
    public class MTN_DL
    {
        SqlConnection Connection = new SqlConnection();
        Store_DL objStore_DL = new Store_DL(ConnectionStringClass.GetConnection());
        Department_DL objDepartment_DL = new Department_DL(ConnectionStringClass.GetConnection());

        public MTN_DL(SqlConnection Conn)
        {
            Connection = Conn;
        }
        public long Add(MTN obj)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@MTNBatchID", obj.MTNBatch),
                new SqlParameter("@MTNDate", obj.MTNDate),
                new SqlParameter("@MTNApprovedBy",  obj.MTNApprovedBy.EmployeeID),
                new SqlParameter("@MTNApproveDate", obj.MTNApprovedDate),
                new SqlParameter("@MTNEnterdBy", obj.MTNEnterdBy.EmployeeID),
                new SqlParameter("@MTNFromDepID", obj.MTNDepartmentFrom.DepID),
                new SqlParameter("@MTNToDepID", obj.MTNDepartmentTo.DepID),
                new SqlParameter("@MTNReceivedBy", obj.MTNReceivedBy.EmployeeID),
                new SqlParameter("@MTNReceivedDate", obj.MTNReceivedDate),
                new SqlParameter("@MTNStatus", obj.MTNStatus),
                new SqlParameter("@MTNType", obj.MTNType),
                new SqlParameter("@MTNItemType", obj.MTNItemType),
                new SqlParameter("@MTNStore", obj.MTNStore.StoreID)
        };

                return Execute.RunSP_RowsEffected(Connection, "SPADD_MTN", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }


        public int CreatePackingMTN_toStores(MTN obj, BatchActivity.Status Status, string FinishProductCode, int Qty, BatchActivity.Status BatchActStatus_Finished, BatchActivity.Status BatchActStatus_Secondary)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@MTNPackingBatch", obj.PackingBatch),
                new SqlParameter("@MTNEnterdBy", obj.MTNEnterdBy.EmployeeID),
                new SqlParameter("@MTNToDepID", obj.MTNDepartmentTo.DepID),
                new SqlParameter("@MTNStatus", obj.MTNStatus),
                new SqlParameter("@MTNType", obj.MTNType),
                new SqlParameter("@MTNItemType", obj.MTNItemType),
                 new SqlParameter("@FinishProductCode", FinishProductCode),
                 new SqlParameter("@Qty", Qty),
                  new SqlParameter("@NextBatchActivityStatus",Convert.ToInt32(Status)),
                  new SqlParameter("@BatchActStatus_Finished",Convert.ToInt32(BatchActStatus_Finished)),
                  new SqlParameter("@BatchActStatus_Secondary",Convert.ToInt32(BatchActStatus_Secondary)),
                 new SqlParameter("@outParam",SqlDbType.Int){Direction=ParameterDirection.Output}

        };

                return Execute.RunSP_Output(Connection, "SPADD_MTN_Packing", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }


        }

        public int CreatePackingMTN_Secondary_toStores(MTN obj, BatchActivity.Status Status, string FinishProductCode, int Qty, BatchActivity.Status BatchActStatus_Finished, BatchActivity.Status BatchActStatus_Secondary)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@MTNPackingBatch", obj.PackingBatch),
                new SqlParameter("@MTNEnterdBy", obj.MTNEnterdBy.EmployeeID),
                new SqlParameter("@MTNToDepID", obj.MTNDepartmentTo.DepID),
                new SqlParameter("@MTNStatus", obj.MTNStatus),
                new SqlParameter("@MTNType", obj.MTNType),
                new SqlParameter("@MTNItemType", obj.MTNItemType),
                 new SqlParameter("@FinishProductCode", FinishProductCode),
                 new SqlParameter("@Qty", Qty),
                  new SqlParameter("@NextBatchActivityStatus",Convert.ToInt32(Status)),
                  new SqlParameter("@BatchActStatus_Finished",Convert.ToInt32(BatchActStatus_Finished)),
                  new SqlParameter("@BatchActStatus_Secondary",Convert.ToInt32(BatchActStatus_Secondary)),
                 new SqlParameter("@outParam",SqlDbType.Int){Direction=ParameterDirection.Output}

        };

                return Execute.RunSP_Output(Connection, "SPADD_MTN_Packing_Secondary", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }


        }


        public int CreateBasicProductTransfer_Semi_toRPD(MTN obj, Batch.Status NextStatus, string BasicProductCode, decimal BasicQty)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@MTNBatchID", obj.MTNBatch),
                new SqlParameter("@MTNEnterdBy", obj.MTNEnterdBy.EmployeeID),
                new SqlParameter("@MTNToDepID", obj.MTNDepartmentTo.DepID),
                new SqlParameter("@MTNStatus", obj.MTNStatus),
                new SqlParameter("@MTNType", obj.MTNType),
                new SqlParameter("@MTNItemType", obj.MTNItemType),
                 new SqlParameter("@BasicProductCode", BasicProductCode),
                 new SqlParameter("@Qty", BasicQty),
                  new SqlParameter("@NextBatchStatus",Convert.ToInt32(NextStatus)),
                 new SqlParameter("@outParam",SqlDbType.Int){Direction=ParameterDirection.Output}

        };

                return Execute.RunSP_Output(Connection, "SPADD_MTN_BasicProductTransfer_Semi", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }


        }

        public int CreateBasicProductTransfer_Basic_toRPD(MTN obj, string BasicProductCode, decimal BasicQty,MTN.Status MTNRejectStatus,Batch.Status BatchStatusTransferred)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@MTNBatchID", obj.MTNBatch),
                new SqlParameter("@MTNEnterdBy", obj.MTNEnterdBy.EmployeeID),
                new SqlParameter("@MTNToDepID", obj.MTNDepartmentTo.DepID),
                new SqlParameter("@MTNStatus", obj.MTNStatus),
                new SqlParameter("@MTNType", obj.MTNType),
                new SqlParameter("@MTNItemType", obj.MTNItemType),
                 new SqlParameter("@BasicProductCode", BasicProductCode),
                 new SqlParameter("@Qty", BasicQty),
                new SqlParameter("@MTNStatus_Reject", (int)MTNRejectStatus),
                 new SqlParameter("@BatchStatus_Transferred", (int)BatchStatusTransferred),
                 new SqlParameter("@outParam",SqlDbType.Int){Direction=ParameterDirection.Output}

        };

                return Execute.RunSP_Output(Connection, "SPADD_MTN_BasicProductTransfer_Basic", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }


        }



        public long Add_Return(MTN obj)
        {
            


         try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
   
                new SqlParameter("@MTNEnterdBy", obj.MTNEnterdBy.EmployeeID),
                new SqlParameter("@MTNFromDepID", obj.MTNDepartmentFrom.DepID),
                new SqlParameter("@MTNToDepID", obj.MTNDepartmentTo.DepID),
                new SqlParameter("@MTNStatus", obj.MTNStatus),
                new SqlParameter("@MTNType", obj.MTNType),
                new SqlParameter("@MTNItemType", obj.MTNItemType)
        };

                return Execute.RunSP_RowsEffected(Connection, "SPADD_MTN_ProductReturn", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public long Add_Other(MTN obj)
        {

            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
   
                new SqlParameter("@MTNEnterdBy", obj.MTNEnterdBy.EmployeeID),
                new SqlParameter("@MTNFromDepID", obj.MTNDepartmentFrom.DepID),
                new SqlParameter("@MTNToDepID", obj.MTNDepartmentTo.DepID),
                new SqlParameter("@MTNStatus", obj.MTNStatus),
                new SqlParameter("@MTNType", obj.MTNType),
                new SqlParameter("@MTNItemType", obj.MTNItemType)
        };

                return Execute.RunSP_RowsEffected(Connection, "SPADD_MTN_ProductReturn", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }
    public int Add_PRPDTransfer(MTN obj)
        {

            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
   
                new SqlParameter("@MTNEnterdBy", obj.MTNEnterdBy.EmployeeID),
                new SqlParameter("@MTNFromDepID", obj.MTNDepartmentFrom.DepID),
                new SqlParameter("@MTNToDepID", obj.MTNDepartmentTo.DepID),
                new SqlParameter("@MTNStatus", obj.MTNStatus),
                new SqlParameter("@MTNType", obj.MTNType),
                new SqlParameter("@MTNItemType", obj.MTNItemType),
                      new SqlParameter("@outParam",SqlDbType.Int){Direction=ParameterDirection.Output}
        };

                return Execute.RunSP_Output(Connection, "SPADD_MTN_PRPDTransfer", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }


        public long RemoveStock(MTN obj)
        {

            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
   
                new SqlParameter("@MTNEnterdBy", obj.MTNEnterdBy.EmployeeID),
                new SqlParameter("@MTNFromDepID", obj.MTNDepartmentFrom.DepID),
                new SqlParameter("@MTNToDepID", obj.MTNDepartmentTo.DepID),
                new SqlParameter("@MTNStatus", obj.MTNStatus),
                new SqlParameter("@MTNType", obj.MTNType),
                new SqlParameter("@MTNItemType", obj.MTNItemType)
        };

                return Execute.RunSP_RowsEffected(Connection, "SPADD_MTN_RemoveStock", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public int Update(MTN obj, long OriginalMTNNO)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@MTNBatchID", obj.MTNBatch),
                new SqlParameter("@MTNDate", obj.MTNDate),
                new SqlParameter("@MTNApprovedBy",  obj.MTNApprovedBy.EmployeeID),
                new SqlParameter("@MTNApproveDate", obj.MTNApprovedDate),
                new SqlParameter("@MTNEnterdBy", obj.MTNEnterdBy.EmployeeID),
                new SqlParameter("@MTNFromDepID", obj.MTNDepartmentFrom.DepID),
                new SqlParameter("@MTNToDepID", obj.MTNDepartmentTo.DepID),
                new SqlParameter("@MTNReceivedBy", obj.MTNReceivedBy.EmployeeID),
                new SqlParameter("@MTNReceivedDate", obj.MTNReceivedDate),
                new SqlParameter("@MTNStatus", obj.MTNStatus),
                new SqlParameter("@MTNType", obj.MTNType),
                new SqlParameter("@MTNItemType", obj.MTNItemType),
                new SqlParameter("@MTNStore", obj.MTNStore.StoreID),
                new SqlParameter("@Original_MTNNO", OriginalMTNNO)
        };

                return Execute.RunSP_RowsEffected(Connection, "SPADD_MR", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }


        


        public int Receive(MTN.Status status,long MTNNO, String RecievedBy)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@Status", status),
                new SqlParameter("@MTNNO", MTNNO),
                new SqlParameter("@MTNReceivedBy",RecievedBy)
        };

                return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_MTN_Recieved", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }


        public int Budget_Cost(MTN.Status status, long MTNNO, String MTNBudgetCostBy)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@Status", status),
                new SqlParameter("@MTNNO", MTNNO),
                new SqlParameter("@MTNBudgetCostBy",MTNBudgetCostBy)
                
                

        };

                return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_MTN_CostBudget", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }


        public int Actual_Cost(MTN.Status status, long MTNNO, String MTNBudgetCostBy)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@Status", status),
                new SqlParameter("@MTNNO", MTNNO),
                new SqlParameter("@MTNCostBy",MTNBudgetCostBy)
                
                

        };

                return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_MTN_CostActual", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }



        public int AddGRN(long MTNNO, MTN.Status MTNstatus, String GRNBy,string StoreID,GRN.Type GRNType, GRN.Status GRNStatus)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                 new SqlParameter("@MTNNO", MTNNO),
                new SqlParameter("@MTNStatus", MTNstatus),
                new SqlParameter("@GRNBy", GRNBy),
                new SqlParameter("@StoreID",StoreID),
                 new SqlParameter("@GRNType", Convert.ToInt32(GRNType)),
                new SqlParameter("@GRNStatus",Convert.ToInt32(GRNStatus)),
                    new SqlParameter("@outParam",SqlDbType.Int){Direction=ParameterDirection.Output}
                
                    
        };

                return Execute.RunSP_Output(Connection, "SPUPDATE_MTN_GRN", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }


        public int Delete(long MTNNO)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@Original_MTNNO", MTNNO)

        };

                return Execute.RunSP_RowsEffected(Connection, "SPDELETE_MTN", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public MTNCollec Get()
        {

            Employee_DL objEmployee_DL = new Employee_DL(Connection);
            Department_DL objDepartment_DL = new Department_DL(Connection);
            MTNCollec objMTNCollec = new MTNCollec();
            Store_DL objStore_DL = new Store_DL(Connection);
            GRN_DL objGRN_DL = new GRN_DL(Connection);

            try
            {

                DataTable dt= Execute.RunSP_DataTable(Connection, "SPGET_MTN");

                for (int i = 0; i < dt.Rows.Count; i++)
                {

                    MTN objMTN = new MTN();

                    objMTN.MTNApprovedBy = objEmployee_DL.Get(Convert.ToString(dt.Rows[i]["MTNApprovedBy"]));
                    objMTN.MTNApprovedDate = Convert.ToDateTime(dt.Rows[i]["MTNApproveDate"]);
                    objMTN.MTNBatch = "No";
                    objMTN.MTNDate = Convert.ToDateTime(dt.Rows[i]["MTNDate"]);
                    objMTN.MTNDepartmentFrom = objDepartment_DL.Get(Convert.ToInt64(dt.Rows[i]["MTNFromDepID"]));
                    objMTN.MTNDepartmentTo = objDepartment_DL.Get(Convert.ToInt64(dt.Rows[i]["MTNToDepID"]));
                    objMTN.MTNEnterdBy = objEmployee_DL.Get(Convert.ToString(dt.Rows[i]["MTNEnterdBy"]));
                    objMTN.MTNNo = Convert.ToInt64(dt.Rows[i]["MTNNo"]);
                    objMTN.MTNReceivedBy = objEmployee_DL.Get(Convert.ToString(dt.Rows[i]["MTNReceivedBy"]));
                    objMTN.MTNReceivedDate = Convert.ToDateTime(dt.Rows[i]["MTNReceivedDate"]); 
                    objMTN.MTNStatus = (MTN.Status)dt.Rows[i]["MTNStatus"];
                    objMTN.MTNType = (MTN.Type)dt.Rows[i]["MTNType"];
                    objMTN.MTNItemType = (MTN.ItemType)dt.Rows[i]["MTNItemType"]; 
                    objMTN.MTNStore = objStore_DL.Get(Convert.ToString(dt.Rows[i]["MTNStore"]));

                    objMTNCollec.Add(objMTN);
                }
                return objMTNCollec;


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }


            
           
        }

        public MTNCollec Get(long FromDepID, MTN.Status Status)
        {
            Employee_DL objEmployee_DL = new Employee_DL(Connection);
            Department_DL objDepartment_DL = new Department_DL(Connection);
            MTNCollec objMTNCollec = new MTNCollec();
            Store_DL objStore_DL = new Store_DL(Connection);
            GRN_DL objGRN_DL = new GRN_DL(Connection);

            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@DepID", FromDepID),
                new SqlParameter("@MTNStatus", Status)

        };


                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_MTN_ByFromDep_Status", paramList);

                for (int i = 0; i < dt.Rows.Count; i++)
                {

                    MTN objMTN = new MTN();

                    objMTN.MTNApprovedBy = objEmployee_DL.Get(Convert.ToString(dt.Rows[i]["MTNApprovedBy"]));
                    objMTN.MTNApprovedDate = Convert.ToDateTime(dt.Rows[i]["MTNApproveDate"]);
                    objMTN.MTNBatch = "No";
                    objMTN.MTNDate = Convert.ToDateTime(dt.Rows[i]["MTNDate"]);
                    objMTN.MTNDepartmentFrom = objDepartment_DL.Get(Convert.ToInt64(dt.Rows[i]["MTNFromDepID"]));
                    objMTN.MTNDepartmentTo = objDepartment_DL.Get(Convert.ToInt64(dt.Rows[i]["MTNToDepID"]));
                    objMTN.MTNEnterdBy = objEmployee_DL.Get(Convert.ToString(dt.Rows[i]["MTNEnterdBy"]));
                    objMTN.MTNNo = Convert.ToInt64(dt.Rows[i]["MTNNo"]);
                    objMTN.MTNReceivedBy = objEmployee_DL.Get(Convert.ToString(dt.Rows[i]["MTNReceivedBy"]));
                    objMTN.MTNReceivedDate = Convert.ToDateTime(dt.Rows[i]["MTNReceivedDate"]);
                    objMTN.MTNStatus = (MTN.Status)dt.Rows[i]["MTNStatus"];
                    objMTN.MTNType = (MTN.Type)dt.Rows[i]["MTNType"];
                    objMTN.MTNItemType = (MTN.ItemType)dt.Rows[i]["MTNItemType"];
                    objMTN.MTNStore = objStore_DL.Get(Convert.ToString(dt.Rows[i]["MTNStore"]));

                    objMTNCollec.Add(objMTN);
                }
                return objMTNCollec;


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }


            
        }

        public MTN Get(long MTNNO)
        {
            Employee_DL objEmployee_DL = new Employee_DL(Connection);
            Department_DL objDepartment_DL = new Department_DL(Connection);
            MTNCollec objMTNCollec = new MTNCollec();
            Store_DL objStore_DL = new Store_DL(Connection);
            GRN_DL objGRN_DL = new GRN_DL(Connection);

            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@MTNNO", MTNNO)


        };


                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_MTNByID", paramList);
                MTN objMTN = new MTN();

                if (dt.Rows.Count > 0)
                {


                    objMTN.MTNApprovedBy = objEmployee_DL.Get(Convert.ToString(dt.Rows[0]["MTNApprovedBy"]));
                    objMTN.MTNApprovedDate = Convert.ToDateTime(dt.Rows[0]["MTNApproveDate"]);
                    objMTN.MTNBatch = "No";
                    objMTN.MTNDate = Convert.ToDateTime(dt.Rows[0]["MTNDate"]);
                    objMTN.MTNDepartmentFrom = objDepartment_DL.Get(Convert.ToInt64(dt.Rows[0]["MTNFromDepID"]));
                    objMTN.MTNDepartmentTo = objDepartment_DL.Get(Convert.ToInt64(dt.Rows[0]["MTNToDepID"]));
                    objMTN.MTNEnterdBy = objEmployee_DL.Get(Convert.ToString(dt.Rows[0]["MTNEnterdBy"]));
                    objMTN.MTNNo = Convert.ToInt64(dt.Rows[0]["MTNNo"]);
                    objMTN.MTNReceivedBy = objEmployee_DL.Get(Convert.ToString(dt.Rows[0]["MTNReceivedBy"]));
                    objMTN.MTNReceivedDate = Convert.ToDateTime(dt.Rows[0]["MTNReceivedDate"]);
                    objMTN.MTNStatus = (MTN.Status)dt.Rows[0]["MTNStatus"];
                    objMTN.MTNType = (MTN.Type)dt.Rows[0]["MTNType"];
                    objMTN.MTNItemType = (MTN.ItemType)dt.Rows[0]["MTNItemType"];
                    objMTN.MTNStore = objStore_DL.Get(Convert.ToString(dt.Rows[0]["MTNStore"]));
                }
               

                return objMTN;


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public System.Data.DataTable GetDataView(long UserID, MTN.Status Status)
        {

            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@UserID", UserID),
                new SqlParameter("@Status", Status)


                 };


                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_MTN_ByFromDep_Status", paramList);



                return dt;


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public System.Data.DataTable GetDataView(long UserID, MTN.Status Status,MTN.Type MTNType)
        {

            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@UserID", UserID),
                 new SqlParameter("@MTNType", MTNType),
                new SqlParameter("@Status", Status)


                 };


                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_MTN_ByFromDep_Status_Type", paramList);



                return dt;


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }



        public System.Data.DataTable GetDataView_ToDep(long ToDepID, MTN.Status Status)
        {
            Employee_DL objEmployee_DL = new Employee_DL(Connection);
            Department_DL objDepartment_DL = new Department_DL(Connection);
            MTNCollec objMTNCollec = new MTNCollec();
            Store_DL objStore_DL = new Store_DL(Connection);
            GRN_DL objGRN_DL = new GRN_DL(Connection);

            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@ToDep", ToDepID),
                new SqlParameter("@Status", Status)


                 };


                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_MTN_ByToDep_Status", paramList);



                return dt;


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }


        public System.Data.DataTable Get_Basic_Transfers(long MTNType, int MTNStatus,int MTNItemType)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@MTNType", MTNType),
                new SqlParameter("@Status", MTNStatus),
                new SqlParameter("@MTNItemType", MTNItemType)


        };


                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_MTN_BasicTransfers", paramList);


                return dt;


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }



        


               public System.Data.DataTable Get_From_HP_Batches(long MTNType,int MTNStatus)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@MTNType", MTNType),
                new SqlParameter("@Status", MTNStatus)


        };


                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_MTN_From_HP_Batches", paramList);


                return dt;


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }



               public System.Data.DataTable Get_From_AP_Batches(long MTNType, int MTNStatus)
               {
                   try
                   {

                       SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@MTNType", MTNType),
                new SqlParameter("@Status", MTNStatus)


        };


                       DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_MTN_From_AP_Batches", paramList);


                       return dt;


                   }
                   catch (Exception ex)
                   {

                       throw new Exception(ex.Message, ex);
                   }
               }


               public System.Data.DataTable Get_From_PRPD_Batches(long MTNType, int MTNStatus)
               {
                   try
                   {

                       SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@MTNType", MTNType),
                new SqlParameter("@Status", MTNStatus)


        };


                       DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_MTN_From_PRPD_Batches", paramList);


                       return dt;


                   }
                   catch (Exception ex)
                   {

                       throw new Exception(ex.Message, ex);
                   }
               }


               public System.Data.DataTable Get_From_AP_Batches_Rework(long MTNType, int MTNStatus)
               {
                   try
                   {

                       SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@MTNType", MTNType),
                new SqlParameter("@Status", MTNStatus)


        };


                       DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_MTN_From_AP_Batches_Rework", paramList);


                       return dt;


                   }
                   catch (Exception ex)
                   {

                       throw new Exception(ex.Message, ex);
                   }
               }

               public System.Data.DataTable Get_From_HP_Batches_Rework(long MTNType, int MTNStatus)
               {
                   try
                   {

                       SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@MTNType", MTNType),
                new SqlParameter("@Status", MTNStatus)


        };


                       DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_MTN_From_HP_Batches_Rework", paramList);


                       return dt;


                   }
                   catch (Exception ex)
                   {

                       throw new Exception(ex.Message, ex);
                   }
               }


               public System.Data.DataTable Get_From_Rejects(long MTNType, int MTNStatus)
               {
                   try
                   {

                       SqlParameter[] paramList = new SqlParameter[] {
                
                        new SqlParameter("@MTNType", MTNType),
                        new SqlParameter("@Status", MTNStatus)};


                       DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_MTN_From_Rejects", paramList);


                       return dt;


                   }
                   catch (Exception ex)
                   {

                       throw new Exception(ex.Message, ex);
                   }
               }




        public System.Data.DataTable GetDataView(long MTNNO)
        {
            Employee_DL objEmployee_DL = new Employee_DL(Connection);
            Department_DL objDepartment_DL = new Department_DL(Connection);
            MTNCollec objMTNCollec = new MTNCollec();
            Store_DL objStore_DL = new Store_DL(Connection);
            GRN_DL objGRN_DL = new GRN_DL(Connection);

            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@MTNNO", MTNNO)


        };


                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_MTN_Items", paramList);


                return dt;


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }


        public System.Data.DataTable GetDataView(long To, long From,  MTN.Status Status)
        {

            
                
              Employee_DL objEmployee_DL = new Employee_DL(Connection);
            Department_DL objDepartment_DL = new Department_DL(Connection);
            MTNCollec objMTNCollec = new MTNCollec();
            Store_DL objStore_DL = new Store_DL(Connection);
            GRN_DL objGRN_DL = new GRN_DL(Connection);

            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                 new SqlParameter("@MTNToDepID", To),
                  new SqlParameter("@MTNFromDepID", From),
                new SqlParameter("@MTNStatus", Status)


        };


                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_MTN_Dataview_By_ToDep_FromDep", paramList);


                return dt;


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public System.Data.DataTable GetDataView(DateTime To, DateTime From, long Department, MTN.Status Status)
        {

            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                 new SqlParameter("@FromDate", From),
                  new SqlParameter("@ToDate", To),
                  new SqlParameter("@MTNStatus", Status),
                new SqlParameter("@DepID", Department)


        };


                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_MTN_Dataview_Manage", paramList);


                return dt;


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public int Update(MTN obj)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@MTNApprovedBy",  obj.MTNApprovedBy.EmployeeID),
                new SqlParameter("@Status", obj.MTNStatus),
                new SqlParameter("@MTNNO", obj.MTNNo)
        };

                return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_MTN_Status", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }


        }

        public int Update(long MTNNO, Decimal ReceivedQty, String Code)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@ReceivedQty",  ReceivedQty),
                new SqlParameter("@MTNNO", MTNNO),
                new SqlParameter("@Code", Code)
        };

                return Execute.RunSP_RowsEffected(Connection, "SPUpdate_MTN_ItemReceived", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }


        }

        public int Update(long MTNNO, MTN.Status Status)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@Status",  Status),
                new SqlParameter("@MTNNO", MTNNO)

        };

                return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_MTN_ChangeStatus", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public int Approve(int Status,String ApprovedEmp, String StoreID, long MTNNO)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@MTNApprovedBy",  ApprovedEmp),
                new SqlParameter("@MTNNO", MTNNO),
                new SqlParameter("@StoreID",  StoreID),
                new SqlParameter("@Status",  Status)

        };

                return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_MTN_Approved", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }


        public System.Data.DataTable GetDataByDpByStatus(long DepID, MTN.Status Status)
        {
            

              try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                new SqlParameter("@DepID",  DepID),
                new SqlParameter("@Status",  Status)

        };

                return Execute.RunSP_DataTable(Connection, "SPGET_MTNByDepByStatus", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }


        }

        


        public System.Data.DataTable GetDataViewByStateAndType(MTN.Status Status, MTN.Type Type)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                new SqlParameter("@MTNStatus",  Status),
                new SqlParameter("@MTNType",  Type)

        };

                return Execute.RunSP_DataTable(Connection, "SPGET_MTNByTypeAndState", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }

        }



    }

}
