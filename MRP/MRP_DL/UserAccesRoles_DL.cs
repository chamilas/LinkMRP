using SESD.MRP.REF;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace DL
{
    public class UserAccesRoles_DL
    {
        SqlConnection Connection = new SqlConnection();
        public UserAccesRoles_DL(SqlConnection Conn)
        {
            Connection = Conn;
        }
        public int Add(UserAccesRoles obj)
        {
            return 0;
        }

        public int Update(UserAccesRoles obj)
        {
            return 0;
        }

        public int Delete(long UserRole, long UserRoleID)
        {
            return 0;
        }

        public UserAccesRolesCollec Get()
        {
            return null;
        }

        public UserAccesRoles Get(long UserRole,long UserRoleID)
        {
            return null;
        }
    }
}
