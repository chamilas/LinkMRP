using System;
using System.Collections.Generic;
using System.Text;
using SESD.MRP.REF;
using System.Data.SqlTypes;
using System.Data;
using System.Data.SqlClient;

namespace DL
{

    public class Activity_DL
    {
       SqlConnection Connection = new SqlConnection();


        public Activity_DL(SqlConnection Conn)
        {
            Connection = Conn;
        }

        public long Add(Activity obj)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@ActMainActID", obj.ActMainActivity.MainActID),
                new SqlParameter("@ActBatchID", obj.ActSTDBatch.STDBatchID),
                new SqlParameter("@ActDuration", obj.ActDuration),
                new SqlParameter("@ActManHours", obj.ActManHours),
                new SqlParameter("@ActCost", obj.ActCost),
                new SqlParameter("@SequenceNo", obj.SequenceNo),
                new SqlParameter("@Part", obj.Part),
                new SqlParameter("@InstructedBy", obj.InstructedBy),
                new SqlParameter("@BlockNextActivity", obj.BlockNextActivity),
                new SqlParameter("@outParam",SqlDbType.Int,120){Direction=ParameterDirection.Output}    
        };

                return Execute.RunSP_Output(Connection, "SPADD_Activity", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public int Delete(Activity obj)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@ActID", obj.ActivityID)    
        };

                return Execute.RunSP_Output(Connection, "SPDELETE_Activity", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public int Update(Activity obj)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@ActMainActID", obj.ActMainActivity.MainActID),
                new SqlParameter("@ActBatchID", obj.ActSTDBatch.STDBatchID),
                new SqlParameter("@ActDuration", obj.ActDuration),
                new SqlParameter("@ActManHours", obj.ActManHours),
                new SqlParameter("@ActCost", obj.ActCost),
                new SqlParameter("@ActID", obj.ActivityID),
                 new SqlParameter("@SequenceNo", obj.SequenceNo),
                new SqlParameter("@Part", obj.Part),
                new SqlParameter("@InstructedBy", obj.InstructedBy),
                new SqlParameter("@LastEdited", obj.LastEdited),
                new SqlParameter("@BlockNextActivity", obj.BlockNextActivity)

        };

                return Execute.RunSP_Output(Connection, "SPUPDATE_Activity", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }




        public Activity Get(long ActID)
        {
            
            STDBatch_DL objBatchDL = new STDBatch_DL(Connection);
            MainActivity_DL objMainActDL = new MainActivity_DL(Connection);
            Activity objActivity = new Activity();
            
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@ActID",ActID)};


                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_Activity_By_ID", paramList);

                Activity obj = new Activity();

                if (dt.Rows[0]["ActID"] != null)
                {
                    obj.ActivityID = Convert.ToInt64(dt.Rows[0]["ActID"]);
                }

                if (dt.Rows[0]["ActMainActID"] != null)
                {
                    obj.ActMainActivity =objMainActDL.Get( Convert.ToInt64(dt.Rows[0]["ActMainActID"]));
                }

                if (dt.Rows[0]["ActSTDBatchID"] != null)
                {
                    obj.ActSTDBatch =objBatchDL.Get((Convert.ToString(dt.Rows[0]["ActSTDBatchID"])));
                }

                
                    obj.ActDuration =Convert.ToDecimal(dt.Rows[0]["ActDuration"]);
                obj.ActManHours =Convert.ToDecimal(dt.Rows[0]["ActManHours"]);

                obj.ActCost = Convert.ToDecimal(dt.Rows[0]["ActCost"]);

                obj.SequenceNo = Convert.ToInt32(dt.Rows[0]["SequenceNo"]);
                obj.Part = Convert.ToString(dt.Rows[0]["Part"]);
                obj.InstructedBy = Convert.ToString(dt.Rows[0]["InstructedBy"]);
                obj.LastEdited = Convert.ToDateTime(dt.Rows[0]["LastEdited"]);
                obj.BlockNextActivity = Convert.ToBoolean(dt.Rows[0]["BlockNextActivity"]);

                return obj;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }


        public ActivityCollec Get_STDBatch(string STDBatchID)
        {
            ActivityCollec objActivityCollec = new ActivityCollec();
            STDBatch_DL objBatchDL = new STDBatch_DL(Connection);
            MainActivity_DL objMainActDL = new MainActivity_DL(Connection);

            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@ActSTDBatchID",STDBatchID)};


                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_Activity_By_STDBatchID", paramList);

                

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Activity obj = new Activity();

                    if (dt.Rows[i]["ActID"] != null)
                    {
                        obj.ActivityID = Convert.ToInt64(dt.Rows[i]["ActID"]);
                    }

                    if (dt.Rows[i]["ActMainActID"] != null)
                    {
                        obj.ActMainActivity = objMainActDL.Get(Convert.ToInt64(dt.Rows[i]["ActMainActID"]));
                    }

                    if (dt.Rows[i]["ActSTDBatchID"] != null)
                    {
                        obj.ActSTDBatch = objBatchDL.Get((Convert.ToString(dt.Rows[i]["ActSTDBatchID"])));
                    }


                    obj.ActDuration = Convert.ToDecimal(dt.Rows[i]["ActDuration"]);
                    obj.ActManHours = Convert.ToDecimal(dt.Rows[i]["ActManHours"]);

                    obj.ActCost = Convert.ToDecimal(dt.Rows[i]["ActCost"]);

                    obj.SequenceNo = Convert.ToInt32(dt.Rows[i]["SequenceNo"]);
                    obj.Part = Convert.ToString(dt.Rows[i]["Part"]);
                    obj.InstructedBy = Convert.ToString(dt.Rows[i]["InstructedBy"]);
                    obj.LastEdited = Convert.ToDateTime(dt.Rows[i]["LastEdited"]);
                    obj.BlockNextActivity = Convert.ToBoolean(dt.Rows[i]["BlockNextActivity"]);


                    objActivityCollec.Add(obj);
                }
                return objActivityCollec;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }


        public Activity Get(long STDBatchActID,long MainAct)
        {
            STDBatch_DL objBatchDL = new STDBatch_DL(Connection);
            MainActivity_DL objMainActDL = new MainActivity_DL(Connection);
            Activity objActivity = new Activity();

            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                new SqlParameter("@ActSTDBatchID",STDBatchActID),
                new SqlParameter("@ActMainActID",MainAct)};


                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_Activity_By_STDBatchID_MainActID", paramList);

                Activity obj = new Activity();

                if (dt.Rows[0]["ActID"] != null)
                {
                    obj.ActivityID = Convert.ToInt64(dt.Rows[0]["ActID"]);
                }

                if (dt.Rows[0]["ActMainActID"] != null)
                {
                    obj.ActMainActivity = objMainActDL.Get(Convert.ToInt64(dt.Rows[0]["ActMainActID"]));
                }

                if (dt.Rows[0]["ActSTDBatchID"] != null)
                {
                    obj.ActSTDBatch = objBatchDL.Get((Convert.ToString(dt.Rows[0]["ActSTDBatchID"])));
                }


                obj.ActDuration = Convert.ToDecimal(dt.Rows[0]["ActDuration"]);
                obj.ActManHours = Convert.ToDecimal(dt.Rows[0]["ActManHours"]);

                obj.ActCost = Convert.ToDecimal(dt.Rows[0]["ActCost"]);

                obj.SequenceNo = Convert.ToInt32(dt.Rows[0]["SequenceNo"]);
                obj.Part = Convert.ToString(dt.Rows[0]["Part"]);
                obj.InstructedBy = Convert.ToString(dt.Rows[0]["InstructedBy"]);
                obj.LastEdited = Convert.ToDateTime(dt.Rows[0]["LastEdited"]);
                obj.BlockNextActivity = Convert.ToBoolean(dt.Rows[0]["BlockNextActivity"]);

                return obj;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        


        public DataTable Get_DataView(string STDBatchID)
        {
            ActivityCollec objActivityCollec = new ActivityCollec();
            STDBatch_DL objBatchDL = new STDBatch_DL(Connection);
            MainActivity_DL objMainActDL = new MainActivity_DL(Connection);

            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@ActSTDBatchID",STDBatchID)};


                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_Activity_By_STDBatchID", paramList);


                return dt;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }
    }
}
