using SESD.MRP.REF;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DL
{
    public class UserDepartments_DL
    {
        SqlConnection Connection = new SqlConnection();
        public UserDepartments_DL(SqlConnection Conn)
        {
            Connection = Conn;
        }
        public int Add(User obj)
        {
            return 0;
        }

        public int Update(User obj)
        {
            return 0;
        }

      

        public int Delete(long UserID)
        {
            return 0;
        }

    



        public DataTable Get(long UserID)
        {
            
            

            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                new SqlParameter("@UserID", UserID)};


                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_UserDepartments", paramList);

                return dt;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }


        }


        public DataTable Get_Default(long UserID)
        {
            
            

            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                new SqlParameter("@UserID", UserID)};


                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_UserDepartments_Default", paramList);

                return dt;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }


        }

        
    }
}
