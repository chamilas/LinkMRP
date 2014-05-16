using SESD.MRP.REF;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace DL
{
    public class UserRole_DL
    {

        SqlConnection Connection = new SqlConnection();
        public UserRole_DL(SqlConnection Conn)
        {
            Connection = Conn;
        }
        public long Add(UserRole obj)
        {
            
              try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@UserRoleID", obj.UserRoleID),
                new SqlParameter("@UserRole", obj.UserRoleName),
                 new SqlParameter("@Edit", obj.Edit),
                new SqlParameter("@Remove", obj.Remove),
                 new SqlParameter("@outParam",SqlDbType.Int){Direction=ParameterDirection.Output}};

                return Execute.RunSP_Output(Connection, "SPADD_UserRole", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public int Update(UserRole obj)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@UserRole", obj.UserRoleName),
                 new SqlParameter("@Edit", obj.Edit),
                new SqlParameter("@Remove", obj.Remove),
                new SqlParameter("@Original_UserRoleID", obj.UserRoleID)};

                return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_Unit", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public int Delete(long UserAccesRolesID)
        {
            try
            {
                
                SqlParameter[] paramList = new SqlParameter[] {
                new SqlParameter("@Original_UserRoleID", UserAccesRolesID)};

                return Execute.RunSP_RowsEffected(Connection, "SPDELETE_Unit", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public UserRoleCollec Get()
        {
            return null;
        }

        public UserRole Get(long UserAccesRolesID)
        {

            UserRole obj = new UserRole();
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                new SqlParameter("@UserRoleID", UserAccesRolesID)};

                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_UserRoleByID", paramList);

                obj.UserRoleID = Convert.ToInt64(dt.Rows[0]["UserRoleID"]);
                obj.UserRoleName = Convert.ToString(dt.Rows[0]["UserRole"]);
                obj.Edit = Convert.ToBoolean(dt.Rows[0]["UserRoleID"]);
                obj.Remove = Convert.ToBoolean(dt.Rows[0]["UserRoleID"]);


                return obj;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }


        public DataTable GetDataview()
        {

            try
            {


                return Execute.RunSP_DataTable(Connection, "SPGET_UserRole");

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }
    }
}
