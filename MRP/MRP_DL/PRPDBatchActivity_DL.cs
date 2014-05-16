using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Sql;
using System.Data.SqlClient;
using SESD.MRP.REF;
using System.Data;

namespace DL
{
    public class PRPDBatchActivity_DL
    {

        SqlConnection Connection = new SqlConnection();

        public PRPDBatchActivity_DL(SqlConnection Conn)
        {
            Connection = Conn;
        }

        Employee_DL objEmployee_DL = new Employee_DL(ConnectionStringClass.GetConnection());

        public int Add(PRPDBatchActivity obj)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@PRPDBatchID", obj.PRPDBatchID),
                new SqlParameter("@MainActID", obj.MainActID),
                new SqlParameter("@ActStatus", obj.State),
                new SqlParameter("@StartedDate", obj.StartedDate),
                new SqlParameter("@PRPDBatchActivityID", obj.PRPDBatchActivityID),
                new SqlParameter("@StartQty", obj.StartQty),
                new SqlParameter("@StopQty", obj.StopQty)};

                return Execute.RunSP_RowsEffected(Connection, "SPADD_PRPDBatchActivity", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }


        }

        public long Add_Initial(PRPDBatchActivity obj)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@PRPDBatchID", obj.PRPDBatchID),
                new SqlParameter("@MainActID", obj.MainActID),
                new SqlParameter("@ActStatus", obj.State),
                new SqlParameter("@Comments", obj.Comments),
                 new SqlParameter("@StartQty", obj.StartQty),
                new SqlParameter("@SupervisedBy", obj.SupervisedBy.EmployeeID),
                new SqlParameter("@outParam",SqlDbType.Int){Direction=ParameterDirection.Output}};

                return Execute.RunSP_RowsEffected(Connection, "SPADD_PRPDBatchActivity_Initial", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }


        }

        public int Update_Initial(PRPDBatchActivity obj, long Original_PRPDBatchActivity)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@EndDate", obj.EndDate),
                new SqlParameter("@Comments", obj.Comments),
                new SqlParameter("@ActStatus", obj.State),
                new SqlParameter("@PRPDBatchActivity", obj.PRPDBatchActivityID)};

                return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_PRPDBatchActivity_Initial", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }


        }

        public int Update(PRPDBatchActivity obj)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@EndDate", obj.EndDate),
                new SqlParameter("@StopQty", obj.StopQty),
                new SqlParameter("@ActStatus", obj.State),
                new SqlParameter("@PRPDBatchActivity", obj.PRPDBatchActivityID)};

                return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_PRPDBatchActivity", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }


        }

        public int Delete(long PRPDBatchActivity)
        {

            try
            {
                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@Original_PRPDBatchActivity",PRPDBatchActivity)};

                return Execute.RunSP_RowsEffected(Connection, "SPDELETE_PRPDBatchActivity", paramList);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }

        }

        public int ActivityCount(String PRPDBatchID, PRPDBatchActivity.ActStatus Status)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@PRPDBatchID" , PRPDBatchID),
                new SqlParameter("@ActStatus" , Status),
                new SqlParameter("@outParam",SqlDbType.Int){Direction=ParameterDirection.Output}};

                return Execute.RunSP_Output(Connection, "SPGET_PRPDBatchActivity_Count_By_BatchID", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public String GetMaxID()
        {
            return "";
        }

        public System.Data.DataTable GetDataByID(long PRPDBatchActivityID)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@PRPDBatchActivity", PRPDBatchActivityID)};

                return Execute.RunSP_DataTable(Connection, "SPGET_PRPDBatchActivityByID", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }

        }

        public System.Data.DataTable GetData()
        {
            try
            {

                return Execute.RunSP_DataTable(Connection, "SPGET_PRPDBatchActivity");

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }

        }

        public System.Data.DataTable GetDataByBatchID(string PRPDBatchID)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@PRPDBatchID", PRPDBatchID)};

                return Execute.RunSP_DataTable(Connection, "SPGET_PRPDBatchActivityByBatchID", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }

        }

        public int GetBy_BatchActivity_Count(string PRPDBatchID, long ActID, PRPDBatchActivity.ActStatus ActStatus)
        {

            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
               
                new SqlParameter("@ActStatus" , ActStatus),
                new SqlParameter("@ActID" , ActID),
                new SqlParameter("@PRPDBatchID" , PRPDBatchID),
                
                };

                return Execute.RunSP_Output(Connection, "SPGET_PRPDBatchActivityByActStatus_Count", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public System.Data.DataTable GetDataByStatus(string PRPDBatchID, long ActID, PRPDBatchActivity.ActStatus ActStatus)
        {


            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@ActStatus", ActStatus),
                new SqlParameter("@MainActID" , ActID),
                new SqlParameter("@PRPDBatchID", PRPDBatchID)};

                return Execute.RunSP_DataTable(Connection, "SPGET_PRPDBatchActivityByStatus", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }

        }

        public PRPDBatchActivity Get(long PRPDBatchActivityID)
        {

            try
            {
                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@PRPDBatchActivity" , PRPDBatchActivityID)};


                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_PRPDBatchActivityByID", paramList);

                PRPDBatchActivity obj = new PRPDBatchActivity();

                if (dt.Rows.Count > 0)
                {

                    obj.PRPDBatchActivityID = Convert.ToInt64(dt.Rows[0]["PRPDBatchActivity"]);
                    obj.PRPDBatchID = Convert.ToString(dt.Rows[0]["PRPDBatchID"]);
                    obj.MainActID = Convert.ToInt64(dt.Rows[0]["MainActID"]);
                    obj.StartedDate = Convert.ToDateTime(dt.Rows[0]["StartedDate"]);
                    if (dt.Rows[0]["EndDate"] != DBNull.Value)
                    {
                        obj.EndDate = Convert.ToDateTime(dt.Rows[0]["EndDate"]);
                    }
                    obj.SupervisedBy = objEmployee_DL.Get(Convert.ToString(dt.Rows[0]["SupervisedBy"]));
                    obj.Comments = Convert.ToString(dt.Rows[0]["Comments"]);
                    obj.State = (PRPDBatchActivity.ActStatus)Enum.Parse(typeof(PRPDBatchActivity.ActStatus), Convert.ToString(dt.Rows[0]["ActStatus"]));
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

        public PRPDBatchActivity Get(string PRPDBatchID, long MainActID, PRPDBatchActivity.ActStatus ActState)
        {

            try
            {
                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@ActStatus" , ActState),
                new SqlParameter("@MainActID" , MainActID),
                new SqlParameter("@PRPDBatchID" , PRPDBatchID)};


                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_PRPDBatchActivityByStatus", paramList);

                PRPDBatchActivity obj = new PRPDBatchActivity();

                if (dt.Rows.Count > 0)
                {

                    obj.PRPDBatchActivityID = Convert.ToInt64(dt.Rows[0]["PRPDBatchActivity"]);
                    obj.PRPDBatchID = Convert.ToString(dt.Rows[0]["PRPDBatchID"]);
                    obj.MainActID = Convert.ToInt64(dt.Rows[0]["MainActID"]);
                    obj.StartedDate = Convert.ToDateTime(dt.Rows[0]["StartedDate"]);
                    if (dt.Rows[0]["EndDate"] != DBNull.Value)
                    {
                        obj.EndDate = Convert.ToDateTime(dt.Rows[0]["EndDate"]);
                    }
                    obj.SupervisedBy = objEmployee_DL.Get(Convert.ToString(dt.Rows[0]["SupervisedBy"]));
                    obj.Comments = Convert.ToString(dt.Rows[0]["Comments"]);
                    obj.State = (PRPDBatchActivity.ActStatus)Enum.Parse(typeof(PRPDBatchActivity.ActStatus), Convert.ToString(dt.Rows[0]["ActStatus"]));
                    obj.SectionOverHeadRate = Convert.ToDecimal(dt.Rows[0]["SectionOverHeadRate"]);
                    obj.StartQty = Convert.ToDecimal(dt.Rows[0]["@StartQty"]);
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

        public DataTable GetView()
        {
            try
            {

                return Execute.RunSP_DataTable(Connection, "SPGET_PRPDBatchActivity_View");

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }

        }

        public DataTable GetView(String PRPDBatchID)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@PRPDBatchID", PRPDBatchID)};

                return Execute.RunSP_DataTable(Connection, "SPGET_PRPDBatchActivity_View_By_PRPDBatch", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }

        }

        public int GetNotFinishedCount(int BatchActID)
        {

            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
               
                new SqlParameter("@PRPDBatchBatchActID" , BatchActID),
                new SqlParameter("@outParam",SqlDbType.Int){Direction=ParameterDirection.Output}
                };

                return Execute.RunSP_Output(Connection, "SPGET_PRPDBatchActivity_Count_By_Status", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

    }
}
