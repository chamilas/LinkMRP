using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using DL;
using SESD.MRP.REF;
using System.Data;

namespace DL
{
    public class RPDActivityDetailsMachine_DL
    {
        SqlConnection Connection = new SqlConnection();

        public RPDActivityDetailsMachine_DL(SqlConnection conn)
        {
            Connection = conn;
        }

        public long Add(RPDActivityDetailsMachine obj)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@BatchActID",obj.BatchActID),
                new SqlParameter("@Description", obj.Description),
                new SqlParameter("@MachineCode", obj.MachineCode),
                new SqlParameter("@MeshSize", obj.MeshSize),
                new SqlParameter("@StartTime", obj.StartTime),
                new SqlParameter("@StopTime", obj.StopTime),
                new SqlParameter("@outParam", obj.ActivityDetailsMachineID)};

                return Execute.RunSP_Output(Connection, "SPADD_RPDActivityDetailsMachine", paramList);

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

                return Execute.RunSP_RowsEffected(Connection, "SPGET_RPDActivityDetailsMachine_Count_NotFinished", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public RPDActivityDetailsMachine Get(long ID)
        {

            try
            {
                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@ActivityDetailsMachineID",ID)};


                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_RPDActivityDetailsMachine_By_ID", paramList);

                RPDActivityDetailsMachine obj = new RPDActivityDetailsMachine();

                if (dt.Rows.Count > 0)
                {

                    obj.ActivityDetailsMachineID = Convert.ToInt64(dt.Rows[0]["ActivityDetailsMachineID"]);
                    obj.BatchActID = Convert.ToInt64(dt.Rows[0]["BatchActID"]);
                    obj.Description = Convert.ToString(dt.Rows[0]["Description"]);
                    obj.MachineCode = Convert.ToString(dt.Rows[0]["MachineCode"]);
                    obj.MeshSize = Convert.ToString(dt.Rows[0]["MeshSize"]);
                    obj.StartTime_D= Convert.ToDateTime(dt.Rows[0]["StartTime"]);
                    obj.StopTime_D = Convert.ToDateTime(dt.Rows[0]["StopTime"]);
                    obj.HourlyRate = Convert.ToDecimal(dt.Rows[0]["HourlyRate"]);

                }

                return obj;


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

                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_RPDActivityDetailsMachine_By_BatchActID", paramList);


                return dt;


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public RPDActivityDetailsMachineCollec Get_By_BatchActID(long ID)
        {

            try
            {
                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@BatchActID",ID)};

                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_RPDActivityDetailsMachine_By_BatchActID", paramList);

                RPDActivityDetailsMachineCollec objCollec = new RPDActivityDetailsMachineCollec();
                RPDActivityDetailsMachine obj = new RPDActivityDetailsMachine();

                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        obj.ActivityDetailsMachineID = Convert.ToInt64(dt.Rows[i]["ActivityDetailsMachineID"]);
                        obj.BatchActID = Convert.ToInt64(dt.Rows[i]["BatchActID"]);
                        obj.Description = Convert.ToString(dt.Rows[i]["Description"]);
                        obj.MachineCode = Convert.ToString(dt.Rows[i]["MachineCode"]);
                        obj.MeshSize = Convert.ToString(dt.Rows[i]["MeshSize"]);
                        obj.StartTime_D = Convert.ToDateTime(dt.Rows[i]["StartTime"]);
                        obj.StopTime_D = Convert.ToDateTime(dt.Rows[i]["StopTime"]);
                        obj.HourlyRate = Convert.ToDecimal(dt.Rows[i]["HourlyRate"]);

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


                return Execute.RunSP_DataTable(Connection, "SPGET_RPDActivityDetailsMachine");

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public DataTable Get_By_BatchActDetails_View(long BatchActDetailsID)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@BatchActID",BatchActDetailsID)
                };


                return Execute.RunSP_DataTable(Connection, "SPGET_RPDActivityDetailsMachine_By_BatchActID", paramList);

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
                
                new SqlParameter("@Original_ActivityDetailsMachineID", ID)};

                return Execute.RunSP_RowsEffected(Connection, "SPDELETE_RPDActivityDetailsMachine", paramList);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }

        }


    }
}
