using System;
using System.Collections.Generic;
using System.Text;
using SESD.MRP.REF;
using System.Data.SqlClient;
using System.Data;
using System.Data.Sql;

namespace DL
{
    public class PRPDBatchActivityDetails_DL
    {
        SqlConnection Connection = new SqlConnection();

        PRPDBatchActivity_DL objPRPDBatchActivity_DL = new PRPDBatchActivity_DL(ConnectionStringClass.GetConnection());
        Employee_DL objEmployee_DL = new Employee_DL(ConnectionStringClass.GetConnection());

        public PRPDBatchActivityDetails_DL(SqlConnection Conn)
        {
            Connection = Conn;
        }

        public int AddActWithMachine(PRPDBatchActivityDetails obj)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@PRPDBatchBatchActID", obj.PRPDBatchActivity),
                new SqlParameter("@SubActivity", obj.SubActivity),
                new SqlParameter("@ActivityDate", obj.ActivityDate),
                new SqlParameter("@StartTime", obj.StartTime),
                new SqlParameter("@StartQty", obj.StartQty),
                new SqlParameter("@SupervisedBy", obj.SupervisedBy),
                new SqlParameter("@Remarks", obj.Remarks),
                new SqlParameter("@NoOfTrays", obj.NoOfTrays),
                new SqlParameter("@WeightLoss", obj.WeightLoss),
                new SqlParameter("@ID", obj.PRPDBatchActDetailsID)};

                return Execute.RunSP_RowsEffected(Connection, "SPADD_PRPDBatchActivityDetails", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }

        }

        public int GetNotFinishedCount(long ActivityID)
        {

            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
               
                new SqlParameter("@PRPDBatchBatchActID", ActivityID)};

                return Execute.RunSP_Output(Connection, "SPGET_PRPDActivityDetails_Count_NotFinished", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public int Add_For_GeneralAct(PRPDBatchActivityDetails obj)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@PRPDBatchBatchActID", obj.PRPDBatchActivity),
                new SqlParameter("@SubActivity", obj.SubActivity),
                new SqlParameter("@ActivityDate", obj.ActivityDate),
                new SqlParameter("@StartTime", obj.StartTime),
                new SqlParameter("@StopTime", obj.StopTime),
                new SqlParameter("@StartQty", obj.StartQty),
                new SqlParameter("@StopQty", obj.StopQty),
                new SqlParameter("@SupervisedBy", obj.SupervisedBy),
                new SqlParameter("@Remarks", obj.Remarks),
                new SqlParameter("@PRPDBatchActDetailsID", obj.PRPDBatchActDetailsID)};

                return Execute.RunSP_RowsEffected(Connection, "SPADD_PRPDBatchActivityDetailsGen", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }

        }

        public int Update(PRPDBatchActivityDetails obj, long Original_PRPDBatchActDetailsID)
        {

            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@PRPDBatchBatchActID", obj.PRPDBatchActivity),
                new SqlParameter("@SubActivity", obj.SubActivity),
                new SqlParameter("@ActivityDate", obj.ActivityDate),
                new SqlParameter("@StartTime", obj.StartTime),
                new SqlParameter("@StopTime", obj.StopTime),
                new SqlParameter("@StartQty", obj.StartQty),
                new SqlParameter("@StopQty", obj.StopQty),
                new SqlParameter("@SupervisedBy", obj.SupervisedBy),
                new SqlParameter("@Remarks",obj.Remarks),
                new SqlParameter("@Original_PRPDBatchActDetailsID", obj.PRPDBatchActDetailsID)};

                return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_PRPDBatchActivityDetails", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }

        }


        public int Delete(long Original_PRPDBatchActDetailsID)
        {

            try
            {
                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@Original_PRPDBatchActDetailsID",Original_PRPDBatchActDetailsID)};

                return Execute.RunSP_RowsEffected(Connection, "SPDELETE_PRPDBatchActivityDetails", paramList);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }

        }


        public PRPDBatchActivityDetails.PRPDBatchActivityDetailsCollc Get()
       {

           try
           {

               DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_PRPDBatchActivityDetails");

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
                       obj.Status = (PRPDBatch.PRPDBatchStatus)Enum.Parse(typeof(PRPDBatch.PRPDBatchStatus),Convert.ToString(dt.Rows[i]["PRPDBatchStatus"]);
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
                       obj.OutSourceQty = Convert.ToDecimal(dt.Rows[i]["OutSourceQty"]);

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
        public PRPDBatchActivityDetails Get(long PRPDBatchActivityDetailsID)
        {

           try
           {
               SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@PRPDBatchActDetailsID" , PRPDBatchActivityDetailsID)};


               DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_PRPDBatchActivityDetailsByID", paramList);

               PRPDBatchActivityDetails obj = new PRPDBatchActivityDetails();

               if (dt.Rows.Count > 0)
               {

                   obj.PRPDBatchActDetailsID = Convert.ToInt64(dt.Rows[0]["PRPDBatchActDetailsID"]);
                   obj.PRPDBatchActivity= objPRPDBatchActivity_DL.Get(Convert.ToInt64(dt.Rows[0]["PRPDBatchBatchActID"]));
                   obj.SubActivity = Convert.ToString(dt.Rows[0]["SubActivity"]);
                   obj.ActivityDate = Convert.ToDateTime(dt.Rows[0]["ActivityDate"]);
                   obj.StartTime = Convert.ToDateTime(dt.Rows[0]["StartTime"]);
                   obj.StopTime = Convert.ToDateTime(dt.Rows[0]["StopTime"]);
                   obj.StartQty = Convert.ToDecimal(dt.Rows[0]["StartQty"]);
                   obj.StopQty = Convert.ToDecimal(dt.Rows[0]["StopQty"]);
                   obj.SupervisedBy = objEmployee_DL.Get(Convert.ToString(dt.Rows[0]["SupervisedBy"]));
                   obj.Remarks = Convert.ToString(dt.Rows[0]["Remarks"]);
                   obj.NoOfTrays = Convert.ToInt64(dt.Rows[0]["NoOfTrays"]);
                   obj.WeightLoss = Convert.ToDecimal(dt.Rows[0]["WeightLoss"]);
               }

               return obj;


           }
           catch (Exception ex)
           {

               throw new Exception(ex.Message, ex);
           }
       }




        public System.Data.DataTable GetDataByID(int PRPDBatchActivityDetailsID)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
               new SqlParameter("@PRPDBatchActDetailsID" , PRPDBatchActivityDetailsID)};

                return Execute.RunSP_DataTable(Connection, "SPGET_PRPDBatchActivityDetailsByID", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }

        }



        public System.Data.DataTable GetView(long BatchActID)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
               new SqlParameter("@PRPDBatchBatchActID" ,BatchActID)};

                return Execute.RunSP_DataTable(Connection, "SPGET_PRPDBatchActivityDetails_By_BatchActID", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }

        }

        public System.Data.DataTable GetData_Full_ByBatchID(string PRPDBatchID)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
               new SqlParameter("@PRPDBatchID" ,PRPDBatchID )};

                return Execute.RunSP_DataTable(Connection, "SPGET_PRPDBatchActivityDetails_Full_By_BatchID", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }

        }

    }
}
