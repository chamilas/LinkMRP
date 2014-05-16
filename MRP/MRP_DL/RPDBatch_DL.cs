using SESD.MRP.REF;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Data.Sql;

namespace DL
{
    public class RPDBatch_DL
    {
        SqlConnection Connection = new SqlConnection();


        public RPDBatch_DL(SqlConnection Conn)
       {
           Connection = Conn;
       }


        RPDBatchCollec objRPDBatchCollec = new RPDBatchCollec();
        Employee_DL objEmployee_DL = new Employee_DL(ConnectionStringClass.GetConnection());
        MR_DL objMR_DL = new MR_DL(ConnectionStringClass.GetConnection());
        Material_DL objMaterial_DL = new Material_DL(ConnectionStringClass.GetConnection());

        public int Add(RPDBatch obj)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@RPDBatchID", obj.RPDBatchID),
                new SqlParameter("@RPDBatchSuperviserID",obj.RPDBatchSupervisedBy),
                new SqlParameter("@RPDBatchMaterialCode", obj.RPDBatchMaterial),
                new SqlParameter("@RPDBatchQty", obj.RPDBatchQty),
                new SqlParameter("@RPDBatchInstructedBy", obj.RPDBatchInstructedBy),
                new SqlParameter("@RPDBatchInstructedDate", obj.RPDBatchInstructedDate),
                new SqlParameter("@RPDBatchStartDate", obj.RPDBatchStartDate),
                new SqlParameter("@RPDBatchEndDate", obj.RPDBatchEndDate),
                new SqlParameter("@RPDBatchFinalQty", obj.RPDBatchFinalQty),
                new SqlParameter("@RPDBatchStatus", obj.Status),
                new SqlParameter("@RPDBatchMRNO", obj.RPDBatchMR),
                new SqlParameter("@RPDBatchType", obj.Type),
                new SqlParameter("@RPDBatchApprovedBy", obj.ApprovedBy),
                new SqlParameter("@RPDBatchApprovedDate", obj.ApprovedDate),
                new SqlParameter("@RPDBatchEndBy", obj.EndBy)};

                return Execute.RunSP_RowsEffected(Connection, "SPADD_RPDBatch", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }

        }


        public String Add_Initial(RPDBatch obj)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@RPDBatchMaterialCode", obj.RPDBatchMaterial.MaterialCode),
                new SqlParameter("@RPDBatchQty",obj.RPDBatchQty),
                new SqlParameter("@RPDBatchInstructedBy", obj.RPDBatchInstructedBy.EmployeeID),
                new SqlParameter("@RPDBatchStatus", (int)obj.Status),
                new SqlParameter("@RPDBatchType", obj.Type),
                new SqlParameter("@outParam",SqlDbType.VarChar,50){Direction=ParameterDirection.Output}};


                return Execute.RunSP_Output_String(Connection, "SPADD_RPDBatch_Initial", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }

        }

        public int Update_Finish(RPDBatch obj)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@RPDBatchID", obj.RPDBatchID),
                new SqlParameter("@RPDBatchStatus" , obj.Status),
                new SqlParameter("@RPDBatchEndBy" , obj.EndBy.EmployeeID)};

                return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_RPDBatch_Finalize", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public int Update_Transfer(RPDBatch obj)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@RPDBatchID", obj.RPDBatchID),
                new SqlParameter("@RPDBatchStatus" , obj.Status)};

                return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_RPDBatch_Transfer", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public int Update_ApproveCost(RPDBatch obj)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@RPDBatchID", obj.RPDBatchID),
                new SqlParameter("@RPDBatchStatus" , obj.Status)};

                return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_RPDBatch_ApproveCost", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }



        public int Update(RPDBatch obj)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@RPDBatchID", obj.RPDBatchID),
                new SqlParameter("@RPDBatchSuperviserID" , obj.RPDBatchSupervisedBy.EmployeeID),
                new SqlParameter("@RPDBatchMaterialCode" , obj.RPDBatchMaterial.MaterialCode),
                new SqlParameter("@RPDBatchQty", obj.RPDBatchQty),
                new SqlParameter("@RPDBatchInstructedBy" , obj.RPDBatchInstructedBy.EmployeeID),
                new SqlParameter("@RPDBatchInstructedDate", obj.RPDBatchInstructedDate),
                new SqlParameter("@RPDBatchStartDate", obj.RPDBatchStartDate),
                new SqlParameter("@RPDBatchEndDate" , obj.RPDBatchEndDate),
                new SqlParameter("@RPDBatchFinalQty" , obj.RPDBatchFinalQty),
                new SqlParameter("@RPDBatchStatus" , obj.Status),
                new SqlParameter("@RPDBatchMRNO" , obj.RPDBatchMR.MRNO),
                new SqlParameter("@RPDBatchType" , obj.Type),
                new SqlParameter("@RPDBatchApprovedBy" , obj.ApprovedBy.EmployeeID),
                new SqlParameter("@RPDBatchApprovedDate" , obj.ApprovedDate),
                new SqlParameter("@RPDBatchEndBy" , obj.EndBy.EmployeeID)};

                return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_RPDBatch", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public int Update_BatchSize(RPDBatch obj)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@RPDBatchID", obj.RPDBatchID),
                new SqlParameter("@RPDBatchQty", obj.RPDBatchQty),
                new SqlParameter("@RPDBatchInstructedBy" , obj.RPDBatchInstructedBy.EmployeeID)
                };

                return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_RPDBatch_BatchQty", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }



        public int Finish(string RPDBatchID,RPDBatch.RPDBatchStatus theStatus)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@RPDBatchID", RPDBatchID),
                new SqlParameter("@RPDBatchStatus" , (int)theStatus)};

                return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_RPDBatch_Finish", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }



        public int Update_Start(RPDBatch obj)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@RPDBatchID", obj.RPDBatchID),
                new SqlParameter("@RPDBatchSuperviserID" , obj.RPDBatchSupervisedBy.EmployeeID),
                new SqlParameter("@RPDBatchStartDate", obj.RPDBatchStartDate),
                new SqlParameter("@RPDBatchStatus", (int)obj.Status)};

                return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_RPDBatch_Start", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }




        public int Approve(RPDBatch obj)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@RPDBatchID", obj.RPDBatchID),
                new SqlParameter("@RPDBatchApprovedBy" , obj.ApprovedBy.EmployeeID),
                new SqlParameter("@RPDBatchApprovedDate" , obj.ApprovedDate),
                new SqlParameter("@RPDBatchStatus", obj.Status),

            };

                return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_RPDBatch_Approve", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }


        public int Update(String RPDBatchID, long MRNO)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@RPDBatchID", RPDBatchID),
                new SqlParameter("@RPDBatchMRNO",MRNO)};

                return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_RPDBatch_MRNO", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }


        //public DataTable GetFinalProduction(String BatchID)
        //{
        //    tblRPDBatch_FinalProductionTableAdapter daFinalProduction = new tblRPDBatch_FinalProductionTableAdapter();
        //    daFinalProduction.Connection = Connection;
        //    try
        //    {

        //        return daFinalProduction.GetData(BatchID);
        //    }

        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message, ex);
        //    }


        //}


        public Decimal Cost(String RPDBatchID)
        {

            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
               
                new SqlParameter("@RPDBatchID", RPDBatchID)};

                return Execute.RunSP_RowsEffected(Connection, "SPGET_RPDBatchCost", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }


        public Decimal UnitCost(String RPDBatchID)
        {

            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
               
                new SqlParameter("@RPDBatchID", RPDBatchID)};

                return Execute.RunSP_RowsEffected(Connection, "SPGET_RPDBatch_UnitPrice", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }


        public int Delete(String RPDBatchID)
        {

            try
            {
                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@Original_RPDBatchID" , RPDBatchID)};

                return Execute.RunSP_RowsEffected(Connection, "SPDELETE_RPDBatch", paramList);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }

        }


        public RPDBatchCollec Get()
        {

            try
            {

                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_RPDBatch");

                RPDBatchCollec objCollec = new RPDBatchCollec();
                RPDBatch obj = new RPDBatch();

                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {


                        obj.RPDBatchID = Convert.ToString(dt.Rows[i]["RPDBatchID"]);
                        obj.RPDBatchSupervisedBy = objEmployee_DL.Get(Convert.ToString(dt.Rows[i]["RPDBatchSuperviserID"]));
                        obj.RPDBatchMaterial = objMaterial_DL.Get(Convert.ToString(dt.Rows[i]["RPDBatchMaterialCode"]));
                        obj.RPDBatchQty = Convert.ToDecimal(dt.Rows[i]["RPDBatchQty"]);
                        obj.RPDBatchInstructedBy = objEmployee_DL.Get(Convert.ToString(dt.Rows[i]["RPDBatchInstructedBy"]));
                        obj.RPDBatchInstructedDate = Convert.ToDateTime(dt.Rows[i]["RPDBatchInstructedDate"]);
                        obj.RPDBatchStartDate = Convert.ToDateTime(dt.Rows[i]["RPDBatchStartDate"]);
                        obj.RPDBatchEndDate = Convert.ToDateTime(dt.Rows[i]["RPDBatchEndDate"]);
                        obj.RPDBatchFinalQty = Convert.ToDecimal(dt.Rows[i]["RPDBatchFinalQty"]);
                        obj.Status = (RPDBatch.RPDBatchStatus) Enum.Parse(typeof(RPDBatch.RPDBatchStatus),Convert.ToString(dt.Rows[i]["RPDBatchStatus"]));
                        obj.RPDBatchMR = objMR_DL.Get(Convert.ToInt64(dt.Rows[i]["RPDBatchMRNO"]));
                        obj.Type = Convert.ToString(dt.Rows[i]["RPDBatchType"]);
                        obj.ApprovedBy = objEmployee_DL.Get(Convert.ToString(dt.Rows[i]["RPDBatchApprovedBy"]));
                        obj.ApprovedDate = Convert.ToDateTime(dt.Rows[i]["RPDBatchApprovedDate"]);
                        obj.EndBy = objEmployee_DL.Get(Convert.ToString(dt.Rows[i]["RPDBatchEndBy"]));


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


        public RPDBatch Get(String RPDBatchID)
        {

           try
           {
               SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@RPDBatchID",RPDBatchID)};


               DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_RPDBatch_By_ID", paramList);

                RPDBatch obj = new RPDBatch();

                if (dt.Rows.Count > 0)
                {

                        obj.RPDBatchID = Convert.ToString(dt.Rows[0]["RPDBatchID"]);
                        obj.RPDBatchSupervisedBy = objEmployee_DL.Get(Convert.ToString(dt.Rows[0]["RPDBatchSuperviserID"]));
                        obj.RPDBatchMaterial = objMaterial_DL.Get(Convert.ToString(dt.Rows[0]["RPDBatchMaterialCode"]));
                        obj.RPDBatchQty = Convert.ToDecimal(dt.Rows[0]["RPDBatchQty"]);
                        obj.RPDBatchInstructedBy = objEmployee_DL.Get(Convert.ToString(dt.Rows[0]["RPDBatchInstructedBy"]));
                        obj.RPDBatchInstructedDate = Convert.ToDateTime(dt.Rows[0]["RPDBatchInstructedDate"]);
                        obj.RPDBatchStartDate = Convert.ToDateTime(dt.Rows[0]["RPDBatchStartDate"]);
                        obj.RPDBatchEndDate = Convert.ToDateTime(dt.Rows[0]["RPDBatchEndDate"]);
                        obj.RPDBatchFinalQty = Convert.ToDecimal(dt.Rows[0]["RPDBatchFinalQty"]);
                        obj.Status = (RPDBatch.RPDBatchStatus)Enum.Parse(typeof(RPDBatch.RPDBatchStatus), Convert.ToString(dt.Rows[0]["RPDBatchStatus"]));
                        obj.RPDBatchMR = objMR_DL.Get(Convert.ToInt64(dt.Rows[0]["RPDBatchMRNO"]));
                        obj.Type = Convert.ToString(dt.Rows[0]["RPDBatchType"]);
                        obj.ApprovedBy = objEmployee_DL.Get(Convert.ToString(dt.Rows[0]["RPDBatchApprovedBy"]));
                        obj.ApprovedDate = Convert.ToDateTime(dt.Rows[0]["RPDBatchApprovedDate"]);
                        obj.EndBy = objEmployee_DL.Get(Convert.ToString(dt.Rows[0]["RPDBatchEndBy"]));

                }

                return obj;


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }


        public RPDBatchCollec GetByState(int RPDBatchState)
        {

            try
            {
                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@RPDBatchStatus", RPDBatchState)};


                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_RPDBatchByState", paramList);

                RPDBatchCollec objCollec = new RPDBatchCollec();
                RPDBatch obj = new RPDBatch();

                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {


                        obj.RPDBatchID = Convert.ToString(dt.Rows[i]["RPDBatchID"]);
                        obj.RPDBatchSupervisedBy = objEmployee_DL.Get(Convert.ToString(dt.Rows[i]["RPDBatchSuperviserID"]));
                        obj.RPDBatchMaterial = objMaterial_DL.Get(Convert.ToString(dt.Rows[i]["RPDBatchMaterialCode"]));
                        obj.RPDBatchQty = Convert.ToDecimal(dt.Rows[i]["RPDBatchQuantity"]);
                        obj.RPDBatchInstructedBy = objEmployee_DL.Get(Convert.ToString(dt.Rows[i]["RPDBatchInstructedBy"]));
                        obj.RPDBatchInstructedDate = Convert.ToDateTime(dt.Rows[i]["RPDBatchInstructedDate"]);
                        obj.RPDBatchStartDate = Convert.ToDateTime(dt.Rows[i]["RPDBatchStartDate"]);
                        obj.RPDBatchEndDate = Convert.ToDateTime(dt.Rows[i]["RPDBatchEndDate"]);
                        obj.RPDBatchFinalQty = Convert.ToDecimal(dt.Rows[i]["RPDBatchFinalQty"]);
                        obj.Status = (RPDBatch.RPDBatchStatus)Enum.Parse(typeof(RPDBatch.RPDBatchStatus),Convert.ToString(dt.Rows[i]["RPDBatchStatus"]));
                        obj.RPDBatchMR = objMR_DL.Get(Convert.ToInt64(dt.Rows[i]["RPDBatchMRNO"]));
                        obj.Status = (RPDBatch.RPDBatchStatus)Enum.Parse(typeof(RPDBatch.RPDBatchStatus), Convert.ToString(dt.Rows[i]["MaterialName"]));

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


        public int UpdateDryerDate(string RPDBatchID,decimal DryerRate)
        {

            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@RPDBatchID",RPDBatchID),
                 new SqlParameter("@DryerRate",DryerRate)
                };

                return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_RPDBatch_DryerRate", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }


        }


        public System.Data.DataTable GetDataViewByState(RPDBatch.RPDBatchStatus state, bool QueryType)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@RPDBatchStatus",state),
                 new SqlParameter("@QueryType",QueryType)
                };

                return Execute.RunSP_DataTable(Connection, "SPGET_RPDBatch_View_By_Status", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }


        public System.Data.DataTable GetDataViewByState(RPDBatch.RPDBatchStatus state1,RPDBatch.RPDBatchStatus state2, bool QueryType)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                 new SqlParameter("@RPDBatchStatus1",state1),
                 new SqlParameter("@RPDBatchStatus2",state2),
                 new SqlParameter("@QueryType",QueryType)
                };

                return Execute.RunSP_DataTable(Connection, "SPGET_RPDBatch_View_By_Status1", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }


        public System.Data.DataTable GetData(string RPDBatchID)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                 new SqlParameter("@RPDBatchID",RPDBatchID)
                };

                return Execute.RunSP_DataTable(Connection, "SPGET_RPDBatchByID", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }


        public Decimal CalculateUnitCost(String RPDBatchID)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@RPDBatchID", RPDBatchID)};

                return Execute.RunSP_RowsEffected(Connection, "SPGET_RPDBatch_UnitPrice", paramList);


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        

public int Update_Cost(String RPDBatchID,string GeneratedBy)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@RPDBatchID", RPDBatchID),
               new SqlParameter("@GenerateBy", GeneratedBy)};

                return Execute.RunSP_RowsEffected(Connection, "SPADD_RPDBatchCost_Update", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }



        public int UpdateUnitCost(String RPDBatchID)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@RPDBatchID", RPDBatchID)};

                return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_RPDBatchActualProduction_UnitCost", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }


        public DataTable GetRPDBatchCost(String RPDBatchID)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@RPDBatchID", RPDBatchID)};

                return Execute.RunSP_DataTable(Connection, "SPGET_RPDBatch_Cost", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public DataTable GetPrevious(String RPDBatchID)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@RPDBatchID", RPDBatchID)};

                return Execute.RunSP_DataTable(Connection, "SPGET_RPDBatch_PreviousBatch", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }



        public DataTable GetRPDBatchLabourCost(String RPDBatchID)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@RPDBatchID", RPDBatchID)};

                return Execute.RunSP_DataTable(Connection, "SPGET_RPDBatch_Labour_Summary", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public DataTable GetRPDBatchMachineCost(String RPDBatchID)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@RPDBatchID", RPDBatchID)};

                return Execute.RunSP_DataTable(Connection, "SPGET_RPDBatch_Machine_Summary", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }


        public DataTable GetRPDBatchOHCost(String RPDBatchID)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@RPDBatchID", RPDBatchID)};

                return Execute.RunSP_DataTable(Connection, "SPGET_RPDBatch_Overhead_Summary", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }
 public DataTable GetRPDBatchMaterialCost(String RPDBatchID)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@RPDBatchID", RPDBatchID)};

                return Execute.RunSP_DataTable(Connection, "SPGET_RPDBatch_MaterialCost", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

 public DataTable GetRPDBatchActualProdution(String RPDBatchID)
 {
     try
     {


         SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@RPDBatchID", RPDBatchID)};

         return Execute.RunSP_DataTable(Connection, "SPGET_RPDBatchActualProduction_By_RPDBatchID_ForReport", paramList);

     }
     catch (Exception ex)
     {

         throw new Exception(ex.Message, ex);
     }
 }


    }
}


