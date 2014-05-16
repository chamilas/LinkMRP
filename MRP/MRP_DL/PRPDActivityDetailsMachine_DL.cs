using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data.Sql;
using SESD.MRP.REF;
using System.Data;

namespace DL
{
   public class PRPDActivityDetailsMachine_DL

   {
        SqlConnection Connection = new SqlConnection();
       

       public PRPDActivityDetailsMachine_DL(SqlConnection Conn)
       {
           Connection = Conn;
       }


        public int Add(PRPDActivityDetailsMachine obj)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@BatchActID" , obj.PRPDBatchActDetailsID),
                new SqlParameter("@MachineCode" , obj.MachineCode),
                new SqlParameter("@MeshSize", obj.MeshSize),
                new SqlParameter("@StartTime", obj.StartTime),
                new SqlParameter("@StopTime", obj.StopTime),
                new SqlParameter("@Remarks", obj.Remarks)};

                return Execute.RunSP_Int(Connection, "SPADD_PRPDActivityDetailsMachine", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }

        }


       public int Update(PRPDActivityDetailsMachine obj, long Original_ActivityDetailsMachineID)
        {

            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@BatchActID", obj.PRPDBatchActDetailsID),
                new SqlParameter("@MachineCode",obj.MachineCode),
                new SqlParameter("@MeshSize", obj.MeshSize),
                new SqlParameter("@StartTime", obj.StartTime),
                new SqlParameter("@StopTime", obj.StopTime),
                new SqlParameter("@Remarks", obj.Remarks),
                new SqlParameter("@Original_ActivityDetailsMachineID",obj.ActivityDetailsMachineID)};

                return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_PRPDActivityDetailsMachine", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }

        }


       public int Delete(long ActivityDetailsMachineID)
       {

           try
           {
               SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@Original_ActivityDetailsMachineID", ActivityDetailsMachineID)};

               return Execute.RunSP_RowsEffected(Connection, "SPDELETE_PRPDActivityDetailsMachine", paramList);
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


       public System.Data.DataTable GetDataByID(long ActivityDetailsMachineID)
        {

            try
            {
                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@ActivityDetailsMachineID" , ActivityDetailsMachineID)};

                return Execute.RunSP_DataTable(Connection, "SPGET_PRPDActivityMachineByID", paramList);
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
                
                new SqlParameter("@BatchActID" , ActivityID)};

               return Execute.RunSP_Output(Connection, "SPGET_PRPDActivityDetailsMachine_Count_NotFinished", paramList);

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
                
                new SqlParameter("@PRPDBatchID" , PRPDBatchID)};

                return Execute.RunSP_DataTable(Connection, "SPGET_PRPDActivityDetailsMachine_Full_BatchByID", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }

        }


       public System.Data.DataTable GetDataView(long PRPDBatchActDetailsID)
       {


           try
           {


               SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@ActivityDetailsMachineID" , PRPDBatchActDetailsID)};

               return Execute.RunSP_DataTable(Connection, "SPGET_PRPDActivityDetailsMachine_By_DetailID", paramList);

           }
           catch (Exception ex)
           {

               throw new Exception(ex.Message, ex);
           }

       }


       public PRPDActivityDetailsMachine Get(long ActivityDetailsMachineID)
       {

           try
           {
               SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@ActivityDetailsMachineID" , ActivityDetailsMachineID)};


               DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_PRPDActivityMachineByID", paramList);

               PRPDActivityDetailsMachine obj = new PRPDActivityDetailsMachine();

               if (dt.Rows.Count > 0)
               {

                   obj.ActivityDetailsMachineID = Convert.ToInt64(dt.Rows[0]["ActivityDetailsMachineID"]);
                   obj.PRPDBatchActDetailsID = Convert.ToInt64(dt.Rows[0]["BatchActID"]);
                   obj.MachineCode = Convert.ToString(dt.Rows[0]["MachineCode"]);
                   obj.MeshSize = Convert.ToString(dt.Rows[0]["MeshSize"]);
                   obj.StartTime_D = Convert.ToDateTime(dt.Rows[0]["StartTime"]);
                   obj.StopTime_D = Convert.ToDateTime(dt.Rows[0]["StopTime"]);
                   obj.Remarks = Convert.ToString(dt.Rows[0]["Remarks"]);


               }

               return obj;


           }
           catch (Exception ex)
           {

               throw new Exception(ex.Message, ex);
           }
       }




    }
}
