using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using DL;
using SESD.MRP.REF;
using System.Data;

namespace DL
{
    public class RPDActivityDetailsLabour_DL
    {
        SqlConnection Connection = new SqlConnection();

        public RPDActivityDetailsLabour_DL(SqlConnection conn)
        {
            Connection = conn;
        }

        public long Add(RPDActivityDetailsLabour obj)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@ActivityDetailsLabourID", obj.ActivityDetailsLabourID),
                new SqlParameter("@BatchActID",obj.BatchActID),
                new SqlParameter("@Description", obj.Description),
                new SqlParameter("@Helper", obj.Helper),
                new SqlParameter("@StartTime", obj.StartTime),
                new SqlParameter("@StopTime", obj.StopTime),
                new SqlParameter("@OTHours", obj.OTHours),
                new SqlParameter("@outParam",SqlDbType.Int){Direction=ParameterDirection.Output}};

                return Execute.RunSP_Output(Connection, "SPADD_RPDActivityDetailsLabour_Update", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }

        }

        public RPDActivityDetailsLabour Get(long ID)
        {

            try
            {
                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@ActivityDetailsLabourID",ID)};


                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_RPDActivityDetailsLabour_ID", paramList);

                RPDActivityDetailsLabour obj = new RPDActivityDetailsLabour();

                if (dt.Rows.Count > 0)
                {

                    obj.ActivityDetailsLabourID = Convert.ToInt64(dt.Rows[0]["ActivityDetailsLabourID"]);
                    obj.BatchActID = Convert.ToInt64(dt.Rows[0]["BatchActID"]);
                    obj.Description = Convert.ToString(dt.Rows[0]["Description"]);
                    obj.Helper = Convert.ToString(dt.Rows[0]["Helper"]);
                    obj.StartTime_D = Convert.ToDateTime(dt.Rows[0]["StartTime"]);
                    obj.StopTime_D = Convert.ToDateTime(dt.Rows[0]["StopTime"]);
                    obj.OTHours = Convert.ToDecimal(dt.Rows[0]["OTHours"]);
                    obj.HourlyRate = Convert.ToDecimal(dt.Rows[0]["HourlyRate"]);
                    obj.OTRate = Convert.ToDecimal(dt.Rows[0]["OTRate"]);

                }

                return obj;


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public RPDActivityDetailsLabourCollec Get_By_BatchAct(long ID)
       {

           try
           {
               SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@BatchActID",ID)};

               DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_RPDActivityDetailsLabour_BatchActID", paramList);

               RPDActivityDetailsLabourCollec objCollec = new RPDActivityDetailsLabourCollec();
               RPDActivityDetailsLabour obj = new RPDActivityDetailsLabour();

               if (dt.Rows.Count > 0)
               {
                   for (int i = 0; i < dt.Rows.Count; i++)
                   {


                       obj.ActivityDetailsLabourID = Convert.ToInt64(dt.Rows[i]["ActivityDetailsLabourID"]);
                       obj.BatchActID = Convert.ToInt64(dt.Rows[i]["BatchActID"]);
                       obj.Description = Convert.ToString(dt.Rows[i]["Description"]);
                       obj.Helper = Convert.ToString(dt.Rows[i]["Helper"]);
                       obj.StartTime_D = Convert.ToDateTime(dt.Rows[i]["StartTime"]);
                       obj.StopTime_D = Convert.ToDateTime(dt.Rows[i]["StopTime"]);
                       obj.OTHours = Convert.ToDecimal(dt.Rows[i]["OTHours"]);
                       obj.HourlyRate = Convert.ToDecimal(dt.Rows[i]["HourlyRate"]);
                       obj.OTRate = Convert.ToDecimal(dt.Rows[i]["OTRate"]);


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


        public DataTable GetData_By_BatchAct(long ID)
        {

            try
            {
                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@BatchActID",ID)};

                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_RPDActivityDetailsLabour_BatchActID", paramList);

                return dt;


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }



        public RPDActivityDetailsLabourCollec Get_All()
        {

            try
            {

                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_RPDActivityDetailsLabour");

                RPDActivityDetailsLabourCollec objCollec = new RPDActivityDetailsLabourCollec();
                RPDActivityDetailsLabour obj = new RPDActivityDetailsLabour();

                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {


                        obj.ActivityDetailsLabourID = Convert.ToInt64(dt.Rows[i]["ActivityDetailsLabourID"]);
                        obj.BatchActID = Convert.ToInt64(dt.Rows[i]["BatchActID"]);
                        obj.Description = Convert.ToString(dt.Rows[i]["Description"]);
                        obj.Helper = Convert.ToString(dt.Rows[i]["Helper"]);
                        obj.StartTime_D = Convert.ToDateTime(dt.Rows[i]["StartTime"]);
                        obj.StopTime_D = Convert.ToDateTime(dt.Rows[i]["StopTime"]);
                        obj.OTHours = Convert.ToDecimal(dt.Rows[i]["OTHours"]);
                        obj.HourlyRate = Convert.ToDecimal(dt.Rows[i]["HourlyRate"]);
                        obj.OTRate = Convert.ToDecimal(dt.Rows[i]["OTRate"]);


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

        public int Delete(long ID)
        {

            try
            {
                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@Original_ActivityDetailsLabourID", ID)};

                return Execute.RunSP_RowsEffected(Connection, "SPDELETE_RPDActivityDetailsLabour", paramList);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }

        }

        public int GetNotFinishedCount(long BatchActivityDetailsID)
        {

            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
               
                new SqlParameter("@BatchActID", BatchActivityDetailsID)};

                return Execute.RunSP_RowsEffected(Connection, "SPGET_RPDActivityDetailsLabour_Count_NotFinished", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public DataTable Get()
        {
            try
            {


                return Execute.RunSP_DataTable(Connection, "SPGET_RPDActivityDetailsLabour");

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public DataTable Get_By_BatchAct_View(long ID)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@BatchActID",ID)
                };


                return Execute.RunSP_DataTable(Connection, "SPGET_RPDActivityDetailsLabour_BatchActID", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }


    }
}