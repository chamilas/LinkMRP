using System;
using System.Collections.Generic;
using System.Text;
using SESD.MRP.REF;
using System.Data;
using System.Data.SqlClient;

namespace DL
{
    public class UserAccessRights_DL
    {
        SqlConnection Connection = new SqlConnection();


        public UserAccessRights_DL(SqlConnection Conn)
        {
            Connection = Conn;
        }

        public int Add(UserAccessRights obj)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@Menu_Item", obj.MenuName),
                new SqlParameter("@Menu_ID", obj.MenuID),
                new SqlParameter("@UserRoleID", obj.UserRoleID),
                new SqlParameter("@Access_Permission", obj.Permission)};

                return Execute.RunSP_RowsEffected(Connection, "SPADD_UserAccessRights", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public int Update(UserAccessRights obj)
        {
            return 0;
        }

        public UserAccessRights Get(String MenuID, long RoleID)
        {
            UserAccessRights obj = new UserAccessRights();

            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@Menu_ID", MenuID),
                new SqlParameter("@UserRoleID", RoleID)};

                DataTable dt= Execute.RunSP_DataTable(Connection, "SPGET_UserAccessRights_By_ID", paramList);

                if (dt.Rows.Count > 0)
                {
                    obj.MenuID = Convert.ToString(dt.Rows[0]["Menu_ID"]);
                    obj.MenuName = Convert.ToString(dt.Rows[0]["Menu_Item"]);
                    obj.Permission = Convert.ToString(dt.Rows[0]["Access_Permission"]);
                    obj.UserRoleID = Convert.ToInt64(dt.Rows[0]["UserRoleID"]);
                }

                return obj;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }

            
        }

        public UserAccessRightsCollec Get(long RoleID)
        {
            
            UserAccessRightsCollec objCollec = new UserAccessRightsCollec();
            

            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                new SqlParameter("@UserRoleID", RoleID)};

                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_UserAccessRights_By_USERROLE", paramList);

                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        UserAccessRights obj = new UserAccessRights();

                        obj.MenuID = Convert.ToString(dt.Rows[i]["Menu_ID"]);
                        obj.MenuName = Convert.ToString(dt.Rows[i]["Menu_Item"]);
                        obj.Permission = Convert.ToString(dt.Rows[i]["Access_Permission"]);
                        obj.UserRoleID = Convert.ToInt64(dt.Rows[i]["UserRoleID"]);

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

        public DataTable GetDataview(long RoleID)
        {

            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                new SqlParameter("@UserRoleID", RoleID)};

                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_UserAccessRights_By_USERROLE", paramList);

                return dt;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        
        }
    }
}
