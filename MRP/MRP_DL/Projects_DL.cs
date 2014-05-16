using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DL
{
    public class Projects_DL
    {
        SqlConnection Connection = new SqlConnection();
        private SqlConnection sqlConnection;

        public Projects_DL(SqlConnection Conn)
        {
            Connection = Conn;
        }

        public long Add(String ProjectName,String DepID,String ProjectType)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@ProjectName", ProjectName),
                new SqlParameter("@DepID", DepID),
                new SqlParameter("@ProjectType", ProjectType),
                new SqlParameter("@outParam",SqlDbType.Int,120){Direction=ParameterDirection.Output}
        };

                return Execute.RunSP_RowsEffected(Connection, "SPADD_Project", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public DataTable GetProjects()
        {
            try
            {
                return Execute.RunSP_DataTable(Connection, "SPGET_Projects");
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

    }
}
