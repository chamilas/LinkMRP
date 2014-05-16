using SESD.MRP.REF;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DL
{
    public class MR_DL
    {
        SqlConnection Connection = new SqlConnection();

        Employee_DL objEmployee_DL = new Employee_DL(ConnectionStringClass.GetConnection());
        Store_DL objStore_DL = new Store_DL(ConnectionStringClass.GetConnection());
        Department_DL objDepartment_DL = new Department_DL(ConnectionStringClass.GetConnection());

        public MR_DL(SqlConnection Conn)
        {
            Connection = Conn;
        }


        public long Add_M(MR obj)
        {
            
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@MRStore", obj.MRStore.StoreID),
                new SqlParameter("@MREnterdBy", obj.MREnterdBy),
                new SqlParameter("@MRFromDepId", obj.MRDepartmentFrom.DepID),
                new SqlParameter("@MRRemarks", obj.MRRemarks),
                new SqlParameter("@MRStatus", obj.MRStatus),
                new SqlParameter("@MRType", obj.MRType),
                new SqlParameter("@OriginType", obj.OriginType),
                new SqlParameter("@outParam",SqlDbType.Int){Direction=ParameterDirection.Output}
                
        };

                return Execute.RunSP_Output(Connection, "SPADD_MR_M", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public int Update(MR obj)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@MRStore", obj.MRStore.StoreID),
                new SqlParameter("@MRDate", obj.MRDate),
                new SqlParameter("@MRApprovedBy", obj.MRApprovedBy),
                new SqlParameter("@MRApproveDate", obj.MRApprovedDate),
                new SqlParameter("@MREnterdBy", obj.MREnterdBy),
                new SqlParameter("@MRFromDepId", obj.MRDepartmentFrom.DepID),
                new SqlParameter("@MRIssuedBy",  obj.MRIssuedBy),
                new SqlParameter("@MRIssuedDate", obj.MRIssuedDate),
                new SqlParameter("@MRReceivedBy", obj.MRReceivedBy),
                new SqlParameter("@MRReceivedDate", obj.MRReceivedDate),
                new SqlParameter("@MRRemarks", obj.MRRemarks),
                new SqlParameter("@MRStatus", obj.MRStatus),
                new SqlParameter("@MRType", obj.MRType),
                new SqlParameter("@Original_MRNO", obj.MRNO)
                
        };

                return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_MR", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

         public int Add_BatchMR(string Part,string BatchID,string StoreID,string RequestedBy,string Remarks,MR.Status MRStatus, MR.Type MRType,int OriginType)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@Part", Part),
                new SqlParameter("@BatchID", BatchID),
                new SqlParameter("@MRStore", StoreID),
                new SqlParameter("@MREnterdBy", RequestedBy),
                new SqlParameter("@MRRemarks", Remarks),
                new SqlParameter("@MRStatus",  MRStatus),
                new SqlParameter("@MRType", MRType),
                new SqlParameter("@OriginType", OriginType),
                 new SqlParameter("@outParam",SqlDbType.Int){Direction=ParameterDirection.Output}
                
                                                            };

                return Execute.RunSP_Output(Connection, "SPADD_BatchMR_SendMR", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }


         public int Add_BatchMR_Packing(string Part, string BatchID, string StoreID, string RequestedBy, string Remarks, MR.Status MRStatus, MR.Type MRType, int OriginType)
         {
             try
             {

                 SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@Part", Part),
                new SqlParameter("@BatchID", BatchID),
                new SqlParameter("@MRStore", StoreID),
                new SqlParameter("@MREnterdBy", RequestedBy),
                new SqlParameter("@MRRemarks", Remarks),
                new SqlParameter("@MRStatus",  MRStatus),
                new SqlParameter("@MRType", MRType),
                new SqlParameter("@OriginType", OriginType),
                 new SqlParameter("@outParam",SqlDbType.Int){Direction=ParameterDirection.Output}
                
                                                            };

                 return Execute.RunSP_Output(Connection, "SPADD_BatchMR_SendMR_Packing", paramList);

             }
             catch (Exception ex)
             {

                 throw new Exception(ex.Message, ex);
             }
         }


         public int Add_Packing_ToSections(string StoreID,int SectionID,int DepID, string RequestedBy, string Remarks, MR.Status MRStatus, MR.Type MRType, int OriginType)
         {
             try
             {

                 SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@MRStore", StoreID),
                new SqlParameter("@SectionID", SectionID),
                new SqlParameter("@DepID", DepID),
                new SqlParameter("@MREnterdBy", RequestedBy),
                new SqlParameter("@MRRemarks", Remarks),
                new SqlParameter("@MRStatus",  MRStatus),
                new SqlParameter("@MRType", MRType),
                new SqlParameter("@OriginType", OriginType),
                 new SqlParameter("@outParam",SqlDbType.Int){Direction=ParameterDirection.Output}
                
                                                            };

                 return Execute.RunSP_Output(Connection, "SPADD_MR_Packing_ToSections", paramList);

             }
             catch (Exception ex)
             {

                 throw new Exception(ex.Message, ex);
             }
         }


         public int Add_BatchMR_SemiFinished(string Part, string BatchID, string StoreID, string RequestedBy, string Remarks, MR.Status MRStatus, MR.Type MRType, int OriginType)
         {
             try
             {

                 SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@Part", Part),
                new SqlParameter("@BatchID", BatchID),
                new SqlParameter("@MRStore", StoreID),
                new SqlParameter("@MREnterdBy", RequestedBy),
                new SqlParameter("@MRRemarks", Remarks),
                new SqlParameter("@MRStatus",  MRStatus),
                new SqlParameter("@MRType", MRType),
                new SqlParameter("@OriginType", OriginType),
                 new SqlParameter("@outParam",SqlDbType.Int){Direction=ParameterDirection.Output}
                
                                                            };

                 return Execute.RunSP_Output(Connection, "SPADD_BatchMR_SendMR_SemiFinished", paramList);

             }
             catch (Exception ex)
             {

                 throw new Exception(ex.Message, ex);
             }
         }



          public int Add_BatchMR_Optional(string Part,string BatchID,string StoreID,string RequestedBy,string Remarks,MR.Status MRStatus, MR.Type MRType,int OriginType)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@Part", Part),
                new SqlParameter("@BatchID", BatchID),
                new SqlParameter("@MRStore", StoreID),
                new SqlParameter("@MREnterdBy", RequestedBy),
                new SqlParameter("@MRRemarks", Remarks),
                new SqlParameter("@MRStatus",  MRStatus),
                new SqlParameter("@MRType", MRType),
                new SqlParameter("@OriginType", OriginType),
                 new SqlParameter("@outParam",SqlDbType.Int){Direction=ParameterDirection.Output}
                
                                                            };

                return Execute.RunSP_Output(Connection, "SPADD_BatchMR_SendMR_Optional", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }


         public int Add_BatchMR_Partial(string Part, string BatchID, string StoreID, string RequestedBy, long DepartmentID, string Remarks, MR.Status MRStatus, MR.Type MRType, int OriginType)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@Part", Part),
                new SqlParameter("@BatchID", BatchID),
                new SqlParameter("@MRStore", StoreID),
                new SqlParameter("@MREnterdBy", RequestedBy),
                new SqlParameter("@MRFromDepId", DepartmentID),
                new SqlParameter("@MRRemarks", Remarks),
                new SqlParameter("@MRStatus",  MRStatus),
                new SqlParameter("@MRType", MRType),
                new SqlParameter("@OriginType", OriginType),
                new SqlParameter("@outParam",SqlDbType.Int){Direction=ParameterDirection.Output}
                
                                                            };

                return Execute.RunSP_Output(Connection, "SPADD_BatchMR_SendMR_Partial", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }


         public int Update_Approve(MR obj)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@ApprovedBy", obj.MRApprovedBy),
                new SqlParameter("@Status", obj.MRStatus),
                new SqlParameter("@MRNO", obj.MRNO)
                
                                                                };

                return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_MR_Approve", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public int Update_Received(MR obj)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@ReceivedBy", obj.MRReceivedBy),
                new SqlParameter("@Status", obj.MRStatus),
                new SqlParameter("@MRNO", obj.MRNO)
                
                                                                };

                return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_MR_Received", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }


        public int Update_ReceiveGRN(MR obj,string StoreID)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@ReceivedBy", obj.MRReceivedBy),
                new SqlParameter("@Status", obj.MRStatus),
                new SqlParameter("@Type", obj.MRType),
                 new SqlParameter("@StoreID",StoreID),
                new SqlParameter("@MRNO", obj.MRNO)
                
                                                                };

                return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_MR_ReceivedGRN", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }


      public int Update_Receive_toRPDBatch(MR obj)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@ReceivedBy", obj.MRReceivedBy),
                new SqlParameter("@Status", obj.MRStatus),
                new SqlParameter("@MRNO", obj.MRNO)        
                                                                };

                return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_MR_Received_toSection", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }


        public int Update_Receive_toBatch(MR obj)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@ReceivedBy", obj.MRReceivedBy),
                new SqlParameter("@Status", obj.MRStatus),
                new SqlParameter("@MRNO", obj.MRNO)        
                                                                };

                return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_MR_Received_toBatch", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        
        public int Update_Issue(MR obj)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@IssuedBy", obj.MRIssuedBy),
                new SqlParameter("@Status", obj.MRStatus),
                new SqlParameter("@MRNO", obj.MRNO)
                
                                                                };

                return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_MR_Issue", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }


        public int Delete(long MRNO)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@Original_MRNO", MRNO)
                
                                                                };

                return Execute.RunSP_RowsEffected(Connection, "SPDELETE_MR", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public MRCollec Get()
        {
            return null;
        }

        public MR Get(long MRNO)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@MRNO", MRNO)};
                
                MR objMR = new MR();

                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_MRByID", paramList);
                if (dt.Rows.Count > 0)
                {

                    if (dt.Rows[0]["MRApprovedBy"] != null)
                    {
                        objMR.MRApprovedBy = Convert.ToString(dt.Rows[0]["MRApprovedBy"]);
                    }

                    if (dt.Rows[0]["MRApproveDate"] != null)
                    {
                        objMR.MRApprovedDate = Convert.ToDateTime(dt.Rows[0]["MRApproveDate"]);
                    }

                    objMR.MRDate = Convert.ToDateTime(dt.Rows[0]["MRDate"]);
                    objMR.MRDepartmentFrom = objDepartment_DL.Get(Convert.ToInt64(dt.Rows[0]["MRFromDepID"]));
                    objMR.MREnterdBy = Convert.ToString(dt.Rows[0]["MREnterdBy"]);

                    if (dt.Rows[0]["MRIssuedBy"] != null)
                    {
                        objMR.MRIssuedBy = Convert.ToString(dt.Rows[0]["MRIssuedBy"]);
                    }

                    if (dt.Rows[0]["MRIssuedDate"] != null)
                    {
                        objMR.MRIssuedDate = Convert.ToDateTime(dt.Rows[0]["MRIssuedDate"]);
                    }


                    objMR.MRNO = Convert.ToInt64(dt.Rows[0]["MRNO"]);

                    if (dt.Rows[0]["MRReceivedBy"] != null)
                    {
                        objMR.MRReceivedBy = Convert.ToString(dt.Rows[0]["MRReceivedBy"]);
                    }

                    if (dt.Rows[0]["MRReceivedDate"] != null)
                    {
                        objMR.MRReceivedDate = Convert.ToDateTime(dt.Rows[0]["MRReceivedDate"]);
                    }

                    objMR.MRRemarks = Convert.ToString(dt.Rows[0]["MRNO"]);
                    objMR.MRStatus = (MR.Status)dt.Rows[0]["MRStatus"];
                    objMR.MRType = (MR.Type)dt.Rows[0]["MRType"];
                    objMR.MRStore = objStore_DL.Get(Convert.ToString(dt.Rows[0]["MRStore"]));

                    if (dt.Rows[0]["MRSectionID"] != DBNull.Value)
                    {
                        objMR.SectionID = Convert.ToInt64(dt.Rows[0]["MRSectionID"]);
                    }


                    objMR.OriginType = (MR.Origin)dt.Rows[0]["OriginType"];

                    if (dt.Rows[0]["MRPrint"] != DBNull.Value)
                    {
                        objMR.Print = Convert.ToBoolean(dt.Rows[0]["MRPrint"]);
                    }

                    if (dt.Rows[0]["MRBulkPrint"] != DBNull.Value)
                    {
                        objMR.BulkPrint = Convert.ToBoolean(dt.Rows[0]["MRBulkPrint"]);
                    }

                }
                    return objMR;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }

                
                    
                
        }

        public System.Data.DataTable GetDataView(long DepID)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@MRFromDepID", DepID)
                
                                                                };

                return Execute.RunSP_DataTable(Connection, "SPGET_MRbyDepID", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }


        public System.Data.DataTable GetMR_BulkPrint_Material(string StoreID, MR.Status MRIssued, MR.Status MRReceived, MR.Status MRReceivedGRN, MR.Status MRReceivedSubStock)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@StoreID", StoreID),
                    new SqlParameter("@MRStatus_Issued", (int)MRIssued),
                 new SqlParameter("@MRStatus_Received", (int)MRReceived),
                 new SqlParameter("@MRStatus_ReceviedGRN", (int)MRReceivedGRN),
                 new SqlParameter("@MRStatus_ReceviedSubStock", (int)MRReceivedSubStock)
                                                                };

                return Execute.RunSP_DataTable(Connection, "SPGET_MRMaterial_BulkPrint_Dataview", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public System.Data.DataTable GetMR_BulkPrint_Material_Packing(string StoreID, int MRType_ToBatch, MR.Status MRIssued, MR.Status MRReceived, MR.Status MRReceivedGRN, MR.Status MRReceivedSubStock)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@StoreID", StoreID),
                 new SqlParameter("@MRType_Batch", MRType_ToBatch),
                 new SqlParameter("@MRStatus_Issued", (int)MRIssued),
                 new SqlParameter("@MRStatus_Received", (int)MRReceived),
                 new SqlParameter("@MRStatus_ReceviedGRN", (int)MRReceivedGRN),
                 new SqlParameter("@MRStatus_ReceviedSubStock", (int)MRReceivedSubStock)
                
                                                                };

                return Execute.RunSP_DataTable(Connection, "SPGET_MRMaterial_BulkPrint_Dataview", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public System.Data.DataTable GetDataView(String StoreID,MR.Status Status)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@StoreID", StoreID),
                new SqlParameter("@Status", Status)
                                                                };

                return Execute.RunSP_DataTable(Connection, "SPGET_MR_ByStoreNoStatus", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public System.Data.DataTable GetMR_ToDep_or_ToStore(long DepID,MR.Status Status,MR.Origin ToBatch)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@DepID", DepID),
                new SqlParameter("@Status", Status) ,
                new SqlParameter("@Origin", ToBatch) };

                return Execute.RunSP_DataTable(Connection, "SPGET_MR_ByDepID_Status", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public System.Data.DataTable GetMR_ToBatch(long UserID, MR.Status Status, MR.Origin ToBatch)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@UserID", UserID),
                new SqlParameter("@Status", Status) ,
                new SqlParameter("@Origin", ToBatch) };

                return Execute.RunSP_DataTable(Connection, "SPGET_MR_ByProduct_Status", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public System.Data.DataTable GetDataView(long UserID, MR.Status Status, MR.Origin OriginType)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@UserID", UserID),
                new SqlParameter("@Status", Status),
                new SqlParameter("@OriginType", OriginType)
                                                                };

                return Execute.RunSP_DataTable(Connection, "SPGET_MR_ByDepID_Status_Origin", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public System.Data.DataTable GetDataView_Store(long UserID, MR.Status Status, MR.Origin OriginType, long DepID)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@UserID", UserID),
                new SqlParameter("@Status", Status),
                new SqlParameter("@OriginType", OriginType),
                new SqlParameter("@DepID", DepID)
                                                                };

                return Execute.RunSP_DataTable(Connection, "SPGET_MR_ByDepID_Status_Origin_Store", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }


        public System.Data.DataTable GetData_toReceive_Batch(int Status,int UserID,int OriginType)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                new SqlParameter("@Status", Status),
                new SqlParameter("@UserID", UserID),
                new SqlParameter("@OriginType", OriginType)
                                                                };

                return Execute.RunSP_DataTable(Connection, "SPGET_MR_By_Receive_toBatch", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        

               public DataTable GetItems(long MRNO)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@MRNO", MRNO)
                                                                };

                return Execute.RunSP_DataTable(Connection, "SPGET_MRItem_By_MR", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public DataTable GetDataView_Material(String MaterialCode,MR.Status Status)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@MRMaterialCode", MaterialCode),
                new SqlParameter("@Status", Status)
                                                                };

                return Execute.RunSP_DataTable(Connection, "SPGET_MR_By_Material", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public DataTable GetDataView_Material_DepID(String MaterialCode, long DepID, MR.Status Status)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@MRMaterialCode", MaterialCode),
                new SqlParameter("@DepID", DepID),
                new SqlParameter("@Status", Status)
                                                                };

                return Execute.RunSP_DataTable(Connection, "SPGET_MR_By_Material_FromDep", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public DataTable GetDataView_BasicProduct(String BasicProduct, MR.Status Status)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@MRBasicProductID", BasicProduct),
                new SqlParameter("@Status", Status)
                                                                };

                return Execute.RunSP_DataTable(Connection, "SPGET_MR_By_BasicProduct", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public DataTable GetDataView_FinishProduct(String FinishProduct, MR.Status Status)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@MRFinishProductID", FinishProduct),
                new SqlParameter("@Status", Status)
                                                                };

                return Execute.RunSP_DataTable(Connection, "SPGET_MR_By_FinishProduct", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public DataTable GetDataView_Item(String Item, MR.Status Status)
        {
            


             try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@ItemCode", Item),
                new SqlParameter("@Status", Status)
                                                                };

                return Execute.RunSP_DataTable(Connection, "SPGET_MR_By_Item", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }
 
        public MRCollec GetByFromDep(decimal FromDep)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@MRFromDepID", FromDep)};

                MRCollec objMRCollec = new MRCollec();

                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_MRbyDepID", paramList);


                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    MR objMR = new MR();

                    objMR.MRApprovedBy = Convert.ToString(dt.Rows[i]["MRApprovedBy"]);
                    objMR.MRApprovedDate = Convert.ToDateTime(dt.Rows[i]["MRApproveDate"]);
                    objMR.MRDate = Convert.ToDateTime(dt.Rows[i]["MRDate"]);
                    objMR.MRDepartmentFrom = objDepartment_DL.Get(Convert.ToInt64(dt.Rows[i]["MRFromDepID"]));
                    objMR.MREnterdBy = Convert.ToString(dt.Rows[i]["MREnterdBy"]);
                    objMR.MRIssuedBy = Convert.ToString(dt.Rows[i]["MRIssuedBy"]);
                    objMR.MRIssuedDate = Convert.ToDateTime(dt.Rows[i]["MRIssuedDate"]);
                    objMR.MRNO = Convert.ToInt64(dt.Rows[i]["MRNO"]);
                    objMR.MRReceivedBy = Convert.ToString(dt.Rows[i]["MRReceivedBy"]);
                    objMR.MRReceivedDate = Convert.ToDateTime(dt.Rows[i]["MRReceivedDate"]);
                    objMR.MRRemarks = Convert.ToString(dt.Rows[i]["MRNO"]);
                    objMR.MRStatus = (MR.Status)dt.Rows[i]["MRStatus"];
                    objMR.MRType = (MR.Type)dt.Rows[i]["MRType"];
                    objMR.MRStore = objStore_DL.Get(Convert.ToString(dt.Rows[i]["MRStore"]));
                    if (dt.Rows[i]["MRSectionID"] != null)
                    {
                        objMR.SectionID = Convert.ToInt64(dt.Rows[i]["MRSectionID"]);
                    }

                    objMRCollec.Add(objMR);

                }


                return objMRCollec;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }

        }

        public int GET_Approval_Count(String EmpID,MR.Status Status)
        {

            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@EmpID", EmpID),
                new SqlParameter("@MRStatus", Status)
                                                                };

                return Execute.RunSP_Int(Connection, "SPGET_MR_CHECKED_Approval", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public int Update_BulkPrint(long MRNO)
        {

            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@MRNO", MRNO)
                                                                };

                return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_MRMaterial_BulkPrint", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public int Update_Print(long MRNO)
        {

            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@MRNO", MRNO)
                                                                };

                return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_MRMaterial_Print", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }



        public int GET_Issue_Count(String EmpID, MR.Status Status)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@EmpID", EmpID),
                new SqlParameter("@MRStatus", Status)
                                                                };

                return Execute.RunSP_Int(Connection, "SPGET_MR_CHECKED_Approval", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public Decimal GetIssuedQuantity(long MRNO,String Item)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@MRNO", MRNO),
                new SqlParameter("@Item", Item)
                                                                };

                return Execute.RunSP_Int(Connection, "SPGET_MRItemIssuedQty", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }   
        }

        public DataTable Get_By_Employee(String EmpID, MR.Status Status)
        {

           try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@EmpID", EmpID),
                new SqlParameter("@MRStatus", Status) };

                return Execute.RunSP_DataTable(Connection, "SPGET_MR_User", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }   
        }

        public DataTable Get_By_Section(long SectionID, MR.Status Status)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@MRSectionID", SectionID),
                new SqlParameter("@MRStatus", Status)
                                                                };

                return Execute.RunSP_DataTable(Connection, "SPGET_MR_View_By_SectionID", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }  
        }


        public DataTable Get_By_Batch(String BatchID, BatchMR.Status Status)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                 new SqlParameter("@BatchID", BatchID),
                new SqlParameter("@MRStatus", Status)
                                                                };

                return Execute.RunSP_DataTable(Connection, "SPGET_MR_View_By_BatchID", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            } 
        }

        public DataTable GetActiveMR(String BatchID, string Part, int Status,int MRType,string StoreID)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                 new SqlParameter("@BatchID", BatchID),
                  new SqlParameter("@Part", Part),
                new SqlParameter("@Status", Status),
                 new SqlParameter("@MRType", MRType),
                 new SqlParameter("@StoreID", StoreID)
                                                                };

                return Execute.RunSP_DataTable(Connection, "SPGET_MR_Active_ByPart_Type", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            } 
        }



        


        public DataTable Get_By_Manage(long DepID, MR.Status Status,DateTime ToDate, DateTime FromDate)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                 new SqlParameter("@DepID", DepID),
                new SqlParameter("@MRStatus", Status),
                new SqlParameter("@ToDate", ToDate),
                new SqlParameter("@FromDate", FromDate)
                                                                };

                return Execute.RunSP_DataTable(Connection, "SPGET_MR_DataView_Manage", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            } 
        }




        
    }
}
