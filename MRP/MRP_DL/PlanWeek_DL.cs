using SESD.MRP.REF;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;

namespace DL
{
    public class PlanWeek_DL
    {
        SqlConnection Connection = new SqlConnection();


        public PlanWeek_DL(SqlConnection Conn)
        {
            Connection = Conn;
        }
   
    
        //---------------------ADD REGION------------------------------
        public int Add(PlanWeeks objPlanWeeks)
        {

            try
            {
                SqlParameter[] paramList = new SqlParameter[] {

                new SqlParameter("@Year",objPlanWeeks.Year),
                new SqlParameter("@Month",objPlanWeeks.Month),
                new SqlParameter("@WeekID", objPlanWeeks.WeekID),
                new SqlParameter("@FromDate",objPlanWeeks.FromDate),
                new SqlParameter("@ToDate",objPlanWeeks.ToDate),
                new SqlParameter("@State", objPlanWeeks.State)};


                return Execute.RunSP_RowsEffected(Connection, "SPADD_PlanWeeks", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }


        public int Update_Fix(int Year,string Month,int WeekID,int RevisionID,int Status)
        {

            try
            {
                SqlParameter[] paramList = new SqlParameter[] {

                new SqlParameter("@Year",Year),
                new SqlParameter("@Month",Month),
                new SqlParameter("@WeekID", WeekID),
                new SqlParameter("@RevisionID",RevisionID),
                new SqlParameter("@State", Status)};


                return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_PlanWeeks_Fix", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }



        public PlanWeeks GetByID(int Year, string Month, int WeekID)
        {
            try
            {
                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@Year",Year),
                new SqlParameter("@Month",Month),
                new SqlParameter("@WeekID",WeekID)};


                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_PlanWeeks", paramList);

                PlanWeeks obj = new PlanWeeks();

                if (dt.Rows.Count > 0)
                {
                    obj.State = Convert.ToInt32(dt.Rows[0]["State"]);
                    obj.FromDate = Convert.ToDateTime(dt.Rows[0]["FromDate"]);
                    obj.ToDate = Convert.ToDateTime(dt.Rows[0]["ToDate"]);
                    obj.WeekID = Convert.ToInt32(dt.Rows[0]["WeekID"]);
                    obj.Month = Convert.ToString(dt.Rows[0]["Month"]);
                    obj.Year = Convert.ToInt32(dt.Rows[0]["Year"]);
                }

                return obj;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public DataTable GetDataByMonth(int Year, string Month)
        {
            try
            {
                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@Year",Year),
                new SqlParameter("@Month",Month)
                };


                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_PlanWeeks_ByMonth", paramList);

                return dt;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public DataTable GetDataByMonth_Fixed(int Year, string Month)
        {
            try
            {
                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@Year",Year),
                new SqlParameter("@Month",Month)
                };


                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_PlanWeeks_ByMonth_Fixed", paramList);

                return dt;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }




        public PlanWeeksCollec GetByMonth(int Year, string Month)
        {
            try
            {
                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@Year",Year),
                new SqlParameter("@Month",Month)
                };


                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_PlanWeeks_ByMonth", paramList);

                PlanWeeksCollec objCollec = new PlanWeeksCollec();

                if (dt.Rows.Count > 0)
                {
                    PlanWeeks obj = new PlanWeeks();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        obj.State = Convert.ToInt32(dt.Rows[i]["State"]);
                        obj.FromDate = Convert.ToDateTime(dt.Rows[i]["FromDate"]);
                        obj.ToDate = Convert.ToDateTime(dt.Rows[i]["ToDate"]);
                        obj.WeekID = Convert.ToInt32(dt.Rows[i]["WeekID"]);
                        obj.Month = Convert.ToString(dt.Rows[i]["Month"]);
                        obj.Year = Convert.ToInt32(dt.Rows[i]["Year"]);
                    }

                    objCollec.Add(obj);
                }

                return objCollec;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }


        public int SetPlanYear2(int year, string month)
        {
            int month1;
            int year2;

            month1 = DateTime.ParseExact(month, "MMMM", CultureInfo.CurrentCulture).Month;

            if (month1 == 12)
            {
                year2 = year + 1;
            }
            else
            {
                year2 = year;
            }

            return year2;
        }

        public int SetPlanYear3(int year, string month)
        {
            int month1;
            int year3;

            month1 = DateTime.ParseExact(month, "MMMM", CultureInfo.CurrentCulture).Month;

            if ((month1 == 12) | (month1 == 11))
            {
                year3 = year + 1;
            }
            else
            {
                year3 = year;
            }

            return year3;

        }

        public string SetPlanMonth2(string month)
        {
            int month1, month2;
            string strmonth2;

            month1 = DateTime.ParseExact(month, "MMMM", CultureInfo.CurrentCulture).Month;

            if (month1 == 12)
            {
                month2 = 1;
            }
            else
            {
                month2 = month1 + 1;
            }


            strmonth2 = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(month2);
 

            return strmonth2;
        }

        public string SetPlanMonth3(string month)
        {
            int month1, month3;
            string strmonth3;

            month1 = DateTime.ParseExact(month, "MMMM", CultureInfo.CurrentCulture).Month;

            if (month1 == 12)
            {
                month3 = 2;
            }
            else if (month1 == 11)
            {
                month3 = 1;
            }
            else
            {
                month3 = month1 + 2;
            }


            strmonth3 = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(month3);

            return strmonth3;
        }

    }
}
