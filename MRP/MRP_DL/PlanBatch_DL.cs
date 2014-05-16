using System;
using System.Collections.Generic;
using System.Text;
using SESD.MRP.REF;
using System.Data;
using System.Data.SqlClient;


namespace DL
{
    public class PlanBatch_DL
    {
        SqlConnection Connection = new SqlConnection();


        public PlanBatch_DL(SqlConnection Conn)
        {
            Connection = Conn;
        }


        public long Add(PlanBatch objPlanBatch)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@Year", objPlanBatch.Year),
                new SqlParameter("@Month", objPlanBatch.Month),
                new SqlParameter("@RevisionID", objPlanBatch.RevisionID),
                new SqlParameter("@ProductCode", objPlanBatch.ProductCode),
                new SqlParameter("@WeekID", objPlanBatch.WeekID),
                new SqlParameter("@BatchSize", objPlanBatch.BatchSize),
                new SqlParameter("@Nos", objPlanBatch.Nos)};


                return Execute.RunSP_RowsEffected(Connection, "SPADD_PlanBatch", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }


        public int Update(PlanBatch objPlanBatch, int Original_RevisionID)
        {



            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@Year", objPlanBatch.Year),
                new SqlParameter("@Month", objPlanBatch.Month),
                new SqlParameter("@RevisionID", objPlanBatch.RevisionID),
                new SqlParameter("@ProductCode", objPlanBatch.ProductCode),
                new SqlParameter("@WeekID", objPlanBatch.WeekID),
                new SqlParameter("@BatchSize", objPlanBatch.BatchSize),
                new SqlParameter("@Nos", objPlanBatch.Nos),
                new SqlParameter("@Original_RevisionID", objPlanBatch.RevisionID)};



                return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_PlanBatch", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }



        public int Delete(int Year, string Month,int WeekID, int RevisionID, string ProductCode)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@Year",Year),
                new SqlParameter("@Month",Month),
                new SqlParameter("@WeekID",WeekID),
                new SqlParameter("@RevisionID",RevisionID),
                new SqlParameter("@ProductCode",ProductCode)};


                return Execute.RunSP_RowsEffected(Connection, "SPDELETE_PlanBatch", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }


        public DataTable Get(int Year,string Month,int WeekID,int RevisionID)
        {


            try
            {
                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@Year",Year),
                new SqlParameter("@Month",Month),
                new SqlParameter("@RevisionID",RevisionID),
                new SqlParameter("@WeekID",WeekID)};


                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_PlanBatch_ByWeek",paramList);

                return dt;


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }

        }



      //public PlanBatchCollec Get()
      //  {


      //      try
      //      {

      //         DataTable dt=  Execute.RunSP_DataTable(Connection, "SPGET_PlanBatch");

      //         PlanBatchCollec objPlanBatchCollec = new PlanBatchCollec();


      //         for (int i = 0; i < dt.Rows.Count;i++ )
      //         {

      //             PlanBatch objPlanBatch = new PlanBatch();
      //             objPlanBatch.Year = Convert.ToInt32(dt.Rows[i]["Year"]);
      //             objPlanBatch.Month = Convert.ToString(dt.Rows[i]["Month"]);
      //             objPlanBatch.RevisionID = Convert.ToInt32(dt.Rows[i]["RevisionID"]);
      //             objPlanBatch.ProductCode = Convert.ToString(dt.Rows[i]["ProductCode"]);
      //             objPlanBatch.WeekID = Convert.ToInt32(dt.Rows[i]["WeekID"]);
      //             objPlanBatch.BatchSize = Convert.ToDecimal(dt.Rows[i]["BatchSize"]);
      //             objPlanBatch.Nos = Convert.ToInt32(dt.Rows[i]["Nos"]);


      //             objPlanBatchCollec.Add(objPlanBatch);
      //         }
      //         return objPlanBatchCollec;


      //      }
      //      catch (Exception ex)
      //      {

      //          throw new Exception(ex.Message, ex);
      //      }

      //  }

    }
}
