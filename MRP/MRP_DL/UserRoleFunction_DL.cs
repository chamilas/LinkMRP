using SESD.MRP.REF;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace DL
{
    public class UserRoleFunction_DL
    {
        SqlConnection Connection = new SqlConnection();


        public UserRoleFunction_DL(SqlConnection Conn)
        {
            Connection = Conn;
        }
        public int Add(UserRoleFunction obj)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@UserRoleID", obj.UserRole),
                new SqlParameter("@FuncID", obj.SystemFunction)};

                return Execute.RunSP_RowsEffected(Connection, "SPADD_UserRoleFunction", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public int Update(UserRoleFunction obj,UserRoleFunction OriginalUserRoleFunction)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@UserRoleID", obj.UserRole),
                new SqlParameter("@FuncID", obj.SystemFunction),
                new SqlParameter("@Original_UserRoleID", obj.UserRole),
                new SqlParameter("@Original_FuncID", obj.UserRole)};

                return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_UserRoleFunction", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public int Delete(long UserRolesID, long FunctionID)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@Original_UserRoleID",UserRolesID),
                new SqlParameter("@Original_FuncID", FunctionID)};

                return Execute.RunSP_RowsEffected(Connection, "SPDELETE_UserRoleFunction", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public UserRoleFunctionCollec Get()
        {
            return null;
        }

        public UserRoleFunction Get(long UserRolesID,long FunctionID)
        {
            UserRoleFunction objUserRoleFunction = new UserRoleFunction();

            UserRole_DL objUserRole = new UserRole_DL(Connection);
            SystemFunction_DL objSystemFunction = new SystemFunction_DL(Connection);


            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@Original_UserRoleID", UserRolesID),
                new SqlParameter("@Original_FuncID", FunctionID)};

                DataTable dt= Execute.RunSP_DataTable(Connection, "SPADD_Unit", paramList);


                objUserRoleFunction.SystemFunction = objSystemFunction.Get(Convert.ToInt64(dt.Rows[0]["FuncID"]));
                objUserRoleFunction.UserRole = objUserRole.Get(Convert.ToInt64(dt.Rows[0]["UserRoleID"]));


                return objUserRoleFunction;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }

        }
    }
}
