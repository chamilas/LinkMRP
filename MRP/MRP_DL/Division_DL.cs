using System;
using System.Collections.Generic;
using System.Text;
using SESD.MRP.REF;
using System.Data;
using System.Data.SqlClient;


namespace DL
{
   public class Division_DL
    {

        SqlConnection Connection = new SqlConnection();
        Employee_DL objEmployee_DL = new Employee_DL(ConnectionStringClass.GetConnection());


        public Division_DL(SqlConnection Conn)
        {
            Connection = Conn;
        }

        public long Add(Divisions objDivisions)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@DivisionID", objDivisions.DivisionID),
                new SqlParameter("@DivisionName", objDivisions.DivisionName),
                new SqlParameter("@DivisionType", objDivisions.DivisionType)};


                return Execute.RunSP_RowsEffected(Connection, "SPADD_Division_Update", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public int Update(Divisions objDivisions, long Original_DivisionID)
        {
            


             try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@DivisionID", objDivisions.DivisionID),
                new SqlParameter("@DivisionName", objDivisions.DivisionName),
                new SqlParameter("@DivisionType", objDivisions.DivisionType),
                new SqlParameter("@Original_DivisionID", Original_DivisionID)};


                return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_Division", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public int Delete(long DivisionID)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@DivisionID", DivisionID)};


                return Execute.RunSP_RowsEffected(Connection, "SPDELETE_Division", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public DivisionsCollec Get()
        {


            try
            {

               DataTable dt=  Execute.RunSP_DataTable(Connection, "SPGET_Division");

               DivisionsCollec objDepCollec = new DivisionsCollec();


               for (int i = 0; i < dt.Rows.Count;i++ )
               {

                   Divisions objDivisions = new Divisions();
                   objDivisions.DivisionID = Convert.ToInt64(dt.Rows[i]["DivisionID"]);
                   objDivisions.DivisionName = Convert.ToString(dt.Rows[i]["DivisionName"]);
                   objDivisions.DivisionType = Convert.ToString(dt.Rows[i]["DivisionType"]);

                   objDepCollec.Add(objDivisions);
               }
               return objDepCollec;


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }



           

            
        }

        public Divisions Get(string DivisionType)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@DivisionType", DivisionType)};


                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_Division_By_Type", paramList);

                Divisions objDivisions = new Divisions();

                objDivisions.DivisionID = Convert.ToInt64(dt.Rows[0]["DivisionID"]);
                objDivisions.DivisionName = Convert.ToString(dt.Rows[0]["DivisionName"]);
                objDivisions.DivisionType = Convert.ToString(dt.Rows[0]["DivisionType"]);

                return objDivisions;


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }


        }

        public Divisions Get(long DivisionID)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@DivisionID", DivisionID)};


                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_Division_By_ID",paramList);

                Divisions objDivisions = new Divisions();

                    objDivisions.DivisionID = Convert.ToInt64(dt.Rows[0]["DivisionID"]);
                    objDivisions.DivisionName = Convert.ToString(dt.Rows[0]["DivisionName"]);
                    objDivisions.DivisionType = Convert.ToString(dt.Rows[0]["DivisionType"]);

                    return objDivisions;


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }


        }

        public System.Data.DataTable GetDataView()
       {
           try
           {


               return Execute.RunSP_DataTable(Connection, "SPGET_Division");

           }
           catch (Exception ex)
           {

               throw new Exception(ex.Message, ex);
           }
       }

    }
}
