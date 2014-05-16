using SESD.MRP.REF;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DL
{
    public class EmployeeRole_DL
    {
        SqlConnection Connection = new SqlConnection();


        public EmployeeRole_DL(SqlConnection Conn)
        {
            Connection = Conn;
        }
        public int Add(EmployeeRole objEmployeeRole)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@EmpRoleTitle", objEmployeeRole.RoleTitle),
                new SqlParameter("@Type", objEmployeeRole.Type)};

                return Execute.RunSP_RowsEffected(Connection, "SPADD_EmployeeRole", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public int Update(EmployeeRole objEmployeeRole)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@EmpRoleTitle", objEmployeeRole.RoleTitle),
                new SqlParameter("@Type", objEmployeeRole.Type),
                new SqlParameter("@Original_EMPRoleID", objEmployeeRole.EmpRoleID)};

                return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_EmployeeRole", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public int Delete(long EmployeeRoleID)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@Original_EMPRoleID", EmployeeRoleID)};

                return Execute.RunSP_RowsEffected(Connection, "SPDELETE_EmployeeRole", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public EmployeeRoleCollec Get()
        {
            return null;
        }

        public EmployeeRole Get(long EmployeeRoleID)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {

                new SqlParameter("@EmpRoleID", EmployeeRoleID)};

                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_EmployeeRoleByID", paramList);

                EmployeeRole obj = new EmployeeRole();


                obj.EmpRoleID = Convert.ToInt64(dt.Rows[0]["EMPRoleID"]);
                obj.RoleTitle = Convert.ToString(dt.Rows[0]["EmpRoleTitle"]);
                obj.Type = Convert.ToString(dt.Rows[0]["Type"]);


                return obj;


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


                return Execute.RunSP_DataTable(Connection, "SPGET_EmployeeRole_Dataview");

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        
        }
    }
}
