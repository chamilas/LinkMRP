using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using SESD.MRP.REF;


namespace DL
{
  public  class PlanMaterials_DL
    {

       SqlConnection Connection = new SqlConnection();

       public PlanMaterials_DL(SqlConnection Conn)
        {
            Connection = Conn;
        }

       public int Add(int Year,string Month,string PlanType,int Status)
       {

           try
           {
               SqlParameter[] paramList = new SqlParameter[] {
                   new SqlParameter("@Year", Year),
                   new SqlParameter("@Month", Month),
                new SqlParameter("@Type",PlanType),
                new SqlParameter("@Status",Status)
               };


               return Execute.RunSP_RowsEffected(Connection, "SPADD_PlanMaterial", paramList);

           }
           catch (Exception ex)
           {

               throw new Exception(ex.Message, ex);
           }
       }

       public int Add_PRPD(int Year, string Month, string PlanType, int Status)
       {

           try
           {
               SqlParameter[] paramList = new SqlParameter[] {
                   new SqlParameter("@Year", Year),
                   new SqlParameter("@Month", Month),
                new SqlParameter("@Type",PlanType),
                new SqlParameter("@Status",Status)
               };


               return Execute.RunSP_RowsEffected(Connection, "SPADD_PlanMaterial_PRPD", paramList);

           }
           catch (Exception ex)
           {

               throw new Exception(ex.Message, ex);
           }
       }

       public int Add_Stores(int Year, string Month, string PlanType, int Status)
       {

           try
           {
               SqlParameter[] paramList = new SqlParameter[] {
                   new SqlParameter("@Year", Year),
                   new SqlParameter("@Month", Month),
                new SqlParameter("@Type",PlanType),
                new SqlParameter("@Status",Status)
               };


               return Execute.RunSP_RowsEffected(Connection, "SPADD_PlanMaterial_Store", paramList);

           }
           catch (Exception ex)
           {

               throw new Exception(ex.Message, ex);
           }
       }


      
        public int Update_Fix(int Year,string Month,int WeekID,string PlanType,int Status)
       {

           try
           {
               SqlParameter[] paramList = new SqlParameter[] {
                   new SqlParameter("@Year", Year),
                   new SqlParameter("@Month", Month),
                new SqlParameter("@WeekID", WeekID),
                new SqlParameter("@Type",PlanType),
                new SqlParameter("@Status",Status)
               };


               return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_PlanMaterial_Fix", paramList);

           }
           catch (Exception ex)
           {

               throw new Exception(ex.Message, ex);
           }
       }

        public DataTable GetRequirement(String PlanType, int Year, string Month)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                new SqlParameter("@Type",PlanType),
                new SqlParameter("@Year",Year),
                new SqlParameter("@Month",Month)
                };

                return Execute.RunSP_DataTable(Connection, "SPGET_PlanMaterial", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public DataTable GetRequirement_Full(String PlanType, int Year1, string Month1, int Year2, string Month2, int Year3, string Month3)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                new SqlParameter("@Type",PlanType),
                new SqlParameter("@Year1",Year1),
                new SqlParameter("@Month1",Month1),
                new SqlParameter("@Year2",Year2),
                new SqlParameter("@Month2",Month2),
                new SqlParameter("@Year3",Year3),
                new SqlParameter("@Month3",Month3)
                };

                return Execute.RunSP_DataTable(Connection, "SPGET_PlanMaterial_Full", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public int GetPlan_Availability(String PlanType, int Year1, string Month1, int Year2, string Month2, int Year3, string Month3)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                new SqlParameter("@Type",PlanType),
                new SqlParameter("@Year1",Year1),
                new SqlParameter("@Month1",Month1),
                   new SqlParameter("@Year2",Year2),
                new SqlParameter("@Month2",Month2),
                   new SqlParameter("@Year3",Year3),
                new SqlParameter("@Month3",Month3),
                new SqlParameter("@outParam",SqlDbType.Int){Direction=ParameterDirection.Output}
                };

                return Execute.RunSP_Output(Connection, "SPGET_PlanMaterial_Availability", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public DataTable GetPackingMaterialsForecast(int Year,string Month3)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                new SqlParameter("@prmYear",Year),
                new SqlParameter("@prmMonth",Month3)
                };

                return Execute.RunSP_DataTable(Connection, "SPGET_PackingMaterialsForecast", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

    }
}
