using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Data.SqlClient;
using SESD.MRP.REF;
using System.Data;

namespace DL
{
    public class RPDBatchActivity_DL
    {

        SqlConnection Connection = new SqlConnection();

        public RPDBatchActivity_DL(SqlConnection Conn)
        {
            Connection = Conn;
        }

        public long Add(RPDBatchActivity obj)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                new SqlParameter("@RPDBatchID", obj.RPDBatchID),
                new SqlParameter("@MainActID",obj.MainActID),
                new SqlParameter("@Comments", obj.Comments),
                new SqlParameter("@ActivityStatus", obj.ActivityStatus),
                new SqlParameter("@SupervisedBy", obj.SupervisedBy),
                new SqlParameter("@StartQty", obj.StartQty),
                new SqlParameter("@outParam",SqlDbType.Int){Direction=ParameterDirection.Output}};

                return Execute.RunSP_Output(Connection, "SPADD_RPDBatchActivity", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }

        }

           public long Update(RPDBatchActivity obj)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                new SqlParameter("@RPDBatchActID" , obj.RPDBatchActID ),
                new SqlParameter("@ActivityStatus", obj.ActivityStatus),
                new SqlParameter("@StopDate", obj.StopDate),
                new SqlParameter("@StopQty", obj.StopQty)};

                return Execute.RunSP_RowsEffected(Connection, "SPADD_RPDBatchActivity_Update", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }

        }

        


        public RPDBatchActivity Get(long ID)
        {

            try
            {
                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@RPDBatchActID",ID)};


                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_RPDBatchActivity_By_ID", paramList);

                RPDBatchActivity obj = new RPDBatchActivity();

                if (dt.Rows.Count > 0)
                {

                    obj.RPDBatchActID = Convert.ToInt64(dt.Rows[0]["RPDBatchActID"]);
                    obj.RPDBatchID = Convert.ToString(dt.Rows[0]["RPDBatchID"]);
                    obj.MainActID = Convert.ToInt64(dt.Rows[0]["MainActID"]);
                    obj.Comments = Convert.ToString(dt.Rows[0]["Comments"]);
                    obj.ActivityStatus = ( RPDBatchActivity.Status) Enum.Parse(typeof(RPDBatchActivity.Status),Convert.ToString(dt.Rows[0]["ActivityStatus"]));
                    obj.StartDate = Convert.ToDateTime(dt.Rows[0]["StartDate"]);
                    if (dt.Rows[0]["StopDate"] != DBNull.Value)
                    {
                        obj.StopDate = Convert.ToDateTime(dt.Rows[0]["StopDate"]);
                    }
                    obj.SupervisedBy = Convert.ToString(dt.Rows[0]["SupervisedBy"]);
                    obj.SectionOverHeadRate = Convert.ToDecimal(dt.Rows[0]["SectionOverHeadRate"]);

                    obj.StartQty = Convert.ToDecimal(dt.Rows[0]["StartQty"]);
                    if (dt.Rows[0]["StopQty"] != DBNull.Value)
                    {
                        obj.StopQty = Convert.ToDecimal(dt.Rows[0]["StopQty"]);
                    }

                }

                return obj;


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public RPDBatchActivity Get(String MainActivity,String RPDBatchID)
        {

            try
            {
                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@RPDBatchID",RPDBatchID),
                new SqlParameter("@MainActivity",MainActivity)};


                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_RPDBatchActivity_By_MainActivity", paramList);

                RPDBatchActivity obj = new RPDBatchActivity();

                if (dt.Rows.Count > 0)
                {

                    obj.RPDBatchActID = Convert.ToInt64(dt.Rows[0]["RPDBatchActID"]);
                    obj.RPDBatchID = Convert.ToString(dt.Rows[0]["RPDBatchID"]);
                    obj.MainActID = Convert.ToInt64(dt.Rows[0]["MainActID"]);
                    obj.Comments = Convert.ToString(dt.Rows[0]["Comments"]);
                    obj.ActivityStatus = (RPDBatchActivity.Status)Enum.Parse(typeof(RPDBatchActivity.Status), Convert.ToString(dt.Rows[0]["ActivityStatus"]));
                    obj.StartDate = Convert.ToDateTime(dt.Rows[0]["StartDate"]);
                    if (dt.Rows[0]["StopDate"] != DBNull.Value)
                    {
                        obj.StopDate = Convert.ToDateTime(dt.Rows[0]["StopDate"]);
                    }
                    obj.SupervisedBy = Convert.ToString(dt.Rows[0]["SupervisedBy"]);
                    obj.SectionOverHeadRate = Convert.ToDecimal(dt.Rows[0]["SectionOverHeadRate"]);

                    obj.StartQty = Convert.ToDecimal(dt.Rows[0]["StartQty"]);
                    if (dt.Rows[0]["StopQty"] != DBNull.Value)
                    {
                        obj.StopQty = Convert.ToDecimal(dt.Rows[0]["StopQty"]);
                    }
                }

                return obj;


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public RPDBatchActivityCollec Get_By_RPDBatchID(long RPDBatchID)
        {

            try
            {
                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@RPDBatchID",RPDBatchID)};


                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_RPDBatchActivity_RPDBatchID", paramList);

                RPDBatchActivityCollec objCollec = new RPDBatchActivityCollec();
                RPDBatchActivity obj = new RPDBatchActivity();


                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {

                        obj.RPDBatchActID = Convert.ToInt64(dt.Rows[i]["RPDBatchActID"]);
                        obj.RPDBatchID = Convert.ToString(dt.Rows[i]["RPDBatchID"]);
                        obj.MainActID = Convert.ToInt64(dt.Rows[i]["MainActID"]);
                        obj.Comments = Convert.ToString(dt.Rows[i]["Comments"]);
                        obj.ActivityStatus = (RPDBatchActivity.Status)Enum.Parse(typeof(RPDBatchActivity.Status), Convert.ToString(dt.Rows[i]["ActivityStatus"]));
                        obj.StartDate = Convert.ToDateTime(dt.Rows[i]["StartDate"]);
                        obj.StopDate = Convert.ToDateTime(dt.Rows[i]["StopDate"]);
                        obj.SupervisedBy = Convert.ToString(dt.Rows[i]["SupervisedBy"]);
                        obj.SectionOverHeadRate = Convert.ToDecimal(dt.Rows[i]["SectionOverHeadRate"]);

                        obj.StartQty = Convert.ToDecimal(dt.Rows[i]["StartQty"]);
                        obj.StopQty = Convert.ToDecimal(dt.Rows[i]["StopQty"]);

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

        public DataTable Get()
        {
            try
            {


                return Execute.RunSP_DataTable(Connection, "SPGET_RPDBatchActivity");

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public DataTable Get_By_RPDBatch(long RPDBatchID)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@RPDBatchID",RPDBatchID)
                };


                return Execute.RunSP_DataTable(Connection, "SPGET_RPDBatchActivity_RPDBatchID", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public DataTable GetDataView()
        {
            try
            {


                return Execute.RunSP_DataTable(Connection, "SPGET_RPDBatchActivity_View");

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public DataTable GetDataView(String RPDBatchID)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@RPDBatchID",RPDBatchID)
                };


                return Execute.RunSP_DataTable(Connection, "SPGET_RPDBatchActivity_View_By_RPDBatchID", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public DataTable GetActivityCount_ByStatus(String RPDBatchID,int Status1,int Status2)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@RPDBatchID",RPDBatchID),
                new SqlParameter("@Status1",Status1),
                new SqlParameter("@Status2",Status2)
                };


                return Execute.RunSP_DataTable(Connection, "SPGET_RPDBatchActivity_Count_ByStatus", paramList);

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
                
                new SqlParameter("@Original_RPDBatchActID" , ID)};

                return Execute.RunSP_RowsEffected(Connection, "SPDELETE_RPDBatchActivity", paramList);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }

        }
	
    }

}
