using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using SESD.MRP.REF;



namespace DL
{
   public class PRPDActivityDetailsLabour_DL

           {
        SqlConnection Connection = new SqlConnection();


        public PRPDActivityDetailsLabour_DL(SqlConnection Conn)
        {
            Connection = Conn;
        }


        Employee_DL objEmployee_DL = new Employee_DL(ConnectionStringClass.GetConnection());


        public int Add(PRPDActivityDetailsLabour obj)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@BatchActID" , obj.PRPDBatchActivityDetails),
                new SqlParameter("@Helper" , obj.Helper.EmployeeID),
                new SqlParameter("@StartTime",obj.StartTime),
                new SqlParameter("@StopTime",obj.StopTime),
                new SqlParameter("@OTHours",obj.OTHours),
                new SqlParameter("@Remarks", obj.Remarks)};

                return Execute.RunSP_Int(Connection, "SPADD_PRPDActivityDetailsLabour", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }



        }


       public int Update(PRPDActivityDetailsLabour obj, long Original_ActivityDetailsLabourID)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@BatchActID", obj.PRPDBatchActivityDetails),
                new SqlParameter("@Helper" , obj.Helper.EmployeeID),
                new SqlParameter("@StartTime" , obj.StartTime),
                new SqlParameter("@StopTime", obj.StopTime),
                new SqlParameter("@OTHours", obj.OTHours),
                new SqlParameter("@Remarks" , obj.Remarks),
                new SqlParameter("@Original_ActivityDetailsLabourID" , obj.ActivityDetailsLabourID)};

                return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_PRPDActivityDetailsLabour", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }


       public int Delete(long ActivityDetailsLabourID)
       {

           try
           {
               SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@Original_ActivityDetailsLabourID" , ActivityDetailsLabourID)};

               return Execute.RunSP_RowsEffected(Connection, "SPDELETE_PRPDActivityDetailsLabour", paramList);
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


       public System.Data.DataTable GetDataByID(long ActivityDetailsLabourID)
        {
            try
            {
                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@ActivityDetailsLabourID" ,ActivityDetailsLabourID)};


                return Execute.RunSP_DataTable(Connection, "SPGET_PRPDActivityDetailsLabourByID", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }


       public System.Data.DataTable GetDataView(long ActivityDetailsID)
       {
           try
           {


               SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@ActivityDetailsLabourID" , ActivityDetailsID )};

               return Execute.RunSP_DataTable(Connection, "SPGET_PRPDActivityDetailsLabour_By_DetailID", paramList);

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

               return Execute.RunSP_RowsEffected(Connection, "SPGET_PRPDActivityDetailsLabour_Count_NotFinished", paramList);

           }
           catch (Exception ex)
           {

               throw new Exception(ex.Message, ex);
           }
       }


       public PRPDActivityDetailsLabour Get(long ActivityDetailsLabourID)
       {

           try
           {

               SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@ActivityDetailsLabourID" , ActivityDetailsLabourID )};

               DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_PRPDActivityDetailsLabourByID", paramList);

               PRPDActivityDetailsLabour obj = new PRPDActivityDetailsLabour();

               if (dt.Rows.Count > 0)
               {
                    obj.ActivityDetailsLabourID = Convert.ToInt64(dt.Rows[0]["ActivityDetailsLabourID"]);
                    obj.PRPDBatchActivityDetails = Convert.ToInt64(dt.Rows[0]["BatchActID"]);
                    obj.Helper = objEmployee_DL.Get(Convert.ToString(dt.Rows[0]["Helper"]));
                    obj.StartTime_D = Convert.ToDateTime(dt.Rows[0]["StartTime"]);
                    obj.StopTime_D = Convert.ToDateTime(dt.Rows[0]["StopTime"]);
                    obj.OTHours = Convert.ToDecimal(dt.Rows[0]["OTHours"]);
                    obj.Remarks = Convert.ToString(dt.Rows[0]["Remarks"]);
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


       public PRPDActivityDetailsLabour GetByDetailID(long DetailID)
       {

           try
           {

               SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@BatchActID" , DetailID )};

               DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_PRPDActivityDetailsLabourByDetailID", paramList);

               PRPDActivityDetailsLabour obj = new PRPDActivityDetailsLabour();

               if (dt.Rows.Count > 0)
               {
                   obj.ActivityDetailsLabourID = Convert.ToInt64(dt.Rows[0]["ActivityDetailsLabourID"]);
                   obj.PRPDBatchActivityDetails = Convert.ToInt64(dt.Rows[0]["BatchActID"]);
                   obj.Helper = objEmployee_DL.Get(Convert.ToString(dt.Rows[0]["Helper"]));
                   obj.StartTime_D = Convert.ToDateTime(dt.Rows[0]["StartTime"]);
                   obj.StopTime_D = Convert.ToDateTime(dt.Rows[0]["StopTime"]);
                   obj.OTHours = Convert.ToDecimal(dt.Rows[0]["OTHours"]);
                   obj.Remarks = Convert.ToString(dt.Rows[0]["Remarks"]);
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



    }
}
