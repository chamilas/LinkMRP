using SESD.MRP.REF;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DL
{
    public class SystemFunction_DL
    {
        SqlConnection Connection = new SqlConnection();


        public SystemFunction_DL(SqlConnection Conn)
        {
            Connection = Conn;
        }


        //public int Add(SystemFunction obj)
        //{
        //    //try
        //    //{


        //    //    SqlParameter[] paramList = new SqlParameter[] {
                
        //    //    new SqlParameter("@StoreID", obj.StoreID),
        //    //    new SqlParameter("@StoreDepID", obj.StoreDepartment.DepID),
        //    //     new SqlParameter("@StoreName", obj.StoreName),
        //    //     new SqlParameter("@StoreDesription", obj.StoreDescription),
        //    //    new SqlParameter("@StoreKeeper", obj.StoreKeeper.EmployeeID)};

        //    //    return Execute.RunSP_RowsEffected(Connection, "SPADD_Store", paramList);

        //    //}
        //    //catch (Exception ex)
        //    //{

        //    //    throw new Exception(ex.Message, ex);
        //    //}

        //}

        public int Update(SystemFunction obj)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@SystemFunction", obj.FunctionName),
                new SqlParameter("@Original_FuncID", obj.FunctionID)};

                return Execute.RunSP_RowsEffected(Connection, "SPUPDATE_SystemFunction", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public int Delete(long SystemFunctionID)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@Original_FuncID", SystemFunctionID)};

                return Execute.RunSP_RowsEffected(Connection, "SPDELETE_SystemFunction", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public SystemFunctionCollec Get()
        {
            return null;
        }

        public SystemFunction Get(long SystemFunctionID)
        {
            SystemFunction objSystemFunction = new SystemFunction();


            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@FunctionID", SystemFunctionID)};

                DataTable dt= Execute.RunSP_DataTable(Connection, "SPGET_SystemFunctionByID", paramList);


                objSystemFunction.FunctionID = Convert.ToInt64(dt.Rows[0]["FunctionID"]);
                objSystemFunction.FunctionName = Convert.ToString(dt.Rows[0]["SystemFunction"]);

                return objSystemFunction;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }

            
            
         
                   





        }
    }
}
