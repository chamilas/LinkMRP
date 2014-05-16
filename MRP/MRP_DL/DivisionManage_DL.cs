using System;
using System.Collections.Generic;
using System.Text;
using DL;
using SESD.MRP.REF;
using System.Data.SqlClient;
using System.Data;

namespace DL
{
    public class DivisionManage_DL
    {
        private SqlConnection Connection;


        public DivisionManage_DL(SqlConnection Conn)
        {
            Connection = Conn;
        }


        public int Add(DivisionManage obj, DivisionManage OriginalObj)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@DivisionID", obj.DivisionID),
                new SqlParameter("@ManagerID", obj.ManagerID),
                new SqlParameter("@Original_DivisionID", OriginalObj.DivisionID),
                new SqlParameter("@Original_ManagerID", OriginalObj.ManagerID)};


                return Execute.RunSP_RowsEffected(Connection, "SPADD_DivisionManage_Update", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public int Delete(DivisionManage obj)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@Original_DivisionID", obj.DivisionID),
                new SqlParameter("@Original_ManagerID", obj.ManagerID)};


                return Execute.RunSP_RowsEffected(Connection, "SPDELETE_DivisionManage", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }


        public DataTable Get(long DivisionID)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@DivisionID",DivisionID)};

                return Execute.RunSP_DataTable(Connection, "SPGET_DivisionManagers_By_DivisionID", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }
    }
}
