using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace DL
{
   public class Execute
    {

       public static DataTable RunSP_DataTable(SqlConnection conn, string SPName, SqlParameter[] myParams)
       {
           SqlDataReader rdr = null;


           try
           {
               conn.Open();

               SqlCommand cmd = new SqlCommand(SPName, conn);

               cmd.CommandType = CommandType.StoredProcedure;

               cmd.Parameters.AddRange(myParams);

               rdr = cmd.ExecuteReader();

               DataTable dt = new DataTable();

               dt.Load(rdr);

               return dt;
           }

           finally
           {
               if (conn != null)
               {
                   conn.Close();
               }
               if (rdr != null)
               {
                   rdr.Close();
               }
           }


       }

       public static int RunSP_BulkUpdate(SqlConnection conn, string SPName, DataTable _dt,string ParamName)
       {
           SqlDataReader rdr = null;
           DataTable dt = new DataTable();

           _dt = dt;


           try
           {
               conn.Open();

               SqlCommand cmd = new SqlCommand(SPName, conn);

               cmd.CommandType = CommandType.StoredProcedure;

               cmd.Parameters.AddWithValue("@"+ParamName, dt);

               int x = cmd.ExecuteNonQuery();

               return x;
           }

           finally
           {
               if (conn != null)
               {
                   conn.Close();
               }
               if (rdr != null)
               {
                   rdr.Close();
               }
           }


       }


       public static DataTable RunSP_DataTable(SqlConnection conn, string SPName)
       {
           SqlDataReader rdr = null;


           try
           {
               conn.Open();

               SqlCommand cmd = new SqlCommand(SPName, conn);

               cmd.CommandType = CommandType.StoredProcedure;

               rdr = cmd.ExecuteReader();

               DataTable dt = new DataTable();

               dt.Load(rdr);

               return dt;
           }

           finally
           {
               if (conn != null)
               {
                   conn.Close();
               }
               if (rdr != null)
               {
                   rdr.Close();
               }
           }


       }


        public static int RunSP_RowsEffected(SqlConnection conn, string SPName, SqlParameter[] myParams)
       {
           SqlDataReader rdr = null;


           try
           {
               conn.Open();

               SqlCommand cmd = new SqlCommand(SPName, conn);

               cmd.CommandType = CommandType.StoredProcedure;

               cmd.Parameters.AddRange(myParams);

               rdr = cmd.ExecuteReader();

               return rdr.RecordsAffected;
           }

           finally
           {
               if (conn != null)
               {
                   conn.Close();
               }
               if (rdr != null)
               {
                   rdr.Close();
               }
           }


       }



        



        public static string RunSP_String(SqlConnection conn, string SPName, SqlParameter[] myParams)
        {
            SqlDataReader rdr = null;


            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(SPName, conn);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddRange(myParams);

               return (cmd.ExecuteScalar()).ToString();


            }

            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
                if (rdr != null)
                {
                    rdr.Close();
                }
            }


        }



        public static int RunSP_Int(SqlConnection conn, string SPName, SqlParameter[] myParams)
        {
            SqlDataReader rdr = null;


            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(SPName, conn);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddRange(myParams);

                return Convert.ToInt32(cmd.ExecuteScalar());


            }

            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
                if (rdr != null)
                {
                    rdr.Close();
                }
            }


        }

        public static long RunSP_Long(SqlConnection conn, string SPName, SqlParameter[] myParams)
        {
            SqlDataReader rdr = null;


            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(SPName, conn);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddRange(myParams);

                return Convert.ToInt64(cmd.ExecuteScalar());


            }

            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
                if (rdr != null)
                {
                    rdr.Close();
                }
            }


        }



        public static decimal RunSP_Decimal(SqlConnection conn, string SPName, SqlParameter[] myParams)
        {
            SqlDataReader rdr = null;


            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(SPName, conn);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddRange(myParams);

                return Convert.ToDecimal(cmd.ExecuteScalar());


            }

            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
                if (rdr != null)
                {
                    rdr.Close();
                }
            }


        }

        public static int RunSP_Output(SqlConnection conn, string SPName, SqlParameter[] myParams)
        {
            SqlDataReader rdr = null;


            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(SPName, conn);


                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddRange(myParams);

                cmd.ExecuteNonQuery();
                Console.Out.WriteLine(">>>"+cmd.Parameters["@outParam"].Value);
                //return Convert.ToInt32(cmd.Parameters["@outParam"].Value);

                if (cmd.Parameters["@outParam"].Value is DBNull)
                {
                    return 0;
                }
                else
                {
                    return Convert.ToInt32(cmd.Parameters["@outParam"].Value);
                }
                
                

            }

            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
                if (rdr != null)
                {
                    rdr.Close();
                }
            }


        }


        public static decimal RunSP_Output_Decimal(SqlConnection conn, string SPName, SqlParameter[] myParams)
        {
            SqlDataReader rdr = null;


            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(SPName, conn);


                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddRange(myParams);

                cmd.ExecuteNonQuery();

                return Convert.ToDecimal(cmd.Parameters["@outParam"].Value);


            }

            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
                if (rdr != null)
                {
                    rdr.Close();
                }
            }


        }

        public static decimal RunSP_Q_Output_Decimal(SqlConnection conn, string SPName, SqlParameter[] myParams)
        {
            SqlDataReader rdr = null;
            decimal x=0;

            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(SPName, conn);


                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddRange(myParams);

                DataTable dt= new DataTable();
                dt.Load(cmd.ExecuteReader());

                if (dt.Rows.Count > 0)
                {
                   x  = Convert.ToDecimal(dt.Rows[0][0]);

                }
                else
                {
                    x = 0;
                }
                  return x;


            }

            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
                if (rdr != null)
                {
                    rdr.Close();
                }
            }


        }


        public static string RunSP_Output_String(SqlConnection conn, string SPName, SqlParameter[] myParams)
        {
            SqlDataReader rdr = null;


            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(SPName, conn);


                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddRange(myParams);

                cmd.ExecuteNonQuery();

                return Convert.ToString(cmd.Parameters["@outParam"].Value);


            }

            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
                if (rdr != null)
                {
                    rdr.Close();
                }
            }


        }




   }
}

